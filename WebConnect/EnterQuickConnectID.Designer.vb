<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnterQuickConnectID
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
        QuickConnectID = New TextBox()
        ConnectWithDSMButton = New Button()
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
        Label1.Size = New Size(681, 159)
        Label1.TabIndex = 0
        Label1.Text = "Gebe deine QuickConnect-ID hier ein," & vbCrLf & "  um dich mit deinen Synology-Gerät " & vbCrLf & "    zu verbinden."
        ' 
        ' QuickConnectID
        ' 
        QuickConnectID.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        QuickConnectID.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        QuickConnectID.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        QuickConnectID.Location = New Point(12, 198)
        QuickConnectID.Name = "QuickConnectID"
        QuickConnectID.Size = New Size(657, 31)
        QuickConnectID.TabIndex = 1
        QuickConnectID.Text = "QuickConnect-ID"
        ' 
        ' ConnectWithDSMButton
        ' 
        ConnectWithDSMButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConnectWithDSMButton.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ConnectWithDSMButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConnectWithDSMButton.Location = New Point(676, 198)
        ConnectWithDSMButton.Name = "ConnectWithDSMButton"
        ConnectWithDSMButton.Size = New Size(112, 42)
        ConnectWithDSMButton.TabIndex = 2
        ConnectWithDSMButton.Text = "Los"
        ConnectWithDSMButton.UseVisualStyleBackColor = False
        ' 
        ' EnterQuickConnectID
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 252)
        Controls.Add(ConnectWithDSMButton)
        Controls.Add(QuickConnectID)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "EnterQuickConnectID"
        Text = "QuickConnect ID eingeben"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents QuickConnectID As TextBox
    Friend WithEvents ConnectWithDSMButton As Button
End Class
