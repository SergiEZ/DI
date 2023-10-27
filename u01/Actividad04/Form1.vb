Public Class Form1
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        If (Button1.Location = New Point(66, 160)) Then
            Button1.Location = New Point(66, 40)
        Else Button1.Location = New Point(66, 160)
        End If

    End Sub
End Class
