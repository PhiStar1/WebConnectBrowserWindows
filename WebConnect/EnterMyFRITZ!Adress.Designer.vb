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
        Label1 = New Label()
        MyFRITZAdresse = New TextBox()
        MyFRITZAdresseButton = New Button()
        Port = New TextBox()
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
        Label1.Size = New Size(703, 159)
        Label1.TabIndex = 0
        Label1.Text = "Gebe deine MyFRITZ!-Adresse hier ein," & vbCrLf & "  um dich mit deinen FRITZ!NAS-Gerät " & vbCrLf & "    zu verbinden."
        ' 
        ' MyFRITZAdresse
        ' 
        MyFRITZAdresse.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MyFRITZAdresse.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MyFRITZAdresse.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MyFRITZAdresse.Location = New Point(12, 198)
        MyFRITZAdresse.Name = "MyFRITZAdresse"
        MyFRITZAdresse.Size = New Size(347, 31)
        MyFRITZAdresse.TabIndex = 1
        MyFRITZAdresse.Text = "MyFRITZ!-Adresse"
        ' 
        ' MyFRITZAdresseButton
        ' 
        MyFRITZAdresseButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        MyFRITZAdresseButton.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        MyFRITZAdresseButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        MyFRITZAdresseButton.Location = New Point(676, 198)
        MyFRITZAdresseButton.Name = "MyFRITZAdresseButton"
        MyFRITZAdresseButton.Size = New Size(112, 42)
        MyFRITZAdresseButton.TabIndex = 2
        MyFRITZAdresseButton.Text = "Los"
        MyFRITZAdresseButton.UseVisualStyleBackColor = False
        ' 
        ' Port
        ' 
        Port.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Port.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Port.Location = New Point(365, 198)
        Port.Name = "Port"
        Port.Size = New Size(305, 31)
        Port.TabIndex = 3
        Port.Text = "443"
        ' 
        ' EnterMyFRITZ_Adress
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 252)
        Controls.Add(Port)
        Controls.Add(MyFRITZAdresseButton)
        Controls.Add(MyFRITZAdresse)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "EnterMyFRITZ_Adress"
        Text = "MyFRITZ!-Adresse eingeben"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MyFRITZAdresse As TextBox
    Friend WithEvents MyFRITZAdresseButton As Button
    Friend WithEvents Port As TextBox
End Class
