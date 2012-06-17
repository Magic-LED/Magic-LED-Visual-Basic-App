Public Class Form2

    Private Sub RichTextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles RichTextBox1.TextChanged
        RichTextBox1.ScrollToCaret()
    End Sub
End Class