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
        BotonPulseAqui = New Button()
        Label1 = New Label()
        ButtonClose = New Button()
        SuspendLayout()
        ' 
        ' BotonPulseAqui
        ' 
        BotonPulseAqui.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        BotonPulseAqui.Location = New Point(112, 137)
        BotonPulseAqui.Name = "BotonPulseAqui"
        BotonPulseAqui.Size = New Size(195, 77)
        BotonPulseAqui.TabIndex = 0
        BotonPulseAqui.Text = "Pulse aquí"
        BotonPulseAqui.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(170, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 30)
        Label1.TabIndex = 1
        ' 
        ' ButtonClose
        ' 
        ButtonClose.Font = New Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point)
        ButtonClose.Location = New Point(366, 137)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(195, 77)
        ButtonClose.TabIndex = 2
        ButtonClose.Text = "Salir"
        ButtonClose.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(669, 255)
        Controls.Add(ButtonClose)
        Controls.Add(Label1)
        Controls.Add(BotonPulseAqui)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BotonPulseAqui As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonClose As Button
End Class
