<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SetupOrganization
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
        OrganizationNameText = New TextBox()
        ApplyButton = New Label()
        CancelButton = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(340, 25)
        Label1.TabIndex = 0
        Label1.Text = "Gebe hier den Name der Organisation ein"
        ' 
        ' OrganizationNameText
        ' 
        OrganizationNameText.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        OrganizationNameText.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        OrganizationNameText.Location = New Point(12, 49)
        OrganizationNameText.Name = "OrganizationNameText"
        OrganizationNameText.Size = New Size(150, 31)
        OrganizationNameText.TabIndex = 1
        OrganizationNameText.Text = "Organisation"
        ' 
        ' ApplyButton
        ' 
        ApplyButton.AutoSize = True
        ApplyButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ApplyButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ApplyButton.Location = New Point(283, 87)
        ApplyButton.Name = "ApplyButton"
        ApplyButton.Size = New Size(96, 25)
        ApplyButton.TabIndex = 2
        ApplyButton.Text = "Anwenden"
        ' 
        ' CancelButton
        ' 
        CancelButton.AutoSize = True
        CancelButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CancelButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CancelButton.Location = New Point(12, 87)
        CancelButton.Name = "CancelButton"
        CancelButton.Size = New Size(98, 25)
        CancelButton.TabIndex = 3
        CancelButton.Text = "Abbrechen"
        ' 
        ' SetupOrganization
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(391, 121)
        Controls.Add(CancelButton)
        Controls.Add(ApplyButton)
        Controls.Add(OrganizationNameText)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "SetupOrganization"
        Text = "Organisation einrichten"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents OrganizationNameText As TextBox
    Friend WithEvents ApplyButton As Label
    Friend WithEvents CancelButton As Label
End Class
