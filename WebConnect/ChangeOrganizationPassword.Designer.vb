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
        CurrentPassword = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ConfirmNewPasswordPassword = New TextBox()
        NewPasswordPassword = New TextBox()
        CurrentPasswordPassword = New TextBox()
        ApplyButton = New Label()
        CancelButton = New Label()
        ShowPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' CurrentPassword
        ' 
        CurrentPassword.AutoSize = True
        CurrentPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CurrentPassword.Location = New Point(15, 12)
        CurrentPassword.Name = "CurrentPassword"
        CurrentPassword.Size = New Size(386, 25)
        CurrentPassword.TabIndex = 0
        CurrentPassword.Text = "ChangeOrganizationPassword.CurrentPassword"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(12, 106)
        Label2.Name = "Label2"
        Label2.Size = New Size(427, 25)
        Label2.TabIndex = 1
        Label2.Text = "ChangeOrganizationPassword.ConfirmNewPassword"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label3.Location = New Point(12, 70)
        Label3.Name = "Label3"
        Label3.Size = New Size(363, 25)
        Label3.TabIndex = 2
        Label3.Text = "ChangeOrganizationPassword.NewPassword"
        ' 
        ' ConfirmNewPasswordPassword
        ' 
        ConfirmNewPasswordPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmNewPasswordPassword.Location = New Point(447, 107)
        ConfirmNewPasswordPassword.Name = "ConfirmNewPasswordPassword"
        ConfirmNewPasswordPassword.PasswordChar = "*"c
        ConfirmNewPasswordPassword.Size = New Size(278, 31)
        ConfirmNewPasswordPassword.TabIndex = 3
        ' 
        ' NewPasswordPassword
        ' 
        NewPasswordPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        NewPasswordPassword.Location = New Point(447, 70)
        NewPasswordPassword.Name = "NewPasswordPassword"
        NewPasswordPassword.PasswordChar = "*"c
        NewPasswordPassword.Size = New Size(278, 31)
        NewPasswordPassword.TabIndex = 4
        ' 
        ' CurrentPasswordPassword
        ' 
        CurrentPasswordPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CurrentPasswordPassword.Location = New Point(447, 12)
        CurrentPasswordPassword.Name = "CurrentPasswordPassword"
        CurrentPasswordPassword.PasswordChar = "*"c
        CurrentPasswordPassword.Size = New Size(278, 31)
        CurrentPasswordPassword.TabIndex = 5
        ' 
        ' ApplyButton
        ' 
        ApplyButton.AutoSize = True
        ApplyButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ApplyButton.Location = New Point(375, 202)
        ApplyButton.Name = "ApplyButton"
        ApplyButton.Size = New Size(353, 25)
        ApplyButton.TabIndex = 6
        ApplyButton.Text = "ChangeOrganizationPassword.ApplyButton"
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSize = True
        CancelButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CancelButton.Location = New Point(12, 202)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(357, 25)
        CancelButton.TabIndex = 7
        CancelButton.Text = "ChangeOrganizationPassword.CancelButton"
        ' 
        ' ShowPassword
        ' 
        ShowPassword.AutoSize = True
        ShowPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ShowPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ShowPassword.Location = New Point(12, 151)
        ShowPassword.Name = "ShowPassword"
        ShowPassword.Size = New Size(398, 29)
        ShowPassword.TabIndex = 8
        ShowPassword.Text = "ChangeOrganizationPassword.ShowPassword"
        ShowPassword.UseVisualStyleBackColor = False
        ' 
        ' ChangeOrganizationPassword
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(737, 241)
        Controls.Add(ShowPassword)
        Controls.Add(CancelButton)
        Controls.Add(ApplyButton)
        Controls.Add(CurrentPasswordPassword)
        Controls.Add(NewPasswordPassword)
        Controls.Add(ConfirmNewPasswordPassword)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(CurrentPassword)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "ChangeOrganizationPassword"
        Text = "WebConnect.ChangeOrganizationPassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CurrentPassword As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ConfirmNewPasswordPassword As TextBox
    Friend WithEvents NewPasswordPassword As TextBox
    Friend WithEvents CurrentPasswordPassword As TextBox
    Friend WithEvents ApplyButton As Label
    Friend WithEvents CancelButton As Label
    Friend WithEvents ShowPassword As CheckBox
End Class
