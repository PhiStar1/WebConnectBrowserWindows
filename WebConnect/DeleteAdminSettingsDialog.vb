Public Class DeleteAdminSettingsDialog
    Private Sub DeleteAdminSettingsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConfirmWithPassword.Text = ""
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        If ConfirmWithPassword.Text = My.Settings.AdminPassword Then

            Reboot.ShowDialog()
        Else
            Me.Text = "Falsches Passwort"
        End If
    End Sub
End Class