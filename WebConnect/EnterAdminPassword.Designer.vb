<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnterAdminPassword
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
        OrganizationPassword = New TextBox()
        UnlockAdminSoftwareButton = New Label()
        CancelButton = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(8, 5)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' OrganizationPassword
        ' 
        OrganizationPassword.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        OrganizationPassword.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        OrganizationPassword.Location = New Point(13, 7)
        OrganizationPassword.Margin = New Padding(2, 2, 2, 2)
        OrganizationPassword.Name = "OrganizationPassword"
        OrganizationPassword.Size = New Size(306, 23)
        OrganizationPassword.TabIndex = 1
        OrganizationPassword.Text = "Organisationspasswort"
        ' 
        ' UnlockAdminSoftwareButton
        ' 
        UnlockAdminSoftwareButton.AutoSize = True
        UnlockAdminSoftwareButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        UnlockAdminSoftwareButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        UnlockAdminSoftwareButton.Location = New Point(292, 44)
        UnlockAdminSoftwareButton.Margin = New Padding(2, 0, 2, 0)
        UnlockAdminSoftwareButton.Name = "UnlockAdminSoftwareButton"
        UnlockAdminSoftwareButton.Size = New Size(23, 15)
        UnlockAdminSoftwareButton.TabIndex = 2
        UnlockAdminSoftwareButton.Text = "OK"
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSize = True
        CancelButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CancelButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CancelButton.Location = New Point(8, 44)
        CancelButton.Margin = New Padding(2, 0, 2, 0)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(65, 15)
        CancelButton.TabIndex = 3
        CancelButton.Text = "Abbrechen"
        ' 
        ' EnterAdminPassword
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(326, 68)
        ControlBox = False
        Controls.Add(CancelButton)
        Controls.Add(UnlockAdminSoftwareButton)
        Controls.Add(OrganizationPassword)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Margin = New Padding(2, 2, 2, 2)
        Name = "EnterAdminPassword"
        Text = "Organisationspasswort eingeben"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OrganizationPassword As TextBox
    Friend WithEvents UnlockAdminSoftwareButton As Label
    Friend WithEvents CancelButton As Label
End Class
