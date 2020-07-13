Imports System.ComponentModel

Public Class mostrarRegistrosWizard

    Dim conexion As conexion = New conexion()

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If cmbComponentes.SelectedItem <> "" Then

                conexion.Consulta(" select id_Compu as 'Service Tag', dia as 'Fecha', tipoMantenimiento as 'Mantenimiento', componentesAfectados as 'Componente', descripcion as 'Descripcion'   FROM historialMantenimientos where componentesAfectados = '" & cmbComponentes.SelectedItem & "'", "data")
                dgvPRINCIPAL.DataSource = conexion.ds.Tables("data")

                conexion.Consulta(" select id_Compu as 'Service Tag', dia as 'Fecha', tipoMantenimiento as 'Mantenimiento', otrosComponentes as 'Componente Secundario', descripcion as 'Descripcion'   FROM historialMantenimientos where otrosComponentes = '" & cmbComponentes.SelectedItem & "'", "data")
                dgvSECUNDARIO.DataSource = conexion.ds.Tables("data")
            Else
                MsgBox("Selecciona un Componente", vbCritical)
            End If
        Catch ex As Exception

        End Try
    End Sub



    Private Sub cmbComponentes_Validating(sender As Object, e As CancelEventArgs) Handles cmbComponentes.Validating
        If (cmbComponentes.SelectedItem <> "") Then
            Me.ErrorProvider1.SetError(sender, "")
        Else
            Me.ErrorProvider1.SetError(sender, "Seleccione un componente a buscar")
        End If

    End Sub

    Private Sub cmbComponentes_MouseHover(sender As Object, e As EventArgs) Handles cmbComponentes.MouseHover
        ToolTip1.SetToolTip(cmbComponentes, "Elija un Componente para ver su historial")
        ToolTip1.ToolTipTitle = "Componente"
        ToolTip1.ToolTipIcon = ToolTipIcon.Info
    End Sub

    Private Sub btnBuscar_MouseHover(sender As Object, e As EventArgs) Handles btnBuscar.MouseHover
        ToolTip1.SetToolTip(btnBuscar, "Buscar Componente")
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
        MenuPrincipal.Show()
    End Sub

    Private Sub mostrarRegistrosWizard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class