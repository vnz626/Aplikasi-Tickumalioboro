Imports MySql.Data.MySqlClient

Public Class Home
    ' Constructor or form load logic can be placed here if needed
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Any initial setup if needed
    End Sub

    ' Informasi Wisata button click - Opens tourism information form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Open Informasi Wisata form (assuming you have a form called Wisata)
        Dim wisataForm As New Wisata()  ' Using Wisata.vb form
        wisataForm.Show()
        Me.Hide() ' Hide the Home form
    End Sub

    ' Beli Tiket button click - Opens ticket purchasing form
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Open Beli1 form (assuming you have a form called Beli1 for purchasing tickets)
        Dim beliTiketForm As New Beli1()  ' Using Beli1.vb form
        beliTiketForm.Show()
        Me.Hide() ' Hide the Home form
    End Sub

    ' Riwayat Pembelian button click - Opens purchase history form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Open Riwayat form (assuming you have a form called Riwayat)
        Dim riwayatForm As New Riwayat()  ' Using Riwayat.vb form
        riwayatForm.Show()
        Me.Hide() ' Hide the Home form
    End Sub

    ' About Us button click - Opens about us form or displays information
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' Open AboutUs form (assuming you have a form called AboutUs)
        Dim aboutUsForm As New AboutUs()  ' Using AboutUs.vb form
        aboutUsForm.Show()
        Me.Hide() ' Hide the Home form
    End Sub

End Class
