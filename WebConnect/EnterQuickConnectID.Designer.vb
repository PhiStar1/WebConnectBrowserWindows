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
        Header = New Label()
        QuickConnectID = New TextBox()
        ConnectWithDSMButton = New Button()
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
        Header.Size = New Size(574, 46)
        Header.TabIndex = 0
        Header.Text = "EnterQuickConnectID.Header"
        ' 
        ' QuickConnectID
        ' 
        QuickConnectID.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        QuickConnectID.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        QuickConnectID.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        QuickConnectID.Location = New Point(12, 198)
        QuickConnectID.Name = "QuickConnectID"
        QuickConnectID.PlaceholderText = "EnterQuickConnectID.QuickConnectID.PlaceholderText"
        QuickConnectID.Size = New Size(507, 28)
        QuickConnectID.TabIndex = 1
        ' 
        ' ConnectWithDSMButton
        ' 
        ConnectWithDSMButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConnectWithDSMButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        ConnectWithDSMButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConnectWithDSMButton.Location = New Point(525, 198)
        ConnectWithDSMButton.Name = "ConnectWithDSMButton"
        ConnectWithDSMButton.Size = New Size(431, 42)
        ConnectWithDSMButton.TabIndex = 2
        ConnectWithDSMButton.Text = "EnterQuickConnectID.ConnectWithDSMButton"
        ConnectWithDSMButton.UseVisualStyleBackColor = False
        ' 
        ' EnterQuickConnectID
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(965, 252)
        Controls.Add(ConnectWithDSMButton)
        Controls.Add(QuickConnectID)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "EnterQuickConnectID"
        Text = "WebConnect.EnterQuickConnectID"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents QuickConnectID As TextBox
    Friend WithEvents ConnectWithDSMButton As Button
End Class
