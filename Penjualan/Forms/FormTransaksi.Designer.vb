<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransaksi
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LblJumlah = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TxtBanyak = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.TxtKdBrg = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTanggal = New System.Windows.Forms.TextBox()
        Me.TxtNota = New System.Windows.Forms.TextBox()
        Me.TxtKdKasir = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtKasir = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPotongan = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtBayar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtKembali = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ravie", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Toko Apa Aja"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kode"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblTotal)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.LblJumlah)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.ListView1)
        Me.GroupBox1.Controls.Add(Me.TxtBanyak)
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.BtnCari)
        Me.GroupBox1.Controls.Add(Me.TxtKdBrg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(20, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(525, 278)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Transaksi"
        '
        'LblTotal
        '
        Me.LblTotal.AutoSize = True
        Me.LblTotal.Location = New System.Drawing.Point(382, 249)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(33, 13)
        Me.LblTotal.TabIndex = 14
        Me.LblTotal.Text = "Label"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(283, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(69, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Total Belanja"
        '
        'LblJumlah
        '
        Me.LblJumlah.AutoSize = True
        Me.LblJumlah.Location = New System.Drawing.Point(126, 249)
        Me.LblJumlah.Name = "LblJumlah"
        Me.LblJumlah.Size = New System.Drawing.Size(33, 13)
        Me.LblJumlah.TabIndex = 12
        Me.LblJumlah.Text = "Label"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(19, 249)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Jumlah Barang"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(19, 87)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(483, 155)
        Me.ListView1.TabIndex = 10
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'TxtBanyak
        '
        Me.TxtBanyak.Enabled = False
        Me.TxtBanyak.Location = New System.Drawing.Point(402, 61)
        Me.TxtBanyak.Name = "TxtBanyak"
        Me.TxtBanyak.Size = New System.Drawing.Size(100, 20)
        Me.TxtBanyak.TabIndex = 9
        '
        'TxtHarga
        '
        Me.TxtHarga.Enabled = False
        Me.TxtHarga.Location = New System.Drawing.Point(286, 61)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(100, 20)
        Me.TxtHarga.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(399, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Banyak"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Harga"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(165, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nama"
        '
        'TxtNama
        '
        Me.TxtNama.Enabled = False
        Me.TxtNama.Location = New System.Drawing.Point(168, 61)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(100, 20)
        Me.TxtNama.TabIndex = 4
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(126, 58)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(36, 23)
        Me.BtnCari.TabIndex = 3
        Me.BtnCari.Text = ". . ."
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TxtKdBrg
        '
        Me.TxtKdBrg.Enabled = False
        Me.TxtKdBrg.Location = New System.Drawing.Point(19, 58)
        Me.TxtKdBrg.Name = "TxtKdBrg"
        Me.TxtKdBrg.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdBrg.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tanggal"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nota"
        '
        'TxtTanggal
        '
        Me.TxtTanggal.Location = New System.Drawing.Point(92, 88)
        Me.TxtTanggal.Name = "TxtTanggal"
        Me.TxtTanggal.Size = New System.Drawing.Size(100, 20)
        Me.TxtTanggal.TabIndex = 5
        '
        'TxtNota
        '
        Me.TxtNota.Location = New System.Drawing.Point(92, 121)
        Me.TxtNota.Name = "TxtNota"
        Me.TxtNota.Size = New System.Drawing.Size(100, 20)
        Me.TxtNota.TabIndex = 6
        '
        'TxtKdKasir
        '
        Me.TxtKdKasir.Location = New System.Drawing.Point(367, 85)
        Me.TxtKdKasir.Name = "TxtKdKasir"
        Me.TxtKdKasir.Size = New System.Drawing.Size(100, 20)
        Me.TxtKdKasir.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(300, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Kasir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(300, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nama Kasir"
        '
        'TxtKasir
        '
        Me.TxtKasir.Location = New System.Drawing.Point(367, 121)
        Me.TxtKasir.Name = "TxtKasir"
        Me.TxtKasir.Size = New System.Drawing.Size(100, 20)
        Me.TxtKasir.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 463)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "Potongan"
        '
        'TxtPotongan
        '
        Me.TxtPotongan.Location = New System.Drawing.Point(136, 460)
        Me.TxtPotongan.Name = "TxtPotongan"
        Me.TxtPotongan.Size = New System.Drawing.Size(141, 20)
        Me.TxtPotongan.TabIndex = 14
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(136, 486)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(141, 20)
        Me.TxtTotal.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 489)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Total Bersih"
        '
        'TxtBayar
        '
        Me.TxtBayar.Location = New System.Drawing.Point(136, 512)
        Me.TxtBayar.Name = "TxtBayar"
        Me.TxtBayar.Size = New System.Drawing.Size(141, 20)
        Me.TxtBayar.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(61, 515)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Bayar"
        '
        'TxtKembali
        '
        Me.TxtKembali.Location = New System.Drawing.Point(136, 541)
        Me.TxtKembali.Name = "TxtKembali"
        Me.TxtKembali.Size = New System.Drawing.Size(141, 20)
        Me.TxtKembali.TabIndex = 20
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(63, 544)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Kembali"
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = Global.Penjualan.My.Resources.Resources._1463227215_Log_Out
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTutup.Location = New System.Drawing.Point(331, 516)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(75, 45)
        Me.BtnTutup.TabIndex = 23
        Me.BtnTutup.Text = "Tutup"
        Me.BtnTutup.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.Penjualan.My.Resources.Resources._1463227320_Save
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnSimpan.Location = New System.Drawing.Point(434, 457)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(75, 45)
        Me.BtnSimpan.TabIndex = 22
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Image = Global.Penjualan.My.Resources.Resources._1463227288_Add
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnTambah.Location = New System.Drawing.Point(331, 457)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 45)
        Me.BtnTambah.TabIndex = 21
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'FormTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 583)
        Me.Controls.Add(Me.BtnTutup)
        Me.Controls.Add(Me.BtnSimpan)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.TxtKembali)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtBayar)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtPotongan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtKasir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtKdKasir)
        Me.Controls.Add(Me.TxtNota)
        Me.Controls.Add(Me.TxtTanggal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransaksi"
        Me.Text = "FormTransaksi"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TxtBanyak As System.Windows.Forms.TextBox
    Friend WithEvents TxtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents TxtKdBrg As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTanggal As System.Windows.Forms.TextBox
    Friend WithEvents TxtNota As System.Windows.Forms.TextBox
    Friend WithEvents TxtKdKasir As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtKasir As System.Windows.Forms.TextBox
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LblJumlah As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtPotongan As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtKembali As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
End Class
