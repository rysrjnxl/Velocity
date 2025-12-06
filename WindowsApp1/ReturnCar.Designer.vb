<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReturnCar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReturnCarGrid = New System.Windows.Forms.DataGridView()
        Me.LateFeetxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Totaltxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ConfirmBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ExtensionCmbBx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UpdateBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.ReturnCarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(481, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'ReturnCarGrid
        '
        Me.ReturnCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReturnCarGrid.Location = New System.Drawing.Point(165, 83)
        Me.ReturnCarGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReturnCarGrid.Name = "ReturnCarGrid"
        Me.ReturnCarGrid.RowHeadersWidth = 51
        Me.ReturnCarGrid.RowTemplate.Height = 24
        Me.ReturnCarGrid.Size = New System.Drawing.Size(1080, 429)
        Me.ReturnCarGrid.TabIndex = 1
        '
        'LateFeetxtbx
        '
        Me.LateFeetxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LateFeetxtbx.DefaultText = ""
        Me.LateFeetxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LateFeetxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LateFeetxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LateFeetxtbx.DisabledState.Parent = Me.LateFeetxtbx
        Me.LateFeetxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LateFeetxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LateFeetxtbx.FocusedState.Parent = Me.LateFeetxtbx
        Me.LateFeetxtbx.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LateFeetxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LateFeetxtbx.HoverState.Parent = Me.LateFeetxtbx
        Me.LateFeetxtbx.Location = New System.Drawing.Point(165, 554)
        Me.LateFeetxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LateFeetxtbx.Name = "LateFeetxtbx"
        Me.LateFeetxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LateFeetxtbx.PlaceholderText = ""
        Me.LateFeetxtbx.ReadOnly = True
        Me.LateFeetxtbx.SelectedText = ""
        Me.LateFeetxtbx.ShadowDecoration.Parent = Me.LateFeetxtbx
        Me.LateFeetxtbx.Size = New System.Drawing.Size(300, 55)
        Me.LateFeetxtbx.TabIndex = 3
        '
        'Totaltxtbx
        '
        Me.Totaltxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Totaltxtbx.DefaultText = ""
        Me.Totaltxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Totaltxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Totaltxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Totaltxtbx.DisabledState.Parent = Me.Totaltxtbx
        Me.Totaltxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Totaltxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Totaltxtbx.FocusedState.Parent = Me.Totaltxtbx
        Me.Totaltxtbx.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totaltxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Totaltxtbx.HoverState.Parent = Me.Totaltxtbx
        Me.Totaltxtbx.Location = New System.Drawing.Point(473, 554)
        Me.Totaltxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Totaltxtbx.Name = "Totaltxtbx"
        Me.Totaltxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Totaltxtbx.PlaceholderText = ""
        Me.Totaltxtbx.ReadOnly = True
        Me.Totaltxtbx.SelectedText = ""
        Me.Totaltxtbx.ShadowDecoration.Parent = Me.Totaltxtbx
        Me.Totaltxtbx.Size = New System.Drawing.Size(300, 55)
        Me.Totaltxtbx.TabIndex = 4
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.BorderRadius = 5
        Me.ConfirmBtn.CheckedState.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.CustomImages.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.FillColor = System.Drawing.SystemColors.GrayText
        Me.ConfirmBtn.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmBtn.ForeColor = System.Drawing.Color.White
        Me.ConfirmBtn.HoverState.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.Location = New System.Drawing.Point(798, 742)
        Me.ConfirmBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.ShadowDecoration.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.Size = New System.Drawing.Size(202, 56)
        Me.ConfirmBtn.TabIndex = 5
        Me.ConfirmBtn.Text = "Confirm"
        '
        'CancelBtn
        '
        Me.CancelBtn.BorderRadius = 5
        Me.CancelBtn.CheckedState.Parent = Me.CancelBtn
        Me.CancelBtn.CustomImages.Parent = Me.CancelBtn
        Me.CancelBtn.FillColor = System.Drawing.SystemColors.GrayText
        Me.CancelBtn.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.HoverState.Parent = Me.CancelBtn
        Me.CancelBtn.Location = New System.Drawing.Point(1043, 742)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.ShadowDecoration.Parent = Me.CancelBtn
        Me.CancelBtn.Size = New System.Drawing.Size(202, 56)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "Cancel"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("ROG Fonts", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(384, 53)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "Return Car"
        '
        'ExtensionCmbBx
        '
        Me.ExtensionCmbBx.BackColor = System.Drawing.Color.Transparent
        Me.ExtensionCmbBx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ExtensionCmbBx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ExtensionCmbBx.FocusedColor = System.Drawing.Color.Empty
        Me.ExtensionCmbBx.FocusedState.Parent = Me.ExtensionCmbBx
        Me.ExtensionCmbBx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ExtensionCmbBx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ExtensionCmbBx.FormattingEnabled = True
        Me.ExtensionCmbBx.HoverState.Parent = Me.ExtensionCmbBx
        Me.ExtensionCmbBx.ItemHeight = 30
        Me.ExtensionCmbBx.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.ExtensionCmbBx.ItemsAppearance.Parent = Me.ExtensionCmbBx
        Me.ExtensionCmbBx.Location = New System.Drawing.Point(425, 646)
        Me.ExtensionCmbBx.Name = "ExtensionCmbBx"
        Me.ExtensionCmbBx.ShadowDecoration.Parent = Me.ExtensionCmbBx
        Me.ExtensionCmbBx.Size = New System.Drawing.Size(244, 36)
        Me.ExtensionCmbBx.TabIndex = 9
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(165, 646)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(244, 31)
        Me.Guna2HtmlLabel1.TabIndex = 10
        Me.Guna2HtmlLabel1.Text = "Extend (Days):"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BorderRadius = 5
        Me.UpdateBtn.CheckedState.Parent = Me.UpdateBtn
        Me.UpdateBtn.CustomImages.Parent = Me.UpdateBtn
        Me.UpdateBtn.FillColor = System.Drawing.SystemColors.GrayText
        Me.UpdateBtn.Font = New System.Drawing.Font("ROG Fonts", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.HoverState.Parent = Me.UpdateBtn
        Me.UpdateBtn.Location = New System.Drawing.Point(551, 742)
        Me.UpdateBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.ShadowDecoration.Parent = Me.UpdateBtn
        Me.UpdateBtn.Size = New System.Drawing.Size(202, 56)
        Me.UpdateBtn.TabIndex = 11
        Me.UpdateBtn.Text = "Update"
        '
        'ReturnCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.ExtensionCmbBx)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Controls.Add(Me.Totaltxtbx)
        Me.Controls.Add(Me.LateFeetxtbx)
        Me.Controls.Add(Me.ReturnCarGrid)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "ReturnCar"
        Me.Text = "ReturnCar"
        CType(Me.ReturnCarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ReturnCarGrid As DataGridView
    Friend WithEvents LateFeetxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Totaltxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ConfirmBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label21 As Label
    Friend WithEvents ExtensionCmbBx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UpdateBtn As Guna.UI2.WinForms.Guna2Button
End Class
