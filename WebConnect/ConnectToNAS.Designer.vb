<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ConnectToNAS
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
        Cancel = New Label()
        ManualConnection = New Label()
        Label1 = New Label()
        Synology = New Button()
        WesternDigital = New Button()
        Buffalo = New Button()
        QNAP = New Button()
        FRITZNAS = New Button()
        Asustor = New Button()
        SuspendLayout()
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(538, 236)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(88, 22)
        Cancel.TabIndex = 30
        Cancel.Text = "Abbrechen"
        ' 
        ' ManualConnection
        ' 
        ManualConnection.AutoSize = True
        ManualConnection.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        ManualConnection.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ManualConnection.Location = New Point(12, 236)
        ManualConnection.Name = "ManualConnection"
        ManualConnection.Size = New Size(240, 22)
        ManualConnection.TabIndex = 29
        ManualConnection.Text = "Stattdessen IP-Adresse angeben"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(269, 106)
        Label1.TabIndex = 18
        Label1.Text = "Welchen NAS " & vbCrLf & "  benutzt du?"
        ' 
        ' Synology
        ' 
        Synology.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Synology.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Synology.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Synology.Location = New Point(12, 145)
        Synology.Name = "Synology"
        Synology.Size = New Size(112, 33)
        Synology.TabIndex = 31
        Synology.Text = "Synology"
        Synology.UseVisualStyleBackColor = False
        ' 
        ' WesternDigital
        ' 
        WesternDigital.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        WesternDigital.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        WesternDigital.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        WesternDigital.Location = New Point(366, 145)
        WesternDigital.Name = "WesternDigital"
        WesternDigital.Size = New Size(172, 33)
        WesternDigital.TabIndex = 32
        WesternDigital.Text = "Western-Digital"
        WesternDigital.UseVisualStyleBackColor = False
        ' 
        ' Buffalo
        ' 
        Buffalo.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Buffalo.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Buffalo.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Buffalo.Location = New Point(248, 145)
        Buffalo.Name = "Buffalo"
        Buffalo.Size = New Size(112, 33)
        Buffalo.TabIndex = 33
        Buffalo.Text = "Buffalo "
        Buffalo.UseVisualStyleBackColor = False
        ' 
        ' QNAP
        ' 
        QNAP.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        QNAP.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        QNAP.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        QNAP.Location = New Point(130, 145)
        QNAP.Name = "QNAP"
        QNAP.Size = New Size(112, 33)
        QNAP.TabIndex = 34
        QNAP.Text = "QNAP"
        QNAP.UseVisualStyleBackColor = False
        ' 
        ' FRITZNAS
        ' 
        FRITZNAS.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        FRITZNAS.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        FRITZNAS.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FRITZNAS.Location = New Point(130, 186)
        FRITZNAS.Name = "FRITZNAS"
        FRITZNAS.Size = New Size(112, 33)
        FRITZNAS.TabIndex = 35
        FRITZNAS.Text = "FRITZ!NAS"
        FRITZNAS.UseVisualStyleBackColor = False
        ' 
        ' Asustor
        ' 
        Asustor.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Asustor.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Asustor.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Asustor.Location = New Point(12, 186)
        Asustor.Name = "Asustor"
        Asustor.Size = New Size(112, 33)
        Asustor.TabIndex = 36
        Asustor.Text = "Asustor"
        Asustor.UseVisualStyleBackColor = False
        ' 
        ' ConnectToNAS
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(641, 270)
        Controls.Add(Asustor)
        Controls.Add(FRITZNAS)
        Controls.Add(QNAP)
        Controls.Add(Buffalo)
        Controls.Add(WesternDigital)
        Controls.Add(Synology)
        Controls.Add(Cancel)
        Controls.Add(ManualConnection)
        Controls.Add(Label1)
        Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        KeyPreview = True
        Name = "ConnectToNAS"
        Text = "Einen NAS verbinden"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cancel As Label
    Friend WithEvents ManualConnection As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Synology As Button
    Friend WithEvents WesternDigital As Button
    Friend WithEvents Buffalo As Button
    Friend WithEvents QNAP As Button
    Friend WithEvents FRITZNAS As Button
    Friend WithEvents Asustor As Button
End Class
