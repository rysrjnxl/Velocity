Imports MySql.Data.MySqlClient

Public Class ReturnCar
    ' Variables for calculation
    Private SelectedRentalID As Integer = 0
    Private SelectedCarModel As String = ""
    Private OriginalDueDate As DateTime
    Private DailyRate As Decimal = 0
    Private BaseTotal As Decimal = 0

    ' Fee Variables for Calculation
    Private FinalExtensionFee As Decimal = 0
    Private FinalLateFee As Decimal = 0
    Private FinalTotalAmount As Decimal = 0
    Private ExtensionDaysCount As Integer = 0
    Private LateDaysCount As Integer = 0

    Private Sub ReturnCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)

        ' 1. Setup Grid
        ReturnCarGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ReturnCarGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        ReturnCarGrid.ReadOnly = True
        ReturnCarGrid.AllowUserToAddRows = False
        ReturnCarGrid.RowHeadersVisible = False
        ReturnCarGrid.AllowUserToResizeColumns = False
        ReturnCarGrid.AllowUserToResizeRows = False

        ' 2. Setup Extension Dropdown
        ExtensionCmbBx.Items.Clear()
        ExtensionCmbBx.Items.Add("0")
        ExtensionCmbBx.Items.Add("1")
        ExtensionCmbBx.Items.Add("2")
        ExtensionCmbBx.Items.Add("3")
        ExtensionCmbBx.SelectedIndex = 0

        ' 3. Lock Buttons
        ConfirmBtn.Enabled = False
        UpdateBtn.Enabled = False

        LoadActiveRentals("")

    End Sub

    ' --- LOAD ACTIVE RENTALS (WITH STATUS & DATE) ---
    Private Sub LoadActiveRentals(Optional searchTerm As String = "")
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                ' UPDATED QUERY:
                ' 1. Added r.rent_date
                ' 2. Added Logic: IF rent_date > Today THEN 'Upcoming' ELSE 'Ongoing'
                Dim query As String = "SELECT r.rental_id, c.name AS customer_name, r.car_model, " &
                                      "r.rent_date, " &
                                      "r.return_date AS due_date, r.total_price, car.daily_rate, " &
                                      "r.destination, " &
                                      "IF(r.baby_seat = 1, 'Yes', 'No') AS baby_seat_disp, " &
                                      "r.extended_days, " &
                                      "IF(r.rent_date > CURDATE(), 'Upcoming', 'Ongoing') AS rent_status_disp " &
                                      "FROM rentals r " &
                                      "JOIN customers c ON r.customer_id = c.customer_id " &
                                      "JOIN cars car ON r.car_model = car.car_model " &
                                      "WHERE r.status = 'Active'"

                ' Add Search Filter
                If Not String.IsNullOrEmpty(searchTerm) Then
                    query &= " AND (c.name LIKE @search OR r.car_model LIKE @search)"
                End If

                Dim da As New MySqlDataAdapter(query, conn)

                If Not String.IsNullOrEmpty(searchTerm) Then
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                End If

                Dim dt As New DataTable()
                da.Fill(dt)

                ReturnCarGrid.DataSource = dt

                ' --- HIDE IDs ---
                If ReturnCarGrid.Columns("rental_id") IsNot Nothing Then ReturnCarGrid.Columns("rental_id").Visible = False
                If ReturnCarGrid.Columns("daily_rate") IsNot Nothing Then ReturnCarGrid.Columns("daily_rate").Visible = False

                ' --- RENAME HEADERS ---
                If ReturnCarGrid.Columns("customer_name") IsNot Nothing Then ReturnCarGrid.Columns("customer_name").HeaderText = "Customer"
                If ReturnCarGrid.Columns("car_model") IsNot Nothing Then ReturnCarGrid.Columns("car_model").HeaderText = "Car Model"

                ' NEW: Rent Date
                If ReturnCarGrid.Columns("rent_date") IsNot Nothing Then ReturnCarGrid.Columns("rent_date").HeaderText = "Rent Date"

                If ReturnCarGrid.Columns("due_date") IsNot Nothing Then ReturnCarGrid.Columns("due_date").HeaderText = "Due Date"
                If ReturnCarGrid.Columns("total_price") IsNot Nothing Then
                    ReturnCarGrid.Columns("total_price").HeaderText = "Base Total"
                    ReturnCarGrid.Columns("total_price").DefaultCellStyle.Format = "N2"
                End If
                If ReturnCarGrid.Columns("destination") IsNot Nothing Then ReturnCarGrid.Columns("destination").HeaderText = "Destination"
                If ReturnCarGrid.Columns("baby_seat_disp") IsNot Nothing Then ReturnCarGrid.Columns("baby_seat_disp").HeaderText = "Baby Seat"
                If ReturnCarGrid.Columns("extended_days") IsNot Nothing Then ReturnCarGrid.Columns("extended_days").HeaderText = "Ext. Days"

                ' NEW: Status Column
                If ReturnCarGrid.Columns("rent_status_disp") IsNot Nothing Then ReturnCarGrid.Columns("rent_status_disp").HeaderText = "Status"

                For Each row As DataGridViewRow In ReturnCarGrid.Rows
                    ' Get the status text
                    Dim status As String = row.Cells("rent_status_disp").Value.ToString()

                    ' Apply color ONLY to the "Status" cell
                    If status = "Overdue" Then
                        row.Cells("rent_status_disp").Style.ForeColor = Color.Red
                        row.Cells("rent_status_disp").Style.SelectionForeColor = Color.Red ' Keep red even when selected
                        row.Cells("rent_status_disp").Style.Font = New Font(ReturnCarGrid.Font, FontStyle.Bold)
                    ElseIf status = "Upcoming" Then
                        row.Cells("rent_status_disp").Style.ForeColor = Color.Blue
                        row.Cells("rent_status_disp").Style.SelectionForeColor = Color.Blue
                    ElseIf status = "Ongoing" Then
                        row.Cells("rent_status_disp").Style.ForeColor = Color.Green
                        row.Cells("rent_status_disp").Style.SelectionForeColor = Color.Green
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show("Error loading rentals: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- SEARCH EVENT ---
    Private Sub SearchbarTxtBx_TextChanged(sender As Object, e As EventArgs) Handles SearchbarTxtBx.TextChanged
        LoadActiveRentals(SearchbarTxtBx.Text)
    End Sub

    ' --- CELL CLICK: CALCULATE IMMEDIATELY ---
    Private Sub ReturnCarGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ReturnCarGrid.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = ReturnCarGrid.Rows(e.RowIndex)

            SelectedRentalID = Convert.ToInt32(row.Cells("rental_id").Value)
            SelectedCarModel = row.Cells("car_model").Value.ToString()
            OriginalDueDate = Convert.ToDateTime(row.Cells("due_date").Value)
            BaseTotal = Convert.ToDecimal(row.Cells("total_price").Value)
            DailyRate = Convert.ToDecimal(row.Cells("daily_rate").Value)

            ' Check if already extended
            Dim prevExtensions As Integer = 0
            If Not IsDBNull(row.Cells("extended_days").Value) Then
                prevExtensions = Convert.ToInt32(row.Cells("extended_days").Value)
            End If

            ExtensionCmbBx.SelectedIndex = 0

            ' Disable extension if limit reached
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

    ' --- EXTENSION CHANGED ---
    Private Sub ExtensionCmbBx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ExtensionCmbBx.SelectedIndexChanged
        CalculateFinalTotal()
    End Sub

    ' --- CALCULATION LOGIC ---
    Private Sub CalculateFinalTotal()
        If SelectedRentalID = 0 Then Exit Sub

        ' 1. Calculate Extension Fee
        ExtensionDaysCount = Convert.ToInt32(ExtensionCmbBx.SelectedItem)
        FinalExtensionFee = 0

        If ExtensionDaysCount > 0 Then
            Dim increasedRate As Decimal = DailyRate + (DailyRate * 0.2D)
            FinalExtensionFee = increasedRate * ExtensionDaysCount
        End If

        ' 2. Calculate Late Fee
        Dim effectiveDueDate As DateTime = OriginalDueDate.AddDays(ExtensionDaysCount)
        Dim daysLate As Integer = (DateTime.Now.Date - effectiveDueDate.Date).Days
        FinalLateFee = 0

        If daysLate > 0 Then
            FinalLateFee = LateDaysCount * DailyRate
            LateFeetxtbx.Text = "Late Fee (" & daysLate & " days): ₱" & FinalLateFee.ToString("N2")
            LateFeetxtbx.ForeColor = Color.Red
        Else
            LateFeetxtbx.Text = "Late Fee: ₱0.00"
            LateFeetxtbx.ForeColor = Color.Black
        End If

        ' 3. Total
        FinalTotalAmount = BaseTotal + FinalExtensionFee + FinalLateFee
        Totaltxtbx.Text = "Final Total: ₱" & FinalTotalAmount.ToString("N2")
    End Sub

    ' --- BUTTON: UPDATE EXTENSION ---
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
            LoadActiveRentals("")

        Catch ex As Exception
            MessageBox.Show("Error updating extension: " & ex.Message)
        End Try
    End Sub

    ' --- BUTTON: CONFIRM RETURN ---
    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        If SelectedRentalID = 0 Then
            MessageBox.Show("Please select a rental transaction first.")
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()

                ' 1. Close Rental
                Dim sqlRental As String = "UPDATE rentals SET status = 'Returned', total_price = @newPrice, extended_days = @ext WHERE rental_id = @id"
                Using cmd As New MySqlCommand(sqlRental, conn)
                    cmd.Parameters.AddWithValue("@newPrice", FinalTotalAmount)
                    cmd.Parameters.AddWithValue("@ext", ExtensionDaysCount)
                    cmd.Parameters.AddWithValue("@id", SelectedRentalID)
                    cmd.ExecuteNonQuery()
                End Using

                ' 2. Free up Car
                Dim sqlCar As String = "UPDATE cars SET status = 'Available' WHERE car_model = @model"
                Using cmdCar As New MySqlCommand(sqlCar, conn)
                    cmdCar.Parameters.AddWithValue("@model", SelectedCarModel)
                    cmdCar.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Car Returned Successfully!" & vbCrLf & "Total Fee Paid: ₱" & FinalTotalAmount.ToString("N2"))

            ResetForm()
            LoadActiveRentals("")

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
        ExtensionCmbBx.SelectedIndex = 0
        SearchbarTxtBx.Clear()
        ExtensionCmbBx.Enabled = True
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub ReturnCar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadActiveRentals("")
    End Sub

End Class