Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.Data

Public Class Beli1
    Private idCulture As CultureInfo = New CultureInfo("id-ID")
    Private wisataDT As DataTable

    ' WAJIB biar kontrol dari designer kebentuk
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub Beli1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            tanggal.Value = Date.Today
            jumlah.Text = "1"
            total.Text = "Total: Rp 0"

            ' --- 1) Ambil user dari DB ---
            Dim uid As String = If(tickumdb.CurrentUserId, "")
            Dim u As DataRow = Nothing
            If Not String.IsNullOrWhiteSpace(uid) Then
                u = tickumdb.GetUserById(uid)
            End If

            If u IsNot Nothing Then
                Dim nm As String = u("nama").ToString()
                Dim hp As String = u("no_hp").ToString()

                ' Isi ke label yang kamu pakai (Label4 = Nama, Label5 = No Telp)
                SetTextIfExists("Label4", nm)
                SetTextIfExists("Label5", hp)

                ' Fallback kalau masih ada kontrol lama bernama "nama"/"telp"
                SetTextIfExists("nama", nm)
                SetTextIfExists("telp", hp)
            Else
                ' kosongin aja kalau user ga ketemu
                SetTextIfExists("Label4", "")
                SetTextIfExists("Label5", "")
            End If

            ' --- 2) Ambil list wisata + harga ---
            wisataDT = tickumdb.GetWisataListBasic()

            If Not wisataDT.Columns.Contains("display") Then
                wisataDT.Columns.Add("display", GetType(String))
            End If
            For Each r As DataRow In wisataDT.Rows
                Dim nmWis As String = r("nama_wisata").ToString()
                Dim h As Decimal = If(IsDBNull(r("harga_tiket")), 0D, Convert.ToDecimal(r("harga_tiket")))
                r("display") = $"{nmWis} - Rp {h.ToString("N0", idCulture)}"
            Next

            wisata.DataSource = wisataDT
            wisata.DisplayMember = "display"
            wisata.ValueMember = "wisata_id"
            wisata.SelectedIndex = -1

            UpdateTotalLabel()

        Catch ex As Exception
            MessageBox.Show("Gagal load: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================
    ' Helper: set teks jika kontrolnya ada
    ' =========================
    Private Sub SetTextIfExists(ctrlName As String, value As String)
        Dim arr = Me.Controls.Find(ctrlName, True)
        If arr IsNot Nothing AndAlso arr.Length > 0 Then
            arr(0).Text = value
        End If
    End Sub

    ' =========================
    ' Hitung total realtime
    ' =========================
    Private Sub UpdateTotalLabel()
        Dim harga As Decimal = 0D
        If wisata.SelectedIndex >= 0 AndAlso wisata.SelectedItem IsNot Nothing Then
            Dim drv As DataRowView = CType(wisata.SelectedItem, DataRowView)
            If Not IsDBNull(drv("harga_tiket")) Then harga = Convert.ToDecimal(drv("harga_tiket"))
        End If

        Dim qty As Integer
        If Not Integer.TryParse(jumlah.Text.Trim(), qty) OrElse qty < 0 Then qty = 0

        total.Text = "Total: Rp " & (harga * qty).ToString("N0", idCulture)
    End Sub

    Private Sub wisata_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wisata.SelectedIndexChanged
        UpdateTotalLabel()
    End Sub

    Private Sub jumlah_TextChanged(sender As Object, e As EventArgs) Handles jumlah.TextChanged
        UpdateTotalLabel()
    End Sub

    Private Sub jumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jumlah.KeyPress
        ' hanya angka & tombol kontrol
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
        ' blok Enter biar ga bikin newline
        If e.KeyChar = ChrW(Keys.Enter) Then e.Handled = True
    End Sub

    ' =========================
    ' Beli -> insert transaksi & lanjut ke Beli2
    ' =========================
    Private Sub beli_Click(sender As Object, e As EventArgs) Handles beli.Click
        Try
            If wisata.SelectedIndex < 0 Then
                MessageBox.Show("Pilih wisata dulu.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim qty As Integer
            If Not Integer.TryParse(jumlah.Text.Trim(), qty) OrElse qty <= 0 Then
                MessageBox.Show("Jumlah tiket minimal 1.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            Dim drv As DataRowView = CType(wisata.SelectedItem, DataRowView)
            Dim wisataId As Integer = CInt(wisata.SelectedValue)
            Dim wisataNama As String = drv("nama_wisata").ToString()
            Dim harga As Decimal = If(IsDBNull(drv("harga_tiket")), 0D, Convert.ToDecimal(drv("harga_tiket")))
            Dim tgl As Date = tanggal.Value.Date
            Dim totalHarga As Decimal = harga * qty

            Dim transaksiId As Long =
                tickumdb.InsertTransaksi(tickumdb.CurrentUserId, wisataId, tgl, qty, totalHarga)

            If transaksiId = 0 Then
                MessageBox.Show("Gagal menyimpan transaksi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Oper data ke Beli2 lewat context
            PurchaseContext.TransaksiId = CInt(transaksiId)
            PurchaseContext.UserId = tickumdb.CurrentUserId
            PurchaseContext.WisataId = wisataId
            PurchaseContext.WisataNama = wisataNama
            PurchaseContext.HargaTiket = harga
            PurchaseContext.JumlahTiket = qty
            PurchaseContext.TanggalKunjungan = tgl
            PurchaseContext.TotalHarga = totalHarga

            Dim f As New Beli2()
            f.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Try
            Dim f As New Home()   ' pastikan nama form-mu "Home"
            f.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Gagal kembali ke Home: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class

' =========================
' Context untuk dipakai Beli2
' =========================
Public Module PurchaseContext
    Public TransaksiId As Integer
    Public UserId As String
    Public WisataId As Integer
    Public WisataNama As String
    Public HargaTiket As Decimal
    Public JumlahTiket As Integer
    Public TanggalKunjungan As Date
    Public TotalHarga As Decimal
End Module
