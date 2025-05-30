Public Class SetupOrganization
    Private allowExit As Boolean = False
    Private Sub Reboot_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
        If e.KeyCode = Keys.Enter Then
            My.Settings.OrganizationName = OrganizationNameText.Text
            My.Settings.OrganizationMode = True
            allowExit = True
            Me.Close()
        End If
    End Sub

    Private Sub SetupOrganization_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not allowExit AndAlso e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True
        End If
    End Sub
    Private Sub SetupOrganization_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Form1.Language = "de" Then
            Me.Text = "Organisation einrichten"
            Description.Text = "Gib den Namen deiner Organisation ein."
            OrganizationNameText.PlaceholderText = "Name der Organisation"
            Apply.Text = "Anwenden"
            Cancel.Text = "Abbrechen"
        End If
        If Form1.Language = "en" Then
            Me.Text = "Setup Organization"
            Description.Text = "Enter the name of your organization."
            OrganizationNameText.PlaceholderText = "Organization Name"
            Apply.Text = "Apply"
            Cancel.Text = "Cancel"
        End If
        If Form1.Language = "fr" Then
            Me.Text = "Configurer l'organisation"
            Description.Text = "Entrez le nom de votre organisation."
            OrganizationNameText.PlaceholderText = "Nom de l'organisation"
            Apply.Text = "Appliquer"
            Cancel.Text = "Annuler"
        End If
        If Form1.Language = "es" Then
            Me.Text = "Configurar organización"
            Description.Text = "Ingrese el nombre de su organización."
            OrganizationNameText.PlaceholderText = "Nombre de la organización"
            Apply.Text = "Aplicar"
            Cancel.Text = "Cancelar"
        End If
        If Form1.Language = "it" Then
            Me.Text = "Impostare l'organizzazione"
            Description.Text = "Inserisci il nome della tua organizzazione."
            OrganizationNameText.PlaceholderText = "Nome dell'organizzazione"
            Apply.Text = "Applica"
            Cancel.Text = "Annulla"
        End If
        If Form1.Language = "tr" Then
            Me.Text = "Kuruluşu Ayarla"
            Description.Text = "Kuruluşunuzun adını girin."
            OrganizationNameText.PlaceholderText = "Kuruluş Adı"
            Apply.Text = "Tamam"
            Cancel.Text = "İptal Et"
        End If
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        allowExit = True
        Me.Close()
        SetupPassword.Close()
        WebConnectAdminSoftware.Close()
    End Sub

    Private Sub ApplyButton_Click(sender As Object, e As EventArgs) Handles Apply.Click
        My.Settings.OrganizationName = OrganizationNameText.Text
        My.Settings.OrganizationMode = True
        allowExit = True
        Me.Close()
    End Sub

    Private Sub OrganizationNameText_TextChanged(sender As Object, e As EventArgs) Handles OrganizationNameText.TextChanged

    End Sub
End Class