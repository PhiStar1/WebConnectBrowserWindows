<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InstallAppleAirport
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
        Button1 = New Button()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(6, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(437, 148)
        Label1.TabIndex = 0
        Label1.Text = "Willst du das " & vbCrLf & "  AirPort-Dienstprogramm " & vbCrLf & "    auf diesen PC herunterladen und " & vbCrLf & "      installieren?"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Location = New Point(-4, 176)
        Button1.Margin = New Padding(2, 2, 2, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(277, 37)
        Button1.TabIndex = 1
        Button1.Text = "Ja"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(271, 176)
        Button2.Margin = New Padding(2, 2, 2, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(289, 37)
        Button2.TabIndex = 2
        Button2.Text = "Nein"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' InstallAppleAirport
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(560, 224)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Margin = New Padding(2, 2, 2, 2)
        Name = "InstallAppleAirport"
        Text = "Anwendungsinstallation auf diesem Gerät | Apple AirPort"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
