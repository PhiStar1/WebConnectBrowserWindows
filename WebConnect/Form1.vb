Public Class Form1


    Private Sub NavigatiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigatiToolStripMenuItem.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Me.Text = "Fenster wird geladen"

        Me.Text = "WebConnect-Browser für Windows"






    End Sub

    Private Sub WebView21_Click(sender As Object, e As EventArgs) Handles WebView21.Click

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        If WebView21.CanGoBack Then
            WebView21.GoBack()
        Else
            TextBox1.Text = "Du kannst nicht weiter zurückgehen"
        End If


    End Sub

    Private Sub Forward_Click(sender As Object, e As EventArgs) Handles Forward.Click

        If WebView21.CanGoForward Then
            WebView21.GoForward()
        Else
            TextBox1.Text = "Du kannst nicht weiter vorgehen"
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        If TextBox1.Text = "Hier URL eingeben" Then
            TextBox1.Clear()
        End If
        If TextBox1.Text = "Du kannst nicht weiter zurückgehen" Then
            TextBox1.Clear()
        End If
        If TextBox1.Text = "Du kannst nicht weiter vorgehen" Then
            TextBox1.Clear()

        End If
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        ''Dim URL As String = TextBox1.Text
        If TextBox1.Text = "Hier URL eingeben" Then
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
        WebView21.CoreWebView2.Navigate(TextBox1.Text)
        ''End If

    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        WebView21.CoreWebView2.Reload()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        WebView21.CoreWebView2.Stop()

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        WebView21.CoreWebView2.Navigate("https://www.google.com/")
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NeustartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeustartenToolStripMenuItem.Click
        Application.Restart()
    End Sub

    Private Sub AppInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AppInfoToolStripMenuItem.Click
        AppInfo.ShowDialog()

    End Sub

    Private Sub VorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VorToolStripMenuItem.Click
        If WebView21.CanGoForward Then
            WebView21.GoForward()
        Else
            TextBox1.Text = "Du kannst nicht weiter vorgehen"
        End If
    End Sub

    Private Sub ZurückToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZurückToolStripMenuItem.Click
        If WebView21.CanGoBack Then
            WebView21.GoBack()
        Else
            TextBox1.Text = "Du kannst nicht weiter zurückgehen"
        End If


    End Sub

    Private Sub AktualisierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AktualisierenToolStripMenuItem.Click
        WebView21.Reload()
    End Sub

    Private Sub StartseiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartseiteToolStripMenuItem.Click
        WebView21.CoreWebView2.Navigate("https://www.google.de/")
    End Sub
End Class
' Google als Startseite festlegen? https://www.google.com/intl/de_ALL/homepage/hp-edge.html?utm_source=google.com&utm_medium=callout&utm_campaign=EDHP