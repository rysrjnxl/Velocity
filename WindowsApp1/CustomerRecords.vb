Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class CustomerRecords
    Private SelectedCustomerId As Integer = 0

    Private Sub CustomerRecords_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim parentForm As Main = CType(Me.MdiParent, Main)
        AddHandler parentForm.SidebarResized, AddressOf OnSidebarResized

        CustomerList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        CustomerList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        CustomerList.ReadOnly = True
        CustomerList.AllowUserToAddRows = False
        CustomerList.RowHeadersVisible = False
        CustomerList.AllowUserToResizeColumns = False
        CustomerList.AllowUserToResizeRows = False

        Theme.ApplyThemeToForm(Me)

        LoadCustomers("")
        ClearTxtBx()
    End Sub

    Private Sub LoadCustomers(searchTerm As String)
        Using connection As New MySqlConnection(ConnectDatabase)
            Try
                connection.Open()
                Dim query As String = "SELECT customer_id, name, contact_number, email, address FROM customers"

                If Not String.IsNullOrEmpty(searchTerm) Then
                    query &= " WHERE name LIKE @search OR email LIKE @search OR contact_number LIKE @search"
                End If

                Dim cmd As New MySqlCommand(query, connection)
                If Not String.IsNullOrEmpty(searchTerm) Then
                    cmd.Parameters.AddWithValue("@search", "%" & searchTerm & "%")
                End If

                Dim da As New MySqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                CustomerList.DataSource = dt

                If CustomerList.Columns("customer_id") IsNot Nothing Then
                    CustomerList.Columns("customer_id").Visible = False
                End If

                If CustomerList.Columns("name") IsNot Nothing Then
                    CustomerList.Columns("name").HeaderText = "Customer Name"
                End If

                If CustomerList.Columns("contact_number") IsNot Nothing Then
                    CustomerList.Columns("contact_number").HeaderText = "Contact Number"
                End If

                If CustomerList.Columns("email") IsNot Nothing Then
                    CustomerList.Columns("email").HeaderText = "Email Address"
                End If

                If CustomerList.Columns("address") IsNot Nothing Then
                    CustomerList.Columns("address").HeaderText = "Home Address"
                End If

            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CustomerList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles CustomerList.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = CustomerList.Rows(e.RowIndex)

            SelectedCustomerId = Convert.ToInt32(row.Cells("customer_id").Value)

            NameTxtBx.Text = row.Cells("name").Value.ToString()
            ContactNumTxtBx.Text = row.Cells("contact_number").Value.ToString()
            EmailTxtBx.Text = row.Cells("email").Value.ToString()
            AddressTxtBx.Text = row.Cells("address").Value.ToString()

            AddCustomerBtn.Enabled = False
            UpdateBtn.Enabled = True
        End If
    End Sub

    Private Sub AddCustomerBtn_Click(sender As Object, e As EventArgs) Handles AddCustomerBtn.Click
        If NameTxtBx.Text = "" Then
            MessageBox.Show("Please enter a Name.")
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(ConnectDatabase)
                connection.Open()
                Dim query As String = "INSERT INTO customers (name, contact_number, email, address) VALUES (@n, @c, @e, @a)"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@n", NameTxtBx.Text)
                    cmd.Parameters.AddWithValue("@c", ContactNumTxtBx.Text)
                    cmd.Parameters.AddWithValue("@e", EmailTxtBx.Text)
                    cmd.Parameters.AddWithValue("@a", AddressTxtBx.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Customer Added Successfully!")
            LoadCustomers("")
            ClearTxtBx()

        Catch ex As Exception
            MessageBox.Show("Error Adding: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If SelectedCustomerId = 0 Then
            MessageBox.Show("Please select a customer from the list first.")
            Exit Sub
        End If

        Try
            Using connection As New MySqlConnection(ConnectDatabase)
                connection.Open()
                Dim query As String = "UPDATE customers SET name=@n, contact_number=@c, email=@e, address=@a WHERE customer_id=@id"

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@n", NameTxtBx.Text)
                    cmd.Parameters.AddWithValue("@c", ContactNumTxtBx.Text)
                    cmd.Parameters.AddWithValue("@e", EmailTxtBx.Text)
                    cmd.Parameters.AddWithValue("@a", AddressTxtBx.Text)
                    cmd.Parameters.AddWithValue("@id", SelectedCustomerId)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Customer Updated Successfully!")
            LoadCustomers("")
            ClearTxtBx()

        Catch ex As Exception
            MessageBox.Show("Error Updating: " & ex.Message)
        End Try
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ClearTxtBx()
    End Sub

    Private Sub ClearTxtBx()
        NameTxtBx.Clear()
        ContactNumTxtBx.Clear()
        EmailTxtBx.Clear()
        AddressTxtBx.Clear()
        SearchBarTxtBx.Clear()

        SelectedCustomerId = 0
        AddCustomerBtn.Enabled = True
        UpdateBtn.Enabled = False
        CustomerList.ClearSelection()
    End Sub

    Private Sub SearchBarTxtBx_TextChanged(sender As Object, e As EventArgs) Handles SearchBarTxtBx.TextChanged
        LoadCustomers(SearchBarTxtBx.Text)
    End Sub

    Private Sub OnSidebarResized(sidebarWidth As Integer)
        Panel1.Width = Me.ClientSize.Width - sidebarWidth
    End Sub

    Private Sub CustomerRecords_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        LoadCustomers("")
    End Sub

End Class