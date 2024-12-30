Imports System.Diagnostics.Metrics
Imports System.Threading.Channels
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class ChangeOrganizationPassword
    Private Sub EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Wenn Enter gedrückt wird
        If e.KeyCode = Keys.Enter Then
            If ActualPassword.Focused Then
                ' Fokus auf NewPassword setzen, wenn ActualPassword fokussiert ist
                NewPassword.Select()
                Debug.WriteLine("Fokus auf NewPassword gewechselt.")
            ElseIf NewPassword.Focused Then
                ' Fokus auf ConfirmNewPassword setzen, wenn NewPassword fokussiert ist
                ConfirmNewPassword.Select()
                Debug.WriteLine("Fokus auf ConfirmNewPassword gewechselt.")
            ElseIf ConfirmNewPassword.Focused Then
                ' Funktion ausführen, wenn ConfirmNewPassword fokussiert ist
                Debug.WriteLine("Funktion ConnectToMyFRITZAdress wird ausgeführt.")
                If ActualPassword.Text = My.Settings.AdminPassword AndAlso NewPassword.Text = ConfirmNewPassword.Text Then
                    My.Settings.AdminPassword = NewPassword.Text
                    Me.Close()
                End If
                If Not ActualPassword.Text = My.Settings.AdminPassword Then
                    Me.Text = "Falsches Passwort"
                End If
                If Not NewPassword.Text = ConfirmNewPassword.Text Then
                    Me.Text = "Die Passwörter stimmen nicht überein"
                End If
                If Not ActualPassword.Text = My.Settings.AdminPassword AndAlso Not NewPassword.Text = ConfirmNewPassword.Text Then
                    Me.Text = "Falsches Passwort und die Passwörter stimmen nicht überein"
                End If
            End If

            ' Verhindern, dass Enter die Standardaktion ausführt
            e.Handled = True
        End If

        ' Wenn Escape gedrückt wird, das Formular schließen
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        ' Wenn Backspace gedrückt wird und nicht Strg
        If e.KeyCode = Keys.Back AndAlso Not e.Control Then
            If NewPassword.Focused Then
                ' Wenn der Cursor am Anfang von NewPassword ist, Fokus auf ActualPassword wechseln
                If NewPassword.SelectionStart = 0 Then
                    ActualPassword.Select()
                    Debug.WriteLine("Fokus auf ActualPassword gewechselt (Backspace ohne Strg, am Anfang von NewPassword).")
                End If
            ElseIf ConfirmNewPassword.Focused Then
                ' Wenn der Cursor am Anfang von ConfirmNewPassword ist, Fokus auf NewPassword wechseln
                If ConfirmNewPassword.SelectionStart = 0 Then
                    NewPassword.Select()
                    Debug.WriteLine("Fokus auf NewPassword gewechselt (Backspace ohne Strg, am Anfang von ConfirmNewPassword).")
                End If
            End If
        End If

        ' Wenn Ctrl + Backspace gedrückt wird
        If e.Control AndAlso e.KeyCode = Keys.Back Then
            Debug.WriteLine("CTRL + BACKSPACE gedrückt")
            If NewPassword.Focused Then
                If NewPassword.Text = "" Then
                    ActualPassword.Select()
                    Debug.WriteLine("Fokus auf ActualPassword gewechselt (Ctrl + Backspace).")
                End If
            ElseIf ConfirmNewPassword.Focused Then
                If ConfirmNewPassword.Text = "" Then
                    NewPassword.Select()
                    Debug.WriteLine("Fokus auf NewPassword gewechselt (Ctrl + Backspace).")
                End If
            End If
        End If

        ' Wenn die linke Pfeiltaste gedrückt wird
        If e.KeyCode = Keys.Left Then
            If NewPassword.Focused AndAlso NewPassword.SelectionStart = 0 Then
                ActualPassword.Select()
                Debug.WriteLine("Fokus auf ActualPassword gewechselt (Pfeiltaste Links, Anfang von NewPassword).")
            ElseIf ConfirmNewPassword.Focused AndAlso ConfirmNewPassword.SelectionStart = 0 Then
                NewPassword.Select()
                Debug.WriteLine("Fokus auf NewPassword gewechselt (Pfeiltaste Links, Anfang von ConfirmNewPassword).")
            End If
        End If

        ' Wenn die rechte Pfeiltaste gedrückt wird
        If e.KeyCode = Keys.Right Then
            If ActualPassword.Focused Then
                Dim cursorPosition As Integer = ActualPassword.SelectionStart
                Dim textLength As Integer = ActualPassword.Text.Length
                If cursorPosition = textLength Then
                    NewPassword.Select()
                    Debug.WriteLine("Fokus auf NewPassword gewechselt (Cursor am Ende von ActualPassword).")
                End If
            ElseIf NewPassword.Focused Then
                Dim cursorPosition As Integer = NewPassword.SelectionStart
                Dim textLength As Integer = NewPassword.Text.Length
                If cursorPosition = textLength Then
                    ConfirmNewPassword.Select()
                    Debug.WriteLine("Fokus auf ConfirmNewPassword gewechselt (Cursor am Ende von NewPassword).")
                End If
            End If
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        If ActualPassword.Text = My.Settings.AdminPassword AndAlso NewPassword.Text = ConfirmNewPassword.Text Then
            My.Settings.AdminPassword = NewPassword.Text
            Me.Close()
        End If
        If Not ActualPassword.Text = My.Settings.AdminPassword Then
            Me.Text = "Falsches Passwort"
        End If
        If Not NewPassword.Text = ConfirmNewPassword.Text Then
            Me.Text = "Die Passwörter stimmen nicht überein"
        End If
        If Not ActualPassword.Text = My.Settings.AdminPassword AndAlso Not NewPassword.Text = ConfirmNewPassword.Text Then
            Me.Text = "Falsches Passwort und die Passwörter stimmen nicht überein"
        End If
    End Sub

    Private Sub ChangeOrganizationPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualPassword.Text = ""
        NewPassword.Text = ""
        ConfirmNewPassword.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked Then
            ActualPassword.PasswordChar = ""
            NewPassword.PasswordChar = ""
            ConfirmNewPassword.PasswordChar = ""
        Else
            ActualPassword.PasswordChar = "*"
            NewPassword.PasswordChar = "*"
            ConfirmNewPassword.PasswordChar = "*"
        End If
    End Sub
End Class