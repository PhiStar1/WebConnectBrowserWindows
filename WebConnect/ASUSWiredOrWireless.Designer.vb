<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ASUSWiredOrWireless
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
        WLAN = New Button()
        LAN = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(8, 5)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 148)
        Label1.TabIndex = 0
        Label1.Text = "Ist dein ASUS-Gerät " & vbCrLf & "  kabellos (WLAN) oder per " & vbCrLf & "    Kabel (LAN) am PC " & vbCrLf & "      angeschlossen?"
        ' 
        ' WLAN
        ' 
        WLAN.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WLAN.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        WLAN.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        WLAN.Location = New Point(-2, 151)
        WLAN.Margin = New Padding(1, 1, 1, 1)
        WLAN.Name = "WLAN"
        WLAN.Size = New Size(210, 31)
        WLAN.TabIndex = 1
        WLAN.Text = "WLAN"
        WLAN.UseVisualStyleBackColor = False
        ' 
        ' LAN
        ' 
        LAN.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        LAN.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        LAN.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        LAN.Location = New Point(206, 151)
        LAN.Margin = New Padding(1, 1, 1, 1)
        LAN.Name = "LAN"
        LAN.Size = New Size(224, 31)
        LAN.TabIndex = 2
        LAN.Text = "LAN"
        LAN.UseVisualStyleBackColor = False
        ' 
        ' ASUSWiredOrWireless
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(430, 192)
        Controls.Add(LAN)
        Controls.Add(WLAN)
        Controls.Add(Label1)
        Margin = New Padding(1, 1, 1, 1)
        MaximizeBox = False
        Name = "ASUSWiredOrWireless"
        Text = "Verbindungsart vom ASUS-Gerät"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents WLAN As Button
    Friend WithEvents LAN As Button
End Class
