Public Class ErrorWhileConnectingWithSynologyQuickConnect
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.WebView21.CoreWebView2.Navigate("https://" & EnterQuickConnectID.QuickConnectID.Text & ".quickconnect.to")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ErrorWhileConnectingWithSynologyQuickConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class