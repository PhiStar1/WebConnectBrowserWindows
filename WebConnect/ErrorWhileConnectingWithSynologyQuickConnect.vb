Public Class ErrorWhileConnectingWithSynologyQuickConnect
    'Diese Form wird angezeigt, wenn der Benutzer auf Shortcuts/Geraete/NAS/Synology/QuickConnect klickt und die Verbindung fehlschlägt.
    'Dieses Fenster fordert den Benutzer auf, die Verbindung erneut herzustellen.
    'Das bringt folgendes: Der Benutzer kann die Verbindung erneut herstellen, wenn die Verbindung fehlschlägt.

    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    'Dieser Sub überprüft, ob der Benutzer F5 oder Escape drückt.
    Private Sub ErrorWhileConnectingWithSynologyQuickConnect_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Wenn der Benutzer F5 drückt, wird die Verbindung erneut hergestellt.
        If e.KeyCode = Keys.F5 Then
            'Die Verbindung wird erneut hergestellt.
            RetryQuickConnect()
        End If
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        If e.KeyCode = Keys.Escape Then
            'Das Fenster wird geschlossen.
            Me.Close()
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Button "Erneut verbinden" klickt.
    'Dieser Sub ruft die Funktion RetryQuickConnect auf.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Die Funktion RetryQuickConnect wird aufgerufen.
        RetryQuickConnect()
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Button "Abbrechen" klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Das Fenster wird geschlossen.
        Me.Close()
    End Sub


    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub ErrorWhileConnectingWithSynologyQuickConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "QuickConnect ist auf ein Problem gestoßen"
            Label2.Text = "QuickConnect kann nicht verbunden werden."
            Label1.Text = "Bei dem Versuch, eine Verbindung zu QuickConnect herzustellen, ist ein Problem aufgetreten. 
Erneut versuchen?"
            Button1.Text = "Erneut versuchen"
            Button2.Text = "Abbrechen"
        End If
        If Form1.Language = "en" Then
            Me.Text = "QuickConnect has encountered a problem"
            Label2.Text = "QuickConnect cannot be connected."
            Label1.Text = "An issue occurred while trying to connect to QuickConnect.
Try again?"
            Button1.Text = "Try again"
            Button2.Text = "Cancel"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "QuickConnect a rencontré un problème"
            Label2.Text = "QuickConnect ne peut pas être connecté."
            Label1.Text = "Un problème est survenu lors de la tentative de connexion à QuickConnect.
Réessayer ?"
            Button1.Text = "Réessayer"
            Button2.Text = "Annuler"
        End If
        If Form1.Language = "es" Then
            Me.Text = "QuickConnect ha encontrado un problema"
            Label2.Text = "No se puede conectar QuickConnect."
            Label1.Text = "Se produjo un problema al intentar conectarse a QuickConnect.
Intenta de nuevo?"
            Button1.Text = "Intenta de nuevo"
            Button2.Text = "Cancelar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "QuickConnect ha riscontrato un problema"
            Label2.Text = "Non è possibile connettere QuickConnect."
            Label1.Text = "Si è verificato un problema durante il tentativo di connessione a QuickConnect.
Riprova?"
            Button1.Text = "Riprova"
            Button2.Text = "Annulla"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "QuickConnect bir sorunla karşılaştı"
            Label2.Text = "QuickConnect bağlanamıyor."
            Label1.Text = "QuickConnect'e bağlanmaya çalışırken bir sorun oluştu.
Tekrar denemek ister misiniz?"
            Button1.Text = "Tekrar dene"
            Button2.Text = "İptal"
        End If
    End Sub

    'Diese Funktion wird ausgeführt, wenn die Verbindung erneut hergestellt wird.
    'Diese Funktion lädt die Seite erneut.
    Private Function RetryQuickConnect()
        'Die Seite wird erneut geladen.
        Form1.WebView21.CoreWebView2.Navigate("https://" & EnterQuickConnectID.QuickConnectID.Text & ".quickconnect.to")

    End Function
End Class