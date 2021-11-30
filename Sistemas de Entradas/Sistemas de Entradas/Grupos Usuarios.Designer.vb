<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Grupos_Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grupos_Usuarios))
        Me.cbx_grupos = New System.Windows.Forms.ComboBox()
        Me.cbx_usuarios = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_aplicar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCerrar_grup_usu = New System.Windows.Forms.Button()
        Me.Panel_usu_grup = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pbaplicar_usugrup = New System.Windows.Forms.PictureBox()
        Me.btn_elinar_del_grupo = New System.Windows.Forms.Button()
        Me.Panel_usu_grup.SuspendLayout()
        CType(Me.Pbaplicar_usugrup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbx_grupos
        '
        Me.cbx_grupos.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cbx_grupos.ForeColor = System.Drawing.Color.White
        Me.cbx_grupos.FormattingEnabled = True
        Me.cbx_grupos.Location = New System.Drawing.Point(219, 145)
        Me.cbx_grupos.Name = "cbx_grupos"
        Me.cbx_grupos.Size = New System.Drawing.Size(121, 21)
        Me.cbx_grupos.TabIndex = 23
        '
        'cbx_usuarios
        '
        Me.cbx_usuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.cbx_usuarios.ForeColor = System.Drawing.Color.White
        Me.cbx_usuarios.FormattingEnabled = True
        Me.cbx_usuarios.Location = New System.Drawing.Point(56, 145)
        Me.cbx_usuarios.Name = "cbx_usuarios"
        Me.cbx_usuarios.Size = New System.Drawing.Size(121, 21)
        Me.cbx_usuarios.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(240, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 18)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "GRUPOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(76, 112)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "USUARIOS"
        '
        'btn_aplicar
        '
        Me.btn_aplicar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aplicar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_aplicar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_aplicar.Location = New System.Drawing.Point(56, 189)
        Me.btn_aplicar.Name = "btn_aplicar"
        Me.btn_aplicar.Size = New System.Drawing.Size(137, 46)
        Me.btn_aplicar.TabIndex = 18
        Me.btn_aplicar.Text = "                 Aplicar"
        Me.btn_aplicar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(12, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(398, 32)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Para realizar las asignaciones, debe elegir el/los usuario/s " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "con su/s respectiv" & _
    "o/s grupo/s:"
        '
        'btnCerrar_grup_usu
        '
        Me.btnCerrar_grup_usu.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_grup_usu.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_grup_usu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_grup_usu.FlatAppearance.BorderSize = 0
        Me.btnCerrar_grup_usu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_grup_usu.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_grup_usu.Location = New System.Drawing.Point(377, 0)
        Me.btnCerrar_grup_usu.Name = "btnCerrar_grup_usu"
        Me.btnCerrar_grup_usu.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_grup_usu.TabIndex = 26
        Me.btnCerrar_grup_usu.UseVisualStyleBackColor = False
        '
        'Panel_usu_grup
        '
        Me.Panel_usu_grup.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_usu_grup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_usu_grup.Controls.Add(Me.Label4)
        Me.Panel_usu_grup.Controls.Add(Me.btnCerrar_grup_usu)
        Me.Panel_usu_grup.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_usu_grup.Location = New System.Drawing.Point(0, 0)
        Me.Panel_usu_grup.Name = "Panel_usu_grup"
        Me.Panel_usu_grup.Size = New System.Drawing.Size(436, 28)
        Me.Panel_usu_grup.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(86, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(235, 15)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "SELECCIÓN DE USUARIOS A GRUPOS"
        '
        'Pbaplicar_usugrup
        '
        Me.Pbaplicar_usugrup.BackColor = System.Drawing.Color.SeaGreen
        Me.Pbaplicar_usugrup.Enabled = False
        Me.Pbaplicar_usugrup.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.guardar
        Me.Pbaplicar_usugrup.Location = New System.Drawing.Point(66, 195)
        Me.Pbaplicar_usugrup.Name = "Pbaplicar_usugrup"
        Me.Pbaplicar_usugrup.Size = New System.Drawing.Size(36, 35)
        Me.Pbaplicar_usugrup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pbaplicar_usugrup.TabIndex = 28
        Me.Pbaplicar_usugrup.TabStop = False
        '
        'btn_elinar_del_grupo
        '
        Me.btn_elinar_del_grupo.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_elinar_del_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_elinar_del_grupo.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_elinar_del_grupo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_elinar_del_grupo.Location = New System.Drawing.Point(219, 189)
        Me.btn_elinar_del_grupo.Name = "btn_elinar_del_grupo"
        Me.btn_elinar_del_grupo.Size = New System.Drawing.Size(137, 46)
        Me.btn_elinar_del_grupo.TabIndex = 29
        Me.btn_elinar_del_grupo.Text = " Eliminar Del Grupo"
        Me.btn_elinar_del_grupo.UseVisualStyleBackColor = False
        '
        'Grupos_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(436, 283)
        Me.Controls.Add(Me.btn_elinar_del_grupo)
        Me.Controls.Add(Me.Pbaplicar_usugrup)
        Me.Controls.Add(Me.Panel_usu_grup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbx_grupos)
        Me.Controls.Add(Me.cbx_usuarios)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_aplicar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Grupos_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos Usuarios"
        Me.Panel_usu_grup.ResumeLayout(False)
        Me.Panel_usu_grup.PerformLayout()
        CType(Me.Pbaplicar_usugrup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbx_grupos As System.Windows.Forms.ComboBox
    Friend WithEvents cbx_usuarios As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_aplicar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar_grup_usu As System.Windows.Forms.Button
    Friend WithEvents Panel_usu_grup As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Pbaplicar_usugrup As System.Windows.Forms.PictureBox
    Friend WithEvents btn_elinar_del_grupo As System.Windows.Forms.Button
End Class
