Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resultado As String
        Dim p1 As New Producto("Camisas", 5, 15.35)
        Dim p2 As New Producto("Pantalon", 3, 11.36)
        Dim p3 As New Producto("Zapatillas", 9, 10.25)
        Dim p4 As New Producto("Gorras", 6, 12.74)

        resultado = "Nombre" & vbTab & "Cantidad" & vbTab & "Precio" & vbTab & "Total" & vbCrLf
        resultado &= p1.Nombre & vbTab & p1.Cantidad & vbTab & p1.Precio & "€ " & vbTab & p1.Total & "€" & vbCrLf
        resultado &= p2.Nombre & vbTab & p2.Cantidad & vbTab & p2.Precio & "€ " & vbTab & p2.Total & "€" & vbCrLf
        resultado &= p3.Nombre & vbTab & p3.Cantidad & vbTab & p3.Precio & "€ " & vbTab & p3.Total & "€" & vbCrLf
        resultado &= p4.Nombre & vbTab & p4.Cantidad & vbTab & p4.Precio & "€ " & vbTab & p4.Total & "€"

        TextBox1.Text = resultado

    End Sub
End Class
