Imports System.Data.Odbc
Public Class form_data_user
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=warnet"
        con.Open()
    End Sub

    Sub simpan()
        koneksi()
        Dim sql As String = "insert into data_user (nama,jenis_kelamin,alamat,username,password) values ('" & inputNama.Text & "','" & inputJenKel.Text & "','" & inputAlamat.Text & "','" & inputUsername.Text & "','" & inputPassword.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
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
            If inputPassword.Text = inputKonfirmasi.Text Then
                simpan()
            Else
                MessageBox.Show("Maaf Konfirmasi Password Tidak Sama", "PERINGATAN")
                inputPassword.Text = ""
                inputKonfirmasi.Text = ""
                inputPassword.Focus()
            End If
        End If
    End Sub

    Sub tampil()
        dgvUser.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from data_user order by nama asc ", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgvUser.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub

    Private Sub form_data_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
        inputPassword.UseSystemPasswordChar = True
        inputKonfirmasi.UseSystemPasswordChar = True
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
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
            cekUser()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        tampil()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        index.Show()
    End Sub

    Private Sub btnUlangi_Click(sender As Object, e As EventArgs) Handles btnUlangi.Click
        inputNama.Text = ""
        inputJenKel.Text = ""
        inputAlamat.Text = ""
        inputUsername.Text = ""
        inputPassword.Text = ""
        inputKonfirmasi.Text = ""
        inputNama.Focus()
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = dgvUser.Item(0, dgvUser.CurrentRow.Index).Value
        Dim b As String = dgvUser.Item(4, dgvUser.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Pasien yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan username=" & b &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from data_user where id_user='" & a &
                "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim id_user_edit, nama_edit, jenkel_edit, alamat_edit, username_edit, password_edit
        Dim selectedRowIndexs As Integer
        selectedRowIndexs = dgvUser.CurrentRow.Index
        id_user_edit = dgvUser.Rows(selectedRowIndexs).Cells(0).Value
        nama_edit = dgvUser.Rows(selectedRowIndexs).Cells(1).Value
        jenkel_edit = dgvUser.Rows(selectedRowIndexs).Cells(2).Value
        alamat_edit = dgvUser.Rows(selectedRowIndexs).Cells(3).Value
        username_edit = dgvUser.Rows(selectedRowIndexs).Cells(4).Value
        password_edit = dgvUser.Rows(selectedRowIndexs).Cells(5).Value

        form_edit_user.loadUser(id_user_edit, nama_edit, jenkel_edit, alamat_edit, username_edit, password_edit)
        Me.Hide()
        form_edit_user.Show()
    End Sub
    Sub openAfterEdit()
        tampil()
        Me.Show()
    End Sub
End Class