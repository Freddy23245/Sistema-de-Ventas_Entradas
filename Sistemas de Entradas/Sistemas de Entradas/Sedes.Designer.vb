<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sedes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sedes))
        Me.txt_nom_sede = New System.Windows.Forms.TextBox()
        Me.txt_dir_sede = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.dt_sede = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_nueva_sede = New System.Windows.Forms.Button()
        Me.txtflag = New System.Windows.Forms.TextBox()
        Me.txtBuscar_Sede = New System.Windows.Forms.TextBox()
        Me.cmbSede = New System.Windows.Forms.ComboBox()
        Me.ErrorSede = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel_Sede = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCerrar_sede = New System.Windows.Forms.Button()
        Me.LblId_sede = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LsBuscar_Sede = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsDireccion_Sede = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsNombre_Sede = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Ls_idSede = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PbNueva_sede = New System.Windows.Forms.PictureBox()
        Me.PbEliminar_Sede = New System.Windows.Forms.PictureBox()
        Me.PbEditar_sede = New System.Windows.Forms.PictureBox()
        Me.PbAgregar_sede = New System.Windows.Forms.PictureBox()
        Me.chkbSede = New System.Windows.Forms.CheckBox()
        Me.LblSeleccion_sede = New System.Windows.Forms.Label()
        Me.Lblbuscarpor_Sede = New System.Windows.Forms.Label()
        CType(Me.dt_sede, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorSede, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Sede.SuspendLayout()
        CType(Me.PbNueva_sede, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEliminar_Sede, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEditar_sede, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbAgregar_sede, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_nom_sede
        '
        Me.txt_nom_sede.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_nom_sede.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nom_sede.ForeColor = System.Drawing.Color.White
        Me.txt_nom_sede.Location = New System.Drawing.Point(143, 94)
        Me.txt_nom_sede.Name = "txt_nom_sede"
        Me.txt_nom_sede.Size = New System.Drawing.Size(184, 13)
        Me.txt_nom_sede.TabIndex = 2
        '
        'txt_dir_sede
        '
        Me.txt_dir_sede.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_dir_sede.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dir_sede.ForeColor = System.Drawing.Color.White
        Me.txt_dir_sede.Location = New System.Drawing.Point(143, 124)
        Me.txt_dir_sede.Name = "txt_dir_sede"
        Me.txt_dir_sede.Size = New System.Drawing.Size(268, 13)
        Me.txt_dir_sede.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(2, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nombre de la Sede:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(8, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Dirección de Sede:"
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Location = New System.Drawing.Point(425, 182)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(109, 44)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "              Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modificar.Location = New System.Drawing.Point(425, 228)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(109, 44)
        Me.btn_modificar.TabIndex = 7
        Me.btn_modificar.Text = "             Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Location = New System.Drawing.Point(425, 278)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(109, 44)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.Text = "              Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'dt_sede
        '
        Me.dt_sede.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_sede.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_sede.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dt_sede.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dt_sede.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dt_sede.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_sede.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_sede.ColumnHeadersHeight = 30
        Me.dt_sede.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dt_sede.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dt_sede.EnableHeadersVisualStyles = False
        Me.dt_sede.GridColor = System.Drawing.Color.SteelBlue
        Me.dt_sede.Location = New System.Drawing.Point(9, 182)
        Me.dt_sede.Name = "dt_sede"
        Me.dt_sede.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_sede.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dt_sede.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_sede.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_sede.Size = New System.Drawing.Size(402, 182)
        Me.dt_sede.TabIndex = 5
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(47, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nº de Sede:"
        '
        'btn_nueva_sede
        '
        Me.btn_nueva_sede.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_nueva_sede.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nueva_sede.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_nueva_sede.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_nueva_sede.Location = New System.Drawing.Point(425, 329)
        Me.btn_nueva_sede.Name = "btn_nueva_sede"
        Me.btn_nueva_sede.Size = New System.Drawing.Size(109, 44)
        Me.btn_nueva_sede.TabIndex = 9
        Me.btn_nueva_sede.Text = "             Nueva   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Sede"
        Me.btn_nueva_sede.UseVisualStyleBackColor = False
        '
        'txtflag
        '
        Me.txtflag.Location = New System.Drawing.Point(500, 36)
        Me.txtflag.Name = "txtflag"
        Me.txtflag.Size = New System.Drawing.Size(34, 20)
        Me.txtflag.TabIndex = 0
        Me.txtflag.Text = "0"
        '
        'txtBuscar_Sede
        '
        Me.txtBuscar_Sede.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtBuscar_Sede.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar_Sede.ForeColor = System.Drawing.Color.White
        Me.txtBuscar_Sede.Location = New System.Drawing.Point(259, 373)
        Me.txtBuscar_Sede.Name = "txtBuscar_Sede"
        Me.txtBuscar_Sede.Size = New System.Drawing.Size(145, 13)
        Me.txtBuscar_Sede.TabIndex = 11
        '
        'cmbSede
        '
        Me.cmbSede.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cmbSede.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbSede.ForeColor = System.Drawing.Color.White
        Me.cmbSede.FormattingEnabled = True
        Me.cmbSede.Items.AddRange(New Object() {"nombre", "direccion"})
        Me.cmbSede.Location = New System.Drawing.Point(127, 370)
        Me.cmbSede.Name = "cmbSede"
        Me.cmbSede.Size = New System.Drawing.Size(122, 24)
        Me.cmbSede.TabIndex = 10
        '
        'ErrorSede
        '
        Me.ErrorSede.ContainerControl = Me
        '
        'Panel_Sede
        '
        Me.Panel_Sede.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_Sede.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Sede.Controls.Add(Me.Label3)
        Me.Panel_Sede.Controls.Add(Me.btnCerrar_sede)
        Me.Panel_Sede.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Sede.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Sede.Name = "Panel_Sede"
        Me.Panel_Sede.Size = New System.Drawing.Size(550, 30)
        Me.Panel_Sede.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(179, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 15)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "GESTIÓN DE SEDES"
        '
        'btnCerrar_sede
        '
        Me.btnCerrar_sede.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_sede.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_sede.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_sede.FlatAppearance.BorderSize = 0
        Me.btnCerrar_sede.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_sede.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_sede.Location = New System.Drawing.Point(512, 0)
        Me.btnCerrar_sede.Name = "btnCerrar_sede"
        Me.btnCerrar_sede.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_sede.TabIndex = 27
        Me.btnCerrar_sede.UseVisualStyleBackColor = False
        '
        'LblId_sede
        '
        Me.LblId_sede.AutoSize = True
        Me.LblId_sede.BackColor = System.Drawing.Color.Transparent
        Me.LblId_sede.ForeColor = System.Drawing.Color.White
        Me.LblId_sede.Location = New System.Drawing.Point(137, 64)
        Me.LblId_sede.Name = "LblId_sede"
        Me.LblId_sede.Size = New System.Drawing.Size(0, 13)
        Me.LblId_sede.TabIndex = 1
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LsBuscar_Sede, Me.LsDireccion_Sede, Me.LsNombre_Sede, Me.Ls_idSede})
        Me.ShapeContainer1.Size = New System.Drawing.Size(550, 468)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'LsBuscar_Sede
        '
        Me.LsBuscar_Sede.BorderColor = System.Drawing.Color.White
        Me.LsBuscar_Sede.Name = "LsBuscar_Sede"
        Me.LsBuscar_Sede.X1 = 259
        Me.LsBuscar_Sede.X2 = 403
        Me.LsBuscar_Sede.Y1 = 392
        Me.LsBuscar_Sede.Y2 = 392
        '
        'LsDireccion_Sede
        '
        Me.LsDireccion_Sede.BorderColor = System.Drawing.Color.White
        Me.LsDireccion_Sede.Name = "LsDireccion_Sede"
        Me.LsDireccion_Sede.X1 = 140
        Me.LsDireccion_Sede.X2 = 410
        Me.LsDireccion_Sede.Y1 = 140
        Me.LsDireccion_Sede.Y2 = 140
        '
        'LsNombre_Sede
        '
        Me.LsNombre_Sede.BorderColor = System.Drawing.Color.White
        Me.LsNombre_Sede.Name = "LsNombre_Sede"
        Me.LsNombre_Sede.X1 = 140
        Me.LsNombre_Sede.X2 = 326
        Me.LsNombre_Sede.Y1 = 113
        Me.LsNombre_Sede.Y2 = 113
        '
        'Ls_idSede
        '
        Me.Ls_idSede.BorderColor = System.Drawing.Color.White
        Me.Ls_idSede.Name = "Ls_idSede"
        Me.Ls_idSede.X1 = 140
        Me.Ls_idSede.X2 = 218
        Me.Ls_idSede.Y1 = 79
        Me.Ls_idSede.Y2 = 79
        '
        'PbNueva_sede
        '
        Me.PbNueva_sede.BackColor = System.Drawing.Color.SeaGreen
        Me.PbNueva_sede.Enabled = False
        Me.PbNueva_sede.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.nuevo
        Me.PbNueva_sede.Location = New System.Drawing.Point(434, 334)
        Me.PbNueva_sede.Name = "PbNueva_sede"
        Me.PbNueva_sede.Size = New System.Drawing.Size(36, 35)
        Me.PbNueva_sede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbNueva_sede.TabIndex = 34
        Me.PbNueva_sede.TabStop = False
        '
        'PbEliminar_Sede
        '
        Me.PbEliminar_Sede.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEliminar_Sede.Enabled = False
        Me.PbEliminar_Sede.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.eliminar
        Me.PbEliminar_Sede.Location = New System.Drawing.Point(434, 282)
        Me.PbEliminar_Sede.Name = "PbEliminar_Sede"
        Me.PbEliminar_Sede.Size = New System.Drawing.Size(36, 35)
        Me.PbEliminar_Sede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEliminar_Sede.TabIndex = 33
        Me.PbEliminar_Sede.TabStop = False
        '
        'PbEditar_sede
        '
        Me.PbEditar_sede.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEditar_sede.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.editar
        Me.PbEditar_sede.Location = New System.Drawing.Point(434, 232)
        Me.PbEditar_sede.Name = "PbEditar_sede"
        Me.PbEditar_sede.Size = New System.Drawing.Size(36, 35)
        Me.PbEditar_sede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEditar_sede.TabIndex = 32
        Me.PbEditar_sede.TabStop = False
        '
        'PbAgregar_sede
        '
        Me.PbAgregar_sede.BackColor = System.Drawing.Color.SeaGreen
        Me.PbAgregar_sede.Enabled = False
        Me.PbAgregar_sede.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.PbAgregar_sede.Location = New System.Drawing.Point(434, 186)
        Me.PbAgregar_sede.Name = "PbAgregar_sede"
        Me.PbAgregar_sede.Size = New System.Drawing.Size(36, 35)
        Me.PbAgregar_sede.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbAgregar_sede.TabIndex = 31
        Me.PbAgregar_sede.TabStop = False
        '
        'chkbSede
        '
        Me.chkbSede.AutoSize = True
        Me.chkbSede.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkbSede.ForeColor = System.Drawing.Color.White
        Me.chkbSede.Location = New System.Drawing.Point(9, 159)
        Me.chkbSede.Name = "chkbSede"
        Me.chkbSede.Size = New System.Drawing.Size(164, 20)
        Me.chkbSede.TabIndex = 4
        Me.chkbSede.Text = "Sedes seleccionadas"
        Me.chkbSede.UseVisualStyleBackColor = True
        '
        'LblSeleccion_sede
        '
        Me.LblSeleccion_sede.AutoSize = True
        Me.LblSeleccion_sede.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblSeleccion_sede.ForeColor = System.Drawing.Color.White
        Me.LblSeleccion_sede.Location = New System.Drawing.Point(168, 160)
        Me.LblSeleccion_sede.Name = "LblSeleccion_sede"
        Me.LblSeleccion_sede.Size = New System.Drawing.Size(0, 16)
        Me.LblSeleccion_sede.TabIndex = 36
        '
        'Lblbuscarpor_Sede
        '
        Me.Lblbuscarpor_Sede.AutoSize = True
        Me.Lblbuscarpor_Sede.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Lblbuscarpor_Sede.ForeColor = System.Drawing.Color.White
        Me.Lblbuscarpor_Sede.Location = New System.Drawing.Point(4, 373)
        Me.Lblbuscarpor_Sede.Name = "Lblbuscarpor_Sede"
        Me.Lblbuscarpor_Sede.Size = New System.Drawing.Size(117, 16)
        Me.Lblbuscarpor_Sede.TabIndex = 37
        Me.Lblbuscarpor_Sede.Text = "Buscar sede por:"
        '
        'Sedes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(550, 468)
        Me.Controls.Add(Me.Lblbuscarpor_Sede)
        Me.Controls.Add(Me.LblSeleccion_sede)
        Me.Controls.Add(Me.chkbSede)
        Me.Controls.Add(Me.PbNueva_sede)
        Me.Controls.Add(Me.PbEliminar_Sede)
        Me.Controls.Add(Me.PbEditar_sede)
        Me.Controls.Add(Me.PbAgregar_sede)
        Me.Controls.Add(Me.LblId_sede)
        Me.Controls.Add(Me.Panel_Sede)
        Me.Controls.Add(Me.cmbSede)
        Me.Controls.Add(Me.txtBuscar_Sede)
        Me.Controls.Add(Me.txtflag)
        Me.Controls.Add(Me.btn_nueva_sede)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dt_sede)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_dir_sede)
        Me.Controls.Add(Me.txt_nom_sede)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Sedes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sedes"
        CType(Me.dt_sede, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorSede, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Sede.ResumeLayout(False)
        Me.Panel_Sede.PerformLayout()
        CType(Me.PbNueva_sede, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEliminar_Sede, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEditar_sede, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbAgregar_sede, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_nom_sede As System.Windows.Forms.TextBox
    Friend WithEvents txt_dir_sede As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents dt_sede As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_nueva_sede As System.Windows.Forms.Button
    Friend WithEvents txtflag As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscar_Sede As System.Windows.Forms.TextBox
    Friend WithEvents cmbSede As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorSede As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCerrar_sede As System.Windows.Forms.Button
    Friend WithEvents Panel_Sede As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblId_sede As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LsDireccion_Sede As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsNombre_Sede As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Ls_idSede As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PbNueva_sede As System.Windows.Forms.PictureBox
    Friend WithEvents PbEliminar_Sede As System.Windows.Forms.PictureBox
    Friend WithEvents PbEditar_sede As System.Windows.Forms.PictureBox
    Friend WithEvents PbAgregar_sede As System.Windows.Forms.PictureBox
    Friend WithEvents chkbSede As System.Windows.Forms.CheckBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LblSeleccion_sede As System.Windows.Forms.Label
    Friend WithEvents LsBuscar_Sede As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Lblbuscarpor_Sede As System.Windows.Forms.Label
End Class
