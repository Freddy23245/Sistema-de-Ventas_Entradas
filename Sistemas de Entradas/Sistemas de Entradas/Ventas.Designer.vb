<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.dt_ventas = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Pbnueva_ven = New System.Windows.Forms.PictureBox()
        Me.btnNueva_venta = New System.Windows.Forms.Button()
        Me.PbEditar_ven = New System.Windows.Forms.PictureBox()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.PbEliminar_ven = New System.Windows.Forms.PictureBox()
        Me.PbAgregar_ven = New System.Windows.Forms.PictureBox()
        Me.LblNombre_cli = New System.Windows.Forms.Label()
        Me.LblId_Cliente = New System.Windows.Forms.Label()
        Me.Lbl_idVenta = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_num_comprobamte = New System.Windows.Forms.TextBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btnbuscar_cliente = New System.Windows.Forms.Button()
        Me.cmbTipo_pago = New System.Windows.Forms.ComboBox()
        Me.txtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LsComprobante = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsNombre_cli = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Ls_idCliente = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsId_Venta = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnCerrar_ventas = New System.Windows.Forms.Button()
        Me.Panel_ventas = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dt_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Pbnueva_ven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEditar_ven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEliminar_ven, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbAgregar_ven, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_ventas.SuspendLayout()
        Me.SuspendLayout()
        '
        'dt_ventas
        '
        Me.dt_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_ventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_ventas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dt_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dt_ventas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dt_ventas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_ventas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_ventas.ColumnHeadersHeight = 30
        Me.dt_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dt_ventas.EnableHeadersVisualStyles = False
        Me.dt_ventas.GridColor = System.Drawing.Color.SteelBlue
        Me.dt_ventas.Location = New System.Drawing.Point(462, 82)
        Me.dt_ventas.Name = "dt_ventas"
        Me.dt_ventas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_ventas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dt_ventas.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_ventas.Size = New System.Drawing.Size(433, 274)
        Me.dt_ventas.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Pbnueva_ven)
        Me.GroupBox1.Controls.Add(Me.btnNueva_venta)
        Me.GroupBox1.Controls.Add(Me.PbEditar_ven)
        Me.GroupBox1.Controls.Add(Me.btn_editar)
        Me.GroupBox1.Controls.Add(Me.PbEliminar_ven)
        Me.GroupBox1.Controls.Add(Me.PbAgregar_ven)
        Me.GroupBox1.Controls.Add(Me.LblNombre_cli)
        Me.GroupBox1.Controls.Add(Me.LblId_Cliente)
        Me.GroupBox1.Controls.Add(Me.Lbl_idVenta)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_num_comprobamte)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_agregar)
        Me.GroupBox1.Controls.Add(Me.btnbuscar_cliente)
        Me.GroupBox1.Controls.Add(Me.cmbTipo_pago)
        Me.GroupBox1.Controls.Add(Me.txtfecha)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(12, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 284)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Venta"
        '
        'Pbnueva_ven
        '
        Me.Pbnueva_ven.BackColor = System.Drawing.Color.SeaGreen
        Me.Pbnueva_ven.Enabled = False
        Me.Pbnueva_ven.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.nuevo
        Me.Pbnueva_ven.Location = New System.Drawing.Point(341, 229)
        Me.Pbnueva_ven.Name = "Pbnueva_ven"
        Me.Pbnueva_ven.Size = New System.Drawing.Size(36, 35)
        Me.Pbnueva_ven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbnueva_ven.TabIndex = 34
        Me.Pbnueva_ven.TabStop = False
        '
        'btnNueva_venta
        '
        Me.btnNueva_venta.BackColor = System.Drawing.Color.SeaGreen
        Me.btnNueva_venta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNueva_venta.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnNueva_venta.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNueva_venta.Location = New System.Drawing.Point(336, 226)
        Me.btnNueva_venta.Name = "btnNueva_venta"
        Me.btnNueva_venta.Size = New System.Drawing.Size(100, 43)
        Me.btnNueva_venta.TabIndex = 27
        Me.btnNueva_venta.Text = "          Nueva " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         Venta"
        Me.btnNueva_venta.UseVisualStyleBackColor = False
        '
        'PbEditar_ven
        '
        Me.PbEditar_ven.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEditar_ven.Enabled = False
        Me.PbEditar_ven.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.editar
        Me.PbEditar_ven.Location = New System.Drawing.Point(238, 230)
        Me.PbEditar_ven.Name = "PbEditar_ven"
        Me.PbEditar_ven.Size = New System.Drawing.Size(36, 35)
        Me.PbEditar_ven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEditar_ven.TabIndex = 33
        Me.PbEditar_ven.TabStop = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_editar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_editar.Location = New System.Drawing.Point(231, 226)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(99, 43)
        Me.btn_editar.TabIndex = 22
        Me.btn_editar.Text = "                Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'PbEliminar_ven
        '
        Me.PbEliminar_ven.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEliminar_ven.Enabled = False
        Me.PbEliminar_ven.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.eliminar
        Me.PbEliminar_ven.Location = New System.Drawing.Point(133, 229)
        Me.PbEliminar_ven.Name = "PbEliminar_ven"
        Me.PbEliminar_ven.Size = New System.Drawing.Size(36, 35)
        Me.PbEliminar_ven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEliminar_ven.TabIndex = 32
        Me.PbEliminar_ven.TabStop = False
        '
        'PbAgregar_ven
        '
        Me.PbAgregar_ven.BackColor = System.Drawing.Color.SeaGreen
        Me.PbAgregar_ven.Enabled = False
        Me.PbAgregar_ven.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.PbAgregar_ven.Location = New System.Drawing.Point(26, 229)
        Me.PbAgregar_ven.Name = "PbAgregar_ven"
        Me.PbAgregar_ven.Size = New System.Drawing.Size(36, 35)
        Me.PbAgregar_ven.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbAgregar_ven.TabIndex = 31
        Me.PbAgregar_ven.TabStop = False
        '
        'LblNombre_cli
        '
        Me.LblNombre_cli.AutoSize = True
        Me.LblNombre_cli.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre_cli.ForeColor = System.Drawing.Color.White
        Me.LblNombre_cli.Location = New System.Drawing.Point(209, 67)
        Me.LblNombre_cli.Name = "LblNombre_cli"
        Me.LblNombre_cli.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblNombre_cli.Size = New System.Drawing.Size(0, 15)
        Me.LblNombre_cli.TabIndex = 29
        '
        'LblId_Cliente
        '
        Me.LblId_Cliente.AutoSize = True
        Me.LblId_Cliente.BackColor = System.Drawing.Color.Transparent
        Me.LblId_Cliente.ForeColor = System.Drawing.Color.White
        Me.LblId_Cliente.Location = New System.Drawing.Point(136, 67)
        Me.LblId_Cliente.Name = "LblId_Cliente"
        Me.LblId_Cliente.Size = New System.Drawing.Size(0, 15)
        Me.LblId_Cliente.TabIndex = 29
        '
        'Lbl_idVenta
        '
        Me.Lbl_idVenta.AutoSize = True
        Me.Lbl_idVenta.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_idVenta.ForeColor = System.Drawing.Color.White
        Me.Lbl_idVenta.Location = New System.Drawing.Point(146, 37)
        Me.Lbl_idVenta.Name = "Lbl_idVenta"
        Me.Lbl_idVenta.Size = New System.Drawing.Size(0, 15)
        Me.Lbl_idVenta.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(299, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 32)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "         Traer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "        Cliente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(4, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "N° de Comprobante:"
        '
        'txt_num_comprobamte
        '
        Me.txt_num_comprobamte.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_num_comprobamte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_num_comprobamte.Enabled = False
        Me.txt_num_comprobamte.ForeColor = System.Drawing.Color.White
        Me.txt_num_comprobamte.Location = New System.Drawing.Point(147, 156)
        Me.txt_num_comprobamte.Name = "txt_num_comprobamte"
        Me.txt_num_comprobamte.Size = New System.Drawing.Size(206, 14)
        Me.txt_num_comprobamte.TabIndex = 25
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Location = New System.Drawing.Point(129, 226)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(100, 43)
        Me.btn_eliminar.TabIndex = 24
        Me.btn_eliminar.Text = "           Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Location = New System.Drawing.Point(17, 226)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(105, 43)
        Me.btn_agregar.TabIndex = 23
        Me.btn_agregar.Text = "              Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'btnbuscar_cliente
        '
        Me.btnbuscar_cliente.BackColor = System.Drawing.Color.SeaGreen
        Me.btnbuscar_cliente.ForeColor = System.Drawing.Color.White
        Me.btnbuscar_cliente.Location = New System.Drawing.Point(337, 64)
        Me.btnbuscar_cliente.Name = "btnbuscar_cliente"
        Me.btnbuscar_cliente.Size = New System.Drawing.Size(40, 25)
        Me.btnbuscar_cliente.TabIndex = 21
        Me.btnbuscar_cliente.Text = "..."
        Me.btnbuscar_cliente.UseVisualStyleBackColor = False
        '
        'cmbTipo_pago
        '
        Me.cmbTipo_pago.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cmbTipo_pago.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbTipo_pago.ForeColor = System.Drawing.Color.White
        Me.cmbTipo_pago.FormattingEnabled = True
        Me.cmbTipo_pago.Location = New System.Drawing.Point(147, 129)
        Me.cmbTipo_pago.Name = "cmbTipo_pago"
        Me.cmbTipo_pago.Size = New System.Drawing.Size(127, 24)
        Me.cmbTipo_pago.TabIndex = 20
        '
        'txtfecha
        '
        Me.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtfecha.Location = New System.Drawing.Point(149, 98)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(100, 21)
        Me.txtfecha.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(43, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo De Pago:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(91, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(64, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cliente:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(55, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "N° de Venta:"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LsComprobante, Me.LsNombre_cli, Me.Ls_idCliente, Me.LsId_Venta})
        Me.ShapeContainer2.Size = New System.Drawing.Size(433, 264)
        Me.ShapeContainer2.TabIndex = 30
        Me.ShapeContainer2.TabStop = False
        '
        'LsComprobante
        '
        Me.LsComprobante.BorderColor = System.Drawing.Color.White
        Me.LsComprobante.Name = "LsComprobante"
        Me.LsComprobante.X1 = 143
        Me.LsComprobante.X2 = 349
        Me.LsComprobante.Y1 = 158
        Me.LsComprobante.Y2 = 158
        '
        'LsNombre_cli
        '
        Me.LsNombre_cli.BorderColor = System.Drawing.Color.White
        Me.LsNombre_cli.Name = "LsNombre_cli"
        Me.LsNombre_cli.X1 = 209
        Me.LsNombre_cli.X2 = 311
        Me.LsNombre_cli.Y1 = 67
        Me.LsNombre_cli.Y2 = 67
        '
        'Ls_idCliente
        '
        Me.Ls_idCliente.BorderColor = System.Drawing.Color.White
        Me.Ls_idCliente.Name = "Ls_idCliente"
        Me.Ls_idCliente.X1 = 144
        Me.Ls_idCliente.X2 = 191
        Me.Ls_idCliente.Y1 = 67
        Me.Ls_idCliente.Y2 = 67
        '
        'LsId_Venta
        '
        Me.LsId_Venta.BorderColor = System.Drawing.Color.White
        Me.LsId_Venta.Name = "LsId_Venta"
        Me.LsId_Venta.X1 = 146
        Me.LsId_Venta.X2 = 225
        Me.LsId_Venta.Y1 = 37
        Me.LsId_Venta.Y2 = 37
        '
        'btnCerrar_ventas
        '
        Me.btnCerrar_ventas.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_ventas.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_ventas.FlatAppearance.BorderSize = 0
        Me.btnCerrar_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_ventas.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_ventas.Location = New System.Drawing.Point(875, 0)
        Me.btnCerrar_ventas.Name = "btnCerrar_ventas"
        Me.btnCerrar_ventas.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_ventas.TabIndex = 27
        Me.btnCerrar_ventas.UseVisualStyleBackColor = False
        '
        'Panel_ventas
        '
        Me.Panel_ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_ventas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_ventas.Controls.Add(Me.Label7)
        Me.Panel_ventas.Controls.Add(Me.btnCerrar_ventas)
        Me.Panel_ventas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_ventas.Location = New System.Drawing.Point(0, 0)
        Me.Panel_ventas.Name = "Panel_ventas"
        Me.Panel_ventas.Size = New System.Drawing.Size(907, 30)
        Me.Panel_ventas.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(385, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "GESTIÓN DE VENTAS"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(907, 429)
        Me.Controls.Add(Me.Panel_ventas)
        Me.Controls.Add(Me.dt_ventas)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        CType(Me.dt_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Pbnueva_ven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEditar_ven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEliminar_ven, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbAgregar_ven, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_ventas.ResumeLayout(False)
        Me.Panel_ventas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt_ventas As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btnbuscar_cliente As System.Windows.Forms.Button
    Friend WithEvents cmbTipo_pago As System.Windows.Forms.ComboBox
    Friend WithEvents txtfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_num_comprobamte As System.Windows.Forms.TextBox
    Friend WithEvents btnNueva_venta As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar_ventas As System.Windows.Forms.Button
    Friend WithEvents Panel_ventas As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Lbl_idVenta As System.Windows.Forms.Label
    Friend WithEvents LblId_Cliente As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LsId_Venta As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Ls_idCliente As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LblNombre_cli As System.Windows.Forms.Label
    Friend WithEvents LsComprobante As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsNombre_cli As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PbAgregar_ven As System.Windows.Forms.PictureBox
    Friend WithEvents PbEliminar_ven As System.Windows.Forms.PictureBox
    Friend WithEvents Pbnueva_ven As System.Windows.Forms.PictureBox
    Friend WithEvents PbEditar_ven As System.Windows.Forms.PictureBox
End Class
