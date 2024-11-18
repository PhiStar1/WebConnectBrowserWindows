Public Class EnterMyFRITZ_Adress
    Private Sub EnterMyFRITZ_Adress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub QuickConnectID_Click(sender As Object, e As EventArgs) Handles MyFRITZAdresse.Click
        If MyFRITZAdresse.Text = "MyFRITZ!-Adresse" Then
            MyFRITZAdresse.Clear()

        End If
    End Sub

    Private Sub ConnectWithDSMButton_Click(sender As Object, e As EventArgs) Handles MyFRITZAdresseButton.Click
        Try
            Form1.AddNewTab("https://" & MyFRITZAdresse.Text & ".myfritz.net:" & Port.Text & "/nas")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()
        Catch ex As Exception
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try

    End Sub
End Class