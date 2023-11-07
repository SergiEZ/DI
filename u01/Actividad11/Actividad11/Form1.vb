Public Class Form1
    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            lbASCII.Text = Asc(e.KeyChar)
            lbChar.Text = e.KeyChar
        Catch ex As Exception
            MessageBox.Show("Tecla no válida")
        End Try
    End Sub
End Class
