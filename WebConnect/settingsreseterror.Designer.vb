<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settingsreseterror
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
        reboot = New Label()
        SuspendLayout()
        ' 
        ' reboot
        ' 
        reboot.AutoSize = True
        reboot.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        reboot.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        reboot.Location = New Point(85, 9)
        reboot.Name = "reboot"
        reboot.Size = New Size(176, 25)
        reboot.TabIndex = 0
        reboot.Text = "Reboot WebConnect"
        ' 
        ' settingsreseterror
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(273, 41)
        Controls.Add(reboot)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "settingsreseterror"
        Text = "Failed"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents reboot As Label
End Class
