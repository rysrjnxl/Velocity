Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class Dashboard

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)
        LoadDashboardStats()

        Me.ControlBox = False

        Dim parentForm As Main = CType(Me.MdiParent, Main)
        AddHandler parentForm.SidebarResized, AddressOf OnSidebarResized
    End Sub
    Private Sub OnSidebarResized(sidebarWidth As Integer)
        Dim newWidth As Integer = Me.MdiParent.ClientSize.Width - sidebarWidth
        Me.Width = newWidth

        DashboardBGPanel.Width = newWidth
        DashboardPic.Width = newWidth - 6

        ScorecardPanel.Width = newWidth

        Dim cardWidth As Integer = (newWidth - 30) \ 4

        TotalCarsPanel.Width = cardWidth
        AvailableCarsPanel.Width = cardWidth
        RentedCarsPanel.Width = cardWidth
        MostRentedPanel.Width = cardWidth
    End Sub

    Private Sub Dashboard_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadDashboardStats()
    End Sub

    Private Sub LoadDashboardStats()
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()

                Dim cmdTotal As New MySqlCommand("SELECT COUNT(*) FROM cars", conn)
                Dim total As Integer = Convert.ToInt32(cmdTotal.ExecuteScalar())
                TotalCarsLbl.Text = total.ToString()

                Dim cmdAvail As New MySqlCommand("SELECT COUNT(*) FROM cars WHERE status = 'Available'", conn)
                Dim avail As Integer = Convert.ToInt32(cmdAvail.ExecuteScalar())
                CarsAvailableLbl.Text = avail.ToString()

                Dim cmdRented As New MySqlCommand("SELECT COUNT(*) FROM cars WHERE status = 'Rented'", conn)
                Dim rented As Integer = Convert.ToInt32(cmdRented.ExecuteScalar())
                RentedCarsLbl.Text = rented.ToString()

                Dim sqlMost As String = "SELECT car_model FROM rentals GROUP BY car_model ORDER BY COUNT(*) DESC LIMIT 1"
                Dim cmdMost As New MySqlCommand(sqlMost, conn)
                Dim result = cmdMost.ExecuteScalar()

                If result IsNot Nothing Then
                    MostRentedCarLbl.Text = result.ToString()
                Else
                    MostRentedCarLbl.Text = "N/A"
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading dashboard stats: " & ex.Message)
            End Try
        End Using
    End Sub
End Class