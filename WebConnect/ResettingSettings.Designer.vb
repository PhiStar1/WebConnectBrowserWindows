<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ResettingSettings
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
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ProgressBar1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ProgressBar1.Location = New Point(12, 12)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(776, 45)
        ProgressBar1.Step = 0
        ProgressBar1.TabIndex = 0
        ' 
        ' ResettingSettings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(799, 66)
        Controls.Add(ProgressBar1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "ResettingSettings"
        Text = "ResettingSettings"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
End Class
