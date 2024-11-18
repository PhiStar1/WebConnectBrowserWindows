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
        Label1 = New Label()
        CloudID = New TextBox()
        ConnectWithCloudIDButton = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(11, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(649, 159)
        Label1.TabIndex = 0
        Label1.Text = "Gebe deine Cloud ID hier ein," & vbCrLf & "  um dich mit deinen Asustor-Gerät " & vbCrLf & "    zu verbinden."
        ' 
        ' CloudID
        ' 
        CloudID.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        CloudID.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        CloudID.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        CloudID.Location = New Point(12, 198)
        CloudID.Name = "CloudID"
        CloudID.Size = New Size(657, 31)
        CloudID.TabIndex = 1
        CloudID.Text = "Cloud ID"
        ' 
        ' ConnectWithCloudIDButton
        ' 
        ConnectWithCloudIDButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConnectWithCloudIDButton.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ConnectWithCloudIDButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConnectWithCloudIDButton.Location = New Point(676, 198)
        ConnectWithCloudIDButton.Name = "ConnectWithCloudIDButton"
        ConnectWithCloudIDButton.Size = New Size(112, 42)
        ConnectWithCloudIDButton.TabIndex = 2
        ConnectWithCloudIDButton.Text = "Los"
        ConnectWithCloudIDButton.UseVisualStyleBackColor = False
        ' 
        ' EnterCloudID
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 252)
        Controls.Add(ConnectWithCloudIDButton)
        Controls.Add(CloudID)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "EnterCloudID"
        Text = "Cloud ID eingeben"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents CloudID As TextBox
    Friend WithEvents ConnectWithCloudIDButton As Button
End Class
