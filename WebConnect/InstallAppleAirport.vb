Public Class InstallAppleAirport
    Private Sub InstallAppleAirport_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            DownloadAirPortSoftware()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DownloadAirPortSoftware()
    End Sub

    Private Sub InstallAppleAirport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Function DownloadAirPortSoftware()
        Form1.AddNewTab("https://download.info.apple.com/Mac_OS_X/041-0257.20120611.MkI85/AirPortSetup.exe")
        Me.Close()
        ConnectToRouter.Close()
        Launcher.Close()
    End Function

End Class