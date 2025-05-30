<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterCloudID
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
        Header = New Label()
        CloudID = New TextBox()
        ConnectWithCloudIDButton = New Button()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Header.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(11, 14)
        Header.Name = "Header"
        Header.Size = New Size(419, 46)
        Header.TabIndex = 0
        Header.Text = "EnterCloudID.Header"
        ' 
        ' CloudID
        ' 
        CloudID.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CloudID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CloudID.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CloudID.Location = New Point(12, 198)
        CloudID.Name = "CloudID"
        CloudID.PlaceholderText = "EnterCloudID.CloudID"
        CloudID.Size = New Size(657, 28)
        CloudID.TabIndex = 1
        ' 
        ' ConnectWithCloudIDButton
        ' 
        ConnectWithCloudIDButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConnectWithCloudIDButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ConnectWithCloudIDButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConnectWithCloudIDButton.Location = New Point(676, 198)
        ConnectWithCloudIDButton.Name = "ConnectWithCloudIDButton"
        ConnectWithCloudIDButton.Size = New Size(391, 42)
        ConnectWithCloudIDButton.TabIndex = 2
        ConnectWithCloudIDButton.Text = "EnterCloudID.ConnectWithCloudIDButton"
        ConnectWithCloudIDButton.UseVisualStyleBackColor = False
        ' 
        ' EnterCloudID
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1075, 252)
        Controls.Add(ConnectWithCloudIDButton)
        Controls.Add(CloudID)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "EnterCloudID"
        Text = "WebConnect.EnterCloudID"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents CloudID As TextBox
    Friend WithEvents ConnectWithCloudIDButton As Button
End Class
