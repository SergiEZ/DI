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
        lbChar = New Label()
        lbASCII = New Label()
        SuspendLayout()
        ' 
        ' lbChar
        ' 
        lbChar.AutoSize = True
        lbChar.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbChar.Location = New Point(62, 47)
        lbChar.Name = "lbChar"
        lbChar.Size = New Size(139, 37)
        lbChar.TabIndex = 0
        lbChar.Text = "labelChar"
        ' 
        ' lbASCII
        ' 
        lbASCII.AutoSize = True
        lbASCII.Font = New Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        lbASCII.Location = New Point(62, 157)
        lbASCII.Name = "lbASCII"
        lbASCII.Size = New Size(149, 37)
        lbASCII.TabIndex = 1
        lbASCII.Text = "labelASCII"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(284, 261)
        Controls.Add(lbASCII)
        Controls.Add(lbChar)
        Name = "Form1"
        Text = "ASCII Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbChar As Label
    Friend WithEvents lbASCII As Label
End Class
