<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BootError
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
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(228, 9)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Location = New Point(-1, 236)
        Button1.Margin = New Padding(1, 2, 1, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(242, 50)
        Button1.TabIndex = 1
        Button1.Text = "Terminate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(182, 172)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(271, 236)
        Button2.Margin = New Padding(1, 2, 1, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(248, 50)
        Button2.TabIndex = 3
        Button2.Text = "Try again"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button3.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button3.Location = New Point(558, 236)
        Button3.Margin = New Padding(1, 2, 1, 2)
        Button3.Name = "Button3"
        Button3.Size = New Size(248, 50)
        Button3.TabIndex = 4
        Button3.Text = "Start WebConnect Recovery"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(232, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(508, 125)
        Label2.TabIndex = 5
        Label2.Text = "An Error occurred while booting the WebConnect application!!!" & vbCrLf & vbCrLf & "Please try to erase your current settings " & vbCrLf & "or try to reinstall WebConnect with the " & vbCrLf & "help of a update file."
        ' 
        ' BootError
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(816, 282)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Margin = New Padding(1, 2, 1, 2)
        Name = "BootError"
        Text = "Can't boot WebConnect Application for Windows"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
End Class
