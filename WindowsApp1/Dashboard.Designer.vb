<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.DashboardPic_Panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ScorecardPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TotalCarsPanel = New System.Windows.Forms.Panel()
        Me.TotalCarsLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label = New System.Windows.Forms.Label()
        Me.AvailableCarsPanel = New System.Windows.Forms.Panel()
        Me.CarsAvailableLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RentedCarsPanel = New System.Windows.Forms.Panel()
        Me.RentedCarsLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MostRentedPanel = New System.Windows.Forms.Panel()
        Me.MostRentedCarLbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DashboardBGPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DashboardPic = New System.Windows.Forms.PictureBox()
        Me.ScorecardPanel.SuspendLayout()
        Me.TotalCarsPanel.SuspendLayout()
        Me.AvailableCarsPanel.SuspendLayout()
        Me.RentedCarsPanel.SuspendLayout()
        Me.MostRentedPanel.SuspendLayout()
        Me.DashboardBGPanel.SuspendLayout()
        CType(Me.DashboardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardPic_Panel
        '
        Me.DashboardPic_Panel.AutoSize = True
        Me.DashboardPic_Panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.DashboardPic_Panel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DashboardPic_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DashboardPic_Panel.Location = New System.Drawing.Point(0, 838)
        Me.DashboardPic_Panel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DashboardPic_Panel.Name = "DashboardPic_Panel"
        Me.DashboardPic_Panel.Size = New System.Drawing.Size(1361, 0)
        Me.DashboardPic_Panel.TabIndex = 8
        '
        'ScorecardPanel
        '
        Me.ScorecardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ScorecardPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ScorecardPanel.Controls.Add(Me.TotalCarsPanel)
        Me.ScorecardPanel.Controls.Add(Me.AvailableCarsPanel)
        Me.ScorecardPanel.Controls.Add(Me.RentedCarsPanel)
        Me.ScorecardPanel.Controls.Add(Me.MostRentedPanel)
        Me.ScorecardPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ScorecardPanel.Location = New System.Drawing.Point(0, 659)
        Me.ScorecardPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ScorecardPanel.Name = "ScorecardPanel"
        Me.ScorecardPanel.Size = New System.Drawing.Size(1361, 179)
        Me.ScorecardPanel.TabIndex = 9
        '
        'TotalCarsPanel
        '
        Me.TotalCarsPanel.BackColor = System.Drawing.Color.Transparent
        Me.TotalCarsPanel.Controls.Add(Me.TotalCarsLbl)
        Me.TotalCarsPanel.Controls.Add(Me.Label)
        Me.TotalCarsPanel.Location = New System.Drawing.Point(3, 4)
        Me.TotalCarsPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalCarsPanel.Name = "TotalCarsPanel"
        Me.TotalCarsPanel.Size = New System.Drawing.Size(326, 172)
        Me.TotalCarsPanel.TabIndex = 1
        '
        'TotalCarsLbl
        '
        Me.TotalCarsLbl.BackColor = System.Drawing.SystemColors.Control
        Me.TotalCarsLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalCarsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCarsLbl.Location = New System.Drawing.Point(0, 20)
        Me.TotalCarsLbl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalCarsLbl.Name = "TotalCarsLbl"
        Me.TotalCarsLbl.Size = New System.Drawing.Size(326, 152)
        Me.TotalCarsLbl.TabIndex = 1
        Me.TotalCarsLbl.Text = Nothing
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BackColor = System.Drawing.SystemColors.Control
        Me.Label.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label.Location = New System.Drawing.Point(0, 0)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(81, 20)
        Me.Label.TabIndex = 0
        Me.Label.Text = "Total Cars"
        '
        'AvailableCarsPanel
        '
        Me.AvailableCarsPanel.BackColor = System.Drawing.Color.Transparent
        Me.AvailableCarsPanel.Controls.Add(Me.CarsAvailableLbl)
        Me.AvailableCarsPanel.Controls.Add(Me.Label1)
        Me.AvailableCarsPanel.Location = New System.Drawing.Point(335, 4)
        Me.AvailableCarsPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AvailableCarsPanel.Name = "AvailableCarsPanel"
        Me.AvailableCarsPanel.Size = New System.Drawing.Size(324, 172)
        Me.AvailableCarsPanel.TabIndex = 0
        '
        'CarsAvailableLbl
        '
        Me.CarsAvailableLbl.BackColor = System.Drawing.SystemColors.Control
        Me.CarsAvailableLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarsAvailableLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarsAvailableLbl.Location = New System.Drawing.Point(0, 20)
        Me.CarsAvailableLbl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CarsAvailableLbl.Name = "CarsAvailableLbl"
        Me.CarsAvailableLbl.Size = New System.Drawing.Size(324, 152)
        Me.CarsAvailableLbl.TabIndex = 1
        Me.CarsAvailableLbl.Text = Nothing
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cars Available"
        '
        'RentedCarsPanel
        '
        Me.RentedCarsPanel.BackColor = System.Drawing.Color.Transparent
        Me.RentedCarsPanel.Controls.Add(Me.RentedCarsLbl)
        Me.RentedCarsPanel.Controls.Add(Me.Label2)
        Me.RentedCarsPanel.Location = New System.Drawing.Point(665, 4)
        Me.RentedCarsPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RentedCarsPanel.Name = "RentedCarsPanel"
        Me.RentedCarsPanel.Size = New System.Drawing.Size(330, 172)
        Me.RentedCarsPanel.TabIndex = 1
        '
        'RentedCarsLbl
        '
        Me.RentedCarsLbl.BackColor = System.Drawing.SystemColors.Control
        Me.RentedCarsLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentedCarsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentedCarsLbl.Location = New System.Drawing.Point(0, 20)
        Me.RentedCarsLbl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RentedCarsLbl.Name = "RentedCarsLbl"
        Me.RentedCarsLbl.Size = New System.Drawing.Size(330, 152)
        Me.RentedCarsLbl.TabIndex = 1
        Me.RentedCarsLbl.Text = Nothing
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rented Cars"
        '
        'MostRentedPanel
        '
        Me.MostRentedPanel.BackColor = System.Drawing.Color.Transparent
        Me.MostRentedPanel.Controls.Add(Me.MostRentedCarLbl)
        Me.MostRentedPanel.Controls.Add(Me.Label3)
        Me.MostRentedPanel.Location = New System.Drawing.Point(1001, 4)
        Me.MostRentedPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MostRentedPanel.Name = "MostRentedPanel"
        Me.MostRentedPanel.Size = New System.Drawing.Size(344, 172)
        Me.MostRentedPanel.TabIndex = 2
        '
        'MostRentedCarLbl
        '
        Me.MostRentedCarLbl.BackColor = System.Drawing.SystemColors.Control
        Me.MostRentedCarLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MostRentedCarLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostRentedCarLbl.Location = New System.Drawing.Point(0, 20)
        Me.MostRentedCarLbl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MostRentedCarLbl.Name = "MostRentedCarLbl"
        Me.MostRentedCarLbl.Size = New System.Drawing.Size(344, 152)
        Me.MostRentedCarLbl.TabIndex = 1
        Me.MostRentedCarLbl.Text = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Most Rented Car"
        '
        'DashboardBGPanel
        '
        Me.DashboardBGPanel.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DashboardBGPanel.Controls.Add(Me.DashboardPic)
        Me.DashboardBGPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DashboardBGPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashboardBGPanel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DashboardBGPanel.Name = "DashboardBGPanel"
        Me.DashboardBGPanel.Size = New System.Drawing.Size(1361, 659)
        Me.DashboardBGPanel.TabIndex = 10
        '
        'DashboardPic
        '
        Me.DashboardPic.BackColor = System.Drawing.Color.WhiteSmoke
        Me.DashboardPic.Image = CType(resources.GetObject("DashboardPic.Image"), System.Drawing.Image)
        Me.DashboardPic.Location = New System.Drawing.Point(3, 4)
        Me.DashboardPic.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DashboardPic.Name = "DashboardPic"
        Me.DashboardPic.Size = New System.Drawing.Size(1358, 658)
        Me.DashboardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DashboardPic.TabIndex = 0
        Me.DashboardPic.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1361, 838)
        Me.Controls.Add(Me.DashboardBGPanel)
        Me.Controls.Add(Me.ScorecardPanel)
        Me.Controls.Add(Me.DashboardPic_Panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashbard"
        Me.ScorecardPanel.ResumeLayout(False)
        Me.TotalCarsPanel.ResumeLayout(False)
        Me.TotalCarsPanel.PerformLayout()
        Me.AvailableCarsPanel.ResumeLayout(False)
        Me.AvailableCarsPanel.PerformLayout()
        Me.RentedCarsPanel.ResumeLayout(False)
        Me.RentedCarsPanel.PerformLayout()
        Me.MostRentedPanel.ResumeLayout(False)
        Me.MostRentedPanel.PerformLayout()
        Me.DashboardBGPanel.ResumeLayout(False)
        CType(Me.DashboardPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DashboardPic_Panel As FlowLayoutPanel
    Friend WithEvents ScorecardPanel As FlowLayoutPanel
    Friend WithEvents DashboardBGPanel As FlowLayoutPanel
    Friend WithEvents DashboardPic As PictureBox
    Friend WithEvents AvailableCarsPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TotalCarsPanel As Panel
    Friend WithEvents Label As Label
    Friend WithEvents TotalCarsLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents RentedCarsPanel As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents MostRentedPanel As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CarsAvailableLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents RentedCarsLbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents MostRentedCarLbl As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
