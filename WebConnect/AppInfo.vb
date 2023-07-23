Public Class AppInfo
    Private Sub TwitchLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TwitchLink.LinkClicked
        Form1.WebView21.CoreWebView2.Navigate("https://www.twitch.tv/philconnected")
        Me.Close()
    End Sub

    Private Sub YouTubeLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles YouTubeLink.LinkClicked
        Form1.WebView21.CoreWebView2.Navigate("https://www.youtube.com/@philconnected")
        Me.Close()
    End Sub

    Private Sub TikTokLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TikTokLink.LinkClicked
        Form1.WebView21.CoreWebView2.Navigate("https://www.tiktok.com/@philconnected")
        Me.Close()
    End Sub

    Private Sub InstaLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InstaLink.LinkClicked
        Form1.WebView21.CoreWebView2.Navigate("https://www.instagram.com/philconnected.official/")
        Me.Close()

    End Sub

    Private Sub ExitAppInfo_Click(sender As Object, e As EventArgs) Handles ExitAppInfo.Click
        Me.Close()
    End Sub

    Private Sub AppInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class