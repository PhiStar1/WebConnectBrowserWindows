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


        WelchenRouterBenutztDu.Show()
        ASUS.Show()
        FRITZBox.Show()
        Synology.Show()
        tplink.Show()
        Cisco.Show()
        DLink.Show()
        Google.Show()
        TelekomSpeedport.Show()
        Vodafone.Show()
        AppleAirport.Show()
        ManualConnection.Show()
        AI.Hide()
        ChatGPT.Hide()
        DALLE.Hide()
        ImageCreator.Hide()
        Soundraw.Hide()
        Musik.Hide()
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
        Geraete.Hide()
        Router.Hide()
        NAS.Hide()
        important.Hide()
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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles important.Click

    End Sub

    Private Sub Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        WelchenRouterBenutztDu.Hide()
        ASUS.Hide()
        FRITZBox.Hide()
        Synology.Hide()
        tplink.Hide()
        Cisco.Hide()
        DLink.Hide()
        Google.Hide()
        TelekomSpeedport.Hide()
        Vodafone.Hide()
        AppleAirport.Hide()
        ManualConnection.Hide()
        AI.Show()
        ChatGPT.Show()
        DALLE.Show()
        ImageCreator.Show()
        Soundraw.Show()
        Musik.Show()
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
        Geraete.Show()
        Router.Show()
        NAS.Show()
        important.Show()
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

    Private Sub Google_Click(sender As Object, e As EventArgs) Handles Google.Click
        InstallGoogleHome.ShowDialog()
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

    Private Sub AppleAirport_Click(sender As Object, e As EventArgs) Handles AppleAirport.Click
        InstallAppleAirport.ShowDialog()
    End Sub

    Private Sub ManualConnection_Click(sender As Object, e As EventArgs) Handles ManualConnection.Click
        EnterIPAdress.ShowDialog()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs)
        WelchenRouterBenutztDu.Hide()
        ASUS.Hide()
        FRITZBox.Hide()
        Synology.Hide()
        tplink.Hide()
        Cisco.Hide()
        DLink.Hide()
        Google.Hide()
        TelekomSpeedport.Hide()
        Vodafone.Hide()
        AppleAirport.Hide()
        ManualConnection.Hide()
        AI.Show()
        ChatGPT.Show()
        DALLE.Show()
        ImageCreator.Show()
        Soundraw.Show()
        Musik.Show()
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
        Geraete.Show()
        Router.Show()
        NAS.Show()
        important.Show()
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