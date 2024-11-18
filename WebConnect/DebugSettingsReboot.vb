Public Class DebugSettingsReboot
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Reboot.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub DebugSettingsReboot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class