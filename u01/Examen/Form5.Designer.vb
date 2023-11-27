<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form5))
        lbUbicaciones = New Label()
        GroupBox1 = New GroupBox()
        rb4 = New RadioButton()
        rb3 = New RadioButton()
        rb2 = New RadioButton()
        rb1 = New RadioButton()
        pbMapa = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(pbMapa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbUbicaciones
        ' 
        lbUbicaciones.AutoSize = True
        lbUbicaciones.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lbUbicaciones.ForeColor = SystemColors.ControlText
        lbUbicaciones.Location = New Point(12, 9)
        lbUbicaciones.Name = "lbUbicaciones"
        lbUbicaciones.Size = New Size(382, 84)
        lbUbicaciones.TabIndex = 1
        lbUbicaciones.Text = "Ubicaciones:"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rb4)
        GroupBox1.Controls.Add(rb3)
        GroupBox1.Controls.Add(rb2)
        GroupBox1.Controls.Add(rb1)
        GroupBox1.Font = New Font("Tempus Sans ITC", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        GroupBox1.Location = New Point(30, 96)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(305, 316)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        GroupBox1.Text = "Lugares"
        ' 
        ' rb4
        ' 
        rb4.AutoSize = True
        rb4.Location = New Point(19, 250)
        rb4.Name = "rb4"
        rb4.Size = New Size(98, 31)
        rb4.TabIndex = 3
        rb4.Text = "Siuuuu"
        rb4.UseVisualStyleBackColor = True
        ' 
        ' rb3
        ' 
        rb3.AutoSize = True
        rb3.Location = New Point(19, 177)
        rb3.Name = "rb3"
        rb3.Size = New Size(103, 31)
        rb3.TabIndex = 2
        rb3.Text = "Jjajajaja"
        rb3.UseVisualStyleBackColor = True
        ' 
        ' rb2
        ' 
        rb2.AutoSize = True
        rb2.Location = New Point(19, 106)
        rb2.Name = "rb2"
        rb2.Size = New Size(139, 31)
        rb2.TabIndex = 1
        rb2.Text = "Fortinaiti 2"
        rb2.UseVisualStyleBackColor = True
        ' 
        ' rb1
        ' 
        rb1.AutoSize = True
        rb1.Checked = True
        rb1.Location = New Point(19, 41)
        rb1.Name = "rb1"
        rb1.Size = New Size(156, 31)
        rb1.TabIndex = 0
        rb1.TabStop = True
        rb1.Text = "Portaventura"
        rb1.UseVisualStyleBackColor = True
        ' 
        ' pbMapa
        ' 
        pbMapa.BackgroundImage = My.Resources.Resources.mapa1
        pbMapa.BackgroundImageLayout = ImageLayout.Zoom
        pbMapa.Location = New Point(363, 109)
        pbMapa.Name = "pbMapa"
        pbMapa.Size = New Size(416, 303)
        pbMapa.TabIndex = 3
        pbMapa.TabStop = False
        ' 
        ' Form5
        ' 
        AutoScaleMode = AutoScaleMode.None
        ClientSize = New Size(800, 450)
        Controls.Add(pbMapa)
        Controls.Add(GroupBox1)
        Controls.Add(lbUbicaciones)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form5"
        Text = "Benidorm"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(pbMapa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbUbicaciones As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rb4 As RadioButton
    Friend WithEvents rb3 As RadioButton
    Friend WithEvents rb2 As RadioButton
    Friend WithEvents rb1 As RadioButton
    Friend WithEvents pbMapa As PictureBox
End Class
