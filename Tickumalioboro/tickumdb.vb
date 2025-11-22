Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Public Class tickumdb
    ' =========================
    ' KONFIG
    ' =========================
    Private Shared connectionString As String =
        "server=localhost;userid=root;password=;database=tickum_db"

    ' user_id di tabel kamu berupa teks (contoh: "user", "tes")
    Public Shared Property CurrentUserId As String = ""

    ' =========================
    ' KONEKSI & UTIL UMUM
    ' =========================
    Public Shared Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connectionString)
    End Function

    Public Shared Function ExecuteQuery(query As String) As Boolean
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Shared Function GetData(query As String) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Shared Function GetImageFromDatabase(imagePath As String) As Image
        Try
            Return Image.FromFile(imagePath)
        Catch ex As Exception
            MessageBox.Show("Image Error: " & ex.Message, "Image Load Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' Tetap disediakan untuk form lain
    Public Shared Function GetWisataData() As DataTable
        Dim dt As New DataTable()
        Dim query As String = "SELECT * FROM wisata"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Shared Function InsertUser(name As String, email As String, password As String, phone As String) As Boolean
        Dim query As String =
            "INSERT INTO users (nama, email, password, no_hp) VALUES (@Nama, @Email, @Password, @NoHp)"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Nama", name)
                    cmd.Parameters.AddWithValue("@Email", email)
                    cmd.Parameters.AddWithValue("@Password", password)
                    cmd.Parameters.AddWithValue("@NoHp", phone)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    ' =========================
    ' HELPER KHUSUS BELI
    ' =========================

    ' Ambil 1 user by id (user_id, nama, no_hp)
    Public Shared Function GetUserById(userId As String) As DataRow
        Dim dt As New DataTable()
        Dim sql As String =
            "SELECT user_id, nama, no_hp FROM users WHERE user_id=@uid LIMIT 1;"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@uid", userId)
                    Using adp As New MySqlDataAdapter(cmd)
                        adp.Fill(dt)
                    End Using
                End Using
            End Using
            If dt.Rows.Count > 0 Then Return dt.Rows(0)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return Nothing
    End Function

    ' List wisata minimal (wisata_id, nama_wisata, harga_tiket)
    Public Shared Function GetWisataListBasic() As DataTable
        Dim dt As New DataTable()
        Dim sql As String =
            "SELECT wisata_id, nama_wisata, harga_tiket FROM wisata ORDER BY nama_wisata;"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Using adp As New MySqlDataAdapter(cmd)
                        adp.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    ' Insert transaksi lalu kembalikan transaksi_id
    Public Shared Function InsertTransaksi(userId As String,
                                           wisataId As Integer,
                                           tanggalKunjungan As Date,
                                           jumlahTiket As Integer,
                                           totalHarga As Decimal) As Long
        Dim sql As String =
            "INSERT INTO transaksi (user_id, wisata_id, tanggal_kunjungan, jumlah_tiket, total_harga) " &
            "VALUES (@uid, @wid, @tgl, @qty, @total);"
        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@uid", userId)
                    cmd.Parameters.AddWithValue("@wid", wisataId)
                    cmd.Parameters.AddWithValue("@tgl", tanggalKunjungan)
                    cmd.Parameters.AddWithValue("@qty", jumlahTiket)
                    cmd.Parameters.AddWithValue("@total", totalHarga)
                    cmd.ExecuteNonQuery()
                    Return CLng(cmd.LastInsertedId)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        End Try
    End Function

End Class
