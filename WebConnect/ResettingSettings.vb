Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ResettingSettings
    Private Sub ResettingSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Name = "Erasing User Settings..."
            With My.Settings
                ProgressBar1.Value = 38
                .Automatischhttpoderhttpsdavorsetzen = True
                ProgressBar1.Value = 50
                .JavaScript = "True"
                ProgressBar1.Value = 63
                .Sprache = ""
                ProgressBar1.Value = 75

                ' Typen setzen
                '.Properties.Item("AutomatischHttpOderHttpsDavorSetzen").PropertyValue.Scope = SettingsScope.User
                '           .Properties.Item("JavaScript").Propertý.Scope PropertyValue.Scope = SettingsScope.User
                '            .Properties.Item("Sprache").Property.Scope PropertyValue.Scope = SettingsScope.User


            End With
            ProgressBar1.Value = 88
            My.Settings.Save()
            ProgressBar1.Value = 100
            Reboot.ShowDialog()
        Catch ex As Exception
            settingsreseterror.ShowDialog()
        End Try




    End Sub
End Class