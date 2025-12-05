<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentTransaction
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.CustomerCmbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CarModelCmbx = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TotalCostTxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ConfirmBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.RentDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(752, 47)
        Me.Panel1.TabIndex = 0
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BorderRadius = 5
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(644, 8)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 5
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(695, 8)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 0
        '
        'CustomerCmbx
        '
        Me.CustomerCmbx.BackColor = System.Drawing.Color.Transparent
        Me.CustomerCmbx.BorderRadius = 5
        Me.CustomerCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CustomerCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CustomerCmbx.FocusedColor = System.Drawing.Color.Empty
        Me.CustomerCmbx.FocusedState.Parent = Me.CustomerCmbx
        Me.CustomerCmbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CustomerCmbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CustomerCmbx.FormattingEnabled = True
        Me.CustomerCmbx.HoverState.Parent = Me.CustomerCmbx
        Me.CustomerCmbx.ItemHeight = 30
        Me.CustomerCmbx.ItemsAppearance.Parent = Me.CustomerCmbx
        Me.CustomerCmbx.Location = New System.Drawing.Point(164, 96)
        Me.CustomerCmbx.Name = "CustomerCmbx"
        Me.CustomerCmbx.ShadowDecoration.Parent = Me.CustomerCmbx
        Me.CustomerCmbx.Size = New System.Drawing.Size(413, 36)
        Me.CustomerCmbx.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Car Model:"
        '
        'CarModelCmbx
        '
        Me.CarModelCmbx.BackColor = System.Drawing.Color.Transparent
        Me.CarModelCmbx.BorderRadius = 5
        Me.CarModelCmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.CarModelCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CarModelCmbx.FocusedColor = System.Drawing.Color.Empty
        Me.CarModelCmbx.FocusedState.Parent = Me.CarModelCmbx
        Me.CarModelCmbx.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.CarModelCmbx.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.CarModelCmbx.FormattingEnabled = True
        Me.CarModelCmbx.HoverState.Parent = Me.CarModelCmbx
        Me.CarModelCmbx.ItemHeight = 30
        Me.CarModelCmbx.ItemsAppearance.Parent = Me.CarModelCmbx
        Me.CarModelCmbx.Location = New System.Drawing.Point(164, 165)
        Me.CarModelCmbx.Name = "CarModelCmbx"
        Me.CarModelCmbx.ShadowDecoration.Parent = Me.CarModelCmbx
        Me.CarModelCmbx.Size = New System.Drawing.Size(413, 36)
        Me.CarModelCmbx.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rent Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Return Date:"
        '
        'TotalCostTxtbx
        '
        Me.TotalCostTxtbx.BorderRadius = 5
        Me.TotalCostTxtbx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TotalCostTxtbx.DefaultText = ""
        Me.TotalCostTxtbx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TotalCostTxtbx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TotalCostTxtbx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalCostTxtbx.DisabledState.Parent = Me.TotalCostTxtbx
        Me.TotalCostTxtbx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TotalCostTxtbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalCostTxtbx.FocusedState.Parent = Me.TotalCostTxtbx
        Me.TotalCostTxtbx.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCostTxtbx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TotalCostTxtbx.HoverState.Parent = Me.TotalCostTxtbx
        Me.TotalCostTxtbx.Location = New System.Drawing.Point(164, 435)
        Me.TotalCostTxtbx.Margin = New System.Windows.Forms.Padding(4)
        Me.TotalCostTxtbx.Name = "TotalCostTxtbx"
        Me.TotalCostTxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TotalCostTxtbx.PlaceholderText = ""
        Me.TotalCostTxtbx.ReadOnly = True
        Me.TotalCostTxtbx.SelectedText = ""
        Me.TotalCostTxtbx.ShadowDecoration.Parent = Me.TotalCostTxtbx
        Me.TotalCostTxtbx.Size = New System.Drawing.Size(267, 44)
        Me.TotalCostTxtbx.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 453)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Cost:"
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.BorderRadius = 5
        Me.ConfirmBtn.CheckedState.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.CustomImages.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.FillColor = System.Drawing.SystemColors.GrayText
        Me.ConfirmBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ConfirmBtn.ForeColor = System.Drawing.Color.White
        Me.ConfirmBtn.HoverState.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.Location = New System.Drawing.Point(237, 664)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.ShadowDecoration.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.Size = New System.Drawing.Size(320, 45)
        Me.ConfirmBtn.TabIndex = 11
        Me.ConfirmBtn.Text = "Confirm Transaction"
        '
        'ReturnDate
        '
        Me.ReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturnDate.Location = New System.Drawing.Point(164, 285)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(267, 24)
        Me.ReturnDate.TabIndex = 12
        '
        'RentDate
        '
        Me.RentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RentDate.Location = New System.Drawing.Point(164, 230)
        Me.RentDate.Name = "RentDate"
        Me.RentDate.Size = New System.Drawing.Size(267, 24)
        Me.RentDate.TabIndex = 13
        '
        'RentTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 771)
        Me.Controls.Add(Me.RentDate)
        Me.Controls.Add(Me.ReturnDate)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TotalCostTxtbx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CarModelCmbx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerCmbx)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RentTransaction"
        Me.Text = "RentTransaction"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents CustomerCmbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CarModelCmbx As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TotalCostTxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ConfirmBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents RentDate As DateTimePicker
End Class
