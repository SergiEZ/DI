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
        lbPrimero = New Label()
        tbPrimero = New TextBox()
        tbSegundo = New TextBox()
        lbSegundo = New Label()
        Label1 = New Label()
        lbResultado = New Label()
        btResultado = New Button()
        btCerrar = New Button()
        SuspendLayout()
        ' 
        ' lbPrimero
        ' 
        lbPrimero.AutoSize = True
        lbPrimero.Location = New Point(25, 31)
        lbPrimero.Name = "lbPrimero"
        lbPrimero.Size = New Size(159, 30)
        lbPrimero.TabIndex = 0
        lbPrimero.Text = "Primer número"
        ' 
        ' tbPrimero
        ' 
        tbPrimero.Location = New Point(25, 68)
        tbPrimero.Name = "tbPrimero"
        tbPrimero.Size = New Size(182, 36)
        tbPrimero.TabIndex = 1
        ' 
        ' tbSegundo
        ' 
        tbSegundo.Location = New Point(25, 209)
        tbSegundo.Name = "tbSegundo"
        tbSegundo.Size = New Size(182, 36)
        tbSegundo.TabIndex = 3
        ' 
        ' lbSegundo
        ' 
        lbSegundo.AutoSize = True
        lbSegundo.Location = New Point(25, 172)
        lbSegundo.Name = "lbSegundo"
        lbSegundo.Size = New Size(182, 30)
        lbSegundo.TabIndex = 2
        lbSegundo.Text = "Segundo número"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 30)
        Label1.TabIndex = 4
        Label1.Text = "+"
        ' 
        ' lbResultado
        ' 
        lbResultado.AutoSize = True
        lbResultado.Location = New Point(25, 279)
        lbResultado.Name = "lbResultado"
        lbResultado.Size = New Size(0, 30)
        lbResultado.TabIndex = 5
        ' 
        ' btResultado
        ' 
        btResultado.Location = New Point(29, 333)
        btResultado.Name = "btResultado"
        btResultado.Size = New Size(142, 62)
        btResultado.TabIndex = 6
        btResultado.Text = "Resultado"
        btResultado.UseVisualStyleBackColor = True
        ' 
        ' btCerrar
        ' 
        btCerrar.Location = New Point(306, 333)
        btCerrar.Name = "btCerrar"
        btCerrar.Size = New Size(142, 62)
        btCerrar.TabIndex = 7
        btCerrar.Text = "Cerrar"
        btCerrar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(12F, 30F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(484, 411)
        Controls.Add(btCerrar)
        Controls.Add(btResultado)
        Controls.Add(lbResultado)
        Controls.Add(Label1)
        Controls.Add(tbSegundo)
        Controls.Add(lbSegundo)
        Controls.Add(tbPrimero)
        Controls.Add(lbPrimero)
        Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(5, 6, 5, 6)
        Name = "Form1"
        Text = "Calculadora Simple"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbPrimero As Label
    Friend WithEvents tbPrimero As TextBox
    Friend WithEvents tbSegundo As TextBox
    Friend WithEvents lbSegundo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbResultado As Label
    Friend WithEvents btResultado As Button
    Friend WithEvents btCerrar As Button
End Class
