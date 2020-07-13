Imports System.ComponentModel

Public Class bolsa_solidaria
    Dim contador As Integer = 1
    Private Sub Ciudades()
        Dim id, n1, n2 As String

        id = txtidentidad.Text
        For i = 0 To id.Length - 1
            n1 = id.Substring(i, 1)

            If n1 = id.Substring(1, 1) Then
                If n1 = "3" Then
                    'COMAYAGUA
                    lblDepartamento.Text = "Comayagua"

                    'INTIBUCÁ
                ElseIf n1 = "0" Then

                    lblDepartamento.Text = "Intibucá"

                    'CORTÉS
                ElseIf n1 = "5" Then

                    lblDepartamento.Text = "Cortés"
                End If
            End If

            If lblDepartamento.Text = "Comayagua" Then
                If n1 = id.Substring(3, 1) Then
                    If n1 = "1" Then
                        lblMunicipio.Text = "Comayagua"
                    ElseIf n1 = "8" Then
                        lblMunicipio.Text = "Siguatepeque"
                    End If
                End If
            ElseIf lblDepartamento.Text = "Intibucá" Then
                If n1 = id.Substring(3, 1) Then
                    If n1 = "1" Then
                        lblMunicipio.Text = "La Esperanza"
                    ElseIf n1 = "8" Then
                        lblMunicipio.Text = "Magdalena"
                    End If
                End If
            ElseIf lblDepartamento.Text = "Cortés" Then
                If n1 = id.Substring(3, 1) Then
                    If n1 = "1" Then
                        lblMunicipio.Text = "San Pedro Sula"
                    ElseIf n1 = "0" Then
                        lblMunicipio.Text = "Santa Cruz De Yojoa"
                    End If
                End If
            End If

        Next
    End Sub
    Private Sub Tipo_Bolsa()
        Dim cantidad As Integer
        cantidad = Val(txtintegrantes.Text)
        If cantidad <= 3 Then
            lbxTipo.Items.Add("Básica")
        ElseIf cantidad > 3 Then
            lbxTipo.Items.Add("Regular")
        End If
    End Sub
    Private Sub btnSolicitar_Click(sender As Object, e As EventArgs) Handles btnSolicitar.Click
        contador += 1
        lbxid.Items.Add(txtidentidad.Text)
        lbxDireccion.Items.Add(txtDireccion.Text)
        Ciudades()
        Tipo_Bolsa()
        lblBolsas.Text = contador - 1
    End Sub

    Private Sub txtidentidad_TextChanged(sender As Object, e As EventArgs) Handles txtidentidad.TextChanged

    End Sub

    Private Sub txtidentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidentidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtidentidad_Validating(sender As Object, e As CancelEventArgs) Handles txtidentidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, " ")
        Else
            Me.errorValidacion.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, " ")
        Else
            Me.errorValidacion.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtintegrantes_TextChanged(sender As Object, e As EventArgs) Handles txtintegrantes.TextChanged

    End Sub

    Private Sub txtintegrantes_Validating(sender As Object, e As CancelEventArgs) Handles txtintegrantes.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, " ")
        Else
            Me.errorValidacion.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub cmbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEstado.SelectedIndexChanged

    End Sub

    Private Sub cmbEstado_Validating(sender As Object, e As CancelEventArgs) Handles cmbEstado.Validating
        If DirectCast(sender, ComboBox).SelectedIndex = True Then
            Me.errorValidacion.SetError(sender, " ")
        Else
            Me.errorValidacion.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.errorValidacion.SetError(sender, " ")
        Else
            Me.errorValidacion.SetError(sender, "Este campo es obligatorio")
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtDireccion.Clear()
        txtidentidad.Clear()
        txtintegrantes.Clear()
        txtNombre.Clear()
        cmbEstado.SelectedIndex = False
        lblDepartamento.Text = " "
        lblMunicipio.Text = " "


    End Sub
End Class