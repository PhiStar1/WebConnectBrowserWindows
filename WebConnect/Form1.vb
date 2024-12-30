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

Public Class Form1
    Public WithEvents WebView21 As New WebView2()
    <DllImport("user32.dll")>
    Public Shared Function RegisterHotKey(hWnd As IntPtr, id As Integer, fsModifiers As Integer, vk As Integer) As Boolean
    End Function

    <DllImport("user32.dll")>
    Public Shared Function UnregisterHotKey(hWnd As IntPtr, id As Integer) As Boolean
    End Function

    'HOTKEYS
    Private Const MOD_ALT As Integer = &H1
    Private Const MOD_CONTROL As Integer = &H2
    Private Const WM_HOTKEY As Integer = &H312
    Private Const MOD_SHIFT As Integer = &H4
    Protected Overrides Sub WndProc(ByRef m As Message)
        ' Start der Methode
        Debug.WriteLine("Start of protected overrides sub: WndProc(ByRef m As Message)")

        ' Überprüfung, ob die Nachricht ein Hotkey ist
        If m.Msg = WM_HOTKEY Then
            Debug.WriteLine("   If m.Msg = WM_HOTKEY Then")
            Debug.WriteLine("   m.Msg = " & m.Msg)
            Debug.WriteLine("       Select Case m.WParam.ToInt32()")
            Debug.WriteLine("       m.WParam.ToInt32() = " & m.WParam.ToInt32)
            Select Case m.WParam.ToInt32()
                Case 1 ' Alt + E oder CTRL + D oder CTRL + E oder CTRL + K oder CTRL + L
                    Debug.WriteLine("           Case 1: Alt + E oder CTRL + D/E/K/L")
                    Debug.WriteLine("               TextBox1.Focus()")
                    TextBox1.Focus()
                    Debug.WriteLine("               TextBox1.SelectAll()")
                    TextBox1.SelectAll()

                Case 2 ' Alt + F
                    Debug.WriteLine("           Case 2: Alt + F")
                    Debug.WriteLine("               WebConnectToolStripMenuItem.Select()")
                    WebConnectToolStripMenuItem.Select()

                Case 3 ' CTRL + N oder CTRL + T
                    Debug.WriteLine("           Case 3: CTRL + N oder CTRL + T")
                    Debug.WriteLine("               newTab()")
                    newTab()

                Case 4 ' CTRL + W
                    Debug.WriteLine("           Case 4: CTRL + W")
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

                Case 5 ' ALT + S
                    Debug.WriteLine("            Case 5: ALT + S")
                    Try
                        Debug.WriteLine("                Try")
                        Debug.WriteLine("                    Launcher.ShowDialog()")
                        Launcher.ShowDialog()
                    Catch ex As System.InvalidOperationException
                        Debug.WriteLine("                Catch ex As System.InvalidOperationException")

                        Debug.WriteLine(ex.Message)
                        Debug.WriteLine("                End Try")

                    End Try

                Case 6 ' CTRL + TAB
                    Debug.WriteLine("            Case 6: CTRL + TAB")
                    Debug.WriteLine("                If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then")
                    Debug.WriteLine("TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                    Debug.WriteLine("TabControl1.TabCount = " & TabControl1.TabCount - 1)
                    If TabControl1.SelectedIndex < TabControl1.TabCount - 1 Then
                        Debug.WriteLine("                    TabControl1.SelectedIndex += 1")
                        TabControl1.SelectedIndex += 1
                        Debug.WriteLine("                    TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                    Else
                        Debug.WriteLine("                Else")
                        Debug.WriteLine("                    TabControl1.SelectedIndex = 0")
                        TabControl1.SelectedIndex = 0
                        Debug.WriteLine("                End If")
                    End If

                Case 7 ' CTRL + SHIFT + TAB
                    Debug.WriteLine("            Case 7: CTRL + SHIFT + TAB")
                    Debug.WriteLine("                If TabControl1.SelectedIndex > 0 Then")
                    Debug.WriteLine("                TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                    If TabControl1.SelectedIndex > 0 Then
                        Debug.WriteLine("                    TabControl1.SelectedIndex -= 1")
                        TabControl1.SelectedIndex -= 1
                        Debug.WriteLine("                    TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                    Else
                        Debug.WriteLine("                Else")
                        Debug.WriteLine("                    TabControl1.SelectedIndex = TabControl1.TabCount - 1")
                        TabControl1.SelectedIndex = TabControl1.TabCount - 1
                        Debug.WriteLine("                    TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                        Debug.WriteLine("               End If")
                    End If
                    Debug.WriteLine("        End Select")
                Case 8 'CTRL + .
                    MagicAILinkExecute()
            End Select
            Debug.WriteLine("    End If")
        End If

        ' Zusätzliche Logik für Case 1 (Tab-Wechsel) innerhalb der gleichen Hotkey-Nachricht
        Debug.WriteLine("   If m.Msg = WM_HOTKEY AndAlso m.WParam.ToInt32() = 1 Then")
        Debug.WriteLine("   m.Msg = " & m.Msg)
        Debug.WriteLine("   WM_HOTKEY = " & WM_HOTKEY)
        'Debug.WriteLine("   m.WParam.ToInt32() = " & m.WParam.ToInt32)
        If m.Msg = WM_HOTKEY AndAlso m.WParam.ToInt32() = 1 Then
            Debug.WriteLine("        If TabControl1.SelectedIndex > 0 Then")
            Debug.WriteLine("        TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
            If TabControl1.SelectedIndex > 0 Then
                ' Wechsel zum linken Tab
                Debug.WriteLine("            TabControl1.SelectedIndex -= 1")
                TabControl1.SelectedIndex -= 1
                Debug.WriteLine("            TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
            Else
                Debug.WriteLine("        Else")
                ' Wechsel zum rechten Tab, wenn kein linker Tab mehr vorhanden ist
                Debug.WriteLine("            TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1")
                TabControl1.SelectedIndex = TabControl1.TabPages.Count - 1
                Debug.WriteLine("            TabControl1.SelectedIndex = " & TabControl1.SelectedIndex)
                Debug.WriteLine("        End If")
            End If
            Debug.WriteLine("    End If")
        End If

        ' Ende der Methode
        Debug.WriteLine("    MyBase.WndProc(m)")
        Try
            MyBase.WndProc(m)
        Catch ex As System.InvalidCastException
            Debug.WriteLine(ex.Message)
        End Try
        Debug.WriteLine("End of protected overrides sub: WndProc")

    End Sub




    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Überprüfen, ob Ctrl + D gedrückt wird
        Debug.WriteLine("Start of private sub: Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
        Debug.WriteLine("    If e.Control AndAlso e.KeyCode = Keys.D Then")
        Debug.WriteLine("    e.Control = " & e.Control)
        Debug.WriteLine("    e.KeyCode = " & e.KeyCode)
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

    Public downloadVersion
    Public Version As String

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(lpClassName As String, lpWindowName As String) As IntPtr

    End Function
    <DllImport("user32.dll")>
    Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean

    End Function
    Private BootCompleted = False

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
    Public Errorcode As String
    ' Public macroEditor As MacroEditor
    Private TextBox1Text As String
    Private MouseOnTab As TabPage = Nothing
    Public AIWebView As WebView2
    Private Const spacing As Integer = 10 ' Abstand in Pixeln



    Private Sub KeyPress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Debug.WriteLine("Start of private sub: KeyPress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
        Debug.WriteLine("    If TextBox1.Focused Then")
        Debug.WriteLine("    TextBox1.Focused = " & TextBox1.Focused)
        If TextBox1.Focused Then
            Debug.WriteLine("        If e.KeyCode = Keys.Enter Then")
            Debug.WriteLine("        e.KeyCode = " & e.KeyCode)
            If e.KeyCode = Keys.Enter Then
                Debug.WriteLine("            Try")
                Try
                    Debug.WriteLine("                If TextBox1.Text = 'cmd://reboot' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text = "cmd://reboot" Then
                        Debug.WriteLine("                Application.Restart()")
                        Application.Restart()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text = 'cmd://shutdown' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text = "cmd://shutdown" Then
                        Debug.WriteLine("                Application.Exit()")
                        Application.Exit()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text = 'cmd://exit' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text = "cmd://exit" Then
                        Debug.WriteLine("                Application.Exit()")
                        Application.Exit()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text = 'cmd://kill' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text = "cmd://kill" Then
                        Debug.WriteLine("                Application.Exit()")
                        Application.Exit()
                    End If
                    Debug.WriteLine("                If TextBox1.Text = 'cmd://about' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text = "cmd://about" Then
                        Debug.WriteLine("                Dim AppInfo As New AppInfo(Me)")
                        Dim AppInfo As New AppInfo(Me)
                        Debug.WriteLine("                AppInfo.ShowDialog()")
                        AppInfo.ShowDialog()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text = 'cmd://setup' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text = "cmd://setup" Then
                        Debug.WriteLine("                Settings.ShowDialog()")
                        Settings.ShowDialog()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text IsNot 'cmd://reboot' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text IsNot "cmd://reboot" Then
                        Debug.WriteLine("                SearchURL()")
                        SearchURL()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text IsNot 'cmd://shutdown' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text IsNot "cmd://shutdown" Then
                        Debug.WriteLine("                SearchURL()")
                        SearchURL()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text IsNot 'cmd://exit' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text IsNot "cmd://exit" Then
                        Debug.WriteLine("                SearchURL()")
                        SearchURL()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text IsNot 'cmd://kill' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text IsNot "cmd://kill" Then
                        Debug.WriteLine("                SearchURL()")
                        SearchURL()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text IsNot 'cmd://about' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text IsNot "cmd://about" Then
                        Debug.WriteLine("                SearchURL()")
                        SearchURL()
                        Debug.WriteLine("           End If")
                    End If
                    Debug.WriteLine("                If TextBox1.Text IsNot 'cmd://setup' Then")
                    Debug.WriteLine("                TextBox1.Text = " & TextBox1.Text)
                    If TextBox1.Text IsNot "cmd://setup" Then
                        Debug.WriteLine("                SearchURL()")
                        SearchURL()
                        Debug.WriteLine("           End If")
                    End If
                    Try
                        Debug.WriteLine("                Try")
                        Debug.WriteLine("                    WebView21.CoreWebView2.Navigate(TextBox1.Text)")
                        Debug.WriteLine("                    TextBox1.Text = " & TextBox1.Text)
                        WebView21.CoreWebView2.Navigate(TextBox1.Text)

                    Catch ex As System.NullReferenceException
                        Debug.WriteLine(ex.Message)

                    End Try
                    Debug.WriteLine("               e.SuppressKeyPress = True")
                    e.SuppressKeyPress = True
                    Debug.WriteLine("               e.SuppressKeyPress = " & e.SuppressKeyPress)
                Catch ex As System.NullReferenceException
                    Debug.WriteLine(ex.Message)

                End Try
                Debug.WriteLine("            End Try")
                Debug.WriteLine("        End If")
            End If


            Debug.WriteLine("   End If")
        End If

        Debug.WriteLine("End of private sub: KeyPress_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")

    End Sub

    Private Sub NavigatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigatiToolStripMenuItem.Click

    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
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
    Private Sub Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        Debug.WriteLine("Start of sub: Form1_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate")

        ' Unregister all HotKeys
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
    Private Sub Form1_Activate(sender As Object, e As EventArgs) Handles Me.Activated
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
    Private Async Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Booting...")
        Debug.WriteLine("Start of async sub: Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load")

        Debug.WriteLine("    booting.Show()")
        booting.Show()

        Debug.WriteLine("   booting.bootprogress.Value = 0")
        booting.bootprogress.Value = 0
        Debug.WriteLine("   booting.bootprogress.Value = -->")
        Debug.WriteLine(booting.bootprogress)
        ' Setzt die Version
        Debug.WriteLine("Version = '2024.12.27'")
        Version = "2024.12.27"
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
            Debug.WriteLine("        Name = My.Settings.MainWindowWindowName")
            Name = My.Settings.MainWindowWindowName
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
                End If
                Debug.WriteLine("        End If")
            End If
            'MainWindowWindowAcceptButton
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Nothing' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
            If My.Settings.MainWindowWindowAcceptButton = "Nothing" Then
                Debug.WriteLine("            AcceptButton = Nothing")
                AcceptButton = Nothing
                Debug.WriteLine("            AcceptButton = -->")
                Debug.WriteLine(AcceptButton)
                Debug.WriteLine("        End If")
            End If
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Back' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
            If My.Settings.MainWindowWindowAcceptButton = "Back" Then
                Debug.WriteLine("            AcceptButton = Back")
                AcceptButton = Back
                Debug.WriteLine("            End If")

            End If
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Cancel' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)

            If My.Settings.MainWindowWindowAcceptButton = "Cancel" Then
                AcceptButton = Cancel
            End If
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Forward' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
            If My.Settings.MainWindowWindowAcceptButton = "Forward" Then
                AcceptButton = Forward
            End If
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Home' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
            If My.Settings.MainWindowWindowAcceptButton = "Home" Then
                AcceptButton = Home
            End If
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Refresh' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
            If My.Settings.MainWindowWindowAcceptButton = "Refresh" Then
                AcceptButton = Refresh
            End If
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Search' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
            If My.Settings.MainWindowWindowAcceptButton = "Search" Then
                AcceptButton = Search
            End If
            Debug.WriteLine("        If My.Settings.MainWindowWindowAcceptButton = 'Shortcuts' Then")
            Debug.WriteLine("        My.Settings.MainWindowWindowAcceptButton = " & My.Settings.MainWindowWindowAcceptButton)
            If My.Settings.MainWindowWindowAcceptButton = "Shortcuts" Then
                AcceptButton = Shortcuts
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
            If My.Settings.Sprache = "Deutsch" Then

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
                BeendenToolStripMenuItem.Text = "Beenden"
                TextBox1.Text = "Hier URL eingeben"
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
                Launcher.Musik.Text = "Musik"
                Launcher.Geraete.Text = "Geräte"
                Launcher.important.Text = "Es kann sein, dass manche Dienste auf dieser Seite kostenpflichtig über einen einmaligen Preis oder ein Abomodell bezahlt werden sollen
oder man kann damit einkaufen.
Unbezahlte Werbung
"
                Launcher.ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
                ConnectToNAS.Text = "Einen NAS verbinden"
                ConnectToNAS.Label1.Text = "Welchen NAS 
  benutzt du?"
                ConnectToNAS.ManualConnection.Text = "Stattdessen IP-Adresse eingeben"
                ConnectToNAS.Cancel.Text = "Abbrechen"
                AppInfoToolStripMenuItem.Text = "Über WebConnect"
                AppInfo.Text = "Über WebConnect"

            End If
            If My.Settings.Sprache = "English" Then
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
                BeendenToolStripMenuItem.Text = "Shut down"
                NeustartenToolStripMenuItem.Text = "Reboot"
                AppInfoToolStripMenuItem.Text = "About"
                EinstellungenToolStripMenuItem.Text = "Settings"
                VorToolStripMenuItem.Text = "Forward"
                ZurückToolStripMenuItem.Text = "Backward"
                AktualisierenToolStripMenuItem.Text = "Reload"
                StartseiteToolStripMenuItem.Text = "Start Page"
                NeuerTabToolStripMenuItem.Text = "New Tab"
                TextBox1.Text = "Enter URL here"
                Dim AppInfo As New AppInfo(Me)
                AppInfo.Text = "App info"
                AppInfo.Description.Text = "WebConnect
FrontEnd version: 1.0.0-015
BackEnd: WebView2 (Microsoft.Web.WebView2.WinForms)
BackEnd version: 1.0.1823.32
Programmer: PhilConnected (Phileas Melchert)
"
                Launcher.Musik.Text = "Music"
                Launcher.Geraete.Text = "Devices"
                Launcher.important.Text = "It may be that some services on this site require payment via a one-off price or a subscription model
or you can use it to shop.
Unpaid advertising
"
                Launcher.ManualConnection.Text = "Enter IP address instead"
            End If
            If My.Settings.Sprache = "Français" Then
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
            End If
            If My.Settings.Sprache = "Español" Then
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
            End If
            If My.Settings.Sprache = "Türkçe" Then
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
            booting.bootprogress.Value = 42

            AddInitialTab()
            booting.bootprogress.Value = 56
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
            booting.bootprogress.Value = 70
            RegisterBrowserForProtocolsAndFileTypes()
            booting.bootprogress.Value = 84
            RegisterBrowserForHttpAndHttps()
            booting.bootprogress.Value = 91
            RegisterAsDefaultApp()
            booting.bootprogress.Value = 94
            If My.Settings.OrganizationMode = True Then
                Me.Text = "WebConnect für Windows | WebConnect wird von einer Organisation bzw. von einem Systemadmin namens " & My.Settings.OrganizationName & " verwaltet"

            End If
            If My.Settings.OrganizationMode = False Then
                Me.Text = "WebConnect für Windows"
            End If
            If My.Settings.AutomaticSoftwareUpdateNotification = True Then
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
                            SoftwareUpdateTool.Label1.Text = "Es ist ein Software-Update 
                  für WebConnect verfügbar!
                "
                            SoftwareUpdateTool.RichTextBox1.Text = "!!!HINWEIS!!! SOBALD DIE HERUNTERGELADENE UPDATEDATEI GESTARTET WURDE UND DAS UPDATE INSTALLIERT WIRD,
                IST DER PC NICHT AUSZUSCHALTEN BZW. DIE UPDATEDATEI ZU STOPPEN, DA DIE INSTALLIERTE SOFTWAREVERSION
                DADURCH BESCHÄDIGT WERDEN KANN!!!
                FÜR SCHÄDEN, DIE DURCH EIN DURCH DEN BENUTZER UNSACHGEMÄß AUSGEFÜHRTEN SOFTWAREUPDATE ENTSTEHEN,
                WIRD KEINE HAFTUNG ÜBERNOMMEN!!!
                Neue Version auf Updateserver: " & latestSWVersion & " 
                Beschreibung: " & releaseBody

                            'Return $"Ein Software-Update ist verfügbar!{Environment.NewLine}" &
                            '$"Version: {latestSWVersion}{Environment.NewLine}" &
                            '$"Titel: {releaseTitle}{Environment.NewLine}" &
                            '       $"Beschreibung: {releaseBody}{Environment.NewLine}" &
                            '      $"Downloadlink: {downloadURL}"
                        End If
                    End Using
                Catch ex As Exception

                End Try

            End If
            BootCompleted = True
            booting.bootprogress.Value = 100
            booting.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            BootError.ShowDialog()
            Application.Exit()
        Catch ex As FileNotFoundException
            MsgBox(ex.Message)
            BootError.ShowDialog()
        End Try
    End Sub


    Private Function CompareVersions(version1 As String, version2 As String) As Integer
        version1 = version1.TrimStart("v"c)
        version2 = version2.TrimStart("v"c)

        version1 = NormalizeVersionString(version1)
        version2 = NormalizeVersionString(version2)

        Dim v1 As Version = New Version(version1)
        Dim v2 As Version = New Version(version2)

        Return v1.CompareTo(v2)
    End Function
    Private Function NormalizeVersionString(version As String) As String
        Dim parts As String() = version.Split("."c)

        While parts.Length < 2
            version &= ".0"
            parts = version.Split("."c)
        End While

        Return String.Join(".", parts.Take(4))
    End Function
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

    Private Sub Home_Click(sender As Object, e As EventArgs)
        Startpage()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NeustartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeustartenToolStripMenuItem.Click
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
                TextBox1.Text = "Du kannst nicht weiter zurück gehen"
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
    Private Async Sub Startpage()
        Dim webView As WebView2 = GetCurrentWebView()
        Await WebView21.EnsureCoreWebView2Async()

        ' Setze die Sprache über die DefaultHeaders
        Dim headers As String = "Accept-Language: en-EN" & vbCrLf

        If webView IsNot Nothing Then
            If My.Settings.DefaultSearchEngine = "Google" Then
                ' Initialisiere die WebView2-Umgebung
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
            Try
                If WebView21.CoreWebView2 IsNot Nothing Then
                    WebView21.CoreWebView2.Settings.UserAgent = "WebConnect/1.0 (Custom User-Agent)"
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











    Private Sub NeuerTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuerTabToolStripMenuItem.Click
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

    Private Async Sub TabSchließenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabSchließenToolStripMenuItem.Click
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

    Private Sub TabSchließenToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TabSchließenToolStripMenuItem1.Click
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
                If My.Settings.DefaultAIEngine = "Microsoft Copilot" Then
                    Me.AIWebView.CoreWebView2.Navigate("https://copilot.microsoft.com/")
                    Settings.PendingAIChanges = False
                End If
                If My.Settings.DefaultAIEngine = "Google Gemini" Then
                    Me.AIWebView.CoreWebView2.Navigate("https://gemini.google.com/app?hl=de")
                    Settings.PendingAIChanges = False

                End If
                If My.Settings.DefaultAIEngine = "ChatGPT" Then
                    Me.AIWebView.CoreWebView2.Navigate("https://chatgpt.com/")
                    Settings.PendingAIChanges = False

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
End Class


' Google als Startseite festlegen? https://www.google.com/intl/de_ALL/homepage/hp-edge.html?utm_source=google.com&utm_medium=callout&utm_campaign=EDHP
