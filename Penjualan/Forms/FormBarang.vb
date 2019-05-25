Public Class FormBarang
    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        BtnTambah.Enabled = st
        BtnUbah.Enabled = st
        BtnHapus.Enabled = st
        BtnSimpan.Enabled = st
        BtnBatal.Enabled = st


        GroupBox1.Enabled = Not st
        GroupBox3.Enabled = st
        GroupBox4.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGBarang.Rows(br)
                TxtKode.Text = .Cells(0).Value.ToString
                TxtNama.Text = .Cells(0).Value.ToString
                TxtHarga.Text = .Cells(0).Value.ToString
                TxtStok.Text = .Cells(0).Value.ToString
            End With
            LblBaris.Text = "Data ke -" & br + 1 & " dari " & DGBarang.RowCount - 1 & " data"
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            AturButton(True)
            IsiBox(baris)
        End If
    End Sub

    Private Sub TampilCari(kunci As String)
        DTGrid = KontrolBarang.cariData(kunci).ToTable

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGBarang.DataSource = DTGrid
            DGBarang.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGBarang.CurrentCell = DGBarang.Item(1, baris)
            IsiBox(baris)
        Else
            MsgBox("data tidak ditemukan")
            RefreshGrid()

        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click

    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        AturButton(False)
        modeProses = 1

        TxtNama.Text = ""
        TxtHarga.Text = ""
        TxtStok.Text = ""

        TxtKode.Text = KontrolBarang.kodeBaru()
        TxtNama.Focus()

    End Sub

    Private Sub FormBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call RefreshGrid()

        TxtKode.Enabled = False
    End Sub

    Private Sub ButtonSelesai_Click(sender As Object, e As EventArgs) Handles ButtonSelesai.Click
        Me.Close()
    End Sub

    Private Sub BtnAkhir_Click(sender As Object, e As EventArgs) Handles BtnAkhir.Click
        DGBarang.ClearSelection()
        baris = DTGrid.Rows.Count - 1
        DGBarang.Rows(baris).Selected = True

        IsiBox(baris)


    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        AturButton(False)

        TxtNama.Focus()
        modeProses = 2
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles BtnBatal.Click
        RefreshGrid()

        AturButton(True)
        modeProses = 0
    End Sub

    Private Sub BtnNaik_Click(sender As Object, e As EventArgs) Handles BtnNaik.Click
        DGBarang.ClearSelection()
        If baris > 0 Then baris = baris - 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnTurun_Click(sender As Object, e As EventArgs) Handles BtnTurun.Click
        DGBarang.ClearSelection()
        If baris > DTGrid.Rows.Count - 1 Then baris = baris + 1
        DGBarang.Rows(baris).Selected = True
        IsiBox(baris)
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        If TxtCari.Text = "" Then
            Call RefreshGrid()
        Else
            Call TampilCari(TxtCari.Text)
            TxtCari.Focus()
        End If
    End Sub
End Class
