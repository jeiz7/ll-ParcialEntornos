<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.eliminarcomputadora = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.agregarcomputadora = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.consultarinventario = New System.Windows.Forms.Button()
        Me.mantenimineto = New System.Windows.Forms.Button()
        Me.mostrarregistro = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.eliminarcliente = New System.Windows.Forms.Button()
        Me.modificarcliente = New System.Windows.Forms.Button()
        Me.agregarcliente = New System.Windows.Forms.Button()
        Me.panelMostrador = New System.Windows.Forms.Panel()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnVolver)
        Me.Panel1.Controls.Add(Me.btnRestaurar)
        Me.Panel1.Controls.Add(Me.btnMinimizar)
        Me.Panel1.Controls.Add(Me.btnMaximizar)
        Me.Panel1.Controls.Add(Me.btnCerrar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(828, 44)
        Me.Panel1.TabIndex = 0
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnRestaurar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnRestaurar.Location = New System.Drawing.Point(742, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(44, 44)
        Me.btnRestaurar.TabIndex = 12
        Me.btnRestaurar.UseVisualStyleBackColor = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnMinimizar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMinimizar.Location = New System.Drawing.Point(699, 0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(44, 44)
        Me.btnMinimizar.TabIndex = 11
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnMaximizar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMaximizar.Location = New System.Drawing.Point(742, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(44, 44)
        Me.btnMaximizar.TabIndex = 10
        Me.btnMaximizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.btnCerrar.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.Icono_cerrar_FN
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.Location = New System.Drawing.Point(783, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(44, 44)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.eliminarcomputadora)
        Me.GroupBox2.Controls.Add(Me.PictureBox3)
        Me.GroupBox2.Controls.Add(Me.agregarcomputadora)
        Me.GroupBox2.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(437, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 228)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Computadoras"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(201, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "&Modificar "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "&Agregar"
        '
        'eliminarcomputadora
        '
        Me.eliminarcomputadora.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.pantalla
        Me.eliminarcomputadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.eliminarcomputadora.FlatAppearance.BorderSize = 0
        Me.eliminarcomputadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminarcomputadora.Location = New System.Drawing.Point(216, 148)
        Me.eliminarcomputadora.Name = "eliminarcomputadora"
        Me.eliminarcomputadora.Size = New System.Drawing.Size(47, 46)
        Me.eliminarcomputadora.TabIndex = 5
        Me.eliminarcomputadora.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.pruebaConexion.My.Resources.Resources.web
        Me.PictureBox3.Location = New System.Drawing.Point(120, 45)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(112, 78)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'agregarcomputadora
        '
        Me.agregarcomputadora.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.sitio_web
        Me.agregarcomputadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.agregarcomputadora.FlatAppearance.BorderSize = 0
        Me.agregarcomputadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarcomputadora.Location = New System.Drawing.Point(72, 148)
        Me.agregarcomputadora.Name = "agregarcomputadora"
        Me.agregarcomputadora.Size = New System.Drawing.Size(47, 46)
        Me.agregarcomputadora.TabIndex = 3
        Me.agregarcomputadora.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.consultarinventario)
        Me.GroupBox3.Controls.Add(Me.eliminarcliente)
        Me.GroupBox3.Controls.Add(Me.mantenimineto)
        Me.GroupBox3.Controls.Add(Me.mostrarregistro)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(118, 335)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(582, 228)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Registros "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(334, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "&Mostrar Registro"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 182)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "&Mantenimiento"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(144, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "&Consultar Inventario"
        '
        'consultarinventario
        '
        Me.consultarinventario.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.investigacion
        Me.consultarinventario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.consultarinventario.FlatAppearance.BorderSize = 0
        Me.consultarinventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.consultarinventario.Location = New System.Drawing.Point(69, 133)
        Me.consultarinventario.Name = "consultarinventario"
        Me.consultarinventario.Size = New System.Drawing.Size(47, 46)
        Me.consultarinventario.TabIndex = 6
        Me.consultarinventario.UseVisualStyleBackColor = True
        '
        'mantenimineto
        '
        Me.mantenimineto.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.monitor__1_
        Me.mantenimineto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mantenimineto.FlatAppearance.BorderSize = 0
        Me.mantenimineto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mantenimineto.Location = New System.Drawing.Point(213, 133)
        Me.mantenimineto.Name = "mantenimineto"
        Me.mantenimineto.Size = New System.Drawing.Size(47, 46)
        Me.mantenimineto.TabIndex = 7
        Me.mantenimineto.UseVisualStyleBackColor = True
        '
        'mostrarregistro
        '
        Me.mostrarregistro.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.monitor
        Me.mostrarregistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.mostrarregistro.FlatAppearance.BorderSize = 0
        Me.mostrarregistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mostrarregistro.Location = New System.Drawing.Point(373, 133)
        Me.mostrarregistro.Name = "mostrarregistro"
        Me.mostrarregistro.Size = New System.Drawing.Size(47, 46)
        Me.mostrarregistro.TabIndex = 8
        Me.mostrarregistro.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.pruebaConexion.My.Resources.Resources.tablero
        Me.PictureBox2.Location = New System.Drawing.Point(242, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(112, 78)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(202, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.modificarcliente)
        Me.GroupBox1.Controls.Add(Me.agregarcliente)
        Me.GroupBox1.Font = New System.Drawing.Font("Metropolis Semi Bold", 10.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(321, 228)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Empleados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(480, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Eliminar "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "&Modificar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(57, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 14)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "&Agregar "
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pruebaConexion.My.Resources.Resources.lista_de_verificacion
        Me.PictureBox1.Location = New System.Drawing.Point(104, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(112, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'eliminarcliente
        '
        Me.eliminarcliente.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.habilidades
        Me.eliminarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.eliminarcliente.FlatAppearance.BorderSize = 0
        Me.eliminarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.eliminarcliente.Location = New System.Drawing.Point(483, 133)
        Me.eliminarcliente.Name = "eliminarcliente"
        Me.eliminarcliente.Size = New System.Drawing.Size(57, 46)
        Me.eliminarcliente.TabIndex = 2
        Me.eliminarcliente.UseVisualStyleBackColor = True
        '
        'modificarcliente
        '
        Me.modificarcliente.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.contratado
        Me.modificarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.modificarcliente.FlatAppearance.BorderSize = 0
        Me.modificarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modificarcliente.Location = New System.Drawing.Point(195, 148)
        Me.modificarcliente.Name = "modificarcliente"
        Me.modificarcliente.Size = New System.Drawing.Size(60, 46)
        Me.modificarcliente.TabIndex = 1
        Me.modificarcliente.UseVisualStyleBackColor = True
        '
        'agregarcliente
        '
        Me.agregarcliente.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.reanudar
        Me.agregarcliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.agregarcliente.FlatAppearance.BorderSize = 0
        Me.agregarcliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.agregarcliente.Location = New System.Drawing.Point(60, 148)
        Me.agregarcliente.Name = "agregarcliente"
        Me.agregarcliente.Size = New System.Drawing.Size(55, 46)
        Me.agregarcliente.TabIndex = 0
        Me.agregarcliente.UseVisualStyleBackColor = True
        '
        'panelMostrador
        '
        Me.panelMostrador.BackColor = System.Drawing.Color.Silver
        Me.panelMostrador.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMostrador.Location = New System.Drawing.Point(0, 44)
        Me.panelMostrador.Margin = New System.Windows.Forms.Padding(1, 1, 1, 1)
        Me.panelMostrador.Name = "panelMostrador"
        Me.panelMostrador.Size = New System.Drawing.Size(828, 546)
        Me.panelMostrador.TabIndex = 9
        '
        'btnVolver
        '
        Me.btnVolver.BackgroundImage = Global.pruebaConexion.My.Resources.Resources.regreso
        Me.btnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnVolver.FlatAppearance.BorderSize = 0
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Location = New System.Drawing.Point(12, 11)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 77
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(828, 590)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.panelMostrador)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents eliminarcomputadora As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents agregarcomputadora As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents consultarinventario As Button
    Friend WithEvents mantenimineto As Button
    Friend WithEvents mostrarregistro As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents eliminarcliente As Button
    Friend WithEvents modificarcliente As Button
    Friend WithEvents agregarcliente As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents panelMostrador As Panel
    Public WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnVolver As Button
End Class
