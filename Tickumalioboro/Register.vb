Imports MySql.Data.MySqlClient

Public Class Register
    ' We no longer need the connection string or connection initialization here.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Capture user input from the RichTextBox controls
        Dim name As String = RichTextBox4.Text
        Dim phone As String = RichTextBox3.Text
        Dim email As String = RichTextBox1.Text
        Dim password As String = RichTextBox2.Text

        ' Basic validation
        If String.IsNullOrEmpty(name) Or String.IsNullOrEmpty(phone) Or String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to insert new user into the database
        Dim query As String = "INSERT INTO users (nama, email, password, no_hp) VALUES ('" & name & "', '" & email & "', '" & password & "', '" & phone & "')"

        ' Use tickumdb.ExecuteQuery to execute the insert query
        Try
            ' Now we use tickumdb.ExecuteQuery to execute the SQL query
            If tickumdb.ExecuteQuery(query) Then
                MessageBox.Show("Registration successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Optionally, navigate to the Login form after successful registration
                Dim loginForm As New Login()
                loginForm.Show()
                Me.Hide() ' Hide the Register form
            Else
                MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Redirect to Login form when label is clicked
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ' Hide the Register form
        Me.Hide()

        ' Show the Login form
        Dim loginForm As New Login()
        loginForm.Show()
    End Sub
End Class
