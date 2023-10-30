Public Class Form1

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
    End Sub
    Private Sub btComma_Click(sender As Object, e As EventArgs) Handles btComma.Click
        tbCampo.Text += ","
    End Sub

    Private Sub btEaL_Click(sender As Object, e As EventArgs) Handles btEaL.Click

        Try
            tbCampo.Text = Replace(tbCampo.Text, "€", "")
            tbCampo.Text = Replace(tbCampo.Text, "£", "")
            tbCampo.Text = FormatCurrency(Decimal.Parse(tbCampo.Text) * 0.872, 2, , , TriState.True)
            tbCampo.Text = Replace(tbCampo.Text, "€", "£")

        Catch ex As FormatException
            MessageBox.Show("Introduce un valor válido.")

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)

        End Try
    End Sub

    Private Sub btLaE_Click(sender As Object, e As EventArgs) Handles btLaE.Click

        Try
            tbCampo.Text = Replace(tbCampo.Text, "€", "")
            tbCampo.Text = Replace(tbCampo.Text, "£", "")
            tbCampo.Text = FormatCurrency(Decimal.Parse(tbCampo.Text) * 1.146, 2, , , TriState.True)

        Catch ex As FormatException
            MessageBox.Show("Introduce un valor válido.")

        Catch ex As Exception
            MessageBox.Show("ERROR: " & ex.Message)

        End Try

    End Sub

End Class
