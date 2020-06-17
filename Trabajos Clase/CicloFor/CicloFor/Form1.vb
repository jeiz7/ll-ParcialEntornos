Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        'Definicion de las variables
        Dim T As Integer
        Dim i As Integer


        T = Val(txtNumero.Text)
        'A este label le da el tipo de letra que desea para el encabezado
        lbPregunta.Font = New Font("Arial", 10, FontStyle.Bold)
        'Este centra el texto
        lbPregunta.TextAlign = ContentAlignment.MiddleCenter
        '
        lbPregunta.Text = "TABLA DEL " & T & vbCrLf & vbCrLf
        For i = 1 To 10
            lbPregunta.Text = lbPregunta.Text & T & " * " & i & " = " & T * i & vbCrLf
        Next i
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
