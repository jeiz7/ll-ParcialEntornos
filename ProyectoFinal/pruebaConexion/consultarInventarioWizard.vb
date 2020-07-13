Imports System.ComponentModel

Public Class consultarInventarioWizard

    Dim conexion As conexion = New conexion()

    Private Sub clearScreen()

        txtSerialPC.Clear()
        txtFindEmployee.Clear()

        conexion.Consulta("select empleados.codigoEmpleado as 'ID', empleados.identidadEmpleado as 'Identidad', CONCAT(empleados.primerNombre,' ', empleados.segundoNombre, ' ', empleados.primerApellido, ' ', empleados.segundoApellido) as 'Nombre', empleados.edadEmpleado as 'Edad', empleados.sexoEmpleado as 'Sexo', empleados.puestoTrabajo as 'Cargo', Direccion.departamento as 'Departamento', Direccion.municipio as 'Municipio', Direccion.barrio as 'BARRIO', Direccion.colonia as 'Colonia'  FROM empleados INNER JOIN Direccion on empleados.codigoEmpleado = Direccion.dirEmpleado", "data")
        dgvEmpleados.DataSource = conexion.ds.Tables("data")

        conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas", "data")
        dgvComputadoras.DataSource = conexion.ds.Tables("data")
    End Sub

    Private Sub consultarInventarioWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            conexion.Consulta("select empleados.codigoEmpleado as 'ID', empleados.identidadEmpleado as 'Identidad', CONCAT(empleados.primerNombre,' ', empleados.segundoNombre, ' ', empleados.primerApellido, ' ', empleados.segundoApellido) as 'Nombre', empleados.edadEmpleado as 'Edad', empleados.sexoEmpleado as 'Sexo', empleados.puestoTrabajo as 'Cargo', Direccion.departamento as 'Departamento', Direccion.municipio as 'Municipio', Direccion.barrio as 'BARRIO', Direccion.colonia as 'Colonia'  FROM empleados INNER JOIN Direccion on empleados.codigoEmpleado = Direccion.dirEmpleado", "data")
            dgvEmpleados.DataSource = conexion.ds.Tables("data")

            conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas", "data")
            dgvComputadoras.DataSource = conexion.ds.Tables("data")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        Try

            If txtFindEmployee.Text <> String.Empty And IsNumeric(txtFindEmployee.Text) = True And txtFindEmployee.TextLength = 5 Then

                If conexion.comprobarExistenciaUsuario(txtFindEmployee.Text) = 1 Then

                    conexion.Consulta("select empleados.codigoEmpleado as 'ID', CONCAT(empleados.primerNombre,' ', empleados.segundoNombre, ' ', empleados.primerApellido, ' ', empleados.segundoApellido) as 'Nombre', empleados.edadEmpleado as 'Edad', empleados.sexoEmpleado as 'Sexo', empleados.puestoTrabajo as 'Cargo', Direccion.departamento as 'Departamento', Direccion.municipio as 'Municipio', Direccion.barrio as 'BARRIO', Direccion.colonia as 'Colonia'  FROM empleados INNER JOIN Direccion ON empleados.codigoEmpleado = '" & txtFindEmployee.Text & "' and empleados.codigoEmpleado = Direccion.dirEmpleado", "data")
                    dgvEmpleados.DataSource = conexion.ds.Tables("data")

                    MsgBox("Empleado Encontrado", vbInformation)

                Else
                    MsgBox("El Empleado no existe", vbCritical)
                End If

            Else

                MsgBox("Revisa el codigo proporcionado", vbCritical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFindPC_Click(sender As Object, e As EventArgs) Handles btnFindPC.Click
        Try
            If txtSerialPC.Text <> String.Empty And txtSerialPC.TextLength = 5 Then

                If conexion.comprobarExistenciaPC(Microsoft.VisualBasic.Left(UCase(txtSerialPC.Text), 5)) = 1 Then

                    conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas WHERE serviceTag = '" & Microsoft.VisualBasic.Left(UCase(txtSerialPC.Text), 5) & "'", "data")
                    dgvComputadoras.DataSource = conexion.ds.Tables("data")

                    MsgBox("Computadora Encontrada", vbInformation)

                Else
                    MsgBox("No hay niguna computadora con el serial ingreasdo", vbCritical)
                End If

            Else
                MsgBox("Revisa el codigo proporcionado", vbCritical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        clearScreen()

    End Sub

    Private Sub txtFindEmployee_MouseHover(sender As Object, e As EventArgs) Handles txtFindEmployee.MouseHover
        ToolTip1.SetToolTip(txtFindEmployee, "Se ingresa el codigo para buscar al Empleado")
        ToolTip1.ToolTipTitle = "Busqueda de Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscarEmpleado_MouseHover(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.MouseHover
        ToolTip1.SetToolTip(btnBuscarEmpleado, "Buscar")
    End Sub

    Private Sub btnLimpiar_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles btnLimpiar.MouseDoubleClick
        ToolTip1.SetToolTip(btnLimpiar, "Limpiar")
    End Sub

    Private Sub txtSerialPC_MouseHover(sender As Object, e As EventArgs) Handles txtSerialPC.MouseHover
        ToolTip1.SetToolTip(txtSerialPC, "Se ingresa el dodigo para buscar a la Computadora")
        ToolTip1.ToolTipTitle = "Busqueda de Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnFindPC_MouseHover(sender As Object, e As EventArgs) Handles btnFindPC.MouseHover
        ToolTip1.SetToolTip(btnFindPC, "Buscar")
    End Sub
    Private Sub txtFindEmployee_Validating(sender As Object, e As CancelEventArgs) Handles txtFindEmployee.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorValidar.SetError(sender, "")
        Else
            Me.ErrorValidar.SetError(sender, "Es un campo obligatorio")

        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub dgvEmpleados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellContentClick

    End Sub
End Class