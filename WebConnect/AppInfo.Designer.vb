<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Public Class AppInfo
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Description = New Label()
        TwitchLink = New LinkLabel()
        YouTubeLink = New LinkLabel()
        TikTokLink = New LinkLabel()
        InstagramLink = New LinkLabel()
        ExitAppInfo = New Button()
        VersionInfo = New RichTextBox()
        SuspendLayout()
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        Description.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Description.Location = New Point(13, 10)
        Description.Name = "Description"
        Description.Size = New Size(0, 25)
        Description.TabIndex = 0
        ' 
        ' TwitchLink
        ' 
        TwitchLink.AutoSize = True
        TwitchLink.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        TwitchLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TwitchLink.Location = New Point(13, 851)
        TwitchLink.Margin = New Padding(2, 0, 2, 0)
        TwitchLink.Name = "TwitchLink"
        TwitchLink.Size = New Size(196, 25)
        TwitchLink.TabIndex = 1
        TwitchLink.TabStop = True
        TwitchLink.Text = "AppInfo.TwitchLink"
        ' 
        ' YouTubeLink
        ' 
        YouTubeLink.AutoSize = True
        YouTubeLink.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        YouTubeLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        YouTubeLink.Location = New Point(13, 878)
        YouTubeLink.Margin = New Padding(2, 0, 2, 0)
        YouTubeLink.Name = "YouTubeLink"
        YouTubeLink.Size = New Size(221, 25)
        YouTubeLink.TabIndex = 2
        YouTubeLink.TabStop = True
        YouTubeLink.Text = "AppInfo.YouTubeLink"
        ' 
        ' TikTokLink
        ' 
        TikTokLink.AutoSize = True
        TikTokLink.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        TikTokLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TikTokLink.Location = New Point(13, 905)
        TikTokLink.Margin = New Padding(2, 0, 2, 0)
        TikTokLink.Name = "TikTokLink"
        TikTokLink.Size = New Size(200, 25)
        TikTokLink.TabIndex = 3
        TikTokLink.TabStop = True
        TikTokLink.Text = "AppInfo.TikTokLink"
        ' 
        ' InstagramLink
        ' 
        InstagramLink.AutoSize = True
        InstagramLink.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        InstagramLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        InstagramLink.Location = New Point(13, 932)
        InstagramLink.Margin = New Padding(2, 0, 2, 0)
        InstagramLink.Name = "InstagramLink"
        InstagramLink.Size = New Size(228, 25)
        InstagramLink.TabIndex = 4
        InstagramLink.TabStop = True
        InstagramLink.Text = "AppInfo.InstagramLink"
        ' 
        ' ExitAppInfo
        ' 
        ExitAppInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ExitAppInfo.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ExitAppInfo.Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        ExitAppInfo.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ExitAppInfo.Location = New Point(13, 986)
        ExitAppInfo.Name = "ExitAppInfo"
        ExitAppInfo.Size = New Size(1108, 65)
        ExitAppInfo.TabIndex = 5
        ExitAppInfo.Text = "AppInfo.ExitAppInfo"
        ExitAppInfo.UseVisualStyleBackColor = False
        ' 
        ' VersionInfo
        ' 
        VersionInfo.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        VersionInfo.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        VersionInfo.Location = New Point(0, -4)
        VersionInfo.Name = "VersionInfo"
        VersionInfo.ReadOnly = True
        VersionInfo.Size = New Size(1132, 841)
        VersionInfo.TabIndex = 6
        VersionInfo.Text = "AppInfo.VersionInfo"
        ' 
        ' AppInfo
        ' 
        AutoScaleDimensions = New SizeF(13.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1134, 1064)
        ControlBox = False
        Controls.Add(VersionInfo)
        Controls.Add(ExitAppInfo)
        Controls.Add(InstagramLink)
        Controls.Add(TikTokLink)
        Controls.Add(YouTubeLink)
        Controls.Add(TwitchLink)
        Controls.Add(Description)
        Font = New Font("Microsoft Sans Serif", 10.0F, FontStyle.Bold, GraphicsUnit.Point)
        KeyPreview = True
        Location = New Point(9, 7)
        Name = "AppInfo"
        Text = "WebConnect.AppInfo"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Description As Label
    Friend WithEvents TwitchLink As LinkLabel
    Friend WithEvents YouTubeLink As LinkLabel
    Friend WithEvents TikTokLink As LinkLabel
    Friend WithEvents InstagramLink As LinkLabel
    Friend WithEvents ExitAppInfo As Button
    Friend WithEvents VersionInfo As RichTextBox
End Class
