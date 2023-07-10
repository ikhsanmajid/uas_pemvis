Public Class form_transaksi
    Dim harga As Integer
    Dim totalBayar As Integer
    Dim cashback As Integer
    Dim counterSlideShow As Integer

    Private Sub form_transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hargaInput.ReadOnly = True
        userInput.ReadOnly = True
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

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles jenisPaket.SelectedIndexChanged
        userInput.ReadOnly = False
        jumlahInput.Text = ""
        If jenisPaket.Text.Trim = "" Then
            userInput.Text = ""
            hargaInput.Text = ""
            userInput.ReadOnly = True
        End If
        Select Case jenisPaket.Text.Trim.ToUpper
            Case "REGULER"
                harga = 6000
                hargaInput.Text = harga
            Case "VIP"
                harga = 10000
                hargaInput.Text = harga
            Case "BATTLE ARENA"
                harga = 13000
                hargaInput.Text = harga
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
            totalHarga = jumlah * harga
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
        userInput.ReadOnly = True
        btnProses.Enabled = False
        cashbackOutput.Text = ""
        resetHasil()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        index.Show()
    End Sub

    Private Sub userInput_TextChanged(sender As Object, e As EventArgs) Handles userInput.TextChanged
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
End Class
