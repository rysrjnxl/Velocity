Imports MySql.Data.MySqlClient

Public Class RentTransaction
    Public Property InitialCarSelection As String
    Private DailyRate As Decimal = 0

    Private Sub RentTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)
        LoadCustomers()
        LoadAvailableCars()

        RentDate.Value = DateTime.Now
        ReturnDate.Value = DateTime.Now.AddDays(1)

        If Not String.IsNullOrEmpty(InitialCarSelection) Then
            GetCarRate(InitialCarSelection)
            CalculatePrice()
        End If
    End Sub

    Private Sub LoadCustomers()
        Using connection As New MySqlConnection(ConnectDatabase)
            Try
                connection.Open()
                Dim da As New MySqlDataAdapter("SELECT customer_id, name FROM customers", connection)
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
        Using connection As New MySqlConnection(ConnectDatabase)
            connection.Open()
            Dim cmd As New MySqlCommand("SELECT car_model FROM cars WHERE status = 'Available'", connection)
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            Dim row As DataRow = dt.NewRow()
            row("car_model") = "-- Select Car --"
            dt.Rows.InsertAt(row, 0)

            If Not String.IsNullOrEmpty(InitialCarSelection) Then
                Dim rows = dt.Select("car_model = '" & InitialCarSelection & "'")
                If rows.Length = 0 Then
                    Dim newRow As DataRow = dt.NewRow()
                    newRow("car_model") = InitialCarSelection
                    dt.Rows.Add(newRow)
                End If
            End If

            CarModelCmbx.DataSource = dt
            CarModelCmbx.DisplayMember = "car_model"
            CarModelCmbx.ValueMember = "car_model"

            If Not String.IsNullOrEmpty(InitialCarSelection) Then
                CarModelCmbx.SelectedValue = InitialCarSelection
            Else
                CarModelCmbx.SelectedIndex = 0
            End If
        End Using
    End Sub

    Private Sub CarModelCmbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CarModelCmbx.SelectedIndexChanged
        If CarModelCmbx.SelectedValue Is Nothing OrElse CarModelCmbx.SelectedValue.ToString() = "-- Select Car --" Then
            DailyRate = 0
            TotalCostTxtbx.Text = "0.00"
            Exit Sub
        End If

        GetCarRate(CarModelCmbx.SelectedValue.ToString())
        CalculatePrice()
    End Sub

    Private Sub GetCarRate(modelName As String)
        Using connection As New MySqlConnection(ConnectDatabase)
            connection.Open()
            Dim cmd As New MySqlCommand("SELECT daily_rate FROM cars WHERE car_model = @model", connection)
            cmd.Parameters.AddWithValue("@model", modelName)

            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing Then
                DailyRate = Convert.ToDecimal(result)
            End If
        End Using
    End Sub

    Private Sub Date_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDate.ValueChanged, RentDate.ValueChanged
        CalculatePrice()
    End Sub
    Private Sub CustomerCmbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CustomerCmbx.SelectedIndexChanged
        CalculatePrice()
    End Sub
    Private Sub CalculatePrice()
        If TypeOf CustomerCmbx.SelectedValue Is DataRowView Or TypeOf CarModelCmbx.SelectedValue Is DataRowView Then
            Exit Sub
        End If
        If CustomerCmbx.SelectedValue Is Nothing OrElse Convert.ToInt32(CustomerCmbx.SelectedValue) = 0 Then
            TotalCostTxtbx.Text = "0.00"
            Exit Sub
        End If


        If CarModelCmbx.SelectedValue Is Nothing OrElse CarModelCmbx.SelectedValue.ToString() = "-- Select Car --" Then
            TotalCostTxtbx.Text = "0.00"
            Exit Sub
        End If

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
            If CustomerCmbx.SelectedValue Is Nothing OrElse Convert.ToInt32(CustomerCmbx.SelectedValue) = 0 Then
                MessageBox.Show("Please select a valid Customer.")
                Exit Sub
            End If

            If CarModelCmbx.SelectedValue Is Nothing OrElse CarModelCmbx.SelectedValue.ToString() = "-- Select Car --" Then
                MessageBox.Show("Please select a valid Car.")
                Exit Sub
            End If

            Dim customerID As Integer = Convert.ToInt32(CustomerCmbx.SelectedValue)
            Dim selectedCar As String = CarModelCmbx.SelectedValue.ToString()

            Dim totalCost As Decimal = Decimal.Parse(TotalCostTxtbx.Text)

            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()

                Dim sqlRent As String = "INSERT INTO rentals (customer_id, car_model, rent_date, return_date, total_price, status) " &
                                        "VALUES (@cid, @cmodel, @rdate, @retdate, @total, 'Active')"

                Using cmd As New MySqlCommand(sqlRent, conn)
                    cmd.Parameters.AddWithValue("@cid", customerID)
                    cmd.Parameters.AddWithValue("@cmodel", selectedCar)
                    cmd.Parameters.AddWithValue("@rdate", RentDate.Value.Date)
                    cmd.Parameters.AddWithValue("@retdate", ReturnDate.Value.Date)
                    cmd.Parameters.AddWithValue("@total", totalCost)
                    cmd.ExecuteNonQuery()
                End Using

                Dim sqlUpdate As String = "UPDATE cars SET status = 'Rented' WHERE car_model = @cmodel"
                Using cmdUpdate As New MySqlCommand(sqlUpdate, conn)
                    cmdUpdate.Parameters.AddWithValue("@cmodel", selectedCar)
                    cmdUpdate.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Rental Confirmed for " & CustomerCmbx.Text)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class