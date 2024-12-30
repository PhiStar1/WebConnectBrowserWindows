Public Class MDMSettingsReboot
    Private Sub MDMSettingsReboot_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Escape()
        End If
        If e.KeyCode = Keys.Enter Then
            AskForReboot()
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        AskForReboot()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Escape()
    End Sub

    Private Sub DebugSettingsReboot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function Escape()
        Me.Close()

    End Function
    Private Function AskForReboot()
        Reboot.ShowDialog()
    End Function
End Class