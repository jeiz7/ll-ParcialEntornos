Imports System.ComponentModel

Public Class modificarUsuarioWizard

    Dim conexion As conexion = New conexion()

    Dim codigoAModificar As String
    Dim primerNombre As String
    Dim segundoNombre As String
    Dim primerApellido As String
    Dim segundoApellido As String
    Dim identidad As String
    Dim edad As String
    Dim sexo As String
    Dim cargo As String
    Dim departamento As String
    Dim municipio As String
    Dim barrio As String
    Dim colonia As String
    Dim codigoPC As String

    Dim estadoVerificacionPersonalData As Integer
    Dim estadoVerificacionLocationData As Integer

    Private Sub clearScreen()
        txtFindUserCode.Enabled = True
        chkModifyLocationData.Checked = False
        chkModifyPersonalData.Checked = False
        chkModifyBOTH.Checked = False

        chkModifyLocationData.Enabled = False
        chkModifyPersonalData.Enabled = False
        chkModifyBOTH.Enabled = False

        txtNewCode.Clear()
        txtIdentity.Clear()
        txtFullName.Clear()
        txtAge.Clear()
        chkMale.Checked = False
        chkFemale.Checked = False
        chkNonGenre.Checked = False
        cmbPosition.SelectedIndex = 0
        txtFindUserCode.Clear()

        grpBoxLocation.Enabled = False
        grpBoxPersonalData.Enabled = False


        txtSerialNumber.Clear()

        cmbDepartamento.SelectedIndex = 0
        txtMunicipio.Clear()
        txtBarrio.Clear()
        txtColonia.Clear()


        txtDataUpdate.Enabled = False

    End Sub

    Private Sub modificarUsuarioWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewCode.Enabled = False
        txtIdentity.Enabled = False
        txtFullName.Enabled = False
        grpBoxLocation.Enabled = False
        grpBoxPersonalData.Enabled = False
        chkModifyLocationData.Enabled = False
        chkModifyPersonalData.Enabled = False
        chkModifyBOTH.Enabled = False
        txtDataUpdate.Enabled = False
        cmbPosition.SelectedIndex = 0
        cmbDepartamento.SelectedIndex = 0
    End Sub

    Private Sub chkModifyPersonalData_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyPersonalData.CheckedChanged
        If chkModifyPersonalData.Checked = True Then
            grpBoxPersonalData.Enabled = True

            chkModifyBOTH.Checked = False
            chkModifyLocationData.Checked = False

            chkModifyBOTH.Enabled = False
            chkModifyLocationData.Enabled = False

        Else
            grpBoxPersonalData.Enabled = False

            chkModifyBOTH.Enabled = True
            chkModifyLocationData.Enabled = True
        End If
    End Sub

    Private Sub chkModifyLocationData_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyLocationData.CheckedChanged
        If chkModifyLocationData.Checked = True Then
            grpBoxLocation.Enabled = True


            chkModifyBOTH.Checked = False
            chkModifyPersonalData.Checked = False

            chkModifyBOTH.Enabled = False
            chkModifyPersonalData.Enabled = False
        Else
            grpBoxLocation.Enabled = False


            chkModifyBOTH.Enabled = True
            chkModifyPersonalData.Enabled = True
        End If
    End Sub

    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click



        Try
            If txtFindUserCode.Text <> String.Empty And txtFindUserCode.TextLength = 5 Then


                codigoAModificar = txtFindUserCode.Text

                If conexion.comprobarExistenciaUsuario(codigoAModificar) = 1 Then

                    chkModifyPersonalData.Enabled = True
                    chkModifyLocationData.Enabled = True
                    chkModifyBOTH.Enabled = True

                    txtNewCode.Text = codigoAModificar
                    identidad = conexion.retornarValorIdentidad(codigoAModificar)

                    primerNombre = conexion.retornarValorPrimerNombre(codigoAModificar)
                    segundoNombre = conexion.retornarValorSegundoNombre(codigoAModificar)
                    primerApellido = conexion.retornarValorPrimerApellido(codigoAModificar)
                    segundoApellido = conexion.retornarValorSegundoApellido(codigoAModificar)

                    departamento = conexion.retornarValorDepto(codigoAModificar)
                    municipio = conexion.retornarValorMunicipio(codigoAModificar)
                    barrio = conexion.retornarValorBarrio(codigoAModificar)
                    colonia = conexion.retornarValorColonia(codigoAModificar)

                    edad = conexion.retornarValorEdad(codigoAModificar)

                    sexo = conexion.retornarValorSexo(codigoAModificar)

                    codigoPC = conexion.retornarValor(codigoAModificar)

                    Select Case sexo
                        Case "M"
                            chkMale.Checked = True
                        Case "F"
                            chkFemale.Checked = True
                        Case "N"
                            chkNonGenre.Checked = True

                    End Select

                    cargo = conexion.retornarValorCargo(codigoAModificar)

                    txtIdentity.Text = identidad
                    txtFullName.Text = primerNombre & " " & segundoNombre & " " & primerApellido & " " & segundoApellido
                    txtAge.Text = edad
                    cmbPosition.SelectedItem = cargo

                    cmbDepartamento.SelectedItem = departamento
                    txtMunicipio.Text = municipio
                    txtBarrio.Text = barrio
                    txtColonia.Text = colonia


                    txtSerialNumber.Text = (Microsoft.VisualBasic.Left(codigoPC, 5))

                    MsgBox("EMPLEADO ENCONTRADO", vbInformation)
                    txtFindUserCode.Enabled = False

                Else
                    MsgBox("El empleado no esta registrado!", vbCritical)

                End If
            Else
                MsgBox("Revise el codigo proporcionado!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnValidateUserData_Click(sender As Object, e As EventArgs) Handles btnValidateUserData.Click
        Dim tempSerial As String



        Try


            tempSerial = conexion.retornarValor(codigoAModificar)


            If IsNumeric(txtAge.Text) = True And txtAge.Text <> String.Empty And (Val(txtAge.Text) > 18 And Val(txtAge.Text) < 100) Then

                If chkFemale.Checked = True Or chkMale.Checked = True Or chkNonGenre.Checked = True Then

                    If cmbPosition.SelectedIndex <> 0 Then

                        If txtSerialNumber.Text <> String.Empty And txtSerialNumber.TextLength = 5 Then

                            If conexion.comprobarExistenciaPC(UCase(txtSerialNumber.Text)) = 1 Then


                                If Microsoft.VisualBasic.Left(UCase(txtSerialNumber.Text), 5) = Microsoft.VisualBasic.Left(UCase(tempSerial), 5) Then

                                    edad = Val(txtAge.Text)
                                    cargo = cmbPosition.SelectedItem


                                    If chkFemale.Checked = True Then
                                        sexo = "F"
                                    ElseIf chkMale.Checked = True Then
                                        sexo = "M"
                                    Else
                                        sexo = "N"
                                    End If


                                    If chkModifyPersonalData.Checked = True Then

                                        grpBoxPersonalData.Enabled = False
                                        txtDataUpdate.Enabled = True
                                        chkModifyBOTH.Enabled = False
                                        chkModifyLocationData.Enabled = False
                                        chkModifyPersonalData.Enabled = False

                                    ElseIf chkModifyBOTH.Checked = True Then
                                        grpBoxPersonalData.Enabled = False
                                        grpBoxLocation.Enabled = True
                                        chkModifyBOTH.Enabled = False
                                        chkModifyLocationData.Enabled = False
                                        chkModifyPersonalData.Enabled = False

                                    End If
                                    MsgBox("DATOS CORRECTOS", vbInformation)


                                ElseIf txtSerialNumber.Text <> tempSerial And conexion.comprobarSerial(txtSerialNumber.Text) = 2 Then

                                    edad = Val(txtAge.Text)
                                    cargo = cmbPosition.SelectedItem


                                    If chkFemale.Checked = True Then
                                        sexo = "F"
                                    ElseIf chkMale.Checked = True Then
                                        sexo = "M"
                                    Else
                                        sexo = "N"
                                    End If

                                    If chkModifyPersonalData.Checked = True Then

                                        grpBoxPersonalData.Enabled = False
                                        txtDataUpdate.Enabled = True

                                        chkModifyBOTH.Enabled = False
                                        chkModifyLocationData.Enabled = False
                                        chkModifyPersonalData.Enabled = False

                                    ElseIf chkModifyBOTH.Checked = True Then
                                        grpBoxPersonalData.Enabled = False
                                        grpBoxLocation.Enabled = True

                                        chkModifyBOTH.Enabled = False
                                        chkModifyLocationData.Enabled = False
                                        chkModifyPersonalData.Enabled = False

                                    End If
                                    MsgBox("DATOS CORRECTOS", vbInformation)



                                ElseIf txtSerialNumber.Text <> tempSerial And conexion.comprobarSerial(txtSerialNumber.Text) = 1 Then
                                    MsgBox("Esta computadora ya esta asignada a un usuario", vbCritical)

                                End If


                            Else
                                MsgBox("Esta computadora no Existe", vbCritical)
                            End If


                        Else
                            MsgBox("Revisa el serial proporcionado!", vbCritical)
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnValidateLocation_Click(sender As Object, e As EventArgs) Handles btnValidateLocation.Click
        Try


            If cmbDepartamento.SelectedIndex <> 0 Then
                If IsNumeric(txtMunicipio.Text) = False And txtMunicipio.Text <> String.Empty Then
                    If (txtBarrio.Text <> String.Empty And IsNumeric(txtBarrio.Text) = False) Or (txtColonia.Text <> String.Empty And IsNumeric(txtBarrio.Text) = False) Then


                        departamento = cmbDepartamento.SelectedItem
                        municipio = txtMunicipio.Text
                        barrio = txtBarrio.Text
                        colonia = txtColonia.Text

                        If chkModifyLocationData.Checked = True Then

                            grpBoxLocation.Enabled = False
                            txtDataUpdate.Enabled = True

                        ElseIf chkModifyBOTH.Checked = True Then
                            grpBoxLocation.Enabled = False
                            txtDataUpdate.Enabled = True
                        End If
                        MsgBox("DATOS CORRECTOS", vbInformation)
                        chkModifyBOTH.Enabled = False
                        chkModifyLocationData.Enabled = False
                        chkModifyPersonalData.Enabled = False
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clearScreen()
    End Sub

    Private Sub grpBoxPersonalData_Enter(sender As Object, e As EventArgs) Handles grpBoxPersonalData.Enter

    End Sub

    Private Sub chkModifyBOTH_CheckedChanged(sender As Object, e As EventArgs) Handles chkModifyBOTH.CheckedChanged
        If chkModifyBOTH.Checked = True Then
            grpBoxPersonalData.Enabled = True

            chkModifyPersonalData.Checked = False
            chkModifyLocationData.Checked = False

            chkModifyPersonalData.Enabled = False
            chkModifyLocationData.Enabled = False

        Else
            grpBoxPersonalData.Enabled = False


            chkModifyPersonalData.Enabled = True
            chkModifyLocationData.Enabled = True
        End If
    End Sub

    Private Sub txtDataUpdate_Click(sender As Object, e As EventArgs) Handles txtDataUpdate.Click

        Try

            If conexion.actualizarEmpleados(codigoAModificar, Microsoft.VisualBasic.Left(UCase(txtSerialNumber.Text), 5), identidad, primerNombre, segundoNombre, primerApellido, segundoApellido, edad, sexo, UCase(cargo)) And (conexion.actualizarDirecciones(codigoAModificar, UCase(departamento), UCase(municipio), UCase(barrio), UCase(colonia))) Then
                MsgBox("Datos Actualizados", vbInformation)
                clearScreen()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub chkFemale_CheckedChanged(sender As Object, e As EventArgs) Handles chkFemale.CheckedChanged
        If chkFemale.Checked = True Then
            chkMale.Checked = False
            chkNonGenre.Checked = False

        End If
    End Sub

    Private Sub chkMale_CheckedChanged(sender As Object, e As EventArgs) Handles chkMale.CheckedChanged
        If chkMale.Checked = True Then
            chkFemale.Checked = False
            chkNonGenre.Checked = False

        End If
    End Sub

    Private Sub chkNonGenre_CheckedChanged(sender As Object, e As EventArgs) Handles chkNonGenre.CheckedChanged
        If chkNonGenre.Checked = True Then
            chkFemale.Checked = False
            chkMale.Checked = False

        End If
    End Sub



    Private Sub txtFindUserCode_Validating(sender As Object, e As CancelEventArgs) Handles txtFindUserCode.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "El Codigo es un campo obligatorio para modificar")

        End If
    End Sub
    Private Sub txtFindUserCode_MouseHover(sender As Object, e As EventArgs) Handles txtFindUserCode.MouseHover
        ToolTip1.SetToolTip(txtFindUserCode, "Ingrese el codigo del usuario a modificar")
        ToolTip1.ToolTipTitle = "Codigo Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnValidar_MouseHover(sender As Object, e As EventArgs) Handles btnValidar.MouseHover
        ToolTip1.SetToolTip(btnValidar, "Buscar")
    End Sub

    Private Sub txtNewCode_MouseHover(sender As Object, e As EventArgs) Handles txtNewCode.MouseHover
        ToolTip1.SetToolTip(txtNewCode, "Ingrese un identificador de 5 digitos para el empleado")
        ToolTip1.ToolTipTitle = "Codigo del Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtIdentity_MouseHover(sender As Object, e As EventArgs) Handles txtIdentity.MouseHover
        ToolTip1.SetToolTip(txtIdentity, "Ingrese la identidad del empleado")
        ToolTip1.ToolTipTitle = "Identidad del Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub



    Private Sub txtFullName_MouseHover(sender As Object, e As EventArgs) Handles txtFullName.MouseHover
        ToolTip1.SetToolTip(txtFullName, "Ingrese el nombre completo del empleado (OBLIGATORIO)")
        ToolTip1.ToolTipTitle = "Nombre"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtAge_MouseHover(sender As Object, e As EventArgs) Handles txtAge.MouseHover
        ToolTip1.SetToolTip(txtAge, "Ingrese la edad del empleado")
        ToolTip1.ToolTipTitle = "Edad"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkMale_MouseHover(sender As Object, e As EventArgs) Handles chkMale.MouseHover
        ToolTip1.SetToolTip(chkMale, "Sexo Masculino")
        ToolTip1.ToolTipTitle = "Sexo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkFemale_MouseHover(sender As Object, e As EventArgs) Handles chkFemale.MouseHover
        ToolTip1.SetToolTip(chkFemale, "Sexo Femenino")
        ToolTip1.ToolTipTitle = "Sexo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub chkNonGenre_MouseHover(sender As Object, e As EventArgs) Handles chkNonGenre.MouseHover
        ToolTip1.SetToolTip(chkNonGenre, "Sexo No Definido")
        ToolTip1.ToolTipTitle = "Sexo"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub cmbPosition_MouseHover(sender As Object, e As EventArgs) Handles cmbPosition.MouseHover
        ToolTip1.SetToolTip(cmbPosition, "Seleccione el cargo del empleado")
        ToolTip1.ToolTipTitle = "Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnValidateUserData_MouseHover(sender As Object, e As EventArgs) Handles btnValidateUserData.MouseHover
        ToolTip1.SetToolTip(btnValidateUserData, "Verifica los datos ingresados anteriormente")
        ToolTip1.ToolTipTitle = "Verificacion de Datos Generales"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub cmbDepartamento_MouseHover(sender As Object, e As EventArgs) Handles cmbDepartamento.MouseHover
        ToolTip1.SetToolTip(cmbDepartamento, "Seleccione el departamento")
        ToolTip1.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtMunicipio_MouseHover(sender As Object, e As EventArgs) Handles txtMunicipio.MouseHover
        ToolTip1.SetToolTip(txtMunicipio, "Ingrese el municipio")
        ToolTip1.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtBarrio_MouseHover(sender As Object, e As EventArgs) Handles txtBarrio.MouseHover
        ToolTip1.SetToolTip(txtBarrio, "Indique el Barrio")
        ToolTip1.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub txtColonia_MouseHover(sender As Object, e As EventArgs) Handles txtColonia.MouseHover
        ToolTip1.SetToolTip(txtColonia, "Indique la Colonia")
        ToolTip1.ToolTipTitle = "Lugar de Origen/Residencia"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnValidateLocation_MouseHover(sender As Object, e As EventArgs) Handles btnValidateLocation.MouseHover
        ToolTip1.SetToolTip(btnValidateLocation, "Verifica los datos ingresados anteriormente")
        ToolTip1.ToolTipTitle = "Verificacion de Datos de Localizacion"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSerialNumber_MouseHover(sender As Object, e As EventArgs) Handles txtSerialNumber.MouseHover
        ToolTip1.SetToolTip(txtSerialNumber, "Ingrese el serial de la computadora que se le asignará al empleado")
        ToolTip1.ToolTipTitle = "Serial/Service Tag"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        ToolTip1.SetToolTip(btnValidateLocation, "Limpiar los Datos Ingresados")
        ToolTip1.ToolTipTitle = "Limpiar/Nueva Modificacion"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDataUpdate_MouseHover(sender As Object, e As EventArgs) Handles txtDataUpdate.MouseHover
        ToolTip1.SetToolTip(btnValidateLocation, "Se actualizaran los datos del empleado ")
        ToolTip1.ToolTipTitle = "Actualizar Datos de Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuPrincipal.Show()
    End Sub
End Class