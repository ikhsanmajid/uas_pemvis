Imports System.Data.Odbc

Public Class form_error_client
    Dim con As OdbcConnection
    Dim da As OdbcDataAdapter
    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader

    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=warnet"
        con.Open()
    End Sub

    Private Function getNewKodePC()
        Dim query As String = "SELECT MAX(kode_client) FROM status_client"
        Try
            koneksi()
            Using cmd As New OdbcCommand(query, con)
                Using reader As OdbcDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Dim new_kode_client As String = "PC" & Integer.Parse(reader.GetString(0).Substring(2, 3) + 1).ToString("D3")
                        Return new_kode_client
                    End If
                End Using

            End Using
        Catch ex As Exception

        End Try

        Return "PC001"
    End Function

    Private Function populateComboBox(table As String, column As String, combobox As ComboBox)
        Dim query As String = "SELECT " & column & " FROM " & table
        Try
            koneksi()
            Using cmd As New OdbcCommand(query, con)
                Using reader As OdbcDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim value As String = reader(column).ToString()
                        combobox.Items.Add(value)
                    End While
                End Using

            End Using
        Catch ex As Exception

        End Try

        Return 0
    End Function

    Sub simpan()
        Dim kode_pc, ipaddr, keterangan As String
        Dim status As Integer

        kode_pc = kode_pc_add.Text
        ipaddr = ipaddress_add.Text

        Select Case status_add.SelectedItem.ToString()
            Case "Normal"
                status = 1
            Case "Ada kerusakan"
                status = 0
        End Select

        keterangan = keterangan_add.Text


        Dim query As String = "INSERT INTO status_client (kode_client, ip_address, status, keterangan) VALUES (?,?,?,?)"

        Try
            koneksi()
            Using cmd As New OdbcCommand(query, con)
                cmd.Parameters.AddWithValue("@param1", kode_pc)
                cmd.Parameters.AddWithValue("@param2", ipaddr)
                cmd.Parameters.AddWithValue("@param3", status)
                cmd.Parameters.AddWithValue("@param4", keterangan)

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

        loadTable()
    End Sub

    Sub loadTable()
        kode_pc_add.ReadOnly = True
        kode_pc_add.Text = getNewKodePC()
        Dim query As String = "SELECT * FROM status_client ORDER BY kode_client ASC"
        Try
            DataSet1.Clear()
            DataSet1.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(DataSet1.status_client)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub form_error_client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadTable()

        'Set dropdown style
        status_add.DropDownStyle = ComboBoxStyle.DropDownList
        status_add.SelectedIndex = 0
        status_filter.DropDownStyle = ComboBoxStyle.DropDownList
        status_filter.SelectedIndex = 0
        'set width
        DataGridView1.Columns(3).Width = 410 'keterangan
    End Sub

    'edit value from sql in status column
    Private Sub DataGridView1_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If e.ColumnIndex = 2 AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "1" Then
            e.Value = "Normal"
        ElseIf e.ColumnIndex = 2 AndAlso e.Value IsNot Nothing AndAlso e.Value.ToString() = "0" Then
            e.Value = "Ada kerusakan"
        End If
    End Sub

    'simpan button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click
        simpan()
    End Sub

    'refresh table
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        loadTable()
    End Sub

    'edit row
    Private Sub EditRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditRowToolStripMenuItem.Click
        Dim kode_pc_edit, ipaddr_edit, keterangan_edit As String
        Dim status_edit As Integer
        Dim selectedRowIndex As Integer

        selectedRowIndex = DataGridView1.CurrentRow.Index

        kode_pc_edit = DataGridView1.Rows(selectedRowIndex).Cells(0).Value
        ipaddr_edit = DataGridView1.Rows(selectedRowIndex).Cells(1).Value
        status_edit = DataGridView1.Rows(selectedRowIndex).Cells(2).Value
        keterangan_edit = DataGridView1.Rows(selectedRowIndex).Cells(3).Value

        form_edit_client.loadEdit(kode_pc_edit, ipaddr_edit, status_edit, keterangan_edit)
        Me.Hide()
        form_edit_client.Show()
    End Sub

    'delete row
    Private Sub DeleteRowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteRowToolStripMenuItem.Click
        Dim kode_pc_delete, query As String
        Dim selectedRowIndex As Integer
        selectedRowIndex = DataGridView1.CurrentRow.Index

        kode_pc_delete = DataGridView1.Rows(selectedRowIndex).Cells(0).Value

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete " & kode_pc_delete & "?", "Confirmation", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            query = "DELETE FROM status_client WHERE kode_client='" & kode_pc_delete & "'"
            Try
                koneksi()
                Using cmd As New OdbcCommand(query, con)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data berhasil dihapus")
                        loadTable()
                    Else
                        MessageBox.Show("Data gagal dihapus")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: ", ex.Message)
            End Try
        Else

        End If

    End Sub

    'filter menu
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim query, base_query As String
        Dim status_pc As String

        Select Case status_filter.SelectedItem
            Case "Normal"
                status_pc = "1"
            Case "Ada kerusakan"
                status_pc = "0"
            Case Else
                status_pc = "All"
        End Select

        base_query = "SELECT * FROM status_client"

        If status_pc = "All" Then
            query = base_query
        Else
            query = base_query & " where status='" & status_pc & "'"
        End If

        Try
            DataSet1.Clear()
            DataSet1.EnforceConstraints = False
            koneksi()
            da = New OdbcDataAdapter(query, con)
            da.Fill(DataSet1.status_client)
        Catch ex As Exception
        End Try

    End Sub

    'buka setelah edit
    Sub openAfterEdit()
        loadTable()
        Me.Show()
    End Sub

End Class