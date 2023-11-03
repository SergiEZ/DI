Public Class Form1
    Dim comma As Boolean = False
    Dim memoria As Double = 0
    Dim operacion As Integer = -1

    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        tbCampo.Text += "0"
    End Sub

    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        tbCampo.Text += "1"
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        tbCampo.Text += "2"
    End Sub
    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        tbCampo.Text += "3"
    End Sub
    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        tbCampo.Text += "4"
    End Sub
    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        tbCampo.Text += "5"
    End Sub
    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        tbCampo.Text += "6"
    End Sub
    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        tbCampo.Text += "7"
    End Sub
    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        tbCampo.Text += "8"
    End Sub
    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        tbCampo.Text += "9"
    End Sub

    Private Sub btClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        tbCampo.Text = ""
        lbMemo.Text = ""
        RehabilitaNumeros()
        RehabilitaOperadores()
        btResultado.Enabled = False
    End Sub
    Private Sub btComma_Click(sender As Object, e As EventArgs) Handles btComma.Click
        If comma = False Then
            tbCampo.Text += ","
            comma = True
        End If

    End Sub

    Sub DeshabilitaOperadores()
        lbMemo.Text = memoria
        tbCampo.Text = "0"
        comma = False
        btSuma.Enabled = False
        btResta.Enabled = False
        btMultiplica.Enabled = False
        btDivide.Enabled = False
        btResultado.Enabled = True
    End Sub

    Sub RehabilitaOperadores()
        btSuma.Enabled = True
        btResta.Enabled = True
        btMultiplica.Enabled = True
        btDivide.Enabled = True
        btResultado.Enabled = False
    End Sub

    Sub DeshabilitaNumeros()
        lbMemo.Text = memoria
        bt0.Enabled = False
        bt1.Enabled = False
        bt2.Enabled = False
        bt3.Enabled = False
        bt4.Enabled = False
        bt5.Enabled = False
        bt6.Enabled = False
        bt7.Enabled = False
        bt8.Enabled = False
        bt9.Enabled = False
        btComma.Enabled = False
    End Sub

    Sub RehabilitaNumeros()
        bt0.Enabled = True
        bt1.Enabled = True
        bt2.Enabled = True
        bt3.Enabled = True
        bt4.Enabled = True
        bt5.Enabled = True
        bt6.Enabled = True
        bt7.Enabled = True
        bt8.Enabled = True
        bt9.Enabled = True
        btComma.Enabled = True
    End Sub
    Function Operar(ByVal operacion As Integer, ByVal num1 As Double, ByVal num2 As Double) As Double
        Dim resultado As Double

        Try
            Select Case operacion
                Case 0 ' Suma
                    resultado = num1 + num2
                Case 1 ' Resta
                    resultado = num1 - num2
                Case 2 ' Multiplicación
                    resultado = num1 * num2
                Case 3 ' División
                    If num2 <> 0 Then ' Verificar que el divisor no sea cero
                        resultado = num1 / num2
                    Else
                        Throw New DivideByZeroException("Error: División por cero.")
                    End If
                Case Else ' Operación inválida
                    Throw New Exception("Error: Operación inválida.")
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            resultado = Double.NaN ' Devolver NaN en caso de error
        End Try

        Return resultado
    End Function

    Private Sub btSuma_Click(sender As Object, e As EventArgs) Handles btSuma.Click
        memoria = CDbl(tbCampo.Text)
        operacion = 0
        DeshabilitaOperadores()
        RehabilitaNumeros()
    End Sub

    Private Sub btResta_Click(sender As Object, e As EventArgs) Handles btResta.Click
        memoria = CDbl(tbCampo.Text)
        operacion = 1
        DeshabilitaOperadores()
        RehabilitaNumeros()
    End Sub

    Private Sub btMultiplica_Click(sender As Object, e As EventArgs) Handles btMultiplica.Click
        memoria = CDbl(tbCampo.Text)
        operacion = 2
        DeshabilitaOperadores()
        RehabilitaNumeros()
    End Sub

    Private Sub btDivide_Click(sender As Object, e As EventArgs) Handles btDivide.Click
        memoria = CDbl(tbCampo.Text)
        operacion = 3
        DeshabilitaOperadores()
        RehabilitaNumeros()
    End Sub

    Private Sub btResultado_Click(sender As Object, e As EventArgs) Handles btResultado.Click
        tbCampo.Text = Operar(operacion, memoria, CDbl(tbCampo.Text))
        DeshabilitaNumeros()
        RehabilitaOperadores()
        lbMemo.Text = ""
    End Sub
End Class
