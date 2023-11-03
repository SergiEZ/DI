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
        lbTitulo = New Label()
        tbCampo = New TextBox()
        bt7 = New Button()
        bt8 = New Button()
        bt9 = New Button()
        bt4 = New Button()
        bt5 = New Button()
        bt6 = New Button()
        bt1 = New Button()
        bt2 = New Button()
        bt3 = New Button()
        bt0 = New Button()
        btClear = New Button()
        btComma = New Button()
        btSuma = New Button()
        btResta = New Button()
        btMultiplica = New Button()
        btDivide = New Button()
        btResultado = New Button()
        lbMemo = New Label()
        SuspendLayout()
        ' 
        ' lbTitulo
        ' 
        lbTitulo.AutoSize = True
        lbTitulo.FlatStyle = FlatStyle.Flat
        lbTitulo.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lbTitulo.Location = New Point(42, 9)
        lbTitulo.Name = "lbTitulo"
        lbTitulo.Size = New Size(226, 30)
        lbTitulo.TabIndex = 0
        lbTitulo.Text = "Calculadora Científica"
        ' 
        ' tbCampo
        ' 
        tbCampo.Enabled = False
        tbCampo.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        tbCampo.Location = New Point(33, 87)
        tbCampo.Name = "tbCampo"
        tbCampo.Size = New Size(190, 39)
        tbCampo.TabIndex = 1
        ' 
        ' bt7
        ' 
        bt7.BackColor = SystemColors.ActiveCaption
        bt7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt7.Location = New Point(32, 144)
        bt7.Name = "bt7"
        bt7.Size = New Size(50, 50)
        bt7.TabIndex = 2
        bt7.Text = "7"
        bt7.UseVisualStyleBackColor = False
        ' 
        ' bt8
        ' 
        bt8.BackColor = SystemColors.ActiveCaption
        bt8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt8.Location = New Point(102, 144)
        bt8.Name = "bt8"
        bt8.Size = New Size(50, 50)
        bt8.TabIndex = 3
        bt8.Text = "8"
        bt8.UseVisualStyleBackColor = False
        ' 
        ' bt9
        ' 
        bt9.BackColor = SystemColors.ActiveCaption
        bt9.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt9.Location = New Point(173, 144)
        bt9.Name = "bt9"
        bt9.Size = New Size(50, 50)
        bt9.TabIndex = 4
        bt9.Text = "9"
        bt9.UseVisualStyleBackColor = False
        ' 
        ' bt4
        ' 
        bt4.BackColor = SystemColors.ActiveCaption
        bt4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt4.Location = New Point(32, 211)
        bt4.Name = "bt4"
        bt4.Size = New Size(50, 50)
        bt4.TabIndex = 5
        bt4.Text = "4"
        bt4.UseVisualStyleBackColor = False
        ' 
        ' bt5
        ' 
        bt5.BackColor = SystemColors.ActiveCaption
        bt5.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt5.Location = New Point(102, 211)
        bt5.Name = "bt5"
        bt5.Size = New Size(50, 50)
        bt5.TabIndex = 6
        bt5.Text = "5"
        bt5.UseVisualStyleBackColor = False
        ' 
        ' bt6
        ' 
        bt6.BackColor = SystemColors.ActiveCaption
        bt6.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt6.Location = New Point(173, 211)
        bt6.Name = "bt6"
        bt6.Size = New Size(50, 50)
        bt6.TabIndex = 7
        bt6.Text = "6"
        bt6.UseVisualStyleBackColor = False
        ' 
        ' bt1
        ' 
        bt1.BackColor = SystemColors.ActiveCaption
        bt1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt1.Location = New Point(33, 279)
        bt1.Name = "bt1"
        bt1.Size = New Size(50, 50)
        bt1.TabIndex = 8
        bt1.Text = "1"
        bt1.UseVisualStyleBackColor = False
        ' 
        ' bt2
        ' 
        bt2.BackColor = SystemColors.ActiveCaption
        bt2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt2.Location = New Point(102, 279)
        bt2.Name = "bt2"
        bt2.Size = New Size(50, 50)
        bt2.TabIndex = 9
        bt2.Text = "2"
        bt2.UseVisualStyleBackColor = False
        ' 
        ' bt3
        ' 
        bt3.BackColor = SystemColors.ActiveCaption
        bt3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt3.Location = New Point(173, 279)
        bt3.Name = "bt3"
        bt3.Size = New Size(50, 50)
        bt3.TabIndex = 10
        bt3.Text = "3"
        bt3.UseVisualStyleBackColor = False
        ' 
        ' bt0
        ' 
        bt0.BackColor = SystemColors.ActiveCaption
        bt0.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        bt0.Location = New Point(33, 348)
        bt0.Name = "bt0"
        bt0.Size = New Size(50, 50)
        bt0.TabIndex = 11
        bt0.Text = "0"
        bt0.UseVisualStyleBackColor = False
        ' 
        ' btClear
        ' 
        btClear.BackColor = Color.IndianRed
        btClear.Font = New Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point)
        btClear.Location = New Point(234, 87)
        btClear.Name = "btClear"
        btClear.Size = New Size(50, 39)
        btClear.TabIndex = 12
        btClear.Text = "C"
        btClear.UseVisualStyleBackColor = False
        ' 
        ' btComma
        ' 
        btComma.BackColor = SystemColors.Info
        btComma.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btComma.Location = New Point(102, 348)
        btComma.Name = "btComma"
        btComma.Size = New Size(50, 50)
        btComma.TabIndex = 15
        btComma.Text = ","
        btComma.UseVisualStyleBackColor = False
        ' 
        ' btSuma
        ' 
        btSuma.BackColor = Color.Gold
        btSuma.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btSuma.Location = New Point(234, 144)
        btSuma.Name = "btSuma"
        btSuma.Size = New Size(50, 50)
        btSuma.TabIndex = 16
        btSuma.Text = "➕"
        btSuma.UseVisualStyleBackColor = False
        ' 
        ' btResta
        ' 
        btResta.BackColor = Color.Gold
        btResta.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btResta.Location = New Point(234, 211)
        btResta.Name = "btResta"
        btResta.Size = New Size(50, 50)
        btResta.TabIndex = 17
        btResta.Text = "➖"
        btResta.UseVisualStyleBackColor = False
        ' 
        ' btMultiplica
        ' 
        btMultiplica.BackColor = Color.Gold
        btMultiplica.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btMultiplica.Location = New Point(234, 279)
        btMultiplica.Name = "btMultiplica"
        btMultiplica.Size = New Size(50, 50)
        btMultiplica.TabIndex = 18
        btMultiplica.Text = "✖️"
        btMultiplica.UseVisualStyleBackColor = False
        ' 
        ' btDivide
        ' 
        btDivide.BackColor = Color.Gold
        btDivide.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btDivide.Location = New Point(173, 348)
        btDivide.Name = "btDivide"
        btDivide.Size = New Size(50, 50)
        btDivide.TabIndex = 19
        btDivide.Text = "➗"
        btDivide.UseVisualStyleBackColor = False
        ' 
        ' btResultado
        ' 
        btResultado.BackColor = Color.LawnGreen
        btResultado.Enabled = False
        btResultado.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btResultado.Location = New Point(234, 348)
        btResultado.Name = "btResultado"
        btResultado.Size = New Size(50, 50)
        btResultado.TabIndex = 20
        btResultado.Text = ChrW(55357) & ChrW(57328)
        btResultado.UseVisualStyleBackColor = False
        ' 
        ' lbMemo
        ' 
        lbMemo.AutoSize = True
        lbMemo.FlatStyle = FlatStyle.Flat
        lbMemo.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point)
        lbMemo.Location = New Point(32, 52)
        lbMemo.Name = "lbMemo"
        lbMemo.Size = New Size(0, 32)
        lbMemo.TabIndex = 21
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(296, 449)
        Controls.Add(lbMemo)
        Controls.Add(btResultado)
        Controls.Add(btDivide)
        Controls.Add(btMultiplica)
        Controls.Add(btResta)
        Controls.Add(btSuma)
        Controls.Add(btComma)
        Controls.Add(btClear)
        Controls.Add(bt0)
        Controls.Add(bt3)
        Controls.Add(bt2)
        Controls.Add(bt1)
        Controls.Add(bt6)
        Controls.Add(bt5)
        Controls.Add(bt4)
        Controls.Add(bt9)
        Controls.Add(bt8)
        Controls.Add(bt7)
        Controls.Add(tbCampo)
        Controls.Add(lbTitulo)
        Name = "Form1"
        Text = "Calculadora"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbTitulo As Label
    Friend WithEvents tbCampo As TextBox
    Friend WithEvents bt7 As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents bt9 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents bt1 As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents bt0 As Button
    Friend WithEvents btClear As Button
    Friend WithEvents btComma As Button
    Friend WithEvents btSuma As Button
    Friend WithEvents btResta As Button
    Friend WithEvents btMultiplica As Button
    Friend WithEvents btDivide As Button
    Friend WithEvents btResultado As Button
    Friend WithEvents lbMemo As Label
End Class
