Public Class DeleteAdminSettingsDialog
    'Diese Form wird angezeigt, wenn der Benutzer auf WebConnect/Einstellungen/Software-Update/Schnell hintereinander auf Aktuell installierte Softwareversion: xxxx.xx.xx/WebConnect Admin Software/Administrator gibt Passwort ein/Organization Setup/Organisationseinstellungen löschen klickt.
    'Dieses Fenster fordert ein Passwort an, um die Organisationseinstellungen zu löschen.
    'Das bringt folgendes: Der Benutzer kann die Organisationseinstellungen löschen, wenn er das Passwort kennt.
    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    'Dieser Sub überprüft, ob das eingegebene Passwort korrekt ist oder schließt das Fenster.
    Private Sub DeleteAdminSettingsDialog(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        Debug.WriteLine("Gedrückt")
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            'Das Fenster wird geschlossen.
            Me.Close()

        End If
        'Wenn der Benutzer Enter drückt, wird überprüft, ob das eingegebene Passwort korrekt ist.
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            'Wenn das Passwort korrekt ist, wird das Fenster "RebootAndDeleteMDMSettings" geöffnet.
            If ConfirmWithPassword.Text = My.Settings.AdminPassword Then
                'Das Fenster "RebootAndDeleteMDMSettings" wird geöffnet.

                RebootAndDeleteMDMSettings.ShowDialog()
            Else
                'Wenn das Passwort falsch ist, wird der Benutzer benachrichtigt.
                Me.Text = "Falsches Passwort"
            End If
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub setzt den Text des Textfeldes auf leer.
    Private Sub DeleteAdminSettingsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Der Text des Textfeldes wird auf leer gesetzt.
        ConfirmWithPassword.Text = ""
        If Form1.Language = "de" Then
            Me.Text = "Organisationseinstellungen löschen?"
            Password.Text = "Passwort eingeben:"
            RebootMessage.Text = "WebConnect wird danach neu gestartet."
            Cancel.Text = "Abbrechen"
            Delete.Text = "Löschen"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Erase organization settings?"
            Password.Text = "Enter password:"
            RebootMessage.Text = "WebConnect will then reboot."
            Cancel.Text = "Cancel"
            Delete.Text = "Erase"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Effacer les paramètres de l'organisation ?"
            Password.Text = "Saisir le mot de passe :"
            RebootMessage.Text = "WWebConnect redémarre alors."
            Cancel.Text = "Annuler"
            Delete.Text = "Effacer"
        End If
        If Form1.Language = "es" Then
            Me.Text = "¿Borrar la configuración de la organización?"
            Password.Text = "Introducir contraseña:"
            RebootMessage.Text = "WebConnect se reiniciará después."
            Cancel.Text = "Cancelar"
            Delete.Text = "Borrar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Elimina le impostazioni dell'organizzazione?"
            Password.Text = "Inserire la password:"
            RebootMessage.Text = "WebConnect viene quindi riavviato."
            Cancel.Text = "Annulla"
            Delete.Text = "Elimina"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Organizasyon ayarları silinsin mi?"
            Password.Text = "Şifreyi girin:"
            RebootMessage.Text = "WebConnect daha sonra yeniden başlatılır."
            Cancel.Text = "İptal"
            Delete.Text = "Sil"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den "Abbrechen"-Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        'Das Fenster wird geschlossen.
        Me.Close()
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den "Löschen"-Button klickt.
    'Dieser Sub überprüft, ob das eingegebene Passwort korrekt ist und öffnet das Fenster "RebootAndDeleteMDMSettings".
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Delete.Click
        'Wenn das Passwort korrekt ist, wird das Fenster "RebootAndDeleteMDMSettings" geöffnet.
        If ConfirmWithPassword.Text = My.Settings.AdminPassword Then
            'Das Fenster "RebootAndDeleteMDMSettings" wird geöffnet.

            RebootAndDeleteMDMSettings.ShowDialog()
        Else
            'Wenn das Passwort falsch ist, wird der Benutzer benachrichtigt.
            Me.Text = "Falsches Passwort"
        End If
    End Sub
End Class