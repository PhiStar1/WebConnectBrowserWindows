<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShutDownWebConnect
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
        Header = New Label()
        Description = New Label()
        Cancel = New Label()
        Shutdown = New Label()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Header.Font = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(12, 18)
        Header.Name = "Header"
        Header.Size = New Size(497, 52)
        Header.TabIndex = 0
        Header.Text = "WebConnect beenden?"
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Description.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Description.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Description.Location = New Point(12, 106)
        Description.Name = "Description"
        Description.Size = New Size(666, 50)
        Description.TabIndex = 1
        Description.Text = "Alle Tabs und im Browser ausgeführten Programme werden beendet" & vbCrLf & "und nicht gespeicherte Daten gehen verloren."
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(604, 227)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(98, 25)
        Cancel.TabIndex = 2
        Cancel.Text = "Abbrechen"
        ' 
        ' Shutdown
        ' 
        Shutdown.AutoSize = True
        Shutdown.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Shutdown.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Shutdown.Location = New Point(708, 227)
        Shutdown.Name = "Shutdown"
        Shutdown.Size = New Size(80, 25)
        Shutdown.TabIndex = 3
        Shutdown.Text = "Beenden"
        ' 
        ' ShutDownWebConnect
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 261)
        Controls.Add(Shutdown)
        Controls.Add(Cancel)
        Controls.Add(Description)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "ShutDownWebConnect"
        Text = "WebConnect.ShutDownWebConnect"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents Description As Label
    Friend WithEvents Cancel As Label
    Friend WithEvents Shutdown As Label
End Class
