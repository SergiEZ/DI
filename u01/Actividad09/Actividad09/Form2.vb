Public Class Form2
    Dim contador As Integer = 0
    Private Sub btAdd_Click(sender As Object, e As EventArgs) Handles btAdd.Click

        contador = contador + 1
        Form1.lbCont.Text = "Cont = " & contador

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form1.lbCont.Text = "Cont = 0"
        contador = 0

    End Sub
End Class