Imports System.Data.Odbc
Public Class form_edit_user
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Dim id_user As String
    Dim user As String

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=warnet"
        con.Open()
    End Sub

    Sub loadUser(id_user_edit As String, nama_edit As String, jenkel_edit As String, alamat_edit As String, username_edit As String, password_edit As String)
        id_user = id_user_edit
        user = username_edit
        inputNama.Text = nama_edit
        inputJenKel.Text = jenkel_edit
        inputAlamat.Text = alamat_edit
        inputUsername.Text = username_edit
        inputPassword.Text = password_edit
        inputKonfirmasi.Text = password_edit
    End Sub

    Sub edit()
        Dim nama, jenkel, alamat, username, password, query As String
        nama = inputNama.Text
        jenkel = inputJenKel.Text
        alamat = inputAlamat.Text
        username = inputUsername.Text
        password = inputPassword.Text

        query = "UPDATE data_user SET nama=?, jenis_kelamin=?, alamat=?, username=?, password=? where id_user=?"

        Try
            koneksi()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("@param1", nama)
                cmd.Parameters.AddWithValue("@param2", jenkel)
                cmd.Parameters.AddWithValue("@param3", alamat)
                cmd.Parameters.AddWithValue("@param4", username)
                cmd.Parameters.AddWithValue("@param5", password)
                cmd.Parameters.AddWithValue("@param6", id_user)

                Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                If rowAffected > 0 Then
                    MessageBox.Show("Data berhasil diupdate")
                    Me.Close()
                    form_data_user.openAfterEdit()
                Else
                    MessageBox.Show("Tidak Ada Data Yang Diupdate")
                    Me.Close()
                    form_data_user.openAfterEdit()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: ", ex.Message)
        End Try
    End Sub

    Sub cekUser()
        koneksi()
        Dim sql As String = "select username from data_user where username = '" & inputUsername.Text & "'"
        cmd = New OdbcCommand(sql, con)
        dr = cmd.ExecuteReader
        If dr.HasRows Then
            MsgBox("Maaf Username Sudah Terdaftar Silahkan Gunakan Username Lain")
            inputUsername.Text = ""
            inputUsername.Focus()
        Else
            cekPassword()
        End If
    End Sub

    Sub cekPassword()
        If inputPassword.Text = inputKonfirmasi.Text Then
            edit()
        Else
            MessageBox.Show("Maaf Konfirmasi Password Tidak Sama", "PERINGATAN")
            inputPassword.Text = ""
            inputKonfirmasi.Text = ""
            inputPassword.Focus()
        End If
    End Sub

    Private Sub form_edit_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputPassword.UseSystemPasswordChar = True
        inputKonfirmasi.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            inputPassword.UseSystemPasswordChar = False
            inputKonfirmasi.UseSystemPasswordChar = False
        Else
            inputPassword.UseSystemPasswordChar = True
            inputKonfirmasi.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
        Else
            If inputUsername.Text = user Then
                cekPassword()
            Else
                cekUser()
            End If
        End If
    End Sub
End Class