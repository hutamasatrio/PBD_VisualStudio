<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cari
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Kode Barang")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Nama Barang")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Harga")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Stok")
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnCari = New System.Windows.Forms.Button()
        Me.ListTampil = New System.Windows.Forms.ListView()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(93, 32)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(208, 20)
        Me.TxtCari.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Kata Kunci"
        '
        'BtnCari
        '
        Me.BtnCari.Location = New System.Drawing.Point(317, 28)
        Me.BtnCari.Name = "BtnCari"
        Me.BtnCari.Size = New System.Drawing.Size(75, 23)
        Me.BtnCari.TabIndex = 2
        Me.BtnCari.Text = "Cari"
        Me.BtnCari.UseVisualStyleBackColor = True
        '
        'ListTampil
        '
        Me.ListTampil.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListTampil.Location = New System.Drawing.Point(16, 78)
        Me.ListTampil.Name = "ListTampil"
        Me.ListTampil.Size = New System.Drawing.Size(376, 211)
        Me.ListTampil.TabIndex = 3
        Me.ListTampil.UseCompatibleStateImageBehavior = False
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(16, 305)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 4
        Me.BtnTambah.Text = "Tambah"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'Cari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 386)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.ListTampil)
        Me.Controls.Add(Me.BtnCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCari)
        Me.Name = "Cari"
        Me.Text = "Cari Barang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnCari As System.Windows.Forms.Button
    Friend WithEvents ListTampil As System.Windows.Forms.ListView
    Friend WithEvents BtnTambah As System.Windows.Forms.Button
End Class
