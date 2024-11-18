<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupPassword
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
        EnterNewPasswordText = New TextBox()
        EnterNewPassword = New Label()
        ConfirmNewPassword = New Label()
        ConfirmNewPasswordText = New TextBox()
        ApplyButton = New Label()
        ExitButton = New Label()
        SuspendLayout()
        ' 
        ' EnterNewPasswordText
        ' 
        EnterNewPasswordText.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        EnterNewPasswordText.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        EnterNewPasswordText.Location = New Point(169, 5)
        EnterNewPasswordText.Margin = New Padding(2, 2, 2, 2)
        EnterNewPasswordText.Name = "EnterNewPasswordText"
        EnterNewPasswordText.PasswordChar = "*"c
        EnterNewPasswordText.Size = New Size(106, 23)
        EnterNewPasswordText.TabIndex = 0
        ' 
        ' EnterNewPassword
        ' 
        EnterNewPassword.AutoSize = True
        EnterNewPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        EnterNewPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        EnterNewPassword.Location = New Point(8, 7)
        EnterNewPassword.Margin = New Padding(2, 0, 2, 0)
        EnterNewPassword.Name = "EnterNewPassword"
        EnterNewPassword.Size = New Size(142, 15)
        EnterNewPassword.TabIndex = 1
        EnterNewPassword.Text = "Neues Passwort eingeben"
        ' 
        ' ConfirmNewPassword
        ' 
        ConfirmNewPassword.AutoSize = True
        ConfirmNewPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmNewPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConfirmNewPassword.Location = New Point(8, 32)
        ConfirmNewPassword.Margin = New Padding(2, 0, 2, 0)
        ConfirmNewPassword.Name = "ConfirmNewPassword"
        ConfirmNewPassword.Size = New Size(148, 15)
        ConfirmNewPassword.TabIndex = 3
        ConfirmNewPassword.Text = "Neues Passwort bestätigen"
        ' 
        ' ConfirmNewPasswordText
        ' 
        ConfirmNewPasswordText.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmNewPasswordText.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConfirmNewPasswordText.Location = New Point(169, 30)
        ConfirmNewPasswordText.Margin = New Padding(2, 2, 2, 2)
        ConfirmNewPasswordText.Name = "ConfirmNewPasswordText"
        ConfirmNewPasswordText.PasswordChar = "*"c
        ConfirmNewPasswordText.Size = New Size(106, 23)
        ConfirmNewPasswordText.TabIndex = 2
        ' 
        ' ApplyButton
        ' 
        ApplyButton.AutoSize = True
        ApplyButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ApplyButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ApplyButton.Location = New Point(282, 56)
        ApplyButton.Margin = New Padding(2, 0, 2, 0)
        ApplyButton.Name = "ApplyButton"
        ApplyButton.Size = New Size(64, 15)
        ApplyButton.TabIndex = 4
        ApplyButton.Text = "Anwenden"
        ' 
        ' ExitButton
        ' 
        ExitButton.AutoSize = True
        ExitButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ExitButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ExitButton.Location = New Point(8, 56)
        ExitButton.Margin = New Padding(2, 0, 2, 0)
        ExitButton.Name = "ExitButton"
        ExitButton.Size = New Size(65, 15)
        ExitButton.TabIndex = 5
        ExitButton.Text = "Abbrechen"
        ' 
        ' SetupPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(358, 74)
        ControlBox = False
        Controls.Add(ExitButton)
        Controls.Add(ApplyButton)
        Controls.Add(ConfirmNewPassword)
        Controls.Add(ConfirmNewPasswordText)
        Controls.Add(EnterNewPassword)
        Controls.Add(EnterNewPasswordText)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2, 2, 2, 2)
        Name = "SetupPassword"
        Text = "Organisationspasswort einrichten"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EnterNewPasswordText As TextBox
    Friend WithEvents EnterNewPassword As Label
    Friend WithEvents ConfirmNewPassword As Label
    Friend WithEvents ConfirmNewPasswordText As TextBox
    Friend WithEvents ApplyButton As Label
    Friend WithEvents ExitButton As Label
End Class
