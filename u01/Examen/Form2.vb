Public Class Form2
    Private Sub btCerrar_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim box = New Form3()
        box.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Close()
        Form1.Close()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Dim box = New Form4()
        box.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Dim box = New Form5()
        box.Show()
    End Sub

    Private Sub IntroduccionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroduccionToolStripMenuItem.Click

    End Sub

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        Dim box = New Form6()
        box.Show()
    End Sub

    Private Sub CalculaTuEntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculaTuEntradaToolStripMenuItem.Click
        Dim box = New Form7()
        box.Show()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        Dim box = New Form8()
        box.Show()
    End Sub
End Class