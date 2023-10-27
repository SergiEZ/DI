Public Class Form1
    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Close()
    End Sub

    Private Sub btResultado_Click(sender As Object, e As EventArgs) Handles btResultado.Click
        Dim num1 As Decimal = Decimal.Parse(tbPrimero.Text)
        Dim num2 As Decimal = Decimal.Parse(tbSegundo.Text)
        Dim resultado As Decimal


        If (rbSumar.Checked = True) Then
            resultado = num1 + num2
        End If

        If (rbRestar.Checked = True) Then
            resultado = num1 - num2
        End If

        If (rbMultiplicar.Checked = True) Then
            resultado = num1 * num2
        End If

        If (rbDividir.Checked = True) Then
            resultado = num1 / num2
        End If

        lbResultado.Text = resultado.ToString()
    End Sub
End Class
