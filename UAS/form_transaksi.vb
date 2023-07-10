Imports System.Data.Odbc
Public Class form_transaksi
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Dim hargaPaket As Integer
    Dim totalBayar As Integer
    Dim cashback As Integer
    Dim counterSlideShow As Integer

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=warnet"
        con.Open()
    End Sub

    Sub tampil()
        dgvTransaksi.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select * from transaksi_warnet order by id_transaksi asc ", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgvTransaksi.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7))
            Next
            dt.Rows.Clear()
        Catch ex As Exception

        End Try
    End Sub

    Sub tampilUser()
        cmd = New OdbcCommand("select username from data_user", con)
        dr = cmd.ExecuteReader
        userInput.Items.Clear()
        Do While dr.Read
            userInput.Items.Add(dr.Item("username"))
        Loop
    End Sub

    Sub simpan()
        Dim username, jenis_paket As String
        Dim harga, jumlah, total_harga, diskon, total_bayar As Integer
        username = userInput.Text
        jenis_paket = jenisPaket.Text
        harga = hargaInput.Text
        jumlah = jumlahInput.Text
        total_harga = totalHargaOutput.Text
        diskon = diskonOutput.Text
        total_bayar = totalBayarOutput.Text
        koneksi()
        Dim sql As String = "INSERT INTO transaksi_warnet (username,jenis_paket,harga,jumlah,total_harga,diskon,total_bayar) VALUES (?,?,?,?,?,?,?)"

        Try
            koneksi()
            Using cmd As New OdbcCommand(sql, con)
                cmd.Parameters.AddWithValue("@param1", username)
                cmd.Parameters.AddWithValue("@param2", jenis_paket)
                cmd.Parameters.AddWithValue("@param3", harga)
                cmd.Parameters.AddWithValue("@param4", jumlah)
                cmd.Parameters.AddWithValue("@param5", total_harga)
                cmd.Parameters.AddWithValue("@param6", diskon)
                cmd.Parameters.AddWithValue("@param7", total_bayar)

                Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                If rowAffected > 0 Then
                    MessageBox.Show("Data Berhasil Ditambahkan")
                    tampil()
                Else
                    MessageBox.Show("Data Gagal Ditambahkan")
                End If
            End Using


        Catch ex As Exception
            MessageBox.Show("Data Gagal Ditambahkan" & ex.Message)
        End Try
    End Sub

    Private Sub form_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hargaInput.ReadOnly = True
        userInput.Enabled = False
        jumlahInput.ReadOnly = True
        totalHargaOutput.ReadOnly = True
        totalBayarOutput.ReadOnly = True
        diskonOutput.ReadOnly = True
        bayarInput.ReadOnly = True
        kembalianOutput.ReadOnly = True
        btnProses.Enabled = False
        cashbackOutput.Text = ""
        resetHasil()

        Timer1.Interval = 5000
        Timer1.Start()

        counterSlideShow = 0

        tampil()
        tampilUser()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenisPaket.SelectedIndexChanged
        userInput.Enabled = True
        tampilUser()
        jumlahInput.Text = ""
        If jenisPaket.Text.Trim = "" Then
            userInput.Text = ""
            hargaInput.Text = ""
            userInput.Enabled = False
        End If
        Select Case jenisPaket.Text.Trim.ToUpper
            Case "REGULER"
                hargaPaket = 6000
                hargaInput.Text = hargaPaket
            Case "VIP"
                hargaPaket = 10000
                hargaInput.Text = hargaPaket
            Case "BATTLE ARENA"
                hargaPaket = 13000
                hargaInput.Text = hargaPaket
        End Select
    End Sub

    Private Sub jumlahInput_TextChanged(sender As Object, e As EventArgs) Handles jumlahInput.TextChanged
        Dim jumlah As Integer
        Dim totalHarga As Integer
        Dim diskon As Integer
        bayarInput.Text = ""
        If jumlahInput.Text.Trim = "" Then
            totalHargaOutput.Text = ""
            diskonOutput.Text = ""
            totalBayarOutput.Text = ""
            bayarInput.Text = ""
            cashbackOutput.Text = ""
            bayarInput.ReadOnly = True
        End If
        If IsNumeric(jumlahInput.Text) Then
            jumlah = CInt(jumlahInput.Text)
            totalHarga = jumlah * hargaPaket
            totalHargaOutput.Text = totalHarga
            diskon = (5 / 100) * totalHarga
            diskonOutput.Text = diskon
            totalBayar = totalHarga - diskon
            totalBayarOutput.Text = totalBayar
            bayarInput.ReadOnly = False

            If totalHarga >= 100000 Then
                cashback = 5000
                cashbackOutput.Text = "Berhasil Mendapat Cash Back 5K"
                cashbackOutput.ForeColor = Color.Green
            Else
                cashback = 0
                cashbackOutput.Text = "Maaf belum mendapat cashback"
                cashbackOutput.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub jumlahInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlahInput.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub bayarInput_TextChanged(sender As Object, e As EventArgs) Handles bayarInput.TextChanged
        btnProses.Enabled = True
        kembalianOutput.Text = ""
        If bayarInput.Text.Trim = "" Then
            btnProses.Enabled = False
        End If
    End Sub

    Private Sub btnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        Dim bayar As Integer
        Dim kembalian As Integer
        If IsNumeric(bayarInput.Text) Then
            bayar = CInt(bayarInput.Text)
            If bayar >= totalBayar Then
                kembalian = bayar - totalBayar + cashback
                kembalianOutput.Text = kembalian
                hasilUser.Text = "User               :   " & userInput.Text
                hasilPaket.Text = "Paket             :   " & jenisPaket.Text
                hasilJam.Text = "Jumlah Jam     :   " & jumlahInput.Text & " Jam"
                hasilTotalHarga.Text = "Total Harga    :   Rp." & totalHargaOutput.Text
                hasilDiskon.Text = "Diskon           :   Rp." & diskonOutput.Text
                hasilTotalBayar.Text = "Total Bayar    :   Rp." & totalBayarOutput.Text
                pembatas.Text = "=============================="
                hasilBayar.Text = "Bayar             :   Rp." & bayarInput.Text
                hasilKembalian.Text = "Kembalian      :   Rp." & kembalian
                ucapan.Text = "Selamat Bermain"
                simpan()
            Else
                MessageBox.Show("Maaf Uang Anda Kurang Bro", "PERINGATAN")
                bayarInput.Text = ""
                kembalianOutput.Text = ""
                bayarInput.Focus()
            End If
        End If
    End Sub

    Private Sub btnUlangi_Click(sender As Object, e As EventArgs) Handles btnUlangi.Click
        jenisPaket.Text = ""
        hargaInput.Text = ""
        userInput.Text = ""
        jumlahInput.Text = ""
        bayarInput.Text = ""
        kembalianOutput.Text = ""
        jumlahInput.ReadOnly = True
        userInput.Enabled = False
        btnProses.Enabled = False
        cashbackOutput.Text = ""
        resetHasil()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        index.Show()
    End Sub

    Private Sub userInput_TextChanged(sender As Object, e As EventArgs)
        jumlahInput.ReadOnly = False
        If userInput.Text.Trim = "" Then
            jumlahInput.Text = ""
            jumlahInput.ReadOnly = True
        End If
    End Sub

    Sub resetHasil()
        hasilUser.Text = ""
        hasilPaket.Text = ""
        hasilJam.Text = ""
        hasilTotalHarga.Text = ""
        hasilTotalBayar.Text = ""
        hasilDiskon.Text = ""
        hasilBayar.Text = ""
        hasilKembalian.Text = ""
        pembatas.Text = ""
        ucapan.Text = ""
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        counterSlideShow += 1

        If (counterSlideShow = 5) Then
            counterSlideShow = 0
        End If

        Select Case counterSlideShow
            Case 0
                PictureBox2.BackgroundImage = My.Resources.logo_valorant

            Case 1
                PictureBox2.BackgroundImage = My.Resources.logo_ls

            Case 2
                PictureBox2.BackgroundImage = My.Resources.logo_pb

            Case 3
                PictureBox2.BackgroundImage = My.Resources.logo_pubg

            Case 4
                PictureBox2.BackgroundImage = My.Resources.lol_logo

        End Select
    End Sub

    Private Sub userInput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles userInput.SelectedIndexChanged
        jumlahInput.ReadOnly = False
        If userInput.Text.Trim = "" Then
            jumlahInput.Text = ""
            jumlahInput.ReadOnly = True
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        tampil()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim a As String = dgvTransaksi.Item(0, dgvTransaksi.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Nilai yang dihapus belum DIPILIH")
        ElseIf (MessageBox.Show("Anda yakin menghapus data transaksi=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
            koneksi()
            cmd = New OdbcCommand("delete from transaksi_warnet where id_transaksi='" & a & "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Menghapus data nilai BERHASIL", vbInformation,
            "INFORMASI")
            con.Close()
            tampil()
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click

    End Sub
End Class
