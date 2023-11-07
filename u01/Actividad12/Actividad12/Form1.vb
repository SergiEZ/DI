Imports System.Windows

Public Class Form1
    Private Sub btLimpiar_Click(sender As Object, e As EventArgs) Handles btLimpiar.Click
        tbInsert.Text = ""
        tbLetras.Text = ""
        tbNumeros.Text = ""
        tbOtros.Text = ""
    End Sub

    Private Sub btSubmit_Click(sender As Object, e As EventArgs) Handles btSubmit.Click
        Try
            Dim input As String = tbInsert.Text
            Dim letras As String = ""
            Dim numeros As String = ""
            Dim otros As String = ""

            For i As Integer = 1 To Len(input)
                Dim caracter As String = Mid(input, i, 1)
                Dim codigoAscii As Integer = Asc(caracter)

                If codigoAscii >= 65 AndAlso codigoAscii <= 90 OrElse codigoAscii >= 97 AndAlso codigoAscii <= 122 Then
                    letras += caracter
                ElseIf codigoAscii >= 48 AndAlso codigoAscii <= 57 Then
                    numeros += caracter
                Else
                    otros += caracter
                End If
            Next

            tbLetras.Text = letras
            tbNumeros.Text = numeros
            tbOtros.Text = otros

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)
        End Try
    End Sub
End Class
