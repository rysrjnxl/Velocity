<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustomerRecords
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CustomerList = New System.Windows.Forms.DataGridView()
        Me.EmailTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ContactNumTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddressTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.NameTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddCustomerBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.SearchBarTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CustomerList)
        Me.Panel1.Controls.Add(Me.EmailTxtBx)
        Me.Panel1.Controls.Add(Me.ContactNumTxtBx)
        Me.Panel1.Controls.Add(Me.AddressTxtBx)
        Me.Panel1.Controls.Add(Me.NameTxtBx)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.AddCustomerBtn)
        Me.Panel1.Controls.Add(Me.UpdateBtn)
        Me.Panel1.Controls.Add(Me.SearchBarTxtBx)
        Me.Panel1.Controls.Add(Me.ClearBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1210, 670)
        Me.Panel1.TabIndex = 0
        '
        'CustomerList
        '
        Me.CustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CustomerList.Location = New System.Drawing.Point(153, 101)
        Me.CustomerList.Name = "CustomerList"
        Me.CustomerList.RowHeadersWidth = 51
        Me.CustomerList.RowTemplate.Height = 24
        Me.CustomerList.Size = New System.Drawing.Size(868, 360)
        Me.CustomerList.TabIndex = 12
        '
        'EmailTxtBx
        '
        Me.EmailTxtBx.BorderRadius = 5
        Me.EmailTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.EmailTxtBx.DefaultText = ""
        Me.EmailTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.EmailTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.EmailTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTxtBx.DisabledState.Parent = Me.EmailTxtBx
        Me.EmailTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.EmailTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTxtBx.FocusedState.Parent = Me.EmailTxtBx
        Me.EmailTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EmailTxtBx.HoverState.Parent = Me.EmailTxtBx
        Me.EmailTxtBx.Location = New System.Drawing.Point(754, 534)
        Me.EmailTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EmailTxtBx.Name = "EmailTxtBx"
        Me.EmailTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.EmailTxtBx.PlaceholderText = ""
        Me.EmailTxtBx.SelectedText = ""
        Me.EmailTxtBx.ShadowDecoration.Parent = Me.EmailTxtBx
        Me.EmailTxtBx.Size = New System.Drawing.Size(267, 44)
        Me.EmailTxtBx.TabIndex = 11
        '
        'ContactNumTxtBx
        '
        Me.ContactNumTxtBx.BorderRadius = 5
        Me.ContactNumTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContactNumTxtBx.DefaultText = ""
        Me.ContactNumTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ContactNumTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ContactNumTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactNumTxtBx.DisabledState.Parent = Me.ContactNumTxtBx
        Me.ContactNumTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactNumTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContactNumTxtBx.FocusedState.Parent = Me.ContactNumTxtBx
        Me.ContactNumTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContactNumTxtBx.HoverState.Parent = Me.ContactNumTxtBx
        Me.ContactNumTxtBx.Location = New System.Drawing.Point(754, 482)
        Me.ContactNumTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ContactNumTxtBx.Name = "ContactNumTxtBx"
        Me.ContactNumTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ContactNumTxtBx.PlaceholderText = ""
        Me.ContactNumTxtBx.SelectedText = ""
        Me.ContactNumTxtBx.ShadowDecoration.Parent = Me.ContactNumTxtBx
        Me.ContactNumTxtBx.Size = New System.Drawing.Size(267, 44)
        Me.ContactNumTxtBx.TabIndex = 10
        '
        'AddressTxtBx
        '
        Me.AddressTxtBx.BorderRadius = 5
        Me.AddressTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressTxtBx.DefaultText = ""
        Me.AddressTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddressTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddressTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTxtBx.DisabledState.Parent = Me.AddressTxtBx
        Me.AddressTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTxtBx.FocusedState.Parent = Me.AddressTxtBx
        Me.AddressTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTxtBx.HoverState.Parent = Me.AddressTxtBx
        Me.AddressTxtBx.Location = New System.Drawing.Point(260, 534)
        Me.AddressTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AddressTxtBx.Name = "AddressTxtBx"
        Me.AddressTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddressTxtBx.PlaceholderText = ""
        Me.AddressTxtBx.SelectedText = ""
        Me.AddressTxtBx.ShadowDecoration.Parent = Me.AddressTxtBx
        Me.AddressTxtBx.Size = New System.Drawing.Size(267, 44)
        Me.AddressTxtBx.TabIndex = 9
        '
        'NameTxtBx
        '
        Me.NameTxtBx.BorderRadius = 5
        Me.NameTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NameTxtBx.DefaultText = ""
        Me.NameTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NameTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NameTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxtBx.DisabledState.Parent = Me.NameTxtBx
        Me.NameTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NameTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxtBx.FocusedState.Parent = Me.NameTxtBx
        Me.NameTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NameTxtBx.HoverState.Parent = Me.NameTxtBx
        Me.NameTxtBx.Location = New System.Drawing.Point(260, 482)
        Me.NameTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NameTxtBx.Name = "NameTxtBx"
        Me.NameTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NameTxtBx.PlaceholderText = ""
        Me.NameTxtBx.SelectedText = ""
        Me.NameTxtBx.ShadowDecoration.Parent = Me.NameTxtBx
        Me.NameTxtBx.Size = New System.Drawing.Size(267, 44)
        Me.NameTxtBx.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(641, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(641, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Contact Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 544)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(150, 498)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name:"
        '
        'AddCustomerBtn
        '
        Me.AddCustomerBtn.Location = New System.Drawing.Point(691, 601)
        Me.AddCustomerBtn.Name = "AddCustomerBtn"
        Me.AddCustomerBtn.Size = New System.Drawing.Size(116, 32)
        Me.AddCustomerBtn.TabIndex = 3
        Me.AddCustomerBtn.Text = "Add Customer"
        Me.AddCustomerBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Location = New System.Drawing.Point(832, 601)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(87, 32)
        Me.UpdateBtn.TabIndex = 0
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'SearchBarTxtBx
        '
        Me.SearchBarTxtBx.BorderRadius = 20
        Me.SearchBarTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBarTxtBx.DefaultText = ""
        Me.SearchBarTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchBarTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchBarTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBarTxtBx.DisabledState.Parent = Me.SearchBarTxtBx
        Me.SearchBarTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBarTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBarTxtBx.FocusedState.Parent = Me.SearchBarTxtBx
        Me.SearchBarTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBarTxtBx.HoverState.Parent = Me.SearchBarTxtBx
        Me.SearchBarTxtBx.Location = New System.Drawing.Point(153, 46)
        Me.SearchBarTxtBx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchBarTxtBx.Name = "SearchBarTxtBx"
        Me.SearchBarTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBarTxtBx.PlaceholderText = ""
        Me.SearchBarTxtBx.SelectedText = ""
        Me.SearchBarTxtBx.ShadowDecoration.Parent = Me.SearchBarTxtBx
        Me.SearchBarTxtBx.Size = New System.Drawing.Size(347, 37)
        Me.SearchBarTxtBx.TabIndex = 2
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(934, 601)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(87, 32)
        Me.ClearBtn.TabIndex = 2
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'CustomerRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 670)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomerRecords"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomerRecords"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CustomerList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SearchBarTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents ClearBtn As Button
    Friend WithEvents AddCustomerBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents EmailTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ContactNumTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddressTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents NameTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CustomerList As DataGridView
End Class
