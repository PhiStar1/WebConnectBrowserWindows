Imports System.Diagnostics.Metrics
Imports System.Threading.Channels
Imports System.Windows.Forms.LinkLabel
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Partial Class AppInfo
    'Diese Form wird angezeigt, wenn der Benutzer auf den "App-Info"-Button klickt.

    'Dieses Fenster zeigt Informationen über die App an.
    'Das bringt folgendes: Der Benutzer kann Softwareversionen, Entwicklerinformationen und Links zu den sozialen Medien des Entwicklers finden.

    Private _mainForm As Form1
    'Wenn der Benutzer Escape drückt, wird das Fenster geschlossen.
    Private Sub AppInfo(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine("Start of sub: AppInfo(sender As Object, e As KeyPressEventArgs)")
        Debug.WriteLine($"  If e.KeyChar =Convert.ToChar(Keys.Escape)")
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Debug.WriteLine("   e.KeyChar = " & e.KeyChar)
            Me.Close()
            Debug.WriteLine("       Me.Close()")
            Debug.WriteLine("   End If")
        End If
        Debug.WriteLine("End of sub: AppInfo(sender As Object, e As KeyPressEventArgs)")
    End Sub
    'Initialisierung der Form
    Public Sub New(mainForm As Form1)
        Debug.WriteLine("Start of sub: New(mainForm As Form1)")

        ' Dieser Aufruf ist für den Designer erforderlich.
        Debug.WriteLine("    InitializeComponent()")
        InitializeComponent()

        Debug.WriteLine("    _mainForm = mainForm")
        Debug.WriteLine("Current _mainForm: ")
        Debug.WriteLine(_mainForm)
        Debug.WriteLine("Current mainForm: ")
        Debug.WriteLine(mainForm)

        _mainForm = mainForm
        Debug.WriteLine("Updated _mainForm:")
        Debug.WriteLine(_mainForm)
        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.


        Debug.WriteLine("End of sub: New(mainForm As Form1)")
    End Sub

    'Wenn der Benutzer auf den Link klickt, wird der Twitch-Kanal von PhilConnected geöffnet.
    Private Sub TwitchLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TwitchLink.LinkClicked
        Debug.WriteLine("Start of sub: TwitchLink_LinkClicked")
        Try
            Debug.WriteLine("Try")
            Debug.WriteLine("    Form1.AddNewTab('https://www.twitch.tv/philconnected')")
            Form1.AddNewTab("https://www.twitch.tv/philconnected")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
            Debug.WriteLine("End Try")

        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: TwitchLink_LinkClicked")
    End Sub

    'Wenn der Benutzer auf den Link klickt, wird der YouTube-Kanal von PhilConnected geöffnet.
    Private Sub YouTubeLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles YouTubeLink.LinkClicked
        Debug.WriteLine("Start of sub: YouTubeLink_LinkClicked")
        Try
            Debug.WriteLine("Try")
            Debug.WriteLine("    Form1.AddNewTab('https://www.youtube.com/@philconnected')")
            Form1.AddNewTab("https://www.youtube.com/@philconnected")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
            Debug.WriteLine("End Try")
        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: YouTubeLink_LinkClicked")
    End Sub

    'Wenn der Benutzer auf den Link klickt, wird der TikTok-Kanal von PhilConnected geöffnet.
    Private Sub TikTokLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles TikTokLink.LinkClicked
        Debug.WriteLine("Start of sub: TikTokLink_LinkClicked")
        Try
            Debug.WriteLine("Try")
            Debug.WriteLine("    Form1.AddNewTab('https://www.tiktok.com/@philconnected')")
            Form1.AddNewTab("https://www.tiktok.com/@philconnected")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
            Debug.WriteLine("End Try")
        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: TikTokLink_LinkClicked")
    End Sub

    'Wenn der Benutzer auf den Link klickt, wird der Instagram-Kanal von PhilConnected.offical geöffnet.
    Private Sub InstaLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles InstagramLink.LinkClicked
        Debug.WriteLine("Start of sub: InstaLink_LinkClicked")
        Try
            Debug.WriteLine("Try")
            Debug.WriteLine("    Form1.AddNewTab('https://www.instagram.com/philconnected.official/')")
            Form1.AddNewTab("https://www.instagram.com/philconnected.official/")
            Debug.WriteLine("    Me.Close()")
            Me.Close()
            Debug.WriteLine("End Try")
        Catch ex As Exception
            Debug.WriteLine("    Exception occurred: " & ex.Message)
            Debug.WriteLine("    ErrorWhileLoadingThisLink.ShowDialog()")
            ErrorWhileLoadingThisLink.ShowDialog()
        End Try
        Debug.WriteLine("End of sub: InstaLink_LinkClicked")
    End Sub

    'Wenn der Benutzer auf OK klickt, wird das Fenster geschlossen
    Private Sub ExitAppInfo_Click(sender As Object, e As EventArgs) Handles ExitAppInfo.Click
        Debug.WriteLine("Start of sub: ExitAppInfo_Click")
        Debug.WriteLine("    Me.Close()")
        Me.Close()
        Debug.WriteLine("End of sub: ExitAppInfo_Click")
    End Sub

    'Debug-Ausgabe
    Public Sub New()
        InitializeComponent()
    End Sub
    Private Sub AppInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Version auslesen

        Debug.WriteLine("Start of sub: AppInfo_Load")
        Debug.WriteLine("If Form1.Language = 'de' Then")
        Debug.WriteLine("    Form1.Language = " & Form1.Language)
        If Form1.Language = "de" Then
            Debug.WriteLine("    Current Me.Text = " & Me.Text)
            Me.Text = "Über WebConnect"
            Debug.WriteLine("    Updated Me.Text = " & Me.Text)
            Debug.WriteLine("    Current VersionInfo.Text = " & VersionInfo.Text)
            VersionInfo.Text = "Allgemein:
Lizenz: Open-Source MIT
App: WebConnect
Programmierer: PhilConnected (Phileas Melchert)
Softwareversion: " & Form1.MainVersion & "

Komponentenversionen:
FrontEnd-Version: " & Form1.FrontEndVersion & "

Microsoft Edge Engine-Version: " & Form1.webViewVersion & "
Microsoft.Web.WebView2.Core-Version: " & Form1.MicrosoftWebWebView2CoreVersion & "
Microsoft.Web.WebView2.WinForms-Version: " & Form1.MicrosoftWebWebView2WinFormsVersion & "
Microsoft.Web.WebView2.Wpf-Version: " & Form1.MicrosoftWebWebView2WpfVersion & "
AutoLaunch Protocols Preregistration-Version: " & Form1.AutoLaunchProtocolsPreregistrationVersion & "
Microsoft CRLSet-Version: " & Form1.MicrosoftCRLSetVersion & "
DomainActions-Version: " & Form1.DomainActionsVersion & "
hyphens-data-Version: " & Form1.hyphensdataversion & "
OriginTrials-Version: " & Form1.originTrialsVersion & "
Microsoft PKI Metadata-Version: " & Form1.MicrosoftPKIMetadataVersion & "
Speech Recognition-Version: " & Form1.SpeechRecognitionVersion & "
Subresource Filter-Version: " & Form1.SubresourceFilterVersion & "
trustToken-Version: " & Form1.trustTokenVersion & "
Zxcvbn Data-Version: " & Form1.ZxcvbnVersion & "



Newtonsoft.Json-Version: " & Form1.NewtonsoftJsonVersion & "


Version der Wiederherstellungssoftware: " & Form1.RecoverySoftwareVersion & "
Version der Adminsoftware: " & Form1.AdminSoftwareVersion & "
Version des Bootloaders: " & Form1.BootloaderVersion
            Debug.WriteLine("Updated VersionInfo.Text: " & VersionInfo.Text)
            Debug.WriteLine("    Current TwitchLink.Text = " & TwitchLink.Text)
            TwitchLink.Text = "Twitch: philconnected"
            Debug.WriteLine("Updated TwitchLink.Text: " & TwitchLink.Text)
            Debug.WriteLine("    Current YouTubeLink.Text = " & YouTubeLink.Text)
            YouTubeLink.Text = "YouTube: PhilConnected"
            Debug.WriteLine("Updated YouTubeLink.Text: " & YouTubeLink.Text)
            Debug.WriteLine("    Current TikTokLink.Text = " & TikTokLink.Text)
            TikTokLink.Text = "TikTok: philconnected"
            Debug.WriteLine("Updated TikTokLink.Text: " & TikTokLink.Text)
            Debug.WriteLine("    Current InstagramLink.Text = " & InstagramLink.Text)
            InstagramLink.Text = "Instagram: philconnected.official"
            Debug.WriteLine("Updated InstagramLink.Text: " & InstagramLink.Text)
            Debug.WriteLine("    Current ExitAppInfo.Text = " & ExitAppInfo.Text)
            ExitAppInfo.Text = "OK"
            Debug.WriteLine("Updated ExitAppInfo.Text: " & ExitAppInfo.Text)
            Debug.WriteLine("End If")
        End If
        Debug.WriteLine("If Form1.Language = 'en' Then")
        Debug.WriteLine("    Form1.Language = " & Form1.Language)
        If Form1.Language = "en" Then
            Debug.WriteLine("    Current Me.Text = " & Me.Text)
            Me.Text = "About WebConnect"
            Debug.WriteLine("    Updated Me.Text = " & Me.Text)
            Debug.WriteLine("    Current VersionInfo.Text = " & VersionInfo.Text)
            VersionInfo.Text = "General:
License: Open source MIT
App: WebConnect
Developer: PhilConnected (Phileas Melchert)
Software version: " & Form1.MainVersion & "

Component versions:
FrontEnd version: " & Form1.FrontEndVersion & "

Microsoft Edge engine version: " & Form1.webViewVersion & "
Microsoft.Web.WebView2.Core version: " & Form1.MicrosoftWebWebView2CoreVersion & "
Microsoft.Web.WebView2.WinForms version: " & Form1.MicrosoftWebWebView2WinFormsVersion & "
Microsoft.Web.WebView2.Wpf version: " & Form1.MicrosoftWebWebView2WpfVersion & "
Microsoft.Web.WebView2.Core version: " & Form1.MicrosoftWebWebView2CoreVersion & "
Microsoft.Web.WebView2.WinForms version: " & Form1.MicrosoftWebWebView2WinFormsVersion & "
Microsoft.Web.WebView2.Wpf version: " & Form1.MicrosoftWebWebView2WpfVersion & "

AutoLaunch Protocols Preregistration version: " & Form1.AutoLaunchProtocolsPreregistrationVersion & "
Microsoft CRLSet version: " & Form1.MicrosoftCRLSetVersion & "
DomainActions version: " & Form1.DomainActionsVersion & "
hyphens-data version: " & Form1.hyphensdataversion & "
OriginTrials version: " & Form1.originTrialsVersion & "
Microsoft PKI Metadata version: " & Form1.MicrosoftPKIMetadataVersion & "
Speech Recognition version: " & Form1.SpeechRecognitionVersion & "
Subresource Filter version: " & Form1.SubresourceFilterVersion & "
trustToken version: " & Form1.trustTokenVersion & "
Zxcvbn Data version: " & Form1.ZxcvbnVersion & "

Newtonsoft.Json version: " & Form1.NewtonsoftJsonVersion & "

Recovery software version: " & Form1.RecoverySoftwareVersion & "
Admin software version: " & Form1.AdminSoftwareVersion & "
Bootloader version: " & Form1.BootloaderVersion &
""
            Debug.WriteLine("Updated VersionInfo.Text: " & VersionInfo.Text)
            Debug.WriteLine("    Current TwitchLink.Text = " & TwitchLink.Text)
            TwitchLink.Text = "Twitch: philconnected"
            Debug.WriteLine("Updated TwitchLink.Text: " & TwitchLink.Text)
            Debug.WriteLine("    Current YouTubeLink.Text = " & YouTubeLink.Text)
            YouTubeLink.Text = "YouTube: PhilConnected"
            Debug.WriteLine("Updated YouTubeLink.Text: " & YouTubeLink.Text)
            Debug.WriteLine("    Current TikTokLink.Text = " & TikTokLink.Text)
            TikTokLink.Text = "TikTok: philconnected"
            Debug.WriteLine("Updated TikTokLink.Text: " & TikTokLink.Text)
            Debug.WriteLine("    Current InstagramLink.Text = " & InstagramLink.Text)
            InstagramLink.Text = "Instagram: philconnected.official"
            Debug.WriteLine("Updated InstagramLink.Text: " & InstagramLink.Text)
            Debug.WriteLine("    Current ExitAppInfo.Text = " & ExitAppInfo.Text)
            ExitAppInfo.Text = "OK"
            Debug.WriteLine("Updated ExitAppInfo.Text: " & ExitAppInfo.Text)
            Debug.WriteLine("End If")
        End If
        Debug.WriteLine("If Form1.Language = 'fr' Then")
        Debug.WriteLine("    Form1.Language = " & Form1.Language)
        If Form1.Language = "fr" Then
            Debug.WriteLine("    Current Me.Text = " & Me.Text)
            Me.Text = "À propos de WebConnect"
            Debug.WriteLine("    Updated Me.Text = " & Me.Text)
            Debug.WriteLine("    Current VersionInfo.Text = " & VersionInfo.Text)
            VersionInfo.Text = "Généralités :
Licence : Open source MIT
Application : WebConnect
Développeur : PhilConnected (Phileas Melchert)
Version du logiciel : " & Form1.MainVersion & "

Versions des composants :
Version FrontEnd : " & Form1.FrontEndVersion & "

Version du moteur : " & Form1.webViewVersion & "
Version du Microsoft.Web.WebView2.Core: " & Form1.MicrosoftWebWebView2CoreVersion & "
Version du Microsoft.Web.WebView2.WinForms: " & Form1.MicrosoftWebWebView2WinFormsVersion & "
Version du Microsoft.Web.WebView2.Wpf: " & Form1.MicrosoftWebWebView2WpfVersion & "

Version de pré-enregistrement des protocoles AutoLaunch : " & Form1.AutoLaunchProtocolsPreregistrationVersion & "
Version Microsoft CRLSet : " & Form1.MicrosoftCRLSetVersion & "
Version DomainActions : " & Form1.DomainActionsVersion & "
Version des données d'hyphens : " & Form1.hyphensdataversion & "
Version d'OriginTrials : " & Form1.originTrialsVersion & "
Version des métadonnées Microsoft PKI : " & Form1.MicrosoftPKIMetadataVersion & "
Version de la reconnaissance vocale : " & Form1.SpeechRecognitionVersion & "
Version du filtre de sous-ressources : " & Form1.SubresourceFilterVersion & "
Version du jeton de confiance : " & Form1.trustTokenVersion & "
Version des données Zxcvbn : " & Form1.ZxcvbnVersion & "


Version de Newtonsoft.Json : " & Form1.NewtonsoftJsonVersion & "

Version du logiciel de récupération : " & Form1.RecoverySoftwareVersion & "
Version du logiciel d’administration : " & Form1.AdminSoftwareVersion & "
Version du chargeur de démarrage : " & Form1.BootloaderVersion

            Debug.WriteLine("Updated VersionInfo.Text: " & VersionInfo.Text)
            Debug.WriteLine("    Current TwitchLink.Text = " & TwitchLink.Text)
            TwitchLink.Text = "Twitch : philconnected"
            Debug.WriteLine("Updated TwitchLink.Text: " & TwitchLink.Text)
            Debug.WriteLine("    Current YouTubeLink.Text = " & YouTubeLink.Text)
            YouTubeLink.Text = "YouTube : PhilConnected"
            Debug.WriteLine("Updated YouTubeLink.Text: " & YouTubeLink.Text)
            Debug.WriteLine("    Current TikTokLink.Text = " & TikTokLink.Text)
            TikTokLink.Text = "TikTok : philconnected"
            Debug.WriteLine("Updated TikTokLink.Text: " & TikTokLink.Text)
            Debug.WriteLine("    Current InstagramLink.Text = " & InstagramLink.Text)
            InstagramLink.Text = "Instagram : philconnected.official"
            Debug.WriteLine("Updated InstagramLink.Text: " & InstagramLink.Text)
            Debug.WriteLine("    Current ExitAppInfo.Text = " & ExitAppInfo.Text)
            ExitAppInfo.Text = "OK"
            Debug.WriteLine("Updated ExitAppInfo.Text: " & ExitAppInfo.Text)
            Debug.WriteLine("End If")
        End If
        Debug.WriteLine("If Form1.Language = 'es' Then")
        Debug.WriteLine("    Form1.Language = " & Form1.Language)
        If Form1.Language = "es" Then
            Debug.WriteLine("    Current Me.Text = " & Me.Text)
            Me.Text = "Acerca de WebConnect"
            Debug.WriteLine("    Updated Me.Text = " & Me.Text)
            Debug.WriteLine("    Current VersionInfo.Text = " & VersionInfo.Text)
            VersionInfo.Text = "General:
Licencia: Código abierto MIT
Aplicación: WebConnect
Desarrollador: PhilConnected (Phileas Melchert)
Versión del software: " & Form1.MainVersion & "

Versiones de los componentes:
Versión del front-end: " & Form1.FrontEndVersion & "

Versión del motor: " & Form1.webViewVersion & "
Versión de Microsoft.Web.WebView2.Core: " & Form1.MicrosoftWebWebView2CoreVersion & "
Versión de Microsoft.Web.WebView2.WinForms: " & Form1.MicrosoftWebWebView2WinFormsVersion & "
Versión de Microsoft.Web.WebView2.Wpf: " & Form1.MicrosoftWebWebView2WpfVersion & "

Versión de prerregistro de protocolos de inicio automático: " & Form1.AutoLaunchProtocolsPreregistrationVersion & "
Versión de Microsoft CRLSet: " & Form1.MicrosoftCRLSetVersion & "
Versión de DomainActions: " & Form1.DomainActionsVersion & "
Versión de hyphens-data: " & Form1.hyphensdataversion & "
Versión de OriginTrials: " & Form1.originTrialsVersion & "
Versión de metadatos de Microsoft PKI: " & Form1.MicrosoftPKIMetadataVersion & "
Versión de reconocimiento de voz: " & Form1.SpeechRecognitionVersion & "
Versión del filtro de subrecursos: " & Form1.SubresourceFilterVersion & "
Versión de trustToken: " & Form1.trustTokenVersion & "
Versión de datos de Zxcvbn: " & Form1.ZxcvbnVersion & "


Versión de Newtonsoft.Json: " & Form1.NewtonsoftJsonVersion & "

Versión del software de recuperación: " & Form1.RecoverySoftwareVersion & "
Versión del software de administración: " & Form1.AdminSoftwareVersion & "
Versión del cargador de arranque: " & Form1.BootloaderVersion
            Debug.WriteLine("Updated VersionInfo.Text: " & VersionInfo.Text)
            Debug.WriteLine("    Current TikTokLink.Text = " & TikTokLink.Text)
            TikTokLink.Text = "TikTok: philconnected"
            Debug.WriteLine("Updated TikTokLink.Text: " & TikTokLink.Text)
            Debug.WriteLine("    Current InstagramLink.Text = " & InstagramLink.Text)
            InstagramLink.Text = "Instagram: philconnected.official"
            Debug.WriteLine("Updated InstagramLink.Text: " & InstagramLink.Text)
            Debug.WriteLine("    Current YouTubeLink.Text = " & YouTubeLink.Text)
            TwitchLink.Text = "Twitch: philconnected"
            YouTubeLink.Text = "YouTube: PhilConnected"
            Debug.WriteLine("Updated YouTubeLink.Text: " & YouTubeLink.Text)
            Debug.WriteLine("    Current ExitAppInfo.Text = " & ExitAppInfo.Text)
            ExitAppInfo.Text = "OK"
            Debug.WriteLine("Updated ExitAppInfo.Text: " & ExitAppInfo.Text)
            Debug.WriteLine("End If")
        End If
        Debug.WriteLine("If Form1.Language = 'it' Then")
        Debug.WriteLine("    Form1.Language = " & Form1.Language)
        If Form1.Language = "it" Then
            Debug.WriteLine("    Current Me.Text = " & Me.Text)
            Me.Text = "Informazioni su WebConnect"
            Debug.WriteLine("    Updated Me.Text = " & Me.Text)
            Debug.WriteLine("    Current VersionInfo.Text = " & VersionInfo.Text)
            VersionInfo.Text = "Generale:
Licenza: Open source MIT
App: WebConnect
Sviluppatore: PhilConnected (Phileas Melchert)
Versione software: " & Form1.MainVersion & "

Versioni componenti:
Versione FrontEnd: " & Form1.FrontEndVersion & "

Versione motore: " & Form1.webViewVersion & "
Versione Microsoft.Web.WebView2.Core:  " & Form1.MicrosoftWebWebView2CoreVersion & "
Versione Microsoft.Web.WebView2.WinForms: " & Form1.MicrosoftWebWebView2WinFormsVersion & "
Versione Microsoft.Web.WebView2.Wpf: " & Form1.MicrosoftWebWebView2WpfVersion & "

Versione di preregistrazione dei protocolli di avvio automatico: " & Form1.AutoLaunchProtocolsPreregistrationVersion & "
Versione Microsoft CRLSet: " & Form1.MicrosoftCRLSetVersion & "
Versione DomainActions: " & Form1.DomainActionsVersion & "
Versione di hyphens-data: " & Form1.hyphensdataversion & "
Versione di OriginTrials: " & Form1.originTrialsVersion & "
Versione di Microsoft PKI Metadata: " & Form1.MicrosoftPKIMetadataVersion & "
Versione di riconoscimento vocale: " & Form1.SpeechRecognitionVersion & "
Versione di Subresource Filter: " & Form1.SubresourceFilterVersion & "
Versione di trustToken: " & Form1.trustTokenVersion & "
Versione di Zxcvbn Data: " & Form1.ZxcvbnVersion & "


Versione di Newtonsoft.Json: " & Form1.NewtonsoftJsonVersion & "

Versione del software di ripristino: " & Form1.RecoverySoftwareVersion & "
Versione del software di amministrazione: " & Form1.AdminSoftwareVersion & "
Versione del bootloader: " & Form1.BootloaderVersion
            Debug.WriteLine("Updated VersionInfo.Text: " & VersionInfo.Text)
            Debug.WriteLine("    Current TikTokLink.Text = " & TikTokLink.Text)
            TikTokLink.Text = "TikTok: philconnected"
            Debug.WriteLine("Updated TikTokLink.Text: " & TikTokLink.Text)
            Debug.WriteLine("    Current InstagramLink.Text = " & InstagramLink.Text)
            InstagramLink.Text = "Instagram: philconnected.official"
            Debug.WriteLine("Updated InstagramLink.Text: " & InstagramLink.Text)
            Debug.WriteLine("    Current YouTubeLink.Text = " & YouTubeLink.Text)
            YouTubeLink.Text = "YouTube: PhilConnected"
            TwitchLink.Text = "Twitch: philconnected"
            Debug.WriteLine("Updated YouTubeLink.Text: " & YouTubeLink.Text)
            Debug.WriteLine("    Current ExitAppInfo.Text = " & ExitAppInfo.Text)
            ExitAppInfo.Text = "OK"
            Debug.WriteLine("Updated ExitAppInfo.Text: " & ExitAppInfo.Text)
            Debug.WriteLine("End If")
        End If
        Debug.WriteLine("If Form1.Language = 'tr' Then")
        Debug.WriteLine("    Form1.Language = " & Form1.Language)
        If Form1.Language = "tr" Then
            Debug.WriteLine("    Current Me.Text = " & Me.Text)
            Me.Text = "WebConnect Hakkında"
            Debug.WriteLine("    Updated Me.Text = " & Me.Text)
            Debug.WriteLine("    Current VersionInfo.Text = " & VersionInfo.Text)
            VersionInfo.Text = "Genel:
Lisans: Açık kaynak MIT
Uygulama: WebConnect
Geliştirici: PhilConnected (Phileas Melchert)
Yazılım sürümü: " & Form1.MainVersion & "

Bileşen sürümleri:
FrontEnd sürümü: " & Form1.FrontEndVersion & "

Motor sürümü: " & Form1.webViewVersion & "
Microsoft.Web.WebView2.Core sürümü: " & Form1.MicrosoftWebWebView2CoreVersion & "
Microsoft.Web.WebView2.WinForms sürümü: " & Form1.MicrosoftWebWebView2WinFormsVersion & "
Microsoft.Web.WebView2.Wpf sürümü: " & Form1.MicrosoftWebWebView2WpfVersion & "

AutoLaunch Protocols Ön Kayıt sürümü: " & Form1.AutoLaunchProtocolsPreregistrationVersion & "
Microsoft CRLSet sürümü: " & Form1.MicrosoftCRLSetVersion & "
DomainActions sürümü: " & Form1.DomainActionsVersion & "
hyphens-data sürümü: " & Form1.hyphensdataversion & "
OriginTrials sürümü: " & Form1.originTrialsVersion & "
Microsoft PKI Meta Veri sürümü: " & Form1.MicrosoftPKIMetadataVersion & "
Konuşma Tanıma sürümü: " & Form1.SpeechRecognitionVersion & "
Alt Kaynak Filtresi sürümü: " & Form1.SubresourceFilterVersion & "
trustToken sürümü: " & Form1.trustTokenVersion & "
Zxcvbn Veri sürümü: " & Form1.ZxcvbnVersion & "


Newtonsoft.Json sürümü: " & Form1.NewtonsoftJsonVersion & "

Kurtarma yazılımı sürümü: " & Form1.RecoverySoftwareVersion & "
Yönetici yazılımı sürümü: " & Form1.AdminSoftwareVersion & "
Önyükleyici sürümü: " & Form1.BootloaderVersion
            Debug.WriteLine("Updated VersionInfo.Text: " & VersionInfo.Text)
            Debug.WriteLine("    Current TikTokLink.Text = " & TwitchLink.Text)
            TikTokLink.Text = "TikTok: philconnected"
            Debug.WriteLine("Updated TikTokLink.Text: " & TikTokLink.Text)
            Debug.WriteLine("    Current InstagramLink.Text = " & InstagramLink.Text)
            InstagramLink.Text = "Instagram: philconnected.official"
            Debug.WriteLine("Updated InstagramLink.Text: " & InstagramLink.Text)
            Debug.WriteLine("    Current YouTubeLink.Text = " & YouTubeLink.Text)
            YouTubeLink.Text = "YouTube: PhilConnected"
            TwitchLink.Text = "Twitch: philconnected"
            Debug.WriteLine("Updated YouTubeLink.Text: " & YouTubeLink.Text)
            Debug.WriteLine("    Current ExitAppInfo.Text = " & ExitAppInfo.Text)
            ExitAppInfo.Text = "Tamam"
            Debug.WriteLine("Updated ExitAppInfo.Text: " & ExitAppInfo.Text)
            Debug.WriteLine("End If")
        End If

        Debug.WriteLine("End of sub: AppInfo_Load")
    End Sub

    'Debug-Ausgabe
    Private Sub Description_Click(sender As Object, e As EventArgs) Handles Description.Click
        Debug.WriteLine("Start of sub: Description_Click")
        Debug.WriteLine("End of sub: Description_Click")
    End Sub

End Class