Imports System.Data.OleDb
Imports Penjualan

Public Class ClsEntBarang
    Private kode As String
    Private nama As String
    Private harga As Integer
    Private stok As Integer
    Public Property kodeBarang() As String
        Get
            Return kode

        End Get
        Set(value As String)
            kode = value
        End Set
    End Property
    Public Property namaBarang() As String
        Get
            Return nama
        End Get
        Set(value As String)
            nama = value
        End Set
    End Property
    Public Property hargaBarang() As Integer
        Get
            Return harga
        End Get
        Set(value As Integer)
            harga = value
        End Set
    End Property
    Public Property stokBarang() As Integer
        Get
            Return stok
        End Get
        Set(value As Integer)
            stok = value
        End Set
    End Property
    Public Class ClsCtlBarang : Implements InfProses
        Function kodeBaru() As String
            Dim baru As String
            Dim kodeakhir As Integer

            Try
                DTA = New OleDbDataAdapter("select max(kode_barang, 4)) from barang", BUKAKONEKSI)
                DTS = New DataSet()
                DTA.Fill(DTS, "max_code")
                kodeakhir = Val(DTS.Tables("max_code").Rows(0).Item(0))
                baru = "B" & Strings.Right("000" & kodeakhir + 1, 4)
                Return baru
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function


        Public Function InsertData(Ob As Object) As OleDbCommand Implements InfProses.InsertData
            Throw New NotImplementedException()
        End Function

        Public Function updateData(Ob As Object) As OleDbCommand Implements InfProses.updateData
            Throw New NotImplementedException()
        End Function

        Public Function deleteData(kunci As String) As OleDbCommand Implements InfProses.deleteData
            Throw New NotImplementedException()
        End Function

        Public Function tampilData() As DataView Implements InfProses.tampilData
            Throw New NotImplementedException()
        End Function

        Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
            Throw New NotImplementedException()

            Try
                DTA = New OleDbDataAdapter("select * from Barang where nama_barang " & "like '%" & kunci & "%'", BUKAKONEKSI)
                DTS = New DataSet()
                DTA.Fill(DTS, "Cari_Barang")
                Dim grid As New DataView(DTS.Tables("Cari_Barang"))
                Return grid
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
    End Class

End Class
