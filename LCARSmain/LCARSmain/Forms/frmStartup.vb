Imports System.Runtime.InteropServices
Imports Microsoft.Win32
Imports LCARS.x32

Public Class frmStartup

    'Constants used to make this form act like the Windows desktop (stay in back, don't get activated)
    Const WS_EX_NOACTIVATE As Integer = &H8000000
    Const WS_VISIBLE As Integer = &H10000000

    'Used to register the "LCARS_X32_MSG" window message which allows x32 to talk to it's various windows
    'and applications.
    Declare Auto Function RegisterWindowMessage Lib "user32.dll" (ByVal lpString As String) As UInteger

    'Desktop panels
    Public curDesktop As New List(Of Panel)

    '<System.Diagnostics.DebuggerStepThrough()> _
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        'This method intercepts incomming window messages and looks to see if any need to be read

        'Check if it's the "LCARS_X32_MSG"
        If m.Msg = InterMsgID Then

            'It is! So find out what was sent.

            'Send back a 1 so the program that sent the message knows we received it.
            m.Result = 1

            'LParam is used as a simple way of telling what the sender intended.  For example, x32 sends
            'a "LCARS_X32_MSG" to all registered windows with an LParam of 13 when it is closing, so they
            'can close too.
            If m.LParam = 1 Then
                'They are registering their program with x32 so they can receive resize and close notices.
                'Save their handle so we can send a message to them when 
                'the working area has changed or x32 is closing (if that handle isn't in the list already).
                Dim targetWnd As IntPtr = m.WParam
                LinkedWindows.Add(m.WParam)
                'Send them the window handle for x32 so they can communicate directly, otherwise they have
                'to broadcast the message to all windows.
                PostMessage(targetWnd, InterMsgID, Me.Handle, 2)
            ElseIf m.LParam = 2 Then
                'They are telling this instance to load settings.
                curBusiness(0).mySettingsButton_Click(Nothing, Nothing)
            End If

            'WM_COPYDATA is used when more than just a number needs to be sent to x32.
        ElseIf m.Msg = WM_COPYDATA Then

            'Copy the data from memory (RAM) into a COPYDATASTRUCT structure
            Dim myData As New COPYDATASTRUCT
            myData = System.Runtime.InteropServices.Marshal.PtrToStructure(m.LParam, GetType(COPYDATASTRUCT))

            'Find out what kind of data was sent:
            Select Case myData.dwData
                Case 1
                    'They want to set the wallpaper

                    'Deprecated message; can't handle multiple screens
                    m.Result = 0
                Case 2
                    'Reload x32's colors (presumably, after they have changed them in the registry)

                    'Yeah, yeah, we got the message
                    m.Result = 1

                    RefreshColors()
                Case 3
                    'Set whether buttons should beep or not.

                    'Got it!
                    m.Result = 1

                    'Set the button beeping of the current mainscreen
                    Dim myValue As Boolean = Marshal.PtrToStructure(myData.lpData, GetType(Boolean))
                    SetBeeping(myValue)
                Case 4
                    'Set the wallpaper sizemode of the desktop

                    'Deprecated message; can't handle multiple screens.
                    m.Result = 0
                Case 5
                    'They want to close LCARS x32.

                    'We got the message
                    m.Result = 1

                    'Close LCARS (pretty self explainitory)
                    CloseLCARS()
                Case 6
                    'Start a Red Alert
                    'This is deprecated, but kept for backwards compatibility.
                    m.Result = 1

                    'Dim myAlert As New Threading.Thread(AddressOf redAlert)
                    'myAlert.Start()
                    GeneralAlert(0)
                Case 7
                    m.Result = 1

                    'Cancel current Alerts
                    CancelAlert()
                Case 8
                    m.Result = 1

                    'Turn on/off Voice commands.
                    modSpeech.SpeechEnabled = (myData.lpData <> IntPtr.Zero)
                Case 9
                    'Turn on/off AutoHide

                    'Deprecated message; can't handle multiple screens
                    m.Result = 0
                Case 10
                    'set language of mainscreens

                    'Deprecated message; can't handle multiple screens
                    m.Result = 0
                Case 11
                    m.Result = 1

                    'Set an alert
                    Dim alertID As Int32
                    If Marshal.SizeOf(alertID) = myData.cdData Then
                        alertID = Marshal.PtrToStructure(myData.lpData, GetType(Int32))
                        GeneralAlert(alertID)
                    Else
                        GeneralAlert(0)
                    End If

                Case 12
                    m.Result = 1
                    'Alerts updated
                    frmAlerts.loadAlerts()
            End Select
        ElseIf m.Msg = WM_EXPLORER_CLOSE Then
            CloseLCARS()
        ElseIf m.Msg <= WM_DDE_LAST And m.Msg >= WM_DDE_FIRST Then
            ' Handle Dynamic Data Exchange messages.
            ' This is mostly ensuring that LCARS Explorer opens when another program wants to 
            ' open a folder.
            handleDDE(m)
        Else
            'it wasn't a message we need to handle, so let VB take back over.
            MyBase.WndProc(m)
        End If
    End Sub

    Private Sub frmStartup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '''''''''''''''''''''''''''''''''''''''
        '''' Critical LCARS initialization ''''
        '''''''''''''''''''''''''''''''''''''''
        CheckComponents()
        If Command().Contains("-u") Then
            Try
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\runInstallScript.exe")
                My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.SpecialDirectories.Temp & "\Ionic.Zip.Reduced.dll")
            Catch ex As Exception
            End Try
        End If
        If modSettings.InstallPath = "" Then
            modSettings.InstallPath = Application.StartupPath
        End If
        modSettings.InitializeSettings()
        If Not Command().Contains("-L") Then
            If System.IO.File.Exists(Application.StartupPath & "\LCARSLogin.exe") Then
                Process.Start(Application.StartupPath & "\LCARSLogin.exe")
                End
            End If
        End If
        shellMode = (GetShellWindow() = IntPtr.Zero)
        SetDesktop(Me)

        ''''''''''''''''''''''''''''''
        '''' Shell initialization ''''
        ''''''''''''''''''''''''''''''

        HideMinimizedWindows()

        If shellMode Then
            Debug.Print("Shellmode!")
            'This supposedly does something. Not entirely sure what, so we'll leave it disabled.
            'SendMessage(GetDesktopWindow(), &H400, 0, 0)
            If Not SetShellWindow(Me.Handle) Then
                Debug.Print("Failed to set shell window! Current window: {0}", GetShellWindow())
            End If
            If Not SetShellReadyEvent("msgina: ShellReadyEvent") Then
                SetShellReadyEvent("ShellDesktopSwitchEvent")
            End If
            If LCARS.x32.modSettings.DDEEnabled Then
                initDDE()
            End If
        Else
            'Carefully work around Windows Explorer
            GetTaskbarSettings()
            SaveDesktopIcons()
            MoveTrayIcons()
            ShowTaskBar(False)
            For Each myScreen As Screen In Screen.AllScreens
                StartingWorkingArea.Add(myScreen.WorkingArea)
            Next
        End If

        VirtualDesktops.Init()


        '''''''''''''''''''''''''''''''''''''
        '''' Finish LCARS initialization ''''
        '''''''''''''''''''''''''''''''''''''
        ' LCARS message setup
        SaveSetting("LCARS x32", "Application", "MainWindowHandle", Me.Handle.ToString)
        InterMsgID = RegisterWindowMessage("LCARS_X32_MSG")
        PostMessage(HWND_BROADCAST, InterMsgID, myDesktop.Handle, 0)

        'Make desktop non-selectable and not in the alt-tab menu or taskbar
        Dim currentStyle As Integer = GetWindowLong_Safe(Me.Handle, GWL_EXSTYLE)
        currentStyle = currentStyle Or WS_EX_TOOLWINDOW Or WS_EX_NOACTIVATE
        SetWindowLong_Safe(Me.Handle, GWL_EXSTYLE, currentStyle)
        setBackBounds()

        For i As Integer = 0 To Screen.AllScreens.Length - 1
            CreateDesktop(i)
            loadForm(i)
        Next
        mainTimer.Start()
        AddHandler Microsoft.Win32.SystemEvents.DisplaySettingsChanged, AddressOf System_DisplayChanged

        modSpeech.SpeechEnabled = GetSetting("LCARS X32", "Application", "SpeechOn", "TRUE")

        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        '''' Run auto-start programs (Including updates) ''''
        '''''''''''''''''''''''''''''''''''''''''''''''''''''
        If GetSetting("LCARS X32", "Application", "Updates", "FALSE") Then
            Try
                Process.Start(Application.StartupPath & "\LCARSUpdate.exe", "-s")
            Catch ex As Exception
                MsgBox("Unable to check for updates" & vbNewLine & vbNewLine & ex.ToString())
            End Try
        End If
        Dim startupThread As New Threading.Thread(AddressOf StartupPrograms.StartAll)
        startupThread.Start()
    End Sub

    Private Sub SaveDesktopIcons()
        Dim hwndProgMan As IntPtr = FindWindow("ProgMan", Nothing)
        Dim hwndSHELLDLL_DefView As IntPtr = FindWindowEx(hwndProgMan, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero)
        'Debug.Print("ProgMan handle: " & Hex(hwndSHELLDLL_DefView.ToInt32()))
        If hwndSHELLDLL_DefView = IntPtr.Zero And Not shellMode Then
            'MsgBox("Your desktop has been set to a rotating slideshow." & vbNewLine & "LCARS x32 will not display properly until you disable this.")
            Dim parent As IntPtr = GetParent(hwndProgMan)
            Dim count As Integer = 0
            Do
                hwndProgMan = FindWindowEx(parent, hwndProgMan, "WorkerW", IntPtr.Zero)
                'Debug.Print("WorkerW handle: " & Hex(hwndProgMan.ToInt32()))
                hwndSHELLDLL_DefView = FindWindowEx(hwndProgMan, IntPtr.Zero, "SHELLDLL_DefView", IntPtr.Zero)
                'Debug.Print("ShellDLL DefView handle: " & Hex(hwndSHELLDLL_DefView.ToInt32()))
                count += 1
            Loop While hwndSHELLDLL_DefView = IntPtr.Zero And count < 20
        End If

        SysListViewParent = hwndSHELLDLL_DefView
        SysListView = FindWindowEx(hwndSHELLDLL_DefView, IntPtr.Zero, "SysListView32", IntPtr.Zero)
        SetParent(Me.Handle, hwndProgMan)
        Me.BringToFront()

        myIconSaver.Bounds = Screen.PrimaryScreen.Bounds
        SetParent(SysListView, myIconSaver.Handle)
    End Sub

    Private Sub MoveTrayIcons()
        Dim hTray As IntPtr = FindWindow("Shell_TrayWnd", Nothing)
        Dim hTrayNotify As IntPtr = FindWindowEx(hTray, IntPtr.Zero, "TrayNotifyWnd", IntPtr.Zero)

        hTrayParent = FindWindowEx(hTrayNotify, IntPtr.Zero, "SysPager", IntPtr.Zero)
        hTrayIcons = FindWindowEx(hTrayParent, IntPtr.Zero, "ToolbarWindow32", IntPtr.Zero)

        Dim myStyle As Integer = GetWindowLong_Safe(hTrayIcons, GWL_STYLE)
        myStyle = myStyle And Not TBSTYLE_TRANSPARENT
        SetWindowLong_Safe(hTrayIcons, GWL_STYLE, myStyle)

        SetParent(hTrayIcons, myIconSaver.Handle)
    End Sub


    Private Function SetShellReadyEvent(ByVal eventName As String) As Boolean
        'Thanks to 'Raster' for his post on DreamInCode.net!
        'http://www.dreamincode.net/forums/showtopic98329.htm

        Dim hEvent As IntPtr

        ' open an event
        hEvent = OpenEvent(EventAccessRights.EVENT_MODIFY_STATE, False, eventName)

        ' return if event is null
        If (hEvent = IntPtr.Zero) Then
            Return False
        Else
            ' set the event using the handle
            SetEvent(hEvent)

            ' close the handle
            CloseHandle(hEvent)

            Return True
        End If
    End Function

    Private Sub CheckComponents()
        'Checks that critical files have not been deleted. Only files required for running and shutting down
        'LCARSmain.exe, or that might be run on startup are checked.
        If System.IO.File.Exists(Application.StartupPath & "\LCARS.dll") _
        And System.IO.File.Exists(Application.StartupPath & "\LCARSshutdown.exe") _
        And System.IO.File.Exists(Application.StartupPath & "\LCARSUpdate.exe") _
        Then
            'Do nothing. Nothing is needed.
        Else
            'Use standard message box because there's no telling if LCARS.dll was deleted.
            Microsoft.VisualBasic.MsgBox("Critical files have been deleted. LCARS x32 is either unable to start, or unable to shut down after being started. " _
                                         & "Reinstalling should fix this problem." & vbNewLine & vbNewLine & "Program will exit.", MsgBoxStyle.Critical, "Fatal error")
            End
        End If
    End Sub

    Private Sub HideMinimizedWindows()
        Dim myMetrics As MinimizedMetrics
        myMetrics.cbSize = Marshal.SizeOf(myMetrics)
        Dim myPtr As IntPtr = Marshal.AllocCoTaskMem(myMetrics.cbSize)
        Marshal.StructureToPtr(myMetrics, myPtr, True)
        'Get current information
        SystemParametersInfo(SPI_GETMINIMIZEDMETRICS, 0, myPtr, 0)
        myMetrics.iArrange = MinimizedMetricsArrangement.Hide
        myMetrics.cbSize = Marshal.SizeOf(myMetrics)
        Marshal.StructureToPtr(myMetrics, myPtr, True)
        'Set minimized windows to actually hide
        SystemParametersInfo(SPI_SETMINIMIZEDMETRICS, 0, myPtr, 0)
        Marshal.FreeCoTaskMem(myPtr)
    End Sub

    Public Sub System_DisplayChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        setBackBounds()
        If Screen.AllScreens.Length <> curBusiness.Count Then
            'Update the screens.
            Debug.Print("Number of displays changed!")
            If Screen.AllScreens.Length > curBusiness.Count Then
                'Assume new screen(s) are added at end
                'Add desktop, working area, empty modBusiness, and form
                For i As Integer = curBusiness.Count To Screen.AllScreens.Length - 1
                    CreateDesktop(i)
                    If Not shellMode Then
                        StartingWorkingArea.Add(Screen.AllScreens(i).Bounds)
                    End If
                    loadForm(i)
                Next
            Else
                'Assume removed screen(s) are at end - Might not be accurate, 
                '    but will be correct in most common case
                'Remove desktop, working area, form, and modBusiness
                'Loop runs backwards to avoid indexing changes
                For i As Integer = curBusiness.Count - 1 To Screen.AllScreens.Length Step -1
                    curBusiness(i).ShutdownScreen()
                    curBusiness.RemoveAt(i)
                    Me.Controls.Remove(curDesktop(i))
                    curDesktop.RemoveAt(i)
                    If Not shellMode Then
                        StartingWorkingArea.RemoveAt(i)
                    End If
                Next
            End If
        End If
        For Each b As modBusiness In curBusiness
            b.myForm.Bounds = Screen.AllScreens(b.ScreenIndex).Bounds
            b.UpdateWorkingArea()
        Next
    End Sub

    Private Sub CreateDesktop(ByVal i As Integer)
        Dim myDesktop As New Panel()
        myDesktop.BackColor = Color.Black
        Me.Controls.Add(myDesktop)
        curDesktop.Add(myDesktop)
        'Set wallpaper
        Dim wallpaper As String
        Dim sizeMode As Integer

        sizeMode = modSettings.WallpaperSizeMode(i)
        Select Case sizeMode
            Case 0
                setWallpaperSizeMode(ImageLayout.Zoom, i)
            Case 1
                setWallpaperSizeMode(ImageLayout.Stretch, i)
            Case 2
                setWallpaperSizeMode(ImageLayout.Center, i)
            Case 3
                setWallpaperSizeMode(ImageLayout.Tile, i)
            Case Else
                Exit Sub
        End Select

        wallpaper = modSettings.Wallpaper(i)
        If wallpaper = "FederationLogo" Then
            SetWallpaper(My.Resources.federationLogo, i)
        Else
            If System.IO.File.Exists(wallpaper) Then
                SetWallpaper(Image.FromFile(wallpaper), i)
            Else
                SetWallpaper(My.Resources.federationLogo, i)
                LCARS.UI.MsgBox("Unable to find user-defined wallpaper. Reverting to default.", MsgBoxStyle.OkOnly, "Error:")
            End If
        End If
    End Sub

    Private Sub loadForm(ByVal i As Integer)
        Dim b As New modBusiness(i)
        curBusiness.Add(b)
        Dim myForm As Form
        Try
            Dim screenType As Type = getMainScreenTypes()(modSettings.MainScreen(i) - 1)
            myForm = CType(Activator.CreateInstance(screenType, b), Form)
        Catch ex As Exception
            myForm = New frmMainscreen1(b)
        End Try
        b.init(myForm)
    End Sub

    Private Sub setBackBounds()
        Dim myBounds As Rectangle = SystemInformation.VirtualScreen
        If Not shellMode Then
            myBounds.Location = Point.Empty
        End If
        Me.Bounds = myBounds
    End Sub
End Class