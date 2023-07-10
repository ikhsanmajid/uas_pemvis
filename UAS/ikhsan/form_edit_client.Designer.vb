<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_edit_client
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
        Me.ipaddress_add = New System.Windows.Forms.TextBox()
        Me.status_add = New System.Windows.Forms.ComboBox()
        Me.kode_pc_add = New System.Windows.Forms.TextBox()
        Me.keterangan_add = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ipaddress_add
        '
        Me.ipaddress_add.Location = New System.Drawing.Point(12, 91)
        Me.ipaddress_add.Name = "ipaddress_add"
        Me.ipaddress_add.Size = New System.Drawing.Size(202, 20)
        Me.ipaddress_add.TabIndex = 34
        '
        'status_add
        '
        Me.status_add.FormattingEnabled = True
        Me.status_add.Items.AddRange(New Object() {"Normal", "Ada kerusakan"})
        Me.status_add.Location = New System.Drawing.Point(12, 143)
        Me.status_add.Name = "status_add"
        Me.status_add.Size = New System.Drawing.Size(131, 21)
        Me.status_add.TabIndex = 33
        '
        'kode_pc_add
        '
        Me.kode_pc_add.Location = New System.Drawing.Point(12, 42)
        Me.kode_pc_add.Name = "kode_pc_add"
        Me.kode_pc_add.Size = New System.Drawing.Size(121, 20)
        Me.kode_pc_add.TabIndex = 31
        '
        'keterangan_add
        '
        Me.keterangan_add.Location = New System.Drawing.Point(12, 200)
        Me.keterangan_add.Name = "keterangan_add"
        Me.keterangan_add.Size = New System.Drawing.Size(202, 20)
        Me.keterangan_add.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 127)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Kode PC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "IP Address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(105, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 23)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Edit Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form_edit_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(230, 307)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ipaddress_add)
        Me.Controls.Add(Me.status_add)
        Me.Controls.Add(Me.kode_pc_add)
        Me.Controls.Add(Me.keterangan_add)
        Me.Name = "form_edit_client"
        Me.Text = "form_edit_client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ipaddress_add As System.Windows.Forms.TextBox
    Friend WithEvents status_add As System.Windows.Forms.ComboBox
    Friend WithEvents kode_pc_add As System.Windows.Forms.TextBox
    Friend WithEvents keterangan_add As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
