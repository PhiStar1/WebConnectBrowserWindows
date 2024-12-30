Imports System.Net
Imports System.Net.Http
Imports System.Net.WebRequestMethods
Imports System.Reflection.Emit
Imports Microsoft.CodeAnalysis.CSharp.Syntax
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports Newtonsoft.Json
Public Class Settings
    Public PendingAIChanges As Boolean
    Private clickLabelCounter = 0
    Private WithEvents Timer As New Timer()
    Private Sub Settings_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MicrosoftCopilotRadioButton.Checked = False
        GoogleGeminiRadioButton.Checked = False
        ChatGPTRadioButton.Checked = False
        Select Case My.Settings.DefaultSearchEngine
            Case "Google"
                GoogleDefault.Checked = True
            Case "Bing"
                BingDefault.Checked = True

        End Select
        Select Case My.Settings.DefaultAIEngine
            Case "Microsoft Copilot"
                MicrosoftCopilotRadioButton.Checked = True
            Case "Google Gemini"
                GoogleGeminiRadioButton.Checked = True
            Case "ChatGPT"
                ChatGPTRadioButton.Checked = True
            Case Else
                ' Fallback für ungültige Werte
                MicrosoftCopilotRadioButton.Checked = True
        End Select
        If My.Settings.AutomaticSoftwareUpdateNotification = True Then
            SearchForUpdatesOnApplicationBoot.Checked = True
        End If
        If My.Settings.AutomaticSoftwareUpdateNotification = False Then
            SearchForUpdatesOnApplicationBoot.Checked = False
        End If
        Timer.Interval = 2000
        Timer.Stop()
        WebConnectAdminSoftware.Visible = False
    End Sub






    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        WebConnectRecoveryTool.ShowDialog()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        WebConnectAdminSoftware.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub German_Click(sender As Object, e As EventArgs) Handles German.Click
        My.Settings.Sprache = "Deutsch"
        Application.Restart()
    End Sub

    Private Sub English_Click(sender As Object, e As EventArgs) Handles English.Click
        My.Settings.Sprache = "English"
        Application.Restart()

    End Sub

    Private Sub SoftwareUpdate_Click(sender As Object, e As EventArgs) Handles SoftwareUpdate.Click

    End Sub

    Private Sub VersionInfo_Click(sender As Object, e As EventArgs) Handles VersionInfo.Click
        clickLabelCounter += 1
        If clickLabelCounter = 1 Then
            Timer.Start()
        End If
        If clickLabelCounter >= 5 Then
            Timer.Stop()
            Label3.Visible = True
            clickLabelCounter = 0
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        clickLabelCounter = 0
        Timer.Stop()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Français.Click
        My.Settings.Sprache = "Français"
        Application.Restart()
    End Sub

    Private Sub Español_Click(sender As Object, e As EventArgs) Handles Español.Click
        My.Settings.Sprache = "Español"
        Application.Restart()
    End Sub

    Private Sub Italiano_Click(sender As Object, e As EventArgs) Handles Italiano.Click
        My.Settings.Sprache = "Italiano"
        Application.Restart()
    End Sub

    Private Sub Türkçe_Click(sender As Object, e As EventArgs) Handles Türkçe.Click
        My.Settings.Sprache = "Türkçe"
        Application.Restart()
    End Sub

    Private Async Sub SearchForSoftwareUpdate_Click(sender As Object, e As EventArgs) Handles SoftwareUpdate.Click

    End Sub

    Private Sub GoogleDefault_CheckedChanged(sender As Object, e As EventArgs) Handles GoogleDefault.CheckedChanged
        If GoogleDefault.Checked Then
            My.Settings.DefaultSearchEngine = "Google"
        End If
    End Sub

    Private Sub BingDefault_CheckedChanged(sender As Object, e As EventArgs) Handles BingDefault.CheckedChanged
        If BingDefault.Checked Then
            My.Settings.DefaultSearchEngine = "Bing"
        End If
    End Sub

    Private Sub SearchForSoftwareUpdate_Click_1(sender As Object, e As EventArgs) Handles SearchForSoftwareUpdate.Click
        SoftwareUpdateTool.ShowDialog()
    End Sub

    Public Sub OpenMacroEditor()
        ' Initialisiere MacroEditor und übergebe die aktuelle Instanz von Form1
        'MacroEditor = New MacroEditor(Form1)
        'MacroEditor.Show()
    End Sub

    Private Sub RunMacroEditor_Click(sender As Object, e As EventArgs)
        OpenMacroEditor()

    End Sub

    Private Sub SearchForUpdatesOnApplicationBoot_CheckedChanged(sender As Object, e As EventArgs) Handles SearchForUpdatesOnApplicationBoot.CheckedChanged
        If SearchForUpdatesOnApplicationBoot.Checked = True Then
            My.Settings.AutomaticSoftwareUpdateNotification = True
        End If
        If SearchForUpdatesOnApplicationBoot.Checked = False Then
            My.Settings.AutomaticSoftwareUpdateNotification = False
        End If

    End Sub

    Private Sub MicrosoftCopilotRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MicrosoftCopilotRadioButton.CheckedChanged
        If MicrosoftCopilotRadioButton.Checked = True Then
            My.Settings.DefaultAIEngine = "Microsoft Copilot"
            PendingAIChanges = True
            My.Settings.Save()

            If Form1.AIWebView IsNot Nothing Then
                Form1.AIWebView.CoreWebView2.Navigate("https://copilot.microsoft.com/")
                PendingAIChanges = False
            End If
        End If
        If GoogleGeminiRadioButton.Checked = True Then
            My.Settings.DefaultAIEngine = "Google Gemini"
            PendingAIChanges = True
            My.Settings.Save()

            If Form1.AIWebView IsNot Nothing Then
                Form1.AIWebView.CoreWebView2.Navigate("https://gemini.google.com/app?hl=de")
                PendingAIChanges = False

            End If
        End If
        If ChatGPTRadioButton.Checked = True Then
            My.Settings.DefaultAIEngine = "ChatGPT"
            PendingAIChanges = True
            My.Settings.Save()

            If Form1.AIWebView IsNot Nothing Then
                Form1.AIWebView.CoreWebView2.Navigate("https://chatgpt.com/")
                PendingAIChanges = False

            End If
        End If
    End Sub








    ' Die Funktion muss asynchron sein, daher die Rückgabe von Task(Of String)
End Class