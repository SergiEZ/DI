<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen1
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
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents MainLayoutPanel As TableLayoutPanel

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SplashScreen1))
        MainLayoutPanel = New TableLayoutPanel()
        Copyright = New Label()
        Version = New Label()
        DetailsLayoutPanel = New TableLayoutPanel()
        ProgressBar1 = New ProgressBar()
        ApplicationTitle = New Label()
        Timer1 = New Timer(components)
        MainLayoutPanel.SuspendLayout()
        DetailsLayoutPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' MainLayoutPanel
        ' 
        MainLayoutPanel.BackColor = SystemColors.ActiveCaption
        MainLayoutPanel.BackgroundImage = CType(resources.GetObject("MainLayoutPanel.BackgroundImage"), Image)
        MainLayoutPanel.BackgroundImageLayout = ImageLayout.Zoom
        MainLayoutPanel.ColumnCount = 2
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 243F))
        MainLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 100F))
        MainLayoutPanel.Controls.Add(Copyright, 0, 0)
        MainLayoutPanel.Controls.Add(Version, 1, 0)
        MainLayoutPanel.Controls.Add(DetailsLayoutPanel, 1, 1)
        MainLayoutPanel.Controls.Add(ApplicationTitle, 0, 1)
        MainLayoutPanel.Dock = DockStyle.Fill
        MainLayoutPanel.Location = New Point(0, 0)
        MainLayoutPanel.Name = "MainLayoutPanel"
        MainLayoutPanel.RowCount = 2
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 218F))
        MainLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Absolute, 38F))
        MainLayoutPanel.Size = New Size(496, 303)
        MainLayoutPanel.TabIndex = 0
        ' 
        ' Copyright
        ' 
        Copyright.Anchor = AnchorStyles.None
        Copyright.BackColor = Color.Transparent
        Copyright.Font = New Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Copyright.ForeColor = Color.IndianRed
        Copyright.Location = New Point(3, 89)
        Copyright.Name = "Copyright"
        Copyright.Size = New Size(237, 40)
        Copyright.TabIndex = 2
        Copyright.Text = "Copyright DI 2023"
        Copyright.Visible = False
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Version.ForeColor = SystemColors.MenuHighlight
        Version.Location = New Point(249, 99)
        Version.Name = "Version"
        Version.Size = New Size(241, 20)
        Version.TabIndex = 1
        Version.Text = "Versión {0}.{1:00}"
        Version.Visible = False
        ' 
        ' DetailsLayoutPanel
        ' 
        DetailsLayoutPanel.Anchor = AnchorStyles.None
        DetailsLayoutPanel.BackColor = Color.Transparent
        DetailsLayoutPanel.ColumnCount = 1
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 142F))
        DetailsLayoutPanel.Controls.Add(ProgressBar1, 0, 1)
        DetailsLayoutPanel.Enabled = False
        DetailsLayoutPanel.Location = New Point(246, 221)
        DetailsLayoutPanel.Name = "DetailsLayoutPanel"
        DetailsLayoutPanel.RowCount = 2
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 33F))
        DetailsLayoutPanel.Size = New Size(247, 79)
        DetailsLayoutPanel.TabIndex = 1
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(3, 42)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(143, 23)
        ProgressBar1.TabIndex = 0
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Yellow
        ApplicationTitle.Font = New Font("MS PGothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        ApplicationTitle.Location = New Point(14, 240)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(214, 40)
        ApplicationTitle.TabIndex = 0
        ApplicationTitle.Text = "Actividad 13"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' SplashScreen1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(496, 303)
        ControlBox = False
        Controls.Add(MainLayoutPanel)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "SplashScreen1"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        MainLayoutPanel.ResumeLayout(False)
        DetailsLayoutPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents DetailsLayoutPanel As TableLayoutPanel
    Friend WithEvents Version As Label
    Friend WithEvents Copyright As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
