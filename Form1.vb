
Public Class Form1
    Private con As New Connection
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        con.Filename = "config.json"
        con.Connect()
        txtHost.Text = con.DBHost
        txtUser.Text = con.DBUser
        txtPassword.Text = con.DBPassword
        txtDBName.Text = con.DBName
        txtPort.Text = con.DBPort
    End Sub
End Class
