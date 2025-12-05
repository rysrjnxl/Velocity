Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class RentCar

    Private CarPanelMap As New Dictionary(Of String, Panel)
    Private CarButtonMap As New Dictionary(Of String, Button)
    Private Sub RentCar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)
        Me.ControlBox = False
        BufferPictureControls()

        Dim parentForm As Main = CType(Me.MdiParent, Main)
        AddHandler parentForm.SidebarResized, AddressOf OnSidebarResized

        CarPanelMap.Add("Vios 2024", Vios2024Panel)
        CarPanelMap.Add("Vios 2023", Vios2023Panel)
        CarPanelMap.Add("Innova 2025", Innova2025Panel)
        CarPanelMap.Add("Innova 2022", Innova2022Panel)
        CarPanelMap.Add("Corolla 2023", Corolla2023Panel)
        CarPanelMap.Add("Corolla 2024", Corolla2024Panel)
        CarPanelMap.Add("Fortuner 2025", Fortuner2025Panel)
        CarPanelMap.Add("Fortuner 2023", Fortuner2023Panel)
        CarPanelMap.Add("Hilux 2024", Hilux2024Panel)
        CarPanelMap.Add("Hilux 2022", Hilux2022Panel)

        CarButtonMap.Add("Vios 2024", Vios2024RentBtn)
        CarButtonMap.Add("Vios 2023", Vios2023RentBtn)
        CarButtonMap.Add("Innova 2025", Innova2025RentBtn)
        CarButtonMap.Add("Innova 2022", Innova2022RentBtn)
        CarButtonMap.Add("Corolla 2023", Corolla2023RentBtn)
        CarButtonMap.Add("Corolla 2024", Corolla2024RentBtn)
        CarButtonMap.Add("Fortuner 2025", Fortuner2025RentBtn)
        CarButtonMap.Add("Fortuner 2023", Fortuner2023RentBtn)
        CarButtonMap.Add("Hilux 2024", Hilux2024RentBtn)
        CarButtonMap.Add("Hilux 2022", Hilux2022RentBtn)

        AttachButtonEvents()
        UpdateCarAvailability()
    End Sub
    Private Sub AttachButtonEvents()
        For Each kvp As KeyValuePair(Of String, Button) In CarButtonMap
            Dim carName As String = kvp.Key
            Dim btn As Button = kvp.Value
            AddHandler btn.Click, Sub(s, args) OpenTransactionForm(carName)
        Next
    End Sub
    Private Sub OpenTransactionForm(carModel As String)
        Dim transForm As New RentTransaction()
        transForm.InitialCarSelection = carModel
        transForm.ShowDialog()

        UpdateCarAvailability()
    End Sub
    Private Sub UpdateCarAvailability()
        Dim query As String = "SELECT car_model, status FROM cars"
        Try
            Using connection As New MySqlConnection(ConnectDatabase)
                connection.Open()
                Using cmd As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        While reader.Read()
                            Dim dbModelName As String = reader("car_model").ToString()
                            Dim dbStatus As String = reader("status").ToString()

                            If CarPanelMap.ContainsKey(dbModelName) Then
                                Dim targetPanel As Panel = CarPanelMap(dbModelName)

                                If dbStatus = "Available" Then
                                    targetPanel.Visible = True
                                Else
                                    targetPanel.Visible = False
                                End If
                            End If
                        End While

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking availability: " & ex.Message)
        End Try
    End Sub
    Private Sub BufferPictureControls()
        Dim carpic() As PictureBox = {CarPic2, CarPic1, CarPic3, CarPic4, CarPic5,
                                      CarPic10, Me.CarPic9, CarPic8, CarPic7, CarPic6}
        For Each cp As PictureBox In carpic
            Dim propertyInfo As PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            propertyInfo.SetValue(cp, True, Nothing)
        Next
    End Sub
    Private Sub OnSidebarResized(sidebarWidth As Integer)
        CarFlowPanel.SuspendLayout()
        CarFlowPanel.Width = Me.ClientSize.Width - sidebarWidth
        CarFlowPanel.ResumeLayout()
    End Sub

    Private Sub RentCar_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateCarAvailability()
    End Sub

End Class