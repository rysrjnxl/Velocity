Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class ReturnCar
    Private SelectedRentalID As Integer = 0
    Private SelectedCarModel As String = ""
    Private SelectedCustomerName As String = ""
    Private OriginalDueDate As DateTime
    Private DailyRate As Decimal = 0
    Private BaseTotal As Decimal = 0

    Private FinalExtensionFee As Decimal = 0
    Private FinalLateFee As Decimal = 0
    Private FinalTotalAmount As Decimal = 0
    Private ExtensionDaysCount As Integer = 0
    Private LateDaysCount As Integer = 0

    Private WithEvents PrintDoc As New PrintDocument()

    Private Sub ReturnCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)

        ReturnCarGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ReturnCarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ReturnCarGrid.ReadOnly = True
        ReturnCarGrid.AllowUserToAddRows = False

        ExtensionCmbBx.Items.Clear()
        ExtensionCmbBx.Items.Add("0")
        ExtensionCmbBx.Items.Add("1")
        ExtensionCmbBx.Items.Add("2")
        ExtensionCmbBx.Items.Add("3")
        ExtensionCmbBx.SelectedIndex = 0

        ConfirmBtn.Enabled = False
        UpdateBtn.Enabled = False

        LoadActiveRentals()
    End Sub

    Private Sub LoadActiveRentals()
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                Dim query As String = "SELECT r.rental_id, c.name AS customer_name, r.car_model, " &
                                      "r.return_date AS due_date, r.total_price, car.daily_rate, " &
                                      "r.destination, " &
                                      "IF(r.baby_seat = 1, 'Yes', 'No') AS baby_seat_disp, " &
                                      "r.extended_days, " &
                                      "TRUNCATE(r.extended_days * (car.daily_rate * 1.2), 2) AS ext_fee_disp " &
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
                If ReturnCarGrid.Columns("customer_name") IsNot Nothing Then ReturnCarGrid.Columns("customer_name").HeaderText = "Customer"
                If ReturnCarGrid.Columns("car_model") IsNot Nothing Then ReturnCarGrid.Columns("car_model").HeaderText = "Car Model"
                If ReturnCarGrid.Columns("due_date") IsNot Nothing Then ReturnCarGrid.Columns("due_date").HeaderText = "Due Date"
                If ReturnCarGrid.Columns("total_price") IsNot Nothing Then
                    ReturnCarGrid.Columns("total_price").HeaderText = "Current Total"
                    ReturnCarGrid.Columns("total_price").DefaultCellStyle.Format = "N2"
                End If
                If ReturnCarGrid.Columns("destination") IsNot Nothing Then ReturnCarGrid.Columns("destination").HeaderText = "Destination"
                If ReturnCarGrid.Columns("baby_seat_disp") IsNot Nothing Then ReturnCarGrid.Columns("baby_seat_disp").HeaderText = "Baby Seat"
                If ReturnCarGrid.Columns("extended_days") IsNot Nothing Then ReturnCarGrid.Columns("extended_days").HeaderText = "Ext. Days"
                If ReturnCarGrid.Columns("ext_fee_disp") IsNot Nothing Then
                    ReturnCarGrid.Columns("ext_fee_disp").HeaderText = "Ext. Fee"
                    ReturnCarGrid.Columns("ext_fee_disp").DefaultCellStyle.Format = "N2"
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
            SelectedCustomerName = row.Cells("customer_name").Value.ToString()
            SelectedCarModel = row.Cells("car_model").Value.ToString()
            OriginalDueDate = Convert.ToDateTime(row.Cells("due_date").Value)
            BaseTotal = Convert.ToDecimal(row.Cells("total_price").Value)
            DailyRate = Convert.ToDecimal(row.Cells("daily_rate").Value)

            Dim prevExtensions As Integer = 0
            If Not IsDBNull(row.Cells("extended_days").Value) Then
                prevExtensions = Convert.ToInt32(row.Cells("extended_days").Value)
            End If

            ExtensionCmbBx.SelectedIndex = 0

            If prevExtensions > 0 Then
                ExtensionCmbBx.Enabled = False
                UpdateBtn.Enabled = False
                MessageBox.Show("This rental has already been extended once and cannot be extended again.", "Extension Limit", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ExtensionCmbBx.Enabled = True
                UpdateBtn.Enabled = True
            End If

            ConfirmBtn.Enabled = True

            CalculateFinalTotal()
        End If
    End Sub

    Private Sub ExtensionCmbBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExtensionCmbBx.SelectedIndexChanged
        CalculateFinalTotal()
    End Sub

    Private Sub CalculateFinalTotal()
        If SelectedRentalID = 0 Then Exit Sub

        ExtensionDaysCount = Convert.ToInt32(ExtensionCmbBx.SelectedItem)
        FinalExtensionFee = 0

        If ExtensionDaysCount > 0 Then
            Dim increasedRate As Decimal = DailyRate + (DailyRate * 0.2D)
            FinalExtensionFee = increasedRate * ExtensionDaysCount
        End If

        Dim effectiveDueDate As DateTime = OriginalDueDate.AddDays(ExtensionDaysCount)
        LateDaysCount = (DateTime.Now.Date - effectiveDueDate.Date).Days
        FinalLateFee = 0

        If LateDaysCount > 0 Then
            FinalLateFee = LateDaysCount * DailyRate
            LateFeetxtbx.Text = "Late Fee (" & LateDaysCount & " days): ₱" & FinalLateFee.ToString("N2")
            LateFeetxtbx.ForeColor = Color.Red
        Else
            LateFeetxtbx.Text = "Late Fee: ₱0.00"
            LateFeetxtbx.ForeColor = Color.Black
        End If

        FinalTotalAmount = BaseTotal + FinalExtensionFee + FinalLateFee
        Totaltxtbx.Text = "Final Total: ₱" & FinalTotalAmount.ToString("N2")
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If SelectedRentalID = 0 Then
            MessageBox.Show("Please select a rental transaction first.")
            Exit Sub
        End If

        If ExtensionDaysCount = 0 Then
            MessageBox.Show("Please select extension days to update.")
            Exit Sub
        End If

        Try
            Dim newBaseTotal As Decimal = BaseTotal + FinalExtensionFee

            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()
                Dim sqlUpdate As String = "UPDATE rentals SET return_date = DATE_ADD(return_date, INTERVAL @ext DAY), " &
                                          "total_price = @newPrice, " &
                                          "extended_days = extended_days + @ext " &
                                          "WHERE rental_id = @id"

                Using cmd As New MySqlCommand(sqlUpdate, conn)
                    cmd.Parameters.AddWithValue("@ext", ExtensionDaysCount)
                    cmd.Parameters.AddWithValue("@newPrice", newBaseTotal)
                    cmd.Parameters.AddWithValue("@id", SelectedRentalID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Rental Extended Successfully!")
            ResetForm()
            LoadActiveRentals()

        Catch ex As Exception
            MessageBox.Show("Error updating extension: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        If SelectedRentalID = 0 Then
            MessageBox.Show("Please select a rental transaction first.")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()

                Dim sqlRental As String = "UPDATE rentals SET status = 'Returned', total_price = @newPrice, " &
                                          "extended_days = extended_days + @ext " &
                                          "WHERE rental_id = @id"

                Using cmd As New MySqlCommand(sqlRental, conn)
                    cmd.Parameters.AddWithValue("@newPrice", FinalTotalAmount)
                    cmd.Parameters.AddWithValue("@ext", ExtensionDaysCount)
                    cmd.Parameters.AddWithValue("@id", SelectedRentalID)
                    cmd.ExecuteNonQuery()
                End Using

                Dim sqlCar As String = "UPDATE cars SET status = 'Available' WHERE car_model = @model"
                Using cmdCar As New MySqlCommand(sqlCar, conn)
                    cmdCar.Parameters.AddWithValue("@model", SelectedCarModel)
                    cmdCar.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Car Returned Successfully!" & vbCrLf & "Total Fee Paid: ₱" & FinalTotalAmount.ToString("N2"))

            ResetForm()
            LoadActiveRentals()

        Catch ex As Exception
            MessageBox.Show("Error processing return: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetForm()
        SelectedRentalID = 0
        LateFeetxtbx.Text = "Late Fee: ₱0.00"
        Totaltxtbx.Text = "Final Total: ₱0.00"
        ConfirmBtn.Enabled = False
        UpdateBtn.Enabled = False
        ReturnCarGrid.ClearSelection()
        ExtensionCmbBx.Enabled = True
        ExtensionCmbBx.SelectedIndex = 0
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        SelectedRentalID = 0
        LateFeetxtbx.Text = "Late Fee: ₱0.00"
        Totaltxtbx.Text = "Final Total: ₱0.00"
        ConfirmBtn.Enabled = False
        UpdateBtn.Enabled = False
        ReturnCarGrid.ClearSelection()
        ExtensionCmbBx.Enabled = True
        ExtensionCmbBx.SelectedIndex = 0
    End Sub

    Private Sub ReturnCar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadActiveRentals()
    End Sub

End Class