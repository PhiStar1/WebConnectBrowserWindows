<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebConnectRecoveryTool
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
        Button1 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Button1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(162, 34)
        Button1.TabIndex = 0
        Button1.Text = "Reset Settings"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        Label1.ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Label1.Location = New Point(12, 416)
        Label1.Name = "Label1"
        Label1.Size = New Size(265, 25)
        Label1.TabIndex = 1
        Label1.Text = "WebConnect Recovery Tool v1.0"
        ' 
        ' WebConnectRecoveryTool
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(778, 445)
        Controls.Add(Label1)
        Controls.Add(Button1)
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Name = "WebConnectRecoveryTool"
        Text = "WebConnect Revovery Tool"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
