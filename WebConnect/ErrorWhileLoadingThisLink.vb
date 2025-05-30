Public Class ErrorWhileLoadingThisLink
    'Dieses Fenster wird angezeigt, wenn ein Fehler beim Laden eines internen Links auftritt.
    'Dieses Fenster zeigt dem Benutzer an, dass ein Fehler aufgetreten ist und dass er es erneut versuchen soll.
    'Das bringt folgendes: Der Benutzer kann sehen, dass ein Fehler aufgetreten ist und es erneut versuchen.

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den escape-Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        If e.KeyCode = Keys.Escape Then
            'Das Fenster wird geschlossen.
            Me.Close()
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub ErrorWhileLoadingThisLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Fehler beim Laden des Links"
            Header.Text = "Fehler beim Laden des Links"
            OKButton.Text = "OK"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Error while loading the link"
            Header.Text = "Error while loading the link"
            OKButton.Text = "OK"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Erreur lors du chargement du lien"
            Header.Text = "Erreur lors du chargement du lien"
            OKButton.Text = "OK"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Error al cargar el enlace"
            Header.Text = "Error al cargar el enlace"
            OKButton.Text = "OK"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Errore durante il caricamento del link"
            Header.Text = "Errore durante il caricamento del link"
            OKButton.Text = "OK"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Bağlantı yüklenirken hata"
            Header.Text = "Bağlantı yüklenirken hata"
            OKButton.Text = "Tamam"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        'Das Fenster wird geschlossen.
        Me.Close()
    End Sub
End Class