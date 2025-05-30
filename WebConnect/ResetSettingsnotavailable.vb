Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32
Public Class ResetSettingsnotavailable
    Private Sub ResetSettingsnotavailable_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub ResetSettingsnotavailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class