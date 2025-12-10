Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If UsernameTxtbx.Text = "" Or Passwordtxtbx.Text = "" Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As New MySqlConnection(ConnectDatabase)
                conn.Open()

                Dim query As String = "SELECT count(*) FROM useraccount WHERE username = @user AND password = @pass"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@user", UsernameTxtbx.Text)
                    cmd.Parameters.AddWithValue("@pass", Passwordtxtbx.Text)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        MessageBox.Show("Login Successful! Welcome to Velocity.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim dashboard As New Main()
                        dashboard.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Username or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub Passwordtxtbx_KeyDown(sender As Object, e As KeyEventArgs) Handles Passwordtxtbx.KeyDown
        If e.KeyCode = Keys.Enter Then
            loginBtn.PerformClick()
        End If
    End Sub

End Class