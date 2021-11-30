<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CorreoElectronico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CorreoElectronico))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDe = New System.Windows.Forms.TextBox()
        Me.txtPara = New System.Windows.Forms.TextBox()
        Me.txtAsunto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.btnenviar = New System.Windows.Forms.Button()
        Me.rtxtTexto = New System.Windows.Forms.RichTextBox()
        Me.Panel_Correo = New System.Windows.Forms.Panel()
        Me.btnCerrar_mail = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LsContraseña = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsAsunto = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsPara = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LsDe = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbUsu_correo = New System.Windows.Forms.ComboBox()
        Me.ErrorCorreo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PbCorreo = New System.Windows.Forms.PictureBox()
        Me.Panel_Correo.SuspendLayout()
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbCorreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(89, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "De:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(76, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Para:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(62, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Asunto:"
        '
        'txtDe
        '
        Me.txtDe.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtDe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDe.ForeColor = System.Drawing.Color.White
        Me.txtDe.Location = New System.Drawing.Point(119, 120)
        Me.txtDe.Name = "txtDe"
        Me.txtDe.Size = New System.Drawing.Size(195, 13)
        Me.txtDe.TabIndex = 1
        '
        'txtPara
        '
        Me.txtPara.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtPara.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPara.ForeColor = System.Drawing.Color.White
        Me.txtPara.Location = New System.Drawing.Point(117, 159)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(195, 13)
        Me.txtPara.TabIndex = 2
        '
        'txtAsunto
        '
        Me.txtAsunto.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtAsunto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAsunto.ForeColor = System.Drawing.Color.White
        Me.txtAsunto.Location = New System.Drawing.Point(115, 199)
        Me.txtAsunto.Name = "txtAsunto"
        Me.txtAsunto.Size = New System.Drawing.Size(195, 13)
        Me.txtAsunto.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(348, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contraseña:"
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.ForeColor = System.Drawing.Color.White
        Me.txtContraseña.Location = New System.Drawing.Point(433, 120)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(142, 13)
        Me.txtContraseña.TabIndex = 4
        '
        'btnenviar
        '
        Me.btnenviar.BackColor = System.Drawing.Color.SeaGreen
        Me.btnenviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnenviar.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenviar.ForeColor = System.Drawing.Color.Transparent
        Me.btnenviar.Location = New System.Drawing.Point(65, 474)
        Me.btnenviar.Name = "btnenviar"
        Me.btnenviar.Size = New System.Drawing.Size(497, 44)
        Me.btnenviar.TabIndex = 6
        Me.btnenviar.Text = "Enviar"
        Me.btnenviar.UseVisualStyleBackColor = False
        '
        'rtxtTexto
        '
        Me.rtxtTexto.Location = New System.Drawing.Point(65, 261)
        Me.rtxtTexto.Name = "rtxtTexto"
        Me.rtxtTexto.Size = New System.Drawing.Size(497, 207)
        Me.rtxtTexto.TabIndex = 5
        Me.rtxtTexto.Text = ""
        '
        'Panel_Correo
        '
        Me.Panel_Correo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel_Correo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Correo.Controls.Add(Me.btnCerrar_mail)
        Me.Panel_Correo.Controls.Add(Me.Label5)
        Me.Panel_Correo.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel_Correo.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Correo.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Correo.Name = "Panel_Correo"
        Me.Panel_Correo.Size = New System.Drawing.Size(633, 32)
        Me.Panel_Correo.TabIndex = 24
        '
        'btnCerrar_mail
        '
        Me.btnCerrar_mail.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar_mail.BackgroundImage = Global.Sistemas_de_Entradas.My.Resources.Resources.boton_cerrar
        Me.btnCerrar_mail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar_mail.FlatAppearance.BorderSize = 0
        Me.btnCerrar_mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar_mail.ForeColor = System.Drawing.Color.Black
        Me.btnCerrar_mail.Location = New System.Drawing.Point(594, 1)
        Me.btnCerrar_mail.Name = "btnCerrar_mail"
        Me.btnCerrar_mail.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar_mail.TabIndex = 26
        Me.btnCerrar_mail.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(244, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 15)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "CORREO ELECTRÓNICO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LsContraseña, Me.LsAsunto, Me.LsPara, Me.LsDe})
        Me.ShapeContainer1.Size = New System.Drawing.Size(633, 534)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
        '
        'LsContraseña
        '
        Me.LsContraseña.BorderColor = System.Drawing.Color.White
        Me.LsContraseña.Name = "LsContraseña"
        Me.LsContraseña.X1 = 432
        Me.LsContraseña.X2 = 573
        Me.LsContraseña.Y1 = 138
        Me.LsContraseña.Y2 = 138
        '
        'LsAsunto
        '
        Me.LsAsunto.BorderColor = System.Drawing.Color.White
        Me.LsAsunto.Name = "LsAsunto"
        Me.LsAsunto.X1 = 115
        Me.LsAsunto.X2 = 311
        Me.LsAsunto.Y1 = 213
        Me.LsAsunto.Y2 = 213
        '
        'LsPara
        '
        Me.LsPara.BorderColor = System.Drawing.Color.White
        Me.LsPara.Name = "LsPara"
        Me.LsPara.X1 = 115
        Me.LsPara.X2 = 311
        Me.LsPara.Y1 = 176
        Me.LsPara.Y2 = 176
        '
        'LsDe
        '
        Me.LsDe.BorderColor = System.Drawing.Color.White
        Me.LsDe.Name = "LsDe"
        Me.LsDe.X1 = 115
        Me.LsDe.X2 = 311
        Me.LsDe.Y1 = 134
        Me.LsDe.Y2 = 134
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(243, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 16)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Clientes Disponibles"
        '
        'cmbUsu_correo
        '
        Me.cmbUsu_correo.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cmbUsu_correo.ForeColor = System.Drawing.Color.White
        Me.cmbUsu_correo.FormattingEnabled = True
        Me.cmbUsu_correo.Location = New System.Drawing.Point(209, 71)
        Me.cmbUsu_correo.Name = "cmbUsu_correo"
        Me.cmbUsu_correo.Size = New System.Drawing.Size(211, 21)
        Me.cmbUsu_correo.TabIndex = 27
        '
        'ErrorCorreo
        '
        Me.ErrorCorreo.ContainerControl = Me
        '
        'PbCorreo
        '
        Me.PbCorreo.BackColor = System.Drawing.Color.SeaGreen
        Me.PbCorreo.Enabled = False
        Me.PbCorreo.Image = Global.Sistemas_de_Entradas.My.Resources.Resources.correo1
        Me.PbCorreo.Location = New System.Drawing.Point(232, 478)
        Me.PbCorreo.Name = "PbCorreo"
        Me.PbCorreo.Size = New System.Drawing.Size(44, 36)
        Me.PbCorreo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PbCorreo.TabIndex = 28
        Me.PbCorreo.TabStop = False
        '
        'CorreoElectronico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(633, 534)
        Me.Controls.Add(Me.PbCorreo)
        Me.Controls.Add(Me.cmbUsu_correo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel_Correo)
        Me.Controls.Add(Me.rtxtTexto)
        Me.Controls.Add(Me.btnenviar)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAsunto)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.txtDe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CorreoElectronico"
        Me.Text = "CorreoElectronico"
        Me.Panel_Correo.ResumeLayout(False)
        Me.Panel_Correo.PerformLayout()
        CType(Me.ErrorCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbCorreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDe As System.Windows.Forms.TextBox
    Friend WithEvents txtPara As System.Windows.Forms.TextBox
    Friend WithEvents txtAsunto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents btnenviar As System.Windows.Forms.Button
    Friend WithEvents rtxtTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel_Correo As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LsContraseña As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsAsunto As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsPara As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LsDe As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbUsu_correo As System.Windows.Forms.ComboBox
    Friend WithEvents ErrorCorreo As System.Windows.Forms.ErrorProvider
    Friend WithEvents PbCorreo As System.Windows.Forms.PictureBox
    Friend WithEvents btnCerrar_mail As System.Windows.Forms.Button
End Class
