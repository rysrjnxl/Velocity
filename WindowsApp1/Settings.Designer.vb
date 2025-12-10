<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.LightModeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DarkModeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LightModeBtn
        '
        Me.LightModeBtn.CheckedState.Parent = Me.LightModeBtn
        Me.LightModeBtn.CustomImages.Parent = Me.LightModeBtn
        Me.LightModeBtn.FillColor = System.Drawing.Color.White
        Me.LightModeBtn.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LightModeBtn.ForeColor = System.Drawing.Color.Black
        Me.LightModeBtn.HoverState.Parent = Me.LightModeBtn
        Me.LightModeBtn.Location = New System.Drawing.Point(220, 479)
        Me.LightModeBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LightModeBtn.Name = "LightModeBtn"
        Me.LightModeBtn.ShadowDecoration.Parent = Me.LightModeBtn
        Me.LightModeBtn.Size = New System.Drawing.Size(202, 56)
        Me.LightModeBtn.TabIndex = 0
        Me.LightModeBtn.Text = "Light Mode"
        '
        'DarkModeBtn
        '
        Me.DarkModeBtn.CheckedState.Parent = Me.DarkModeBtn
        Me.DarkModeBtn.CustomImages.Parent = Me.DarkModeBtn
        Me.DarkModeBtn.FillColor = System.Drawing.Color.White
        Me.DarkModeBtn.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DarkModeBtn.ForeColor = System.Drawing.Color.Black
        Me.DarkModeBtn.HoverState.Parent = Me.DarkModeBtn
        Me.DarkModeBtn.Location = New System.Drawing.Point(220, 274)
        Me.DarkModeBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DarkModeBtn.Name = "DarkModeBtn"
        Me.DarkModeBtn.ShadowDecoration.Parent = Me.DarkModeBtn
        Me.DarkModeBtn.Size = New System.Drawing.Size(202, 56)
        Me.DarkModeBtn.TabIndex = 1
        Me.DarkModeBtn.Text = "Dark Mode"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LightModeBtn)
        Me.Panel1.Controls.Add(Me.DarkModeBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1440, 900)
        Me.Panel1.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("ROG Fonts", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(310, 53)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(143, 392)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 38)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Light Theme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(143, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 38)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Dark Theme"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 48)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Theme"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LightModeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DarkModeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label21 As Label
End Class
