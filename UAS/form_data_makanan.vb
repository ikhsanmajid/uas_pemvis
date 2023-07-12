
Imports System.Data.Odbc
Public Class form_data_makanan
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
        Try
            koneksi()
            Dim sql As String = "insert into makanan_minuman (nama, jenis, harga, stok, status) values (?,?,?,?,?)"
            cmd = New OdbcCommand(sql, con)
            cmd.Parameters.AddWithValue("@param1", nama1.Text)
            cmd.Parameters.AddWithValue("@param2", jenis1.Text)
            cmd.Parameters.AddWithValue("@param3", harga1.Text)
            cmd.Parameters.AddWithValue("@param4", stok1.Text)
            cmd.Parameters.AddWithValue("@param5", status1.Text)
            Dim rowAffected As Integer = cmd.ExecuteNonQuery()
            If rowAffected > 0 Then
                MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
            End If
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Sub tampil()
        Try
            koneksi()
            DataSet1.makanan_minuman.Clear()
            DataSet1.EnforceConstraints = False
            da = New OdbcDataAdapter("select * from makanan_minuman order by id asc", con)
            da.Fill(DataSet1.makanan_minuman)
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As String = dgv1.Item(0, dgv1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data User yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan daftar=" & a &
            "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) =
            Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from makanan_minuman where id='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampil()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        nama1.Text = ""
        jenis1.Text = ""
        status1.Text = ""
        harga1.Text = ""
        stok1.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            Dim query As String = "SELECT * FROM makanan_minuman ORDER BY id ASC"
            form_report_data_makanan.DataSet1.Clear()
            form_report_data_makanan.DataSet1.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(form_report_data_makanan.DataSet1.makanan_minuman)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        form_report_data_makanan.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        form_report_data_makanan.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        form_report_data_makanan.ReportViewer1.ZoomPercent = 100
        form_report_data_makanan.ReportViewer1.RefreshReport()
        form_report_data_makanan.Show()
    End Sub

End Class