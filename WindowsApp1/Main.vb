Public Class Main

    Dim FormDashboard As Dashboard
    Dim FormCarInventory As CarInventory
    Dim FormCustomerRecords As CustomerRecords
    Dim FormRentCar As RentCar
    Dim FormReturnCar As ReturnCar
    Dim FormSettings As Settings
    Dim FormAbout As About
    Dim FormTransaction As TransactionRecords

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carinvBtn_Click(Nothing, Nothing)
        recordsBtn_Click(Nothing, Nothing)
        RentCarBtn_Click(Nothing, Nothing)
        ReturnCarBtn_Click(Nothing, Nothing)
        settingsBtn_Click(Nothing, Nothing)
        aboutBtn_Click(Nothing, Nothing)
        TransactionBtn_Click(Nothing, Nothing)
        dashboardBtn_Click(Nothing, Nothing)

    End Sub

    'Dim menuExpand As Boolean = False

    'Private Sub menuTransition_Tick(sender As Object, e As EventArgs) Handles menuTransition.Tick
    '    If menuExpand = False Then
    '        menuContainer.Height += 10
    '        If menuContainer.Height >= 250 Then
    '            menuTransition.Stop()
    '            menuExpand = True
    '        End If

    '    Else menuContainer.Height -= 10
    '        If menuContainer.Height <= 57 Then
    '            menuTransition.Stop()
    '            menuExpand = False
    '        End If
    '    End If
    'End Sub

    'Private Sub menuBtn_Click(sender As Object, e As EventArgs)
    '    menuTransition.Start()
    'End Sub

    Dim sidebarExpand As Boolean = False
    Public Event SidebarResized(ByVal sidebarWidth As Integer)

    Private Sub sidebarTransition_Tick(sender As Object, e As EventArgs) Handles sidebarTransition.Tick

        If sidebarExpand = False Then
            sidebarPanel.Width += 10

            If sidebarPanel.Width >= 200 Then
                sidebarExpand = True
                sidebarTransition.Stop()
                pnDashboard.Width = sidebarPanel.Width
                pnAbout.Width = sidebarPanel.Width
                pnSidebar.Width = sidebarPanel.Width
                pnLogout.Width = sidebarPanel.Width
                pnSettings.Width = sidebarPanel.Width
                RaiseEvent SidebarResized(sidebarPanel.Width)
            End If
        Else
            sidebarPanel.Width -= 10
            If sidebarPanel.Width <= 60 Then
                sidebarExpand = False
                sidebarTransition.Stop()
                pnDashboard.Width = sidebarPanel.Width
                pnAbout.Width = sidebarPanel.Width
                pnSidebar.Width = sidebarPanel.Width
                pnLogout.Width = sidebarPanel.Width
                pnSettings.Width = sidebarPanel.Width
                RaiseEvent SidebarResized(sidebarPanel.Width)
            End If
        End If
    End Sub

    Private Sub sidebarBtn_Click(sender As Object, e As EventArgs) Handles sidebarBtn.Click
        sidebarTransition.Start()
    End Sub
    Private Sub closeBox_Click(sender As Object, e As EventArgs) Handles closeBox.Click
        Login.Close()
    End Sub

    Private Sub dashboardBtn_Click(sender As Object, e As EventArgs) Handles dashboardBtn.Click
        If FormDashboard Is Nothing Then
            FormDashboard = New Dashboard()
            AddHandler FormDashboard.FormClosed, AddressOf FormDashboard_FormClosed
            FormDashboard.MdiParent = Me
            FormDashboard.Dock = DockStyle.Fill
            FormDashboard.Show()
        Else
            FormDashboard.Activate()
        End If
    End Sub

    Private Sub FormDashboard_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormDashboard = Nothing
    End Sub

    Private Sub carinvBtn_Click(sender As Object, e As EventArgs) Handles carinvBtn.Click
        If FormCarInventory Is Nothing Then
            FormCarInventory = New CarInventory()
            AddHandler FormCarInventory.FormClosed, AddressOf FormCarInventory_FormClosed
            FormCarInventory.MdiParent = Me
            FormCarInventory.Dock = DockStyle.Fill
            FormCarInventory.Show()
        Else
            FormCarInventory.Activate()
        End If

    End Sub

    Private Sub FormCarInventory_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormCarInventory = Nothing
    End Sub

    Private Sub recordsBtn_Click(sender As Object, e As EventArgs) Handles recordsBtn.Click
        If FormCustomerRecords Is Nothing Then
            FormCustomerRecords = New CustomerRecords()
            AddHandler FormCustomerRecords.FormClosed, AddressOf FormCustomerRecords_FormClosed
            FormCustomerRecords.MdiParent = Me
            FormCustomerRecords.Dock = DockStyle.Fill
            FormCustomerRecords.Show()
        Else
            FormCustomerRecords.Activate()
        End If
    End Sub
    Private Sub FormCustomerRecords_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormCustomerRecords = Nothing
    End Sub

    Private Sub RentCarBtn_Click(sender As Object, e As EventArgs) Handles RentCarBtn.Click
        If FormRentCar Is Nothing Then
            FormRentCar = New RentCar()
            AddHandler FormRentCar.FormClosed, AddressOf FormRentCar_FormClosed
            FormRentCar.MdiParent = Me
            FormRentCar.Dock = DockStyle.Fill
            FormRentCar.Show()
        Else
            FormRentCar.Activate()
        End If

    End Sub
    Private Sub FormRentCar_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormRentCar = Nothing
    End Sub

    Private Sub ReturnCarBtn_Click(sender As Object, e As EventArgs) Handles ReturnCarBtn.Click
        If FormReturnCar Is Nothing Then
            FormReturnCar = New ReturnCar()
            AddHandler FormReturnCar.FormClosed, AddressOf FormReturnCar_FormClosed
            FormReturnCar.MdiParent = Me
            FormReturnCar.Dock = DockStyle.Fill
            FormReturnCar.Show()
        Else
            FormReturnCar.Activate()
        End If

    End Sub

    Private Sub FormReturnCar_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormReturnCar = Nothing
    End Sub

    Private Sub TransactionBtn_Click(sender As Object, e As EventArgs) Handles TransactionsBtn.Click
        If FormTransaction Is Nothing Then
            FormTransaction = New TransactionRecords()
            AddHandler FormTransaction.FormClosed, AddressOf FormTransaction_FormClosed
            FormTransaction.MdiParent = Me
            FormTransaction.Dock = DockStyle.Fill
            FormTransaction.Show()
        Else
            FormTransaction.Activate()
        End If
    End Sub
    Private Sub FormTransaction_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormTransaction = Nothing
    End Sub

    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        If FormSettings Is Nothing Then
            FormSettings = New Settings()
            AddHandler FormSettings.FormClosed, AddressOf FormSettings_FormClosed
            FormSettings.MdiParent = Me
            FormSettings.Dock = DockStyle.Fill
            FormSettings.Show()
        Else
            FormSettings.Activate()
        End If
    End Sub
    Private Sub FormSettings_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormSettings = Nothing
    End Sub
    Private Sub aboutBtn_Click(sender As Object, e As EventArgs) Handles aboutBtn.Click
        If FormAbout Is Nothing Then
            FormAbout = New About()
            AddHandler FormAbout.FormClosed, AddressOf FormAbout_FormClosed
            FormAbout.MdiParent = Me
            FormAbout.Dock = DockStyle.Fill
            FormAbout.Show()
        Else
            FormAbout.Activate()
        End If

    End Sub
    Private Sub FormAbout_FormClosed(sender As Object, e As FormClosedEventArgs)
        FormAbout = Nothing
    End Sub
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Login.Show()
            Me.Close()
        End If
    End Sub


End Class