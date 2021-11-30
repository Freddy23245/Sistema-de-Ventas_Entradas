Imports Capa_Logica
Imports Capa_Datos
Imports System.Data.SqlClient
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing.Image
Public Class Entradas
    'Dim con As New SqlConnection("Data Source=BOCA_JUNIORS;Initial Catalog=Entradas;Integrated Security=true")
    'Private dibujos(25) As Image 'se crea un array con indice hasta 26, total de equipos de tipo Imagen
    'Private escudos As Escudos 'se crea una variable escudos de tipo clase numerica Escudos
    Dim fun As New fentradas
    Dim dt As New DataTable

    Dim x, y As Integer
    Dim mover_ent As Boolean

    Private _usu As String

    Public Property id_entrada As Integer
    Public Property nom_entrada As String
    Public Property stock_ent As Double
    Public Property precio As Double
  
    Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Sub New(usu As String)
        Me.New()
        ' TODO: Complete member initialization 
        _usu = usu
    End Sub


    Private Sub Entradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        activar()
        dt_entradas.AllowUserToAddRows = False
        dt_entradas.AllowUserToDeleteRows = False

        Dim cargaGrupos As New fentradas
        Dim cargaPermisos As New fentradas

        cbx_local.DataSource = cargaGrupos.mostrar_equipos()
        cbx_local.DisplayMember = "nombre_equipo"
        cbx_local.ValueMember = "id_equipo"

        cbx_visitante.DataSource = cargaPermisos.mostrar_equipos()
        cbx_visitante.DisplayMember = "nombre_equipo"
        cbx_visitante.ValueMember = "id_equipo"

        mostrar()
    End Sub

    'EVENTOS PARA ARRASTRAR EL FORM
    Private Sub Panel_topEntradas_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_topEntradas.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_ent = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_topEntradas_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_topEntradas.MouseMove
        Try

            If mover_ent Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_topEntradas_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_topEntradas.MouseUp
        Try
            mover_ent = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Entradas_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_ent Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Entradas_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_ent = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Entradas_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_ent = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub activar()
        Dim fun As New fusuario
        Dim dts As New vusuario
    
        Dim tabla As DataTable
       
        tabla = dts.nbotones(_usu)



        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_modificar.Enabled = False


        For i = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i)("descripcion") = "Entradas" Then

                If tabla.Rows(i)("alta") = "True" Then btn_agregar.Enabled = True
                If tabla.Rows(i)("baja") = "True" Then btn_eliminar.Enabled = True
                If tabla.Rows(i)("modifica") = "True" Then btn_modificar.Enabled = True
            End If


        Next


       

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If Me.ValidateChildren = True And dtp_hora.Text <> "" And dtpFecha.Text <> "" And txt_precio.Text <> "" And
            txt_stock.Text <> "" Then

            Try
                If cbx_local.Text = "Seleccione un Equipo Local" Or cbx_visitante.Text = "Seleccione un Equipo Visitante" Then
                    MessageBox.Show("Debe elegir un equipo de la lista", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                Else
                    If cbx_local.SelectedIndex = cbx_visitante.SelectedIndex Then
                        MessageBox.Show("No puede elegir otro equipo con el mismo nombre.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Else

                        Dim func As New fentradas
                        Dim dts As New ventradas

                        dts.local = cbx_local.Text
                        dts.visitante = cbx_visitante.Text
                        dts.hora = dtp_hora.Value
                        dts.fecha = dtpFecha.Value
                        dts.precio = txt_precio.Text
                        dts.stock = txt_stock.Text
                        dts.id_sede = lblId_sede.Text

                        If func.agregarEnt(dts) Then
                            MessageBox.Show("Se ha agregado correctamente")
                            mostrarE()
                        Else
                            MessageBox.Show("No se ha podido agregado")
                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar datos de la Entrada", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub mostrarE()
        Try
            Dim func As New fentradas
            dt = func.mostrar_entradas

            dt_entradas.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub





    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            If lblId_entrada.Text = "" Then
                MessageBox.Show("Seleccione a al entrada que quiere editar")
            Else
                Dim func As New fentradas
                Dim dts As New ventradas

                dts.id_entradas = lblId_entrada.Text
                
                dts.hora = dtp_hora.Value.ToString
                dts.fecha = dtpFecha.Value.ToString("yyyy-MM-dd")
                dts.precio = CDbl(txt_precio.Text)
                dts.stock = CInt(txt_stock.Text)
                dts.id_sede = lblId_sede.Text

                If func.editarEntrada(dts) Then
                    MessageBox.Show("Se ha modificado correctamente")
                    mostrarE()
                Else
                    MessageBox.Show("No se ha podido modificar")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: " & ex.Message)
        End Try

    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fentradas
            dt = func.mostrar_entradas

            dt_entradas.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If lblId_entrada.Text = "" Then
                MessageBox.Show("Seleccione a la entrada que quiere eliminar")
            Else
                Dim funEliminar As New fentradas
                Dim dts As New ventradas

                dts.id_entradas = lblId_entrada.Text
                dts.id_sede = lblId_sede.Text

                If funEliminar.eliminarEntradas(dts) Then
                    MessageBox.Show("Se ha eliminado correctamente")
                    mostrarE()
                Else
                    MessageBox.Show("No se ha podido eliminar")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: " & ex.Message)
        End Try
    End Sub
    Private Sub dt_entradas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_entradas.CellContentClick
        Try

            Dim dgv As DataGridViewRow = dt_entradas.Rows(e.RowIndex)

            lblId_entrada.Text = dgv.Cells(0).Value
            lblId_sede.Text = dgv.Cells(1).Value
            txt_nombre_sede.Text = dgv.Cells(5).Value
            dtpFecha.Text = dgv.Cells(4).Value
            txt_precio.Text = dgv.Cells(6).Value
            txt_stock.Text = dgv.Cells(7).Value

        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub btnbuscar_producto_Click(sender As Object, e As EventArgs) Handles btnbuscar_producto.Click

        Dim xsedes As New Sedes(_usu)
        xsedes.txtflag.Text = "1"
        xsedes.ShowDialog()

        lblId_sede.Text = xsedes.LblId_sede.Text
        txt_nombre_sede.Text = xsedes.nom_sede

        xsedes.Dispose()

    End Sub

    Private Sub dt_entradas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_entradas.CellDoubleClick
        Dim dgv As DataGridViewRow = dt_entradas.Rows(e.RowIndex)
        If txt_flag.Text = "1" Then
            id_entrada = dgv.Cells(0).Value

            nom_entrada = dgv.Cells(2).Value
            precio = dgv.Cells(6).Value
            stock_ent = dgv.Cells(7).Value
            Hide()

        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Try
            lblId_entrada.Text = ""
            lblId_sede.Text = ""
            txt_nombre_sede.Clear()
            cbx_local.SelectedIndex = -1
            cbx_visitante.SelectedIndex = -1
            txt_precio.Clear()
            txt_stock.Clear()
            txt_flag.Clear()
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub


    '-------------------------------Validación de Campos de la Clase Clientes-------------------------------------


    Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
        Try
            If DirectCast(sender, DateTimePicker).Text.Length > 0 Then
                ErrorEntradas.SetError(sender, "")
            Else
                ErrorEntradas.SetError(sender, "Es obligatorio que ingrese la fecha estipulada del Partido")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            Me.ErrorEntradas.SetError(sender, "solo acepta numero")
        End If
    End Sub
    Private Sub txt_precio_Validated(sender As Object, e As EventArgs) Handles txt_precio.Validated
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorEntradas.SetError(sender, "")
            Else
                ErrorEntradas.SetError(sender, "Es obligatorio que ingrese un precio")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_stock_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_stock.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            Me.ErrorEntradas.SetError(sender, "solo acepta numero")
        End If
    End Sub

    Private Sub txt_stock_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_stock.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorEntradas.SetError(sender, "")
            Else
                ErrorEntradas.SetError(sender, "Es obligatorio que ingrese el stock de ventas disponibles")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbx_visitante_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles cbx_visitante.Validating
        Try
            If DirectCast(sender, ComboBox).DisplayMember = cbx_local.DisplayMember Then
                ErrorEntradas.SetError(sender, "")
            Else
                ErrorEntradas.SetError(sender, "")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_ent_Click(sender As Object, e As EventArgs) Handles btnCerrar_ent.Click
        Try

            Dim can_ent As DialogResult

            can_ent = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_ent = DialogResult.OK) Then

                Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub cbx_visitante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_visitante.SelectedIndexChanged
        cbx_visitante.Text = "Seleccione un Equipo Visitante"
    

    End Sub

    Private Sub cbx_local_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_local.SelectedIndexChanged
        cbx_local.Text = "Seleccione un Equipo Local"

    End Sub

    Private Sub dt_entradas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dt_entradas.CellFormatting
        If (Me.dt_entradas.Columns(e.ColumnIndex).Name = "stock") Then
            If (Convert.ToInt32(e.Value) <= 10) Then
                e.CellStyle.ForeColor = Color.Black
                e.CellStyle.BackColor = Color.Red

            End If
        End If
    End Sub
End Class