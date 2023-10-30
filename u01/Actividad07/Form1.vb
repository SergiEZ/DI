Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Close()
    End Sub

    Private Sub btResultado_Click(sender As Object, e As EventArgs) Handles btResultado.Click
        Try

            Select Case True
                Case rbSumar.Checked
                    lbResultado.Text = (Decimal.Parse(tbPrimero.Text) + Decimal.Parse(tbSegundo.Text)).ToString

                Case rbRestar.Checked
                    lbResultado.Text = (Decimal.Parse(tbPrimero.Text) - Decimal.Parse(tbSegundo.Text)).ToString

                Case rbMultiplicar.Checked
                    lbResultado.Text = (Decimal.Parse(tbPrimero.Text) * Decimal.Parse(tbSegundo.Text)).ToString

                Case rbDividir.Checked
                    lbResultado.Text = (Decimal.Parse(tbPrimero.Text) / Decimal.Parse(tbSegundo.Text)).ToString
            End Select

        Catch ex As FormatException
            MessageBox.Show("Campos inválidos. Debes usar números.")

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)

        End Try

    End Sub

End Class
