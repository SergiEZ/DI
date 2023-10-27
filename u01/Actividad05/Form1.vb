Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Close()
    End Sub

    Private Sub btResultado_Click(sender As Object, e As EventArgs) Handles btResultado.Click
        Dim num1 As Decimal = Decimal.Parse(tbPrimero.Text)
        Dim num2 As Decimal = Decimal.Parse(tbSegundo.Text)

        Dim resultado As Decimal = num1 + num2

        lbResultado.Text = resultado.ToString()
    End Sub
End Class
