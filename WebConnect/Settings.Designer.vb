<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        SettingsTabPage = New TabControl()
        DisplaySettings = New TabPage()
        Label4 = New Label()
        German = New Button()
        English = New Button()
        Italiano = New Button()
        Türkçe = New Button()
        Español = New Button()
        Français = New Button()
        DefaultSearchEngine = New Label()
        GoogleDefault = New RadioButton()
        BingDefault = New RadioButton()
        MagicAILinkButton = New TabPage()
        GoogleGeminiRadioButton = New RadioButton()
        ChatGPTRadioButton = New RadioButton()
        MicrosoftCopilotRadioButton = New RadioButton()
        Label5 = New Label()
        SoftwareUpdate = New TabPage()
        SearchForUpdatesOnApplicationBoot = New CheckBox()
        VersionInfo = New Label()
        SearchForSoftwareUpdate = New Button()
        Changelog = New RichTextBox()
        SettingsTabPage.SuspendLayout()
        DisplaySettings.SuspendLayout()
        MagicAILinkButton.SuspendLayout()
        SoftwareUpdate.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Font = New Font("SamsungOneUILatin 700C", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(686, 418)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 27)
        Label2.TabIndex = 4
        Label2.Text = "Schließen"
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700C", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(6, 418)
        Label1.Name = "Label1"
        Label1.Size = New Size(171, 27)
        Label1.TabIndex = 5
        Label1.Text = "Wiederherstellung"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Font = New Font("SamsungOneUILatin 700C", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(167, 418)
        Label3.Name = "Label3"
        Label3.Size = New Size(257, 27)
        Label3.TabIndex = 6
        Label3.Text = "WebConnect Admin Software"
        Label3.Visible = False
        ' 
        ' SettingsTabPage
        ' 
        SettingsTabPage.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        SettingsTabPage.Controls.Add(DisplaySettings)
        SettingsTabPage.Controls.Add(MagicAILinkButton)
        SettingsTabPage.Controls.Add(SoftwareUpdate)
        SettingsTabPage.Font = New Font("SamsungOneUILatin 700C", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        SettingsTabPage.Location = New Point(11, 12)
        SettingsTabPage.Name = "SettingsTabPage"
        SettingsTabPage.SelectedIndex = 0
        SettingsTabPage.Size = New Size(771, 403)
        SettingsTabPage.TabIndex = 7
        ' 
        ' DisplaySettings
        ' 
        DisplaySettings.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DisplaySettings.Controls.Add(Label4)
        DisplaySettings.Controls.Add(German)
        DisplaySettings.Controls.Add(English)
        DisplaySettings.Controls.Add(Italiano)
        DisplaySettings.Controls.Add(Türkçe)
        DisplaySettings.Controls.Add(Español)
        DisplaySettings.Controls.Add(Français)
        DisplaySettings.Controls.Add(DefaultSearchEngine)
        DisplaySettings.Controls.Add(GoogleDefault)
        DisplaySettings.Controls.Add(BingDefault)
        DisplaySettings.Font = New Font("SamsungOneUILatin 700", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        DisplaySettings.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DisplaySettings.Location = New Point(4, 36)
        DisplaySettings.Name = "DisplaySettings"
        DisplaySettings.Padding = New Padding(3)
        DisplaySettings.Size = New Size(763, 363)
        DisplaySettings.TabIndex = 0
        DisplaySettings.Text = "Anzeige & Sprache"
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.Font = New Font("SamsungOneUILatin 700C", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Location = New Point(6, 13)
        Label4.Name = "Label4"
        Label4.Size = New Size(80, 27)
        Label4.TabIndex = 15
        Label4.Text = "Sprache"
        ' 
        ' German
        ' 
        German.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        German.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        German.Location = New Point(221, 13)
        German.Name = "German"
        German.Size = New Size(111, 52)
        German.TabIndex = 14
        German.Text = "Deutsch"
        German.UseVisualStyleBackColor = False
        ' 
        ' English
        ' 
        English.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        English.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        English.Location = New Point(339, 13)
        English.Name = "English"
        English.Size = New Size(111, 52)
        English.TabIndex = 13
        English.Text = "English"
        English.UseVisualStyleBackColor = False
        ' 
        ' Italiano
        ' 
        Italiano.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Italiano.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Italiano.Location = New Point(221, 123)
        Italiano.Name = "Italiano"
        Italiano.Size = New Size(111, 45)
        Italiano.TabIndex = 12
        Italiano.Text = "Italiano"
        Italiano.UseVisualStyleBackColor = False
        ' 
        ' Türkçe
        ' 
        Türkçe.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Türkçe.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Türkçe.Location = New Point(339, 123)
        Türkçe.Name = "Türkçe"
        Türkçe.Size = New Size(111, 45)
        Türkçe.TabIndex = 11
        Türkçe.Text = "Türkçe"
        Türkçe.UseVisualStyleBackColor = False
        ' 
        ' Español
        ' 
        Español.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Español.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Español.Location = New Point(221, 72)
        Español.Name = "Español"
        Español.Size = New Size(111, 45)
        Español.TabIndex = 10
        Español.Text = "Español"
        Español.UseVisualStyleBackColor = False
        ' 
        ' Français
        ' 
        Français.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Français.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Français.Location = New Point(339, 72)
        Français.Name = "Français"
        Français.Size = New Size(111, 45)
        Français.TabIndex = 9
        Français.Text = "Français"
        Français.UseVisualStyleBackColor = False
        ' 
        ' DefaultSearchEngine
        ' 
        DefaultSearchEngine.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        DefaultSearchEngine.AutoSize = True
        DefaultSearchEngine.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DefaultSearchEngine.Font = New Font("SamsungOneUILatin 700C", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        DefaultSearchEngine.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DefaultSearchEngine.Location = New Point(6, 175)
        DefaultSearchEngine.Name = "DefaultSearchEngine"
        DefaultSearchEngine.Size = New Size(210, 27)
        DefaultSearchEngine.TabIndex = 8
        DefaultSearchEngine.Text = "Standardsuchmaschine"
        ' 
        ' GoogleDefault
        ' 
        GoogleDefault.AutoSize = True
        GoogleDefault.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GoogleDefault.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GoogleDefault.Location = New Point(221, 175)
        GoogleDefault.Name = "GoogleDefault"
        GoogleDefault.Size = New Size(100, 31)
        GoogleDefault.TabIndex = 1
        GoogleDefault.Text = "Google"
        GoogleDefault.UseVisualStyleBackColor = False
        ' 
        ' BingDefault
        ' 
        BingDefault.AutoSize = True
        BingDefault.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BingDefault.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BingDefault.Location = New Point(221, 210)
        BingDefault.Name = "BingDefault"
        BingDefault.Size = New Size(77, 31)
        BingDefault.TabIndex = 0
        BingDefault.Text = "Bing"
        BingDefault.UseVisualStyleBackColor = False
        ' 
        ' MagicAILinkButton
        ' 
        MagicAILinkButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MagicAILinkButton.Controls.Add(GoogleGeminiRadioButton)
        MagicAILinkButton.Controls.Add(ChatGPTRadioButton)
        MagicAILinkButton.Controls.Add(MicrosoftCopilotRadioButton)
        MagicAILinkButton.Controls.Add(Label5)
        MagicAILinkButton.Location = New Point(4, 36)
        MagicAILinkButton.Name = "MagicAILinkButton"
        MagicAILinkButton.Size = New Size(763, 363)
        MagicAILinkButton.TabIndex = 2
        MagicAILinkButton.Text = "Magic AI Link"
        ' 
        ' GoogleGeminiRadioButton
        ' 
        GoogleGeminiRadioButton.AutoSize = True
        GoogleGeminiRadioButton.Location = New Point(163, 48)
        GoogleGeminiRadioButton.Name = "GoogleGeminiRadioButton"
        GoogleGeminiRadioButton.Size = New Size(159, 31)
        GoogleGeminiRadioButton.TabIndex = 3
        GoogleGeminiRadioButton.Text = "Google Gemini"
        GoogleGeminiRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ChatGPTRadioButton
        ' 
        ChatGPTRadioButton.AutoSize = True
        ChatGPTRadioButton.Location = New Point(163, 85)
        ChatGPTRadioButton.Name = "ChatGPTRadioButton"
        ChatGPTRadioButton.Size = New Size(109, 31)
        ChatGPTRadioButton.TabIndex = 2
        ChatGPTRadioButton.Text = "ChatGPT"
        ChatGPTRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MicrosoftCopilotRadioButton
        ' 
        MicrosoftCopilotRadioButton.AutoSize = True
        MicrosoftCopilotRadioButton.Location = New Point(163, 11)
        MicrosoftCopilotRadioButton.Name = "MicrosoftCopilotRadioButton"
        MicrosoftCopilotRadioButton.Size = New Size(181, 31)
        MicrosoftCopilotRadioButton.TabIndex = 1
        MicrosoftCopilotRadioButton.Text = "Microsoft Copilot"
        MicrosoftCopilotRadioButton.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(3, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(154, 27)
        Label5.TabIndex = 0
        Label5.Text = "Standardchatbot"
        ' 
        ' SoftwareUpdate
        ' 
        SoftwareUpdate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SoftwareUpdate.Controls.Add(SearchForUpdatesOnApplicationBoot)
        SoftwareUpdate.Controls.Add(VersionInfo)
        SoftwareUpdate.Controls.Add(SearchForSoftwareUpdate)
        SoftwareUpdate.Controls.Add(Changelog)
        SoftwareUpdate.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SoftwareUpdate.Location = New Point(4, 36)
        SoftwareUpdate.Name = "SoftwareUpdate"
        SoftwareUpdate.Padding = New Padding(3)
        SoftwareUpdate.Size = New Size(763, 363)
        SoftwareUpdate.TabIndex = 1
        SoftwareUpdate.Text = "Software-Update"
        ' 
        ' SearchForUpdatesOnApplicationBoot
        ' 
        SearchForUpdatesOnApplicationBoot.AutoSize = True
        SearchForUpdatesOnApplicationBoot.Location = New Point(6, 63)
        SearchForUpdatesOnApplicationBoot.Name = "SearchForUpdatesOnApplicationBoot"
        SearchForUpdatesOnApplicationBoot.Size = New Size(302, 58)
        SearchForUpdatesOnApplicationBoot.TabIndex = 9
        SearchForUpdatesOnApplicationBoot.Text = "Beim Start immer automatisch " & vbCrLf & "nach Software-Updates suchen"
        SearchForUpdatesOnApplicationBoot.UseVisualStyleBackColor = True
        ' 
        ' VersionInfo
        ' 
        VersionInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        VersionInfo.AutoSize = True
        VersionInfo.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        VersionInfo.Font = New Font("SamsungOneUILatin 700C", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        VersionInfo.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        VersionInfo.Location = New Point(6, 6)
        VersionInfo.Name = "VersionInfo"
        VersionInfo.Size = New Size(319, 54)
        VersionInfo.TabIndex = 8
        VersionInfo.Text = "Aktuell installierte Softwareversion:" & vbCrLf & "2024.12.27"
        ' 
        ' SearchForSoftwareUpdate
        ' 
        SearchForSoftwareUpdate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SearchForSoftwareUpdate.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SearchForSoftwareUpdate.Location = New Point(6, 305)
        SearchForSoftwareUpdate.Name = "SearchForSoftwareUpdate"
        SearchForSoftwareUpdate.Size = New Size(756, 48)
        SearchForSoftwareUpdate.TabIndex = 1
        SearchForSoftwareUpdate.Text = "Nach Softwareupdates suchen"
        SearchForSoftwareUpdate.UseVisualStyleBackColor = False
        ' 
        ' Changelog
        ' 
        Changelog.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Changelog.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Changelog.Location = New Point(366, 3)
        Changelog.Name = "Changelog"
        Changelog.ReadOnly = True
        Changelog.Size = New Size(398, 296)
        Changelog.TabIndex = 0
        Changelog.Text = resources.GetString("Changelog.Text")
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(796, 453)
        Controls.Add(SettingsTabPage)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Label2)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        KeyPreview = True
        Name = "Settings"
        Text = "Settings"
        SettingsTabPage.ResumeLayout(False)
        DisplaySettings.ResumeLayout(False)
        DisplaySettings.PerformLayout()
        MagicAILinkButton.ResumeLayout(False)
        MagicAILinkButton.PerformLayout()
        SoftwareUpdate.ResumeLayout(False)
        SoftwareUpdate.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SettingsTabPage As TabControl
    Friend WithEvents DisplaySettings As TabPage
    Friend WithEvents SoftwareUpdate As TabPage
    Friend WithEvents DefaultSearchEngine As Label
    Friend WithEvents GoogleDefault As RadioButton
    Friend WithEvents BingDefault As RadioButton
    Friend WithEvents Français As Button
    Friend WithEvents German As Button
    Friend WithEvents English As Button
    Friend WithEvents Italiano As Button
    Friend WithEvents Türkçe As Button
    Friend WithEvents Español As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Changelog As RichTextBox
    Friend WithEvents SearchForSoftwareUpdate As Button
    Friend WithEvents VersionInfo As Label
    Friend WithEvents SearchForUpdatesOnApplicationBoot As CheckBox
    Friend WithEvents MagicAILinkButton As TabPage
    Friend WithEvents GoogleGeminiRadioButton As RadioButton
    Friend WithEvents ChatGPTRadioButton As RadioButton
    Friend WithEvents MicrosoftCopilotRadioButton As RadioButton
    Friend WithEvents Label5 As Label
End Class
