Imports System.Net

Public Class EnterIPAdress
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click


        If ConnectWithHttps.Checked Then
            If Not IPAdress.Text = "" Then

                Form1.AddNewTab("https://" & IPAdress.Text)
                Form1.TextBox1.Text = "https://" & IPAdress.Text
                Me.Close()
                ASUSWiredOrWireless.Close()
                ConnectToRouter.Close()
                Launcher.Close()
            Else
                IPAdress.Text = "Gib eine IP-Adresse ein!"
                IPAdress.SelectAll()
            End If
        Else
            If Not IPAdress.Text = "" Then
                Form1.AddNewTab("http://" & IPAdress.Text)
                Form1.TextBox1.Text = "http://" & IPAdress.Text
                Me.Close()
                ASUSWiredOrWireless.Close()
                ConnectToRouter.Close()
                Launcher.Close()
            Else
                IPAdress.Text = "Gib eine IP-Adresse ein!"
                IPAdress.SelectAll()
            End If
        End If



    End Sub

    Private Sub EnterIPAdress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class