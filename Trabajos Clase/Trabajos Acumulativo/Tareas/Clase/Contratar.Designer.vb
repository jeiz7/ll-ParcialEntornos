<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Contratar
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbIlustrador = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.chbCaricatura = New System.Windows.Forms.CheckBox()
        Me.chbReal = New System.Windows.Forms.CheckBox()
        Me.chbRetrato = New System.Windows.Forms.CheckBox()
        Me.chbDiseño = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label2.Location = New System.Drawing.Point(547, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contratar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label3.Location = New System.Drawing.Point(41, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Contrata un ilustrador"
        '
        'cmbIlustrador
        '
        Me.cmbIlustrador.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.cmbIlustrador.FormattingEnabled = True
        Me.cmbIlustrador.Items.AddRange(New Object() {"Rujojo", "Banksy", "Shaun Tan", "Mark Colan"})
        Me.cmbIlustrador.Location = New System.Drawing.Point(61, 52)
        Me.cmbIlustrador.Name = "cmbIlustrador"
        Me.cmbIlustrador.Size = New System.Drawing.Size(121, 21)
        Me.cmbIlustrador.TabIndex = 5
        Me.cmbIlustrador.Text = "Ilustradores"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chbDiseño)
        Me.GroupBox1.Controls.Add(Me.chbRetrato)
        Me.GroupBox1.Controls.Add(Me.chbReal)
        Me.GroupBox1.Controls.Add(Me.chbCaricatura)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox1.Location = New System.Drawing.Point(44, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 283)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(17, 36)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(17, 86)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(230, 20)
        Me.txtCorreo.TabIndex = 2
        '
        'chbCaricatura
        '
        Me.chbCaricatura.AutoSize = True
        Me.chbCaricatura.Location = New System.Drawing.Point(20, 138)
        Me.chbCaricatura.Name = "chbCaricatura"
        Me.chbCaricatura.Size = New System.Drawing.Size(74, 17)
        Me.chbCaricatura.TabIndex = 3
        Me.chbCaricatura.Text = "Caricatura"
        Me.chbCaricatura.UseVisualStyleBackColor = True
        '
        'chbReal
        '
        Me.chbReal.AutoSize = True
        Me.chbReal.Location = New System.Drawing.Point(20, 175)
        Me.chbReal.Name = "chbReal"
        Me.chbReal.Size = New System.Drawing.Size(64, 17)
        Me.chbReal.TabIndex = 4
        Me.chbReal.Text = "Realista"
        Me.chbReal.UseVisualStyleBackColor = True
        '
        'chbRetrato
        '
        Me.chbRetrato.AutoSize = True
        Me.chbRetrato.Location = New System.Drawing.Point(129, 138)
        Me.chbRetrato.Name = "chbRetrato"
        Me.chbRetrato.Size = New System.Drawing.Size(61, 17)
        Me.chbRetrato.TabIndex = 5
        Me.chbRetrato.Text = "Retrato"
        Me.chbRetrato.UseVisualStyleBackColor = True
        '
        'chbDiseño
        '
        Me.chbDiseño.AutoSize = True
        Me.chbDiseño.Location = New System.Drawing.Point(129, 175)
        Me.chbDiseño.Name = "chbDiseño"
        Me.chbDiseño.Size = New System.Drawing.Size(118, 17)
        Me.chbDiseño.TabIndex = 6
        Me.chbDiseño.Text = "Diseño de Logotipo"
        Me.chbDiseño.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Correo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 49)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Enviar Información"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(361, 87)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(270, 264)
        Me.ListBox1.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tipo de Ilustración"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(358, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Historial de contratos"
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(153, 212)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(129, 49)
        Me.btnNuevo.TabIndex = 10
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Contratar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 390)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbIlustrador)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Contratar"
        Me.Text = "Contratar"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbIlustrador As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents chbDiseño As CheckBox
    Friend WithEvents chbRetrato As CheckBox
    Friend WithEvents chbReal As CheckBox
    Friend WithEvents chbCaricatura As CheckBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents btnNuevo As Button
End Class
