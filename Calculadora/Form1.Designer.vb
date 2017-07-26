<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnSuma = New System.Windows.Forms.RadioButton()
        Me.btnResta = New System.Windows.Forms.RadioButton()
        Me.btnDivision = New System.Windows.Forms.RadioButton()
        Me.btnMultiplicacion = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSuma
        '
        Me.btnSuma.AutoSize = True
        Me.btnSuma.Location = New System.Drawing.Point(8, 71)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(52, 17)
        Me.btnSuma.TabIndex = 0
        Me.btnSuma.TabStop = True
        Me.btnSuma.Text = "Suma"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnResta
        '
        Me.btnResta.AutoSize = True
        Me.btnResta.Location = New System.Drawing.Point(8, 113)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(53, 17)
        Me.btnResta.TabIndex = 1
        Me.btnResta.TabStop = True
        Me.btnResta.Text = "Resta"
        Me.btnResta.UseVisualStyleBackColor = True
        '
        'btnDivision
        '
        Me.btnDivision.AutoSize = True
        Me.btnDivision.Location = New System.Drawing.Point(8, 148)
        Me.btnDivision.Name = "btnDivision"
        Me.btnDivision.Size = New System.Drawing.Size(62, 17)
        Me.btnDivision.TabIndex = 2
        Me.btnDivision.TabStop = True
        Me.btnDivision.Text = "División"
        Me.btnDivision.UseVisualStyleBackColor = True
        '
        'btnMultiplicacion
        '
        Me.btnMultiplicacion.AutoSize = True
        Me.btnMultiplicacion.Location = New System.Drawing.Point(8, 189)
        Me.btnMultiplicacion.Name = "btnMultiplicacion"
        Me.btnMultiplicacion.Size = New System.Drawing.Size(89, 17)
        Me.btnMultiplicacion.TabIndex = 3
        Me.btnMultiplicacion.TabStop = True
        Me.btnMultiplicacion.Text = "Multiplicación"
        Me.btnMultiplicacion.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Valor 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(292, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Valor 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(276, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Resultado"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(337, 68)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 20)
        Me.txtValor1.TabIndex = 7
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(337, 110)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 20)
        Me.txtValor2.TabIndex = 8
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(337, 189)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(100, 20)
        Me.txtResultado.TabIndex = 9
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(221, 265)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 10
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 350)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMultiplicacion)
        Me.Controls.Add(Me.btnDivision)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btnSuma)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSuma As RadioButton
    Friend WithEvents btnResta As RadioButton
    Friend WithEvents btnDivision As RadioButton
    Friend WithEvents btnMultiplicacion As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents btnCalcular As Button
End Class
