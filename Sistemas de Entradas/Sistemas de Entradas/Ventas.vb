Imports Capa_Logica

Public Class Ventas
    Dim func As New fVenta
    Dim dts As New vventas
    Dim dt As New DataTable


    Dim x, y As Integer
    Dim mover_ventas As Boolean

    Private _usu As String


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

    Private Sub btnbuscar_cliente_Click(sender As Object, e As EventArgs) Handles btnbuscar_cliente.Click
        Dim xcli As New Clientes(_usu)
        xcli.btn_agregar.Visible = False
        xcli.btn_editar.Visible = False
        xcli.btn_eliminar.Visible = False
        xcli.PbEditar_cli.Visible = False
        xcli.PbEliminar_cli.Visible = False
        xcli.PbGuardar_cli.Visible = False
        xcli.PbLimpiar_cli.Visible = False
        xcli.btnLimpiar.Visible = False
        xcli.txt_flag.Text = "1"
        xcli.ShowDialog()

        LblId_Cliente.Text = xcli.lblCodCli.Text
        LblNombre_cli.Text = xcli.txt_nombre.Text & " " & xcli.txt_apellido.Text

        xcli.Dispose()
    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbTipo_pago.Items.Add("Tarjeta")
        cmbTipo_pago.Items.Add("Efectivo")
        mostrar()
        activar_vent()
       

    End Sub


    'EVENTOS PARA ARRASTRAR EL FORM
    Private Sub Ventas_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_ventas = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ventas_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_ventas Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Ventas_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_ventas = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_ventas_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_ventas.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_ventas = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_ventas_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_ventas.MouseMove
        Try

            If mover_ventas Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_ventas_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_ventas.MouseUp
        Try
            mover_ventas = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '------------------------------------------------------------------------------------------------
    Public Sub activar_vent()

        Dim fun As New fusuario
        Dim dts As New vusuario
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim tabla As DataTable
        Dim dtv As New Detalle_de_Venta

        tabla = dts.nbotones(_usu)
        j = tabla.Rows.Count

        btn_agregar.Enabled = False

        btn_eliminar.Enabled = False

        btn_editar.Enabled = False

        For i = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i)("descripcion") = "Ventas" Then

                If tabla.Rows(i)("alta") = "True" Then btn_agregar.Enabled = True
                dtv.btn_agregar.Enabled = True
                dtv.btn_generar_comporbante.Enabled = True
                If tabla.Rows(i)("baja") = "True" Then btn_eliminar.Enabled = True
                dtv.btn_eliminar.Enabled = True
                If tabla.Rows(i)("modifica") = "True" Then btn_editar.Enabled = True
            End If

        Next
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fVenta
            dt = func.mostrar_venta

            dt_ventas.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Public Sub cargar_detalle()
        Detalle_de_Venta.lblId_venta = dt_ventas.SelectedCells.Item(0).Value
        Detalle_de_Venta.txt_id_cliente = dt_ventas.SelectedCells.Item(1).Value
        Detalle_de_Venta.txt_nombre_cliente = dt_ventas.SelectedCells.Item(2).Value
        Detalle_de_Venta.txtfecha = dt_ventas.SelectedCells.Item(3).Value
        Detalle_de_Venta.cbx_tipo_pago = dt_ventas.SelectedCells.Item(4).Value

        Detalle_de_Venta.ShowDialog()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If LblId_Cliente.Text = String.Empty And LblNombre_cli.Text = String.Empty And cmbTipo_pago.SelectedItem = "" Then
            MessageBox.Show("Faltan  Datos")
        ElseIf LblId_Cliente.Text = String.Empty Or LblNombre_cli.Text = String.Empty Or cmbTipo_pago.SelectedItem = "" Then
            MessageBox.Show("Faltan Agunos Datos")
        Else
            Try
                Dim func As New fVenta
                Dim dts As New vventas

                dts.id_cliente = LblId_Cliente.Text
                dts.fecha = txtfecha.Text
                dts.tipo_pago = cmbTipo_pago.Text



                If func.insertar_venta(dts) Then
                    MessageBox.Show("La Venta Fue Generada Correctamente", "Guardando Entradas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()

                Else
                    MessageBox.Show("La Venta no fue registrada", "Guardando Entradas", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

      
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Lbl_idVenta.Text = "" Then
            MessageBox.Show("Por favor seleccione la venta que desea eliminar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim fun As New fVenta
                Dim dts As New vventas

                dts.id_venta = Lbl_idVenta.Text

                If fun.eliminar_venta(dts) Then

                    MessageBox.Show("La venta Fue Eliminada Correctamente", "Eliminar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    mostrar()
                Else
                    MessageBox.Show("La venta No Fue Eliminada ", "Eliminar Ventas", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If

            Catch ex As Exception
                MsgBox("Error en eliminar")
            End Try
        End If
    End Sub


    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If Lbl_idVenta.Text = "" Then
            MessageBox.Show("Por favor seleccione la venta que desea eliminar", "Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim result As DialogResult

            result = MessageBox.Show("Realmente desea editar los datos de la venta?", "Modificando registros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then

                Try
                    Dim dts As New vventas
                    Dim func As New fVenta

                    dts.id_venta = Lbl_idVenta.Text
                    dts.id_cliente = LblId_Cliente.Text
                    dts.fecha = txtfecha.Text
                    dts.tipo_pago = cmbTipo_pago.Text
                    dts.num_venta = txt_num_comprobamte.Text


                    If func.editar_venta(dts) Then
                        MessageBox.Show("venta Modificada correctamente", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()

                    Else
                        MessageBox.Show("Venta no fue modifcada intente de nuevo", "Modificando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()

                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Falta ingresar algunos datos", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dt_ventas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_ventas.CellDoubleClick

        Dim dgv As DataGridViewRow = dt_ventas.Rows(e.RowIndex)
        Dim dv As New Detalle_de_Venta(_usu)
        dv.lblId_venta.Text = dgv.Cells(0).Value
        dv.txt_id_cliente.Text = dgv.Cells(1).Value
        dv.txt_nombre_cliente.Text = dgv.Cells(2).Value
        dv.txtfecha.Text = dgv.Cells(3).Value
        dv.cbx_tipo_pago.Text = dgv.Cells(4).Value
        dv.txt_num_comprobamte.Text = dgv.Cells(5).Value

        dv.ShowDialog()
        Close()
    End Sub

    Private Sub dt_ventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_ventas.CellContentClick

        Dim dgv As DataGridViewRow = dt_ventas.Rows(e.RowIndex)

        Lbl_idVenta.Text = dgv.Cells(0).Value
        LblId_Cliente.Text = dgv.Cells(1).Value
        LblNombre_cli.Text = dgv.Cells(2).Value
        cmbTipo_pago.Text = dgv.Cells(4).Value
        txt_num_comprobamte.Text = dgv.Cells(5).Value
    End Sub

    Private Sub btnCancelar_ventas_click(sender As Object, e As EventArgs)
        Try

            Dim can_ven As DialogResult

            can_ven = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_ven = DialogResult.OK) Then

                Close()

            End If

        Catch ex As Exception

            MsgBox(ex.StackTrace)

        End Try

    End Sub

    Private Sub btnNueva_venta_Click(sender As Object, e As EventArgs) Handles btnNueva_venta.Click
        Try
            Lbl_idVenta.Text = ""
            LblId_Cliente.Text = ""
            LblNombre_cli.Text = ""
            cmbTipo_pago.SelectedIndex = -1
            txt_num_comprobamte.Clear()
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_ventas_Click(sender As Object, e As EventArgs) Handles btnCerrar_ventas.Click
        Try

            Dim can_ven As DialogResult

            can_ven = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_ven = DialogResult.OK) Then

                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try


    End Sub

End Class