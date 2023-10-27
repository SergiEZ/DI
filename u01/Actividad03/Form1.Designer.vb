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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl = New TabControl()
        TabPage1 = New TabPage()
        cbComida = New ComboBox()
        btEnviar = New Button()
        btBorrar = New Button()
        lbElige = New Label()
        lbSaludo = New Label()
        TabPage2 = New TabPage()
        rbNinguno = New RadioButton()
        rbAmbos = New RadioButton()
        rbMujer = New RadioButton()
        rbHombre = New RadioButton()
        tbCiudad = New TextBox()
        tbApe2 = New TextBox()
        tbApe1 = New TextBox()
        tbNombre = New TextBox()
        TabPage3 = New TabPage()
        pbShrek = New PictureBox()
        TabPage4 = New TabPage()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel = New ToolStripLabel()
        ToolStripButton = New ToolStripButton()
        ToolStripTextBox1 = New ToolStripTextBox()
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        CType(pbShrek, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Controls.Add(TabPage3)
        TabControl.Controls.Add(TabPage4)
        TabControl.Location = New Point(12, 28)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(457, 414)
        TabControl.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(cbComida)
        TabPage1.Controls.Add(btEnviar)
        TabPage1.Controls.Add(btBorrar)
        TabPage1.Controls.Add(lbElige)
        TabPage1.Controls.Add(lbSaludo)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(449, 386)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Comida"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' cbComida
        ' 
        cbComida.Cursor = Cursors.AppStarting
        cbComida.DropDownStyle = ComboBoxStyle.DropDownList
        cbComida.Items.AddRange(New Object() {"Bollycao", "Colacao", "Tomacao", "Matutano", "Pacquiao", "Agua con gas"})
        cbComida.Location = New Point(143, 114)
        cbComida.Name = "cbComida"
        cbComida.Size = New Size(150, 23)
        cbComida.TabIndex = 4
        ' 
        ' btEnviar
        ' 
        btEnviar.Font = New Font("Segoe UI", 24.0F, FontStyle.Regular, GraphicsUnit.Point)
        btEnviar.ForeColor = SystemColors.HotTrack
        btEnviar.Location = New Point(105, 266)
        btEnviar.Name = "btEnviar"
        btEnviar.Size = New Size(220, 114)
        btEnviar.TabIndex = 3
        btEnviar.Text = "Enviar"
        btEnviar.UseVisualStyleBackColor = True
        ' 
        ' btBorrar
        ' 
        btBorrar.BackColor = Color.IndianRed
        btBorrar.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        btBorrar.Location = New Point(143, 217)
        btBorrar.Name = "btBorrar"
        btBorrar.Size = New Size(151, 43)
        btBorrar.TabIndex = 2
        btBorrar.Text = "Borrar"
        btBorrar.UseVisualStyleBackColor = False
        ' 
        ' lbElige
        ' 
        lbElige.AutoSize = True
        lbElige.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lbElige.Location = New Point(131, 43)
        lbElige.Name = "lbElige"
        lbElige.Size = New Size(173, 21)
        lbElige.TabIndex = 1
        lbElige.Text = "Elige tu comida favorita"
        ' 
        ' lbSaludo
        ' 
        lbSaludo.AutoSize = True
        lbSaludo.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
        lbSaludo.Location = New Point(143, 12)
        lbSaludo.Name = "lbSaludo"
        lbSaludo.Size = New Size(151, 21)
        lbSaludo.TabIndex = 0
        lbSaludo.Text = "Hola, figura mundial"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(rbNinguno)
        TabPage2.Controls.Add(rbAmbos)
        TabPage2.Controls.Add(rbMujer)
        TabPage2.Controls.Add(rbHombre)
        TabPage2.Controls.Add(tbCiudad)
        TabPage2.Controls.Add(tbApe2)
        TabPage2.Controls.Add(tbApe1)
        TabPage2.Controls.Add(tbNombre)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(449, 386)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Datos"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' rbNinguno
        ' 
        rbNinguno.AutoSize = True
        rbNinguno.Location = New Point(46, 253)
        rbNinguno.Name = "rbNinguno"
        rbNinguno.Size = New Size(72, 19)
        rbNinguno.TabIndex = 8
        rbNinguno.TabStop = True
        rbNinguno.Text = "Ninguno"
        rbNinguno.UseVisualStyleBackColor = True
        ' 
        ' rbAmbos
        ' 
        rbAmbos.AutoSize = True
        rbAmbos.Location = New Point(46, 228)
        rbAmbos.Name = "rbAmbos"
        rbAmbos.Size = New Size(63, 19)
        rbAmbos.TabIndex = 7
        rbAmbos.TabStop = True
        rbAmbos.Text = "Ambos"
        rbAmbos.UseVisualStyleBackColor = True
        ' 
        ' rbMujer
        ' 
        rbMujer.AutoSize = True
        rbMujer.Location = New Point(46, 203)
        rbMujer.Name = "rbMujer"
        rbMujer.Size = New Size(56, 19)
        rbMujer.TabIndex = 6
        rbMujer.TabStop = True
        rbMujer.Text = "Mujer"
        rbMujer.UseVisualStyleBackColor = True
        ' 
        ' rbHombre
        ' 
        rbHombre.AutoSize = True
        rbHombre.Location = New Point(46, 178)
        rbHombre.Name = "rbHombre"
        rbHombre.Size = New Size(69, 19)
        rbHombre.TabIndex = 5
        rbHombre.TabStop = True
        rbHombre.Text = "Hombre"
        rbHombre.UseVisualStyleBackColor = True
        ' 
        ' tbCiudad
        ' 
        tbCiudad.Location = New Point(36, 115)
        tbCiudad.Name = "tbCiudad"
        tbCiudad.PlaceholderText = "Ciudad"
        tbCiudad.Size = New Size(158, 23)
        tbCiudad.TabIndex = 4
        ' 
        ' tbApe2
        ' 
        tbApe2.Location = New Point(36, 86)
        tbApe2.Name = "tbApe2"
        tbApe2.PlaceholderText = "Apellido 2"
        tbApe2.Size = New Size(158, 23)
        tbApe2.TabIndex = 3
        ' 
        ' tbApe1
        ' 
        tbApe1.Location = New Point(36, 57)
        tbApe1.Name = "tbApe1"
        tbApe1.PlaceholderText = "Apellido 1"
        tbApe1.Size = New Size(158, 23)
        tbApe1.TabIndex = 2
        ' 
        ' tbNombre
        ' 
        tbNombre.Location = New Point(36, 28)
        tbNombre.Name = "tbNombre"
        tbNombre.PlaceholderText = "Nombre"
        tbNombre.Size = New Size(158, 23)
        tbNombre.TabIndex = 1
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(pbShrek)
        TabPage3.Location = New Point(4, 24)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(449, 386)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Imagen"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' pbShrek
        ' 
        pbShrek.Image = My.Resources.Resources.shrek4_disneyscreencaps_com_675_0
        pbShrek.Location = New Point(0, 0)
        pbShrek.Name = "pbShrek"
        pbShrek.Size = New Size(448, 385)
        pbShrek.TabIndex = 0
        pbShrek.TabStop = False
        ' 
        ' TabPage4
        ' 
        TabPage4.BackColor = Color.Turquoise
        TabPage4.Location = New Point(4, 24)
        TabPage4.Name = "TabPage4"
        TabPage4.Padding = New Padding(3)
        TabPage4.RightToLeft = RightToLeft.No
        TabPage4.Size = New Size(449, 386)
        TabPage4.TabIndex = 3
        TabPage4.Text = "Azul"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel, ToolStripButton, ToolStripTextBox1})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(476, 25)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel
        ' 
        ToolStripLabel.Name = "ToolStripLabel"
        ToolStripLabel.Size = New Size(85, 22)
        ToolStripLabel.Text = "Botón inútil ->"
        ' 
        ' ToolStripButton
        ' 
        ToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton.Image = CType(resources.GetObject("ToolStripButton.Image"), Image)
        ToolStripButton.ImageTransparentColor = Color.Magenta
        ToolStripButton.Name = "ToolStripButton"
        ToolStripButton.Size = New Size(23, 22)
        ToolStripButton.Text = "ToolStripButton1"
        ' 
        ' ToolStripTextBox1
        ' 
        ToolStripTextBox1.Name = "ToolStripTextBox1"
        ToolStripTextBox1.Size = New Size(100, 25)
        ToolStripTextBox1.Text = "DI"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(476, 450)
        Controls.Add(ToolStrip1)
        Controls.Add(TabControl)
        Name = "Form1"
        Text = "Interfaz Increíble"
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        TabPage3.ResumeLayout(False)
        CType(pbShrek, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents lbSaludo As Label
    Friend WithEvents lbElige As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel As ToolStripLabel
    Friend WithEvents btBorrar As Button
    Friend WithEvents btEnviar As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents cbComida As ComboBox
    Friend WithEvents pbShrek As PictureBox
    Friend WithEvents tbCiudad As TextBox
    Friend WithEvents tbApe2 As TextBox
    Friend WithEvents tbApe1 As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents rbNinguno As RadioButton
    Friend WithEvents rbAmbos As RadioButton
    Friend WithEvents rbMujer As RadioButton
    Friend WithEvents rbHombre As RadioButton
End Class
