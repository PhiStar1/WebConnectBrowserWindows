Public Class BootError
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub BootError_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Restart()
    End Sub
End Class