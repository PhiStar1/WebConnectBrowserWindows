Imports System.Diagnostics.Metrics
Imports System.Threading.Channels
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Public Class AppInfo
    Private _mainForm As Form1
    Private Sub AppInfo(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine("Start of sub: AppInfo(sender As Object, e As KeyPressEventArgs)")
        Debug.WriteLine($"  If e.KeyChar =Convert.ToChar(Keys.Escape)")
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Debug.WriteLine("   e.KeyChar = " & e.KeyChar)
            Me.Close()
            Debug.WriteLine("       Me.Close()")
            Debug.WriteLine("   End If")
        End If
        Debug.WriteLine("End of sub: AppInfo(sender As Object, e As KeyPressEventArgs)")
    End Sub
    Public Sub New(mainForm As Form1)
        Debug.WriteLine("Start of sub: New(mainForm As Form1)")

        ' Dieser Aufruf ist für den Designer erforderlich.
        Debug.WriteLine("    InitializeComponent()")
        InitializeComponent()

        Debug.WriteLine("    _mainForm = mainForm")
        _mainForm = mainForm

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.


        Debug.WriteLine("End of sub: New(mainForm As Form1)")
    End Sub
    Private Sub TwitchLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TwitchLink.LinkClicked
        Debug.WriteLine("Start of sub: TwitchLink_LinkClicked")
        Try
            Debug.WriteLine("    Form1.AddNewTab('https://www.twitch.tv/philconnected')")
            Form1.AddNewTab("https://www.twitch.tv/philconnected")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: TwitchLink_LinkClicked")
    End Sub

    Private Sub YouTubeLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles YouTubeLink.LinkClicked
        Debug.WriteLine("Start of sub: YouTubeLink_LinkClicked")
        Try
            Debug.WriteLine("    Form1.AddNewTab('https://www.youtube.com/@philconnected')")
            Form1.AddNewTab("https://www.youtube.com/@philconnected")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: YouTubeLink_LinkClicked")
    End Sub

    Private Sub TikTokLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TikTokLink.LinkClicked
        Debug.WriteLine("Start of sub: TikTokLink_LinkClicked")
        Try
            Debug.WriteLine("    Form1.AddNewTab('https://www.tiktok.com/@philconnected')")
            Form1.AddNewTab("https://www.tiktok.com/@philconnected")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: TikTokLink_LinkClicked")
    End Sub

    Private Sub InstaLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InstaLink.LinkClicked
        Debug.WriteLine("Start of sub: InstaLink_LinkClicked")
        Try
            Debug.WriteLine("    Form1.AddNewTab('https://www.instagram.com/philconnected.official/')")
            Form1.AddNewTab("https://www.instagram.com/philconnected.official/")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: InstaLink_LinkClicked")
    End Sub

    Private Sub ExitAppInfo_Click(sender As Object, e As EventArgs) Handles ExitAppInfo.Click
        Debug.WriteLine("Start of sub: ExitAppInfo_Click")
        Debug.WriteLine("    Me.Close()")
        Me.Close()
        Debug.WriteLine("End of sub: ExitAppInfo_Click")
    End Sub

    Private Sub AppInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Start of sub: AppInfo_Load")
        Debug.WriteLine("End of sub: AppInfo_Load")
    End Sub

    Private Sub Description_Click(sender As Object, e As EventArgs) Handles Description.Click
        Debug.WriteLine("Start of sub: Description_Click")
        Debug.WriteLine("End of sub: Description_Click")
    End Sub

End Class