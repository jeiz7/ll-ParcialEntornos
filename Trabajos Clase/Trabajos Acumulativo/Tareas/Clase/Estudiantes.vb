Imports System.Data.SqlClient
Public Class Estudiantes
    'Instanciar datatable
    Private dtEstudiantes As New dsEstudiantes.estudianteDataTable
    'Levantar instancia del tableadapter
    Private taEstudiantes As New dsEstudiantesTableAdapters.estudianteTableAdapter
    'Levantar instancia de filas del tableadapter... Row=Fila
    Private registro As dsEstudiantes.estudianteRow
    'Para lógica de la app
    Private campollave As String
    Private editar As Boolean = False
    Private numeroRegistro As String

    Private Sub Estudiantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtEstudiantes = Me.taEstudiantes.getData()
        dtgRegistros.DataSource = Me.dtEstudiantes

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        'actualizar un registro modificado
        If Me.editar Then
            Me.registro = dtEstudiantes.FindBycodigo(Me.campollave)
            Me.registro.nombre = txtNombre.Text
            Me.registro.primerApellido = txtPrimerApellido.Text
            Me.registro.segundoApellido = txtSegundoApellido.Text
            Me.registro.edad = txtEdad.Text
            Me.registro.codigoclase = cmbClase.Text

            Try
                taEstudiantes.Update(dtEstudiantes)
                MsgBox("La base de datos ha sido actualizada")
            Catch ex As Exception
                MsgBox("Hubo un error al actualizar la base de datos")
            End Try
            Me.editar = False
            Limpiar()
        Else
            'guardar registro no existente
            Me.registro = dtEstudiantes.NewestudianteRow()
            Me.registro.codigo = txtCodigo.Text
            Me.registro.nombre = txtNombre.Text
            Me.registro.primerApellido = txtPrimerApellido.Text
            Me.registro.segundoApellido = txtSegundoApellido.Text
            Me.registro.edad = txtEdad.Text
            Me.registro.sexo = cmbSexo.Text
            Me.registro.codigoclase = cmbClase.Text

            'agregar registro al datatable
            dtEstudiantes.AddestudianteRow(Me.registro)
            'actualiza la base de datos

            Try
                taEstudiantes.Update(dtEstudiantes)
                MsgBox("Dato Ingresado exitosamente")
            Catch ex As Exception
                MsgBox("Error al ingresar el dato")
            End Try
            Limpiar()
        End If


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Me.editar = True
        enviarDatosACajas()

    End Sub

    'Envía los selexionados datos a las cajas de texto
    Private Sub enviarDatosACajas()
        Me.campollave = Me.dtgRegistros.CurrentRow.Cells.Item(0).Value.ToString()
        txtNombre.Text = Me.dtgRegistros.CurrentRow.Cells.Item(1).Value.ToString()
        txtPrimerApellido.Text = Me.dtgRegistros.CurrentRow.Cells.Item(2).Value.ToString()
        txtSegundoApellido.Text = Me.dtgRegistros.CurrentRow.Cells.Item(3).Value.ToString()
        txtEdad.Text = Me.dtgRegistros.CurrentRow.Cells.Item(4).Value.ToString()
        cmbClase.Text = Me.dtgRegistros.CurrentRow.Cells.Item(6).Value.ToString()
        txtCodigo.Text = Me.dtgRegistros.CurrentRow.Cells.Item(0).Value.ToString()
        txtCodigo.Enabled = False
        cmbSexo.Enabled = False
    End Sub

    Public Sub Limpiar()
        txtCodigo.Clear()
        txtNombre.Clear()
        txtPrimerApellido.Clear()
        txtSegundoApellido.Clear()
        txtEdad.Clear()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Me.registro = dtEstudiantes.Rows(numeroRegistro)
        registro.Delete()

        Try
            taEstudiantes.Update(dtEstudiantes)
            MsgBox("Los datos han sido eliminados")
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al eliminar los datos")
        End Try


    End Sub

    Private Sub dtgRegistros_SelectionChanged(sender As Object, e As EventArgs) Handles dtgRegistros.SelectionChanged

        Me.numeroRegistro = dtgRegistros.CurrentRow.Index.ToString()
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        dtEstudiantes = taEstudiantes.GetDataByNombre(txtBusqueda.Text)

        dtgRegistros.DataSource = dtEstudiantes
    End Sub

    Private Sub btnVerTodo_Click(sender As Object, e As EventArgs) Handles btnVerTodo.Click
        Me.dtEstudiantes = Me.taEstudiantes.GetData()
        dtgRegistros.DataSource = Me.dtEstudiantes
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class