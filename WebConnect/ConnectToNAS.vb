'Import von Bibliotheken
Imports System.IO
Imports Microsoft.Win32

Public Class ConnectToNAS
    'Diese Form wird angezeigt, wenn der Benutzer auf Shortcuts/Geräte/NAS klickt.
    'Dieses Fenster zeigt dem Benutzer verschiedene Optionen, um sich mit einem NAS zu verbinden.
    'Das bringt folgendes: Der Benutzer kann sich mit einem NAS verbinden, indem er auf einen der Buttons klickt 
    'Dieser Sub wird ausgeführt, wenn der Benutzer Escape drückt.
    'Dieser Sub schließt das Fenster.
    Private Sub ConnectToNAS(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine("Start of private sub: ConnectToNAS(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress")
        'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
        Debug.WriteLine("  If e.KeyChar = Convert.ToChar(Keys.Escape) Then")
        Debug.WriteLine("e.KeyChar = " & e.KeyChar & ", Convert.ToChar(Keys.Escape) = " & Convert.ToChar(Keys.Escape))

        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            'Das Fenster wird geschlossen.
            Debug.WriteLine("    Me.Close()")
            Me.Close()

        End If
        Debug.WriteLine("End of private sub: ConnectToNAS(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress")
    End Sub
    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Synology-Button klickt.
    'Dieser Sub öffnet das Fenster "EnterQuickConnectID".
    Private Sub Synology_Click(sender As Object, e As EventArgs) Handles Synology.Click
        Debug.WriteLine("Start of private sub: Synology_Click(sender As Object, e As EventArgs) Handles Synology.Click")
        'Das Fenster "EnterQuickConnectID" wird geöffnet.
        Debug.WriteLine("EnterQuickConnectID.ShowDialog()")
        EnterQuickConnectID.ShowDialog()
        Debug.WriteLine("End of private sub: Synology_Click(sender As Object, e As EventArgs) Handles Synology.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub ConnectToNAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Mit NAS verbinden"
            Header.Text = "Mit NAS verbinden"
            Synology.Text = "Synology"
            QNAP.Text = "QNAP"
            Buffalo.Text = "Buffalo"
            WesternDigital.Text = "Western Digital"
            Asustor.Text = "Asustor"
            FRITZNAS.Text = "FRITZ!NAS"
            ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
            Cancel.Text = "Abbrechen"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Connect to NAS"
            Header.Text = "Connect to NAS"
            Synology.Text = "Synology"
            QNAP.Text = "QNAP"
            Buffalo.Text = "Buffalo"
            WesternDigital.Text = "Western Digital"
            Asustor.Text = "Asustor"
            FRITZNAS.Text = "FRITZ!NAS"
            ManualConnection.Text = "Enter IP address instead"
            Cancel.Text = "Cancel"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Connecter au NAS"
            Header.Text = "Connecter au NAS"
            Synology.Text = "Synology"
            QNAP.Text = "QNAP"
            Buffalo.Text = "Buffalo"
            WesternDigital.Text = "Western Digital"
            Asustor.Text = "Asustor"
            FRITZNAS.Text = "FRITZ!NAS"
            ManualConnection.Text = "Entrer l'adresse IP à la place"
            Cancel.Text = "Annuler"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Conectar a NAS"
            Header.Text = "Conectar a NAS"
            Synology.Text = "Synology"
            QNAP.Text = "QNAP"
            Buffalo.Text = "Buffalo"
            WesternDigital.Text = "Western Digital"
            Asustor.Text = "Asustor"
            FRITZNAS.Text = "FRITZ!NAS"
            ManualConnection.Text = "Introducir dirección IP en su lugar"
            Cancel.Text = "Cancelar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Collegati a NAS"
            Header.Text = "Collegati a NAS"
            Synology.Text = "Synology"
            QNAP.Text = "QNAP"
            Buffalo.Text = "Buffalo"
            WesternDigital.Text = "Western Digital"
            Asustor.Text = "Asustor"
            FRITZNAS.Text = "FRITZ!NAS"
            ManualConnection.Text = "Inserire invece l'indirizzo IP"
            Cancel.Text = "Annulla"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "NAS'a Bağlan"
            Header.Text = "NAS'a Bağlan"
            Synology.Text = "Synology"
            QNAP.Text = "QNAP"
            Buffalo.Text = "Buffalo"
            WesternDigital.Text = "Western Digital"
            Asustor.Text = "Asustor"
            FRITZNAS.Text = "FRITZ!NAS"
            ManualConnection.Text = "Bunun yerine IP adresini girin"
            Cancel.Text = "İptal"
        End If
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den "Abbrechen"-Button klickt.
    'Dieser Sub schließt das Fenster.
    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Debug.WriteLine("Start Of Private Sub: Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click")
        'Das Fenster wird geschlossen.
        Debug.WriteLine("    Me.Close()")
        Me.Close()
        Debug.WriteLine("End of private sub: Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den QNAP-Button klickt.
    'Dieser Sub navigiert den Benutzer zu myqnapcloud.com.
    Private Sub QNAP_Click(sender As Object, e As EventArgs) Handles QNAP.Click
        Debug.WriteLine("Start of private sub: QNAP_Click(sender As Object, e As EventArgs) Handles QNAP.Click")
        'Der Benutzer wird zu myqnapcloud.com navigiert.
        Debug.WriteLine("Form1.AddNewTab('https://www.myqnapcloud.com/?lang=de')")
        Form1.AddNewTab("https://www.myqnapcloud.com/?lang=de")
        Debug.WriteLine("    Close()")
        Close()
        Debug.WriteLine("    Launcher.Close()")
        Launcher.Close()
        Debug.WriteLine("End of private sub: QNAP_Click(sender As Object, e As EventArgs) Handles QNAP.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Buffalo-Button klickt.
    'Dieser Sub navigiert den Benutzer zu buffalonas.com.
    Private Sub Buffalo_Click(sender As Object, e As EventArgs) Handles Buffalo.Click
        Debug.WriteLine("Start of private sub: Buffalo_Click(sender As Object, e As EventArgs) Handles Buffalo.Click")
        'Der Benutzer wird zu buffalonas.com navigiert.
        Debug.WriteLine("Form1.AddNewTab('https://buffalonas.com/index.php')")
        Form1.AddNewTab("https://buffalonas.com/index.php")
        Debug.WriteLine("    Close()")
        Close()
        Debug.WriteLine("    Launcher.Close()")
        Launcher.Close()
        Debug.WriteLine("End of private sub: Buffalo_Click(sender As Object, e As EventArgs) Handles Buffalo.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den WesternDigital-Button klickt.
    'Dieser Sub navigiert den Benutzer zu mycloud.com.
    Private Sub WesternDigital_Click(sender As Object, e As EventArgs) Handles WesternDigital.Click
        Debug.WriteLine("Start of private sub: WesternDigital_Click(sender As Object, e As EventArgs) Handles WesternDigital.Click")
        'Der Benutzer wird zu mycloud.com navigiert.
        Debug.WriteLine("Form1.AddNewTab('https://www.mycloud.com/#/')")
        Form1.AddNewTab("https://www.mycloud.com/#/")
        Debug.WriteLine("    Close()")
        Close()
        Debug.WriteLine("    Launcher.Close()")
        Launcher.Close()
        Debug.WriteLine("End of private sub: WesternDigital_Click(sender As Object, e As EventArgs) Handles WesternDigital.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Asustor-Button klickt.
    'Dieser Sub öffnet das Fenster "EnterCloudID".
    Private Sub Asustor_Click(sender As Object, e As EventArgs) Handles Asustor.Click
        Debug.WriteLine("Start of private sub: Asustor_Click(sender As Object, e As EventArgs) Handles Asustor.Click")
        'Das Fenster "EnterCloudID" wird geöffnet.
        Debug.WriteLine("EnterCloudID.ShowDialog()")
        EnterCloudID.ShowDialog()
        'https://hallo.ezconnect.to/?lang=de-DE
        Debug.WriteLine("End of private sub: Asustor_Click(sender As Object, e As EventArgs) Handles Asustor.Click")
    End Sub
    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den FRITZ!NAS-Button klickt.
    'Dieser Sub öffnet das Fenster "EnterMyFRITZ_Adress".

    Private Sub FRITZNAS_Click(sender As Object, e As EventArgs) Handles FRITZNAS.Click
        Debug.WriteLine("Start of private sub: FRITZNAS_Click(sender As Object, e As EventArgs) Handles FRITZNAS.Click")
        'Das Fenster "EnterMyFRITZ_Adress" wird geöffnet.
        Debug.WriteLine("EnterMyFRITZ_Adress.ShowDialog()")
        EnterMyFRITZ_Adress.ShowDialog()
        Debug.WriteLine("End of private sub: FRITZNAS_Click(sender As Object, e As EventArgs) Handles FRITZNAS.Click")
    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den XigmaNAS-Button klickt.
    'Dieser Sub wird nicht verwendet.
    Private Sub XigmaNAS_Click(sender As Object, e As EventArgs)

    End Sub

    'Dieser Sub wird ausgeführt, wenn der Benutzer auf den Stattdessen IP-Adresse eingeben-Button klickt.
    'Dieser Sub öffnet das Fenster "EnterIPAdress".
    Private Sub ManualConnection_Click(sender As Object, e As EventArgs) Handles ManualConnection.Click
        Debug.WriteLine("Start of private sub: ManualConnection_Click(sender As Object, e As EventArgs) Handles ManualConnection.Click")
        'Das Fenster "EnterIPAdress" wird geöffnet.
        Debug.WriteLine("EnterIPAdress.ShowDialog()")
        EnterIPAdress.ShowDialog()
        Debug.WriteLine("End of private sub: ManualConnection_Click(sender As Object, e As EventArgs) Handles ManualConnection.Click")
    End Sub
End Class