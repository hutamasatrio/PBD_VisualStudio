<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBarang))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.TxtStok = New System.Windows.Forms.TextBox()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonSelesai = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnAkhir = New System.Windows.Forms.Button()
        Me.BtnTurun = New System.Windows.Forms.Button()
        Me.BtnNaik = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.LblBaris = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.TxtStok)
        Me.GroupBox1.Controls.Add(Me.TxtKode)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 177)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(134, 61)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(260, 20)
        Me.TxtNama.TabIndex = 7
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(134, 100)
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(215, 20)
        Me.TxtHarga.TabIndex = 6
        '
        'TxtStok
        '
        Me.TxtStok.Location = New System.Drawing.Point(134, 135)
        Me.TxtStok.Name = "TxtStok"
        Me.TxtStok.Size = New System.Drawing.Size(215, 20)
        Me.TxtStok.TabIndex = 5
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(134, 25)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(215, 20)
        Me.TxtKode.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stok"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Harga Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Barang"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonSelesai)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnHapus)
        Me.GroupBox2.Controls.Add(Me.BtnUbah)
        Me.GroupBox2.Controls.Add(Me.BtnTambah)
        Me.GroupBox2.Location = New System.Drawing.Point(525, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(161, 423)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'ButtonSelesai
        '
        Me.ButtonSelesai.Image = Global.Penjualan.My.Resources.Resources.images
        Me.ButtonSelesai.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ButtonSelesai.Location = New System.Drawing.Point(33, 381)
        Me.ButtonSelesai.Name = "ButtonSelesai"
        Me.ButtonSelesai.Size = New System.Drawing.Size(94, 34)
        Me.ButtonSelesai.TabIndex = 5
        Me.ButtonSelesai.Text = "Selesai"
        Me.ButtonSelesai.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = Global.Penjualan.My.Resources.Resources._1463227215_Log_Out
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(33, 237)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(94, 34)
        Me.BtnBatal.TabIndex = 4
        Me.BtnBatal.Text = "Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = Global.Penjualan.My.Resources.Resources._1463227320_Save
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(33, 185)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(94, 34)
        Me.BtnSimpan.TabIndex = 3
        Me.BtnSimpan.Text = "Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(33, 134)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(94, 34)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(33, 78)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(94, 34)
        Me.BtnUbah.TabIndex = 1
        Me.BtnUbah.Text = "Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnTambah
        '
        Me.BtnTambah.Image = CType(resources.GetObject("BtnTambah.Image"), System.Drawing.Image)
        Me.BtnTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTambah.Location = New System.Drawing.Point(31, 19)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(94, 37)
        Me.BtnTambah.TabIndex = 0
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BtnCari)
        Me.GroupBox3.Controls.Add(Me.TxtCari)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 382)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(300, 77)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Masukkan Data Yang Dicari"
        '
        'BtnCari
        '
        Me.BtnCari.Image = CType(resources.GetObject("BtnCari.Image"), System.Drawing.Image)
        Me.BtnCari.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCari.Location = New System.Drawing.Point(184, 25)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(103, 37)
        Me.BtnCari.TabIndex = 1
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(20, 34)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(158, 20)
        Me.TxtCari.TabIndex = 0
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(12, 207)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(493, 150)
        Me.DGBarang.TabIndex = 3
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BtnAkhir)
        Me.GroupBox4.Controls.Add(Me.BtnTurun)
        Me.GroupBox4.Controls.Add(Me.BtnNaik)
        Me.GroupBox4.Controls.Add(Me.Button5)
        Me.GroupBox4.Location = New System.Drawing.Point(318, 390)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(193, 54)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        '
        'BtnAkhir
        '
        Me.BtnAkhir.Location = New System.Drawing.Point(150, 14)
        Me.BtnAkhir.Name = "BtnAkhir"
        Me.BtnAkhir.Size = New System.Drawing.Size(37, 34)
        Me.BtnAkhir.TabIndex = 6
        Me.BtnAkhir.Text = ">>"
        Me.BtnAkhir.UseVisualStyleBackColor = True
        '
        'BtnTurun
        '
        Me.BtnTurun.Location = New System.Drawing.Point(107, 14)
        Me.BtnTurun.Name = "BtnTurun"
        Me.BtnTurun.Size = New System.Drawing.Size(37, 34)
        Me.BtnTurun.TabIndex = 5
        Me.BtnTurun.Text = ">"
        Me.BtnTurun.UseVisualStyleBackColor = True
        '
        'BtnNaik
        '
        Me.BtnNaik.Location = New System.Drawing.Point(51, 14)
        Me.BtnNaik.Name = "BtnNaik"
        Me.BtnNaik.Size = New System.Drawing.Size(37, 34)
        Me.BtnNaik.TabIndex = 1
        Me.BtnNaik.Text = "<"
        Me.BtnNaik.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(6, 14)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 34)
        Me.Button5.TabIndex = 0
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'LblBaris
        '
        Me.LblBaris.AutoSize = True
        Me.LblBaris.Location = New System.Drawing.Point(258, 363)
        Me.LblBaris.Name = "LblBaris"
        Me.LblBaris.Size = New System.Drawing.Size(111, 13)
        Me.LblBaris.TabIndex = 5
        Me.LblBaris.Text = "data ke - 0 dari 0 data"
        '
        'FormBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 467)
        Me.Controls.Add(Me.LblBaris)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DGBarang)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormBarang"
        Me.Text = "Form Barang"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtHarga As System.Windows.Forms.TextBox
    Friend WithEvents TxtStok As System.Windows.Forms.TextBox
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnAkhir As System.Windows.Forms.Button
    Friend WithEvents BtnTurun As System.Windows.Forms.Button
    Friend WithEvents BtnNaik As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As Button
    Friend WithEvents BtnSimpan As Button
    Friend WithEvents ButtonSelesai As Button
    Friend WithEvents LblBaris As Label
End Class
