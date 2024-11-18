Public Class ASUSWiredOrWireless
    Private Sub WLAN_Click(sender As Object, e As EventArgs) Handles WLAN.Click
        Try
            ' Navigieren zur ASUS-Seite
            Form1.WebView21.CoreWebView2.Navigate("https://router.asus.com")
            ' Schließen Sie das aktuelle Formular und andere erforderliche Formulare
            Me.Close()
            ConnectToRouter.Close()
            Launcher.Close()
            ' Aktualisieren des Texts von Form1
            Form1.Text = "ASUSWRT"
        Catch ex As Exception
            ' Im Falle eines Fehlers beim Navigieren wird ASUSWRTnotworking angezeigt
            ASUSWRTnotworking.ShowDialog()
        End Try
    End Sub

    Private Sub LAN_Click(sender As Object, e As EventArgs) Handles LAN.Click
        ' Öffnen des Dialogs zur Eingabe der IP-Adresse
        EnterIPAdress.ShowDialog()
    End Sub

    Private Sub ASUSWiredOrWireless_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
