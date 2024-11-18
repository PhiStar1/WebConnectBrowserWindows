<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeleteAdminSettingsDialog
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
        ConfirmWithPassword = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 25)
        Label1.TabIndex = 0
        Label1.Text = "Passwort eingeben:"
        ' 
        ' ConfirmWithPassword
        ' 
        ConfirmWithPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmWithPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConfirmWithPassword.Location = New Point(182, 6)
        ConfirmWithPassword.Name = "ConfirmWithPassword"
        ConfirmWithPassword.PasswordChar = "*"c
        ConfirmWithPassword.Size = New Size(150, 31)
        ConfirmWithPassword.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(12, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 25)
        Label2.TabIndex = 2
        Label2.Text = "Abbrechen"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(393, 120)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 25)
        Label3.TabIndex = 3
        Label3.Text = "Löschen"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label4.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label4.Location = New Point(12, 61)
        Label4.Name = "Label4"
        Label4.Size = New Size(318, 25)
        Label4.TabIndex = 4
        Label4.Text = "WebConnect wird danach neugestartet"
        ' 
        ' DeleteAdminSettingsDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(481, 154)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(ConfirmWithPassword)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "DeleteAdminSettingsDialog"
        Text = "Organisationseinstellungen löschen?"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ConfirmWithPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
