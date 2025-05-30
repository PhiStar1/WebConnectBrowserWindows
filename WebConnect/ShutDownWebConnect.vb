Public Class ShutDownWebConnect
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Shutdown.Click
        Application.Exit()
    End Sub

    Private Sub ShutDownWebConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "WebConnect beenden"
            Header.Text = "WebConnect beenden"
            Description.Text = "Alle Tabs und im Browser ausgeführten Programme werden beendet
und nicht gespeicherte Daten gehen verloren."
            Cancel.Text = "Abbrechen"
            Shutdown.Text = "Beenden"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Shut Down WebConnect"
            Header.Text = "Shut Down WebConnect"
            Description.Text = "All tabs and programs running in the browser will be closed
and unsaved data will be lost."
            Cancel.Text = "Cancel"
            Shutdown.Text = "Shut Down"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Fermer WebConnect"
            Header.Text = "Fermer WebConnect"
            Description.Text = "Tous les onglets et programmes en cours d'exécution dans le navigateur seront fermés
et les données non enregistrées seront perdues."
            Cancel.Text = "Annuler"
            Shutdown.Text = "Fermer"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Cerrar WebConnect"
            Header.Text = "Cerrar WebConnect"
            Description.Text = "Todas las pestañas y programas que se ejecutan en el navegador se cerrarán
y los datos no guardados se perderán."
            Cancel.Text = "Cancelar"
            Shutdown.Text = "Cerrar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Chiudere WebConnect"
            Header.Text = "Chiudere WebConnect"
            Description.Text = "Tutte le schede e i programmi in esecuzione nel browser verranno chiusi
e i dati non salvati andranno persi."
            Cancel.Text = "Annulla"
            Shutdown.Text = "Chiudere"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "WebConnect'i Kapat"
            Header.Text = "WebConnect'i Kapat"
            Description.Text = "Tarayıcıda çalışan tüm sekmeler ve programlar kapatılacak
ve kaydedilmemiş veriler kaybolacak."
            Cancel.Text = "İptal"
            Shutdown.Text = "Kapat"
        End If


    End Sub
End Class