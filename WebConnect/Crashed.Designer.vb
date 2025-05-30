<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crashed
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Description = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Header = New Label()
        Stopcode = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Description
        ' 
        Description.AutoSize = True
        Description.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Description.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Description.Location = New Point(217, 87)
        Description.Name = "Description"
        Description.Size = New Size(170, 25)
        Description.TabIndex = 8
        Description.Text = "Crashed.Description"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(182, 172)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(228, 9)
        Label1.Margin = New Padding(1, 0, 1, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 22)
        Label1.TabIndex = 6
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Header.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(228, 9)
        Header.Name = "Header"
        Header.Size = New Size(229, 41)
        Header.TabIndex = 9
        Header.Text = "Crashed.Header"
        ' 
        ' Stopcode
        ' 
        Stopcode.AutoSize = True
        Stopcode.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Stopcode.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Stopcode.Location = New Point(217, 140)
        Stopcode.Name = "Stopcode"
        Stopcode.Size = New Size(156, 25)
        Stopcode.TabIndex = 10
        Stopcode.Text = "Crashed.Stopcode"
        ' 
        ' Crashed
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(1582, 415)
        Controls.Add(Stopcode)
        Controls.Add(Header)
        Controls.Add(Description)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "Crashed"
        Text = "WebConnect.Crashed"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Description As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Header As Label
    Friend WithEvents Stopcode As Label
End Class
