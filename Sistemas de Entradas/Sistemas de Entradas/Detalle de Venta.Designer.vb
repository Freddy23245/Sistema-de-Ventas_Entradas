<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle_de_Venta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalle_de_Venta))
        Me.btn_generar_comporbante = New System.Windows.Forms.Button()
        Me.dt_detalle_venta = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PbNuevo_det = New System.Windows.Forms.PictureBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.pbEliminar_det = New System.Windows.Forms.PictureBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.pbAgregar_det = New System.Windows.Forms.PictureBox()
        Me.lbl_nombreEntrada = New System.Windows.Forms.Label()
        Me.lbl_Id_Entrada = New System.Windows.Forms.Label()
        Me.txt_id_cliente = New System.Windows.Forms.TextBox()
        Me.lblId_venta = New System.Windows.Forms.Label()
        Me.LblConsultar_entrada = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_num_comprobamte = New System.Windows.Forms.TextBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txtstock = New System.Windows.Forms.NumericUpDown()
        Me.txtcantidad = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnbuscar_producto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbx_tipo_pago = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsNombre_Entrada = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lsId_entrada = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ls_comprobante = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lsNombre_Cliente = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lsId_Cliente = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.lsId_Venta = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel_det_ven = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCerrar_det_ven = New System.Windows.Forms.Button()
        Me.lblId_detalle_venta = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dt_detalle_venta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PbNuevo_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEliminar_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAgregar_det, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_det_ven.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_generar_comporbante
        '
        Me.btn_generar_comporbante.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_generar_comporbante.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_generar_comporbante.Font = New System.Drawing.Font("Candara", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generar_comporbante.ForeColor = System.Drawing.Color.Transparent
        Me.btn_generar_comporbante.Location = New System.Drawing.Point(639, 447)
        Me.btn_generar_comporbante.Name = "btn_generar_comporbante"
        Me.btn_generar_comporbante.Size = New System.Drawing.Size(574, 45)
        Me.btn_generar_comporbante.TabIndex = 8
        Me.btn_generar_comporbante.Text = "Generar Comprobante"
        Me.btn_generar_comporbante.UseVisualStyleBackColor = False
        '
        'dt_detalle_venta
        '
        Me.dt_detalle_venta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_detalle_venta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_detalle_venta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dt_detalle_venta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dt_detalle_venta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dt_detalle_venta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_detalle_venta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_detalle_venta.ColumnHeadersHeight = 30
        Me.dt_detalle_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dt_detalle_venta.EnableHeadersVisualStyles = False
        Me.dt_detalle_venta.GridColor = System.Drawing.Color.SteelBlue
        Me.dt_detalle_venta.Location = New System.Drawing.Point(639, 104)
        Me.dt_detalle_venta.Name = "dt_detalle_venta"
        Me.dt_detalle_venta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_detalle_venta.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dt_detalle_venta.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_detalle_venta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_detalle_venta.Size = New System.Drawing.Size(575, 337)
        Me.dt_detalle_venta.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.PbNuevo_det)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.pbEliminar_det)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.pbAgregar_det)
        Me.GroupBox1.Controls.Add(Me.lbl_nombreEntrada)
        Me.GroupBox1.Controls.Add(Me.lbl_Id_Entrada)
        Me.GroupBox1.Controls.Add(Me.txt_id_cliente)
        Me.GroupBox1.Controls.Add(Me.lblId_venta)
        Me.GroupBox1.Controls.Add(Me.LblConsultar_entrada)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_precio)
        Me.GroupBox1.Controls.Add(Me.txt_num_comprobamte)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.txtstock)
        Me.GroupBox1.Controls.Add(Me.txtcantidad)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_producto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cbx_tipo_pago)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.txt_nombre_cliente)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(15, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(595, 383)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Insertar Productos:"
        '
        'PbNuevo_det
        '
        Me.PbNuevo_det.BackColor = System.Drawing.Color.SeaGreen
        Me.PbNuevo_det.Enabled = False
        Me.PbNuevo_det.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.nuevo
        Me.PbNuevo_det.Location = New System.Drawing.Point(355, 329)
        Me.PbNuevo_det.Name = "PbNuevo_det"
        Me.PbNuevo_det.Size = New System.Drawing.Size(36, 35)
        Me.PbNuevo_det.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbNuevo_det.TabIndex = 49
        Me.PbNuevo_det.TabStop = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_nuevo.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_nuevo.Location = New System.Drawing.Point(344, 322)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(106, 48)
        Me.btn_nuevo.TabIndex = 38
        Me.btn_nuevo.Text = "            Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'pbEliminar_det
        '
        Me.pbEliminar_det.BackColor = System.Drawing.Color.SeaGreen
        Me.pbEliminar_det.Enabled = False
        Me.pbEliminar_det.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.eliminar
        Me.pbEliminar_det.Location = New System.Drawing.Point(238, 329)
        Me.pbEliminar_det.Name = "pbEliminar_det"
        Me.pbEliminar_det.Size = New System.Drawing.Size(36, 35)
        Me.pbEliminar_det.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEliminar_det.TabIndex = 48
        Me.pbEliminar_det.TabStop = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Location = New System.Drawing.Point(232, 322)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(106, 48)
        Me.btn_eliminar.TabIndex = 40
        Me.btn_eliminar.Text = "            Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'pbAgregar_det
        '
        Me.pbAgregar_det.BackColor = System.Drawing.Color.SeaGreen
        Me.pbAgregar_det.Enabled = False
        Me.pbAgregar_det.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.pbAgregar_det.Location = New System.Drawing.Point(125, 329)
        Me.pbAgregar_det.Name = "pbAgregar_det"
        Me.pbAgregar_det.Size = New System.Drawing.Size(36, 35)
        Me.pbAgregar_det.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAgregar_det.TabIndex = 47
        Me.pbAgregar_det.TabStop = False
        '
        'lbl_nombreEntrada
        '
        Me.lbl_nombreEntrada.AutoSize = True
        Me.lbl_nombreEntrada.ForeColor = System.Drawing.Color.White
        Me.lbl_nombreEntrada.Location = New System.Drawing.Point(203, 214)
        Me.lbl_nombreEntrada.Name = "lbl_nombreEntrada"
        Me.lbl_nombreEntrada.Size = New System.Drawing.Size(0, 16)
        Me.lbl_nombreEntrada.TabIndex = 31
        '
        'lbl_Id_Entrada
        '
        Me.lbl_Id_Entrada.AutoSize = True
        Me.lbl_Id_Entrada.ForeColor = System.Drawing.Color.White
        Me.lbl_Id_Entrada.Location = New System.Drawing.Point(149, 216)
        Me.lbl_Id_Entrada.Name = "lbl_Id_Entrada"
        Me.lbl_Id_Entrada.Size = New System.Drawing.Size(0, 16)
        Me.lbl_Id_Entrada.TabIndex = 31
        '
        'txt_id_cliente
        '
        Me.txt_id_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_id_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_id_cliente.Enabled = False
        Me.txt_id_cliente.Location = New System.Drawing.Point(148, 58)
        Me.txt_id_cliente.Name = "txt_id_cliente"
        Me.txt_id_cliente.Size = New System.Drawing.Size(48, 16)
        Me.txt_id_cliente.TabIndex = 22
        '
        'lblId_venta
        '
        Me.lblId_venta.AutoSize = True
        Me.lblId_venta.ForeColor = System.Drawing.Color.White
        Me.lblId_venta.Location = New System.Drawing.Point(148, 29)
        Me.lblId_venta.Name = "lblId_venta"
        Me.lblId_venta.Size = New System.Drawing.Size(0, 16)
        Me.lblId_venta.TabIndex = 29
        '
        'LblConsultar_entrada
        '
        Me.LblConsultar_entrada.AutoSize = True
        Me.LblConsultar_entrada.BackColor = System.Drawing.Color.Transparent
        Me.LblConsultar_entrada.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblConsultar_entrada.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblConsultar_entrada.Location = New System.Drawing.Point(522, 178)
        Me.LblConsultar_entrada.Name = "LblConsultar_entrada"
        Me.LblConsultar_entrada.Size = New System.Drawing.Size(67, 32)
        Me.LblConsultar_entrada.TabIndex = 45
        Me.LblConsultar_entrada.Text = "    Traer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  Entrada"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(32, 290)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 16)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Precio Unitario: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(3, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Nº de Comprobante:"
        '
        'txt_precio
        '
        Me.txt_precio.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_precio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_precio.ForeColor = System.Drawing.Color.White
        Me.txt_precio.Location = New System.Drawing.Point(149, 290)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(100, 16)
        Me.txt_precio.TabIndex = 42
        '
        'txt_num_comprobamte
        '
        Me.txt_num_comprobamte.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_num_comprobamte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_num_comprobamte.Enabled = False
        Me.txt_num_comprobamte.Location = New System.Drawing.Point(146, 178)
        Me.txt_num_comprobamte.Name = "txt_num_comprobamte"
        Me.txt_num_comprobamte.Size = New System.Drawing.Size(130, 16)
        Me.txt_num_comprobamte.TabIndex = 41
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Location = New System.Drawing.Point(119, 322)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(107, 49)
        Me.btn_agregar.TabIndex = 39
        Me.btn_agregar.Text = "          Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstock.Enabled = False
        Me.txtstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.ForeColor = System.Drawing.Color.White
        Me.txtstock.Location = New System.Drawing.Point(272, 255)
        Me.txtstock.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtstock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(66, 20)
        Me.txtstock.TabIndex = 37
        Me.txtstock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtcantidad
        '
        Me.txtcantidad.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidad.ForeColor = System.Drawing.Color.White
        Me.txtcantidad.Location = New System.Drawing.Point(146, 255)
        Me.txtcantidad.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(57, 20)
        Me.txtcantidad.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(216, 260)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Stock: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(71, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Cantidad: "
        '
        'btnbuscar_producto
        '
        Me.btnbuscar_producto.BackColor = System.Drawing.Color.SeaGreen
        Me.btnbuscar_producto.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_producto.Location = New System.Drawing.Point(535, 214)
        Me.btnbuscar_producto.Name = "btnbuscar_producto"
        Me.btnbuscar_producto.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscar_producto.TabIndex = 33
        Me.btnbuscar_producto.Text = "..."
        Me.btnbuscar_producto.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(36, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "N° de Entrada: "
        '
        'cbx_tipo_pago
        '
        Me.cbx_tipo_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cbx_tipo_pago.Enabled = False
        Me.cbx_tipo_pago.ForeColor = System.Drawing.Color.White
        Me.cbx_tipo_pago.FormattingEnabled = True
        Me.cbx_tipo_pago.Location = New System.Drawing.Point(146, 134)
        Me.cbx_tipo_pago.Name = "cbx_tipo_pago"
        Me.cbx_tipo_pago.Size = New System.Drawing.Size(121, 24)
        Me.cbx_tipo_pago.TabIndex = 28
        '
        'txtfecha
        '
        Me.txtfecha.Enabled = False
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(146, 95)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(103, 23)
        Me.txtfecha.TabIndex = 27
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_nombre_cliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre_cliente.Enabled = False
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(202, 58)
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(138, 16)
        Me.txt_nombre_cliente.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(44, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Tipo de Pago:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(90, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(87, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Cliente: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(55, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "N° de Venta:"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 19)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LsNombre_Entrada, Me.lsId_entrada, Me.ls_comprobante, Me.lsNombre_Cliente, Me.lsId_Cliente, Me.lsId_Venta})
        Me.ShapeContainer2.Size = New System.Drawing.Size(589, 361)
        Me.ShapeContainer2.TabIndex = 46
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 146
        Me.LineShape2.X2 = 246
        Me.LineShape2.Y1 = 292
        Me.LineShape2.Y2 = 292
        '
        'LsNombre_Entrada
        '
        Me.LsNombre_Entrada.BorderColor = System.Drawing.Color.White
        Me.LsNombre_Entrada.Name = "LsNombre_Entrada"
        Me.LsNombre_Entrada.X1 = 200
        Me.LsNombre_Entrada.X2 = 524
        Me.LsNombre_Entrada.Y1 = 216
        Me.LsNombre_Entrada.Y2 = 216
        '
        'lsId_entrada
        '
        Me.lsId_entrada.BorderColor = System.Drawing.Color.White
        Me.lsId_entrada.Name = "lsId_entrada"
        Me.lsId_entrada.X1 = 145
        Me.lsId_entrada.X2 = 189
        Me.lsId_entrada.Y1 = 216
        Me.lsId_entrada.Y2 = 216
        '
        'ls_comprobante
        '
        Me.ls_comprobante.BorderColor = System.Drawing.Color.White
        Me.ls_comprobante.Name = "ls_comprobante"
        Me.ls_comprobante.X1 = 143
        Me.ls_comprobante.X2 = 272
        Me.ls_comprobante.Y1 = 180
        Me.ls_comprobante.Y2 = 180
        '
        'lsNombre_Cliente
        '
        Me.lsNombre_Cliente.BorderColor = System.Drawing.Color.White
        Me.lsNombre_Cliente.Name = "lsNombre_Cliente"
        Me.lsNombre_Cliente.X1 = 199
        Me.lsNombre_Cliente.X2 = 340
        Me.lsNombre_Cliente.Y1 = 60
        Me.lsNombre_Cliente.Y2 = 60
        '
        'lsId_Cliente
        '
        Me.lsId_Cliente.BorderColor = System.Drawing.Color.White
        Me.lsId_Cliente.Name = "lsId_Cliente"
        Me.lsId_Cliente.X1 = 145
        Me.lsId_Cliente.X2 = 191
        Me.lsId_Cliente.Y1 = 60
        Me.lsId_Cliente.Y2 = 60
        '
        'lsId_Venta
        '
        Me.lsId_Venta.BorderColor = System.Drawing.Color.White
        Me.lsId_Venta.Name = "lsId_Venta"
        Me.lsId_Venta.X1 = 145
        Me.lsId_Venta.X2 = 184
        Me.lsId_Venta.Y1 = 28
        Me.lsId_Venta.Y2 = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label10.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label10.Location = New System.Drawing.Point(636, 73)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 16)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nº Detalle de Venta:"
        '
        'Panel_det_ven
        '
        Me.Panel_det_ven.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_det_ven.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_det_ven.Controls.Add(Me.Label12)
        Me.Panel_det_ven.Controls.Add(Me.btnCerrar_det_ven)
        Me.Panel_det_ven.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_det_ven.Location = New System.Drawing.Point(0, 0)
        Me.Panel_det_ven.Name = "Panel_det_ven"
        Me.Panel_det_ven.Size = New System.Drawing.Size(1267, 32)
        Me.Panel_det_ven.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(510, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 15)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "DETALLE DE VENTAS"
        '
        'btnCerrar_det_ven
        '
        Me.btnCerrar_det_ven.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_det_ven.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_det_ven.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_det_ven.FlatAppearance.BorderSize = 0
        Me.btnCerrar_det_ven.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_det_ven.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_det_ven.Location = New System.Drawing.Point(1228, 0)
        Me.btnCerrar_det_ven.Name = "btnCerrar_det_ven"
        Me.btnCerrar_det_ven.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_det_ven.TabIndex = 27
        Me.btnCerrar_det_ven.UseVisualStyleBackColor = False
        '
        'lblId_detalle_venta
        '
        Me.lblId_detalle_venta.AutoSize = True
        Me.lblId_detalle_venta.ForeColor = System.Drawing.Color.White
        Me.lblId_detalle_venta.Location = New System.Drawing.Point(768, 76)
        Me.lblId_detalle_venta.Name = "lblId_detalle_venta"
        Me.lblId_detalle_venta.Size = New System.Drawing.Size(0, 13)
        Me.lblId_detalle_venta.TabIndex = 29
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 769
        Me.LineShape1.X2 = 818
        Me.LineShape1.Y1 = 94
        Me.LineShape1.Y2 = 94
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1267, 551)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SeaGreen
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.comprobante
        Me.PictureBox1.Location = New System.Drawing.Point(815, 451)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(36, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Detalle_de_Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1267, 551)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblId_detalle_venta)
        Me.Controls.Add(Me.Panel_det_ven)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btn_generar_comporbante)
        Me.Controls.Add(Me.dt_detalle_venta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Detalle_de_Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Venta"
        CType(Me.dt_detalle_venta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PbNuevo_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEliminar_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAgregar_det, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_det_ven.ResumeLayout(False)
        Me.Panel_det_ven.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_generar_comporbante As System.Windows.Forms.Button
    Friend WithEvents dt_detalle_venta As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents txtstock As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtcantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnbuscar_producto As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbx_tipo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_id_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_num_comprobamte As System.Windows.Forms.TextBox
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LblConsultar_entrada As System.Windows.Forms.Label
    Friend WithEvents btnCerrar_det_ven As System.Windows.Forms.Button
    Friend WithEvents Panel_det_ven As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblId_venta As System.Windows.Forms.Label
    Friend WithEvents lblId_detalle_venta As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lsId_Venta As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents lsNombre_Cliente As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lsId_Cliente As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_Id_Entrada As System.Windows.Forms.Label
    Friend WithEvents ls_comprobante As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lbl_nombreEntrada As System.Windows.Forms.Label
    Friend WithEvents LsNombre_Entrada As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents lsId_entrada As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents pbAgregar_det As System.Windows.Forms.PictureBox
    Friend WithEvents pbEliminar_det As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PbNuevo_det As System.Windows.Forms.PictureBox
End Class
