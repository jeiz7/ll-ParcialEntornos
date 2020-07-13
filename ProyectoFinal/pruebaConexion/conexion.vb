Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms


Public Class conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source =DESKTOP-P4A3L4O;Initial Catalog=mantenimientoComputadoras;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub Conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub



    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub



    Function Insertar(ByVal sql)

        conexion.Open()
        comando = New SqlCommand(sql, conexion)

        Dim i As Integer = comando.ExecuteNonQuery()
        If (i > 0) Then
            conexion.Close()
            Return True

        Else
            conexion.Close()
            Return False

        End If

    End Function

    Function Eliminar(ByVal tabla, ByVal condicion)
        conexion.Open()
        Dim elimina As String = "delete from " & tabla & " where " & condicion
        comando = New SqlCommand(elimina, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()

        If (i > 0) Then
            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function Actualizar(ByVal tabla, ByVal campos, ByVal condicion)
        conexion.Open()
        Dim actualiza As String = "update " & tabla & " set " & campos & " where " & condicion
        comando = New SqlCommand(actualiza, conexion)
        Dim i As Integer = comando.ExecuteNonQuery()
        conexion.Close()

        If (i > 0) Then
            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False

        End If
    End Function


    Function retornarValor(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT idComputadora from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()


        End Try
    End Function

    Function retornarValorIdentidad(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT identidadEmpleado from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()


        End Try
    End Function

    Function retornarValorPrimerNombre(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT primerNombre from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar


        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()


        End Try
    End Function

    Function retornarValorSegundoNombre(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT segundoNombre from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorPrimerApellido(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT primerApellido from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function


    Function retornarValorSegundoApellido(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT segundoApellido from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorEdad(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT edadEmpleado from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorSexo(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT sexoEmpleado from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorCargo(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT puestoTrabajo from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorDepto(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT departamento from Direccion WHERE dirEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorMunicipio(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT municipio from Direccion WHERE dirEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorBarrio(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT barrio from Direccion WHERE dirEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarValorColonia(ByVal codigoUsuario As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT colonia from Direccion WHERE dirEmpleado = '" & codigoUsuario & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function





    Function comprobarExistenciaUsuario(ByVal codigoUsuario As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT id from empleados WHERE codigoEmpleado = '" & codigoUsuario & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

    Function comprobarExistenciaIdentidad(ByVal identidadUsuario As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT id from empleados WHERE identidadEmpleado = '" & identidadUsuario & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

    Function comprobarSerial(ByVal codigoSerial As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT id from empleados WHERE idComputadora = '" & codigoSerial & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

    Function comprobarExistenciaPC(ByVal codigoService As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT id from computadorasAsignadas WHERE serviceTag = '" & codigoService & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

    Function insertarManutencion(ByVal serial As String, ByVal day As String, ByVal mant As String, ByVal comp As String, ByVal otherComp As String, ByVal desc As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "registrarMantenimiento"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@serialPC", serial)
        sqlComm.Parameters.AddWithValue("@dia", day)
        sqlComm.Parameters.AddWithValue("@tipoMant", mant)
        sqlComm.Parameters.AddWithValue("@componentesAfectados", comp)
        sqlComm.Parameters.AddWithValue("@otrosComponentes", otherComp)
        sqlComm.Parameters.AddWithValue("@descripcion", desc)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function insertarEmpleado(ByVal codigoE As String, ByVal codigoPCE As String, ByVal identidadE As String, ByVal nombre1 As String, ByVal nombre2 As String, ByVal apellido1 As String, ByVal apellido2 As String, ByVal edadE As Integer, ByVal sexoE As String, ByVal puestoE As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "registrarEmpleado"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@codigoEmpleado", codigoE)
        sqlComm.Parameters.AddWithValue("@idComputadora", codigoPCE)
        sqlComm.Parameters.AddWithValue("@identidadEmpleado", identidadE)
        sqlComm.Parameters.AddWithValue("@primerNombre", nombre1)
        sqlComm.Parameters.AddWithValue("@segundoNombre", nombre2)
        sqlComm.Parameters.AddWithValue("@primerApellido", apellido1)
        sqlComm.Parameters.AddWithValue("@segundoApellido", apellido2)
        sqlComm.Parameters.AddWithValue("@edadEmpleado", edadE)
        sqlComm.Parameters.AddWithValue("@sexoEmpleado", sexoE)
        sqlComm.Parameters.AddWithValue("@puestoTrabajo ", puestoE)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If



    End Function

    Function actualizarEmpleados(ByVal codigoE As String, ByVal codigoPCE As String, ByVal identidadE As String, ByVal nombre1 As String, ByVal nombre2 As String, ByVal apellido1 As String, ByVal apellido2 As String, ByVal edadE As Integer, ByVal sexoE As String, ByVal puestoE As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "actualizarEmpleado"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@codigoEmpleado", codigoE)
        sqlComm.Parameters.AddWithValue("@idComputadora", codigoPCE)
        sqlComm.Parameters.AddWithValue("@identidadEmpleado", identidadE)
        sqlComm.Parameters.AddWithValue("@primerNombre", nombre1)
        sqlComm.Parameters.AddWithValue("@segundoNombre", nombre2)
        sqlComm.Parameters.AddWithValue("@primerApellido", apellido1)
        sqlComm.Parameters.AddWithValue("@segundoApellido", apellido2)
        sqlComm.Parameters.AddWithValue("@edadEmpleado", edadE)
        sqlComm.Parameters.AddWithValue("@sexoEmpleado", sexoE)
        sqlComm.Parameters.AddWithValue("@puestoTrabajo ", puestoE)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If



    End Function


    Function actualizarDirecciones(ByVal codigoEmp As String, ByVal depto As String, ByVal muni As String, ByVal barrio As String, ByVal colonia As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "actualizarDireccion"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@dirEmpleado", codigoEmp)
        sqlComm.Parameters.AddWithValue("@departamento", depto)
        sqlComm.Parameters.AddWithValue("@municipio", muni)
        sqlComm.Parameters.AddWithValue("@barrio", barrio)
        sqlComm.Parameters.AddWithValue("@colonia", colonia)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If
    End Function

    Function insertarDireccion(ByVal codigoEmp As String, ByVal depto As String, ByVal muni As String, ByVal barrio As String, ByVal colonia As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "registrarDireccion"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@dirEmpleado", codigoEmp)
        sqlComm.Parameters.AddWithValue("@departamento", depto)
        sqlComm.Parameters.AddWithValue("@municipio", muni)
        sqlComm.Parameters.AddWithValue("@barrio", barrio)
        sqlComm.Parameters.AddWithValue("@colonia", colonia)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If
    End Function


    Function retornarFechaMantenimiento(ByVal codigoPC As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("select MIN(dia) as 'Fecha' from historialMantenimientos WHERE id_Compu = '" & codigoPC & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function ingresarComputadora(ByVal etiquetaServicio As String, ByVal marcaPC As String, ByVal modeloPC As String, ByVal procesadorPC As String, ByVal memoriaR As Integer, ByVal disco As String, ByVal grafica As String, ByVal teclado As String, ByVal monitor As String)


        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "registrarComputadora"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@serviceTag", etiquetaServicio)
        sqlComm.Parameters.AddWithValue("@marca", marcaPC)
        sqlComm.Parameters.AddWithValue("@modelo", modeloPC)
        sqlComm.Parameters.AddWithValue("@procesador", procesadorPC)
        sqlComm.Parameters.AddWithValue("@memoriaRAM", memoriaR)
        sqlComm.Parameters.AddWithValue("@tipoDisco", disco)
        sqlComm.Parameters.AddWithValue("@tarjetaVideo", grafica)
        sqlComm.Parameters.AddWithValue("@teclado", teclado)
        sqlComm.Parameters.AddWithValue("@monitor", monitor)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    'LLENAR CAMPOS DE ACTUALIZACION DE COMPUTADORAS
    Function retornarSERIAL(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT serviceTag from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarMARCA(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT marca from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function


    Function retornarMODELO(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT modelo from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarPROCESADOR(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT procesador from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarRAM(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT memoriaRAM from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = value
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarDISCO(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT tipoDisco from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarGRAFICA(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT tarjetaVideo from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarTECLADO(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT teclado from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function retornarMONITOR(ByVal serviceTAG As String)
        Try

            Dim valorARetornar As String
            Dim cmd As SqlCommand = conexion.CreateCommand()
            cmd.CommandText = ("SELECT monitor from computadorasAsignadas WHERE serviceTag = '" & serviceTAG & "'")

            conexion.Open()

            Dim value As Object = cmd.ExecuteScalar()

            valorARetornar = Convert.ToString(value)
            conexion.Close()

            Return valorARetornar

        Catch ex As Exception
            MsgBox(ex.Message)
            conexion.Close()

        End Try
    End Function

    Function actualizarCOMPUTADORAS(ByVal etiquetaServicio As String, ByVal marcaPC As String, ByVal modeloPC As String, ByVal procesadorPC As String, ByVal memoriaR As Integer, ByVal disco As String, ByVal grafica As String, ByVal teclado As String, ByVal monitor As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "actualizarComputadora"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@serviceTag", etiquetaServicio)
        sqlComm.Parameters.AddWithValue("@marca", marcaPC)
        sqlComm.Parameters.AddWithValue("@modelo", modeloPC)
        sqlComm.Parameters.AddWithValue("@procesador", procesadorPC)
        sqlComm.Parameters.AddWithValue("@memoriaRAM", memoriaR)
        sqlComm.Parameters.AddWithValue("@tipoDisco", disco)
        sqlComm.Parameters.AddWithValue("@tarjetaVideo", grafica)
        sqlComm.Parameters.AddWithValue("@teclado", teclado)
        sqlComm.Parameters.AddWithValue("@monitor", monitor)

        conexion.Open()

        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function eliminarEmpleado(ByVal codigoEmpleado As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "eliminarRegistro"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@codigoEmpleado", codigoEmpleado)


        conexion.Open()

        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function eliminarComputadora(ByVal etiquetaServicio As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "eliminarRegistroPC"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@serviceTag", etiquetaServicio)


        conexion.Open()

        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

End Class
