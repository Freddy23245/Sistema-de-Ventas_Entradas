<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.chk_habilitado = New System.Windows.Forms.CheckBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dt_usuarios = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblId_usuario = New System.Windows.Forms.Label()
        Me.cmbUsuario = New System.Windows.Forms.ComboBox()
        Me.txtBuscar_usu = New System.Windows.Forms.TextBox()
        Me.ErrorUsuarios = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCerrar_usuario = New System.Windows.Forms.Button()
        Me.Panel_usu = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LsBuscar_usu = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Lscontraseña = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsUsuario = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsDni_cliente = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsNombre_usu = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsId_usu = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PbAgregar_usu = New System.Windows.Forms.PictureBox()
        Me.PbEditar_usu = New System.Windows.Forms.PictureBox()
        Me.Pbeliminar_usu = New System.Windows.Forms.PictureBox()
        Me.PbLimpiar_usu = New System.Windows.Forms.PictureBox()
        Me.chkbUsu = New System.Windows.Forms.CheckBox()
        Me.LblSeleccion_usu = New System.Windows.Forms.Label()
        CType(Me.dt_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_usu.SuspendLayout()
        CType(Me.PbAgregar_usu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEditar_usu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbeliminar_usu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLimpiar_usu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Location = New System.Drawing.Point(17, 280)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(101, 44)
        Me.btn_agregar.TabIndex = 0
        Me.btn_agregar.Text = "          Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_editar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_editar.Location = New System.Drawing.Point(124, 280)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(101, 44)
        Me.btn_editar.TabIndex = 1
        Me.btn_editar.Text = "         Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Location = New System.Drawing.Point(17, 327)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(101, 44)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "          Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'chk_habilitado
        '
        Me.chk_habilitado.AutoSize = True
        Me.chk_habilitado.BackColor = System.Drawing.Color.Transparent
        Me.chk_habilitado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_habilitado.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.chk_habilitado.Location = New System.Drawing.Point(88, 241)
        Me.chk_habilitado.Name = "chk_habilitado"
        Me.chk_habilitado.Size = New System.Drawing.Size(96, 20)
        Me.chk_habilitado.TabIndex = 3
        Me.chk_habilitado.Text = "Habilitado"
        Me.chk_habilitado.UseVisualStyleBackColor = False
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.ForeColor = System.Drawing.Color.White
        Me.txt_nombre.Location = New System.Drawing.Point(90, 105)
        Me.txt_nombre.MaxLength = 30
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(166, 13)
        Me.txt_nombre.TabIndex = 5
        '
        'txt_dni
        '
        Me.txt_dni.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dni.ForeColor = System.Drawing.Color.White
        Me.txt_dni.Location = New System.Drawing.Point(90, 135)
        Me.txt_dni.MaxLength = 8
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(96, 13)
        Me.txt_dni.TabIndex = 6
        '
        'txt_usuario
        '
        Me.txt_usuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_usuario.ForeColor = System.Drawing.Color.White
        Me.txt_usuario.Location = New System.Drawing.Point(89, 167)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(204, 13)
        Me.txt_usuario.TabIndex = 7
        '
        'txt_contraseña
        '
        Me.txt_contraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_contraseña.ForeColor = System.Drawing.Color.White
        Me.txt_contraseña.Location = New System.Drawing.Point(89, 206)
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(204, 13)
        Me.txt_contraseña.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(26, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(53, 132)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Dni:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(26, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Usuario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(1, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Contraseña:"
        '
        'dt_usuarios
        '
        Me.dt_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dt_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dt_usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dt_usuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_usuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_usuarios.ColumnHeadersHeight = 30
        Me.dt_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dt_usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dt_usuarios.EnableHeadersVisualStyles = False
        Me.dt_usuarios.GridColor = System.Drawing.Color.SteelBlue
        Me.dt_usuarios.Location = New System.Drawing.Point(357, 85)
        Me.dt_usuarios.Name = "dt_usuarios"
        Me.dt_usuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_usuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dt_usuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_usuarios.Size = New System.Drawing.Size(426, 214)
        Me.dt_usuarios.TabIndex = 13
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 60
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.Location = New System.Drawing.Point(124, 327)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(101, 44)
        Me.btnLimpiar.TabIndex = 14
        Me.btnLimpiar.Text = "           Limpiar "
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(26, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Código:"
        '
        'lblId_usuario
        '
        Me.lblId_usuario.AutoSize = True
        Me.lblId_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lblId_usuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblId_usuario.ForeColor = System.Drawing.SystemColors.Control
        Me.lblId_usuario.Location = New System.Drawing.Point(87, 68)
        Me.lblId_usuario.Name = "lblId_usuario"
        Me.lblId_usuario.Size = New System.Drawing.Size(0, 16)
        Me.lblId_usuario.TabIndex = 16
        '
        'cmbUsuario
        '
        Me.cmbUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cmbUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbUsuario.ForeColor = System.Drawing.Color.White
        Me.cmbUsuario.FormattingEnabled = True
        Me.cmbUsuario.Items.AddRange(New Object() {"nombre", "dni", "usuario"})
        Me.cmbUsuario.Location = New System.Drawing.Point(494, 303)
        Me.cmbUsuario.Name = "cmbUsuario"
        Me.cmbUsuario.Size = New System.Drawing.Size(150, 24)
        Me.cmbUsuario.TabIndex = 18
        '
        'txtBuscar_usu
        '
        Me.txtBuscar_usu.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtBuscar_usu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar_usu.ForeColor = System.Drawing.Color.White
        Me.txtBuscar_usu.Location = New System.Drawing.Point(650, 306)
        Me.txtBuscar_usu.Name = "txtBuscar_usu"
        Me.txtBuscar_usu.Size = New System.Drawing.Size(135, 13)
        Me.txtBuscar_usu.TabIndex = 19
        '
        'ErrorUsuarios
        '
        Me.ErrorUsuarios.ContainerControl = Me
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(354, 306)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Buscar Usuario por:"
        '
        'btnCerrar_usuario
        '
        Me.btnCerrar_usuario.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_usuario.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_usuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_usuario.FlatAppearance.BorderSize = 0
        Me.btnCerrar_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_usuario.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_usuario.Location = New System.Drawing.Point(787, 0)
        Me.btnCerrar_usuario.Name = "btnCerrar_usuario"
        Me.btnCerrar_usuario.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_usuario.TabIndex = 27
        Me.btnCerrar_usuario.UseVisualStyleBackColor = False
        '
        'Panel_usu
        '
        Me.Panel_usu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_usu.Controls.Add(Me.Label7)
        Me.Panel_usu.Controls.Add(Me.btnCerrar_usuario)
        Me.Panel_usu.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_usu.Location = New System.Drawing.Point(0, 0)
        Me.Panel_usu.Name = "Panel_usu"
        Me.Panel_usu.Size = New System.Drawing.Size(815, 28)
        Me.Panel_usu.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(310, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "GESTIÓN DE USUARIOS"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LsBuscar_usu, Me.Lscontraseña, Me.LsUsuario, Me.LsDni_cliente, Me.LsNombre_usu, Me.LsId_usu})
        Me.ShapeContainer1.Size = New System.Drawing.Size(815, 390)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
        '
        'LsBuscar_usu
        '
        Me.LsBuscar_usu.BorderColor = System.Drawing.Color.White
        Me.LsBuscar_usu.Name = "LsBuscar_usu"
        Me.LsBuscar_usu.X1 = 650
        Me.LsBuscar_usu.X2 = 786
        Me.LsBuscar_usu.Y1 = 324
        Me.LsBuscar_usu.Y2 = 324
        '
        'Lscontraseña
        '
        Me.Lscontraseña.BorderColor = System.Drawing.Color.White
        Me.Lscontraseña.Name = "Lscontraseña"
        Me.Lscontraseña.X1 = 88
        Me.Lscontraseña.X2 = 293
        Me.Lscontraseña.Y1 = 224
        Me.Lscontraseña.Y2 = 224
        '
        'LsUsuario
        '
        Me.LsUsuario.BorderColor = System.Drawing.Color.White
        Me.LsUsuario.Name = "LsUsuario"
        Me.LsUsuario.X1 = 89
        Me.LsUsuario.X2 = 292
        Me.LsUsuario.Y1 = 187
        Me.LsUsuario.Y2 = 187
        '
        'LsDni_cliente
        '
        Me.LsDni_cliente.BorderColor = System.Drawing.Color.White
        Me.LsDni_cliente.Name = "LsDni_cliente"
        Me.LsDni_cliente.X1 = 89
        Me.LsDni_cliente.X2 = 188
        Me.LsDni_cliente.Y1 = 153
        Me.LsDni_cliente.Y2 = 153
        '
        'LsNombre_usu
        '
        Me.LsNombre_usu.BorderColor = System.Drawing.SystemColors.Window
        Me.LsNombre_usu.Name = "LsNombre_usu"
        Me.LsNombre_usu.X1 = 90
        Me.LsNombre_usu.X2 = 254
        Me.LsNombre_usu.Y1 = 120
        Me.LsNombre_usu.Y2 = 120
        '
        'LsId_usu
        '
        Me.LsId_usu.BorderColor = System.Drawing.Color.White
        Me.LsId_usu.Name = "LsId_usu"
        Me.LsId_usu.X1 = 89
        Me.LsId_usu.X2 = 157
        Me.LsId_usu.Y1 = 85
        Me.LsId_usu.Y2 = 85
        '
        'PbAgregar_usu
        '
        Me.PbAgregar_usu.BackColor = System.Drawing.Color.SeaGreen
        Me.PbAgregar_usu.Enabled = False
        Me.PbAgregar_usu.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.PbAgregar_usu.Location = New System.Drawing.Point(21, 284)
        Me.PbAgregar_usu.Name = "PbAgregar_usu"
        Me.PbAgregar_usu.Size = New System.Drawing.Size(36, 35)
        Me.PbAgregar_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbAgregar_usu.TabIndex = 30
        Me.PbAgregar_usu.TabStop = False
        '
        'PbEditar_usu
        '
        Me.PbEditar_usu.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEditar_usu.Enabled = False
        Me.PbEditar_usu.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.editar
        Me.PbEditar_usu.Location = New System.Drawing.Point(128, 283)
        Me.PbEditar_usu.Name = "PbEditar_usu"
        Me.PbEditar_usu.Size = New System.Drawing.Size(36, 35)
        Me.PbEditar_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEditar_usu.TabIndex = 31
        Me.PbEditar_usu.TabStop = False
        '
        'Pbeliminar_usu
        '
        Me.Pbeliminar_usu.BackColor = System.Drawing.Color.SeaGreen
        Me.Pbeliminar_usu.Enabled = False
        Me.Pbeliminar_usu.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.eliminar
        Me.Pbeliminar_usu.Location = New System.Drawing.Point(21, 331)
        Me.Pbeliminar_usu.Name = "Pbeliminar_usu"
        Me.Pbeliminar_usu.Size = New System.Drawing.Size(36, 35)
        Me.Pbeliminar_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbeliminar_usu.TabIndex = 32
        Me.Pbeliminar_usu.TabStop = False
        '
        'PbLimpiar_usu
        '
        Me.PbLimpiar_usu.BackColor = System.Drawing.Color.SeaGreen
        Me.PbLimpiar_usu.Enabled = False
        Me.PbLimpiar_usu.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.Limpiar
        Me.PbLimpiar_usu.Location = New System.Drawing.Point(128, 332)
        Me.PbLimpiar_usu.Name = "PbLimpiar_usu"
        Me.PbLimpiar_usu.Size = New System.Drawing.Size(36, 35)
        Me.PbLimpiar_usu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbLimpiar_usu.TabIndex = 33
        Me.PbLimpiar_usu.TabStop = False
        '
        'chkbUsu
        '
        Me.chkbUsu.AutoSize = True
        Me.chkbUsu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkbUsu.ForeColor = System.Drawing.Color.White
        Me.chkbUsu.Location = New System.Drawing.Point(357, 59)
        Me.chkbUsu.Name = "chkbUsu"
        Me.chkbUsu.Size = New System.Drawing.Size(179, 20)
        Me.chkbUsu.TabIndex = 34
        Me.chkbUsu.Text = "Usuarios seleccionados"
        Me.chkbUsu.UseVisualStyleBackColor = True
        '
        'LblSeleccion_usu
        '
        Me.LblSeleccion_usu.AutoSize = True
        Me.LblSeleccion_usu.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblSeleccion_usu.ForeColor = System.Drawing.Color.White
        Me.LblSeleccion_usu.Location = New System.Drawing.Point(531, 60)
        Me.LblSeleccion_usu.Name = "LblSeleccion_usu"
        Me.LblSeleccion_usu.Size = New System.Drawing.Size(0, 16)
        Me.LblSeleccion_usu.TabIndex = 35
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(815, 390)
        Me.Controls.Add(Me.LblSeleccion_usu)
        Me.Controls.Add(Me.chkbUsu)
        Me.Controls.Add(Me.PbLimpiar_usu)
        Me.Controls.Add(Me.Pbeliminar_usu)
        Me.Controls.Add(Me.PbEditar_usu)
        Me.Controls.Add(Me.PbAgregar_usu)
        Me.Controls.Add(Me.Panel_usu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtBuscar_usu)
        Me.Controls.Add(Me.cmbUsuario)
        Me.Controls.Add(Me.lblId_usuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.dt_usuarios)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_contraseña)
        Me.Controls.Add(Me.txt_usuario)
        Me.Controls.Add(Me.txt_dni)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.chk_habilitado)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.dt_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_usu.ResumeLayout(False)
        Me.Panel_usu.PerformLayout()
        CType(Me.PbAgregar_usu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEditar_usu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbeliminar_usu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLimpiar_usu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents chk_habilitado As System.Windows.Forms.CheckBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblId_usuario As System.Windows.Forms.Label
    Friend WithEvents cmbUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents txtBuscar_usu As System.Windows.Forms.TextBox
    Friend WithEvents ErrorUsuarios As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar_usuario As System.Windows.Forms.Button
    Friend WithEvents Panel_usu As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LsId_usu As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Lscontraseña As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsUsuario As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsDni_cliente As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsNombre_usu As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsBuscar_usu As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PbLimpiar_usu As System.Windows.Forms.PictureBox
    Friend WithEvents Pbeliminar_usu As System.Windows.Forms.PictureBox
    Friend WithEvents PbEditar_usu As System.Windows.Forms.PictureBox
    Friend WithEvents PbAgregar_usu As System.Windows.Forms.PictureBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents chkbUsu As System.Windows.Forms.CheckBox
    Friend WithEvents LblSeleccion_usu As System.Windows.Forms.Label
End Class
