Imports System.Runtime.InteropServices
Public Class MenuPrincipal
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub AbrirFormEnPanel(ByVal Formhijo As Object)
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False

        panelMostrador.Visible = True

        If panelMostrador.Controls.Count > 0 Then
            Me.panelMostrador.Controls.RemoveAt(0)
        End If

        Dim frm As Form = TryCast(Formhijo, Form)
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        Me.panelMostrador.Controls.Add(frm)
        Me.panelMostrador.Tag = frm
        frm.Show()


    End Sub

    Private Sub modificarcliente_Click(sender As Object, e As EventArgs) Handles modificarcliente.Click
        AbrirFormEnPanel(New modificarUsuarioWizard)
    End Sub

    Private Sub eliminarcliente_Click(sender As Object, e As EventArgs) Handles eliminarcliente.Click
        AbrirFormEnPanel(New eliminarWizard)
    End Sub

    Private Sub agregarcomputadora_Click(sender As Object, e As EventArgs) Handles agregarcomputadora.Click
        AbrirFormEnPanel(New insertarComputadoraWizard)
    End Sub

    Private Sub eliminarcomputadora_Click(sender As Object, e As EventArgs) Handles eliminarcomputadora.Click
        AbrirFormEnPanel(New modificarComputadorasWizard)
    End Sub

    Private Sub consultarinventario_Click(sender As Object, e As EventArgs) Handles consultarinventario.Click
        AbrirFormEnPanel(New consultarInventarioWizard)
    End Sub

    Private Sub mantenimineto_Click(sender As Object, e As EventArgs) Handles mantenimineto.Click
        AbrirFormEnPanel(New registrarMantenimientoWizard)
    End Sub

    Private Sub mostrarregistro_Click(sender As Object, e As EventArgs) Handles mostrarregistro.Click
        AbrirFormEnPanel(New mostrarRegistrosWizard)
    End Sub
    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        btnMaximizar.Visible = False
        btnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized

    End Sub
    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Me.WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btnMaximizar.Visible = True
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Application.Exit()
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click


        panelMostrador.Visible = False
        mostrarRegistrosWizard.Close()
        eliminarWizard.Close()
        insertarComputadoraWizard.Close()
        modificarComputadorasWizard.Close()
        modificarUsuarioWizard.Close()
        consultarInventarioWizard.Close()
        registrarMantenimientoWizard.Close()
        agregarUsuarioWizard.Close()



        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True

    End Sub

    Private Sub MenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelMostrador.Visible = False
        btnRestaurar.Enabled = False
        btnMaximizar.Enabled = False

    End Sub
End Class
