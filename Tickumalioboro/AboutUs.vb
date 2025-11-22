Public Class AboutUs

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