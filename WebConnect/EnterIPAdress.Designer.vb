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
        Header = New Label()
        IPAdress = New TextBox()
        IPAdressLabel = New Label()
        ConnectWithHttps = New CheckBox()
        Connect = New Button()
        Cancel = New Button()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Header.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(9, 7)
        Header.Margin = New Padding(1, 0, 1, 0)
        Header.Name = "Header"
        Header.Size = New Size(437, 46)
        Header.TabIndex = 0
        Header.Text = "EnterIPAdress.Header"
        ' 
        ' IPAdress
        ' 
        IPAdress.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        IPAdress.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        IPAdress.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        IPAdress.Location = New Point(256, 145)
        IPAdress.Margin = New Padding(1, 2, 1, 2)
        IPAdress.Name = "IPAdress"
        IPAdress.Size = New Size(244, 26)
        IPAdress.TabIndex = 1
        ' 
        ' IPAdressLabel
        ' 
        IPAdressLabel.AutoSize = True
        IPAdressLabel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        IPAdressLabel.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        IPAdressLabel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        IPAdressLabel.Location = New Point(6, 148)
        IPAdressLabel.Margin = New Padding(1, 0, 1, 0)
        IPAdressLabel.Name = "IPAdressLabel"
        IPAdressLabel.Size = New Size(248, 20)
        IPAdressLabel.TabIndex = 2
        IPAdressLabel.Text = "EnterIPAdress.IPAdressLabel"
        ' 
        ' ConnectWithHttps
        ' 
        ConnectWithHttps.AutoSize = True
        ConnectWithHttps.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ConnectWithHttps.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        ConnectWithHttps.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ConnectWithHttps.Location = New Point(502, 147)
        ConnectWithHttps.Margin = New Padding(1, 2, 1, 2)
        ConnectWithHttps.Name = "ConnectWithHttps"
        ConnectWithHttps.Size = New Size(304, 24)
        ConnectWithHttps.TabIndex = 3
        ConnectWithHttps.Text = "EnterIPAdress.ConnectWithHttps"
        ConnectWithHttps.UseVisualStyleBackColor = False
        ' 
        ' Connect
        ' 
        Connect.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Connect.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Connect.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Connect.Location = New Point(-1, 215)
        Connect.Margin = New Padding(1, 2, 1, 2)
        Connect.Name = "Connect"
        Connect.Size = New Size(434, 48)
        Connect.TabIndex = 4
        Connect.Text = "EnterIPAdress.Connect"
        Connect.TextAlign = ContentAlignment.MiddleLeft
        Connect.UseVisualStyleBackColor = False
        ' 
        ' Cancel
        ' 
        Cancel.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Cancel.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point)
        Cancel.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Cancel.Location = New Point(428, 215)
        Cancel.Margin = New Padding(1, 2, 1, 2)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(378, 48)
        Cancel.TabIndex = 5
        Cancel.Text = "EnterIPAdress.Cancel"
        Cancel.TextAlign = ContentAlignment.MiddleRight
        Cancel.UseVisualStyleBackColor = False
        ' 
        ' EnterIPAdress
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(805, 258)
        Controls.Add(Cancel)
        Controls.Add(Connect)
        Controls.Add(ConnectWithHttps)
        Controls.Add(IPAdressLabel)
        Controls.Add(IPAdress)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Margin = New Padding(1, 2, 1, 2)
        Name = "EnterIPAdress"
        Text = "WebConnect.EnterIPAdress"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents IPAdress As TextBox
    Friend WithEvents IPAdressLabel As Label
    Friend WithEvents ConnectWithHttps As CheckBox
    Friend WithEvents Connect As Button
    Friend WithEvents Cancel As Button
End Class
