<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_edit_user
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.inputJenKel = New System.Windows.Forms.ComboBox()
        Me.inputKonfirmasi = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.inputPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inputUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.inputAlamat = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.inputNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(202, 421)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(198, 24)
        Me.CheckBox1.TabIndex = 66
        Me.CheckBox1.Text = "Tampilkan Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'inputJenKel
        '
        Me.inputJenKel.FormattingEnabled = True
        Me.inputJenKel.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.inputJenKel.Location = New System.Drawing.Point(202, 128)
        Me.inputJenKel.Name = "inputJenKel"
        Me.inputJenKel.Size = New System.Drawing.Size(251, 28)
        Me.inputJenKel.TabIndex = 65
        '
        'inputKonfirmasi
        '
        Me.inputKonfirmasi.Location = New System.Drawing.Point(202, 362)
        Me.inputKonfirmasi.Name = "inputKonfirmasi"
        Me.inputKonfirmasi.Size = New System.Drawing.Size(251, 26)
        Me.inputKonfirmasi.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(40, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 20)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Konfirmasi Password"
        '
        'inputPassword
        '
        Me.inputPassword.Location = New System.Drawing.Point(202, 302)
        Me.inputPassword.Name = "inputPassword"
        Me.inputPassword.Size = New System.Drawing.Size(251, 26)
        Me.inputPassword.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 20)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Password"
        '
        'inputUsername
        '
        Me.inputUsername.Location = New System.Drawing.Point(202, 243)
        Me.inputUsername.Name = "inputUsername"
        Me.inputUsername.Size = New System.Drawing.Size(251, 26)
        Me.inputUsername.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Username"
        '
        'inputAlamat
        '
        Me.inputAlamat.Location = New System.Drawing.Point(202, 187)
        Me.inputAlamat.Name = "inputAlamat"
        Me.inputAlamat.Size = New System.Drawing.Size(251, 26)
        Me.inputAlamat.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Alamat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(40, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 20)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Jenis Kelamin"
        '
        'inputNama
        '
        Me.inputNama.Location = New System.Drawing.Point(202, 68)
        Me.inputNama.Name = "inputNama"
        Me.inputNama.Size = New System.Drawing.Size(251, 26)
        Me.inputNama.TabIndex = 55
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Nama"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 46)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'form_edit_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(498, 565)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.inputJenKel)
        Me.Controls.Add(Me.inputKonfirmasi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.inputPassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inputUsername)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.inputAlamat)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputNama)
        Me.Controls.Add(Me.Label2)
        Me.Name = "form_edit_user"
        Me.Text = "form_edit_user"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents inputJenKel As System.Windows.Forms.ComboBox
    Friend WithEvents inputKonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents inputPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents inputUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents inputAlamat As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents inputNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
