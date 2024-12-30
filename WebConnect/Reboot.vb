Public Class Reboot
    Private Sub Reboot_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            Reboot()
        End If
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Reboot()
    End Sub

    Private Sub Reboot_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Function Reboot()
        Application.Restart()
    End Function
End Class