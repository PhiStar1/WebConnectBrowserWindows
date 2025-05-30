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
        Description = New Label()
        OrganizationNameText = New TextBox()
        Apply = New Label()
        Cancel = New Label()
        SuspendLayout()
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Description.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Description.Location = New Point(12, 9)
        Description.Name = "Description"
        Description.Size = New Size(254, 25)
        Description.TabIndex = 0
        Description.Text = "SetupOrganization.Description"
        ' 
        ' OrganizationNameText
        ' 
        OrganizationNameText.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        OrganizationNameText.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        OrganizationNameText.Location = New Point(12, 49)
        OrganizationNameText.Name = "OrganizationNameText"
        OrganizationNameText.PlaceholderText = "SetupOrganization.OrganizationNameText"
        OrganizationNameText.Size = New Size(150, 31)
        OrganizationNameText.TabIndex = 1
        ' 
        ' Apply
        ' 
        Apply.AutoSize = True
        Apply.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Apply.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Apply.Location = New Point(283, 87)
        Apply.Name = "Apply"
        Apply.Size = New Size(211, 25)
        Apply.TabIndex = 2
        Apply.Text = "SetupOrganization.Apply"
        ' 
        ' Cancel
        ' 
        Cancel.AutoSize = True
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(12, 87)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(215, 25)
        Cancel.TabIndex = 3
        Cancel.Text = "SetupOrganization.Cancel"
        ' 
        ' SetupOrganization
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(391, 121)
        Controls.Add(Cancel)
        Controls.Add(Apply)
        Controls.Add(OrganizationNameText)
        Controls.Add(Description)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "SetupOrganization"
        Text = "WebConnect,SetupOrganization"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Description As Label
    Friend WithEvents OrganizationNameText As TextBox
    Friend WithEvents Apply As Label
    Friend WithEvents Cancel As Label
End Class
