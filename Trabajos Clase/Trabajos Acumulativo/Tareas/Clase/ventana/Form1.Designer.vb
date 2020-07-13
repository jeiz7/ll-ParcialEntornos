<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.btnCuidado = New System.Windows.Forms.Button()
        Me.btnDistanciamiento = New System.Windows.Forms.Button()
        Me.btnproteccion = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnMaximizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.PanelCabecera.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.Teal
        Me.PanelCabecera.Controls.Add(Me.btnRestaurar)
        Me.PanelCabecera.Controls.Add(Me.btnMinimizar)
        Me.PanelCabecera.Controls.Add(Me.btnMaximizar)
        Me.PanelCabecera.Controls.Add(Me.btnCerrar)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1926, 100)
        Me.PanelCabecera.TabIndex = 0
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.Gray
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnCuidado)
        Me.PanelMenu.Controls.Add(Me.btnDistanciamiento)
        Me.PanelMenu.Controls.Add(Me.btnproteccion)
        Me.PanelMenu.Controls.Add(Me.PictureBox2)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 100)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(243, 1322)
        Me.PanelMenu.TabIndex = 1
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Location = New System.Drawing.Point(3, 260)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(22, 97)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Turquoise
        Me.Panel2.Location = New System.Drawing.Point(0, 1014)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(22, 97)
        Me.Panel2.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Turquoise
        Me.Panel3.Location = New System.Drawing.Point(3, 627)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(22, 97)
        Me.Panel3.TabIndex = 1
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackgroundImage = Global.VentanaPersonalizada.My.Resources.Resources.CHLA_What_You_Should_Know_Covid_19_1200x628_02
        Me.PanelContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(243, 100)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1683, 1322)
        Me.PanelContenedor.TabIndex = 2
        '
        'btnCuidado
        '
        Me.btnCuidado.BackgroundImage = Global.VentanaPersonalizada.My.Resources.Resources._1686026
        Me.btnCuidado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCuidado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCuidado.FlatAppearance.BorderSize = 0
        Me.btnCuidado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnCuidado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCuidado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuidado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuidado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCuidado.Location = New System.Drawing.Point(-43, 627)
        Me.btnCuidado.Name = "btnCuidado"
        Me.btnCuidado.Size = New System.Drawing.Size(312, 97)
        Me.btnCuidado.TabIndex = 4
        Me.btnCuidado.Text = "Cuidado"
        Me.btnCuidado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCuidado.UseVisualStyleBackColor = True
        '
        'btnDistanciamiento
        '
        Me.btnDistanciamiento.BackgroundImage = Global.VentanaPersonalizada.My.Resources.Resources.social
        Me.btnDistanciamiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDistanciamiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDistanciamiento.FlatAppearance.BorderSize = 0
        Me.btnDistanciamiento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnDistanciamiento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDistanciamiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDistanciamiento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDistanciamiento.Location = New System.Drawing.Point(-24, 1014)
        Me.btnDistanciamiento.Name = "btnDistanciamiento"
        Me.btnDistanciamiento.Size = New System.Drawing.Size(312, 97)
        Me.btnDistanciamiento.TabIndex = 3
        Me.btnDistanciamiento.Text = "Distanciamiento"
        Me.btnDistanciamiento.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDistanciamiento.UseVisualStyleBackColor = True
        '
        'btnproteccion
        '
        Me.btnproteccion.BackgroundImage = Global.VentanaPersonalizada.My.Resources.Resources.e83db85552ee35f6276411c9f19d982d_covid_19_icono_de_personaje_chico_by_vexels
        Me.btnproteccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnproteccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnproteccion.FlatAppearance.BorderSize = 0
        Me.btnproteccion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnproteccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnproteccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnproteccion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnproteccion.Location = New System.Drawing.Point(-43, 260)
        Me.btnproteccion.Name = "btnproteccion"
        Me.btnproteccion.Size = New System.Drawing.Size(312, 97)
        Me.btnproteccion.TabIndex = 2
        Me.btnproteccion.Text = "Proteccion"
        Me.btnproteccion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnproteccion.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.VentanaPersonalizada.My.Resources.Resources.virus_coronavirus_covid_covid_icon_1348291
        Me.PictureBox2.Location = New System.Drawing.Point(-14, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(142, 81)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.VentanaPersonalizada.My.Resources.Resources.unnamed
        Me.PictureBox1.Location = New System.Drawing.Point(134, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Image = Global.VentanaPersonalizada.My.Resources.Resources.Icono_Restaurar
        Me.btnRestaurar.Location = New System.Drawing.Point(1720, 0)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(100, 100)
        Me.btnRestaurar.TabIndex = 3
        Me.btnRestaurar.UseVisualStyleBackColor = True
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Image = Global.VentanaPersonalizada.My.Resources.Resources.Icono_Minimizar
        Me.btnMinimizar.Location = New System.Drawing.Point(1614, -3)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(100, 100)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = True
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.FlatAppearance.BorderSize = 0
        Me.btnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximizar.Image = Global.VentanaPersonalizada.My.Resources.Resources.Icono_Maximizar
        Me.btnMaximizar.Location = New System.Drawing.Point(1720, 0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(100, 100)
        Me.btnMaximizar.TabIndex = 1
        Me.btnMaximizar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.VentanaPersonalizada.My.Resources.Resources.Icono_cerrar_FN1
        Me.btnCerrar.Location = New System.Drawing.Point(1826, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(100, 100)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1926, 1422)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents btnMaximizar As Button
    Friend WithEvents btnMinimizar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnproteccion As Button
    Friend WithEvents btnCuidado As Button
    Friend WithEvents btnDistanciamiento As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class
