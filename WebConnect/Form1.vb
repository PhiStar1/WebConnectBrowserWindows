'WebConnect by PhilConnected (Phileas Melchert)

'Import von Bibliotheken
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
Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Reflection.Emit
Imports CefSharp.WinForms
Imports System.Diagnostics.Tracing
Imports Microsoft.CodeAnalysis.Emit
Imports Microsoft.CodeAnalysis

Public Class Form1
    'Diese Form wird angezeigt, wenn die Anwendung gestartet wird.
    'Diese Form zeigt dem Benutzer die Benutzeroberfläche der Anwendung.
    'Das bringt folgendes: Der Benutzer kann im Internet surfen und verschiedene Funktionen der Anwendung verwenden.
    'Auf der Hauptbenutzeroberfläche wird angezeigt: Menüleiste, TabControl, TextBox, Zurück-Button, Vor-Button, Suchen-Button, Aktualisieren-Button, Aktualisieren abbrechen-Button, Neuer Tab-Button, Verknüpfungen-Button, MagicAI-Link-Button, Startseite-Button, WebView-Komponente
    'Variablen
    Public WithEvents WebView21 As New WebView2()
    'Import von DLLs


    'Sprachvariablen
    Public Language
    <DllImport("user32.dll")>
    Public Shared Function RegisterHotKey(hWnd As IntPtr, id As Integer, fsModifiers As Integer, vk As Integer) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function UnregisterHotKey(hWnd As IntPtr, id As Integer) As Boolean
    End Function

    'Konstanten
    Private Const MOD_ALT As Integer = &H1
    Private Const MOD_CONTROL As Integer = &H2
    Private Const WM_HOTKEY As Integer = &H312
    Private Const MOD_SHIFT As Integer = &H4

    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Tastenkombination drückt.
    'Dieser Sub wird verwendet, um Hotkeys zu verarbeiten.
    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Überprüfung, ob die Nachricht ein Hotkey ist
        Debug.WriteLine("Start of protected overrides sub: WndProc(ByRef m As Message)")

        ' Überprüfung, ob die Nachricht ein Hotkey ist
        If m.Msg = WM_HOTKEY Then
            ' Ausgabe der Hotkey-Nachricht
            Debug.WriteLine("   If m.Msg = WM_HOTKEY Then")
            Debug.WriteLine("   m.Msg = " & m.Msg)
            Debug.WriteLine("       Select Case m.WParam.ToInt32()")
            Debug.WriteLine("       m.WParam.ToInt32() = " & m.WParam.ToInt32)
            ' Hotkey-Logik
            Select Case m.WParam.ToInt32()
                ' Alt + E oder CTRL + D oder CTRL + E oder CTRL + K oder CTRL + L
                Case 1
                    ' Fokus auf TextBox1 setzen und Text auswählen
                    Debug.WriteLine("           Case 1: Alt + E oder CTRL + D/E/K/L")
                    Debug.WriteLine("               TextBox1.Focus()")
                    TextBox1.Focus()
                    Debug.WriteLine("               TextBox1.SelectAll()")
                    TextBox1.SelectAll()

                Case 2 ' Alt + F
                    ' Fokus auf WebConnectToolStripMenuItem setzen
                    Debug.WriteLine("           Case 2: Alt + F")
                    Debug.WriteLine("               WebConnectToolStripMenuItem.Select()")
                    WebConnectToolStripMenuItem.Select()

                Case 3 ' CTRL + N oder CTRL + T
                    ' Neuen Tab öffnen
                    Debug.WriteLine("           Case 3: CTRL + N oder CTRL + T")
                    Debug.WriteLine("               newTab()")
                    newTab()

                Case 4 ' CTRL + W
                    ' Aktuellen Tab schließen
                    Debug.WriteLine("           Case 4: CTRL + W")
                    Debug.WriteLine("               If TabControl1.SelectedIndex >= 0 Then") ' Wert von m.WParam ausgeben
                    Debug.WriteLine("               TabControl1.SelectedIndex = " & TabControl1.SelectedIndex) ' Wert von m.WParam ausgeben
                    ' Wenn ein Tab ausgewählt ist
                    If TabControl1.SelectedIndex >= 0 Then
                        ' Ausgewählten Tab finden
                        Debug.WriteLine("                   Dim selectedTab As TabPage = TabControl1.TabPages(TabControl1.SelectedIndex)") ' Wert von m.WParam ausgeben
                        Dim selectedTab As TabPage = TabControl1.TabPages(TabControl1.SelectedIndex)
                        Debug.WriteLine("                   selectedTab = -->") ' Wert von m.WParam ausgeben
                        Debug.WriteLine(TabControl1.TabPages(TabControl1.SelectedIndex)) ' Wert von m.WParam ausgeben
                        Debug.WriteLine("                   Selected Tab: " & selectedTab.Text)
                        Debug.WriteLine("                   Dim webView As Microsoft.Web.WebView2.WinForms.WebView2 = Nothing")
                        Dim webView As Microsoft.Web.WebView2.WinForms.WebView2 = Nothing
                        Debug.WriteLine("                   webView = -->")
                        Debug.WriteLine(webView)
                        ' WebView2-Steuerelement im ausgewählten Tab finden
                        For Each control As Control In selectedTab.Controls
                            ' Wenn das Steuerelement ein WebView2-Steuerelement ist
                            Debug.WriteLine("                    For Each control As Control In selectedTab.Controls")
                            Debug.WriteLine("                        If TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2 Then")

                            If TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2 Then
                                ' WebView2-Steuerelement zuweisen
                                Debug.WriteLine("                        TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2")
                                Debug.WriteLine("                            webView = CType(control, Microsoft.Web.WebView2.WinForms.WebView2)")

                                webView = CType(control, Microsoft.Web.WebView2.WinForms.WebView2)
                                Debug.WriteLine("                            webView = --> ")
                                Debug.WriteLine(CType(control, Microsoft.Web.WebView2.WinForms.WebView2))
                                Debug.WriteLine("                            Exit For")
                                ' Schleife beenden
                                Exit For
                                Debug.WriteLine("                        End If")
                            End If
                            Debug.WriteLine("                    Next")
                        Next

                        ' WebView2-Steuerelement freigeben
                        Debug.WriteLine("                    If webView IsNot Nothing Then")
                        Debug.WriteLine("                    webView = -->")
                        Debug.WriteLine(webView)
                        ' Wenn das WebView2-Steuerelement gefunden wurde
                        If webView IsNot Nothing Then
                            ' WebView2-Steuerelement und Prozess freigeben
                            Try

                                Debug.WriteLine("                        Try")
                                Debug.WriteLine("                            If webView.CoreWebView2 IsNot Nothing Then")
                                Debug.WriteLine("                            webView.CoreWebView2 = -->")
                                Debug.WriteLine(webView.CoreWebView2)
                                ' Wenn das CoreWebView2-Objekt vorhanden ist
                                If webView.CoreWebView2 IsNot Nothing Then
                                    ' WebView2-Steuerelement und Prozess freigeben
                                    Debug.WriteLine("                                webView.Dispose()")
                                    webView.Dispose() ' Steuerelement und Prozess freigeben
                                    Debug.WriteLine("                            End If")
                                End If

                            Catch ex As Exception
                                ' Fehlerbehandlung
                                Debug.WriteLine("                        Catch ex As Exception")
                                Debug.WriteLine(ex.Message)
                                Debug.WriteLine("                        End Try")
                            End Try
                            Debug.WriteLine("                    End If")
                        End If

                        ' Tab schließen
                        Debug.WriteLine("                    TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)")
                        TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
                        Debug.WriteLine("                End If")
                    End If

                Case 5 ' ALT + S
                    'Shortcuts öffnen
                    Debug.WriteLine("            Case 5: ALT + S")
                    Try
                        'Launcher.ShowDialog()
                        Debug.WriteLine("                Try")
                        Debug.WriteLine("                    Launcher.ShowDialog()")
                        Launcher.ShowDialog()

                    Catch ex As System.InvalidOperationException
                        ' Fehlerbehandlung
                        Debug.WriteLine("                Catch ex As System.InvalidOperationException")

                        Debug.WriteLine(ex.Message)
                        Debug.WriteLine("                End Try")

                    End Try

                Case 6 ' CTRL + TAB
                    ' Tab nach rechts wechseln
                    Debug.WriteLine("            Case 6: CTRL + TAB")
                    Debug.WriteLine("                If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then")
                    Debug.WriteLine("TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                    Debug.WriteLine("TabControl1.TabCount = " & TabControl1.TabCount - 1)
                    ' Wenn der aktuelle Tab nicht der letzte Tab ist
                    If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                        ' Wechsel zum nächsten Tab
                        Debug.WriteLine("                    TabControl1.SelectedIndex += 1")
                        TabControl1.SelectedIndex += 1
                        Debug.WriteLine("                    TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                        ' Wenn der aktuelle Tab der letzte Tab ist
                    Else
                        ' Wechsel zum ersten Tab
                        Debug.WriteLine("                Else")
                        Debug.WriteLine("                    TabControl1.SelectedIndex = 0")
                        TabControl1.SelectedIndex = 0
                        Debug.WriteLine("                End If")
                    End If

                Case 7 ' CTRL + SHIFT + TAB
                    ' Tab nach links wechseln
                    Debug.WriteLine("            Case 7: CTRL + SHIFT + TAB")
                    Debug.WriteLine("                If TabControl1.SelectedIndex > 0 Then")
                    Debug.WriteLine("                TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                    ' Wenn der aktuelle Tab nicht der erste Tab ist
                    If TabControl1.SelectedIndex > 0 Then
                        ' Wechsel zum vorherigen Tab
                        Debug.WriteLine("                    TabControl1.SelectedIndex -= 1")
                        TabControl1.SelectedIndex -= 1
                        Debug.WriteLine("                    TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                        ' Wenn der aktuelle Tab der erste Tab ist
                    Else
                        ' Wechsel zum letzten Tab
                        Debug.WriteLine("                Else")
                        Debug.WriteLine("                    TabControl1.SelectedIndex = TabControl1.TabCount - 1")
                        TabControl1.SelectedIndex = TabControl1.TabCount - 1
                        Debug.WriteLine("                    TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                        Debug.WriteLine("               End If")
                    End If
                    Debug.WriteLine("        End Select")
                Case 8 'CTRL + .
                    'MagicAI-Link ausführen
                    MagicAILinkExecute()
            End Select
            Debug.WriteLine("    End If")
        End If

        ' Zusätzliche Logik für Case 1 (Tab-Wechsel) innerhalb der gleichen Hotkey-Nachricht
        Debug.WriteLine("   If m.Msg = WM_HOTKEY AndAlso m.WParam.ToInt32() = 1 Then")
        Debug.WriteLine("   m.Msg = " & m.Msg)
        Debug.WriteLine("   WM_HOTKEY = " & WM_HOTKEY)
        'Debug.WriteLine("   m.WParam.ToInt32() = " & m.WParam.ToInt32)
        ' Wenn die Hotkey-Nachricht für den Tab-Wechsel ist
        If m.Msg = WM_HOTKEY AndAlso m.WParam.ToInt32() = 1 Then
            ' Tab-Wechsel-Logik
            Debug.WriteLine("        If TabControl1.SelectedIndex > 0 Then")
            Debug.WriteLine("        TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
            ' Wenn der aktuelle Tab nicht der erste Tab ist
            If TabControl1.SelectedIndex > 0 Then
                ' Wechsel zum linken Tab
                Debug.WriteLine("            TabControl1.SelectedIndex -= 1")
                TabControl1.SelectedIndex -= 1
                Debug.WriteLine("            TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                ' Wenn der aktuelle Tab der erste Tab ist
            Else
                ' Wechsel zum rechten Tab, wenn kein linker Tab mehr vorhanden ist
                Debug.WriteLine("        Else")
                Debug.WriteLine("            TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1")
                TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1
                Debug.WriteLine("            TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                Debug.WriteLine("        End If")
            End If
            Debug.WriteLine("    End If")
        End If

        ' Ende der Methode
        Debug.WriteLine("    MyBase.WndProc(m)")
        ' Weiterleitung der Nachricht an die Basisklasse
        Try

            MyBase.WndProc(m)
        Catch ex As System.InvalidCastException
            ' Fehlerbehandlung
            Debug.WriteLine(ex.Message)
        End Try
        Debug.WriteLine("End of protected overrides sub: WndProc")

    End Sub



    'Dieser Sub wird ausgeführt, wenn der Benutzer CTRL + D drückt.
    'Dieser Sub wird verwendet, um den Fokus auf TextBox1 zu setzen und den Text auszuwählen.
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Überprüfen, ob Ctrl + D gedrückt wird
        Debug.WriteLine("Start of private sub: Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
        Debug.WriteLine("    If e.Control AndAlso e.KeyCode = Keys.D Then")
        Debug.WriteLine("    e.Control = " & e.Control)
        Debug.WriteLine("    e.KeyCode = " & e.KeyCode)
        ' Wenn Ctrl + D gedrückt wird
        If e.Control AndAlso e.KeyCode = Keys.D Then
            ' Wenn WebView2 fokussiert ist, Fokus auf TextBox1 setzen
            ' Verhindern, dass der Tastendruck von WebView2 verarbeitet wird
            Debug.WriteLine("        e.Handled = True")
            e.Handled = True
            Debug.WriteLine("        e.Handled = " & e.Handled)
            Debug.WriteLine("        TextBox1.Select()")
            TextBox1.Select()
            Debug.WriteLine("    End If")
        End If
        Debug.WriteLine("End of private sub: Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
    End Sub

    'Variablen deklarieren. Diese Variablen werden für Software-Updates verwendet.
    Public downloadVersion
    Public Version As String

    'Imprt von DLLs user32

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr

    End Function
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean

    End Function

    'Definieren von Variablen
    'BootCompleted ist dafür da, um zu überprüfen, ob der Bootvorgang abgeschlossen ist.
    Private BootCompleted = False
    'OpenLinkOnBoot ist dafür da, um zu überprüfen, ob ein Link geöffnet werden soll, wenn der Bootvorgang abgeschlossen ist.
    Public OpenLinkOnBoot As Boolean = False
    'SW_HIDE ist dafür da, um das Fenster zu verstecken.
    Public SW_HIDE As Integer = 0
    'SW_SHOW ist dafür da, um das Fenster anzuzeigen.
    Public SW_SHOW As Integer = 5
    'Fullscreen ist dafür da, um zu überprüfen, ob das Fenster im Vollbildmodus ist.
    Public Fullscreen As Boolean = False
    'taskbarHandle ist dafür da, um den Handle der Taskleiste zu speichern.
    Public taskbarHandle As IntPtr
    'isFullscreen ist dafür da, um zu überprüfen, ob das Fenster im Vollbildmodus ist.
    Public isFullscreen As Boolean = False
    'Private WithEvents KeyPressTimer As New Timer()
    'Private mouseTimer As New Timer()
    'elementVisible ist dafür da, um zu überprüfen, ob die Elemente sichtbar sind.
    Public elementsVisible As Boolean = True
    'originalWebViewBounds ist dafür da, um die ursprünglichen Grenzen des WebViews zu speichern.
    Public originalWebViewBounds As Rectangle
    'originalFormBounds ist dafür da, um die ursprünglichen Grenzen des Formulars zu speichern.
    Public originalFormBounds As Rectangle
    'originalWindowState ist dafür da, um den ursprünglichen Fensterzustand zu speichern.
    Public originalWindowState As FormWindowState
    'originalTabControlBounds ist dafür da, um die ursprünglichen Grenzen des TabControls zu speichern.
    Public originalTabControlBounds As Rectangle
    'TabControlLocationX ist dafür da, um die X-Koordinate des TabControls zu speichern.
    Public TabControlLocationX As Integer = 0
    'TabControlLocation ist dafür da, um die Position des TabControls zu speichern.
    Public TabControlLocation As Point
    'TabControlHeight ist dafür da, um die Höhe des TabControls zu speichern.
    Public TabControlHeight As Integer = 882
    'DXTabControlWidth ist dafür da, um die Breite des DXTabControls zu speichern.
    Public DXTabControlWidth As Integer = 1721
    'pipeThread ist dafür da, um den Thread für die Pipe zu speichern.
    Public pipeThread As Thread
    'Errorcode ist dafür da, um den Fehlercode zu speichern.
    Public Errorcode As String
    ' Public macroEditor As MacroEditor
    'TextBox1Text ist dafür da, um den Text des TextBox1 zu speichern.
    Private TextBox1Text As String
    'MouseOnTab ist dafür da, um den Tab zu speichern, auf dem sich die Maus befindet.
    Private MouseOnTab As TabPage = Nothing
    Public webView As WebView2
    'AIWebView ist dafür da, um den AIWebView zu speichern.
    Public AIWebView As WebView2
    'spacing ist dafür da, um den Abstand in Pixeln zu speichern.
    Private Const spacing As Integer = 10 ' Abstand in Pixeln
    Public AdminMode As Boolean = True



    'Dieser Sub wird ausgeführt, wenn der Benutzer eine Taste drückt.
    'Dieser Sub wird für Befehle verwendet, die der Benutzer in textBox1 eingibt.
    Private Sub KeyPress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Überprüfen, ob die TextBox1 den Fokus hat
        Debug.WriteLine("Start of private sub: KeyPress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
        Debug.WriteLine("    If TextBox1.Focused Then")
        Debug.WriteLine("    TextBox1.Focused = " & TextBox1.Focused)
        If TextBox1.Focused Then
            ' Überprüfen, ob die Enter-Taste gedrückt wird
            Debug.WriteLine("        If e.KeyCode = Keys.Enter Then")
            Debug.WriteLine("        e.KeyCode = " & e.KeyCode)
            If e.KeyCode = Keys.Enter Then
                e.SuppressKeyPress = True 'verhindert dass beim Aufruf einer Internetseite ein Ton abgespielt wird
                SearchURL()
            End If


            Debug.WriteLine("   End If")
        End If

        Debug.WriteLine("End of private sub: KeyPress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")

    End Sub

    Private Sub NavigatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigationToolStripMenuItem.Click

    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geschlossen wird.
    'Dieser Sub wird verwendet, um die Hotkeys zu deaktivieren.
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Alle Hotkeys deaktivieren
        Debug.WriteLine("Start of sub: Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing")
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 1)")
        UnregisterHotKey(Me.Handle, 1)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 2)")
        UnregisterHotKey(Me.Handle, 2)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 3)")
        UnregisterHotKey(Me.Handle, 3)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 4)")
        UnregisterHotKey(Me.Handle, 4)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 5)")
        UnregisterHotKey(Me.Handle, 5)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 6)")
        UnregisterHotKey(Me.Handle, 6)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 7)")
        UnregisterHotKey(Me.Handle, 7)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 8)")
        UnregisterHotKey(Me.Handle, 8)
        Debug.WriteLine("End of sub: Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing")
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster den Fokus verliert.
    'Dieser Sub wird verwendet, um die Hotkeys zu deaktivieren.
    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        ' Alle Hotkeys deaktivieren
        Debug.WriteLine("Start of sub: Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate")
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 1)")
        UnregisterHotKey(Me.Handle, 1)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 2)")
        UnregisterHotKey(Me.Handle, 2)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 3)")
        UnregisterHotKey(Me.Handle, 3)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 4)")
        UnregisterHotKey(Me.Handle, 4)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 5)")
        UnregisterHotKey(Me.Handle, 5)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 6)")
        UnregisterHotKey(Me.Handle, 6)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 7)")
        UnregisterHotKey(Me.Handle, 7)
        Debug.WriteLine("    UnregisterHotKey(Me.Handle, 8)")
        UnregisterHotKey(Me.Handle, 8)

        Debug.WriteLine("End of sub: Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate")
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster den Fokus erhält.
    'Dieser Sub wird verwendet, um die Hotkeys zu aktivieren.
    Private Sub Form1_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        ' Alle Hotkeys aktivieren
        Debug.WriteLine("Start of sub:Form1_Activate(sender As Object, e As EventArgs) Handles Me.Activated")
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.D)")
        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.D)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.E)")
        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.E)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.K)")
        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.K)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.L)")
        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.L)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_ALT, Keys.E)")
        RegisterHotKey(Me.Handle, 1, MOD_ALT, Keys.E)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 2, MOD_ALT, Keys.F)")
        RegisterHotKey(Me.Handle, 2, MOD_ALT, Keys.F)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.N)")
        RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.N)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.T)")
        RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.T)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W & Keys.Shift)")
        RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W & Keys.Shift)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W)")
        RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 5, MOD_ALT, Keys.S)")
        RegisterHotKey(Me.Handle, 5, MOD_ALT, Keys.S)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 6, MOD_CONTROL, Keys.Tab)")
        RegisterHotKey(Me.Handle, 6, MOD_CONTROL, Keys.Tab)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 7, MOD_CONTROL Or MOD_SHIFT, Keys.Shift)")
        RegisterHotKey(Me.Handle, 7, MOD_CONTROL Or MOD_SHIFT, Keys.Shift)
        Debug.WriteLine("        RegisterHotKey(Me.Handle, 7, Keys.OemPeriod)")
        RegisterHotKey(Me.Handle, 8, MOD_CONTROL, Keys.OemPeriod)
        Debug.WriteLine("End of sub: Form1_Activate(sender As Object, e As EventArgs) Handles Me.Activated")
    End Sub

    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird verwendet, um die Einstellungen zu laden.
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        Debug.WriteLine("Welcome to WebConnect Bootloader v2.0 for WebConnect for Windows")
        Debug.WriteLine("Preparing boot... Wait a minute!")
        'Registry-Keys erstellen für den Einstellungsspeicher
        'Registry-Einträge für die Anzeigeeinstellungen wie z. B. die Sprache
        Dim RegKeyPathDisplaySettings As String = "Software\WebConnect\User\Settings\DisplaySettings"
        Dim LanguageValueName = "Language"
        Dim defaultLanguageValue As String = "en"
        Dim DefaultSearchEngineValueName = "DefaultSearchEngine"
        Dim DefaultSearchEngineValue As String = "Google"

        Try
            ' Öffne den Registry-Schlüssel im Schreibmodus
            Dim LanguageRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathDisplaySettings, True)

            ' Falls der Schlüssel nicht existiert, erstelle ihn
            If LanguageRegistryKey Is Nothing Then
                LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathDisplaySettings)
                Debug.WriteLine("LanguageRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathDisplaySettings)")
            End If

            ' Überprüfe, ob der Wert für 'Language' existiert, falls nicht, setze ihn
            If LanguageRegistryKey.GetValue(LanguageValueName, Nothing) Is Nothing Then
                LanguageRegistryKey.SetValue(LanguageValueName, defaultLanguageValue)
            End If

            ' Überprüfe, ob der Wert für 'DefaultSearchEngine' existiert, falls nicht, setze ihn
            If LanguageRegistryKey.GetValue(DefaultSearchEngineValueName, Nothing) Is Nothing Then
                LanguageRegistryKey.SetValue(DefaultSearchEngineValueName, DefaultSearchEngineValue)
            End If

            ' Schließe den Registry-Schlüssel
            LanguageRegistryKey.Close()

        Catch ex As Exception
            ' Fehlerbehandlung
            MessageBox.Show("Error: " & ex.Message)
        End Try
        'Registry-Eintrage für die MagicAI Link-Einstellungen, wie z. B. der Standard-KI-Chatbot
        Dim RegKeyPathMagicAILinkSettings As String = "Software\WebConnect\User\Settings\MagicAILinkSettings"
        Dim DefaultAIChatbotValueName = "DefaultChatbot"
        Dim DefaultAIChatbotValue As String = "Microsoft Copilot"
        Try
            Dim AIChatbotRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMagicAILinkSettings, True)
            If AIChatbotRegistryKey Is Nothing Then
                AIChatbotRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMagicAILinkSettings)
                Debug.WriteLine("AIChatbotRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMagicAILinkSettings)")
            End If
            If AIChatbotRegistryKey.GetValue(DefaultAIChatbotValueName, Nothing) Is Nothing Then
                AIChatbotRegistryKey.SetValue(DefaultAIChatbotValueName, DefaultAIChatbotValue)
            End If
            AIChatbotRegistryKey.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        'Registry-Einträge für die Software-Updater-Einstellungen wie z. B. Beim Start überprüfen ob Updates verfügbar sind
        'Software-Updates sorgen dafür, dass die Anwendung immer auf dem neuesten Stand ist. Das heißt, dass die Anwendung immer die neuesten Funktionen und Verbesserungen enthält.
        'Ohne Software-Updates können Sicherheitslücken und Fehler in der Anwendung auftreten sowie manche Webseiten nicht mehr korrekt angezeigt werden.
        'Während des Software-Update-Prozesses wird die Anwendung aktualisiert und neu gestartet. Das bedeutet, dass die Anwendung während des Software-Update-Prozesses nicht verwendet werden kann.
        'Während des Software-Update-Prozesses ist dein Gerät nicht auszuschalten, neu zu starten, in den Ruhezustand zu versetzen oder das Update-Tool zu schließen, da das Software-Update sonst abgebrochen wird und WebConnect dadürch beschädigt werden kann.
        'Eine beschädigte WebConnect-Installation erkennt man daran, dass folgender Fehler angezeigt wird: "Failed to boot WebConnect Application for Windows."
        Dim RegKeyPathSoftwareUpdateSettings As String = "Software\WebConnect\User\Settings\SoftwareUpdateSettings"
        Dim CheckForUpdatesOnStartupValueName = "AlwaysCheckForUpdatesOnApplicationBoot"
        Dim CheckForUpdatesOnStartupValue As Boolean = True
        Try
            Dim CheckForUpdatesOnStartupRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathSoftwareUpdateSettings, True)
            If CheckForUpdatesOnStartupRegistryKey Is Nothing Then
                CheckForUpdatesOnStartupRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathSoftwareUpdateSettings)
                Debug.WriteLine("CheckForUpdatesOnStartupRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathSoftwareUpdaterSettings)")
            End If
            If CheckForUpdatesOnStartupRegistryKey.GetValue(CheckForUpdatesOnStartupValueName, Nothing) Is Nothing Then
                CheckForUpdatesOnStartupRegistryKey.SetValue(CheckForUpdatesOnStartupValueName, CheckForUpdatesOnStartupValue)
            End If
            CheckForUpdatesOnStartupRegistryKey.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        'Registry-Einträge für die Administratoreinstellungen
        'Registry-Einträge für MainWindow/Window
        Dim RegKeyPathMainWindowWindowSettings As String = "Software\WebConnect\System\Designer values\MainWindow\Window"
        Dim RegKeyPathMainWindowWindowAutoScrollMarginSettings As String = "Software\WebConnect\System\Designer values\MainWindow\Window\AutoScrollMargin"
        Dim MainWindowWindowNameValueName = "MainWindowWindowName"
        Dim MainWindowWindowNameValue As String = "WebConnect für Windows"
        Dim MainWindowWindowAcceptButtonValueName = "MainWindowWindowAcceptButton"
        Dim MainWindowWindowAcceptButtonValue As String = "(None)"
        Dim MainWindowWindowAccessibleDescriptionValueName = "MainWindowWindowAccessibleDescription"
        Dim MainWindowWindowAccessibleDescriptionValue As String = ""
        Dim MainWindowWindowAccessibleNameValueName = "MainWindowWindowAccessibleName"
        Dim MainWindowWindowAccessibleNameValue As String = ""
        Dim MainWindowWindowAccessibleRoleValueName = "MainWindowWindowAccessibleRole"
        Dim MainWindowWindowAccessibleRoleValue As String = "Default"
        Dim MainWindowWindowAllowDropValueName = "MainWindowWindowAllowDrop"
        Dim MainWindowWindowAllowDropValue As Boolean = True
        Dim MainWindowWindowAutoScaleMode As String = "MainWindowWindowAutoScaleMode"
        Dim MainWindowWindowAutoScaleModeValue As String = "Inherit"
        Dim MainWindowWindowAutoScrollValueName = "MainWindowWindowAutoScroll"
        Dim MainWindowWindowAutoScrollValue As Boolean = False
        Dim MainWindowWindowAutoScrollMarginValueName = "MainWindowWindowAutoScrollMarginWidth"
        Dim MainWindowWindowAutoScrollMarginWidthValue As Integer = 0
        Dim MainWindowWindowAutoScrollMarginHeightName = "MainWindowWindowAutoScrollMarginHeight"
        Dim MainWindowWindowAutoScrollMarginHeightValue As Integer = 0
        Dim MainWindowWindowAutoSizeValueName = "MainWindowWindowAutoSize"
        Dim MainWindowWindowAutoSizeValue As Boolean = True
        'MainWindowWindowName
        Try
            Dim MainWindowWindowNameRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
            If MainWindowWindowNameRegistryKey Is Nothing Then
                MainWindowWindowNameRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
                Debug.WriteLine("MainWindowWindowNameRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
            End If
            If MainWindowWindowNameRegistryKey.GetValue(MainWindowWindowNameValueName, Nothing) Is Nothing Then
                MainWindowWindowNameRegistryKey.SetValue(MainWindowWindowNameValueName, MainWindowWindowNameValue)
            End If
            MainWindowWindowNameRegistryKey.Close()
        Catch ex As Exception

        End Try
        'MainWindowWindowAcceptButton
        Dim MainWindowWindowAcceptButtonRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAcceptButtonRegistryKey Is Nothing Then
            MainWindowWindowAcceptButtonRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAcceptButtonRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAcceptButtonRegistryKey.GetValue(MainWindowWindowAcceptButtonValueName, Nothing) Is Nothing Then
            MainWindowWindowAcceptButtonRegistryKey.SetValue(MainWindowWindowAcceptButtonValueName, MainWindowWindowAcceptButtonValue)
        End If
        MainWindowWindowAcceptButtonRegistryKey.Close()
        'MainWindowWindowAccessibleDescription
        Dim MainWindowWindowAccessibleDescriptionRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAccessibleDescriptionRegistryKey Is Nothing Then
            MainWindowWindowAccessibleDescriptionRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAccessibleDescriptionRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAccessibleDescriptionRegistryKey.GetValue(MainWindowWindowAccessibleDescriptionValueName, Nothing) Is Nothing Then
            MainWindowWindowAccessibleDescriptionRegistryKey.SetValue(MainWindowWindowAccessibleDescriptionValueName, MainWindowWindowAccessibleDescriptionValue)
        End If
        MainWindowWindowAccessibleDescriptionRegistryKey.Close()
        'MainWindowWindowAccessibleName
        Dim MainWindowWindowAccessibleNameRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAccessibleNameRegistryKey Is Nothing Then
            MainWindowWindowAccessibleNameRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAccessibleNameRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAccessibleNameRegistryKey.GetValue(MainWindowWindowAccessibleNameValueName, Nothing) Is Nothing Then
            MainWindowWindowAccessibleNameRegistryKey.SetValue(MainWindowWindowAccessibleNameValueName, MainWindowWindowAccessibleNameValue)
        End If
        MainWindowWindowAccessibleNameRegistryKey.Close()
        'MainWindowWindowAccessibleRole
        Dim MainWindowWindowAccessibleRoleRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAccessibleRoleRegistryKey Is Nothing Then
            MainWindowWindowAccessibleRoleRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAccessibleRoleRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAccessibleRoleRegistryKey.GetValue(MainWindowWindowAccessibleRoleValueName, Nothing) Is Nothing Then
            MainWindowWindowAccessibleRoleRegistryKey.SetValue(MainWindowWindowAccessibleRoleValueName, MainWindowWindowAccessibleRoleValue)
        End If
        MainWindowWindowAccessibleRoleRegistryKey.Close()
        'MainWindowWindowAllowDrop
        Dim MainWindowWindowAllowDropRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAllowDropRegistryKey Is Nothing Then
            MainWindowWindowAllowDropRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAllowDropRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAllowDropRegistryKey.GetValue(MainWindowWindowAllowDropValueName, Nothing) Is Nothing Then
            MainWindowWindowAllowDropRegistryKey.SetValue(MainWindowWindowAllowDropValueName, MainWindowWindowAllowDropValue)
        End If
        MainWindowWindowAllowDropRegistryKey.Close()
        'MainWindowWindowAutoScaleMode
        Dim MainWindowWindowAutoScaleModeRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAutoScaleModeRegistryKey Is Nothing Then
            MainWindowWindowAutoScaleModeRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAutoScaleModeRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAutoScaleModeRegistryKey.GetValue(MainWindowWindowAutoScaleMode, Nothing) Is Nothing Then
            MainWindowWindowAutoScaleModeRegistryKey.SetValue(MainWindowWindowAutoScaleMode, MainWindowWindowAutoScaleModeValue)
        End If
        MainWindowWindowAutoScaleModeRegistryKey.Close()
        'MainWindowWindowAutoScroll
        Dim MainWindowWindowAutoScrollRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAutoScrollRegistryKey Is Nothing Then
            MainWindowWindowAutoScrollRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAutoScrollRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAutoScrollRegistryKey.GetValue(MainWindowWindowAutoScrollValueName, Nothing) Is Nothing Then
            MainWindowWindowAutoScrollRegistryKey.SetValue(MainWindowWindowAutoScrollValueName, MainWindowWindowAutoScrollValue)
        End If
        MainWindowWindowAutoScrollRegistryKey.Close()
        'MainWindowWindowAutoScrollMarginWidth
        Dim MainWindowWindowAutoScrollMarginWidthRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowAutoScrollMarginSettings, True)
        If MainWindowWindowAutoScrollMarginWidthRegistryKey Is Nothing Then
            MainWindowWindowAutoScrollMarginWidthRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowAutoScrollMarginSettings)
            Debug.WriteLine("MainWindowWindowAutoScrollMarginWidthRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowAutoScrollMarginSettings)")
        End If
        If MainWindowWindowAutoScrollMarginWidthRegistryKey.GetValue(MainWindowWindowAutoScrollMarginValueName, Nothing) Is Nothing Then
            MainWindowWindowAutoScrollMarginWidthRegistryKey.SetValue(MainWindowWindowAutoScrollMarginValueName, MainWindowWindowAutoScrollMarginWidthValue)
        End If
        MainWindowWindowAutoScrollMarginWidthRegistryKey.Close()
        'MainWindowWindowAutoScrollMarginHeight
        Dim MainWindowWindowAutoScrollMarginHeightRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowAutoScrollMarginSettings, True)
        If MainWindowWindowAutoScrollMarginHeightRegistryKey Is Nothing Then
            MainWindowWindowAutoScrollMarginHeightRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowAutoScrollMarginSettings)
            Debug.WriteLine("MainWindowWindowAutoScrollMarginHeightRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowAutoScrollMarginSettings)")
        End If
        If MainWindowWindowAutoScrollMarginHeightRegistryKey.GetValue(MainWindowWindowAutoScrollMarginHeightName, Nothing) Is Nothing Then
            MainWindowWindowAutoScrollMarginHeightRegistryKey.SetValue(MainWindowWindowAutoScrollMarginHeightName, MainWindowWindowAutoScrollMarginHeightValue)
        End If
        MainWindowWindowAutoScrollMarginHeightRegistryKey.Close()
        'MainWindowWindowAutoSize
        Dim MainWindowWindowAutoSizeRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(RegKeyPathMainWindowWindowSettings, True)
        If MainWindowWindowAutoSizeRegistryKey Is Nothing Then
            MainWindowWindowAutoSizeRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)
            Debug.WriteLine("MainWindowWindowAutoSizeRegistryKey = Registry.CurrentUser.CreateSubKey(RegKeyPathMainWindowWindowSettings)")
        End If
        If MainWindowWindowAutoSizeRegistryKey.GetValue(MainWindowWindowAutoSizeValueName, Nothing) Is Nothing Then
            MainWindowWindowAutoSizeRegistryKey.SetValue(MainWindowWindowAutoSizeValueName, MainWindowWindowAutoSizeValue)
        End If
        MainWindowWindowAutoSizeRegistryKey.Close()
        Try
            Debug.WriteLine("Booting...")
            Debug.WriteLine("Start of async sub: Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load")

            Debug.WriteLine("    booting.Show()")
            booting.Show()

            Debug.WriteLine("   booting.bootprogress.Value = 0")
            booting.bootprogress.Value = 0
            Debug.WriteLine("   booting.bootprogress.Value = -->")
            Debug.WriteLine(booting.bootprogress)
            ' Setzt die Version
            Debug.WriteLine("Version = '2025.05.27'")
            Version = "2025.05.27"
            Debug.WriteLine("Version: " & Version)
            'Versionen
            Debug.WriteLine("  Text = Loading main window... Please wait")
            Text = "Loading main window... Please wait"
            Await WebView21.EnsureCoreWebView2Async()
            Debug.WriteLine("  Text = " & Text)
            Debug.WriteLine("   booting.bootprogress.Value = 14")
            booting.bootprogress.Value = 14
            Debug.WriteLine("   booting.bootprogress.Value = -->")
            Debug.WriteLine(booting.bootprogress)
            Debug.WriteLine("    Try")
        Catch ex As Exception
            BootError.ShowDialog()
        End Try

        Try
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.D)")
            RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.D)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.E)")
            RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.E)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.K)")
            RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.K)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.L)")
            RegisterHotKey(Me.Handle, 1, MOD_CONTROL, Keys.L)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 1, MOD_ALT, Keys.E)")
            RegisterHotKey(Me.Handle, 1, MOD_ALT, Keys.E)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 2, MOD_ALT, Keys.F)")
            RegisterHotKey(Me.Handle, 2, MOD_ALT, Keys.F)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.N)")
            RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.N)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.T)")
            RegisterHotKey(Me.Handle, 3, MOD_CONTROL, Keys.T)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W & Keys.Shift)")
            RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W & Keys.Shift)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W)")
            RegisterHotKey(Me.Handle, 4, MOD_CONTROL, Keys.W)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 5, MOD_ALT, Keys.S)")
            RegisterHotKey(Me.Handle, 5, MOD_ALT, Keys.S)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 6, MOD_CONTROL, Keys.Tab)")
            RegisterHotKey(Me.Handle, 6, MOD_CONTROL, Keys.Tab)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 7, MOD_CONTROL Or MOD_SHIFT, Keys.Shift)")
            RegisterHotKey(Me.Handle, 7, MOD_CONTROL Or MOD_SHIFT, Keys.Shift)
            Debug.WriteLine("        RegisterHotKey(Me.Handle, 7, Keys.OemPeriod)")
            RegisterHotKey(Me.Handle, 8, MOD_CONTROL, Keys.OemPeriod)
            'MainWindowWindowName
            Dim WebConnectAdminDesignerValuesMainWindowWindowPath As String = "Software\WebConnect\System\Designer values\MainWindow\Window"
            Dim WebConnectAdminDesignerValuesMainWindowWindowNameValueName As String = "MainWindowWindowName"
            Dim WebConnectAdminDesignerValuesMainWindowWindowNameRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(WebConnectAdminDesignerValuesMainWindowWindowPath, True)

            Debug.WriteLine("        Name = My.Settings.MainWindowWindowName")

            Debug.WriteLine("        Name = " & My.Settings.MainWindowWindowName)
            'Backend initialisieren
            Debug.WriteLine("        WebView21 = New WebView2()")
            WebView21 = New WebView2()
            Debug.WriteLine("        WebView21 = -->")
            Debug.WriteLine(WebView21)
            Debug.WriteLine("       WebView21.Location = New Point(0, 0)")
            WebView21.Location = New Point(0, 0)
            Debug.WriteLine("       WebView21.Location = -->")
            Debug.WriteLine(WebView21.Location)
            Debug.WriteLine("        WebView21.Size = New Size(1707, 785)")
            WebView21.Size = New Size(1707, 785)
            Debug.WriteLine("        WebView21.Size = -->")
            Debug.WriteLine(WebView21.Size)
            Debug.WriteLine("        Dim args As String() = Environment.GetCommandLineArgs()")
            Dim args As String() = Environment.GetCommandLineArgs()
            Debug.WriteLine("        Dim args As String() = -->")
            Debug.WriteLine(args)
            ' Wenn eine URL als Argument übergeben wird, öffne sie in einem neuen Tab
            Debug.WriteLine("        If args.Length > 1 Then")
            Debug.WriteLine("        args.Length = " & args.Length)
            If args.Length > 1 Then
                Debug.WriteLine("            OpenLinkOnBoot = True")
                OpenLinkOnBoot = True
                Debug.WriteLine("            OpenLinkOnBoot = " & OpenLinkOnBoot)
                Debug.WriteLine("            Dim url As String = args(1)")
                Dim url As String = args(1)
                Debug.WriteLine("            Dim url As String = " & url)
                Debug.WriteLine("            If Not String.IsNullOrEmpty(url) Then")
                Debug.WriteLine("            String.IsNullOrEmpty(url) = " & String.IsNullOrEmpty(url))
                If Not String.IsNullOrEmpty(url) Then
                    Debug.WriteLine("                AddNewTabFromAnotherApplication(url)")
                    AddNewTabFromAnotherApplication(url)
                    Debug.WriteLine("            End If")
                    Debug.WriteLine("        End If")
                End If
            End If



            'MainWindowWindowAccessibleDescription
            AccessibleDescription = My.Settings.MainWindowWindowAccessibleDescription
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
            booting.bootprogress.Value = 25
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
            booting.bootprogress.Value = 50
            If My.Settings.MainWindowWindowAllowDrop = True Then
                AllowDrop = True
            End If
            If My.Settings.MainWindowWindowAllowDrop = False Then
                AllowDrop = False
            End If
            'MainWindowWindowAutoScaleMode
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
        booting.bootprogress.Value = 28


        Try

            Dim languagePath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\DisplaySettings"
            Dim languageValueName1 As String = "Language"
            Try
                Dim languageValue As Object = Registry.GetValue(languagePath, languageValueName1, Nothing)
                If languageValue Is Nothing Then
                    BootError.ShowDialog()
                Else
                    Select Case languageValue.ToString()
                        'Deutsch
                        Case "de"
                            QuickInfo.IsBalloon = True
                            Debug.WriteLine("deregistry")

                            ' Initialisiere die WebView2-Umgebung

                            ' WebView2-Steuerelement mit der festgelegten Umgebung initialisieren
                            Await WebView21.EnsureCoreWebView2Async()

                            ' Setze die Sprache über die DefaultHeaders


                            Text = "Lade Hauptfenster... Warte kurz"
                            Dim toolTip1 As New ToolTip
                            toolTip1.SetToolTip(Back, "Navigiert auf der Internetseite zurück
            bzw. navigiert zur vorherigen Internetseite")
                            toolTip1.SetToolTip(Forward, "Navigiert auf der Internetseite vor
            bzw. navigiert zur nächsten geöffneten Internetseite")
                            toolTip1.SetToolTip(Search, "Sucht nach der URL, was in die Textbox eingegeben worden ist")
                            toolTip1.SetToolTip(Refresh, "Lädt eine Internetseite neu")
                            toolTip1.SetToolTip(Cancel, "Bricht das Laden einer Internetseite ab")
                            toolTip1.SetToolTip(Shortcuts, "Ruft Verknüpfungen zu verschiedenen Internetseiten auf")
                            toolTip1.SetToolTip(Home, "Navigiert zu Startseite")
                            toolTip1.SetToolTip(AddTab, "Fügt einen Tab hinzu")
                            toolTip1.SetToolTip(MagicAILink, "MagicAI Link")

                            ExitToolStripMenuItem.Text = "Beenden"
                            TextBox1.PlaceholderText = "Hier URL eingeben"
                            'AddHandler WebView21.CoreWebView2.WebMessageReceived, AddressOf WebViewMessageReceived
                            'WebView21.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("document.documentElement.setAttribute('lang', 'en-US');")
                            Dim AppInfo As New AppInfo(Me)
                            AppInfo.Text = "Info"
                            AppInfo.Description.Text = "WebConnect ist ein Browser
FrontEnd-Version: 1.0.0-015
BackEnd: WebView2 (Microsoft.Web.WebView2.WinForms)
BackEnd-Version: 1.0.1823.32
Programmierer: PhilConnected (Phileas Melchert)
"
                            Launcher.Music.Text = "Musik"
                            Launcher.Devices.Text = "Geräte"
                            Launcher.Important.Text = "Es kann sein, dass manche Dienste auf dieser Seite kostenpflichtig über einen einmaligen Preis oder ein Abomodell bezahlt werden sollen
oder man kann damit einkaufen.
Unbezahlte Werbung
"
                            Launcher.ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
                            ConnectToNAS.Text = "Einen NAS verbinden"
                            ConnectToNAS.Header.Text = "Welchen NAS 
  benutzt du?"
                            ConnectToNAS.ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
                            ConnectToNAS.Cancel.Text = "Abbrechen"
                            AppInfoToolStripMenuItem.Text = "Über WebConnect"
                            Language = "de"
                            WebConnectToolStripMenuItem.Text = "WebConnect"
                            ExitToolStripMenuItem.Text = "Beenden"
                            RebootToolStripMenuItem.Text = "Neustarten"
                            AppInfoToolStripMenuItem.Text = "Über WebConnect"
                            SettingsToolStripMenuItem.Text = "Einstellungen"
                            NavigationToolStripMenuItem.Text = "Navigation"
                            ForwardToolStripMenuItem.Text = "Vor"
                            BackToolStripMenuItem.Text = "Zurück"
                            ReloadToolStripMenuItem.Text = "Aktualisieren"
                            HomepageToolStripMenuItem.Text = "Startseite"
                            NewTabToolStripMenuItem.Text = "Neuer Tab"
                            CloseTabToolStripMenuItem.Text = "Tab schließen"
                            MoveTabToToolStripMenuItem.Text = "Tab bewegen nach..."
                            LeftToolStripMenuItem.Text = "links"
                            RightToolStripMenuItem.Text = "rechts"
                            TextBox1.PlaceholderText = "Hier URL eingeben"
                            Me.Text = "WebConnect für Windows"
                            CloseTabContextMenuToolStripMenuItem.Text = "Tab schließen"
                            NewTabContextMenuToolStripMenuItem.Text = "Neuer Tab"
                            MoveTabToContextMenuToolStripMenuItem.Text = "Tab bewegen nach..."
                            LeftContextMenuToolStripMenuItem.Text = "links"
                            RightContextMenuToolStripMenuItem1.Text = "rechts"
                            WebConnectToolStripMenuItem.Text = "WebConnect"
                            NavigationToolStripMenuItem.Text = "Navigation"

                            'englisch   
                        Case "en"
                            QuickInfo.IsBalloon = True
                            Debug.WriteLine("enregistry")
                            ' Optionen für WebView2: Sprache setzen mit "--lang=de-DE"
                            ' WebView2-Komponente starten
                            Await WebView21.EnsureCoreWebView2Async()
                            Text = "Loading main window... Please wait"
                            Dim toolTip1 As New ToolTip
                            toolTip1.SetToolTip(Back, "Navigates back on the website 
            or navigates to the previous website")
                            toolTip1.SetToolTip(Forward, "Navigates the website 
            or navigates to the next open website")
                            toolTip1.SetToolTip(Search, "Searches for the URL 
            that has been typed in the text box")
                            toolTip1.SetToolTip(Refresh, "Reloads a web page")
                            toolTip1.SetToolTip(Cancel, "Cancels the loading of a web page")
                            toolTip1.SetToolTip(Shortcuts, "Calls up links to different websites")
                            toolTip1.SetToolTip(Home, "Navigates to Home")
                            toolTip1.SetToolTip(AddTab, "Adds a Tab")
                            toolTip1.SetToolTip(MagicAILink, "MagicAI Link")
                            ExitToolStripMenuItem.Text = "Shut down"
                            RebootToolStripMenuItem.Text = "Reboot"
                            AppInfoToolStripMenuItem.Text = "About WebConnect"
                            SettingsToolStripMenuItem.Text = "Settings"
                            ForwardToolStripMenuItem.Text = "Forward"
                            BackToolStripMenuItem.Text = "Backward"
                            ReloadToolStripMenuItem.Text = "Reload"
                            HomepageToolStripMenuItem.Text = "Start Page"
                            NewTabToolStripMenuItem.Text = "New Tab"
                            CloseTabToolStripMenuItem.Text = "Close Tab"
                            MoveTabToToolStripMenuItem.Text = "Move Tab To..."
                            LeftToolStripMenuItem.Text = "left"
                            RightToolStripMenuItem.Text = "right"
                            TextBox1.PlaceholderText = "Enter URL here"
                            CloseTabContextMenuToolStripMenuItem.Text = "Close Tab"
                            NewTabContextMenuToolStripMenuItem.Text = "New Tab"
                            MoveTabToContextMenuToolStripMenuItem.Text = "Move Tab To..."
                            LeftContextMenuToolStripMenuItem.Text = "left"
                            RightContextMenuToolStripMenuItem1.Text = "right"
                            Dim AppInfo As New AppInfo(Me)
                            AppInfo.Text = "App info"
                            AppInfo.Description.Text = "WebConnect
FrontEnd version: 1.0.0-015
BackEnd: WebView2 (Microsoft.Web.WebView2.WinForms)
BackEnd version: 1.0.1823.32
Programmer: PhilConnected (Phileas Melchert)
"
                            Launcher.Music.Text = "Music"
                            Launcher.Devices.Text = "Devices"
                            Launcher.Important.Text = "It may be that some services on this site require payment via a one-off price or a subscription model
or you can use it to shop.
Unpaid advertising
"
                            Launcher.ManualConnection.Text = "Enter IP address instead"
                            Text = "WebConnect for Windows"

                            WebConnectToolStripMenuItem.Text = "WebConnect"
                            NavigationToolStripMenuItem.Text = "Navigation"
                            Language = "en"

                            'französisch
                        Case "fr"
                            QuickInfo.IsBalloon = True
                            Text = "Chargement de la fenêtre principale... Attendez un instant"
                            Dim toolTip1 As New ToolTip
                            toolTip1.SetToolTip(Back, "Navigue de nouveau sur le site Web 
            ou navigue vers le site Web précédent")
                            toolTip1.SetToolTip(Forward, "Navigue sur le site Web 
            ou navigue jusqu’au prochain site Web ouvert")
                            booting.bootprogress.Value = 75
                            toolTip1.SetToolTip(Search, "Recherche l’URL 
            qui a été saisie dans la zone de texte")
                            toolTip1.SetToolTip(Refresh, "Recharge une page web")
                            toolTip1.SetToolTip(Cancel, "Annule le chargement d’une page web")
                            toolTip1.SetToolTip(Shortcuts, "Appelle des liens vers différents sites Web")
                            toolTip1.SetToolTip(Home, "Navigue jusqu’à la page d’accueil")
                            toolTip1.SetToolTip(AddTab, "Onglet ajouté")
                            toolTip1.SetToolTip(MagicAILink, "MagicAI Link")
                            ExitToolStripMenuItem.Text = "Arrêter"
                            RebootToolStripMenuItem.Text = "Redémarrer"
                            AppInfoToolStripMenuItem.Text = "À propos de WebConnect"
                            SettingsToolStripMenuItem.Text = "Réglages"
                            ForwardToolStripMenuItem.Text = "Avant"
                            BackToolStripMenuItem.Text = "Retour"
                            ReloadToolStripMenuItem.Text = "Recharger"
                            HomepageToolStripMenuItem.Text = "Page d'accueil"
                            NewTabToolStripMenuItem.Text = "Nouvel onglet"
                            CloseTabToolStripMenuItem.Text = "Fermer l'onglet"
                            MoveTabToToolStripMenuItem.Text = "Déplacer l'onglet vers..."
                            LeftToolStripMenuItem.Text = "Liens"
                            RightToolStripMenuItem.Text = "Droite"
                            TextBox1.PlaceholderText = "Saisir ici l'URL"
                            CloseTabContextMenuToolStripMenuItem.Text = "Fermer l'onglet"
                            NewTabContextMenuToolStripMenuItem.Text = "Nouvel onglet"
                            MoveTabToContextMenuToolStripMenuItem.Text = "Déplacer l'onglet vers..."
                            LeftContextMenuToolStripMenuItem.Text = "Liens"
                            RightContextMenuToolStripMenuItem1.Text = "Droite"
                            WebConnectToolStripMenuItem.Text = "WebConnect"
                            NavigationToolStripMenuItem.Text = "Navigation"
                            Text = "WebConnect pour Windows"
                            Language = "fr"
                            'spanisch
                        Case "es"
                            QuickInfo.IsBalloon = True
                            Text = "Cargando ventana principal... Espere un momento"
                            Dim toolTip1 As New ToolTip
                            toolTip1.SetToolTip(Back, "Navega hacia atrás en el sitio web 
            o navega al sitio web anterior")
                            toolTip1.SetToolTip(Forward, "Navegue por el sitio web 
            o navegue hasta el siguiente sitio web abierto")
                            toolTip1.SetToolTip(Search, "Busca la dirección URL 
            que se introdujo en el cuadro de texto")
                            toolTip1.SetToolTip(Refresh, "Volver a cargar una página web")
                            toolTip1.SetToolTip(Cancel, "Cancela la carga de una página web")
                            toolTip1.SetToolTip(Shortcuts, "Invoca enlaces a diferentes sitios web")
                            toolTip1.SetToolTip(Home, "Vaya a la página de inicio")
                            toolTip1.SetToolTip(AddTab, "Nueva pestaña")
                            toolTip1.SetToolTip(MagicAILink, "MagicAI Link")
                            ExitToolStripMenuItem.Text = "Cerrar"
                            RebootToolStripMenuItem.Text = "Empezar de nuevo"
                            AppInfoToolStripMenuItem.Text = "A través de WebConnect"
                            SettingsToolStripMenuItem.Text = "Ajustes"
                            ForwardToolStripMenuItem.Text = "Adelante"
                            BackToolStripMenuItem.Text = "Hacia atrás"
                            ReloadToolStripMenuItem.Text = "Recargar"
                            HomepageToolStripMenuItem.Text = "Pagina de inicio"
                            NewTabToolStripMenuItem.Text = "Nueva pestaña"
                            CloseTabToolStripMenuItem.Text = "Cerrar pestaña"
                            MoveTabToToolStripMenuItem.Text = "Mover pestaña a..."
                            LeftToolStripMenuItem.Text = "izquierda"
                            RightToolStripMenuItem.Text = "bien"
                            TextBox1.PlaceholderText = "Introduzca la URL aquí"
                            CloseTabContextMenuToolStripMenuItem.Text = "Cerrar pestaña"
                            NewTabContextMenuToolStripMenuItem.Text = "Nueva pestaña"
                            MoveTabToContextMenuToolStripMenuItem.Text = "Mover pestaña a..."
                            LeftContextMenuToolStripMenuItem.Text = "izquierda"
                            RightContextMenuToolStripMenuItem1.Text = "bien"
                            WebConnectToolStripMenuItem.Text = "WebConnect"
                            NavigationToolStripMenuItem.Text = "Navegación"
                            Text = "WebConnect para Windows"
                            Language = "es"

                            'italienisch
                        Case "it"

                            QuickInfo.IsBalloon = True
                            Text = "Caricamento della finestra principale... Attendere un attimo"
                            Dim toolTip1 As New ToolTip
                            toolTip1.SetToolTip(Back, "Naviga nuovamente sul sito Web")
                            toolTip1.SetToolTip(Forward, "Naviga sul sito Web")
                            toolTip1.SetToolTip(Search, "Cerca l'URL")
                            toolTip1.SetToolTip(Refresh, "Ricarica una pagina Web")
                            toolTip1.SetToolTip(Cancel, "Annulla il caricamento di una pagina Web")
                            toolTip1.SetToolTip(Shortcuts, "Chiama collegamenti a diversi siti Web")
                            toolTip1.SetToolTip(Home, "Vai alla pagina iniziale")
                            toolTip1.SetToolTip(MagicAILink, "MagicAI Link")
                            ExitToolStripMenuItem.Text = "Fermare"
                            RebootToolStripMenuItem.Text = "Riavviare"
                            AppInfoToolStripMenuItem.Text = "Informazioni su WebConnect"
                            SettingsToolStripMenuItem.Text = "Impostazioni"
                            ForwardToolStripMenuItem.Text = "Inoltrare"
                            BackToolStripMenuItem.Text = "Indietro"
                            ReloadToolStripMenuItem.Text = "Ricaricare"
                            HomepageToolStripMenuItem.Text = "Pagina iniziale"
                            NewTabToolStripMenuItem.Text = "Nuova scheda"
                            CloseTabToolStripMenuItem.Text = "Chiudi scheda"
                            MoveTabToToolStripMenuItem.Text = "Sposta scheda in..."
                            LeftToolStripMenuItem.Text = "sinistra"
                            RightToolStripMenuItem.Text = "destra"
                            TextBox1.PlaceholderText = "Inserisci l'URL qui"
                            CloseTabContextMenuToolStripMenuItem.Text = "Chiudi scheda"
                            NewTabContextMenuToolStripMenuItem.Text = "Nuova scheda"
                            MoveTabToContextMenuToolStripMenuItem.Text = "Sposta scheda in..."
                            LeftContextMenuToolStripMenuItem.Text = "sinistra"
                            RightContextMenuToolStripMenuItem1.Text = "destra"
                            WebConnectToolStripMenuItem.Text = "WebConnect"
                            NavigationToolStripMenuItem.Text = "Navigazione"
                            Language = "it"

                            'türkisch
                        Case "tr"
                            QuickInfo.IsBalloon = True
                            Text = "Ana pencere yükleniyor... Bir dakika bekleyin"
                            Dim toolTip1 As New ToolTip
                            toolTip1.SetToolTip(Back, "Web sitesine geri döndüğünde 
            veya önceki web sitesine gittiğinde")
                            toolTip1.SetToolTip(Forward, "Web sitesine gidin 
            veya bir sonraki açık web sitesine gidin")
                            toolTip1.SetToolTip(Search, "Metin kutusuna girilen URL'yi bulun")
                            toolTip1.SetToolTip(Refresh, "Web sayfasını yeniden yükleme")
                            toolTip1.SetToolTip(Cancel, "Bir web sayfasının yüklenmesini iptal etme")
                            toolTip1.SetToolTip(Shortcuts, "Farklı web sitelerine bağlantılar çağırır")
                            toolTip1.SetToolTip(Home, "Ana sayfaya git")
                            toolTip1.SetToolTip(MagicAILink, "MagicAILink")
                            ExitToolStripMenuItem.Text = "Kapat"
                            RebootToolStripMenuItem.Text = "Yeniden başlat"
                            AppInfoToolStripMenuItem.Text = "WebConnect Hakkında"
                            SettingsToolStripMenuItem.Text = "Ayarlar"
                            ForwardToolStripMenuItem.Text = "İleri"
                            BackToolStripMenuItem.Text = "Geri"
                            ReloadToolStripMenuItem.Text = "Yeniden yükle"
                            HomepageToolStripMenuItem.Text = "Başlangıç ​​Sayfası"
                            NewTabToolStripMenuItem.Text = "Yeni Sekme"
                            CloseTabToolStripMenuItem.Text = "Sekmeyi Kapat"
                            MoveTabToToolStripMenuItem.Text = "Sekmeyi Şuraya Taşı..."
                            LeftToolStripMenuItem.Text = "sol"
                            RightToolStripMenuItem.Text = "sağ"
                            TextBox1.PlaceholderText = "URL'yi buraya girin"
                            CloseTabContextMenuToolStripMenuItem.Text = "Sekmeyi Kapat"
                            NewTabContextMenuToolStripMenuItem.Text = "Yeni Sekme"
                            MoveTabToContextMenuToolStripMenuItem.Text = "Sekmeyi Şuraya Taşı..."
                            LeftContextMenuToolStripMenuItem.Text = "sol"
                            RightContextMenuToolStripMenuItem1.Text = "sağ"
                            WebConnectToolStripMenuItem.Text = "WebConnect"
                            NavigationToolStripMenuItem.Text = "Navigasyon"
                            Text = "Windows için WebConnect"
                            Language = "tr"

                    End Select

                End If

            Catch ex As Exception
            End Try
            If My.Settings.AdminPassword IsNot Nothing Then
                Dim WebConnectAdminDesignerValuesMainWindowWindowPath As String = "Software\WebConnect\System\Designer values\MainWindow\Window"
                Dim WebConnectAdminDesignerValuesMainWindowWindowNameValueName As String = "MainWindowWindowName"
                Dim WebConnectAdminDesignerValuesMainWindowWindowNameRegistryKey As RegistryKey = Registry.CurrentUser.OpenSubKey(WebConnectAdminDesignerValuesMainWindowWindowPath, True)


                If WebConnectAdminDesignerValuesMainWindowWindowNameRegistryKey Is Nothing Then
                    ' Schlüssel erstellen, wenn er nicht existiert
                    WebConnectAdminDesignerValuesMainWindowWindowNameRegistryKey = Registry.CurrentUser.CreateSubKey(WebConnectAdminDesignerValuesMainWindowWindowPath)
                End If

                Using WebConnectAdminDesignerValuesMainWindowWindowNameRegistryKey
                    If WebConnectAdminDesignerValuesMainWindowWindowNameRegistryKey IsNot Nothing Then
                        ' Lese einen spezifischen Wert aus dem Schlüssel
                        Dim WebConnectAdminDesignerValuesMainWindowWindowNameValueName1 As String = "MainWindowWindowName"
                        Dim WebConnectAdminDesignerValuesMainWindowWindowNameValue As String = CStr(WebConnectAdminDesignerValuesMainWindowWindowNameRegistryKey.GetValue(WebConnectAdminDesignerValuesMainWindowWindowNameValueName1, "MainWindowWindowName"))

                        ' Wert in Me.Text anzeigen
                        Me.Text = $"{WebConnectAdminDesignerValuesMainWindowWindowNameValue}"
                    Else
                        BootError.ShowDialog()
                    End If
                End Using
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonPath As String = "HKEY_CURRENT_USER\Software\WebConnect\System\Designer values\MainWindow\Window"
                'MainWindowWindowAcceptButton
                Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Nothing' Then")
                Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
                Dim WebConnectAdminDesignerValuesMainWindowWindowValueName As String = "MainWindowWindowAcceptButton"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueNone As String = "(None)"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueBack As String = "Back"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueCancel As String = "Cancel"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueForward As String = "Forward"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueHome As String = "Home"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueRefresh As String = "Refresh"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueSearch As String = "Search"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueShortcuts As String = "Shortcuts"
                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueNone Then
                        AcceptButton = Nothing
                    End If
                Catch ex As Exception

                End Try

                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueBack Then
                        AcceptButton = Back
                    End If
                Catch ex As Exception
                End Try
                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueCancel Then
                        AcceptButton = Cancel
                    End If
                Catch ex As Exception
                End Try
                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueForward Then
                        AcceptButton = Forward
                    End If
                Catch ex As Exception
                End Try
                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueHome Then
                        AcceptButton = Home
                    End If
                Catch ex As Exception
                End Try
                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueRefresh Then
                        AcceptButton = Refresh
                    End If
                Catch ex As Exception
                End Try
                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueSearch Then
                        AcceptButton = Search
                    End If
                Catch ex As Exception
                End Try
                Try
                    Dim WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue As Object = Registry.GetValue(WebConnectAdminDesignerValuesMainWindowWindowPath, WebConnectAdminDesignerValuesMainWindowWindowValueName, Nothing)
                    If WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue IsNot Nothing AndAlso WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonCurrentValue.ToString() = WebConnectAdminDesignerValuesMainWindowWindowAcceptButtonExpectedValueShortcuts Then
                        AcceptButton = Shortcuts
                    End If
                Catch ex As Exception
                End Try
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRole As String = "MainWindowWindowAccessibleRole"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueDefault As String = "Default"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueNone As String = "None"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueTitleBar As String = "TitleBar"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueMenuBar As String = "MenuBar"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueScrollBar As String = "ScrollBar"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueGrip As String = "Grip"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueSound As String = "Sound"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueCursor As String = "Cursor"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueCaret As String = "Caret"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueAlert As String = "Alert"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueWindow As String = "Window"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueClient As String = "Client"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueMenuPopup As String = "MenuPopup"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedMenuItem As String = "MenuItem"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueToolTip As String = "ToolTip"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueApplication As String = "Application"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueDocument As String = "Document"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValuePane As String = "Pane"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueChart As String = "Chart"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueDialog As String = "Dialog"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueBorder As String = "Border"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueGrouping As String = "Grouping"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueSeperator As String = "Seperator"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueToolBar As String = "ToolBar"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueStatusBar As String = "StatusBar"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueTable As String = "Table"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueColumnHeader As String = "ColumnHeader"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueRowHeader As String = "RowHeader"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueColumn As String = "Column"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueRow As String = "Row"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueCell As String = "Cell"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueLink As String = "Link"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueHelpBalloon As String = "HelpBalloon"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueCharacter As String = "Character"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueList As String = "List"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueListItem As String = "ListItem"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueOutline As String = "Outline"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueOutlineItem As String = "OutlineItem"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValuePageTab As String = "PageTab"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValuePropertyPage As String = "PropertyPage"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueIndicator As String = "Indicator"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueGraphic As String = "Graphic"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueStaticText As String = "StaticText"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueText As String = "Text"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValuePushButton As String = "PushButton"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueCheckButton As String = "CheckButton"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueRadioButton As String = "RadioButton"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueComboBox As String = "ComboBox"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueDropList As String = "DropList"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueProgressBar As String = "ProgressBar"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueDial As String = "Dial"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueHotkeyField As String = "HotkeyField"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueSlider As String = "Slider"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueSpinButton As String = "SpinButton"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueDiagram As String = "Diagram"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueAnimation As String = "Animation"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueEquation As String = "Equation"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueButtonDropDown As String = "ButtonDropDown"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueButtonMenu As String = "ButtonMenu"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueButtonDropDownGrid As String = "ButtonDropDownGrid"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueWhiteSpace As String = "WhiteSpace"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValuePageTabList As String = "PageTabList"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueClock As String = "Clock"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueSplitButton As String = "SplitButton"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueIpAdress As String = "IpAdress"
                Dim WebConnectAdminDesignerValuesMainWindowWindowAccessibleRoleExpectedValueOutlineButton As String = "OutlineButton"
            End If



            booting.bootprogress.Value = 42

            booting.bootprogress.Value = 56
            If OpenLinkOnBoot = False Then
                If My.Settings.DefaultSearchEngine = "Google" Then
                    AddNewTab("https://www.google.com")
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
            booting.bootprogress.Value = 70
            RegisterBrowserForProtocolsAndFileTypes()
            booting.bootprogress.Value = 84
            RegisterBrowserForHttpAndHttps()
            booting.bootprogress.Value = 91
            RegisterAsDefaultApp()
            booting.bootprogress.Value = 94
            Dim regPath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\SoftwareUpdateSettings"
            Dim valueName As String = "AlwaysCheckForUpdatesOnApplicationBoot"

            Dim currentValue As Object = Registry.GetValue(regPath, valueName, Nothing)


            Dim WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootFalseExpectedValue = "False"
            Dim WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootTrueExpectedValue = "True"
            Dim WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootPath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\SoftwareUpdateSettings"
            Dim WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootValueName As String = "AlwaysCheckForUpdatesOnApplicationBoot"
            Dim WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootCurrentValue As Object = Registry.GetValue(WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootPath, WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootValueName, Nothing)
            If WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootCurrentValue IsNot Nothing AndAlso WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootCurrentValue.ToString() = WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootFalseExpectedValue Then

            ElseIf WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootCurrentValue IsNot Nothing AndAlso WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootCurrentValue.ToString() = WebConnectUserSettingsSoftwareUpdateSettingsAlwaysCheckForUpdatesOnApplicationBootTrueExpectedValue Then
                Dim currentSWVersion As String = Me.Version
                Dim SWOwnerongithub As String = "PhiStar1"
                Dim SWNameOnGithub As String = "WebConnectBrowserWindows"
                Try
                    Dim SWUpdateURL As String = $"https://api.github.com/repos/{SWOwnerongithub}/{SWNameOnGithub}/releases/latest"
                    Using client As New HttpClient()
                        client.DefaultRequestHeaders.UserAgent.ParseAdd("WebConnectUpdate")
                        Dim jsonResponse As String = Await client.GetStringAsync(SWUpdateURL)
                        Dim releaseInfo As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(jsonResponse)
                        Dim latestSWVersion As String = releaseInfo("tag_name").ToString()
                        Dim downloadURL As String = releaseInfo("html_url").ToString()
                        Dim releaseTitle As String = releaseInfo("name").ToString()
                        Dim releaseBody As String = releaseInfo("body").ToString()

                        downloadVersion = latestSWVersion
                        If CompareVersions(currentSWVersion, latestSWVersion) < 0 Then
                            booting.Close()
                            SoftwareUpdateTool.ShowDialog()
                            SoftwareUpdateTool.DownloadButton.Show()
                            SoftwareUpdateTool.RichTextBox1.Show()
                            SoftwareUpdateTool.Label1.Text = SoftwareUpdateTool.readyToDownloadSWUpdateScreenMessage
                            SoftwareUpdateTool.RichTextBox1.Text = SoftwareUpdateTool.importantNoteScreenMessage & " " & latestSWVersion & " 
BREAKING NEWS!!! " & releaseBody

                            'Return $"Ein Software-Update ist verfügbar!{Environment.NewLine}" &
                            '$"Version: {latestSWVersion}{Environment.NewLine}" &
                            '$"Titel: {releaseTitle}{Environment.NewLine}" &
                            '       $"Beschreibung: {releaseBody}{Environment.NewLine}" &
                            '      $"Downloadlink: {downloadURL}"
                        Else

                        End If
                    End Using

                Catch ex As Exception

                End Try
            End If

            newTab()

            BootCompleted = True
            booting.bootprogress.Value = 100
            booting.Close()
            'Catch ex As Exception
            'BootError.ShowDialog()
        Catch ex As FileNotFoundException
            BootError.ShowDialog()
        End Try
    End Sub


    Private Function CompareVersions(version1 As String, version2 As String) As Integer
        'Diese Funktion ist dafür zuständig, zwei Versionsnummern zu vergleichen
        version1 = version1.TrimStart("v"c)
        version2 = version2.TrimStart("v"c)

        version1 = NormalizeVersionString(version1)
        version2 = NormalizeVersionString(version2)

        Dim v1 As Version = New Version(version1)
        Dim v2 As Version = New Version(version2)

        Return v1.CompareTo(v2)
    End Function
    Private Function NormalizeVersionString(version As String) As String
        'Diese Funktion ist dafür zuständig, eine Versionsnummer zu normalisieren
        Dim parts As String() = version.Split("."c)

        While parts.Length < 2
            version &= ".0"
            parts = version.Split("."c)
        End While

        Return String.Join(".", parts.Take(4))
    End Function
    Private Sub AddNewTabFromAnotherApplication(url As String)
        'Diese Funktion ist dafür zuständig, einen neuen Tab zu erstellen, wenn eine URL von einer anderen App geöffnet wird
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
        'Dieser Sub ist dafür zuständig, die Tabs zu verwalten
        If e.Button = MouseButtons.Middle Then
            'Tab schließen
            For i As Integer = 0 To TabControl1.TabPages.Count - 1
                Dim tabPage As TabPage = TabControl1.TabPages(i)
                Dim tabRect As Rectangle = TabControl1.GetTabRect(i)
                If tabRect.Contains(e.Location) Then
                    Dim webView As Microsoft.Web.WebView2.WinForms.WebView2 = Nothing
                    For Each control As Control In tabPage.Controls
                        If TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2 Then
                            webView = CType(control, Microsoft.Web.WebView2.WinForms.WebView2)
                            Exit For
                        End If
                    Next
                    If webView IsNot Nothing Then
                        Try
                            If webView.CoreWebView2 IsNot Nothing Then
                                webView.Dispose()
                            End If

                        Catch ex As Exception

                        End Try
                    End If
                    TabControl1.TabPages.Remove(tabPage)
                    Exit For
                End If
            Next
        End If
        If e.Button = MouseButtons.Right Then
            'Tab-Menü anzeigen
            ' Mausposition relativ zum TabControl holen
            Dim mousePosition As Point = New Point(e.X, e.Y)

            ' Durchsuche alle Tabs
            MouseOnTab = Nothing ' Zurücksetzen
            For i As Integer = 0 To TabControl1.TabCount - 1
                Dim tabRect As Rectangle = TabControl1.GetTabRect(i)
                If tabRect.Contains(mousePosition) Then
                    ' Tab unter der Maus speichern
                    MouseOnTab = TabControl1.TabPages(i)
                    ' Kontextmenü anzeigen
                    ContextMenuStrip1.Show(TabControl1, mousePosition)
                    Exit For
                End If
            Next
        End If
        If e.Button = MouseButtons.Left Then
            'Tab bewegen
            For i As Integer = 0 To TabControl1.TabCount - 1
                If TabControl1.GetTabRect(i).Contains(e.Location) Then
                    TabdragdropIndex = i
                    Exit For
                End If
            Next
            If TabdragdropIndex >= 0 Then
                TabControl1.DoDragDrop(TabControl1.TabPages(TabdragdropIndex), DragDropEffects.Move)
            End If
        End If
    End Sub
    Private Sub TabControl1_DragOver(sender As Object, e As DragEventArgs) Handles TabControl1.DragOver
        'Dieser Sub ist für Drag&Drop Effects zuständig
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub TabControl1_DragDrop(sender As Object, e As DragEventArgs) Handles TabControl1.DragDrop
        'Dieser Sub ist dafür zuständig, die Tabs zu verschieben
        Dim targetIndex As Integer = -1
        For i As Integer = 0 To TabControl1.TabCount - 1
            If TabControl1.GetTabRect(i).Contains(TabControl1.PointToClient(New Point(e.X, e.Y))) Then
                targetIndex = i
                Exit For
            End If
        Next
        If targetIndex >= 0 AndAlso TabdragdropIndex >= 0 AndAlso TabdragdropIndex <> targetIndex Then
            Dim tab As TabPage = TabControl1.TabPages(TabdragdropIndex)
            TabControl1.TabPages.RemoveAt(TabdragdropIndex)
            TabControl1.TabPages.Insert(targetIndex, tab)
            TabControl1.SelectedIndex = targetIndex
        End If
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

    Private Sub Home_Click(sender As Object, e As EventArgs)
        Startpage()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NeustartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RebootToolStripMenuItem.Click
        Reboot.ShowDialog()
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

    Private Async Sub GoForward()
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
                TextBox1.Text = "Du kannst nicht weiter zurück gehen"
            End If
            If My.Settings.Sprache = "English" Then
                TextBox1.Text = "You can't go more back"
            End If
        End If




    End Sub
    Private Async Sub ReloadPage()
        Dim webView As WebView2 = GetCurrentWebView()
        If webView IsNot Nothing Then
            webView.CoreWebView2.Reload()


        Else
        End If
    End Sub
    Private Async Sub newTab()
        ' WebConnect-Initialisierung sicherstellen
        'While Not WebConnectIsInitialized()
        'Await Task.Delay(100) ' Warten für 100 ms und dann erneut prüfen
        'End While

        ' Weiter mit der WebView2-Initialisierung, da WebConnect bereit ist
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineGoogleExpectedValue = "Google"
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineBingExpectedValue = "Bing"
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEnginePath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\DisplaySettings"
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineValueName As String = "DefaultSearchEngine"

        Debug.WriteLine("Dim newWebView As New WebView2()")
        Dim newWebView As New WebView2()

        Debug.WriteLine("Dim newTabPage As New TabPage()")
        Dim newTabPage As New TabPage()

        newTabPage.Text = "Tab"


        Debug.WriteLine("newWebView.Dock = DockStyle.Fill")
        newWebView.Dock = DockStyle.Fill

        Debug.WriteLine("newTabPage.Controls.Add(newWebView)")
        newTabPage.Controls.Add(newWebView)

        Debug.WriteLine("TabControl1.TabPages.Add(newTabPage)")
        'TabControl1.TabPages.Add(newTabPage)

        Debug.WriteLine("TabControl1.SelectedTab = newTabPage")
        TabControl1.SelectedTab = newTabPage

        Try
            Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue As Object = Registry.GetValue(WebConnectUserSettingsDisplaySettingsDefaultSearchEnginePath, WebConnectUserSettingsDisplaySettingsDefaultSearchEngineValueName, Nothing)

            If WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue IsNot Nothing AndAlso WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue.ToString() = WebConnectUserSettingsDisplaySettingsDefaultSearchEngineGoogleExpectedValue Then
                ' Google als Standard-Suchmaschine
                Me.AddNewTab("https://www.google.de")
            ElseIf WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue IsNot Nothing AndAlso WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue.ToString() = WebConnectUserSettingsDisplaySettingsDefaultSearchEngineBingExpectedValue Then
                ' Bing als Standard-Suchmaschine
                Me.AddNewTab("https://www.bing.de")
            End If
        Catch ex As Exception
            Debug.WriteLine("Fehler beim Abrufen der Suchmaschine: " & ex.Message)
        End Try

    End Sub

    ' Funktion, die prüft, ob WebConnect bereit ist (hier abhängig von deiner Implementierung)
    Private Function WebConnectIsInitialized() As Boolean
        ' Überprüfe eine Eigenschaft oder einen Zustand, der anzeigt, dass WebConnect bereit ist
        ' Zum Beispiel: WebConnect.Status = "Ready" oder WebConnect.Initialized = True
        Return True ' Beispiel: Hier solltest du deinen tatsächlichen WebConnect-Status überprüfen
    End Function

    ' Funktion zum Initialisieren der WebView2-Instanz
    Private Async Sub InitializeWebView2(newWebView As WebView2, url As String)
        Dim environment As CoreWebView2Environment = Nothing
        Try
            ' Verzögere die Ausführung um 1 Sekunde (1000 Millisekunden)
            Debug.WriteLine("Warte 1 Sekunde bevor die Initialisierung beginnt...")
            Await Task.Delay(1000)

            ' Setze das Sprach-Flag oder andere Optionen
            Dim options As New CoreWebView2EnvironmentOptions()
            options.AdditionalBrowserArguments = "--lang=en"  ' Beispiel: Setze Sprache auf Englisch

            ' Erstelle die WebView2-Umgebung mit den Optionen
            Debug.WriteLine("Erstelle WebView2-Umgebung...")
            environment = Await CoreWebView2Environment.CreateAsync(Nothing, Nothing, options)

            ' Warten, bis WebView2 bereit ist
            Debug.WriteLine("Warten auf WebView2-Initialisierung...")
            Await newWebView.EnsureCoreWebView2Async(environment)

            Debug.WriteLine("WebView2 erfolgreich initialisiert.")

            ' Lade die angegebene URL
            newWebView.CoreWebView2.Navigate(url)
            Debug.WriteLine("WebView2-Inhalt geladen: " & url)
        Catch ex As COMException
            ' Fange COM-Fehler ab
            Debug.WriteLine("COMException bei der Initialisierung: " & ex.Message)
        Catch ex As Exception
            ' Fange alle anderen Fehler ab
            Debug.WriteLine("Fehler bei der Initialisierung: " & ex.Message)
        End Try
    End Sub



    Private Function GetCurrentWebView() As WebView2
        If TabControl1.SelectedTab IsNot Nothing Then
            Return TabControl1.SelectedTab.Controls.OfType(Of WebView2)().FirstOrDefault

        End If
        Return Nothing
    End Function
    Private Async Sub Startpage()
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineGoogleExpectedValue = "Google"
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineBingExpectedValue = "Bing"
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEnginePath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\DisplaySettings"
        Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineValueName As String = "DefaultSearchEngine"
        Dim webView As WebView2 = GetCurrentWebView()
        Await WebView21.EnsureCoreWebView2Async()

        ' Setze die Sprache über die DefaultHeaders
        Dim headers As String = "Accept-Language: en-EN" & vbCrLf

        If webView IsNot Nothing Then
            Try
                Dim WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue As Object = Registry.GetValue(WebConnectUserSettingsDisplaySettingsDefaultSearchEnginePath, WebConnectUserSettingsDisplaySettingsDefaultSearchEngineValueName, Nothing)

                If WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue IsNot Nothing AndAlso WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue.ToString() = WebConnectUserSettingsDisplaySettingsDefaultSearchEngineGoogleExpectedValue Then
                    ' Google als Standard-Suchmaschine
                    webView.CoreWebView2.Navigate("https://www.google.de")
                ElseIf WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue IsNot Nothing AndAlso WebConnectUserSettingsDisplaySettingsDefaultSearchEngineCurrentValue.ToString() = WebConnectUserSettingsDisplaySettingsDefaultSearchEngineBingExpectedValue Then
                    ' Bing als Standard-Suchmaschine
                    webView.CoreWebView2.Navigate("https://www.bing.de")
                End If
            Catch ex As Exception
                Debug.WriteLine("Fehler beim Abrufen der Suchmaschine: " & ex.Message)
            End Try

        Else

        End If
    End Sub

    Private Sub VorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForwardToolStripMenuItem.Click
        GoForward()
    End Sub

    Private Sub ZurückToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        GoBack()


    End Sub

    Private Sub AktualisierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReloadToolStripMenuItem.Click
        ReloadPage()
    End Sub

    Private Sub StartseiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HomepageToolStripMenuItem.Click
        Startpage()
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
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
            NavigationToolStripMenuItem.Enabled = True
            Try
                If WebView21.CoreWebView2 IsNot Nothing Then
                    WebView21.CoreWebView2.Settings.UserAgent = "WebConnect"
                End If
            Catch ex As Exception
                MessageBox.Show("Fehler beim Setzen des User-Agents: " & ex.Message)
            End Try
        Catch ex As Exception
            If BootCompleted = False Then
                MsgBox(ex.Message)
                BootError.ShowDialog()
            End If
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











    Private Sub NeuerTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        newTab()
    End Sub

    Private Sub Home_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Async Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

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

    Private Sub WebView22_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Control.ModifierKeys = Keys.Control AndAlso e.KeyChar = "d"c Then
            ' Übertrage den Fokus auf die TextBox
            TextBox1.Select() ' Markiere den Text in der TextBox
            TextBox1.SelectAll() ' Verhindere das weitere Verarbeiten dieses Ereignisses
            e.Handled = True
        End If
    End Sub

    Private Async Sub TabSchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseTabContextMenuToolStripMenuItem.Click
        If MouseOnTab IsNot Nothing Then
            Dim webView As Microsoft.Web.WebView2.WinForms.WebView2 = Nothing
            For Each control As Control In MouseOnTab.Controls
                If TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2 Then
                    webView = CType(control, Microsoft.Web.WebView2.WinForms.WebView2)
                    Exit For
                End If
            Next
            If webView IsNot Nothing Then
                Try
                    If webView.CoreWebView2 IsNot Nothing Then
                        webView.Dispose()
                    End If

                Catch ex As Exception

                End Try
            End If
            TabControl1.TabPages.Remove(MouseOnTab)
            MouseOnTab = Nothing ' Zurücksetzen
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
    End Sub

    Private Sub TabSchließenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CloseTabToolStripMenuItem.Click
        Debug.WriteLine("               If TabControl1.SelectedIndex >= 0 Then") ' Wert von m.WParam ausgeben
        Debug.WriteLine("               TabControl1.SelectedIndex = " & TabControl1.SelectedIndex) ' Wert von m.WParam ausgeben

        If TabControl1.SelectedIndex >= 0 Then
            ' Ausgewählten Tab entfernen
            Debug.WriteLine("                   Dim selectedTab As TabPage = TabControl1.TabPages(TabControl1.SelectedIndex)") ' Wert von m.WParam ausgeben
            Dim selectedTab As TabPage = TabControl1.TabPages(TabControl1.SelectedIndex)
            Debug.WriteLine("                   selectedTab = -->") ' Wert von m.WParam ausgeben
            Debug.WriteLine(TabControl1.TabPages(TabControl1.SelectedIndex)) ' Wert von m.WParam ausgeben
            Debug.WriteLine("                   Selected Tab: " & selectedTab.Text)
            Debug.WriteLine("                   Dim webView As Microsoft.Web.WebView2.WinForms.WebView2 = Nothing")
            ' WebView2-Steuerelement im ausgewählten Tab finden
            Dim webView As Microsoft.Web.WebView2.WinForms.WebView2 = Nothing
            Debug.WriteLine("                   webView = -->")
            Debug.WriteLine(webView)

            For Each control As Control In selectedTab.Controls
                Debug.WriteLine("                    For Each control As Control In selectedTab.Controls")
                Debug.WriteLine("                        If TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2 Then")

                If TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2 Then
                    Debug.WriteLine("                        TypeOf control Is Microsoft.Web.WebView2.WinForms.WebView2")
                    Debug.WriteLine("                            webView = CType(control, Microsoft.Web.WebView2.WinForms.WebView2)")

                    webView = CType(control, Microsoft.Web.WebView2.WinForms.WebView2)
                    Debug.WriteLine("                            webView = --> ")
                    Debug.WriteLine(CType(control, Microsoft.Web.WebView2.WinForms.WebView2))
                    Debug.WriteLine("                            Exit For")
                    Exit For
                    Debug.WriteLine("                        End If")
                End If
                Debug.WriteLine("                    Next")
            Next

            ' WebView2-Prozess freigeben und beenden
            Debug.WriteLine("                    If webView IsNot Nothing Then")
            Debug.WriteLine("                    webView = -->")
            Debug.WriteLine(webView)
            If webView IsNot Nothing Then
                Try
                    Debug.WriteLine("                        Try")
                    Debug.WriteLine("                            If webView.CoreWebView2 IsNot Nothing Then")
                    Debug.WriteLine("                            webView.CoreWebView2 = -->")
                    Debug.WriteLine(webView.CoreWebView2)
                    If webView.CoreWebView2 IsNot Nothing Then
                        Debug.WriteLine("                                webView.Dispose()")
                        webView.Dispose() ' Steuerelement und Prozess freigeben
                        Debug.WriteLine("                            End If")
                    End If
                Catch ex As Exception
                    Debug.WriteLine("                        Catch ex As Exception")
                    Debug.WriteLine(ex.Message)
                    Debug.WriteLine("                        End Try")
                End Try
                Debug.WriteLine("                    End If")
            End If

            ' Ausgewählten Tab entfernen
            Debug.WriteLine("                    TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)")
            TabControl1.TabPages.RemoveAt(TabControl1.SelectedIndex)
            Debug.WriteLine("                End If")
        End If
    End Sub

    Private Sub Home_Click_2(sender As Object, e As EventArgs) Handles Home.Click
        Startpage()
    End Sub

    Private isNarrow As Boolean = False

    Private Async Sub MagicAILink_Click(sender As Object, e As EventArgs) Handles MagicAILink.Click
        MagicAILinkExecute()
    End Sub
    Private Sub AIWebView_VisibleChanged(sender As Object, e As EventArgs)
        If AIWebView.Visible Then
            AIWebView.Width = CInt(Me.ClientSize.Width * 0.25) - spacing
            AIWebView.Height = TabControl1.Height
            AIWebView.Left = TabControl1.Right + spacing
            AIWebView.Top = TabControl1.Top
            AIWebView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        End If
    End Sub
    Private Async Sub Form1_Resize(sender As Object, es As EventArgs)

        If AIWebView IsNot Nothing AndAlso AIWebView.Visible Then
            AIWebView_VisibleChanged(AIWebView, EventArgs.Empty)
        End If

    End Sub
    Private Async Sub MagicAILinkExecute()


        If isNarrow Then
            ' Setze die Breite der TabControl1 auf 100% der Formularbreite
            TabControl1.Width = Me.ClientSize.Width
            If AIWebView IsNot Nothing Then
                AIWebView.Visible = False
            End If
        Else
            ' Setze die Breite der TabControl1 auf 75% der Formularbreite
            TabControl1.Width = CInt(Me.ClientSize.Width * 0.75) - spacing
            ' WebView22 erzeugen und konfigurieren, falls sie noch nicht existiert
            If AIWebView Is Nothing Then
                AIWebView = New WebView2() With {
                    .Visible = False
                }
                Await AIWebView.EnsureCoreWebView2Async(Nothing)
                Dim WebConnectUserSettingsMagicAILinkSettingsPath As String = "HKEY_CURRENT_USER\Software\WebConnect\User\Settings\MagicAILinkSettings"
                Dim WebConnectUserSettingsDefaultChatbotValueName As String = "DefaultChatbot"
                Dim DefaultChatbotExpectedValueMicrosoftCopilot As String = "Microsoft Copilot"
                Dim DefaultChatbotExpectedValueGoogleGemini As String = "Google Gemini"
                Dim DefaultChatbotExpectedValueChatGPT As String = "ChatGPT"
                Dim defaultChatbotCurrentValue As Object = Registry.GetValue(WebConnectUserSettingsMagicAILinkSettingsPath, WebConnectUserSettingsDefaultChatbotValueName, Nothing)
                If defaultChatbotCurrentValue IsNot Nothing Then
                    Select Case defaultChatbotCurrentValue.ToString()
                        Case DefaultChatbotExpectedValueMicrosoftCopilot
                            Me.AIWebView.CoreWebView2.Navigate("https://copilot.microsoft.com/")
                            Settings.PendingAIChanges = False
                        Case DefaultChatbotExpectedValueGoogleGemini
                            Me.AIWebView.CoreWebView2.Navigate("https://gemini.google.com/app?hl=de")
                            Settings.PendingAIChanges = False
                        Case DefaultChatbotExpectedValueChatGPT
                            Me.AIWebView.CoreWebView2.Navigate("https://chatgpt.com/")
                            Settings.PendingAIChanges = False
                        Case Else
                    End Select
                Else
                    Debug.WriteLine("Registry-Wert für den Standard-KI-Chatbot nicht gefunden.")
                End If
                If My.Settings.DefaultAIEngine = "Microsoft Copilot" Then

                End If
                If My.Settings.DefaultAIEngine = "Google Gemini" Then


                End If
                If My.Settings.DefaultAIEngine = "ChatGPT" Then


                End If

                Me.Controls.Add(AIWebView)
                AddHandler AIWebView.VisibleChanged, AddressOf AIWebView_VisibleChanged
            End If
            AIWebView.Visible = True
        End If
        ' Umschalten des Zustands
        isNarrow = Not isNarrow

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged

        Try
            If AIWebView IsNot Nothing AndAlso AIWebView.Visible = True Then
                MagicAILinkExecute()
                MagicAILinkExecute()
                TabControl1.Height = ClientSize.Height - 79
                AIWebView.Height = ClientSize.Height - 79
            Else
                TabControl1.Width = ClientSize.Width
                TabControl1.Height = ClientSize.Height - 79
            End If
        Catch ex As System.NullReferenceException
            Debug.WriteLine(ex.Message)
        End Try



    End Sub

    Private Sub LinksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        MoveTabLeft()
    End Sub
    Private Sub RechtsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        MoveTabRight()
    End Sub
    Public Sub MoveTabLeft()
        Dim currentTab As Integer = TabControl1.SelectedIndex
        If currentTab > 0 Then
            ' Hole den Tab, der verschoben werden soll
            Dim selectedTab As TabPage = TabControl1.TabPages(currentTab)

            ' Entferne den Tab aus der aktuellen Position
            TabControl1.TabPages.RemoveAt(currentTab)

            ' Füge den Tab an der neuen Position ein (eine Position nach links)
            TabControl1.TabPages.Insert(currentTab - 1, selectedTab)

            ' Setze den Fokus auf den vorherigen Tab
            TabControl1.SelectedIndex = currentTab - 1
        End If
    End Sub

    Public Sub MoveTabRight()
        Dim currentTab As Integer = TabControl1.SelectedIndex
        If currentTab < TabControl1.TabCount - 1 Then
            ' Hole den Tab, der verschoben werden soll
            Dim selectedTab As TabPage = TabControl1.TabPages(currentTab)

            ' Entferne den Tab aus der aktuellen Position
            TabControl1.TabPages.RemoveAt(currentTab)

            ' Füge den Tab an der neuen Position ein (eine Position nach rechts)
            TabControl1.TabPages.Insert(currentTab + 1, selectedTab)

            ' Setze den Fokus auf den nächsten Tab
            TabControl1.SelectedIndex = currentTab + 1

        End If
    End Sub
    Private Sub NeuerTabToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewTabContextMenuToolStripMenuItem.Click
        newTab()
    End Sub

    Private Sub LinksToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LeftContextMenuToolStripMenuItem.Click
        MoveTabLeft()
    End Sub

    Private Sub RechtsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RightContextMenuToolStripMenuItem1.Click
        MoveTabRight()
    End Sub
    Dim TabdragdropIndex As Integer = -1

    Private Sub WebConnectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebConnectToolStripMenuItem.Click
    End Sub
End Class


' Google als Startseite festlegen? https://www.google.com/intl/de_ALL/homepage/hp-edge.html?utm_source=google.com&utm_medium=callout&utm_campaign=EDHP
