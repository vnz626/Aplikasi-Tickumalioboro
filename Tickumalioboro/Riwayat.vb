Imports MySql.Data.MySqlClient

Public Class Riwayat
    ' MySQL connection string (via tickumdb.vb)

    Private Sub Riwayat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data into DataGridView when the form loads
        LoadRiwayatData()
    End Sub

    ' Function to load data from the database
    Private Sub LoadRiwayatData()
        ' SQL query to get data from multiple tables: transaksi, tiket, pembayaran, riwayat_transaksi
        Dim query As String = "
            SELECT 
                t.tiket_id, 
                w.wisata_id, 
                t.tanggal_pesan, 
                t.jumlah_tiket, 
                p.status_tiket
            FROM 
                riwayat_transaksi w
            JOIN 
                transaksi t ON w.transaksi_id = t.transaksi_id
            JOIN 
                tiket tk ON t.tiket_id = tk.tiket_id
            JOIN 
                pembayaran p ON t.transaksi_id = p.transaksi_id"

        ' Get data using the method from tickumdb.vb
        Dim dt As DataTable = tickumdb.GetData(query)

        ' Check if data is available and bind it to the DataGridView
        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            ' Bind the data to DataGridView
            DataGridView1.DataSource = dt

            ' Set the column names for better readability
            DataGridView1.Columns("tiket_id").HeaderText = "ID Tiket"
            DataGridView1.Columns("wisata_id").HeaderText = "ID Wisata"
            DataGridView1.Columns("tanggal_pesan").HeaderText = "Tanggal Pesan"
            DataGridView1.Columns("jumlah_tiket").HeaderText = "Jumlah Tiket"
            DataGridView1.Columns("status_tiket").HeaderText = "Status"

            ' Adjust column width for better visibility
            DataGridView1.Columns("tiket_id").Width = 100
            DataGridView1.Columns("wisata_id").Width = 100
            DataGridView1.Columns("tanggal_pesan").Width = 120
            DataGridView1.Columns("jumlah_tiket").Width = 100
            DataGridView1.Columns("status_tiket").Width = 100
        Else
            MessageBox.Show("No data available.")
        End If
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
