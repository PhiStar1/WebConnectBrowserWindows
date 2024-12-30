Public Class ErrorWhileConnectingWithSynologyQuickConnect
    Private Sub ErrorWhileConnectingWithSynologyQuickConnect_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            RetryQuickConnect()
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RetryQuickConnect()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ErrorWhileConnectingWithSynologyQuickConnect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function RetryQuickConnect()
        Form1.WebView21.CoreWebView2.Navigate("https://" & EnterQuickConnectID.QuickConnectID.Text & ".quickconnect.to")

    End Function
End Class