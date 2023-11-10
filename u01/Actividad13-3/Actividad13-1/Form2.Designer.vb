<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAyuda
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(formAyuda))
        TextBox1 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(12, 12)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Horizontal
        TextBox1.Size = New Size(403, 364)
        TextBox1.TabIndex = 0
        TextBox1.Text = resources.GetString("TextBox1.Text")
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(161, 397)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 28)
        Button1.TabIndex = 1
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' formAyuda
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(427, 441)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Name = "formAyuda"
        Text = "Actividad13 Help"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
End Class
