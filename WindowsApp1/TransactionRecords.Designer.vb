<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionRecords
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionRecords))
        Me.SearchbarTxtBx = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ReturnCarGrid = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ReturnCarGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchbarTxtBx
        '
        Me.SearchbarTxtBx.BorderRadius = 10
        Me.SearchbarTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchbarTxtBx.DefaultText = ""
        Me.SearchbarTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchbarTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchbarTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchbarTxtBx.DisabledState.Parent = Me.SearchbarTxtBx
        Me.SearchbarTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchbarTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchbarTxtBx.FocusedState.Parent = Me.SearchbarTxtBx
        Me.SearchbarTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchbarTxtBx.HoverState.Parent = Me.SearchbarTxtBx
        Me.SearchbarTxtBx.Location = New System.Drawing.Point(171, 123)
        Me.SearchbarTxtBx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SearchbarTxtBx.Name = "SearchbarTxtBx"
        Me.SearchbarTxtBx.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchbarTxtBx.PlaceholderText = ""
        Me.SearchbarTxtBx.SelectedText = ""
        Me.SearchbarTxtBx.ShadowDecoration.Parent = Me.SearchbarTxtBx
        Me.SearchbarTxtBx.Size = New System.Drawing.Size(344, 39)
        Me.SearchbarTxtBx.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label21.Font = New System.Drawing.Font("ROG Fonts", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(705, 53)
        Me.Label21.TabIndex = 16
        Me.Label21.Text = "Transaction Records"
        '
        'ReturnCarGrid
        '
        Me.ReturnCarGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReturnCarGrid.Location = New System.Drawing.Point(171, 182)
        Me.ReturnCarGrid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReturnCarGrid.Name = "ReturnCarGrid"
        Me.ReturnCarGrid.RowHeadersWidth = 51
        Me.ReturnCarGrid.RowTemplate.Height = 24
        Me.ReturnCarGrid.Size = New System.Drawing.Size(1080, 429)
        Me.ReturnCarGrid.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(487, 399)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 14
        '
        'TransactionRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 900)
        Me.Controls.Add(Me.SearchbarTxtBx)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.ReturnCarGrid)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TransactionRecords"
        Me.Text = "TransactionRecords"
        CType(Me.ReturnCarGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SearchbarTxtBx As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ReturnCarGrid As DataGridView
    Friend WithEvents Label1 As Label
End Class
