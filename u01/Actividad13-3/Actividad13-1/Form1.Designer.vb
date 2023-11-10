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
        GroupBox1 = New GroupBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        rbNumbers = New RadioButton()
        rbAll = New RadioButton()
        rbLetters = New RadioButton()
        btQuit = New Button()
        lbUpper = New Label()
        lbNumber = New Label()
        lbLower = New Label()
        lbU = New Label()
        lbN = New Label()
        lbL = New Label()
        btBackground = New Button()
        btFont = New Button()
        ColorDialog1 = New ColorDialog()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        QuitToolStripMenuItem = New ToolStripMenuItem()
        ColorToolStripMenuItem = New ToolStripMenuItem()
        BackgroundColorToolStripMenuItem1 = New ToolStripMenuItem()
        FontColorToolStripMenuItem1 = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        ViewHelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        GroupBox1.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(rbNumbers)
        GroupBox1.Controls.Add(rbAll)
        GroupBox1.Controls.Add(rbLetters)
        GroupBox1.Location = New Point(23, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(285, 149)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(145, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(42, 21)
        Label3.TabIndex = 5
        Label3.Text = "0 - 9"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(145, 67)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 21)
        Label2.TabIndex = 4
        Label2.Text = "A - Z, 0 - 9"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(145, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 21)
        Label1.TabIndex = 3
        Label1.Text = "A - Z"
        ' 
        ' rbNumbers
        ' 
        rbNumbers.AutoSize = True
        rbNumbers.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rbNumbers.Location = New Point(6, 110)
        rbNumbers.Name = "rbNumbers"
        rbNumbers.Size = New Size(96, 25)
        rbNumbers.TabIndex = 2
        rbNumbers.TabStop = True
        rbNumbers.Text = "Numbers:"
        rbNumbers.UseVisualStyleBackColor = True
        ' 
        ' rbAll
        ' 
        rbAll.AutoSize = True
        rbAll.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rbAll.Location = New Point(6, 67)
        rbAll.Name = "rbAll"
        rbAll.Size = New Size(49, 25)
        rbAll.TabIndex = 1
        rbAll.TabStop = True
        rbAll.Text = "All:"
        rbAll.UseVisualStyleBackColor = True
        ' 
        ' rbLetters
        ' 
        rbLetters.AutoSize = True
        rbLetters.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rbLetters.Location = New Point(6, 22)
        rbLetters.Name = "rbLetters"
        rbLetters.Size = New Size(78, 25)
        rbLetters.TabIndex = 0
        rbLetters.TabStop = True
        rbLetters.Text = "Letters:"
        rbLetters.UseVisualStyleBackColor = True
        ' 
        ' btQuit
        ' 
        btQuit.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btQuit.Location = New Point(386, 261)
        btQuit.Name = "btQuit"
        btQuit.Size = New Size(88, 38)
        btQuit.TabIndex = 1
        btQuit.Text = "Quit"
        btQuit.UseVisualStyleBackColor = True
        ' 
        ' lbUpper
        ' 
        lbUpper.AutoSize = True
        lbUpper.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbUpper.Location = New Point(23, 201)
        lbUpper.Name = "lbUpper"
        lbUpper.Size = New Size(113, 25)
        lbUpper.TabIndex = 6
        lbUpper.Text = "Upper Case:"
        ' 
        ' lbNumber
        ' 
        lbNumber.AutoSize = True
        lbNumber.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbNumber.Location = New Point(22, 237)
        lbNumber.Name = "lbNumber"
        lbNumber.Size = New Size(85, 25)
        lbNumber.TabIndex = 7
        lbNumber.Text = "Number:"
        lbNumber.Visible = False
        ' 
        ' lbLower
        ' 
        lbLower.AutoSize = True
        lbLower.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbLower.Location = New Point(23, 274)
        lbLower.Name = "lbLower"
        lbLower.Size = New Size(112, 25)
        lbLower.TabIndex = 8
        lbLower.Text = "Lower Case:"
        ' 
        ' lbU
        ' 
        lbU.AutoSize = True
        lbU.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbU.Location = New Point(195, 201)
        lbU.Name = "lbU"
        lbU.Size = New Size(0, 25)
        lbU.TabIndex = 9
        ' 
        ' lbN
        ' 
        lbN.AutoSize = True
        lbN.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbN.Location = New Point(195, 237)
        lbN.Name = "lbN"
        lbN.Size = New Size(0, 25)
        lbN.TabIndex = 10
        ' 
        ' lbL
        ' 
        lbL.AutoSize = True
        lbL.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbL.Location = New Point(195, 274)
        lbL.Name = "lbL"
        lbL.Size = New Size(0, 25)
        lbL.TabIndex = 11
        ' 
        ' btBackground
        ' 
        btBackground.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btBackground.Location = New Point(330, 37)
        btBackground.Name = "btBackground"
        btBackground.Size = New Size(144, 38)
        btBackground.TabIndex = 12
        btBackground.Text = "Background"
        btBackground.UseVisualStyleBackColor = True
        ' 
        ' btFont
        ' 
        btFont.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        btFont.Location = New Point(330, 140)
        btFont.Name = "btFont"
        btFont.Size = New Size(144, 38)
        btFont.TabIndex = 13
        btFont.Text = "Font Color"
        btFont.UseVisualStyleBackColor = True
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, ColorToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(486, 24)
        MenuStrip1.TabIndex = 15
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {QuitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' QuitToolStripMenuItem
        ' 
        QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        QuitToolStripMenuItem.ShortcutKeyDisplayString = "Alt + F4"
        QuitToolStripMenuItem.Size = New Size(141, 22)
        QuitToolStripMenuItem.Text = "Exit"
        ' 
        ' ColorToolStripMenuItem
        ' 
        ColorToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {BackgroundColorToolStripMenuItem1, FontColorToolStripMenuItem1})
        ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        ColorToolStripMenuItem.Size = New Size(48, 20)
        ColorToolStripMenuItem.Text = "&Color"
        ' 
        ' BackgroundColorToolStripMenuItem1
        ' 
        BackgroundColorToolStripMenuItem1.Name = "BackgroundColorToolStripMenuItem1"
        BackgroundColorToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl + B"
        BackgroundColorToolStripMenuItem1.Size = New Size(217, 22)
        BackgroundColorToolStripMenuItem1.Text = "Background Color"
        ' 
        ' FontColorToolStripMenuItem1
        ' 
        FontColorToolStripMenuItem1.Name = "FontColorToolStripMenuItem1"
        FontColorToolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl + C"
        FontColorToolStripMenuItem1.Size = New Size(217, 22)
        FontColorToolStripMenuItem1.Text = "Font Color"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ViewHelpToolStripMenuItem, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(44, 20)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' ViewHelpToolStripMenuItem
        ' 
        ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        ViewHelpToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + F1"
        ViewHelpToolStripMenuItem.Size = New Size(231, 22)
        ViewHelpToolStripMenuItem.Text = "View Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Mayúsculas + A"
        AboutToolStripMenuItem.Size = New Size(231, 22)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(486, 311)
        Controls.Add(MenuStrip1)
        Controls.Add(btFont)
        Controls.Add(btBackground)
        Controls.Add(lbL)
        Controls.Add(lbN)
        Controls.Add(lbU)
        Controls.Add(lbLower)
        Controls.Add(lbNumber)
        Controls.Add(lbUpper)
        Controls.Add(btQuit)
        Controls.Add(GroupBox1)
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rbNumbers As RadioButton
    Friend WithEvents rbAll As RadioButton
    Friend WithEvents rbLetters As RadioButton
    Friend WithEvents btQuit As Button
    Friend WithEvents lbUpper As Label
    Friend WithEvents lbNumber As Label
    Friend WithEvents lbLower As Label
    Friend WithEvents lbU As Label
    Friend WithEvents lbN As Label
    Friend WithEvents lbL As Label
    Friend WithEvents btBackground As Button
    Friend WithEvents btFont As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
