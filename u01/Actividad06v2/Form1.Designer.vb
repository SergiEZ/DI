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
        gbOperaciones = New GroupBox()
        rbDividir = New RadioButton()
        rbMultiplicar = New RadioButton()
        rbRestar = New RadioButton()
        rbSumar = New RadioButton()
        btCerrar = New Button()
        btResultado = New Button()
        Label1 = New Label()
        tbSegundo = New TextBox()
        lbSegundo = New Label()
        tbPrimero = New TextBox()
        lbPrimero = New Label()
        lbResultado = New Label()
        gbOperaciones.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbOperaciones
        ' 
        gbOperaciones.Controls.Add(rbDividir)
        gbOperaciones.Controls.Add(rbMultiplicar)
        gbOperaciones.Controls.Add(rbRestar)
        gbOperaciones.Controls.Add(rbSumar)
        gbOperaciones.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        gbOperaciones.Location = New Point(283, 26)
        gbOperaciones.Name = "gbOperaciones"
        gbOperaciones.Size = New Size(169, 217)
        gbOperaciones.TabIndex = 16
        gbOperaciones.TabStop = False
        gbOperaciones.Text = "Select An Operation"
        ' 
        ' rbDividir
        ' 
        rbDividir.AutoSize = True
        rbDividir.Location = New Point(9, 166)
        rbDividir.Name = "rbDividir"
        rbDividir.Size = New Size(93, 34)
        rbDividir.TabIndex = 3
        rbDividir.Text = "Dividir"
        rbDividir.UseVisualStyleBackColor = True
        ' 
        ' rbMultiplicar
        ' 
        rbMultiplicar.AutoSize = True
        rbMultiplicar.Location = New Point(9, 132)
        rbMultiplicar.Name = "rbMultiplicar"
        rbMultiplicar.Size = New Size(132, 34)
        rbMultiplicar.TabIndex = 2
        rbMultiplicar.Text = "Multiplicar"
        rbMultiplicar.UseVisualStyleBackColor = True
        ' 
        ' rbRestar
        ' 
        rbRestar.AutoSize = True
        rbRestar.Location = New Point(9, 98)
        rbRestar.Name = "rbRestar"
        rbRestar.Size = New Size(90, 34)
        rbRestar.TabIndex = 1
        rbRestar.Text = "Restar"
        rbRestar.UseVisualStyleBackColor = True
        ' 
        ' rbSumar
        ' 
        rbSumar.AutoSize = True
        rbSumar.Checked = True
        rbSumar.Location = New Point(9, 64)
        rbSumar.Name = "rbSumar"
        rbSumar.Size = New Size(93, 34)
        rbSumar.TabIndex = 0
        rbSumar.TabStop = True
        rbSumar.Text = "Sumar"
        rbSumar.UseVisualStyleBackColor = True
        ' 
        ' btCerrar
        ' 
        btCerrar.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        btCerrar.Location = New Point(310, 328)
        btCerrar.Name = "btCerrar"
        btCerrar.Size = New Size(142, 62)
        btCerrar.TabIndex = 15
        btCerrar.Text = "Cerrar"
        btCerrar.UseVisualStyleBackColor = True
        ' 
        ' btResultado
        ' 
        btResultado.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        btResultado.Location = New Point(25, 328)
        btResultado.Name = "btResultado"
        btResultado.Size = New Size(142, 62)
        btResultado.TabIndex = 14
        btResultado.Text = "Resultado"
        btResultado.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(25, 122)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 30)
        Label1.TabIndex = 13
        Label1.Text = "+"
        ' 
        ' tbSegundo
        ' 
        tbSegundo.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        tbSegundo.Location = New Point(25, 204)
        tbSegundo.Name = "tbSegundo"
        tbSegundo.Size = New Size(182, 36)
        tbSegundo.TabIndex = 12
        ' 
        ' lbSegundo
        ' 
        lbSegundo.AutoSize = True
        lbSegundo.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lbSegundo.Location = New Point(25, 167)
        lbSegundo.Name = "lbSegundo"
        lbSegundo.Size = New Size(182, 30)
        lbSegundo.TabIndex = 11
        lbSegundo.Text = "Segundo número"
        ' 
        ' tbPrimero
        ' 
        tbPrimero.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        tbPrimero.Location = New Point(25, 63)
        tbPrimero.Name = "tbPrimero"
        tbPrimero.Size = New Size(182, 36)
        tbPrimero.TabIndex = 10
        ' 
        ' lbPrimero
        ' 
        lbPrimero.AutoSize = True
        lbPrimero.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lbPrimero.Location = New Point(25, 26)
        lbPrimero.Name = "lbPrimero"
        lbPrimero.Size = New Size(159, 30)
        lbPrimero.TabIndex = 9
        lbPrimero.Text = "Primer número"
        ' 
        ' lbResultado
        ' 
        lbResultado.AutoSize = True
        lbResultado.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        lbResultado.Location = New Point(25, 278)
        lbResultado.Name = "lbResultado"
        lbResultado.Size = New Size(0, 30)
        lbResultado.TabIndex = 17
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 411)
        Controls.Add(lbResultado)
        Controls.Add(gbOperaciones)
        Controls.Add(btCerrar)
        Controls.Add(btResultado)
        Controls.Add(Label1)
        Controls.Add(tbSegundo)
        Controls.Add(lbSegundo)
        Controls.Add(tbPrimero)
        Controls.Add(lbPrimero)
        Name = "Form1"
        Text = "Calculadora Simple"
        gbOperaciones.ResumeLayout(False)
        gbOperaciones.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gbOperaciones As GroupBox
    Friend WithEvents rbDividir As RadioButton
    Friend WithEvents rbMultiplicar As RadioButton
    Friend WithEvents rbRestar As RadioButton
    Friend WithEvents rbSumar As RadioButton
    Friend WithEvents btCerrar As Button
    Friend WithEvents btResultado As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSegundo As TextBox
    Friend WithEvents lbSegundo As Label
    Friend WithEvents tbPrimero As TextBox
    Friend WithEvents lbPrimero As Label
    Friend WithEvents lbResultado As Label
End Class
