Imports System.ComponentModel.Design.ObjectSelectorEditor

Public Class InstallGoogleHome
    Private Sub InstallGoogleHome(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
    Private Sub Install_Click(sender As Object, e As EventArgs) Handles Install.Click
        InstallQuestion.Hide()
        Install.Hide()
        CancelInstall.Hide()
        SelectOS.Show()
        iPadOSoriOS.Show()
        Android.Show()
    End Sub
    Private Sub CancelInstall_Click(sender As Object, e As EventArgs) Handles CancelInstall.Click
        Me.Close()
    End Sub

    Private Sub InstallGoogleHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InstallQuestion.Show()
        Install.Show()
        CancelInstall.Show()
        SelectOS.Hide()
        iPadOSoriOS.Hide()
        Android.Hide()
    End Sub

    Private Sub iPadOSoriOS_Click(sender As Object, e As EventArgs) Handles iPadOSoriOS.Click
        Form1.AddNewTab("https://apps.apple.com/de/app/google-home/id680819774")
        Me.Close()
        ConnectToRouter.Close()
        Launcher.Close()
    End Sub

    Private Sub Android_Click(sender As Object, e As EventArgs) Handles Android.Click
        Form1.AddNewTab("https://play.google.com/store/apps/details?id=com.google.android.apps.chromecast.app")
        Me.Close()
        ConnectToRouter.Close()
        Launcher.Close()
    End Sub
End Class