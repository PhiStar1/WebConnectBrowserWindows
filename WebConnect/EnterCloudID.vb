Public Class EnterCloudID
    Private Sub EnterCloudID(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine("Gedrückt")
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Debug.WriteLine("enter Gedrückt")
            If CloudID.Focused Then
                ConnectToCloudID()
            End If
        End If
    End Sub
    Private Sub EnterCloudID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuickConnectID_Click(sender As Object, e As EventArgs) Handles CloudID.Click
        If CloudID.Text = "Cloud ID" Then
            CloudID.Clear()

        End If
    End Sub

    Private Sub ConnectWithDSMButton_Click(sender As Object, e As EventArgs) Handles ConnectWithCloudIDButton.Click
        ConnectToCloudID()

    End Sub
    Public Function ConnectToCloudID()
        Try
            Form1.AddNewTab("https://" & CloudID.Text & ".ezconnect.to/?lang=de-DE")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()
        Catch ex As Exception
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try
    End Function
End Class