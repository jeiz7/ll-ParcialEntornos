Imports System.Runtime.InteropServices
Public Class Form1

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMaxim.Click
        btnMaxim.Visible = False
        btnRes.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        btnRes.Visible = False
        btnMaxim.Visible = True
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TimerOcultarMenú_Tick(sender As Object, e As EventArgs) Handles TimerOcultarMenú.Tick
        If PanelMenu.Width <= 60 Then
            Me.TimerOcultarMenú.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If

    End Sub

    Private Sub TimerMostrarMenú_Tick(sender As Object, e As EventArgs) Handles TimerMostrarMenú.Tick
        If PanelMenu.Width >= 200 Then
            Me.TimerMostrarMenú.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub


    Private Sub btnmen_Click(sender As Object, e As EventArgs) Handles btnmen.Click
        If PanelMenu.Width = 200 Then
            TimerOcultarMenú.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            TimerMostrarMenú.Enabled = True
        End If

    End Sub

    Private Sub abrirFormulario(ByVal formHijo As Object)
        If PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim frm As Form = TryCast(formHijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(frm)
        Me.PanelContenedor.Tag = frm
        frm.Show()
    End Sub
    Private Sub btnEmpleados_Click(sender As Object, e As EventArgs) Handles btnEmpleados.Click
        abrirFormulario(New Galeria)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormulario(New Contratar)
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        abrirFormulario(New Ilustrador)
    End Sub
End Class
