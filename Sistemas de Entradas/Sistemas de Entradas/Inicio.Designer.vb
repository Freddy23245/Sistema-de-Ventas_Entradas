<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.Panel_arriba = New System.Windows.Forms.Panel()
        Me.PbSlide = New System.Windows.Forms.PictureBox()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHora_Actual = New System.Windows.Forms.Label()
        Me.btnMinimizar = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Paneles = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pbVentas = New System.Windows.Forms.PictureBox()
        Me.pbUsuario = New System.Windows.Forms.PictureBox()
        Me.pbSede = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbEntradas = New System.Windows.Forms.PictureBox()
        Me.pbArroba = New System.Windows.Forms.PictureBox()
        Me.PbEquipo = New System.Windows.Forms.PictureBox()
        Me.pbCliente = New System.Windows.Forms.PictureBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCorreo = New System.Windows.Forms.Button()
        Me.btnEquipos = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnSede = New System.Windows.Forms.Button()
        Me.MenuInicio = New System.Windows.Forms.MenuStrip()
        Me.grupos_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.crear_grupo_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.grupos_usuarios_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.grupos_permisos_tsmi = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEntradas = New System.Windows.Forms.Button()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.panel_contenedor = New System.Windows.Forms.Panel()
        Me.pbSaf = New System.Windows.Forms.PictureBox()
        Me.tmHora = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_arriba.SuspendLayout()
        CType(Me.PbSlide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Paneles.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSede, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbArroba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuInicio.SuspendLayout()
        Me.panel_contenedor.SuspendLayout()
        CType(Me.pbSaf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_arriba
        '
        Me.Panel_arriba.BackColor = System.Drawing.Color.White
        Me.Panel_arriba.Controls.Add(Me.PbSlide)
        Me.Panel_arriba.Controls.Add(Me.lblUsuario)
        Me.Panel_arriba.Controls.Add(Me.Label3)
        Me.Panel_arriba.Controls.Add(Me.Label2)
        Me.Panel_arriba.Controls.Add(Me.lblFecha)
        Me.Panel_arriba.Controls.Add(Me.Label1)
        Me.Panel_arriba.Controls.Add(Me.LblHora_Actual)
        Me.Panel_arriba.Controls.Add(Me.btnMinimizar)
        Me.Panel_arriba.Controls.Add(Me.btnCerrar)
        Me.Panel_arriba.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel_arriba.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_arriba.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel_arriba.Location = New System.Drawing.Point(0, 0)
        Me.Panel_arriba.Name = "Panel_arriba"
        Me.Panel_arriba.Size = New System.Drawing.Size(1075, 36)
        Me.Panel_arriba.TabIndex = 1
        '
        'PbSlide
        '
        Me.PbSlide.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.Mobile_Menu_Icon1
        Me.PbSlide.Location = New System.Drawing.Point(0, 0)
        Me.PbSlide.Name = "PbSlide"
        Me.PbSlide.Size = New System.Drawing.Size(44, 35)
        Me.PbSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbSlide.TabIndex = 5
        Me.PbSlide.TabStop = False
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblUsuario.Location = New System.Drawing.Point(180, 9)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(0, 15)
        Me.lblUsuario.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(50, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "USUARIO ACTIVO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(650, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FECHA:"
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFecha.Location = New System.Drawing.Point(708, 9)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(0, 15)
        Me.lblFecha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(860, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "HORA:"
        '
        'LblHora_Actual
        '
        Me.LblHora_Actual.AutoSize = True
        Me.LblHora_Actual.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora_Actual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblHora_Actual.Location = New System.Drawing.Point(908, 9)
        Me.LblHora_Actual.Name = "LblHora_Actual"
        Me.LblHora_Actual.Size = New System.Drawing.Size(0, 15)
        Me.LblHora_Actual.TabIndex = 3
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.btnMinimizar.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_minimizar
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnMinimizar.FlatAppearance.BorderSize = 0
        Me.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimizar.Location = New System.Drawing.Point(1006, 4)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(26, 25)
        Me.btnMinimizar.TabIndex = 2
        Me.btnMinimizar.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar.Location = New System.Drawing.Point(1037, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(26, 25)
        Me.btnCerrar.TabIndex = 0
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'Paneles
        '
        Me.Paneles.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Paneles.Controls.Add(Me.PictureBox2)
        Me.Paneles.Controls.Add(Me.pbVentas)
        Me.Paneles.Controls.Add(Me.pbUsuario)
        Me.Paneles.Controls.Add(Me.pbSede)
        Me.Paneles.Controls.Add(Me.PictureBox1)
        Me.Paneles.Controls.Add(Me.pbEntradas)
        Me.Paneles.Controls.Add(Me.pbArroba)
        Me.Paneles.Controls.Add(Me.PbEquipo)
        Me.Paneles.Controls.Add(Me.pbCliente)
        Me.Paneles.Controls.Add(Me.btnSalir)
        Me.Paneles.Controls.Add(Me.btnCorreo)
        Me.Paneles.Controls.Add(Me.btnEquipos)
        Me.Paneles.Controls.Add(Me.btnVentas)
        Me.Paneles.Controls.Add(Me.btnUsuarios)
        Me.Paneles.Controls.Add(Me.btnSede)
        Me.Paneles.Controls.Add(Me.MenuInicio)
        Me.Paneles.Controls.Add(Me.btnEntradas)
        Me.Paneles.Controls.Add(Me.btnClientes)
        Me.Paneles.Dock = System.Windows.Forms.DockStyle.Left
        Me.Paneles.Location = New System.Drawing.Point(0, 36)
        Me.Paneles.Margin = New System.Windows.Forms.Padding(30, 14, 3, 3)
        Me.Paneles.Name = "Paneles"
        Me.Paneles.Size = New System.Drawing.Size(220, 548)
        Me.Paneles.TabIndex = 2
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.salir
        Me.PictureBox2.Location = New System.Drawing.Point(0, 379)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'pbVentas
        '
        Me.pbVentas.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.venta
        Me.pbVentas.Location = New System.Drawing.Point(0, 329)
        Me.pbVentas.Name = "pbVentas"
        Me.pbVentas.Size = New System.Drawing.Size(60, 44)
        Me.pbVentas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbVentas.TabIndex = 14
        Me.pbVentas.TabStop = False
        '
        'pbUsuario
        '
        Me.pbUsuario.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.usuario
        Me.pbUsuario.Location = New System.Drawing.Point(1, 285)
        Me.pbUsuario.Name = "pbUsuario"
        Me.pbUsuario.Size = New System.Drawing.Size(55, 35)
        Me.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUsuario.TabIndex = 13
        Me.pbUsuario.TabStop = False
        '
        'pbSede
        '
        Me.pbSede.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.sede
        Me.pbSede.Location = New System.Drawing.Point(1, 231)
        Me.pbSede.Name = "pbSede"
        Me.pbSede.Size = New System.Drawing.Size(55, 48)
        Me.pbSede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSede.TabIndex = 12
        Me.pbSede.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.clientes
        Me.PictureBox1.Location = New System.Drawing.Point(0, 196)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'pbEntradas
        '
        Me.pbEntradas.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.entrada
        Me.pbEntradas.Location = New System.Drawing.Point(3, 152)
        Me.pbEntradas.Name = "pbEntradas"
        Me.pbEntradas.Size = New System.Drawing.Size(53, 38)
        Me.pbEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbEntradas.TabIndex = 10
        Me.pbEntradas.TabStop = False
        '
        'pbArroba
        '
        Me.pbArroba.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.arroba
        Me.pbArroba.Location = New System.Drawing.Point(3, 110)
        Me.pbArroba.Name = "pbArroba"
        Me.pbArroba.Size = New System.Drawing.Size(52, 34)
        Me.pbArroba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbArroba.TabIndex = 9
        Me.pbArroba.TabStop = False
        '
        'PbEquipo
        '
        Me.PbEquipo.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.equipo
        Me.PbEquipo.Location = New System.Drawing.Point(4, 57)
        Me.PbEquipo.Name = "PbEquipo"
        Me.PbEquipo.Size = New System.Drawing.Size(52, 39)
        Me.PbEquipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbEquipo.TabIndex = 8
        Me.PbEquipo.TabStop = False
        '
        'pbCliente
        '
        Me.pbCliente.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.cliente1
        Me.pbCliente.Location = New System.Drawing.Point(3, 1)
        Me.pbCliente.Name = "pbCliente"
        Me.pbCliente.Size = New System.Drawing.Size(52, 50)
        Me.pbCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbCliente.TabIndex = 7
        Me.pbCliente.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(66, 373)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(156, 38)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Cerrar Sesion"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnCorreo
        '
        Me.btnCorreo.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnCorreo.FlatAppearance.BorderSize = 0
        Me.btnCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCorreo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCorreo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCorreo.Location = New System.Drawing.Point(84, 102)
        Me.btnCorreo.Name = "btnCorreo"
        Me.btnCorreo.Size = New System.Drawing.Size(118, 44)
        Me.btnCorreo.TabIndex = 1
        Me.btnCorreo.Text = "CORREO ELECTRÓNICO"
        Me.btnCorreo.UseVisualStyleBackColor = True
        '
        'btnEquipos
        '
        Me.btnEquipos.FlatAppearance.BorderSize = 0
        Me.btnEquipos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEquipos.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEquipos.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipos.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEquipos.Location = New System.Drawing.Point(84, 57)
        Me.btnEquipos.Name = "btnEquipos"
        Me.btnEquipos.Size = New System.Drawing.Size(129, 39)
        Me.btnEquipos.TabIndex = 1
        Me.btnEquipos.Text = "CREAR EQUIPOS"
        Me.btnEquipos.UseVisualStyleBackColor = True
        '
        'btnVentas
        '
        Me.btnVentas.FlatAppearance.BorderSize = 0
        Me.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVentas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnVentas.Location = New System.Drawing.Point(66, 329)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(125, 38)
        Me.btnVentas.TabIndex = 5
        Me.btnVentas.Text = "VENTAS"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        'btnUsuarios
        '
        Me.btnUsuarios.FlatAppearance.BorderSize = 0
        Me.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUsuarios.Location = New System.Drawing.Point(58, 285)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(156, 38)
        Me.btnUsuarios.TabIndex = 1
        Me.btnUsuarios.Text = "USUARIOS"
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnSede
        '
        Me.btnSede.FlatAppearance.BorderSize = 0
        Me.btnSede.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSede.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnSede.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSede.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSede.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSede.Location = New System.Drawing.Point(84, 240)
        Me.btnSede.Name = "btnSede"
        Me.btnSede.Size = New System.Drawing.Size(77, 39)
        Me.btnSede.TabIndex = 1
        Me.btnSede.Text = "SEDES"
        Me.btnSede.UseVisualStyleBackColor = True
        '
        'MenuInicio
        '
        Me.MenuInicio.BackColor = System.Drawing.Color.Transparent
        Me.MenuInicio.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuInicio.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.grupos_tsmi})
        Me.MenuInicio.Location = New System.Drawing.Point(19, 193)
        Me.MenuInicio.Name = "MenuInicio"
        Me.MenuInicio.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuInicio.Size = New System.Drawing.Size(183, 44)
        Me.MenuInicio.TabIndex = 4
        Me.MenuInicio.Text = "MenuStrip1"
        '
        'grupos_tsmi
        '
        Me.grupos_tsmi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grupos_tsmi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.crear_grupo_tsmi, Me.grupos_usuarios_tsmi, Me.grupos_permisos_tsmi})
        Me.grupos_tsmi.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grupos_tsmi.ForeColor = System.Drawing.SystemColors.Control
        Me.grupos_tsmi.ImageTransparentColor = System.Drawing.Color.LightSkyBlue
        Me.grupos_tsmi.Margin = New System.Windows.Forms.Padding(30, -1, 0, 0)
        Me.grupos_tsmi.Name = "grupos_tsmi"
        Me.grupos_tsmi.Padding = New System.Windows.Forms.Padding(5, 1, 80, 20)
        Me.grupos_tsmi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grupos_tsmi.Size = New System.Drawing.Size(145, 41)
        Me.grupos_tsmi.Text = "GRUPOS"
        '
        'crear_grupo_tsmi
        '
        Me.crear_grupo_tsmi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.crear_grupo_tsmi.ForeColor = System.Drawing.Color.White
        Me.crear_grupo_tsmi.ImageTransparentColor = System.Drawing.Color.LightSkyBlue
        Me.crear_grupo_tsmi.Name = "crear_grupo_tsmi"
        Me.crear_grupo_tsmi.Size = New System.Drawing.Size(172, 22)
        Me.crear_grupo_tsmi.Text = "Crear Grupo"
        '
        'grupos_usuarios_tsmi
        '
        Me.grupos_usuarios_tsmi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grupos_usuarios_tsmi.ForeColor = System.Drawing.Color.White
        Me.grupos_usuarios_tsmi.Name = "grupos_usuarios_tsmi"
        Me.grupos_usuarios_tsmi.Size = New System.Drawing.Size(172, 22)
        Me.grupos_usuarios_tsmi.Text = "Grupos Usuarios"
        '
        'grupos_permisos_tsmi
        '
        Me.grupos_permisos_tsmi.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grupos_permisos_tsmi.ForeColor = System.Drawing.Color.White
        Me.grupos_permisos_tsmi.Name = "grupos_permisos_tsmi"
        Me.grupos_permisos_tsmi.Size = New System.Drawing.Size(172, 22)
        Me.grupos_permisos_tsmi.Text = "Grupos Permisos"
        '
        'btnEntradas
        '
        Me.btnEntradas.FlatAppearance.BorderSize = 0
        Me.btnEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEntradas.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntradas.ForeColor = System.Drawing.SystemColors.Control
        Me.btnEntradas.Location = New System.Drawing.Point(76, 152)
        Me.btnEntradas.Name = "btnEntradas"
        Me.btnEntradas.Size = New System.Drawing.Size(115, 39)
        Me.btnEntradas.TabIndex = 1
        Me.btnEntradas.Text = "ENTRADAS"
        Me.btnEntradas.UseVisualStyleBackColor = True
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Transparent
        Me.btnClientes.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnClientes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnClientes.FlatAppearance.BorderSize = 0
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.Control
        Me.btnClientes.Location = New System.Drawing.Point(65, 6)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(120, 39)
        Me.btnClientes.TabIndex = 0
        Me.btnClientes.Text = "CLIENTES"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'panel_contenedor
        '
        Me.panel_contenedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panel_contenedor.Controls.Add(Me.pbSaf)
        Me.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_contenedor.Location = New System.Drawing.Point(220, 36)
        Me.panel_contenedor.Name = "panel_contenedor"
        Me.panel_contenedor.Size = New System.Drawing.Size(855, 548)
        Me.panel_contenedor.TabIndex = 3
        '
        'pbSaf
        '
        Me.pbSaf.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.Sin_título_1
        Me.pbSaf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbSaf.Location = New System.Drawing.Point(195, 110)
        Me.pbSaf.Name = "pbSaf"
        Me.pbSaf.Size = New System.Drawing.Size(428, 263)
        Me.pbSaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbSaf.TabIndex = 0
        Me.pbSaf.TabStop = False
        '
        'tmHora
        '
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1075, 584)
        Me.Controls.Add(Me.panel_contenedor)
        Me.Controls.Add(Me.Paneles)
        Me.Controls.Add(Me.Panel_arriba)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.Panel_arriba.ResumeLayout(False)
        Me.Panel_arriba.PerformLayout()
        CType(Me.PbSlide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Paneles.ResumeLayout(False)
        Me.Paneles.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSede, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbArroba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuInicio.ResumeLayout(False)
        Me.MenuInicio.PerformLayout()
        Me.panel_contenedor.ResumeLayout(False)
        CType(Me.pbSaf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel_arriba As System.Windows.Forms.Panel
    Friend WithEvents Paneles As System.Windows.Forms.Panel
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents btnCorreo As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMinimizar As System.Windows.Forms.Button
    Friend WithEvents panel_contenedor As System.Windows.Forms.Panel
    Friend WithEvents pbSaf As System.Windows.Forms.PictureBox
    Friend WithEvents btnEntradas As System.Windows.Forms.Button
    Friend WithEvents btnEquipos As System.Windows.Forms.Button
    Friend WithEvents MenuInicio As System.Windows.Forms.MenuStrip
    Friend WithEvents grupos_tsmi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents crear_grupo_tsmi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grupos_usuarios_tsmi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents grupos_permisos_tsmi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSede As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnVentas As System.Windows.Forms.Button
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents LblHora_Actual As System.Windows.Forms.Label
    Friend WithEvents tmHora As System.Windows.Forms.Timer
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pbCliente As System.Windows.Forms.PictureBox
    Friend WithEvents PbSlide As System.Windows.Forms.PictureBox
    Friend WithEvents PbEquipo As System.Windows.Forms.PictureBox
    Friend WithEvents pbArroba As System.Windows.Forms.PictureBox
    Friend WithEvents pbEntradas As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbSede As System.Windows.Forms.PictureBox
    Friend WithEvents pbUsuario As System.Windows.Forms.PictureBox
    Friend WithEvents pbVentas As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
