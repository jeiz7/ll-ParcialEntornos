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
        Me.gpTablaMultiplicar = New System.Windows.Forms.GroupBox()
        Me.lbPregunta = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.gpTablaMultiplicar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpTablaMultiplicar
        '
        Me.gpTablaMultiplicar.BackColor = System.Drawing.Color.MediumPurple
        Me.gpTablaMultiplicar.Controls.Add(Me.txtNumero)
        Me.gpTablaMultiplicar.Controls.Add(Me.Button2)
        Me.gpTablaMultiplicar.Controls.Add(Me.btnCalcular)
        Me.gpTablaMultiplicar.Controls.Add(Me.lbPregunta)
        Me.gpTablaMultiplicar.Location = New System.Drawing.Point(44, 12)
        Me.gpTablaMultiplicar.Name = "gpTablaMultiplicar"
        Me.gpTablaMultiplicar.Size = New System.Drawing.Size(494, 351)
        Me.gpTablaMultiplicar.TabIndex = 0
        Me.gpTablaMultiplicar.TabStop = False
        Me.gpTablaMultiplicar.Text = " Tablas de Multiplicacion "
        '
        'lbPregunta
        '
        Me.lbPregunta.AutoSize = True
        Me.lbPregunta.Location = New System.Drawing.Point(41, 44)
        Me.lbPregunta.Name = "lbPregunta"
        Me.lbPregunta.Size = New System.Drawing.Size(221, 13)
        Me.lbPregunta.TabIndex = 0
        Me.lbPregunta.Text = "Introduzaca el numero de la Tabla que desea"
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(355, 60)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(89, 20)
        Me.btnCalcular.TabIndex = 3
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(355, 107)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 20)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(344, 153)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(113, 20)
        Me.txtNumero.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.gpTablaMultiplicar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gpTablaMultiplicar.ResumeLayout(False)
        Me.gpTablaMultiplicar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpTablaMultiplicar As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnCalcular As Button
    Friend WithEvents lbPregunta As Label
    Friend WithEvents txtNumero As TextBox
End Class
