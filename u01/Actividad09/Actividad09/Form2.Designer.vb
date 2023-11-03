<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        lbForm2 = New Label()
        btAdd = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' lbForm2
        ' 
        lbForm2.AutoSize = True
        lbForm2.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        lbForm2.Location = New Point(29, 33)
        lbForm2.Name = "lbForm2"
        lbForm2.Size = New Size(213, 45)
        lbForm2.TabIndex = 1
        lbForm2.Text = "Formulario 2"
        ' 
        ' btAdd
        ' 
        btAdd.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        btAdd.Location = New Point(63, 95)
        btAdd.Name = "btAdd"
        btAdd.Size = New Size(139, 65)
        btAdd.TabIndex = 2
        btAdd.Text = "Añadir"
        btAdd.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(99, 166)
        Button1.Name = "Button1"
        Button1.Size = New Size(62, 65)
        Button1.TabIndex = 3
        Button1.Text = "🗑️"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(270, 255)
        Controls.Add(Button1)
        Controls.Add(btAdd)
        Controls.Add(lbForm2)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbForm2 As Label
    Friend WithEvents btAdd As Button
    Friend WithEvents Button1 As Button
End Class
