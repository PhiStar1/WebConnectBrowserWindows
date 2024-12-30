<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EnterIPAdress
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
        IPAdress = New TextBox()
        Label2 = New Label()
        ConnectWithHttps = New CheckBox()
        Connect = New Button()
        Cancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(9, 7)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(532, 106)
        Label1.TabIndex = 0
        Label1.Text = "Gib die IP-Adresse zu deinen " & vbCrLf & "  Gerät ein"
        ' 
        ' IPAdress
        ' 
        IPAdress.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        IPAdress.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        IPAdress.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        IPAdress.Location = New Point(120, 145)
        IPAdress.Margin = New Padding(1, 2, 1, 2)
        IPAdress.Name = "IPAdress"
        IPAdress.Size = New Size(244, 29)
        IPAdress.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(6, 148)
        Label2.Margin = New Padding(1, 0, 1, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 22)
        Label2.TabIndex = 2
        Label2.Text = "IP-Adresse"
        ' 
        ' ConnectWithHttps
        ' 
        ConnectWithHttps.AutoSize = True
        ConnectWithHttps.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConnectWithHttps.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        ConnectWithHttps.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConnectWithHttps.Location = New Point(369, 148)
        ConnectWithHttps.Margin = New Padding(1, 2, 1, 2)
        ConnectWithHttps.Name = "ConnectWithHttps"
        ConnectWithHttps.Size = New Size(202, 26)
        ConnectWithHttps.TabIndex = 3
        ConnectWithHttps.Text = "Verbindung per https://"
        ConnectWithHttps.UseVisualStyleBackColor = False
        ' 
        ' Connect
        ' 
        Connect.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Connect.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Connect.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Connect.Location = New Point(-1, 215)
        Connect.Margin = New Padding(1, 2, 1, 2)
        Connect.Name = "Connect"
        Connect.Size = New Size(326, 48)
        Connect.TabIndex = 4
        Connect.Text = "Verbinden"
        Connect.TextAlign = ContentAlignment.MiddleLeft
        Connect.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.Font = New Font("SamsungOneUILatin 700", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(321, 215)
        Cancel.Margin = New Padding(1, 2, 1, 2)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(314, 48)
        Cancel.TabIndex = 5
        Cancel.Text = "Abbrechen"
        Cancel.TextAlign = ContentAlignment.MiddleRight
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' EnterIPAdress
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(636, 258)
        Controls.Add(Cancel)
        Controls.Add(Connect)
        Controls.Add(ConnectWithHttps)
        Controls.Add(Label2)
        Controls.Add(IPAdress)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Margin = New Padding(1, 2, 1, 2)
        Name = "EnterIPAdress"
        Text = "Gerät manuell verbinden"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents IPAdress As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ConnectWithHttps As CheckBox
    Friend WithEvents Connect As Button
    Friend WithEvents Cancel As Button
End Class
