Public Class ErrorWithSourceCodeWebConnectMacro
    'Diese Form wird angezeigt, wenn ein Fehler im Quellcode der WebConnect-Makro-Software auftritt.
    'Dieses Fenster zeigt dem Benutzer an, dass ein Fehler im Quellcode der WebConnect-Makro-Software aufgetreten ist.
    'Das bringt folgendes: Der Benutzer kann den Quellcode des WebConnect-Makros überprüfen und den Fehler beheben.

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den "Schließen"-Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        'Das Fenster wird geschlossen.
        Me.Close()
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub ErrorWithSourceCodeWebConnectMacro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class