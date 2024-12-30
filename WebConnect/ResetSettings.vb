Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Win32

Public Class ResetSettings
    Private Sub ResetSettings_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        If e.KeyCode = Keys.Enter Then

            If TextBox1.Text = "RESET SETTINGS" Then
                Try
                    ResettingSettings.ShowDialog()
                Catch ex As Exception
                    ResettingSettingsnotavailable.ShowDialog()

                End Try


            End If
        End If
    End Sub
    Private Sub ResetSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class