Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class RentTransaction
    Public Property InitialCarSelection As String
    Private DailyRate As Decimal = 0

    Private WithEvents PrintDoc As New PrintDocument()

    Private Sub RentTransaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)

        LoadCustomers()

        RentDate.Value = DateTime.Now
        ReturnDate.Value = DateTime.Now.AddDays(1)

        LoadAvailableCars()

        If Not String.IsNullOrEmpty(InitialCarSelection) Then
            Dim dt As DataTable = CType(CarModelCmbx.DataSource, DataTable)
            Dim rows = dt.Select("car_model = '" & InitialCarSelection & "'")

            If rows.Length > 0 Then
                CarModelCmbx.SelectedValue = InitialCarSelection
            End If
        End If
    End Sub

    Private Sub LoadAvailableCars()
        Dim currentSelection As String = ""
        If CarModelCmbx.SelectedValue IsNot Nothing Then
            currentSelection = CarModelCmbx.SelectedValue.ToString()
        End If

        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                Dim query As String = "SELECT car_model FROM cars " &
                                      "WHERE status <> 'Maintenance' " &
                                      "AND car_model NOT IN (" &
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

                CarModelCmbx.DataSource = dt
                CarModelCmbx.DisplayMember = "car_model"
                CarModelCmbx.ValueMember = "car_model"

                Dim foundRows = dt.Select("car_model = '" & currentSelection & "'")
                If foundRows.Length > 0 AndAlso currentSelection <> "-- Select Car --" Then
                    CarModelCmbx.SelectedValue = currentSelection
                Else
                    CarModelCmbx.SelectedIndex = 0
                    DailyRate = 0
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading cars: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub RentDate_ValueChanged(sender As Object, e As EventArgs)
        If RentDate.Value.Date < DateTime.Now.Date Then
            MessageBox.Show("Rent date cannot be in the past.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            RentDate.Value = DateTime.Now
            Return
        End If

        If ReturnDate.Value.Date < RentDate.Value.Date Then
            MessageBox.Show("Return date cannot be before rent date.", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ReturnDate.Value = RentDate.Value.AddDays(1)
            Return
        End If

        Dim days As Integer = (ReturnDate.Value.Date - RentDate.Value.Date).Days
        If days > 7 Then
            MessageBox.Show("Maximum rental period is 7 days.", "Duration Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ReturnDate.Value = RentDate.Value.AddDays(7)
            Return
        End If

        LoadAvailableCars()
        CalculatePrice()
    End Sub

    Private Sub CalculatePrice()
        If DailyRate = 0 OrElse CarModelCmbx.SelectedIndex = 0 Then
            TotalCostTxtbx.Text = "0.00"
            Exit Sub
        End If

        Dim days As Integer = (ReturnDate.Value.Date - RentDate.Value.Date).Days
        If days <= 0 Then days = 1

        Dim carCost As Decimal = days * DailyRate

        Dim extraCost As Decimal = 0
        If BabySitChkBx.Checked Then
            extraCost = 150.0
        End If

        Dim total As Decimal = carCost + extraCost
        TotalCostTxtbx.Text = total.ToString("N2")
    End Sub

    Private Sub BabySitChkBx_CheckedChanged(sender As Object, e As EventArgs)
        CalculatePrice()
    End Sub

    Private Sub CarModelCmbx_SelectedIndexChanged(sender As Object, e As EventArgs)
        If TypeOf CarModelCmbx.SelectedValue Is DataRowView OrElse CarModelCmbx.SelectedValue Is Nothing Then Exit Sub

        Dim selectedItem As String = CarModelCmbx.SelectedValue.ToString()

        If selectedItem <> "-- Select Car --" Then
            GetCarRate(selectedItem)
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

    Private Function ValidateTransaction() As Boolean
        If CustomerCmbx.SelectedValue Is Nothing OrElse Convert.ToInt32(CustomerCmbx.SelectedValue) = 0 Then
            MessageBox.Show("Please select a Customer.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If CarModelCmbx.SelectedValue Is Nothing OrElse CarModelCmbx.SelectedValue.ToString() = "-- Select Car --" Then
            MessageBox.Show("Please select a Car.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If DestinationTxtBx.Text.Trim() = "" Then
            MessageBox.Show("Please enter a Destination.", "Missing Field", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Sub PrintContractBtn_Click(sender As Object, e As EventArgs)
        If ValidateTransaction() = False Then Exit Sub

        Dim ppd As New PrintPreviewDialog()
        ppd.Document = PrintDoc
        ppd.ShowDialog()
    End Sub

    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs)
        If ValidateTransaction() = False Then Exit Sub

        Try
            Dim finalTotal As Decimal = Decimal.Parse(TotalCostTxtbx.Text)

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

                CustomerCmbx.DisplayMember = "name"
                CustomerCmbx.ValueMember = "customer_id"
                CustomerCmbx.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Connection Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        Dim g As Graphics = e.Graphics
        Dim rightMargin As Integer = e.MarginBounds.Right
        Dim leftMargin As Integer = e.MarginBounds.Left
        Dim topMargin As Integer = e.MarginBounds.Top
        Dim lineY As Integer = topMargin
        Dim printWidth As Integer = e.MarginBounds.Width
        Dim sectionSpacing As Integer = 15
        Dim paragraphSpacing As Integer = 5
        Dim titleFont As New Font("Segoe UI", 24, FontStyle.Bold)
        Dim headerFont As New Font("Segoe UI", 12, FontStyle.Bold)
        Dim contentFont As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim smallFont As New Font("Segoe UI", 8, FontStyle.Italic)
        Dim blackBrush As Brush = Brushes.Black
        Dim pen As New Pen(Color.Black, 1)
        Dim thickPen As New Pen(Color.Black, 2)

        Try
            Dim logo As Image = My.Resources.vlogob
            g.DrawImage(logo, leftMargin, lineY, 80, 75)
        Catch ex As Exception
        End Try

        Dim centerFormat As New StringFormat()
        centerFormat.Alignment = StringAlignment.Center
        Dim titleRect As New Rectangle(leftMargin, lineY, e.MarginBounds.Width, 50)
        g.DrawString("VELOCITY CAR RENTAL", titleFont, blackBrush, titleRect, centerFormat)

        lineY += 40
        Dim subTitleRect As New Rectangle(leftMargin, lineY, e.MarginBounds.Width, 30)
        g.DrawString("RENTAL AGREEMENT", headerFont, blackBrush, subTitleRect, centerFormat)

        lineY += 50
        g.DrawLine(thickPen, leftMargin, lineY, rightMargin, lineY)
        lineY += 20

        Dim col1X As Integer = leftMargin + 20
        Dim col2X As Integer = leftMargin + 350

        g.DrawString("Renter Name:", headerFont, blackBrush, col1X, lineY)
        g.DrawString(CustomerCmbx.Text, contentFont, blackBrush, col1X + 110, lineY + 2)

        g.DrawString("Vehicle:", headerFont, blackBrush, col2X, lineY)
        g.DrawString(CarModelCmbx.Text, contentFont, blackBrush, col2X + 100, lineY + 2)
        lineY += 30

        g.DrawString("Destination:", headerFont, blackBrush, col1X, lineY)
        g.DrawString(DestinationTxtBx.Text, contentFont, blackBrush, col1X + 110, lineY + 2)

        g.DrawString("Dates:", headerFont, blackBrush, col2X, lineY)
        Dim dateStr As String = RentDate.Value.ToString("MM/dd") & " - " & ReturnDate.Value.ToString("MM/dd")
        g.DrawString(dateStr, contentFont, blackBrush, col2X + 100, lineY + 2)
        lineY += 40

        g.DrawLine(pen, leftMargin, lineY, rightMargin, lineY)
        lineY += 20

        g.DrawString("PAYMENT SUMMARY", headerFont, blackBrush, leftMargin, lineY)
        lineY += 30
        g.DrawString("Total Cost:", contentFont, blackBrush, col1X, lineY)
        g.DrawString("₱ " & TotalCostTxtbx.Text, headerFont, blackBrush, rightMargin - 150, lineY)

        If BabySitChkBx.Checked Then
            lineY += 20
            g.DrawString("(Includes Baby Seat Fee: ₱150.00)", smallFont, blackBrush, rightMargin - 200, lineY)
        End If

        lineY += 50


        Dim finePrintFont As New Font("Arial", 8, FontStyle.Regular)
        Dim headerFineFont As New Font("Arial", 8, FontStyle.Bold)

        Dim colWidth As Integer = (e.MarginBounds.Width / 2) - 10
        Dim rightColX As Integer = e.MarginBounds.Left + colWidth + 20
        Dim startTermsY As Integer = lineY

        g.DrawString("1. GENERAL PROVISIONS", headerFineFont, blackBrush, leftMargin, lineY)
        lineY += 15
        Dim text1 As String = "Agreement between Owner and Renter. By taking possession, Renter agrees to terms."
        Dim rect1 As New RectangleF(leftMargin, lineY, colWidth, g.MeasureString(text1, finePrintFont, colWidth).Height)
        g.DrawString(text1, finePrintFont, blackBrush, rect1)
        lineY += rect1.Height + 10

        g.DrawString("2. ELIGIBILITY", headerFineFont, blackBrush, leftMargin, lineY)
        lineY += 15
        Dim text2 As String = "Must be 21+ years old, possess valid Driver’s License & Gov ID. International needs IDP."
        Dim rect2 As New RectangleF(leftMargin, lineY, colWidth, g.MeasureString(text2, finePrintFont, colWidth).Height)
        g.DrawString(text2, finePrintFont, blackBrush, rect2)
        lineY += rect2.Height + 10

        g.DrawString("3. RENTAL PERIOD", headerFineFont, blackBrush, leftMargin, lineY)
        lineY += 15
        Dim text3 As String = "Late Return: 1 hr grace period, then fees apply. Early Return: No refunds unless agreed."
        Dim rect3 As New RectangleF(leftMargin, lineY, colWidth, g.MeasureString(text3, finePrintFont, colWidth).Height)
        g.DrawString(text3, finePrintFont, blackBrush, rect3)
        lineY += rect3.Height + 10

        g.DrawString("4. FEES & DEPOSIT", headerFineFont, blackBrush, leftMargin, lineY)
        lineY += 15
        Dim text4 As String = "Payment due before release. Security Deposit required (Refundable upon safe return)."
        Dim rect4 As New RectangleF(leftMargin, lineY, colWidth, g.MeasureString(text4, finePrintFont, colWidth).Height)
        g.DrawString(text4, finePrintFont, blackBrush, rect4)
        lineY += rect4.Height + 10

        g.DrawString("5. CONDITION & FUEL", headerFineFont, blackBrush, leftMargin, lineY)
        lineY += 15
        Dim text5 As String = "Renter accepts vehicle condition. Fuel Policy: Full-to-Full. Refueling fees apply."
        Dim rect5 As New RectangleF(leftMargin, lineY, colWidth, g.MeasureString(text5, finePrintFont, colWidth).Height)
        g.DrawString(text5, finePrintFont, blackBrush, rect5)
        lineY += rect5.Height + 10


        Dim currentY As Integer = startTermsY

        g.DrawString("6. PROHIBITED USES", headerFineFont, blackBrush, rightColX, currentY)
        currentY += 15
        Dim text6 As String = "No illegal goods, towing, racing, drunk driving, or unauthorized drivers."
        Dim rect6 As New RectangleF(rightColX, currentY, colWidth, g.MeasureString(text6, finePrintFont, colWidth).Height)
        g.DrawString(text6, finePrintFont, blackBrush, rect6)
        currentY += rect6.Height + 10

        g.DrawString("7. ACCIDENTS/DAMAGE", headerFineFont, blackBrush, rightColX, currentY)
        currentY += 15
        Dim text7 As String = "Report immediately. Police report required. Renter liable for all damage/tires/glass."
        Dim rect7 As New RectangleF(rightColX, currentY, colWidth, g.MeasureString(text7, finePrintFont, colWidth).Height)
        g.DrawString(text7, finePrintFont, blackBrush, rect7)
        currentY += rect7.Height + 10

        g.DrawString("8. INDEMNIFICATION", headerFineFont, blackBrush, rightColX, currentY)
        currentY += 15
        Dim text8 As String = "Renter holds Owner harmless from all fines/claims arising from use of vehicle."
        Dim rect8 As New RectangleF(rightColX, currentY, colWidth, g.MeasureString(text8, finePrintFont, colWidth).Height)
        g.DrawString(text8, finePrintFont, blackBrush, rect8)
        currentY += rect8.Height + 10

        g.DrawString("9. GEOGRAPHIC LIMITS", headerFineFont, blackBrush, rightColX, currentY)
        currentY += 15
        Dim text9 As String = "Drive within agreed region only. No Inter-island (RORO) without written permit."
        Dim rect9 As New RectangleF(rightColX, currentY, colWidth, g.MeasureString(text9, finePrintFont, colWidth).Height)
        g.DrawString(text9, finePrintFont, blackBrush, rect9)
        currentY += rect9.Height + 10

        g.DrawString("10. GOVERNING LAW", headerFineFont, blackBrush, rightColX, currentY)
        currentY += 15
        Dim text10 As String = "Governed by laws of the Philippines. Disputes settled in local courts."
        Dim rect10 As New RectangleF(rightColX, currentY, colWidth, g.MeasureString(text10, finePrintFont, colWidth).Height)
        g.DrawString(text10, finePrintFont, blackBrush, rect10)
        currentY += rect10.Height + 10

        If currentY > lineY Then
            lineY = currentY
        End If

        lineY += 20

        lineY += 80
        g.DrawLine(pen, leftMargin, lineY, leftMargin + 250, lineY)
        g.DrawString("RENTER SIGNATURE", headerFont, blackBrush, leftMargin + 50, lineY + 5)

        g.DrawLine(pen, rightMargin - 250, lineY, rightMargin, lineY)
        g.DrawString("VELOCITY STAFF SIGNATURE", headerFont, blackBrush, rightMargin - 235, lineY + 5)
    End Sub
End Class