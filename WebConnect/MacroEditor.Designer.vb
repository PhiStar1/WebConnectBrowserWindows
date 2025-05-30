<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MacroEditor
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
        ExecuteButton = New Button()
        RichTextBox1 = New RichTextBox()
        TabControl1 = New TabControl()
        Errors = New TabPage()
        ErrorsText = New RichTextBox()
        TabControl1.SuspendLayout()
        Errors.SuspendLayout()
        SuspendLayout()
        ' 
        ' ExecuteButton
        ' 
        ExecuteButton.Location = New Point(12, 12)
        ExecuteButton.Name = "ExecuteButton"
        ExecuteButton.Size = New Size(112, 34)
        ExecuteButton.TabIndex = 0
        ExecuteButton.Text = "Button1"
        ExecuteButton.UseVisualStyleBackColor = True
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(12, 52)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(776, 188)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(Errors)
        TabControl1.Location = New Point(12, 246)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(776, 192)
        TabControl1.TabIndex = 2
        ' 
        ' Errors
        ' 
        Errors.Controls.Add(ErrorsText)
        Errors.Location = New Point(4, 34)
        Errors.Name = "Errors"
        Errors.Padding = New Padding(3)
        Errors.Size = New Size(768, 154)
        Errors.TabIndex = 0
        Errors.Text = "Fehler"
        Errors.UseVisualStyleBackColor = True
        ' 
        ' ErrorsText
        ' 
        ErrorsText.Location = New Point(6, 3)
        ErrorsText.Name = "ErrorsText"
        ErrorsText.Size = New Size(756, 144)
        ErrorsText.TabIndex = 0
        ErrorsText.Text = ""
        ' 
        ' MacroEditor
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TabControl1)
        Controls.Add(RichTextBox1)
        Controls.Add(ExecuteButton)
        Name = "MacroEditor"
        Text = "MacroEditor"
        TopMost = True
        TabControl1.ResumeLayout(False)
        Errors.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents ExecuteButton As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Errors As TabPage
    Friend WithEvents ErrorsText As RichTextBox
End Class
