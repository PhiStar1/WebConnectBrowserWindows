Imports System.Net
Imports System.Net.Http
Imports System.Reflection.Emit
Imports Newtonsoft.Json
Public Class Settings
    Private clickLabelCounter = 0
    Private WithEvents Timer As New Timer()

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.DefaultSearchEngine = "Google" Then
            GoogleDefault.Checked = True
        End If
        If My.Settings.DefaultSearchEngine = "Bing" Then
            BingDefault.Checked = True
        End If

        Timer.Interval = 2000
        Timer.Stop()
        WebConnectAdminSoftware.Visible = False
    End Sub






    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        WebConnectRecoveryTool.ShowDialog

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







    ' Die Funktion muss asynchron sein, daher die Rückgabe von Task(Of String)
End Class