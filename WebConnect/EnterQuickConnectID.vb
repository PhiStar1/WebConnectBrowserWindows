Public Class EnterQuickConnectID
    Private Sub EnterQuickConnectID_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Enter Then
            If QuickConnectID.Focused Then
                ConnectToQuickConnect()
            End If

        End If
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub
    Private Sub EnterQuickConnectID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuickConnectID_Click(sender As Object, e As EventArgs) Handles QuickConnectID.Click
        If QuickConnectID.Text = "QuickConnect-ID" Then
            QuickConnectID.Clear()

        End If
    End Sub

    Private Sub ConnectWithDSMButton_Click(sender As Object, e As EventArgs) Handles ConnectWithDSMButton.Click
        ConnectToQuickConnect()

    End Sub
    Private Function ConnectToQuickConnect()
        Try
            Form1.AddNewTab("https://" & QuickConnectID.Text & ".quickconnect.to")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()

        Catch ex As Exception
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try
    End Function
End Class