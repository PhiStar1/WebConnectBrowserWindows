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
        SuspendLayout()
        ' 
        ' bootprogress
        ' 
        bootprogress.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        bootprogress.Location = New Point(10, 62)
        bootprogress.MarqueeAnimationSpeed = 0
        bootprogress.Name = "bootprogress"
        bootprogress.Size = New Size(740, 10)
        bootprogress.TabIndex = 0
        bootprogress.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(283, 50)
        Label1.TabIndex = 1
        Label1.Text = "Booting WebConnect v2024.12.10" & vbCrLf & "Wait a moment!!!"
        Label1.UseWaitCursor = True
        ' 
        ' booting
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(762, 82)
        ControlBox = False
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
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents bootprogress As ProgressBar
    Friend WithEvents Label1 As Label
End Class
