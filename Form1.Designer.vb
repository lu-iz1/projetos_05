<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnComparar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.lblIdade1 = New System.Windows.Forms.Label()
        Me.lblIdade2 = New System.Windows.Forms.Label()
        Me.tbtIdade1 = New System.Windows.Forms.TextBox()
        Me.tbtIdade2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnComparar
        '
        Me.btnComparar.Location = New System.Drawing.Point(223, 211)
        Me.btnComparar.Name = "btnComparar"
        Me.btnComparar.Size = New System.Drawing.Size(296, 39)
        Me.btnComparar.TabIndex = 0
        Me.btnComparar.Text = "&Comparar idades"
        Me.btnComparar.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Location = New System.Drawing.Point(223, 256)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(296, 39)
        Me.btnLimpar.TabIndex = 1
        Me.btnLimpar.Text = "&Limpar dados"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'lblIdade1
        '
        Me.lblIdade1.AutoSize = True
        Me.lblIdade1.Location = New System.Drawing.Point(220, 112)
        Me.lblIdade1.Name = "lblIdade1"
        Me.lblIdade1.Size = New System.Drawing.Size(114, 13)
        Me.lblIdade1.TabIndex = 2
        Me.lblIdade1.Text = "Digite a primeira idade:"
        '
        'lblIdade2
        '
        Me.lblIdade2.AutoSize = True
        Me.lblIdade2.Location = New System.Drawing.Point(220, 156)
        Me.lblIdade2.Name = "lblIdade2"
        Me.lblIdade2.Size = New System.Drawing.Size(119, 13)
        Me.lblIdade2.TabIndex = 3
        Me.lblIdade2.Text = "Digite a segunda idade:"
        '
        'tbtIdade1
        '
        Me.tbtIdade1.Location = New System.Drawing.Point(357, 109)
        Me.tbtIdade1.Name = "tbtIdade1"
        Me.tbtIdade1.Size = New System.Drawing.Size(162, 20)
        Me.tbtIdade1.TabIndex = 4
        '
        'tbtIdade2
        '
        Me.tbtIdade2.Location = New System.Drawing.Point(357, 156)
        Me.tbtIdade2.Name = "tbtIdade2"
        Me.tbtIdade2.Size = New System.Drawing.Size(162, 20)
        Me.tbtIdade2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.tbtIdade2)
        Me.Controls.Add(Me.tbtIdade1)
        Me.Controls.Add(Me.lblIdade2)
        Me.Controls.Add(Me.lblIdade1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnComparar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnComparar As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents lblIdade1 As Label
    Friend WithEvents lblIdade2 As Label
    Friend WithEvents tbtIdade1 As TextBox
    Friend WithEvents tbtIdade2 As TextBox
End Class
