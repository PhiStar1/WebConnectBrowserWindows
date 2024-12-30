Imports System.Windows.Forms

Public Class EnterAdminPassword
    Private Sub EnterAdminPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Wenn Enter gedrückt wird
        If e.KeyCode = Keys.Enter Then
            If OrganizationPassword.Text = My.Settings.AdminPassword Then
                allowExit = True
                Me.Close()

            Else
                MessageBox.Show("Falsches Passwort")
            End If
        End If
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub EnterAdminPassword(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine("Gedrückt")
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
    End Sub
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