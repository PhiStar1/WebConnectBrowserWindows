'Import von Bibliotheken
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
    Private Sub AppInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
Softwareversion: 2025.05.27

Komponentenversionen:
FrontEnd-Version: 4.1

Engine-Version: Microsoft Edge WebView2 1.0.3240.44 (Edge 136)
Microsoft.Web.WebView2.Core-Version: 1.0.3240.44
Microsoft.Web.WebView2.WinForms-Version: 1.0.3240.44
Microsoft.Web.WebView2.Wpf-Version: 1.0.3240.44

AutoLaunch Protocols Preregistration-Version: 1.0.0.9
Microsoft CRLSet-Version: 6498.2024.12.2
DomainActions-Version: 3.0.0.14
hyphens-data-Version: 120.0.6050.0
OriginTrials-Version: 0.0.1.7
Microsoft PKI Metadata-Version: 22.0.0.1
Speech Recognition-Version: 1.15.0.1
Subresource Filter-Version: 10.34.0.80
trustToken-Version: 2025.5.15.1
Zxcvbn Data-Version: 3.1.0.0

Humanizer-Version: 2.14.1.48190
Microsoft.Bcl.AsyncInterfaces-Version: 9.0.24.52809
Microsoft.CodeAnalysis.CSharp-Version: 4.1400.25.26210
Microsoft.CodeAnalysis.CSharp.Workspaces-Version: 4.1400.25.26210
Microsoft.CodeAnalysis-Version: 4.1400.25.26210
Microsoft.CodeAnalysis.VisualBasic-Version: 4.1400.25.26210
Microsoft.CodeAnalysis.VisualBasic.Workspaces-Version: 4.1400.25.26210
Microsoft.CodeAnalysis.Workspaces-Version: 4.1400.25.26210
Microsoft.Win32-Version: 2.0.1
Newtonsoft.Json-Version: 13.0.3.27908
System.Collections.Immutable-Version: 9.0.24.52809
System.Composition.AttributedModel-Version: 9.0.24.52809
System.Composition.Convention-Version: 9.0.24.52809
System.Composition.Hosting-Version: 9.0.24.52809
System.Composition.Runtime-Version: 9.0.24.52809
System.Composition.TypedParts-Version: 9.0.24.52809
System.IO.Pipelines-Version: 9.0.24.52809
System.Reflection.Metadata-Version: 9.0.24.52809
System.Threading.Channels-Version: 9.0.525.21509


Version der Wiederherstellungssoftware: 1.0
Version der Adminsoftware: 1.0
Version des Bootloaders: 2.2
"
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
Software version: 2025.05.27

Component versions:
FrontEnd version: 4.1

Engine version: Microsoft Edge WebView2 1.0.3240.44 (Edge 136)
Microsoft.Web.WebView2.Core version: 1.0.3240.44
Microsoft.Web.WebView2.WinForms version: 1.0.3240.44
Microsoft.Web.WebView2.Wpf version: 1.0.3240.44

AutoLaunch Protocols Preregistration version: 1.0.0.9
Microsoft CRLSet version: 6498.2024.12.2
DomainActions version: 3.0.0.14
hyphens-data version: 120.0.6050.0
OriginTrials version: 0.0.1.7
Microsoft PKI Metadata version: 22.0.0.1
Speech Recognition version: 1.15.0.1
Subresource Filter version: 10.34.0.80
trustToken version: 2025.5.15.1
Zxcvbn Data version: 3.1.0.0

Humanizer version: 2.14.1.48190
Microsoft.Bcl.AsyncInterfaces version: 9.0.24.52809
Microsoft.CodeAnalysis.CSharp version: 4.1400.25.26210
Microsoft.CodeAnalysis.CSharp.Workspaces version: 4.1400.25.26210
Microsoft.CodeAnalysis version: 4.1400.25.26210
Microsoft.CodeAnalysis.VisualBasic version: 4.1400.25.26210
Microsoft.CodeAnalysis.VisualBasic.Workspaces version: 4.1400.25.26210
Microsoft.CodeAnalysis.Workspaces version: 4.1400.25.26210
Microsoft.Win32 version: 2.0.1
Newtonsoft.Json version: 13.0.3.27908
System.Collections.Immutable version: 9.0.24.52809
System.Composition.AttributedModel version: 9.0.24.52809
System.Composition.Convention version: 9.0.24.52809
System.Composition.Hosting version: 9.0.24.52809
System.Composition.Runtime version: 9.0.24.52809
System.Composition.TypedParts version: 9.0.24.52809
System.IO.Pipelines version: 9.0.24.52809
System.Reflection.Metadata version: 9.0.24.52809
System.Threading.Channels version: 9.0.525.21509


Recovery software version: 1.0
Admin software version: 1.0
Bootloader version: 2.2
"
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
Version du logiciel : 27/05/2025

Versions des composants :
Version FrontEnd : 4.1

Version du moteur : Microsoft Edge WebView2 1.0.3240.44 (Edge 136)
Version Microsoft.Web.WebView2.Core : 1.0.3240.44
Version Microsoft.Web.WebView2.WinForms : 1.0.3240.44
Version Microsoft.Web.WebView2.Wpf : 1.0.3240.44

Version de pré-enregistrement des protocoles AutoLaunch : 1.0.0.9
Version Microsoft CRLSet : 6498.2024.12.2
Version DomainActions : 3.0.0.14
Version des données d'hyphens : 120.0.6050.0
Version d'OriginTrials : 0.0.1.7
Version des métadonnées Microsoft PKI : 22.0.0.1
Version de la reconnaissance vocale : 1.15.0.1
Version du filtre de sous-ressources : 10.34.0.80
Version du jeton de confiance : 2025.5.15.1
Version des données Zxcvbn : 3.1.0.0

Version de l'humaniseur : 2.14.1.48190
Version de Microsoft.Bcl.AsyncInterfaces : 9.0.24.52809
Version de Microsoft.CodeAnalysis.CSharp : 4.1400.25.26210
Version de Microsoft.CodeAnalysis.CSharp.Workspaces : 4.1400.25.26210
Version de Microsoft.CodeAnalysis : 4.1400.25.26210
Version de Microsoft.CodeAnalysis.VisualBasic : 4.1400.25.26210
Version de Microsoft.CodeAnalysis.VisualBasic.Workspaces : 4.1400.25.26210
Version de Microsoft.CodeAnalysis.Workspaces : 4.1400.25.26210
Version de Microsoft.Win32 : 2.0.1
Version de Newtonsoft.Json : 13.0.3.27908
Version de System.Collections.Immutable : 9.0.24.52809
Version de System.Composition.AttributedModel : 9.0.24.52809
Version de System.Composition.Convention : 9.0.24.52809
Version de System.Composition.Hosting : 9.0.24.52809
Version de System.Composition.Runtime : 9.0.24.52809
Version de System.Composition.TypedParts : 9.0.24.52809
Version de System.IO.Pipelines : 9.0.24.52809
Version de System.Reflection.Metadata : 9.0.24.52809
Version de System.Threading.Channels : 9.0.525.21509

Version du logiciel de récupération : 1.0
Version du logiciel d’administration : 1.0
Version du chargeur de démarrage : 2.2
"

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
Versión del software: 2025.05.27

Versiones de los componentes:
Versión del front-end: 4.1

Versión del motor: Microsoft Edge WebView2 1.0.3240.44 (Edge 136)
Versión de Microsoft.Web.WebView2.Core: 1.0.3240.44
Versión de Microsoft.Web.WebView2.WinForms: 1.0.3240.44
Versión de Microsoft.Web.WebView2.Wpf: 1.0.3240.44

Versión de prerregistro de protocolos de inicio automático: 1.0.0.9
Versión de Microsoft CRLSet: 6498.2024.12.2
Versión de DomainActions: 3.0.0.14
Versión de hyphens-data: 120.0.6050.0
Versión de OriginTrials: 0.0.1.7
Versión de metadatos de Microsoft PKI: 22.0.0.1
Versión de reconocimiento de voz: 1.15.0.1
Versión del filtro de subrecursos: 10.34.0.80
Versión de trustToken: 2025.5.15.1
Versión de datos de Zxcvbn: 3.1.0.0

Versión de Humanizer: 2.14.1.48190
Versión de Microsoft.Bcl.AsyncInterfaces: 9.0.24.52809
Versión de Microsoft.CodeAnalysis.CSharp: 4.1400.25.26210
Versión de Microsoft.CodeAnalysis.CSharp.Workspaces: 4.1400.25.26210
Versión de Microsoft.CodeAnalysis: 4.1400.25.26210
Versión de Microsoft.CodeAnalysis.VisualBasic: 4.1400.25.26210
Versión de Microsoft.CodeAnalysis.VisualBasic.Workspaces: 4.1400.25.26210
Versión de Microsoft.CodeAnalysis.Workspaces: 4.1400.25.26210
Versión de Microsoft.Win32: 2.0.1
Versión de Newtonsoft.Json: 13.0.3.27908
Versión de System.Collections.Immutable: 9.0.24.52809
Versión de System.Composition.AttributedModel: 9.0.24.52809
Versión de System.Composition.Convention: 9.0.24.52809
Versión de System.Composition.Hosting: 9.0.24.52809
Versión de System.Composition.Runtime: 9.0.24.52809
Versión de System.Composition.TypedParts: 9.0.24.52809
Versión de System.IO.Pipelines: 9.0.24.52809
Versión de System.Reflection.Metadata: 9.0.24.52809
Versión de System.Threading.Channels: 9.0.525.21509

Versión del software de recuperación: 1.0
Versión del software de administración: 1.0
Versión del cargador de arranque: 2.2
"
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
Versione software: 27/05/2025

Versioni componenti:
Versione FrontEnd: 4.1

Versione motore: Microsoft Edge WebView2 1.0.3240.44 (Edge 136)
Versione Microsoft.Web.WebView2.Core: 1.0.3240.44
Versione Microsoft.Web.WebView2.WinForms: 1.0.3240.44
Versione Microsoft.Web.WebView2.Wpf: 1.0.3240.44

Versione di preregistrazione dei protocolli di avvio automatico: 1.0.0.9
Versione Microsoft CRLSet: 6498.2024.12.2
Versione DomainActions: 3.0.0.14
Versione di hyphens-data: 120.0.6050.0
Versione di OriginTrials: 0.0.1.7
Versione di Microsoft PKI Metadata: 22.0.0.1
Versione di riconoscimento vocale: 1.15.0.1
Versione di Subresource Filter: 10.34.0.80
Versione di trustToken: 2025.5.15.1
Versione di Zxcvbn Data: 3.1.0.0

Versione di Humanizer: 2.14.1.48190
Versione di Microsoft.Bcl.AsyncInterfaces: 9.0.24.52809
Versione di Microsoft.CodeAnalysis.CSharp: 4.1400.25.26210
Versione di Microsoft.CodeAnalysis.CSharp.Workspaces: 4.1400.25.26210
Versione di Microsoft.CodeAnalysis: 4.1400.25.26210
Versione di Microsoft.CodeAnalysis.VisualBasic: 4.1400.25.26210
Versione di Microsoft.CodeAnalysis.VisualBasic.Workspaces: 4.1400.25.26210
Versione di Microsoft.CodeAnalysis.Workspaces: 4.1400.25.26210
Versione di Microsoft.Win32: 2.0.1
Versione di Newtonsoft.Json: 13.0.3.27908
Versione di System.Collections.Immutable: 9.0.24.52809
Versione di System.Composition.AttributedModel: 9.0.24.52809
Versione di System.Composition.Convention: 9.0.24.52809
Versione di System.Composition.Hosting: 9.0.24.52809
Versione di System.Composition.Runtime: 9.0.24.52809
Versione di System.Composition.TypedParts: 9.0.24.52809
Versione di System.IO.Pipelines: 9.0.24.52809
Versione di System.Reflection.Metadata: 9.0.24.52809
Versione di System.Threading.Channels: 9.0.525.21509

Versione del software di ripristino: 1.0
Versione del software di amministrazione: 1.0
Versione del bootloader: 2.2
"
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
Yazılım sürümü: 2025.05.27

Bileşen sürümleri:
FrontEnd sürümü: 4.1

Motor sürümü: Microsoft Edge WebView2 1.0.3240.44 (Edge 136)
Microsoft.Web.WebView2.Core sürümü: 1.0.3240.44
Microsoft.Web.WebView2.WinForms sürümü: 1.0.3240.44
Microsoft.Web.WebView2.Wpf sürümü: 1.0.3240.44

AutoLaunch Protocols Ön Kayıt sürümü: 1.0.0.9
Microsoft CRLSet sürümü: 6498.2024.12.2
DomainActions sürümü: 3.0.0.14
hyphens-data sürümü: 120.0.6050.0
OriginTrials sürümü: 0.0.1.7
Microsoft PKI Meta Veri sürümü: 22.0.0.1
Konuşma Tanıma sürümü: 1.15.0.1
Alt Kaynak Filtresi sürümü: 10.34.0.80
trustToken sürümü: 2025.5.15.1
Zxcvbn Veri sürümü: 3.1.0.0

Humanizer sürümü: 2.14.1.48190
Microsoft.Bcl.AsyncInterfaces sürümü: 9.0.24.52809
Microsoft.CodeAnalysis.CSharp sürümü: 4.1400.25.26210
Microsoft.CodeAnalysis.CSharp.Workspaces sürümü: 4.1400.25.26210
Microsoft.CodeAnalysis sürümü: 4.1400.25.26210
Microsoft.CodeAnalysis.VisualBasic sürümü: 4.1400.25.26210
Microsoft.CodeAnalysis.VisualBasic.Workspaces sürümü: 4.1400.25.26210
Microsoft.CodeAnalysis.Workspaces sürümü: 4.1400.25.26210
Microsoft.Win32 sürümü: 2.0.1
Newtonsoft.Json sürümü: 13.0.3.27908
System.Collections.Immutable sürümü: 9.0.24.52809
System.Composition.AttributedModel sürümü: 9.0.24.52809
System.Composition.Convention sürümü: 9.0.24.52809
System.Composition.Hosting sürümü: 9.0.24.52809
System.Composition.Runtime sürümü: 9.0.24.52809
System.Composition.TypedParts sürümü: 9.0.24.52809
System.IO.Pipelines sürümü: 9.0.24.52809
System.Reflection.Metadata sürümü: 9.0.24.52809
System.Threading.Channels sürümü: 9.0.525.21509

Kurtarma yazılımı sürümü: 1.0
Yönetici yazılımı sürümü: 1.0
Önyükleyici sürümü: 2.2"
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