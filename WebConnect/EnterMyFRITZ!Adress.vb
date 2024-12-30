Public Class EnterMyFRITZ_Adress
    Private isEnterPressed As Boolean = False

    Private Sub EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Wenn Enter gedrückt wird
        If e.KeyCode = Keys.Enter Then
            If MyFRITZAdresse.Focused Then
                ' Fokus auf Port setzen, wenn MyFRITZAdresse fokussiert ist
                Port.Select()
                Debug.WriteLine("Fokus auf Port gewechselt.")
            ElseIf Port.Focused Then
                ' Funktion ausführen, wenn Port fokussiert ist
                Debug.WriteLine("Funktion ConnectToMyFRITZAdress wird ausgeführt.")
                ConnectToMyFRITZAdress()
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
            If Port.Focused Then
                ' Nur wenn der Cursor am Anfang von Port ist (SelectionStart = 0)
                If Port.SelectionStart = 0 Then
                    MyFRITZAdresse.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If
        If e.KeyCode = Keys.Left Then
            If Port.Focused Then
                ' Nur wenn der Cursor am Anfang von Port ist (SelectionStart = 0)
                If Port.SelectionStart = 0 Then
                    MyFRITZAdresse.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If

        ' Wenn Ctrl + Backspace gedrückt wird
        If e.Control AndAlso e.KeyCode = Keys.Back Then
            Debug.WriteLine("CTRL + BACKSPACE gedrückt")
            If Port.Focused Then
                If Port.Text = "" Then
                    MyFRITZAdresse.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Ctrl + Backspace).")
                End If
            End If
        End If

        ' Wenn die rechte Pfeiltaste gedrückt wird und der Cursor am Ende des Textes ist
        If e.KeyCode = Keys.Right Then
            If MyFRITZAdresse.Focused Then
                Dim cursorPosition As Integer = MyFRITZAdresse.SelectionStart
                Dim textLength As Integer = MyFRITZAdresse.Text.Length
                If cursorPosition = textLength Then
                    Port.Select()
                    Debug.WriteLine("Fokus auf Port gewechselt (Cursor am Ende von MyFRITZAdresse).")
                End If
            End If
        End If
    End Sub





    Private Sub EnterMyFRITZ_Adress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MyFRITZAdress_Click(sender As Object, e As EventArgs) Handles MyFRITZAdresse.Click
        If MyFRITZAdresse.Text = "MyFRITZ!-Adresse" Then
            MyFRITZAdresse.Clear()

        End If
    End Sub
    Private Function ConnectToMyFRITZAdress()
        Try
            Form1.AddNewTab("https://" & MyFRITZAdresse.Text & ".myfritz.net:" & Port.Text & "/nas")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()
        Catch ex As Exception
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try
    End Function
    Private Sub MyFRITZAdresseButton_Click(sender As Object, e As EventArgs) Handles MyFRITZAdresseButton.Click
        ConnectToMyFRITZAdress()

    End Sub
End Class