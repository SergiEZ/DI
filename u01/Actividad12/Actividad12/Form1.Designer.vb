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
        Label1 = New Label()
        Label2 = New Label()
        tbInsert = New TextBox()
        tbLetras = New TextBox()
        tbNumeros = New TextBox()
        tbOtros = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        btSubmit = New Button()
        btLimpiar = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 21)
        Label1.TabIndex = 0
        Label1.Text = "Inserte Texto para Clasificar:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(15, 262)
        Label2.Name = "Label2"
        Label2.Size = New Size(55, 21)
        Label2.TabIndex = 1
        Label2.Text = "Letras:"
        ' 
        ' tbInsert
        ' 
        tbInsert.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tbInsert.Location = New Point(15, 44)
        tbInsert.Multiline = True
        tbInsert.Name = "tbInsert"
        tbInsert.Size = New Size(530, 150)
        tbInsert.TabIndex = 2
        ' 
        ' tbLetras
        ' 
        tbLetras.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tbLetras.Location = New Point(12, 286)
        tbLetras.Multiline = True
        tbLetras.Name = "tbLetras"
        tbLetras.Size = New Size(530, 35)
        tbLetras.TabIndex = 3
        ' 
        ' tbNumeros
        ' 
        tbNumeros.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tbNumeros.Location = New Point(12, 357)
        tbNumeros.Multiline = True
        tbNumeros.Name = "tbNumeros"
        tbNumeros.Size = New Size(530, 35)
        tbNumeros.TabIndex = 4
        ' 
        ' tbOtros
        ' 
        tbOtros.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        tbOtros.Location = New Point(12, 427)
        tbOtros.Multiline = True
        tbOtros.Name = "tbOtros"
        tbOtros.Size = New Size(530, 35)
        tbOtros.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(15, 333)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 21)
        Label3.TabIndex = 6
        Label3.Text = "Números:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(15, 403)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 21)
        Label4.TabIndex = 7
        Label4.Text = "Otros:"
        ' 
        ' btSubmit
        ' 
        btSubmit.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        btSubmit.Location = New Point(12, 204)
        btSubmit.Name = "btSubmit"
        btSubmit.Size = New Size(169, 48)
        btSubmit.TabIndex = 8
        btSubmit.Text = "Submit"
        btSubmit.UseVisualStyleBackColor = True
        ' 
        ' btLimpiar
        ' 
        btLimpiar.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        btLimpiar.Location = New Point(376, 204)
        btLimpiar.Name = "btLimpiar"
        btLimpiar.Size = New Size(169, 48)
        btLimpiar.TabIndex = 9
        btLimpiar.Text = "Limpiar"
        btLimpiar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(557, 478)
        Controls.Add(btLimpiar)
        Controls.Add(btSubmit)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(tbOtros)
        Controls.Add(tbNumeros)
        Controls.Add(tbLetras)
        Controls.Add(tbInsert)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = " ASCII"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbInsert As TextBox
    Friend WithEvents tbLetras As TextBox
    Friend WithEvents tbNumeros As TextBox
    Friend WithEvents tbOtros As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btSubmit As Button
    Friend WithEvents btLimpiar As Button
End Class
