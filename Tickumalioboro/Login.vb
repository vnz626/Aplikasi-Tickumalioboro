Imports MySql.Data.MySqlClient

Public Class Login
    ' MySQL connection string is now handled in tickumdb.vb
    ' So we no longer need the connectionString here.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Capture the email and password from the textboxes
        Dim email As String = RichTextBox1.Text
        Dim password As String = RichTextBox2.Text

        ' Basic validation
        If String.IsNullOrEmpty(email) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both email and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' SQL query to check if the user exists with the entered credentials
        Dim query As String = "SELECT * FROM users WHERE email = @Email AND password = @Password"

        ' Use tickumdb.GetData to retrieve data
        Try
            ' Prepare the query with parameters
            query = query.Replace("@Email", "'" & email & "'").Replace("@Password", "'" & password & "'")

            ' Call tickumdb to get the data
            Dim dt As DataTable = tickumdb.GetData(query)

            If dt.Rows.Count > 0 Then
                ' Login successful, navigate to Home form or Dashboard
                MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim homeForm As New Home() ' Assuming Home is your next form
                homeForm.Show()
                Me.Hide() ' Hide the Login form
            Else
                ' Incorrect credentials
                MessageBox.Show("Invalid email or password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As MySqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Redirect to Register form when label is clicked
    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ' Hide the Login form
        Me.Hide()

        ' Show the Register form
        Dim registerForm As New Register()
        registerForm.Show()
    End Sub
End Class
