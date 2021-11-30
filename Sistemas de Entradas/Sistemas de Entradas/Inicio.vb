
Imports Capa_Logica
Public Class Inicio

    Private _usu As String
    Private puestoGrupo As String
    Dim x, y As Integer
    Dim mover_ini As Boolean

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Sub New(usu As String)
        Me.New()
        ' TODO: Complete member initialization 
        _usu = usu
    End Sub

   

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try

            Dim cerrar As DialogResult

            cerrar = MessageBox.Show("¿Seguro que desea cerrar el programa?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (cerrar = DialogResult.OK) Then
                Application.Exit()

            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try
    End Sub

    'MÉTODOS + EVENTOS PARA MANIPULAR LA VENTANA INICIO, A TRAVÉZ DEL MOUSE
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub panel_contenedor_MouseMove(sender As Object, e As MouseEventArgs) Handles panel_contenedor.MouseMove
        Try

            If mover_ini Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub panel_contenedor_MouseDown(sender As Object, e As MouseEventArgs) Handles panel_contenedor.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_ini = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub panel_contenedor_MouseUp(sender As Object, e As MouseEventArgs) Handles panel_contenedor.MouseUp
        Try
            mover_ini = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_arriba_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_arriba.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_ini = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_arriba_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_arriba.MouseMove
        Try

            If mover_ini Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_arriba_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_arriba.MouseUp
        Try
            mover_ini = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'Metodo de abrir el formulario
    Private Sub abrirFormenPanel(Of MiForm As {Form, New})()
        Dim formulario As Form
        formulario = panel_contenedor.Controls.OfType(Of MiForm)().FirstOrDefault 'Busca el formulario en la coleccion

        If formulario Is Nothing Then

            formulario = New MiForm()
            formulario.TopLevel = False

            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill

            panel_contenedor.Controls.Add(formulario)
            panel_contenedor.Tag = formulario

            formulario.Show()
            formulario.BringToFront()
        Else
            formulario.BringToFront()
        End If
    End Sub

 
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim cli As New Clientes(_usu)
        cli.Show()
        'btnClientes.BackColor = Color.FromArgb(0, 122, 204)
    End Sub

    Private Sub btnCorreo_Click(sender As Object, e As EventArgs) Handles btnCorreo.Click
        abrirFormenPanel(Of CorreoElectronico)()
        'btnCorreo.BackColor = Color.FromArgb(0, 122, 204)
    End Sub

    Private Sub btnEntradas_Click(sender As Object, e As EventArgs) Handles btnEntradas.Click
        Dim entr As New Entradas(_usu)
        entr.Show()
        'btnEntradas.BackColor = Color.FromArgb(0, 122, 204)
    End Sub

    Private Sub btnEquipos_Click(sender As Object, e As EventArgs) Handles btnEquipos.Click
        Dim crear As New CrearEquipos(_usu)
        crear.Show()
        'btnEquipos.BackColor = Color.FromArgb(0, 122, 204)
    End Sub

    Private Sub crear_grupo_tsmi_Click(sender As Object, e As EventArgs) Handles crear_grupo_tsmi.Click
        Dim cg As New Crear_Grupos
        cg.Show()
    End Sub


    Private Sub grupos_usuarios_tsmi_Click(sender As Object, e As EventArgs) Handles grupos_usuarios_tsmi.Click
        Dim gu As New Grupos_Usuarios
        gu.Show()
    End Sub
    Private Sub grupos_permisos_tsmi_Click(sender As Object, e As EventArgs) Handles grupos_permisos_tsmi.Click
        Dim gp As New Grupos_Permisos
        gp.Show()
    End Sub

    Private Sub BtnSede_Click(sender As Object, e As EventArgs) Handles btnSede.Click
        Dim sede As New Sedes(_usu)
        sede.Show()
        'btnSede.BackColor = Color.FromArgb(0, 122, 204)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Dim usus As New Usuarios(_usu)
        usus.Show()
        'btnUsuarios.BackColor = Color.FromArgb(0, 122, 204)
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim vent As New Ventas(_usu)
        vent.Show()
        'btnVentas.BackColor = Color.FromArgb(0, 122, 204)
    End Sub

    'SALIDA DEL PROGRAMA, VUELTA AL LOGIN
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Try

            Dim cerrar As DialogResult

            cerrar = MessageBox.Show("¿Seguro que desea salir del programa?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (cerrar = DialogResult.OK) Then
                Close()
                Dim log As New Login
                log.Show()
                Hide()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try
    End Sub

    Private Sub tmHora_Tick(sender As Object, e As EventArgs) Handles tmHora.Tick
        LblHora_Actual.Text = TimeOfDay
        lblFecha.Text = DateString
    End Sub

    Private Sub Panel_arriba_Paint(sender As Object, e As PaintEventArgs) Handles Panel_arriba.Paint
        tmHora.Start()
        Dim log_usu As New Login

        lblUsuario.Text = _usu.ToString
    End Sub


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activar()
    End Sub

    Public Sub activar()

        Dim fun As New fusuario
        Dim dts As New vusuario
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim tabla As DataTable


        tabla = dts.npermisos(_usu)
        j = tabla.Rows.Count

        btnClientes.Enabled = False
        btnVentas.Enabled = False
        btnEntradas.Enabled = False

        btnEquipos.Enabled = False
        btnCorreo.Enabled = False

        crear_grupo_tsmi.Enabled = False
        grupos_permisos_tsmi.Enabled = False
        grupos_usuarios_tsmi.Enabled = False
        btnSede.Enabled = False
        btnUsuarios.Enabled = False


        Do While (i < j)

            If tabla.Rows(i)("permisos").ToString.Equals("Ventas") Then btnVentas.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Entradas") Then btnEntradas.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Clientes") Then btnClientes.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Equipos") Then btnEquipos.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Correo") Then btnCorreo.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Sedes") Then btnSede.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Usuarios") Then btnUsuarios.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Grupos") Then crear_grupo_tsmi.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Grupos_usuarios") Then grupos_usuarios_tsmi.Enabled = True
            If tabla.Rows(i)("permisos").ToString.Equals("Grupos_permisos") Then grupos_permisos_tsmi.Enabled = True

            i = (i + 1)
        Loop

    End Sub

  
    Private Sub PbSlide_Click(sender As Object, e As EventArgs) Handles PbSlide.Click
        Try
            If Paneles.Width = 220 Then
                Panel_arriba.Left = 20
                Paneles.Width = 60
            Else
                Paneles.Width = 220
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub panel_contenedor_Paint(sender As Object, e As PaintEventArgs) Handles panel_contenedor.Paint

    End Sub
End Class