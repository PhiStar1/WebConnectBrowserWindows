Imports System.Net

Public Class EnterIPAdress
    Private Sub EnterIPAdress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Debug.WriteLine("Gedrückt")
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()

        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            Debug.WriteLine("enter Gedrückt")

            ConnectToIPAdress()

        End If
    End Sub
    Private Sub Connect_Click(sender As Object, e As EventArgs) Handles Connect.Click

        ConnectToIPAdress()


    End Sub
    Public Function ConnectToIPAdress()


        If ConnectWithHttps.Checked Then
            If Not IPAdress.Text = "" Then

                Form1.AddNewTab("https://" & IPAdress.Text)
                Form1.TextBox1.Text = "https://" & IPAdress.Text
                Me.Close()
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
                ConnectToRouter.Close()
                Launcher.Close()
            Else
                IPAdress.Text = "Gib eine IP-Adresse ein!"
                IPAdress.SelectAll()
            End If
        End If

    End Function

    Private Sub EnterIPAdress_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class