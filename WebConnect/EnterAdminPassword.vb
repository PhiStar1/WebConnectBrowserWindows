'Import von Bibliotheken
Imports System.Windows.Forms

Public Class EnterAdminPassword
    'Diese Form wird angezeigt, wenn der Benutzer auf WebConnect/Einstellungen/Software-Update/Schnell hintereinander auf Aktuell installierte Softwareversion: xxxx.xx.xx/WebConnect Admin Software/ klickt, und der Administratormodus bereits eingerichtet ist.
    'Dieses Fenster fordert ein Passwort an, um den Administratormodus zu entsperren.
    'Das bringt folgendes: Der Benutzer kann die Administratormodus-Software verwenden, um die Software zu aktualisieren oder zu konfigurieren.
    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    'Dieser Sub überprüft, ob das eingegebene Passwort korrekt ist oder schließt das Fenster.
    Private Sub EnterAdminPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Wenn der Benutzer Enter drückt, wird überprüft, ob das eingegebene Passwort korrekt ist.
        If e.KeyCode = Keys.Enter Then
            'Wenn das Passwort korrekt ist, wird das Fenster geschlossen.
            If OrganizationPassword.Text = My.Settings.AdminPassword Then
                'Das Fenster wird geschlossen.
                allowExit = True
                Me.Close()

            Else
                'Wenn das Passwort falsch ist, wird der Benutzer benachrichtigt.
                MessageBox.Show("Falsches Passwort")
            End If
        End If
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        If e.KeyCode = Keys.Escape Then
            'Das Fenster wird geschlossen.
            Me.Close()
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den escape-Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub EnterAdminPassword(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        Debug.WriteLine("Gedrückt")
        'Das Fenster wird geschlossen.
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
    End Sub
    'setze allowExit auf False
    Private allowExit As Boolean = False

    'Dieser Sub wird ausgeführt, wenn das Fenster geschlossen wird.
    'Dieser Sub verhindert, dass das Fenster geschlossen wird, wenn allowExit auf False gesetzt ist.
    Private Sub EnterAdminPassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Wenn allowExit auf False gesetzt ist und der Benutzer das Fenster schließen möchte, wird das Schließen des Fensters verhindert.
        If Not allowExit AndAlso e.CloseReason = CloseReason.UserClosing Then
            'Das Schließen des Fensters wird verhindert.
            e.Cancel = True
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den alt-F4-Button klickt.
    '    Dieser Sub setzt allowExit auf False.
    Private Sub AltF4(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Wenn der Benutzer Alt und F4 drückt, wird allowExit auf False gesetzt.
        If e.Alt AndAlso e.KeyCode = Keys.F4 Then
            'allowExit wird auf False gesetzt.
            allowExit = False
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf das Textfeld klickt.
    'Dieser Sub löscht den Text im Textfeld, wenn der Text "Organisationspasswort" ist.
    Private Sub OrganizationPassword_Click(sender As Object, e As EventArgs) Handles OrganizationPassword.Click
        'Wenn der Text "Organisationspasswort" ist, wird der Text gelöscht.
        If OrganizationPassword.Text = "Organisationspasswort" Then
            'Der Text wird gelöscht.
            OrganizationPassword.Clear()
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub setzt den Text des Textfeldes auf "".
    Private Sub EnterAdminPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Der Text des Textfeldes wird auf "" gesetzt.
        OrganizationPassword.Text = ""
        OrganizationPassword.PasswordChar = ""
        If Form1.Language = "de" Then
            'Der Text des Fensters wird auf "Organisationseinstellungen" gesetzt.
            Me.Text = "Organisationseinstellungen"
            CancelButton.Text = "Abbrechen"
            UnlockAdminSoftwareButton.Text = "OK"
        End If
        If Form1.Language = "en" Then
            'Der Text des Fensters wird auf "Organization settings" gesetzt.
            Me.Text = "Organization settings"
            CancelButton.Text = "Cancel"
            UnlockAdminSoftwareButton.Text = "OK"
        End If
        If Form1.Language = "fr" Then
            'Der Text des Fensters wird auf "Paramètres de l'organisation" gesetzt.
            Me.Text = "Paramètres de l'organisation"
            CancelButton.Text = "Annuler"
            UnlockAdminSoftwareButton.Text = "OK"
        End If
        If Form1.Language = "es" Then
            'Der Text des Fensters wird auf "Configuración de la organización" gesetzt.
            Me.Text = "Configuración de la organización"
            CancelButton.Text = "Cancelar"
            UnlockAdminSoftwareButton.Text = "OK"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Impostazioni dell'organizzazione"
            CancelButton.Text = "Annulla"
            UnlockAdminSoftwareButton.Text = "OK"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Organizasyon ayarları"
            CancelButton.Text = "İptal"
            UnlockAdminSoftwareButton.Text = "Tamam"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer das Textfeld bearbeitet.
    'Dieser Sub setzt den Text des Textfeldes auf "*"
    Private Sub OrganizationPassword_TextChanged(sender As Object, e As EventArgs) Handles OrganizationPassword.TextChanged
        'Der Text des Textfeldes wird auf "*" gesetzt.
        OrganizationPassword.PasswordChar = "*"
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den OK-Button klickt.
    'Dieser Sub überprüft, ob das eingegebene Passwort korrekt ist.
    Private Sub UnlockAdminSoftwareButton_Click(sender As Object, e As EventArgs) Handles UnlockAdminSoftwareButton.Click
        'Wenn das Passwort korrekt ist, wird das Fenster geschlossen.
        If OrganizationPassword.Text = My.Settings.AdminPassword Then
            'Das Fenster wird geschlossen.
            allowExit = True
            Me.Close()

        Else
            'Wenn das Passwort falsch ist, wird der Benutzer benachrichtigt.
            MessageBox.Show("Falsches Passwort")
        End If

    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Abbrechen-Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        'Das Fenster wird geschlossen.
        allowExit = True
        Me.Close()
        WebConnectAdminSoftware.Close()

    End Sub
End Class