Public Class ConnectToRouter
    Private Sub ConnectToRouter(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
    End Sub
    Private Sub ManualConnection_Click(sender As Object, e As EventArgs) Handles ManualConnection.Click
        EnterIPAdress.ShowDialog()
    End Sub

    Private Sub ASUS_Click(sender As Object, e As EventArgs) Handles ASUS.Click
        Form1.WebView21.CoreWebView2.Navigate("http://router.asus.com")
        Form1.Text = "ASUSWRT"
        Me.Close()
        Launcher.Close()
    End Sub

    Private Sub FRITZBox_Click(sender As Object, e As EventArgs) Handles FRITZBox.Click
        Form1.WebView21.CoreWebView2.Navigate("http://fritz.box")
        Form1.Text = "FRITZ!OS"
        Me.Close()
        Launcher.Close()
    End Sub

    Private Sub Synology_Click(sender As Object, e As EventArgs) Handles Synology.Click
        Form1.WebView21.CoreWebView2.Navigate("http://router.synology.com")
        Form1.Text = "SRM"
        Me.Close()
        Launcher.Close()
    End Sub

    Private Sub tplink_Click(sender As Object, e As EventArgs) Handles tplink.Click
        Form1.WebView21.CoreWebView2.Navigate("http://tplinkwifi.net")
        Form1.Text = "TP-LINK"
        Me.Close()
        Launcher.Close()
    End Sub



    Private Sub Cisco_Click(sender As Object, e As EventArgs) Handles Cisco.Click
        Form1.WebView21.CoreWebView2.Navigate("http://192.168.1.1")
        Form1.Text = "Cisco IOS"
        Me.Close()
        Launcher.Close()
    End Sub

    Private Sub DLink_Click(sender As Object, e As EventArgs) Handles DLink.Click
        Form1.WebView21.CoreWebView2.Navigate("http://192.168.0.1")
        Form1.Text = "D-Link"
        Me.Close()
        Launcher.Close()
    End Sub

    Private Sub Google_Click(sender As Object, e As EventArgs) Handles Google.Click
        InstallGoogleHome.ShowDialog()
    End Sub

    Private Sub Linksys_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TelekomSpeedport_Click(sender As Object, e As EventArgs) Handles TelekomSpeedport.Click
        Form1.WebView21.CoreWebView2.Navigate("http://speedport.ip")
        Form1.Text = "Telekom Speedport"
        Me.Close()
        Launcher.Close()
    End Sub

    Private Sub Vodafone_Click(sender As Object, e As EventArgs) Handles Vodafone.Click
        Form1.WebView21.CoreWebView2.Navigate("http://easy.box")
        Form1.Text = "Vodafone"
        Me.Close()
        Launcher.Close()
    End Sub

    Private Sub AppleAirport_Click(sender As Object, e As EventArgs) Handles AppleAirport.Click
        InstallAppleAirport.ShowDialog()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub ConnectToRouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class