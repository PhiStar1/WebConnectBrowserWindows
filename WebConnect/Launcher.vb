Imports System.Diagnostics.Metrics
Imports System.Threading.Channels
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Launcher

    Private Sub Launcher(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
    End Sub
    Private moveTimer As Timer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ChatGPT.Click
        Form1.AddNewTab("https://chat.openai.com/")
        Close()
    End Sub

    Private Sub DALLE_Click(sender As Object, e As EventArgs) Handles DALLE.Click
        Form1.AddNewTab("https://labs.openai.com/")
        Close()

    End Sub

    Private Sub Copilot_Click(sender As Object, e As EventArgs) Handles Copilot.Click
        Form1.AddNewTab("https://copilot.microsoft.com/")
        Close()
    End Sub

    Private Sub ImageCreator_Click(sender As Object, e As EventArgs) Handles ImageCreator.Click
        Form1.AddNewTab("https://www.bing.com/images/create")
        Close()
    End Sub

    Private Sub Soundraw_Click(sender As Object, e As EventArgs) Handles Soundraw.Click
        Form1.AddNewTab("https://soundraw.io/create_music")
        Close()
    End Sub

    Private Sub Spotify_Click(sender As Object, e As EventArgs) Handles Spotify.Click
        Form1.AddNewTab("https://open.spotify.com/")
        Close()
    End Sub

    Private Sub AppleMusic_Click(sender As Object, e As EventArgs) Handles AppleMusic.Click
        Form1.AddNewTab("https://music.apple.com/")
        Close()
    End Sub

    Private Sub AmazonMusic_Click(sender As Object, e As EventArgs) Handles AmazonMusic.Click
        Form1.AddNewTab("https://music.amazon.de/")
        Close()
    End Sub

    Private Sub SoundCloud_Click(sender As Object, e As EventArgs) Handles SoundCloud.Click
        Form1.AddNewTab("https://soundcloud.com/discover")
        Close()
    End Sub

    Private Sub YTMusic_Click(sender As Object, e As EventArgs) Handles YTMusic.Click
        Form1.AddNewTab("https://music.youtube.com/")
        Close()
    End Sub

    Private Sub YouTube_Click(sender As Object, e As EventArgs) Handles YouTube.Click
        Form1.AddNewTab("https://www.youtube.com/")
        Close()
    End Sub

    Private Sub Netflix_Click(sender As Object, e As EventArgs) Handles Netflix.Click
        Form1.AddNewTab("https://www.netflix.com/de/")
        Close()
    End Sub

    Private Sub AmazonPrimeVideo_Click(sender As Object, e As EventArgs) Handles AmazonPrimeVideo.Click
        Form1.AddNewTab("https://www.amazon.de/Amazon-Video/b/?&node=3010075031&ref=dvm_MLP_ROWEU_DE_1")
        Close()
    End Sub

    Private Sub Sky_Click(sender As Object, e As EventArgs) Handles Sky.Click
        Form1.AddNewTab("https://www.sky.de/filme-serien")
        Close()
    End Sub

    Private Sub Disney_Click(sender As Object, e As EventArgs) Handles Disney.Click
        Form1.AddNewTab("https://www.disneyplus.com/de-de")
        Close()
    End Sub



    Private Sub Router_Click_1(sender As Object, e As EventArgs) Handles Router.Click
        moveTimer = New Timer()
        moveTimer.Interval = 1
        moveTimer.Start()
        Dim stopTimer As New Timer()
        stopTimer.Interval = 500


        RouterQuestion.Show()
        ASUS.Show()
        FRITZBox.Show()
        Synology.Show()
        tplink.Show()
        Cisco.Show()
        DLink.Show()
        TelekomSpeedport.Show()
        Vodafone.Show()
        ManualConnection.Show()
        AI.Hide()
        ChatGPT.Hide()
        DALLE.Hide()
        ImageCreator.Hide()
        Soundraw.Hide()
        Music.Hide()
        Spotify.Hide()
        AmazonMusic.Hide()
        SoundCloud.Hide()
        YTMusic.Hide()
        Videos.Hide()
        YouTube.Hide()
        Netflix.Hide()
        AmazonPrimeVideo.Hide()
        Sky.Hide()
        Disney.Hide()
        Cloud.Hide()
        iCloud.Hide()
        OneDrive.Hide()
        Dropbox.Hide()
        GoogleDrive.Hide()
        Devices.Hide()
        Router.Hide()
        NAS.Hide()
        Important.Hide()
        Copilot.Hide()
        AppleMusic.Hide()
        Discord.Hide()
        Teams.Hide()
        Snapchat.Hide()
        WhatsApp.Hide()
        Chats.Hide()
        Fitness.Hide()
        GarminConnect.Hide()
        PolarFlow.Hide()
        Strava.Hide()




    End Sub

    Private Sub NAS_Click(sender As Object, e As EventArgs) Handles NAS.Click
        ConnectToNAS.ShowDialog()
    End Sub

    Private Sub iCloud_Click(sender As Object, e As EventArgs) Handles iCloud.Click
        Form1.AddNewTab("https://www.icloud.com/")
        Close()
    End Sub

    Private Sub OneDrive_Click(sender As Object, e As EventArgs) Handles OneDrive.Click
        Form1.AddNewTab("https://onedrive.live.com/")
        Close()
    End Sub

    Private Sub Dropbox_Click(sender As Object, e As EventArgs) Handles Dropbox.Click
        Form1.AddNewTab("https://www.dropbox.com/de")
        Close()
    End Sub

    Private Sub GoogleDrive_Click(sender As Object, e As EventArgs) Handles GoogleDrive.Click
        Form1.AddNewTab("https://drive.google.com/drive/home")
        Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Important.Click

    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Verknüpfungen"
            RouterQuestion.Text = "Welchen Router
  benutzt du?"
            AI.Text = "AI"
            ChatGPT.Text = "ChatGPT"
            DALLE.Text = "DALL·E"
            ImageCreator.Text = "Bing Bildgenerator"
            Copilot.Text = "Copilot"
            Soundraw.Text = "Soundraw"
            Music.Text = "Musik"
            Spotify.Text = "Spotify"
            AmazonMusic.Text = "Amazon Music"
            AppleMusic.Text = "Apple Music"
            SoundCloud.Text = "SoundCloud"
            YTMusic.Text = "YouTube Music"
            Videos.Text = "Videos"
            YouTube.Text = "YouTube"
            Netflix.Text = "Netflix"
            AmazonPrimeVideo.Text = "Amazon Prime Video"
            Sky.Text = "Sky"
            Disney.Text = "Disney+"
            Cloud.Text = "Cloud"
            iCloud.Text = "iCloud"
            OneDrive.Text = "OneDrive"
            Dropbox.Text = "Dropbox"
            GoogleDrive.Text = "Google Drive"
            Devices.Text = "Geräte"
            Router.Text = "Router"
            NAS.Text = "NAS"
            Chats.Text = "Chats"
            Discord.Text = "Discord"
            Teams.Text = "Teams"
            Snapchat.Text = "Snapchat"
            WhatsApp.Text = "WhatsApp"
            Fitness.Text = "Fitness"
            GarminConnect.Text = "Garmin Connect"
            PolarFlow.Text = "Polar Flow"
            Strava.Text = "Strava"
            Important.Text = "Es kann sein, dass manche Dienste auf dieser Seite kostenpflichtig oder über einen einmaligen Preis oder Abomodell bezahlt werden sollen 
oder man kann damit einkaufen.
Unbezahlte Werbung"
            ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Shortcuts"
            RouterQuestion.Text = "Which router
  do you use?"
            AI.Text = "AI"
            ChatGPT.Text = "ChatGPT"
            DALLE.Text = "DALL·E"
            ImageCreator.Text = "Bing Image Creator"
            Copilot.Text = "Copilot"
            Soundraw.Text = "Soundraw"
            Music.Text = "Music"
            Spotify.Text = "Spotify"
            AmazonMusic.Text = "Amazon Music"
            AppleMusic.Text = "Apple Music"
            SoundCloud.Text = "SoundCloud"
            YTMusic.Text = "YouTube Music"
            Videos.Text = "Videos"
            YouTube.Text = "YouTube"
            Netflix.Text = "Netflix"
            AmazonPrimeVideo.Text = "Amazon Prime Video"
            Sky.Text = "Sky"
            Disney.Text = "Disney+"
            Cloud.Text = "Cloud"
            iCloud.Text = "iCloud"
            OneDrive.Text = "OneDrive"
            Dropbox.Text = "Dropbox"
            GoogleDrive.Text = "Google Drive"
            Devices.Text = "Devices"
            Router.Text = "Router"
            NAS.Text = "NAS"
            Chats.Text = "Chats"
            Discord.Text = "Discord"
            Teams.Text = "Teams"
            Snapchat.Text = "Snapchat"
            WhatsApp.Text = "WhatsApp"
            Fitness.Text = "Fitness"
            GarminConnect.Text = "Garmin Connect"
            PolarFlow.Text = "Polar Flow"
            Strava.Text = "Strava"
            Important.Text = "Some services on this page may be chargeable or require a one-time payment or subscription model
or you can shop with it.
Unpaid advertising"
            ManualConnection.Text = "Enter IP address instead"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Raccourcis"
            RouterQuestion.Text = "Quel routeur
  utilisez-vous?"
            AI.Text = "AI"
            ChatGPT.Text = "ChatGPT"
            DALLE.Text = "DALL·E"
            ImageCreator.Text = "Créateur d'images Bing"
            Copilot.Text = "Copilot"
            Soundraw.Text = "Soundraw"
            Music.Text = "Musique"
            Spotify.Text = "Spotify"
            AmazonMusic.Text = "Amazon Music"
            AppleMusic.Text = "Apple Music"
            SoundCloud.Text = "SoundCloud"
            YTMusic.Text = "YouTube Music"
            Videos.Text = "Vidéos"
            YouTube.Text = "YouTube"
            Netflix.Text = "Netflix"
            AmazonPrimeVideo.Text = "Amazon Prime Video"
            Sky.Text = "Sky"
            Disney.Text = "Disney+"
            Cloud.Text = "Nuage"
            iCloud.Text = "iCloud"
            OneDrive.Text = "OneDrive"
            Dropbox.Text = "Dropbox"
            GoogleDrive.Text = "Google Drive"
            Devices.Text = "Appareils"
            Router.Text = "Routeur"
            NAS.Text = "NAS"
            Chats.Text = "Discussions"
            Discord.Text = "Discord"
            Teams.Text = "Teams"
            Snapchat.Text = "Snapchat"
            WhatsApp.Text = "WhatsApp"
            Fitness.Text = "Fitness"
            GarminConnect.Text = "Garmin Connect"
            PolarFlow.Text = "Polar Flow"
            Strava.Text = "Strava"
            Important.Text = "Certains services de cette page peuvent être payants ou nécessiter un paiement unique ou un modèle d'abonnement
ou vous pouvez faire vos courses avec.
Publicité non rémunérée"
            ManualConnection.Text = "Entrez l'adresse IP à la place"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Atajos"
            RouterQuestion.Text = "¿Qué enrutador
  usas?"
            AI.Text = "AI"
            ChatGPT.Text = "ChatGPT"
            DALLE.Text = "DALL·E"
            ImageCreator.Text = "Creador de imágenes de Bing"
            Copilot.Text = "Copilot"
            Soundraw.Text = "Soundraw"
            Music.Text = "Música"
            Spotify.Text = "Spotify"
            AmazonMusic.Text = "Amazon Music"
            AppleMusic.Text = "Apple Music"
            SoundCloud.Text = "SoundCloud"
            YTMusic.Text = "YouTube Music"
            Videos.Text = "Videos"
            YouTube.Text = "YouTube"
            Netflix.Text = "Netflix"
            AmazonPrimeVideo.Text = "Amazon Prime Video"
            Sky.Text = "Sky"
            Disney.Text = "Disney+"
            Cloud.Text = "Cloud"
            iCloud.Text = "iCloud"
            OneDrive.Text = "OneDrive"
            Dropbox.Text = "Dropbox"
            GoogleDrive.Text = "Google Drive"
            Devices.Text = "Dispositivos"
            Router.Text = "Enrutador"
            NAS.Text = "NAS"
            Chats.Text = "Chats"
            Discord.Text = "Discord"
            Teams.Text = "Teams"
            Snapchat.Text = "Snapchat"
            WhatsApp.Text = "WhatsApp"
            Fitness.Text = "Aptitud física"
            GarminConnect.Text = "Garmin Connect"
            PolarFlow.Text = "Polar Flow"
            Strava.Text = "Strava"
            Important.Text = "Es posible que algunos servicios de esta página sean de pago o requieran un pago único o un modelo de suscripción
o puedes comprar con él.
Publicidad no pagada"
            ManualConnection.Text = "Ingrese la dirección IP en su lugar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Collegamenti"
            RouterQuestion.Text = "Quale router
  usi?"
            AI.Text = "AI"
            ChatGPT.Text = "ChatGPT"
            DALLE.Text = "DALL·E"
            ImageCreator.Text = "Creatore di immagini Bing"
            Copilot.Text = "Copilot"
            Soundraw.Text = "Soundraw"
            Music.Text = "Musica"
            Spotify.Text = "Spotify"
            AmazonMusic.Text = "Amazon Music"
            AppleMusic.Text = "Apple Music"
            SoundCloud.Text = "SoundCloud"
            YTMusic.Text = "YouTube Music"
            Videos.Text = "Video"
            YouTube.Text = "YouTube"
            Netflix.Text = "Netflix"
            AmazonPrimeVideo.Text = "Amazon Prime Video"
            Sky.Text = "Sky"
            Disney.Text = "Disney+"
            Cloud.Text = "Cloud"
            iCloud.Text = "iCloud"
            OneDrive.Text = "OneDrive"
            Dropbox.Text = "Dropbox"
            GoogleDrive.Text = "Google Drive"
            Devices.Text = "Dispositivi"
            Router.Text = "Router"
            NAS.Text = "NAS"
            Chats.Text = "Chat"
            Discord.Text = "Discord"
            Teams.Text = "Teams"
            Snapchat.Text = "Snapchat"
            WhatsApp.Text = "WhatsApp"
            Fitness.Text = "Fitness"
            GarminConnect.Text = "Garmin Connect"
            PolarFlow.Text = "Polar Flow"
            Strava.Text = "Strava"
            Important.Text = "Alcuni servizi di questa pagina potrebbero essere a pagamento o richiedere un pagamento una tantum o un modello di abbonamento
o puoi fare acquisti con esso.
Pubblicità non retribuita"
            ManualConnection.Text = "Inserisci l'indirizzo IP invece"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Kısayollar"
            RouterQuestion.Text = "Hangi yönlendiriciyi
  kullanıyorsun?"
            AI.Text = "AI"
            ChatGPT.Text = "ChatGPT"
            DALLE.Text = "DALL·E"
            ImageCreator.Text = "Bing Görüntü Oluşturucu"
            Copilot.Text = "Copilot"
            Soundraw.Text = "Soundraw"
            Music.Text = "Müzik"
            Spotify.Text = "Spotify"
            AmazonMusic.Text = "Amazon Music"
            AppleMusic.Text = "Apple Music"
            SoundCloud.Text = "SoundCloud"
            YTMusic.Text = "YouTube Music"
            Videos.Text = "Videolar"
            YouTube.Text = "YouTube"
            Netflix.Text = "Netflix"
            AmazonPrimeVideo.Text = "Amazon Prime Video"
            Sky.Text = "Sky"
            Disney.Text = "Disney+"
            Cloud.Text = "Cloud"
            iCloud.Text = "iCloud"
            OneDrive.Text = "OneDrive"
            Dropbox.Text = "Dropbox"
            GoogleDrive.Text = "Google Drive"
            Devices.Text = "Cihazlar"
            Router.Text = "Yönlendirici"
            NAS.Text = "NAS"
            Chats.Text = "Sohbetler"
            Discord.Text = "Discord"
            Teams.Text = "Teams"
            Snapchat.Text = "Snapchat"
            WhatsApp.Text = "WhatsApp"
            Fitness.Text = "Fitness"
            GarminConnect.Text = "Garmin Connect"
            PolarFlow.Text = "Polar Flow"
            Strava.Text = "Strava"
            Important.Text = "Bu sayfadaki bazı hizmetlerin ücretli olabileceğini veya tek seferlik bir ödeme veya abonelik modeli gerektirebileceğini
veya bununla alışveriş yapabileceğinizi unutmayın.
Ücretli reklam"
            ManualConnection.Text = "Bunun yerine IP adresini girin"
        End If
        RouterQuestion.Hide()
        ASUS.Hide()
        FRITZBox.Hide()
        Synology.Hide()
        tplink.Hide()
        Cisco.Hide()
        DLink.Hide()
        TelekomSpeedport.Hide()
        Vodafone.Hide()
        ManualConnection.Hide()
        AI.Show()
        ChatGPT.Show()
        DALLE.Show()
        ImageCreator.Show()
        Soundraw.Show()
        Music.Show()
        Spotify.Show()
        AmazonMusic.Show()
        SoundCloud.Show()
        YTMusic.Show()
        Videos.Show()
        YouTube.Show()
        Netflix.Show()
        AmazonPrimeVideo.Show()
        Sky.Show()
        Disney.Show()
        Cloud.Show()
        iCloud.Show()
        OneDrive.Show()
        Dropbox.Show()
        GoogleDrive.Show()
        Devices.Show()
        Router.Show()
        NAS.Show()
        Important.Show()
        Copilot.Show()
        AppleMusic.Show()
        Discord.Show()
        Teams.Show()
        Snapchat.Show()
        WhatsApp.Show()
        Fitness.Show()
        GarminConnect.Show()
        PolarFlow.Show()
        Strava.Show()




    End Sub

    Private Sub ASUS_Click(sender As Object, e As EventArgs) Handles ASUS.Click
        Form1.AddNewTab("http://router.asus.com/")
        Close()
    End Sub

    Private Sub FRITZBox_Click(sender As Object, e As EventArgs) Handles FRITZBox.Click
        Form1.AddNewTab("http://fritz.box")
        Close()

    End Sub

    Private Sub Synology_Click(sender As Object, e As EventArgs) Handles Synology.Click
        Form1.AddNewTab("http://router.synology.com")
        Close()

    End Sub

    Private Sub tplink_Click(sender As Object, e As EventArgs) Handles tplink.Click
        Form1.AddNewTab("http://tplinkwifi.net")
        Close()

    End Sub

    Private Sub Cisco_Click(sender As Object, e As EventArgs) Handles Cisco.Click
        Form1.AddNewTab("http://192.168.1.1")
        Close()

    End Sub

    Private Sub DLink_Click(sender As Object, e As EventArgs) Handles DLink.Click
        Form1.AddNewTab("http://dlinkrouter")
        Close()

    End Sub



    Private Sub TelekomSpeedport_Click(sender As Object, e As EventArgs) Handles TelekomSpeedport.Click
        Form1.AddNewTab("http://speedport.ip")
        Close()
    End Sub

    Private Sub Vodafone_Click(sender As Object, e As EventArgs) Handles Vodafone.Click
        Form1.AddNewTab("http://vodafone.connect")
        Close()

    End Sub



    Private Sub ManualConnection_Click(sender As Object, e As EventArgs) Handles ManualConnection.Click
        EnterIPAdress.ShowDialog()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        RouterQuestion.Hide()
        ASUS.Hide()
        FRITZBox.Hide()
        Synology.Hide()
        tplink.Hide()
        Cisco.Hide()
        DLink.Hide()
        TelekomSpeedport.Hide()
        Vodafone.Hide()
        ManualConnection.Hide()
        AI.Show()
        ChatGPT.Show()
        DALLE.Show()
        ImageCreator.Show()
        Soundraw.Show()
        Music.Show()
        Spotify.Show()
        AmazonMusic.Show()
        SoundCloud.Show()
        YTMusic.Show()
        Videos.Show()
        YouTube.Show()
        Netflix.Show()
        AmazonPrimeVideo.Show()
        Sky.Show()
        Disney.Show()
        Cloud.Show()
        iCloud.Show()
        OneDrive.Show()
        Dropbox.Show()
        GoogleDrive.Show()
        Devices.Show()
        Router.Show()
        NAS.Show()
        Important.Show()
        Copilot.Show()
        AppleMusic.Show()
        Chats.Show()
        Discord.Show()
        Snapchat.Show()
        WhatsApp.Show()
        Teams.Show()
        Chats.Show()
        Fitness.Show()
        GarminConnect.Show()
        PolarFlow.Show()
        Strava.Show()



    End Sub

    Private Sub Discord_Click(sender As Object, e As EventArgs) Handles Discord.Click
        Form1.AddNewTab("https://discord.com/app")
        Close()
    End Sub

    Private Sub Teams_Click(sender As Object, e As EventArgs) Handles Teams.Click
        Form1.AddNewTab("https://teams.microsoft.com/")
        Close()
    End Sub

    Private Sub Snapchat_Click(sender As Object, e As EventArgs) Handles Snapchat.Click
        Form1.AddNewTab("https://web.snapchat.com/")
        Close()
    End Sub

    Private Sub WhatsApp_Click(sender As Object, e As EventArgs) Handles WhatsApp.Click
        Form1.AddNewTab("https://web.whatsapp.com/")
        Close()
    End Sub

    Private Sub GarminConnect_Click(sender As Object, e As EventArgs) Handles GarminConnect.Click
        Form1.AddNewTab("https://connect.garmin.com/")
        Close()
    End Sub

    Private Sub PolarFlow_Click(sender As Object, e As EventArgs) Handles PolarFlow.Click
        Form1.AddNewTab("https://flow.polar.com/")
        Close()
    End Sub

    Private Sub Strava_Click(sender As Object, e As EventArgs) Handles Strava.Click
        Form1.AddNewTab("https://www.strava.com/")
        Close()
    End Sub
End Class