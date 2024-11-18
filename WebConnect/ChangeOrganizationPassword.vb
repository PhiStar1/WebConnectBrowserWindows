Public Class ChangeOrganizationPassword
    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        If ActualPassword.Text = My.Settings.AdminPassword AndAlso NewPassword.Text = ConfirmNewPassword.Text Then
            My.Settings.AdminPassword = NewPassword.Text
            Me.Close()
        End If
        If Not ActualPassword.Text = My.Settings.AdminPassword Then
            Me.Text = "Falsches Passwort"
        End If
        If Not NewPassword.Text = ConfirmNewPassword.Text Then
            Me.Text = "Die Passwörter stimmen nicht überein"
        End If
        If Not ActualPassword.Text = My.Settings.AdminPassword AndAlso Not NewPassword.Text = ConfirmNewPassword.Text Then
            Me.Text = "Falsches Passwort und die Passwörter stimmen nicht überein"
        End If
    End Sub

    Private Sub ChangeOrganizationPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualPassword.Text = ""
        NewPassword.Text = ""
        ConfirmNewPassword.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPassword.CheckedChanged
        If ShowPassword.Checked Then
            ActualPassword.PasswordChar = ""
            NewPassword.PasswordChar = ""
            ConfirmNewPassword.PasswordChar = ""
        Else
            ActualPassword.PasswordChar = "*"
            NewPassword.PasswordChar = "*"
            ConfirmNewPassword.PasswordChar = "*"
        End If
    End Sub
End Class