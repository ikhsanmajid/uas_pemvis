Public Class form_data_user
    Sub kosong()
        If inputNama.Text.Trim = "" Then
            MessageBox.Show("Silahkan Input Nama Dulu", "PERINGATAN")
        ElseIf inputJenKel.Text.Trim = "" Then
            MessageBox.Show("Silahkan Input Jenis Kelamin Dulu", "PERINGATAN")
        ElseIf inputAlamat.Text.Trim = "" Then
            MessageBox.Show("Silahkan Input Alamat Dulu", "PERINGATAN")
        ElseIf inputUsername.Text.Trim = "" Then
            MessageBox.Show("Silahkan Input Username Dulu", "PERINGATAN")
        ElseIf inputPassword.Text.Trim = "" Then
            MessageBox.Show("Silahkan Input Password Dulu", "PERINGATAN")
        ElseIf inputKonfirmasi.Text.Trim = "" Then
            MessageBox.Show("Silahkan Input Konfirmasi Password Dulu", "PERINGATAN")
        End If
    End Sub
    Private Sub form_data_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        kosong()
    End Sub
End Class