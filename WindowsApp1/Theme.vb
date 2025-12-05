Imports Guna.UI2.WinForms

Module Theme

    Public Enum ThemeMode
        Light
        Dark
    End Enum

    Public CurrentTheme As ThemeMode = ThemeMode.Light
    Public Sub ApplyThemeToForm(window As Form)
        If CurrentTheme = ThemeMode.Dark Then
            window.BackColor = Color.FromArgb(18, 21, 29)
            window.ForeColor = Color.White
        Else
            window.BackColor = Color.White
            window.ForeColor = Color.Black
        End If

        ApplyThemeToControls(window.Controls)
    End Sub

    Private Sub ApplyThemeToControls(controls As Control.ControlCollection)
        For Each c As Control In controls
            If TypeOf c Is Guna2Button Then Theme_GunaButton(DirectCast(c, Guna2Button))
            If TypeOf c Is Guna2TextBox Then Theme_GunaTextBox(DirectCast(c, Guna2TextBox))
            'If TypeOf c Is Guna2Panel Then Theme_GunaPanel(DirectCast(c, Guna2Panel))
            If TypeOf c Is Guna2ComboBox Then Theme_GunaCombo(DirectCast(c, Guna2ComboBox))
            If TypeOf c Is DataGridView Then DataGrid(DirectCast(c, DataGridView))

            If TypeOf c Is Label Then Theme_Label(DirectCast(c, Label))
            'If TypeOf c Is Panel Then Theme_Panel(DirectCast(c, Panel))
            If TypeOf c Is TextBox Then Theme_TextBox(DirectCast(c, TextBox))
            If TypeOf c Is Button Then Theme_Button(DirectCast(c, Button))
            If TypeOf c Is Guna2HtmlLabel Then Theme_GunaHtmlLabel(DirectCast(c, Guna2HtmlLabel))
            If TypeOf c Is FlowLayoutPanel Then Theme_FlowPanel(DirectCast(c, FlowLayoutPanel))

            If c.HasChildren Then ApplyThemeToControls(c.Controls)
        Next
    End Sub

    Private Sub Theme_GunaButton(btn As Guna2Button)
        If CurrentTheme = ThemeMode.Dark Then
            btn.FillColor = Color.FromArgb(60, 60, 60)
            btn.ForeColor = Color.White
        Else
            btn.FillColor = Color.WhiteSmoke
            btn.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Theme_GunaTextBox(tb As Guna2TextBox)
        If CurrentTheme = ThemeMode.Dark Then
            tb.FillColor = Color.FromArgb(18, 21, 29)
            tb.ForeColor = Color.White
            tb.PlaceholderForeColor = Color.Silver
        Else
            tb.FillColor = Color.White
            tb.ForeColor = Color.Black
            tb.PlaceholderForeColor = Color.Gray
        End If
    End Sub

    'Private Sub Theme_GunaPanel(p As Guna2Panel)
    '    If CurrentTheme = ThemeMode.Dark Then
    '        p.FillColor = Color.FromArgb(35, 35, 35)
    '    Else
    '        p.FillColor = Color.WhiteSmoke
    '    End If
    'End Sub

    Private Sub Theme_GunaCombo(cb As Guna2ComboBox)
        If CurrentTheme = ThemeMode.Dark Then
            cb.FillColor = Color.FromArgb(40, 40, 40)
            cb.ForeColor = Color.White
            cb.ItemsAppearance.ForeColor = Color.White
            cb.ItemsAppearance.BackColor = Color.FromArgb(40, 40, 40)
        Else
            cb.FillColor = Color.White
            cb.ForeColor = Color.Black
            cb.ItemsAppearance.ForeColor = Color.Black
            cb.ItemsAppearance.BackColor = Color.White
        End If
    End Sub

    Private Sub DataGrid(grid As DataGridView)
        If CurrentTheme = ThemeMode.Dark Then
            grid.BackgroundColor = Color.FromArgb(30, 30, 30)
            grid.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45)
            grid.DefaultCellStyle.ForeColor = Color.White
        Else
            grid.BackgroundColor = Color.White
            grid.DefaultCellStyle.BackColor = Color.White
            grid.DefaultCellStyle.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Theme_Label(lbl As Label)
        lbl.ForeColor = If(CurrentTheme = ThemeMode.Dark, Color.White, Color.Black)
        lbl.BackColor = Color.Transparent
    End Sub

    'Private Sub Theme_Panel(p As Panel)
    '    p.BackColor = If(CurrentTheme = ThemeMode.Dark, Color.FromArgb(35, 35, 35), Color.WhiteSmoke)
    'End Sub

    Private Sub Theme_TextBox(tb As TextBox)
        If CurrentTheme = ThemeMode.Dark Then
            tb.BackColor = Color.FromArgb(40, 40, 40)
            tb.ForeColor = Color.White
        Else
            tb.BackColor = Color.White
            tb.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Theme_Button(b As Button)
        If CurrentTheme = ThemeMode.Dark Then
            b.BackColor = Color.FromArgb(60, 60, 60)
            b.ForeColor = Color.White
        Else
            b.BackColor = Color.WhiteSmoke
            b.ForeColor = Color.Black
        End If
    End Sub
    Public Sub ApplyToAllOpenForms()
        For Each frm As Form In Application.OpenForms
            If frm.Name <> "Main" Then
                ApplyThemeToForm(frm)
            End If

        Next
    End Sub

    Private Sub Theme_GunaHtmlLabel(lbl As Guna2HtmlLabel)
        If CurrentTheme = ThemeMode.Dark Then
            lbl.ForeColor = Color.White
        Else
            lbl.ForeColor = Color.Black
        End If
        lbl.BackColor = Color.Transparent
    End Sub

    Private Sub Theme_FlowPanel(fp As FlowLayoutPanel)
        If CurrentTheme = ThemeMode.Dark Then
            fp.BackColor = Color.FromArgb(18, 21, 29)
        Else
            fp.BackColor = Color.WhiteSmoke
        End If
    End Sub
End Module
