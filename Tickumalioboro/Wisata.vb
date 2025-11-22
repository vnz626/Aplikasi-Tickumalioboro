Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Wisata
    ' MySQL connection string
    ' Make sure your tickumdb.vb is properly connected to your database

    Private Sub Wisata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the columns of the DataGridView with image as the first column
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Foto", "Gambar") ' First column for image (displayed as image)
        DataGridView1.Columns.Add("Nama", "Nama Wisata")
        DataGridView1.Columns.Add("Lokasi", "Lokasi")
        DataGridView1.Columns.Add("HariBuka", "Hari Buka")
        DataGridView1.Columns.Add("JamOperasional", "Jam Operasional")
        DataGridView1.Columns.Add("HargaTiket", "Harga Tiket")
        DataGridView1.Columns.Add("Deskripsi", "Deskripsi") ' Column for description

        ' Set the row height to auto size based on content
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

        ' Set the column width for the image (so it's a fixed size, square)
        DataGridView1.Columns("Foto").Width = 100 ' Set the fixed width for the image column

        ' Enable text wrapping for the columns that might overflow (Lokasi, Nama, Hari Buka, Deskripsi)
        DataGridView1.Columns("Deskripsi").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("Lokasi").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("Nama").DefaultCellStyle.WrapMode = DataGridViewTriState.True
        DataGridView1.Columns("HariBuka").DefaultCellStyle.WrapMode = DataGridViewTriState.True

        ' Set specific widths for the columns for a better visual experience
        DataGridView1.Columns("Lokasi").Width = 200 ' Adjust as needed
        DataGridView1.Columns("Nama").Width = 150 ' Adjust as needed
        DataGridView1.Columns("HariBuka").Width = 150 ' Adjust as needed

        ' Set a fixed width for Deskripsi column (200 pixels)
        DataGridView1.Columns("Deskripsi").Width = 200 ' Set a fixed width for the Deskripsi column

        ' Load data from database
        LoadWisataData()
    End Sub

    Private Sub LoadWisataData()
        ' Query to get the wisata data, including BLOB image
        Dim query As String = "SELECT wisata_id, nama_wisata, deskripsi, lokasi, hari_buka, jam_operasional, harga_tiket, foto_wisata FROM wisata"

        ' Get the data from tickumdb.vb
        Dim dt As DataTable = tickumdb.GetData(query)

        ' Loop through the rows and add them to the DataGridView
        For Each row As DataRow In dt.Rows
            ' Create a new row for the DataGridView
            Dim newRow As DataGridViewRow = New DataGridViewRow()

            ' Add image for the first column (image column) and resize the image to fit the square size
            Dim imageData As Byte() = TryCast(row("foto_wisata"), Byte())
            If imageData IsNot Nothing Then
                Dim ms As New MemoryStream(imageData)
                Dim img As Image = Image.FromStream(ms)

                ' Resize the image to a square (100x100 pixels)
                Dim resizedImg As New Bitmap(img, New Size(100, 100))
                newRow.Cells.Add(New DataGridViewImageCell() With {.Value = resizedImg})
            Else
                newRow.Cells.Add(New DataGridViewImageCell() With {.Value = Nothing})
            End If

            ' Add cell values for the rest of the columns
            newRow.Cells.Add(New DataGridViewTextBoxCell() With {.Value = row("nama_wisata").ToString()})
            newRow.Cells.Add(New DataGridViewTextBoxCell() With {.Value = row("lokasi").ToString()})
            newRow.Cells.Add(New DataGridViewTextBoxCell() With {.Value = row("hari_buka").ToString()})
            newRow.Cells.Add(New DataGridViewTextBoxCell() With {.Value = row("jam_operasional").ToString()})
            newRow.Cells.Add(New DataGridViewTextBoxCell() With {.Value = "Rp " & row("harga_tiket").ToString()})
            newRow.Cells.Add(New DataGridViewTextBoxCell() With {.Value = row("deskripsi").ToString()})

            ' Add the new row to the DataGridView
            DataGridView1.Rows.Add(newRow)
        Next
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
