Imports System.ComponentModel
Imports System.Threading.Tasks.Dataflow

Public Class EnterCloudID
    'Dieses Fenster wird angezeigt, wenn der Benutzer auf Shortcuts/Geräte/NAS/Asustor klickt.
    'Dieses Fenster zeigt dem Benutzer ein Textfeld, um sich mit einem NAS von Asustor zu verbinden.
    'Das bringt folgendes: Der Benutzer kann sich mit einem NAS von Asustor verbinden.
    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    'Dieser Sub überprüft, ob der Benutzer Escape oder Enter drückt.
    Private Sub EnterCloudID(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        Debug.WriteLine("Gedrückt")
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            'Das Fenster wird geschlossen.
            Me.Close()

        End If
        'Wenn der Benutzer Enter drückt, wird die Funktion ConnectToCloudID ausgeführt.
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            'Die Funktion ConnectToCloudID wird ausgeführt.
            Debug.WriteLine("enter Gedrückt")
            'Wenn das Textfeld CloudID den Fokus hat, wird die Funktion ConnectToCloudID ausgeführt.
            If CloudID.Focused Then
                'Die Funktion ConnectToCloudID wird ausgeführt.
                ConnectToCloudID()
            End If
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub EnterCloudID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Cloud ID eingeben"
            Header.Text = "Gebe deine Cloud ID hier ein,
  um dich mit deinen Asustor-Gerät 
    zu verbinden."
            CloudID.Text = "Cloud ID"
            ConnectWithCloudIDButton.Text = "Los"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Enter Cloud ID"
            Header.Text = "Enter your Cloud ID here,
                to connect to your Asustor device."
            CloudID.Text = "Cloud ID"
            ConnectWithCloudIDButton.Text = "Go"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Entrer l'ID Cloud"
            Header.Text = "Entrez votre ID Cloud ici,
                pour vous connecter à votre appareil Asustor."
            CloudID.Text = "ID Cloud"
            ConnectWithCloudIDButton.Text = "Aller"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Introducir ID de nube"
            Header.Text = "Introduce tu ID de nube aquí,
                para conectarte a tu dispositivo Asustor."
            CloudID.Text = "ID de nube"
            ConnectWithCloudIDButton.Text = "Ir"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Inserisci ID Cloud"
            Header.Text = "Inserisci qui il tuo ID Cloud,
                per connetterti al tuo dispositivo Asustor."
            CloudID.Text = "ID Cloud"
            ConnectWithCloudIDButton.Text = "Vai"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Bulut Kimliğini Girin"
            Header.Text = "Asustor cihazınıza bağlanmak için
                Bulut Kimliğinizi buraya girin."
            CloudID.Text = "Bulut Kimliği"
            ConnectWithCloudIDButton.Text = "Git"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf die CloudID-Textbox klickt.
    'Dieser Sub überprüft, ob das Textfeld CloudID leer ist und führt die Funktion CloudID.Clear aus.
    Private Sub QuickConnectID_Click(sender As Object, e As EventArgs) Handles CloudID.Click
        'Wenn das Textfeld CloudID den Standardtext "Cloud ID" enthält, wird das Textfeld geleert.
        If CloudID.Text = "Cloud ID" Then
            'Das Textfeld CloudID wird geleert.
            CloudID.Clear()

        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den "Los"-Button klickt.
    'Dieser Sub führt die Funktion ConnectToCloudID aus.
    Private Sub ConnectWithDSMButton_Click(sender As Object, e As EventArgs) Handles ConnectWithCloudIDButton.Click
        'Die Funktion ConnectToCloudID wird ausgeführt.
        ConnectToCloudID()

    End Sub
    'Diese Funktion wird ausgeführt, wenn der Benutzer auf den "Los"-Button klickt oder Enter drückt.
    'Diese Funktion verbindet den Benutzer mit der CloudID.
    Public Function ConnectToCloudID()

        Try
            'Der Benutzer wird zu https://CloudID.ezconnect.to/?lang=de-DE navigiert.
            Form1.AddNewTab("https://" & CloudID.Text & ".ezconnect.to/?lang=de-DE")
            Me.Close()
            ConnectToNAS.Close()
            Launcher.Close()
        Catch ex As Exception
            'Wenn ein Fehler auftritt, wird dem Benutzer eine Fehlermeldung angezeigt.
            ErrorWhileConnectingWithSynologyQuickConnect.ShowDialog()

        End Try
    End Function
End Class