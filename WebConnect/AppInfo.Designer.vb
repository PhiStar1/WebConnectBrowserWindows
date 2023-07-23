<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppInfo
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
        Description = New Label()
        TwitchLink = New LinkLabel()
        YouTubeLink = New LinkLabel()
        TikTokLink = New LinkLabel()
        InstaLink = New LinkLabel()
        ExitAppInfo = New Button()
        SuspendLayout()
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.Location = New Point(12, 9)
        Description.Name = "Description"
        Description.Size = New Size(631, 160)
        Description.TabIndex = 0
        Description.Text = "App: WebConnect" & vbCrLf & "FrontEnd-Version: 1.0.0-015" & vbCrLf & "BackEnd: WebView2 (Microsoft.Web.WebView2.WinForms)" & vbCrLf & "BackEnd-Version: 1.0.1823.32" & vbCrLf & "Programmierer: PhilConnected (Phileas Melchert)" & vbCrLf
        ' 
        ' TwitchLink
        ' 
        TwitchLink.AutoSize = True
        TwitchLink.Location = New Point(12, 198)
        TwitchLink.Name = "TwitchLink"
        TwitchLink.Size = New Size(246, 32)
        TwitchLink.TabIndex = 1
        TwitchLink.TabStop = True
        TwitchLink.Text = "Twitch: philconnected"
        ' 
        ' YouTubeLink
        ' 
        YouTubeLink.AutoSize = True
        YouTubeLink.Location = New Point(12, 241)
        YouTubeLink.Name = "YouTubeLink"
        YouTubeLink.Size = New Size(274, 32)
        YouTubeLink.TabIndex = 2
        YouTubeLink.TabStop = True
        YouTubeLink.Text = "YouTube: PhilConnected"
        ' 
        ' TikTokLink
        ' 
        TikTokLink.AutoSize = True
        TikTokLink.Location = New Point(12, 285)
        TikTokLink.Name = "TikTokLink"
        TikTokLink.Size = New Size(246, 32)
        TikTokLink.TabIndex = 3
        TikTokLink.TabStop = True
        TikTokLink.Text = "TikTok: philconnected"
        ' 
        ' InstaLink
        ' 
        InstaLink.AutoSize = True
        InstaLink.Location = New Point(12, 328)
        InstaLink.Name = "InstaLink"
        InstaLink.Size = New Size(359, 32)
        InstaLink.TabIndex = 4
        InstaLink.TabStop = True
        InstaLink.Text = "Instagram: philconnected.official"
        ' 
        ' ExitAppInfo
        ' 
        ExitAppInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ExitAppInfo.Location = New Point(12, 363)
        ExitAppInfo.Name = "ExitAppInfo"
        ExitAppInfo.Size = New Size(776, 75)
        ExitAppInfo.TabIndex = 5
        ExitAppInfo.Text = "OK"
        ExitAppInfo.UseVisualStyleBackColor = True
        ' 
        ' AppInfo
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(ExitAppInfo)
        Controls.Add(InstaLink)
        Controls.Add(TikTokLink)
        Controls.Add(YouTubeLink)
        Controls.Add(TwitchLink)
        Controls.Add(Description)
        Name = "AppInfo"
        Text = "App-Info"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Description As Label
    Friend WithEvents TwitchLink As LinkLabel
    Friend WithEvents YouTubeLink As LinkLabel
    Friend WithEvents TikTokLink As LinkLabel
    Friend WithEvents InstaLink As LinkLabel
    Friend WithEvents ExitAppInfo As Button
End Class
