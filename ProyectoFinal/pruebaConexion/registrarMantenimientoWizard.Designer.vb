<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registrarMantenimientoWizard
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvHistorial_Mantenimiento = New System.Windows.Forms.DataGridView()
        Me.grbRegistro_Mant = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mktFecha = New System.Windows.Forms.MaskedTextBox()
        Me.cmbOtros = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbComponentes = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbTip_Mantenimiento = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvCompu_Asignada = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvHistorial_Mantenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbRegistro_Mant.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCompu_Asignada, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Metropolis Semi Bold", 16.0!)
        Me.Label9.Location = New System.Drawing.Point(243, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(334, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "REGISTRO MANTENIMIENTOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox3.Controls.Add(Me.dgvHistorial_Mantenimiento)
        Me.GroupBox3.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(58, 393)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(721, 155)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Historial de Mantenimiento"
        '
        'dgvHistorial_Mantenimiento
        '
        Me.dgvHistorial_Mantenimiento.AllowUserToAddRows = False
        Me.dgvHistorial_Mantenimiento.AllowUserToDeleteRows = False
        Me.dgvHistorial_Mantenimiento.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvHistorial_Mantenimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistorial_Mantenimiento.Location = New System.Drawing.Point(15, 21)
        Me.dgvHistorial_Mantenimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvHistorial_Mantenimiento.Name = "dgvHistorial_Mantenimiento"
        Me.dgvHistorial_Mantenimiento.ReadOnly = True
        Me.dgvHistorial_Mantenimiento.RowHeadersWidth = 62
        Me.dgvHistorial_Mantenimiento.RowTemplate.Height = 28
        Me.dgvHistorial_Mantenimiento.Size = New System.Drawing.Size(686, 123)
        Me.dgvHistorial_Mantenimiento.TabIndex = 3
        '
        'grbRegistro_Mant
        '
        Me.grbRegistro_Mant.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.grbRegistro_Mant.Controls.Add(Me.Label13)
        Me.grbRegistro_Mant.Controls.Add(Me.mktFecha)
        Me.grbRegistro_Mant.Controls.Add(Me.cmbOtros)
        Me.grbRegistro_Mant.Controls.Add(Me.Label10)
        Me.grbRegistro_Mant.Controls.Add(Me.cmbComponentes)
        Me.grbRegistro_Mant.Controls.Add(Me.txtDescripcion)
        Me.grbRegistro_Mant.Controls.Add(Me.Label8)
        Me.grbRegistro_Mant.Controls.Add(Me.Label7)
        Me.grbRegistro_Mant.Controls.Add(Me.cmbTip_Mantenimiento)
        Me.grbRegistro_Mant.Controls.Add(Me.Label6)
        Me.grbRegistro_Mant.Controls.Add(Me.Label5)
        Me.grbRegistro_Mant.Controls.Add(Me.btnAgregar)
        Me.grbRegistro_Mant.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.grbRegistro_Mant.Location = New System.Drawing.Point(58, 223)
        Me.grbRegistro_Mant.Margin = New System.Windows.Forms.Padding(2)
        Me.grbRegistro_Mant.Name = "grbRegistro_Mant"
        Me.grbRegistro_Mant.Padding = New System.Windows.Forms.Padding(2)
        Me.grbRegistro_Mant.Size = New System.Drawing.Size(721, 152)
        Me.grbRegistro_Mant.TabIndex = 18
        Me.grbRegistro_Mant.TabStop = False
        Me.grbRegistro_Mant.Text = "Registro de Mantenimiento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Metropolis Semi Bold", 12.0!)
        Me.Label13.Location = New System.Drawing.Point(597, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 16)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "&Agregar"
        '
        'mktFecha
        '
        Me.mktFecha.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.mktFecha.Location = New System.Drawing.Point(104, 30)
        Me.mktFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.mktFecha.Mask = "00/00/0000"
        Me.mktFecha.Name = "mktFecha"
        Me.mktFecha.Size = New System.Drawing.Size(139, 19)
        Me.mktFecha.TabIndex = 20
        Me.mktFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.mktFecha.ValidatingType = GetType(Date)
        '
        'cmbOtros
        '
        Me.cmbOtros.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.cmbOtros.FormattingEnabled = True
        Me.cmbOtros.Items.AddRange(New Object() {"NINGUNO", "Procesador", "Memoria RAM", "Tarjeta de Video", "Almacenamiento", "Teclado", "Monitor", "Suministro de Energia "})
        Me.cmbOtros.Location = New System.Drawing.Point(413, 62)
        Me.cmbOtros.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbOtros.Name = "cmbOtros"
        Me.cmbOtros.Size = New System.Drawing.Size(136, 20)
        Me.cmbOtros.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.Label10.Location = New System.Drawing.Point(287, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 12)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Otros:"
        '
        'cmbComponentes
        '
        Me.cmbComponentes.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.cmbComponentes.FormattingEnabled = True
        Me.cmbComponentes.Items.AddRange(New Object() {"Procesador", "Memoria RAM", "Tarjeta de Video", "Almacenamiento", "Teclado", "Monitor", "Suministro de Energia "})
        Me.cmbComponentes.Location = New System.Drawing.Point(106, 62)
        Me.cmbComponentes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbComponentes.Name = "cmbComponentes"
        Me.cmbComponentes.Size = New System.Drawing.Size(137, 20)
        Me.cmbComponentes.TabIndex = 16
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(104, 101)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(445, 38)
        Me.txtDescripcion.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(18, 65)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 12)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Componente:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(18, 102)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 12)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Descripcion:"
        '
        'cmbTip_Mantenimiento
        '
        Me.cmbTip_Mantenimiento.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.cmbTip_Mantenimiento.FormattingEnabled = True
        Me.cmbTip_Mantenimiento.Items.AddRange(New Object() {"PREVENTIVO", "CORRECTIVO"})
        Me.cmbTip_Mantenimiento.Location = New System.Drawing.Point(413, 30)
        Me.cmbTip_Mantenimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTip_Mantenimiento.Name = "cmbTip_Mantenimiento"
        Me.cmbTip_Mantenimiento.Size = New System.Drawing.Size(136, 20)
        Me.cmbTip_Mantenimiento.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(287, 33)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 12)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Tipo Mantenimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(18, 33)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Fecha:"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAgregar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._22251473
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnAgregar.Location = New System.Drawing.Point(589, 46)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(88, 48)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(236, 41)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox1.Controls.Add(Me.dgvCompu_Asignada)
        Me.GroupBox1.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 102)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(721, 108)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles Empleado"
        '
        'dgvCompu_Asignada
        '
        Me.dgvCompu_Asignada.AllowUserToAddRows = False
        Me.dgvCompu_Asignada.AllowUserToDeleteRows = False
        Me.dgvCompu_Asignada.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvCompu_Asignada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompu_Asignada.Location = New System.Drawing.Point(20, 17)
        Me.dgvCompu_Asignada.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvCompu_Asignada.Name = "dgvCompu_Asignada"
        Me.dgvCompu_Asignada.ReadOnly = True
        Me.dgvCompu_Asignada.RowHeadersWidth = 62
        Me.dgvCompu_Asignada.RowTemplate.Height = 28
        Me.dgvCompu_Asignada.Size = New System.Drawing.Size(681, 71)
        Me.dgvCompu_Asignada.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 140)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 14
        '
        'txtCodEmpleado
        '
        Me.txtCodEmpleado.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtCodEmpleado.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.txtCodEmpleado.Location = New System.Drawing.Point(336, 60)
        Me.txtCodEmpleado.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodEmpleado.Name = "txtCodEmpleado"
        Me.txtCodEmpleado.Size = New System.Drawing.Size(117, 21)
        Me.txtCodEmpleado.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(131, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Ingrese Codigo Empleado:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(842, 32)
        Me.Panel1.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(483, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "&Validar Empleado"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(675, 75)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 14)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "&Nuevo"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._146952
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button3.Location = New System.Drawing.Point(662, 47)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(73, 26)
        Me.Button3.TabIndex = 22
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnValidar
        '
        Me.btnValidar.BackColor = System.Drawing.Color.Transparent
        Me.btnValidar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._6268273
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidar.FlatAppearance.BorderSize = 0
        Me.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btnValidar.Location = New System.Drawing.Point(522, 46)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(55, 27)
        Me.btnValidar.TabIndex = 21
        Me.btnValidar.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.PictureBox2.Image = Global.pruebaConexion.My.Resources.Resources.empleados
        Me.PictureBox2.Location = New System.Drawing.Point(94, 54)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'registrarMantenimientoWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(842, 607)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grbRegistro_Mant)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodEmpleado)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "registrarMantenimientoWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registrarMantenimientoWizard"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvHistorial_Mantenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbRegistro_Mant.ResumeLayout(False)
        Me.grbRegistro_Mant.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvCompu_Asignada, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents btnValidar As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgvHistorial_Mantenimiento As DataGridView
    Friend WithEvents grbRegistro_Mant As GroupBox
    Friend WithEvents mktFecha As MaskedTextBox
    Friend WithEvents cmbOtros As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmbComponentes As ComboBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbTip_Mantenimiento As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvCompu_Asignada As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
