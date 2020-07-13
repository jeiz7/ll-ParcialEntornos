Imports System.ComponentModel

Public Class modificarComputadorasWizard

    Dim conexion As conexion = New conexion()

    Dim serialPC As String

    Dim marcaPC As String
    Dim modelo As String
    Dim unidadCPU As String
    Dim randomMemory As Integer
    Dim almacenamiento As String
    Dim grafica As String
    Dim teclado As String
    Dim monitor As String

    Private Sub clearScreen()
        txtPCToFind.Enabled = True

        txtPCToFind.Clear()
        txtServiceTag.Clear()
        txtModel.Clear()
        cmbBrand.SelectedItem = ""
        cmbProcessor.SelectedIndex = 0
        cmbRAM.SelectedIndex = 0
        cmbGraphics.SelectedIndex = 0
        cmbKeyboard.SelectedIndex = 0
        cmbStorage.SelectedIndex = 0
        cmbScreen.SelectedIndex = 0
        grpBoxDescript.Enabled = False

    End Sub

    Private Sub modificarComputadorasWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grpBoxDescript.Enabled = False
        txtServiceTag.Enabled = False
        cmbBrand.Enabled = False
        txtModel.Enabled = False
        cmbProcessor.SelectedIndex = 0
        cmbRAM.SelectedIndex = 0
        cmbGraphics.SelectedIndex = 0
        cmbKeyboard.SelectedIndex = 0
        cmbStorage.SelectedIndex = 0
        cmbScreen.SelectedIndex = 0
    End Sub

    Private Sub btnFindToChange_Click(sender As Object, e As EventArgs) Handles btnFindToChange.Click
        Dim pcABuscar As String


        If txtPCToFind.Text <> String.Empty And txtPCToFind.TextLength = 5 Then
            pcABuscar = UCase(txtPCToFind.Text)


            If conexion.comprobarExistenciaPC(pcABuscar) = 1 Then
                grpBoxDescript.Enabled = True
                txtPCToFind.Enabled = False


                serialPC = conexion.retornarSERIAL(pcABuscar)
                marcaPC = conexion.retornarMARCA(pcABuscar)
                modelo = conexion.retornarMODELO(pcABuscar)


                unidadCPU = conexion.retornarPROCESADOR(pcABuscar)
                randomMemory = Val(conexion.retornarRAM(pcABuscar))
                almacenamiento = conexion.retornarDISCO(pcABuscar)
                grafica = conexion.retornarGRAFICA(pcABuscar)
                teclado = conexion.retornarTECLADO(pcABuscar)
                monitor = conexion.retornarMONITOR(pcABuscar)

                txtServiceTag.Text = serialPC
                cmbBrand.SelectedItem = marcaPC
                txtModel.Text = modelo
                cmbProcessor.SelectedItem = unidadCPU


                If Val(randomMemory) = 16 Then
                    cmbRAM.SelectedIndex = 1

                ElseIf Val(randomMemory) = 32 Then
                    cmbRAM.SelectedIndex = 2

                ElseIf Val(randomMemory) = 64 Then
                    cmbRAM.SelectedIndex = 3

                End If

                cmbStorage.SelectedItem = almacenamiento
                cmbGraphics.SelectedItem = grafica
                cmbKeyboard.SelectedItem = teclado
                cmbScreen.SelectedItem = monitor



                conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas where serviceTag = '" & serialPC & "'", "data")
                dgvPCAgregada.DataSource = conexion.ds.Tables("data")


            Else

                MsgBox("La Computadora no existe!", vbCritical)
            End If
        Else
            MsgBox("Revise el codigo Ingresado!", vbCritical)
        End If
    End Sub

    Private Sub btnAddComputer_Click(sender As Object, e As EventArgs) Handles btnAddComputer.Click
        Try

            If cmbProcessor.SelectedIndex <> 0 And cmbRAM.SelectedIndex <> 0 And cmbStorage.SelectedIndex <> 0 And cmbGraphics.SelectedIndex <> 0 And cmbKeyboard.SelectedIndex <> 0 And cmbScreen.SelectedIndex <> 0 Then

                unidadCPU = cmbProcessor.SelectedItem
                randomMemory = Val(cmbRAM.SelectedItem)
                almacenamiento = cmbStorage.SelectedItem
                grafica = cmbGraphics.SelectedItem
                teclado = cmbKeyboard.SelectedItem
                monitor = cmbScreen.SelectedItem

                If conexion.actualizarCOMPUTADORAS(UCase(serialPC), UCase(marcaPC), UCase(modelo), UCase(unidadCPU), UCase(randomMemory), UCase(almacenamiento), UCase(grafica), UCase(teclado), UCase(monitor)) Then
                    MsgBox("DATOS ACTUALIZADOS", vbInformation)



                    conexion.Consulta(" select serviceTag as 'Service Tag', marca as 'Marca', modelo as 'Modelo', procesador as 'CPU', memoriaRAM as 'RAM', tipoDisco as 'Almacenamiento', tarjetaVideo as 'Grafica', teclado as 'Teclado', monitor as 'Monitor' FROM computadorasAsignadas where serviceTag = '" & serialPC & "'", "data")
                    dgvPCAgregada.DataSource = conexion.ds.Tables("data")
                    clearScreen()
                Else
                    MsgBox("ERROR INESPERADO", vbCritical)
                End If
            Else
                MsgBox("Revisa los datos Seleccionados!", vbCritical)
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNEW_Click(sender As Object, e As EventArgs) Handles btnNEW.Click
        clearScreen()
        dgvPCAgregada.DataSource = ""
    End Sub



    Private Sub txtPCToFind_Validating(sender As Object, e As CancelEventArgs) Handles txtPCToFind.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Es un campo obligatorio para la busqueda")

        End If
    End Sub
    Private Sub txtPCToFind_MouseHover(sender As Object, e As EventArgs) Handles txtPCToFind.MouseHover
        ToolTip1.SetToolTip(txtPCToFind, "Ingrese el Codigo de la Computadora")
        ToolTip1.ToolTipTitle = "Serial de Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
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
        ToolTip1.SetToolTip(btnAddComputer, "Se agregaran los cambios a la Computadora")
        ToolTip1.ToolTipTitle = "Aplicar Cambios"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnNEW_MouseHover(sender As Object, e As EventArgs) Handles btnNEW.MouseHover
        ToolTip1.SetToolTip(btnNEW, "Registrara una nueva Computadora")
        ToolTip1.ToolTipTitle = "Nueva Computadora"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnFindToChange_MouseHover(sender As Object, e As EventArgs) Handles btnFindToChange.MouseHover
        ToolTip1.SetToolTip(btnFindToChange, "Buscar")
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuPrincipal.Show()
    End Sub
End Class