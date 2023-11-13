'Imports Microsoft.WindowsAPICodePack.Taskbar
Public Class Form1

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.B Then
            btBackground.PerformClick()
        End If
        If e.Control AndAlso e.KeyCode = Keys.C Then
            btFont.PerformClick()
        End If
        If e.Alt AndAlso e.KeyCode = Keys.F4 Then
            btQuit.PerformClick()
        End If
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.A Then
            AboutBox1.Show()
        End If
        If e.Control AndAlso e.KeyCode = Keys.F1 Then
            formAyuda.Show()
        End If
    End Sub
    Private Sub btQuit_Click(sender As Object, e As EventArgs) Handles btQuit.Click, QuitToolStripMenuItem.Click
        Close()
        SplashScreen1.Close()
    End Sub

    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Try
            Dim keyAscii As Integer = Asc(e.KeyChar)

            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then ' Comprobar si es un número
                If rbNumbers.Checked = True Or rbAll.Checked = True Then
                    lbN.Show()
                    lbN.Text = Chr(keyAscii)
                    lbU.Hide()
                    lbL.Hide()
                    lbLower.Hide()
                    lbUpper.Hide()
                    lbNumber.Show()
                End If
            End If

            If rbLetters.Checked = True Or rbAll.Checked = True Then
                Dim tecla As String = Chr(keyAscii)

                If Asc(tecla) >= 65 And Asc(tecla) <= 90 Then ' Letra mayúscula
                    lbU.Text = tecla
                    lbL.Text = Mid(tecla, 1, 1)
                    lbN.Hide()
                    lbNumber.Hide()
                    lbU.Show()
                    lbUpper.Show()
                    lbL.Show()
                    lbLower.Show()
                ElseIf Asc(tecla) >= 97 And Asc(tecla) <= 122 Then ' Letra minúscula
                    lbNumber.Hide()
                    lbN.Hide()
                    lbL.Text = tecla
                    lbU.Text = Mid(tecla, 1, 1)
                    lbUpper.Hide()
                    lbLower.Hide()
                    lbU.Show()
                    lbUpper.Show()
                    lbL.Show()
                    lbLower.Show()
                End If
            End If
        Catch ex As Exception
            ' Manejar la excepción aquí
            MessageBox.Show("Se ha producido un error al procesar la tecla.")
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btBackground.Click, BackgroundColorToolStripMenuItem1.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form1.ActiveForm.BackColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub btFont_Click(sender As Object, e As EventArgs) Handles btFont.Click, FontColorToolStripMenuItem1.Click
        If ColorDialog1.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            Form1.ActiveForm.ForeColor = ColorDialog1.Color
        End If
    End Sub

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        formAyuda.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub
End Class