Imports System.Windows.Forms

Public Class EnterAdminPassword
    Private allowExit As Boolean = False
    Private Sub EnterAdminPassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not allowExit AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub
    Private Sub AltF4(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Alt AndAlso e.KeyCode = Keys.F4 Then
            allowExit = False
        End If
    End Sub


    Private Sub OrganizationPassword_Click(sender As Object, e As EventArgs) Handles OrganizationPassword.Click
        If OrganizationPassword.Text = "Organisationspasswort" Then
            OrganizationPassword.Clear()
        End If
    End Sub

    Private Sub EnterAdminPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OrganizationPassword.Text = ""
        OrganizationPassword.PasswordChar = ""
    End Sub

    Private Sub OrganizationPassword_TextChanged(sender As Object, e As EventArgs) Handles OrganizationPassword.TextChanged
        OrganizationPassword.PasswordChar = "*"
    End Sub

    Private Sub UnlockAdminSoftwareButton_Click(sender As Object, e As EventArgs) Handles UnlockAdminSoftwareButton.Click
        If OrganizationPassword.Text = My.Settings.AdminPassword Then
            allowExit = True
            Me.Close()

        Else
            MessageBox.Show("Falsches Passwort")
        End If

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        allowExit = True
        Me.Close()
        WebConnectAdminSoftware.Close()

    End Sub
End Class