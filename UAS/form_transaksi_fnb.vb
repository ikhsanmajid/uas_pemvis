Imports System.Data.Odbc
Public Class form_transaksi_fnb
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
        Dim sql As String = "insert into transaksi_makanan_minuman values('" &
       id_trans.Text & "','" & id_makan.Text & "','" & jum.Text & "','" & harga.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        dgv1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from transaksi_makanan_minuman order by id_transaksi asc",
            con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                dgv1.Rows.Add(row(0), row(1), row(2), row(3))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv1.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        index.Show()
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
                cmd = New OdbcCommand("delete from transaksi_makanan_minuman where id_transaksi='" & a &
                "'", con)
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
        id_trans.Text = ""
        id_makan.Text = ""
        jum.Text = ""
        harga.Text = ""
        id_trans.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim query As String = "SELECT * FROM transaksi_makanan_minuman ORDER BY id_transaksi ASC"
        Try
            form_report_transaksi.DataSet1.Clear()
            form_report_transaksi.DataSet1.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(form_report_transaksi.DataSet1.transaksi_makanan_minuman)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        form_report_transaksi.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
        form_report_transaksi.ReportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent
        form_report_transaksi.ReportViewer1.ZoomPercent = 25
        form_report_transaksi.ReportViewer1.RefreshReport()
        form_report_transaksi.Show()

    End Sub
End Class