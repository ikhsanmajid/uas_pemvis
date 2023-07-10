<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_transaksi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ucapan = New System.Windows.Forms.Label()
        Me.hasilKembalian = New System.Windows.Forms.Label()
        Me.hasilBayar = New System.Windows.Forms.Label()
        Me.pembatas = New System.Windows.Forms.Label()
        Me.hasilTotalBayar = New System.Windows.Forms.Label()
        Me.hasilDiskon = New System.Windows.Forms.Label()
        Me.hasilTotalHarga = New System.Windows.Forms.Label()
        Me.hasilJam = New System.Windows.Forms.Label()
        Me.hasilPaket = New System.Windows.Forms.Label()
        Me.hasilUser = New System.Windows.Forms.Label()
        Me.cashbackOutput = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.userInput = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnUlangi = New System.Windows.Forms.Button()
        Me.btnProses = New System.Windows.Forms.Button()
        Me.kembalianOutput = New System.Windows.Forms.TextBox()
        Me.bayarInput = New System.Windows.Forms.TextBox()
        Me.totalBayarOutput = New System.Windows.Forms.TextBox()
        Me.diskonOutput = New System.Windows.Forms.TextBox()
        Me.totalHargaOutput = New System.Windows.Forms.TextBox()
        Me.jumlahInput = New System.Windows.Forms.TextBox()
        Me.hargaInput = New System.Windows.Forms.TextBox()
        Me.jenisPaket = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.UAS.My.Resources.Resources.logo_valorant
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(543, 46)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(346, 138)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ucapan)
        Me.GroupBox1.Controls.Add(Me.hasilKembalian)
        Me.GroupBox1.Controls.Add(Me.hasilBayar)
        Me.GroupBox1.Controls.Add(Me.pembatas)
        Me.GroupBox1.Controls.Add(Me.hasilTotalBayar)
        Me.GroupBox1.Controls.Add(Me.hasilDiskon)
        Me.GroupBox1.Controls.Add(Me.hasilTotalHarga)
        Me.GroupBox1.Controls.Add(Me.hasilJam)
        Me.GroupBox1.Controls.Add(Me.hasilPaket)
        Me.GroupBox1.Controls.Add(Me.hasilUser)
        Me.GroupBox1.Location = New System.Drawing.Point(543, 213)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 435)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hasil"
        '
        'ucapan
        '
        Me.ucapan.AutoSize = True
        Me.ucapan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ucapan.Location = New System.Drawing.Point(111, 388)
        Me.ucapan.Name = "ucapan"
        Me.ucapan.Size = New System.Drawing.Size(131, 20)
        Me.ucapan.TabIndex = 9
        Me.ucapan.Text = "Selamat Bermain"
        '
        'hasilKembalian
        '
        Me.hasilKembalian.AutoSize = True
        Me.hasilKembalian.Location = New System.Drawing.Point(33, 346)
        Me.hasilKembalian.Name = "hasilKembalian"
        Me.hasilKembalian.Size = New System.Drawing.Size(111, 20)
        Me.hasilKembalian.TabIndex = 8
        Me.hasilKembalian.Text = "Kembalian      :"
        '
        'hasilBayar
        '
        Me.hasilBayar.AutoSize = True
        Me.hasilBayar.Location = New System.Drawing.Point(34, 311)
        Me.hasilBayar.Name = "hasilBayar"
        Me.hasilBayar.Size = New System.Drawing.Size(106, 20)
        Me.hasilBayar.TabIndex = 7
        Me.hasilBayar.Text = "Bayar             :"
        '
        'pembatas
        '
        Me.pembatas.AutoSize = True
        Me.pembatas.Location = New System.Drawing.Point(34, 275)
        Me.pembatas.Name = "pembatas"
        Me.pembatas.Size = New System.Drawing.Size(279, 20)
        Me.pembatas.TabIndex = 6
        Me.pembatas.Text = "=============================="
        '
        'hasilTotalBayar
        '
        Me.hasilTotalBayar.AutoSize = True
        Me.hasilTotalBayar.Location = New System.Drawing.Point(34, 231)
        Me.hasilTotalBayar.Name = "hasilTotalBayar"
        Me.hasilTotalBayar.Size = New System.Drawing.Size(109, 20)
        Me.hasilTotalBayar.TabIndex = 5
        Me.hasilTotalBayar.Text = "Total Bayar    :"
        '
        'hasilDiskon
        '
        Me.hasilDiskon.AutoSize = True
        Me.hasilDiskon.Location = New System.Drawing.Point(34, 192)
        Me.hasilDiskon.Name = "hasilDiskon"
        Me.hasilDiskon.Size = New System.Drawing.Size(106, 20)
        Me.hasilDiskon.TabIndex = 4
        Me.hasilDiskon.Text = "Diskon           :"
        '
        'hasilTotalHarga
        '
        Me.hasilTotalHarga.AutoSize = True
        Me.hasilTotalHarga.Location = New System.Drawing.Point(32, 154)
        Me.hasilTotalHarga.Name = "hasilTotalHarga"
        Me.hasilTotalHarga.Size = New System.Drawing.Size(112, 20)
        Me.hasilTotalHarga.TabIndex = 3
        Me.hasilTotalHarga.Text = "Total Harga    :"
        '
        'hasilJam
        '
        Me.hasilJam.AutoSize = True
        Me.hasilJam.Location = New System.Drawing.Point(32, 118)
        Me.hasilJam.Name = "hasilJam"
        Me.hasilJam.Size = New System.Drawing.Size(118, 20)
        Me.hasilJam.TabIndex = 2
        Me.hasilJam.Text = "Jumlah Jam     :"
        '
        'hasilPaket
        '
        Me.hasilPaket.AutoSize = True
        Me.hasilPaket.Location = New System.Drawing.Point(34, 82)
        Me.hasilPaket.Name = "hasilPaket"
        Me.hasilPaket.Size = New System.Drawing.Size(106, 20)
        Me.hasilPaket.TabIndex = 1
        Me.hasilPaket.Text = "Paket             :"
        '
        'hasilUser
        '
        Me.hasilUser.AutoSize = True
        Me.hasilUser.Location = New System.Drawing.Point(32, 45)
        Me.hasilUser.Name = "hasilUser"
        Me.hasilUser.Size = New System.Drawing.Size(107, 20)
        Me.hasilUser.TabIndex = 0
        Me.hasilUser.Text = "User               :"
        '
        'cashbackOutput
        '
        Me.cashbackOutput.AutoSize = True
        Me.cashbackOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cashbackOutput.Location = New System.Drawing.Point(152, 461)
        Me.cashbackOutput.Name = "cashbackOutput"
        Me.cashbackOutput.Size = New System.Drawing.Size(246, 20)
        Me.cashbackOutput.TabIndex = 50
        Me.cashbackOutput.Text = "Berhasil Mendapat Cash Back 5K"
        Me.cashbackOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(108, 81)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(344, 20)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Cashback 5Rb Setiap Pembelian Diatas 100Rb"
        '
        'userInput
        '
        Me.userInput.Location = New System.Drawing.Point(224, 219)
        Me.userInput.Name = "userInput"
        Me.userInput.Size = New System.Drawing.Size(248, 26)
        Me.userInput.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(75, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Username"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(350, 612)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'btnUlangi
        '
        Me.btnUlangi.Location = New System.Drawing.Point(236, 612)
        Me.btnUlangi.Name = "btnUlangi"
        Me.btnUlangi.Size = New System.Drawing.Size(75, 38)
        Me.btnUlangi.TabIndex = 45
        Me.btnUlangi.Text = "Ulangi"
        Me.btnUlangi.UseVisualStyleBackColor = True
        '
        'btnProses
        '
        Me.btnProses.Location = New System.Drawing.Point(124, 612)
        Me.btnProses.Name = "btnProses"
        Me.btnProses.Size = New System.Drawing.Size(75, 38)
        Me.btnProses.TabIndex = 44
        Me.btnProses.Text = "Proses"
        Me.btnProses.UseVisualStyleBackColor = True
        '
        'kembalianOutput
        '
        Me.kembalianOutput.Location = New System.Drawing.Point(224, 553)
        Me.kembalianOutput.Name = "kembalianOutput"
        Me.kembalianOutput.Size = New System.Drawing.Size(248, 26)
        Me.kembalianOutput.TabIndex = 43
        '
        'bayarInput
        '
        Me.bayarInput.Location = New System.Drawing.Point(224, 499)
        Me.bayarInput.Name = "bayarInput"
        Me.bayarInput.Size = New System.Drawing.Size(248, 26)
        Me.bayarInput.TabIndex = 42
        '
        'totalBayarOutput
        '
        Me.totalBayarOutput.Location = New System.Drawing.Point(224, 415)
        Me.totalBayarOutput.Name = "totalBayarOutput"
        Me.totalBayarOutput.Size = New System.Drawing.Size(248, 26)
        Me.totalBayarOutput.TabIndex = 41
        '
        'diskonOutput
        '
        Me.diskonOutput.Location = New System.Drawing.Point(224, 366)
        Me.diskonOutput.Name = "diskonOutput"
        Me.diskonOutput.Size = New System.Drawing.Size(248, 26)
        Me.diskonOutput.TabIndex = 40
        '
        'totalHargaOutput
        '
        Me.totalHargaOutput.Location = New System.Drawing.Point(224, 316)
        Me.totalHargaOutput.Name = "totalHargaOutput"
        Me.totalHargaOutput.Size = New System.Drawing.Size(248, 26)
        Me.totalHargaOutput.TabIndex = 39
        '
        'jumlahInput
        '
        Me.jumlahInput.Location = New System.Drawing.Point(224, 267)
        Me.jumlahInput.Name = "jumlahInput"
        Me.jumlahInput.Size = New System.Drawing.Size(248, 26)
        Me.jumlahInput.TabIndex = 38
        '
        'hargaInput
        '
        Me.hargaInput.Location = New System.Drawing.Point(224, 172)
        Me.hargaInput.Name = "hargaInput"
        Me.hargaInput.Size = New System.Drawing.Size(248, 26)
        Me.hargaInput.TabIndex = 37
        '
        'jenisPaket
        '
        Me.jenisPaket.FormattingEnabled = True
        Me.jenisPaket.Items.AddRange(New Object() {"Reguler", "VIP", "Battle Arena"})
        Me.jenisPaket.Location = New System.Drawing.Point(224, 126)
        Me.jenisPaket.Name = "jenisPaket"
        Me.jenisPaket.Size = New System.Drawing.Size(248, 28)
        Me.jenisPaket.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 556)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 20)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Kembalian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 503)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 418)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Total Bayar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 369)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 20)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Diskon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 270)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 20)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Jumlah"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 319)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Total Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Harga / jam"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Jenis Paket"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(277, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "WARNET GGWP GAME CENTER"
        '
        'form_transaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 728)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cashbackOutput)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.userInput)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUlangi)
        Me.Controls.Add(Me.btnProses)
        Me.Controls.Add(Me.kembalianOutput)
        Me.Controls.Add(Me.bayarInput)
        Me.Controls.Add(Me.totalBayarOutput)
        Me.Controls.Add(Me.diskonOutput)
        Me.Controls.Add(Me.totalHargaOutput)
        Me.Controls.Add(Me.jumlahInput)
        Me.Controls.Add(Me.hargaInput)
        Me.Controls.Add(Me.jenisPaket)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_transaksi"
        Me.Text = "form_transaksi"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ucapan As System.Windows.Forms.Label
    Friend WithEvents hasilKembalian As System.Windows.Forms.Label
    Friend WithEvents hasilBayar As System.Windows.Forms.Label
    Friend WithEvents pembatas As System.Windows.Forms.Label
    Friend WithEvents hasilTotalBayar As System.Windows.Forms.Label
    Friend WithEvents hasilDiskon As System.Windows.Forms.Label
    Friend WithEvents hasilTotalHarga As System.Windows.Forms.Label
    Friend WithEvents hasilJam As System.Windows.Forms.Label
    Friend WithEvents hasilPaket As System.Windows.Forms.Label
    Friend WithEvents hasilUser As System.Windows.Forms.Label
    Friend WithEvents cashbackOutput As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents userInput As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnUlangi As System.Windows.Forms.Button
    Friend WithEvents btnProses As System.Windows.Forms.Button
    Friend WithEvents kembalianOutput As System.Windows.Forms.TextBox
    Friend WithEvents bayarInput As System.Windows.Forms.TextBox
    Friend WithEvents totalBayarOutput As System.Windows.Forms.TextBox
    Friend WithEvents diskonOutput As System.Windows.Forms.TextBox
    Friend WithEvents totalHargaOutput As System.Windows.Forms.TextBox
    Friend WithEvents jumlahInput As System.Windows.Forms.TextBox
    Friend WithEvents hargaInput As System.Windows.Forms.TextBox
    Friend WithEvents jenisPaket As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
