Public Class Form6
    Dim resultado As String
    Private Sub btPrecios_Click(sender As Object, e As EventArgs) Handles btPrecios.Click
        TextBox1.Clear()
        TextBox1.Text = resultado
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        resultado = "Tipo" & vbTab & "Precio" & vbTab & "Definición" & vbCrLf
        resultado &= "Adulto" & vbTab & "30.00 €" & vbTab & "Mayores de 18 años y menores de 65 años" & vbCrLf
        resultado &= "Junior" & vbTab & "20.00 €" & vbTab & "Menores de 18 años" & vbCrLf
        resultado &= "Senior" & vbTab & "15.00 €" & vbTab & "Mayores de 65 años" & vbCrLf
        resultado &= "Niños" & vbTab & "5.00 €" & vbTab & "Menores de 5 años" & vbCrLf
    End Sub
End Class