Imports System.CodeDom.Compiler
Imports Microsoft.VisualBasic

Public Class MacroEditor

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        ' Code to handle text change event  
    End Sub

    Private Sub ExecuteButton_Click(sender As Object, e As EventArgs) Handles ExecuteButton.Click
        ' Code to execute the content of the RichTextBox  
        Dim code As String = RichTextBox1.Text
        ExecuteCode(code)
    End Sub

    Private Sub ExecuteCode(code As String)
        Try
            ErrorsText.Text = ""
            Dim provider As CodeDomProvider = CodeDomProvider.CreateProvider("VB")
            Dim parameters As New CompilerParameters()
            parameters.GenerateInMemory = True
            parameters.ReferencedAssemblies.Add("System.dll")
            parameters.ReferencedAssemblies.Add("System.Windows.Forms.dll")
            parameters.ReferencedAssemblies.Add("System.Drawing.dll")
            parameters.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
            parameters.ReferencedAssemblies.Add(Me.GetType().Assembly.Location)

            Dim results As CompilerResults = provider.CompileAssemblyFromSource(parameters, WrapCode(code))

            If results.Errors.Count > 0 Then
                Dim errors As String = String.Join(Environment.NewLine, results.Errors.Cast(Of CompilerError).Select(Function(e) e.ToString()))
                MessageBox.Show("Compilation failed: " & errors)
            Else
                Dim assembly As Reflection.Assembly = results.CompiledAssembly
                Dim type As Type = assembly.GetType("DynamicCode.Execution")
                Dim method As Reflection.MethodInfo = type.GetMethod("Execute")
                method.Invoke(Nothing, New Object() {Me})
            End If
        Catch ex As System.PlatformNotSupportedException
            ErrorsText.Text = "Plattform not supported: " & ex.Message

        End Try

    End Sub

    Private Function WrapCode(code As String) As String
        Return "
        Imports System
        Imports System.Windows.Forms
        Imports System.Drawing

        Public Class DynamicCode
            Public Shared Sub Execute(editor As MacroEditor)
                " & code & "
            End Sub
        End Class"
    End Function

    Private Sub MacroEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorsText.Text = ""

    End Sub
End Class