<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.txt_flag = New System.Windows.Forms.TextBox()
        Me.dt_clientes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_dni = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LpNombre = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_editar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCodCli = New System.Windows.Forms.Label()
        Me.txtBuscar_cli = New System.Windows.Forms.TextBox()
        Me.cmbBuscar = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ErrorClientes = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel_cli = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCerrar_cli = New System.Windows.Forms.Button()
        Me.LineShape5 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LblContador_Clientes = New System.Windows.Forms.Label()
        Me.LblReg_cli = New System.Windows.Forms.Label()
        Me.PbEliminar_cli = New System.Windows.Forms.PictureBox()
        Me.PbLimpiar_cli = New System.Windows.Forms.PictureBox()
        Me.PbGuardar_cli = New System.Windows.Forms.PictureBox()
        Me.PbEditar_cli = New System.Windows.Forms.PictureBox()
        Me.LblFila_eliminar = New System.Windows.Forms.Label()
        CType(Me.dt_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_cli.SuspendLayout()
        CType(Me.PbEliminar_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLimpiar_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbGuardar_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEditar_cli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_flag
        '
        Me.txt_flag.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_flag.Location = New System.Drawing.Point(859, 52)
        Me.txt_flag.Name = "txt_flag"
        Me.txt_flag.Size = New System.Drawing.Size(43, 13)
        Me.txt_flag.TabIndex = 14
        Me.txt_flag.Text = "0"
        '
        'dt_clientes
        '
        Me.dt_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_clientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dt_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dt_clientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dt_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_clientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dt_clientes.ColumnHeadersHeight = 30
        Me.dt_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dt_clientes.EnableHeadersVisualStyles = False
        Me.dt_clientes.GridColor = System.Drawing.Color.SteelBlue
        Me.dt_clientes.Location = New System.Drawing.Point(495, 75)
        Me.dt_clientes.Name = "dt_clientes"
        Me.dt_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_clientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        Me.dt_clientes.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dt_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_clientes.Size = New System.Drawing.Size(407, 241)
        Me.dt_clientes.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.txt_mail)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_dni)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(15, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 241)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingrese Datos"
        '
        'txt_mail
        '
        Me.txt_mail.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_mail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_mail.ForeColor = System.Drawing.Color.White
        Me.txt_mail.Location = New System.Drawing.Point(80, 180)
        Me.txt_mail.Multiline = True
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(254, 16)
        Me.txt_mail.TabIndex = 5
        '
        'txt_telefono
        '
        Me.txt_telefono.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_telefono.ForeColor = System.Drawing.Color.White
        Me.txt_telefono.Location = New System.Drawing.Point(80, 142)
        Me.txt_telefono.MaxLength = 10
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(189, 14)
        Me.txt_telefono.TabIndex = 4
        '
        'txt_dni
        '
        Me.txt_dni.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_dni.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_dni.ForeColor = System.Drawing.Color.White
        Me.txt_dni.Location = New System.Drawing.Point(80, 107)
        Me.txt_dni.MaxLength = 8
        Me.txt_dni.Name = "txt_dni"
        Me.txt_dni.Size = New System.Drawing.Size(142, 14)
        Me.txt_dni.TabIndex = 3
        '
        'txt_apellido
        '
        Me.txt_apellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_apellido.ForeColor = System.Drawing.Color.White
        Me.txt_apellido.Location = New System.Drawing.Point(80, 72)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(189, 14)
        Me.txt_apellido.TabIndex = 2
        '
        'txt_nombre
        '
        Me.txt_nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txt_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_nombre.ForeColor = System.Drawing.Color.White
        Me.txt_nombre.Location = New System.Drawing.Point(79, 40)
        Me.txt_nombre.Multiline = True
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(189, 16)
        Me.txt_nombre.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(35, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Mail:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(10, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(41, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dni:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(10, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(14, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre:"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1, Me.LpNombre})
        Me.ShapeContainer2.Size = New System.Drawing.Size(358, 221)
        Me.ShapeContainer2.TabIndex = 13
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape4
        '
        Me.LineShape4.BorderColor = System.Drawing.Color.White
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 73
        Me.LineShape4.X2 = 329
        Me.LineShape4.Y1 = 184
        Me.LineShape4.Y2 = 184
        '
        'LineShape3
        '
        Me.LineShape3.BorderColor = System.Drawing.Color.White
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 75
        Me.LineShape3.X2 = 263
        Me.LineShape3.Y1 = 144
        Me.LineShape3.Y2 = 144
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 76
        Me.LineShape2.X2 = 226
        Me.LineShape2.Y1 = 107
        Me.LineShape2.Y2 = 107
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 77
        Me.LineShape1.X2 = 265
        Me.LineShape1.Y1 = 74
        Me.LineShape1.Y2 = 74
        '
        'LpNombre
        '
        Me.LpNombre.BorderColor = System.Drawing.Color.White
        Me.LpNombre.Name = "LpNombre"
        Me.LpNombre.X1 = 76
        Me.LpNombre.X2 = 264
        Me.LpNombre.Y1 = 43
        Me.LpNombre.Y2 = 43
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLimpiar.Location = New System.Drawing.Point(385, 239)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(104, 38)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "          Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_eliminar.Location = New System.Drawing.Point(385, 192)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(104, 39)
        Me.btn_eliminar.TabIndex = 8
        Me.btn_eliminar.Text = "          Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_editar
        '
        Me.btn_editar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_editar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_editar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_editar.Location = New System.Drawing.Point(385, 149)
        Me.btn_editar.Name = "btn_editar"
        Me.btn_editar.Size = New System.Drawing.Size(104, 39)
        Me.btn_editar.TabIndex = 7
        Me.btn_editar.Text = "       Editar"
        Me.btn_editar.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_agregar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_agregar.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_agregar.Location = New System.Drawing.Point(385, 104)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(104, 39)
        Me.btn_agregar.TabIndex = 6
        Me.btn_agregar.Text = "           Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(12, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Código Único del Cliente:"
        '
        'lblCodCli
        '
        Me.lblCodCli.AutoSize = True
        Me.lblCodCli.BackColor = System.Drawing.Color.Transparent
        Me.lblCodCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodCli.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblCodCli.Location = New System.Drawing.Point(193, 57)
        Me.lblCodCli.Name = "lblCodCli"
        Me.lblCodCli.Size = New System.Drawing.Size(0, 13)
        Me.lblCodCli.TabIndex = 15
        '
        'txtBuscar_cli
        '
        Me.txtBuscar_cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtBuscar_cli.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscar_cli.ForeColor = System.Drawing.Color.White
        Me.txtBuscar_cli.Location = New System.Drawing.Point(784, 327)
        Me.txtBuscar_cli.Multiline = True
        Me.txtBuscar_cli.Name = "txtBuscar_cli"
        Me.txtBuscar_cli.Size = New System.Drawing.Size(118, 16)
        Me.txtBuscar_cli.TabIndex = 11
        '
        'cmbBuscar
        '
        Me.cmbBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cmbBuscar.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbBuscar.ForeColor = System.Drawing.Color.White
        Me.cmbBuscar.FormattingEnabled = True
        Me.cmbBuscar.Items.AddRange(New Object() {"nombre", "dni", "apellido"})
        Me.cmbBuscar.Location = New System.Drawing.Point(628, 322)
        Me.cmbBuscar.Name = "cmbBuscar"
        Me.cmbBuscar.Size = New System.Drawing.Size(150, 24)
        Me.cmbBuscar.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(496, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Buscar Cliente por:"
        '
        'ErrorClientes
        '
        Me.ErrorClientes.ContainerControl = Me
        '
        'Panel_cli
        '
        Me.Panel_cli.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_cli.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_cli.Controls.Add(Me.Label8)
        Me.Panel_cli.Controls.Add(Me.btnCerrar_cli)
        Me.Panel_cli.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_cli.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel_cli.Location = New System.Drawing.Point(0, 0)
        Me.Panel_cli.Name = "Panel_cli"
        Me.Panel_cli.Size = New System.Drawing.Size(948, 29)
        Me.Panel_cli.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(369, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(158, 15)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "REGISTRO DE CLIENTES"
        '
        'btnCerrar_cli
        '
        Me.btnCerrar_cli.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_cli.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_cli.FlatAppearance.BorderSize = 0
        Me.btnCerrar_cli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_cli.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_cli.Location = New System.Drawing.Point(875, 0)
        Me.btnCerrar_cli.Name = "btnCerrar_cli"
        Me.btnCerrar_cli.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_cli.TabIndex = 22
        Me.btnCerrar_cli.UseVisualStyleBackColor = False
        '
        'LineShape5
        '
        Me.LineShape5.BorderColor = System.Drawing.Color.White
        Me.LineShape5.Name = "LineShape5"
        Me.LineShape5.X1 = 781
        Me.LineShape5.X2 = 903
        Me.LineShape5.Y1 = 347
        Me.LineShape5.Y2 = 347
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape5})
        Me.ShapeContainer1.Size = New System.Drawing.Size(948, 409)
        Me.ShapeContainer1.TabIndex = 24
        Me.ShapeContainer1.TabStop = False
        '
        'LblContador_Clientes
        '
        Me.LblContador_Clientes.AutoSize = True
        Me.LblContador_Clientes.ForeColor = System.Drawing.Color.White
        Me.LblContador_Clientes.Location = New System.Drawing.Point(650, 376)
        Me.LblContador_Clientes.Name = "LblContador_Clientes"
        Me.LblContador_Clientes.Size = New System.Drawing.Size(0, 13)
        Me.LblContador_Clientes.TabIndex = 30
        '
        'LblReg_cli
        '
        Me.LblReg_cli.AutoSize = True
        Me.LblReg_cli.ForeColor = System.Drawing.Color.White
        Me.LblReg_cli.Location = New System.Drawing.Point(496, 376)
        Me.LblReg_cli.Name = "LblReg_cli"
        Me.LblReg_cli.Size = New System.Drawing.Size(148, 13)
        Me.LblReg_cli.TabIndex = 31
        Me.LblReg_cli.Text = "Total de Clientes Registrados:"
        '
        'PbEliminar_cli
        '
        Me.PbEliminar_cli.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEliminar_cli.Enabled = False
        Me.PbEliminar_cli.Image = CType(resources.GetObject("PbEliminar_cli.Image"), System.Drawing.Image)
        Me.PbEliminar_cli.Location = New System.Drawing.Point(387, 199)
        Me.PbEliminar_cli.Name = "PbEliminar_cli"
        Me.PbEliminar_cli.Size = New System.Drawing.Size(39, 29)
        Me.PbEliminar_cli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbEliminar_cli.TabIndex = 28
        Me.PbEliminar_cli.TabStop = False
        '
        'PbLimpiar_cli
        '
        Me.PbLimpiar_cli.BackColor = System.Drawing.Color.SeaGreen
        Me.PbLimpiar_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PbLimpiar_cli.Enabled = False
        Me.PbLimpiar_cli.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.Limpiar
        Me.PbLimpiar_cli.Location = New System.Drawing.Point(392, 242)
        Me.PbLimpiar_cli.Name = "PbLimpiar_cli"
        Me.PbLimpiar_cli.Size = New System.Drawing.Size(32, 31)
        Me.PbLimpiar_cli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbLimpiar_cli.TabIndex = 29
        Me.PbLimpiar_cli.TabStop = False
        '
        'PbGuardar_cli
        '
        Me.PbGuardar_cli.BackColor = System.Drawing.Color.SeaGreen
        Me.PbGuardar_cli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PbGuardar_cli.Enabled = False
        Me.PbGuardar_cli.Image = CType(resources.GetObject("PbGuardar_cli.Image"), System.Drawing.Image)
        Me.PbGuardar_cli.Location = New System.Drawing.Point(388, 106)
        Me.PbGuardar_cli.Name = "PbGuardar_cli"
        Me.PbGuardar_cli.Size = New System.Drawing.Size(39, 32)
        Me.PbGuardar_cli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbGuardar_cli.TabIndex = 27
        Me.PbGuardar_cli.TabStop = False
        '
        'PbEditar_cli
        '
        Me.PbEditar_cli.BackColor = System.Drawing.Color.SeaGreen
        Me.PbEditar_cli.Enabled = False
        Me.PbEditar_cli.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.editar
        Me.PbEditar_cli.Location = New System.Drawing.Point(387, 151)
        Me.PbEditar_cli.Name = "PbEditar_cli"
        Me.PbEditar_cli.Size = New System.Drawing.Size(40, 32)
        Me.PbEditar_cli.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbEditar_cli.TabIndex = 26
        Me.PbEditar_cli.TabStop = False
        '
        'LblFila_eliminar
        '
        Me.LblFila_eliminar.AutoSize = True
        Me.LblFila_eliminar.ForeColor = System.Drawing.Color.White
        Me.LblFila_eliminar.Location = New System.Drawing.Point(679, 58)
        Me.LblFila_eliminar.Name = "LblFila_eliminar"
        Me.LblFila_eliminar.Size = New System.Drawing.Size(0, 13)
        Me.LblFila_eliminar.TabIndex = 32
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(948, 409)
        Me.Controls.Add(Me.LblFila_eliminar)
        Me.Controls.Add(Me.LblReg_cli)
        Me.Controls.Add(Me.LblContador_Clientes)
        Me.Controls.Add(Me.PbEliminar_cli)
        Me.Controls.Add(Me.PbLimpiar_cli)
        Me.Controls.Add(Me.btn_eliminar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.PbGuardar_cli)
        Me.Controls.Add(Me.PbEditar_cli)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_editar)
        Me.Controls.Add(Me.Panel_cli)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbBuscar)
        Me.Controls.Add(Me.txtBuscar_cli)
        Me.Controls.Add(Me.lblCodCli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_flag)
        Me.Controls.Add(Me.dt_clientes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.dt_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_cli.ResumeLayout(False)
        Me.Panel_cli.PerformLayout()
        CType(Me.PbEliminar_cli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLimpiar_cli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbGuardar_cli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEditar_cli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_flag As System.Windows.Forms.TextBox
    Friend WithEvents dt_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_dni As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_editar As System.Windows.Forms.Button
    Friend WithEvents btn_agregar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCodCli As System.Windows.Forms.Label
    Friend WithEvents txtBuscar_cli As System.Windows.Forms.TextBox
    Friend WithEvents cmbBuscar As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ErrorClientes As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar_cli As System.Windows.Forms.Button
    Friend WithEvents Panel_cli As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LpNombre As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape5 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PbLimpiar_cli As System.Windows.Forms.PictureBox
    Friend WithEvents PbEliminar_cli As System.Windows.Forms.PictureBox
    Friend WithEvents PbGuardar_cli As System.Windows.Forms.PictureBox
    Friend WithEvents PbEditar_cli As System.Windows.Forms.PictureBox
    Friend WithEvents LblContador_Clientes As System.Windows.Forms.Label
    Friend WithEvents LblReg_cli As System.Windows.Forms.Label
    Friend WithEvents LblFila_eliminar As System.Windows.Forms.Label
End Class
