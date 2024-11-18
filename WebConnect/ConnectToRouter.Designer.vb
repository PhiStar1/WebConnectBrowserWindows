<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectToRouter
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
        Label1 = New Label()
        ASUS = New Button()
        Google = New Button()
        DLink = New Button()
        Cisco = New Button()
        tplink = New Button()
        Synology = New Button()
        FRITZBox = New Button()
        AppleAirport = New Button()
        Vodafone = New Button()
        TelekomSpeedport = New Button()
        ManualConnection = New Label()
        Cancel = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(314, 106)
        Label1.TabIndex = 0
        Label1.Text = "Welchen Router " & vbCrLf & "  benutzt du?"
        ' 
        ' ASUS
        ' 
        ASUS.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ASUS.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ASUS.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ASUS.Location = New Point(13, 118)
        ASUS.Name = "ASUS"
        ASUS.Size = New Size(112, 34)
        ASUS.TabIndex = 1
        ASUS.Text = "ASUS"
        ASUS.UseVisualStyleBackColor = False
        ' 
        ' Google
        ' 
        Google.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Google.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Google.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Google.Location = New Point(334, 158)
        Google.Name = "Google"
        Google.Size = New Size(145, 34)
        Google.TabIndex = 2
        Google.Text = "Google"
        Google.UseVisualStyleBackColor = False
        ' 
        ' DLink
        ' 
        DLink.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DLink.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DLink.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DLink.Location = New Point(171, 158)
        DLink.Name = "DLink"
        DLink.Size = New Size(157, 34)
        DLink.TabIndex = 3
        DLink.Text = "D-Link"
        DLink.UseVisualStyleBackColor = False
        ' 
        ' Cisco
        ' 
        Cisco.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cisco.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Cisco.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cisco.Location = New Point(13, 158)
        Cisco.Name = "Cisco"
        Cisco.Size = New Size(152, 34)
        Cisco.TabIndex = 7
        Cisco.Text = "Cisco"
        Cisco.UseVisualStyleBackColor = False
        ' 
        ' tplink
        ' 
        tplink.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        tplink.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        tplink.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        tplink.Location = New Point(367, 118)
        tplink.Name = "tplink"
        tplink.Size = New Size(112, 34)
        tplink.TabIndex = 8
        tplink.Text = "tp-link"
        tplink.UseVisualStyleBackColor = False
        ' 
        ' Synology
        ' 
        Synology.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Synology.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Synology.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Synology.Location = New Point(249, 118)
        Synology.Name = "Synology"
        Synology.Size = New Size(112, 34)
        Synology.TabIndex = 9
        Synology.Text = "Synology"
        Synology.UseVisualStyleBackColor = False
        ' 
        ' FRITZBox
        ' 
        FRITZBox.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FRITZBox.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        FRITZBox.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FRITZBox.Location = New Point(131, 118)
        FRITZBox.Name = "FRITZBox"
        FRITZBox.Size = New Size(112, 34)
        FRITZBox.TabIndex = 10
        FRITZBox.Text = "FRITZ!Box"
        FRITZBox.UseVisualStyleBackColor = False
        ' 
        ' AppleAirport
        ' 
        AppleAirport.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        AppleAirport.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        AppleAirport.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        AppleAirport.Location = New Point(249, 238)
        AppleAirport.Name = "AppleAirport"
        AppleAirport.Size = New Size(230, 34)
        AppleAirport.TabIndex = 13
        AppleAirport.Text = "Apple Airport"
        AppleAirport.UseVisualStyleBackColor = False
        ' 
        ' Vodafone
        ' 
        Vodafone.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Vodafone.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Vodafone.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Vodafone.Location = New Point(13, 238)
        Vodafone.Name = "Vodafone"
        Vodafone.Size = New Size(230, 34)
        Vodafone.TabIndex = 14
        Vodafone.Text = "Vodafone"
        Vodafone.UseVisualStyleBackColor = False
        ' 
        ' TelekomSpeedport
        ' 
        TelekomSpeedport.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        TelekomSpeedport.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TelekomSpeedport.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        TelekomSpeedport.Location = New Point(13, 198)
        TelekomSpeedport.Name = "TelekomSpeedport"
        TelekomSpeedport.Size = New Size(466, 34)
        TelekomSpeedport.TabIndex = 15
        TelekomSpeedport.Text = "Telekom Speedport"
        TelekomSpeedport.UseVisualStyleBackColor = False
        ' 
        ' ManualConnection
        ' 
        ManualConnection.AutoSize = True
        ManualConnection.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ManualConnection.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ManualConnection.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ManualConnection.Location = New Point(13, 298)
        ManualConnection.Name = "ManualConnection"
        ManualConnection.Size = New Size(273, 25)
        ManualConnection.TabIndex = 16
        ManualConnection.Text = "Stattdessen IP-Adresse angeben"
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(435, 298)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(92, 25)
        Cancel.TabIndex = 17
        Cancel.Text = "Schließen"
        ' 
        ' ConnectToRouter
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(532, 329)
        Controls.Add(Cancel)
        Controls.Add(ManualConnection)
        Controls.Add(TelekomSpeedport)
        Controls.Add(Vodafone)
        Controls.Add(AppleAirport)
        Controls.Add(FRITZBox)
        Controls.Add(Synology)
        Controls.Add(tplink)
        Controls.Add(Cisco)
        Controls.Add(DLink)
        Controls.Add(Google)
        Controls.Add(ASUS)
        Controls.Add(Label1)
        Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "ConnectToRouter"
        Text = "Einen Router verbinden"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ASUS As Button
    Friend WithEvents Google As Button
    Friend WithEvents DLink As Button
    Friend WithEvents Cisco As Button
    Friend WithEvents tplink As Button
    Friend WithEvents Synology As Button
    Friend WithEvents FRITZBox As Button
    Friend WithEvents AppleAirport As Button
    Friend WithEvents Vodafone As Button
    Friend WithEvents TelekomSpeedport As Button
    Friend WithEvents ManualConnection As Label
    Friend WithEvents Cancel As Label
End Class
