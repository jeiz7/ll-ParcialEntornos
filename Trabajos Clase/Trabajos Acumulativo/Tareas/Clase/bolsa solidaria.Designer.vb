<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bolsa_solidaria
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSolicitar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbEstado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtintegrantes = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtidentidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBolsas = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblMunicipio = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpbx = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbxDireccion = New System.Windows.Forms.ListBox()
        Me.lbxTipo = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbxid = New System.Windows.Forms.ListBox()
        Me.errorValidacion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.grpbx.SuspendLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Controls.Add(Me.btnSolicitar)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbEstado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtintegrantes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtidentidad)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 358)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(196, 253)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(112, 56)
        Me.btnNuevo.TabIndex = 14
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnSolicitar
        '
        Me.btnSolicitar.Location = New System.Drawing.Point(25, 253)
        Me.btnSolicitar.Name = "btnSolicitar"
        Me.btnSolicitar.Size = New System.Drawing.Size(115, 56)
        Me.btnSolicitar.TabIndex = 9
        Me.btnSolicitar.Text = "Solicitar"
        Me.btnSolicitar.UseVisualStyleBackColor = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(130, 192)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(161, 20)
        Me.txtDireccion.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dirección Actual"
        '
        'cmbEstado
        '
        Me.cmbEstado.FormattingEnabled = True
        Me.cmbEstado.Items.AddRange(New Object() {"Pobreza", "Extrema Pobreza", "Desempleado"})
        Me.cmbEstado.Location = New System.Drawing.Point(130, 148)
        Me.cmbEstado.Name = "cmbEstado"
        Me.cmbEstado.Size = New System.Drawing.Size(161, 21)
        Me.cmbEstado.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Estado Financiero"
        '
        'txtintegrantes
        '
        Me.txtintegrantes.Location = New System.Drawing.Point(130, 102)
        Me.txtintegrantes.Name = "txtintegrantes"
        Me.txtintegrantes.Size = New System.Drawing.Size(161, 20)
        Me.txtintegrantes.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Integrantes de la familia"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(130, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(211, 20)
        Me.txtNombre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre Completo"
        '
        'txtidentidad
        '
        Me.txtidentidad.Location = New System.Drawing.Point(130, 22)
        Me.txtidentidad.MaxLength = 13
        Me.txtidentidad.Name = "txtidentidad"
        Me.txtidentidad.Size = New System.Drawing.Size(161, 20)
        Me.txtidentidad.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "identidad"
        '
        'lblBolsas
        '
        Me.lblBolsas.AutoSize = True
        Me.lblBolsas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBolsas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBolsas.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblBolsas.Location = New System.Drawing.Point(385, 48)
        Me.lblBolsas.Name = "lblBolsas"
        Me.lblBolsas.Size = New System.Drawing.Size(2, 22)
        Me.lblBolsas.TabIndex = 16
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(333, 31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(95, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Bolsas Entregadas"
        '
        'lblMunicipio
        '
        Me.lblMunicipio.AutoSize = True
        Me.lblMunicipio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMunicipio.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblMunicipio.Location = New System.Drawing.Point(80, 71)
        Me.lblMunicipio.Name = "lblMunicipio"
        Me.lblMunicipio.Size = New System.Drawing.Size(2, 15)
        Me.lblMunicipio.TabIndex = 13
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartamento.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblDepartamento.Location = New System.Drawing.Point(100, 29)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(2, 15)
        Me.lblDepartamento.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Departamento:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Municipio:"
        '
        'grpbx
        '
        Me.grpbx.Controls.Add(Me.lblBolsas)
        Me.grpbx.Controls.Add(Me.Label11)
        Me.grpbx.Controls.Add(Me.Label12)
        Me.grpbx.Controls.Add(Me.Label10)
        Me.grpbx.Controls.Add(Me.lbxDireccion)
        Me.grpbx.Controls.Add(Me.lblMunicipio)
        Me.grpbx.Controls.Add(Me.lbxTipo)
        Me.grpbx.Controls.Add(Me.lblDepartamento)
        Me.grpbx.Controls.Add(Me.Label9)
        Me.grpbx.Controls.Add(Me.Label7)
        Me.grpbx.Controls.Add(Me.lbxid)
        Me.grpbx.Controls.Add(Me.Label6)
        Me.grpbx.Location = New System.Drawing.Point(414, 17)
        Me.grpbx.Name = "grpbx"
        Me.grpbx.Size = New System.Drawing.Size(440, 358)
        Me.grpbx.TabIndex = 3
        Me.grpbx.TabStop = False
        Me.grpbx.Text = "Reporte"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(333, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Dirección"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(186, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Tipo de bolsa"
        '
        'lbxDireccion
        '
        Me.lbxDireccion.FormattingEnabled = True
        Me.lbxDireccion.Location = New System.Drawing.Point(303, 160)
        Me.lbxDireccion.Name = "lbxDireccion"
        Me.lbxDireccion.Size = New System.Drawing.Size(131, 173)
        Me.lbxDireccion.TabIndex = 5
        '
        'lbxTipo
        '
        Me.lbxTipo.FormattingEnabled = True
        Me.lbxTipo.Location = New System.Drawing.Point(161, 160)
        Me.lbxTipo.Name = "lbxTipo"
        Me.lbxTipo.Size = New System.Drawing.Size(136, 173)
        Me.lbxTipo.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(46, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Identidad"
        '
        'lbxid
        '
        Me.lbxid.FormattingEnabled = True
        Me.lbxid.Location = New System.Drawing.Point(22, 160)
        Me.lbxid.Name = "lbxid"
        Me.lbxid.Size = New System.Drawing.Size(133, 173)
        Me.lbxid.TabIndex = 2
        '
        'errorValidacion
        '
        Me.errorValidacion.ContainerControl = Me
        '
        'bolsa_solidaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 387)
        Me.Controls.Add(Me.grpbx)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "bolsa_solidaria"
        Me.Text = "bolsa_solidaria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpbx.ResumeLayout(False)
        Me.grpbx.PerformLayout()
        CType(Me.errorValidacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSolicitar As Button
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbEstado As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtintegrantes As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidentidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpbx As GroupBox
    Friend WithEvents lblMunicipio As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lbxDireccion As ListBox
    Friend WithEvents lbxTipo As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents lbxid As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblBolsas As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents errorValidacion As ErrorProvider
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
End Class
