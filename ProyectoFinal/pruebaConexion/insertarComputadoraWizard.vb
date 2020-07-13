Public Class insertarComputadoraWizard

    Dim conexion As conexion = New conexion()

    Dim codigoServicio As String
    Dim existenciaCodigoServicio As String

    Dim marcaPC As String
    Dim modelo As String
    Dim unidadCPU As String
    Dim randomMemory As Integer
    Dim almacenamiento As String
    Dim grafica As String
    Dim teclado As String
    Dim monitor As String

    Private Sub clearScreen()

        txtServiceTag.Clear()
        txtModel.Clear()
        cmbBrand.SelectedIndex = 0
        cmbProcessor.SelectedIndex = 0
        cmbRAM.SelectedIndex = 0
        cmbGraphics.SelectedIndex = 0
        cmbKeyboard.SelectedIndex = 0
        cmbStorage.SelectedIndex = 0
        cmbScreen.SelectedIndex = 0

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddComputer.Click

        Try




            If txtServiceTag.Text <> String.Empty And txtServiceTag.TextLength = 5 Then
                codigoServicio = UCase(txtServiceTag.Text)

                If conexion.comprobarExistenciaPC(codigoServicio) = 2 Then

                    If cmbBrand.SelectedIndex <> 0 And txtModel.Text <> String.Empty And cmbProcessor.SelectedIndex <> 0 And cmbRAM.SelectedIndex <> 0 And cmbStorage.SelectedIndex <> 0 And cmbGraphics.SelectedIndex <> 0 And cmbKeyboard.SelectedIndex <> 0 And cmbScreen.SelectedIndex <> 0 Then

                        marcaPC = cmbBrand.SelectedItem
                        modelo = txtModel.Text
                        unidadCPU = cmbProcessor.SelectedItem
                        randomMemory = Val(cmbRAM.SelectedItem)
                        almacenamiento = cmbStorage.SelectedItem
                        grafica = cmbGraphics.SelectedItem
                        teclado = cmbKeyboard.SelectedItem
                        monitor = cmbScreen.SelectedItem

                        conexion.ingresarComputadora(UCase(codigoServicio), UCase(marcaPC), UCase(modelo), UCase(unidadCPU), UCase(randomMemory), UCase(almacenamiento), UCase(grafica), UCase(teclado), UCase(monitor))
                        MsgBox("Computadora Ingresada", vbInformation)

                        conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas where serviceTag = '" & codigoServicio & "'", "data")
                        dgvPCAgregada.DataSource = conexion.ds.Tables("data")

                        clearScreen()

                    Else
                        MsgBox("Seleccione una configuracion correcta", vbCritical)
                    End If
                Else
                    MsgBox("Ya existe una Computadora con el mismo ServiceTag en el inventario", vbCritical)
                End If

            Else
                MsgBox("Revise el Service Tag ingresado!", vbCritical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try





    End Sub

    Private Sub btnNEW_Click(sender As Object, e As EventArgs) Handles btnNEW.Click
        clearScreen()
    End Sub

    Private Sub insertarComputadoraWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbBrand.SelectedIndex = 0
        cmbProcessor.SelectedIndex = 0
        cmbRAM.SelectedIndex = 0
        cmbGraphics.SelectedIndex = 0
        cmbKeyboard.SelectedIndex = 0
        cmbStorage.SelectedIndex = 0
        cmbScreen.SelectedIndex = 0
    End Sub

    Private Sub cmbBrand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBrand.SelectedIndexChanged

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuPrincipal.Show()
    End Sub
    Private Sub txtServiceTag_MouseHover(sender As Object, e As EventArgs) Handles txtServiceTag.MouseHover
        ToolTip1.SetToolTip(txtServiceTag, "Ingrese el Codigo de la Computadora")
        ToolTip1.ToolTipTitle = "Service Tag"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbBrand_MouseHover(sender As Object, e As EventArgs) Handles cmbBrand.MouseHover
        ToolTip1.SetToolTip(cmbBrand, "Elija la Marca de la Computadora")
        ToolTip1.ToolTipTitle = "Marca Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub txtModel_MouseHover(sender As Object, e As EventArgs) Handles txtModel.MouseHover
        ToolTip1.SetToolTip(txtModel, "Ingrese el Modelo de la Computadora")
        ToolTip1.ToolTipTitle = "Modelo Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbProcessor_MouseHover(sender As Object, e As EventArgs) Handles cmbProcessor.MouseHover
        ToolTip1.SetToolTip(cmbProcessor, "Elija el Procesador de la Computadora")
        ToolTip1.ToolTipTitle = "Procesador Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbStorage_MouseHover(sender As Object, e As EventArgs) Handles cmbStorage.MouseHover
        ToolTip1.SetToolTip(cmbStorage, "Elija la Disco de la Computadora")
        ToolTip1.ToolTipTitle = "Disco Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbGraphics_MouseHover(sender As Object, e As EventArgs) Handles cmbGraphics.MouseHover
        ToolTip1.SetToolTip(cmbGraphics, "Elija la Tarjeta Grafica de la Computadora")
        ToolTip1.ToolTipTitle = "Tarjeta Grafica Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbKeyboard_MouseHover(sender As Object, e As EventArgs) Handles cmbKeyboard.MouseHover
        ToolTip1.SetToolTip(cmbKeyboard, "Elija el Tipo de Teclado de la Computadora")
        ToolTip1.ToolTipTitle = "Teclado Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbScreen_MouseHover(sender As Object, e As EventArgs) Handles cmbScreen.MouseHover
        ToolTip1.SetToolTip(cmbScreen, "Elija le Monitor de la Computadora")
        ToolTip1.ToolTipTitle = "Monitor Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub cmbRAM_MouseHover(sender As Object, e As EventArgs) Handles cmbRAM.MouseHover
        ToolTip1.SetToolTip(cmbRAM, "Elija la Memoria RAM de la Computadora")
        ToolTip1.ToolTipTitle = "Memoria RAM Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnAddComputer_MouseHover(sender As Object, e As EventArgs) Handles btnAddComputer.MouseHover
        ToolTip1.SetToolTip(btnAddComputer, "Se agregara la Computadora")
        ToolTip1.ToolTipTitle = "Agregar Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNEW_MouseHover(sender As Object, e As EventArgs) Handles btnNEW.MouseHover
        ToolTip1.SetToolTip(btnNEW, "Registrara una nueva Computadora")
        ToolTip1.ToolTipTitle = "Nueva Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub
End Class