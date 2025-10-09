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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BootError))
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Label1.Location = New Point(228, 9)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 22)
        Label1.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Location = New Point(-1, 236)
        Button1.Margin = New Padding(1, 2, 1, 2)
        Button1.Name = "Button1"
        Button1.Size = New Size(400, 50)
        Button1.TabIndex = 1
        Button1.Text = "Terminate"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button2.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold)
        Button2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.Location = New Point(389, 236)
        Button2.Margin = New Padding(1, 2, 1, 2)
        Button2.Name = "Button2"
        Button2.Size = New Size(430, 50)
        Button2.TabIndex = 3
        Button2.Text = "Try again"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(232, 23)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 25)
        Label2.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(28, 21)
        Label3.Name = "Label3"
        Label3.Size = New Size(508, 125)
        Label3.TabIndex = 6
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' BootError
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(816, 282)
        ControlBox = False
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        KeyPreview = True
        Margin = New Padding(1, 2, 1, 2)
        Name = "BootError"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Can't boot WebConnect Application for Windows"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class