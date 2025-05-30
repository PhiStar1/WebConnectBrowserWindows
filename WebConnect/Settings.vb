Imports System.IO
Imports System.Net
Imports System.Net.Http
Imports System.Net.WebRequestMethods
Imports System.Reflection
Imports System.Reflection.Emit
Imports System.Reflection.Metadata
Imports System.Reflection.PortableExecutable
Imports System.Runtime.ConstrainedExecution
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Text.RegularExpressions
Imports Microsoft.CodeAnalysis
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify
Imports Microsoft.CodeAnalysis.CSharp.Syntax
Imports Microsoft.CodeAnalysis.Diagnostics
Imports Microsoft.Web.WebView2.Core
Imports Microsoft.Web.WebView2.WinForms
Imports Microsoft.Win32
Imports Microsoft.Win32.NativeMethods
Imports Newtonsoft.Json
Imports Windows.Win32
Imports Windows.Win32.System
Public Class Settings
    Public PendingAIChanges As Boolean
    Private clickLabelCounter = 0
    Private WithEvents Timer As New Timer()
    ' Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
    ' Dim MagicAILinkRegistryKey As String = "Software\WebConnect\User\Settings\MagicAILinkSettings"
    'Dim SoftwareUpdateRegistryKey As String = "Software\WebConnect\User\Settings\SoftwareUpdateSettings"


    Private Sub Settings_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Einstellungen"
            DisplaySettings.Text = "Anzeigeeinstellungen"
            Language.Text = "Sprache"
            DefaultSearchEngine.Text = "Standard-Suchmaschine"
            MagicAILinkButton.Text = "MagicAI Link"
            DefaultChatBot.Text = "Standard-KI-ChatBot"
            SoftwareUpdate.Text = "Software-Update"
            VersionInfo.Text = "Aktuell installierte Softwareversion: "
            SearchForUpdatesOnApplicationBoot.Text = "Beim Start immer automatisch
nach Software-Updates suchen"
            SearchForSoftwareUpdate.Text = "Online nach Software-Updates suchen"
            Changelog.Text = "Changelog
Einige Elemente in diesem Text wurden maschinell übersetzt.
v2025.02.25
- Aktualisierte Komponenten
  - Frontend 3.1 --> 4.0
    - NEUE FUNKTIONEN
      - Tabs
        - Du kannst neue Tabs vom Kontextmenü aus öffnen
          - Dazu musst du:
            - einen Rechtsklick auf einen beliebigen Tab machen
            - und ''Neuer Tab'' auswählen
        - Du kannst Tabs nach rechts oder links verschieben
          - Dazu musst du:
            - einen Rechtsklick auf den aktuell geöffneten Tab machen, oder einen Tab auswählen den du verschieben möchtest,
            - ''Tab verschieben nach...'' auswählen
            - und ''...links'' oder ''...rechts'' auswählen
          - oder
            - ''Navigation'' auswählen, mit dem geöffneten Tab, den du verschieben möchtest,
            - ''Tab verschieben nach...'' auswählen
            - und ''...links'' oder ''...rechts'' auswählen
        - Du kannst Tabs direkt mit deiner Maus verschieben
          - Dazu musst du:
            - den Tab, den du verschieben möchtest, mit der linken Maustaste anklicken und gedrückt halten
            - und den Tab an die gewünschte Position ziehen
    - BEHOBENE BUGS
      - WebView
        - Ein Bug wurde behoben, der dazu führte, dass die WebView nicht korrekt angezeigt wird und somit manche Webinhalte außerhalb des Bildes sind.
      - MagicAI Link
        - Ein Bug wurde behoben, der dazu führte, dass die MagicAI Link WebView nicht reagierte, wenn der MagicAI Link Button oder ''CTRL + .'' gedrückt wurde.
        - Dieser Bug führte dazu, dass du die WebConnect-Einstellungen öffnen musstest, damit die MagicAI Link WebView wieder reagiert.
  - hyphens-data-Version: 101.0.4906.0 --> 120.0.6050.0
  - Microsoft PKI Metadata-Version: 14.0.0.1 --> 21.0.0.0
  - Subresource Filter Version: 10.34.0.55 --> 10.34.0.57
  - trustToken-Version: 2024.10.11.1 --> 2024.12.14.1
v2025.02.16
- Aktualisierte Komponenten
  - Frontend 3.0 --> 3.1
    - BEHOBENE BUGS
      - Einstellungen
        - Ein Bug wurde behoben, der dazu führte, dass deine vorgenommenen Einstellungen nach einem Software-Update verloren gingen.
        - Lösung: Deine Einstellungen werden nun in der Registry gespeichert und bleiben auch nach einem Software-Update erhalten.
        - Davor wurden deine Einstellungen direkt in der WebConnect.exe gespeichert, die bei einem Software-Update überschrieben wird.
      - MagicAI Link
        - Ein Bug wurde behoben, der dazu führte, dass deine Magic AI Link-Einstellungen nicht korrekt angewendet wurden.
        End If
        - Ein Bug wurde behoben, der dazu führte, dass die Größe von Magic AI Link nicht korrekt angepasst wurde, wenn du die Größe des Fensters geändert hast.
      - Befehlsinterpreter
        - Ein Bug wurde behoben, der dazu führte, dass WebConnect nicht neu gestartet wurde, wenn du den Befehl ''cmd://reboot'' eingegeben hast.
    - Bootloader 2.0 --> 2.1
      - Neue Startanimation
      - Bootloaderversion wird nun im ''Über WebConnect''-Fenster angezeigt
    - Edge WebView2 v131.0.2908.86 --> v131.0.3065.69
      - Promotionen
        - WPF-Elemente auf der WebView2-Ebene anzeigen (WebView2CompositionControl)
          Verhindert, dass WebView2CompositionControl das WebView2-Steuerelement der obersten Ebene in einer WPF-Anwendung ist und alle WPF-Elemente verdeckt. Microsoft.Web.WebView2.Wpf.WebView2CompositionControl ist ein Drop-in-Ersatz für das standardmäßige WPF WebView2-Steuerelement. Beide implementieren das WebView2-Steuerelement als WebView2CompositionControl und die Microsoft.Web.WebView2.Wpf.IWebView2-Schnittstelle. Beide sind wie folgt von FrameworkElement abgeleitet:

          FrameworkElement ->HwndHost ->WebView2.
          FrameworkElement ->Control ->WebView2CompositionControl.
          Hintergrund: Wenn du eine Windows Presentation Foundation (WPF)-Anwendung erstellst und das WebView2-Steuerelement verwendest, kann es vorkommen, dass deine Anwendung zu ''Airspace''-Problemen führt, bei denen das WebView2-Steuerelement immer oben angezeigt wird und alle WPF-Elemente an der gleichen Stelle verdeckt sind, selbst wenn du versuchst, die WPF-Elemente anzugeben, die oben auf dem WebView2-Steuerelement liegen sollen (z. B. mithilfe der visuellen Strukturreihenfolge oder der z-index-Eigenschaft).

          Dieses Problem tritt auf, weil das WPF-Steuerelement den WPF HwndHost verwendet, um das Win32-WebView2-Steuerelement zu hosten, und HwndHost hat ein Problem mit dem Luftraum.

      - Fehlerbehebungen
        - Nur-Runtime
          - Eine Regression wurde behoben, bei der Anzeigeänderungen dazu führen konnten, dass WebView2 kleiner als das Anwendungsfenster dargestellt wurde.
          - Die fehlende ''Schließen''-Schaltfläche wurde zum ''Download''-Flyout hinzugefügt.
          - Eine Race-Condition wurde behoben, die auftrat, wenn das Web Request Response-Ereignis nie eintrat. 
        - Nur SDK
          - Ein Problem im WPF WebView2CompositionControl wurde behoben, bei dem es nicht angezeigt wurde, wenn es mit der Größe (0,0) initialisiert wurde, z.B. wenn es in einem TabItem von TabControl initialisiert wurde.
  - System.Threading.Channels v9.0.0 --> v9.0.2		
  - Microsoft.Web.WebView2.Core v1.0.2903.40 --> v1.0.3065.39
  - Microsoft.Web.WebView2.WinForms v.1.0.2903.40 --> v1.0.3065.39
  - Microsoft.Web.WebView2.Wpf v1.0.2903.40 --> v1.0.3065.39
v2024.12.27
  - Aktualisierte Komponenten
    - Frontend 2.0 --> 3.0
      - NEUE FUNKTIONEN
        - MAGIC AI LINK

        - WAS IST MAGIC AI LINK?
          MIT MAGIC AI LINK KANNST DU GANZ EINFACH AUF DEINEN BEVORZUGTEN KI-CHATBOT ZUGREIFEN.
          DEIN CHATBOT WIRD RECHTS IN WEBCONNECT ANGEZEIGT, WENN DU IHN STARTEST.
          - Ein Button, der den KI-Chatbot öffnet/schließt, wurde hinzugefügt.
          - Ein Hotkey ''CTRL + .'', der den KI-Chatbot öffnet/schließt, wurde hinzugefügt.
          - Du kannst diesen Button und den Hotkey in den Einstellungen anpassen. Folgende Chatbots sind unterstützt:
            - Google Gemini
            - Microsoft Copilot
            - ChatGPT
      - BEHOBENE BUGS
        - Hotkeys
          - Ein Bug wurde behoben, der dazu führte, dass folgende Hotkeys in anderen Apps nicht funktionierten, während WebConnect ausgeführt wird:
            - ALT + E
            - CTRL + D
            - CTRL + E
            - CTRL + K
            - CTRL + L
            - ALT + F
            - CTRL + N
            - CTRL + T
            - CTRL + W
            - ALT + S
            - CTRL + TAB
            - CTRL + SHIFT + TAB
         - Tabs
           - Ein Bug wurde behoben, der dazu führte, dass ''Tab schließen'' in der Menü-Toolbar nicht funktionierte
v2024.12.13
  - Aktualisierte Komponenten
    - WebConnect-Installations/Aktualisierungsprogramm
      - Ein Bug wurde behoben, der dazu führte, dass das WebConnect-Installations/Aktualisierungsprogramm möglicherweise als nicht erwünschte Software (PUA) erkannt wurde.
v2024.12.11
  - Aktualisierte Komponenten
    - Bootloader
      - Verbesserte Fehlermeldung, wenn beim Starten von WebConnect benötigte Systemdateien fehlen oder fehlerhaft sind.
    - Frontend
      - Verbesserte Anzeige der Versionen der verschiedenen WebConnect-Komponenten im ''Über WebConnect''-Fenster.
      - Verbesserung des Versions-Changelog im ''Software-Update''-Fenster.
  - Microsoft Edge WebView: 130.0.1823.32 --> 130.0.849.56
    - Funktionen
      - Es wurde eine Option zum Abbrechen der anfänglichen Navigation in WebView2 eingeführt, um die Startleistung zu verbessern. 
      - Diese Änderung ist standardmäßig deaktiviert und kann durch die Verwendung der 
        msWebView2CancelInitialNavigation Feature Flag aktiviert werden.
      - Einführung des Funktionsmerkmals msWebView2EnableDownloadContentInWebResourceResponseReceived, 
        ein experimentelles Merkmal (statt eines stabilen Merkmals). Wenn dieses Flag aktiviert ist, können Antworten 
        von Navigationen, die zu Downloads werden, in WebResourceResponseReceived verfügbar sein.
      - Unterstützung für C#/WinRT .NET 6+ wurde hinzugefügt.
    - Laufzeit und SDK
      - Behebung eines Absturzes, wenn async-Methoden des .NET-Hostobjekts ein Null-Ergebnis zurückgeben
      - Wiederaktivierung des Standardverhaltens von SetUserAgent: Standardmäßig ist SetUserAgent für ursprungsübergreifende Iframes wirksam.
    - Runtime-only
      - Ein WebView2-Speicherleck wurde behoben, wenn das Fenster geschlossen wird.
      - Ein Problem wurde behoben, bei dem ignoreMemberNotFoundError für .NET-Objekte nicht funktionierte
      - Gibt jetzt einen korrekten Fehlercode zurück, wenn CreateSharedBuffer mit 0 Puffergröße aufgerufen wird. 
      - Ein Aktivierungsproblem für den Caret-Browsing-Dialog wurde behoben.
      - Es wurde ein Problem behoben, bei dem das WebView2 Visual Hosting CursorChanged-Ereignis für benutzerdefinierte Cursor nicht ausgelöst wurde.
      - Ein Fehler wurde behoben, der auftrat, wenn der LaunchingExternalURIScheme-Eventhandler angehängt wurde, 
        und das Kontrollkästchen ''Immer erinnern'' aktiviert ist, und der Benutzer dieses Kontrollkästchen auswählt, wird der Dialog fälschlicherweise wieder angezeigt.
      - Es wurde ein Problem behoben, bei dem Textbearbeitungssteuerelemente im visuellen Hosting die IME-Eingabe duplizierten, wenn sie den Fokus verloren und wiedererlangten.
      - Es wurde ein Problem behoben, bei dem UWP-Anwendungen mit vollem Vertrauen keine eigenen Fenster anzeigen konnten.
      - Es wurde ein Fehler in der Aktivierungslogik für eigene Fenster beim visuellen Hosting behoben.
      - Deaktiviert BreakoutBoxPreferCaptureTimestampInVideoFrame für WebView2 TextureStream.
      - Eine Regression wurde behoben, bei der das Ereignis WindowCloseRequested nur beim ersten window.close()-Aufruf ausgelöst wurde.
      - Es wurde eine Regression behoben, bei der typisierte Arrays in WinRT JavaScript Projection nicht als IDispatch im Host behandelt werden konnten.
      - Es wurde ein Fehler behoben, bei dem das Autofill-Popup sofort beendet wird und einen Fokuswechsel verursacht.
      - Es wurde ein Fehler behoben, bei dem WebView2 aufgrund von AppPolicyGetWindowingModel nicht geladen werden konnte.
      - Es wurde ein Problem behoben, bei dem das App-Fenster nicht über Systembefehle gesteuert werden konnte 
        (z.B. Alt+F4 oder Alt+Leertaste) gesteuert werden konnte, wenn der Fokus im WebView2 for Visual Hosting Modus war.
      - Es wurde ein Fehler in WebView2 UWP behoben, bei dem die Suchleiste nicht von der Host-App aus angeklickt werden konnte.
      - Eine Regression wurde behoben, bei der WebResourceRequested-Ereignisse auf bestimmten Websites abstürzen.
      - Die Funktion zum interaktiven Ziehen wurde standardmäßig aktiviert. Siehe edge-webview-interactive-dragging in WebView2 Browser-Flags.
      - Deaktiviert IsolateSandboxedIframes für WebView2.
      - Es wurde ein Problem behoben, bei dem die WebView-Erstellung fehlschlägt, wenn mehrere Instanzen gleichzeitig gestartet werden.
      - Ein Fehler in der WinRT JavaScript Projektion wurde behoben, bei dem das Zwischenspeichern bestehender Eigenschaften in Objekten, deren Name 
        Proxy oder Function enthält, einen Fehler aufgrund von Namenskollisionen verursachte.
      - Es wurde ein Fehler behoben, bei dem das WebView2-Steuerelement nach dem Trennen und erneuten Verbinden eines Monitors die falsche Größe annahm.
      - Es wurde ein Problem behoben, bei dem ''mailto:''-Links ein unbenanntes Popup-Fenster offen ließen, anstatt das Popup-Fenster automatisch zu schließen.
      - Es wurde ein Problem behoben, bei dem das Fokussieren auf ein WebView2 Control in WinAppSDK mit der Windows-Einstellung ''Inaktive Fenster scrollen'' deaktiviert 
        zu einem Fehler beim Scrollen führte.
      - Blockiert edge://wallet in WebView2.
      - Die Umgebungsvariable für die Standard-Hintergrundfarbe in .NET WebView2 Controls wurde gelöscht, nachdem die Erstellung des Controllers abgeschlossen ist.
      - Aktivierte Unterstützung für Barrierefreiheit für WebView2 im visuellen Hosting-Modus.
      - Es wurde ein Fehler behoben, bei dem der Filter ''Web-Ressource angefordert'' für mehrere Quellen entfernt wurde, wenn eine der Quellen ein Dokument ist.
      - Regression behoben, bei der DataList in WinUI oder in anderen visuell gehosteten WebView2-Instanzen nicht sichtbar war.
      - Es wurde ein Problem mit dem Fokus des Download-Dialogs behoben, wenn die Tabulatortaste oder Umschalt+Tab gedrückt wurde, um in das Webview2-Steuerelement zu wechseln.
    - Nur SDK
      - Behebung eines Problems im SDK, das zu fehlerhaften <Plattform>-Werten in der Liste der .NET-Projektplattformen führte.
      - Hinzufügen der fehlenden WinRT CoreWebView2Notification.VibrationPattern API. Diese WinRT-API kann 
        mit der stabilen Benachrichtigungs-API kombiniert werden; siehe ''Web Notification'' und 
        NotificationReceived für WinRT, gleich oben.
      - Es wurde ein Problem behoben, bei dem KeyDown-Ereignisse vom WinForms WebView2-Steuerelement nicht die 
        korrekte ModifierKeys Informationen.
      - x86 für WinRT C# Projektion behoben.
      - CreateCoreWebView2Environment und GetAvailableCoreWebView2BrowserVersionString wurden 
        wurden robuster gegen potentielle Race Conditions während der Laufzeitaktualisierung gemacht.
      - x86 für WinRT C# Projektion korrigiert.
      - C# WinRT Projektion funktioniert jetzt auf UWP.
      - Ein Problem wurde behoben, um sicherzustellen, dass GeneratedFilesDir nicht mehr in Visual Studio für C# WinRT-Projektion angezeigt wird.
      - Eine SDK-Abhängigkeit für .NET-Projekte wurde behoben.
      - Ein Kompatibilitätsproblem beim Aufruf von GetAvailableBrowserVersionString() mit einer älteren WebView2Loader.dll wurde behoben.
      - Probleme bei der Kompilierung von wv2winrt-generiertem Code mit den Optionen cpp20 und /permissive- wurden behoben.
      - Das .NET 8 TargetFramework für C# WinRT wurde hinzugefügt, die AOT (ahead-of-time) Kompatibilität aktiviert und das 
        Laufzeit-Marshalling deaktiviert.
      - Eine SDK-Abhängigkeit für .NET-Projekte wurde behoben.
      - Arm64-Inkompatibilität mit WindowsAppSDK 1.6 behoben.
      - Die zusätzliche WebView2Loader.dll im WinAppSDK-Fall wurde entfernt.
      - Verwendung von CoreWebView2.AddWebResourceRequestedFilter ohne einen 
        CoreWebView2WebResourceRequestSourceKinds Parameter ist jetzt veraltet. 
        Siehe die .NET CoreWebView2.AddWebResourceRequestedFilter Methode.
      - Die Verwendung von CoreWebView2.AddWebResourceRequestedFilter ohne einen 
        CoreWebView2WebResourceRequestSourceKinds Parameter ist jetzt 
        veraltet. Siehe die .NET CoreWebView2.AddWebResourceRequestedFilter Methode.
      - Hinzufügen des .NET 8 TargetFrameworks für C# WinRT, Aktivieren der AOT (ahead-of-time) 
        Kompatibilität und deaktivierte das Runtime Marshalling. 
    - Promotions
      - Unterstützung für die Fluent Style Overlay Scrollbar.
      - Die WebMessageObjects API wurde aktualisiert, um das Einfügen von DOM-Objekten in WebView2-Inhalte zu ermöglichen, die über die App konstruiert werden, 
        und über die CoreWebView2.PostWebMessage API in die andere Richtung. Hinzufügen eines neuen Web-Objekt-Typs zur Darstellung eines 
        System-Handle zu repräsentieren, das an den Web-Content gepostet werden kann, um ihm den Zugriff auf das Dateisystem zu ermöglichen.
      - Es wurden SaveAs-APIs hinzugefügt, mit denen du den Vorgang ''Speichern unter'' programmatisch durchführen kannst. Du kannst diese APIs verwenden, um 
        das Standarddialogfeld ''Speichern unter'' blockieren und dann entweder im Hintergrund speichern oder eine eigene Benutzeroberfläche für ''Speichern unter'' erstellen. Diese APIs beziehen sich 
        Diese APIs beziehen sich nur auf das Dialogfeld ''Speichern unter'', nicht auf das Dialogfeld ''Herunterladen'', das weiterhin die vorhandenen Download-APIs verwendet.
      - Unterstützung für Web-Benachrichtigungen, für nicht-persistente Benachrichtigungen, wurde hinzugefügt. Das Ereignis NotificationReceived für 
        CoreWebView2 steuert die Behandlung von Web-Benachrichtigungen und ermöglicht die Anpassung oder Unterdrückung durch die Host-App. 
        Unbehandelte Benachrichtigungen werden standardmäßig in der WebView2 Benutzeroberfläche angezeigt.
      - Die WebMessageObjects API wurde aktualisiert, um das Einfügen von DOM Objekten in WebView2 Inhalte zu ermöglichen, die 
      - die über die App erstellt wurden, und über die CoreWebView2.PostWebMessage API in der anderen Richtung. 
      - Hinzufügen eines neuen Web-Objekt-Typs (CoreWebView2FileSystemHandle) zur Darstellung eines Dateisystem-Handles 
      - zu repräsentieren, das an den Web-Content gepostet werden kann, um ihm den Zugriff auf das Dateisystem zu ermöglichen.
      - Unterstützung für Web Notification, für nicht-persistente Benachrichtigungen, wurde hinzugefügt. 
        Das NotificationReceived-Ereignis für CoreWebView2 steuert die Behandlung von Web Notifications und ermöglicht 
        Anpassung oder Unterdrückung durch die Host-App. Unbehandelte Benachrichtigungen werden standardmäßig in der WebView2 Benutzeroberfläche angezeigt.
      - SaveAs APIs wurden hinzugefügt, die es erlauben, die Save as Operation programmatisch auszuführen. Du kannst 
       diese APIs verwenden, um den Standarddialog Speichern unter zu blockieren und dann entweder im Hintergrund zu speichern oder Ihre eigene 
        UI für Speichern unter. Diese APIs beziehen sich nur auf das Dialogfeld ''Speichern unter'', nicht auf das Dialogfeld ''Herunterladen'', das 
        der weiterhin die vorhandenen Download-APIs verwendet.
      - Ein neues ScreenCaptureStarting Ereignis wurde hinzugefügt. Dieses Ereignis wird ausgelöst, wenn das WebView2 
        und/oder iframe, der dem CoreWebView2Frame entspricht (oder einem seiner abhängigen iframes) 
        die Erlaubnis zur Verwendung der Screen Capture API anfordert, bevor die Benutzeroberfläche angezeigt wird. Die Anwendung kann dann 
        die Anzeige der UI blockieren oder die Anzeige der UI erlauben.
      - Ein neues SaveFileSecurityCheckStarting Ereignis wurde hinzugefügt. Ihre Anwendung kann einen Handler für dieses Ereignis registrieren 
        registrieren, um den Dateipfad, die Dateinamenerweiterung und die URI-Informationen zum Ursprung des Dokuments zu erhalten. Du kannst dann 
        eigene Regeln anwenden, um Aktionen wie die folgenden durchzuführen:
        - Erlauben das Speichern der Datei, ohne eine Standard-Sicherheitswarnung über die Dateityp-Richtlinie anzuzeigen.
        - Abbrechen des Speicherns.
        - Erstellen einer eigenen Benutzeroberfläche zur Verwaltung von Laufzeitrichtlinien für Dateitypen.
    - APIs
      - Ein neues SaveFileSecurityCheckStarting-Ereignis wurde hinzugefügt. Als Entwickler kannst du einen Handler für dieses Ereignis registrieren, um den Dateipfad, 
        Dateinamenerweiterung und URI-Informationen über den Ursprung des Dokuments abzurufen. Dann kannst du deine eigenen Regeln anwenden, um Aktionen wie die folgenden durchzuführen:
        - Erlauben das Speichern der Datei, ohne eine Standard-Sicherheitswarnung über die Dateityp-Richtlinie anzuzeigen.
        - Abbrechen des Speicherns.
        - Erstellen einer eigenen Benutzeroberfläche zur Verwaltung von Laufzeitrichtlinien für Dateitypen.
      - Hinzufügen eines neuen ScreenCaptureStarting-Ereignisses. Dieses Ereignis wird ausgelöst, wenn der WebView2 und/oder iframe, der dem 
        CoreWebView2Frame (oder einem seiner abhängigen iframes) die Erlaubnis zur Verwendung der Screen Capture API anfordert, bevor die UI 
        angezeigt wird. Als Entwickler kannst du dann wählen, ob du die Anzeige der Benutzeroberfläche blockieren oder zulassen möchtest, dass die Benutzeroberfläche angezeigt wird.
      - Hinzufügen einer neuen GetComICoreWebView2-Methode zur CoreWebView2 .NET-Klasse, mit der du eine 
        CoreWebView2 zwischen .NET und COM zu konvertieren kannst. Hinzufügen einer neuen WinRT-Schnittstelle, die die Konvertierung eines CoreWebView2 
        zwischen WinRT und COM zu konvertieren. Dies ermöglicht die Interoperabilität zwischen Bibliotheken, die in verschiedenen Sprachen geschrieben sind.
      - Neue Throttling Controls APIs wurden hinzugefügt, die eine effiziente Ressourcenverwaltung ermöglichen, indem sie die Drosselung von 
      - JavaScript-Zeitgeber. Dies ist hilfreich in Szenarien, in denen ein WebView2-Steuerelement sichtbar bleiben muss, aber weniger Ressourcen verbrauchen soll (z. B. wenn 
      - weniger Ressourcen verbrauchen soll (z.B. wenn der Benutzer nicht mit dem Inhalt interagiert). Diese Throttling Controls 
      - APIs ermöglichen es dir,:
        - Anpassen von Skript-Timern (setTimeout und setInterval), Drosselung bei verschiedenen Seitenstatus (Vordergrund, 
          Hintergrund und Hintergrund mit intensiver Drosselung).
        - Drosselung von Skript-Timern in ausgewählten gehosteten Iframes.
      - Hinzufügen eines neuen RestartRequested-Ereignisses. Das RestartRequested-Ereignis wird ausgelöst, wenn WebView2 
        neu starten muss, um Updates oder Konfigurationsänderungen anzuwenden. Sie können diese API verwenden, um zu erkennen, wann WebView2 
        neu gestartet werden muss, und entsprechende Maßnahmen ergreifen. Die Eigenschaft Priority des RestartRequested Ereignisses 
        Argumente gibt die Priorität der Neustartanforderung an:
        - Hoch bedeutet, dass die Anwendung den Benutzer auffordern soll, so schnell wie möglich neu zu starten.
        - Normal bedeutet, dass die Anwendung die Benutzer an den Neustart erinnern soll, und zwar nach bestem Bemühen.
  - Microsoft PKI Metadata version: 13.0.0.0 --> 14.0.0.1
  - Snapshots version: 126.0.2592.113 --> 129.0.2792.89
  - Subresource Filter version: 10.34.0.54 -->  10.34.0.55
  - trustToken version: 2024.8.165 --> 2024.10.1
  - System.Threading.Channels version: 7.0.0  --> 8.0.0
v2024.11.03
  - Aktualisierte Komponenten
    - Software-Update
      - BEHOBENE BUGS
        - Ein Bug wurde behoben, der dazu führte, dass trotz neuster Software-Version eine neue verfügbare Version gefunden wurde, wenn man 
          auf ''Nach Software-Updates suchen'' geklickt hat.
v2024.09.01
  - Erste Version von WebConnect"
            Terminate.Text = "Schließen"
        End If
        If Form1.Language = "en" Then
            Terminate.Text = "Exit"
            Me.Text = "Settings"
            DisplaySettings.Text = "Display Settings"
            Language.Text = "Language"
            DefaultSearchEngine.Text = "Default Search Engine"
            MagicAILinkButton.Text = "Magic AI Link"
            DefaultChatBot.Text = "Default AI Chatbot"
            SoftwareUpdate.Text = "Software update"
            VersionInfo.Text = "Current installed software version: "
            SearchForUpdatesOnApplicationBoot.Text = "Do always check automatically 
for software updates on 
application boot"
            Changelog.Text = "Changelog
v2025.02.25
- Updated Components
  - Frontend 3.1 --> 4.0
    - NEW FUNCTIONS:
      - Tabs
        - You can add new Tabs from the TabControl context menu
          - You have to:
            - Right-Click on a opened Tab
            - Select ''New Tab''
        - You can move the Tabs to left or right
          - You have to:
            - Right-Click on the focused tab or focus a tab that you want to move
            - Select ''Move to...''
            - Select ''...left'' or ''...right''
          - Or
            - Select ''Navigation''
            - Select ''Move to...''
            - Select ''...left'' or ''...right''
        - You can move the Tabs to a specific position
          - You have to:
            - Place your mouse pointer on the tab you want to move.
            - Hold the left mouse button down while moving it to the position that you want.
            - Leave the left mouse button and the tab will be moved to the position, where you leaved the left mouse button.
    - FIXED BUGS:
      - WebView
        - A bug has been fixed that the WebView is not showing correctly. This bug caused that some web contents aren't displayed.
      - MagicAI Link
        - A bug has been fixed that the MagicAI Link WebView isn't responding by pressing the MagicAI Link Button or ''CTRL * .'' This bug caused that you have to open the WebConnect settings that the MagicAI Link Window is responive.
  - hyphens-data-Version: 101.0.4906.0 --> 120.0.6050.0
  - Microsoft PKI Metadata-Version: 14.0.0.1 --> 21.0.0.0
  - Subresource Filter Version: 10.34.0.55 --> 10.34.0.57
  - trustToken-Version: 2024.10.11.1 --> 2024.12.14.1

v2025.02.16
- Updated Components
  - Frontend 3.0 --> 3.1
    - Settings
      - A bug has been fixed that caused that the user settings are deleted after an software update. Solution: The setting saver is saving the settings on the Windows Registry. Before this update, the settings has been saved in the program it self, which got overwritten by an software update.
    MagicAI Link	
      - A bug has been fixed that changing between different ChatBots is not working properly
      - A bug has been fixed that the MagicAI Window is displayed and the application size is changing, that the MagicAI Window size isn't applying for this
    - Commando interpreter
      - A bug has been fixed that the applicaion isn't rebooting, when the user is entering the following command to the textbox: ''cmd://reboot''
  - Bootloader 2.0 --> 2.1
    - New boot animation
    - Bootloader version is now displayed in the about dialog 
  - Edge WebView2 v131.0.2908.86 --> 133.0.3065.69
    - Promotions
      - Display WPF elements on the WebView2 level (WebView2CompositionControl)
      Prevents WebView2CompositionControl from being the top-level WebView2 control in a WPF app and obfuscating all WPF elements. Microsoft.Web.WebView2.Wpf.WebView2CompositionControl is a drop-in replacement for the default WPF WebView2 control. Both implement the WebView2 control as WebView2CompositionControl and the Microsoft.Web.WebView2.Wpf.IWebView2 interface. Both are derived from FrameworkElement as follows:

      FrameworkElement ->HwndHost ->WebView2.
      FrameworkElement ->Control ->WebView2CompositionControl.
      Background: If you create a Windows Presentation Foundation (WPF) app and use the WebView2 control, you may find that your app results in ''airspace'' issues where the WebView2 control is always displayed on top and all WPF elements in the same location are hidden, even if you try to specify the WPF elements that should be on top of the WebView2 control (using the visual structure order or z-index property, for example).

      This problem occurs because the WPF control uses the WPF HwndHost to host the Win32 WebView2 control and HwndHost has a problem with the airspace.

    - Fehlerbehebungen
      - Runtime-only
        - Fixed a regression where display changes could cause WebView2 to be rendered smaller than the app window.
        - The missing ''Close'' button has been added to the ''Download'' flyout.
        - Fixed a race condition that occurred when the Web Request Response event never occurs. 
      - SDK-only
        - Fixed an issue in WPF WebView2CompositionControl where it is not displayed when initialized with size (0,0), e.g. when initialized in a TabItem of TabControl.
  - System.Threading.Channels v9.0.0 --> v9.0.2		
  - Microsoft.Web.WebView2.Core v1.0.2903.40 --> v1.0.3065.39
  - Microsoft.Web.WebView2.WinForms v.1.0.2903.40 --> v1.0.3065.39
   - Microsoft.Web.WebView2.Wpf v1.0.2903.40 --> v1.0.3065.39
	
v2024.12.27
- Updated Components:
  - Frontend: v2.0 --> v3.0
    - NEW FUNCTIONS:
      - MAGIC AI LINK

        WHAT IS MAGIC AI LINK?
        WITH MAGIC AI LINK, YOU CAN EASILY AND FAST ACCESS YOUR PREFERED AI CHATBOT.
          THE CHATBOT WILL BE DOCKED AT THE RIGHT SIDE OF THE WINDOW, WHEN YOU OPEN IT.
             - A button has been added to toggle an AI chatbot
             - The hotkey ''CTRL + .'' does also toggle Magic AI Link
             - You can program this Button by going to WebConnect-->Settings-->Magic AI Link. Supported Chatbots: 
               - Google Gemini
               - Microsoft Copilot
               - ChatGPT
    - BUG FIXES
      - A bug has been fixed that the following hotkeys are not working in other apps, when WebConnect is running:
        - ALT + E
        - CTRL + D
        - CTRL + E
        - CTRL + K
        - CTRL + L
        - ALT + F
        - CTRL + N
        - CTRL + T
        - CTRL + W
        - ALT + S
        - CTRL + TAB
        - CTRL + SHIFT + TAB
      - A bug has been fixed that the button ''Close tab'' at the menu toolbar is not working
v2024.12.13
- A bug has been fixed that could cause the WebConnect Installer/Updater to be detected as malware
v2024.12.11
- Updated Components:
  - Frontend
    - A bug has been fixed when setup a password for the mdm (mobile device management) mode, because the password setup dialog does not show correctly.
     You can enable/disable the mdm (mobile device management) mode by clicking WebConnect/Settings/Software update/Click fast on the software version until a button ''WebConnect Admin Software'' appears.
     - A bug has been fixed when showing the WebConnect Admin Software, because the WebConnect Admin Software does not show correctly, when the tab ''designer values'' is opened.
     - A bug has been fixed when you press the ok button on a dialog that says that a link can't be opened.
     - A bug has been fixed when you reboot the application, the mdm (moblie device management) settings will be cleared.
     - A bug has been fixed when you open the browser settings, if you set the default search engine to Google, the default search engine will set to Bing.
     - A bug has been fixed when you close a tab, the WebView instance, that startet with the tab, is not terminated and it is running at background.
     - Adding hotkeys for quitting some menus
     - Adding hotkeys for browser navigation
     - A context menu has been added that can close tabs for devices without a middle mouse button
     - Better debug output for developers
  - Microsoft Edge WebView: 130.0.2849.39 --> 131.0.2903.86
     - Promotions
        - Control whether the screen capture UI is displayed (ScreenCaptureStarting event)
        - A new ScreenCaptureStarting event has been added. This event is triggered whenever 
          the webView2 and/or iframe corresponding to the CoreWebView2Frame (or one of its 
          successor iframes) requests permission to use the screen capture API before displaying 
          the UI. The app can then block the display of the UI or allow the display of the UI.
      - Bug fixes
        - Runtime only
          - Allow the Download dialog box to receive initial focus on startup.

v2024.11.07
- Updated Components:
  - Frontend
    - Adjustments to Error Messages while booting WebConnect when WebConnect system files 
      are missing or damaged
    - Correction of version indicators of various WebConnect components
    - Correction of the software version changelog
  - Microsoft Edge WebView: 130.0.1823.32 --> 130.0.849.56
    - Features
      - Introduced an option to cancel the initial navigation in WebView2, to improve startup performance. 
      - This change is disabled by default, and can be enabled by using the 
        msWebView2CancelInitialNavigation feature flag.
      - Introduced the feature flag msWebView2EnableDownloadContentInWebResourceResponseReceived, 
        an an Experimental feature (rather than as a Stable feature). When this flag is enabled, this allows responses 
        of navigations that become downloads to be available in WebResourceResponseReceived.
      - Added support for C#/WinRT .NET 6+.
    - Runtime and SDK
      - Fixed a crash when .NET host object async methods return a null result
      - Re-enabled the default behavior of SetUserAgent: by default, SetUserAgent is effective for cross-origin iframes.
    - Runtime-only
      - Fixed a WebView2 memory leak issue when the window is closed.
      - Fixed an issue where ignoreMemberNotFoundError wasn't working for .NET objects
      - Now returns a proper error code when CreateSharedBuffer is called with 0 buffer size. 
      - Fixed an activation issue for the caret browsing dialog.
      - Fixed an issue where the WebView2 Visual Hosting CursorChanged event wasn't firing for custom cursors.
      - Fixed a bug where if the LaunchingExternalURIScheme event handler is attached, 
        and the always remember checkbox is enabled, and the user selects this checkbox, the dialog is incorrectly displayed again.
      - Fixed an issue where text edit controls in visual hosting would duplicate IME input when losing and then regaining focus.
      - Fixed an issue where full-trust UWP apps couldn't display owned windows.
      - Fixed a bug in owned-window activation logic for visual hosting.
      - Disabled BreakoutBoxPreferCaptureTimestampInVideoFrame for WebView2 TextureStream.
      - Fixed a regression where the WindowCloseRequested event only fires for first window.close() call.
      - Fixed a regression where typed arrays in WinRT JavaScript projection could not be handled as IDispatch in the host.
      ­- Fixed a bug where the autofill popup dismisses immediately and causes a focus change.
      - Fixed a bug where WebView2 fails to load because of AppPolicyGetWindowingModel.
      - Fixed an issue where the app window couldn't be controlled via system commands 
        (such as Alt+F4 or Alt+Spacebar) when the focus was in WebView2 for Visual hosting mode.
      - Fixed a bug in WebView2 UWP where the Find bar couldn't be clicked into from the host app.
      - Fixed a regression where WebResourceRequested events crash on certain sites.
      - Enabled the interactive dragging feature by default. See edge-webview-interactive-dragging in WebView2 browser flags.
      - Disabled IsolateSandboxedIframes for WebView2.
      - Fixed an issue where WebView creation fails when multiple instances are launched at the same time.
      - Fixed a bug in WinRT JavaScript projection where caching existing properties in objects whose name 
        contains Proxy or Function caused an error due to name collision.
      - Fixed a bug where the WebView2 control became the wrong size after disconnecting and reconnecting a monitor.
      - Fixed an issue where ''mailto:'' links leave an untitled popup window open, instead of automatically closing the popup window.
      - Fixed an issue where focusing on a WebView2 control in WinAppSDK with the Windows ''Scroll inactive windows'' setting disabled 
        caused scrolling to fail.
      - Blocked edge://wallet in WebView2.
      - Cleared the environment variable for default background color in .NET WebView2 controls after the controller has finished creation.
      - Enabled accessibility support for Webview2 in visual hosting mode.
      - Fixed a bug with removing a ''web resource requested'' filter for multiple sources when one of them is Document.
      - Fixed a regression where DataList was not visible in WinUI or in other visually hosted WebView2 instances.
      - Fixed a Download dialog focus issue when pressing Tab or Shift+Tab to switch into the Webview2 control.
    - SDK-only
      - Fixed an issue in the SDK causing erroneous <Platform> values in the .NET project platforms list.
      - Adding the missing WinRT CoreWebView2Notification.VibrationPattern API. This WinRT API can 
        be combined with the stable notification API promotion release notes; see ''Web Notification'' and 
        NotificationReceived for WinRT, immediately above.
      - Fixed an issue where KeyDown events from the WinForms WebView2 control didn't include the 
        correct ModifierKeys information.
      - Fixed x86 for WinRT C# projection.
      - Made CreateCoreWebView2Environment and GetAvailableCoreWebView2BrowserVersionString 
        more robust against potential race condition during Runtime update.
      - Fixed x86 for WinRT C# projection.
      - C# WinRT projection now works on UWP.
      - Fixed an issue to ensure that GeneratedFilesDir no longer appears in Visual Studio for C# WinRT projection.
      - Fixed an SDK dependency for .NET projects.
      - Fixed a compatibility issue when calling GetAvailableBrowserVersionString() with an older WebView2Loader.dll.
      - Fixed issues when compiling wv2winrt-generated code with the cpp20 and /permissive- options.
      - Added the .NET 8 TargetFramework for C# WinRT, enabled AOT (ahead-of-time) compatibility, and disabled 
        runtime marshalling.
      - Fixed an SDK dependency for .NET projects.
      - Fixed Arm64 incompatibility with WindowsAppSDK 1.6.
      - Removed extra WebView2Loader.dll in WinAppSDK case.
      - Using CoreWebView2.AddWebResourceRequestedFilter without a 
        CoreWebView2WebResourceRequestSourceKinds parameter is now deprecated. 
        See the .NET CoreWebView2.AddWebResourceRequestedFilter Method.
      - Using CoreWebView2.AddWebResourceRequestedFilter without a 
        CoreWebView2WebResourceRequestSourceKinds parameter is now 
        deprecated. See the .NET CoreWebView2.AddWebResourceRequestedFilter Method.
      - Added the .NET 8 TargetFramework for C# WinRT, enabled AOT (ahead-of-time) 
        compatibility, and disabled runtime marshalling.
    - Promotions
      - Support for the Fluent Style Overlay Scrollbar.
      - Updated the WebMessageObjects API to allow injecting DOM objects into WebView2 content that's constructed via the app, 
        and via the CoreWebView2.PostWebMessage API in the other direction. Added a new web object type to represent a file 
        system handle that can be posted to the web content to provide it with filesystem access.
      - Added SaveAs APIs that allow you to programmatically perform the Save as operation. You can use these APIs to 
        block the default Save as dialog, and then either save silently, or build your own UI for Save as. These APIs pertain 
        only to the Save as dialog, not the Download dialog, which continues to use the existing Download APIs.
      - Added support for Web Notification, for non-persistent notifications. The NotificationReceived event for 
        CoreWebView2 controls web notification handling, allowing customization or suppression by the host app. 
        Unhandled notifications default to WebView2's UI.
      - Updated the WebMessageObjects API to allow injecting DOM objects into WebView2 content that's 
      - constructed via the app, and via the CoreWebView2.PostWebMessage API in the other direction. 
      - Added a new web object type (CoreWebView2FileSystemHandle) to represent a file system handle 
      - that can be posted to the web content to provide it with filesystem access.
      - Added support for Web Notification, for non-persistent notifications. 
        The NotificationReceived event for CoreWebView2 controls web notification handling, allowing 
        customization or suppression by the host app. Unhandled notifications default to WebView2's UI.
      - Added SaveAs APIs that allow you to programmatically perform the Save as operation. You can 
        use these APIs to block the default Save as dialog, and then either save silently, or build your own 
        UI for Save as. These APIs pertain only to the Save as dialog, not the Download dialog, which 
        continues to use the existing Download APIs.
      - Added a new ScreenCaptureStarting event. This event is raised whenever the WebView2 
        and/or iframe that corresponds to the CoreWebView2Frame (or to any of its descendant iframes) 
        requests permission to use the Screen Capture API before the UI is shown. The app can then 
        block the UI from being displayed, or allow the UI to be displayed.
      - Added a new SaveFileSecurityCheckStarting event. Your app can register a handler on this event 
        to get the file path, filename extension, and document origin URI information. You can then 
        apply your own rules to do actions such as the following:
        - Allow saving the file without presenting a default security-warning UI about the file-type policy.
        - Cancel the saving.
        - Create your own UI to manage runtime file-type policies.
    - APIs
      - Added a new SaveFileSecurityCheckStarting event. As a developer, you can register a handler on this event to get the file path, 
        filename extension, and document origin URI information. Then you can apply your own rules to do actions such as the following:
        - Allow saving the file without presenting a default security-warning UI about the file-type policy.
        - Cancel the saving.
        - Create your own UI to manage runtime file-type policies.
      - Added a new ScreenCaptureStarting event. This event is raised whenever the WebView2 and/or iframe that corresponds to the 
        CoreWebView2Frame (or to any of its descendant iframes) requests permission to use the Screen Capture API before the UI is 
        shown. As a developer, you can then choose to block the UI from being displayed, or allow the UI to be displayed.
      - Added a new GetComICoreWebView2 method to the CoreWebView2 .NET class that enables you to convert a 
        CoreWebView2 between .NET and COM. Added a new WinRT interface that enables you to convert a CoreWebView2 
        between WinRT and COM. This allows you to interoperate between libraries that are written in different languages.
      - Added new Throttling Controls APIs which allows for efficient resource management by allowing you to throttle 
      - JavaScript timers. This is helpful in scenarios where a WebView2 control needs to remain visible, but needs to 
      - consume fewer resources (such as when the user isn't interacting with the content). These Throttling Controls 
      - APIs allow you to:
        - Customize script timers (setTimeout and setInterval) throttling under different page states (foreground, 
          background, and background with intensive throttling).
        - Throttle script timers in select hosted iframes.
      - Added a new RestartRequested event. The RestartRequested event is raised whenever WebView2 needs 
        to restart to apply updates or configuration changes. You can use this API to detect when WebView2 
        needs to restart, and take appropriate actions. The Priority property of the RestartRequested event 
        arguments indicates the priority of the restart request:
        - High indicates that the app should prompt users to restart as soon as possible.
        - Normal indicates that the app should remind users to restart, on a best-effort basis.
  - Microsoft PKI Metadata version: 13.0.0.0 --> 14.0.0.1
  - Snapshots version: 126.0.2592.113 --> 129.0.2792.89
  - Subresource Filter version: 10.34.0.54 -->  10.34.0.55
  - trustToken version: 2024.8.165 --> 2024.10.1
  - System.Threading.Channels version: 7.0.0  --> 8.0.0
v2024.11.03
- Frontend
  - A bug with the software update tool has been fixed: 
    When you click ''Search for software updates'', it says ''Update for WebConnect available and ready to download,
    but the newest version is already installed on your device.''

v. 2024.09.01
- First software version"
            SearchForSoftwareUpdate.Text = "Search for software updates"


        End If
        If Form1.Language = "es" Then
            Terminate.Text = "Salir"
            Me.Text = "Ajustes"
            DisplaySettings.Text = "Ajustes de pantalla"
            Language.Text = "Idioma"
            DefaultSearchEngine.Text = "Motor de búsqueda predeterminado"
            MagicAILinkButton.Text = "Magic AI Link"
            DefaultChatBot.Text = "Chatbot AI predeterminado"
            SoftwareUpdate.Text = "Actualización del software"
            VersionInfo.Text = "Versión actual del software 
instalado: "
            SearchForUpdatesOnApplicationBoot.Text = "Compruebe siempre 
automáticamente 
actualizaciones 
de software al arranque 
de la aplicación"
            Changelog.Text = "Changelog
Algunos elementos de este texto han sido traducidos automáticamente.
v2025.02.25
- Componentes actualizados
  - Frontend 3.1 --> 4.0
    - NUEVAS FUNCIONES:
      - Pestañas
        - Puede añadir nuevas pestañas desde el menú contextual TabControl
          - Tienes que
            - Hacer clic con el botón derecho en una pestaña abierta
            - Seleccionar «Nueva Pestaña».
        - Puedes mover las Pestañas a la izquierda o a la derecha
          - Tienes que
            - Hacer clic con el botón derecho en la pestaña enfocada o enfocar una pestaña que quieras mover
            - Seleccionar «Mover a...».
            - Seleccionar «...izquierda» o «...derecha».
          - O bien
            - Seleccionar «Navegación».
            - Seleccione «Mover a...»
            - Seleccione «...izquierda» o «...derecha».
        - Puede mover las pestañas a una posición específica
          - Tiene que
            - Colocar el puntero del ratón sobre la pestaña que desea mover.
            - Mantén pulsado el botón izquierdo del ratón mientras la mueves a la posición que desees.
            - Suelta el botón izquierdo del ratón y la pestaña se moverá a la posición, donde dejaste el botón izquierdo del ratón.
    - ERRORES CORREGIDOS:
      - Vista Web
        - Se ha corregido un error por el que la Vista Web no se mostraba correctamente. Este error provocaba que algunos contenidos web no se mostraran.
      - Enlace MagicAI
        - Se ha corregido un error por el que la MagicAI Link WebView no respondía al pulsar el botón MagicAI Link o «CTRL * .». Este error causó que usted tiene que abrir la configuración de WebConnect que la Ventana MagicAI Link es responive.
  - hyphens-data-Version: 101.0.4906.0 --> 120.0.6050.0
  - Microsoft PKI Metadata-Versión: 14.0.0.1 --> 21.0.0.0
  - Versión del filtro de recursos secundarios: 10.34.0.55 --> 10.34.0.57
  - Versión de trustToken: 2024.10.11.1 --> 2024.12.14.1
v2025.02.16
- Componentes actualizados
  - Frontend 3.0 --> 3.1
    - Ajustes
      - Se ha corregido un error que provocaba que los ajustes del usuario se borraran tras una actualización de software. Solución: El protector de ajustes guarda los ajustes en el Registro de Windows. Antes de esta actualización, los ajustes se guardaban en el propio programa, que se sobrescribía con una actualización de software.
    Enlace MagicAI	
      - Se ha corregido un error por el que el cambio entre diferentes ChatBots no funcionaba correctamente.
      - Se ha corregido un error que la ventana MagicAI se muestra y el tamaño de la aplicación está cambiando, que el tamaño de la ventana MagicAI no está aplicando para este
    - Comando intérprete
      - Se ha corregido un error por el que la aplicación no se reiniciaba cuando el usuario introducía el siguiente comando en el cuadro de texto: «cmd://reboot»
  - Cargador de arranque 2.0 --> 2.1
    - Nueva animación de arranque
    - La versión del cargador de arranque se muestra ahora en el diálogo «Acerca de». 
  - Edge WebView2 v131.0.2908.86 --> 133.0.3065.69
    - Promociones
      - Muestra elementos WPF en el nivel WebView2 (WebView2CompositionControl)
      Evita que WebView2CompositionControl sea el control WebView2 de nivel superior en una aplicación WPF y ofusca todos los elementos WPF. Microsoft.Web.WebView2.Wpf.WebView2CompositionControl es un sustituto directo del control WebView2 predeterminado de WPF. Ambos implementan el control WebView2 como WebView2CompositionControl y la interfaz Microsoft.Web.WebView2.Wpf.IWebView2. Ambos se derivan de FrameworkElement de la siguiente manera:

      FrameworkElement ->HwndHost ->WebView2.
      FrameworkElement ->Control ->WebView2CompositionControl.
      Antecedentes: Si crea una aplicación Windows Presentation Foundation (WPF) y utiliza el control WebView2, es posible que su aplicación presente problemas de «espacio aéreo» en los que el control WebView2 siempre se muestra en la parte superior y todos los elementos WPF de la misma ubicación se ocultan, incluso si intenta especificar los elementos WPF que deberían estar encima del control WebView2 (utilizando el orden de estructura visual o la propiedad z-index, por ejemplo).

      Este problema se produce porque el control WPF utiliza el HwndHost de WPF para alojar el control WebView2 de Win32 y HwndHost tiene un problema con el espacio aéreo.

    - Fehlerbehebungen
      - Sólo en tiempo de ejecución
        - Se ha corregido una regresión por la que los cambios de visualización podían provocar que WebView2 se mostrara más pequeña que la ventana de la aplicación.
        - Se ha añadido el botón «Cerrar» que faltaba en el menú desplegable «Descargar».
        - Se ha corregido una condición de carrera que se producía cuando nunca se producía el evento Web Request Response. 
      - Sólo SDK
        - Se ha corregido un problema en WPF WebView2CompositionControl donde no se muestra cuando se inicializa con tamaño (0,0), por ejemplo, cuando se inicializa en un TabItem de TabControl.
  - System.Threading.Channels v9.0.0 --> v9.0.2		
  - Microsoft.Web.WebView2.Core v1.0.2903.40 --> v1.0.3065.39
  - Microsoft.Web.WebView2.WinForms v.1.0.2903.40 --> v1.0.3065.39
   - Microsoft.Web.WebView2.Wpf v1.0.2903.40 --> v1.0.3065.39
v2024.12.27
- Componentes actualizados:
- Interfaz: v2.0 --> v3.0
- NUEVAS FUNCIONES:
- MAGIC AI LINK

¿QUÉ ES MAGIC AI LINK?
CON MAGIC AI LINK, PUEDES ACCEDER FÁCIL Y RÁPIDAMENTE A TU CHATBOT DE IA PREFERIDO.
EL CHATBOT SE ACOPLARA A LA DERECHA DE LA VENTANA AL ABRIRLA.
- Se ha añadido un botón para activar y desactivar un chatbot de IA.
- La tecla de acceso rápido ''CTRL + .'' también activa y desactiva Magic AI Link.
- Puedes programar este botón en WebConnect-->Configuración-->Magic AI Link. Chatbots compatibles:
- Google Gemini
- Microsoft Copilot
- ChatGPT
- CORRECCIÓN DE ERRORES
- Se ha corregido un error que impedía el funcionamiento de las siguientes teclas de acceso rápido en otras aplicaciones cuando WebConnect se estaba ejecutando:
- ALT + E
- CTRL + D
- CTRL + E
- CTRL + K
- CTRL + L
- ALT + F
- CTRL + N
- CTRL + T
- CTRL + W
- ALT + S
- CTRL + TAB
- CTRL + MAYÚS + TAB
- Se ha corregido un error que impedía el funcionamiento del botón ''Cerrar pestaña'' en la barra de herramientas del menú.
v2024.12.13
- Se ha corregido un error que podía provocar que el instalador/actualizador de WebConnect se detectara como malware.
v2024.12.11
- Componentes actualizados:
- Interfaz
- Se ha corregido un error que impedía que el cuadro de diálogo de configuración de contraseña se mostrara correctamente al configurar una contraseña para el modo mdm (administración de dispositivos móviles). Puede habilitar o deshabilitar el modo mdm (administración de dispositivos móviles) haciendo clic en WebConnect/Configuración/Actualización de software. Haga clic rápidamente en la versión del software hasta que aparezca el botón ''Software de administración de WebConnect''.
- Se ha corregido un error que se producía al mostrar el software de administración de WebConnect, ya que no se mostraba correctamente al abrir la pestaña ''Valores del diseñado''.
- Se ha corregido un error que se producía al pulsar el botón Aceptar en un cuadro de diálogo que indicaba que no se podía abrir un enlace.
- Se ha corregido un error que se producía al reiniciar la aplicación: la configuración de mdm (administración de dispositivos móviles) se borraba.
- Se ha corregido un error que se producía al abrir la configuración del navegador: si se configuraba Google como motor de búsqueda predeterminado, este se configuraba como Bing.
- Se ha corregido un error que se producía al cerrar una pestaña: la instancia de WebView que se iniciaba con ella no se finalizaba y se ejecutaba en segundo plano. - Se han añadido atajos de teclado para salir de algunos menús.
- Se han añadido atajos de teclado para la navegación en el navegador.
- Se ha añadido un menú contextual que permite cerrar pestañas en dispositivos sin botón central del ratón.
- Mejores resultados de depuración para desarrolladores.
- Microsoft Edge WebView: 130.0.2849.39 --> 131.0.2903.86.
- Promociones.
- Se ha controlado si se muestra la interfaz de captura de pantalla (evento ScreenCaptureStarting).
- Se ha añadido un nuevo evento ScreenCaptureStarting. Este evento se activa siempre que la vista web2 o el iframe correspondiente a CoreWebView2Frame (o uno de sus iframes sucesores) solicita permiso para usar la API de captura de pantalla antes de mostrar la interfaz de usuario. La aplicación puede entonces bloquear o permitir la visualización de la interfaz de usuario.
- Corrección de errores.
- Solo en tiempo de ejecución.
- Permitir que el cuadro de diálogo de descarga reciba el foco inicial al iniciar.
v2024.11.07
- Componentes actualizados:
- Interfaz
- Ajustes en los mensajes de error al iniciar WebConnect cuando faltan archivos del sistema o están dañados
- Corrección de los indicadores de versión de varios componentes de WebConnect
- Corrección del registro de cambios de la versión del software
- Microsoft Edge WebView: 130.0.1823.32 --> 130.0.849.56
- Características
- Se introdujo una opción para cancelar la navegación inicial en WebView2 y mejorar el rendimiento al iniciar.
- Este cambio está deshabilitado de forma predeterminada y se puede habilitar mediante el indicador msWebView2CancelInitialNavigation.
- Se introdujo el indicador msWebView2EnableDownloadContentInWebResourceResponseReceived, una función experimental (en lugar de estable). Al habilitar este indicador, las respuestas de las navegaciones que se convierten en descargas están disponibles en WebResourceResponseReceived.
- Se agregó compatibilidad con C#/WinRT .NET 6+.
- Tiempo de ejecución y SDK
- Se solucionó un fallo que ocurría cuando los métodos asíncronos del objeto host .NET devolvían un resultado nulo.
- Se reactivó el comportamiento predeterminado de SetUserAgent: de forma predeterminada, SetUserAgent funciona con iframes de origen cruzado.
- Solo en tiempo de ejecución
- Se solucionó un problema de pérdida de memoria en WebView2 al cerrar la ventana.
- Se solucionó un problema por el cual ignoreMemberNotFoundError no funcionaba con objetos .NET.
- Ahora devuelve un código de error correcto al llamar a CreateSharedBuffer con un tamaño de búfer de 0.
- Se solucionó un problema de activación del cuadro de diálogo de navegación con cursor.
- Se solucionó un problema por el cual el evento CursorChanged de WebView2 Visual Hosting no se activaba con cursores personalizados.
- Se solucionó un error por el cual, si se adjuntaba el controlador de eventos LaunchingExternalURIScheme y la casilla de verificación ''Recordar siempre'' estaba habilitada, y el usuario seleccionaba esta casilla, el cuadro de diálogo se volvía a mostrar incorrectamente.
- Se solucionó un problema por el cual los controles de edición de texto en el alojamiento visual duplicaban la entrada del IME al perder y recuperar el foco.
- Se solucionó un problema por el cual las aplicaciones UWP de plena confianza no podían mostrar ventanas propias.
- Se solucionó un error en la lógica de activación de ventanas propias para el alojamiento visual. - Se desactivó BreakoutBoxPreferCaptureTimestampInVideoFrame para WebView2 TextureStream.
- Se corrigió una regresión donde el evento WindowCloseRequested solo se activaba en la primera llamada a window.close().
- Se corrigió una regresión donde las matrices tipificadas en la proyección de JavaScript de WinRT no se podían gestionar como IDispatch en el host.
- Se corrigió un error donde la ventana emergente de autocompletar se cerraba inmediatamente y provocaba un cambio de foco.
- Se corrigió un error donde WebView2 no se cargaba debido a AppPolicyGetWindowingModel.
- Se corrigió un problema donde la ventana de la aplicación no se podía controlar mediante comandos del sistema (como Alt+F4 o Alt+Barra espaciadora) cuando el foco estaba en WebView2 para el modo de alojamiento visual.
- Se corrigió un error en WebView2 UWP donde no se podía hacer clic en la barra de búsqueda desde la aplicación host.
- Se corrigió una regresión donde los eventos WebResourceRequested fallaban en ciertos sitios. - Se habilitó la función de arrastre interactivo por defecto. Consulte edge-webview-interactive-dragging en las banderas del navegador WebView2.
- Se desactivó IsolateSandboxedIframes para WebView2.
- Se solucionó un problema por el cual la creación de WebView fallaba al iniciar varias instancias simultáneamente.
- Se solucionó un error en la proyección de JavaScript de WinRT donde el almacenamiento en caché de propiedades existentes en objetos cuyo nombre contiene Proxy o Función causaba un error debido a una colisión de nombres.
- Se solucionó un error por el cual el control WebView2 adquiría un tamaño incorrecto después de desconectar y volver a conectar un monitor.
- Se solucionó un problema por el cual los enlaces ''mailto:'' dejaban abierta una ventana emergente sin título, en lugar de cerrarla automáticamente.
- Se solucionó un problema por el cual al enfocar un control WebView2 en WinAppSDK con la opción ''Desplazar ventanas inactivas'' de Windows deshabilitada, el desplazamiento fallaba.
- Se bloqueó edge://wallet en WebView2. - Se borró la variable de entorno del color de fondo predeterminado en los controles .NET WebView2 una vez finalizada la creación del controlador.
- Se habilitó la compatibilidad con la accesibilidad para WebView2 en modo de alojamiento visual.
- Se corrigió un error al eliminar el filtro ''recurso web solicitado'' para múltiples fuentes cuando una de ellas era un documento.
- Se corrigió una regresión donde DataList no era visible en WinUI ni en otras instancias de WebView2 alojadas visualmente.
- Se corrigió un problema con el foco del cuadro de diálogo de descarga al presionar Tab o Mayús+Tab para cambiar al control WebView2."
            SearchForSoftwareUpdate.Text = "Buscar actualizaciones de software"


        End If

        If Form1.Language = "fr" Then
            Terminate.Text = "Fermer"
            Me.Text = "Paramètres"
            DisplaySettings.Text = "Paramètres d'affichage"
            Language.Text = "Langue"
            DefaultSearchEngine.Text = "Moteur de recherche par défaut"
            MagicAILinkButton.Text = "Magic AI Link"
            DefaultChatBot.Text = "Chatbot IA par défaut"
            SoftwareUpdate.Text = "Mise à jour du logiciel"
            VersionInfo.Text = "Version actuelle du logiciel installé: "
            SearchForUpdatesOnApplicationBoot.Text = "Vérifiez toujours 
automatiquement les 
mises à jour 
logicielles au 
démarrage de 
l'application.
"
            Changelog.Text = "Changelog:
Certains éléments de ce texte ont été traduits automatiquement.
v2025.02.25
- Composants mis à jour
- Frontend 3.1 --> 4.0
- NOUVELLES FONCTIONS :
- Onglets
- Vous pouvez ajouter de nouveaux onglets depuis le menu contextuel de TabControl.
- Pour ce faire :
- Cliquez avec le bouton droit sur un onglet ouvert
- Sélectionnez « Nouvel onglet »
- Vous pouvez déplacer les onglets vers la gauche ou la droite.
- Pour ce faire :
- Cliquez avec le bouton droit sur l'onglet sélectionné ou sélectionnez l'onglet que vous souhaitez déplacer.
- Sélectionnez « Déplacer vers… »
- Sélectionnez « à gauche » ou « à droite »
- Ou
- Sélectionnez « Navigation »
- Sélectionnez « Déplacer vers… »
- Sélectionnez « à gauche » ou « à droite »
- Vous pouvez déplacer les onglets vers une position spécifique.
- Pour ce faire :
- Placez le pointeur de la souris sur l'onglet à déplacer.
- Maintenez le bouton gauche de la souris enfoncé tout en le déplaçant vers la position souhaitée.
- Relâchez le bouton gauche de la souris et l'onglet sera déplacé à l'endroit où vous avez appuyé sur le bouton gauche.
- BOGUES CORRIGÉS :
- Vue Web
- Un bug a été corrigé : la vue Web ne s'affichait pas correctement. Ce bug empêchait l'affichage de certains contenus web.
- Lien MagicAI
- Un bug a été corrigé : la vue Web de MagicAI Link ne répondait pas lorsque vous appuyez sur le bouton Lien MagicAI ou sur « Ctrl * ». Ce bug nécessitait l'ouverture des paramètres WebConnect pour que la fenêtre de MagicAI Link soit réactive.
- Version des données hyphens : 101.0.4906.0 --> 120.0.6050.0
- Version des métadonnées Microsoft PKI : 14.0.0.1 --> 21.0.0.0
- Version du filtre de sous-ressources : 10.34.0.55 --> 10.34.0.57
- Version du jeton de confiance : 2024.10.11.1 --> 2024.12.14.1
v2025.02.16
- Composants mis à jour
- Frontend 3.0 --> 3.1
- Paramètres
- Un bug entraînant la suppression des paramètres utilisateur après une mise à jour logicielle a été corrigé. Solution : L'économiseur de paramètres enregistre les paramètres dans le registre Windows. Avant cette mise à jour, les paramètres étaient enregistrés dans le programme lui-même, puis écrasés par une mise à jour logicielle. Lien MagicAI
- Correction d'un bug empêchant le passage d'un chatbot à un autre.
- Correction d'un bug empêchant l'affichage de la fenêtre MagicAI et la taille de l'application, qui ne s'appliquait pas à ce problème.
- Interpréteur Commando
- Correction d'un bug empêchant le redémarrage de l'application lorsque l'utilisateur saisit la commande « cmd://reboot » dans la zone de texte.
- Bootloader 2.0 --> 2.1
- Nouvelle animation de démarrage
- La version du bootloader est désormais affichée dans la boîte de dialogue « À propos ».
- Edge WebView2 v131.0.2908.86 --> 133.0.3065.69
- Promotions
- Affichage des éléments WPF au niveau WebView2 (WebView2CompositionControl).
Empêche WebView2CompositionControl d'être le contrôle WebView2 de niveau supérieur dans une application WPF et d'obscurcir tous les éléments WPF. Microsoft.Web.WebView2.Wpf.WebView2CompositionControl remplace le contrôle WPF WebView2 par défaut. Tous deux implémentent le contrôle WebView2 en tant que WebView2CompositionControl et l'interface Microsoft.Web.WebView2.Wpf.IWebView2. Ils sont dérivés de FrameworkElement comme suit :

FrameworkElement ->HwndHost ->WebView2.
FrameworkElement ->Control ->WebView2CompositionControl.
Contexte : Si vous créez une application Windows Presentation Foundation (WPF) et utilisez le contrôle WebView2, vous risquez de rencontrer des problèmes d'espacement : le contrôle WebView2 est toujours affiché au premier plan et tous les éléments WPF situés au même emplacement sont masqués, même si vous spécifiez les éléments WPF qui doivent être au premier plan du contrôle WebView2 (à l'aide de l'ordre de la structure visuelle ou de la propriété z-index, par exemple).

Ce problème survient car le contrôle WPF utilise le HwndHost WPF pour héberger le contrôle Win32 WebView2, et ce dernier rencontre un problème avec l'espace aérien.

- Correction d'erreurs
- Exécution uniquement
- Correction d'une régression où les modifications d'affichage pouvaient entraîner un affichage de WebView2 plus petit que la fenêtre de l'application.
- Le bouton « Fermer » manquant a été ajouté au menu déroulant « Télécharger ».
- Correction d'une situation de concurrence qui se produisait lorsque l'événement de réponse à la requête Web ne se produisait jamais.
- SDK uniquement
- Correction d'un problème dans WPF WebView2CompositionControl : il ne s'affichait pas lorsqu'il était initialisé avec une taille (0,0), par exemple lorsqu'il était initialisé dans un TabItem de TabControl. - System.Threading.Channels v9.0.0 --> v9.0.2
- Microsoft.Web.WebView2.Core v1.0.2903.40 --> v1.0.3065.39
- Microsoft.Web.WebView2.WinForms v.1.0.2903.40 --> v1.0.3065.39
- Microsoft.Web.WebView2.Wpf v1.0.2903.40 --> v1.0.3065.39
v2024.12.27
- Composants mis à jour :
- Interface utilisateur : v2.0 --> v3.0
- NOUVELLES FONCTIONS :
- MAGIC AI LINK

QU'EST-CE QUE MAGIC AI LINK ?
AVEC MAGIC AI LINK, ACCÉDEZ FACILEMENT ET RAPIDEMENT À VOTRE CHATBOT IA PRÉFÉRÉ.
LE CHATBOT SERA ANCRÉ À DROITE DE LA FENÊTRE À L'OUVERTURE.
- Un bouton a été ajouté pour activer/désactiver un chatbot IA.
- Le raccourci clavier « CTRL + » active également Magic AI Link.
- Vous pouvez programmer ce bouton en allant dans WebConnect-->Paramètres-->Magic AI Link. Chatbots pris en charge :
- Google Gemini
- Microsoft Copilot
- ChatGPT
- CORRECTIONS DE BUGS
- Un bug a été corrigé : les raccourcis clavier suivants ne fonctionnent pas dans d’autres applications lorsque WebConnect est en cours d’exécution :
- ALT + E
- CTRL + D
- CTRL + E
- CTRL + K
- CTRL + L
- ALT + F
- CTRL + N
- CTRL + T
- CTRL + W
- ALT + S
- CTRL + TAB
- CTRL + MAJ + TAB
- Un bug a été corrigé : le bouton « Fermer l’onglet » de la barre d’outils du menu ne fonctionne pas.
v2024.12.13
- Un bug a été corrigé : le programme d’installation/de mise à jour de WebConnect pouvait être détecté comme un logiciel malveillant.
v2024.12.11
- Composants mis à jour :
- Interface utilisateur
- Un bug a été corrigé lors de la configuration d’un mot de passe pour le mode MDM (gestion des appareils mobiles), car la boîte de dialogue de configuration du mot de passe ne s’affiche pas correctement. Vous pouvez activer/désactiver le mode MDM (gestion des appareils mobiles) en cliquant sur WebConnect/Paramètres/Mise à jour logicielle/Cliquez rapidement sur la version du logiciel jusqu'à ce que le bouton « Logiciel d'administration WebConnect » apparaisse.
- Un bug a été corrigé lors de l'affichage du logiciel d'administration WebConnect : il ne s'affichait pas correctement à l'ouverture de l'onglet « Valeurs du concepteur ».
- Un bug a été corrigé lorsque vous appuyiez sur le bouton OK d'une boîte de dialogue indiquant qu'un lien ne pouvait pas être ouvert.
- Un bug a été corrigé lors du redémarrage de l'application : les paramètres MDM (gestion des appareils mobiles) étaient effacés.
- Un bug a été corrigé lors de l'ouverture des paramètres du navigateur : si vous définissiez Google comme moteur de recherche par défaut, ce dernier serait défini sur Bing.
- Un bug a été corrigé lors de la fermeture d'un onglet : l'instance WebView, qui démarrait avec l'onglet, n'était pas arrêtée et s'exécutait en arrière-plan. - Ajout de raccourcis clavier pour quitter certains menus
- Ajout de raccourcis clavier pour la navigation dans le navigateur
- Un menu contextuel a été ajouté pour fermer les onglets sur les appareils sans bouton central de la souris
- Amélioration du débogage pour les développeurs
- Microsoft Edge WebView : 130.0.2849.39 --> 131.0.2903.86
- Promotions
- Contrôle de l'affichage de l'interface utilisateur de capture d'écran (événement ScreenCaptureStarting)
- Un nouvel événement ScreenCaptureStarting a été ajouté. Cet événement est déclenché lorsque la webView2 et/ou l'iframe correspondant à CoreWebView2Frame (ou l'un de ses iframes successeurs) demande l'autorisation d'utiliser l'API de capture d'écran avant d'afficher l'interface utilisateur. L'application peut alors bloquer ou autoriser l'affichage de l'interface utilisateur.
- Corrections de bugs
- Exécution uniquement
- Activer la boîte de dialogue de téléchargement au démarrage.
v2024.11.07
- Composants mis à jour :
- Interface utilisateur
- Ajustements des messages d'erreur au démarrage de WebConnect lorsque les fichiers système sont manquants ou endommagés
- Correction des indicateurs de version de divers composants WebConnect
- Correction du journal des modifications de version du logiciel
- Microsoft Edge WebView : 130.0.1823.32 --> 130.0.849.56
- Fonctionnalités
- Ajout d'une option permettant d'annuler la navigation initiale dans WebView2 afin d'améliorer les performances de démarrage.
- Cette modification est désactivée par défaut et peut être activée à l'aide de l'indicateur de fonctionnalité msWebView2CancelInitialNavigation.
- Ajout de l'indicateur de fonctionnalité msWebView2EnableDownloadContentInWebResourceResponseReceived, une fonctionnalité expérimentale (et non plus stable). L'activation de cet indicateur permet aux réponses des navigations converties en téléchargements d'être disponibles dans WebResourceResponseReceived.
- Ajout de la prise en charge de C#/WinRT .NET 6+.
- Runtime et SDK
- Correction d'un plantage lorsque les méthodes asynchrones des objets hôtes .NET renvoient un résultat nul
- Réactivation du comportement par défaut de SetUserAgent : par défaut, SetUserAgent est efficace pour les iframes multi-origines.
- Exécution uniquement
- Correction d'un problème de fuite de mémoire WebView2 à la fermeture de la fenêtre.
- Correction d'un problème où ignoreMemberNotFoundError ne fonctionnait pas pour les objets .NET.
- Renvoie désormais un code d'erreur correct lorsque CreateSharedBuffer est appelé avec une taille de tampon nulle.
- Correction d'un problème d'activation de la boîte de dialogue de navigation au curseur.
- Correction d'un problème où l'événement CursorChanged de WebView2 Visual Hosting ne se déclenchait pas pour les curseurs personnalisés.
- Correction d'un bug où, si le gestionnaire d'événements LaunchingExternalURIScheme était attaché et que la case « Toujours mémoriser » était cochée, et que l'utilisateur cochait cette case, la boîte de dialogue s'affichait à nouveau de manière incorrecte.
- Correction d'un problème où les contrôles d'édition de texte dans Visual Hosting dupliquaient la saisie IME lors de la perte puis de la récupération du focus.
- Correction d'un problème où les applications UWP de confiance totale ne pouvaient pas afficher les fenêtres possédées.
- Correction d'un bug dans la logique d'activation des fenêtres possédées pour Visual Hosting.
- Désactivation de BreakoutBoxPreferCaptureTimestampInVideoFrame pour WebView2 TextureStream.
- Correction d'une régression où l'événement WindowCloseRequested ne se déclenchait que lors du premier appel à window.close().
- Correction d'une régression où les tableaux typés dans la projection JavaScript WinRT ne pouvaient pas être traités comme IDispatch dans l'hôte.
- Correction d'un bug où la fenêtre contextuelle de remplissage automatique disparaissait immédiatement et provoquait un changement de focus.
- Correction d'un bug où WebView2 ne se chargeait pas à cause d'AppPolicyGetWindowingModel.
- Correction d'un problème où la fenêtre de l'application ne pouvait pas être contrôlée via des commandes système (telles que Alt+F4 ou Alt+Espace) lorsque le focus était sur WebView2 pour le mode d'hébergement Visuel.
- Correction d'un bug dans WebView2 UWP où il était impossible de cliquer sur la barre de recherche depuis l'application hôte.
- Correction d'une régression où les événements WebResourceRequested plantaient sur certains sites.
- Activation par défaut de la fonctionnalité de glissement interactif. Voir edge-webview-interactive-dragging dans les indicateurs de navigateur WebView2.
- Désactivation d'IsolateSandboxedIframes pour WebView2.
- Correction d'un problème d'échec de création de WebView lorsque plusieurs instances sont lancées simultanément.
- Correction d'un bug dans la projection JavaScript WinRT : la mise en cache des propriétés existantes dans les objets dont le nom contient Proxy ou Function provoquait une erreur due à une collision de noms.
- Correction d'un bug où la taille du contrôle WebView2 devenait incorrecte après la déconnexion et la reconnexion d'un moniteur.
- Correction d'un problème où les liens « mailto: » laissaient une fenêtre contextuelle sans titre ouverte, au lieu de la fermer automatiquement.
- Correction d'un problème où la sélection d'un contrôle WebView2 dans WinAppSDK avec le paramètre Windows « Défiler les fenêtres inactives » désactivé provoquait l'échec du défilement.
- Blocage de edge://wallet dans WebView2.
- Suppression de la variable d'environnement pour la couleur d'arrière-plan par défaut dans les contrôles .NET WebView2 une fois la création du contrôleur terminée. - Activation de la prise en charge de l'accessibilité pour Webview2 en mode d'hébergement visuel.
- Correction d'un bug entraînant la suppression du filtre « Ressource Web demandée » pour plusieurs sources lorsque l'une d'elles est un document.
- Correction d'une régression empêchant l'affichage de DataList dans WinUI ou dans d'autres instances WebView2 hébergées visuellement.
- Correction d'un problème de focus dans la boîte de dialogue de téléchargement lorsque l'on appuie sur Tab ou Maj+Tab pour accéder au contrôle Webview2.
- SDK uniquement
- Correction d'un problème dans le SDK provoquant des valeurs <Platform> erronées dans la liste des plateformes de projets .NET.
- Ajout de l'API WinRT CoreWebView2Notification.VibrationPattern manquante. Cette API WinRT peut être combinée avec les notes de publication de la promotion de l'API de notification stable ; voir « Notification Web » et NotificationReceived pour WinRT, ci-dessus.
- Correction d'un problème où les événements KeyDown du contrôle WinForms WebView2 n'incluaient pas les informations ModifierKeys correctes.
- Correction de x86 pour la projection C# WinRT.
- Amélioration de la résistance de CreateCoreWebView2Environment et GetAvailableCoreWebView2BrowserVersionString face aux conditions de concurrence potentielles lors de la mise à jour de l'environnement d'exécution.
- Correction de x86 pour la projection C# WinRT.
- La projection C# WinRT fonctionne désormais sur UWP.
- Correction d'un problème pour garantir que GeneratedFilesDir n'apparaît plus dans la projection Visual Studio pour C# WinRT.
- Correction d'une dépendance au SDK pour les projets .NET.
- Correction d'un problème de compatibilité lors de l'appel de GetAvailableBrowserVersionString() avec une ancienne version de WebView2Loader.dll.
- Correction de problèmes lors de la compilation du code généré par wv2winrt avec les options cpp20 et /permissive-.
- Ajout de .NET 8 TargetFramework pour C# WinRT, activation de la compatibilité AOT (ahead-of-time) et désactivation du marshaling d'exécution.
- Correction d'une dépendance au SDK pour les projets .NET.
- Correction de l'incompatibilité Arm64 avec WindowsAppSDK 1.6.
- Suppression de la version WebView2Loader.dll supplémentaire dans le cas de WinAppSDK.
- L'utilisation de CoreWebView2.AddWebResourceRequestedFilter sans paramètre CoreWebView2WebResourceRequestSourceKinds est désormais obsolète.
Voir la méthode .NET CoreWebView2.AddWebResourceRequestedFilter.
- L'utilisation de CoreWebView2.AddWebResourceRequestedFilter sans paramètre CoreWebView2WebResourceRequestSourceKinds est désormais obsolète.
Voir la méthode .NET CoreWebView2.AddWebResourceRequestedFilter.
- Ajout de .NET 8 TargetFramework pour C# WinRT, activation de la compatibilité AOT (en avance) et désactivation du marshaling d'exécution.
- Promotions
- Prise en charge de la barre de défilement Fluent Style Overlay.
- Mise à jour de l'API WebMessageObjects pour permettre l'injection d'objets DOM dans le contenu WebView2 créé via l'application, et via l'API CoreWebView2.PostWebMessage dans l'autre sens. Ajout d'un nouveau type d'objet web représentant un identifiant de système de fichiers pouvant être publié sur le contenu web pour lui donner accès au système de fichiers.
- Ajout d'API SaveAs permettant d'effectuer l'opération Enregistrer sous par programmation. Vous pouvez utiliser ces API pour bloquer la boîte de dialogue Enregistrer sous par défaut, puis enregistrer silencieusement ou créer votre propre interface utilisateur pour Enregistrer sous. Ces API concernent uniquement la boîte de dialogue Enregistrer sous, et non la boîte de dialogue Télécharger, qui continue d'utiliser les API Télécharger existantes.
- Prise en charge des notifications Web pour les notifications non persistantes. L'événement NotificationReceived pour CoreWebView2 contrôle la gestion des notifications Web, permettant leur personnalisation ou leur suppression par l'application hôte.
Les notifications non gérées sont envoyées par défaut vers l'interface utilisateur de WebView2.
- Mise à jour de l'API WebMessageObjects pour permettre l'injection d'objets DOM dans le contenu WebView2 créé via l'application, et via l'API CoreWebView2.PostWebMessage dans l'autre sens.
- Ajout d'un nouveau type d'objet web (CoreWebView2FileSystemHandle) pour représenter un descripteur de système de fichiers pouvant être publié sur le contenu web afin de lui donner accès au système de fichiers.
- Prise en charge des notifications web pour les notifications non persistantes.
L'événement NotificationReceived de CoreWebView2 contrôle la gestion des notifications web, permettant leur personnalisation ou leur suppression par l'application hôte. Les notifications non gérées sont envoyées par défaut vers l'interface utilisateur de WebView2.
- Ajout d'API SaveAs permettant d'effectuer l'opération Enregistrer sous par programmation. Vous pouvez utiliser ces API pour bloquer la boîte de dialogue Enregistrer sous par défaut, puis enregistrer en mode silencieux ou créer votre propre interface utilisateur pour Enregistrer sous. Ces API concernent uniquement la boîte de dialogue Enregistrer sous, et non la boîte de dialogue Télécharger, qui continue d'utiliser les API de téléchargement existantes.
- Ajout d'un nouvel événement ScreenCaptureStarting. Cet événement est déclenché lorsque la WebView2 et/ou l'iframe correspondant à CoreWebView2Frame (ou à l'une de ses iframes descendantes) demandent l'autorisation d'utiliser l'API Capture d'écran avant l'affichage de l'interface utilisateur. L'application peut alors bloquer ou autoriser l'affichage de l'interface utilisateur.
- Ajout d'un nouvel événement SaveFileSecurityCheckStarting. Votre application peut enregistrer un gestionnaire sur cet événement pour obtenir le chemin d'accès au fichier, l'extension du nom de fichier et l'URI d'origine du document. Vous pouvez ensuite appliquer vos propres règles pour effectuer des actions telles que :
- Autoriser l'enregistrement du fichier sans afficher d'avertissement de sécurité par défaut concernant la politique de type de fichier.
- Annuler l'enregistrement.
- Créer votre propre interface utilisateur pour gérer les politiques de type de fichier à l'exécution.
- API
- Ajout d'un nouvel événement SaveFileSecurityCheckStarting. En tant que développeur, vous pouvez enregistrer un gestionnaire sur cet événement pour obtenir le chemin d'accès au fichier, l'extension du nom de fichier et l'URI d'origine du document. Vous pouvez ensuite appliquer vos propres règles pour effectuer des actions telles que :
- Autoriser l'enregistrement du fichier sans afficher d'interface utilisateur d'avertissement de sécurité par défaut concernant la politique de type de fichier.
- Annuler l'enregistrement.
- Créer votre propre interface utilisateur pour gérer les politiques de type de fichier à l'exécution.
- Ajout d'un nouvel événement ScreenCaptureStarting. Cet événement est déclenché lorsque la WebView2 et/ou l'iframe correspondant à la CoreWebView2Frame (ou à l'une de ses iframes descendantes) demande l'autorisation d'utiliser l'API Capture d'écran avant l'affichage de l'interface utilisateur. En tant que développeur, vous pouvez alors choisir de bloquer l'affichage de l'interface utilisateur ou de l'autoriser.
- Ajout d'une nouvelle méthode GetComICoreWebView2 à la classe .NET CoreWebView2 permettant de convertir une CoreWebView2 entre .NET et COM. Ajout d'une nouvelle interface WinRT permettant de convertir une CoreWebView2 entre WinRT et COM. Cela permet l'interopérabilité entre des bibliothèques écrites dans différents langages.
- Ajout de nouvelles API de contrôles de limitation permettant une gestion efficace des ressources en limitant les temporisateurs JavaScript. Ceci est utile lorsqu'un contrôle WebView2 doit rester visible, tout en consommant moins de ressources (par exemple, lorsque l'utilisateur n'interagit pas avec le contenu). Ces API de contrôles de limitation permettent de :

Personnaliser les temporisateurs de script (setTimeout et setInterval) selon différents états de page (premier plan, arrière-plan et arrière-plan avec limitation intensive).

Limiter les temporisateurs de script dans certaines iframes hébergées.

Ajout d'un nouvel événement RestartRequested. L'événement RestartRequested est déclenché chaque fois que WebView2 doit redémarrer pour appliquer des mises à jour ou des modifications de configuration. Cette API permet de détecter le moment où WebView2 doit redémarrer et de prendre les mesures appropriées. La propriété Priority des arguments de l'événement RestartRequested indique la priorité de la demande de redémarrage :
- Élevée indique que l'application doit inviter les utilisateurs à redémarrer dès que possible.
- Normale indique que l'application doit rappeler aux utilisateurs de redémarrer, dans la mesure du possible. - Version des métadonnées Microsoft PKI : 13.0.0.0 --> 14.0.0.1
- Version des instantanés : 126.0.2592.113 --> 129.0.2792.89
- Version du filtre de sous-ressources : 10.34.0.54 --> 10.34.0.55
- Version du jeton de confiance : 2024.8.165 --> 2024.10.1
- Version de System.Threading.Channels : 7.0.0 --> 8.0.0
v2024.11.03
- Interface utilisateur
- Un bug lié à l'outil de mise à jour logicielle a été corrigé :
Lorsque vous cliquez sur « Rechercher des mises à jour logicielles », le message « Mise à jour pour WebConnect disponible et prête à être téléchargée » s'affiche, mais la dernière version est déjà installée sur votre appareil.

v. 2024.09.01
- Première version logicielle
"
            SearchForSoftwareUpdate.Text = "Rechercher des mises à jour logicielles"

        End If
        If Form1.Language = "it" Then
            Terminate.Text = "Chiudi"
            Me.Text = "Impostazioni"
            DisplaySettings.Text = "Impostazioni di visualizzazione"
            Language.Text = "Lingua"
            DefaultSearchEngine.Text = "Motore di ricerca predefinito"
            MagicAILinkButton.Text = "Magic AI Link"
            DefaultChatBot.Text = "Chatbot AI predefinito"
            SoftwareUpdate.Text = "Aggiornamento software"
            VersionInfo.Text = "Versione software attualmente
installata: "
            SearchForUpdatesOnApplicationBoot.Text = "Controlla sempre 
automaticamente per 
gli aggiornamenti 
software su
avvio dell'applicazione"
            Changelog.Text = "Changelog:
Alcune parti di questo testo sono state tradotte automaticamente.
v2025.02.25
- Componenti aggiornati
- Frontend 3.1 --> 4.0
- NUOVE FUNZIONI:
- Schede
- È possibile aggiungere nuove schede dal menu contestuale di TabControl
- Bisogna:
- Fare clic con il pulsante destro del mouse su una scheda aperta
- Selezionare ''Nuova scheda''
- È possibile spostare le schede a sinistra o a destra
- Bisogna:
- Fare clic con il pulsante destro del mouse sulla scheda selezionata o selezionare la scheda che si desidera spostare
- Selezionare ''Sposta in...''
- Selezionare ''...sinistra'' o ''...destra''
- Oppure
- Selezionare ''Navigazione''
- Selezionare ''Sposta in...''
- Selezionare ''...sinistra'' o ''...destra''
- È possibile spostare le schede in una posizione specifica
- Bisogna:
- Posizionare il puntatore del mouse sulla scheda che si desidera spostare.
- Tenere premuto il pulsante sinistro del mouse mentre la si sposta nella posizione desiderata.
- Rilasciare il pulsante sinistro del mouse e la scheda verrà spostata nella posizione in cui si era lasciato il pulsante sinistro del mouse.
- BUG RISOLTI:
- WebView
- È stato risolto un bug che impediva la corretta visualizzazione della WebView. Questo bug causava la mancata visualizzazione di alcuni contenuti web.
- MagicAI Link
- È stato risolto un bug che impediva la risposta della WebView di MagicAI Link premendo il pulsante MagicAI Link o ''CTRL *''. Questo bug richiedeva l'apertura delle impostazioni di WebConnect per verificare che la finestra di MagicAI Link rispondesse. - Versione hyphens-data: 101.0.4906.0 --> 120.0.6050.0
- Versione Microsoft PKI Metadata: 14.0.0.1 --> 21.0.0.0
- Versione Subresource Filter: 10.34.0.55 --> 10.34.0.57
- Versione trustToken: 2024.10.11.1 --> 2024.12.14.1
v2025.02.16
- Componenti aggiornati
- Frontend 3.0 --> 3.1
- Impostazioni
- È stato risolto un bug che causava l'eliminazione delle impostazioni utente dopo un aggiornamento software. Soluzione: il salvataggio delle impostazioni salvava le impostazioni nel Registro di sistema di Windows. Prima di questo aggiornamento, le impostazioni venivano salvate nel programma stesso, che veniva poi sovrascritto da un aggiornamento software.
Link MagicAI
- È stato risolto un bug che impediva il corretto funzionamento del passaggio da un ChatBot all'altro.
- È stato risolto un bug che impediva il corretto funzionamento della finestra di MagicAI quando veniva visualizzata la finestra e le dimensioni dell'applicazione cambiavano, senza che le dimensioni della finestra di MagicAI venissero applicate.
- Interprete Commando
- È stato risolto un bug che impediva il riavvio dell'applicazione quando l'utente immetteva il seguente comando nella casella di testo: ''cmd://reboot''
- Bootloader 2.0 --> 2.1
- Nuova animazione di avvio
- La versione del bootloader ora viene visualizzata nella finestra di dialogo ''Informazioni''.
- Edge WebView2 v131.0.2908.86 --> 133.0.3065.69
- Promozioni
- Visualizza gli elementi WPF a livello WebView2 (WebView2CompositionControl)
Impedisce a WebView2CompositionControl di essere il controllo WebView2 di primo livello in un'app WPF e di offuscare tutti gli elementi WPF. Microsoft.Web.WebView2.Wpf.WebView2CompositionControl è un sostituto per il controllo WebView2 WPF predefinito. Entrambi implementano il controllo WebView2 come WebView2CompositionControl e l'interfaccia Microsoft.Web.WebView2.Wpf.IWebView2. Entrambi derivano da FrameworkElement come segue:

FrameworkElement ->HwndHost ->WebView2.
FrameworkElement ->Control ->WebView2CompositionControl. Premessa: se si crea un'app Windows Presentation Foundation (WPF) e si utilizza il controllo WebView2, è possibile che l'app generi problemi di ''airspace'', in cui il controllo WebView2 viene sempre visualizzato in primo piano e tutti gli elementi WPF nella stessa posizione risultano nascosti, anche se si tenta di specificare gli elementi WPF che dovrebbero essere in primo piano rispetto al controllo WebView2 (ad esempio, utilizzando l'ordine della struttura visiva o la proprietà z-index).

Questo problema si verifica perché il controllo WPF utilizza l'HwndHost WPF per ospitare il controllo WebView2 Win32 e l'HwndHost presenta un problema con l'airspace.

- Errori
- Solo runtime
- Risolta una regressione per cui le modifiche alla visualizzazione potevano causare il rendering di WebView2 più piccolo della finestra dell'app.
- Il pulsante ''Chiudi'' mancante è stato aggiunto al flyout ''Download''.
- Risolta una race condition che si verificava quando l'evento Web Request Response non si verificava mai.
- Solo SDK
- Risolto un problema in WPF WebView2CompositionControl che non veniva visualizzato se inizializzato con dimensione (0,0), ad esempio quando inizializzato in un TabItem di TabControl.
- System.Threading.Channels v9.0.0 --> v9.0.2
- Microsoft.Web.WebView2.Core v1.0.2903.40 --> v1.0.3065.39
- Microsoft.Web.WebView2.WinForms v1.0.2903.40 --> v1.0.3065.39
- Microsoft.Web.WebView2.Wpf v1.0.2903.40 --> v1.0.3065.39

v2024.12.27
- Componenti aggiornati:
- Frontend: v2.0 --> v3.0
- NUOVE FUNZIONI:
- MAGIC AI LINK

COS'È MAGIC AI LINK?
CON MAGIC AI LINK, PUOI ACCEDERE FACILMENTE E VELOCEMENTE AL TUO CHATBOT AI PREFERITO.
IL CHATBOT SARÀ ANCORA SUL LATO DESTRO DELLA FINESTRA, QUANDO LO APRI.
- È stato aggiunto un pulsante per attivare/disattivare un chatbot AI.
- Anche il tasto di scelta rapida ''CTRL + .'' attiva/disattiva Magic AI Link.
- Puoi programmare questo pulsante andando su WebConnect -> Impostazioni -> Magic AI Link. Chatbot supportati:
- Google Gemini
- Microsoft Copilot
- ChatGPT
- CORREZIONE BUG
- È stato risolto un bug che impediva il funzionamento dei seguenti tasti di scelta rapida in altre app quando WebConnect era in esecuzione:
- ALT + E
- CTRL + D
- CTRL + E
- CTRL + K
- CTRL + L
- ALT + F
- CTRL + N
- CTRL + T
- CTRL + W
- ALT + S
- CTRL + TAB
- CTRL + MAIUSC + TAB
- È stato risolto un bug che impediva il funzionamento del pulsante ''Chiudi scheda'' nella barra degli strumenti del menu.
v2024.12.13
- È stato risolto un bug che poteva causare il rilevamento di WebConnect Installer/Updater come malware
v2024.12.11
- Componenti aggiornati:
- Frontend
- È stato risolto un bug durante l'impostazione di una password per la modalità MDM (gestione dispositivi mobili), poiché la finestra di dialogo di impostazione della password non veniva visualizzata correttamente.
È possibile abilitare/disabilitare la modalità MDM (gestione dispositivi mobili) cliccando su WebConnect/Impostazioni/Aggiornamento software/Clicca rapidamente sulla versione del software finché non viene visualizzato il pulsante ''Software di amministrazione WebConnect''.
- È stato risolto un bug durante la visualizzazione del Software di amministrazione WebConnect, poiché non veniva visualizzato correttamente quando si apriva la scheda ''Valori di progettazione''.
- È stato risolto un bug quando si premeva il pulsante OK in una finestra di dialogo che indicava che un collegamento non poteva essere aperto.
- È stato risolto un bug quando si riavviava l'applicazione, le impostazioni MDM (gestione dispositivi mobili) venivano cancellate.
- È stato risolto un bug quando si aprivano le impostazioni del browser: se si impostava Google come motore di ricerca predefinito, il motore di ricerca predefinito veniva impostato su Bing. - È stato risolto un bug: quando si chiude una scheda, l'istanza di WebView, che si avviava con la scheda, non si chiudeva e rimaneva in esecuzione in background.
- Aggiunta di tasti di scelta rapida per uscire da alcuni menu
- Aggiunta di tasti di scelta rapida per la navigazione nel browser
- Aggiunto un menu contestuale che consente di chiudere le schede sui dispositivi senza tasto centrale del mouse
- Migliorato l'output di debug per gli sviluppatori
  - Microsoft Edge WebView: 130.0.2849.39 --> 131.0.2903.86
     - Promotions
        - Control whether the screen capture UI is displayed (ScreenCaptureStarting event)
        - A new ScreenCaptureStarting event has been added. This event is triggered whenever 
          the webView2 and/or iframe corresponding to the CoreWebView2Frame (or one of its 
          successor iframes) requests permission to use the screen capture API before displaying 
          the UI. The app can then block the display of the UI or allow the display of the UI.
      - Bug fixes
        - Runtime only
          - Allow the Download dialog box to receive initial focus on startup.

v2024.11.07
- Componenti aggiornati:
- Frontend
- Modifiche ai messaggi di errore all'avvio di WebConnect quando i file di sistema di WebConnect
sono mancanti o danneggiati
- Correzione degli indicatori di versione di vari componenti di WebConnect
- Correzione del changelog della versione software
- Microsoft Edge WebView: 130.0.1823.32 --> 130.0.849.56
- Funzionalità
- Introdotta un'opzione per annullare la navigazione iniziale in WebView2, per migliorare le prestazioni di avvio.
- Questa modifica è disabilitata per impostazione predefinita e può essere abilitata utilizzando il flag di funzionalità msWebView2CancelInitialNavigation.
- Introdotto il flag di funzionalità msWebView2EnableDownloadContentInWebResourceResponseReceived, una funzionalità sperimentale (piuttosto che stabile). Quando questo flag è abilitato, le risposte delle navigazioni che diventano download sono disponibili in WebResourceResponseReceived.
- Aggiunto il supporto per C#/WinRT .NET 6+.
- Runtime e SDK
- Risolto un crash quando i metodi asincroni degli oggetti host .NET restituiscono un risultato nullo
- Riattivato il comportamento predefinito di SetUserAgent: per impostazione predefinita, SetUserAgent è efficace per gli iframe multi-origine.
- Solo runtime
- Risolto un problema di perdita di memoria in WebView2 alla chiusura della finestra.
- Risolto un problema per cui ignoreMemberNotFoundError non funzionava per gli oggetti .NET.
- Ora restituisce un codice di errore corretto quando CreateSharedBuffer viene chiamato con una dimensione del buffer pari a 0.
- Risolto un problema di attivazione per la finestra di dialogo di esplorazione del cursore.
- Risolto un problema per cui l'evento CursorChanged di WebView2 Visual Hosting non si attivava per i cursori personalizzati.
- Risolto un bug per cui, se il gestore eventi LaunchingExternalURIScheme è associato,
e la casella di controllo ''Ricorda sempre'' è abilitata, e l'utente seleziona questa casella di controllo, la finestra di dialogo viene nuovamente visualizzata in modo errato.
- Risolto un problema per cui i controlli di modifica del testo nell'hosting visuale duplicavano l'input IME quando perdevano e poi riacquisivano lo stato attivo.
- Risolto un problema per cui le app UWP con attendibilità totale non potevano visualizzare le finestre di proprietà.
- Risolto un bug nella logica di attivazione delle finestre di proprietà per l'hosting visuale. - Disabilitato BreakoutBoxPreferCaptureTimestampInVideoFrame per WebView2 TextureStream.
- Risolto un problema per cui l'evento WindowCloseRequested si attivava solo per la prima chiamata a window.close().
- Risolto un problema per cui gli array tipizzati nella proiezione JavaScript WinRT non potevano essere gestiti come IDispatch nell'host.
- Risolto un bug per cui il popup di riempimento automatico si chiudeva immediatamente e causava una modifica del focus.
- Risolto un bug per cui WebView2 non si caricava a causa di AppPolicyGetWindowingModel.
- Risolto un problema per cui la finestra dell'app non poteva essere controllata tramite comandi di sistema (come Alt+F4 o Alt+Barra spaziatrice) quando il focus era in WebView2 per la modalità di hosting Visual.
- Risolto un bug in WebView2 UWP per cui non era possibile fare clic sulla barra di ricerca dall'app host.
- Risolto un problema per cui gli eventi WebResourceRequested si bloccavano su alcuni siti.
- Abilitata la funzione di trascinamento interattivo per impostazione predefinita. Vedi edge-webview-interactive-dragging nei flag del browser WebView2.
- Disattivato IsolateSandboxedIframes per WebView2.
- Risolto un problema per cui la creazione di WebView falliva quando venivano avviate più istanze contemporaneamente.
- Risolto un bug nella proiezione JavaScript di WinRT in cui la memorizzazione nella cache delle proprietà esistenti negli oggetti il ​​cui nome
contiene Proxy o Function causava un errore a causa di una collisione di nomi.
- Risolto un bug per cui il controllo WebView2 assumeva dimensioni errate dopo la disconnessione e la riconnessione di un monitor.
- Risolto un problema per cui i link ''mailto:'' lasciavano aperta una finestra popup senza titolo, invece di chiuderla automaticamente.
- Risolto un problema per cui il focus su un controllo WebView2 in WinAppSDK con l'impostazione ''Scorri finestre inattive'' di Windows disattivata
causava il fallimento dello scorrimento.
- Bloccato edge://wallet in WebView2.
- Cancellata la variabile d'ambiente per il colore di sfondo predefinito nei controlli .NET WebView2 al termine della creazione del controller. - Abilitato il supporto per l'accessibilità per Webview2 in modalità di hosting visuale.
- Risolto un bug relativo alla rimozione del filtro ''risorsa web richiesta'' per più fonti, quando una di esse è un documento.
- Risolto un problema di regressione per cui DataList non era visibile in WinUI o in altre istanze di WebView2 in hosting visuale.
- Risolto un problema di focus nella finestra di dialogo Download quando si premeva Tab o Maiusc+Tab per passare al controllo Webview2.
- Solo SDK
- Risolto un problema nell'SDK che causava valori <Platform> errati nell'elenco delle piattaforme del progetto .NET.
- Aggiunta dell'API WinRT CoreWebView2Notification.VibrationPattern mancante. Questa API WinRT può essere combinata con le note di rilascio della promozione dell'API di notifica stabile; vedere ''Notifica Web'' e
Notifica ricevuta per WinRT, immediatamente sopra.
- Risolto un problema per cui gli eventi KeyDown del controllo WinForms WebView2 non includevano le informazioni corrette di ModifierKeys.
- Corretto x86 per la proiezione C# di WinRT.
- CreateCoreWebView2Environment e GetAvailableCoreWebView2BrowserVersionString resi più robusti contro potenziali condizioni di race condition durante l'aggiornamento del runtime.
- Corretto x86 per la proiezione C# di WinRT.
- La proiezione C# WinRT ora funziona su UWP.
- Risolto un problema per garantire che GeneratedFilesDir non venga più visualizzato in Visual Studio per la proiezione C# WinRT.
- Corretta una dipendenza dall'SDK per i progetti .NET.
- Corretto un problema di compatibilità durante la chiamata a GetAvailableBrowserVersionString() con una versione precedente di WebView2Loader.dll.
- Corretti problemi durante la compilazione del codice generato da wv2winrt con le opzioni cpp20 e /permissive-.
- Aggiunto .NET 8 TargetFramework per C# WinRT, abilitata la compatibilità AOT (ahead-of-time) e disabilitato il marshalling a runtime.
- Corretta una dipendenza dall'SDK per i progetti .NET.
- Corretta l'incompatibilità di Arm64 con WindowsAppSDK 1.6.
- Rimosso WebView2Loader.dll aggiuntivo nel caso di WinAppSDK.
- L'utilizzo di CoreWebView2.AddWebResourceRequestedFilter senza il parametro CoreWebView2WebResourceRequestSourceKinds è ora deprecato.
Vedere il metodo .NET CoreWebView2.AddWebResourceRequestedFilter.
- L'utilizzo di CoreWebView2.AddWebResourceRequestedFilter senza il parametro CoreWebView2WebResourceRequestSourceKinds è ora deprecato. Vedere il metodo .NET CoreWebView2.AddWebResourceRequestedFilter.
- Aggiunto .NET 8 TargetFramework per C# WinRT, abilitata la compatibilità AOT (ahead-of-time) e disabilitato il marshalling in fase di esecuzione.
- Promozioni
- Supporto per la barra di scorrimento sovrapposta Fluent Style.
- Aggiornata l'API WebMessageObjects per consentire l'inserimento di oggetti DOM nel contenuto WebView2 creato tramite l'app e tramite l'API CoreWebView2.PostWebMessage nella direzione opposta. Aggiunto un nuovo tipo di oggetto web per rappresentare un handle del file system che può essere inviato al contenuto web per fornirgli l'accesso al file system.
- Aggiunte le API SaveAs che consentono di eseguire a livello di codice l'operazione Salva con nome. È possibile utilizzare queste API per bloccare la finestra di dialogo predefinita Salva con nome e quindi salvare in modo silenzioso o creare una propria interfaccia utente per Salva con nome. Queste API riguardano solo la finestra di dialogo Salva con nome, non la finestra di dialogo Scarica, che continua a utilizzare le API Scarica esistenti.
- Aggiunto il supporto per le notifiche web, per le notifiche non persistenti. L'evento NotificationReceived per CoreWebView2 controlla la gestione delle notifiche web, consentendone la personalizzazione o la soppressione da parte dell'app host.
Le notifiche non gestite vengono visualizzate per impostazione predefinita nell'interfaccia utente di WebView2.
- Aggiornata l'API WebMessageObjects per consentire l'inserimento di oggetti DOM nel contenuto di WebView2, che viene
- costruito tramite l'app e tramite l'API CoreWebView2.PostWebMessage nella direzione opposta.
- Aggiunto un nuovo tipo di oggetto web (CoreWebView2FileSystemHandle) per rappresentare un handle del file system
- che può essere inviato al contenuto web per fornirgli l'accesso al file system.
- Aggiunto il supporto per le notifiche web, per le notifiche non persistenti.
L'evento NotificationReceived per CoreWebView2 controlla la gestione delle notifiche web, consentendo
la personalizzazione o la soppressione da parte dell'app host. Le notifiche non gestite vengono visualizzate per impostazione predefinita nell'interfaccia utente di WebView2.
- Aggiunte le API SaveAs che consentono di eseguire a livello di codice l'operazione Salva con nome. È possibile
utilizzare queste API per bloccare la finestra di dialogo predefinita Salva con nome e quindi salvare in modo silenzioso o creare una propria interfaccia utente per Salva con nome. Queste API riguardano solo la finestra di dialogo Salva con nome, non la finestra di dialogo Scarica, che continua a utilizzare le API Scarica esistenti.
- Aggiunto un nuovo evento ScreenCaptureStarting. Questo evento viene generato ogni volta che WebView2
e/o l'iframe corrispondente a CoreWebView2Frame (o a uno qualsiasi dei suoi iframe discendenti)
richiedono l'autorizzazione a utilizzare l'API Cattura Schermo prima che l'interfaccia utente venga visualizzata. L'app può quindi
bloccare la visualizzazione dell'interfaccia utente o consentirne la visualizzazione.
- Aggiunto un nuovo evento SaveFileSecurityCheckStarting. L'app può registrare un gestore su questo evento
per ottenere il percorso del file, l'estensione del nome del file e le informazioni sull'URI di origine del documento. È quindi possibile
applicare regole personalizzate per eseguire azioni come le seguenti:
- Consentire il salvataggio del file senza visualizzare un'interfaccia utente predefinita con avviso di sicurezza relativa ai criteri relativi al tipo di file.
- Annullare il salvataggio.
- Creare un'interfaccia utente personalizzata per gestire i criteri relativi al tipo di file a runtime.
- API
- Aggiunto un nuovo evento SaveFileSecurityCheckStarting. Come sviluppatore, puoi registrare un gestore su questo evento per ottenere il percorso del file, l'estensione del nome del file e le informazioni sull'URI di origine del documento. Puoi quindi applicare le tue regole per eseguire azioni come le seguenti:
- Consentire il salvataggio del file senza visualizzare un'interfaccia utente predefinita con avviso di sicurezza relativa ai criteri relativi al tipo di file.
- Annullare il salvataggio.
- Creare la propria interfaccia utente per gestire i criteri relativi al tipo di file a runtime.
- Aggiunto un nuovo evento ScreenCaptureStarting. Questo evento viene generato ogni volta che WebView2 e/o l'iframe corrispondente a CoreWebView2Frame (o a uno qualsiasi dei suoi iframe discendenti) richiede l'autorizzazione per utilizzare l'API Screen Capture prima che l'interfaccia utente venga visualizzata. Come sviluppatore, puoi quindi scegliere di bloccare o consentire la visualizzazione dell'interfaccia utente. - Aggiunto un nuovo metodo GetComICoreWebView2 alla classe .NET CoreWebView2 che consente di convertire un CoreWebView2 tra .NET e COM. Aggiunta una nuova interfaccia WinRT che consente di convertire un CoreWebView2 tra WinRT e COM. Ciò consente l'interoperabilità tra librerie scritte in linguaggi diversi.
- Aggiunte nuove API per i controlli di limitazione che consentono una gestione efficiente delle risorse consentendo di limitare i timer JavaScript. Questo è utile negli scenari in cui un controllo WebView2 deve rimanere visibile, ma consumare meno risorse (ad esempio quando l'utente non interagisce con il contenuto). Queste API per i controlli di limitazione consentono di:
- Personalizzare la limitazione dei timer degli script (setTimeout e setInterval) in diversi stati della pagina (primo piano, sfondo e sfondo con limitazione intensiva).
- Limitare i timer degli script in iframe ospitati selezionati.
- Aggiunto un nuovo evento RestartRequested. L'evento RestartRequested viene generato ogni volta che WebView2 deve essere riavviato per applicare aggiornamenti o modifiche alla configurazione. È possibile utilizzare questa API per rilevare quando WebView2 deve essere riavviato e intraprendere le azioni appropriate. La proprietà Priority degli argomenti dell'evento RestartRequested indica la priorità della richiesta di riavvio:
- Alta indica che l'app deve richiedere agli utenti di riavviarsi il prima possibile.
- Normale indica che l'app deve ricordare agli utenti di riavviarsi, con la massima priorità. - Versione metadati Microsoft PKI: 13.0.0.0 --> 14.0.0.1
- Versione snapshot: 126.0.2592.113 --> 129.0.2792.89
- Versione filtro sottorisorse: 10.34.0.54 --> 10.34.0.55
- Versione trustToken: 2024.8.165 --> 2024.10.1
- Versione System.Threading.Channels: 7.0.0 --> 8.0.0
v2024.11.03
- Frontend
- È stato risolto un bug con lo strumento di aggiornamento software:
Quando si fa clic su ''Cerca aggiornamenti software'', viene visualizzato il messaggio ''Aggiornamento per WebConnect disponibile e pronto per il download'',
ma la versione più recente è già installata sul dispositivo.
v2024.09.01
- Prima versione del software"
            SearchForSoftwareUpdate.Text = "Controllare gli aggiornamenti software"
        End If
        If Form1.Language = "tr" Then
            Terminate.Text = "Kapat"
            Me.Text = "Ayarlar"
            DisplaySettings.Text = "Görüntü Ayarları"
            Language.Text = "Dil"
            DefaultSearchEngine.Text = "Varsayılan Arama Motoru"
            MagicAILinkButton.Text = "Magic AI Link"
            DefaultChatBot.Text = "Varsayılan AI Sohbet Robotu"
            SoftwareUpdate.Text = "Yazılım güncellemesi"
            VersionInfo.Text = "Şu anda yüklü yazılım sürümü: "
            SearchForUpdatesOnApplicationBoot.Text = "Her zaman otomatik olarak kontrol edin
yazılım güncellemeleri için
uygulama önyüklemesi"
            Changelog.Text = "Changelog:
Bazı metinler otomatik olarak çevrildi.
v2025.02.25
- Güncellenen Bileşenler
- Ön Uç 3.1 --> 4.0
- YENİ İŞLEVLER:
- Sekmeler
- TabControl bağlam menüsünden yeni Sekmeler ekleyebilirsiniz
- Yapmanız gerekenler:
- Açılan bir Sekmeye Sağ Tıklayın
- ''Yeni Sekme''yi seçin
- Sekmeleri sola veya sağa taşıyabilirsiniz
- Yapmanız gerekenler:
- Odaklanmış sekmeye Sağ Tıklayın veya taşımak istediğiniz bir sekmeye odaklanın
- ''Taşı...''yı seçin
- ''...sola'' veya ''...sağa''yı seçin
- Veya
- ''Gezinme''yi seçin
- ''Taşı...''yı seçin
- ''...sola'' veya ''...sağa''yı seçin
- Sekmeleri belirli bir konuma taşıyabilirsiniz
- Yapmanız gerekenler:
- Fare işaretçinizi taşımak istediğiniz sekmenin üzerine getirin.
- İstediğiniz konuma taşırken sol fare düğmesini basılı tutun. - Sol fare düğmesini bırakın ve sekme sol fare düğmesini bıraktığınız konuma taşınacaktır.
- DÜZELTİLEN HATALAR:
- WebView
- WebView'in doğru şekilde gösterilmemesi hatası düzeltildi. Bu hata bazı web içeriklerinin görüntülenmemesine neden oluyordu.
- MagicAI Link
- MagicAI Link WebView'in MagicAI Link Düğmesine veya ''CTRL * .'' tuşuna basıldığında yanıt vermemesi hatası düzeltildi. Bu hata MagicAI Link Penceresinin yanıt vermesi için WebConnect ayarlarını açmanız gerekmesine neden oluyordu. - hyphens-data-Version: 101.0.4906.0 --> 120.0.6050.0
- Microsoft PKI Metadata-Version: 14.0.0.1 --> 21.0.0.0
- Alt Kaynak Filtresi Sürümü: 10.34.0.55 --> 10.34.0.57
- trustToken-Version: 2024.10.11.1 --> 2024.12.14.1
v2025.02.16
- Güncellenen Bileşenler
- Ön Uç 3.0 --> 3.1
- Ayarlar
- Bir yazılım güncellemesinden sonra kullanıcı ayarlarının silinmesine neden olan bir hata düzeltildi. Çözüm: Ayar koruyucu, ayarları Windows Kayıt Defterine kaydediyor. Bu güncellemeden önce, ayarlar programın kendisine kaydediliyordu ve bu da bir yazılım güncellemesi tarafından üzerine yazıldı. MagicAI Bağlantısı
- Farklı ChatBot'lar arasında geçiş yapmanın düzgün çalışmaması hatası düzeltildi
- MagicAI Penceresinin görüntülenmesi ve uygulama boyutunun değişmesi, MagicAI Pencere boyutunun buna uygulanmaması hatası düzeltildi
- Commando yorumlayıcısı
- Kullanıcı metin kutusuna şu komutu girdiğinde uygulamanın yeniden başlatılmaması hatası düzeltildi: ''cmd://reboot''
- Önyükleyici 2.0 --> 2.1
- Yeni önyükleme animasyonu
- Önyükleyici sürümü artık hakkında iletişim kutusunda görüntüleniyor
- Edge WebView2 v131.0.2908.86 --> 133.0.3065.69
- Promosyonlar
- WPF öğelerini WebView2 düzeyinde görüntüle (WebView2CompositionControl)
WebView2CompositionControl'ün bir WPF uygulamasında en üst düzey WebView2 denetimi olmasını ve tüm WPF öğelerini gizlemesini önler. Microsoft.Web.WebView2.Wpf.WebView2CompositionControl, varsayılan WPF WebView2 denetimi için bir drop-in değiştirmedir. Her ikisi de WebView2 denetimini WebView2CompositionControl ve Microsoft.Web.WebView2.Wpf.IWebView2 arayüzü olarak uygular. Her ikisi de FrameworkElement'ten aşağıdaki şekilde türetilmiştir:

FrameworkElement ->HwndHost ->WebView2.
FrameworkElement ->Control ->WebView2CompositionControl.
Arka Plan: Bir Windows Presentation Foundation (WPF) uygulaması oluşturur ve WebView2 denetimini kullanırsanız, uygulamanızın WebView2 denetiminin her zaman en üstte görüntülendiği ve aynı konumdaki tüm WPF öğelerinin gizlendiği ''hava sahası'' sorunlarına yol açtığını görebilirsiniz, hatta WebView2 denetiminin en üstünde olması gereken WPF öğelerini belirtmeye çalışsanız bile (örneğin görsel yapı sırasını veya z-indeks özelliğini kullanarak).

Bu sorun, WPF denetiminin Win32 WebView2 denetimini barındırmak için WPF HwndHost'u kullanması ve HwndHost'un hava sahasında bir sorun yaşaması nedeniyle oluşur.

- Fehlerbehebungen
- Yalnızca çalışma zamanı
- Görüntüleme değişikliklerinin WebView2'nin uygulama penceresinden daha küçük gösterilmesine neden olabileceği bir gerileme düzeltildi.
- Eksik ''Kapat'' düğmesi ''İndir'' açılır penceresine eklendi.
- Web İsteği Yanıt olayının asla gerçekleşmediği durumlarda oluşan bir yarış durumu düzeltildi.
- Yalnızca SDK
- WPF WebView2CompositionControl'de, örneğin TabControl'ün bir TabItem'inde başlatıldığında (0,0) boyutuyla başlatıldığında görüntülenmediği bir sorun düzeltildi. - System.Threading.Channels v9.0.0 --> v9.0.2
- Microsoft.Web.WebView2.Core v1.0.2903.40 --> v1.0.3065.39
- Microsoft.Web.WebView2.WinForms v.1.0.2903.40 --> v1.0.3065.39
- Microsoft.Web.WebView2.Wpf v1.0.2903.40 --> v1.0.3065.39

v2024.12.27
- Güncellenen Bileşenler:
- Önyüz: v2.0 --> v3.0
- YENİ İŞLEVLER:
- MAGIC AI LINK

MAGIC AI LINK NEDİR?
MAGIC AI LINK İLE TERCİH ETTİĞİNİZ AI SOHBETİNE KOLAYCA VE HIZLI BİR ŞEKİLDE ERİŞEBİLİRSİNİZ.
AÇTIĞINIZDA SOHBET PENCERENİN SAĞ TARAFINA YERLEŞTİRİLECEKTİR.
- Bir AI sohbet robotunu açıp kapatmak için bir düğme eklendi
- ''CTRL + .'' kısayolu da Magic AI Link'i açıp kapatır
- Bu Düğmeyi WebConnect-->Ayarlar-->Magic AI Link'e giderek programlayabilirsiniz. Desteklenen Chatbot'lar:
- Google Gemini
- Microsoft Copilot
- ChatGPT
- HATA DÜZELTMELERİ
- WebConnect çalışırken diğer uygulamalarda aşağıdaki kısayol tuşlarının çalışmaması hatası düzeltildi:
- ALT + E
- CTRL + D
- CTRL + E
- CTRL + K
- CTRL + L
- ALT + F
- CTRL + N
- CTRL + T
- CTRL + W
- ALT + S
- CTRL + TAB
- CTRL + SHIFT + TAB
- Menü araç çubuğundaki ''Sekmeyi kapat'' düğmesinin çalışmaması hatası düzeltildi
v2024.12.13
- WebConnect Installer/Updater'ın kötü amaçlı yazılım olarak algılanmasına neden olabilecek bir hata düzeltildi
v2024.12.11
- Güncellenen Bileşenler:
- Ön Uç
- mdm (mobil cihaz yönetimi) modu için bir parola ayarlandığında oluşan bir hata düzeltildi, çünkü parola ayar iletişim kutusu doğru şekilde gösterilmiyor.
''WebConnect Admin Yazılımı'' düğmesi görünene kadar WebConnect/Ayarlar/Yazılım güncelleme/Yazılım sürümünde Hızlı tıkla'ya tıklayarak mdm (mobil cihaz yönetimi) modunu etkinleştirebilir/devre dışı bırakabilirsiniz.
- ''Tasarımcı değerleri'' sekmesi açıldığında WebConnect Admin Yazılımı doğru şekilde gösterilmediği için WebConnect Admin Yazılımı gösterilirken oluşan bir hata düzeltildi.
- Bir bağlantının açılamadığını söyleyen bir iletişim kutusunda Tamam düğmesine bastığınızda oluşan bir hata düzeltildi.
- Uygulamayı yeniden başlattığınızda oluşan bir hata düzeltildi, mdm (mobil cihaz yönetimi) ayarları temizlenecek.
- Tarayıcı ayarlarını açtığınızda oluşan bir hata düzeltildi, varsayılan arama motorunu Google olarak ayarlarsanız varsayılan arama motoru Bing olarak ayarlanacaktır. - Bir sekmeyi kapattığınızda, sekmeyle başlayan WebView örneği sonlandırılmıyor ve arka planda çalışıyor.
- Bazı menülerden çıkmak için kısayol tuşları ekleniyor
- Tarayıcı gezintisi için kısayol tuşları ekleniyor
- Orta fare düğmesi olmayan cihazlarda sekmeleri kapatabilen bir bağlam menüsü eklendi
- Geliştiriciler için daha iyi hata ayıklama çıktısı
- Microsoft Edge WebView: 130.0.2849.39 --> 131.0.2903.86
- Promosyonlar
- Ekran yakalama kullanıcı arayüzünün görüntülenip görüntülenmeyeceğini kontrol edin (ScreenCaptureStarting olayı)
- Yeni bir ScreenCaptureStarting olayı eklendi. Bu olay, CoreWebView2Frame'e (veya haleflerinden birine) karşılık gelen webView2 ve/veya iframe, kullanıcı arayüzünü görüntülemeden önce ekran yakalama API'sini kullanma izni istediğinde tetiklenir. Uygulama daha sonra kullanıcı arayüzünün görüntülenmesini engelleyebilir veya kullanıcı arayüzünün görüntülenmesine izin verebilir.
- Hata düzeltmeleri
- Yalnızca çalışma zamanı
- İndirme iletişim kutusunun başlangıçta ilk odağı almasına izin ver.

v2024.11.07
- Güncellenen Bileşenler:
- Ön Uç
- WebConnect sistem dosyaları eksik veya hasarlı olduğunda WebConnect'i başlatırken Hata Mesajlarında Ayarlamalar
- Çeşitli WebConnect bileşenlerinin sürüm göstergelerinin düzeltilmesi
- Yazılım sürümü değişiklik günlüğünün düzeltilmesi
- Microsoft Edge WebView: 130.0.1823.32 --> 130.0.849.56
- Özellikler
- Başlangıç ​​performansını iyileştirmek için WebView2'de ilk gezinmeyi iptal etme seçeneği sunuldu.
- Bu değişiklik varsayılan olarak devre dışıdır ve
msWebView2CancelInitialNavigation özellik bayrağı kullanılarak etkinleştirilebilir.
- Deneysel bir özellik olan (Kararlı bir özellik yerine) msWebView2EnableDownloadContentInWebResourceResponseReceived özellik bayrağı sunuldu. Bu bayrak etkinleştirildiğinde, indirmelere dönüşen
gezinmelerin yanıtlarının WebResourceResponseReceived'da kullanılabilir olması sağlanır.
- C#/WinRT .NET 6+ desteği eklendi.
- Çalışma zamanı ve SDK
- .NET ana bilgisayar nesnesi asenkron yöntemleri boş bir sonuç döndürdüğünde oluşan bir çökme düzeltildi
- SetUserAgent'ın varsayılan davranışı yeniden etkinleştirildi: varsayılan olarak, SetUserAgent çapraz kökenli iframe'ler için etkilidir.
- Yalnızca çalışma zamanı
- Pencere kapatıldığında WebView2 bellek sızıntısı sorunu düzeltildi.
- ignoreMemberNotFoundError'ın .NET nesneleri için çalışmadığı bir sorun düzeltildi
- Artık CreateSharedBuffer 0 arabellek boyutuyla çağrıldığında uygun bir hata kodu döndürülüyor.
- İmleç tarama iletişim kutusu için bir etkinleştirme sorunu düzeltildi.
- WebView2 Visual Hosting CursorChanged olayının özel imleçler için tetiklenmediği bir sorun düzeltildi.
- LaunchingExternalURIScheme olay işleyicisi eklendiğinde ve her zaman hatırla onay kutusu etkinleştirildiğinde ve kullanıcı bu onay kutusunu seçtiğinde iletişim kutusunun yanlış bir şekilde tekrar görüntülendiği bir hata düzeltildi.
- Görsel barındırmadaki metin düzenleme denetimlerinin odak kaybedildiğinde ve sonra yeniden kazanıldığında IME girişini çoğalttığı bir sorun düzeltildi.
- Tam güvenilir UWP uygulamalarının sahip olunan pencereleri görüntüleyemediği bir sorun düzeltildi.
- Görsel barındırma için sahip olunan pencere etkinleştirme mantığındaki bir hata düzeltildi. - WebView2 TextureStream için BreakoutBoxPreferCaptureTimestampInVideoFrame devre dışı bırakıldı.
- WindowCloseRequested olayının yalnızca ilk window.close() çağrısı için tetiklendiği bir gerileme düzeltildi.
- WinRT JavaScript projeksiyonunda yazılan dizilerin ana bilgisayarda IDispatch olarak işlenemediği bir gerileme düzeltildi.
- Otomatik doldurma açılır penceresinin hemen kapanıp odak değişikliğine neden olduğu bir hata düzeltildi.
- AppPolicyGetWindowingModel nedeniyle WebView2'nin yüklenemediği bir hata düzeltildi.
- Odak, Görsel barındırma modu için WebView2'deyken uygulama penceresinin sistem komutlarıyla (Alt+F4 veya Alt+Boşluk Çubuğu gibi) kontrol edilemediği bir sorun düzeltildi.
- WebView2 UWP'de, ana bilgisayar uygulamasından Bul çubuğuna tıklanamadığı bir hata düzeltildi.
- WebResourceRequested olaylarının belirli sitelerde çöktüğü bir gerileme düzeltildi. - Varsayılan olarak etkileşimli sürükleme özelliği etkinleştirildi. WebView2 tarayıcı bayraklarında edge-webview-interactive-dragging'e bakın.
- WebView2 için IsolateSandboxedIframes devre dışı bırakıldı.
- Aynı anda birden fazla örnek başlatıldığında WebView oluşturma işleminin başarısız olduğu bir sorun düzeltildi.
- Adı Proxy veya Function içeren nesnelerde mevcut özelliklerin önbelleğe alınmasının ad çakışması nedeniyle bir hataya neden olduğu WinRT JavaScript projeksiyonunda bir hata düzeltildi.
- Bir monitörün bağlantısı kesilip yeniden bağlandıktan sonra WebView2 denetiminin yanlış boyuta geldiği bir hata düzeltildi.
- ''mailto:'' bağlantılarının otomatik olarak açılan pencereyi kapatmak yerine başlıksız bir açılır pencereyi açık bıraktığı bir sorun düzeltildi.
- Windows ''Etkin olmayan pencereleri kaydır'' ayarı devre dışıyken WinAppSDK'da bir WebView2 denetimine odaklanmanın kaydırmanın başarısız olmasına neden olduğu bir sorun düzeltildi.
- WebView2'de edge://wallet engellendi.
- Denetleyici oluşturmayı tamamladıktan sonra .NET WebView2 denetimlerinde varsayılan arka plan rengi için ortam değişkeni temizlendi.
- Görsel barındırma modunda Webview2 için erişilebilirlik desteği etkinleştirildi.
- Bunlardan biri Belge olduğunda birden fazla kaynak için ''web kaynağı talep edildi'' filtresinin kaldırılmasıyla ilgili bir hata düzeltildi.
- DataList'in WinUI'de veya görsel olarak barındırılan diğer WebView2 örneklerinde görünür olmadığı bir gerileme düzeltildi.
- Webview2 denetimine geçmek için Tab veya Shift+Tab tuşlarına basıldığında bir İndirme iletişim kutusu odak sorunu düzeltildi.
- Yalnızca SDK
- .NET proje platformları listesinde hatalı <Platform> değerlerine neden olan SDK'daki bir sorun düzeltildi.
- Eksik WinRT CoreWebView2Notification.VibrationPattern API'si eklendi. Bu WinRT API'si,
kararlı bildirim API tanıtım sürüm notlarıyla birleştirilebilir; hemen yukarıdaki ''Web Bildirimi'' ve
WinRT için NotificationReceived'a bakın.
- WinForms WebView2 denetimindeki KeyDown olaylarının doğru ModifierKeys bilgilerini içermediği bir sorun düzeltildi.
- WinRT C# projeksiyonu için x86 düzeltildi.
- Çalışma zamanı güncellemesi sırasında olası yarış koşullarına karşı CreateCoreWebView2Environment ve GetAvailableCoreWebView2BrowserVersionString daha sağlam hale getirildi.
- WinRT C# projeksiyonu için x86 düzeltildi.
- C# WinRT projeksiyonu artık UWP'de çalışıyor.
- GeneratedFilesDir'in artık Visual Studio for C# WinRT projeksiyonunda görünmemesini sağlamak için bir sorun düzeltildi.
- .NET projeleri için bir SDK bağımlılığı düzeltildi.
- GetAvailableBrowserVersionString()'i eski bir WebView2Loader.dll ile çağırırken bir uyumluluk sorunu düzeltildi.
- wv2winrt tarafından oluşturulan kodu cpp20 ve /permissive- seçenekleriyle derlerken sorunlar düzeltildi.
- C# WinRT için .NET 8 TargetFramework eklendi, AOT (zamanından önce) uyumluluğu etkinleştirildi ve
çalışma zamanı düzenlemesi devre dışı bırakıldı.
- .NET projeleri için bir SDK bağımlılığı düzeltildi.
- Arm64'ün WindowsAppSDK 1.6 ile uyumsuzluğu düzeltildi.
- WinAppSDK durumundaki fazladan WebView2Loader.dll kaldırıldı. - CoreWebView2.AddWebResourceRequestedFilter'ı
CoreWebView2WebResourceRequestSourceKinds parametresi olmadan kullanmak artık kullanım dışıdır.
.NET CoreWebView2.AddWebResourceRequestedFilter Yöntemine bakın.
- CoreWebView2.AddWebResourceRequestedFilter'ı
CoreWebView2WebResourceRequestSourceKinds parametresi olmadan kullanmak artık kullanım dışıdır.
.NET CoreWebView2.AddWebResourceRequestedFilter Yöntemine bakın.
- C# WinRT için .NET 8 TargetFramework eklendi, AOT (zamanından önce) uyumluluğu etkinleştirildi ve çalışma zamanı düzenlemesi devre dışı bırakıldı.
- Promosyonlar
- Fluent Style Overlay Kaydırma Çubuğu için destek.
- WebMessageObjects API'sini, uygulama üzerinden oluşturulan WebView2 içeriğine ve diğer yönde CoreWebView2.PostWebMessage API'si üzerinden DOM nesnelerinin eklenmesine izin verecek şekilde güncelledik. Web içeriğine dosya sistemi erişimi sağlamak için
gönderilebilen bir dosya sistemi tutamacını temsil eden yeni bir web nesnesi türü ekledik.
- Farklı Kaydet işlemini programatik olarak gerçekleştirmenize izin veren Farklı Kaydet API'leri eklendi. Bu API'leri, varsayılan Farklı Kaydet iletişim kutusunu engellemek ve ardından sessizce kaydetmek veya Farklı Kaydet için kendi kullanıcı arayüzünüzü oluşturmak için kullanabilirsiniz. Bu API'ler yalnızca Farklı Kaydet iletişim kutusuyla ilgilidir, mevcut İndirme API'lerini kullanmaya devam eden İndirme iletişim kutusuyla ilgili değildir.
- Kalıcı olmayan bildirimler için Web Bildirimi desteği eklendi. CoreWebView2 için NotificationReceived olayı, web bildirimi işlemeyi kontrol ederek ana uygulama tarafından özelleştirmeye veya bastırmaya izin verir.
İşlenmemiş bildirimler varsayılan olarak WebView2'nin kullanıcı arayüzüne gider.
- WebMessageObjects API'sini, uygulama üzerinden oluşturulan WebView2 içeriğine ve diğer yönde CoreWebView2.PostWebMessage API'si üzerinden DOM nesnelerinin eklenmesine izin verecek şekilde güncelledik.
- Dosya sistemi erişimi sağlamak için web içeriğine gönderilebilen bir dosya sistemi tutamacını temsil eden yeni bir web nesnesi türü (CoreWebView2FileSystemHandle) ekledik.
- Kalıcı olmayan bildirimler için Web Bildirimi desteği ekledik.
CoreWebView2 için NotificationReceived olayı, web bildirimi işlemeyi kontrol ederek ana uygulama tarafından özelleştirmeye veya
bastırmaya izin verir. İşlenmemiş bildirimler varsayılan olarak WebView2'nin kullanıcı arayüzüne gider.
- Farklı Kaydet işlemini programlı olarak gerçekleştirmenize izin veren Farklı Kaydet API'leri ekledik. Bu API'leri varsayılan Farklı Kaydet iletişim kutusunu engellemek ve ardından sessizce kaydetmek veya Farklı Kaydet için kendi kullanıcı arayüzünüzü oluşturmak için kullanabilirsiniz. Bu API'ler yalnızca Farklı Kaydet iletişim kutusuyla ilgilidir, mevcut İndirme API'lerini kullanmaya devam eden İndirme iletişim kutusuyla ilgili değildir.
- Yeni bir ScreenCaptureStarting olayı eklendi. Bu olay, WebView2 ve/veya CoreWebView2Frame'e (veya onun alt iframe'lerinden herhangi birine) karşılık gelen iframe,
kullanıcı arayüzü gösterilmeden önce Ekran Yakalama API'sini kullanma izni istediğinde tetiklenir. Uygulama daha sonra
kullanıcı arayüzünün görüntülenmesini engelleyebilir veya
kullanıcı arayüzünün görüntülenmesine izin verebilir.
- Yeni bir SaveFileSecurityCheckStarting olayı eklendi. Uygulamanız, dosya yolunu, dosya adı uzantısını ve belge kaynak URI bilgilerini almak için bu olayda bir işleyici kaydedebilir. Daha sonra aşağıdakiler gibi eylemleri gerçekleştirmek için kendi kurallarınızı uygulayabilirsiniz:
- Dosya türü politikası hakkında varsayılan bir güvenlik uyarısı UI'si sunmadan dosyayı kaydetmeye izin verin.
- Kaydetmeyi iptal edin.
- Çalışma zamanı dosya türü politikalarını yönetmek için kendi kullanıcı arayüzünüzü oluşturun.
- API'ler
- Yeni bir SaveFileSecurityCheckStarting olayı eklendi. Bir geliştirici olarak, dosya yolunu,
dosya adı uzantısını ve belge kaynak URI bilgilerini almak için bu olaya bir işleyici kaydedebilirsiniz. Ardından, aşağıdakiler gibi eylemler yapmak için kendi kurallarınızı uygulayabilirsiniz:
- Dosya türü politikası hakkında varsayılan bir güvenlik uyarısı kullanıcı arayüzü sunmadan dosyayı kaydetmeye izin verin.
- Kaydetmeyi iptal edin.
- Çalışma zamanı dosya türü politikalarını yönetmek için kendi kullanıcı arayüzünüzü oluşturun.
- Yeni bir ScreenCaptureStarting olayı eklendi. Bu olay, WebView2 ve/veya CoreWebView2Frame'e (veya onun alt iframe'lerinden herhangi birine) karşılık gelen iframe, kullanıcı arayüzü gösterilmeden önce Ekran Yakalama API'sini kullanma izni istediğinde
tetiklenir. Bir geliştirici olarak, kullanıcı arayüzünün görüntülenmesini engellemeyi veya kullanıcı arayüzünün görüntülenmesine izin vermeyi seçebilirsiniz.
- CoreWebView2 .NET sınıfına, .NET ve COM arasında bir CoreWebView2 dönüştürmenize olanak tanıyan yeni bir GetComICoreWebView2 yöntemi eklendi. WinRT ve COM arasında bir CoreWebView2 dönüştürmenize olanak tanıyan yeni bir WinRT arayüzü eklendi. Bu, farklı dillerde yazılmış kitaplıklar arasında etkileşim kurmanızı sağlar.
- JavaScript zamanlayıcılarını sınırlamanıza izin vererek verimli kaynak yönetimi sağlayan yeni Kısıtlama Kontrolleri API'leri eklendi. Bu, bir WebView2 denetiminin görünür kalması gereken ancak daha az kaynak tüketmesi gereken senaryolarda (örneğin, kullanıcı içerikle etkileşimde bulunmadığında) yardımcı olur. Bu Kısıtlama Kontrolleri
- API'ler şunları yapmanızı sağlar:
- Farklı sayfa durumlarında (ön plan, arka plan ve yoğun kısıtlamalı arka plan) komut dosyası zamanlayıcılarını (setTimeout ve setInterval) özelleştirme.
- Seçili barındırılan iframe'lerde komut dosyası zamanlayıcılarını sınırlama. - Yeni bir RestartRequested olayı eklendi. RestartRequested olayı, WebView2'nin güncellemeleri veya yapılandırma değişikliklerini uygulamak için
yeniden başlatılması gerektiğinde tetiklenir. Bu API'yi, WebView2'nin ne zaman
yeniden başlatılması gerektiğini algılamak ve uygun eylemleri gerçekleştirmek için kullanabilirsiniz. RestartRequested olayının
argümanlarının Öncelik özelliği, yeniden başlatma isteğinin önceliğini belirtir:
- Yüksek, uygulamanın kullanıcıları mümkün olan en kısa sürede yeniden başlatmaya yönlendirmesi gerektiğini belirtir.
- Normal, uygulamanın kullanıcıları en iyi çaba temelinde yeniden başlatmaya yönlendirmesi gerektiğini belirtir. - Microsoft PKI Meta Veri sürümü: 13.0.0.0 --> 14.0.0.1
- Anlık Görüntüler sürümü: 126.0.2592.113 --> 129.0.2792.89
- Alt Kaynak Filtresi sürümü: 10.34.0.54 --> 10.34.0.55
- trustToken sürümü: 2024.8.165 --> 2024.10.1
- System.Threading.Channels sürümü: 7.0.0 --> 8.0.0
v2024.11.03
- Önyüz
- Yazılım güncelleme aracıyla ilgili bir hata düzeltildi:
''Yazılım güncellemelerini ara''ya tıkladığınızda, ''WebConnect için güncelleme mevcut ve indirilmeye hazır'' yazıyor,
ancak en yeni sürüm cihazınıza zaten yüklenmiş durumda.

v2024.09.01
- İlk yazılım sürümü
"
            SearchForSoftwareUpdate.Text = "Yazılım güncellemelerini kontrol edin"
        End If
        'initialisiere die Anzeige für die Einstellungen der Standard-Suchmaschine
        Dim WebConnectUserSettingsDisplaySettingsPath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\DisplaySettings"
        Dim WebConnectUserSettingsDefaultSearchEngineSettingsValueName As String = "DefaultSearchEngine"
        Dim DefaultSearchEngineExpectedValueGoogle As String = "Google"
        Dim DefaultSearchEngineExpectedValueBing As String = "Bing"
        Try
            ' Einmalige Abfrage des Registry-Werts
            Dim defaultSearchEngineCurrentValue As Object = Registry.GetValue(WebConnectUserSettingsDisplaySettingsPath, WebConnectUserSettingsDefaultSearchEngineSettingsValueName, Nothing)

            ' Prüfen, ob der Wert existiert und entsprechend reagieren
            If defaultSearchEngineCurrentValue IsNot Nothing Then
                Select Case defaultSearchEngineCurrentValue.ToString()
                    Case DefaultSearchEngineExpectedValueGoogle
                        Debug.WriteLine("Google ist die Standard-Suchmaschine")
                        GoogleDefault.Checked = True
                    Case DefaultSearchEngineExpectedValueBing
                        Debug.WriteLine("Bing ist die Standard-Suchmaschine")
                        BingDefault.Checked = True
                    Case Else
                End Select
            Else
                Debug.WriteLine("Registry-Wert für die Standard-Suchmaschine nicht gefunden.")
            End If
        Catch ex As Exception
            Debug.WriteLine("Fehler beim Zugriff auf die Registry: " & ex.Message)
        End Try
        'initialisiere die Anzeige für die Einstellungen des Standard-KI-ChatBots
        Dim WebConnectUserSettingsMagicAILinkSettingsPath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\MagicAILinkSettings"
        Dim WebConnectUserSettingsDefaultChatbotValueName As String = "DefaultChatbot"
        Dim DefaultChatbotExpectedValueMicrosoftCopilot As String = "Microsoft Copilot"
        Dim DefaultChatbotExpectedValueGoogleGemini As String = "Google Gemini"
        Dim DefaultChatbotExpectedValueChatGPT As String = "ChatGPT"
        Try
            ' Einmalige Abfrage des Registry-Werts
            Dim defaultChatbotCurrentValue As Object = Registry.GetValue(WebConnectUserSettingsMagicAILinkSettingsPath, WebConnectUserSettingsDefaultChatbotValueName, Nothing)
            ' Prüfen, ob der Wert existiert und entsprechend reagieren
            If defaultChatbotCurrentValue IsNot Nothing Then
                Select Case defaultChatbotCurrentValue.ToString()
                    Case DefaultChatbotExpectedValueMicrosoftCopilot
                        Debug.WriteLine("Microsoft Copilot ist der Standard-KI-Chatbot")
                        MicrosoftCopilotRadioButton.Checked = True
                    Case DefaultChatbotExpectedValueGoogleGemini
                        Debug.WriteLine("Google Gemini ist der Standard-KI-Chatbot")
                        GoogleGeminiRadioButton.Checked = True
                    Case DefaultChatbotExpectedValueChatGPT
                        Debug.WriteLine("ChatGPT ist der Standard-KI-Chatbot")
                        ChatGPTRadioButton.Checked = True
                    Case Else
                End Select
            Else
                Debug.WriteLine("Registry-Wert für den Standard-KI-Chatbot nicht gefunden.")
            End If
        Catch ex As Exception
            Debug.WriteLine("Fehler beim Zugriff auf die Registry: " & ex.Message)
        End Try

        'initialisiere die Anzeige für die Einstellungen der automatischen Software-Update-Benachrichtigung
        Dim WebConnectUserSettingsSoftwareUpdateSettingsPath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\SoftwareUpdateSettings"
        Dim WebConnectUserSettingsAlwaysCheckForUpdatesOnApplicationBootValueName As String = "AlwaysCheckForUpdatesOnApplicationBoot"
        Dim AlwaysCheckForUpdatesOnApplicationBootExpectedValueTrue As Boolean = True
        Dim AlwaysCheckForUpdatesOnApplicationBootExpectedValueFalse As Boolean = False
        Try
            ' Einmalige Abfrage des Registry-Werts
            Dim AlwaysCheckForUpdatesOnApplicationBootCurrentValue As Object = Registry.GetValue(WebConnectUserSettingsSoftwareUpdateSettingsPath, WebConnectUserSettingsAlwaysCheckForUpdatesOnApplicationBootValueName, Nothing)
            ' Prüfen, ob der Wert existiert und entsprechend reagieren
            If AlwaysCheckForUpdatesOnApplicationBootCurrentValue IsNot Nothing Then
                Select Case AlwaysCheckForUpdatesOnApplicationBootCurrentValue
                    Case AlwaysCheckForUpdatesOnApplicationBootExpectedValueTrue
                        Debug.WriteLine("Automatische Software-Update-Benachrichtigung ist aktiviert")
                        SearchForUpdatesOnApplicationBoot.Checked = True
                    Case AlwaysCheckForUpdatesOnApplicationBootExpectedValueFalse
                        Debug.WriteLine("Automatische Software-Update-Benachrichtigung ist deaktiviert")
                        SearchForUpdatesOnApplicationBoot.Checked = False
                    Case Else
                End Select
            Else
                Debug.WriteLine("Registry-Wert für die automatische Software-Update-Benachrichtigung nicht gefunden.")
            End If
        Catch ex As Exception
            Debug.WriteLine("Fehler beim Zugriff auf die Registry: " & ex.Message)
        End Try
        Timer.Interval = 2000
        Timer.Stop()
        WebConnectAdminSoftware.Visible = False
        Version.Text = Form1.Version
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Terminate.Click
        Me.Close()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        WebConnectRecoveryTool.ShowDialog()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        WebConnectAdminSoftware.ShowDialog()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
    End Sub
    Private Sub German_Click(sender As Object, e As EventArgs) Handles German.Click
        Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
        Dim LanguageValueName As String = "Language"
        Dim LanguageGermanValue As String = "de"
        Try
            Dim LanguageRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
            If LanguageRegistryKey Is Nothing Then
                LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
            End If
            LanguageRegistryKey.SetValue(LanguageValueName, LanguageGermanValue)
            LanguageRegistryKey.Close()

        Catch ex As Exception

        End Try
        Reboot.ShowDialog()
    End Sub

    Private Sub English_Click(sender As Object, e As EventArgs) Handles English.Click
        Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
        Dim LanguageValueName As String = "Language"
        Dim LanguageGermanValue As String = "en"
        Try
            Dim LanguageRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
            If LanguageRegistryKey Is Nothing Then
                LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
            End If
            LanguageRegistryKey.SetValue(LanguageValueName, LanguageGermanValue)
            LanguageRegistryKey.Close()

        Catch ex As Exception

        End Try
        Reboot.ShowDialog()

    End Sub

    Private Sub SoftwareUpdate_Click(sender As Object, e As EventArgs) Handles SoftwareUpdate.Click

    End Sub

    Private Sub VersionInfo_Click(sender As Object, e As EventArgs) Handles VersionInfo.Click
        clickLabelCounter += 1
        If clickLabelCounter = 1 Then
            Timer.Start()
        End If
        If clickLabelCounter >= 5 Then
            Timer.Stop()
            Label3.Visible = True
            clickLabelCounter = 0
        End If
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        clickLabelCounter = 0
        Timer.Stop()
    End Sub

    Private Sub Français_Click(sender As Object, e As EventArgs) Handles Français.Click
        Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
        Dim LanguageValueName As String = "Language"
        Dim LanguageGermanValue As String = "fr"
        Try
            Dim LanguageRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
            If LanguageRegistryKey Is Nothing Then
                LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
            End If
            LanguageRegistryKey.SetValue(LanguageValueName, LanguageGermanValue)
            LanguageRegistryKey.Close()

        Catch ex As Exception

        End Try
        Reboot.ShowDialog()
    End Sub

    Private Sub Español_Click(sender As Object, e As EventArgs) Handles Español.Click
        Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
        Dim LanguageValueName As String = "Language"
        Dim LanguageGermanValue As String = "es"
        Try
            Dim LanguageRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
            If LanguageRegistryKey Is Nothing Then
                LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
            End If
            LanguageRegistryKey.SetValue(LanguageValueName, LanguageGermanValue)
            LanguageRegistryKey.Close()

        Catch ex As Exception

        End Try
        Reboot.ShowDialog()
    End Sub

    Private Sub Italiano_Click(sender As Object, e As EventArgs) Handles Italiano.Click
        Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
        Dim LanguageValueName As String = "Language"
        Dim LanguageGermanValue As String = "it"
        Try
            Dim LanguageRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
            If LanguageRegistryKey Is Nothing Then
                LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
            End If
            LanguageRegistryKey.SetValue(LanguageValueName, LanguageGermanValue)
            LanguageRegistryKey.Close()

        Catch ex As Exception

        End Try
        Reboot.ShowDialog()
    End Sub

    Private Sub Türkçe_Click(sender As Object, e As EventArgs) Handles Türkçe.Click
        Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
        Dim LanguageValueName As String = "Language"
        Dim LanguageGermanValue As String = "tr"
        Try
            Dim LanguageRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
            If LanguageRegistryKey Is Nothing Then
                LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
            End If
            LanguageRegistryKey.SetValue(LanguageValueName, LanguageGermanValue)
            LanguageRegistryKey.Close()

        Catch ex As Exception

        End Try
        Reboot.ShowDialog()
    End Sub

    Private Async Sub SearchForSoftwareUpdate_Click(sender As Object, e As EventArgs) Handles SoftwareUpdate.Click

    End Sub

    'Wenn Google als Standard-Suchmaschine ausgewählt wird, wird der Wert in der Registry gespeichert
    Private Sub GoogleDefault_CheckedChanged(sender As Object, e As EventArgs) Handles GoogleDefault.CheckedChanged
        If GoogleDefault.Checked Then
            Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
            Dim SearchEngineValueName As String = "DefaultSearchEngine"
            Dim SearchEngineValue As String = "Google"
            Try
                Dim SearchEngineRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
                If SearchEngineRegistryKey Is Nothing Then
                    SearchEngineRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
                End If
                SearchEngineRegistryKey.SetValue(SearchEngineValueName, SearchEngineValue)
                SearchEngineRegistryKey.Close()

            Catch ex As Exception

            End Try
        End If
    End Sub
    'Wenn Bing als Standard-Suchmaschine ausgewählt wird, wird der Wert in der Registry gespeichert
    Private Sub BingDefault_CheckedChanged(sender As Object, e As EventArgs) Handles BingDefault.CheckedChanged
        If BingDefault.Checked Then
            Dim DisplayRegistryKey As String = "Software\WebConnect\User\Settings\DisplaySettings"
            Dim SearchEngineValueName As String = "DefaultSearchEngine"
            Dim SearchEngineValue As String = "Bing"
            Try
                Dim SearchEngineRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(DisplayRegistryKey, True)
                If SearchEngineRegistryKey Is Nothing Then
                    SearchEngineRegistryKey = Registry.CurrentUser.CreateSubKey(DisplayRegistryKey)
                End If
                SearchEngineRegistryKey.SetValue(SearchEngineValueName, SearchEngineValue)
                SearchEngineRegistryKey.Close()

            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub SearchForSoftwareUpdate_Click_1(sender As Object, e As EventArgs) Handles SearchForSoftwareUpdate.Click
        SoftwareUpdateTool.ShowDialog()
    End Sub

    Public Sub OpenMacroEditor()
        ' Initialisiere MacroEditor und übergebe die aktuelle Instanz von Form1
        'MacroEditor = New MacroEditor(Form1)
        'MacroEditor.Show()
    End Sub

    Private Sub RunMacroEditor_Click(sender As Object, e As EventArgs)
        OpenMacroEditor()

    End Sub

    Private Sub SearchForUpdatesOnApplicationBoot_CheckedChanged(sender As Object, e As EventArgs) Handles SearchForUpdatesOnApplicationBoot.CheckedChanged
        If SearchForUpdatesOnApplicationBoot.Checked = True Then
            Dim SoftwareUpdateRegistryKey As String = "Software\WebConnect\User\Settings\SoftwareUpdateSettings"
            Dim AlwaysCheckForUpdatesOnApplicationBootValueName As String = "AlwaysCheckForUpdatesOnApplicationBoot"
            Dim AlwaysCheckForUpdatesOnApplicationBootValue As Boolean = True
            Try
                Dim AlwaysCheckForUpdatesOnApplicationBootRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(SoftwareUpdateRegistryKey, True)
                If AlwaysCheckForUpdatesOnApplicationBootRegistryKey Is Nothing Then
                    AlwaysCheckForUpdatesOnApplicationBootRegistryKey = Registry.CurrentUser.CreateSubKey(SoftwareUpdateRegistryKey)
                End If
                AlwaysCheckForUpdatesOnApplicationBootRegistryKey.SetValue(AlwaysCheckForUpdatesOnApplicationBootValueName, AlwaysCheckForUpdatesOnApplicationBootValue)
                AlwaysCheckForUpdatesOnApplicationBootRegistryKey.Close()
            Catch ex As Exception
            End Try
        End If
        If SearchForUpdatesOnApplicationBoot.Checked = False Then
            Dim SoftwareUpdateRegistryKey As String = "Software\WebConnect\User\Settings\SoftwareUpdateSettings"
            Dim AlwaysCheckForUpdatesOnApplicationBootValueName As String = "AlwaysCheckForUpdatesOnApplicationBoot"
            Dim AlwaysCheckForUpdatesOnApplicationBootValue As Boolean = False
            Try
                Dim AlwaysCheckForUpdatesOnApplicationBootRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(SoftwareUpdateRegistryKey, True)
                If AlwaysCheckForUpdatesOnApplicationBootRegistryKey Is Nothing Then
                    AlwaysCheckForUpdatesOnApplicationBootRegistryKey = Registry.CurrentUser.CreateSubKey(SoftwareUpdateRegistryKey)
                End If
                AlwaysCheckForUpdatesOnApplicationBootRegistryKey.SetValue(AlwaysCheckForUpdatesOnApplicationBootValueName, AlwaysCheckForUpdatesOnApplicationBootValue)
                AlwaysCheckForUpdatesOnApplicationBootRegistryKey.Close()
            Catch ex As Exception
            End Try
        End If

    End Sub

    Private Sub MicrosoftCopilotRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MicrosoftCopilotRadioButton.CheckedChanged
        If MicrosoftCopilotRadioButton.Checked = True Then
            Dim MagicAILinkRegistryKey As String = "Software\WebConnect\User\Settings\MagicAILinkSettings"
            Dim MagicAILinkValueName As String = "DefaultChatbot"
            Dim MagicAILinkValue As String = "Microsoft Copilot"
            Try
                Dim DefaultChatbotRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(MagicAILinkRegistryKey, True)
                If DefaultChatbotRegistryKey Is Nothing Then
                    DefaultChatbotRegistryKey = Registry.CurrentUser.CreateSubKey(MagicAILinkRegistryKey)
                End If
                DefaultChatbotRegistryKey.SetValue(MagicAILinkValueName, MagicAILinkValue)
                PendingAIChanges = True
                DefaultChatbotRegistryKey.Close()
            Catch ex As Exception

            End Try


            If Form1.AIWebView IsNot Nothing Then
                Form1.AIWebView.CoreWebView2.Navigate("https://copilot.microsoft.com/")
                PendingAIChanges = False
            End If
        End If


    End Sub

    Private Sub GoogleGeminiRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GoogleGeminiRadioButton.CheckedChanged
        If GoogleGeminiRadioButton.Checked = True Then
            Dim MagicAILinkRegistryKey As String = "Software\WebConnect\User\Settings\MagicAILinkSettings"
            Dim MagicAILinkValueName As String = "DefaultChatbot"
            Dim MagicAILinkValue As String = "Google Gemini"
            Try
                Dim DefaultChatbotRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(MagicAILinkRegistryKey, True)
                If DefaultChatbotRegistryKey Is Nothing Then
                    DefaultChatbotRegistryKey = Registry.CurrentUser.CreateSubKey(MagicAILinkRegistryKey)
                End If
                DefaultChatbotRegistryKey.SetValue(MagicAILinkValueName, MagicAILinkValue)
                PendingAIChanges = True
                DefaultChatbotRegistryKey.Close()
            Catch ex As Exception

            End Try

            If Form1.AIWebView IsNot Nothing Then
                Form1.AIWebView.CoreWebView2.Navigate("https://gemini.google.com/app?hl=de")
                PendingAIChanges = False

            End If
        End If
    End Sub

    Private Sub ChatGPTRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ChatGPTRadioButton.CheckedChanged
        If ChatGPTRadioButton.Checked = True Then
            Dim MagicAILinkRegistryKey As String = "Software\WebConnect\User\Settings\MagicAILinkSettings"
            Dim MagicAILinkValueName As String = "DefaultChatbot"
            Dim MagicAILinkValue As String = "ChatGPT"
            Try
                Dim DefaultChatbotRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(MagicAILinkRegistryKey, True)
                If DefaultChatbotRegistryKey Is Nothing Then
                    DefaultChatbotRegistryKey = Registry.CurrentUser.CreateSubKey(MagicAILinkRegistryKey)
                End If
                DefaultChatbotRegistryKey.SetValue(MagicAILinkValueName, MagicAILinkValue)
                PendingAIChanges = True
                DefaultChatbotRegistryKey.Close()
            Catch ex As Exception

            End Try

            If Form1.AIWebView IsNot Nothing Then
                Form1.AIWebView.CoreWebView2.Navigate("https://chatgpt.com/")
                PendingAIChanges = False

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MacroEditor.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        MacroEditor.ShowDialog()
    End Sub












    ' Die Funktion muss asynchron sein, daher die Rückgabe von Task(Of String)
End Class