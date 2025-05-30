Public Class RebootAndDeleteMDMSettings
    Private Sub RebootAndDeleteMDMSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            ClearMDMSettings()
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Reboot.Click
        ClearMDMSettings()
    End Sub

    Private Sub Reboot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Neustarten"
            Header.Text = "WebConnect neu starten"
            Description.Text = "Alle Tabs und im Browser ausgeführten Programme werden beendet
und nicht gespeicherte Daten gehen verloren."
            Cancel.Text = "Abbrechen"
            Reboot.Text = "Neustarten"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Reboot"
            Header.Text = "Reboot WebConnect"
            Description.Text = "All tabs and programs running in the browser will be closed
and unsaved files will be lost."
            Cancel.Text = "Cancel"
            Reboot.Text = "Reboot"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Redémarrer"
            Header.Text = "Redémarrer WebConnect"
            Description.Text = "Tous les onglets et programmes en cours d'exécution dans le navigateur seront fermés
et les fichiers non enregistrés seront perdus."
            Cancel.Text = "Annuler"
            Reboot.Text = "Redémarrer"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Riavvia"
            Header.Text = "Riavvia WebConnect"
            Description.Text = "Tutte le schede e i programmi in esecuzione nel browser verranno chiusi
e i file non salvati andranno persi."
            Cancel.Text = "Annulla"
            Reboot.Text = "Riavvia"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Reiniciar"
            Header.Text = "Reiniciar WebConnect"
            Description.Text = "Todas las pestañas y programas que se ejecutan en el navegador se cerrarán
y los archivos no guardados se perderán."
            Cancel.Text = "Cancelar"
            Reboot.Text = "Reiniciar"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Yeniden Başlat"
            Header.Text = "WebConnect'i Yeniden Başlat"
            Description.Text = "Tarayıcıda çalışan tüm sekmeler ve programlar kapatılacak
ve kaydedilmemiş dosyalar kaybolacaktır."
            Cancel.Text = "İptal"
            Reboot.Text = "Yeniden Başlat"
        End If
    End Sub
    Private Function ClearMDMSettings()
        My.Settings.AdminPassword = ""
        My.Settings.OrganizationName = ""
        My.Settings.OrganizationMode = False
        Application.Restart()
    End Function
End Class