Public Class BootError
    'Diese Form wird angezeigt, wenn die Anwendung nicht korrekt gestartet werden konnte.
    'Dieses Fenster zeigt dem Benutzer verschiedene Optionen, um das Problem zu beheben.
    'Das bringt folgendes: Der Benutzer kann die Anwendung neu starten, das WebConnect Recovery Tool starten oder die Anwendung beenden.
    'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
    Private Sub BootError(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine("Start of private sub: BootError(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress")
        Debug.WriteLine("    If e.KeyChar = Convert.ToChar(Keys.Escape) Then")
        Debug.WriteLine("    e.KeyChar = " & Convert.ToChar(Keys.Escape))
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Debug.WriteLine("        Me.Close()")
            Me.Close()
            Debug.WriteLine("    End If")
        End If
        Debug.WriteLine("End of private sub: BootError(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress")
    End Sub

    'Wenn das Fenster geladen wird, wird eine Warnung in der Konsole ausgegeben, dass die Anwendung nicht korrekt gestartet werden konnte.
    Private Sub ErrorLoadingLanguage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("WARNING!!! The application failed to boot correctly. The bootloader has entered the recovery mode. This can happen because of corrupted files or faulty configuration.")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    'Wenn der Benutzer auf Terminate klickt, wird das Fenster geschlossen.
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Debug.WriteLine("Start of private sub: Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click")
        Debug.WriteLine("    ShutDownWebConnect.ShowDialog()")
        ShutDownWebConnect.ShowDialog()
        Debug.WriteLine("End of private sub: Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click")
    End Sub

    'Wenn der Benutzer auf Try Again klickt, wird erneut versucht, die Anwendung zu starten.A
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Debug.WriteLine("Start of private sub: Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click")
        Debug.WriteLine("    Reboot.ShowDialog()")
        Reboot.ShowDialog()
        Debug.WriteLine("End of private sub: Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click")
    End Sub

    'Wenn der Benutzer auf Start WebConnect Recovery klickt, wird das WebConnect Recovery Tool geöffnet.
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Debug.WriteLine("Start of private sub: Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click")
        Debug.WriteLine("    WebConnectRecoveryTool.ShowDialog()")
        WebConnectRecoveryTool.ShowDialog
        Debug.WriteLine("End of private sub: Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click")
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class