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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form2))
        msPrincipal = New MenuStrip()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripMenuItem2 = New ToolStripMenuItem()
        ToolStripMenuItem3 = New ToolStripMenuItem()
        ToolStripMenuItem4 = New ToolStripMenuItem()
        IntroduccionToolStripMenuItem = New ToolStripMenuItem()
        PreciosToolStripMenuItem = New ToolStripMenuItem()
        CalculaTuEntradaToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem5 = New ToolStripMenuItem()
        PictureBox1 = New PictureBox()
        msPrincipal.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' msPrincipal
        ' 
        msPrincipal.Items.AddRange(New ToolStripItem() {ToolStripMenuItem1, IntroduccionToolStripMenuItem, ToolStripMenuItem5})
        msPrincipal.Location = New Point(0, 0)
        msPrincipal.Name = "msPrincipal"
        msPrincipal.Size = New Size(1155, 32)
        msPrincipal.TabIndex = 0
        msPrincipal.Text = "MenuStrip1"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {ToolStripMenuItem2, ToolStripMenuItem3, ToolStripMenuItem4})
        ToolStripMenuItem1.Font = New Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(128, 28)
        ToolStripMenuItem1.Text = "&Introducción"
        ' 
        ' ToolStripMenuItem2
        ' 
        ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        ToolStripMenuItem2.ShortcutKeyDisplayString = "Ctrl + P"
        ToolStripMenuItem2.Size = New Size(250, 28)
        ToolStripMenuItem2.Text = "Parque"
        ' 
        ' ToolStripMenuItem3
        ' 
        ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        ToolStripMenuItem3.ShortcutKeyDisplayString = "Ctrl + H"
        ToolStripMenuItem3.Size = New Size(250, 28)
        ToolStripMenuItem3.Text = "Historia"
        ' 
        ' ToolStripMenuItem4
        ' 
        ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        ToolStripMenuItem4.ShortcutKeyDisplayString = "Ctrl + U"
        ToolStripMenuItem4.Size = New Size(250, 28)
        ToolStripMenuItem4.Text = "Ubicaciones"
        ' 
        ' IntroduccionToolStripMenuItem
        ' 
        IntroduccionToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PreciosToolStripMenuItem, CalculaTuEntradaToolStripMenuItem})
        IntroduccionToolStripMenuItem.Font = New Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        IntroduccionToolStripMenuItem.Name = "IntroduccionToolStripMenuItem"
        IntroduccionToolStripMenuItem.Size = New Size(89, 28)
        IntroduccionToolStripMenuItem.Text = "&Entradas"
        ' 
        ' PreciosToolStripMenuItem
        ' 
        PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        PreciosToolStripMenuItem.ShortcutKeyDisplayString = "Alt + E"
        PreciosToolStripMenuItem.Size = New Size(293, 28)
        PreciosToolStripMenuItem.Text = "Precios"
        ' 
        ' CalculaTuEntradaToolStripMenuItem
        ' 
        CalculaTuEntradaToolStripMenuItem.Name = "CalculaTuEntradaToolStripMenuItem"
        CalculaTuEntradaToolStripMenuItem.ShortcutKeyDisplayString = "Alt + C"
        CalculaTuEntradaToolStripMenuItem.Size = New Size(293, 28)
        CalculaTuEntradaToolStripMenuItem.Text = "Calcula tu entrada"
        ' 
        ' ToolStripMenuItem5
        ' 
        ToolStripMenuItem5.Font = New Font("Tempus Sans ITC", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        ToolStripMenuItem5.Size = New Size(100, 28)
        ToolStripMenuItem5.Text = "&Acerca de"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = My.Resources.Resources.cerrar
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(1093, 614)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(50, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.fondo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1155, 676)
        Controls.Add(PictureBox1)
        Controls.Add(msPrincipal)
        Font = New Font("Tempus Sans ITC", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = msPrincipal
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pantalla Principal"
        msPrincipal.ResumeLayout(False)
        msPrincipal.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents msPrincipal As MenuStrip
    Friend WithEvents IntroduccionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculaTuEntradaToolStripMenuItem As ToolStripMenuItem
End Class
