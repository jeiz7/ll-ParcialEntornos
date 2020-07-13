Imports System.ComponentModel

Public Class eliminarWizard
    Dim conexion As conexion = New conexion()


    Private Sub clearScreen()
        grpDATAEMPLOYEE.Visible = False
        grPCDATA.Visible = False
        deleteButton.Enabled = False

        chkDeleteEmployee.Enabled = True
        chkDeleteEmployee.Checked = False

        chkDeletePC.Enabled = True
        chkDeletePC.Checked = False

        txtCodigoDelEmpleado.Clear()
        txtSerialPcToDelete.Clear()

        txtCodigoDelEmpleado.Enabled = True
        txtSerialPcToDelete.Enabled = True


    End Sub

    Private Sub eliminarWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpDATAEMPLOYEE.Visible = False
        grPCDATA.Visible = False

        deleteButton.Enabled = False


    End Sub

    Private Sub chkDeleteEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeleteEmployee.CheckedChanged
        If chkDeleteEmployee.Checked = True Then
            chkDeletePC.Checked = False
            chkDeletePC.Enabled = False
            grpDATAEMPLOYEE.Visible = True


        Else
            chkDeletePC.Enabled = True
            grpDATAEMPLOYEE.Visible = False

        End If
    End Sub

    Private Sub chkDeletePC_CheckedChanged(sender As Object, e As EventArgs) Handles chkDeletePC.CheckedChanged
        If chkDeletePC.Checked = True Then
            chkDeleteEmployee.Checked = False
            chkDeleteEmployee.Enabled = False
            grPCDATA.Visible = True


        Else
            chkDeleteEmployee.Enabled = True
            grPCDATA.Visible = False

        End If
    End Sub

    Private Sub btnFindUser_Click(sender As Object, e As EventArgs) Handles btnFindUser.Click
        Try

            If IsNumeric(txtCodigoDelEmpleado.Text) = True And txtCodigoDelEmpleado.Text <> String.Empty And txtCodigoDelEmpleado.TextLength = 5 Then

                If conexion.comprobarExistenciaUsuario(txtCodigoDelEmpleado.Text) = 1 Then

                    conexion.Consulta(" select codigoEmpleado as 'Codigo', identidadEmpleado as 'Identidad', concat(primerNombre, ' ', primerApellido) as 'Nombre', edadEmpleado as 'Edad', sexoEmpleado as 'Sexo', puestoTrabajo as 'Cargo' FROM empleados where codigoEmpleado = '" & txtCodigoDelEmpleado.Text & "'", "data")
                    dgvMostrarDetalles.DataSource = conexion.ds.Tables("data")
                    deleteButton.Enabled = True
                    txtCodigoDelEmpleado.Enabled = False


                Else
                    MsgBox("Este empleado no existe!", vbCritical)
                End If

            Else
                MsgBox("Revise el Codigo de Empleado Ingresado", vbCritical)
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub btnFindComputer_Click(sender As Object, e As EventArgs) Handles btnFindComputer.Click
        Try

            If txtSerialPcToDelete.Text <> String.Empty And txtSerialPcToDelete.TextLength = 5 Then

                If conexion.comprobarExistenciaPC(Microsoft.VisualBasic.Left(UCase(txtSerialPcToDelete.Text), 5)) = 1 Then

                    If conexion.comprobarSerial(Microsoft.VisualBasic.Left(UCase(txtSerialPcToDelete.Text), 5)) = 2 Then

                        conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas where serviceTag = '" & Microsoft.VisualBasic.Left(UCase(txtSerialPcToDelete.Text), 5) & "'", "data")
                        dgvMostrarDetalles.DataSource = conexion.ds.Tables("data")

                        txtSerialPcToDelete.Enabled = False



                        deleteButton.Enabled = True

                    Else
                        MsgBox("No se puede eliminar una PC que este asignada a un usuario", vbCritical)
                    End If


                Else
                    MsgBox("Esta computadora no existe!", vbCritical)
                End If

            Else
                MsgBox("Revise el Codigo de Empleado Ingresado", vbCritical)
            End If



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub deleteButton_Click(sender As Object, e As EventArgs) Handles deleteButton.Click
        Dim Pregunta As String
        Try

            If chkDeleteEmployee.Checked = True Then

                Pregunta = MsgBox("Deseas continuar", vbYesNo + vbQuestion, "ELIMINAR")
                If Pregunta = vbYes Then
                    MsgBox("Elegiste Sí")

                    If conexion.eliminarEmpleado(txtCodigoDelEmpleado.Text) Then
                        MsgBox("ELIMINADO", vbInformation)

                        conexion.Consulta(" select codigoEmpleado as 'Codigo', identidadEmpleado as 'Identidad', concat(primerNombre, ' ', primerApellido) as 'Nombre', edadEmpleado as 'Edad', sexoEmpleado as 'Sexo', puestoTrabajo as 'Cargo' FROM empleados where codigoEmpleado = '" & txtCodigoDelEmpleado.Text & "'", "data")
                        dgvMostrarDetalles.DataSource = conexion.ds.Tables("data")
                        clearScreen()
                    Else
                        MsgBox("ERROR INESPERADO", vbCritical)
                    End If

                Else
                    MsgBox("Elegiste No")
                End If
            End If

            If chkDeletePC.Checked = True Then

                Pregunta = MsgBox("Deseas continuar", vbYesNo + vbQuestion, "ELIMINAR")
                If Pregunta = vbYes Then
                    MsgBox("Elegiste Sí")

                    If conexion.eliminarComputadora(Microsoft.VisualBasic.Left(UCase(txtSerialPcToDelete.Text), 5)) Then
                        MsgBox("ELIMINADO", vbInformation)
                        conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas where serviceTag = '" & Microsoft.VisualBasic.Left(UCase(txtSerialPcToDelete.Text), 5) & "'", "data")
                        dgvMostrarDetalles.DataSource = conexion.ds.Tables("data")
                        clearScreen()

                    Else
                        MsgBox("ERROR INESPERADO", vbCritical)
                    End If

                Else
                    MsgBox("Elegiste No")
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        clearScreen()
        dgvMostrarDetalles.DataSource = ""
    End Sub

    Private Sub btnFindUser_MouseHover(sender As Object, e As EventArgs) Handles btnFindUser.MouseHover
        ToolTip1.SetToolTip(btnFindUser, "Buscar")
    End Sub

    Private Sub txtCodigoDelEmpleado_MouseHover(sender As Object, e As EventArgs) Handles txtCodigoDelEmpleado.MouseHover
        ToolTip1.SetToolTip(txtCodigoDelEmpleado, "Se ingresa el codigo para buscar al Empleado a eliminar")
        ToolTip1.ToolTipTitle = "Codigo Empleado"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtSerialPcToDelete_MouseHover(sender As Object, e As EventArgs) Handles txtSerialPcToDelete.MouseHover
        ToolTip1.SetToolTip(txtCodigoDelEmpleado, "Se ingresa el codigo para buscar la Computadora a eliminar")
        ToolTip1.ToolTipTitle = "Serial de la Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnFindComputer_MouseHover(sender As Object, e As EventArgs) Handles btnFindComputer.MouseHover
        ToolTip1.SetToolTip(btnFindComputer, "Buscar")
    End Sub

    Private Sub clearButton_MouseHover(sender As Object, e As EventArgs) Handles clearButton.MouseHover
        ToolTip1.SetToolTip(clearButton, "Limpiar Datos")
    End Sub

    Private Sub deleteButton_MouseHover(sender As Object, e As EventArgs) Handles deleteButton.MouseHover
        ToolTip1.SetToolTip(btnFindUser, "Eliminar Empleado/Cumputadora")
    End Sub
    Private Sub txtCodigoDelEmpleado_Validating(sender As Object, e As CancelEventArgs) Handles txtCodigoDelEmpleado.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "El codigo es un campo obligatorio")

        End If
    End Sub
    Private Sub txtSerialPcToDelete_Validating(sender As Object, e As CancelEventArgs) Handles txtSerialPcToDelete.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "El Serial de la PC es un campo obligatorio")

        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuPrincipal.Show()
    End Sub


End Class