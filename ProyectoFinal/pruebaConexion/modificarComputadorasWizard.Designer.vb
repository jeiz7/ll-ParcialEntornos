<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarComputadorasWizard
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
        Me.dgvPCAgregada = New System.Windows.Forms.DataGridView()
        Me.grpBoxDescript = New System.Windows.Forms.GroupBox()
        Me.cmbProcessor = New System.Windows.Forms.ComboBox()
        Me.cmbRAM = New System.Windows.Forms.ComboBox()
        Me.txtServiceTag = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.cmbBrand = New System.Windows.Forms.ComboBox()
        Me.cmbStorage = New System.Windows.Forms.ComboBox()
        Me.cmbGraphics = New System.Windows.Forms.ComboBox()
        Me.cmbScreen = New System.Windows.Forms.ComboBox()
        Me.cmbKeyboard = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPCToFind = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnFindToChange = New System.Windows.Forms.Button()
        Me.btnNEW = New System.Windows.Forms.Button()
        Me.btnAddComputer = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvPCAgregada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxDescript.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPCAgregada
        '
        Me.dgvPCAgregada.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvPCAgregada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPCAgregada.Location = New System.Drawing.Point(59, 401)
        Me.dgvPCAgregada.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.dgvPCAgregada.Name = "dgvPCAgregada"
        Me.dgvPCAgregada.RowHeadersWidth = 62
        Me.dgvPCAgregada.RowTemplate.Height = 37
        Me.dgvPCAgregada.Size = New System.Drawing.Size(701, 132)
        Me.dgvPCAgregada.TabIndex = 26
        '
        'grpBoxDescript
        '
        Me.grpBoxDescript.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.grpBoxDescript.Controls.Add(Me.cmbProcessor)
        Me.grpBoxDescript.Controls.Add(Me.cmbRAM)
        Me.grpBoxDescript.Controls.Add(Me.txtServiceTag)
        Me.grpBoxDescript.Controls.Add(Me.txtModel)
        Me.grpBoxDescript.Controls.Add(Me.cmbBrand)
        Me.grpBoxDescript.Controls.Add(Me.cmbStorage)
        Me.grpBoxDescript.Controls.Add(Me.cmbGraphics)
        Me.grpBoxDescript.Controls.Add(Me.cmbScreen)
        Me.grpBoxDescript.Controls.Add(Me.cmbKeyboard)
        Me.grpBoxDescript.Controls.Add(Me.Label2)
        Me.grpBoxDescript.Controls.Add(Me.Label10)
        Me.grpBoxDescript.Controls.Add(Me.Label3)
        Me.grpBoxDescript.Controls.Add(Me.Label4)
        Me.grpBoxDescript.Controls.Add(Me.Label9)
        Me.grpBoxDescript.Controls.Add(Me.Label5)
        Me.grpBoxDescript.Controls.Add(Me.Label8)
        Me.grpBoxDescript.Controls.Add(Me.Label7)
        Me.grpBoxDescript.Controls.Add(Me.Label6)
        Me.grpBoxDescript.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.grpBoxDescript.Location = New System.Drawing.Point(59, 115)
        Me.grpBoxDescript.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxDescript.Name = "grpBoxDescript"
        Me.grpBoxDescript.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxDescript.Size = New System.Drawing.Size(701, 212)
        Me.grpBoxDescript.TabIndex = 24
        Me.grpBoxDescript.TabStop = False
        Me.grpBoxDescript.Text = "Descripcion del PC"
        '
        'cmbProcessor
        '
        Me.cmbProcessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProcessor.FormattingEnabled = True
        Me.cmbProcessor.Items.AddRange(New Object() {"SELECCIONE", "INTEL I5", "INTEL I7", "INTEL XEON", "AMD FX 5000", "AMD RYZEN 5", "AMD RYZEN 7"})
        Me.cmbProcessor.Location = New System.Drawing.Point(142, 138)
        Me.cmbProcessor.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbProcessor.Name = "cmbProcessor"
        Me.cmbProcessor.Size = New System.Drawing.Size(150, 21)
        Me.cmbProcessor.TabIndex = 35
        '
        'cmbRAM
        '
        Me.cmbRAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRAM.FormattingEnabled = True
        Me.cmbRAM.Items.AddRange(New Object() {"SELECCIONE", "16", "32", "64"})
        Me.cmbRAM.Location = New System.Drawing.Point(142, 173)
        Me.cmbRAM.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbRAM.Name = "cmbRAM"
        Me.cmbRAM.Size = New System.Drawing.Size(78, 21)
        Me.cmbRAM.TabIndex = 34
        '
        'txtServiceTag
        '
        Me.txtServiceTag.Location = New System.Drawing.Point(142, 37)
        Me.txtServiceTag.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtServiceTag.Name = "txtServiceTag"
        Me.txtServiceTag.Size = New System.Drawing.Size(150, 21)
        Me.txtServiceTag.TabIndex = 31
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(142, 104)
        Me.txtModel.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(150, 21)
        Me.txtModel.TabIndex = 32
        '
        'cmbBrand
        '
        Me.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBrand.FormattingEnabled = True
        Me.cmbBrand.Items.AddRange(New Object() {"", "DELL", "HP", "LENOVO"})
        Me.cmbBrand.Location = New System.Drawing.Point(142, 72)
        Me.cmbBrand.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbBrand.Name = "cmbBrand"
        Me.cmbBrand.Size = New System.Drawing.Size(150, 21)
        Me.cmbBrand.TabIndex = 33
        '
        'cmbStorage
        '
        Me.cmbStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStorage.FormattingEnabled = True
        Me.cmbStorage.Items.AddRange(New Object() {"SELECCIONE", "HDD 500GB", "HDD 1TB", "SSD 500GB", "SSD 2TB"})
        Me.cmbStorage.Location = New System.Drawing.Point(513, 37)
        Me.cmbStorage.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbStorage.Name = "cmbStorage"
        Me.cmbStorage.Size = New System.Drawing.Size(155, 21)
        Me.cmbStorage.TabIndex = 30
        '
        'cmbGraphics
        '
        Me.cmbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGraphics.FormattingEnabled = True
        Me.cmbGraphics.Items.AddRange(New Object() {"SELECCIONE", "INTEL HD GRAPHICS", "AMD RADEON GRAPHICS", "NVIDIA QUADRO "})
        Me.cmbGraphics.Location = New System.Drawing.Point(513, 72)
        Me.cmbGraphics.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbGraphics.Name = "cmbGraphics"
        Me.cmbGraphics.Size = New System.Drawing.Size(155, 21)
        Me.cmbGraphics.TabIndex = 29
        '
        'cmbScreen
        '
        Me.cmbScreen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbScreen.FormattingEnabled = True
        Me.cmbScreen.Items.AddRange(New Object() {"SELECCIONE", "TACTIL ", "FHD", "UHD", "RETINA"})
        Me.cmbScreen.Location = New System.Drawing.Point(513, 141)
        Me.cmbScreen.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbScreen.Name = "cmbScreen"
        Me.cmbScreen.Size = New System.Drawing.Size(155, 21)
        Me.cmbScreen.TabIndex = 28
        '
        'cmbKeyboard
        '
        Me.cmbKeyboard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKeyboard.FormattingEnabled = True
        Me.cmbKeyboard.Items.AddRange(New Object() {"SELECCIONE", "GENERICO", "BACKLIGHT", "MECANICO", "MEMBRANA"})
        Me.cmbKeyboard.Location = New System.Drawing.Point(513, 105)
        Me.cmbKeyboard.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbKeyboard.Name = "cmbKeyboard"
        Me.cmbKeyboard.Size = New System.Drawing.Size(155, 21)
        Me.cmbKeyboard.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 39)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Service Tag"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(385, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Monitor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Modelo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(385, 105)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 14)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Teclado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 143)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 14)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Procesador"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(385, 74)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 14)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Tarjeta De Video"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(385, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 14)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Tipo De Disco"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 180)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Memoria RAM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Metropolis Semi Bold", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(170, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 24)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "MODIFICACION DE COMPUTADORAS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(234, 79)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(101, 14)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Computadora"
        '
        'txtPCToFind
        '
        Me.txtPCToFind.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.txtPCToFind.Location = New System.Drawing.Point(359, 76)
        Me.txtPCToFind.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtPCToFind.Name = "txtPCToFind"
        Me.txtPCToFind.Size = New System.Drawing.Size(130, 21)
        Me.txtPCToFind.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(203, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(839, 51)
        Me.Panel1.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(293, 359)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 14)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "&Aplicar Cambios"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label13.Location = New System.Drawing.Point(600, 359)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 14)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "&Nuevo"
        '
        'btnFindToChange
        '
        Me.btnFindToChange.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._646731
        Me.btnFindToChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFindToChange.FlatAppearance.BorderSize = 0
        Me.btnFindToChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindToChange.Location = New System.Drawing.Point(549, 66)
        Me.btnFindToChange.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnFindToChange.Name = "btnFindToChange"
        Me.btnFindToChange.Size = New System.Drawing.Size(54, 36)
        Me.btnFindToChange.TabIndex = 29
        Me.btnFindToChange.UseVisualStyleBackColor = True
        '
        'btnNEW
        '
        Me.btnNEW.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._146951
        Me.btnNEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNEW.FlatAppearance.BorderSize = 0
        Me.btnNEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNEW.Location = New System.Drawing.Point(507, 341)
        Me.btnNEW.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(71, 48)
        Me.btnNEW.TabIndex = 27
        Me.btnNEW.UseVisualStyleBackColor = True
        '
        'btnAddComputer
        '
        Me.btnAddComputer.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._6268271
        Me.btnAddComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddComputer.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnAddComputer.FlatAppearance.BorderSize = 0
        Me.btnAddComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddComputer.Location = New System.Drawing.Point(212, 341)
        Me.btnAddComputer.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAddComputer.Name = "btnAddComputer"
        Me.btnAddComputer.Size = New System.Drawing.Size(71, 48)
        Me.btnAddComputer.TabIndex = 25
        Me.btnAddComputer.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'modificarComputadorasWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(839, 602)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnFindToChange)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtPCToFind)
        Me.Controls.Add(Me.btnNEW)
        Me.Controls.Add(Me.dgvPCAgregada)
        Me.Controls.Add(Me.grpBoxDescript)
        Me.Controls.Add(Me.btnAddComputer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "modificarComputadorasWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificarComputadorasWizard"
        CType(Me.dgvPCAgregada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxDescript.ResumeLayout(False)
        Me.grpBoxDescript.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNEW As Button
    Friend WithEvents dgvPCAgregada As DataGridView
    Friend WithEvents grpBoxDescript As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAddComputer As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPCToFind As TextBox
    Friend WithEvents btnFindToChange As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmbStorage As ComboBox
    Friend WithEvents cmbGraphics As ComboBox
    Friend WithEvents cmbScreen As ComboBox
    Friend WithEvents cmbKeyboard As ComboBox
    Friend WithEvents cmbProcessor As ComboBox
    Friend WithEvents cmbRAM As ComboBox
    Friend WithEvents txtServiceTag As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents cmbBrand As ComboBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
