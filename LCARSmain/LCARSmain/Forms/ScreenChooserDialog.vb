Public Class ScreenChooserDialog
    Inherits LCARS.LCARSForm
    Private screenType As Type = Nothing
    Private selectedScreen As LCScreenImage = Nothing
    Private _screenIndex As Integer

    Public Sub New(ByVal screenIndex As Integer)
        InitializeComponent()
        _screenIndex = screenIndex
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not screenType Is Nothing Then
            curBusiness(_screenIndex).ShutdownScreen()
            Dim myForm As Form = CType(Activator.CreateInstance(screenType, curBusiness(_screenIndex)), Form)
            curBusiness(_screenIndex).init(myForm)
        End If
        Me.Close()
    End Sub

    Private Sub sbCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sbCancel.Click
        Me.Close()
    End Sub

    Private Sub ScreenChooserDialog_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For i As Integer = 0 To gridScreens.Count - 1
            Dim myScreenImage As LCScreenImage = CType(gridScreens.Items(i), LCScreenImage)
            If Not myScreenImage.Image Is Nothing Then
                myScreenImage.Image.Dispose()
            End If
        Next
    End Sub

    Private Sub ScreenChooserDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each myScreenType As Type In getMainScreenTypes()
            Dim myScreen As New LCScreenImage()
            myScreen.Text = myScreenType.Name
            myScreen.Data = myScreenType
            AddHandler myScreen.Click, AddressOf myScreen_Click
            Try
                'Get cached files (Will match screen aspect ratio)
                myScreen.Image = System.Drawing.Image.FromFile(System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\LCARS x32\Images\" & myScreenType.Name & "_" & _screenIndex & ".jpg")
            Catch ex As Exception
                'File didn't exist or was in use
                Dim pInfo As Reflection.PropertyInfo = myScreenType.GetProperty("ScreenImage")
                If Not pInfo Is Nothing Then
                    myScreen.Image = pInfo.GetValue(Nothing, Nothing)
                End If
            End Try
            gridScreens.Add(myScreen)
        Next
        LCARS.SetBeeping(Me)
    End Sub

    Private Sub myScreen_Click(ByVal sender As Object, ByVal e As EventArgs)
        If selectedScreen IsNot Nothing Then
            selectedScreen.Selected = False
        End If
        selectedScreen = CType(sender, LCScreenImage)
        selectedScreen.Selected = True
        screenType = CType(selectedScreen.Data, Type)
    End Sub
End Class