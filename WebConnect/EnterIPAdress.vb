'Import von Bibliotheken
Imports System.Net

Public Class EnterIPAdress
    'Diese Form wird angezeigt, wenn der Benutzer auf Shortcuts/Geräte/Router oder NAS/Stattdessen IP-Adresse eingeben klickt.
    'Dieses Fenster ermöglicht es dem Benutzer, eine IP-Adresse einzugeben, um sich mit einem Router oder NAS zu verbinden.
    'Das bringt folgendes: Der Benutzer kann sich mit einem Router oder NAS verbinden, indem er die IP-Adresse eingibt.

    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    'Dieser Sub überprüft, ob der Benutzer Enter oder Escape gedrückt hat.
    Private Sub EnterIPAdress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Wenn der Benutzer Enter drückt, wird die Methode ConnectToIPAdress() oder Me.Close() aufgerufen.
        Debug.WriteLine("Gedrückt")
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            'Das Fenster wird geschlossen.
            Me.Close()

        End If
        'Wenn der Benutzer Enter drückt, wird die Methode ConnectToIPAdress() aufgerufen.
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            'Die Methode ConnectToIPAdress() wird aufgerufen.
            Debug.WriteLine("enter Gedrückt")

            ConnectToIPAdress()

        End If
    End Sub
    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Connect-Button klickt.
    'Dieser Sub ruft die Methode ConnectToIPAdress() auf.
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click
        'Die Methode ConnectToIPAdress() wird aufgerufen.
        ConnectToIPAdress()


    End Sub
    'Diese Methode wird aufgerufen, wenn der Benutzer auf den Connect-Button klickt oder Enter drückt.
    'Diese Methode verbindet den Benutzer mit der eingegebenen IP-Adresse.
    Public Function ConnectToIPAdress()

        'Wenn der Benutzer "Mit HTTPS verbinden" ausgewählt hat, wird die IP-Adresse mit HTTPS geöffnet.
        If ConnectWithHttps.Checked Then
            'Wenn die IP-Adresse nicht leer ist, wird die IP-Adresse mit HTTPS geöffnet.
            If Not IPAdress.Text = "" Then
                'Die IP-Adresse wird mit HTTPS geöffnet.
                Form1.AddNewTab("https://" & IPAdress.Text)
                Form1.TextBox1.Text = "https://" & IPAdress.Text
                Me.Close()
                Launcher.Close()
            Else
                'Wenn die IP-Adresse leer ist, wird der Benutzer benachrichtigt.
                IPAdress.Text = "Gib eine IP-Adresse ein!"
                IPAdress.SelectAll()
            End If
        Else
            'Wenn der Benutzer "Mit HTTP verbinden" ausgewählt hat, wird die IP-Adresse mit HTTP geöffnet.
            If Not IPAdress.Text = "" Then
                Form1.AddNewTab("http://" & IPAdress.Text)
                Form1.TextBox1.Text = "http://" & IPAdress.Text
                Me.Close()
                Launcher.Close()
            Else
                'Wenn die IP-Adresse leer ist, wird der Benutzer benachrichtigt.
                IPAdress.Text = "Gib eine IP-Adresse ein!"
                IPAdress.SelectAll()
            End If
        End If

    End Function
    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub EnterIPAdress_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Gerät manuell verbinden"
            Header.Text = "Gib die IP-Adresse zu deinen
  Gerät ein"
            IPAdressLabel.Text = "IP-Adresse"
            ConnectWithHttps.Text = "Verbindung per https://"
            Connect.Text = "Verbinden"
            Cancel.Text = "Abbrechen"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Manually connect device"
            Header.Text = "Enter the IP address for your
 device"
            IPAdressLabel.Text = "IP address"
            ConnectWithHttps.Text = "Connect via https://"
            Connect.Text = "Connect"
            Cancel.Text = "Cancel"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Connecter manuellement l'appareil"
            Header.Text = "Entrez l'adresse IP de votre
    appareil"
            IPAdressLabel.Text = "Adresse IP"
            ConnectWithHttps.Text = "Se connecter via https://"
            Connect.Text = "Connecter"
            Cancel.Text = "Annuler"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Conectar dispositivo manualmente"
            Header.Text = "Introduce la dirección IP de tu
    dispositivo"
            IPAdressLabel.Text = "Dirección IP"
            ConnectWithHttps.Text = "Conectar a través de https://"
            Connect.Text = "Conectar"
            Cancel.Text = "Cancelar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Collegare manualmente il dispositivo"
            Header.Text = "Inserisci l'indirizzo IP del tuo
    dispositivo"
            IPAdressLabel.Text = "Indirizzo IP"
            ConnectWithHttps.Text = "Collegati tramite https://"
            Connect.Text = "Collegare"
            Cancel.Text = "Annulla"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Cihazı manuel olarak bağla"
            Header.Text = "Cihazınızın IP adresini girin"
            IPAdressLabel.Text = "IP adresi"
            ConnectWithHttps.Text = "Bağlantı https:// ile"
            Connect.Text = "Bağlan"
            Cancel.Text = "İptal"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Cancel-Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class