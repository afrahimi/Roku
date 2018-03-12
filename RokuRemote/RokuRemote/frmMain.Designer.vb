<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnPOST = New System.Windows.Forms.Button()
        Me.tbxPOSTURL = New System.Windows.Forms.TextBox()
        Me.tbxCommand = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxResponse = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGET = New System.Windows.Forms.Button()
        Me.tbxGETURL = New System.Windows.Forms.TextBox()
        Me.tbxIPAddr = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnUpdateIP = New System.Windows.Forms.Button()
        Me.pbxIcon = New System.Windows.Forms.PictureBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnRev = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.btnOn = New System.Windows.Forms.Button()
        Me.btnOff = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVolumedown = New System.Windows.Forms.Button()
        Me.btnVolumemute = New System.Windows.Forms.Button()
        Me.btnVolumeup = New System.Windows.Forms.Button()
        Me.lb1 = New System.Windows.Forms.ListBox()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.il1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnApps = New System.Windows.Forms.Button()
        Me.ni1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkMon = New System.Windows.Forms.CheckBox()
        Me.chkTue = New System.Windows.Forms.CheckBox()
        Me.chkWed = New System.Windows.Forms.CheckBox()
        Me.chkThu = New System.Windows.Forms.CheckBox()
        Me.chkFri = New System.Windows.Forms.CheckBox()
        Me.chkSat = New System.Windows.Forms.CheckBox()
        Me.chkSun = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOn = New System.Windows.Forms.TextBox()
        Me.txtOff = New System.Windows.Forms.TextBox()
        CType(Me.pbxIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPOST
        '
        Me.btnPOST.Location = New System.Drawing.Point(531, 64)
        Me.btnPOST.Name = "btnPOST"
        Me.btnPOST.Size = New System.Drawing.Size(75, 23)
        Me.btnPOST.TabIndex = 0
        Me.btnPOST.Text = "POST"
        Me.btnPOST.UseVisualStyleBackColor = True
        '
        'tbxPOSTURL
        '
        Me.tbxPOSTURL.Location = New System.Drawing.Point(114, 64)
        Me.tbxPOSTURL.Name = "tbxPOSTURL"
        Me.tbxPOSTURL.Size = New System.Drawing.Size(411, 20)
        Me.tbxPOSTURL.TabIndex = 1
        '
        'tbxCommand
        '
        Me.tbxCommand.Location = New System.Drawing.Point(114, 90)
        Me.tbxCommand.Name = "tbxCommand"
        Me.tbxCommand.Size = New System.Drawing.Size(411, 20)
        Me.tbxCommand.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "URL to POST to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Command to POST"
        '
        'tbxResponse
        '
        Me.tbxResponse.Location = New System.Drawing.Point(617, 25)
        Me.tbxResponse.Multiline = True
        Me.tbxResponse.Name = "tbxResponse"
        Me.tbxResponse.Size = New System.Drawing.Size(220, 207)
        Me.tbxResponse.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(614, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Response"
        '
        'btnGET
        '
        Me.btnGET.Location = New System.Drawing.Point(531, 36)
        Me.btnGET.Name = "btnGET"
        Me.btnGET.Size = New System.Drawing.Size(75, 23)
        Me.btnGET.TabIndex = 7
        Me.btnGET.Text = "GET"
        Me.btnGET.UseVisualStyleBackColor = True
        '
        'tbxGETURL
        '
        Me.tbxGETURL.Location = New System.Drawing.Point(114, 38)
        Me.tbxGETURL.Name = "tbxGETURL"
        Me.tbxGETURL.Size = New System.Drawing.Size(411, 20)
        Me.tbxGETURL.TabIndex = 8
        '
        'tbxIPAddr
        '
        Me.tbxIPAddr.Location = New System.Drawing.Point(114, 12)
        Me.tbxIPAddr.Name = "tbxIPAddr"
        Me.tbxIPAddr.Size = New System.Drawing.Size(411, 20)
        Me.tbxIPAddr.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "IP Address of Roku"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "URL to GET from"
        '
        'btnUpdateIP
        '
        Me.btnUpdateIP.Location = New System.Drawing.Point(531, 7)
        Me.btnUpdateIP.Name = "btnUpdateIP"
        Me.btnUpdateIP.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdateIP.TabIndex = 12
        Me.btnUpdateIP.Text = "Update IP"
        Me.btnUpdateIP.UseVisualStyleBackColor = True
        '
        'pbxIcon
        '
        Me.pbxIcon.Location = New System.Drawing.Point(758, 406)
        Me.pbxIcon.Name = "pbxIcon"
        Me.pbxIcon.Size = New System.Drawing.Size(81, 78)
        Me.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pbxIcon.TabIndex = 13
        Me.pbxIcon.TabStop = False
        '
        'btnUp
        '
        Me.btnUp.Location = New System.Drawing.Point(68, 86)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(51, 24)
        Me.btnUp.TabIndex = 14
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Location = New System.Drawing.Point(68, 140)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(51, 24)
        Me.btnDown.TabIndex = 15
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'btnRight
        '
        Me.btnRight.Location = New System.Drawing.Point(127, 113)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(51, 24)
        Me.btnRight.TabIndex = 16
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = True
        '
        'btnLeft
        '
        Me.btnLeft.Location = New System.Drawing.Point(8, 113)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(51, 24)
        Me.btnLeft.TabIndex = 17
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(68, 113)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(51, 24)
        Me.btnOK.TabIndex = 18
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(127, 65)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(51, 24)
        Me.btnHome.TabIndex = 19
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(8, 65)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(51, 24)
        Me.btnBack.TabIndex = 20
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(68, 175)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(51, 24)
        Me.btnPlay.TabIndex = 27
        Me.btnPlay.Text = "| | >"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnRev
        '
        Me.btnRev.Location = New System.Drawing.Point(8, 175)
        Me.btnRev.Name = "btnRev"
        Me.btnRev.Size = New System.Drawing.Size(51, 24)
        Me.btnRev.TabIndex = 26
        Me.btnRev.Text = "<<"
        Me.btnRev.UseVisualStyleBackColor = True
        '
        'btnFwd
        '
        Me.btnFwd.Location = New System.Drawing.Point(127, 175)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(51, 24)
        Me.btnFwd.TabIndex = 25
        Me.btnFwd.Text = ">>"
        Me.btnFwd.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(533, 97)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(73, 13)
        Me.LinkLabel1.TabIndex = 28
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Command List"
        '
        'btnOn
        '
        Me.btnOn.Location = New System.Drawing.Point(127, 19)
        Me.btnOn.Name = "btnOn"
        Me.btnOn.Size = New System.Drawing.Size(51, 23)
        Me.btnOn.TabIndex = 29
        Me.btnOn.Text = "On"
        Me.btnOn.UseVisualStyleBackColor = True
        '
        'btnOff
        '
        Me.btnOff.Location = New System.Drawing.Point(6, 19)
        Me.btnOff.Name = "btnOff"
        Me.btnOff.Size = New System.Drawing.Size(51, 23)
        Me.btnOff.TabIndex = 29
        Me.btnOff.Text = "Off"
        Me.btnOff.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 487)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(614, 22)
        Me.StatusStrip1.TabIndex = 30
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(12, 17)
        Me.lblTime.Text = "-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnVolumedown)
        Me.GroupBox1.Controls.Add(Me.btnVolumemute)
        Me.GroupBox1.Controls.Add(Me.btnVolumeup)
        Me.GroupBox1.Controls.Add(Me.btnOff)
        Me.GroupBox1.Controls.Add(Me.btnUp)
        Me.GroupBox1.Controls.Add(Me.btnDown)
        Me.GroupBox1.Controls.Add(Me.btnOn)
        Me.GroupBox1.Controls.Add(Me.btnRight)
        Me.GroupBox1.Controls.Add(Me.btnLeft)
        Me.GroupBox1.Controls.Add(Me.btnPlay)
        Me.GroupBox1.Controls.Add(Me.btnOK)
        Me.GroupBox1.Controls.Add(Me.btnRev)
        Me.GroupBox1.Controls.Add(Me.btnHome)
        Me.GroupBox1.Controls.Add(Me.btnFwd)
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(189, 244)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'btnVolumedown
        '
        Me.btnVolumedown.BackgroundImage = CType(resources.GetObject("btnVolumedown.BackgroundImage"), System.Drawing.Image)
        Me.btnVolumedown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolumedown.Location = New System.Drawing.Point(68, 215)
        Me.btnVolumedown.Name = "btnVolumedown"
        Me.btnVolumedown.Size = New System.Drawing.Size(51, 23)
        Me.btnVolumedown.TabIndex = 30
        Me.btnVolumedown.UseVisualStyleBackColor = True
        '
        'btnVolumemute
        '
        Me.btnVolumemute.BackgroundImage = CType(resources.GetObject("btnVolumemute.BackgroundImage"), System.Drawing.Image)
        Me.btnVolumemute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolumemute.Location = New System.Drawing.Point(8, 215)
        Me.btnVolumemute.Name = "btnVolumemute"
        Me.btnVolumemute.Size = New System.Drawing.Size(51, 23)
        Me.btnVolumemute.TabIndex = 30
        Me.btnVolumemute.UseVisualStyleBackColor = True
        '
        'btnVolumeup
        '
        Me.btnVolumeup.BackgroundImage = CType(resources.GetObject("btnVolumeup.BackgroundImage"), System.Drawing.Image)
        Me.btnVolumeup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVolumeup.Location = New System.Drawing.Point(127, 215)
        Me.btnVolumeup.Name = "btnVolumeup"
        Me.btnVolumeup.Size = New System.Drawing.Size(51, 23)
        Me.btnVolumeup.TabIndex = 30
        Me.btnVolumeup.UseVisualStyleBackColor = True
        '
        'lb1
        '
        Me.lb1.FormattingEnabled = True
        Me.lb1.Location = New System.Drawing.Point(617, 238)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(220, 238)
        Me.lb1.TabIndex = 32
        '
        'lv1
        '
        Me.lv1.LargeImageList = Me.il1
        Me.lv1.Location = New System.Drawing.Point(223, 126)
        Me.lv1.Margin = New System.Windows.Forms.Padding(0)
        Me.lv1.Name = "lv1"
        Me.lv1.Scrollable = False
        Me.lv1.Size = New System.Drawing.Size(379, 228)
        Me.lv1.TabIndex = 33
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'il1
        '
        Me.il1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.il1.ImageSize = New System.Drawing.Size(48, 48)
        Me.il1.TransparentColor = System.Drawing.SystemColors.Control
        '
        'btnApps
        '
        Me.btnApps.Location = New System.Drawing.Point(762, 454)
        Me.btnApps.Name = "btnApps"
        Me.btnApps.Size = New System.Drawing.Size(75, 23)
        Me.btnApps.TabIndex = 34
        Me.btnApps.Text = "Refresh"
        Me.btnApps.UseVisualStyleBackColor = True
        Me.btnApps.Visible = False
        '
        'ni1
        '
        Me.ni1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ni1.Icon = CType(resources.GetObject("ni1.Icon"), System.Drawing.Icon)
        Me.ni1.Text = "Roku Remote"
        Me.ni1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(93, 26)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtOff)
        Me.GroupBox2.Controls.Add(Me.txtOn)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.chkSun)
        Me.GroupBox2.Controls.Add(Me.chkSat)
        Me.GroupBox2.Controls.Add(Me.chkFri)
        Me.GroupBox2.Controls.Add(Me.chkThu)
        Me.GroupBox2.Controls.Add(Me.chkWed)
        Me.GroupBox2.Controls.Add(Me.chkTue)
        Me.GroupBox2.Controls.Add(Me.chkMon)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 367)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(587, 117)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Scheduling"
        '
        'chkMon
        '
        Me.chkMon.AutoSize = True
        Me.chkMon.Checked = True
        Me.chkMon.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMon.Location = New System.Drawing.Point(12, 29)
        Me.chkMon.Name = "chkMon"
        Me.chkMon.Size = New System.Drawing.Size(64, 17)
        Me.chkMon.TabIndex = 0
        Me.chkMon.Text = "Monday"
        Me.chkMon.UseVisualStyleBackColor = True
        '
        'chkTue
        '
        Me.chkTue.AutoSize = True
        Me.chkTue.Checked = True
        Me.chkTue.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTue.Location = New System.Drawing.Point(82, 29)
        Me.chkTue.Name = "chkTue"
        Me.chkTue.Size = New System.Drawing.Size(67, 17)
        Me.chkTue.TabIndex = 0
        Me.chkTue.Text = "Tuesday"
        Me.chkTue.UseVisualStyleBackColor = True
        '
        'chkWed
        '
        Me.chkWed.AutoSize = True
        Me.chkWed.Checked = True
        Me.chkWed.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWed.Location = New System.Drawing.Point(155, 29)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(83, 17)
        Me.chkWed.TabIndex = 0
        Me.chkWed.Text = "Wednesday"
        Me.chkWed.UseVisualStyleBackColor = True
        '
        'chkThu
        '
        Me.chkThu.AutoSize = True
        Me.chkThu.Checked = True
        Me.chkThu.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkThu.Location = New System.Drawing.Point(244, 29)
        Me.chkThu.Name = "chkThu"
        Me.chkThu.Size = New System.Drawing.Size(70, 17)
        Me.chkThu.TabIndex = 0
        Me.chkThu.Text = "Thursday"
        Me.chkThu.UseVisualStyleBackColor = True
        '
        'chkFri
        '
        Me.chkFri.AutoSize = True
        Me.chkFri.Checked = True
        Me.chkFri.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkFri.Location = New System.Drawing.Point(320, 29)
        Me.chkFri.Name = "chkFri"
        Me.chkFri.Size = New System.Drawing.Size(54, 17)
        Me.chkFri.TabIndex = 0
        Me.chkFri.Text = "Friday"
        Me.chkFri.UseVisualStyleBackColor = True
        '
        'chkSat
        '
        Me.chkSat.AutoSize = True
        Me.chkSat.Location = New System.Drawing.Point(380, 29)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(68, 17)
        Me.chkSat.TabIndex = 0
        Me.chkSat.Text = "Saturday"
        Me.chkSat.UseVisualStyleBackColor = True
        '
        'chkSun
        '
        Me.chkSun.AutoSize = True
        Me.chkSun.Location = New System.Drawing.Point(454, 29)
        Me.chkSun.Name = "chkSun"
        Me.chkSun.Size = New System.Drawing.Size(62, 17)
        Me.chkSun.TabIndex = 0
        Me.chkSun.Text = "Sunday"
        Me.chkSun.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Power On at:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Power Off at:"
        '
        'txtOn
        '
        Me.txtOn.Location = New System.Drawing.Point(86, 58)
        Me.txtOn.Name = "txtOn"
        Me.txtOn.Size = New System.Drawing.Size(100, 20)
        Me.txtOn.TabIndex = 3
        Me.txtOn.Text = "5:30"
        '
        'txtOff
        '
        Me.txtOff.Location = New System.Drawing.Point(86, 84)
        Me.txtOff.Name = "txtOff"
        Me.txtOff.Size = New System.Drawing.Size(100, 20)
        Me.txtOff.TabIndex = 3
        Me.txtOff.Text = "6:30"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 509)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnApps)
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.lb1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.pbxIcon)
        Me.Controls.Add(Me.btnUpdateIP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbxIPAddr)
        Me.Controls.Add(Me.tbxGETURL)
        Me.Controls.Add(Me.btnGET)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxResponse)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbxCommand)
        Me.Controls.Add(Me.tbxPOSTURL)
        Me.Controls.Add(Me.btnPOST)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RokuRemote"
        CType(Me.pbxIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPOST As System.Windows.Forms.Button
    Friend WithEvents tbxPOSTURL As System.Windows.Forms.TextBox
    Friend WithEvents tbxCommand As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbxResponse As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnGET As System.Windows.Forms.Button
    Friend WithEvents tbxGETURL As System.Windows.Forms.TextBox
    Friend WithEvents tbxIPAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateIP As System.Windows.Forms.Button
    Friend WithEvents pbxIcon As System.Windows.Forms.PictureBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnRight As System.Windows.Forms.Button
    Friend WithEvents btnLeft As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnPlay As System.Windows.Forms.Button
    Friend WithEvents btnRev As System.Windows.Forms.Button
    Friend WithEvents btnFwd As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnOn As Button
    Friend WithEvents btnOff As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTime As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lb1 As ListBox
    Friend WithEvents lv1 As ListView
    Friend WithEvents btnApps As Button
    Friend WithEvents il1 As ImageList
    Friend WithEvents btnVolumedown As Button
    Friend WithEvents btnVolumemute As Button
    Friend WithEvents btnVolumeup As Button
    Friend WithEvents ni1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents chkSun As CheckBox
    Friend WithEvents chkSat As CheckBox
    Friend WithEvents chkFri As CheckBox
    Friend WithEvents chkThu As CheckBox
    Friend WithEvents chkWed As CheckBox
    Friend WithEvents chkTue As CheckBox
    Friend WithEvents chkMon As CheckBox
    Friend WithEvents txtOff As TextBox
    Friend WithEvents txtOn As TextBox
End Class
