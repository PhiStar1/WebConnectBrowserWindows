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
        Terminate = New Label()
        Label3 = New Label()
        SettingsTabPage = New TabControl()
        DisplaySettings = New TabPage()
        Language = New Label()
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
        DefaultChatBot = New Label()
        SoftwareUpdate = New TabPage()
        SearchForUpdatesOnApplicationBoot = New CheckBox()
        VersionInfo = New Label()
        SearchForSoftwareUpdate = New Button()
        Changelog = New RichTextBox()
        Version = New Label()
        SettingsTabPage.SuspendLayout()
        DisplaySettings.SuspendLayout()
        MagicAILinkButton.SuspendLayout()
        SoftwareUpdate.SuspendLayout()
        SuspendLayout()
        ' 
        ' Terminate
        ' 
        Terminate.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        Terminate.AutoSize = True
        Terminate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Terminate.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Terminate.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Terminate.Location = New Point(642, 418)
        Terminate.Name = "Terminate"
        Terminate.Size = New Size(153, 25)
        Terminate.TabIndex = 4
        Terminate.Text = "Settings.Close"
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(11, 419)
        Label3.Name = "Label3"
        Label3.Size = New Size(296, 25)
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
        SettingsTabPage.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        SettingsTabPage.Location = New Point(11, 12)
        SettingsTabPage.Name = "SettingsTabPage"
        SettingsTabPage.SelectedIndex = 0
        SettingsTabPage.Size = New Size(771, 403)
        SettingsTabPage.TabIndex = 7
        ' 
        ' DisplaySettings
        ' 
        DisplaySettings.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DisplaySettings.Controls.Add(Language)
        DisplaySettings.Controls.Add(German)
        DisplaySettings.Controls.Add(English)
        DisplaySettings.Controls.Add(Italiano)
        DisplaySettings.Controls.Add(Türkçe)
        DisplaySettings.Controls.Add(Español)
        DisplaySettings.Controls.Add(Français)
        DisplaySettings.Controls.Add(DefaultSearchEngine)
        DisplaySettings.Controls.Add(GoogleDefault)
        DisplaySettings.Controls.Add(BingDefault)
        DisplaySettings.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        DisplaySettings.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DisplaySettings.Location = New Point(4, 34)
        DisplaySettings.Name = "DisplaySettings"
        DisplaySettings.Padding = New Padding(3)
        DisplaySettings.Size = New Size(763, 365)
        DisplaySettings.TabIndex = 0
        DisplaySettings.Text = "Settings.DisplaySettings"
        ' 
        ' Language
        ' 
        Language.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Language.AutoSize = True
        Language.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Language.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Language.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Language.Location = New Point(4, 13)
        Language.Name = "Language"
        Language.Size = New Size(264, 25)
        Language.TabIndex = 15
        Language.Text = "DisplaySettings.Language"
        ' 
        ' German
        ' 
        German.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        German.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        German.Location = New Point(274, 13)
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
        English.Location = New Point(392, 13)
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
        Italiano.Location = New Point(274, 123)
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
        Türkçe.Location = New Point(392, 123)
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
        Español.Location = New Point(274, 72)
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
        Français.Location = New Point(392, 72)
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
        DefaultSearchEngine.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        DefaultSearchEngine.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DefaultSearchEngine.Location = New Point(3, 171)
        DefaultSearchEngine.Name = "DefaultSearchEngine"
        DefaultSearchEngine.Size = New Size(372, 25)
        DefaultSearchEngine.TabIndex = 8
        DefaultSearchEngine.Text = "DisplaySettings.DefaultSearchEngine"
        ' 
        ' GoogleDefault
        ' 
        GoogleDefault.AutoSize = True
        GoogleDefault.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        GoogleDefault.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        GoogleDefault.Location = New Point(274, 199)
        GoogleDefault.Name = "GoogleDefault"
        GoogleDefault.Size = New Size(106, 29)
        GoogleDefault.TabIndex = 1
        GoogleDefault.Text = "Google"
        GoogleDefault.UseVisualStyleBackColor = False
        ' 
        ' BingDefault
        ' 
        BingDefault.AutoSize = True
        BingDefault.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        BingDefault.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BingDefault.Location = New Point(274, 234)
        BingDefault.Name = "BingDefault"
        BingDefault.Size = New Size(80, 29)
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
        MagicAILinkButton.Controls.Add(DefaultChatBot)
        MagicAILinkButton.Location = New Point(4, 34)
        MagicAILinkButton.Name = "MagicAILinkButton"
        MagicAILinkButton.Size = New Size(763, 365)
        MagicAILinkButton.TabIndex = 2
        MagicAILinkButton.Text = "Settings.MagicAILinkButton"
        ' 
        ' GoogleGeminiRadioButton
        ' 
        GoogleGeminiRadioButton.AutoSize = True
        GoogleGeminiRadioButton.Location = New Point(354, 44)
        GoogleGeminiRadioButton.Name = "GoogleGeminiRadioButton"
        GoogleGeminiRadioButton.Size = New Size(179, 29)
        GoogleGeminiRadioButton.TabIndex = 3
        GoogleGeminiRadioButton.Text = "Google Gemini"
        GoogleGeminiRadioButton.UseVisualStyleBackColor = True
        ' 
        ' ChatGPTRadioButton
        ' 
        ChatGPTRadioButton.AutoSize = True
        ChatGPTRadioButton.Location = New Point(354, 81)
        ChatGPTRadioButton.Name = "ChatGPTRadioButton"
        ChatGPTRadioButton.Size = New Size(127, 29)
        ChatGPTRadioButton.TabIndex = 2
        ChatGPTRadioButton.Text = "ChatGPT"
        ChatGPTRadioButton.UseVisualStyleBackColor = True
        ' 
        ' MicrosoftCopilotRadioButton
        ' 
        MicrosoftCopilotRadioButton.AutoSize = True
        MicrosoftCopilotRadioButton.Location = New Point(354, 9)
        MicrosoftCopilotRadioButton.Name = "MicrosoftCopilotRadioButton"
        MicrosoftCopilotRadioButton.Size = New Size(199, 29)
        MicrosoftCopilotRadioButton.TabIndex = 1
        MicrosoftCopilotRadioButton.Text = "Microsoft Copilot"
        MicrosoftCopilotRadioButton.UseVisualStyleBackColor = True
        ' 
        ' DefaultChatBot
        ' 
        DefaultChatBot.AutoSize = True
        DefaultChatBot.Location = New Point(3, 11)
        DefaultChatBot.Name = "DefaultChatBot"
        DefaultChatBot.Size = New Size(345, 25)
        DefaultChatBot.TabIndex = 0
        DefaultChatBot.Text = "MagicAILinkButton.DefaultChatBot"
        ' 
        ' SoftwareUpdate
        ' 
        SoftwareUpdate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SoftwareUpdate.Controls.Add(Version)
        SoftwareUpdate.Controls.Add(SearchForUpdatesOnApplicationBoot)
        SoftwareUpdate.Controls.Add(VersionInfo)
        SoftwareUpdate.Controls.Add(SearchForSoftwareUpdate)
        SoftwareUpdate.Controls.Add(Changelog)
        SoftwareUpdate.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SoftwareUpdate.Location = New Point(4, 34)
        SoftwareUpdate.Name = "SoftwareUpdate"
        SoftwareUpdate.Padding = New Padding(3)
        SoftwareUpdate.Size = New Size(763, 365)
        SoftwareUpdate.TabIndex = 1
        SoftwareUpdate.Text = "Settings.SoftwareUpdate"
        ' 
        ' SearchForUpdatesOnApplicationBoot
        ' 
        SearchForUpdatesOnApplicationBoot.AutoSize = True
        SearchForUpdatesOnApplicationBoot.Location = New Point(3, 99)
        SearchForUpdatesOnApplicationBoot.Name = "SearchForUpdatesOnApplicationBoot"
        SearchForUpdatesOnApplicationBoot.Size = New Size(559, 29)
        SearchForUpdatesOnApplicationBoot.TabIndex = 9
        SearchForUpdatesOnApplicationBoot.Text = "SoftwareUpdate.SearchForUpdatesOnApplicationBoot"
        SearchForUpdatesOnApplicationBoot.UseVisualStyleBackColor = True
        ' 
        ' VersionInfo
        ' 
        VersionInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        VersionInfo.AutoSize = True
        VersionInfo.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        VersionInfo.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        VersionInfo.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        VersionInfo.Location = New Point(6, 6)
        VersionInfo.Name = "VersionInfo"
        VersionInfo.Size = New Size(282, 25)
        VersionInfo.TabIndex = 8
        VersionInfo.Text = "SoftwareUpdate.VersionInfo"
        ' 
        ' SearchForSoftwareUpdate
        ' 
        SearchForSoftwareUpdate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SearchForSoftwareUpdate.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SearchForSoftwareUpdate.Location = New Point(6, 305)
        SearchForSoftwareUpdate.Name = "SearchForSoftwareUpdate"
        SearchForSoftwareUpdate.Size = New Size(756, 48)
        SearchForSoftwareUpdate.TabIndex = 1
        SearchForSoftwareUpdate.Text = "SoftwareUpdate.SearchForSoftwareUpdate"
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
        Changelog.Text = "SoftwareUpdate.Changelog"
        ' 
        ' Version
        ' 
        Version.AutoSize = True
        Version.Location = New Point(6, 45)
        Version.Name = "Version"
        Version.Size = New Size(112, 25)
        Version.TabIndex = 10
        Version.Text = "xxxx.xx.xx"
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(796, 453)
        Controls.Add(SettingsTabPage)
        Controls.Add(Label3)
        Controls.Add(Terminate)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        KeyPreview = True
        Name = "Settings"
        Text = "WebConnect.Settings"
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

    Friend WithEvents Terminate As Label
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
    Friend WithEvents Language As Label
    Friend WithEvents Changelog As RichTextBox
    Friend WithEvents SearchForSoftwareUpdate As Button
    Friend WithEvents VersionInfo As Label
    Friend WithEvents SearchForUpdatesOnApplicationBoot As CheckBox
    Friend WithEvents MagicAILinkButton As TabPage
    Friend WithEvents GoogleGeminiRadioButton As RadioButton
    Friend WithEvents ChatGPTRadioButton As RadioButton
    Friend WithEvents MicrosoftCopilotRadioButton As RadioButton
    Friend WithEvents DefaultChatBot As Label
    Friend WithEvents Version As Label
End Class
