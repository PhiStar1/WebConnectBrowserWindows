<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class booting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(booting))
        bootprogress = New ProgressBar()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' bootprogress
        ' 
        bootprogress.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        bootprogress.Location = New Point(1, 155)
        bootprogress.MarqueeAnimationSpeed = 0
        bootprogress.Name = "bootprogress"
        bootprogress.Size = New Size(428, 43)
        bootprogress.TabIndex = 0
        bootprogress.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 50)
        Label1.TabIndex = 1
        Label1.Text = "Booting WebConnect v2025.05.27" & vbCrLf & "Wait a moment!!!"
        Label1.UseWaitCursor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(48, 47)
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        PictureBox1.UseWaitCursor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 20F)
        Label2.Location = New Point(80, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(349, 54)
        Label2.TabIndex = 3
        Label2.Text = "WebConnect 2025"
        Label2.UseWaitCursor = True
        ' 
        ' booting
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(430, 161)
        ControlBox = False
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(bootprogress)
        Cursor = Cursors.WaitCursor
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "booting"
        RightToLeft = RightToLeft.No
        ShowIcon = False
        Text = "Booting WebConnect... Please wait"
        TopMost = True
        UseWaitCursor = True
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bootprogress As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
End Class
