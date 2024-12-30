<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InstallGoogleHome
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
        InstallQuestion = New Label()
        CancelInstall = New Button()
        Install = New Button()
        SelectOS = New Label()
        iPadOSoriOS = New Button()
        Android = New Button()
        SuspendLayout()
        ' 
        ' InstallQuestion
        ' 
        InstallQuestion.AutoSize = True
        InstallQuestion.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        InstallQuestion.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        InstallQuestion.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        InstallQuestion.Location = New Point(12, 9)
        InstallQuestion.Name = "InstallQuestion"
        InstallQuestion.Size = New Size(573, 212)
        InstallQuestion.TabIndex = 0
        InstallQuestion.Text = "Willst du die Google Home App" & vbCrLf & "  installieren (auf deinen " & vbCrLf & "    Smartphone oder " & vbCrLf & "      Tablet)?"
        ' 
        ' CancelInstall
        ' 
        CancelInstall.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CancelInstall.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        CancelInstall.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CancelInstall.Location = New Point(424, 386)
        CancelInstall.Name = "CancelInstall"
        CancelInstall.Size = New Size(382, 68)
        CancelInstall.TabIndex = 1
        CancelInstall.Text = "Nein"
        CancelInstall.UseVisualStyleBackColor = False
        ' 
        ' Install
        ' 
        Install.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Install.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Install.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Install.Location = New Point(-4, 386)
        Install.Name = "Install"
        Install.Size = New Size(432, 68)
        Install.TabIndex = 2
        Install.Text = "Ja"
        Install.UseVisualStyleBackColor = False
        ' 
        ' SelectOS
        ' 
        SelectOS.AutoSize = True
        SelectOS.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        SelectOS.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        SelectOS.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        SelectOS.Location = New Point(12, 9)
        SelectOS.Name = "SelectOS"
        SelectOS.Size = New Size(621, 318)
        SelectOS.TabIndex = 3
        SelectOS.Text = "Welches Betriebssystem hat dein " & vbCrLf & "  Smartphone oder Tablet?" & vbCrLf & "    Du brauchst mindestens die " & vbCrLf & "      Betriebssystemversion " & vbCrLf & "        iOS/iPadOS 15 " & vbCrLf & "          oder Android 9"
        SelectOS.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' iPadOSoriOS
        ' 
        iPadOSoriOS.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        iPadOSoriOS.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        iPadOSoriOS.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        iPadOSoriOS.Location = New Point(0, 386)
        iPadOSoriOS.Name = "iPadOSoriOS"
        iPadOSoriOS.Size = New Size(428, 68)
        iPadOSoriOS.TabIndex = 4
        iPadOSoriOS.Text = "iPadOS/iOS"
        iPadOSoriOS.UseVisualStyleBackColor = False
        ' 
        ' Android
        ' 
        Android.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Android.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Android.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Android.Location = New Point(424, 386)
        Android.Name = "Android"
        Android.Size = New Size(382, 68)
        Android.TabIndex = 5
        Android.Text = "Android"
        Android.UseVisualStyleBackColor = False
        ' 
        ' InstallGoogleHome
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 450)
        Controls.Add(Android)
        Controls.Add(iPadOSoriOS)
        Controls.Add(SelectOS)
        Controls.Add(Install)
        Controls.Add(CancelInstall)
        Controls.Add(InstallQuestion)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "InstallGoogleHome"
        Text = "Anwendungsinstallation auf Smartphone bzw. Tablet | Google Home"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents InstallQuestion As Label
    Friend WithEvents CancelInstall As Button
    Friend WithEvents Install As Button
    Friend WithEvents SelectOS As Label
    Friend WithEvents iPadOSoriOS As Button
    Friend WithEvents Android As Button
End Class
