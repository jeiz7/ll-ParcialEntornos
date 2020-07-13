Public Class Contratar
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Me.ValidateChildren And txtNombre.Text <> String.Empty And txtCorreo.Text <> String.Empty Then
                Dim Ilustrador As String


                Select Case cmbIlustrador.SelectedIndex
                    Case 0
                        Ilustrador = " Rujojo "
                    Case 1
                        Ilustrador = " Banksy "
                    Case 2
                        Ilustrador = " Sophie Crumb "
                    Case 3
                        Ilustrador = " Mark Colan "
                End Select

                ListBox1.Items.Add("Cliente :  " & txtNombre.Text & "   " & txtCorreo.Text & "  Ilustrador : " & Ilustrador)
                MessageBox.Show("El ilustrador lo contactará de inmediato", "Servicio Contratado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Revise los datos ingresados", "Error en Productos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtNombre.Clear()
        txtCorreo.Clear()
        chbCaricatura.Checked = False
        chbDiseño.Checked = False
        chbReal.Checked = False
        chbRetrato.Checked = False
    End Sub
End Class