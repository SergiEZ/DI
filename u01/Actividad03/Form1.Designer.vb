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
        Label2 = New Label()
        Label1 = New Label()
        TabPage2 = New TabPage()
        ToolStrip1 = New ToolStrip()
        ToolStripButton = New ToolStripButton()
        ToolStripLabel = New ToolStripLabel()
        PictureBox1 = New PictureBox()
        TabControl.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        ToolStrip1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TabControl
        ' 
        TabControl.Controls.Add(TabPage1)
        TabControl.Controls.Add(TabPage2)
        TabControl.Location = New Point(12, 28)
        TabControl.Name = "TabControl"
        TabControl.SelectedIndex = 0
        TabControl.Size = New Size(776, 414)
        TabControl.TabIndex = 0
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label1)
        TabPage1.Location = New Point(4, 24)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(768, 386)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 24)
        Label2.Name = "Label2"
        Label2.Size = New Size(285, 21)
        Label2.TabIndex = 1
        Label2.Text = "En esta pestaña hay botones y etiquetas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(6, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(151, 21)
        Label1.TabIndex = 0
        Label1.Text = "Hola, figura mundial"
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(PictureBox1)
        TabPage2.Location = New Point(4, 24)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(768, 386)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton, ToolStripLabel})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(800, 25)
        ToolStrip1.TabIndex = 1
        ToolStrip1.Text = "ToolStrip1"
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
        ' ToolStripLabel
        ' 
        ToolStripLabel.Name = "ToolStripLabel"
        ToolStripLabel.Size = New Size(69, 22)
        ToolStripLabel.Text = "Botón inútil"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), Image)
        PictureBox1.Location = New Point(43, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(237, 166)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(ToolStrip1)
        Controls.Add(TabControl)
        Name = "Form1"
        Text = "Form1"
        TabControl.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel As ToolStripLabel
    Friend WithEvents PictureBox1 As PictureBox
End Class
