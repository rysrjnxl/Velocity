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
        Me.DashboardBGPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.DashboardPic = New System.Windows.Forms.PictureBox()
        Me.TotalCarsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.AvailableCarsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.RentedCarsPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.MostRentedPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TotalCarsLbl = New System.Windows.Forms.Label()
        Me.CarsAvailableLbl = New System.Windows.Forms.Label()
        Me.RentedCarsLbl = New System.Windows.Forms.Label()
        Me.MostRentedCarLbl = New System.Windows.Forms.Label()
        Me.ScorecardPanel.SuspendLayout()
        Me.DashboardBGPanel.SuspendLayout()
        CType(Me.DashboardPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TotalCarsPanel.SuspendLayout()
        Me.AvailableCarsPanel.SuspendLayout()
        Me.RentedCarsPanel.SuspendLayout()
        Me.MostRentedPanel.SuspendLayout()
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
        'TotalCarsPanel
        '
        Me.TotalCarsPanel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.TotalCarsPanel.Controls.Add(Me.Guna2HtmlLabel5)
        Me.TotalCarsPanel.Controls.Add(Me.TotalCarsLbl)
        Me.TotalCarsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.TotalCarsPanel.Location = New System.Drawing.Point(3, 3)
        Me.TotalCarsPanel.Name = "TotalCarsPanel"
        Me.TotalCarsPanel.Size = New System.Drawing.Size(331, 176)
        Me.TotalCarsPanel.TabIndex = 0
        '
        'AvailableCarsPanel
        '
        Me.AvailableCarsPanel.Controls.Add(Me.Guna2HtmlLabel2)
        Me.AvailableCarsPanel.Controls.Add(Me.CarsAvailableLbl)
        Me.AvailableCarsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.AvailableCarsPanel.Location = New System.Drawing.Point(340, 3)
        Me.AvailableCarsPanel.Name = "AvailableCarsPanel"
        Me.AvailableCarsPanel.Size = New System.Drawing.Size(331, 176)
        Me.AvailableCarsPanel.TabIndex = 1
        '
        'RentedCarsPanel
        '
        Me.RentedCarsPanel.Controls.Add(Me.Guna2HtmlLabel3)
        Me.RentedCarsPanel.Controls.Add(Me.RentedCarsLbl)
        Me.RentedCarsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.RentedCarsPanel.Location = New System.Drawing.Point(677, 3)
        Me.RentedCarsPanel.Name = "RentedCarsPanel"
        Me.RentedCarsPanel.Size = New System.Drawing.Size(331, 176)
        Me.RentedCarsPanel.TabIndex = 2
        '
        'MostRentedPanel
        '
        Me.MostRentedPanel.Controls.Add(Me.Guna2HtmlLabel4)
        Me.MostRentedPanel.Controls.Add(Me.MostRentedCarLbl)
        Me.MostRentedPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.MostRentedPanel.Location = New System.Drawing.Point(1014, 3)
        Me.MostRentedPanel.Name = "MostRentedPanel"
        Me.MostRentedPanel.Size = New System.Drawing.Size(331, 176)
        Me.MostRentedPanel.TabIndex = 2
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(198, 31)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Total Cars"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(262, 31)
        Me.Guna2HtmlLabel2.TabIndex = 0
        Me.Guna2HtmlLabel2.Text = "Available Cars"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("ROG Fonts", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(219, 31)
        Me.Guna2HtmlLabel3.TabIndex = 1
        Me.Guna2HtmlLabel3.Text = "Rented Cars"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("ROG Fonts", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(243, 26)
        Me.Guna2HtmlLabel4.TabIndex = 2
        Me.Guna2HtmlLabel4.Text = "Most Rented Car"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(3, 40)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(3, 2)
        Me.Guna2HtmlLabel5.TabIndex = 1
        '
        'TotalCarsLbl
        '
        Me.TotalCarsLbl.AutoSize = True
        Me.TotalCarsLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TotalCarsLbl.Font = New System.Drawing.Font("ROG Fonts", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCarsLbl.Location = New System.Drawing.Point(3, 45)
        Me.TotalCarsLbl.Name = "TotalCarsLbl"
        Me.TotalCarsLbl.Size = New System.Drawing.Size(198, 58)
        Me.TotalCarsLbl.TabIndex = 2
        '
        'CarsAvailableLbl
        '
        Me.CarsAvailableLbl.AutoSize = True
        Me.CarsAvailableLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarsAvailableLbl.Font = New System.Drawing.Font("ROG Fonts", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarsAvailableLbl.Location = New System.Drawing.Point(3, 37)
        Me.CarsAvailableLbl.Name = "CarsAvailableLbl"
        Me.CarsAvailableLbl.Size = New System.Drawing.Size(262, 58)
        Me.CarsAvailableLbl.TabIndex = 3
        '
        'RentedCarsLbl
        '
        Me.RentedCarsLbl.AutoSize = True
        Me.RentedCarsLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RentedCarsLbl.Font = New System.Drawing.Font("ROG Fonts", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RentedCarsLbl.Location = New System.Drawing.Point(3, 37)
        Me.RentedCarsLbl.Name = "RentedCarsLbl"
        Me.RentedCarsLbl.Size = New System.Drawing.Size(219, 58)
        Me.RentedCarsLbl.TabIndex = 4
        '
        'MostRentedCarLbl
        '
        Me.MostRentedCarLbl.AutoSize = True
        Me.MostRentedCarLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MostRentedCarLbl.Font = New System.Drawing.Font("ROG Fonts", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MostRentedCarLbl.Location = New System.Drawing.Point(3, 32)
        Me.MostRentedCarLbl.Name = "MostRentedCarLbl"
        Me.MostRentedCarLbl.Size = New System.Drawing.Size(243, 43)
        Me.MostRentedCarLbl.TabIndex = 4
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
        Me.DashboardBGPanel.ResumeLayout(False)
        CType(Me.DashboardPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TotalCarsPanel.ResumeLayout(False)
        Me.TotalCarsPanel.PerformLayout()
        Me.AvailableCarsPanel.ResumeLayout(False)
        Me.AvailableCarsPanel.PerformLayout()
        Me.RentedCarsPanel.ResumeLayout(False)
        Me.RentedCarsPanel.PerformLayout()
        Me.MostRentedPanel.ResumeLayout(False)
        Me.MostRentedPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DashboardPic_Panel As FlowLayoutPanel
    Friend WithEvents ScorecardPanel As FlowLayoutPanel
    Friend WithEvents DashboardBGPanel As FlowLayoutPanel
    Friend WithEvents DashboardPic As PictureBox
    Friend WithEvents TotalCarsPanel As FlowLayoutPanel
    Friend WithEvents AvailableCarsPanel As FlowLayoutPanel
    Friend WithEvents RentedCarsPanel As FlowLayoutPanel
    Friend WithEvents MostRentedPanel As FlowLayoutPanel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TotalCarsLbl As Label
    Friend WithEvents CarsAvailableLbl As Label
    Friend WithEvents RentedCarsLbl As Label
    Friend WithEvents MostRentedCarLbl As Label
End Class
