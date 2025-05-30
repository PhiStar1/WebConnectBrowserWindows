Imports System.Net
Imports System.Net.Http
Imports System.Reflection.Emit
Imports Newtonsoft.Json

Public Class SoftwareUpdateTool
    Dim searchForSWUpdateScreenMessage As String
    Public readyToDownloadSWUpdateScreenMessage As String
    Public importantNoteScreenMessage As String
    Dim newestSWVersionInstalledScreenMessage As String
    Dim installedSWVersionScreenMessage As String
    Dim HttpRequestExceptionErrorMessageHeader As String
    Dim HttpRequestExceptionErrorMessageDescription As String
    Dim TaskCanceledExceptionErrorMessageHeader As String
    Dim TaskCanceledExceptionErrorMessageDescription As String
    Dim JsonSerializationExceptionErrorMessageHeader As String
    Dim JsonSerializationExceptionErrorMessageDescription As String
    Dim JsonReaderExceptionErrorMessageHeader As String
    Dim JsonReaderExceptionErrorMessageDescription As String
    Dim ArgumentExceptionErrorMessageHeader As String
    Dim ArgumentExceptionErrorMessageDescription As String
    Dim FormatExceptionErrorMessageHeader As String
    Dim FormatExceptionErrorMessageDescription As String
    Dim InvalidOperationExceptionErrorMessageHeader As String
    Dim InvalidOperationExceptionErrorMessageDescription As String
    Dim NullReferenceExceptionErrorMessageHeader As String
    Dim NullReferenceExceptionErrorMessageDescription As String
    Dim ArgumentNullExceptionErrorMessageHeader As String
    Dim ArgumentNullExceptionErrorMessageDescription As String
    Dim AggregateExceptionErrorMessageHeader As String
    Dim AggregateExceptionErrorMessageDescription As String
    Dim UnauthorizedAccessExceptionErrorMessageHeader As String
    Dim UnauthorizedAccessExceptionErrorMessageDescription As String
    Dim WebExceptionErrorMessageHeader As String
    Dim WebExceptionErrorMessageDescription As String
    Dim ExceptionErrorMessageHeader As String
    Dim ExceptionErrorMessageDescription As String
    Public downloadVersion
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Async Sub SoftwareUpdateTool_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Form1.Language = "de" Then
            Me.Text = "Software-Update"
            Label2.Text = "Schließen"
            searchForSWUpdateScreenMessage = "Es wird nach Software-Updates
für dein WebConnect gesucht"
            readyToDownloadSWUpdateScreenMessage = "Es ist ein Software-Update
für WebConnect verfügbar!"
            importantNoteScreenMessage = "!!!HINWEIS!!! SOBALD DIE HERUNTERGELADENE UPDATEDATEI GESTARTET WURDE UND DAS UPDATE INSTALLIERT WIRD,
IST DER PC NICHT AUSZUSCHALTEN BZW. DIE UPDATEDATEI ZU STOPPEN, DA DIE INSTALLIERTE SOFTWAREVERSION
DADURCH BESCHÄDIGT WERDEN KANN!!!
FÜR SCHÄDEN, DIE DURCH EIN DURCH DEN BENUTZER UNSACHGEMÄß AUSGEFÜHRTE SOFTWAREUPDATE ENTSTEHEN,
WIRD KEINE HAFTUNG ÜBERNOMMEN!!!"
            newestSWVersionInstalledScreenMessage = "Deine Software ist
auf dem neuesten Stand."
            installedSWVersionScreenMessage = "Softwareversion: "
            HttpRequestExceptionErrorMessageHeader = "Netzwerkfehler bei der Suche nach Updates"
            HttpRequestExceptionErrorMessageDescription = "Es konnte zum Update-Server keine Internetverbindung hergestellt werden.
Überprüfe deine Internetverbindung und versuche es nochmal.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            TaskCanceledExceptionErrorMessageHeader = "Verbindungs-Timeout"
            TaskCanceledExceptionErrorMessageDescription = "Der Server hat
nicht rechtzeitig geantwortet
bzw. deine Internetverbindung ist zu langsam.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            JsonSerializationExceptionErrorMessageHeader = "Fehler im Format der Softwareupdate-Daten"
            JsonSerializationExceptionErrorMessageDescription = "Die vom Update-Server gesendeten Softwareupdatedaten sind im falschen Format.
Versuche es später erneut.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            JsonReaderExceptionErrorMessageHeader = "Fehler beim Lesen der Softwareupdate-Daten"
            JsonReaderExceptionErrorMessageDescription = "Die vom Update-Server gesendeten Softwareupdatedaten sind nicht lesbar.
Versuche es später erneut.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            ArgumentExceptionErrorMessageHeader = "Nummer des Softwareupdates ist ungültig"
            ArgumentExceptionErrorMessageDescription = "Kontaktiere den Support bzw. das Systemadmin.
Versuche es später erneut!!!"
            FormatExceptionErrorMessageHeader = "Format der Nummer des Softwareupdates ist ungültig"
            FormatExceptionErrorMessageDescription = "Kontaktiere den Support bzw. das Systemadmin.
Versuche es später erneut!!!"
            InvalidOperationExceptionErrorMessageHeader = "Operationsfehler"
            InvalidOperationExceptionErrorMessageDescription = "Operation nicht möglich"
            NullReferenceExceptionErrorMessageHeader = "Softwareupdate-Programm beschädigt"
            NullReferenceExceptionErrorMessageDescription = "Ein für diese Funktion erforderliches Objekt fehlt.
Behebe den Fehler mit der WebConnect Recovery Software
('WebConnect-->Einstellungen-->Wiederherstellung)
Sollte das den Fehler nicht beheben:
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            ArgumentNullExceptionErrorMessageHeader = "Softwareupdate-Programm beschädigt"
            ArgumentNullExceptionErrorMessageDescription = "Ein für diese Funktion erforderliches
eigentlich vorhandenes Argument fehlt.
Behebe den Fehler mit der WebConnect Recovery Software
('WebConnect-->Einstellungen-->Wiederherstellung)
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            AggregateExceptionErrorMessageHeader = "Es ist min. 1 Fehler aufgetreten"
            AggregateExceptionErrorMessageDescription = "Es ist min. 1 Fehler aufgetreten.
Behebe den Fehler mit der WebConnect Recovery Software
('WebConnect-->Einstellungen-->Wiederherstellung)
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            UnauthorizedAccessExceptionErrorMessageHeader = "Kein Zugriff auf Software-Update"
            UnauthorizedAccessExceptionErrorMessageDescription = "Du hast nicht ausreichend Rechte,
um nach Software-Updates zu suchen.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            WebExceptionErrorMessageHeader = "Netzwerkfehler"
            WebExceptionErrorMessageDescription = "Es gibt ein Netzwerk- oder Serverproblem.
Überprüfe deine Internetverbindung und versuche es nochmal.
Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
            ExceptionErrorMessageHeader = "Unbekannter Fehler"
            ExceptionErrorMessageDescription = "Kontaktiere den Support bzw. das Systemadmin,
wenn das Problem weiterhin besteht!!!"
        ElseIf Form1.Language = "en" Then
            Me.Text = "Software update"
            Label2.Text = "Close"
            searchForSWUpdateScreenMessage = "Searching for software updates 
for your WebConnect"
            readyToDownloadSWUpdateScreenMessage = "A software update for 
WebConnect is available!"
            importantNoteScreenMessage = "!!!IMPORTANT!!! ONCE THE DOWNLOADED UPDATE FILE IS STARTED AND THE UPDATE IS INSTALLED,
THE PC MUST NOT BE SHUT DOWN OR THE UPDATE FILE STOPPED, AS THIS CAN DAMAGE THE INSTALLED SOFTWARE VERSION!!!
NO LIABILITY IS ACCEPTED FOR DAMAGE CAUSED BY A SOFTWARE UPDATE PERFORMED UNSAFELY BY THE USER!!!"
            newestSWVersionInstalledScreenMessage = "Your software is
up to date."
            installedSWVersionScreenMessage = "Software version: "
            HttpRequestExceptionErrorMessageHeader = "Network error when searching for updates"
            HttpRequestExceptionErrorMessageDescription = "Could not establish an internet connection to the update server.
Check your internet connection and try again.
Contact support or system admin if the problem persists!!!"
            TaskCanceledExceptionErrorMessageHeader = "Connection timeout"
            TaskCanceledExceptionErrorMessageDescription = "The server did not respond in time
or your internet connection is too slow.
Contact support or system admin if the problem persists!!!"
            JsonSerializationExceptionErrorMessageHeader = "Error in the format of the software update data"
            JsonSerializationExceptionErrorMessageDescription = "The software update data sent by the update server is in the wrong format.
Try again later.
Contact support or system admin if the problem persists!!!"
            JsonReaderExceptionErrorMessageHeader = "Error reading software update data"
            JsonReaderExceptionErrorMessageDescription = "The software update data sent by the update server is not readable.
Try again later.
Contact support or system admin if the problem persists!!!"
            ArgumentExceptionErrorMessageHeader = "Software update number is invalid"
            ArgumentExceptionErrorMessageDescription = "Contact support or system admin.
Try again later!!!"
            FormatExceptionErrorMessageHeader = "Format of the software update number is invalid"
            FormatExceptionErrorMessageDescription = "Contact support or system admin.
Try again later!!!"
            InvalidOperationExceptionErrorMessageHeader = "Operation error"
            InvalidOperationExceptionErrorMessageDescription = "Operation not possible"
            NullReferenceExceptionErrorMessageHeader = "Software update program damaged"
            NullReferenceExceptionErrorMessageDescription = "A required object for this function is missing.
Fix the error with the WebConnect Recovery Software
('WebConnect-->Settings-->Recovery)
If that does not fix the error:
Contact support or system admin if the problem persists!!!"
            ArgumentNullExceptionErrorMessageHeader = "Software update program damaged"
            ArgumentNullExceptionErrorMessageDescription = "A required argument that should be present is missing.
Fix the error with the WebConnect Recovery Software
('WebConnect-->Settings-->Recovery)
Contact support or system admin if the problem persists!!!"
            AggregateExceptionErrorMessageHeader = "At least one error has occurred"
            AggregateExceptionErrorMessageDescription = "At least one error has occurred.
Fix the error with the WebConnect Recovery Software
('WebConnect-->Settings-->Recovery)
If that does not fix the error:
Contact support or system admin if the problem persists!!!"
            UnauthorizedAccessExceptionErrorMessageHeader = "No access to software update"
            UnauthorizedAccessExceptionErrorMessageDescription = "You do not have sufficient rights to search for software updates.
Contact support or system admin if the problem persists!!!"
            WebExceptionErrorMessageHeader = "Network error"
            WebExceptionErrorMessageDescription = "There is a network or server problem.
Check your internet connection and try again.
Contact support or system admin if the problem persists!!!"
            ExceptionErrorMessageHeader = "Unknown error"
            ExceptionErrorMessageDescription = "Contact support or system admin if the problem persists!!!"


        End If
        If Form1.Language = "fr" Then
            Me.Text = "Mise à jour du logiciel"
            Label2.Text = "Fermer"
            searchForSWUpdateScreenMessage = "Recherche de mises à 
jour logicielles pour votre WebConnect"
            readyToDownloadSWUpdateScreenMessage = "Une mise à jour logicielle 
pour WebConnect est disponible !"
            importantNoteScreenMessage = "!!!IMPORTANT !!! UNE FOIS LE FICHIER DE MISE À JOUR TÉLÉCHARGÉ DÉMARRÉ ET LA MISE À JOUR INSTALLÉE,
LE PC NE DOIT PAS ÊTRE ÉTEINT OU LE FICHIER DE MISE À JOUR ARRÊTÉ, CAR CELA PEUT ENDOMMAGER LA VERSION LOGICIELLE INSTALLÉE !!!
AUCUNE RESPONSABILITÉ N'EST ACCEPTÉE POUR LES DOMMAGES CAUSÉS PAR UNE MISE À JOUR LOGICIELLE EFFECTUÉE DE MANIÈRE INAPPROPRIÉE PAR L'UTILISATEUR !!!"
            newestSWVersionInstalledScreenMessage = "Votre logiciel est à jour"
            installedSWVersionScreenMessage = "Version du logiciel : "
            HttpRequestExceptionErrorMessageHeader = "Erreur réseau lors de la recherche de mises à jour"
            HttpRequestExceptionErrorMessageDescription = "Impossible d'établir une connexion Internet avec le serveur de mise à jour.
Vérifiez votre connexion Internet et réessayez.
Contactez le support ou l'administrateur système si le problème persiste !!!"
            TaskCanceledExceptionErrorMessageHeader = "Délai d'attente de la connexion"
            TaskCanceledExceptionErrorMessageDescription = "Le serveur n'a pas répondu à temps
ou votre connexion Internet est trop lente.
Contactez le support ou l'administrateur système si le problème persiste !!!"
            JsonSerializationExceptionErrorMessageHeader = "Erreur dans le format des données de mise à jour logicielle"
            JsonSerializationExceptionErrorMessageDescription = "Les données de mise à jour logicielle envoyées par le serveur de mise à jour sont au mauvais format.
Essayez à nouveau plus tard.
Contactez le support ou l'administrateur système si le problème persiste !!!"
            JsonReaderExceptionErrorMessageHeader = "Erreur de lecture des données de mise à jour logicielle"
            JsonReaderExceptionErrorMessageDescription = "Les données de mise à jour logicielle envoyées par le serveur de mise à jour ne sont pas lisibles.
Essayez à nouveau plus tard.
Contactez le support ou l'administrateur système si le problème persiste !!!"
            ArgumentExceptionErrorMessageHeader = "Le numéro de mise à jour logicielle est invalide"
            ArgumentExceptionErrorMessageDescription = "Contactez le support ou l'administrateur système.
Essayez à nouveau plus tard !!!"
            FormatExceptionErrorMessageHeader = "Le format du numéro de mise à jour logicielle est invalide"
            FormatExceptionErrorMessageDescription = "Contactez le support ou l'administrateur système.
Essayez à nouveau plus tard !!!"
            InvalidOperationExceptionErrorMessageHeader = "Erreur d'opération"
            InvalidOperationExceptionErrorMessageDescription = "Opération impossible"
            NullReferenceExceptionErrorMessageHeader = "Programme de mise à jour logicielle endommagé"
            NullReferenceExceptionErrorMessageDescription = "Un objet requis pour cette fonction est manquant.
Corrigez l'erreur avec le logiciel de récupération WebConnect
('WebConnect-->Paramètres-->Récupération)
Si cela ne corrige pas l'erreur :
Contactez le support ou l'administrateur système si le problème persiste !!!"
            ArgumentNullExceptionErrorMessageHeader = "Programme de mise à jour logicielle endommagé"
            ArgumentNullExceptionErrorMessageDescription = "Un argument requis qui devrait être présent est manquant.
Corrigez l'erreur avec le logiciel de récupération WebConnect
('WebConnect-->Paramètres-->Récupération)
Contactez le support ou l'administrateur système si le problème persiste !!!"
            AggregateExceptionErrorMessageHeader = "Au moins une erreur s'est produite"
            AggregateExceptionErrorMessageDescription = "Au moins une erreur s'est produite.
Corrigez l'erreur avec le logiciel de récupération WebConnect
('WebConnect-->Paramètres-->Récupération)
Si cela ne corrige pas l'erreur :
Contactez le support ou l'administrateur système si le problème persiste !!!"
            UnauthorizedAccessExceptionErrorMessageHeader = "Aucun accès à la mise à jour logicielle"
            UnauthorizedAccessExceptionErrorMessageDescription = "Vous n'avez pas les droits suffisants pour rechercher des mises à jour logicielles.
Contactez le support ou l'administrateur système si le problème persiste !!!"
            WebExceptionErrorMessageHeader = "Erreur réseau"
            WebExceptionErrorMessageDescription = "Il y a un problème de réseau ou de serveur.
Vérifiez votre connexion Internet et réessayez.
Contactez le support ou l'administrateur système si le problème persiste !!!"
            ExceptionErrorMessageHeader = "Erreur inconnue"
            ExceptionErrorMessageDescription = "Contactez le support ou l'administrateur système si le problème persiste !!!"
        ElseIf Form1.Language = "es" Then
            Me.Text = "Actualización de software"
            Label2.Text = "Cerrar"
            searchForSWUpdateScreenMessage = "Buscando actualizaciones de software 
para tu WebConnect"
            readyToDownloadSWUpdateScreenMessage = "¡Hay una actualización de 
software disponible para WebConnect!"
            importantNoteScreenMessage = "!!!¡IMPORTANTE! UNA VEZ QUE SE INICIE EL ARCHIVO DE ACTUALIZACIÓN DESCARGADO Y SE INSTALE LA ACTUALIZACIÓN,
EL PC NO DEBE APAGARSE NI DETENERSE EL ARCHIVO DE ACTUALIZACIÓN, YA QUE ESTO PUEDE DAÑAR LA VERSIÓN DE SOFTWARE INSTALADA!!!
NO SE ACEPTA NINGUNA RESPONSABILIDAD POR LOS DAÑOS CAUSADOS POR UNA ACTUALIZACIÓN DE SOFTWARE REALIZADA DE MANERA INADECUADA POR EL USUARIO!!!"
            newestSWVersionInstalledScreenMessage = "Su software está actualizado"
            installedSWVersionScreenMessage = "Versión del software: "
            HttpRequestExceptionErrorMessageHeader = "Error de red al buscar actualizaciones"
            HttpRequestExceptionErrorMessageDescription = "No se pudo establecer una conexión a Internet con el servidor de actualizaciones.
Verifica tu conexión a Internet y vuelve a intentarlo.
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            TaskCanceledExceptionErrorMessageHeader = "Tiempo de espera de conexión"
            TaskCanceledExceptionErrorMessageDescription = "El servidor no respondió a tiempo
o tu conexión a Internet es demasiado lenta.
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            JsonSerializationExceptionErrorMessageHeader = "Error en el formato de los datos de actualización de software"
            JsonSerializationExceptionErrorMessageDescription = "Los datos de actualización de software enviados por el servidor de actualizaciones están en el formato incorrecto.
Intenta nuevamente más tarde.
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            JsonReaderExceptionErrorMessageHeader = "Error al leer los datos de actualización de software"
            JsonReaderExceptionErrorMessageDescription = "Los datos de actualización de software enviados por el servidor de actualizaciones no son legibles.
Intenta nuevamente más tarde.
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            ArgumentExceptionErrorMessageHeader = "El número de actualización de software es inválido"
            ArgumentExceptionErrorMessageDescription = "Contacta al soporte o al administrador del sistema.
Intenta nuevamente más tarde!!!"
            FormatExceptionErrorMessageHeader = "El formato del número de actualización de software es inválido"
            FormatExceptionErrorMessageDescription = "Contacta al soporte o al administrador del sistema.
Intenta nuevamente más tarde!!!"
            InvalidOperationExceptionErrorMessageHeader = "Error de operación"
            InvalidOperationExceptionErrorMessageDescription = "Operación no posible"
            NullReferenceExceptionErrorMessageHeader = "Programa de actualización de software dañado"
            NullReferenceExceptionErrorMessageDescription = "Falta un objeto requerido para esta función.
Corrige el error con el software de recuperación de WebConnect
('WebConnect-->Configuración-->Recuperación)
Si eso no corrige el error:
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            ArgumentNullExceptionErrorMessageHeader = "Programa de actualización de software dañado"
            ArgumentNullExceptionErrorMessageDescription = "Falta un argumento requerido que debería estar presente.
Corrige el error con el software de recuperación de WebConnect
('WebConnect-->Configuración-->Recuperación)
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            AggregateExceptionErrorMessageHeader = "Se ha producido al menos un error"
            AggregateExceptionErrorMessageDescription = "Se ha producido al menos un error.
Corrige el error con el software de recuperación de WebConnect
('WebConnect-->Configuración-->Recuperación)
Si eso no corrige el error:
    Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            UnauthorizedAccessExceptionErrorMessageHeader = "Sin acceso a la actualización de software"
            UnauthorizedAccessExceptionErrorMessageDescription = "No tienes los derechos suficientes para buscar actualizaciones de software.
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            WebExceptionErrorMessageHeader = "Error de red"
            WebExceptionErrorMessageDescription = "Hay un problema de red o del servidor.
Verifica tu conexión a Internet y vuelve a intentarlo.
Contacta al soporte o al administrador del sistema si el problema persiste!!!"
            ExceptionErrorMessageHeader = "Error desconocido"
            ExceptionErrorMessageDescription = "Contacta al soporte o al administrador del sistema si el problema persiste!!!"
        ElseIf Form1.Language = "it" Then
            Me.Text = "Aggiornamento software"
            Label2.Text = "Chiudi"
            searchForSWUpdateScreenMessage = "Ricerca di aggiornamenti software 
per il tuo WebConnect"
            readyToDownloadSWUpdateScreenMessage = "È disponibile un aggiornamento 
software per WebConnect!"
            importantNoteScreenMessage = "!!!IMPORTANTE!!! UNA VOLTA AVVIATO IL FILE DI AGGIORNAMENTO SCARICATO E INSTALLATO L'AGGIORNAMENTO,
IL PC NON DEVE ESSERE SPENTO O IL FILE DI AGGIORNAMENTO INTERROTTO, POICHÉ QUESTO PUÒ DANNEGGIARE LA VERSIONE SOFTWARE INSTALLATA!!!
NON SI ACCETTA ALCUNA RESPONSABILITÀ PER I DANNI CAUSATI DA UN AGGIORNAMENTO SOFTWARE ESEGUITO IN MODO INADEGUATO DALL'UTENTE!!!"
            newestSWVersionInstalledScreenMessage = "Il tuo software è 
aggiornato
"
            installedSWVersionScreenMessage = "Versione del software: "
            HttpRequestExceptionErrorMessageHeader = "Errore di rete durante la ricerca di aggiornamenti"
            HttpRequestExceptionErrorMessageDescription = "Impossibile stabilire una connessione Internet con il server di aggiornamento.
Controlla la tua connessione Internet e riprova.
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            TaskCanceledExceptionErrorMessageHeader = "Timeout di connessione"
            TaskCanceledExceptionErrorMessageDescription = "Il server non ha risposto in tempo
o la tua connessione Internet è troppo lenta.
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            JsonSerializationExceptionErrorMessageHeader = "Errore nel formato dei dati di aggiornamento software"
            JsonSerializationExceptionErrorMessageDescription = "I dati di aggiornamento software inviati dal server di aggiornamento sono nel formato sbagliato.
Prova di nuovo più tardi.
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            JsonReaderExceptionErrorMessageHeader = "Errore nella lettura dei dati di aggiornamento software"
            JsonReaderExceptionErrorMessageDescription = "I dati di aggiornamento software inviati dal server di aggiornamento non sono leggibili.
Prova di nuovo più tardi.
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            ArgumentExceptionErrorMessageHeader = "Il numero di aggiornamento software è invalido"
            ArgumentExceptionErrorMessageDescription = "Contatta il supporto o l'amministratore di sistema.
Prova di nuovo più tardi!!!"
            FormatExceptionErrorMessageHeader = "Il formato del numero di aggiornamento software è invalido"
            FormatExceptionErrorMessageDescription = "Contatta il supporto o l'amministratore di sistema.
Prova di nuovo più tardi!!!"
            InvalidOperationExceptionErrorMessageHeader = "Errore di operazione"
            InvalidOperationExceptionErrorMessageDescription = "Operazione non possibile"
            NullReferenceExceptionErrorMessageHeader = "Programma di aggiornamento software danneggiato"
            NullReferenceExceptionErrorMessageDescription = "Manca un oggetto richiesto per questa funzione.
Correggi l'errore con il software di recupero WebConnect
('WebConnect-->Impostazioni-->Recupero)
Se ciò non risolve l'errore:
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            ArgumentNullExceptionErrorMessageHeader = "Programma di aggiornamento software danneggiato"
            ArgumentNullExceptionErrorMessageDescription = "Manca un argomento richiesto che dovrebbe essere presente.
Correggi l'errore con il software di recupero WebConnect
('WebConnect-->Impostazioni-->Recupero)
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            AggregateExceptionErrorMessageHeader = "Si è verificato almeno un errore"
            AggregateExceptionErrorMessageDescription = "Si è verificato almeno un errore.
Correggi l'errore con il software di recupero WebConnect
('WebConnect-->Impostazioni-->Recupero)
Se ciò non risolve l'errore:
            Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            UnauthorizedAccessExceptionErrorMessageHeader = "Nessun accesso all'aggiornamento software"
            UnauthorizedAccessExceptionErrorMessageDescription = "Non hai i diritti sufficienti per cercare aggiornamenti software.
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            WebExceptionErrorMessageHeader = "Errore di rete"
            WebExceptionErrorMessageDescription = "C'è un problema di rete o del server.
Controlla la tua connessione Internet e riprova.
Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
            ExceptionErrorMessageHeader = "Errore sconosciuto"
            ExceptionErrorMessageDescription = "Contatta il supporto o l'amministratore di sistema se il problema persiste!!!"
        ElseIf Form1.Language = "tr" Then
            Me.Text = "Yazılım güncellemesi"
            Label2.Text = "Kapat"
            searchForSWUpdateScreenMessage = "WebConnect'iniz yazılım 
güncellemeleri aranıyor"
            readyToDownloadSWUpdateScreenMessage = "WebConnect için bir 
yazılım güncellemesi mevcut!"
            importantNoteScreenMessage = "!!!ÖNEMLİ!!! İNDİRİLEN GÜNCELLEME DOSYASI BAŞLATILDIĞINDA VE GÜNCELLEME YÜKLENİRKEN,
PC KAPATILMAMALI VEYA GÜNCELLEME DOSYASI DURDURULMAMALIDIR, ÇÜNKÜ BU YÜKLENEN YAZILIM SÜRÜMÜNE ZARAR VEREBİLİR!!!
KULLANICI TARAFINDAN YANLIŞ YAPILAN BİR YAZILIM GÜNCELLEMESİ NEDENİYLE OLUŞAN HASARLAR İÇİN HİÇBİR SORUMLULUK KABUL EDİLMEZ!!!"
            newestSWVersionInstalledScreenMessage = "Yazılımınız güncel
"
            installedSWVersionScreenMessage = "Yazılım sürümü: "
            HttpRequestExceptionErrorMessageHeader = "Güncellemeler aranırken ağ hatası"
            HttpRequestExceptionErrorMessageDescription = "Güncelleme sunucusuna internet bağlantısı kurulamadı.
İnternet bağlantınızı kontrol edin ve tekrar deneyin.
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            TaskCanceledExceptionErrorMessageHeader = "Bağlantı zaman aşımı"
            TaskCanceledExceptionErrorMessageDescription = "Sunucu zamanında yanıt vermedi
veya internet bağlantınız çok yavaş.
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            JsonSerializationExceptionErrorMessageHeader = "Yazılım güncelleme verilerinin formatında hata"
            JsonSerializationExceptionErrorMessageDescription = "Güncelleme sunucusundan gönderilen yazılım güncelleme verileri yanlış formatta.
Daha sonra tekrar deneyin.
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            JsonReaderExceptionErrorMessageHeader = "Yazılım güncelleme verileri okunurken hata"
            JsonReaderExceptionErrorMessageDescription = "Güncelleme sunucusundan gönderilen yazılım güncelleme verileri okunabilir değil.
Daha sonra tekrar deneyin.
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            ArgumentExceptionErrorMessageHeader = "Yazılım güncelleme numarası geçersiz"
            ArgumentExceptionErrorMessageDescription = "Destek veya sistem yöneticisi ile iletişime geçin.
Daha sonra tekrar deneyin!!!"
            FormatExceptionErrorMessageHeader = "Yazılım güncelleme numarasının formatı geçersiz"
            FormatExceptionErrorMessageDescription = "Destek veya sistem yöneticisi ile iletişime geçin.
Daha sonra tekrar deneyin!!!"
            InvalidOperationExceptionErrorMessageHeader = "İşlem hatası"
            InvalidOperationExceptionErrorMessageDescription = "İşlem mümkün değil"
            NullReferenceExceptionErrorMessageHeader = "Yazılım güncelleme programı bozuk"
            NullReferenceExceptionErrorMessageDescription = "Bu işlev için gerekli bir nesne eksik.
WebConnect Kurtarma Yazılımı ile hatayı düzeltin
('WebConnect-->Ayarlar-->Kurtarma)
Eğer bu hatayı düzeltmezse:
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            ArgumentNullExceptionErrorMessageHeader = "Yazılım güncelleme programı bozuk"
            ArgumentNullExceptionErrorMessageDescription = "Bu işlev için gerekli olan aslında mevcut bir argüman eksik.
WebConnect Kurtarma Yazılımı ile hatayı düzeltin
('WebConnect-->Ayarlar-->Kurtarma)
Eğer bu hatayı düzeltmezse:
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            AggregateExceptionErrorMessageHeader = "En az 1 hata oluştu"
            AggregateExceptionErrorMessageDescription = "En az 1 hata oluştu.
WebConnect Kurtarma Yazılımı ile hatayı düzeltin
('WebConnect-->Ayarlar-->Kurtarma)
Eğer bu hatayı düzeltmezse:
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            UnauthorizedAccessExceptionErrorMessageHeader = "Yazılım güncellemesine erişim yok"
            UnauthorizedAccessExceptionErrorMessageDescription = "Yazılım güncellemelerini aramak için yeterli yetkiniz yok.
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            WebExceptionErrorMessageHeader = "Ağ hatası"
            WebExceptionErrorMessageDescription = "Bir ağ veya sunucu sorunu var.
İnternet bağlantınızı kontrol edin ve tekrar deneyin.
Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"
            ExceptionErrorMessageHeader = "Bilinmeyen hata"
            ExceptionErrorMessageDescription = "Destek veya sistem yöneticisi ile iletişime geçin, eğer sorun devam ederse!!!"

        End If


        DownloadButton.Hide()
        RichTextBox1.Hide()
        Label1.Text = searchForSWUpdateScreenMessage
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
                    Label1.Text = readyToDownloadSWUpdateScreenMessage
                    RichTextBox1.Text = importantNoteScreenMessage & latestSWVersion & " 
BREAKING NEWS!!! " & releaseBody

                    'Return $"Ein Software-Update ist verfügbar!{Environment.NewLine}" &
                    '$"Version: {latestSWVersion}{Environment.NewLine}" &
                    '$"Titel: {releaseTitle}{Environment.NewLine}" &
                    '       $"Beschreibung: {releaseBody}{Environment.NewLine}" &
                    '      $"Downloadlink: {downloadURL}"
                Else
                    Label1.Text = newestSWVersionInstalledScreenMessage
                    Label4.Text = installedSWVersionScreenMessage & "
" & currentSWVersion
                End If
            End Using
        Catch ex As HttpRequestException
            Label1.Text = HttpRequestExceptionErrorMessageHeader
            Label4.Text = HttpRequestExceptionErrorMessageDescription
        Catch ex As TaskCanceledException
            Label1.Text = TaskCanceledExceptionErrorMessageHeader
            Label4.Text = TaskCanceledExceptionErrorMessageDescription
        Catch ex As JsonSerializationException
            Label1.Text = JsonSerializationExceptionErrorMessageHeader
            Label4.Text = JsonSerializationExceptionErrorMessageDescription
        Catch Ex As JsonReaderException
            Label1.Text = JsonReaderExceptionErrorMessageHeader
            Label4.Text = JsonReaderExceptionErrorMessageDescription
        Catch ex As ArgumentException
            Label1.Text = ArgumentExceptionErrorMessageHeader
            Label4.Text = ArgumentExceptionErrorMessageDescription
        Catch ex As FormatException
            Label1.Text = FormatExceptionErrorMessageHeader
            Label4.Text = FormatExceptionErrorMessageDescription
        Catch ex As InvalidOperationException
            Label1.Text = InvalidOperationExceptionErrorMessageHeader
            Label4.Text = InvalidOperationExceptionErrorMessageDescription
        Catch ex As NullReferenceException
            Label1.Text = NullReferenceExceptionErrorMessageHeader
            Label4.Text = NullReferenceExceptionErrorMessageDescription
        Catch ex As ArgumentNullException
            Label1.Text = ArgumentNullExceptionErrorMessageHeader
            Label4.Text = ArgumentNullExceptionErrorMessageDescription
        Catch ex As AggregateException
            Label1.Text = AggregateExceptionErrorMessageHeader
            Label4.Text = AggregateExceptionErrorMessageDescription
        Catch ex As UnauthorizedAccessException
            Label1.Text = UnauthorizedAccessExceptionErrorMessageHeader
            Label4.Text = UnauthorizedAccessExceptionErrorMessageDescription
        Catch ex As WebException
            Label1.Text = WebExceptionErrorMessageHeader
            Label4.Text = WebExceptionErrorMessageDescription
        Catch ex As Exception
            Label1.Text = ExceptionErrorMessageHeader
            Label4.Text = ExceptionErrorMessageDescription
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