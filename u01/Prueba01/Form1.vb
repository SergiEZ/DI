Public Class Form1


    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub

    Private Sub BotonPulseAqui_MouseEnter(sender As Object, e As EventArgs) Handles BotonPulseAqui.MouseEnter
        Label1.Text = "Hola mundo"
    End Sub

    Private Sub BotonPulseAqui_MouseLeave(sender As Object, e As EventArgs) Handles BotonPulseAqui.MouseLeave
        Label1.Text = "Adiós mundo"
    End Sub
End Class
