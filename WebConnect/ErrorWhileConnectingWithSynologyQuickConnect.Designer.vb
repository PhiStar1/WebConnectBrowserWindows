<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ErrorWhileConnectingWithSynologyQuickConnect
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
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 169)
        Label1.Name = "Label1"
        Label1.Size = New Size(839, 50)
        Label1.TabIndex = 0
        Label1.Text = "Bei dem Versuch, eine Verbindung zu Synology QuickConnect herzustellen, ist ein Problem aufgetreten." & vbCrLf & "Erneut versuchen?" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(154, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(678, 106)
        Label2.TabIndex = 1
        Label2.Text = "QuickConnect kann nicht verbunden " & vbCrLf & "  werden"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PictureBox1.Location = New Point(18, 40)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 102)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Location = New Point(-1, 238)
        Button1.Name = "Button1"
        Button1.Size = New Size(480, 51)
        Button1.TabIndex = 3
        Button1.Text = "Erneut versuchen"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(475, 238)
        Button2.Name = "Button2"
        Button2.Size = New Size(455, 51)
        Button2.TabIndex = 4
        Button2.Text = "Abbrechen"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ErrorWhileConnectingWithSynologyQuickConnect
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(927, 289)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "ErrorWhileConnectingWithSynologyQuickConnect"
        Text = "QuickConnect ist auf ein Problem gestoßen"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
