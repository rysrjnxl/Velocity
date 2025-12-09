<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.closeBox = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.menuTransition = New System.Windows.Forms.Timer(Me.components)
        Me.sidebarTransition = New System.Windows.Forms.Timer(Me.components)
        Me.pnLogout = New System.Windows.Forms.Panel()
        Me.logoutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.pnAbout = New System.Windows.Forms.Panel()
        Me.aboutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.pnSettings = New System.Windows.Forms.Panel()
        Me.settingsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ReturnCarBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.RentCarBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.recordsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.carinvBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.pnDashboard = New System.Windows.Forms.Panel()
        Me.dashboardBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.pnSidebar = New System.Windows.Forms.Panel()
        Me.sidebarBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.sidebarPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnLogout.SuspendLayout()
        Me.pnAbout.SuspendLayout()
        Me.pnSettings.SuspendLayout()
        Me.pnDashboard.SuspendLayout()
        Me.pnSidebar.SuspendLayout()
        Me.sidebarPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'closeBox
        '
        Me.closeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBox.BorderRadius = 5
        Me.closeBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.closeBox.HoverState.Parent = Me.closeBox
        Me.closeBox.IconColor = System.Drawing.Color.White
        Me.closeBox.Location = New System.Drawing.Point(1377, 13)
        Me.closeBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.closeBox.Name = "closeBox"
        Me.closeBox.ShadowDecoration.Parent = Me.closeBox
        Me.closeBox.Size = New System.Drawing.Size(51, 36)
        Me.closeBox.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BorderRadius = 5
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1320, 13)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(51, 36)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.closeBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1440, 62)
        Me.Guna2Panel1.TabIndex = 0
        '
        'Guna2PictureBox2
        '
        Me.Guna2PictureBox2.Image = CType(resources.GetObject("Guna2PictureBox2.Image"), System.Drawing.Image)
        Me.Guna2PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.Guna2PictureBox2.Name = "Guna2PictureBox2"
        Me.Guna2PictureBox2.ShadowDecoration.Parent = Me.Guna2PictureBox2
        Me.Guna2PictureBox2.Size = New System.Drawing.Size(39, 33)
        Me.Guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox2.TabIndex = 3
        Me.Guna2PictureBox2.TabStop = False
        '
        'menuTransition
        '
        Me.menuTransition.Interval = 10
        '
        'sidebarTransition
        '
        Me.sidebarTransition.Interval = 10
        '
        'pnLogout
        '
        Me.pnLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnLogout.Controls.Add(Me.logoutBtn)
        Me.pnLogout.Location = New System.Drawing.Point(9, 652)
        Me.pnLogout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnLogout.Name = "pnLogout"
        Me.pnLogout.Size = New System.Drawing.Size(281, 75)
        Me.pnLogout.TabIndex = 3
        '
        'logoutBtn
        '
        Me.logoutBtn.CheckedState.Parent = Me.logoutBtn
        Me.logoutBtn.CustomImages.Parent = Me.logoutBtn
        Me.logoutBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.logoutBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.logoutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.logoutBtn.HoverState.Parent = Me.logoutBtn
        Me.logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), System.Drawing.Image)
        Me.logoutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.logoutBtn.Location = New System.Drawing.Point(0, 0)
        Me.logoutBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.ShadowDecoration.Parent = Me.logoutBtn
        Me.logoutBtn.Size = New System.Drawing.Size(336, 75)
        Me.logoutBtn.TabIndex = 0
        Me.logoutBtn.Text = "        Logout"
        Me.logoutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnAbout
        '
        Me.pnAbout.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnAbout.Controls.Add(Me.aboutBtn)
        Me.pnAbout.Location = New System.Drawing.Point(9, 569)
        Me.pnAbout.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnAbout.Name = "pnAbout"
        Me.pnAbout.Size = New System.Drawing.Size(281, 75)
        Me.pnAbout.TabIndex = 3
        '
        'aboutBtn
        '
        Me.aboutBtn.CheckedState.Parent = Me.aboutBtn
        Me.aboutBtn.CustomImages.Parent = Me.aboutBtn
        Me.aboutBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.aboutBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.aboutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.aboutBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.aboutBtn.HoverState.Parent = Me.aboutBtn
        Me.aboutBtn.Image = CType(resources.GetObject("aboutBtn.Image"), System.Drawing.Image)
        Me.aboutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.aboutBtn.Location = New System.Drawing.Point(0, 0)
        Me.aboutBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.aboutBtn.Name = "aboutBtn"
        Me.aboutBtn.ShadowDecoration.Parent = Me.aboutBtn
        Me.aboutBtn.Size = New System.Drawing.Size(336, 75)
        Me.aboutBtn.TabIndex = 0
        Me.aboutBtn.Text = "        About"
        Me.aboutBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnSettings
        '
        Me.pnSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnSettings.Controls.Add(Me.settingsBtn)
        Me.pnSettings.Location = New System.Drawing.Point(9, 486)
        Me.pnSettings.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnSettings.Name = "pnSettings"
        Me.pnSettings.Size = New System.Drawing.Size(281, 75)
        Me.pnSettings.TabIndex = 3
        '
        'settingsBtn
        '
        Me.settingsBtn.CheckedState.Parent = Me.settingsBtn
        Me.settingsBtn.CustomImages.Parent = Me.settingsBtn
        Me.settingsBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.settingsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.settingsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.settingsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.settingsBtn.HoverState.Parent = Me.settingsBtn
        Me.settingsBtn.Image = CType(resources.GetObject("settingsBtn.Image"), System.Drawing.Image)
        Me.settingsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.settingsBtn.Location = New System.Drawing.Point(0, 0)
        Me.settingsBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.ShadowDecoration.Parent = Me.settingsBtn
        Me.settingsBtn.Size = New System.Drawing.Size(336, 75)
        Me.settingsBtn.TabIndex = 0
        Me.settingsBtn.Text = "        Settings"
        Me.settingsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ReturnCarBtn
        '
        Me.ReturnCarBtn.CheckedState.Parent = Me.ReturnCarBtn
        Me.ReturnCarBtn.CustomImages.Parent = Me.ReturnCarBtn
        Me.ReturnCarBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ReturnCarBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ReturnCarBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ReturnCarBtn.HoverState.Parent = Me.ReturnCarBtn
        Me.ReturnCarBtn.Image = CType(resources.GetObject("ReturnCarBtn.Image"), System.Drawing.Image)
        Me.ReturnCarBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ReturnCarBtn.Location = New System.Drawing.Point(9, 407)
        Me.ReturnCarBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReturnCarBtn.Name = "ReturnCarBtn"
        Me.ReturnCarBtn.ShadowDecoration.Parent = Me.ReturnCarBtn
        Me.ReturnCarBtn.Size = New System.Drawing.Size(336, 71)
        Me.ReturnCarBtn.TabIndex = 0
        Me.ReturnCarBtn.Text = "         Return A Car"
        Me.ReturnCarBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'RentCarBtn
        '
        Me.RentCarBtn.CheckedState.Parent = Me.RentCarBtn
        Me.RentCarBtn.CustomImages.Parent = Me.RentCarBtn
        Me.RentCarBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.RentCarBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RentCarBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.RentCarBtn.HoverState.Parent = Me.RentCarBtn
        Me.RentCarBtn.Image = CType(resources.GetObject("RentCarBtn.Image"), System.Drawing.Image)
        Me.RentCarBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.RentCarBtn.Location = New System.Drawing.Point(9, 328)
        Me.RentCarBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RentCarBtn.Name = "RentCarBtn"
        Me.RentCarBtn.ShadowDecoration.Parent = Me.RentCarBtn
        Me.RentCarBtn.Size = New System.Drawing.Size(336, 71)
        Me.RentCarBtn.TabIndex = 0
        Me.RentCarBtn.Text = "         Rent A Car"
        Me.RentCarBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'recordsBtn
        '
        Me.recordsBtn.CheckedState.Parent = Me.recordsBtn
        Me.recordsBtn.CustomImages.Parent = Me.recordsBtn
        Me.recordsBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.recordsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.recordsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.recordsBtn.HoverState.Parent = Me.recordsBtn
        Me.recordsBtn.Image = CType(resources.GetObject("recordsBtn.Image"), System.Drawing.Image)
        Me.recordsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.recordsBtn.Location = New System.Drawing.Point(9, 249)
        Me.recordsBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.recordsBtn.Name = "recordsBtn"
        Me.recordsBtn.ShadowDecoration.Parent = Me.recordsBtn
        Me.recordsBtn.Size = New System.Drawing.Size(336, 71)
        Me.recordsBtn.TabIndex = 0
        Me.recordsBtn.Text = "         Customer Records"
        Me.recordsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'carinvBtn
        '
        Me.carinvBtn.CheckedState.Parent = Me.carinvBtn
        Me.carinvBtn.CustomImages.Parent = Me.carinvBtn
        Me.carinvBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.carinvBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.carinvBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.carinvBtn.HoverState.Parent = Me.carinvBtn
        Me.carinvBtn.Image = CType(resources.GetObject("carinvBtn.Image"), System.Drawing.Image)
        Me.carinvBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.carinvBtn.Location = New System.Drawing.Point(9, 170)
        Me.carinvBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.carinvBtn.Name = "carinvBtn"
        Me.carinvBtn.ShadowDecoration.Parent = Me.carinvBtn
        Me.carinvBtn.Size = New System.Drawing.Size(336, 71)
        Me.carinvBtn.TabIndex = 0
        Me.carinvBtn.Text = "         Car Inventory"
        Me.carinvBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnDashboard
        '
        Me.pnDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnDashboard.Controls.Add(Me.dashboardBtn)
        Me.pnDashboard.Location = New System.Drawing.Point(9, 87)
        Me.pnDashboard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnDashboard.Name = "pnDashboard"
        Me.pnDashboard.Size = New System.Drawing.Size(281, 75)
        Me.pnDashboard.TabIndex = 4
        '
        'dashboardBtn
        '
        Me.dashboardBtn.CheckedState.Parent = Me.dashboardBtn
        Me.dashboardBtn.CustomImages.Parent = Me.dashboardBtn
        Me.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.dashboardBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.dashboardBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dashboardBtn.HoverState.Parent = Me.dashboardBtn
        Me.dashboardBtn.Image = CType(resources.GetObject("dashboardBtn.Image"), System.Drawing.Image)
        Me.dashboardBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.dashboardBtn.Location = New System.Drawing.Point(0, 0)
        Me.dashboardBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dashboardBtn.Name = "dashboardBtn"
        Me.dashboardBtn.ShadowDecoration.Parent = Me.dashboardBtn
        Me.dashboardBtn.Size = New System.Drawing.Size(336, 75)
        Me.dashboardBtn.TabIndex = 0
        Me.dashboardBtn.Text = "         Dashboard"
        Me.dashboardBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pnSidebar
        '
        Me.pnSidebar.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.pnSidebar.Controls.Add(Me.sidebarBtn)
        Me.pnSidebar.Location = New System.Drawing.Point(9, 4)
        Me.pnSidebar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pnSidebar.Name = "pnSidebar"
        Me.pnSidebar.Size = New System.Drawing.Size(281, 75)
        Me.pnSidebar.TabIndex = 2
        '
        'sidebarBtn
        '
        Me.sidebarBtn.CheckedState.Parent = Me.sidebarBtn
        Me.sidebarBtn.CustomImages.Parent = Me.sidebarBtn
        Me.sidebarBtn.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.sidebarBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sidebarBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(184, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.sidebarBtn.HoverState.Parent = Me.sidebarBtn
        Me.sidebarBtn.Image = CType(resources.GetObject("sidebarBtn.Image"), System.Drawing.Image)
        Me.sidebarBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.sidebarBtn.Location = New System.Drawing.Point(0, 0)
        Me.sidebarBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sidebarBtn.Name = "sidebarBtn"
        Me.sidebarBtn.ShadowDecoration.Parent = Me.sidebarBtn
        Me.sidebarBtn.Size = New System.Drawing.Size(336, 75)
        Me.sidebarBtn.TabIndex = 0
        Me.sidebarBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'sidebarPanel
        '
        Me.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.sidebarPanel.Controls.Add(Me.pnSidebar)
        Me.sidebarPanel.Controls.Add(Me.pnDashboard)
        Me.sidebarPanel.Controls.Add(Me.carinvBtn)
        Me.sidebarPanel.Controls.Add(Me.recordsBtn)
        Me.sidebarPanel.Controls.Add(Me.RentCarBtn)
        Me.sidebarPanel.Controls.Add(Me.ReturnCarBtn)
        Me.sidebarPanel.Controls.Add(Me.pnSettings)
        Me.sidebarPanel.Controls.Add(Me.pnAbout)
        Me.sidebarPanel.Controls.Add(Me.pnLogout)
        Me.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.sidebarPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.sidebarPanel.Location = New System.Drawing.Point(0, 62)
        Me.sidebarPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.sidebarPanel.Name = "sidebarPanel"
        Me.sidebarPanel.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.sidebarPanel.Size = New System.Drawing.Size(79, 838)
        Me.sidebarPanel.TabIndex = 1
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.sidebarPanel)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnLogout.ResumeLayout(False)
        Me.pnAbout.ResumeLayout(False)
        Me.pnSettings.ResumeLayout(False)
        Me.pnDashboard.ResumeLayout(False)
        Me.pnSidebar.ResumeLayout(False)
        Me.sidebarPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents closeBox As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents menuTransition As Timer
    Friend WithEvents sidebarTransition As Timer
    Friend WithEvents pnLogout As Panel
    Friend WithEvents logoutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnAbout As Panel
    Friend WithEvents aboutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnSettings As Panel
    Friend WithEvents settingsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReturnCarBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents RentCarBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents recordsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents carinvBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnDashboard As Panel
    Friend WithEvents dashboardBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnSidebar As Panel
    Friend WithEvents sidebarBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents sidebarPanel As FlowLayoutPanel
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
