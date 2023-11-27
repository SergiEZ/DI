Public Class Form7
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbAdulto.Enter

    End Sub

    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim valor1 As Double
            Dim valor2 As Double
            Dim valor3 As Double
            Dim valor4 As Double

            valor1 = Double.Parse(lbAdulto.Text)
            valor2 = Double.Parse(lbJunior.Text)
            valor3 = Double.Parse(lbInfantil.Text)
            valor4 = Double.Parse(lbSenior.Text)

            Dim suma As Double = valor1 + valor2 + valor3 + valor4
            lbTotal.Text = suma.ToString & " €"


        Catch ex As Exception
            ''MessageBox.Show("ERROR: " & ex.Message)

        End Try
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btCalcularAdulto_Click(sender As Object, e As EventArgs) Handles btCalcularAdulto.Click
        Dim suma As Double
        If rbA0.Checked Then
            suma = 0 * 30
            lbAdulto.Text = suma.ToString
        End If
        If rbA1.Checked Then
            suma = 1 * 30
            lbAdulto.Text = suma.ToString
        End If
        If rbA2.Checked Then
            suma = 2 * 30
            lbAdulto.Text = suma.ToString
        End If
        If rbA3.Checked Then
            suma = 3 * 30
            lbAdulto.Text = suma.ToString
        End If
    End Sub

    Private Sub btCalcularJunior_Click(sender As Object, e As EventArgs) Handles btCalcularJunior.Click
        Dim suma As Double
        If rbJ0.Checked Then
            suma = 0 * 20
            lbJunior.Text = suma.ToString
        End If
        If rbJ1.Checked Then
            suma = 1 * 20
            lbJunior.Text = suma.ToString
        End If
        If rbJ2.Checked Then
            suma = 2 * 20
            lbJunior.Text = suma.ToString
        End If
        If rbJ3.Checked Then
            suma = 3 * 20
            lbJunior.Text = suma.ToString
        End If
    End Sub

    Private Sub btCalcularSenior_Click(sender As Object, e As EventArgs) Handles btCalcularSenior.Click
        Dim suma As Double
        If rbS0.Checked Then
            suma = 0 * 15
            lbSenior.Text = suma.ToString
        End If
        If rbS1.Checked Then
            suma = 1 * 15
            lbSenior.Text = suma.ToString
        End If
        If rbS2.Checked Then
            suma = 2 * 15
            lbSenior.Text = suma.ToString
        End If
        If rbS3.Checked Then
            suma = 3 * 15
            lbSenior.Text = suma.ToString
        End If
    End Sub

    Private Sub btCalcularInfantil_Click(sender As Object, e As EventArgs) Handles btCalcularInfantil.Click
        Dim suma As Double
        If rbI0.Checked Then
            suma = 0 * 5
            lbInfantil.Text = suma.ToString
        End If
        If rbI1.Checked Then
            suma = 1 * 5
            lbInfantil.Text = suma.ToString
        End If
        If rbI2.Checked Then
            suma = 2 * 5
            lbInfantil.Text = suma.ToString
        End If
        If rbI3.Checked Then
            suma = 3 * 5
            lbInfantil.Text = suma.ToString
        End If
    End Sub
End Class