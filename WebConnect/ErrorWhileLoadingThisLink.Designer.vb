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
        Header = New Label()
        PictureBox1 = New PictureBox()
        OKButton = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Header
        ' 
        Header.AutoSize = True
        Header.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Header.Font = New Font("Microsoft Sans Serif", 20F, FontStyle.Bold, GraphicsUnit.Point)
        Header.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Header.Location = New Point(120, 9)
        Header.Name = "Header"
        Header.Size = New Size(672, 46)
        Header.TabIndex = 0
        Header.Text = "ErrorWhileLoadingThisLink.Header"
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
        ' OKButton
        ' 
        OKButton.AutoSize = True
        OKButton.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        OKButton.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point)
        OKButton.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        OKButton.Location = New Point(435, 120)
        OKButton.Name = "OKButton"
        OKButton.Size = New Size(344, 22)
        OKButton.TabIndex = 2
        OKButton.Text = "ErrorWhileLoadingThisLink.OKButton"
        ' 
        ' ErrorWhileLoadingThisLink
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(791, 151)
        Controls.Add(OKButton)
        Controls.Add(PictureBox1)
        Controls.Add(Header)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        KeyPreview = True
        Name = "ErrorWhileLoadingThisLink"
        Text = "WebConnect.ErrorWhileLoadingThisLink"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Header As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OKButton As Label
End Class
