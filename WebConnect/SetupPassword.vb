Public Class SetupPassword
    Private Sub EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Wenn Enter gedrückt wird
        If e.KeyCode = Keys.Enter Then
            If EnterNewPasswordText.Focused Then
                ' Fokus auf Port setzen, wenn MyFRITZAdresse fokussiert ist
                ConfirmNewPasswordText.Select()
            ElseIf ConfirmNewPasswordText.Focused Then
                ' Funktion ausführen, wenn Port fokussiert ist
                My.Settings.AdminPassword = EnterNewPasswordText.Text
                Me.Close()
            End If

            ' Verhindern, dass Enter die Standardaktion ausführt
            e.Handled = True
        End If

        ' Wenn Escape gedrückt wird, das Formular schließen
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        ' Wenn Backspace gedrückt wird und nicht Strg, Fokus zu MyFRITZAdresse wechseln, wenn der Cursor am Anfang ist
        If e.KeyCode = Keys.Back AndAlso Not e.Control Then
            If ConfirmNewPasswordText.Focused Then
                ' Nur wenn der Cursor am Anfang von Port ist (SelectionStart = 0)
                If ConfirmNewPasswordText.SelectionStart = 0 Then
                    EnterNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If
        If e.KeyCode = Keys.Left Then
            If ConfirmNewPasswordText.Focused Then
                ' Nur wenn der Cursor am Anfang von Port ist (SelectionStart = 0)
                If ConfirmNewPasswordText.SelectionStart = 0 Then
                    EnterNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If

        ' Wenn Ctrl + Backspace gedrückt wird
        If e.Control AndAlso e.KeyCode = Keys.Back Then
            Debug.WriteLine("CTRL + BACKSPACE gedrückt")
            If ConfirmNewPasswordText.Focused Then
                If ConfirmNewPasswordText.Text = "" Then
                    EnterNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Ctrl + Backspace).")
                End If
            End If
        End If

        ' Wenn die rechte Pfeiltaste gedrückt wird und der Cursor am Ende des Textes ist
        If e.KeyCode = Keys.Right Then
            If EnterNewPasswordText.Focused Then
                Dim cursorPosition As Integer = EnterNewPasswordText.SelectionStart
                Dim textLength As Integer = EnterNewPasswordText.Text.Length
                If cursorPosition = textLength Then
                    ConfirmNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf Port gewechselt (Cursor am Ende von MyFRITZAdresse).")
                End If
            End If
        End If
    End Sub
    Private Sub SetupPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Adminpasswort einrichten"
            EnterNewPassword.Text = "Neues Passwort eingeben"
            ConfirmNewPassword.Text = "Neues Passwort bestätigen"
            ApplyButton.Text = "Anwenden"
            Terminate.Text = "Beenden"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Setup Admin Password"
            EnterNewPassword.Text = "Enter New Password"
            ConfirmNewPassword.Text = "Confirm New Password"
            ApplyButton.Text = "Apply"
            Terminate.Text = "Exit"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Configurer le mot de passe administrateur"
            EnterNewPassword.Text = "Entrer un nouveau mot de passe"
            ConfirmNewPassword.Text = "Confirmer le nouveau mot de passe"
            ApplyButton.Text = "Appliquer"
            Terminate.Text = "Quitter"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Configurar contraseña de administrador"
            EnterNewPassword.Text = "Ingresar nueva contraseña"
            ConfirmNewPassword.Text = "Confirmar nueva contraseña"
            ApplyButton.Text = "Aplicar"
            Terminate.Text = "Salir"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Impostare la password dell'amministratore"
            EnterNewPassword.Text = "Inserire nuova password"
            ConfirmNewPassword.Text = "Confermare nuova password"
            ApplyButton.Text = "Applica"
            Terminate.Text = "Esci"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Yönetici Parolasını Ayarla"
            EnterNewPassword.Text = "Yeni Parolayı Girin"
            ConfirmNewPassword.Text = "Yeni Parolayı Onaylayın"
            ApplyButton.Text = "Uygula"
            Terminate.Text = "Çıkış"
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles Terminate.Click
        Me.Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        If EnterNewPasswordText.Text = ConfirmNewPasswordText.Text Then
            My.Settings.AdminPassword = EnterNewPasswordText.Text
            Me.Close()
        Else
            Me.Text = "Die Passwörter stimmen nicht überein"
        End If
    End Sub
End Class