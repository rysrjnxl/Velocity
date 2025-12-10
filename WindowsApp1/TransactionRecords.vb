Imports MySql.Data.MySqlClient

Public Class TransactionRecords

    Private Sub TransactionRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Apply Theme
        Theme.ApplyThemeToForm(Me)

        ' 2. Handle Resizing
        Me.ControlBox = False
        Dim parentForm As Main = CType(Me.MdiParent, Main)
        AddHandler parentForm.SidebarResized, AddressOf OnSidebarResized

        ' 3. Setup Grid
        TransactionGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        TransactionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        TransactionGrid.ReadOnly = True
        TransactionGrid.AllowUserToAddRows = False

        ' 4. Load Data
        LoadTransactions("")
    End Sub

    Private Sub LoadTransactions(searchTerm As String)
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()

                ' --- UPDATED QUERY: FILTER FOR 'Returned' OR 'Cancelled' ONLY ---
                Dim query As String = "SELECT r.rental_id, c.name AS Customer, r.car_model AS Car, " &
                                      "r.rent_date AS 'Rent Date', r.return_date AS 'Return Date', " &
                                      "r.total_price AS 'Total Price', r.status AS Status " &
                                      "FROM rentals r " &
                                      "JOIN customers c ON r.customer_id = c.customer_id " &
                                      "WHERE r.status IN ('Returned', 'Cancelled')"

                ' If searching, append AND condition
                If Not String.IsNullOrEmpty(searchTerm) Then
                    query &= " AND (c.name LIKE @search OR r.car_model LIKE @search)"
                End If

                ' Order by newest first
                query &= " ORDER BY r.rental_id DESC"

                Dim cmd As New MySqlCommand(query, conn)

                If Not String.IsNullOrEmpty(searchTerm) Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                End If

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                TransactionGrid.DataSource = dt

                ' Hide ID column
                If TransactionGrid.Columns("rental_id") IsNot Nothing Then
                    TransactionGrid.Columns("rental_id").Visible = False
                End If

                ' Format Currency
                If TransactionGrid.Columns("Total Price") IsNot Nothing Then
                    TransactionGrid.Columns("Total Price").DefaultCellStyle.Format = "N2"
                End If

                For Each row As DataGridViewRow In TransactionGrid.Rows
                    Dim status As String = row.Cells("Status").Value.ToString()

                    If status = "Cancelled" Then
                        row.DefaultCellStyle.ForeColor = Color.Red
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show("Error loading transactions: " & ex.Message)
            End Try
        End Using
    End Sub

    ' --- SEARCH FUNCTION ---
    Private Sub SearchbarTxtBx_TextChanged(sender As Object, e As EventArgs) Handles SearchbarTxtBx.TextChanged
        LoadTransactions(SearchbarTxtBx.Text)
    End Sub

    ' --- REFRESH ---
    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        LoadTransactions("")
        SearchbarTxtBx.Clear()
    End Sub

    ' --- AUTO REFRESH ON TAB SWITCH ---
    Private Sub TransactionRecords_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadTransactions(SearchbarTxtBx.Text)
    End Sub

    ' --- RESIZE HANDLER ---
    Private Sub OnSidebarResized(sidebarWidth As Integer)
        ' Logic to resize if necessary
    End Sub

End Class