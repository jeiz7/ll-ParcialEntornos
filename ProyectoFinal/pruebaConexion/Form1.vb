Public Class Form1

    Dim conexion As conexion = New conexion()
    Public codigoEmpleado As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
        MostrarDatos()


    End Sub


    Public Sub MostrarDatos()
        conexion.Consulta(" SELECT * from empleados ", "data")
        dgvEmpleados.DataSource = conexion.ds.Tables("data")
    End Sub



    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim agregarComputadora As String = "insert into computadorasAsignadas(serviceTag, marca, modelo, procesador, memoriaRAM, tipoDisco, tarjetaVideo, teclado, monitor) values(" & "'" & txtServiceTag.Text & "','" & txtMarca.Text & "','" & txtModelo.Text & "','" & txtProcesador.Text & "'," & Val(txtRam.Text) & ",'" & txtDisco.Text & "','" & txtGrafica.Text & "','" & txtTeclado.Text & "','" & txtMonitor.Text & "')"

        Dim agregar As String = "insert into empleados(codigoEmpleado,idComputadora  , identidadEmpleado,primerNombre, segundoNombre, primerApellido, segundoApellido, edadEmpleado, sexoEmpleado, puestoTrabajo) values(" & "'" & txtCodigoEmpleado.Text & "','" & txtServiceTag.Text & "','" & txtIdentidad.Text & "','" & txtPrimerN.Text & "','" & txtSegundoN.Text & " ',' " & txtPrimerA.Text & "','" & txtSegundoA.Text & "'," & Val(txtEdad.Text) & ",'" & txtSexo.Text & "','" & txtTrabajo.Text & "')"

        Dim agregarDepartamento As String = "insert into Direccion(dirEmpleado, departamento, municipio, barrio, colonia) values(" & "'" & txtCodigoEmpleado.Text & "','" & txtDepto.Text & "','" & txtMuni.Text & "','" & txtBarrio.Text & "','" & txtColonia.Text & "')"


        If conexion.Insertar(agregarComputadora) Then
            MsgBox("PC AGREGADA")
        Else
            MsgBox("ERROR EN PC")

        End If

        If conexion.Insertar(agregar) Then
            MsgBox("USUARIO AGREGADO")
            MostrarDatos()

        Else
            MsgBox("ERROR EN USUARIO")

        End If


        If conexion.Insertar(agregarDepartamento) Then
            MsgBox("DIRECCION AGREGADA")
        Else
            MsgBox("ERROR EN DIRECCION")

        End If


    End Sub



    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        codigoEmpleado = Val(txtCodigoEliminar.Text)

        Try

            If (conexion.Eliminar("empleados", "id = " & codigoEmpleado)) Then
                MsgBox("DATOS ELIMINADOS")
                MostrarDatos()
            Else
                MsgBox("ERROR AL ACTUALIZAR")
            End If

            If (conexion.Eliminar("Direccion", "id = " & codigoEmpleado)) Then
                MsgBox("DATOS ELIMINADOS")
                MostrarDatos()
            Else
                MsgBox("ERROR AL ACTUALIZAR")
            End If

            If (conexion.Eliminar("historialMantenimientos", "id_Compu = " & codigoEmpleado)) Then
                MsgBox("DATOS ELIMINADOS")
                MostrarDatos()
            Else
                MsgBox("ERROR AL ACTUALIZAR")
            End If

            If (conexion.Eliminar("computadorasAsignadas", "id = " & codigoEmpleado)) Then
                MsgBox("DATOS ELIMINADOS")
                MostrarDatos()
            Else
                MsgBox("ERROR AL ACTUALIZAR")
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        codigoEmpleado = Val(txtCodigoActual.Text)

        If chkDATA.Checked = True Then

            Dim actualizar As String = "identidadEmpleado = '" & txtIdentidad.Text & "', primerNombre= '" & txtPrimerN.Text & "', segundoNombre= '" & txtSegundoN.Text & "', primerApellido= '" & txtPrimerA.Text & "', segundoApellido= '" & txtSegundoA.Text & "', edadEmpleado= " & txtEdad.Text & ", sexoEmpleado= '" & txtSexo.Text & "', puestoTrabajo= '" & txtTrabajo.Text & "'"

            If (conexion.Actualizar("empleados", actualizar, "id =" & codigoEmpleado)) Then
                MsgBox("ACTUALIZADO!")
                MostrarDatos()
            Else
                MsgBox("ERROR AL ACTUALIZAR :(")
            End If
        End If

        If chkDIR.Checked = True Then
            Dim actualizar As String = "departamento = '" & txtDepto.Text & "', municipio= '" & txtMuni.Text & "', barrio= '" & txtBarrio.Text & "', colonia= '" & txtColonia.Text & "'"

            If (conexion.Actualizar("Direccion", actualizar, "id =" & codigoEmpleado)) Then
                MsgBox("ACTUALIZADO!")
                MostrarDatos()
            Else
                MsgBox("ERROR AL ACTUALIZAR :(")
            End If
        End If

        If chkPC.Checked = True Then
            Dim actualizar As String = "marca = '" & txtMarca.Text & "', modelo= '" & txtModelo.Text & "', procesador= '" & txtProcesador.Text & "', memoriaRAM= " & txtRam.Text & ", tipoDisco= '" & txtDisco.Text & "', tarjetaVideo= '" & txtGrafica.Text & "', teclado= '" & txtTeclado.Text & "', monitor= '" & txtMonitor.Text & "'"

            If (conexion.Actualizar("computadorasAsignadas", actualizar, "id =" & codigoEmpleado)) Then
                MsgBox("ACTUALIZADO!")
                MostrarDatos()
            Else
                MsgBox("ERROR AL ACTUALIZAR :(")
            End If
        End If


    End Sub

    Private Sub chkDATA_CheckedChanged(sender As Object, e As EventArgs) Handles chkDATA.CheckedChanged
        If chkDATA.Checked = True Then
            chkDIR.Checked = False
            chkPC.Checked = False

        End If


    End Sub

    Private Sub chkDIR_CheckedChanged(sender As Object, e As EventArgs) Handles chkDIR.CheckedChanged
        If chkDIR.Checked = True Then
            chkDATA.Checked = False
            chkPC.Checked = False

        End If
    End Sub

    Private Sub chkPC_CheckedChanged(sender As Object, e As EventArgs) Handles chkPC.CheckedChanged
        If chkPC.Checked = True Then
            chkDIR.Checked = False
            chkDATA.Checked = False

        End If
    End Sub

    Private Sub llenarCampos(e As DataGridViewCellEventArgs)
        Dim prueba As String
        Try
            Dim dtg As DataGridViewRow = dgvEmpleados.Rows(e.RowIndex)

            prueba = dtg.Cells(2).Value.ToString()

            MsgBox(prueba)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim codigo = txtPruebaRetorno.Text
        Dim mostrar As String
        Try


            mostrar = conexion.retornarValor(codigo)

            MsgBox(mostrar)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnVerificarExistencia_Click(sender As Object, e As EventArgs) Handles btnVerificarExistencia.Click
        Dim prueba As String
        prueba = txtVerificarExistencia.Text





    End Sub


End Class
