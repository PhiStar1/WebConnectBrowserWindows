Public Class EnterMyFRITZ_Adress
    'Diese Form wird angezeigt, wenn der Benutzer auf "FRITZ!NAS" klickt.
    'Dieses Fenster fordert die MyFRITZ!-Adresse und den Port an, um eine Verbindung zum NAS herzustellen.
    'Das bringt folgendes: Der Benutzer kann eine Verbindung zu seiner FRITZ!Box herstellen, um auf das NAS zuzugreifen.
    'Diese Variable wird verwendet, um zu überprüfen, ob die Eingabetaste gedrückt wurde.
    Private isEnterPressed As Boolean = False

    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    'Dieser Sub überprüft, ob die Eingabetaste gedrückt wurde und wechselt den Fokus.
    Private Sub EnterMyFRITZ_Adress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Wenn Enter gedrückt wird
        If e.KeyCode = Keys.Enter Then
            If MyFRITZAdress.Focused Then
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
                    MyFRITZAdress.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If
        If e.KeyCode = Keys.Left Then
            If Port.Focused Then
                ' Nur wenn der Cursor am Anfang von Port ist (SelectionStart = 0)
                If Port.SelectionStart = 0 Then
                    MyFRITZAdress.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Backspace ohne Strg, am Anfang von Port).")
                End If
            End If
        End If

        ' Wenn Ctrl + Backspace gedrückt wird
        If e.Control AndAlso e.KeyCode = Keys.Back Then
            Debug.WriteLine("CTRL + BACKSPACE gedrückt")
            If Port.Focused Then
                If Port.Text = "" Then
                    MyFRITZAdress.Select()
                    Debug.WriteLine("Fokus auf MyFRITZAdresse gewechselt (Ctrl + Backspace).")
                End If
            End If
        End If

        ' Wenn die rechte Pfeiltaste gedrückt wird und der Cursor am Ende des Textes ist
        If e.KeyCode = Keys.Right Then
            If MyFRITZAdress.Focused Then
                Dim cursorPosition As Integer = MyFRITZAdress.SelectionStart
                Dim textLength As Integer = MyFRITZAdress.Text.Length
                If cursorPosition = textLength Then
                    Port.Select()
                    Debug.WriteLine("Fokus auf Port gewechselt (Cursor am Ende von MyFRITZAdresse).")
                End If
            End If
        End If
    End Sub




    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub EnterMyFRITZ_Adress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "MyFRITZ!-Adresse eingeben"
            Header.Text = "Gebe deine MyFRITZ!-Adresse hier ein,
  um dich mit deinen FRITZ!NAS-Gerät zu verbinden."
            MyFRITZAdress.PlaceholderText = "MyFRITZ!-Adresse"
            Port.PlaceholderText = "Port"
            MyFRITZAdressButton.Text = "Los"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Enter MyFRITZ! Address"
            Header.Text = "Enter your MyFRITZ! address here,
    to connect to your FRITZ!NAS device."
            MyFRITZAdress.PlaceholderText = "MyFRITZ! Address"
            Port.PlaceholderText = "Port"
            MyFRITZAdressButton.Text = "Go"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Entrez l'adresse MyFRITZ!"
            Header.Text = "Entrez votre adresse MyFRITZ! ici,
    pour vous connecter à votre appareil FRITZ!NAS."
            MyFRITZAdress.PlaceholderText = "Adresse MyFRITZ!"
            Port.PlaceholderText = "Port"
            MyFRITZAdressButton.Text = "Aller"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Introducir dirección MyFRITZ!"
            Header.Text = "Introduce tu dirección MyFRITZ! aquí,
    para conectarte a tu dispositivo FRITZ!NAS."
            MyFRITZAdress.PlaceholderText = "¡Dirección MyFRITZ!"
            Port.PlaceholderText = "Puerto"
            MyFRITZAdressButton.Text = "Ir"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Inserisci indirizzo MyFRITZ!"
            Header.Text = "Inserisci qui il tuo indirizzo MyFRITZ!,
    per connetterti al tuo dispositivo FRITZ!NAS."
            MyFRITZAdress.PlaceholderText = "Indirizzo MyFRITZ!"
            Port.PlaceholderText = "Porta"
            MyFRITZAdressButton.Text = "Vai"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "MyFRITZ! Adresini Girin"
            Header.Text = "MyFRITZ! adresinizi buraya girin,
    FRITZ!NAS cihazınıza bağlanmak için."
            MyFRITZAdress.PlaceholderText = "MyFRITZ! Adresi"
            Port.PlaceholderText = "Port"
            MyFRITZAdressButton.Text = "Git"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf das Textfeld klickt.
    'Dieser Sub löscht den Text im Textfeld, wenn der Text "MyFRITZ!-Adresse" ist
    Private Sub MyFRITZAdress_Click(sender As Object, e As EventArgs) Handles MyFRITZAdress.Click
        'Wenn der Text "MyFRITZ!-Adresse" ist, wird der Text gelöscht.
        If MyFRITZAdress.Text = "MyFRITZ!-Adresse" Then
            'Der Text wird gelöscht.
            MyFRITZAdress.Clear()

        End If
    End Sub

    'Diese Funktion wird ausgeführt, wenn der Benutzer auf den Button klickt.
    'Diese Funktion verbindet den Benutzer mit der MyFRITZ!-Adresse.
    Private Function ConnectToMyFRITZAdress()
        'Versuchen, eine Verbindung zur MyFRITZ!-Adresse herzustellen
        Try
            'Füge einen neuen Tab hinzu, der auf die NAS-Seite der FRITZ!Box zeigt
            Form1.AddNewTab("https://" & MyFRITZAdress.Text & ".myfritz.net:" & Port.Text & "/nas")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()
        Catch ex As Exception
            'Fehlermeldung anzeigen
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try
    End Function
    'Diese Funktion wird ausgeführt, wenn der Benutzer auf den Button klickt.
    'Diese Funktion verbindet den Benutzer mit der MyFRITZ!-Adresse.
    Private Sub MyFRITZAdresseButton_Click(sender As Object, e As EventArgs) Handles MyFRITZAdressButton.Click
        'Funktion ConnectToMyFRITZAdress ausführen
        ConnectToMyFRITZAdress()

    End Sub
End Class