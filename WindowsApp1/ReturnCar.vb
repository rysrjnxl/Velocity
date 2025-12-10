Imports MySql.Data.MySqlClient

Public Class ReturnCar
    Private SelectedRentalID As Integer = 0
    Private SelectedCarModel As String = ""
    Private OriginalDueDate As DateTime
    Private DailyRate As Decimal = 0
    Private BaseTotal As Decimal = 0

    Private FinalExtensionFee As Decimal = 0
    Private FinalLateFee As Decimal = 0
    Private FinalTotalAmount As Decimal = 0
    Private ExtensionDaysCount As Integer = 0
    Private LateDaysCount As Integer = 0

    Private Sub ReturnCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)

        ReturnCarGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ReturnCarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ReturnCarGrid.ReadOnly = True
        ReturnCarGrid.AllowUserToAddRows = False
        ReturnCarGrid.RowHeadersVisible = False
        ReturnCarGrid.AllowUserToResizeColumns = False
        ReturnCarGrid.AllowUserToResizeRows = False

        ExtensionCmbBx.Items.Clear()
        ExtensionCmbBx.Items.Add("0")
        ExtensionCmbBx.Items.Add("1")
        ExtensionCmbBx.Items.Add("2")
        ExtensionCmbBx.Items.Add("3")
        ExtensionCmbBx.SelectedIndex = 0

        ConfirmBtn.Enabled = False
        UpdateBtn.Enabled = False

        Totaltxtbx.Enabled = False
        Totaltxtbx.DisabledState.FillColor = Color.White
        Totaltxtbx.DisabledState.ForeColor = Color.Black
        Totaltxtbx.DisabledState.BorderColor = Color.FromArgb(213, 218, 223)

        LateFeetxtbx.Enabled = False
        LateFeetxtbx.DisabledState.FillColor = Color.White
        LateFeetxtbx.DisabledState.ForeColor = Color.Red
        LateFeetxtbx.DisabledState.BorderColor = Color.FromArgb(213, 218, 223)
        LoadActiveRentals()
    End Sub

    Private Sub LoadActiveRentals()
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                Dim query As String = "SELECT r.rental_id, c.name AS customer_name, r.car_model, " &
                                      "r.rent_date, " &
                                      "r.return_date AS due_date, r.total_price, car.daily_rate, " &
                                      "r.destination, " &
                                      "IF(r.baby_seat = 1, 'Yes', 'No') AS baby_seat_disp, " &
                                      "r.extended_days, " &
                                      "CASE " &
                                      "  WHEN r.return_date < CURDATE() THEN 'Overdue' " &
                                      "  WHEN r.rent_date > CURDATE() THEN 'Upcoming' " &
                                      "  ELSE 'Ongoing' " &
                                      "END AS rent_status_disp " &
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
                If ReturnCarGrid.Columns("rent_date") IsNot Nothing Then ReturnCarGrid.Columns("rent_date").HeaderText = "Rent Date"
                If ReturnCarGrid.Columns("due_date") IsNot Nothing Then ReturnCarGrid.Columns("due_date").HeaderText = "Due Date"
                If ReturnCarGrid.Columns("total_price") IsNot Nothing Then
                    ReturnCarGrid.Columns("total_price").HeaderText = "Base Total"
                    ReturnCarGrid.Columns("total_price").DefaultCellStyle.Format = "N2"
                End If
                If ReturnCarGrid.Columns("destination") IsNot Nothing Then ReturnCarGrid.Columns("destination").HeaderText = "Destination"
                If ReturnCarGrid.Columns("baby_seat_disp") IsNot Nothing Then ReturnCarGrid.Columns("baby_seat_disp").HeaderText = "Baby Seat"
                If ReturnCarGrid.Columns("extended_days") IsNot Nothing Then ReturnCarGrid.Columns("extended_days").HeaderText = "Ext. Days"

                If ReturnCarGrid.Columns("rent_status_disp") IsNot Nothing Then
                    ReturnCarGrid.Columns("rent_status_disp").HeaderText = "Status"
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading rentals: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ReturnCarGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ReturnCarGrid.CellFormatting
        If ReturnCarGrid.Columns(e.ColumnIndex).Name = "rent_status_disp" AndAlso e.Value IsNot Nothing Then

            Dim statusValue As String = e.Value.ToString()
            If statusValue = "Overdue" Then
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.SelectionForeColor = Color.Red
            ElseIf statusValue = "Upcoming" Then
                e.CellStyle.ForeColor = Color.Blue
                e.CellStyle.SelectionForeColor = Color.Blue
            ElseIf statusValue = "Ongoing" Then
                e.CellStyle.ForeColor = Color.Green
                e.CellStyle.SelectionForeColor = Color.Green
            End If
        End If
    End Sub

    Private Sub ReturnCarGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReturnCarGrid.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = ReturnCarGrid.Rows(e.RowIndex)

            SelectedRentalID = Convert.ToInt32(row.Cells("rental_id").Value)
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
            MessageBox.Show("Please select extension days.")
            Exit Sub
        End If

        Try
            Dim newBaseTotal As Decimal = BaseTotal + FinalExtensionFee
            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()
                Dim sqlUpdate As String = "UPDATE rentals SET return_date = DATE_ADD(return_date, INTERVAL @ext DAY), " &
                                          "total_price = @newPrice, extended_days = extended_days + @ext " &
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
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        If SelectedRentalID = 0 Then
            MessageBox.Show("Select a transaction first.")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()
                Dim sqlRental As String = "UPDATE rentals SET status = 'Returned', total_price = @newPrice, extended_days = @ext WHERE rental_id = @id"
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

            MessageBox.Show("Car Returned Successfully!" & vbCrLf & "Total Fee: ₱" & FinalTotalAmount.ToString("N2"))
            ResetForm()
            LoadActiveRentals()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub ResetForm()
        SelectedRentalID = 0
        LateFeetxtbx.Text = "Late Fee: ₱0.00"
        Totaltxtbx.Text = "Final Total: ₱0.00"
        ConfirmBtn.Enabled = False
        UpdateBtn.Enabled = False
        ReturnCarGrid.ClearSelection()
        ExtensionCmbBx.SelectedIndex = 0
        ExtensionCmbBx.Enabled = True
    End Sub

    Private Sub ReturnCar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadActiveRentals()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ResetForm()
    End Sub
End Class