Imports System.Reflection
Imports MySql.Data.MySqlClient

Public Class CarInventory
    Private CarPanelMap As New Dictionary(Of String, Panel)
    Private CarLabelMap As New Dictionary(Of String, Label)
    Private WithEvents StatusMenu As New ContextMenuStrip()
    Private Sub CarInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Theme.ApplyThemeToForm(Me)
        Me.ControlBox = False
        Dim parentForm As Main = CType(Me.MdiParent, Main)
        AddHandler parentForm.SidebarResized, AddressOf OnSidebarResized

        BufferPictureControls()

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

        CarLabelMap.Add("Vios 2024", Vios2024Status)
        CarLabelMap.Add("Vios 2023", Vios2023Status)
        CarLabelMap.Add("Innova 2025", Innova2025Status)
        CarLabelMap.Add("Innova 2022", Innova2022Status)
        CarLabelMap.Add("Corolla 2023", Corolla2023Status)
        CarLabelMap.Add("Corolla 2024", Corolla2024Status)
        CarLabelMap.Add("Fortuner 2025", Fortuner2025Status)
        CarLabelMap.Add("Fortuner 2023", Fortuner2023Status)
        CarLabelMap.Add("Hilux 2024", Hilux2024Status)
        CarLabelMap.Add("Hilux 2022", Hilux2022Status)

        InitializeContextMenu()
        AttachRightClickEvents()
        UpdateInventoryStatus()
    End Sub
    Private Sub OnSidebarResized(sidebarWidth As Integer)
        Me.Padding = New Padding(0, 0, 0, 0)
        Me.Width = Me.MdiParent.ClientSize.Width - sidebarWidth
    End Sub

    Private Sub InitializeContextMenu()
        StatusMenu.Items.Add("Available")
        StatusMenu.Items.Add("Under Maintenance")
    End Sub
    Private Sub AttachRightClickEvents()
        For Each pnl As Panel In CarPanelMap.Values
            pnl.ContextMenuStrip = StatusMenu

            For Each child As Control In pnl.Controls
                child.ContextMenuStrip = StatusMenu
            Next
        Next
    End Sub

    Private Sub StatusMenu_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusMenu.ItemClicked
        Dim menu As ContextMenuStrip = CType(sender, ContextMenuStrip)
        Dim sourceControl As Control = menu.SourceControl

        Dim targetPanel As Panel
        If TypeOf sourceControl Is Panel Then
            targetPanel = CType(sourceControl, Panel)
        Else
            targetPanel = CType(sourceControl.Parent, Panel)
        End If

        Dim selectedCar As String = ""
        For Each kvp As KeyValuePair(Of String, Panel) In CarPanelMap
            If kvp.Value Is targetPanel Then
                selectedCar = kvp.Key
                Exit For
            End If
        Next

        If selectedCar = "" Then Exit Sub

        Dim newStatus As String = ""
        If e.ClickedItem.Text = "Available" Then
            newStatus = "Available"
        ElseIf e.ClickedItem.Text = "Under Maintenance" Then
            newStatus = "Maintenance"
        End If

        UpdateCarStatus(selectedCar, newStatus)
    End Sub

    Private Sub UpdateCarStatus(carModel As String, newStatus As String)
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                If newStatus = "Maintenance" Then
                    Dim checkCmd As New MySqlCommand("SELECT status FROM cars WHERE car_model = @model", conn)
                    checkCmd.Parameters.AddWithValue("@model", carModel)
                    Dim currentStatus As String = checkCmd.ExecuteScalar().ToString()

                    If currentStatus = "Rented" Then
                        MessageBox.Show("Cannot put a Rented car under maintenance!", "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If

                Dim query As String = "UPDATE cars SET status = @status WHERE car_model = @model"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@status", newStatus)
                    cmd.Parameters.AddWithValue("@model", carModel)
                    cmd.ExecuteNonQuery()
                End Using

                UpdateInventoryStatus()

            Catch ex As Exception
                MessageBox.Show("Error updating status: " & ex.Message, "Error")
            End Try
        End Using
    End Sub
    Private Sub UpdateInventoryStatus()
        Using conn As New MySqlConnection(ConnectDatabase)
            Try
                conn.Open()
                Dim query As String = "SELECT c.car_model, " &
                                      "CASE " &
                                      "  WHEN c.status = 'Maintenance' THEN 'Maintenance' " &
                                      "  WHEN EXISTS ( " &
                                      "      SELECT 1 FROM rentals r " &
                                      "      WHERE r.car_model = c.car_model " &
                                      "      AND r.status = 'Active' " &
                                      "      AND r.rent_date <= CURDATE() " &
                                      "  ) THEN 'Rented' " &
                                      "  ELSE 'Available' " &
                                      "END AS real_status " &
                                      "FROM cars c"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        While reader.Read()
                            Dim dbModel As String = reader("car_model").ToString()
                            Dim dbStatus As String = reader("real_status").ToString()

                            If CarPanelMap.ContainsKey(dbModel) And CarLabelMap.ContainsKey(dbModel) Then
                                Dim pnl As Panel = CarPanelMap(dbModel)
                                Dim lbl As Label = CarLabelMap(dbModel)

                                lbl.Text = dbStatus.ToUpper()

                                If dbStatus = "Available" Then
                                    pnl.BackColor = Color.LightGreen
                                    lbl.ForeColor = Color.DarkGreen
                                ElseIf dbStatus = "Rented" Then
                                    pnl.BackColor = Color.Salmon
                                    lbl.ForeColor = Color.DarkRed
                                ElseIf dbStatus = "Maintenance" Then
                                    pnl.BackColor = Color.LightGray
                                    lbl.ForeColor = Color.DimGray
                                End If
                            End If
                        End While

                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading inventory: " & ex.Message, "Error")
            End Try
        End Using
    End Sub
    Private Sub BufferPictureControls()
        Dim carpic() As PictureBox = {CarPic2, CarPic1, CarPic3, CarPic4, CarPic5,
                                      CarPic10, Me.CarPic9, CarPic8, CarPic7, CarPic6}
        For Each cp As PictureBox In carpic
            Dim propertyInfo As PropertyInfo = GetType(Control).GetProperty("DoubleBuffered", BindingFlags.Instance Or BindingFlags.NonPublic)
            propertyInfo.SetValue(cp, True, Nothing)
        Next
    End Sub

    Private Sub CarInventory_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        UpdateInventoryStatus()
    End Sub

End Class