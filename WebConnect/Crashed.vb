Public Class Crashed
    Private Sub Crashed_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub Showerrorcode(Errorcode As String)
        Label4.Text = "Fehlercode: " & Errorcode
    End Sub
End Class