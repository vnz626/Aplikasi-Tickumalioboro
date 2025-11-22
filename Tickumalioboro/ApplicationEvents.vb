Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication
        ' Handle unhandled exceptions globally
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            MessageBox.Show("An unhandled exception occurred: " & e.Exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
    End Class
End Namespace
