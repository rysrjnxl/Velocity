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
        Me.LightModeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DarkModeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'LightModeBtn
        '
        Me.LightModeBtn.CheckedState.Parent = Me.LightModeBtn
        Me.LightModeBtn.CustomImages.Parent = Me.LightModeBtn
        Me.LightModeBtn.FillColor = System.Drawing.Color.White
        Me.LightModeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LightModeBtn.ForeColor = System.Drawing.Color.Black
        Me.LightModeBtn.HoverState.Parent = Me.LightModeBtn
        Me.LightModeBtn.Location = New System.Drawing.Point(220, 90)
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
        Me.DarkModeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DarkModeBtn.ForeColor = System.Drawing.Color.Black
        Me.DarkModeBtn.HoverState.Parent = Me.DarkModeBtn
        Me.DarkModeBtn.Location = New System.Drawing.Point(12, 90)
        Me.DarkModeBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DarkModeBtn.Name = "DarkModeBtn"
        Me.DarkModeBtn.ShadowDecoration.Parent = Me.DarkModeBtn
        Me.DarkModeBtn.Size = New System.Drawing.Size(202, 56)
        Me.DarkModeBtn.TabIndex = 1
        Me.DarkModeBtn.Text = "Dark Mode"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("ROG Fonts", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2HtmlLabel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(1440, 60)
        Me.Guna2HtmlLabel1.TabIndex = 2
        Me.Guna2HtmlLabel1.Text = "Theme"
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.DarkModeBtn)
        Me.Controls.Add(Me.LightModeBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Settings"
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LightModeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DarkModeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
