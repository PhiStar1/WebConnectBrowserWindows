<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangeOrganizationPassword
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
        Label3 = New Label()
        ConfirmNewPassword = New TextBox()
        NewPassword = New TextBox()
        ActualPassword = New TextBox()
        ApplyButton = New Label()
        CancelButton = New Label()
        ShowPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 25)
        Label1.TabIndex = 0
        Label1.Text = "Aktuelles Passwort:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(12, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(228, 25)
        Label2.TabIndex = 1
        Label2.Text = "Neues Passwort bestätigen:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(12, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(140, 25)
        Label3.TabIndex = 2
        Label3.Text = "Neues Passwort:"
        ' 
        ' ConfirmNewPassword
        ' 
        ConfirmNewPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmNewPassword.Location = New Point(246, 106)
        ConfirmNewPassword.Name = "ConfirmNewPassword"
        ConfirmNewPassword.PasswordChar = "*"c
        ConfirmNewPassword.Size = New Size(150, 31)
        ConfirmNewPassword.TabIndex = 3
        ' 
        ' NewPassword
        ' 
        NewPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewPassword.Location = New Point(246, 70)
        NewPassword.Name = "NewPassword"
        NewPassword.PasswordChar = "*"c
        NewPassword.Size = New Size(150, 31)
        NewPassword.TabIndex = 4
        ' 
        ' ActualPassword
        ' 
        ActualPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ActualPassword.Location = New Point(246, 9)
        ActualPassword.Name = "ActualPassword"
        ActualPassword.PasswordChar = "*"c
        ActualPassword.Size = New Size(150, 31)
        ActualPassword.TabIndex = 5
        ' 
        ' ApplyButton
        ' 
        ApplyButton.AutoSize = True
        ApplyButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ApplyButton.Location = New Point(337, 202)
        ApplyButton.Name = "ApplyButton"
        ApplyButton.Size = New Size(96, 25)
        ApplyButton.TabIndex = 6
        ApplyButton.Text = "Anwenden"
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSize = True
        CancelButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CancelButton.Location = New Point(12, 202)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(98, 25)
        CancelButton.TabIndex = 7
        CancelButton.Text = "Abbrechen"
        ' 
        ' ShowPassword
        ' 
        ShowPassword.AutoSize = True
        ShowPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ShowPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ShowPassword.Location = New Point(12, 151)
        ShowPassword.Name = "ShowPassword"
        ShowPassword.Size = New Size(198, 29)
        ShowPassword.TabIndex = 8
        ShowPassword.Text = "Passwörter anzeigen"
        ShowPassword.UseVisualStyleBackColor = False
        ' 
        ' ChangeOrganizationPassword
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(445, 236)
        Controls.Add(ShowPassword)
        Controls.Add(CancelButton)
        Controls.Add(ApplyButton)
        Controls.Add(ActualPassword)
        Controls.Add(NewPassword)
        Controls.Add(ConfirmNewPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "ChangeOrganizationPassword"
        Text = "Organisationspasswort ändern"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfirmNewPassword As TextBox
    Friend WithEvents NewPassword As TextBox
    Friend WithEvents ActualPassword As TextBox
    Friend WithEvents ApplyButton As Label
    Friend WithEvents CancelButton As Label
    Friend WithEvents ShowPassword As CheckBox
End Class
