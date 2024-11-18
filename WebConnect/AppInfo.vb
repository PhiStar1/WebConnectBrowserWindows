Imports System.Diagnostics.Metrics
Imports System.Threading.Channels
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class AppInfo
    Private _mainForm As Form1
    Private Sub AppInfo(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
    End Sub
    Public Sub New(mainForm As Form1)

        'Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()
        _mainForm = mainForm

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub
    Private Sub TwitchLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TwitchLink.LinkClicked
        Try
            Form1.AddNewTab("https://www.twitch.tv/philconnected")
            Me.Close()
        Catch ex As Exception
            ErrorWhileLoadingThisLink.ShowDialog()

        End Try

    End Sub

    Private Sub YouTubeLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles YouTubeLink.LinkClicked
        Try
            Form1.AddNewTab("https://www.youtube.com/@philconnected")
            Me.Close()
        Catch ex As Exception
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try

    End Sub

    Private Sub TikTokLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TikTokLink.LinkClicked
        Try
            Form1.AddNewTab("https://www.tiktok.com/@philconnected")
            Me.Close()
        Catch ex As Exception
            ErrorWhileLoadingThisLink.ShowDialog()

        End Try

    End Sub

    Private Sub InstaLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InstaLink.LinkClicked
        Try
            Form1.AddNewTab("https://www.instagram.com/philconnected.official/")
            Me.Close()
        Catch ex As Exception
            ErrorWhileLoadingThisLink.ShowDialog()

        End Try


    End Sub

    Private Sub ExitAppInfo_Click(sender As Object, e As EventArgs) Handles ExitAppInfo.Click
        Me.Close()
    End Sub

    Private Sub AppInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Description_Click(sender As Object, e As EventArgs) Handles Description.Click

    End Sub
End Class