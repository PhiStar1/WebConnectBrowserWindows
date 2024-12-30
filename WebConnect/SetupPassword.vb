Public Class SetupPassword
    Private Sub EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Wenn Enter gedrückt wird
        If e.KeyCode = Keys.Enter Then
            If EnterNewPasswordText.Focused Then
                ' Fokus auf Port setzen, wenn MyFRITZAdresse fokussiert ist
                ConfirmNewPasswordText.Select()
            ElseIf ConfirmNewPasswordText.Focused Then
                ' Funktion ausführen, wenn Port fokussiert ist
                My.Settings.AdminPassword = EnterNewPasswordText.Text
                Me.Close()
            End If

            ' Verhindern, dass Enter die Standardaktion ausführt
            e.Handled = True
        End If

        ' Wenn Escape gedrückt wird, das Formular schließen
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

        ' Wenn Backspace gedrückt wird und nicht Strg, Fokus zu MyFRITZAdresse wechseln, wenn der Cursor am Anfang ist
        If e.KeyCode = Keys.Back AndAlso Not e.Control Then
            If ConfirmNewPasswordText.Focused Then
                ' Nur wenn der Cursor am Anfang von Port ist (SelectionStart = 0)
                If ConfirmNewPasswordText.SelectionStart = 0 Then
                    EnterNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If
        If e.KeyCode = Keys.Left Then
            If ConfirmNewPasswordText.Focused Then
                ' Nur wenn der Cursor am Anfang von Port ist (SelectionStart = 0)
                If ConfirmNewPasswordText.SelectionStart = 0 Then
                    EnterNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If

        ' Wenn Ctrl + Backspace gedrückt wird
        If e.Control AndAlso e.KeyCode = Keys.Back Then
            Debug.WriteLine("CTRL + BACKSPACE gedrückt")
            If ConfirmNewPasswordText.Focused Then
                If ConfirmNewPasswordText.Text = "" Then
                    EnterNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Ctrl + Backspace).")
                End If
            End If
        End If

        ' Wenn die rechte Pfeiltaste gedrückt wird und der Cursor am Ende des Textes ist
        If e.KeyCode = Keys.Right Then
            If EnterNewPasswordText.Focused Then
                Dim cursorPosition As Integer = EnterNewPasswordText.SelectionStart
                Dim textLength As Integer = EnterNewPasswordText.Text.Length
                If cursorPosition = textLength Then
                    ConfirmNewPasswordText.Select()
                    Debug.WriteLine("Fokus auf Port gewechselt (Cursor am Ende von MyFRITZAdresse).")
                End If
            End If
        End If
    End Sub
    Private Sub SetupPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles ApplyButton.Click
        If EnterNewPasswordText.Text = ConfirmNewPasswordText.Text Then
            My.Settings.AdminPassword = EnterNewPasswordText.Text
            Me.Close()
        Else
            Me.Text = "Die Passwörter stimmen nicht überein"
        End If
    End Sub
End Class