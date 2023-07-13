Public Class formLogin

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If inputUsername.Text = "admin" And inputPassword.Text = "1234" Then
            index.Show()
        Else
            MsgBox("Maaf username / password yang anda masukkan salah")
        End If
    End Sub

    Private Sub formLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputPassword.UseSystemPasswordChar = True
    End Sub
End Class
