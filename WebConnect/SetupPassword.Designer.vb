﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Terminate = New Label()
        SuspendLayout()
        ' 
        ' EnterNewPasswordText
        ' 
        EnterNewPasswordText.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        EnterNewPasswordText.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        EnterNewPasswordText.Location = New Point(241, 8)
        EnterNewPasswordText.Name = "EnterNewPasswordText"
        EnterNewPasswordText.PasswordChar = "*"c
        EnterNewPasswordText.Size = New Size(150, 31)
        EnterNewPasswordText.TabIndex = 0
        ' 
        ' EnterNewPassword
        ' 
        EnterNewPassword.AutoSize = True
        EnterNewPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        EnterNewPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        EnterNewPassword.Location = New Point(11, 12)
        EnterNewPassword.Name = "EnterNewPassword"
        EnterNewPassword.Size = New Size(287, 25)
        EnterNewPassword.TabIndex = 1
        EnterNewPassword.Text = "SetupPassword.EnterNewPassword"
        ' 
        ' ConfirmNewPassword
        ' 
        ConfirmNewPassword.AutoSize = True
        ConfirmNewPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmNewPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConfirmNewPassword.Location = New Point(11, 53)
        ConfirmNewPassword.Name = "ConfirmNewPassword"
        ConfirmNewPassword.Size = New Size(311, 25)
        ConfirmNewPassword.TabIndex = 3
        ConfirmNewPassword.Text = "SetupPassword.ConfirmNewPassword"
        ' 
        ' ConfirmNewPasswordText
        ' 
        ConfirmNewPasswordText.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmNewPasswordText.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConfirmNewPasswordText.Location = New Point(241, 50)
        ConfirmNewPasswordText.Name = "ConfirmNewPasswordText"
        ConfirmNewPasswordText.PasswordChar = "*"c
        ConfirmNewPasswordText.Size = New Size(150, 31)
        ConfirmNewPasswordText.TabIndex = 2
        ' 
        ' ApplyButton
        ' 
        ApplyButton.AutoSize = True
        ApplyButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ApplyButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ApplyButton.Location = New Point(403, 93)
        ApplyButton.Name = "ApplyButton"
        ApplyButton.Size = New Size(184, 25)
        ApplyButton.TabIndex = 4
        ApplyButton.Text = "SetupPassword.Apply"
        ' 
        ' Terminate
        ' 
        Terminate.AutoSize = True
        Terminate.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Terminate.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Terminate.Location = New Point(11, 93)
        Terminate.Name = "Terminate"
        Terminate.Size = New Size(213, 25)
        Terminate.TabIndex = 5
        Terminate.Text = "SetupPassword.Terminate"
        ' 
        ' SetupPassword
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(525, 129)
        ControlBox = False
        Controls.Add(Terminate)
        Controls.Add(ApplyButton)
        Controls.Add(ConfirmNewPassword)
        Controls.Add(ConfirmNewPasswordText)
        Controls.Add(EnterNewPassword)
        Controls.Add(EnterNewPasswordText)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Name = "SetupPassword"
        Text = "WebConnect.SetupPassword"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents EnterNewPasswordText As TextBox
    Friend WithEvents EnterNewPassword As Label
    Friend WithEvents ConfirmNewPassword As Label
    Friend WithEvents ConfirmNewPasswordText As TextBox
    Friend WithEvents ApplyButton As Label
    Friend WithEvents Terminate As Label
End Class
