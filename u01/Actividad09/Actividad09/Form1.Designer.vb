<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lbForm1 = New Label()
        btAbrir = New Button()
        lbCont = New Label()
        SuspendLayout()
        ' 
        ' lbForm1
        ' 
        lbForm1.AutoSize = True
        lbForm1.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbForm1.Location = New Point(122, 68)
        lbForm1.Name = "lbForm1"
        lbForm1.Size = New Size(213, 45)
        lbForm1.TabIndex = 0
        lbForm1.Text = "Formulario 1"
        ' 
        ' btAbrir
        ' 
        btAbrir.Font = New Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        btAbrir.Location = New Point(122, 154)
        btAbrir.Name = "btAbrir"
        btAbrir.Size = New Size(213, 74)
        btAbrir.TabIndex = 1
        btAbrir.Text = "Abrir Form2"
        btAbrir.UseVisualStyleBackColor = True
        ' 
        ' lbCont
        ' 
        lbCont.AutoSize = True
        lbCont.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        lbCont.Location = New Point(149, 302)
        lbCont.Name = "lbCont"
        lbCont.Size = New Size(145, 45)
        lbCont.TabIndex = 2
        lbCont.Text = "Cont = 0"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(445, 441)
        Controls.Add(lbCont)
        Controls.Add(btAbrir)
        Controls.Add(lbForm1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbForm1 As Label
    Friend WithEvents btAbrir As Button
    Friend WithEvents lbCont As Label
End Class
