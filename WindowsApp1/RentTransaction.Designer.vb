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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RentTransaction))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
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
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DestinationTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.BabySitChkBx = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintContractBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(846, 59)
        Me.Panel1.TabIndex = 0
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(39, 33)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 2
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BorderRadius = 5
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(724, 10)
        Me.Guna2ControlBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(51, 36)
        Me.Guna2ControlBox2.TabIndex = 1
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BorderRadius = 5
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(782, 10)
        Me.Guna2ControlBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(51, 36)
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
        Me.CustomerCmbx.Location = New System.Drawing.Point(277, 156)
        Me.CustomerCmbx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CustomerCmbx.Name = "CustomerCmbx"
        Me.CustomerCmbx.ShadowDecoration.Parent = Me.CustomerCmbx
        Me.CustomerCmbx.Size = New System.Drawing.Size(464, 36)
        Me.CustomerCmbx.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
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
        Me.CarModelCmbx.Location = New System.Drawing.Point(277, 233)
        Me.CarModelCmbx.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CarModelCmbx.Name = "CarModelCmbx"
        Me.CarModelCmbx.ShadowDecoration.Parent = Me.CarModelCmbx
        Me.CarModelCmbx.Size = New System.Drawing.Size(464, 36)
        Me.CarModelCmbx.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 406)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Rent Date:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 479)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Return Date:"
        '
        'TotalCostTxtbx
        '
        Me.TotalCostTxtbx.BackColor = System.Drawing.Color.Transparent
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
        Me.TotalCostTxtbx.Location = New System.Drawing.Point(277, 654)
        Me.TotalCostTxtbx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TotalCostTxtbx.Name = "TotalCostTxtbx"
        Me.TotalCostTxtbx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TotalCostTxtbx.PlaceholderText = ""
        Me.TotalCostTxtbx.ReadOnly = True
        Me.TotalCostTxtbx.SelectedText = ""
        Me.TotalCostTxtbx.ShadowDecoration.Parent = Me.TotalCostTxtbx
        Me.TotalCostTxtbx.Size = New System.Drawing.Size(300, 55)
        Me.TotalCostTxtbx.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(57, 669)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Total Cost:"
        '
        'ConfirmBtn
        '
        Me.ConfirmBtn.BorderRadius = 5
        Me.ConfirmBtn.CheckedState.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.CustomImages.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.FillColor = System.Drawing.SystemColors.GrayText
        Me.ConfirmBtn.Font = New System.Drawing.Font("ROG Fonts", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmBtn.ForeColor = System.Drawing.Color.White
        Me.ConfirmBtn.HoverState.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.Location = New System.Drawing.Point(612, 834)
        Me.ConfirmBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ConfirmBtn.Name = "ConfirmBtn"
        Me.ConfirmBtn.ShadowDecoration.Parent = Me.ConfirmBtn
        Me.ConfirmBtn.Size = New System.Drawing.Size(198, 56)
        Me.ConfirmBtn.TabIndex = 11
        Me.ConfirmBtn.Text = "Confirm Transaction"
        '
        'ReturnDate
        '
        Me.ReturnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturnDate.Location = New System.Drawing.Point(277, 470)
        Me.ReturnDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(300, 28)
        Me.ReturnDate.TabIndex = 12
        '
        'RentDate
        '
        Me.RentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RentDate.Location = New System.Drawing.Point(277, 397)
        Me.RentDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RentDate.Name = "RentDate"
        Me.RentDate.Size = New System.Drawing.Size(300, 28)
        Me.RentDate.TabIndex = 13
        '
        'CancelBtn
        '
        Me.CancelBtn.BorderRadius = 5
        Me.CancelBtn.CheckedState.Parent = Me.CancelBtn
        Me.CancelBtn.CustomImages.Parent = Me.CancelBtn
        Me.CancelBtn.FillColor = System.Drawing.SystemColors.GrayText
        Me.CancelBtn.Font = New System.Drawing.Font("ROG Fonts", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelBtn.ForeColor = System.Drawing.Color.White
        Me.CancelBtn.HoverState.Parent = Me.CancelBtn
        Me.CancelBtn.Location = New System.Drawing.Point(38, 834)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.ShadowDecoration.Parent = Me.CancelBtn
        Me.CancelBtn.Size = New System.Drawing.Size(199, 56)
        Me.CancelBtn.TabIndex = 14
        Me.CancelBtn.Text = "Cancel Transaction"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(57, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Destination:"
        '
        'DestinationTxtBx
        '
        Me.DestinationTxtBx.BorderRadius = 5
        Me.DestinationTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DestinationTxtBx.DefaultText = ""
        Me.DestinationTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DestinationTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DestinationTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DestinationTxtBx.DisabledState.Parent = Me.DestinationTxtBx
        Me.DestinationTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DestinationTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DestinationTxtBx.FocusedState.Parent = Me.DestinationTxtBx
        Me.DestinationTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DestinationTxtBx.HoverState.Parent = Me.DestinationTxtBx
        Me.DestinationTxtBx.Location = New System.Drawing.Point(277, 313)
        Me.DestinationTxtBx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DestinationTxtBx.Name = "DestinationTxtBx"
        Me.DestinationTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DestinationTxtBx.PlaceholderText = ""
        Me.DestinationTxtBx.SelectedText = ""
        Me.DestinationTxtBx.ShadowDecoration.Parent = Me.DestinationTxtBx
        Me.DestinationTxtBx.Size = New System.Drawing.Size(464, 55)
        Me.DestinationTxtBx.TabIndex = 16
        '
        'BabySitChkBx
        '
        Me.BabySitChkBx.AutoSize = True
        Me.BabySitChkBx.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BabySitChkBx.Location = New System.Drawing.Point(277, 550)
        Me.BabySitChkBx.Name = "BabySitChkBx"
        Me.BabySitChkBx.Size = New System.Drawing.Size(245, 29)
        Me.BabySitChkBx.TabIndex = 17
        Me.BabySitChkBx.Text = "Baby/Child Seat (₱150)"
        Me.BabySitChkBx.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(57, 554)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 19)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Add-ons:"
        '
        'PrintContractBtn
        '
        Me.PrintContractBtn.BorderRadius = 5
        Me.PrintContractBtn.CheckedState.Parent = Me.PrintContractBtn
        Me.PrintContractBtn.CustomImages.Parent = Me.PrintContractBtn
        Me.PrintContractBtn.FillColor = System.Drawing.SystemColors.GrayText
        Me.PrintContractBtn.Font = New System.Drawing.Font("ROG Fonts", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrintContractBtn.ForeColor = System.Drawing.Color.White
        Me.PrintContractBtn.HoverState.Parent = Me.PrintContractBtn
        Me.PrintContractBtn.Location = New System.Drawing.Point(328, 834)
        Me.PrintContractBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PrintContractBtn.Name = "PrintContractBtn"
        Me.PrintContractBtn.ShadowDecoration.Parent = Me.PrintContractBtn
        Me.PrintContractBtn.Size = New System.Drawing.Size(199, 56)
        Me.PrintContractBtn.TabIndex = 19
        Me.PrintContractBtn.Text = "Print Contract"
        '
        'RentTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 964)
        Me.Controls.Add(Me.PrintContractBtn)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BabySitChkBx)
        Me.Controls.Add(Me.DestinationTxtBx)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CancelBtn)
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
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "RentTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RentTransaction"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DestinationTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BabySitChkBx As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PrintContractBtn As Guna.UI2.WinForms.Guna2Button
End Class
