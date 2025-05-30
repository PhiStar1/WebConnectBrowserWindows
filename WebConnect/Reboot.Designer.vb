<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reboot
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
        RebootWebConnect = New Label()
        Cancel = New Label()
        Description = New Label()
        Header = New Label()
        SuspendLayout()
        ' 
        ' RebootWebConnect
        ' 
        RebootWebConnect.AutoSize = True
        RebootWebConnect.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RebootWebConnect.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RebootWebConnect.Location = New Point(693, 222)
        RebootWebConnect.Name = "RebootWebConnect"
        RebootWebConnect.Size = New Size(233, 25)
        RebootWebConnect.TabIndex = 7
        RebootWebConnect.Text = "Reboot.RebootWebConnect"
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(589, 222)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(125, 25)
        Cancel.TabIndex = 6
        Cancel.Text = "Reboot.Cancel"
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Description.Font = New Font("Microsoft Sans Serif", 10F, FontStyle.Bold)
        Description.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Description.Location = New Point(12, 101)
        Description.Name = "Description"
        Description.Size = New Size(194, 25)
        Description.TabIndex = 5
        Description.Text = "Reboot.Description"
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Header.Font = New Font("Microsoft Sans Serif", 22F, FontStyle.Bold)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(12, 13)
        Header.Name = "Header"
        Header.Size = New Size(330, 52)
        Header.TabIndex = 4
        Header.Text = "Reboot.Header"
        ' 
        ' Reboot
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 261)
        Controls.Add(RebootWebConnect)
        Controls.Add(Cancel)
        Controls.Add(Description)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "Reboot"
        Text = "WebConnect.Reboot"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents RebootWebConnect As Label
    Friend WithEvents Cancel As Label
    Friend WithEvents Description As Label
    Friend WithEvents Header As Label
End Class
