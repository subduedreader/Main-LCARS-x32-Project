<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPic
    Inherits LCARS.LCARSForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tmrShow = New System.Windows.Forms.Timer(Me.components)
        Me.picturebox1 = New System.Windows.Forms.PictureBox
        Me.panel1 = New System.Windows.Forms.Panel
        Me.ArrowButton2 = New LCARS.Controls.ArrowButton
        Me.ArrowButton1 = New LCARS.Controls.ArrowButton
        Me.dwn = New LCARS.Controls.FlatButton
        Me.up = New LCARS.Controls.FlatButton
        Me.FlatButton2 = New LCARS.Controls.FlatButton
        Me.FlatButton8 = New LCARS.Controls.FlatButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.rht = New LCARS.Controls.FlatButton
        Me.FlatButton13 = New LCARS.Controls.FlatButton
        Me.lft = New LCARS.Controls.FlatButton
        Me.FlatButton1 = New LCARS.Controls.FlatButton
        Me.abPrev = New LCARS.Controls.ArrowButton
        Me.abNext = New LCARS.Controls.ArrowButton
        Me.lblInfo = New System.Windows.Forms.Label
        Me.fbZoomOut = New LCARS.Controls.FlatButton
        Me.fbZoomIn = New LCARS.Controls.FlatButton
        Me.pbZoom = New LCARS.Controls.PieButton
        Me.fbActual = New LCARS.Controls.FlatButton
        Me.FlatButton6 = New LCARS.Controls.FlatButton
        Me.sbExit = New LCARS.Controls.StandardButton
        Me.tbTitle = New LCARS.Controls.TextButton
        Me.Elbow3 = New LCARS.Controls.Elbow
        Me.fbInfo1 = New LCARS.Controls.FlatButton
        Me.Elbow4 = New LCARS.Controls.Elbow
        Me.Elbow2 = New LCARS.Controls.Elbow
        Me.FlatButton4 = New LCARS.Controls.FlatButton
        Me.fbRes = New LCARS.Controls.FlatButton
        Me.Elbow1 = New LCARS.Controls.Elbow
        Me.StandardButton1 = New LCARS.Controls.StandardButton
        Me.sbBrowse = New LCARS.Controls.StandardButton
        Me.sbShow = New LCARS.Controls.StandardButton
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.tmrup = New System.Windows.Forms.Timer(Me.components)
        Me.tmrdown = New System.Windows.Forms.Timer(Me.components)
        Me.tmrleft = New System.Windows.Forms.Timer(Me.components)
        Me.tmrright = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picturebox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrShow
        '
        Me.tmrShow.Interval = 5000
        '
        'picturebox1
        '
        Me.picturebox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picturebox1.BackColor = System.Drawing.Color.Black
        Me.picturebox1.Location = New System.Drawing.Point(3, 3)
        Me.picturebox1.Name = "picturebox1"
        Me.picturebox1.Size = New System.Drawing.Size(349, 486)
        Me.picturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picturebox1.TabIndex = 0
        Me.picturebox1.TabStop = False
        '
        'panel1
        '
        Me.panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.Controls.Add(Me.ArrowButton2)
        Me.panel1.Controls.Add(Me.ArrowButton1)
        Me.panel1.Controls.Add(Me.dwn)
        Me.panel1.Controls.Add(Me.up)
        Me.panel1.Controls.Add(Me.FlatButton2)
        Me.panel1.Controls.Add(Me.FlatButton8)
        Me.panel1.Location = New System.Drawing.Point(663, 388)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(44, 200)
        Me.panel1.TabIndex = 12
        '
        'ArrowButton2
        '
        Me.ArrowButton2.ArrowDirection = LCARS.LCARSarrowDirection.Down
        Me.ArrowButton2.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.ArrowButton2.Location = New System.Drawing.Point(6, 168)
        Me.ArrowButton2.Name = "ArrowButton2"
        Me.ArrowButton2.Size = New System.Drawing.Size(32, 32)
        Me.ArrowButton2.TabIndex = 71
        '
        'ArrowButton1
        '
        Me.ArrowButton1.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.ArrowButton1.Location = New System.Drawing.Point(6, 0)
        Me.ArrowButton1.Name = "ArrowButton1"
        Me.ArrowButton1.Size = New System.Drawing.Size(32, 32)
        Me.ArrowButton1.TabIndex = 71
        '
        'dwn
        '
        Me.dwn.ButtonText = ""
        Me.dwn.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.dwn.Location = New System.Drawing.Point(6, 137)
        Me.dwn.Name = "dwn"
        Me.dwn.Size = New System.Drawing.Size(32, 25)
        Me.dwn.TabIndex = 14
        '
        'up
        '
        Me.up.ButtonText = ""
        Me.up.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.up.Location = New System.Drawing.Point(6, 38)
        Me.up.Name = "up"
        Me.up.Size = New System.Drawing.Size(32, 25)
        Me.up.TabIndex = 11
        '
        'FlatButton2
        '
        Me.FlatButton2.ButtonText = "NAV"
        Me.FlatButton2.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.FlatButton2.Clickable = False
        Me.FlatButton2.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.FlatButton2.Location = New System.Drawing.Point(0, 84)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Size = New System.Drawing.Size(44, 32)
        Me.FlatButton2.TabIndex = 10
        Me.FlatButton2.Text = "NAV"
        '
        'FlatButton8
        '
        Me.FlatButton8.ButtonText = ""
        Me.FlatButton8.Clickable = False
        Me.FlatButton8.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.FlatButton8.Location = New System.Drawing.Point(6, 69)
        Me.FlatButton8.Name = "FlatButton8"
        Me.FlatButton8.Size = New System.Drawing.Size(32, 61)
        Me.FlatButton8.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.rht)
        Me.Panel2.Controls.Add(Me.FlatButton13)
        Me.Panel2.Controls.Add(Me.lft)
        Me.Panel2.Controls.Add(Me.FlatButton1)
        Me.Panel2.Controls.Add(Me.abPrev)
        Me.Panel2.Controls.Add(Me.abNext)
        Me.Panel2.Location = New System.Drawing.Point(585, 466)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 44)
        Me.Panel2.TabIndex = 13
        '
        'rht
        '
        Me.rht.ButtonText = ""
        Me.rht.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.rht.Location = New System.Drawing.Point(141, 6)
        Me.rht.Name = "rht"
        Me.rht.Size = New System.Drawing.Size(20, 32)
        Me.rht.TabIndex = 78
        '
        'FlatButton13
        '
        Me.FlatButton13.ButtonText = ""
        Me.FlatButton13.Clickable = False
        Me.FlatButton13.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.FlatButton13.Location = New System.Drawing.Point(90, 6)
        Me.FlatButton13.Name = "FlatButton13"
        Me.FlatButton13.Size = New System.Drawing.Size(20, 32)
        Me.FlatButton13.TabIndex = 73
        '
        'lft
        '
        Me.lft.ButtonText = ""
        Me.lft.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.lft.Location = New System.Drawing.Point(38, 6)
        Me.lft.Name = "lft"
        Me.lft.Size = New System.Drawing.Size(20, 32)
        Me.lft.TabIndex = 72
        '
        'FlatButton1
        '
        Me.FlatButton1.ButtonText = ""
        Me.FlatButton1.Clickable = False
        Me.FlatButton1.Color = LCARS.LCARScolorStyles.NavigationFunction
        Me.FlatButton1.Location = New System.Drawing.Point(63, 6)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Size = New System.Drawing.Size(72, 32)
        Me.FlatButton1.TabIndex = 4
        '
        'abPrev
        '
        Me.abPrev.ArrowDirection = LCARS.LCARSarrowDirection.Left
        Me.abPrev.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.abPrev.Location = New System.Drawing.Point(1, 6)
        Me.abPrev.Name = "abPrev"
        Me.abPrev.Size = New System.Drawing.Size(31, 32)
        Me.abPrev.TabIndex = 2
        '
        'abNext
        '
        Me.abNext.ArrowDirection = LCARS.LCARSarrowDirection.Right
        Me.abNext.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.abNext.Location = New System.Drawing.Point(167, 6)
        Me.abNext.Name = "abNext"
        Me.abNext.Size = New System.Drawing.Size(32, 32)
        Me.abNext.TabIndex = 3
        '
        'lblInfo
        '
        Me.lblInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblInfo.Font = New System.Drawing.Font("LCARS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.Color.Orange
        Me.lblInfo.Location = New System.Drawing.Point(553, 61)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(221, 104)
        Me.lblInfo.TabIndex = 64
        '
        'fbZoomOut
        '
        Me.fbZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbZoomOut.ButtonText = "−"
        Me.fbZoomOut.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbZoomOut.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.fbZoomOut.Location = New System.Drawing.Point(557, 306)
        Me.fbZoomOut.Name = "fbZoomOut"
        Me.fbZoomOut.Size = New System.Drawing.Size(40, 40)
        Me.fbZoomOut.TabIndex = 69
        Me.fbZoomOut.Text = "−"
        '
        'fbZoomIn
        '
        Me.fbZoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbZoomIn.ButtonText = "+"
        Me.fbZoomIn.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbZoomIn.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.fbZoomIn.Location = New System.Drawing.Point(648, 306)
        Me.fbZoomIn.Name = "fbZoomIn"
        Me.fbZoomIn.Size = New System.Drawing.Size(40, 40)
        Me.fbZoomIn.TabIndex = 67
        Me.fbZoomIn.Text = "+"
        '
        'pbZoom
        '
        Me.pbZoom.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbZoom.ButtonText = "ZOOM"
        Me.pbZoom.ButtonTextAlign = System.Drawing.ContentAlignment.TopRight
        Me.pbZoom.CircleLocation = New System.Drawing.Point(130, 140)
        Me.pbZoom.CircleRadius = 110
        Me.pbZoom.Clickable = False
        Me.pbZoom.Color = LCARS.LCARScolorStyles.LCARSDisplayOnly
        Me.pbZoom.Location = New System.Drawing.Point(557, 352)
        Me.pbZoom.Name = "pbZoom"
        Me.pbZoom.Size = New System.Drawing.Size(131, 95)
        Me.pbZoom.TabIndex = 66
        Me.pbZoom.Text = "ZOOM"
        '
        'fbActual
        '
        Me.fbActual.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbActual.ButtonText = "FULL"
        Me.fbActual.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.fbActual.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.fbActual.Location = New System.Drawing.Point(603, 306)
        Me.fbActual.Name = "fbActual"
        Me.fbActual.Size = New System.Drawing.Size(40, 40)
        Me.fbActual.TabIndex = 68
        Me.fbActual.Text = "FULL"
        '
        'FlatButton6
        '
        Me.FlatButton6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatButton6.Beeping = True
        Me.FlatButton6.ButtonText = ""
        Me.FlatButton6.Clickable = False
        Me.FlatButton6.Location = New System.Drawing.Point(473, 185)
        Me.FlatButton6.Name = "FlatButton6"
        Me.FlatButton6.Size = New System.Drawing.Size(50, 334)
        Me.FlatButton6.TabIndex = 22
        '
        'sbExit
        '
        Me.sbExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbExit.ButtonStyle = LCARS.Controls.StandardButton.LCARSbuttonStyles.RoundedSquare
        Me.sbExit.ButtonText = "X"
        Me.sbExit.ButtonTextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.sbExit.Color = LCARS.LCARScolorStyles.FunctionOffline
        Me.sbExit.Location = New System.Drawing.Point(760, 6)
        Me.sbExit.Name = "sbExit"
        Me.sbExit.Size = New System.Drawing.Size(33, 32)
        Me.sbExit.TabIndex = 63
        Me.sbExit.Text = "X"
        '
        'tbTitle
        '
        Me.tbTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTitle.ButtonText = "LCARS"
        Me.tbTitle.ButtonTextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.tbTitle.ButtonTextHeight = 32
        Me.tbTitle.Clickable = False
        Me.tbTitle.Location = New System.Drawing.Point(8, 6)
        Me.tbTitle.Name = "tbTitle"
        Me.tbTitle.Size = New System.Drawing.Size(746, 31)
        Me.tbTitle.TabIndex = 62
        Me.tbTitle.Text = "LCARS"
        '
        'Elbow3
        '
        Me.Elbow3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow3.Beeping = True
        Me.Elbow3.ButtonHeight = 10
        Me.Elbow3.ButtonText = ""
        Me.Elbow3.ButtonWidth = 50
        Me.Elbow3.Clickable = False
        Me.Elbow3.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.LowerRight
        Me.Elbow3.Location = New System.Drawing.Point(451, 525)
        Me.Elbow3.Name = "Elbow3"
        Me.Elbow3.Size = New System.Drawing.Size(72, 68)
        Me.Elbow3.TabIndex = 23
        '
        'fbInfo1
        '
        Me.fbInfo1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fbInfo1.Beeping = True
        Me.fbInfo1.ButtonText = ""
        Me.fbInfo1.Clickable = False
        Me.fbInfo1.Location = New System.Drawing.Point(473, 122)
        Me.fbInfo1.Name = "fbInfo1"
        Me.fbInfo1.Size = New System.Drawing.Size(50, 57)
        Me.fbInfo1.TabIndex = 21
        '
        'Elbow4
        '
        Me.Elbow4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Elbow4.Beeping = True
        Me.Elbow4.ButtonHeight = 10
        Me.Elbow4.ButtonText = ""
        Me.Elbow4.ButtonWidth = 50
        Me.Elbow4.Clickable = False
        Me.Elbow4.Location = New System.Drawing.Point(451, 48)
        Me.Elbow4.Name = "Elbow4"
        Me.Elbow4.Size = New System.Drawing.Size(72, 68)
        Me.Elbow4.TabIndex = 20
        '
        'Elbow2
        '
        Me.Elbow2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Elbow2.Beeping = True
        Me.Elbow2.ButtonHeight = 10
        Me.Elbow2.ButtonText = ""
        Me.Elbow2.ButtonWidth = 50
        Me.Elbow2.Clickable = False
        Me.Elbow2.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.LowerLeft
        Me.Elbow2.Location = New System.Drawing.Point(12, 520)
        Me.Elbow2.Name = "Elbow2"
        Me.Elbow2.Size = New System.Drawing.Size(72, 68)
        Me.Elbow2.TabIndex = 19
        '
        'FlatButton4
        '
        Me.FlatButton4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlatButton4.Beeping = True
        Me.FlatButton4.ButtonText = ""
        Me.FlatButton4.Clickable = False
        Me.FlatButton4.Location = New System.Drawing.Point(12, 180)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Size = New System.Drawing.Size(50, 334)
        Me.FlatButton4.TabIndex = 18
        '
        'fbRes
        '
        Me.fbRes.Beeping = True
        Me.fbRes.ButtonText = ""
        Me.fbRes.Clickable = False
        Me.fbRes.Location = New System.Drawing.Point(12, 117)
        Me.fbRes.Name = "fbRes"
        Me.fbRes.Size = New System.Drawing.Size(50, 57)
        Me.fbRes.TabIndex = 17
        '
        'Elbow1
        '
        Me.Elbow1.Beeping = True
        Me.Elbow1.ButtonHeight = 10
        Me.Elbow1.ButtonText = ""
        Me.Elbow1.ButtonWidth = 50
        Me.Elbow1.Clickable = False
        Me.Elbow1.ElbowStyle = LCARS.Controls.Elbow.LCARSelbowStyles.UpperLeft
        Me.Elbow1.Location = New System.Drawing.Point(12, 43)
        Me.Elbow1.Name = "Elbow1"
        Me.Elbow1.Size = New System.Drawing.Size(72, 68)
        Me.Elbow1.TabIndex = 16
        '
        'StandardButton1
        '
        Me.StandardButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StandardButton1.ButtonText = ""
        Me.StandardButton1.Clickable = False
        Me.StandardButton1.Color = LCARS.LCARScolorStyles.StaticTan
        Me.StandardButton1.Location = New System.Drawing.Point(585, 388)
        Me.StandardButton1.Name = "StandardButton1"
        Me.StandardButton1.Size = New System.Drawing.Size(200, 200)
        Me.StandardButton1.TabIndex = 11
        '
        'sbBrowse
        '
        Me.sbBrowse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbBrowse.ButtonText = "BROWSE"
        Me.sbBrowse.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbBrowse.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.sbBrowse.Location = New System.Drawing.Point(624, 185)
        Me.sbBrowse.Name = "sbBrowse"
        Me.sbBrowse.Size = New System.Drawing.Size(130, 35)
        Me.sbBrowse.TabIndex = 10
        Me.sbBrowse.Text = "BROWSE"
        '
        'sbShow
        '
        Me.sbShow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sbShow.ButtonText = "START SLIDE SHOW"
        Me.sbShow.ButtonTextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.sbShow.Color = LCARS.LCARScolorStyles.SystemFunction
        Me.sbShow.Location = New System.Drawing.Point(623, 226)
        Me.sbShow.Name = "sbShow"
        Me.sbShow.Size = New System.Drawing.Size(130, 35)
        Me.sbShow.TabIndex = 9
        Me.sbShow.Text = "START SLIDE SHOW"
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.picturebox1)
        Me.Panel3.Location = New System.Drawing.Point(90, 75)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(355, 492)
        Me.Panel3.TabIndex = 70
        '
        'tmrup
        '
        '
        'tmrdown
        '
        '
        'tmrleft
        '
        '
        'tmrright
        '
        '
        'frmPic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.fbZoomOut)
        Me.Controls.Add(Me.fbZoomIn)
        Me.Controls.Add(Me.pbZoom)
        Me.Controls.Add(Me.fbActual)
        Me.Controls.Add(Me.FlatButton6)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.sbExit)
        Me.Controls.Add(Me.tbTitle)
        Me.Controls.Add(Me.Elbow3)
        Me.Controls.Add(Me.fbInfo1)
        Me.Controls.Add(Me.Elbow4)
        Me.Controls.Add(Me.Elbow2)
        Me.Controls.Add(Me.FlatButton4)
        Me.Controls.Add(Me.fbRes)
        Me.Controls.Add(Me.Elbow1)
        Me.Controls.Add(Me.panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.StandardButton1)
        Me.Controls.Add(Me.sbBrowse)
        Me.Controls.Add(Me.sbShow)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmPic"
        Me.Text = "Photo Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.picturebox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picturebox1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrShow As System.Windows.Forms.Timer
    Friend WithEvents sbShow As LCARS.Controls.StandardButton
    Friend WithEvents sbBrowse As LCARS.Controls.StandardButton
    Friend WithEvents panel1 As System.Windows.Forms.Panel
    Friend WithEvents dwn As LCARS.Controls.FlatButton
    Friend WithEvents up As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton2 As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton8 As LCARS.Controls.FlatButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents FlatButton1 As LCARS.Controls.FlatButton
    Friend WithEvents abPrev As LCARS.Controls.ArrowButton
    Friend WithEvents abNext As LCARS.Controls.ArrowButton
    Friend WithEvents StandardButton1 As LCARS.Controls.StandardButton
    Friend WithEvents Elbow1 As LCARS.Controls.Elbow
    Friend WithEvents fbRes As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton4 As LCARS.Controls.FlatButton
    Friend WithEvents Elbow2 As LCARS.Controls.Elbow
    Friend WithEvents Elbow3 As LCARS.Controls.Elbow
    Friend WithEvents FlatButton6 As LCARS.Controls.FlatButton
    Friend WithEvents fbInfo1 As LCARS.Controls.FlatButton
    Friend WithEvents Elbow4 As LCARS.Controls.Elbow
    Friend WithEvents tbTitle As LCARS.Controls.TextButton
    Friend WithEvents sbExit As LCARS.Controls.StandardButton
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents pbZoom As LCARS.Controls.PieButton
    Friend WithEvents fbZoomIn As LCARS.Controls.FlatButton
    Friend WithEvents fbActual As LCARS.Controls.FlatButton
    Friend WithEvents ArrowButton2 As LCARS.Controls.ArrowButton
    Friend WithEvents ArrowButton1 As LCARS.Controls.ArrowButton
    Friend WithEvents fbZoomOut As LCARS.Controls.FlatButton
    Friend WithEvents rht As LCARS.Controls.FlatButton
    Friend WithEvents FlatButton13 As LCARS.Controls.FlatButton
    Friend WithEvents lft As LCARS.Controls.FlatButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents tmrup As System.Windows.Forms.Timer
    Friend WithEvents tmrdown As System.Windows.Forms.Timer
    Friend WithEvents tmrleft As System.Windows.Forms.Timer
    Friend WithEvents tmrright As System.Windows.Forms.Timer

End Class
