Imports MySql.Data.MySqlClient

Public Class ReturnCar
    Private SelectedRentalID As Integer = 0
    Private SelectedCarModel As String = ""
    Private DueDate As DateTime
    Private DailyRate As Decimal = 0
    Private CurrentTotal As Decimal = 0

    Private Sub ReturnCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)

        ReturnCarGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ReturnCarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ReturnCarGrid.ReadOnly = True
        ReturnCarGrid.AllowUserToAddRows = False

        LoadActiveRentals()

    End Sub

    Private Sub LoadActiveRentals()
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                Dim query As String = "SELECT r.rental_id, c.name AS customer_name, r.car_model, " &
                                      "r.return_date AS due_date, r.total_price, car.daily_rate " &
                                      "FROM rentals r " &
                                      "JOIN customers c ON r.customer_id = c.customer_id " &
                                      "JOIN cars car ON r.car_model = car.car_model " &
                                      "WHERE r.status = 'Active'"

                Dim da As New MySqlDataAdapter(query, conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                ReturnCarGrid.DataSource = dt

                If ReturnCarGrid.Columns("rental_id") IsNot Nothing Then ReturnCarGrid.Columns("rental_id").Visible = False
                If ReturnCarGrid.Columns("daily_rate") IsNot Nothing Then ReturnCarGrid.Columns("daily_rate").Visible = False

                If ReturnCarGrid.Columns("customer_name") IsNot Nothing Then
                    ReturnCarGrid.Columns("customer_name").HeaderText = "Customer Name"
                End If
                If ReturnCarGrid.Columns("car_model") IsNot Nothing Then
                    ReturnCarGrid.Columns("car_model").HeaderText = "Car Model"
                End If
                If ReturnCarGrid.Columns("due_date") IsNot Nothing Then
                    ReturnCarGrid.Columns("due_date").HeaderText = "Due Date"
                End If
                If ReturnCarGrid.Columns("total_price") IsNot Nothing Then
                    ReturnCarGrid.Columns("total_price").HeaderText = "Current Total"
                    ReturnCarGrid.Columns("total_price").DefaultCellStyle.Format = "c2"
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading rentals: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ReturnCarGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReturnCarGrid.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = ReturnCarGrid.Rows(e.RowIndex)

            SelectedRentalID = Convert.ToInt32(row.Cells("rental_id").Value)
            SelectedCarModel = row.Cells("car_model").Value.ToString()
            DueDate = Convert.ToDateTime(row.Cells("due_date").Value)
            CurrentTotal = Convert.ToDecimal(row.Cells("total_price").Value)
            DailyRate = Convert.ToDecimal(row.Cells("daily_rate").Value)


            CalculateLateFee()
            ConfirmBtn.Enabled = True
        End If
    End Sub

    Private Sub ReturnDate_ValueChanged(sender As Object, e As EventArgs)
        CalculateLateFee()
    End Sub

    Private Sub CalculateLateFee()
        If SelectedRentalID = 0 Then Exit Sub

        Dim lateFee As Decimal = 0

        Dim finalTotal As Decimal = CurrentTotal + lateFee
        Totaltxtbx.Text = "Final Total: ₱" & finalTotal.ToString("N2")
    End Sub

    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        If SelectedRentalID = 0 Then
            MessageBox.Show("Please select a rental transaction first.")
            Exit Sub
        End If

        Try
            Dim finalTotal As Decimal = Decimal.Parse(Totaltxtbx.Text.Replace("Final Total: ₱", ""))

            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()

                Dim sqlRental As String = "UPDATE rentals SET status = 'Returned', total_price = @newPrice WHERE rental_id = @id"
                Using cmd As New MySqlCommand(sqlRental, conn)
                    cmd.Parameters.AddWithValue("@newPrice", finalTotal)
                    cmd.Parameters.AddWithValue("@id", SelectedRentalID)
                    cmd.ExecuteNonQuery()
                End Using

                Dim sqlCar As String = "UPDATE cars SET status = 'Available' WHERE car_model = @model"
                Using cmdCar As New MySqlCommand(sqlCar, conn)
                    cmdCar.Parameters.AddWithValue("@model", SelectedCarModel)
                    cmdCar.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Car Returned Successfully! Inventory Updated.")

            SelectedRentalID = 0
            LateFeetxtbx.Text = "Late Fee: ₱0.00"
            Totaltxtbx.Text = "Final Total: ₱0.00"
            ConfirmBtn.Enabled = False

            LoadActiveRentals()

        Catch ex As Exception
            MessageBox.Show("Error processing return: " & ex.Message)
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ReturnCar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadActiveRentals()
    End Sub

End Class