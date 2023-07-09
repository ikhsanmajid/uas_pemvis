Imports System.Data.Odbc
Imports System.Numerics

Public Class form_fnb
    Dim con As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader


    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=warnet"
        con.Open()
    End Sub

    Sub loadTable()
        Dim query As String = "SELECT * FROM makanan_minuman ORDER BY id ASC"
        Try
            DataSet2.Clear()
            DataSet2.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(DataSet2.makanan_minuman)
        Catch ex As Exception
        End Try
    End Sub

    Sub simpan()
        Dim status, stok As Integer
        Dim nama, jenis As String
        Dim harga As BigInteger

        Select Case ComboBox2.Text
            Case "masih"
                status = 1
            Case "habis"
                status = 0
        End Select

        stok = Integer.Parse(TextBox3.Text.ToString())

        nama = TextBox1.Text
        jenis = ComboBox1.Text
        harga = TextBox2.Text

        Dim query As String = "INSERT INTO makanan_minuman (nama, jenis, harga, stok, status) VALUES (?,?,?,?,?)"

        Try
            koneksi()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("@param1", nama)
                cmd.Parameters.AddWithValue("@param2", jenis)
                cmd.Parameters.AddWithValue("@param3", harga.ToString())
                cmd.Parameters.AddWithValue("@param4", stok)
                cmd.Parameters.AddWithValue("@param5", status)

                Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                If rowAffected > 0 Then
                    MessageBox.Show("Data Berhasil Ditambahkan")
                Else
                    MessageBox.Show("Data Gagal Ditambahkan")
                End If
            End Using


        Catch ex As Exception
            MessageBox.Show("Data Gagal Ditambahkan" & ex.Message)
        End Try

    End Sub

    'when form loaded
    Private Sub form_fnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set dropdown style
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.SelectedIndex = 0
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.SelectedIndex = 0
        'set width datagrid column
        DataGridView1.Columns(0).Width = 40 'id
        DataGridView1.Columns(1).Width = 480 'nama makanan
        DataGridView1.Columns(2).Width = 100 'jenis makanan
        DataGridView1.Columns(3).Width = 150 'harga makanan
        DataGridView1.Columns(4).Width = 120 'stok makanan
        DataGridView1.Columns(5).Width = 120 'status makanan

        ' load table
        loadTable()
    End Sub

    'edit value from sql in status column
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 5 AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "1" Then
            e.Value = "Masih"
        ElseIf e.ColumnIndex = 5 AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "0" Then
            e.Value = "Habis"
        End If
    End Sub


    'refresh click context menu
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        loadTable()
    End Sub

    'delete click context menu
    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        Dim selectedRowIndex As Integer
        selectedRowIndex = DataGridView1.CurrentRow.Index
        MessageBox.Show(DataGridView1.Rows(selectedRowIndex).Cells(1).Value)
    End Sub

    'edit click context menu
    Private Sub EditRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRowToolStripMenuItem.Click
        Dim selectedRowIndex, stok As Integer
        Dim id, nama, jenis, status, harga As String

        selectedRowIndex = DataGridView1.CurrentRow.Index

        id = DataGridView1.Rows(selectedRowIndex).Cells(0).Value
        nama = DataGridView1.Rows(selectedRowIndex).Cells(1).Value
        jenis = DataGridView1.Rows(selectedRowIndex).Cells(2).Value
        harga = DataGridView1.Rows(selectedRowIndex).Cells(3).Value
        stok = DataGridView1.Rows(selectedRowIndex).Cells(4).Value
        status = DataGridView1.Rows(selectedRowIndex).Cells(5).Value

        form_edit_fnb.loadform(id, nama, jenis, harga, stok, status)
        Me.Hide()
        form_edit_fnb.Show()
    End Sub

    'simpan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Sub openAfterEdit()
        loadTable()
        Me.Show()
    End Sub

End Class