<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class agregarUsuarioWizard
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBoxGeneralData = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.chkNonGenre = New System.Windows.Forms.CheckBox()
        Me.chkFemale = New System.Windows.Forms.CheckBox()
        Me.btnValidateUserData = New System.Windows.Forms.Button()
        Me.chkMale = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSecondLastName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFirstLastName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSecondName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIdentity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerialNumber = New System.Windows.Forms.TextBox()
        Me.grpBoxLocation = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnValidateLocation = New System.Windows.Forms.Button()
        Me.cmbDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBarrio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMunicipio = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.grpBoxSerial = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.errorValidarGeneral = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorValidarDireccion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorValidarPC = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.grpBoxGeneralData.SuspendLayout()
        Me.grpBoxLocation.SuspendLayout()
        Me.grpBoxSerial.SuspendLayout()
        CType(Me.errorValidarGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorValidarDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorValidarPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Metropolis Semi Bold", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(310, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(275, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "INGRESO DE USUARIO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtNewCode
        '
        Me.txtNewCode.Location = New System.Drawing.Point(195, 29)
        Me.txtNewCode.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtNewCode.Name = "txtNewCode"
        Me.txtNewCode.Size = New System.Drawing.Size(153, 21)
        Me.txtNewCode.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 14)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Codigo"
        '
        'grpBoxGeneralData
        '
        Me.grpBoxGeneralData.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grpBoxGeneralData.Controls.Add(Me.Label20)
        Me.grpBoxGeneralData.Controls.Add(Me.cmbPosition)
        Me.grpBoxGeneralData.Controls.Add(Me.chkNonGenre)
        Me.grpBoxGeneralData.Controls.Add(Me.chkFemale)
        Me.grpBoxGeneralData.Controls.Add(Me.btnValidateUserData)
        Me.grpBoxGeneralData.Controls.Add(Me.chkMale)
        Me.grpBoxGeneralData.Controls.Add(Me.Label15)
        Me.grpBoxGeneralData.Controls.Add(Me.Label9)
        Me.grpBoxGeneralData.Controls.Add(Me.Label10)
        Me.grpBoxGeneralData.Controls.Add(Me.txtAge)
        Me.grpBoxGeneralData.Controls.Add(Me.Label8)
        Me.grpBoxGeneralData.Controls.Add(Me.txtSecondLastName)
        Me.grpBoxGeneralData.Controls.Add(Me.Label7)
        Me.grpBoxGeneralData.Controls.Add(Me.txtFirstLastName)
        Me.grpBoxGeneralData.Controls.Add(Me.Label6)
        Me.grpBoxGeneralData.Controls.Add(Me.txtSecondName)
        Me.grpBoxGeneralData.Controls.Add(Me.Label5)
        Me.grpBoxGeneralData.Controls.Add(Me.txtFirstName)
        Me.grpBoxGeneralData.Controls.Add(Me.Label4)
        Me.grpBoxGeneralData.Controls.Add(Me.txtIdentity)
        Me.grpBoxGeneralData.Controls.Add(Me.Label1)
        Me.grpBoxGeneralData.Controls.Add(Me.txtNewCode)
        Me.grpBoxGeneralData.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.grpBoxGeneralData.Location = New System.Drawing.Point(41, 71)
        Me.grpBoxGeneralData.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxGeneralData.Name = "grpBoxGeneralData"
        Me.grpBoxGeneralData.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxGeneralData.Size = New System.Drawing.Size(381, 389)
        Me.grpBoxGeneralData.TabIndex = 4
        Me.grpBoxGeneralData.TabStop = False
        Me.grpBoxGeneralData.Text = "Datos Generales"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(162, 355)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(57, 14)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "&Validar"
        '
        'cmbPosition
        '
        Me.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPosition.FormattingEnabled = True
        Me.cmbPosition.Items.AddRange(New Object() {"SELECCIONAR", "GERENTE", "SUPERVISOR", "PROGRAMADOR", "DISENADOR", "PUBLICIDAD", "MANTENIMIENTO BD"})
        Me.cmbPosition.Location = New System.Drawing.Point(195, 280)
        Me.cmbPosition.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.Size = New System.Drawing.Size(129, 21)
        Me.cmbPosition.TabIndex = 26
        '
        'chkNonGenre
        '
        Me.chkNonGenre.AutoSize = True
        Me.chkNonGenre.Location = New System.Drawing.Point(281, 252)
        Me.chkNonGenre.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkNonGenre.Name = "chkNonGenre"
        Me.chkNonGenre.Size = New System.Drawing.Size(54, 18)
        Me.chkNonGenre.TabIndex = 25
        Me.chkNonGenre.Text = "N/D"
        Me.chkNonGenre.UseVisualStyleBackColor = True
        '
        'chkFemale
        '
        Me.chkFemale.AutoSize = True
        Me.chkFemale.Location = New System.Drawing.Point(241, 252)
        Me.chkFemale.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkFemale.Name = "chkFemale"
        Me.chkFemale.Size = New System.Drawing.Size(35, 18)
        Me.chkFemale.TabIndex = 24
        Me.chkFemale.Text = "F"
        Me.chkFemale.UseVisualStyleBackColor = True
        '
        'btnValidateUserData
        '
        Me.btnValidateUserData.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._626827
        Me.btnValidateUserData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidateUserData.FlatAppearance.BorderSize = 0
        Me.btnValidateUserData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidateUserData.Location = New System.Drawing.Point(147, 316)
        Me.btnValidateUserData.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnValidateUserData.Name = "btnValidateUserData"
        Me.btnValidateUserData.Size = New System.Drawing.Size(85, 38)
        Me.btnValidateUserData.TabIndex = 16
        Me.btnValidateUserData.UseVisualStyleBackColor = True
        '
        'chkMale
        '
        Me.chkMale.AutoSize = True
        Me.chkMale.Location = New System.Drawing.Point(195, 252)
        Me.chkMale.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.chkMale.Name = "chkMale"
        Me.chkMale.Size = New System.Drawing.Size(38, 18)
        Me.chkMale.TabIndex = 23
        Me.chkMale.Text = "M"
        Me.chkMale.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 283)
        Me.Label15.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 14)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Cargo"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 254)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Sexo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 225)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Edad"
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(195, 220)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(55, 21)
        Me.txtAge.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 193)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 14)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Segundo Apellido"
        '
        'txtSecondLastName
        '
        Me.txtSecondLastName.Location = New System.Drawing.Point(195, 189)
        Me.txtSecondLastName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtSecondLastName.Name = "txtSecondLastName"
        Me.txtSecondLastName.Size = New System.Drawing.Size(153, 21)
        Me.txtSecondLastName.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 160)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Primer Apellido"
        '
        'txtFirstLastName
        '
        Me.txtFirstLastName.Location = New System.Drawing.Point(195, 157)
        Me.txtFirstLastName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtFirstLastName.Name = "txtFirstLastName"
        Me.txtFirstLastName.Size = New System.Drawing.Size(153, 21)
        Me.txtFirstLastName.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 127)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Segundo Nombre"
        '
        'txtSecondName
        '
        Me.txtSecondName.Location = New System.Drawing.Point(195, 124)
        Me.txtSecondName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtSecondName.Name = "txtSecondName"
        Me.txtSecondName.Size = New System.Drawing.Size(153, 21)
        Me.txtSecondName.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 95)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Primer Nombre"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(195, 92)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(153, 21)
        Me.txtFirstName.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Identidad"
        '
        'txtIdentity
        '
        Me.txtIdentity.Location = New System.Drawing.Point(195, 61)
        Me.txtIdentity.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtIdentity.Name = "txtIdentity"
        Me.txtIdentity.Size = New System.Drawing.Size(153, 21)
        Me.txtIdentity.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 36)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Serial PC"
        '
        'txtSerialNumber
        '
        Me.txtSerialNumber.Location = New System.Drawing.Point(37, 59)
        Me.txtSerialNumber.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtSerialNumber.Name = "txtSerialNumber"
        Me.txtSerialNumber.Size = New System.Drawing.Size(88, 21)
        Me.txtSerialNumber.TabIndex = 4
        '
        'grpBoxLocation
        '
        Me.grpBoxLocation.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grpBoxLocation.Controls.Add(Me.Label18)
        Me.grpBoxLocation.Controls.Add(Me.btnValidateLocation)
        Me.grpBoxLocation.Controls.Add(Me.cmbDepartamento)
        Me.grpBoxLocation.Controls.Add(Me.Label11)
        Me.grpBoxLocation.Controls.Add(Me.txtColonia)
        Me.grpBoxLocation.Controls.Add(Me.Label12)
        Me.grpBoxLocation.Controls.Add(Me.txtBarrio)
        Me.grpBoxLocation.Controls.Add(Me.Label13)
        Me.grpBoxLocation.Controls.Add(Me.txtMunicipio)
        Me.grpBoxLocation.Controls.Add(Me.Label14)
        Me.grpBoxLocation.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.grpBoxLocation.Location = New System.Drawing.Point(467, 71)
        Me.grpBoxLocation.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxLocation.Name = "grpBoxLocation"
        Me.grpBoxLocation.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxLocation.Size = New System.Drawing.Size(353, 255)
        Me.grpBoxLocation.TabIndex = 17
        Me.grpBoxLocation.TabStop = False
        Me.grpBoxLocation.Text = "Ubicacion"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(156, 225)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 14)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "&Validar"
        '
        'btnValidateLocation
        '
        Me.btnValidateLocation.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._626827
        Me.btnValidateLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnValidateLocation.FlatAppearance.BorderSize = 0
        Me.btnValidateLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValidateLocation.Location = New System.Drawing.Point(143, 177)
        Me.btnValidateLocation.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnValidateLocation.Name = "btnValidateLocation"
        Me.btnValidateLocation.Size = New System.Drawing.Size(79, 40)
        Me.btnValidateLocation.TabIndex = 27
        Me.btnValidateLocation.UseVisualStyleBackColor = True
        '
        'cmbDepartamento
        '
        Me.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartamento.FormattingEnabled = True
        Me.cmbDepartamento.Items.AddRange(New Object() {"SELECCIONAR", "ISLAS DE LA BAHÍA", "CORTÉS", "ATLÁNTIDA", "COLÓN", "GRACIAS A DIOS", "COPÁN", "SANTA BÁRBARA", "YORO", "OLANCHO", "OCOTEPEQUE", "LEMPIRA", "INTIBUCA", "COMAYAGUA", "FRANCISCO MORAZÁN", "EL PARAÍSO", "LA PAZ", "VALLE", "CHOLUTECA"})
        Me.cmbDepartamento.Location = New System.Drawing.Point(143, 26)
        Me.cmbDepartamento.Name = "cmbDepartamento"
        Me.cmbDepartamento.Size = New System.Drawing.Size(164, 21)
        Me.cmbDepartamento.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(18, 124)
        Me.Label11.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 14)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Colonia"
        '
        'txtColonia
        '
        Me.txtColonia.Location = New System.Drawing.Point(143, 122)
        Me.txtColonia.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(164, 21)
        Me.txtColonia.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 92)
        Me.Label12.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 14)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Barrio"
        '
        'txtBarrio
        '
        Me.txtBarrio.Location = New System.Drawing.Point(143, 91)
        Me.txtBarrio.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtBarrio.Name = "txtBarrio"
        Me.txtBarrio.Size = New System.Drawing.Size(164, 21)
        Me.txtBarrio.TabIndex = 8
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(18, 61)
        Me.Label13.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(73, 14)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Municipio"
        '
        'txtMunicipio
        '
        Me.txtMunicipio.Location = New System.Drawing.Point(143, 60)
        Me.txtMunicipio.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.txtMunicipio.Name = "txtMunicipio"
        Me.txtMunicipio.Size = New System.Drawing.Size(164, 21)
        Me.txtMunicipio.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 29)
        Me.Label14.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 14)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Departamento"
        '
        'grpBoxSerial
        '
        Me.grpBoxSerial.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.grpBoxSerial.Controls.Add(Me.Label19)
        Me.grpBoxSerial.Controls.Add(Me.Button2)
        Me.grpBoxSerial.Controls.Add(Me.txtSerialNumber)
        Me.grpBoxSerial.Controls.Add(Me.Label3)
        Me.grpBoxSerial.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.grpBoxSerial.Location = New System.Drawing.Point(467, 356)
        Me.grpBoxSerial.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxSerial.Name = "grpBoxSerial"
        Me.grpBoxSerial.Padding = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.grpBoxSerial.Size = New System.Drawing.Size(353, 104)
        Me.grpBoxSerial.TabIndex = 18
        Me.grpBoxSerial.TabStop = False
        Me.grpBoxSerial.Text = "Asignacion de Computadora"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(223, 70)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 14)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "&Validar"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._626827
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(208, 23)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(90, 38)
        Me.Button2.TabIndex = 18
        Me.Button2.UseVisualStyleBackColor = True
        '
        'errorValidarGeneral
        '
        Me.errorValidarGeneral.ContainerControl = Me
        '
        'errorValidarDireccion
        '
        Me.errorValidarDireccion.ContainerControl = Me
        '
        'errorValidarPC
        '
        Me.errorValidarPC.ContainerControl = Me
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(410, 520)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 14)
        Me.Label16.TabIndex = 30
        Me.Label16.Text = "&Agregar"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Metropolis Semi Bold", 8.25!)
        Me.Label17.Location = New System.Drawing.Point(701, 523)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 11)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "&Nuevo/Limpiar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.PictureBox1.Image = Global.pruebaConexion.My.Resources.Resources.clientes
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'clearBtn
        '
        Me.clearBtn.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._70899
        Me.clearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.clearBtn.FlatAppearance.BorderSize = 0
        Me.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clearBtn.Location = New System.Drawing.Point(720, 475)
        Me.clearBtn.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(54, 47)
        Me.clearBtn.TabIndex = 28
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.BackgroundImage = Global.pruebaConexion.My.Resources.Resources._347781
        Me.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAddUser.FlatAppearance.BorderSize = 0
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Location = New System.Drawing.Point(401, 472)
        Me.btnAddUser.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(83, 47)
        Me.btnAddUser.TabIndex = 27
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(849, 50)
        Me.Panel1.TabIndex = 32
        '
        'agregarUsuarioWizard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(849, 605)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.grpBoxSerial)
        Me.Controls.Add(Me.grpBoxLocation)
        Me.Controls.Add(Me.grpBoxGeneralData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.Name = "agregarUsuarioWizard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "agregarUsuarioWizard"
        Me.grpBoxGeneralData.ResumeLayout(False)
        Me.grpBoxGeneralData.PerformLayout()
        Me.grpBoxLocation.ResumeLayout(False)
        Me.grpBoxLocation.PerformLayout()
        Me.grpBoxSerial.ResumeLayout(False)
        Me.grpBoxSerial.PerformLayout()
        CType(Me.errorValidarGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorValidarDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorValidarPC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents grpBoxGeneralData As GroupBox
    Friend WithEvents cmbPosition As ComboBox
    Friend WithEvents chkNonGenre As CheckBox
    Friend WithEvents chkFemale As CheckBox
    Friend WithEvents chkMale As CheckBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtAge As TextBox
    Friend WithEvents btnValidateUserData As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSecondLastName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFirstLastName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSecondName As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIdentity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSerialNumber As TextBox
    Friend WithEvents grpBoxLocation As GroupBox
    Friend WithEvents cmbDepartamento As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBarrio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtMunicipio As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents grpBoxSerial As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents errorValidarGeneral As ErrorProvider
    Friend WithEvents errorValidarDireccion As ErrorProvider
    Friend WithEvents errorValidarPC As ErrorProvider
    Friend WithEvents btnValidateLocation As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel1 As Panel
End Class
