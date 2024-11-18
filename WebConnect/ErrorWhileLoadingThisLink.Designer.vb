<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ErrorWhileLoadingThisLink
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorWhileLoadingThisLink))
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("SamsungOneUILatin 700", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(120, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(462, 106)
        Label1.TabIndex = 0
        Label1.Text = "Dieser Link kann aktuell " & vbCrLf & "  nicht geöffnet werden"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PictureBox1.ErrorImage = CType(resources.GetObject("PictureBox1.ErrorImage"), Image)
        PictureBox1.Location = New Point(12, 9)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(102, 98)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label2.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label2.Location = New Point(546, 117)
        Label2.Name = "Label2"
        Label2.Size = New Size(36, 25)
        Label2.TabIndex = 2
        Label2.Text = "OK"
        ' 
        ' ErrorWhileLoadingThisLink
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(594, 151)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "ErrorWhileLoadingThisLink"
        Text = "Beim Laden des Links ist ein Fehler aufgetreten"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
