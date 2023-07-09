Imports System.Data.Odbc
Imports System.Numerics

Public Class form_edit_fnb
    Dim con As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader

    Public query As String


    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=warnet"
        con.Open()
    End Sub

    Sub loadform(id As Integer, nama As String, jenis As String, harga As String, stok As Integer, status As String)
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        TextBox1.Text = id
        TextBox2.Text = nama
        ComboBox1.SelectedItem = jenis
        TextBox3.Text = harga.ToString()
        TextBox4.Text = stok

        Select Case status
            Case 1
                ComboBox2.SelectedIndex = 0
            Case 0
                ComboBox2.SelectedIndex = 1
        End Select

    End Sub

    Private Sub form_edit_fnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, stok, status As Integer
        Dim nama, jenis, harga As String
        id = TextBox1.Text
        nama = TextBox2.Text
        jenis = ComboBox1.SelectedItem
        harga = TextBox3.Text
        stok = TextBox4.Text

        Select Case ComboBox2.SelectedItem
            Case "masih"
                status = 1
            Case "habis"
                status = 0
        End Select

        query = "UPDATE makanan_minuman SET nama=?, jenis=?, harga=?, stok=?, status=? WHERE id=?"
        Try
            koneksi()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("@param1", nama)
                cmd.Parameters.AddWithValue("@param2", jenis)
                cmd.Parameters.AddWithValue("@param3", harga)
                cmd.Parameters.AddWithValue("@param4", stok)
                cmd.Parameters.AddWithValue("@param5", status)
                cmd.Parameters.AddWithValue("@param6", id)
                Dim rowAffected As Integer = cmd.ExecuteNonQuery()
                If rowAffected > 0 Then
                    MessageBox.Show("Data berhasil diubah")
                    Me.Close()
                    form_fnb.openAfterEdit()
                Else
                    MessageBox.Show("Data gagal diubah")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: ", ex.Message)
        End Try
    End Sub
End Class