<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnterMyFRITZ_Adress
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
        MyFRITZAdress = New TextBox()
        MyFRITZAdressButton = New Button()
        Port = New TextBox()
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
        Header.Size = New Size(592, 46)
        Header.TabIndex = 0
        Header.Text = "EnterMyFRITZ_Adress.Header"
        ' 
        ' MyFRITZAdress
        ' 
        MyFRITZAdress.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MyFRITZAdress.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MyFRITZAdress.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MyFRITZAdress.Location = New Point(12, 198)
        MyFRITZAdress.Name = "MyFRITZAdress"
        MyFRITZAdress.Size = New Size(369, 28)
        MyFRITZAdress.TabIndex = 1
        MyFRITZAdress.Text = "EnterMyFRITZ_Adress.MyFRITZAdress"
        ' 
        ' MyFRITZAdressButton
        ' 
        MyFRITZAdressButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MyFRITZAdressButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MyFRITZAdressButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MyFRITZAdressButton.Location = New Point(698, 198)
        MyFRITZAdressButton.Name = "MyFRITZAdressButton"
        MyFRITZAdressButton.Size = New Size(438, 42)
        MyFRITZAdressButton.TabIndex = 2
        MyFRITZAdressButton.Text = "EnterMyFRITZ_Adress.MyFRITZAdressButton"
        MyFRITZAdressButton.UseVisualStyleBackColor = False
        ' 
        ' Port
        ' 
        Port.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Port.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Port.Location = New Point(387, 198)
        Port.Name = "Port"
        Port.Size = New Size(305, 31)
        Port.TabIndex = 3
        Port.Text = "EnterMyFRITZ_Adress.Port"
        ' 
        ' EnterMyFRITZ_Adress
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1146, 252)
        Controls.Add(Port)
        Controls.Add(MyFRITZAdressButton)
        Controls.Add(MyFRITZAdress)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "EnterMyFRITZ_Adress"
        Text = "WebConnect.EnterMyFRITZ_Adress"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents MyFRITZAdress As TextBox
    Friend WithEvents MyFRITZAdressButton As Button
    Friend WithEvents Port As TextBox
End Class
