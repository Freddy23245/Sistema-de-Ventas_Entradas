<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearEquipos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbEquipos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEquip_sel = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgv_equipos = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblId_equipo = New System.Windows.Forms.Label()
        Me.btnReg_equipo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNuevo_equipo = New System.Windows.Forms.TextBox()
        Me.btnMostrar_equipos = New System.Windows.Forms.Button()
        Me.Panel_equipos = New System.Windows.Forms.Panel()
        Me.btnCerrar_equip = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExplorar = New System.Windows.Forms.Button()
        Me.EntradasDataSet = New Sistemas_de_Entradas.EntradasDataSet()
        Me.EquiposBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsEquip_sel = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ErrorEquipo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Pbeliminar_equip = New System.Windows.Forms.PictureBox()
        Me.Pbeditar_equip = New System.Windows.Forms.PictureBox()
        Me.PbLimp_equip = New System.Windows.Forms.PictureBox()
        Me.PbReg_equip = New System.Windows.Forms.PictureBox()
        Me.PbEscudo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbexplorar = New System.Windows.Forms.PictureBox()
        Me.chkbSel_equip = New System.Windows.Forms.CheckBox()
        Me.LblSeleccionar_equipos = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.dgv_equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_equipos.SuspendLayout()
        CType(Me.EntradasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbeliminar_equip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pbeditar_equip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbLimp_equip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbReg_equip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbEscudo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbexplorar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(53, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipos existentes:"
        '
        'cmbEquipos
        '
        Me.cmbEquipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cmbEquipos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cmbEquipos.ForeColor = System.Drawing.Color.White
        Me.cmbEquipos.FormattingEnabled = True
        Me.cmbEquipos.Location = New System.Drawing.Point(183, 140)
        Me.cmbEquipos.Name = "cmbEquipos"
        Me.cmbEquipos.Size = New System.Drawing.Size(149, 24)
        Me.cmbEquipos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(37, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Equipo seleccionado:"
        '
        'txtEquip_sel
        '
        Me.txtEquip_sel.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtEquip_sel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEquip_sel.ForeColor = System.Drawing.Color.White
        Me.txtEquip_sel.Location = New System.Drawing.Point(183, 183)
        Me.txtEquip_sel.Name = "txtEquip_sel"
        Me.txtEquip_sel.Size = New System.Drawing.Size(149, 13)
        Me.txtEquip_sel.TabIndex = 3
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.Transparent
        Me.btnModificar.Location = New System.Drawing.Point(536, 385)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(108, 41)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "            Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnEliminar.ForeColor = System.Drawing.Color.Transparent
        Me.btnEliminar.Location = New System.Drawing.Point(536, 432)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(108, 41)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "          Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgv_equipos
        '
        Me.dgv_equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv_equipos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dgv_equipos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_equipos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv_equipos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_equipos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_equipos.ColumnHeadersHeight = 30
        Me.dgv_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.dgv_equipos.EnableHeadersVisualStyles = False
        Me.dgv_equipos.GridColor = System.Drawing.Color.SteelBlue
        Me.dgv_equipos.Location = New System.Drawing.Point(40, 279)
        Me.dgv_equipos.Name = "dgv_equipos"
        Me.dgv_equipos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_equipos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dgv_equipos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_equipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_equipos.Size = New System.Drawing.Size(473, 260)
        Me.dgv_equipos.TabIndex = 7
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 60
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(86, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nº de Equipo:"
        '
        'lblId_equipo
        '
        Me.lblId_equipo.AutoSize = True
        Me.lblId_equipo.BackColor = System.Drawing.Color.Transparent
        Me.lblId_equipo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblId_equipo.ForeColor = System.Drawing.SystemColors.Control
        Me.lblId_equipo.Location = New System.Drawing.Point(186, 108)
        Me.lblId_equipo.Name = "lblId_equipo"
        Me.lblId_equipo.Size = New System.Drawing.Size(0, 16)
        Me.lblId_equipo.TabIndex = 8
        '
        'btnReg_equipo
        '
        Me.btnReg_equipo.BackColor = System.Drawing.Color.SeaGreen
        Me.btnReg_equipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReg_equipo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnReg_equipo.ForeColor = System.Drawing.Color.Transparent
        Me.btnReg_equipo.Location = New System.Drawing.Point(536, 291)
        Me.btnReg_equipo.Name = "btnReg_equipo"
        Me.btnReg_equipo.Size = New System.Drawing.Size(108, 41)
        Me.btnReg_equipo.TabIndex = 9
        Me.btnReg_equipo.Text = "           Registrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "          Equipo"
        Me.btnReg_equipo.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Transparent
        Me.btnLimpiar.Location = New System.Drawing.Point(536, 338)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(108, 41)
        Me.btnLimpiar.TabIndex = 10
        Me.btnLimpiar.Text = "          Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(362, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Nuevo Equipo:"
        '
        'txtNuevo_equipo
        '
        Me.txtNuevo_equipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtNuevo_equipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNuevo_equipo.ForeColor = System.Drawing.Color.White
        Me.txtNuevo_equipo.Location = New System.Drawing.Point(464, 188)
        Me.txtNuevo_equipo.Name = "txtNuevo_equipo"
        Me.txtNuevo_equipo.Size = New System.Drawing.Size(149, 13)
        Me.txtNuevo_equipo.TabIndex = 12
        '
        'btnMostrar_equipos
        '
        Me.btnMostrar_equipos.BackColor = System.Drawing.Color.SeaGreen
        Me.btnMostrar_equipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrar_equipos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnMostrar_equipos.ForeColor = System.Drawing.Color.Transparent
        Me.btnMostrar_equipos.Location = New System.Drawing.Point(536, 479)
        Me.btnMostrar_equipos.Name = "btnMostrar_equipos"
        Me.btnMostrar_equipos.Size = New System.Drawing.Size(108, 41)
        Me.btnMostrar_equipos.TabIndex = 24
        Me.btnMostrar_equipos.Text = "            Mostrar   " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "         Equipos"
        Me.btnMostrar_equipos.UseVisualStyleBackColor = False
        '
        'Panel_equipos
        '
        Me.Panel_equipos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_equipos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_equipos.Controls.Add(Me.btnCerrar_equip)
        Me.Panel_equipos.Controls.Add(Me.Label5)
        Me.Panel_equipos.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_equipos.Location = New System.Drawing.Point(0, 0)
        Me.Panel_equipos.Name = "Panel_equipos"
        Me.Panel_equipos.Size = New System.Drawing.Size(792, 28)
        Me.Panel_equipos.TabIndex = 25
        '
        'btnCerrar_equip
        '
        Me.btnCerrar_equip.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_equip.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_equip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_equip.FlatAppearance.BorderSize = 0
        Me.btnCerrar_equip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_equip.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_equip.Location = New System.Drawing.Point(762, 0)
        Me.btnCerrar_equip.Name = "btnCerrar_equip"
        Me.btnCerrar_equip.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_equip.TabIndex = 26
        Me.btnCerrar_equip.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(222, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(225, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "GESTIÓN DE EQUIPOS DE PRIMERA"
        '
        'btnExplorar
        '
        Me.btnExplorar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnExplorar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExplorar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btnExplorar.ForeColor = System.Drawing.SystemColors.Control
        Me.btnExplorar.Location = New System.Drawing.Point(515, 129)
        Me.btnExplorar.Name = "btnExplorar"
        Me.btnExplorar.Size = New System.Drawing.Size(108, 41)
        Me.btnExplorar.TabIndex = 27
        Me.btnExplorar.Text = "              Explorar"
        Me.btnExplorar.UseVisualStyleBackColor = False
        '
        'EntradasDataSet
        '
        Me.EntradasDataSet.DataSetName = "EntradasDataSet"
        Me.EntradasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EquiposBindingSource
        '
        Me.EquiposBindingSource.DataMember = "Equipos"
        Me.EquiposBindingSource.DataSource = Me.EntradasDataSet
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LsEquip_sel})
        Me.ShapeContainer1.Size = New System.Drawing.Size(792, 569)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 462
        Me.LineShape1.X2 = 612
        Me.LineShape1.Y1 = 206
        Me.LineShape1.Y2 = 206
        '
        'LsEquip_sel
        '
        Me.LsEquip_sel.BorderColor = System.Drawing.Color.White
        Me.LsEquip_sel.Name = "LsEquip_sel"
        Me.LsEquip_sel.X1 = 183
        Me.LsEquip_sel.X2 = 333
        Me.LsEquip_sel.Y1 = 200
        Me.LsEquip_sel.Y2 = 200
        '
        'ErrorEquipo
        '
        Me.ErrorEquipo.ContainerControl = Me
        '
        'Pbeliminar_equip
        '
        Me.Pbeliminar_equip.BackColor = System.Drawing.Color.SeaGreen
        Me.Pbeliminar_equip.Enabled = False
        Me.Pbeliminar_equip.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.eliminar
        Me.Pbeliminar_equip.Location = New System.Drawing.Point(540, 437)
        Me.Pbeliminar_equip.Name = "Pbeliminar_equip"
        Me.Pbeliminar_equip.Size = New System.Drawing.Size(32, 30)
        Me.Pbeliminar_equip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbeliminar_equip.TabIndex = 32
        Me.Pbeliminar_equip.TabStop = False
        '
        'Pbeditar_equip
        '
        Me.Pbeditar_equip.BackColor = System.Drawing.Color.SeaGreen
        Me.Pbeditar_equip.Enabled = False
        Me.Pbeditar_equip.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.editar
        Me.Pbeditar_equip.Location = New System.Drawing.Point(540, 390)
        Me.Pbeditar_equip.Name = "Pbeditar_equip"
        Me.Pbeditar_equip.Size = New System.Drawing.Size(32, 31)
        Me.Pbeditar_equip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbeditar_equip.TabIndex = 31
        Me.Pbeditar_equip.TabStop = False
        '
        'PbLimp_equip
        '
        Me.PbLimp_equip.BackColor = System.Drawing.Color.SeaGreen
        Me.PbLimp_equip.Enabled = False
        Me.PbLimp_equip.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.Limpiar
        Me.PbLimp_equip.Location = New System.Drawing.Point(540, 346)
        Me.PbLimp_equip.Name = "PbLimp_equip"
        Me.PbLimp_equip.Size = New System.Drawing.Size(32, 27)
        Me.PbLimp_equip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbLimp_equip.TabIndex = 30
        Me.PbLimp_equip.TabStop = False
        '
        'PbReg_equip
        '
        Me.PbReg_equip.BackColor = System.Drawing.Color.SeaGreen
        Me.PbReg_equip.Enabled = False
        Me.PbReg_equip.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.PbReg_equip.Location = New System.Drawing.Point(540, 298)
        Me.PbReg_equip.Name = "PbReg_equip"
        Me.PbReg_equip.Size = New System.Drawing.Size(32, 30)
        Me.PbReg_equip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbReg_equip.TabIndex = 29
        Me.PbReg_equip.TabStop = False
        '
        'PbEscudo
        '
        Me.PbEscudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PbEscudo.Location = New System.Drawing.Point(522, 40)
        Me.PbEscudo.Name = "PbEscudo"
        Me.PbEscudo.Size = New System.Drawing.Size(91, 84)
        Me.PbEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbEscudo.TabIndex = 26
        Me.PbEscudo.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.SeaGreen
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.ver_grilla
        Me.PictureBox1.Location = New System.Drawing.Point(540, 484)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'pbexplorar
        '
        Me.pbexplorar.BackColor = System.Drawing.Color.SeaGreen
        Me.pbexplorar.Enabled = False
        Me.pbexplorar.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.lupa
        Me.pbexplorar.Location = New System.Drawing.Point(517, 135)
        Me.pbexplorar.Name = "pbexplorar"
        Me.pbexplorar.Size = New System.Drawing.Size(49, 30)
        Me.pbexplorar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbexplorar.TabIndex = 34
        Me.pbexplorar.TabStop = False
        '
        'chkbSel_equip
        '
        Me.chkbSel_equip.AutoSize = True
        Me.chkbSel_equip.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chkbSel_equip.ForeColor = System.Drawing.Color.White
        Me.chkbSel_equip.Location = New System.Drawing.Point(40, 256)
        Me.chkbSel_equip.Name = "chkbSel_equip"
        Me.chkbSel_equip.Size = New System.Drawing.Size(176, 20)
        Me.chkbSel_equip.TabIndex = 35
        Me.chkbSel_equip.Text = "Equipos seleccionados"
        Me.chkbSel_equip.UseVisualStyleBackColor = True
        '
        'LblSeleccionar_equipos
        '
        Me.LblSeleccionar_equipos.AutoSize = True
        Me.LblSeleccionar_equipos.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LblSeleccionar_equipos.ForeColor = System.Drawing.Color.White
        Me.LblSeleccionar_equipos.Location = New System.Drawing.Point(212, 257)
        Me.LblSeleccionar_equipos.Name = "LblSeleccionar_equipos"
        Me.LblSeleccionar_equipos.Size = New System.Drawing.Size(0, 16)
        Me.LblSeleccionar_equipos.TabIndex = 36
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(647, 40)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 80)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Sólo se admiten " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "imágenes con " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "redimensión: 300x300" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "y en formato:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " .JGP y .PN" & _
    "G."
        '
        'CrearEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 569)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LblSeleccionar_equipos)
        Me.Controls.Add(Me.chkbSel_equip)
        Me.Controls.Add(Me.pbexplorar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Pbeliminar_equip)
        Me.Controls.Add(Me.Pbeditar_equip)
        Me.Controls.Add(Me.PbLimp_equip)
        Me.Controls.Add(Me.PbReg_equip)
        Me.Controls.Add(Me.btnExplorar)
        Me.Controls.Add(Me.PbEscudo)
        Me.Controls.Add(Me.Panel_equipos)
        Me.Controls.Add(Me.btnMostrar_equipos)
        Me.Controls.Add(Me.txtNuevo_equipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnReg_equipo)
        Me.Controls.Add(Me.lblId_equipo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgv_equipos)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtEquip_sel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbEquipos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CrearEquipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificación de Equipos de la Superliga de Argentina"
        CType(Me.dgv_equipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_equipos.ResumeLayout(False)
        Me.Panel_equipos.PerformLayout()
        CType(Me.EntradasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EquiposBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbeliminar_equip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pbeditar_equip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbLimp_equip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbReg_equip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbEscudo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbexplorar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbEquipos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEquip_sel As System.Windows.Forms.TextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents dgv_equipos As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblId_equipo As System.Windows.Forms.Label
    Friend WithEvents btnReg_equipo As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNuevo_equipo As System.Windows.Forms.TextBox
    Friend WithEvents btnMostrar_equipos As System.Windows.Forms.Button
    Friend WithEvents Panel_equipos As System.Windows.Forms.Panel
    Friend WithEvents PbEscudo As System.Windows.Forms.PictureBox
    Friend WithEvents btnExplorar As System.Windows.Forms.Button
    Friend WithEvents EntradasDataSet As Sistemas_de_Entradas.EntradasDataSet
    Friend WithEvents EquiposBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsEquip_sel As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ErrorEquipo As System.Windows.Forms.ErrorProvider
    Friend WithEvents Pbeliminar_equip As System.Windows.Forms.PictureBox
    Friend WithEvents Pbeditar_equip As System.Windows.Forms.PictureBox
    Friend WithEvents PbLimp_equip As System.Windows.Forms.PictureBox
    Friend WithEvents PbReg_equip As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pbexplorar As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar_equip As System.Windows.Forms.Button
    Friend WithEvents chkbSel_equip As System.Windows.Forms.CheckBox
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LblSeleccionar_equipos As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
