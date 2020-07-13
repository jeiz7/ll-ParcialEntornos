<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mostrarRegistrosWizard
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbComponentes = New System.Windows.Forms.ComboBox()
        Me.dgvPRINCIPAL = New System.Windows.Forms.DataGridView()
        Me.dgvSECUNDARIO = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvPRINCIPAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSECUNDARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Metropolis Semi Bold", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(146, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(532, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CONTROL ESTADISTICO DE COMPONENTES"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(175, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Seleccione un componente"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbComponentes
        '
        Me.cmbComponentes.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.cmbComponentes.FormattingEnabled = True
        Me.cmbComponentes.Items.AddRange(New Object() {"Procesador", "Memoria RAM", "Tarjeta de Video", "Almacenamiento", "Teclado", "Monitor", "Suministro de Energia "})
        Me.cmbComponentes.Location = New System.Drawing.Point(383, 82)
        Me.cmbComponentes.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbComponentes.Name = "cmbComponentes"
        Me.cmbComponentes.Size = New System.Drawing.Size(180, 21)
        Me.cmbComponentes.TabIndex = 17
        '
        'dgvPRINCIPAL
        '
        Me.dgvPRINCIPAL.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvPRINCIPAL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPRINCIPAL.Location = New System.Drawing.Point(79, 164)
        Me.dgvPRINCIPAL.Margin = New System.Windows.Forms.Padding(1)
        Me.dgvPRINCIPAL.Name = "dgvPRINCIPAL"
        Me.dgvPRINCIPAL.RowHeadersWidth = 62
        Me.dgvPRINCIPAL.RowTemplate.Height = 37
        Me.dgvPRINCIPAL.Size = New System.Drawing.Size(679, 144)
        Me.dgvPRINCIPAL.TabIndex = 19
        '
        'dgvSECUNDARIO
        '
        Me.dgvSECUNDARIO.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvSECUNDARIO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSECUNDARIO.Location = New System.Drawing.Point(79, 364)
        Me.dgvSECUNDARIO.Margin = New System.Windows.Forms.Padding(1)
        Me.dgvSECUNDARIO.Name = "dgvSECUNDARIO"
        Me.dgvSECUNDARIO.RowHeadersWidth = 62
        Me.dgvSECUNDARIO.RowTemplate.Height = 37
        Me.dgvSECUNDARIO.Size = New System.Drawing.Size(679, 144)
        Me.dgvSECUNDARIO.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(380, 135)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 14)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Como Primario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(371, 338)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 14)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Como Secundario"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 53)
        Me.Panel1.TabIndex = 23
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pruebaConexion.My.Resources.Resources._1161908
        Me.PictureBox1.Location = New System.Drawing.Point(0, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._646733
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Location = New System.Drawing.Point(598, 71)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(59, 40)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'mostrarRegistrosWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(841, 623)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvSECUNDARIO)
        Me.Controls.Add(Me.dgvPRINCIPAL)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.cmbComponentes)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "mostrarRegistrosWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mostrarRegistrosWizard"
        CType(Me.dgvPRINCIPAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSECUNDARIO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbComponentes As ComboBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dgvPRINCIPAL As DataGridView
    Friend WithEvents dgvSECUNDARIO As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
