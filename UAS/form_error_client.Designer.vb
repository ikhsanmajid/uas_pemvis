<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_error_client
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ipaddress_add = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.status_add = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kode_pc_add = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.keterangan_add = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.KodeclientDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IpaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KeteranganDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusclientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New UAS.DataSet1()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.status_filter = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.StatusclientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ipaddress_add)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.status_add)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.kode_pc_add)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.keterangan_add)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(751, 121)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tambah Client PC"
        '
        'ipaddress_add
        '
        Me.ipaddress_add.Location = New System.Drawing.Point(157, 39)
        Me.ipaddress_add.Name = "ipaddress_add"
        Me.ipaddress_add.Size = New System.Drawing.Size(202, 20)
        Me.ipaddress_add.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(630, 80)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Simpan Client Baru"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'status_add
        '
        Me.status_add.FormattingEnabled = True
        Me.status_add.Items.AddRange(New Object() {"Normal", "Ada kerusakan"})
        Me.status_add.Location = New System.Drawing.Point(381, 39)
        Me.status_add.Name = "status_add"
        Me.status_add.Size = New System.Drawing.Size(131, 21)
        Me.status_add.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Status"
        '
        'kode_pc_add
        '
        Me.kode_pc_add.Location = New System.Drawing.Point(15, 40)
        Me.kode_pc_add.Name = "kode_pc_add"
        Me.kode_pc_add.Size = New System.Drawing.Size(121, 20)
        Me.kode_pc_add.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Kode PC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(534, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Keterangan"
        '
        'keterangan_add
        '
        Me.keterangan_add.Location = New System.Drawing.Point(537, 40)
        Me.keterangan_add.Name = "keterangan_add"
        Me.keterangan_add.Size = New System.Drawing.Size(202, 20)
        Me.keterangan_add.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "IP Address"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeclientDataGridViewTextBoxColumn, Me.IpaddressDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.KeteranganDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.DataSource = Me.StatusclientBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(751, 464)
        Me.DataGridView1.TabIndex = 28
        '
        'KodeclientDataGridViewTextBoxColumn
        '
        Me.KodeclientDataGridViewTextBoxColumn.DataPropertyName = "kode_client"
        Me.KodeclientDataGridViewTextBoxColumn.HeaderText = "Kode PC"
        Me.KodeclientDataGridViewTextBoxColumn.Name = "KodeclientDataGridViewTextBoxColumn"
        Me.KodeclientDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IpaddressDataGridViewTextBoxColumn
        '
        Me.IpaddressDataGridViewTextBoxColumn.DataPropertyName = "ip_address"
        Me.IpaddressDataGridViewTextBoxColumn.HeaderText = "IP Address"
        Me.IpaddressDataGridViewTextBoxColumn.Name = "IpaddressDataGridViewTextBoxColumn"
        Me.IpaddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'KeteranganDataGridViewTextBoxColumn
        '
        Me.KeteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan"
        Me.KeteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan Kerusakan"
        Me.KeteranganDataGridViewTextBoxColumn.Name = "KeteranganDataGridViewTextBoxColumn"
        Me.KeteranganDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.EditRowToolStripMenuItem, Me.DeleteRowToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(134, 70)
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RefreshToolStripMenuItem.Text = "Refresh"
        '
        'EditRowToolStripMenuItem
        '
        Me.EditRowToolStripMenuItem.Name = "EditRowToolStripMenuItem"
        Me.EditRowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EditRowToolStripMenuItem.Text = "Edit Row"
        '
        'DeleteRowToolStripMenuItem
        '
        Me.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem"
        Me.DeleteRowToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DeleteRowToolStripMenuItem.Text = "Delete Row"
        '
        'StatusclientBindingSource
        '
        Me.StatusclientBindingSource.DataMember = "status_client"
        Me.StatusclientBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.status_filter)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(751, 65)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter"
        '
        'status_filter
        '
        Me.status_filter.FormattingEnabled = True
        Me.status_filter.Items.AddRange(New Object() {"All", "Normal", "Ada kerusakan"})
        Me.status_filter.Location = New System.Drawing.Point(64, 29)
        Me.status_filter.Name = "status_filter"
        Me.status_filter.Size = New System.Drawing.Size(185, 21)
        Me.status_filter.TabIndex = 33
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Status"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(270, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 23)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Filter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'form_error_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 686)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "form_error_client"
        Me.Text = "form_error_client"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.StatusclientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents status_add As System.Windows.Forms.ComboBox
    Friend WithEvents kode_pc_add As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents keterangan_add As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ipaddress_add As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents KodeclientDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IpaddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KeteranganDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StatusclientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As UAS.DataSet1
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents status_filter As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RefreshToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
