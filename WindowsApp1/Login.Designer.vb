<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.loginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.closeBox = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.UsernameTxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Passwordtxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginBtn
        '
        Me.loginBtn.BorderRadius = 8
        Me.loginBtn.CheckedState.Parent = Me.loginBtn
        Me.loginBtn.CustomImages.Parent = Me.loginBtn
        Me.loginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.loginBtn.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.HoverState.Parent = Me.loginBtn
        Me.loginBtn.Location = New System.Drawing.Point(290, 645)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.ShadowDecoration.Parent = Me.loginBtn
        Me.loginBtn.Size = New System.Drawing.Size(202, 44)
        Me.loginBtn.TabIndex = 0
        Me.loginBtn.Text = "Login"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.closeBox)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(782, 62)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(12, 5)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(361, 57)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 4
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(662, 10)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(51, 36)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'closeBox
        '
        Me.closeBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closeBox.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.closeBox.HoverState.Parent = Me.closeBox
        Me.closeBox.IconColor = System.Drawing.Color.White
        Me.closeBox.Location = New System.Drawing.Point(719, 10)
        Me.closeBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.closeBox.Name = "closeBox"
        Me.closeBox.ShadowDecoration.Parent = Me.closeBox
        Me.closeBox.Size = New System.Drawing.Size(51, 36)
        Me.closeBox.TabIndex = 0
        '
        'UsernameTxtbx
        '
        Me.UsernameTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTxtbx.DefaultText = ""
        Me.UsernameTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxtbx.DisabledState.Parent = Me.UsernameTxtbx
        Me.UsernameTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxtbx.FocusedState.Parent = Me.UsernameTxtbx
        Me.UsernameTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxtbx.HoverState.Parent = Me.UsernameTxtbx
        Me.UsernameTxtbx.Location = New System.Drawing.Point(235, 459)
        Me.UsernameTxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UsernameTxtbx.Name = "UsernameTxtbx"
        Me.UsernameTxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxtbx.PlaceholderText = ""
        Me.UsernameTxtbx.SelectedText = ""
        Me.UsernameTxtbx.ShadowDecoration.Parent = Me.UsernameTxtbx
        Me.UsernameTxtbx.Size = New System.Drawing.Size(300, 43)
        Me.UsernameTxtbx.TabIndex = 2
        '
        'Passwordtxtbx
        '
        Me.Passwordtxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Passwordtxtbx.DefaultText = ""
        Me.Passwordtxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Passwordtxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Passwordtxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Passwordtxtbx.DisabledState.Parent = Me.Passwordtxtbx
        Me.Passwordtxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Passwordtxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Passwordtxtbx.FocusedState.Parent = Me.Passwordtxtbx
        Me.Passwordtxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Passwordtxtbx.HoverState.Parent = Me.Passwordtxtbx
        Me.Passwordtxtbx.Location = New System.Drawing.Point(235, 539)
        Me.Passwordtxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Passwordtxtbx.Name = "Passwordtxtbx"
        Me.Passwordtxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Passwordtxtbx.PlaceholderText = ""
        Me.Passwordtxtbx.SelectedText = ""
        Me.Passwordtxtbx.ShadowDecoration.Parent = Me.Passwordtxtbx
        Me.Passwordtxtbx.Size = New System.Drawing.Size(300, 43)
        Me.Passwordtxtbx.TabIndex = 3
        Me.Passwordtxtbx.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(211, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 62)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Welcome!"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 900)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Passwordtxtbx)
        Me.Controls.Add(Me.UsernameTxtbx)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.loginBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents closeBox As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents UsernameTxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Passwordtxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
End Class
