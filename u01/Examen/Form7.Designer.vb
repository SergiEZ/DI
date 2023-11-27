<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form7))
        lbUbicaciones = New Label()
        gbAdulto = New GroupBox()
        btCalcularAdulto = New Button()
        rbA3 = New RadioButton()
        rbA2 = New RadioButton()
        rbA1 = New RadioButton()
        rbA0 = New RadioButton()
        gbJunior = New GroupBox()
        btCalcularJunior = New Button()
        rbJ3 = New RadioButton()
        rbJ2 = New RadioButton()
        rbJ1 = New RadioButton()
        rbJ0 = New RadioButton()
        gbSenior = New GroupBox()
        btCalcularSenior = New Button()
        rbS3 = New RadioButton()
        rbS2 = New RadioButton()
        rbS1 = New RadioButton()
        rbS0 = New RadioButton()
        gbInfantil = New GroupBox()
        btCalcularInfantil = New Button()
        rbI3 = New RadioButton()
        rbI2 = New RadioButton()
        rbI1 = New RadioButton()
        rbI0 = New RadioButton()
        lbtextototal = New Label()
        lbAdulto = New Label()
        lbJunior = New Label()
        lbSenior = New Label()
        lbInfantil = New Label()
        lbTotal = New Label()
        btCerrar = New Button()
        Button1 = New Button()
        gbAdulto.SuspendLayout()
        gbJunior.SuspendLayout()
        gbSenior.SuspendLayout()
        gbInfantil.SuspendLayout()
        SuspendLayout()
        ' 
        ' lbUbicaciones
        ' 
        lbUbicaciones.AutoSize = True
        lbUbicaciones.Font = New Font("Tempus Sans ITC", 18F, FontStyle.Bold, GraphicsUnit.Point)
        lbUbicaciones.ForeColor = SystemColors.ControlText
        lbUbicaciones.Location = New Point(12, 28)
        lbUbicaciones.Name = "lbUbicaciones"
        lbUbicaciones.Size = New Size(468, 31)
        lbUbicaciones.TabIndex = 2
        lbUbicaciones.Text = "Selecciona las entradas que desea adquirir:"
        ' 
        ' gbAdulto
        ' 
        gbAdulto.Controls.Add(btCalcularAdulto)
        gbAdulto.Controls.Add(rbA3)
        gbAdulto.Controls.Add(rbA2)
        gbAdulto.Controls.Add(rbA1)
        gbAdulto.Controls.Add(rbA0)
        gbAdulto.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        gbAdulto.Location = New Point(22, 73)
        gbAdulto.Name = "gbAdulto"
        gbAdulto.Size = New Size(163, 202)
        gbAdulto.TabIndex = 3
        gbAdulto.TabStop = False
        gbAdulto.Text = "ADULTO"
        ' 
        ' btCalcularAdulto
        ' 
        btCalcularAdulto.Font = New Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btCalcularAdulto.Location = New Point(72, 148)
        btCalcularAdulto.Name = "btCalcularAdulto"
        btCalcularAdulto.Size = New Size(85, 35)
        btCalcularAdulto.TabIndex = 4
        btCalcularAdulto.Text = "Calcular"
        btCalcularAdulto.UseVisualStyleBackColor = True
        ' 
        ' rbA3
        ' 
        rbA3.AutoSize = True
        rbA3.Location = New Point(19, 152)
        rbA3.Name = "rbA3"
        rbA3.Size = New Size(41, 31)
        rbA3.TabIndex = 3
        rbA3.Text = "3"
        rbA3.UseVisualStyleBackColor = True
        ' 
        ' rbA2
        ' 
        rbA2.AutoSize = True
        rbA2.Location = New Point(19, 115)
        rbA2.Name = "rbA2"
        rbA2.Size = New Size(43, 31)
        rbA2.TabIndex = 2
        rbA2.Text = "2"
        rbA2.UseVisualStyleBackColor = True
        ' 
        ' rbA1
        ' 
        rbA1.AutoSize = True
        rbA1.Location = New Point(19, 78)
        rbA1.Name = "rbA1"
        rbA1.Size = New Size(39, 31)
        rbA1.TabIndex = 1
        rbA1.Text = "1"
        rbA1.UseVisualStyleBackColor = True
        ' 
        ' rbA0
        ' 
        rbA0.AutoSize = True
        rbA0.Checked = True
        rbA0.Location = New Point(19, 41)
        rbA0.Name = "rbA0"
        rbA0.Size = New Size(45, 31)
        rbA0.TabIndex = 0
        rbA0.TabStop = True
        rbA0.Text = "0"
        rbA0.UseVisualStyleBackColor = True
        ' 
        ' gbJunior
        ' 
        gbJunior.Controls.Add(btCalcularJunior)
        gbJunior.Controls.Add(rbJ3)
        gbJunior.Controls.Add(rbJ2)
        gbJunior.Controls.Add(rbJ1)
        gbJunior.Controls.Add(rbJ0)
        gbJunior.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        gbJunior.Location = New Point(222, 73)
        gbJunior.Name = "gbJunior"
        gbJunior.Size = New Size(163, 202)
        gbJunior.TabIndex = 5
        gbJunior.TabStop = False
        gbJunior.Text = "JUNIOR"
        ' 
        ' btCalcularJunior
        ' 
        btCalcularJunior.Font = New Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btCalcularJunior.Location = New Point(72, 148)
        btCalcularJunior.Name = "btCalcularJunior"
        btCalcularJunior.Size = New Size(85, 35)
        btCalcularJunior.TabIndex = 4
        btCalcularJunior.Text = "Calcular"
        btCalcularJunior.UseVisualStyleBackColor = True
        ' 
        ' rbJ3
        ' 
        rbJ3.AutoSize = True
        rbJ3.Location = New Point(19, 152)
        rbJ3.Name = "rbJ3"
        rbJ3.Size = New Size(41, 31)
        rbJ3.TabIndex = 3
        rbJ3.Text = "3"
        rbJ3.UseVisualStyleBackColor = True
        ' 
        ' rbJ2
        ' 
        rbJ2.AutoSize = True
        rbJ2.Location = New Point(19, 115)
        rbJ2.Name = "rbJ2"
        rbJ2.Size = New Size(43, 31)
        rbJ2.TabIndex = 2
        rbJ2.Text = "2"
        rbJ2.UseVisualStyleBackColor = True
        ' 
        ' rbJ1
        ' 
        rbJ1.AutoSize = True
        rbJ1.Location = New Point(19, 78)
        rbJ1.Name = "rbJ1"
        rbJ1.Size = New Size(39, 31)
        rbJ1.TabIndex = 1
        rbJ1.Text = "1"
        rbJ1.UseVisualStyleBackColor = True
        ' 
        ' rbJ0
        ' 
        rbJ0.AutoSize = True
        rbJ0.Checked = True
        rbJ0.Location = New Point(19, 41)
        rbJ0.Name = "rbJ0"
        rbJ0.Size = New Size(45, 31)
        rbJ0.TabIndex = 0
        rbJ0.TabStop = True
        rbJ0.Text = "0"
        rbJ0.UseVisualStyleBackColor = True
        ' 
        ' gbSenior
        ' 
        gbSenior.Controls.Add(btCalcularSenior)
        gbSenior.Controls.Add(rbS3)
        gbSenior.Controls.Add(rbS2)
        gbSenior.Controls.Add(rbS1)
        gbSenior.Controls.Add(rbS0)
        gbSenior.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        gbSenior.Location = New Point(419, 73)
        gbSenior.Name = "gbSenior"
        gbSenior.Size = New Size(163, 202)
        gbSenior.TabIndex = 6
        gbSenior.TabStop = False
        gbSenior.Text = "SENIOR"
        ' 
        ' btCalcularSenior
        ' 
        btCalcularSenior.Font = New Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btCalcularSenior.Location = New Point(72, 148)
        btCalcularSenior.Name = "btCalcularSenior"
        btCalcularSenior.Size = New Size(85, 35)
        btCalcularSenior.TabIndex = 4
        btCalcularSenior.Text = "Calcular"
        btCalcularSenior.UseVisualStyleBackColor = True
        ' 
        ' rbS3
        ' 
        rbS3.AutoSize = True
        rbS3.Location = New Point(19, 152)
        rbS3.Name = "rbS3"
        rbS3.Size = New Size(41, 31)
        rbS3.TabIndex = 3
        rbS3.Text = "3"
        rbS3.UseVisualStyleBackColor = True
        ' 
        ' rbS2
        ' 
        rbS2.AutoSize = True
        rbS2.Location = New Point(19, 115)
        rbS2.Name = "rbS2"
        rbS2.Size = New Size(43, 31)
        rbS2.TabIndex = 2
        rbS2.Text = "2"
        rbS2.UseVisualStyleBackColor = True
        ' 
        ' rbS1
        ' 
        rbS1.AutoSize = True
        rbS1.Location = New Point(19, 78)
        rbS1.Name = "rbS1"
        rbS1.Size = New Size(39, 31)
        rbS1.TabIndex = 1
        rbS1.Text = "1"
        rbS1.UseVisualStyleBackColor = True
        ' 
        ' rbS0
        ' 
        rbS0.AutoSize = True
        rbS0.Checked = True
        rbS0.Location = New Point(19, 41)
        rbS0.Name = "rbS0"
        rbS0.Size = New Size(45, 31)
        rbS0.TabIndex = 0
        rbS0.TabStop = True
        rbS0.Text = "0"
        rbS0.UseVisualStyleBackColor = True
        ' 
        ' gbInfantil
        ' 
        gbInfantil.Controls.Add(btCalcularInfantil)
        gbInfantil.Controls.Add(rbI3)
        gbInfantil.Controls.Add(rbI2)
        gbInfantil.Controls.Add(rbI1)
        gbInfantil.Controls.Add(rbI0)
        gbInfantil.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        gbInfantil.Location = New Point(612, 73)
        gbInfantil.Name = "gbInfantil"
        gbInfantil.Size = New Size(163, 202)
        gbInfantil.TabIndex = 7
        gbInfantil.TabStop = False
        gbInfantil.Text = "INFANTIL"
        ' 
        ' btCalcularInfantil
        ' 
        btCalcularInfantil.Font = New Font("Tempus Sans ITC", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btCalcularInfantil.Location = New Point(72, 148)
        btCalcularInfantil.Name = "btCalcularInfantil"
        btCalcularInfantil.Size = New Size(85, 35)
        btCalcularInfantil.TabIndex = 4
        btCalcularInfantil.Text = "Calcular"
        btCalcularInfantil.UseVisualStyleBackColor = True
        ' 
        ' rbI3
        ' 
        rbI3.AutoSize = True
        rbI3.Location = New Point(19, 152)
        rbI3.Name = "rbI3"
        rbI3.Size = New Size(41, 31)
        rbI3.TabIndex = 3
        rbI3.Text = "3"
        rbI3.UseVisualStyleBackColor = True
        ' 
        ' rbI2
        ' 
        rbI2.AutoSize = True
        rbI2.Location = New Point(19, 115)
        rbI2.Name = "rbI2"
        rbI2.Size = New Size(43, 31)
        rbI2.TabIndex = 2
        rbI2.Text = "2"
        rbI2.UseVisualStyleBackColor = True
        ' 
        ' rbI1
        ' 
        rbI1.AutoSize = True
        rbI1.Location = New Point(19, 78)
        rbI1.Name = "rbI1"
        rbI1.Size = New Size(39, 31)
        rbI1.TabIndex = 1
        rbI1.Text = "1"
        rbI1.UseVisualStyleBackColor = True
        ' 
        ' rbI0
        ' 
        rbI0.AutoSize = True
        rbI0.Checked = True
        rbI0.Location = New Point(19, 41)
        rbI0.Name = "rbI0"
        rbI0.Size = New Size(45, 31)
        rbI0.TabIndex = 0
        rbI0.TabStop = True
        rbI0.Text = "0"
        rbI0.UseVisualStyleBackColor = True
        ' 
        ' lbtextototal
        ' 
        lbtextototal.AutoSize = True
        lbtextototal.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Regular, GraphicsUnit.Point)
        lbtextototal.Location = New Point(22, 346)
        lbtextototal.Name = "lbtextototal"
        lbtextototal.Size = New Size(249, 84)
        lbtextototal.TabIndex = 8
        lbtextototal.Text = "TOTAL:"
        ' 
        ' lbAdulto
        ' 
        lbAdulto.AutoSize = True
        lbAdulto.Font = New Font("Tempus Sans ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbAdulto.Location = New Point(27, 284)
        lbAdulto.Name = "lbAdulto"
        lbAdulto.Size = New Size(0, 38)
        lbAdulto.TabIndex = 9
        ' 
        ' lbJunior
        ' 
        lbJunior.AutoSize = True
        lbJunior.Font = New Font("Tempus Sans ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbJunior.Location = New Point(227, 284)
        lbJunior.Name = "lbJunior"
        lbJunior.Size = New Size(0, 38)
        lbJunior.TabIndex = 10
        ' 
        ' lbSenior
        ' 
        lbSenior.AutoSize = True
        lbSenior.Font = New Font("Tempus Sans ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbSenior.Location = New Point(424, 284)
        lbSenior.Name = "lbSenior"
        lbSenior.Size = New Size(0, 38)
        lbSenior.TabIndex = 11
        ' 
        ' lbInfantil
        ' 
        lbInfantil.AutoSize = True
        lbInfantil.Font = New Font("Tempus Sans ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        lbInfantil.Location = New Point(617, 284)
        lbInfantil.Name = "lbInfantil"
        lbInfantil.Size = New Size(0, 38)
        lbInfantil.TabIndex = 12
        ' 
        ' lbTotal
        ' 
        lbTotal.AutoSize = True
        lbTotal.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        lbTotal.Location = New Point(277, 346)
        lbTotal.Name = "lbTotal"
        lbTotal.Size = New Size(0, 84)
        lbTotal.TabIndex = 13
        ' 
        ' btCerrar
        ' 
        btCerrar.BackColor = Color.LightCoral
        btCerrar.Font = New Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        btCerrar.Location = New Point(631, 398)
        btCerrar.Name = "btCerrar"
        btCerrar.Size = New Size(157, 40)
        btCerrar.TabIndex = 5
        btCerrar.Text = "Cerrar"
        btCerrar.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Tempus Sans ITC", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(631, 336)
        Button1.Name = "Button1"
        Button1.Size = New Size(157, 56)
        Button1.TabIndex = 14
        Button1.Text = "Calcular"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btCerrar)
        Controls.Add(lbTotal)
        Controls.Add(lbInfantil)
        Controls.Add(lbSenior)
        Controls.Add(lbJunior)
        Controls.Add(lbAdulto)
        Controls.Add(lbtextototal)
        Controls.Add(gbInfantil)
        Controls.Add(gbSenior)
        Controls.Add(gbJunior)
        Controls.Add(gbAdulto)
        Controls.Add(lbUbicaciones)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form7"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculadora de entradas"
        gbAdulto.ResumeLayout(False)
        gbAdulto.PerformLayout()
        gbJunior.ResumeLayout(False)
        gbJunior.PerformLayout()
        gbSenior.ResumeLayout(False)
        gbSenior.PerformLayout()
        gbInfantil.ResumeLayout(False)
        gbInfantil.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbUbicaciones As Label
    Friend WithEvents gbAdulto As GroupBox
    Friend WithEvents rbA3 As RadioButton
    Friend WithEvents rbA2 As RadioButton
    Friend WithEvents rbA1 As RadioButton
    Friend WithEvents rbA0 As RadioButton
    Friend WithEvents btCalcularAdulto As Button
    Friend WithEvents gbJunior As GroupBox
    Friend WithEvents btCalcularJunior As Button
    Friend WithEvents rbJ3 As RadioButton
    Friend WithEvents rbJ2 As RadioButton
    Friend WithEvents rbJ1 As RadioButton
    Friend WithEvents rbJ0 As RadioButton
    Friend WithEvents gbSenior As GroupBox
    Friend WithEvents btCalcularSenior As Button
    Friend WithEvents rbS3 As RadioButton
    Friend WithEvents rbS2 As RadioButton
    Friend WithEvents rbS1 As RadioButton
    Friend WithEvents rbS0 As RadioButton
    Friend WithEvents gbInfantil As GroupBox
    Friend WithEvents btCalcularInfantil As Button
    Friend WithEvents rbI3 As RadioButton
    Friend WithEvents rbI2 As RadioButton
    Friend WithEvents rbI1 As RadioButton
    Friend WithEvents rbI0 As RadioButton
    Friend WithEvents lbtextototal As Label
    Friend WithEvents lbAdulto As Label
    Friend WithEvents lbJunior As Label
    Friend WithEvents lbSenior As Label
    Friend WithEvents lbInfantil As Label
    Friend WithEvents lbTotal As Label
    Friend WithEvents btCerrar As Button
    Friend WithEvents Button1 As Button
End Class
