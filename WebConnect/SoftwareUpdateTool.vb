Imports System.Net
Imports System.Net.Http
Imports System.Reflection.Emit
Imports Newtonsoft.Json

Public Class SoftwareUpdateTool
    Public downloadVersion
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Async Sub SoftwareUpdateTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadButton.Hide()
        RichTextBox1.Hide()
        Label1.Text = "Es wird nach Software-Updates 
  für dein WebConnect gesucht"
        Dim updateMessage As String = Await SearchForSWUpdate()
    End Sub
    Private Async Function SearchForSWUpdate() As Task(Of String)
        Dim currentSWVersion As String = Form1.Version
        Dim SWOwnerongithub As String = "PhiStar1"
        Dim SWNameOnGithub As String = "WebConnectBrowserWindows"
        Return Await CheckForSWUpdate(currentSWVersion, SWOwnerongithub, SWNameOnGithub)
    End Function

    Private Async Function CheckForSWUpdate(currentSWVersion As String, SWOwnerongithub As String, SWNameOnGithub As String) As Task(Of String)
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
                    DownloadButton.Show()
                    RichTextBox1.Show()
                    Label1.Text = "Es ist ein Software-Update 
  für WebConnect verfügbar!
"
                    RichTextBox1.Text = "!!!HINWEIS!!! SOBALD DIE HERUNTERGELADENE UPDATEDATEI GESTARTET WURDE UND DAS UPDATE INSTALLIERT WIRD,
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
                Else
                    Label1.Text = "Deine Software ist 
  auf dem neuesten Stand."
                    Label4.Text = "Softwareversion: " & currentSWVersion
                End If
            End Using
        Catch ex As HttpRequestException
            Label1.Text = "Netzwerkfehler bei der Suche nach Updates"
            Label4.Text = "Es konnte zum Update-Server keine Internetverbindung hergestellt werden.
Überprüfe deine Internetverbindung und versuche es nochmal.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As TaskCanceledException
            Label1.Text = "Verbindungs-Timeout"
            Label4.Text = "Der Server hat 
  nicht rechtzeitig geantwortet
bzw. deine Internetverbindung ist zu langsam.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As JsonSerializationException
            Label1.Text = "Fehler im Format der Softwareupdate-Daten"
            Label4.Text = "Die vom Update-Server gesendeten Softwareupdatedaten sind im falschen Format.
Versuche es später erneut.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch Ex As JsonReaderException
            Label1.Text = "Fehler beim Lesen der Softwareupdate-Daten"
            Label4.Text = "Die vom Update-Server gesendeten Softwareupdatedaten sind nicht lesbar.
Versuche es später erneut.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As ArgumentException
            Label1.Text = "Nummer des Softwareupdates 
  ist ungültig"
            Label4.Text = "Kontaktiere den Support bzw. das Systemadmin.

Versuche es später erneut!!!"
        Catch ex As FormatException
            Label1.Text = "Format der Nummer des Softwareupdates 
  ist ungültig"
            Label4.Text = "Kontaktiere den Support bzw. das Systemadmin.

Versuche es später erneut!!!"
        Catch ex As InvalidOperationException
            Label1.Text = "Operationsfehler"
            Label4.Text = "Operation nicht möglich"
        Catch ex As NullReferenceException
            Label1.Text = "Softwareupdate-Programm beschädigt"
            Label4.Text = "Ein für diese Funktion erforderliches Objekt fehlt.
Behebe den Fehler mit der WebConnect Recovery Software
('WebConnect-->Einstellungen-->Wiederherstellung)
Sollte das den Fehler nicht beheben:
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As ArgumentNullException
            Label1.Text = "Softwareupdate-Programm beschädigt"
            Label4.Text = "Ein für diese Funktion erforderliches 
eigentlich vorhandenes Argument fehlt.
Behebe den Fehler mit der WebConnect Recovery Software
('WebConnect-->Einstellungen-->Wiederherstellung)
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As AggregateException
            Label1.Text = "Es ist min. 1 Fehler aufgetreten"
            Label4.Text = "Es ist min. 1 Fehler aufgetreten.
Behebe den Fehler mit der WebConnect Recovery Software
('WebConnect-->Einstellungen-->Wiederherstellung)
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As UnauthorizedAccessException
            Label1.Text = "Kein Zugriff auf Software-Update"
            Label4.Text = "Du hast nicht ausreichend Rechte, 
um nach Software-Updates zu suchen.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As WebException
            Label1.Text = "Netzwerkfehler"
            Label4.Text = "Es gibt ein Netzwerk- oder Serverproblem.
Überprüfe deine Internetverbindung und versuche es nochmal.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        Catch ex As Exception
            Label1.Text = "Unbekannter Fehler"
            Label4.Text = "Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        End Try
    End Function
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

    Private Sub DownloadButton_Click(sender As Object, e As EventArgs) Handles DownloadButton.Click
        Dim mainForm As Form1 = DirectCast(Application.OpenForms("Form1"), Form1)
        Debug.WriteLine("Dim mainForm As Form1 = DirectCast(Application.OpenForms(Form1), Form1)")


        Dim newswversion As String = "https://github.com/PhiStar1/WebConnectBrowserWindows/releases/download/" + downloadVersion + "/WebConnect.exe"
        Debug.WriteLine("Dim downloadURL As String = 'https: //github.com/PhiStar1/WebConnectBrowserWindows/releases/latest'")
        MessageBox.Show("Das Software-Update wird im Hintergrund heruntergeladen. 
Der Vorgang kann einige Zeit in Anspruch nehmen.
Falls folgendes Fenster erscheint: WebConnect.exe wird nicht häufig heruntergeladen, gehe wie gefolgt vor, um die Updatedatei zu installieren.
Klicke in dem Fenster auf ...-->Beibehalten-->Mehr Anzeigen--> Trotzdem beibehalten
Während die Updatedatei ausgeführt wird, ist der PC nicht auszuschalten bzw. das Programm zu beenden, 
da dies Schäden an der aktuell installierten Softwareversion verursachen kann.
Für Schäden, die durch ein vom Benutzer unsachgemäßes ausgeführtes Update entstehen, wird keine Haftung übernommen.")
        Form1.AddNewTab(newswversion)

    End Sub
End Class