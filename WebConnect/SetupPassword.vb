Public Class SetupPassword
    Private Sub SetupPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        If EnterNewPasswordText.Text = ConfirmNewPasswordText.Text Then
            My.Settings.AdminPassword = EnterNewPasswordText.Text
            Me.Close()
        Else
            Me.Text = "Die Passwörter stimmen nicht überein"
        End If
    End Sub
End Class