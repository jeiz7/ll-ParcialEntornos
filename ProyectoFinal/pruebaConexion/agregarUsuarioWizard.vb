Imports System.ComponentModel

Public Class agregarUsuarioWizard

    Dim conexion As conexion = New conexion()

    Dim temporalCodigo As String
    Dim temporalIdentidad As String
    Dim temporalPrimerNombre As String
    Dim temporalSegundoNombre As String
    Dim temporalPrimerApellido As String
    Dim temporalSegundoApellido As String
    Dim temporalEdad As Integer
    Dim temporalSexo As String
    Dim temporalCargo As String
    Dim temporalDepto As String
    Dim temporalMunicip As String
    Dim temporalBarrio As String
    Dim temporalColonia As String
    Dim temporalSerial As String

    Private Sub limpiar()
        txtNewCode.Clear()
        txtIdentity.Clear()
        txtFirstLastName.Clear()
        txtFirstName.Clear()
        txtSecondLastName.Clear()
        txtSecondName.Clear()
        txtAge.Clear()
        chkFemale.Checked = False
        chkMale.Checked = False
        chkNonGenre.Checked = False
        cmbPosition.SelectedIndex = 0
        cmbDepartamento.SelectedIndex = 0
        txtMunicipio.Clear()
        txtBarrio.Clear()
        txtColonia.Clear()
        txtSerialNumber.Clear()

        btnAddUser.Enabled = False
        grpBoxLocation.Enabled = False
        grpBoxSerial.Enabled = False
        grpBoxGeneralData.Enabled = True

    End Sub


    Private Sub btnValidateUserData_Click(sender As Object, e As EventArgs) Handles btnValidateUserData.Click
        Dim resultadoExistencia As Integer

        Dim codigoEmpleadoNuevo As String

        Try

            If IsNumeric(txtNewCode.Text) = True And txtNewCode.Text <> String.Empty And txtNewCode.TextLength = 5 Then

                codigoEmpleadoNuevo = txtNewCode.Text

                resultadoExistencia = conexion.comprobarExistenciaUsuario(codigoEmpleadoNuevo)

                If resultadoExistencia = 2 Then

                    If IsNumeric(txtIdentity.Text) = True And txtIdentity.Text <> String.Empty And txtIdentity.TextLength = 13 And (conexion.comprobarExistenciaIdentidad(txtIdentity.Text)) = 2 Then

                        If IsNumeric(txtFirstName.Text) = False And IsNumeric(txtFirstLastName) = False And txtFirstName.Text <> String.Empty And txtFirstLastName.Text <> String.Empty Then

                            If IsNumeric(txtAge.Text) = True And txtAge.Text <> String.Empty And (Val(txtAge.Text) > 18 And Val(txtAge.Text) < 100) Then

                                If chkFemale.Checked = True Or chkMale.Checked = True Or chkNonGenre.Checked = True Then

                                    If cmbPosition.SelectedIndex <> 0 Then

                                        MsgBox("DATOS VALIDOS!", vbInformation)
                                        grpBoxLocation.Enabled = True
                                        grpBoxGeneralData.Enabled = False

                                        temporalCodigo = txtNewCode.Text
                                        temporalIdentidad = txtIdentity.Text
                                        temporalPrimerNombre = txtFirstName.Text
                                        temporalSegundoNombre = txtSecondName.Text
                                        temporalPrimerApellido = txtFirstLastName.Text
                                        temporalSegundoApellido = txtSecondLastName.Text
                                        temporalEdad = Val(txtAge.Text)
                                        temporalCargo = cmbPosition.SelectedItem


                                        If chkFemale.Checked = True Then
                                            temporalSexo = "F"
                                        ElseIf chkMale.Checked = True Then
                                            temporalSexo = "M"
                                        Else
                                            temporalSexo = "N"
                                        End If


                                    Else
                                        MsgBox("Debes seleccionar un cargo!", vbCritical)
                                    End If
                                Else
                                    MsgBox("Debes seleccionar un genero!!", vbCritical)
                                End If
                            Else
                                MsgBox("Revisa la edad ingresada!", vbCritical)
                            End If

                        Else
                            MsgBox("Revisa los nombres ingresados!", vbCritical)
                        End If
                    Else
                        MsgBox("Revisa la Identidad proporcionada!", vbCritical)
                    End If

                ElseIf resultadoExistencia = 1 Then
                    MsgBox("El codigo Ingresado ya esta en uso, escriba otro!", vbCritical)
                End If

            Else
                MsgBox("Revisa el codigo proporcionado!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkMale_CheckedChanged(sender As Object, e As EventArgs) Handles chkMale.CheckedChanged
        If chkMale.Checked = True Then
            chkFemale.Checked = False
            chkNonGenre.Checked = False

        End If
    End Sub

    Private Sub chkFemale_CheckedChanged(sender As Object, e As EventArgs) Handles chkFemale.CheckedChanged
        If chkFemale.Checked = True Then
            chkMale.Checked = False
            chkNonGenre.Checked = False

        End If
    End Sub

    Private Sub chkNonGenre_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonGenre.CheckedChanged
        If chkNonGenre.Checked = True Then
            chkFemale.Checked = False
            chkMale.Checked = False

        End If
    End Sub

    Private Sub agregarUsuarioWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpBoxLocation.Enabled = False
        grpBoxSerial.Enabled = False
        btnAddUser.Enabled = False
        cmbPosition.SelectedIndex = 0
        cmbDepartamento.SelectedIndex = 0
    End Sub

    Private Sub btnValidateLocation_Click(sender As Object, e As EventArgs) Handles btnValidateLocation.Click

        Try


            If cmbDepartamento.SelectedIndex <> 0 Then
                If IsNumeric(txtMunicipio.Text) = False And txtMunicipio.Text <> String.Empty Then
                    If (txtBarrio.Text <> String.Empty And IsNumeric(txtBarrio.Text) = False) Or (txtColonia.Text <> String.Empty And IsNumeric(txtBarrio.Text) = False) Then
                        MsgBox("DATOS VALIDOS!", vbInformation)
                        grpBoxSerial.Enabled = True
                        grpBoxLocation.Enabled = False

                        temporalDepto = cmbDepartamento.SelectedItem
                        temporalMunicip = txtMunicipio.Text
                        temporalBarrio = txtBarrio.Text
                        temporalColonia = txtColonia.Text


                    Else
                        MsgBox("Debes ingresar un barrio o colonia!", vbCritical)
                    End If

                Else
                    MsgBox("Debes ingresar un municipio!", vbCritical)
                End If
            Else
                MsgBox("Debes seleccionar un Departamento!", vbCritical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try


            If txtSerialNumber.Text <> String.Empty And txtSerialNumber.TextLength = 5 Then

                If conexion.comprobarExistenciaPC(UCase(txtSerialNumber.Text)) = 1 Then
                    If conexion.comprobarSerial(UCase(txtSerialNumber.Text)) = 2 Then

                        btnAddUser.Enabled = True
                        grpBoxSerial.Enabled = False
                        btnAddUser.Enabled = True
                        temporalSerial = UCase(txtSerialNumber.Text)
                    Else
                        MsgBox("Esta computadora ya esta asignada a un usuario", vbCritical)
                    End If
                Else
                    MsgBox("Esta computadora no Existe", vbCritical)
                End If


            Else
                MsgBox("Revisa el serial proporcionado!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        Try



            If (conexion.insertarEmpleado(temporalCodigo, UCase(temporalSerial), temporalIdentidad, UCase(temporalPrimerNombre), UCase(temporalSegundoNombre), UCase(temporalPrimerApellido), UCase(temporalSegundoApellido), temporalEdad, temporalSexo, UCase(temporalCargo))) And (conexion.insertarDireccion(temporalCodigo, UCase(temporalDepto), UCase(temporalMunicip), UCase(temporalBarrio), UCase(temporalColonia))) Then
                MsgBox("USUARIO AGREGADO CORRECTAMENTE", vbInformation)
                limpiar()

            Else
                MsgBox("Error Inesperado", vbCritical)
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        limpiar()
    End Sub



    Private Sub txtNewCode_Validating(sender As Object, e As CancelEventArgs) Handles txtNewCode.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidarGeneral.SetError(sender, "")
        Else
            Me.errorValidarGeneral.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub



    Private Sub txtIdentity_Validating(sender As Object, e As CancelEventArgs) Handles txtIdentity.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidarGeneral.SetError(sender, "")
        Else
            Me.errorValidarGeneral.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub


    Private Sub txtFirstName_Validating(sender As Object, e As CancelEventArgs) Handles txtFirstName.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidarGeneral.SetError(sender, "")
        Else
            Me.errorValidarGeneral.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub


    Private Sub txtFirstLastName_Validating(sender As Object, e As CancelEventArgs) Handles txtFirstLastName.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidarGeneral.SetError(sender, "")
        Else
            Me.errorValidarGeneral.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub


    Private Sub txtAge_Validating(sender As Object, e As CancelEventArgs) Handles txtAge.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidarGeneral.SetError(sender, "")
        Else
            Me.errorValidarGeneral.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub



    Private Sub cmbPosition_Validating(sender As Object, e As CancelEventArgs) Handles cmbPosition.Validating
        If (cmbPosition.SelectedItem <> "") Then
            Me.errorValidarGeneral.SetError(sender, "")
        Else
            Me.errorValidarGeneral.SetError(sender, "Seleccione un Cargo")
        End If
    End Sub



    Private Sub cmbDepartamento_Validating(sender As Object, e As CancelEventArgs) Handles cmbDepartamento.Validating
        If (cmbDepartamento.SelectedItem <> "") Then
            Me.errorValidarDireccion.SetError(sender, "")
        Else
            Me.errorValidarDireccion.SetError(sender, "Seleccione un Departamento")
        End If
    End Sub


    Private Sub txtMunicipio_Validating(sender As Object, e As CancelEventArgs) Handles txtMunicipio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidarDireccion.SetError(sender, "")
        Else
            Me.errorValidarDireccion.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub

    Private Sub txtSerialNumber_Validating(sender As Object, e As CancelEventArgs) Handles txtSerialNumber.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidarPC.SetError(sender, "")
        Else
            Me.errorValidarPC.SetError(sender, "Es un campo obligatorio")
        End If

    End Sub


    Private Sub txtNewCode_MouseHover(sender As Object, e As EventArgs) Handles txtNewCode.MouseHover
        ToolTip.SetToolTip(txtNewCode, "Ingrese un identificador de 5 digitos para el empleado")
        ToolTip.ToolTipTitle = "Codigo del Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtIdentity_MouseHover(sender As Object, e As EventArgs) Handles txtIdentity.MouseHover
        ToolTip.SetToolTip(txtIdentity, "Ingrese la identidad del empleado")
        ToolTip.ToolTipTitle = "Identidad del Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtFirstName_MouseHover(sender As Object, e As EventArgs) Handles txtFirstName.MouseHover
        ToolTip.SetToolTip(txtFirstName, "Ingrese el primer nombre del empleado (OBLIGATORIO)")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtSecondName_MouseHover(sender As Object, e As EventArgs) Handles txtSecondName.MouseHover
        ToolTip.SetToolTip(txtSecondName, "Ingrese el segundo nombre del empleado")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtFirstLastName_MouseHover(sender As Object, e As EventArgs) Handles txtFirstLastName.MouseHover
        ToolTip.SetToolTip(txtFirstLastName, "Ingrese el primer apellido del empleado (OBLIGATORIO)")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtAge_MouseHover(sender As Object, e As EventArgs) Handles txtAge.MouseHover
        ToolTip.SetToolTip(txtAge, "Ingrese la edad del empleado")
        ToolTip.ToolTipTitle = "Edad"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSecondLastName_MouseHover(sender As Object, e As EventArgs) Handles txtSecondLastName.MouseHover
        ToolTip.SetToolTip(txtSecondLastName, "Ingrese el segundo apellido del empleado")
        ToolTip.ToolTipTitle = "Nombre"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub chkMale_MouseHover(sender As Object, e As EventArgs) Handles chkMale.MouseHover
        ToolTip.SetToolTip(chkMale, "Sexo Masculino")
        ToolTip.ToolTipTitle = "Sexo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkFemale_MouseHover(sender As Object, e As EventArgs) Handles chkFemale.MouseHover
        ToolTip.SetToolTip(chkFemale, "Sexo Femenino")
        ToolTip.ToolTipTitle = "Sexo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkNonGenre_MouseHover(sender As Object, e As EventArgs) Handles chkNonGenre.MouseHover
        ToolTip.SetToolTip(chkNonGenre, "Sexo No Definido")
        ToolTip.ToolTipTitle = "Sexo"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub cmbPosition_MouseHover(sender As Object, e As EventArgs) Handles cmbPosition.MouseHover
        ToolTip.SetToolTip(cmbPosition, "Seleccione el cargo del empleado")
        ToolTip.ToolTipTitle = "Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnValidateUserData_MouseHover(sender As Object, e As EventArgs) Handles btnValidateUserData.MouseHover
        ToolTip.SetToolTip(btnValidateUserData, "Verifica los datos ingresados anteriormente")
        ToolTip.ToolTipTitle = "Verificacion de Datos Generales"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover
        ToolTip.SetToolTip(cmbDepartamento, "Seleccione el departamento")
        ToolTip.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip.SetToolTip(txtMunicipio, "Ingrese el municipio")
        ToolTip.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtBarrio_MouseHover(sender As Object, e As EventArgs) Handles txtBarrio.MouseHover
        ToolTip.SetToolTip(txtBarrio, "Indique el Barrio")
        ToolTip.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtColonia_MouseHover(sender As Object, e As EventArgs) Handles txtColonia.MouseHover
        ToolTip.SetToolTip(txtColonia, "Indique la Colonia")
        ToolTip.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnValidateLocation_MouseHover(sender As Object, e As EventArgs) Handles btnValidateLocation.MouseHover
        ToolTip.SetToolTip(btnValidateLocation, "Verifica los datos ingresados anteriormente")
        ToolTip.ToolTipTitle = "Verificacion de Datos de Localizacion"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSerialNumber_MouseHover(sender As Object, e As EventArgs) Handles txtSerialNumber.MouseHover
        ToolTip.SetToolTip(txtSerialNumber, "Ingrese el serial de la computadora que se le asignará al empleado")
        ToolTip.ToolTipTitle = "Serial/Service Tag"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        ToolTip.SetToolTip(Button2, "Verifica el estado de la computadora en inventario")
        ToolTip.ToolTipTitle = "Serial/Service Tag"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAddUser_MouseHover(sender As Object, e As EventArgs) Handles btnAddUser.MouseHover
        ToolTip.SetToolTip(btnAddUser, "Registra al Empleado en la Base de Datos")
        ToolTip.ToolTipTitle = "Registro del Empleado"
        ToolTip.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub clearBtn_MouseHover(sender As Object, e As EventArgs) Handles clearBtn.MouseHover
        ToolTip.SetToolTip(clearBtn, "Registar Nevo Usuario/Limpiar")
    End Sub
End Class