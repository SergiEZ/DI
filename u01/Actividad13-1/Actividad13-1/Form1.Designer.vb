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
        GroupBox1.SuspendLayout()
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
        btQuit.Location = New Point(343, 261)
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(443, 313)
        Controls.Add(lbL)
        Controls.Add(lbN)
        Controls.Add(lbU)
        Controls.Add(lbLower)
        Controls.Add(lbNumber)
        Controls.Add(lbUpper)
        Controls.Add(btQuit)
        Controls.Add(GroupBox1)
        KeyPreview = True
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
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
End Class
