<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorWhileLoadingThisLink
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
        ErrorIcon = New Label()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ErrorIcon
        ' 
        ErrorIcon.AutoSize = True
        ErrorIcon.Font = New Font("Segoe UI", 40F)
        ErrorIcon.Location = New Point(12, 9)
        ErrorIcon.Name = "ErrorIcon"
        ErrorIcon.Size = New Size(68, 106)
        ErrorIcon.TabIndex = 0
        ErrorIcon.Text = "!"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 20F)
        Label1.Location = New Point(99, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(454, 108)
        Label1.TabIndex = 1
        Label1.Text = "Dieser Link kann aktuell " & vbCrLf & "  nicht geöffnet werden"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label2.Location = New Point(517, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 22)
        Label2.TabIndex = 3
        Label2.Text = "OK"
        ' 
        ' ErrorWhileLoadingThisLink
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(568, 218)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ErrorIcon)
        Name = "ErrorWhileLoadingThisLink"
        Text = "Fehler | Link kann nicht geöffnet werden"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ErrorIcon As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
