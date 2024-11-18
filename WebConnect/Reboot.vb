Public Class Reboot
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        My.Settings.AdminPassword = ""
        My.Settings.OrganizationName = ""
        My.Settings.OrganizationMode = False
        Application.Restart()
    End Sub

    Private Sub Reboot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class