Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ControlBox = False
        Dim parentForm As Main = CType(Me.MdiParent, Main)
        AddHandler parentForm.SidebarResized, AddressOf OnSidebarResized
    End Sub
    Private Sub OnSidebarResized(sidebarWidth As Integer)
        Me.Padding = New Padding(0, 0, 0, 0)
        Me.Width = Me.MdiParent.ClientSize.Width - sidebarWidth
    End Sub

End Class