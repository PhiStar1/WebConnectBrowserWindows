<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SoftwareUpdateTool
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
        Label2 = New Label()
        DownloadButton = New Label()
        Label4 = New Label()
        RichTextBox1 = New RichTextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(704, 130)
        Label1.TabIndex = 0
        Label1.Text = "Es wird nach Software-Updates " & vbCrLf & "  für dein WebConnect gesucht"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(1040, 406)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 25)
        Label2.TabIndex = 1
        Label2.Text = "Schließen"
        ' 
        ' DownloadButton
        ' 
        DownloadButton.AutoSize = True
        DownloadButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        DownloadButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        DownloadButton.Location = New Point(910, 406)
        DownloadButton.Name = "DownloadButton"
        DownloadButton.Size = New Size(124, 25)
        DownloadButton.TabIndex = 2
        DownloadButton.Text = "Herunterladen"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Location = New Point(12, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(101, 25)
        Label4.TabIndex = 3
        Label4.Text = "Warte kurz!"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RichTextBox1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RichTextBox1.Location = New Point(12, 165)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.ReadOnly = True
        RichTextBox1.Size = New Size(1115, 211)
        RichTextBox1.TabIndex = 4
        RichTextBox1.Text = ""
        ' 
        ' SoftwareUpdateTool
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1139, 440)
        Controls.Add(RichTextBox1)
        Controls.Add(Label4)
        Controls.Add(DownloadButton)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "SoftwareUpdateTool"
        Text = "Software-Update"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DownloadButton As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
