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
        lbWelcome = New Label()
        lbWelcome2 = New Label()
        lbWelcome3 = New Label()
        Button1 = New Button()
        btCerrar = New PictureBox()
        CType(btCerrar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbWelcome
        ' 
        lbWelcome.AutoSize = True
        lbWelcome.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lbWelcome.ForeColor = SystemColors.ControlText
        lbWelcome.Location = New Point(121, 110)
        lbWelcome.Name = "lbWelcome"
        lbWelcome.Size = New Size(779, 84)
        lbWelcome.TabIndex = 0
        lbWelcome.Text = "Bienvenidos a la aplicación "
        ' 
        ' lbWelcome2
        ' 
        lbWelcome2.AutoSize = True
        lbWelcome2.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lbWelcome2.ForeColor = SystemColors.ControlText
        lbWelcome2.Location = New Point(12, 194)
        lbWelcome2.Name = "lbWelcome2"
        lbWelcome2.Size = New Size(988, 84)
        lbWelcome2.TabIndex = 1
        lbWelcome2.Text = "oficial del parque de atracciones de"
        ' 
        ' lbWelcome3
        ' 
        lbWelcome3.AutoSize = True
        lbWelcome3.Font = New Font("Tempus Sans ITC", 48F, FontStyle.Bold, GraphicsUnit.Point)
        lbWelcome3.ForeColor = SystemColors.ControlText
        lbWelcome3.Location = New Point(236, 278)
        lbWelcome3.Name = "lbWelcome3"
        lbWelcome3.Size = New Size(550, 84)
        lbWelcome3.TabIndex = 2
        lbWelcome3.Text = "PORTAVENTURA"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.OrangeRed
        Button1.Font = New Font("Tempus Sans ITC", 26.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ButtonFace
        Button1.Location = New Point(328, 398)
        Button1.Name = "Button1"
        Button1.Size = New Size(357, 108)
        Button1.TabIndex = 3
        Button1.Text = "Pulsa para Entrar"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btCerrar
        ' 
        btCerrar.BackgroundImage = My.Resources.Resources.cerrar
        btCerrar.BackgroundImageLayout = ImageLayout.Stretch
        btCerrar.Location = New Point(966, 538)
        btCerrar.Name = "btCerrar"
        btCerrar.Size = New Size(50, 50)
        btCerrar.SizeMode = PictureBoxSizeMode.AutoSize
        btCerrar.TabIndex = 5
        btCerrar.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1028, 600)
        Controls.Add(btCerrar)
        Controls.Add(Button1)
        Controls.Add(lbWelcome3)
        Controls.Add(lbWelcome2)
        Controls.Add(lbWelcome)
        Font = New Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Bienvenidos"
        CType(btCerrar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbWelcome As Label
    Friend WithEvents lbWelcome2 As Label
    Friend WithEvents lbWelcome3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btCerrar As PictureBox
End Class
