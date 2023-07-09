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

    Sub loadform(id As Integer)
        TextBox1.Text = id.ToString
        query = "SELECT * FROM makanan_minuman WHERE id=" & id
        Try
            koneksi()
            cmd = New OdbcCommand(query, con)
            Using reader As OdbcDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    MessageBox.Show(reader.GetString(1))
                End If
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub form_edit_fnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, stok, status As Integer
        Dim harga As BigInteger
    End Sub
End Class