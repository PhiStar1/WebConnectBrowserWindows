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
        Password = New Label()
        ConfirmWithPassword = New TextBox()
        Cancel = New Label()
        Delete = New Label()
        RebootMessage = New Label()
        SuspendLayout()
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Password.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Password.Location = New Point(12, 9)
        Password.Name = "Password"
        Password.Size = New Size(310, 25)
        Password.TabIndex = 0
        Password.Text = "DeleteAdminSettingsDialog.Password"
        ' 
        ' ConfirmWithPassword
        ' 
        ConfirmWithPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConfirmWithPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConfirmWithPassword.Location = New Point(328, 6)
        ConfirmWithPassword.Name = "ConfirmWithPassword"
        ConfirmWithPassword.PasswordChar = "*"c
        ConfirmWithPassword.Size = New Size(399, 31)
        ConfirmWithPassword.TabIndex = 1
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(12, 120)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(286, 25)
        Cancel.TabIndex = 2
        Cancel.Text = "DeleteAdminSettingsDialog.Cancel"
        ' 
        ' Delete
        ' 
        Delete.AutoSize = True
        Delete.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Delete.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Delete.Location = New Point(442, 120)
        Delete.Name = "Delete"
        Delete.Size = New Size(285, 25)
        Delete.TabIndex = 3
        Delete.Text = "DeleteAdminSettingsDialog.Delete"
        ' 
        ' RebootMessage
        ' 
        RebootMessage.AutoSize = True
        RebootMessage.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        RebootMessage.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        RebootMessage.Location = New Point(12, 61)
        RebootMessage.Name = "RebootMessage"
        RebootMessage.Size = New Size(363, 25)
        RebootMessage.TabIndex = 4
        RebootMessage.Text = "DeleteAdminSettingsDialog.RebootMessage"
        ' 
        ' DeleteAdminSettingsDialog
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(740, 154)
        Controls.Add(RebootMessage)
        Controls.Add(Delete)
        Controls.Add(Cancel)
        Controls.Add(ConfirmWithPassword)
        Controls.Add(Password)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "DeleteAdminSettingsDialog"
        Text = "WebConnect.DeleteAdminSettingsDialog"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Password As Label
    Friend WithEvents ConfirmWithPassword As TextBox
    Friend WithEvents Cancel As Label
    Friend WithEvents Delete As Label
    Friend WithEvents RebootMessage As Label
End Class
