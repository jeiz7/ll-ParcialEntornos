Imports System.ComponentModel

Public Class registrarMantenimientoWizard

    Dim conexion As conexion = New conexion()
    Dim codigoEmpleado As String
    Dim ServiceTag As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grbRegistro_Mant.Enabled = False
    End Sub



    Private Sub btnValidar_Click(sender As Object, e As EventArgs) Handles btnValidar.Click



        Try
            If IsNumeric(txtCodEmpleado.Text) = True And txtCodEmpleado.Text <> String.Empty And txtCodEmpleado.TextLength = 5 Then

                If conexion.comprobarExistenciaUsuario(txtCodEmpleado.Text) = 1 Then
                    codigoEmpleado = txtCodEmpleado.Text
                    conexion.Consulta(" select empleados.codigoEmpleado as 'ID', CONCAT(empleados.primerNombre,' ', empleados.primerApellido) as 'Nombre', empleados.puestoTrabajo as 'Cargo', computadorasAsignadas.serviceTag as 'CodigoPC', computadorasAsignadas.marca as 'Marca PC', computadorasAsignadas.modelo as 'Modelo PC'  FROM empleados INNER JOIN computadorasAsignadas ON empleados.codigoEmpleado = '" & codigoEmpleado & "' and empleados.idComputadora = computadorasAsignadas.serviceTag  ", "data")
                    dgvCompu_Asignada.DataSource = conexion.ds.Tables("data")

                    ServiceTag = conexion.retornarValor(codigoEmpleado)
                    conexion.Consulta(" select id_Compu as 'Service Tag', dia as 'Fecha', tipoMantenimiento as 'Mantenimiento', componentesAfectados as 'Componente', otrosComponentes as 'Otro Componente', descripcion as 'Descripcion' FROM historialMantenimientos where id_Compu = '" & ServiceTag & "'", "data")
                    dgvHistorial_Mantenimiento.DataSource = conexion.ds.Tables("data")


                    grbRegistro_Mant.Enabled = True
                    txtCodEmpleado.Enabled = False

                Else
                    MsgBox("El empleado no existe!", vbCritical)
                End If

            Else
                MsgBox("Revise el codigo proporcionado", vbCritical)
            End If



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim fecha As String
        Dim tipoMantenimiento As String
        Dim componentes As String
        Dim otrosComponentes As String
        Dim descripcion As String

        Dim temporalFechaAnterior As String

        Try

            If mktFecha.Text <> String.Empty And mktFecha.MaskFull Then

                If cmbTip_Mantenimiento.SelectedItem <> "" Then

                    If cmbComponentes.SelectedItem <> "" Then
                        If cmbOtros.SelectedItem <> "" Then

                            If cmbComponentes.SelectedItem <> cmbOtros.SelectedItem Then


                                If txtDescripcion.Text <> String.Empty Then

                                    fecha = mktFecha.Text

                                    tipoMantenimiento = cmbTip_Mantenimiento.SelectedItem
                                    componentes = cmbComponentes.SelectedItem
                                    otrosComponentes = cmbOtros.SelectedItem
                                    descripcion = txtDescripcion.Text

                                    temporalFechaAnterior = conexion.retornarFechaMantenimiento(ServiceTag)

                                    If Mid(mktFecha.Text, 4, 2) = Mid(temporalFechaAnterior, 4, 2) Then
                                        MsgBox("Has traido la computadora 2 veces en menos de un mes, Se mas cuidadoso!", vbExclamation)
                                    End If

                                    If conexion.insertarManutencion(ServiceTag, fecha, tipoMantenimiento, componentes, otrosComponentes, descripcion) Then
                                        MsgBox("Se ingreso el Mantenimiento", vbInformation)

                                        conexion.Consulta(" select id_Compu as 'Service Tag', dia as 'Fecha', tipoMantenimiento as 'Mantenimiento', componentesAfectados as 'Componente', otrosComponentes as 'Otro Componente', descripcion as 'Descripcion'   FROM historialMantenimientos where id_Compu = '" & ServiceTag & "'", "data")
                                        dgvHistorial_Mantenimiento.DataSource = conexion.ds.Tables("data")

                                        txtCodEmpleado.Clear()
                                        txtCodEmpleado.Enabled = True
                                        mktFecha.Clear()
                                        cmbTip_Mantenimiento.ResetText()
                                        cmbComponentes.ResetText()
                                        cmbOtros.ResetText()
                                        txtDescripcion.Clear()
                                        dgvHistorial_Mantenimiento.DataSource = ""
                                        dgvCompu_Asignada.DataSource = ""



                                        grbRegistro_Mant.Enabled = False
                                    Else
                                        MsgBox("Error Inesperado", vbCritical)
                                    End If


                                Else
                                    MsgBox("Proporciona una breve descripcion del problema", vbCritical)
                                End If
                            Else
                                MsgBox("No puedes agregar el mismo mantenimiento!", vbCritical)

                            End If
                        Else
                            MsgBox("Selecciona una opcion en Otros componentes", vbCritical)
                        End If
                    Else
                        MsgBox("Selecciona el componente afectado", vbCritical)
                    End If
                Else
                    MsgBox("Selecciona el tipo de mantenimiento", vbCritical)
                End If

            Else
                MsgBox("Revisa la fecha ingresada", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtCodEmpleado.Clear()
        txtCodEmpleado.Enabled = True
        mktFecha.Clear()
        cmbTip_Mantenimiento.ResetText()
        cmbComponentes.ResetText()
        cmbOtros.ResetText()
        txtDescripcion.Clear()
        dgvHistorial_Mantenimiento.DataSource = ""
        dgvCompu_Asignada.DataSource = ""

        grbRegistro_Mant.Enabled = False
    End Sub



    Private Sub txtCodEmpleado_Validating(sender As Object, e As CancelEventArgs) Handles txtCodEmpleado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub
    Private Sub txtCodEmpleado_MouseHover(sender As Object, e As EventArgs) Handles txtCodEmpleado.MouseHover
        ToolTip1.SetToolTip(txtCodEmpleado, "Ingrese un identificador de 5 digitos para el empleado")
        ToolTip1.ToolTipTitle = "Codigo del Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnValidar_MouseHover(sender As Object, e As EventArgs) Handles btnValidar.MouseHover
        ToolTip1.SetToolTip(btnValidar, "Se verifica que el empleado existe")
        ToolTip1.ToolTipTitle = "Verificar"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        ToolTip1.SetToolTip(Button3, "Se agregara un nuevo mantenimiento")
        ToolTip1.ToolTipTitle = "Nuevo Mantenimiento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub mktFecha_MouseHover(sender As Object, e As EventArgs) Handles mktFecha.MouseHover
        ToolTip1.SetToolTip(mktFecha, "Ingrese la fecha en se realizo el mantenimiento")
        ToolTip1.ToolTipTitle = "Fecha Mantenimiento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbComponentes_MouseHover(sender As Object, e As EventArgs) Handles cmbComponentes.MouseHover
        ToolTip1.SetToolTip(cmbComponentes, "Ingrese el componente al que se le realizo mantenimient")
        ToolTip1.ToolTipTitle = "Componente Mantenimiento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtDescripcion_MouseHover(sender As Object, e As EventArgs) Handles txtDescripcion.MouseHover
        ToolTip1.SetToolTip(txtDescripcion, "Agregue una Descripcion del Mantenimiento")
        ToolTip1.ToolTipTitle = "Descripcion Mantenimiento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub


    Private Sub cmbTip_Mantenimiento_MouseHover(sender As Object, e As EventArgs) Handles cmbTip_Mantenimiento.MouseHover
        ToolTip1.SetToolTip(cmbTip_Mantenimiento, "Ingreseque tipo de mantenimiento se realizo")
        ToolTip1.ToolTipTitle = "Tipo de Mantenimiento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbOtros_MouseHover(sender As Object, e As EventArgs) Handles cmbOtros.MouseHover
        ToolTip1.SetToolTip(cmbOtros, "Ingrese otro tipo de mantenimiento que se haya realizado")
        ToolTip1.ToolTipTitle = "Otro Mantenimiento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAgregar_MouseHover(sender As Object, e As EventArgs) Handles btnAgregar.MouseHover
        ToolTip1.SetToolTip(btnAgregar, "Se agregara el mantenimiento")
        ToolTip1.ToolTipTitle = "Agregar Mantenimiento"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) 
        Me.Close()
        MenuPrincipal.Show()
    End Sub
End Class


