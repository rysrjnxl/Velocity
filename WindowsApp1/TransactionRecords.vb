Imports MySql.Data.MySqlClient

Public Class TransactionRecords

    Private Sub TransactionRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)

        TransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        TransactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TransactionGrid.ReadOnly = True
        TransactionGrid.AllowUserToAddRows = False
        TransactionGrid.RowHeadersVisible = False
        TransactionGrid.AllowUserToResizeColumns = False
        TransactionGrid.AllowUserToResizeRows = False

        LoadTransactions("")
    End Sub

    Private Sub LoadTransactions(searchTerm As String)
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()

                Dim query As String = "SELECT r.rental_id, c.name AS Customer, r.car_model AS Car, " &
                                      "r.rent_date AS 'Rent Date', r.return_date AS 'Return Date', " &
                                      "r.total_price AS 'Total Price', r.status AS Status " &
                                      "FROM rentals r " &
                                      "JOIN customers c ON r.customer_id = c.customer_id " &
                                      "WHERE r.status IN ('Returned', 'Cancelled')"

                If Not String.IsNullOrEmpty(searchTerm) Then
                    query &= " AND (c.name LIKE @search OR r.car_model LIKE @search)"
                End If

                query &= " ORDER BY r.rental_id DESC"

                Dim da As New MySqlDataAdapter(query, conn)
                If Not String.IsNullOrEmpty(searchTerm) Then
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                End If

                Dim dt As New DataTable()
                da.Fill(dt)

                TransactionGrid.DataSource = dt

                If TransactionGrid.Columns("rental_id") IsNot Nothing Then
                    TransactionGrid.Columns("rental_id").Visible = False
                End If

                If TransactionGrid.Columns("Total Price") IsNot Nothing Then
                    TransactionGrid.Columns("Total Price").DefaultCellStyle.Format = "N2"
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading transactions: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub TransactionGrid_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles TransactionGrid.CellFormatting
        If TransactionGrid.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then

            Dim statusValue As String = e.Value.ToString()

            If statusValue = "Cancelled" Then
                e.CellStyle.ForeColor = Color.OrangeRed
                e.CellStyle.SelectionForeColor = Color.OrangeRed

            ElseIf statusValue = "Returned" Then
                e.CellStyle.ForeColor = Color.Blue
                e.CellStyle.SelectionForeColor = Color.Blue
            End If
        End If
    End Sub

    Private Sub SearchbarTxtBx_TextChanged(sender As Object, e As EventArgs) Handles SearchbarTxtBx.TextChanged
        LoadTransactions(SearchbarTxtBx.Text)
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        LoadTransactions("")
        SearchbarTxtBx.Clear()
    End Sub

    Private Sub TransactionRecords_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadTransactions(SearchbarTxtBx.Text)
    End Sub
End Class