<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos_Permisos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grupos_Permisos))
        Me.cbx_permisos = New System.Windows.Forms.ComboBox()
        Me.cbx_grupos = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_alta = New System.Windows.Forms.CheckBox()
        Me.chk_baja = New System.Windows.Forms.CheckBox()
        Me.chk_modificacion = New System.Windows.Forms.CheckBox()
        Me.btn_aplicar = New System.Windows.Forms.Button()
        Me.btnCerrar_permiso = New System.Windows.Forms.Button()
        Me.Panel_permiso = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbAplicar_perm = New System.Windows.Forms.PictureBox()
        Me.dt_permisos = New System.Windows.Forms.DataGridView()
        Me.btn_eliminar_permisos = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel_permiso.SuspendLayout()
        CType(Me.pbAplicar_perm, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_permisos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_permisos
        '
        Me.cbx_permisos.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cbx_permisos.ForeColor = System.Drawing.Color.White
        Me.cbx_permisos.FormattingEnabled = True
        Me.cbx_permisos.Location = New System.Drawing.Point(82, 96)
        Me.cbx_permisos.Name = "cbx_permisos"
        Me.cbx_permisos.Size = New System.Drawing.Size(121, 21)
        Me.cbx_permisos.TabIndex = 24
        '
        'cbx_grupos
        '
        Me.cbx_grupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cbx_grupos.ForeColor = System.Drawing.Color.White
        Me.cbx_grupos.FormattingEnabled = True
        Me.cbx_grupos.Location = New System.Drawing.Point(82, 69)
        Me.cbx_grupos.Name = "cbx_grupos"
        Me.cbx_grupos.Size = New System.Drawing.Size(121, 21)
        Me.cbx_grupos.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(7, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Permisos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(19, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Grupos:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chk_alta)
        Me.GroupBox1.Controls.Add(Me.chk_baja)
        Me.GroupBox1.Controls.Add(Me.chk_modificacion)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(82, 134)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 150)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Permisos"
        '
        'chk_alta
        '
        Me.chk_alta.AutoSize = True
        Me.chk_alta.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_alta.ForeColor = System.Drawing.Color.White
        Me.chk_alta.Location = New System.Drawing.Point(6, 31)
        Me.chk_alta.Name = "chk_alta"
        Me.chk_alta.Size = New System.Drawing.Size(54, 20)
        Me.chk_alta.TabIndex = 2
        Me.chk_alta.Text = "Alta"
        Me.chk_alta.UseVisualStyleBackColor = True
        '
        'chk_baja
        '
        Me.chk_baja.AutoSize = True
        Me.chk_baja.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_baja.ForeColor = System.Drawing.Color.White
        Me.chk_baja.Location = New System.Drawing.Point(6, 70)
        Me.chk_baja.Name = "chk_baja"
        Me.chk_baja.Size = New System.Drawing.Size(57, 20)
        Me.chk_baja.TabIndex = 3
        Me.chk_baja.Text = "Baja"
        Me.chk_baja.UseVisualStyleBackColor = True
        '
        'chk_modificacion
        '
        Me.chk_modificacion.AutoSize = True
        Me.chk_modificacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.chk_modificacion.ForeColor = System.Drawing.Color.White
        Me.chk_modificacion.Location = New System.Drawing.Point(6, 105)
        Me.chk_modificacion.Name = "chk_modificacion"
        Me.chk_modificacion.Size = New System.Drawing.Size(113, 20)
        Me.chk_modificacion.TabIndex = 4
        Me.chk_modificacion.Text = "Modificacion"
        Me.chk_modificacion.UseVisualStyleBackColor = True
        '
        'btn_aplicar
        '
        Me.btn_aplicar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aplicar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_aplicar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_aplicar.Location = New System.Drawing.Point(82, 318)
        Me.btn_aplicar.Name = "btn_aplicar"
        Me.btn_aplicar.Size = New System.Drawing.Size(119, 43)
        Me.btn_aplicar.TabIndex = 18
        Me.btn_aplicar.Text = "              Aplicar"
        Me.btn_aplicar.UseVisualStyleBackColor = False
        '
        'btnCerrar_permiso
        '
        Me.btnCerrar_permiso.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_permiso.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_permiso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_permiso.FlatAppearance.BorderSize = 0
        Me.btnCerrar_permiso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_permiso.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_permiso.Location = New System.Drawing.Point(596, 3)
        Me.btnCerrar_permiso.Name = "btnCerrar_permiso"
        Me.btnCerrar_permiso.Size = New System.Drawing.Size(25, 26)
        Me.btnCerrar_permiso.TabIndex = 25
        Me.btnCerrar_permiso.UseVisualStyleBackColor = False
        '
        'Panel_permiso
        '
        Me.Panel_permiso.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_permiso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_permiso.Controls.Add(Me.Label3)
        Me.Panel_permiso.Controls.Add(Me.btnCerrar_permiso)
        Me.Panel_permiso.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_permiso.Location = New System.Drawing.Point(0, 0)
        Me.Panel_permiso.Name = "Panel_permiso"
        Me.Panel_permiso.Size = New System.Drawing.Size(635, 33)
        Me.Panel_permiso.TabIndex = 26
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(204, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 15)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "GESTIÓN DE PERMISOS"
        '
        'pbAplicar_perm
        '
        Me.pbAplicar_perm.BackColor = System.Drawing.Color.SeaGreen
        Me.pbAplicar_perm.Enabled = False
        Me.pbAplicar_perm.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.pbAplicar_perm.Location = New System.Drawing.Point(88, 325)
        Me.pbAplicar_perm.Name = "pbAplicar_perm"
        Me.pbAplicar_perm.Size = New System.Drawing.Size(36, 35)
        Me.pbAplicar_perm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbAplicar_perm.TabIndex = 27
        Me.pbAplicar_perm.TabStop = False
        '
        'dt_permisos
        '
        Me.dt_permisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_permisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dt_permisos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.dt_permisos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dt_permisos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dt_permisos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_permisos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dt_permisos.ColumnHeadersHeight = 30
        Me.dt_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dt_permisos.EnableHeadersVisualStyles = False
        Me.dt_permisos.GridColor = System.Drawing.Color.SteelBlue
        Me.dt_permisos.Location = New System.Drawing.Point(225, 81)
        Me.dt_permisos.Name = "dt_permisos"
        Me.dt_permisos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dt_permisos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.dt_permisos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dt_permisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dt_permisos.Size = New System.Drawing.Size(368, 241)
        Me.dt_permisos.TabIndex = 29
        '
        'btn_eliminar_permisos
        '
        Me.btn_eliminar_permisos.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_eliminar_permisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar_permisos.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_eliminar_permisos.ForeColor = System.Drawing.Color.Transparent
        Me.btn_eliminar_permisos.Location = New System.Drawing.Point(344, 347)
        Me.btn_eliminar_permisos.Name = "btn_eliminar_permisos"
        Me.btn_eliminar_permisos.Size = New System.Drawing.Size(119, 43)
        Me.btn_eliminar_permisos.TabIndex = 30
        Me.btn_eliminar_permisos.Text = "Quitar Permisos"
        Me.btn_eliminar_permisos.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(250, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Usuario:"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.Lime
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.Location = New System.Drawing.Point(349, 49)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(0, 20)
        Me.lbl_usuario.TabIndex = 32
        '
        'Grupos_Permisos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(635, 402)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_eliminar_permisos)
        Me.Controls.Add(Me.dt_permisos)
        Me.Controls.Add(Me.pbAplicar_perm)
        Me.Controls.Add(Me.Panel_permiso)
        Me.Controls.Add(Me.cbx_permisos)
        Me.Controls.Add(Me.cbx_grupos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_aplicar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Grupos_Permisos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos Permisos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel_permiso.ResumeLayout(False)
        Me.Panel_permiso.PerformLayout()
        CType(Me.pbAplicar_perm, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_permisos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_permisos As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_grupos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents chk_alta As System.Windows.Forms.CheckBox
    Friend WithEvents chk_baja As System.Windows.Forms.CheckBox
    Friend WithEvents chk_modificacion As System.Windows.Forms.CheckBox
    Friend WithEvents btn_aplicar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar_permiso As System.Windows.Forms.Button
    Friend WithEvents Panel_permiso As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents pbAplicar_perm As System.Windows.Forms.PictureBox
    Friend WithEvents dt_permisos As System.Windows.Forms.DataGridView
    Friend WithEvents btn_eliminar_permisos As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbl_usuario As System.Windows.Forms.Label
End Class
