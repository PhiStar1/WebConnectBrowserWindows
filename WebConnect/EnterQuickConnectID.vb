
Public Class EnterQuickConnectID
    '    Diese Form wird angezeigt, wenn der Benutzer auf Shortcuts/Geraete/NAS/Synology klickt.
    '    Dieses Fenster fordert den Benutzer auf, eine QuickConnect-ID einzugeben.
    '    Das bringt folgendes: Der Benutzer kann sich mit seinem Synology-NAS verbinden.

    '    Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    '    Dieser Sub überprüft, ob der Benutzer Enter oder Escape gedrückt hat.
    Private Sub EnterQuickConnectID_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        '    Wenn der Benutzer Enter drückt, wird die Verbindung mit der QuickConnect-ID hergestellt.
        If e.KeyCode = Keys.Enter Then
            '    Wenn der Benutzer auf das Textfeld QuickConnectID fokussiert ist, wird die Verbindung mit der QuickConnect-ID hergestellt.
            If QuickConnectID.Focused Then
                '    Die Verbindung mit der QuickConnect-ID wird hergestellt.
                ConnectToQuickConnect()
            End If

        End If
        '    Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        If e.KeyCode = Keys.Escape Then
            '    Das Fenster wird geschlossen.
            Me.Close()

        End If
    End Sub

    '    Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub EnterQuickConnectID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Gebe deine QuickConnect-ID hier ein,
  um dich mit deinen Synology-Gerät
    zu verbinden."
            QuickConnectID.PlaceholderText = "QuickConnect-ID"
            ConnectWithDSMButton.Text = "Los"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Enter your QuickConnect ID here,
    to connect to your Synology device."
            QuickConnectID.PlaceholderText = "QuickConnect-ID"
            ConnectWithDSMButton.Text = "Go"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Entrez votre ID QuickConnect ici,
    pour vous connecter à votre appareil Synology."
            QuickConnectID.PlaceholderText = "QuickConnect-ID"
            ConnectWithDSMButton.Text = "Aller"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Introduce tu ID de QuickConnect aquí,
    para conectarte a tu dispositivo Synology."
            QuickConnectID.PlaceholderText = "ID de QuickConnect"
            ConnectWithDSMButton.Text = "Ir"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Inserisci qui il tuo ID QuickConnect,
    per connetterti al tuo dispositivo Synology."
            QuickConnectID.PlaceholderText = "ID di QuickConnect"
            ConnectWithDSMButton.Text = "Vai"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "QuickConnect ID'nizi buraya girin,
    Synology cihazınıza bağlanmak için."
            QuickConnectID.PlaceholderText = "QuickConnect-ID"
            ConnectWithDSMButton.Text = "Git"
        End If
    End Sub


    '    Dieser Sub wird ausgeführt, wenn der Benutzer auf das Textfeld QuickConnectID klickt.
    '    Dieser Sub löscht den Text im Textfeld QuickConnectID, wenn der Text "QuickConnect-ID" ist.
    Private Sub QuickConnectID_Click(sender As Object, e As EventArgs) Handles QuickConnectID.Click
        '    Wenn der Text "QuickConnect-ID" ist, wird der Text gelöscht.
        If QuickConnectID.Text = "QuickConnect-ID" Then
            '    Der Text wird gelöscht.
            QuickConnectID.Clear()

        End If
    End Sub

    '    Dieser Sub wird ausgeführt, wenn der Benutzer auf den Verbinden-Button klickt.
    '    Dieser Sub verbindet sich mit der QuickConnect-ID.
    Private Sub ConnectWithDSMButton_Click(sender As Object, e As EventArgs) Handles ConnectWithDSMButton.Click
        '    Die Verbindung mit der QuickConnect-ID wird hergestellt.
        ConnectToQuickConnect()

    End Sub

    'Diese Funktion verbindet sich mit der QuickConnect-ID.
    'Diese Funktion wird verwendet, um sich mit der QuickConnect-ID zu verbinden.
    Private Function ConnectToQuickConnect()
        '    Die Verbindung mit der QuickConnect-ID wird hergestellt.
        Try

            Form1.AddNewTab("https://" & QuickConnectID.Text & ".quickconnect.to")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()

        Catch ex As Exception
            '    Wenn ein Fehler auftritt, wird der Benutzer benachrichtigt.
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try
    End Function
End Class