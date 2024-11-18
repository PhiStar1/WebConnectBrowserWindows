Public Class InstallAppleAirport
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.AddNewTab("https://download.info.apple.com/Mac_OS_X/041-0257.20120611.MkI85/AirPortSetup.exe")
        Me.Close()
        ASUSWiredOrWireless.Close()
        ConnectToRouter.Close()
        Launcher.Close()
    End Sub

    Private Sub InstallAppleAirport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class