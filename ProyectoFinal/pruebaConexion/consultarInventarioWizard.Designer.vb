<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultarInventarioWizard
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvComputadoras = New System.Windows.Forms.DataGridView()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.txtFindEmployee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFindPC = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerialPC = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorValidar = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvComputadoras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorValidar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Metropolis Semi Bold", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(339, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "REGISTROS"
        '
        'dgvComputadoras
        '
        Me.dgvComputadoras.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.dgvComputadoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComputadoras.Location = New System.Drawing.Point(53, 339)
        Me.dgvComputadoras.Margin = New System.Windows.Forms.Padding(1)
        Me.dgvComputadoras.Name = "dgvComputadoras"
        Me.dgvComputadoras.RowHeadersWidth = 62
        Me.dgvComputadoras.RowTemplate.Height = 37
        Me.dgvComputadoras.Size = New System.Drawing.Size(721, 221)
        Me.dgvComputadoras.TabIndex = 2
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Location = New System.Drawing.Point(53, 84)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(1)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.RowHeadersWidth = 62
        Me.dgvEmpleados.RowTemplate.Height = 37
        Me.dgvEmpleados.Size = New System.Drawing.Size(721, 201)
        Me.dgvEmpleados.TabIndex = 3
        '
        'txtFindEmployee
        '
        Me.txtFindEmployee.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.txtFindEmployee.Location = New System.Drawing.Point(216, 57)
        Me.txtFindEmployee.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFindEmployee.Name = "txtFindEmployee"
        Me.txtFindEmployee.Size = New System.Drawing.Size(120, 21)
        Me.txtFindEmployee.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(85, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Codigo empleado"
        '
        'btnFindPC
        '
        Me.btnFindPC.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._646731
        Me.btnFindPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFindPC.FlatAppearance.BorderSize = 0
        Me.btnFindPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindPC.Location = New System.Drawing.Point(308, 299)
        Me.btnFindPC.Margin = New System.Windows.Forms.Padding(1)
        Me.btnFindPC.Name = "btnFindPC"
        Me.btnFindPC.Size = New System.Drawing.Size(52, 31)
        Me.btnFindPC.TabIndex = 9
        Me.btnFindPC.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(94, 309)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "&Buscar PC"
        '
        'txtSerialPC
        '
        Me.txtSerialPC.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.txtSerialPC.Location = New System.Drawing.Point(181, 306)
        Me.txtSerialPC.Margin = New System.Windows.Forms.Padding(1)
        Me.txtSerialPC.Name = "txtSerialPC"
        Me.txtSerialPC.Size = New System.Drawing.Size(115, 21)
        Me.txtSerialPC.TabIndex = 7
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._8384611
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Location = New System.Drawing.Point(694, 38)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(61, 27)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._646731
        Me.btnBuscarEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarEmpleado.FlatAppearance.BorderSize = 0
        Me.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(359, 50)
        Me.btnBuscarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(52, 31)
        Me.btnBuscarEmpleado.TabIndex = 6
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(696, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "&Limpiar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 34)
        Me.Panel1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.PictureBox2.Image = Global.pruebaConexion.My.Resources.Resources.empleados
        Me.PictureBox2.Location = New System.Drawing.Point(44, 53)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.PictureBox1.Image = Global.pruebaConexion.My.Resources.Resources.producto
        Me.PictureBox1.Location = New System.Drawing.Point(53, 299)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'ErrorValidar
        '
        Me.ErrorValidar.ContainerControl = Me
        '
        'consultarInventarioWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(818, 697)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnFindPC)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSerialPC)
        Me.Controls.Add(Me.btnBuscarEmpleado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFindEmployee)
        Me.Controls.Add(Me.dgvEmpleados)
        Me.Controls.Add(Me.dgvComputadoras)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "consultarInventarioWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "consultarInventarioWizard"
        CType(Me.dgvComputadoras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorValidar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvComputadoras As DataGridView
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents txtFindEmployee As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscarEmpleado As Button
    Friend WithEvents btnFindPC As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSerialPC As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorValidar As ErrorProvider
End Class
