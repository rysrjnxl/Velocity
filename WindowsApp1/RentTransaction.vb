Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class RentTransaction
    Public Property InitialCarSelection As String
    Private DailyRate As Decimal = 0

    Private WithEvents PrintDoc As New PrintDocument()

    Private Sub RentTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()

        RentDate.Value = DateTime.Now
        ReturnDate.Value = DateTime.Now.AddDays(1)

        LoadAvailableCars()

        If Not String.IsNullOrEmpty(InitialCarSelection) Then
            Dim dt As DataTable = CType(CarModelCmbx.DataSource, DataTable)
            Dim rows = dt.Select("car_model = '" & InitialCarSelection & "'")

            If rows.Length > 0 Then
                CarModelCmbx.SelectedValue = InitialCarSelection
            Else
                MessageBox.Show("The car you selected is not available for these dates.", "Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub

    Private Sub LoadCustomers()
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                Dim da As New MySqlDataAdapter("SELECT customer_id, name FROM customers", conn)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim row As DataRow = dt.NewRow()
                row("customer_id") = 0
                row("name") = "-- Select Customer --"
                dt.Rows.InsertAt(row, 0)

                CustomerCmbx.DataSource = dt
                CustomerCmbx.DisplayMember = "name"
                CustomerCmbx.ValueMember = "customer_id"
            Catch ex As Exception
                MessageBox.Show("Connection Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadAvailableCars()
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                Dim query As String = "SELECT car_model FROM cars " &
                                      "WHERE car_model NOT IN (" &
                                      "    SELECT car_model FROM rentals " &
                                      "    WHERE status = 'Active' " &
                                      "    AND (" &
                                      "        (@Start <= return_date AND @End >= rent_date)" &
                                      "    )" &
                                      ")"

                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@Start", RentDate.Value.Date)
                cmd.Parameters.AddWithValue("@End", ReturnDate.Value.Date)

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                Dim row As DataRow = dt.NewRow()
                row("car_model") = "-- Select Car --"
                dt.Rows.InsertAt(row, 0)

                If Not String.IsNullOrEmpty(InitialCarSelection) Then
                    Dim rows = dt.Select("car_model = '" & InitialCarSelection & "'")
                    If rows.Length = 0 Then
                    End If
                End If

                CarModelCmbx.DataSource = dt
                CarModelCmbx.DisplayMember = "car_model"
                CarModelCmbx.ValueMember = "car_model"

            Catch ex As Exception
                MessageBox.Show("Error loading cars: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub RentDate_ValueChanged(sender As Object, e As EventArgs) Handles RentDate.ValueChanged, ReturnDate.ValueChanged
        Dim days As Integer = (ReturnDate.Value.Date - RentDate.Value.Date).Days

        If days > 7 Then
            MessageBox.Show("Maximum rental period is 7 days.", "Duration Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ReturnDate.Value = RentDate.Value.AddDays(7)
            Exit Sub
        End If

        LoadAvailableCars()
        CalculatePrice()
    End Sub

    Private Sub CarModelCmbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarModelCmbx.SelectedIndexChanged
        If CarModelCmbx.SelectedValue IsNot Nothing AndAlso CarModelCmbx.SelectedValue.ToString() <> "-- Select Car --" Then
            GetCarRate(CarModelCmbx.SelectedValue.ToString())
        Else
            DailyRate = 0
        End If
        CalculatePrice()
    End Sub

    Private Sub GetCarRate(modelName As String)
        Using conn As New MySqlConnection(ConnectDatabase)
            conn.Open()
            Dim cmd As New MySqlCommand("SELECT daily_rate FROM cars WHERE car_model = @model", conn)
            cmd.Parameters.AddWithValue("@model", modelName)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                DailyRate = Convert.ToDecimal(result)
            End If
        End Using
    End Sub

    Private Sub CalculatePrice()
        If DailyRate = 0 Then
            TotalCostTxtbx.Text = "0.00"
            Exit Sub
        End If

        Dim days As Integer = (ReturnDate.Value.Date - RentDate.Value.Date).Days
        If days <= 0 Then days = 1

        Dim total As Decimal = days * DailyRate
        TotalCostTxtbx.Text = total.ToString("N2")
    End Sub

    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        Try
            ' Validation
            If Convert.ToInt32(CustomerCmbx.SelectedValue) = 0 Then
                MessageBox.Show("Please select a Customer.")
                Exit Sub
            End If
            If CarModelCmbx.SelectedValue.ToString() = "-- Select Car --" Then
                MessageBox.Show("Please select a Car.")
                Exit Sub
            End If
            If DestinationTxtBx.Text.Trim() = "" Then
                MessageBox.Show("Please enter a Destination.")
                Exit Sub
            End If

            Dim baseTotal As Decimal = Decimal.Parse(TotalCostTxtbx.Text)
            Dim babySeatCost As Decimal = 0

            If BabySitChkBx.Checked Then
                babySeatCost = 150.0
            End If

            Dim finalTotal As Decimal = baseTotal + babySeatCost

            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()

                Dim sqlRent As String = "INSERT INTO rentals (customer_id, car_model, rent_date, return_date, total_price, destination, baby_seat, status) " &
                                        "VALUES (@cid, @cmodel, @rdate, @retdate, @total, @dest, @baby, 'Active')"

                Using cmd As New MySqlCommand(sqlRent, conn)
                    cmd.Parameters.AddWithValue("@cid", CustomerCmbx.SelectedValue)
                    cmd.Parameters.AddWithValue("@cmodel", CarModelCmbx.SelectedValue)
                    cmd.Parameters.AddWithValue("@rdate", RentDate.Value.Date)
                    cmd.Parameters.AddWithValue("@retdate", ReturnDate.Value.Date)
                    cmd.Parameters.AddWithValue("@total", finalTotal)
                    cmd.Parameters.AddWithValue("@dest", DestinationTxtBx.Text)
                    cmd.Parameters.AddWithValue("@baby", If(BabySitChkBx.Checked, 1, 0))
                    cmd.ExecuteNonQuery()
                End Using

                ' UPDATE CAR STATUS (Only if rental starts today)
                If RentDate.Value.Date <= DateTime.Now.Date Then
                    Dim sqlUpdate As String = "UPDATE cars SET status = 'Rented' WHERE car_model = @cmodel"
                    Using cmdUpdate As New MySqlCommand(sqlUpdate, conn)
                        cmdUpdate.Parameters.AddWithValue("@cmodel", CarModelCmbx.SelectedValue)
                        cmdUpdate.ExecuteNonQuery()
                    End Using
                End If
            End Using
            MessageBox.Show("Rental Confirmed!")
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    ' --- 6. PRINT LAYOUT ---
    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim g As Graphics = e.Graphics
        Dim fontHeader As New Font("Arial", 18, FontStyle.Bold)
        Dim fontSub As New Font("Arial", 12, FontStyle.Bold)
        Dim fontBody As New Font("Arial", 11)
        Dim fontSmall As New Font("Arial", 9)

        Dim brush As Brush = Brushes.Black
        Dim y As Integer = 50
        Dim left As Integer = 50

        ' Header
        g.DrawString("VELOCITY CAR RENTAL", fontHeader, brush, left, y)
        y += 30
        g.DrawString("Rental Agreement / Contract", fontSub, brush, left, y)
        y += 40

        ' Transaction Info
        g.DrawString("Customer: " & CustomerCmbx.Text, fontBody, brush, left, y)
        y += 25
        g.DrawString("Car Model: " & CarModelCmbx.Text, fontBody, brush, left, y)
        y += 25
        g.DrawString("Destination: " & DestinationTxtBx.Text, fontBody, brush, left, y)
        y += 25
        g.DrawString("Period: " & RentDate.Value.ToShortDateString() & " to " & ReturnDate.Value.ToShortDateString(), fontBody, brush, left, y)
        y += 40

        ' Costs
        g.DrawString("CHARGES:", fontSub, brush, left, y)
        y += 25
        g.DrawString("Rental Cost: ₱" & TotalCostTxtbx.Text, fontBody, brush, left, y)
        y += 20
        If BabySitChkBx.Checked Then
            g.DrawString("Baby Seat: ₱150.00", fontBody, brush, left, y)
            y += 20
        End If
        g.DrawString("--------------------------------", fontBody, brush, left, y)
        y += 40

        ' Terms
        g.DrawString("TERMS AND CONDITIONS:", fontSub, brush, left, y)
        y += 25
        g.DrawString("1. GAS: Full Tank to Full Tank policy applies.", fontSmall, brush, left, y)
        y += 20
        g.DrawString("2. EXTENSION: Max 3 days extension allowed.", fontSmall, brush, left, y)
        y += 20
        g.DrawString("   (Surcharge: Regular Rate + 20% per day)", fontSmall, brush, left, y)
        y += 20
        g.DrawString("3. BAGGAGE: Max 50kg (Sedan) / 100kg (SUV).", fontSmall, brush, left, y)
        y += 60

        ' Signatures
        g.DrawString("_______________________", fontBody, brush, left, y)
        g.DrawString("_______________________", fontBody, brush, left + 350, y)
        y += 25
        g.DrawString("Renter Signature", fontSmall, brush, left, y)
        g.DrawString("Velocity Admin", fontSmall, brush, left + 350, y)
    End Sub

    Private Sub PrintContractBtn_Click(sender As Object, e As EventArgs) Handles PrintContractBtn.Click
        Dim ppd As New PrintPreviewDialog()
        ppd.Document = PrintDoc
        ppd.ShowDialog()
    End Sub
End Class