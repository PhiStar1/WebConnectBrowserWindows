Imports System.IO
Imports Microsoft.Win32

Public Class ConnectToNAS
    Private Sub ConnectToNAS(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
    End Sub
    Private Sub Synology_Click(sender As Object, e As EventArgs) Handles Synology.Click
        EnterQuickConnectID.ShowDialog()
    End Sub

    Private Sub ConnectToNAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()

    End Sub

    Private Sub QNAP_Click(sender As Object, e As EventArgs) Handles QNAP.Click
        Form1.AddNewTab("https://www.myqnapcloud.com/?lang=de")
        Close()
        Launcher.Close()

    End Sub

    Private Sub Buffalo_Click(sender As Object, e As EventArgs) Handles Buffalo.Click
        Form1.AddNewTab("https://buffalonas.com/index.php")
        Close()
        Launcher.Close()

    End Sub

    Private Sub WesternDigital_Click(sender As Object, e As EventArgs) Handles WesternDigital.Click
        Form1.AddNewTab("https://www.mycloud.com/#/")
        Close()
        Launcher.Close()

    End Sub

    Private Sub Asustor_Click(sender As Object, e As EventArgs) Handles Asustor.Click
        EnterCloudID.ShowDialog()
        'https://hallo.ezconnect.to/?lang=de-DE
    End Sub

    Private Sub FRITZNAS_Click(sender As Object, e As EventArgs) Handles FRITZNAS.Click
        EnterMyFRITZ_Adress.ShowDialog()
    End Sub

    Private Sub XigmaNAS_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ManualConnection_Click(sender As Object, e As EventArgs) Handles ManualConnection.Click
        EnterIPAdress.ShowDialog()
    End Sub
End Class