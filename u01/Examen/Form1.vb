Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbWelcome.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lbWelcome2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim box = New Form2()
        box.Show()
    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btCerrar_Click_1(sender As Object, e As EventArgs) Handles btCerrar.Click
        Close()
    End Sub
End Class
