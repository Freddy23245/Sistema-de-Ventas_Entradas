<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Entradas))
        Me.txt_flag = New System.Windows.Forms.TextBox()
        Me.dt_entradas = New System.Windows.Forms.DataGridView()
        Me.GbEntradas = New System.Windows.Forms.GroupBox()
        Me.PbNueva_ent = New System.Windows.Forms.PictureBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Pbeditar_ent = New System.Windows.Forms.PictureBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.PbEliminar_ent = New System.Windows.Forms.PictureBox()
        Me.pb_agregarEnt = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.lblId_sede = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnbuscar_producto = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbx_visitante = New System.Windows.Forms.ComboBox()
        Me.cbx_local = New System.Windows.Forms.ComboBox()
        Me.txt_nombre_sede = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dtp_hora = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_stock = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LsStock = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Lsprecio = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsSeparador = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Lsnombre_sede = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsId_sede = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ErrorEntradas = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel_topEntradas = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnCerrar_ent = New System.Windows.Forms.Button()
        Me.lblId_entrada = New System.Windows.Forms.Label()
        CType(Me.dt_entradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbEntradas.SuspendLayout()
        CType(Me.PbNueva_ent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbeditar_ent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEliminar_ent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_agregarEnt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_topEntradas.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_flag
        '
        Me.txt_flag.Location = New System.Drawing.Point(863, 470)
        Me.txt_flag.Name = "txt_flag"
        Me.txt_flag.Size = New System.Drawing.Size(26, 20)
        Me.txt_flag.TabIndex = 16
        Me.txt_flag.Text = "0"
        '
        'dt_entradas
        '
        Me.dt_entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_entradas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_entradas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dt_entradas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dt_entradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dt_entradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_entradas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_entradas.ColumnHeadersHeight = 30
        Me.dt_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dt_entradas.EnableHeadersVisualStyles = False
        Me.dt_entradas.GridColor = System.Drawing.Color.SteelBlue
        Me.dt_entradas.Location = New System.Drawing.Point(447, 97)
        Me.dt_entradas.Name = "dt_entradas"
        Me.dt_entradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_entradas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dt_entradas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_entradas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_entradas.Size = New System.Drawing.Size(442, 367)
        Me.dt_entradas.TabIndex = 15
        '
        'GbEntradas
        '
        Me.GbEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GbEntradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GbEntradas.Controls.Add(Me.PbNueva_ent)
        Me.GbEntradas.Controls.Add(Me.btnNuevo)
        Me.GbEntradas.Controls.Add(Me.Pbeditar_ent)
        Me.GbEntradas.Controls.Add(Me.btn_modificar)
        Me.GbEntradas.Controls.Add(Me.PbEliminar_ent)
        Me.GbEntradas.Controls.Add(Me.pb_agregarEnt)
        Me.GbEntradas.Controls.Add(Me.btn_eliminar)
        Me.GbEntradas.Controls.Add(Me.lblId_sede)
        Me.GbEntradas.Controls.Add(Me.Label8)
        Me.GbEntradas.Controls.Add(Me.dtpFecha)
        Me.GbEntradas.Controls.Add(Me.btnbuscar_producto)
        Me.GbEntradas.Controls.Add(Me.Label7)
        Me.GbEntradas.Controls.Add(Me.cbx_visitante)
        Me.GbEntradas.Controls.Add(Me.cbx_local)
        Me.GbEntradas.Controls.Add(Me.txt_nombre_sede)
        Me.GbEntradas.Controls.Add(Me.btn_agregar)
        Me.GbEntradas.Controls.Add(Me.dtp_hora)
        Me.GbEntradas.Controls.Add(Me.Label6)
        Me.GbEntradas.Controls.Add(Me.txt_stock)
        Me.GbEntradas.Controls.Add(Me.txt_precio)
        Me.GbEntradas.Controls.Add(Me.Label1)
        Me.GbEntradas.Controls.Add(Me.Label5)
        Me.GbEntradas.Controls.Add(Me.Label2)
        Me.GbEntradas.Controls.Add(Me.Label4)
        Me.GbEntradas.Controls.Add(Me.Label3)
        Me.GbEntradas.Controls.Add(Me.ShapeContainer2)
        Me.GbEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GbEntradas.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GbEntradas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GbEntradas.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GbEntradas.Location = New System.Drawing.Point(26, 85)
        Me.GbEntradas.Name = "GbEntradas"
        Me.GbEntradas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GbEntradas.Size = New System.Drawing.Size(416, 379)
        Me.GbEntradas.TabIndex = 13
        Me.GbEntradas.TabStop = False
        Me.GbEntradas.Text = "Insertar Datos"
        '
        'PbNueva_ent
        '
        Me.PbNueva_ent.BackColor = System.Drawing.Color.SeaGreen
        Me.PbNueva_ent.Enabled = False
        Me.PbNueva_ent.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.nuevo
        Me.PbNueva_ent.Location = New System.Drawing.Point(314, 322)
        Me.PbNueva_ent.Name = "PbNueva_ent"
        Me.PbNueva_ent.Size = New System.Drawing.Size(36, 35)
        Me.PbNueva_ent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbNueva_ent.TabIndex = 45
        Me.PbNueva_ent.TabStop = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.SeaGreen
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNuevo.Location = New System.Drawing.Point(310, 316)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(95, 47)
        Me.btnNuevo.TabIndex = 37
        Me.btnNuevo.Text = "           Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Pbeditar_ent
        '
        Me.Pbeditar_ent.BackColor = System.Drawing.Color.SeaGreen
        Me.Pbeditar_ent.Enabled = False
        Me.Pbeditar_ent.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.editar
        Me.Pbeditar_ent.Location = New System.Drawing.Point(212, 322)
        Me.Pbeditar_ent.Name = "Pbeditar_ent"
        Me.Pbeditar_ent.Size = New System.Drawing.Size(34, 34)
        Me.Pbeditar_ent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbeditar_ent.TabIndex = 44
        Me.Pbeditar_ent.TabStop = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_modificar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_modificar.Location = New System.Drawing.Point(211, 316)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(97, 47)
        Me.btn_modificar.TabIndex = 16
        Me.btn_modificar.Text = "         Modificar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'PbEliminar_ent
        '
        Me.PbEliminar_ent.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEliminar_ent.Enabled = False
        Me.PbEliminar_ent.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.eliminar
        Me.PbEliminar_ent.Location = New System.Drawing.Point(112, 322)
        Me.PbEliminar_ent.Name = "PbEliminar_ent"
        Me.PbEliminar_ent.Size = New System.Drawing.Size(36, 35)
        Me.PbEliminar_ent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEliminar_ent.TabIndex = 43
        Me.PbEliminar_ent.TabStop = False
        '
        'pb_agregarEnt
        '
        Me.pb_agregarEnt.BackColor = System.Drawing.Color.SeaGreen
        Me.pb_agregarEnt.Enabled = False
        Me.pb_agregarEnt.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.pb_agregarEnt.Location = New System.Drawing.Point(17, 322)
        Me.pb_agregarEnt.Name = "pb_agregarEnt"
        Me.pb_agregarEnt.Size = New System.Drawing.Size(36, 35)
        Me.pb_agregarEnt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_agregarEnt.TabIndex = 42
        Me.pb_agregarEnt.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Location = New System.Drawing.Point(110, 316)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(95, 47)
        Me.btn_eliminar.TabIndex = 17
        Me.btn_eliminar.Text = "           Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'lblId_sede
        '
        Me.lblId_sede.AutoSize = True
        Me.lblId_sede.ForeColor = System.Drawing.Color.White
        Me.lblId_sede.Location = New System.Drawing.Point(95, 38)
        Me.lblId_sede.Name = "lblId_sede"
        Me.lblId_sede.Size = New System.Drawing.Size(0, 16)
        Me.lblId_sede.TabIndex = 41
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(328, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Traer Sede"
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(241, 228)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(97, 23)
        Me.dtpFecha.TabIndex = 35
        '
        'btnbuscar_producto
        '
        Me.btnbuscar_producto.BackColor = System.Drawing.Color.SeaGreen
        Me.btnbuscar_producto.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_producto.Location = New System.Drawing.Point(345, 38)
        Me.btnbuscar_producto.Name = "btnbuscar_producto"
        Me.btnbuscar_producto.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscar_producto.TabIndex = 34
        Me.btnbuscar_producto.Text = "..."
        Me.btnbuscar_producto.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(28, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Sede:"
        '
        'cbx_visitante
        '
        Me.cbx_visitante.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cbx_visitante.ForeColor = System.Drawing.Color.White
        Me.cbx_visitante.FormattingEnabled = True
        Me.cbx_visitante.Location = New System.Drawing.Point(81, 99)
        Me.cbx_visitante.Name = "cbx_visitante"
        Me.cbx_visitante.Size = New System.Drawing.Size(216, 24)
        Me.cbx_visitante.TabIndex = 19
        '
        'cbx_local
        '
        Me.cbx_local.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cbx_local.ForeColor = System.Drawing.Color.White
        Me.cbx_local.FormattingEnabled = True
        Me.cbx_local.Items.AddRange(New Object() {""})
        Me.cbx_local.Location = New System.Drawing.Point(82, 69)
        Me.cbx_local.Name = "cbx_local"
        Me.cbx_local.Size = New System.Drawing.Size(216, 24)
        Me.cbx_local.TabIndex = 18
        '
        'txt_nombre_sede
        '
        Me.txt_nombre_sede.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_nombre_sede.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre_sede.ForeColor = System.Drawing.Color.White
        Me.txt_nombre_sede.Location = New System.Drawing.Point(147, 39)
        Me.txt_nombre_sede.Name = "txt_nombre_sede"
        Me.txt_nombre_sede.Size = New System.Drawing.Size(175, 16)
        Me.txt_nombre_sede.TabIndex = 21
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Location = New System.Drawing.Point(14, 316)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(95, 47)
        Me.btn_agregar.TabIndex = 15
        Me.btn_agregar.Text = "           Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'dtp_hora
        '
        Me.dtp_hora.CalendarForeColor = System.Drawing.Color.White
        Me.dtp_hora.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_hora.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dtp_hora.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtp_hora.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtp_hora.Location = New System.Drawing.Point(82, 229)
        Me.dtp_hora.Name = "dtp_hora"
        Me.dtp_hora.Size = New System.Drawing.Size(75, 23)
        Me.dtp_hora.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(187, 234)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Fecha:"
        '
        'txt_stock
        '
        Me.txt_stock.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_stock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_stock.ForeColor = System.Drawing.Color.White
        Me.txt_stock.Location = New System.Drawing.Point(241, 257)
        Me.txt_stock.Multiline = True
        Me.txt_stock.Name = "txt_stock"
        Me.txt_stock.Size = New System.Drawing.Size(97, 15)
        Me.txt_stock.TabIndex = 11
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precio.ForeColor = System.Drawing.Color.White
        Me.txt_precio.Location = New System.Drawing.Point(81, 257)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(97, 16)
        Me.txt_precio.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(25, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Local:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(190, 257)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(4, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Visitante:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(11, 257)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Precio $:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(31, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hora:"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LsStock, Me.Lsprecio, Me.LsSeparador, Me.Lsnombre_sede, Me.LsId_sede})
        Me.ShapeContainer2.Size = New System.Drawing.Size(410, 357)
        Me.ShapeContainer2.TabIndex = 38
        Me.ShapeContainer2.TabStop = False
        '
        'LsStock
        '
        Me.LsStock.BorderColor = System.Drawing.Color.White
        Me.LsStock.Name = "LsStock"
        Me.LsStock.X1 = 238
        Me.LsStock.X2 = 336
        Me.LsStock.Y1 = 255
        Me.LsStock.Y2 = 255
        '
        'Lsprecio
        '
        Me.Lsprecio.BorderColor = System.Drawing.Color.White
        Me.Lsprecio.Name = "Lsprecio"
        Me.Lsprecio.X1 = 79
        Me.Lsprecio.X2 = 177
        Me.Lsprecio.Y1 = 254
        Me.Lsprecio.Y2 = 254
        '
        'LsSeparador
        '
        Me.LsSeparador.BorderColor = System.Drawing.Color.White
        Me.LsSeparador.Name = "LsSeparador"
        Me.LsSeparador.X1 = 127
        Me.LsSeparador.X2 = 137
        Me.LsSeparador.Y1 = 28
        Me.LsSeparador.Y2 = 28
        '
        'Lsnombre_sede
        '
        Me.Lsnombre_sede.BorderColor = System.Drawing.Color.White
        Me.Lsnombre_sede.Name = "Lsnombre_sede"
        Me.Lsnombre_sede.X1 = 143
        Me.Lsnombre_sede.X2 = 318
        Me.Lsnombre_sede.Y1 = 39
        Me.Lsnombre_sede.Y2 = 39
        '
        'LsId_sede
        '
        Me.LsId_sede.BorderColor = System.Drawing.Color.White
        Me.LsId_sede.Name = "LsId_sede"
        Me.LsId_sede.X1 = 74
        Me.LsId_sede.X2 = 122
        Me.LsId_sede.Y1 = 39
        Me.LsId_sede.Y2 = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(27, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Nº de Entrada:"
        '
        'ErrorEntradas
        '
        Me.ErrorEntradas.ContainerControl = Me
        '
        'Panel_topEntradas
        '
        Me.Panel_topEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_topEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_topEntradas.Controls.Add(Me.Label10)
        Me.Panel_topEntradas.Controls.Add(Me.btnCerrar_ent)
        Me.Panel_topEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_topEntradas.Location = New System.Drawing.Point(0, 0)
        Me.Panel_topEntradas.Name = "Panel_topEntradas"
        Me.Panel_topEntradas.Size = New System.Drawing.Size(935, 30)
        Me.Panel_topEntradas.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(373, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 15)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "GESTIÓN DE ENTRADAS"
        '
        'btnCerrar_ent
        '
        Me.btnCerrar_ent.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_ent.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_ent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_ent.FlatAppearance.BorderSize = 0
        Me.btnCerrar_ent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_ent.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_ent.Location = New System.Drawing.Point(862, -1)
        Me.btnCerrar_ent.Name = "btnCerrar_ent"
        Me.btnCerrar_ent.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_ent.TabIndex = 24
        Me.btnCerrar_ent.UseVisualStyleBackColor = False
        '
        'lblId_entrada
        '
        Me.lblId_entrada.AutoSize = True
        Me.lblId_entrada.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblId_entrada.ForeColor = System.Drawing.Color.White
        Me.lblId_entrada.Location = New System.Drawing.Point(133, 62)
        Me.lblId_entrada.Name = "lblId_entrada"
        Me.lblId_entrada.Size = New System.Drawing.Size(0, 16)
        Me.lblId_entrada.TabIndex = 40
        '
        'Entradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(935, 553)
        Me.Controls.Add(Me.lblId_entrada)
        Me.Controls.Add(Me.Panel_topEntradas)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_flag)
        Me.Controls.Add(Me.dt_entradas)
        Me.Controls.Add(Me.GbEntradas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Entradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Entradas"
        CType(Me.dt_entradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbEntradas.ResumeLayout(False)
        Me.GbEntradas.PerformLayout()
        CType(Me.PbNueva_ent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbeditar_ent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEliminar_ent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_agregarEnt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_topEntradas.ResumeLayout(False)
        Me.Panel_topEntradas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_flag As System.Windows.Forms.TextBox
    Friend WithEvents dt_entradas As System.Windows.Forms.DataGridView
    Friend WithEvents GbEntradas As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents dtp_hora As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_stock As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_sede As System.Windows.Forms.TextBox
    Friend WithEvents cbx_visitante As System.Windows.Forms.ComboBox
    Friend WithEvents btnbuscar_producto As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents ErrorEntradas As System.Windows.Forms.ErrorProvider
    Friend WithEvents cbx_local As System.Windows.Forms.ComboBox
    Friend WithEvents btnCerrar_ent As System.Windows.Forms.Button
    Friend WithEvents Panel_topEntradas As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblId_entrada As System.Windows.Forms.Label
    Friend WithEvents lblId_sede As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LsSeparador As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Lsnombre_sede As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsId_sede As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsStock As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Lsprecio As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Pbeditar_ent As System.Windows.Forms.PictureBox
    Friend WithEvents PbEliminar_ent As System.Windows.Forms.PictureBox
    Friend WithEvents pb_agregarEnt As System.Windows.Forms.PictureBox
    Friend WithEvents PbNueva_ent As System.Windows.Forms.PictureBox
End Class
