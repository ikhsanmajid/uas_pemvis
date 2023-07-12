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
        Me.ipaddress_add.Location = New System.Drawing.Point(18, 140)
        Me.ipaddress_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ipaddress_add.Name = "ipaddress_add"
        Me.ipaddress_add.Size = New System.Drawing.Size(301, 26)
        Me.ipaddress_add.TabIndex = 34
        '
        'status_add
        '
        Me.status_add.FormattingEnabled = True
        Me.status_add.Items.AddRange(New Object() {"Normal", "Ada kerusakan"})
        Me.status_add.Location = New System.Drawing.Point(18, 220)
        Me.status_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.status_add.Name = "status_add"
        Me.status_add.Size = New System.Drawing.Size(194, 28)
        Me.status_add.TabIndex = 33
        '
        'kode_pc_add
        '
        Me.kode_pc_add.Location = New System.Drawing.Point(18, 65)
        Me.kode_pc_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kode_pc_add.Name = "kode_pc_add"
        Me.kode_pc_add.Size = New System.Drawing.Size(180, 26)
        Me.kode_pc_add.TabIndex = 31
        '
        'keterangan_add
        '
        Me.keterangan_add.Location = New System.Drawing.Point(18, 308)
        Me.keterangan_add.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.keterangan_add.Name = "keterangan_add"
        Me.keterangan_add.Size = New System.Drawing.Size(301, 26)
        Me.keterangan_add.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 195)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 20)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Kode PC"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 283)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Keterangan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "IP Address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(158, 395)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 35)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Edit Status"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form_edit_client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 472)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ipaddress_add)
        Me.Controls.Add(Me.status_add)
        Me.Controls.Add(Me.kode_pc_add)
        Me.Controls.Add(Me.keterangan_add)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
