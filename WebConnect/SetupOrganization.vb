Public Class SetupOrganization
    Private allowExit As Boolean = False
    Private Sub SetupOrganization_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not allowExit AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub
    Private Sub SetupOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        allowExit = True
        Me.Close()
        SetupPassword.Close()
        WebConnectAdminSoftware.Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        My.Settings.OrganizationName = OrganizationNameText.Text
        My.Settings.OrganizationMode = True
        allowExit = True
        Me.Close()
    End Sub
End Class