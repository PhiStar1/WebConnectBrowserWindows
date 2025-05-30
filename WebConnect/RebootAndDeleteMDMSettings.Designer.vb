<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RebootAndDeleteMDMSettings
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
        Reboot = New Label()
        Cancel = New Label()
        Description = New Label()
        Header = New Label()
        SuspendLayout()
        ' 
        ' Reboot
        ' 
        Reboot.AutoSize = True
        Reboot.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Reboot.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Reboot.Location = New Point(693, 222)
        Reboot.Name = "Reboot"
        Reboot.Size = New Size(324, 25)
        Reboot.TabIndex = 7
        Reboot.Text = "RebootAndDeleteMDMSettings.Reboot"
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(589, 222)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(317, 25)
        Cancel.TabIndex = 6
        Cancel.Text = "RebootAndDeleteMDMSettings.Cancel"
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Description.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Description.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Description.Location = New Point(12, 101)
        Description.Name = "Description"
        Description.Size = New Size(425, 25)
        Description.TabIndex = 5
        Description.Text = "RebootAndDeleteMDMSettings.Description"
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Header.Font = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(12, 13)
        Header.Name = "Header"
        Header.Size = New Size(816, 52)
        Header.TabIndex = 4
        Header.Text = "RebootAndDeleteMDMSettings.Header"
        ' 
        ' RebootAndDeleteMDMSettings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 261)
        Controls.Add(Reboot)
        Controls.Add(Cancel)
        Controls.Add(Description)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "RebootAndDeleteMDMSettings"
        Text = "WebConnect.RebootAndDeleteMDMSettings"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Reboot As Label
    Friend WithEvents Cancel As Label
    Friend WithEvents Description As Label
    Friend WithEvents Header As Label
End Class
