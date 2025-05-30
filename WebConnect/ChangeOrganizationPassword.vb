'Import von Bibliotheken
Imports System.Diagnostics.Metrics
Imports System.Threading.Channels
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class ChangeOrganizationPassword
    'Diese Form wird angezeigt, wenn der Benutzer auf WebConnect/Einstellungen/Software-Update/Schnell hintereinander auf Aktuell installierte Softwareversion: xxxx.xx.xx/WebConnect Admin Software/Administrator gibt Passwort ein/Organization Setup/Organisationspasswort ändern klickt.

    'Dieses Formular ermöglicht es dem Benutzer, das Passwort für die Organisation zu ändern.
    'Das bringt folgendes: Der Benutzer kann das Passwort für die Organisation ändern.
    'Dieser Sub wird ausgeführt, wenn eine Taste gedrückt wird.
    'In diesem Sub wird festgelegt, was passiert, wenn eine Taste gedrückt wird.
    Private Sub EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Debug.WriteLine("Start of private sub: EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
        ' Wenn Enter gedrückt wird und ActualPassword fokussiert ist, Fokus auf NewPassword setzen
        Debug.WriteLine("    If e.KeyCode = Keys.Enter Then")
        Debug.WriteLine("    e.KeyCode = " & e.KeyCode)
        If e.KeyCode = Keys.Enter Then
            Debug.WriteLine("        If ActualPassword.Focused Then")
            Debug.WriteLine("        ActualPassword.Focused = " & CurrentPasswordPassword.Focused)
            If CurrentPasswordPassword.Focused Then
                ' Fokus auf NewPassword setzen, wenn ActualPassword fokussiert ist
                Debug.WriteLine("            NewPassword.Select()")
                NewPasswordPassword.Select()
                Debug.WriteLine("            ElseIf NewPassword.Focused Then")
                Debug.WriteLine("            NewPassword.Focused = " & NewPasswordPassword.Focused)
            ElseIf NewPasswordPassword.Focused Then
                ' Fokus auf ConfirmNewPassword setzen, wenn NewPassword fokussiert ist
                Debug.WriteLine("            ConfirmNewPassword.Select()")
                ConfirmNewPasswordPassword.Select()
                Debug.WriteLine("            ElseIf ConfirmNewPassword.Focused Then")
                Debug.WriteLine("            ConfirmNewPassword.Focused = " & ConfirmNewPasswordPassword.Focused)
            ElseIf ConfirmNewPasswordPassword.Focused Then
                ' Wenn ActualPassword das Admin-Passwort ist und NewPassword und ConfirmNewPassword übereinstimmen, das Passwort ändern
                Debug.WriteLine("                If ActualPassword.Text = My.Settings.AdminPassword AndAlso NewPassword.Text = ConfirmNewPassword.Text Then")
                Debug.WriteLine("                ActualPassword.Text = " & CurrentPasswordPassword.Text & ", NewPassword.Text = " & NewPasswordPassword.Text)
                Debug.WriteLine("                My.Settings.AdminPassword = " & My.Settings.AdminPassword & ", ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
                If CurrentPasswordPassword.Text = My.Settings.AdminPassword AndAlso NewPasswordPassword.Text = ConfirmNewPasswordPassword.Text Then
                    ' Passwort ändern
                    Debug.WriteLine("                    My.Settings.AdminPassword = NewPassword.Text")
                    My.Settings.AdminPassword = NewPasswordPassword.Text
                    Debug.WriteLine("                    My.Settings.AdminPassword = " & My.Settings.AdminPassword)
                    Debug.WriteLine("                    Me.Close()")
                    Me.Close()
                End If
                ' Fehlermeldungen anzeigen
                Debug.WriteLine("                If Not ActualPassword.Text = My.Settings.AdminPassword Then")
                Debug.WriteLine("                ActualPassword.Text = " & CurrentPasswordPassword.Text & ", My.Settings.AdminPassword = " & My.Settings.AdminPassword)
                If Not CurrentPasswordPassword.Text = My.Settings.AdminPassword Then
                    ' Falsches Passwort
                    Debug.WriteLine("                    Me.Text = 'Falsches Passwort'")
                    Me.Text = "Falsches Passwort"
                    Debug.WriteLine("                Me.Text = " & Me.Text)
                End If
                ' Passwörter stimmen nicht überein
                Debug.WriteLine("                If Not NewPassword.Text = ConfirmNewPassword.Text Then")
                Debug.WriteLine("                NewPassword.Text = " & NewPasswordPassword.Text & ", ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
                If Not NewPasswordPassword.Text = ConfirmNewPasswordPassword.Text Then
                    Debug.WriteLine("                    Me.Text = 'Die Passwörter stimmen nicht überein'")
                    Me.Text = "Die Passwörter stimmen nicht überein"
                    Debug.WriteLine("                Me.Text = " & Me.Text)
                End If
                ' Falsches Passwort und Passwörter stimmen nicht überein
                Debug.WriteLine("                If Not ActualPassword.Text = My.Settings.AdminPassword AndAlso Not NewPassword.Text = ConfirmNewPassword.Text Then")
                Debug.WriteLine("                ActualPassword.Text = " & CurrentPasswordPassword.Text & ", My.Settings.AdminPassword = " & My.Settings.AdminPassword & ", NewPassword.Text = " & NewPasswordPassword.Text & ", ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
                If Not CurrentPasswordPassword.Text = My.Settings.AdminPassword AndAlso Not NewPasswordPassword.Text = ConfirmNewPasswordPassword.Text Then
                    Debug.WriteLine("                    Me.Text = 'Falsches Passwort und die Passwörter stimmen nicht überein'")
                    Me.Text = "Falsches Passwort und die Passwörter stimmen nicht überein"
                    Debug.WriteLine("                Me.Text = " & Me.Text)
                End If
            End If

            'Verhindern, dass das Fenster geschlossen wird, wenn Alt + F4 gedrückt wird
            Debug.WriteLine("    e.Handled = True")
            e.Handled = True
            Debug.WriteLine("    e.Handled = " & e.Handled)
        End If

        ' Wenn Escape gedrückt wird, das Fenster schließen
        Debug.WriteLine("    If e.KeyCode = Keys.Escape Then")
        Debug.WriteLine("    e.KeyCode = " & e.KeyCode)
        If e.KeyCode = Keys.Escape Then
            Debug.WriteLine("        Me.Close()")
            ' Fenster schließen
            Me.Close()
        End If

        ' Wenn Backspace gedrückt wird
        Debug.WriteLine("    If e.KeyCode = Keys.Back AndAlso Not e.Control Then")
        Debug.WriteLine("    e.KeyCode = " & e.KeyCode & ", e.Control = " & e.Control)
        If e.KeyCode = Keys.Back AndAlso Not e.Control Then
            ' Wenn der Cursor am Anfang von ActualPassword ist, Fokus auf ActualPassword setzen
            Debug.WriteLine("        If NewPassword.Focused Then")
            Debug.WriteLine("        NewPassword.Focused = " & NewPasswordPassword.Focused)
            If NewPasswordPassword.Focused Then
                Debug.WriteLine("            If NewPassword.SelectionStart = 0 Then")
                Debug.WriteLine("            NewPassword.SelectionStart = " & NewPasswordPassword.SelectionStart)
                If NewPasswordPassword.SelectionStart = 0 Then
                    ' Fokus auf ActualPassword setzen
                    Debug.WriteLine("                ActualPassword.Select()")
                    CurrentPasswordPassword.Select()
                End If
                ' Wenn der Cursor am Anfang von ConfirmNewPassword ist, Fokus auf NewPassword setzen
                Debug.WriteLine("            ElseIf ConfirmNewPassword.Focused Then")
                Debug.WriteLine("            ConfirmNewPassword.Focused = " & ConfirmNewPasswordPassword.Focused)
            ElseIf ConfirmNewPasswordPassword.Focused Then
                ' Fokus auf NewPassword setzen
                Debug.WriteLine("                If ConfirmNewPassword.SelectionStart = 0 Then")
                Debug.WriteLine("                ConfirmNewPassword.SelectionStart = " & ConfirmNewPasswordPassword.SelectionStart)
                If ConfirmNewPasswordPassword.SelectionStart = 0 Then
                    Debug.WriteLine("                    NewPassword.Select()")
                    NewPasswordPassword.Select()
                End If
            End If
        End If

        ' Wenn Strg + Backspace gedrückt wird
        Debug.WriteLine("    If e.Control AndAlso e.KeyCode = Keys.Back Then")
        Debug.WriteLine("    e.Control = " & e.Control & ", e.KeyCode = " & e.KeyCode)
        If e.Control AndAlso e.KeyCode = Keys.Back Then
            ' Wenn NewPassword fokussiert ist und leer ist, Fokus auf ActualPassword setzen
            Debug.WriteLine("        If NewPassword.Focused Then")
            Debug.WriteLine("        NewPassword.Focused = " & NewPasswordPassword.Focused)
            If NewPasswordPassword.Focused Then
                ' Fokus auf ActualPassword setzen, wenn NewPassword leer ist
                Debug.WriteLine("            If NewPassword.Text = '' Then")
                Debug.WriteLine("            NewPassword.Text = " & NewPasswordPassword.Text)
                If NewPasswordPassword.Text = "" Then
                    ' Fokus auf ActualPassword setzen
                    Debug.WriteLine("                ActualPassword.Select()")
                    CurrentPasswordPassword.Select()
                End If
                ' Wenn ConfirmNewPassword fokussiert ist und leer ist, Fokus auf NewPassword setzen
                Debug.WriteLine("            ElseIf ConfirmNewPassword.Focused Then")
                Debug.WriteLine("            ConfirmNewPassword.Focused = " & ConfirmNewPasswordPassword.Focused)
            ElseIf ConfirmNewPasswordPassword.Focused Then
                ' Fokus auf NewPassword setzen, wenn ConfirmNewPassword leer ist
                Debug.WriteLine("                If ConfirmNewPassword.Text = '' Then")
                Debug.WriteLine("                ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
                If ConfirmNewPasswordPassword.Text = "" Then
                    ' Fokus auf NewPassword setzen
                    Debug.WriteLine("                    NewPassword.Select()")
                    NewPasswordPassword.Select()
                End If
            End If
        End If

        ' Wenn die linke Pfeiltaste gedrückt wird
        Debug.WriteLine("    If e.KeyCode = Keys.Left Then")
        Debug.WriteLine("    e.KeyCode = " & e.KeyCode)
        If e.KeyCode = Keys.Left Then
            ' Wenn NewPassword fokussiert ist und der Cursor am Anfang ist, Fokus auf ActualPassword setzen
            Debug.WriteLine("        If NewPassword.Focused AndAlso NewPassword.SelectionStart = 0 Then")
            Debug.WriteLine("        NewPassword.Focused = " & NewPasswordPassword.Focused & ", NewPassword.SelectionStart = " & NewPasswordPassword.SelectionStart)
            If NewPasswordPassword.Focused AndAlso NewPasswordPassword.SelectionStart = 0 Then
                ' Fokus auf ActualPassword setzen
                Debug.WriteLine("            ActualPassword.Select()")
                CurrentPasswordPassword.Select()
                ' Wenn ConfirmNewPassword fokussiert ist und der Cursor am Anfang ist, Fokus auf NewPassword setzen
                Debug.WriteLine("        ElseIf ConfirmNewPassword.Focused AndAlso ConfirmNewPassword.SelectionStart = 0 Then")
                Debug.WriteLine("        ConfirmNewPassword.Focused = " & ConfirmNewPasswordPassword.Focused & ", ConfirmNewPassword.SelectionStart = " & ConfirmNewPasswordPassword.SelectionStart)
            ElseIf ConfirmNewPasswordPassword.Focused AndAlso ConfirmNewPasswordPassword.SelectionStart = 0 Then
                ' Fokus auf NewPassword setzen
                Debug.WriteLine("            NewPassword.Select()")
                NewPasswordPassword.Select()
            End If
        End If

        ' Wenn die rechte Pfeiltaste gedrückt wird
        Debug.WriteLine("    If e.KeyCode = Keys.Right Then")
        Debug.WriteLine("    e.KeyCode = " & e.KeyCode)
        If e.KeyCode = Keys.Right Then
            ' Wenn ActualPassword fokussiert ist und der Cursor am Ende ist, Fokus auf NewPassword setzen
            Debug.WriteLine("        If ActualPassword.Focused Then")
            Debug.WriteLine("        ActualPassword.Focused = " & CurrentPasswordPassword.Focused)
            If CurrentPasswordPassword.Focused Then
                ' Fokus auf NewPassword setzen, wenn der Cursor am Ende von ActualPassword ist
                Debug.WriteLine("            Dim cursorPosition As Integer = ActualPassword.SelectionStart")
                Dim cursorPosition As Integer = CurrentPasswordPassword.SelectionStart
                Debug.WriteLine("            cursorPosition = " & cursorPosition & ", ActualPassword.SelectionStart = " & CurrentPasswordPassword.SelectionStart)
                Debug.WriteLine("            Dim textLength As Integer = ActualPassword.Text.Length")
                Dim textLength As Integer = CurrentPasswordPassword.Text.Length
                Debug.WriteLine("            textLength = " & textLength & ", ActualPassword.Text.Length = " & CurrentPasswordPassword.Text.Length)
                Debug.WriteLine("            If cursorPosition = textLength Then")
                Debug.WriteLine("            cursorPosition = " & cursorPosition & ", textLength = " & textLength)
                If cursorPosition = textLength Then
                    ' Fokus auf NewPassword setzen
                    Debug.WriteLine("                NewPassword.Select()")
                    NewPasswordPassword.Select()
                End If
                ' Wenn NewPassword fokussiert ist und der Cursor am Ende ist, Fokus auf ConfirmNewPassword setzen
                Debug.WriteLine("            ElseIf NewPassword.Focused Then")
                Debug.WriteLine("            NewPassword.Focused = " & NewPasswordPassword.Focused)
            ElseIf NewPasswordPassword.Focused Then
                ' Fokus auf ConfirmNewPassword setzen, wenn der Cursor am Ende von NewPassword ist
                Debug.WriteLine("                Dim cursorPosition As Integer = NewPassword.SelectionStart")
                Dim cursorPosition As Integer = NewPasswordPassword.SelectionStart
                Debug.WriteLine("                cursorPosition = " & cursorPosition & ", NewPassword.SelectionStart = " & NewPasswordPassword.SelectionStart)
                Debug.WriteLine("                Dim textLength As Integer = NewPassword.Text.Length")
                Dim textLength As Integer = NewPasswordPassword.Text.Length
                Debug.WriteLine("                textLength = " & textLength & ", NewPassword.Text.Length = " & NewPasswordPassword.Text.Length)
                Debug.WriteLine("                If cursorPosition = textLength Then")
                Debug.WriteLine("                cursorPosition = " & cursorPosition & ", textLength = " & textLength)
                If cursorPosition = textLength Then
                    ' Fokus auf ConfirmNewPassword setzen
                    Debug.WriteLine("                    ConfirmNewPassword.Select()")
                    ConfirmNewPasswordPassword.Select()
                End If
            End If
        End If
        Debug.WriteLine("End of private sub: EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf die Schaltfläche "Abbrechen" klickt.
    'Dieser Sub schließt das Fenster, wenn der Benutzer auf die Schaltfläche "Abbrechen" klickt.
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Debug.WriteLine("Start of private sub: CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click")
        ' Fenster schließen
        Debug.WriteLine("    Me.Close()")
        Me.Close()
        Debug.WriteLine("End of private sub: CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn Anwenden gedrückt wird.
    'Dieser Sub ändert das Passwort, wenn der Benutzer auf die Schaltfläche "Anwenden" klickt.
    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        Debug.WriteLine("Start of private sub: ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click")
        ' Wenn ActualPassword das Admin-Passwort ist und NewPassword und ConfirmNewPassword übereinstimmen, das Passwort ändern
        Debug.WriteLine("    If ActualPassword.Text = My.Settings.AdminPassword AndAlso NewPassword.Text = ConfirmNewPassword.Text Then")
        Debug.WriteLine("    ActualPassword.Text = " & CurrentPasswordPassword.Text & ", My.Settings.AdminPassword = " & My.Settings.AdminPassword & ", NewPassword.Text = " & NewPasswordPassword.Text & ", ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
        If CurrentPasswordPassword.Text = My.Settings.AdminPassword AndAlso NewPasswordPassword.Text = ConfirmNewPasswordPassword.Text Then
            ' Passwort ändern
            Debug.WriteLine("        My.Settings.AdminPassword = NewPassword.Text")
            My.Settings.AdminPassword = NewPasswordPassword.Text
            Debug.WriteLine("        My.Settings.AdminPassword = " & My.Settings.AdminPassword)
            Debug.WriteLine("        Me.Close()")
            Me.Close()
        End If
        ' Fehlermeldungen anzeigen
        Debug.WriteLine("    If Not ActualPassword.Text = My.Settings.AdminPassword Then")
        Debug.WriteLine("    ActualPassword.Text = " & CurrentPasswordPassword.Text & ", My.Settings.AdminPassword = " & My.Settings.AdminPassword)
        If Not CurrentPasswordPassword.Text = My.Settings.AdminPassword Then
            ' Falsches Passwort
            Debug.WriteLine("        Me.Text = 'Falsches Passwort'")
            Me.Text = "Falsches Passwort"
            Debug.WriteLine("    Me.Text = " & Me.Text)
        End If
        ' Passwörter stimmen nicht überein
        Debug.WriteLine("    If Not NewPassword.Text = ConfirmNewPassword.Text Then")
        Debug.WriteLine("    NewPassword.Text = " & NewPasswordPassword.Text & ", ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
        If Not NewPasswordPassword.Text = ConfirmNewPasswordPassword.Text Then
            Debug.WriteLine("        Me.Text = 'Die Passwörter stimmen nicht überein'")
            Me.Text = "Die Passwörter stimmen nicht überein"
            Debug.WriteLine("    Me.Text = " & Me.Text)
        End If
        ' Falsches Passwort und Passwörter stimmen nicht überein
        Debug.WriteLine("    If Not ActualPassword.Text = My.Settings.AdminPassword AndAlso Not NewPassword.Text = ConfirmNewPassword.Text Then")
        Debug.WriteLine("    ActualPassword.Text = " & CurrentPasswordPassword.Text & ", My.Settings.AdminPassword = " & My.Settings.AdminPassword & ", NewPassword.Text = " & NewPasswordPassword.Text & ", ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
        If Not CurrentPasswordPassword.Text = My.Settings.AdminPassword AndAlso Not NewPasswordPassword.Text = ConfirmNewPasswordPassword.Text Then
            Debug.WriteLine("        Me.Text = 'Falsches Passwort und die Passwörter stimmen nicht überein'")
            Me.Text = "Falsches Passwort und die Passwörter stimmen nicht überein"
            Debug.WriteLine("    Me.Text = " & Me.Text)
        End If
        Debug.WriteLine("End of private sub: ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'In diesem Sub werden die Textfelder geleert.
    Private Sub ChangeOrganizationPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Start of private sub: ChangeOrganizationPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load")
        ' Textfelder leeren
        Debug.WriteLine("    ActualPassword.Text = ''")
        CurrentPasswordPassword.Text = ""
        Debug.WriteLine("    ActualPassword.Text = " & CurrentPasswordPassword.Text)
        Debug.WriteLine("    NewPassword.Text = ''")
        NewPasswordPassword.Text = ""
        Debug.WriteLine("    NewPassword.Text = " & NewPasswordPassword.Text)
        Debug.WriteLine("    ConfirmNewPassword.Text = ''")
        ConfirmNewPasswordPassword.Text = ""
        Debug.WriteLine("    ConfirmNewPassword.Text = " & ConfirmNewPasswordPassword.Text)
        Debug.WriteLine("End of private sub: ChangeOrganizationPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load")
        If Form1.Language = "de" Then
            Me.Text = "Organisationspasswort ändern"
            CurrentPassword.Text = "Aktuelles Passwort"
            Label3.Text = "Neues Passwort"
            Label2.Text = "Neues Passwort bestätigen"
            ShowPassword.Text = "Passwort zeigen"
            CancelButton.Text = "Abbrechen"
            ApplyButton.Text = "Anwenden"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Change organization password"
            CurrentPassword.Text = "Current Password"
            Label3.Text = "New password"
            Label2.Text = "Confirm new password"
            ShowPassword.Text = "Show password"
            CancelButton.Text = "Cancel"
            ApplyButton.Text = "Apply"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Le rapport de l'organisation s'éteint"
            CurrentPassword.Text = "Mot de passe actuel"
            Label3.Text = "Nouveau mot de passe"
            Label2.Text = "Confirmer le nouveau mot de passe"
            ShowPassword.Text = "Afficher le mot de passe"
            CancelButton.Text = "Annuler"
            ApplyButton.Text = "Appliquer"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Cambiar la contraseña de la organización"
            CurrentPassword.Text = "Contraseña actual"
            Label3.Text = "Nueva contraseña"
            Label2.Text = "Confirmar nueva contraseña"
            ShowPassword.Text = "Mostrar contraseña"
            CancelButton.Text = "Cancelar"
            ApplyButton.Text = "Aplicar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Cambia la password dell'organizzazione"
            CurrentPassword.Text = "Password attuale"
            Label3.Text = "Nuova password"
            Label2.Text = "Conferma nuova password"
            ShowPassword.Text = "Mostra password"
            CancelButton.Text = "Annulla"
            ApplyButton.Text = "Applicare"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Kuruluş şifresini değiştirme"
            CurrentPassword.Text = "Mevcut Şifre"
            Label3.Text = "Yeni şifre"
            Label2.Text = "Yeni şifreyi onaylayın"
            ShowPassword.Text = "Şifreyi göster"
            CancelButton.Text = "İptal"
            ApplyButton.Text = "Başvurmak"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Kontrollkästchen "Passwort anzeigen" aktiviert oder deaktiviert wird.
    'In diesem Sub wird festgelegt, ob das Passwort angezeigt wird oder nicht.
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        Debug.WriteLine("Start of private sub: CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged")
        ' Wenn das Kontrollkästchen aktiviert ist, Passwort anzeigen
        Debug.WriteLine("    If ShowPassword.Checked Then")
        Debug.WriteLine("    ShowPassword.Checked = " & ShowPassword.Checked)
        If ShowPassword.Checked Then
            ' Passwort anzeigen
            Debug.WriteLine("        ActualPassword.PasswordChar = ''")
            CurrentPasswordPassword.PasswordChar = ""
            Debug.WriteLine("        ActualPassword.PasswordChar = " & CurrentPasswordPassword.PasswordChar)
            Debug.WriteLine("        NewPassword.PasswordChar = ''")
            NewPasswordPassword.PasswordChar = ""
            Debug.WriteLine("        NewPassword.PasswordChar = " & NewPasswordPassword.PasswordChar)
            Debug.WriteLine("        ConfirmNewPassword.PasswordChar = ''")
            ConfirmNewPasswordPassword.PasswordChar = ""
            Debug.WriteLine("        ConfirmNewPassword.PasswordChar = " & ConfirmNewPasswordPassword.PasswordChar)
            Debug.WriteLine("    Else")
        Else
            ' Passwort verstecken
            Debug.WriteLine("        ActualPassword.PasswordChar = '*'")
            CurrentPasswordPassword.PasswordChar = "*"
            Debug.WriteLine("        ActualPassword.PasswordChar = " & CurrentPasswordPassword.PasswordChar)
            Debug.WriteLine("        NewPassword.PasswordChar = '*'")
            NewPasswordPassword.PasswordChar = "*"
            Debug.WriteLine("        NewPassword.PasswordChar = " & NewPasswordPassword.PasswordChar)
            Debug.WriteLine("        ConfirmNewPassword.PasswordChar = '*'")
            ConfirmNewPasswordPassword.PasswordChar = "*"
            Debug.WriteLine("        ConfirmNewPassword.PasswordChar = " & ConfirmNewPasswordPassword.PasswordChar)
        End If
    End Sub
End Class