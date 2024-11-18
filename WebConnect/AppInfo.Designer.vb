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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AppInfo))
        Description = New Label()
        TwitchLink = New LinkLabel()
        YouTubeLink = New LinkLabel()
        TikTokLink = New LinkLabel()
        InstaLink = New LinkLabel()
        ExitAppInfo = New Button()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.Font = New Font("SamsungOneUILatin 700", 10F, FontStyle.Bold, GraphicsUnit.Point)
        Description.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Description.Location = New Point(13, 10)
        Description.Name = "Description"
        Description.Size = New Size(0, 27)
        Description.TabIndex = 0
        ' 
        ' TwitchLink
        ' 
        TwitchLink.AutoSize = True
        TwitchLink.Font = New Font("SamsungOneUILatin 700", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TwitchLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TwitchLink.Location = New Point(13, 851)
        TwitchLink.Margin = New Padding(2, 0, 2, 0)
        TwitchLink.Name = "TwitchLink"
        TwitchLink.Size = New Size(204, 27)
        TwitchLink.TabIndex = 1
        TwitchLink.TabStop = True
        TwitchLink.Text = "Twitch: philconnected"
        ' 
        ' YouTubeLink
        ' 
        YouTubeLink.AutoSize = True
        YouTubeLink.Font = New Font("SamsungOneUILatin 700", 10F, FontStyle.Bold, GraphicsUnit.Point)
        YouTubeLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        YouTubeLink.Location = New Point(13, 878)
        YouTubeLink.Margin = New Padding(2, 0, 2, 0)
        YouTubeLink.Name = "YouTubeLink"
        YouTubeLink.Size = New Size(225, 27)
        YouTubeLink.TabIndex = 2
        YouTubeLink.TabStop = True
        YouTubeLink.Text = "YouTube: PhilConnected"
        ' 
        ' TikTokLink
        ' 
        TikTokLink.AutoSize = True
        TikTokLink.Font = New Font("SamsungOneUILatin 700", 10F, FontStyle.Bold, GraphicsUnit.Point)
        TikTokLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TikTokLink.Location = New Point(13, 905)
        TikTokLink.Margin = New Padding(2, 0, 2, 0)
        TikTokLink.Name = "TikTokLink"
        TikTokLink.Size = New Size(203, 27)
        TikTokLink.TabIndex = 3
        TikTokLink.TabStop = True
        TikTokLink.Text = "TikTok: philconnected"
        ' 
        ' InstaLink
        ' 
        InstaLink.AutoSize = True
        InstaLink.Font = New Font("SamsungOneUILatin 700", 10F, FontStyle.Bold, GraphicsUnit.Point)
        InstaLink.LinkColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        InstaLink.Location = New Point(13, 932)
        InstaLink.Margin = New Padding(2, 0, 2, 0)
        InstaLink.Name = "InstaLink"
        InstaLink.Size = New Size(303, 27)
        InstaLink.TabIndex = 4
        InstaLink.TabStop = True
        InstaLink.Text = "Instagram: philconnected.official"
        ' 
        ' ExitAppInfo
        ' 
        ExitAppInfo.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        ExitAppInfo.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ExitAppInfo.Font = New Font("SamsungOneUILatin 700", 10F, FontStyle.Bold, GraphicsUnit.Point)
        ExitAppInfo.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ExitAppInfo.Location = New Point(13, 986)
        ExitAppInfo.Name = "ExitAppInfo"
        ExitAppInfo.Size = New Size(1108, 65)
        ExitAppInfo.TabIndex = 5
        ExitAppInfo.Text = "OK"
        ExitAppInfo.UseVisualStyleBackColor = False
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RichTextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RichTextBox1.Location = New Point(0, -4)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(1132, 841)
        RichTextBox1.TabIndex = 6
        RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        ' 
        ' AppInfo
        ' 
        AutoScaleDimensions = New SizeF(11F, 27F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1134, 1064)
        ControlBox = False
        Controls.Add(RichTextBox1)
        Controls.Add(ExitAppInfo)
        Controls.Add(InstaLink)
        Controls.Add(TikTokLink)
        Controls.Add(YouTubeLink)
        Controls.Add(TwitchLink)
        Controls.Add(Description)
        Font = New Font("SamsungOneUILatin 700", 10F, FontStyle.Bold, GraphicsUnit.Point)
        KeyPreview = True
        Location = New Point(9, 7)
        Name = "AppInfo"
        Text = "Über WebConnect"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Description As Label
    Friend WithEvents TwitchLink As LinkLabel
    Friend WithEvents YouTubeLink As LinkLabel
    Friend WithEvents TikTokLink As LinkLabel
    Friend WithEvents InstaLink As LinkLabel
    Friend WithEvents ExitAppInfo As Button
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
