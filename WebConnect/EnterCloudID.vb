Public Class EnterCloudID
    Private Sub EnterCloudID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuickConnectID_Click(sender As Object, e As EventArgs) Handles CloudID.Click
        If CloudID.Text = "Cloud ID" Then
            CloudID.Clear()

        End If
    End Sub

    Private Sub ConnectWithDSMButton_Click(sender As Object, e As EventArgs) Handles ConnectWithCloudIDButton.Click
        Try
            Form1.AddNewTab("https://" & CloudID.Text & ".ezconnect.to/?lang=de-DE")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()
        Catch ex As Exception
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try

    End Sub
End Class