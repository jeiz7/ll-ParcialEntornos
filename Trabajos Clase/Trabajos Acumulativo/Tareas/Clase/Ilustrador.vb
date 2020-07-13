Public Class Ilustrador
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        ListBox1.Items.Add("Nombre: " & txtNomb.Text & "  Contacto: " & txtContacto.Text & "  Descripción: " & txtDescripción.Text)
    End Sub

    Private Sub Nuevo_Click(sender As Object, e As EventArgs) Handles Nuevo.Click
        txtContacto.Clear()
        txtDescripción.Clear()
        txtNomb.Clear()

    End Sub
End Class