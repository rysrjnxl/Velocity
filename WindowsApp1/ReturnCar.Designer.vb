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
        Me.ReturnDate = New System.Windows.Forms.DateTimePicker()
        Me.LateFeetxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Totaltxtbx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ConfirmBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CancelBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        CType(Me.ReturnCarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(478, 339)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 0
        '
        'ReturnCarGrid
        '
        Me.ReturnCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReturnCarGrid.Location = New System.Drawing.Point(162, 122)
        Me.ReturnCarGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReturnCarGrid.Name = "ReturnCarGrid"
        Me.ReturnCarGrid.RowHeadersWidth = 51
        Me.ReturnCarGrid.RowTemplate.Height = 24
        Me.ReturnCarGrid.Size = New System.Drawing.Size(1080, 429)
        Me.ReturnCarGrid.TabIndex = 1
        '
        'ReturnDate
        '
        Me.ReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReturnDate.Location = New System.Drawing.Point(162, 601)
        Me.ReturnDate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReturnDate.Name = "ReturnDate"
        Me.ReturnDate.Size = New System.Drawing.Size(224, 26)
        Me.ReturnDate.TabIndex = 2
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
        Me.LateFeetxtbx.Location = New System.Drawing.Point(622, 574)
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
        Me.Totaltxtbx.Location = New System.Drawing.Point(942, 574)
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
        Me.ConfirmBtn.Location = New System.Drawing.Point(830, 691)
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
        Me.CancelBtn.Location = New System.Drawing.Point(1040, 691)
        Me.CancelBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CancelBtn.Name = "CancelBtn"
        Me.CancelBtn.ShadowDecoration.Parent = Me.CancelBtn
        Me.CancelBtn.Size = New System.Drawing.Size(202, 56)
        Me.CancelBtn.TabIndex = 6
        Me.CancelBtn.Text = "Cancel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ROG Fonts", 7.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(159, 574)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 19)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Select Date Car is Returned:"
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
        'ReturnCar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CancelBtn)
        Me.Controls.Add(Me.ConfirmBtn)
        Me.Controls.Add(Me.Totaltxtbx)
        Me.Controls.Add(Me.LateFeetxtbx)
        Me.Controls.Add(Me.ReturnDate)
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
    Friend WithEvents ReturnDate As DateTimePicker
    Friend WithEvents LateFeetxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Totaltxtbx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ConfirmBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CancelBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label21 As Label
End Class
