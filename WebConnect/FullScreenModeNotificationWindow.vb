Imports System.Windows.Forms

Public Class FullScreenModeNotificationWindow
    Private Sub FullScreenModeNotificationWindow(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
    End Sub
    Private Sub FullScreenModeNotificationWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Header.Text = "Folgende Seite hat den Vollbild-Modus gestartet:"
            Description.Text = "Um zur normalen Ansicht zurückzugehen, drücke 'F11' auf deiner Tastatur."
            CloseMessage.Text = "OK"
        End If
        If Form1.Language = "en" Then
            Header.Text = "The following page has entered full screen mode:"
            Description.Text = "To return to normal view, press 'F11' on your keyboard."
            CloseMessage.Text = "OK"
        End If
        If Form1.Language = "fr" Then
            Header.Text = "La page suivante est passée en mode plein écran :"
            Description.Text = "Pour revenir à la vue normale, appuyez sur 'F11' sur votre clavier."
            CloseMessage.Text = "OK"
        End If
        If Form1.Language = "es" Then
            Header.Text = "La siguiente página ha entrado en modo de pantalla completa:"
            Description.Text = "Para volver a la vista normal, presione 'F11' en su teclado."
            CloseMessage.Text = "OK"
        End If
        If Form1.Language = "it" Then
            Header.Text = "La seguente pagina è entrata in modalità a schermo intero:"
            Description.Text = "Per tornare alla visualizzazione normale, premi 'F11' sulla tastiera."
            CloseMessage.Text = "OK"
        End If
        If Form1.Language = "tr" Then
            Header.Text = "Aşağıdaki sayfa tam ekran moduna girdi:"
            Description.Text = "Normal görünüme dönmek için klavyenizdeki 'F11' tuşuna basın."
            CloseMessage.Text = "Tamam"
        End If
        Me.Opacity = 100
        Me.KeyPreview = True
        ' Immer Monitor vom aktiven Fenster nehmen
        Dim currentScreen As Screen = Screen.FromControl(Form.ActiveForm)

        ' Optional: stattdessen Monitor unter der Maus nehmen
        ' Dim currentScreen As Screen = Screen.FromPoint(Cursor.Position)

        ' Position in die Mitte des Monitors setzen
        Dim bounds As Rectangle = currentScreen.Bounds
        Me.StartPosition = FormStartPosition.Manual
        Me.Location = New Point(
            bounds.Left + (bounds.Width - Me.Width) \ 2,
            bounds.Top + (bounds.Height - Me.Height) \ 10 ' eher oben Mitte
        )
        If Form1.TabControl1.SelectedTab IsNot Nothing Then

            FullScreenSource.Text = Form1.TabControl1.SelectedTab.Text
        Else

        End If



        AutoCloseTimerIndicator.Value = 0
        AutoCloseFullscreenNotification.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles AutoCloseFullscreenNotification.Tick
        If AutoCloseTimerIndicator.Value = 90 Then
            CloseDelayOnIndicatorEnding.Start()
            AutoCloseFullscreenNotification.Stop()
        End If
        AutoCloseTimerIndicator.Value += 5

    End Sub

    Private Sub CloseDelayOnIndicatorEnding_Tick(sender As Object, e As EventArgs) Handles CloseDelayOnIndicatorEnding.Tick
        BlendoutAnimation.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseMessage.Click
        Me.Close()
    End Sub

    Private Sub BlendoutAnimation_Tick(sender As Object, e As EventArgs) Handles BlendoutAnimation.Tick
        Me.Opacity = Me.Opacity - 5
        If Me.Opacity = 0 Then
            Me.Close()
        End If
    End Sub

    Private Sub AutoCloseTimerIndicator_Click(sender As Object, e As EventArgs) Handles AutoCloseTimerIndicator.Click

    End Sub
End Class