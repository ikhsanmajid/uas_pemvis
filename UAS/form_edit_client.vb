Imports System.Data.Odbc

Public Class form_edit_client
    Dim con As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=warnet"
        con.Open()
    End Sub

    Sub loadEdit(kode As String, ipaddr As String, status As Integer, keterangan As String)
        'change style
        status_add.DropDownStyle = ComboBoxStyle.DropDownList

        kode_pc_add.Text = kode
        kode_pc_add.ReadOnly = True
        ipaddress_add.Text = ipaddr
        Select Case status
            Case 1
                status_add.SelectedIndex = 0
            Case 0
                status_add.SelectedIndex = 1
        End Select
        keterangan_add.Text = keterangan
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kode_pc, ipaddr, keterangan, query As String
        Dim status As Integer

        kode_pc = kode_pc_add.Text
        ipaddr = ipaddress_add.Text

        Select Case status_add.SelectedItem
            Case "Normal"
                status = 1
            Case "Ada kerusakan"
                status = 0
        End Select

        keterangan = keterangan_add.Text

        query = "UPDATE status_client SET ip_address=?, status=?, keterangan=? WHERE kode_client=?"

        Try
            koneksi()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("@param1", ipaddr)
                cmd.Parameters.AddWithValue("@param2", status)
                cmd.Parameters.AddWithValue("@param3", keterangan)
                cmd.Parameters.AddWithValue("@param4", kode_pc)

                Dim rowAffected As Integer = cmd.ExecuteNonQuery()

                If rowAffected > 0 Then
                    MessageBox.Show("Data berhasil diupdate")
                    Me.Close()
                    form_error_client.openAfterEdit()
                Else
                    MessageBox.Show("Data gagal diupdate")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error: ", ex.Message)
        End Try

    End Sub
End Class