Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim parentForm As Main = CType(Me.MdiParent, Main)
        AddHandler parentForm.SidebarResized, AddressOf OnSidebarResized
    End Sub
    Private Sub OnSidebarResized(sidebarWidth As Integer)
        Me.Padding = New Padding(0, 0, 0, 0)
        Me.Width = Me.MdiParent.ClientSize.Width - sidebarWidth
    End Sub

    Private Sub LightModeBtn_Click(sender As Object, e As EventArgs) Handles LightModeBtn.Click
        If Theme.CurrentTheme = Theme.ThemeMode.Dark Then
            Theme.CurrentTheme = Theme.ThemeMode.Light
        End If
        Theme.ApplyToAllOpenForms()
    End Sub

    Private Sub DarkModeBtn_Click(sender As Object, e As EventArgs) Handles DarkModeBtn.Click
        If CurrentTheme = ThemeMode.Light Then
            CurrentTheme = ThemeMode.Dark
        End If

        Theme.ApplyToAllOpenForms()
    End Sub


End Class