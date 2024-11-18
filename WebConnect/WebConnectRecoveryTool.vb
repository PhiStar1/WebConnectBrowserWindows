Public Class WebConnectRecoveryTool
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ResetSettings.ShowDialog()
        Catch ex As Exception
            ResetSettingsnotavailable.ShowDialog()

        End Try


    End Sub

    Private Sub WebConnectRecoveryTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class