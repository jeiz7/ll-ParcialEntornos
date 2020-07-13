<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class eliminarWizard
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
        Me.chkDeleteEmployee = New System.Windows.Forms.CheckBox()
        Me.chkDeletePC = New System.Windows.Forms.CheckBox()
        Me.grpDATAEMPLOYEE = New System.Windows.Forms.GroupBox()
        Me.btnFindUser = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCodigoDelEmpleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grPCDATA = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnFindComputer = New System.Windows.Forms.Button()
        Me.txtSerialPcToDelete = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMostrarDetalles = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.clearButton = New System.Windows.Forms.Button()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpDATAEMPLOYEE.SuspendLayout()
        Me.grPCDATA.SuspendLayout()
        CType(Me.dgvMostrarDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Metropolis Semi Bold", 20.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(241, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ELIMINAR UN REGISTRO"
        '
        'chkDeleteEmployee
        '
        Me.chkDeleteEmployee.AutoSize = True
        Me.chkDeleteEmployee.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.chkDeleteEmployee.Location = New System.Drawing.Point(208, 87)
        Me.chkDeleteEmployee.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkDeleteEmployee.Name = "chkDeleteEmployee"
        Me.chkDeleteEmployee.Size = New System.Drawing.Size(175, 18)
        Me.chkDeleteEmployee.TabIndex = 1
        Me.chkDeleteEmployee.Text = "&Eliminar un Empleado"
        Me.chkDeleteEmployee.UseVisualStyleBackColor = True
        '
        'chkDeletePC
        '
        Me.chkDeletePC.AutoSize = True
        Me.chkDeletePC.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.chkDeletePC.Location = New System.Drawing.Point(450, 87)
        Me.chkDeletePC.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkDeletePC.Name = "chkDeletePC"
        Me.chkDeletePC.Size = New System.Drawing.Size(133, 18)
        Me.chkDeletePC.TabIndex = 2
        Me.chkDeletePC.Text = "&Eliminar una PC"
        Me.chkDeletePC.UseVisualStyleBackColor = True
        '
        'grpDATAEMPLOYEE
        '
        Me.grpDATAEMPLOYEE.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grpDATAEMPLOYEE.Controls.Add(Me.btnFindUser)
        Me.grpDATAEMPLOYEE.Controls.Add(Me.Label7)
        Me.grpDATAEMPLOYEE.Controls.Add(Me.txtCodigoDelEmpleado)
        Me.grpDATAEMPLOYEE.Controls.Add(Me.Label2)
        Me.grpDATAEMPLOYEE.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.grpDATAEMPLOYEE.Location = New System.Drawing.Point(30, 171)
        Me.grpDATAEMPLOYEE.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpDATAEMPLOYEE.Name = "grpDATAEMPLOYEE"
        Me.grpDATAEMPLOYEE.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpDATAEMPLOYEE.Size = New System.Drawing.Size(508, 118)
        Me.grpDATAEMPLOYEE.TabIndex = 3
        Me.grpDATAEMPLOYEE.TabStop = False
        Me.grpDATAEMPLOYEE.Text = "&Eliminar Empleado"
        '
        'btnFindUser
        '
        Me.btnFindUser.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._64673
        Me.btnFindUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFindUser.FlatAppearance.BorderSize = 0
        Me.btnFindUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindUser.Location = New System.Drawing.Point(335, 40)
        Me.btnFindUser.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnFindUser.Name = "btnFindUser"
        Me.btnFindUser.Size = New System.Drawing.Size(42, 42)
        Me.btnFindUser.TabIndex = 2
        Me.btnFindUser.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(381, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "&Buscar"
        '
        'txtCodigoDelEmpleado
        '
        Me.txtCodigoDelEmpleado.Location = New System.Drawing.Point(180, 53)
        Me.txtCodigoDelEmpleado.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtCodigoDelEmpleado.Name = "txtCodigoDelEmpleado"
        Me.txtCodigoDelEmpleado.Size = New System.Drawing.Size(126, 21)
        Me.txtCodigoDelEmpleado.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo De Empleado"
        '
        'grPCDATA
        '
        Me.grPCDATA.BackColor = System.Drawing.Color.FromArgb(CType(CType(229, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.grPCDATA.Controls.Add(Me.Label8)
        Me.grPCDATA.Controls.Add(Me.btnFindComputer)
        Me.grPCDATA.Controls.Add(Me.txtSerialPcToDelete)
        Me.grPCDATA.Controls.Add(Me.Label3)
        Me.grPCDATA.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.grPCDATA.Location = New System.Drawing.Point(30, 171)
        Me.grPCDATA.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grPCDATA.Name = "grPCDATA"
        Me.grPCDATA.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grPCDATA.Size = New System.Drawing.Size(510, 118)
        Me.grPCDATA.TabIndex = 4
        Me.grPCDATA.TabStop = False
        Me.grPCDATA.Text = "&Eliminar Computadora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(381, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 14)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "&Buscar"
        '
        'btnFindComputer
        '
        Me.btnFindComputer.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._64673
        Me.btnFindComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFindComputer.FlatAppearance.BorderSize = 0
        Me.btnFindComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindComputer.Location = New System.Drawing.Point(335, 40)
        Me.btnFindComputer.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnFindComputer.Name = "btnFindComputer"
        Me.btnFindComputer.Size = New System.Drawing.Size(42, 39)
        Me.btnFindComputer.TabIndex = 2
        Me.btnFindComputer.UseVisualStyleBackColor = True
        '
        'txtSerialPcToDelete
        '
        Me.txtSerialPcToDelete.Location = New System.Drawing.Point(180, 53)
        Me.txtSerialPcToDelete.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtSerialPcToDelete.Name = "txtSerialPcToDelete"
        Me.txtSerialPcToDelete.Size = New System.Drawing.Size(126, 21)
        Me.txtSerialPcToDelete.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(50, 53)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Serial De PC"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dgvMostrarDetalles
        '
        Me.dgvMostrarDetalles.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgvMostrarDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMostrarDetalles.Location = New System.Drawing.Point(30, 347)
        Me.dgvMostrarDetalles.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvMostrarDetalles.Name = "dgvMostrarDetalles"
        Me.dgvMostrarDetalles.RowHeadersWidth = 62
        Me.dgvMostrarDetalles.RowTemplate.Height = 37
        Me.dgvMostrarDetalles.Size = New System.Drawing.Size(744, 122)
        Me.dgvMostrarDetalles.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(66, 329)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "&Detalles"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Metropolis Semi Bold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(614, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "&Eliminar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Metropolis Semi Bold", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(647, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "&Limpiar"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.pruebaConexion.My.Resources.Resources.relo3
        Me.PictureBox3.Location = New System.Drawing.Point(30, 317)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 12
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.pruebaConexion.My.Resources.Resources.empleados
        Me.PictureBox2.Location = New System.Drawing.Point(172, 77)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.pruebaConexion.My.Resources.Resources.producto
        Me.PictureBox1.Location = New System.Drawing.Point(414, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'clearButton
        '
        Me.clearButton.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._838461
        Me.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.clearButton.FlatAppearance.BorderSize = 0
        Me.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearButton.Location = New System.Drawing.Point(650, 71)
        Me.clearButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.clearButton.Name = "clearButton"
        Me.clearButton.Size = New System.Drawing.Size(59, 44)
        Me.clearButton.TabIndex = 3
        Me.clearButton.UseVisualStyleBackColor = True
        '
        'deleteButton
        '
        Me.deleteButton.BackColor = System.Drawing.Color.Transparent
        Me.deleteButton.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._88666
        Me.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.deleteButton.FlatAppearance.BorderSize = 0
        Me.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteButton.ForeColor = System.Drawing.Color.Red
        Me.deleteButton.Location = New System.Drawing.Point(585, 197)
        Me.deleteButton.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(127, 44)
        Me.deleteButton.TabIndex = 7
        Me.deleteButton.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'eliminarWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 515)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.grPCDATA)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.clearButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvMostrarDetalles)
        Me.Controls.Add(Me.grpDATAEMPLOYEE)
        Me.Controls.Add(Me.chkDeletePC)
        Me.Controls.Add(Me.chkDeleteEmployee)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "eliminarWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "eliminarWizard"
        Me.grpDATAEMPLOYEE.ResumeLayout(False)
        Me.grpDATAEMPLOYEE.PerformLayout()
        Me.grPCDATA.ResumeLayout(False)
        Me.grPCDATA.PerformLayout()
        CType(Me.dgvMostrarDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents chkDeleteEmployee As CheckBox
    Friend WithEvents chkDeletePC As CheckBox
    Friend WithEvents grpDATAEMPLOYEE As GroupBox
    Friend WithEvents btnFindUser As Button
    Friend WithEvents txtCodigoDelEmpleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents grPCDATA As GroupBox
    Friend WithEvents btnFindComputer As Button
    Friend WithEvents txtSerialPcToDelete As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMostrarDetalles As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents deleteButton As Button
    Friend WithEvents clearButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
