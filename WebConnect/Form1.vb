Imports System
Imports System.Linq
Imports System.Windows.Forms
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports Microsoft.Win32
Imports System.Runtime
Imports System.Threading.Channels
Imports System.Security.Principal
Imports System.IO.Pipes
Imports System.Threading
Public Class Form1
    Public Version As String

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr

    End Function
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean

    End Function

    Public OpenLinkOnBoot As Boolean = False
    Public SW_HIDE As Integer = 0
    Public SW_SHOW As Integer = 5
    Public Fullscreen As Boolean = False
    Public taskbarHandle As IntPtr
    Public isFullscreen As Boolean = False
    'Private WithEvents KeyPressTimer As New Timer()
    'Private mouseTimer As New Timer()
    Public elementsVisible As Boolean = True
    Public originalWebViewBounds As Rectangle
    Public originalFormBounds As Rectangle
    Public originalWindowState As FormWindowState
    Public originalTabControlBounds As Rectangle
    Public TabControlLocationX As Integer = 0
    Public TabControlLocation As Point
    Public TabControlHeight As Integer = 882
    Public DXTabControlWidth As Integer = 1721
    Public pipeThread As Thread
    Public WebView21 As WebView2
    Public Errorcode As String
    ' Public macroEditor As MacroEditor




    Private Sub KeyPress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If TextBox1.Focused Then
            If e.KeyCode = Keys.Enter Then
                Try
                    If TextBox1.Text = "cmd://reboot" Then
                        Application.Restart()
                    End If
                    If TextBox1.Text = "cmd://shutdown" Then
                        Application.Exit()
                    End If
                    If TextBox1.Text = "cmd://exit" Then
                        Application.Exit()
                    End If
                    If TextBox1.Text = "cmd://kill" Then
                        Application.Exit()
                    End If
                    If TextBox1.Text = "cmd://about" Then
                        Dim AppInfo As New AppInfo(Me)
                        AppInfo.ShowDialog()
                    End If
                    If TextBox1.Text = "cmd://setup" Then
                        Settings.ShowDialog()
                    End If
                    If TextBox1.Text IsNot "cmd://reboot" Then
                        SearchURL()
                    End If
                    If TextBox1.Text IsNot "cmd://shutdown" Then
                        SearchURL()
                    End If
                    If TextBox1.Text IsNot "cmd://exit" Then
                        SearchURL()
                    End If
                    If TextBox1.Text IsNot "cmd://kill" Then
                        SearchURL()
                    End If
                    If TextBox1.Text IsNot "cmd://about" Then
                        SearchURL()
                    End If
                    If TextBox1.Text IsNot "cmd://setup" Then
                        SearchURL()
                    End If
                    WebView21.CoreWebView2.Navigate(TextBox1.Text)
                    e.SuppressKeyPress = True
                Catch ex As Exception

                End Try

            End If


        End If


    End Sub

    Private Sub NavigatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigatiToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        booting.Show()

        booting.bootprogress.Value = 0

        Version = "2024.11.18"
        'Versionen
        'Frontend = 1.1
        'Backend = 1.0.1823.32
        'Recovery = 1.0
        'Debug = 1.0
        'Bei neuer Softwareversion von oben nach unten der reihe nach in die Variable Version Z. 50 manuell einfügen
        Text = "Loading main window... Please wait"
        booting.bootprogress.Value = 1
        Try

            'MainWindowWindowName
            Name = My.Settings.MainWindowWindowName
            booting.bootprogress.Value = 2
            'Backend initialisieren
            WebView21 = New WebView2()
            WebView21.Location = New Point(0, 0)
            WebView21.Size = New Size(1707, 785)
            Dim args As String() = Environment.GetCommandLineArgs()

            ' Wenn eine URL als Argument übergeben wird, öffne sie in einem neuen Tab
            If args.Length > 1 Then
                OpenLinkOnBoot = True
                Dim url As String = args(1)
                If Not String.IsNullOrEmpty(url) Then
                    AddNewTabFromAnotherApplication(url)
                End If
            End If
            'MainWindowWindowAcceptButton
            If My.Settings.MainWindowWindowAcceptButton = "Nothing" Then
                AcceptButton = Nothing
            End If
            If My.Settings.MainWindowWindowAcceptButton = "Back" Then
                AcceptButton = Back
            End If
            If My.Settings.MainWindowWindowAcceptButton = "Cancel" Then
                AcceptButton = Cancel
            End If
            If My.Settings.MainWindowWindowAcceptButton = "Forward" Then
                AcceptButton = Forward
            End If
            If My.Settings.MainWindowWindowAcceptButton = "Home" Then
                AcceptButton = Home
            End If
            If My.Settings.MainWindowWindowAcceptButton = "Refresh" Then
                AcceptButton = Refresh
            End If
            If My.Settings.MainWindowWindowAcceptButton = "Search" Then
                AcceptButton = Search
            End If
            If My.Settings.MainWindowWindowAcceptButton = "Shortcuts" Then
                AcceptButton = Shortcuts
            End If
            booting.bootprogress.Value = 3
            'MainWindowWindowAccessibleDescription
            AccessibleDescription = My.Settings.MainWindowWindowAccessibleDescription
            booting.bootprogress.Value = 4
            'MainWindowWindowAccessibleRole
            If My.Settings.MainWindowWindowAccessibleRole = "Default" Then
                AccessibleRole = AccessibleRole.Default
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "None" Then
                AccessibleRole = AccessibleRole.None
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "TitleBar" Then
                AccessibleRole = AccessibleRole.TitleBar
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "MenuBar" Then
                AccessibleRole = AccessibleRole.MenuBar
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ScrollBar" Then
                AccessibleRole = AccessibleRole.ScrollBar
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Grip" Then
                AccessibleRole = AccessibleRole.Grip
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Sound" Then
                AccessibleRole = AccessibleRole.Sound
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Cursor" Then
                AccessibleRole = AccessibleRole.Cursor
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Caret" Then
                AccessibleRole = AccessibleRole.Caret
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Alert" Then
                AccessibleRole = AccessibleRole.Alert
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Window" Then
                AccessibleRole = AccessibleRole.Window
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Client" Then
                AccessibleRole = AccessibleRole.Client
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "MenuPopup" Then
                AccessibleRole = AccessibleRole.MenuPopup
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "MenuItem" Then
                AccessibleRole = AccessibleRole.MenuItem
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ToolTip" Then
                AccessibleRole = AccessibleRole.ToolTip
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Application" Then
                AccessibleRole = AccessibleRole.Application
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Document" Then
                AccessibleRole = AccessibleRole.Document
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Pane" Then
                AccessibleRole = AccessibleRole.Pane
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Chart" Then
                AccessibleRole = AccessibleRole.Chart
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Dialog" Then
                AccessibleRole = AccessibleRole.Dialog
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Border" Then
                AccessibleRole = AccessibleRole.Border
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Grouping" Then
                AccessibleRole = AccessibleRole.Grouping
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Seperator" Then
                AccessibleRole = AccessibleRole.Separator
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ToolBar" Then
                AccessibleRole = AccessibleRole.ToolBar
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "StatusBar" Then
                AccessibleRole = AccessibleRole.StatusBar
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Table" Then
                AccessibleRole = AccessibleRole.Table
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ColumnHeader" Then
                AccessibleRole = AccessibleRole.ColumnHeader
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "RowHeader" Then
                AccessibleRole = AccessibleRole.RowHeader
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Column" Then
                AccessibleRole = AccessibleRole.Column
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Row" Then
                AccessibleRole = AccessibleRole.Row
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Cell" Then
                AccessibleRole = AccessibleRole.Cell
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Link" Then
                AccessibleRole = AccessibleRole.Link
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "HelpBalloon" Then
                AccessibleRole = AccessibleRole.HelpBalloon
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Character" Then
                AccessibleRole = AccessibleRole.Character
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "List" Then
                AccessibleRole = AccessibleRole.List
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ListItem" Then
                AccessibleRole = AccessibleRole.ListItem
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Outline" Then
                AccessibleRole = AccessibleRole.Outline
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "OutlineItem" Then
                AccessibleRole = AccessibleRole.OutlineItem
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "PageTab" Then
                AccessibleRole = AccessibleRole.PageTab
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "PropertyPage" Then
                AccessibleRole = AccessibleRole.PropertyPage
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Indicator" Then
                AccessibleRole = AccessibleRole.Indicator
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Graphic" Then
                AccessibleRole = AccessibleRole.Graphic
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "StaticText" Then
                AccessibleRole = AccessibleRole.StaticText
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Text" Then
                AccessibleRole = AccessibleRole.Text
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "PushButton" Then
                AccessibleRole = AccessibleRole.PushButton
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "CheckButton" Then
                AccessibleRole = AccessibleRole.CheckButton
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "RadioButton" Then
                AccessibleRole = AccessibleRole.RadioButton
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ComboBox" Then
                AccessibleRole = AccessibleRole.ComboBox
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "DropList" Then
                AccessibleRole = AccessibleRole.DropList
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ProgressBar" Then
                AccessibleRole = AccessibleRole.ProgressBar
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Dial" Then
                AccessibleRole = AccessibleRole.Dial
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "HotkeyField" Then
                AccessibleRole = AccessibleRole.HotkeyField
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Slider" Then
                AccessibleRole = AccessibleRole.Slider
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "SpinButton" Then
                AccessibleRole = AccessibleRole.SpinButton
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Diagram" Then
                AccessibleRole = AccessibleRole.Diagram
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Animation" Then
                AccessibleRole = AccessibleRole.Animation
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Equation" Then
                AccessibleRole = AccessibleRole.Equation
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ButtonDropDown" Then
                AccessibleRole = AccessibleRole.ButtonDropDown
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ButtonMenu" Then
                AccessibleRole = AccessibleRole.ButtonMenu
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "ButtonDropDownGrid" Then
                AccessibleRole = AccessibleRole.ButtonDropDownGrid
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "WhiteSpace" Then
                AccessibleRole = AccessibleRole.WhiteSpace
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "PageTabList" Then
                AccessibleRole = AccessibleRole.PageTabList
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "Clock" Then
                AccessibleRole = AccessibleRole.Clock
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "SplitButton" Then
                AccessibleRole = AccessibleRole.SplitButton
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "IpAdress" Then
                AccessibleRole = AccessibleRole.IpAddress
            End If
            If My.Settings.MainWindowWindowAccessibleRole = "OutlineButton" Then
                AccessibleRole = AccessibleRole.OutlineButton
            End If
            'MainWindowWindowAllowDrop
            booting.bootprogress.Value = 5
            If My.Settings.MainWindowWindowAllowDrop = True Then
                AllowDrop = True
            End If
            If My.Settings.MainWindowWindowAllowDrop = False Then
                AllowDrop = False
            End If
            'MainWindowWindowAutoScaleMode
            booting.bootprogress.Value = 6
            If My.Settings.MainWindowWindowAutoScaleMode = "None" Then
                AutoScaleMode = AutoScaleMode.None
            End If
            If My.Settings.MainWindowWindowAutoScaleMode = "Font" Then
                AutoScaleMode = AutoScaleMode.Font
            End If
            If My.Settings.MainWindowWindowAutoScaleMode = "Dpi" Then
                AutoScaleMode = AutoScaleMode.Dpi
            End If
            If My.Settings.MainWindowWindowAutoScaleMode = "Inherit" Then
                AutoScaleMode = AutoScaleMode.Inherit
            End If
            'MainWindowWindowAutoScroll
            If My.Settings.MainWindowWindowAutoScrollMarginWidth = True Then
                AutoScroll = True
            End If
            If My.Settings.MainWindowWindowAutoScrollMarginWidth = False Then
                AutoScroll = False
            End If


        Catch ex As Exception

        End Try
        Try
            booting.bootprogress.Value = 6
            If My.Settings.Sprache = "Deutsch" Then
                booting.bootprogress.Value = 9
                Text = "Lade Hauptfenster... Warte kurz"
                booting.bootprogress.Value = 12
                Dim toolTip1 As New ToolTip
                booting.bootprogress.Value = 15
                toolTip1.SetToolTip(Back, "Navigiert auf der Internetseite zurück
            bzw. navigiert zur vorherigen Internetseite")
                booting.bootprogress.Value = 18
                toolTip1.SetToolTip(Forward, "Navigiert auf der Internetseite vor
            bzw. navigiert zur nächsten geöffneten Internetseite")
                booting.bootprogress.Value = 21
                toolTip1.SetToolTip(Search, "Sucht nach der URL, was in die Textbox eingegeben worden ist")
                booting.bootprogress.Value = 24
                toolTip1.SetToolTip(Refresh, "Lädt eine Internetseite neu")
                booting.bootprogress.Value = 27
                toolTip1.SetToolTip(Cancel, "Bricht das Laden einer Internetseite ab")
                booting.bootprogress.Value = 30
                toolTip1.SetToolTip(Shortcuts, "Ruft Verknüpfungen zu verschiedenen Internetseiten auf")
                booting.bootprogress.Value = 33
                toolTip1.SetToolTip(Home, "Navigiert zu Startseite")
                toolTip1.SetToolTip(AddTab, "Fügt einen Tab hinzu")
                booting.bootprogress.Value = 36
                BeendenToolStripMenuItem.Text = "Beenden"
                booting.bootprogress.Value = 39
                TextBox1.Text = "Hier URL eingeben"
                booting.bootprogress.Value = 42
                'AddHandler WebView21.CoreWebView2.WebMessageReceived, AddressOf WebViewMessageReceived
                'WebView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("document.documentElement.setAttribute('lang', 'en-US');")
                Dim AppInfo As New AppInfo(Me)
                AppInfo.Text = "Info"
                booting.bootprogress.Value = 45
                AppInfo.Description.Text = "WebConnect ist ein Browser
FrontEnd-Version: 1.0.0-015
BackEnd: WebView2 (Microsoft.Web.WebView2.WinForms)
BackEnd-Version: 1.0.1823.32
Programmierer: PhilConnected (Phileas Melchert)
"
                booting.bootprogress.Value = 48
                ASUSWiredOrWireless.Text = "Verbindungsart vom ASUS-Gerät"
                booting.bootprogress.Value = 52
                ASUSWiredOrWireless.Label1.Text = "Ist dein ASUS-Gerät 
  kabellos (WLAN) oder per 
    Kabel (LAN) am PC 
      angeschlossen?"
                booting.bootprogress.Value = 56
                Launcher.Musik.Text = "Musik"
                booting.bootprogress.Value = 60
                Launcher.Geraete.Text = "Geräte"
                booting.bootprogress.Value = 64
                Launcher.important.Text = "Es kann sein, dass manche Dienste auf dieser Seite kostenpflichtig über einen einmaligen Preis oder ein Abomodell bezahlt werden sollen
oder man kann damit einkaufen.
Unbezahlte Werbung
"
                booting.bootprogress.Value = 68
                Launcher.ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
                booting.bootprogress.Value = 72
                ConnectToNAS.Text = "Einen NAS verbinden"
                booting.bootprogress.Value = 76
                ConnectToNAS.Label1.Text = "Welchen NAS 
  benutzt du?"
                booting.bootprogress.Value = 80
                ConnectToNAS.ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
                booting.bootprogress.Value = 84
                ConnectToNAS.Cancel.Text = "Abbrechen"
                booting.bootprogress.Value = 88
                AppInfoToolStripMenuItem.Text = "Über WebConnect"
                AppInfo.Text = "Über WebConnect"

            End If
            booting.bootprogress.Value = 100
            If My.Settings.Sprache = "English" Then
                booting.bootprogress.Value = 9
                Text = "Loading main window... Please wait"
                booting.bootprogress.Value = 12
                Dim toolTip1 As New ToolTip
                booting.bootprogress.Value = 15
                toolTip1.SetToolTip(Back, "Navigates back on the website 
            or navigates to the previous website")
                booting.bootprogress.Value = 18
                toolTip1.SetToolTip(Forward, "Navigates the website 
            or navigates to the next open website")
                booting.bootprogress.Value = 21
                toolTip1.SetToolTip(Search, "Searches for the URL 
            that has been typed in the text box")
                booting.bootprogress.Value = 24
                toolTip1.SetToolTip(Refresh, "Reloads a web page")
                booting.bootprogress.Value = 27
                toolTip1.SetToolTip(Cancel, "Cancels the loading of a web page")
                booting.bootprogress.Value = 30
                toolTip1.SetToolTip(Shortcuts, "Calls up links to different websites")
                booting.bootprogress.Value = 33
                toolTip1.SetToolTip(Home, "Navigates to Home")
                toolTip1.SetToolTip(AddTab, "Adds a Tab")
                booting.bootprogress.Value = 36
                BeendenToolStripMenuItem.Text = "Shut down"
                booting.bootprogress.Value = 39
                NeustartenToolStripMenuItem.Text = "Reboot"
                booting.bootprogress.Value = 42
                AppInfoToolStripMenuItem.Text = "About"
                booting.bootprogress.Value = 45
                EinstellungenToolStripMenuItem.Text = "Settings"
                booting.bootprogress.Value = 48
                VorToolStripMenuItem.Text = "Forward"
                booting.bootprogress.Value = 52
                ZurückToolStripMenuItem.Text = "Backward"
                booting.bootprogress.Value = 56
                AktualisierenToolStripMenuItem.Text = "Reload"
                booting.bootprogress.Value = 60
                StartseiteToolStripMenuItem.Text = "Start Page"
                NeuerTabToolStripMenuItem.Text = "New Tab"
                booting.bootprogress.Value = 64
                TextBox1.Text = "Enter URL here"
                booting.bootprogress.Value = 68
                Dim AppInfo As New AppInfo(Me)
                AppInfo.Text = "App info"
                booting.bootprogress.Value = 72
                AppInfo.Description.Text = "WebConnect
FrontEnd version: 1.0.0-015
BackEnd: WebView2 (Microsoft.Web.WebView2.WinForms)
BackEnd version: 1.0.1823.32
Programmer: PhilConnected (Phileas Melchert)
"
                booting.bootprogress.Value = 76
                ASUSWiredOrWireless.Text = "Connection type from ASUS device"
                booting.bootprogress.Value = 80
                ASUSWiredOrWireless.Label1.Text = "Is your ASUS device 
  wireless (WLAN) or via 
    Cable (LAN) on the PC 
      connected?"
                booting.bootprogress.Value = 84
                Launcher.Musik.Text = "Music"
                booting.bootprogress.Value = 88
                Launcher.Geraete.Text = "Devices"
                booting.bootprogress.Value = 92
                Launcher.important.Text = "It may be that some services on this site require payment via a one-off price or a subscription model
or you can use it to shop.
Unpaid advertising
"
                booting.bootprogress.Value = 96
                Launcher.ManualConnection.Text = "Enter IP address instead"
                booting.bootprogress.Value = 98
            End If
            booting.bootprogress.Value = 100
            If My.Settings.Sprache = "Français" Then
                booting.bootprogress.Value = 9
                Text = "Chargement de la fenêtre principale... Attendez un instant"
                booting.bootprogress.Value = 19
                Dim toolTip1 As New ToolTip
                booting.bootprogress.Value = 29
                toolTip1.SetToolTip(Back, "Navigue de nouveau sur le site Web 
            ou navigue vers le site Web précédent")
                booting.bootprogress.Value = 39
                toolTip1.SetToolTip(Forward, "Navigue sur le site Web 
            ou navigue jusqu’au prochain site Web ouvert")
                booting.bootprogress.Value = 49
                toolTip1.SetToolTip(Search, "Recherche l’URL 
            qui a été saisie dans la zone de texte")
                booting.bootprogress.Value = 59
                toolTip1.SetToolTip(Refresh, "Recharge une page web")
                booting.bootprogress.Value = 69
                toolTip1.SetToolTip(Cancel, "Annule le chargement d’une page web")
                booting.bootprogress.Value = 79
                toolTip1.SetToolTip(Shortcuts, "Appelle des liens vers différents sites Web")
                booting.bootprogress.Value = 89
                toolTip1.SetToolTip(Home, "Navigue jusqu’à la page d’accueil")
                booting.bootprogress.Value = 99
            End If
            booting.bootprogress.Value = 100
            If My.Settings.Sprache = "Español" Then
                booting.bootprogress.Value = 10
                Text = "Cargando ventana principal... Espere un momento"
                booting.bootprogress.Value = 20
                Dim toolTip1 As New ToolTip
                booting.bootprogress.Value = 30
                toolTip1.SetToolTip(Back, "Navega hacia atrás en el sitio web 
            o navega al sitio web anterior")
                booting.bootprogress.Value = 40
                toolTip1.SetToolTip(Forward, "Navegue por el sitio web 
            o navegue hasta el siguiente sitio web abierto")
                booting.bootprogress.Value = 50
                toolTip1.SetToolTip(Search, "Busca la dirección URL 
            que se introdujo en el cuadro de texto")
                booting.bootprogress.Value = 60
                toolTip1.SetToolTip(Refresh, "Volver a cargar una página web")
                booting.bootprogress.Value = 70
                toolTip1.SetToolTip(Cancel, "Cancela la carga de una página web")
                booting.bootprogress.Value = 80
                toolTip1.SetToolTip(Shortcuts, "Invoca enlaces a diferentes sitios web")
                booting.bootprogress.Value = 90
                toolTip1.SetToolTip(Home, "Vaya a la página de inicio")
                booting.bootprogress.Value = 100
            End If
            If My.Settings.Sprache = "Türkçe" Then
                booting.bootprogress.Value = 10
                Text = "Ana pencere yükleniyor... Bir dakika bekleyin"
                booting.bootprogress.Value = 20
                Dim toolTip1 As New ToolTip
                booting.bootprogress.Value = 30
                toolTip1.SetToolTip(Back, "Web sitesine geri döndüğünde 
            veya önceki web sitesine gittiğinde")
                booting.bootprogress.Value = 40
                toolTip1.SetToolTip(Forward, "Web sitesine gidin 
            veya bir sonraki açık web sitesine gidin")
                booting.bootprogress.Value = 50
                toolTip1.SetToolTip(Search, "Metin kutusuna girilen URL'yi bulun")
                booting.bootprogress.Value = 60
                toolTip1.SetToolTip(Refresh, "Web sayfasını yeniden yükleme")
                booting.bootprogress.Value = 70
                toolTip1.SetToolTip(Cancel, "Bir web sayfasının yüklenmesini iptal etme")
                booting.bootprogress.Value = 80
                toolTip1.SetToolTip(Shortcuts, "Farklı web sitelerine bağlantılar çağırır")
                booting.bootprogress.Value = 90
                toolTip1.SetToolTip(Home, "Ana sayfaya git")
                booting.bootprogress.Value = 100
            End If
            If My.Settings.Sprache = "Deutsch" Then
                Text = "WebConnect für Windows"

            End If
            If My.Settings.Sprache = "English" Then
                Text = "WebConnect for Windows"
            End If
            If My.Settings.Sprache = "Français" Then
                Text = "WebConnect pour Windows"
            End If
            If My.Settings.Sprache = "Español" Then
                Text = "WebConnect para Windows"

            End If
            If My.Settings.Sprache = "Türkçe" Then
                Text = "Windows için WebConnect"

            End If
            If My.Settings.Sprache = "Italiano" Then

            End If
            AddInitialTab()
            If OpenLinkOnBoot = False Then
                If My.Settings.DefaultSearchEngine = "Google" Then
                    Me.AddNewTab("https://www.google.com")
                ElseIf My.Settings.DefaultSearchEngine = "Bing" Then
                    AddNewTab("https://www.bing.com")
                End If
            End If

            Padding = New Padding(0)
            Margin = New Padding(0)
            TabControl1.Margin = New Padding(0)
            If TabControl1.SelectedTab IsNot Nothing Then
                For Each control As Control In TabControl1.SelectedTab.Controls
                    If TypeOf control Is WebView2 Then
                        Dim webView = CType(control, WebView2)
                        webView.Dock = DockStyle.Fill
                    End If
                Next
            End If
            RegisterBrowserForProtocolsAndFileTypes()
            RegisterBrowserForHttpAndHttps()
            RegisterAsDefaultApp()

            booting.Close()


        Catch ex As Exception
            BootError.ShowDialog()
            Application.Exit()

        Catch ex As FileNotFoundException
            BootError.ShowDialog()
        End Try















    End Sub
    Private Sub AddNewTabFromAnotherApplication(url As String)
        Dim newWebView As New WebView2()
        Dim newTabPage As New TabPage()
        If My.Settings.Sprache = "English" Then
            newTabPage.Text = "Loading new tab"
        End If
        If My.Settings.Sprache = "English" Then
            newTabPage.Text = "Lade neuen Tab"
        End If

        newWebView.Dock = DockStyle.Fill
        newTabPage.Controls.Add(newWebView)
        TabControl1.TabPages.Add(newTabPage)
        TabControl1.SelectedTab = newTabPage
        InitializeWebView(newWebView, url)
    End Sub

    Private Sub TabControl1_MouseDown(sender As Object, e As MouseEventArgs) Handles TabControl1.MouseDown
        If e.Button = MouseButtons.Middle Then
            For i As Integer = 0 To TabControl1.TabPages.Count - 1
                Dim tabPage As TabPage = TabControl1.TabPages(i)
                Dim tabRect As Rectangle = TabControl1.GetTabRect(i)
                If tabRect.Contains(e.Location) Then
                    TabControl1.TabPages.Remove(tabPage)
                    Exit For
                End If
            Next
        End If
    End Sub
    Private Sub AddInitialTab()

    End Sub
    Private Sub WebView21_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click


        GoBack()





    End Sub

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click
        GoForward()

    End Sub


    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Debug.WriteLine(Version)

        Dim clickcounter As Integer = 0
        If clickcounter = 0 Then
            TextBox1.SelectAll()
            clickcounter += 1

        Else
            TextBox1.DeselectAll()
        End If

        If TextBox1.Text = "Hier URL eingeben" Then
            TextBox1.Clear()


        End If
        If TextBox1.Text = "Enter URL here" Then
            TextBox1.Clear()


        End If

        If TextBox1.Text = "Du kannst nicht weiter zurückgehen" Then
            TextBox1.Clear()
        End If
        If TextBox1.Text = "You can't go more back" Then
            TextBox1.Clear()

        End If

        If TextBox1.Text = "Du kannst nicht weiter vorgehen" Then
            TextBox1.Clear()

        End If
        If TextBox1.Text = "You can't go more forward" Then
            TextBox1.Clear()

        End If




    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        SearchURL()
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        ReloadPage()


    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Dim webView As WebView2 = GetCurrentWebView()
        If webView IsNot Nothing Then
            webView.CoreWebView2.Stop()
        Else

        End If

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        Startpage()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NeustartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeustartenToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub AppInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppInfoToolStripMenuItem.Click
        Dim AppInfo As New AppInfo(Me)
        AppInfo.ShowDialog()

    End Sub

    Private Sub SearchURL()
        If TabControl1.SelectedTab IsNot Nothing Then
            Dim webView As WebView2 = TabControl1.SelectedTab.Controls.OfType(Of WebView2)().FirstOrDefault()
            If webView IsNot Nothing Then
                If TextBox1.Text = "Hier URL eingeben" Or TextBox1.Text = "Enter URL here" Then
                    TextBox1.Text = "Hier URL eingeben"
                Else
                    ''If Not String.IsNullOrEmpty(URL) Then
                    ''TextBox1.Text = "Hier URL eingeben"
                    ''End If
                End If
                If TextBox1.Text = "Du kannst nicht weiter zurückgehen" Then
                    TextBox1.Text = "Hier URL eingeben"
                Else
                    ''If Not String.IsNullOrEmpty(URL) Then
                    ''TextBox1.Text = "Hier URL eingeben"
                    ''End If
                End If
                If TextBox1.Text = "Du kannst nicht weiter vorgehen" Then
                    TextBox1.Text = "Hier URL eingeben"
                Else
                    ''If Not String.IsNullOrEmpty(URL) Then
                    ''TextBox1.Text = "Hier URL eingeben"
                    ''End If
                End If
                ''If TextBox1.Text = "" Then
                Try
                    webView.CoreWebView2.Navigate(TextBox1.Text)

                Catch ex As System.ArgumentException
                    TextBox1.Text = "Hier URL eingeben"

                End Try
                ''End If

            Else
                WebViewNotInitializedError.ShowDialog()
            End If
        Else
            TextBox1.Text = "Wähle einen Tab mit aktiver WebView aus oder erstelle einen neuen Tab"
        End If
    End Sub

    Private Sub GoForward()
        Dim webView As WebView2 = GetCurrentWebView()
        If webView IsNot Nothing AndAlso webView.CoreWebView2.CanGoForward Then
            webView.CoreWebView2.GoForward()
        Else
            If My.Settings.Sprache = "Deutsch" Then
                TextBox1.Text = "Du kannst nicht weiter vorgehen"
            End If
            If My.Settings.Sprache = "English" Then
                TextBox1.Text = "You can't go more forward
"
            End If
        End If

    End Sub
    Private Sub GoBack()
        Dim webView As WebView2 = GetCurrentWebView()
        If webView IsNot Nothing AndAlso webView.CoreWebView2.CanGoBack Then
            webView.CoreWebView2.GoBack()
        Else
            If My.Settings.Sprache = "Deutsch" Then
                TextBox1.Text = "Du kannst nicht weiter zurückgehen"
            End If
            If My.Settings.Sprache = "English" Then
                TextBox1.Text = "You can't go more back"
            End If
        End If




    End Sub
    Private Sub ReloadPage()
        Dim webView As WebView2 = GetCurrentWebView()
        If webView IsNot Nothing Then
            webView.CoreWebView2.Reload()
        Else
        End If
    End Sub
    Private Sub newTab()
        Dim newWebView As New WebView2()
        Dim newTabPage As New TabPage()
        If My.Settings.Sprache = "English" Then
            newTabPage.Text = "Loading new tab"
        End If
        If My.Settings.Sprache = "English" Then
            newTabPage.Text = "Lade neuen Tab"
        End If
        newWebView.Dock = DockStyle.Fill
        newTabPage.Controls.Add(newWebView)
        TabControl1.TabPages.Add(newTabPage)
        TabControl1.SelectedTab = newTabPage
        If My.Settings.DefaultSearchEngine = "Google" Then
            InitializeWebView(newWebView, "https://www.google.de")
        ElseIf My.Settings.DefaultSearchEngine = "Bing" Then
            InitializeWebView(newWebView, "https://www.bing.de")
        End If
    End Sub
    Private Function GetCurrentWebView() As WebView2
        If TabControl1.SelectedTab IsNot Nothing Then
            Return TabControl1.SelectedTab.Controls.OfType(Of WebView2)().FirstOrDefault

        End If
        Return Nothing
    End Function
    Private Sub Startpage()
        Dim webView As WebView2 = GetCurrentWebView()
        If webView IsNot Nothing Then
            If My.Settings.DefaultSearchEngine = "Google" Then
                webView.CoreWebView2.Navigate("https://www.google.de")
            ElseIf My.Settings.DefaultSearchEngine = "Bing" Then
                webView.CoreWebView2.Navigate("https://www.bing.de")
            End If

        Else

        End If
    End Sub

    Private Sub VorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VorToolStripMenuItem.Click
        GoForward()
    End Sub

    Private Sub ZurückToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZurückToolStripMenuItem.Click
        GoBack()


    End Sub

    Private Sub AktualisierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AktualisierenToolStripMenuItem.Click
        ReloadPage()
    End Sub

    Private Sub StartseiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartseiteToolStripMenuItem.Click
        Startpage()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Settings.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Shortcuts.Click
        Try
            Launcher.ShowDialog()
        Catch ex As Exception
            Application.Exit()
        End Try

    End Sub

    Private Sub AddTab_Click(sender As Object, e As EventArgs) Handles AddTab.Click
        newTab()
    End Sub


    Public Sub AddNewTab(url As String)
        Dim newWebView As New WebView2()
        Dim newTabPage As New TabPage()
        If My.Settings.Sprache = "English" Then
            newTabPage.Text = "Loading new tab"
        End If
        If My.Settings.Sprache = "English" Then
            newTabPage.Text = "Lade neuen Tab"
        End If

        newWebView.Dock = DockStyle.Fill
        newTabPage.Controls.Add(newWebView)
        TabControl1.TabPages.Add(newTabPage)
        TabControl1.SelectedTab = newTabPage
        InitializeWebView(newWebView, url)
    End Sub
    Private Async Sub InitializeWebView(webView As WebView2, url As String)
        Try
            Await webView.EnsureCoreWebView2Async(Nothing)
            webView.CoreWebView2.Navigate(url)
            AddHandler webView.CoreWebView2.NavigationCompleted, Sub(sender, args)
                                                                     UpdateTabName(webView)
                                                                 End Sub
            AddHandler webView.CoreWebView2.ProcessFailed, AddressOf WebView_ProcessFailed

            Back.Enabled = True
            Forward.Enabled = True
            TextBox1.Enabled = True
            AddTab.Enabled = True
            Search.Enabled = True
            Refresh.Enabled = True
            Cancel.Enabled = True
            Home.Enabled = True
            Shortcuts.Enabled = True
            NavigatiToolStripMenuItem.Enabled = True
        Catch ex As Exception
            BootError.ShowDialog()
        End Try

    End Sub
    Private Sub WebView_ProcessFailed(sender As Object, e As CoreWebView2ProcessFailedEventArgs)
        ' Überprüfen, ob es sich um einen kritischen Fehler handelt
        If e.ProcessFailedKind = CoreWebView2ProcessFailedKind.BrowserProcessExited Then
            Crashed.Showerrorcode("BROWSER_BACKEND_CRASH")
            Crashed.ShowDialog()
        ElseIf e.ProcessFailedKind = CoreWebView2ProcessFailedKind.RenderProcessExited Then
            ' Entferne den aktuellen Tab
            Crashed.Showerrorcode("BROWSER_RENDER_CRASH")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.FrameRenderProcessExited Then
            Crashed.Showerrorcode("BROWSER_FRAMERENDER_CRASH")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.GpuProcessExited Then
            Crashed.Showerrorcode("BROWSER_GPU_CRASH")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.PpapiBrokerProcessExited Then
            Crashed.Showerrorcode("BROWSER_PPAPIBROKER_CRASH")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.PpapiPluginProcessExited Then
            Crashed.Showerrorcode("BROWSER_PPAPIPLUGIN_CRASH")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.RenderProcessUnresponsive Then
            Crashed.Showerrorcode("BROWSER_RENDER_UNRESPONSIVE")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.SandboxHelperProcessExited Then
            Crashed.Showerrorcode("BROWSER_SANDBOXHELPER_CRASH")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.UnknownProcessExited Then
            Crashed.Showerrorcode("BROWSER_UNKNOWN_CRASH")
            Crashed.ShowDialog()
        ElseIf CoreWebView2ProcessFailedKind.UtilityProcessExited Then
            Crashed.Showerrorcode("BROWSER_UTILITY_CRASH")
            Crashed.ShowDialog()



        Else


            Crashed.Showerrorcode("UNKNOWN_ERROR")
            Crashed.ShowDialog()
        End If
    End Sub
    Private Sub UpdateTabName(webview As WebView2)
        Dim selectedTab As TabPage = TabControl1.SelectedTab
        If selectedTab IsNot Nothing AndAlso selectedTab.Controls.OfType(Of WebView2).FirstOrDefault() Is webview Then
            Dim url As String = webview.CoreWebView2.Source
            Dim title As String = webview.CoreWebView2.DocumentTitle
            selectedTab.Text = If(Not String.IsNullOrEmpty(title), title, url)
        End If
    End Sub











    Private Sub NeuerTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuerTabToolStripMenuItem.Click
        newTab()
    End Sub

    Private Sub Home_Click_1(sender As Object, e As EventArgs) Handles Home.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Toolbar_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Toolbar.ItemClicked

    End Sub
    Private Sub RegisterBrowserForProtocolsAndFileTypes()
        Try
            ' Name und Pfad der Anwendung
            Dim appName As String = "WebConnectBrowser"
            Dim appPath As String = Application.ExecutablePath
            Dim browserDescription As String = "WebConnect Browser"

            ' Pfad in der Registry für den Browser in StartMenuInternet
            Dim browserRegPath As String = "Software\Clients\StartMenuInternet"
            Dim shellOpenCommand As String = "shell\open\command"

            ' 1. Schritt: Erstellen des Eintrags in der Liste der Standardbrowser
            Using browserKey As RegistryKey = Registry.CurrentUser.CreateSubKey(browserRegPath & "\" & appName)
                browserKey.SetValue("", browserDescription)  ' Setzt den Namen des Browsers
            End Using

            ' Registriere den Pfad zur EXE als Befehl für das Öffnen von URLs
            Using commandKey As RegistryKey = Registry.CurrentUser.CreateSubKey(browserRegPath & "\" & appName & "\" & shellOpenCommand)
                commandKey.SetValue("", """" & appPath & """ ""%1""")  ' Pfad zur ausführbaren Datei
            End Using

            ' Optional: Icon für den Browser setzen
            Using iconKey As RegistryKey = Registry.CurrentUser.CreateSubKey(browserRegPath & "\" & appName & "\DefaultIcon")
                iconKey.SetValue("", appPath & ",0")  ' Verwende das Icon der EXE als Symbol
            End Using

            ' 2. Schritt: Registrieren der Protokollhandler für http und https
            RegisterProtocolHandler("http", appName, appPath)
            RegisterProtocolHandler("https", appName, appPath)

            ' 3. Schritt: Registrieren als Standardanwendung für den Dateityp .html
            RegisterFileAssociation(".html", appName, appPath)

            'MessageBox.Show("Der Browser wurde erfolgreich für http, https und .html registriert.")
        Catch ex As Exception
            'MessageBox.Show("Fehler beim Registrieren: " & ex.Message)
        End Try
    End Sub

    Private Sub RegisterProtocolHandler(protocol As String, appName As String, appPath As String)
        Dim protocolKeyPath As String = "Software\Classes\" & protocol

        ' Protokoll-Handler für http und https erstellen oder aktualisieren
        Using protocolKey As RegistryKey = Registry.CurrentUser.CreateSubKey(protocolKeyPath)
            protocolKey.SetValue("", appName & " URL")
            protocolKey.SetValue("URL Protocol", "")  ' Notwendiger Wert für Protokoll-Handler

            ' Erstellen des Schlüssels für den Öffnungsbefehl
            Using commandKey As RegistryKey = protocolKey.CreateSubKey("shell\open\command")
                commandKey.SetValue("", """" & appPath & """ ""%1""")
            End Using
        End Using
    End Sub

    Private Sub RegisterFileAssociation(extension As String, appName As String, appPath As String)
        Dim fileTypeKeyPath As String = "Software\Classes\" & extension

        ' Dateityp-Verknüpfung für .html erstellen
        Using fileTypeKey As RegistryKey = Registry.CurrentUser.CreateSubKey(fileTypeKeyPath)
            fileTypeKey.SetValue("", appName & ".html")  ' Setze den Dateityp
        End Using

        ' Erstelle den Schlüssel für den Dateityp und den Öffnungsbefehl
        Dim fileTypeCommandKeyPath As String = "Software\Classes\" & appName & ".html\shell\open\command"
        Using fileTypeCommandKey As RegistryKey = Registry.CurrentUser.CreateSubKey(fileTypeCommandKeyPath)
            fileTypeCommandKey.SetValue("", """" & appPath & """ ""%1""")  ' Setze den Pfad zur ausführbaren Datei
        End Using
    End Sub
    Private Sub RegisterBrowserForHttpAndHttps()
        Try
            ' Name und Pfad der Anwendung
            Dim appName As String = "WebConnectBrowser"
            Dim appPath As String = Application.ExecutablePath
            Dim browserDescription As String = "WebConnect Browser"

            ' 1. Schritt: Erstellen des Programms in der Liste der Standardbrowser mit Progid
            Dim progId As String = appName & ".Progid"
            RegisterProgid(appName, progId, browserDescription, appPath)

            ' 2. Schritt: Registrieren der Capabilities (Fähigkeiten), inklusive http und https
            RegisterCapabilities(appName, progId, appPath)

            ' 3. Schritt: Informiere das System über die neue Registrierung
            'MessageBox.Show("Browser wurde erfolgreich für http, https und als Standard-HTML-Handler registriert.")
        Catch ex As Exception
            ' MessageBox.Show("Fehler beim Registrieren: " & ex.Message)
        End Try
    End Sub

    Private Sub RegisterProgid(appName As String, progId As String, description As String, appPath As String)
        ' Erstellen des Progid-Schlüssels
        Dim progIdPath As String = "Software\Classes\" & progId
        Using progIdKey As RegistryKey = Registry.CurrentUser.CreateSubKey(progIdPath)
            progIdKey.SetValue("", description)  ' Name der Anwendung
        End Using

        ' Verknüpfen mit Öffnungsmethode
        Dim commandKeyPath As String = progIdPath & "\shell\open\command"
        Using commandKey As RegistryKey = Registry.CurrentUser.CreateSubKey(commandKeyPath)
            commandKey.SetValue("", """" & appPath & """ ""%1""")
        End Using
    End Sub

    Private Sub RegisterCapabilities(appName As String, progId As String, appPath As String)
        ' Definiere die Fähigkeiten der Anwendung (Capabilities)
        Dim capabilitiesKeyPath As String = "Software\Clients\StartMenuInternet\" & appName & "\Capabilities"

        Using capabilitiesKey As RegistryKey = Registry.CurrentUser.CreateSubKey(capabilitiesKeyPath)
            ' Anwendungsname und Beschreibung
            capabilitiesKey.SetValue("ApplicationName", appName)
            capabilitiesKey.SetValue("ApplicationDescription", "WebConnect Browser für http und https")

            ' HTTP und HTTPS Protokoll-Handler registrieren
            Using urlAssociationsKey As RegistryKey = capabilitiesKey.CreateSubKey("URLAssociations")
                urlAssociationsKey.SetValue("http", progId)
                urlAssociationsKey.SetValue("https", progId)
            End Using

            ' Standard für HTML-Dateien
            Using fileAssociationsKey As RegistryKey = capabilitiesKey.CreateSubKey("FileAssociations")
                fileAssociationsKey.SetValue(".html", progId)
            End Using
        End Using

        ' Setze den Anwendungspfad unter StartMenuInternet
        Dim browserPath As String = "Software\Clients\StartMenuInternet\" & appName
        Using browserKey As RegistryKey = Registry.CurrentUser.CreateSubKey(browserPath)
            browserKey.SetValue("DefaultIcon", appPath & ",0")
        End Using

        ' Registriere die Anwendung unter RegisteredApplications
        Dim registeredAppsKeyPath As String = "Software\RegisteredApplications"
        Using registeredAppsKey As RegistryKey = Registry.CurrentUser.CreateSubKey(registeredAppsKeyPath)
            registeredAppsKey.SetValue(appName, browserPath & "\Capabilities")
        End Using
    End Sub
    Private Sub RegisterAsDefaultApp()
        Try
            ' Name und Pfad der Anwendung
            Dim appName As String = "WebConnectBrowser"
            Dim appPath As String = Application.ExecutablePath
            Dim progId As String = appName & ".Progid"
            Dim description As String = "WebConnect Browser"

            ' Schritt 1: Registrierung als Protokoll-Handler für http und https
            RegisterProtocolHandler("http", appName, appPath)
            RegisterProtocolHandler("https", appName, appPath)

            ' Schritt 2: Capabilities hinzufügen
            RegisterCapabilities(appName, progId, appPath)

            ' Schritt 3: Standardprotokoll für den Benutzer setzen
            SetUserDefaultBrowser(appName)

            'MessageBox.Show("Browser wurde erfolgreich registriert.")
        Catch ex As Exception
            'MessageBox.Show("Fehler: " & ex.Message)
        End Try
    End Sub

    Private Sub SetUserDefaultBrowser(appName As String)
        ' Dies setzt den Benutzerstandard für den Browser
        Dim userChoiceKeyPath As String = "Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"
        Using userChoiceKey As RegistryKey = Registry.CurrentUser.OpenSubKey(userChoiceKeyPath, True)
            If userChoiceKey IsNot Nothing Then
                userChoiceKey.SetValue("Progid", appName)
            Else
                MessageBox.Show("Fehler beim Festlegen als Standard-Browser.")
            End If
        End Using
    End Sub
    Private Sub StartNamedPipeServer()
        pipeThread = New Thread(AddressOf NamedPipeServer)
        pipeThread.IsBackground = True
        pipeThread.Start()
    End Sub
    Private Sub NamedPipeServer()
        Using server As New NamedPipeServerStream("WebConnectPipe", PipeDirection.In)
            server.WaitForConnection()
            Using reader As New StreamReader(server)
                While True
                    Dim url As String = reader.ReadLine
                    If Not String.IsNullOrEmpty(url) Then
                        Me.Invoke(New Action(Sub() AddNewTab(url)))
                    End If
                End While
            End Using
        End Using
    End Sub
    Private Function IsBrowserRunning() As Boolean
        Dim processes() As Process = Process.GetProcessesByName("WebConnect")
        Return processes.Length > 0
    End Function
    Private Sub StartNewInstance(url As String)
        Process.Start(Application.ExecutablePath, url)
    End Sub
    Public Sub OpenLink(url As String)
        If IsBrowserRunning() Then
            SendUrlToRunningInstance(url)
        Else
            StartNewInstance(url)
        End If
    End Sub

    Private Sub SendUrlToRunningInstance(url As String)
        Try
            Using client As New NamedPipeClientStream(".", "WebConnectPipe", PipeDirection.Out)
                client.Connect(1000)
                Using writer As New StreamWriter(client)
                    writer.WriteLine(url)
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class
' Google als Startseite festlegen? https://www.google.com/intl/de_ALL/homepage/hp-edge.html?utm_source=google.com&utm_medium=callout&utm_campaign=EDHP
