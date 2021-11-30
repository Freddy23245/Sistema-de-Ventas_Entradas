<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Crear_Grupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Crear_Grupos))
        Me.btn_crear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_grupo = New System.Windows.Forms.TextBox()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.ErrorGrupo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panel_grupo = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrar_grupo = New System.Windows.Forms.Button()
        Me.PbGrupos = New System.Windows.Forms.PictureBox()
        Me.PbCancel_grup = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorGrupo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_grupo.SuspendLayout()
        CType(Me.PbGrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCancel_grup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_crear
        '
        Me.btn_crear.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_crear.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_crear.ForeColor = System.Drawing.Color.Transparent
        Me.btn_crear.Location = New System.Drawing.Point(94, 110)
        Me.btn_crear.Name = "btn_crear"
        Me.btn_crear.Size = New System.Drawing.Size(88, 36)
        Me.btn_crear.TabIndex = 0
        Me.btn_crear.Text = "            Crear "
        Me.btn_crear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(12, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Del Grupo:"
        '
        'txt_grupo
        '
        Me.txt_grupo.Location = New System.Drawing.Point(149, 59)
        Me.txt_grupo.Name = "txt_grupo"
        Me.txt_grupo.Size = New System.Drawing.Size(149, 20)
        Me.txt_grupo.TabIndex = 2
        '
        'btn_cancelar
        '
        Me.btn_cancelar.BackColor = System.Drawing.Color.SeaGreen
        Me.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelar.Font = New System.Drawing.Font("Candara", 9.75!, System.Drawing.FontStyle.Bold)
        Me.btn_cancelar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_cancelar.Location = New System.Drawing.Point(205, 110)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(103, 36)
        Me.btn_cancelar.TabIndex = 3
        Me.btn_cancelar.Text = "       Cancelar"
        Me.btn_cancelar.UseVisualStyleBackColor = False
        '
        'ErrorGrupo
        '
        Me.ErrorGrupo.ContainerControl = Me
        '
        'panel_grupo
        '
        Me.panel_grupo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.panel_grupo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.panel_grupo.Controls.Add(Me.Label2)
        Me.panel_grupo.Controls.Add(Me.btnCerrar_grupo)
        Me.panel_grupo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_grupo.Location = New System.Drawing.Point(0, 0)
        Me.panel_grupo.Name = "panel_grupo"
        Me.panel_grupo.Size = New System.Drawing.Size(329, 27)
        Me.panel_grupo.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(56, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 15)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "REGISTRO DE NUEVOS GRUPOS"
        '
        'btnCerrar_grupo
        '
        Me.btnCerrar_grupo.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_grupo.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_grupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_grupo.FlatAppearance.BorderSize = 0
        Me.btnCerrar_grupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_grupo.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_grupo.Location = New System.Drawing.Point(301, -1)
        Me.btnCerrar_grupo.Name = "btnCerrar_grupo"
        Me.btnCerrar_grupo.Size = New System.Drawing.Size(21, 21)
        Me.btnCerrar_grupo.TabIndex = 23
        Me.btnCerrar_grupo.UseVisualStyleBackColor = False
        '
        'PbGrupos
        '
        Me.PbGrupos.BackColor = System.Drawing.Color.SeaGreen
        Me.PbGrupos.Enabled = False
        Me.PbGrupos.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.grupo
        Me.PbGrupos.Location = New System.Drawing.Point(99, 113)
        Me.PbGrupos.Name = "PbGrupos"
        Me.PbGrupos.Size = New System.Drawing.Size(35, 29)
        Me.PbGrupos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbGrupos.TabIndex = 25
        Me.PbGrupos.TabStop = False
        '
        'PbCancel_grup
        '
        Me.PbCancel_grup.BackColor = System.Drawing.Color.SeaGreen
        Me.PbCancel_grup.Enabled = False
        Me.PbCancel_grup.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.eliminar
        Me.PbCancel_grup.Location = New System.Drawing.Point(208, 113)
        Me.PbCancel_grup.Name = "PbCancel_grup"
        Me.PbCancel_grup.Size = New System.Drawing.Size(29, 29)
        Me.PbCancel_grup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbCancel_grup.TabIndex = 26
        Me.PbCancel_grup.TabStop = False
        '
        'Crear_Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(329, 168)
        Me.Controls.Add(Me.PbCancel_grup)
        Me.Controls.Add(Me.PbGrupos)
        Me.Controls.Add(Me.panel_grupo)
        Me.Controls.Add(Me.btn_cancelar)
        Me.Controls.Add(Me.txt_grupo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_crear)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Crear_Grupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Grupos"
        CType(Me.ErrorGrupo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_grupo.ResumeLayout(False)
        Me.panel_grupo.PerformLayout()
        CType(Me.PbGrupos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbCancel_grup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_crear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_grupo As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancelar As System.Windows.Forms.Button
    Friend WithEvents ErrorGrupo As System.Windows.Forms.ErrorProvider
    Friend WithEvents btnCerrar_grupo As System.Windows.Forms.Button
    Friend WithEvents panel_grupo As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PbGrupos As System.Windows.Forms.PictureBox
    Friend WithEvents PbCancel_grup As System.Windows.Forms.PictureBox
End Class
