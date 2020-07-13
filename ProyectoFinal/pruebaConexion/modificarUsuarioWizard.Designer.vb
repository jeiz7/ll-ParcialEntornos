<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarUsuarioWizard
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
        Me.grpBoxPersonalData = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.chkNonGenre = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkFemale = New System.Windows.Forms.CheckBox()
        Me.chkMale = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnValidateUserData = New System.Windows.Forms.Button()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdentity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewCode = New System.Windows.Forms.TextBox()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpBoxLocation = New System.Windows.Forms.GroupBox()
        Me.btnValidateLocation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFindUserCode = New System.Windows.Forms.TextBox()
        Me.chkModifyPersonalData = New System.Windows.Forms.CheckBox()
        Me.chkModifyLocationData = New System.Windows.Forms.CheckBox()
        Me.chkModifyBOTH = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtDataUpdate = New System.Windows.Forms.Button()
        Me.btnValidar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.grpBoxPersonalData.SuspendLayout()
        Me.grpBoxLocation.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpBoxPersonalData
        '
        Me.grpBoxPersonalData.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grpBoxPersonalData.Controls.Add(Me.Label17)
        Me.grpBoxPersonalData.Controls.Add(Me.txtSerialNumber)
        Me.grpBoxPersonalData.Controls.Add(Me.cmbPosition)
        Me.grpBoxPersonalData.Controls.Add(Me.chkNonGenre)
        Me.grpBoxPersonalData.Controls.Add(Me.Label6)
        Me.grpBoxPersonalData.Controls.Add(Me.chkFemale)
        Me.grpBoxPersonalData.Controls.Add(Me.chkMale)
        Me.grpBoxPersonalData.Controls.Add(Me.Label15)
        Me.grpBoxPersonalData.Controls.Add(Me.Label9)
        Me.grpBoxPersonalData.Controls.Add(Me.Label10)
        Me.grpBoxPersonalData.Controls.Add(Me.btnValidateUserData)
        Me.grpBoxPersonalData.Controls.Add(Me.txtAge)
        Me.grpBoxPersonalData.Controls.Add(Me.Label5)
        Me.grpBoxPersonalData.Controls.Add(Me.txtFullName)
        Me.grpBoxPersonalData.Controls.Add(Me.Label4)
        Me.grpBoxPersonalData.Controls.Add(Me.txtIdentity)
        Me.grpBoxPersonalData.Controls.Add(Me.Label1)
        Me.grpBoxPersonalData.Controls.Add(Me.txtNewCode)
        Me.grpBoxPersonalData.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.grpBoxPersonalData.Location = New System.Drawing.Point(62, 148)
        Me.grpBoxPersonalData.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxPersonalData.Name = "grpBoxPersonalData"
        Me.grpBoxPersonalData.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxPersonalData.Size = New System.Drawing.Size(360, 383)
        Me.grpBoxPersonalData.TabIndex = 48
        Me.grpBoxPersonalData.TabStop = False
        Me.grpBoxPersonalData.Text = "Modificar Datos Personales"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(107, 331)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(156, 14)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "&Validar Nuevos Datos"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(172, 239)
        Me.txtSerialNumber.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(149, 21)
        Me.txtSerialNumber.TabIndex = 66
        '
        'cmbPosition
        '
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"SELECCIONAR", "GERENTE", "SUPERVISOR", "PROGRAMADOR", "DISENADOR", "PUBLICIDAD", "MANTENIMIENTO BD"})
        Me.cmbPosition.Location = New System.Drawing.Point(173, 207)
        Me.cmbPosition.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(148, 21)
        Me.cmbPosition.TabIndex = 68
        '
        'chkNonGenre
        '
        Me.chkNonGenre.AutoSize = True
        Me.chkNonGenre.Location = New System.Drawing.Point(267, 174)
        Me.chkNonGenre.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkNonGenre.Name = "chkNonGenre"
        Me.chkNonGenre.Size = New System.Drawing.Size(54, 18)
        Me.chkNonGenre.TabIndex = 67
        Me.chkNonGenre.Text = "N/D"
        Me.chkNonGenre.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 242)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 14)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "PC Asignada"
        '
        'chkFemale
        '
        Me.chkFemale.AutoSize = True
        Me.chkFemale.Location = New System.Drawing.Point(225, 177)
        Me.chkFemale.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkFemale.Name = "chkFemale"
        Me.chkFemale.Size = New System.Drawing.Size(35, 18)
        Me.chkFemale.TabIndex = 66
        Me.chkFemale.Text = "F"
        Me.chkFemale.UseVisualStyleBackColor = True
        '
        'chkMale
        '
        Me.chkMale.AutoSize = True
        Me.chkMale.Location = New System.Drawing.Point(172, 177)
        Me.chkMale.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkMale.Name = "chkMale"
        Me.chkMale.Size = New System.Drawing.Size(38, 18)
        Me.chkMale.TabIndex = 65
        Me.chkMale.Text = "M"
        Me.chkMale.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(27, 210)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 14)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Cargo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 178)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 14)
        Me.Label9.TabIndex = 63
        Me.Label9.Text = "Sexo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 145)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 14)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "Edad"
        '
        'btnValidateUserData
        '
        Me.btnValidateUserData.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._6268272
        Me.btnValidateUserData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidateUserData.FlatAppearance.BorderSize = 0
        Me.btnValidateUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidateUserData.Location = New System.Drawing.Point(150, 300)
        Me.btnValidateUserData.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnValidateUserData.Name = "btnValidateUserData"
        Me.btnValidateUserData.Size = New System.Drawing.Size(79, 30)
        Me.btnValidateUserData.TabIndex = 60
        Me.btnValidateUserData.UseVisualStyleBackColor = True
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(174, 141)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(55, 21)
        Me.txtAge.TabIndex = 61
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(26, 109)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 14)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Nombre Completo"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(172, 106)
        Me.txtFullName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.Size = New System.Drawing.Size(169, 21)
        Me.txtFullName.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Identidad"
        '
        'txtIdentity
        '
        Me.txtIdentity.Location = New System.Drawing.Point(172, 75)
        Me.txtIdentity.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtIdentity.Name = "txtIdentity"
        Me.txtIdentity.Size = New System.Drawing.Size(169, 21)
        Me.txtIdentity.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Codigo"
        '
        'txtNewCode
        '
        Me.txtNewCode.Location = New System.Drawing.Point(172, 43)
        Me.txtNewCode.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtNewCode.Name = "txtNewCode"
        Me.txtNewCode.Size = New System.Drawing.Size(123, 21)
        Me.txtNewCode.TabIndex = 48
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"SELECCIONAR", "ISLAS DE LA BAHÍA", "CORTÉS", "ATLÁNTIDA", "COLÓN", "GRACIAS A DIOS", "COPÁN", "SANTA BÁRBARA", "YORO", "OLANCHO", "OCOTEPEQUE", "LEMPIRA", "INTIBUCA", "COMAYAGUA", "FRANCISCO MORAZÁN", "EL PARAÍSO", "LA PAZ", "VALLE", "CHOLUTECA"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(128, 34)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(143, 20)
        Me.cmbDepartamento.TabIndex = 56
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 131)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 12)
        Me.Label11.TabIndex = 55
        Me.Label11.Text = "Colonia"
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(128, 128)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(143, 19)
        Me.txtColonia.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(24, 101)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 12)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Barrio"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(128, 98)
        Me.txtBarrio.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(143, 19)
        Me.txtBarrio.TabIndex = 52
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 70)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 12)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Municipio"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(128, 67)
        Me.txtMunicipio.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(143, 19)
        Me.txtMunicipio.TabIndex = 50
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 37)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 12)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "Departamento"
        '
        'grpBoxLocation
        '
        Me.grpBoxLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.grpBoxLocation.Controls.Add(Me.Label16)
        Me.grpBoxLocation.Controls.Add(Me.Label14)
        Me.grpBoxLocation.Controls.Add(Me.btnValidateLocation)
        Me.grpBoxLocation.Controls.Add(Me.txtMunicipio)
        Me.grpBoxLocation.Controls.Add(Me.cmbDepartamento)
        Me.grpBoxLocation.Controls.Add(Me.Label13)
        Me.grpBoxLocation.Controls.Add(Me.Label11)
        Me.grpBoxLocation.Controls.Add(Me.txtBarrio)
        Me.grpBoxLocation.Controls.Add(Me.txtColonia)
        Me.grpBoxLocation.Controls.Add(Me.Label12)
        Me.grpBoxLocation.Font = New System.Drawing.Font("Metropolis Semi Bold", 9.0!)
        Me.grpBoxLocation.Location = New System.Drawing.Point(468, 170)
        Me.grpBoxLocation.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxLocation.Name = "grpBoxLocation"
        Me.grpBoxLocation.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxLocation.Size = New System.Drawing.Size(297, 239)
        Me.grpBoxLocation.TabIndex = 58
        Me.grpBoxLocation.TabStop = False
        Me.grpBoxLocation.Text = "Modificar Ubicacion"
        '
        'btnValidateLocation
        '
        Me.btnValidateLocation.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._6268272
        Me.btnValidateLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidateLocation.FlatAppearance.BorderSize = 0
        Me.btnValidateLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidateLocation.Location = New System.Drawing.Point(119, 181)
        Me.btnValidateLocation.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnValidateLocation.Name = "btnValidateLocation"
        Me.btnValidateLocation.Size = New System.Drawing.Size(79, 30)
        Me.btnValidateLocation.TabIndex = 57
        Me.btnValidateLocation.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Metropolis Semi Bold", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(207, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(395, 24)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "MODIFICAR DATOS DE USUARIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(260, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 14)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Codigo Usuario"
        '
        'txtFindUserCode
        '
        Me.txtFindUserCode.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.txtFindUserCode.Location = New System.Drawing.Point(388, 75)
        Me.txtFindUserCode.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtFindUserCode.Name = "txtFindUserCode"
        Me.txtFindUserCode.Size = New System.Drawing.Size(132, 21)
        Me.txtFindUserCode.TabIndex = 61
        '
        'chkModifyPersonalData
        '
        Me.chkModifyPersonalData.AutoSize = True
        Me.chkModifyPersonalData.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.chkModifyPersonalData.Location = New System.Drawing.Point(91, 118)
        Me.chkModifyPersonalData.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkModifyPersonalData.Name = "chkModifyPersonalData"
        Me.chkModifyPersonalData.Size = New System.Drawing.Size(213, 18)
        Me.chkModifyPersonalData.TabIndex = 63
        Me.chkModifyPersonalData.Text = "Modificar Datos Personales"
        Me.chkModifyPersonalData.UseVisualStyleBackColor = True
        '
        'chkModifyLocationData
        '
        Me.chkModifyLocationData.AutoSize = True
        Me.chkModifyLocationData.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.chkModifyLocationData.Location = New System.Drawing.Point(352, 118)
        Me.chkModifyLocationData.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkModifyLocationData.Name = "chkModifyLocationData"
        Me.chkModifyLocationData.Size = New System.Drawing.Size(208, 18)
        Me.chkModifyLocationData.TabIndex = 64
        Me.chkModifyLocationData.Text = "Modificar Datos Ubicacion"
        Me.chkModifyLocationData.UseVisualStyleBackColor = True
        '
        'chkModifyBOTH
        '
        Me.chkModifyBOTH.AutoSize = True
        Me.chkModifyBOTH.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.chkModifyBOTH.Location = New System.Drawing.Point(621, 118)
        Me.chkModifyBOTH.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkModifyBOTH.Name = "chkModifyBOTH"
        Me.chkModifyBOTH.Size = New System.Drawing.Size(144, 18)
        Me.chkModifyBOTH.TabIndex = 72
        Me.chkModifyBOTH.Text = "Modificar Ambos"
        Me.chkModifyBOTH.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(835, 53)
        Me.Panel1.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(662, 492)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "&Nuevo/Limpiar"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(536, 492)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "&Actualizar Datos"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._708991
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(679, 448)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 39)
        Me.Button1.TabIndex = 71
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtDataUpdate
        '
        Me.txtDataUpdate.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._614441
        Me.txtDataUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtDataUpdate.FlatAppearance.BorderSize = 0
        Me.txtDataUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtDataUpdate.Location = New System.Drawing.Point(549, 451)
        Me.txtDataUpdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtDataUpdate.Name = "txtDataUpdate"
        Me.txtDataUpdate.Size = New System.Drawing.Size(54, 32)
        Me.txtDataUpdate.TabIndex = 70
        Me.txtDataUpdate.UseVisualStyleBackColor = True
        '
        'btnValidar
        '
        Me.btnValidar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._646732
        Me.btnValidar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidar.FlatAppearance.BorderSize = 0
        Me.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidar.Location = New System.Drawing.Point(552, 65)
        Me.btnValidar.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnValidar.Name = "btnValidar"
        Me.btnValidar.Size = New System.Drawing.Size(51, 36)
        Me.btnValidar.TabIndex = 62
        Me.btnValidar.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(91, 212)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 12)
        Me.Label16.TabIndex = 78
        Me.Label16.Text = "&Validar Nuevos Datos"
        '
        'modificarUsuarioWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(835, 614)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.chkModifyBOTH)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtDataUpdate)
        Me.Controls.Add(Me.chkModifyLocationData)
        Me.Controls.Add(Me.chkModifyPersonalData)
        Me.Controls.Add(Me.btnValidar)
        Me.Controls.Add(Me.txtFindUserCode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpBoxLocation)
        Me.Controls.Add(Me.grpBoxPersonalData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "modificarUsuarioWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificarUsuarioWizard"
        Me.grpBoxPersonalData.ResumeLayout(False)
        Me.grpBoxPersonalData.PerformLayout()
        Me.grpBoxLocation.ResumeLayout(False)
        Me.grpBoxLocation.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpBoxPersonalData As GroupBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents chkNonGenre As CheckBox
    Friend WithEvents chkFemale As CheckBox
    Friend WithEvents chkMale As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnValidateUserData As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFullName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdentity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewCode As TextBox
    Friend WithEvents btnValidateLocation As Button
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents grpBoxLocation As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFindUserCode As TextBox
    Friend WithEvents btnValidar As Button
    Friend WithEvents chkModifyPersonalData As CheckBox
    Friend WithEvents chkModifyLocationData As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDataUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents chkModifyBOTH As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label16 As Label
End Class
