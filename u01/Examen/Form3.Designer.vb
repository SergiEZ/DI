<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form3))
        Label1 = New Label()
        Label2 = New Label()
        pbVamos = New PictureBox()
        CType(pbVamos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tempus Sans ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(193, 100)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 38)
        Label1.TabIndex = 0
        Label1.Text = "¿Te gustan las emociones fuertes?"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tempus Sans ITC", 21.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(332, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(157, 38)
        Label2.TabIndex = 1
        Label2.Text = "Únete jajaja"
        ' 
        ' pbVamos
        ' 
        pbVamos.BackgroundImage = My.Resources.Resources.vamos
        pbVamos.BackgroundImageLayout = ImageLayout.Zoom
        pbVamos.Location = New Point(243, 287)
        pbVamos.Name = "pbVamos"
        pbVamos.Size = New Size(321, 151)
        pbVamos.TabIndex = 2
        pbVamos.TabStop = False
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pbVamos)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Información sobre el parque"
        CType(pbVamos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pbVamos As PictureBox
End Class
