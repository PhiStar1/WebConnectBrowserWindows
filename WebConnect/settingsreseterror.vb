Public Class settingsreseterror
    Private Sub settingsreseterror_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then

        End If
    End Sub

    Private Sub reboot_Click(sender As Object, e As EventArgs) Handles reboot.Click
        Application.Restart()

    End Sub

    Private Sub settingsreseterror_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class