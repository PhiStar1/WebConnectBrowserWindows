Imports System.Security.Cryptography.X509Certificates

Public Class Crashed
    Dim StopcodeLang As String
    'Dieses Fenster wird angezeigt, wenn ein Fehler auftritt.
    'Dieses Fenster zeigt dem Benutzer den Fehlercode an.
    'Das bringt folgendes: Der Benutzer kann den Fehlercode sehen und diesen an den Entwickler weitergeben.
    'Dieser Sub wird ausgeführt, wenn das Fenster geladen wird.
    'Dieser Sub wird nicht verwendet.
    Private Sub Crashed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Ein Fehler ist aufgetreten!!!"
            Header.Text = "Autsch!!!"
            Description.Text = "Mit deinen WebConnect-Browser ist ein Fehler aufgetreten.
Von dem her muss er neu gestartet werden.

Ist dass das erste Mal, dass du diesen Fehler siehst:
- Drücke auf Neustarten, um WebConnnect neuzustarten.
Tritt dieser Fehler erneut auf, versuche folgendes:
- Repariere WebConnect über das Recovery-Menü: Dazu klickst du auf WebConnect --> Einstellungen --> Wederherstellung
- Beende Apps, die unnötig Ressourcen im Hintergrund verbrauchen
- Aktualisiere die Software-Version auf die neuste Version: Dazu klickst du auf WebConnect --> Einstellungen --> Software-Update --> Nach Softwareupdates suchen
  - Falls neuste Version installiert: Installiere WebConnect neu"
            StopcodeLang = "Fehlercode: "
        End If
        If Form1.Language = "en" Then
            Me.Text = "An error has occurred!!!"
            Header.Text = "Ouch!!!"
            Description.Text = "An error occurred in your WebConnect browser.
Therefore, it needs to be restarted.

If this is the first time you've seen this error:
- Click Restart to restart WebConnect.
If this error occurs again, try the following:
- Repair WebConnect via the Recovery menu: To do this, click WebConnect --> Settings --> Recovery
- Quit apps that are consuming unnecessary resources in the background
- Update the software version to the latest version: To do this, click WebConnect --> Settings --> Software Update --> Check for Software Updates
  - If the latest version is installed: Reinstall WebConnect"
            StopcodeLang = "Error code: "
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Une erreur est survenue !!!"
            Header.Text = "Aïe!!!"
            Description.Text = "Une erreur s'est produite avec ton navigateur WebConnect.
Il faut donc le redémarrer.

Si c'est la première fois que tu vois cette erreur :
- Appuie sur Redémarrer pour redémarrer WebConnnect.
Si l'erreur se reproduit, essaie ce qui suit :
- Réparer WebConnect via le menu de récupération : Pour ce faire, clique sur WebConnect --> Paramètres --> Récupération
- Arrête les applications qui consomment inutilement des ressources en arrière-plan
- Mettre à jour la version du logiciel vers la dernière version : pour ce faire, clique sur WebConnect --> Paramètres --> Mise à jour du logiciel --> Rechercher les mises à jour du logiciel
 - Si la dernière version est installée : Réinstaller WebConnect"
            StopcodeLang = "Code d'erreur: "
        End If
        If Form1.Language = "es" Then
            Me.Text = "¡Ha ocurrido un error!"
            Header.Text = "¡Ay!"
            Description.Text = "Se ha producido un error en su navegador WebConnect.
Por lo tanto, debe reiniciarlo.

Si es la primera vez que aparece este error:
- Pulse Reiniciar para reiniciar WebConnnect.
Si se vuelve a producir este error, intente lo siguiente:
- Repare WebConnect a través del menú de recuperación: Para ello, haga clic en WebConnect --> Configuración --> Recuperación
- Cierre las aplicaciones que estén consumiendo recursos innecesariamente en segundo plano
- Actualice la versión de software a la última versión: Para ello, haga clic en WebConnect --> Configuración --> Actualización de software --> Buscar actualizaciones de software
 - Si está instalada la última versión: Reinstale WebConnect"

            StopcodeLang = "Código de error: "
        End If
        If Form1.Language = "it" Then
            Me.Text = "Si è verificato un errore!!!"
            Header.Text = "Ahi!!!"
            Description.Text = "Si è verificato un errore nel browser WebConnect.
È quindi necessario riavviare il browser.

Se è la prima volta che si verifica questo errore:
- Premere Riavvia per riavviare WebConnect.
Se l'errore si ripete, provare a procedere come segue:
- Riparare WebConnect tramite il menu di ripristino: Per farlo, fare clic su WebConnect --> Impostazioni --> Recupero
- Chiudere le applicazioni che consumano inutilmente risorse in background
- Aggiornare la versione del software alla versione più recente: Per farlo, fare clic su WebConnect --> Impostazioni --> Aggiornamento software --> Verifica aggiornamenti software
 - Se è installata la versione più recente: Reinstallare WebConnect"
            StopcodeLang = "Codice di errore: "
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Bir hata oluştu!!!"
            Header.Text = "Ouch!!!"
            Description.Text = "WebConnect tarayıcınızda bir hata oluştu.
Bu nedenle yeniden başlatılması gerekir.

Bu hatayı ilk kez görüyorsanız:
- WebConnect'i yeniden başlatmak için Yeniden Başlat'a basın.
Bu hata tekrar oluşursa, aşağıdakileri deneyin:
- Kurtarma menüsü aracılığıyla WebConnect'i onarın: Bunu yapmak için WebConnect --> Ayarlar --> Kurtarma'ya tıklayın
- Arka planda gereksiz yere kaynak tüketen uygulamaları kapatın
- Yazılım sürümünü en son sürüme güncelleyin: Bunu yapmak için WebConnect --> Ayarlar --> Yazılım güncelleme --> Yazılım güncellemelerini kontrol et'e tıklayın
 - En son sürüm yüklüyse: WebConnect'i yeniden yükleyin"
            StopcodeLang = "Hata kodu: "
        End If
    End Sub
    'Dieser Sub wird ausgeführt, wenn der Fehlercode übergeben wird.
    'Dieser Sub zeigt dem Benutzer den Fehlercode an.
    Public Sub Showerrorcode(Errorcode As String)
        Debug.WriteLine("WARNING!!! An Error occurred. Error code: " & Errorcode)
        Debug.WriteLine("Start of public sub: Showerrorcode(Errorcode As String)")
        'Der Fehlercode wird dem Benutzer angezeigt.
        Debug.WriteLine("    Label4.Text = 'Fehlercode: ' & Errorcode")
        Me.Stopcode.Text = StopcodeLang & Errorcode
        Debug.WriteLine("Label4.Text = " & Me.Stopcode.Text)
        Debug.WriteLine("End of public sub: Showerrorcode(Errorcode As String)")
    End Sub
End Class