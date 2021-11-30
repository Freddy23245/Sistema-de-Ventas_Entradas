Imports Capa_Logica
Public Class Detalle_de_Venta

    Dim func As New fdetalle_venta
    Dim dts As New vdetalle_venta
    Dim dt As New DataTable

    Dim x, y As Integer
    Dim mover_det As Boolean
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

    Private Sub btnbuscar_producto_Click(sender As Object, e As EventArgs) Handles btnbuscar_producto.Click
        Dim ent As New Entradas(_usu)
        ent.btn_agregar.Visible = False
        ent.btn_modificar.Visible = False
        ent.btn_eliminar.Visible = False
        ent.pb_agregarEnt.Visible = False
        ent.Pbeditar_ent.Visible = False
        ent.PbEliminar_ent.Visible = False
        ent.txt_flag.Text = "1"
        ent.ShowDialog()

        lbl_Id_Entrada.Text = ent.id_entrada
        lbl_nombreEntrada.Text = ent.nom_entrada
        txtstock.Text = ent.stock_ent
        txt_precio.Text = ent.precio
        ent.Dispose()
       
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        If Me.ValidateChildren = True And lbl_Id_Entrada.Text <> "" And txtcantidad.Text <> "" And txt_precio.Text <> "" Then
            Try
                If txtcantidad.Text = "0" Then
                    MessageBox.Show("La Cantidad Tiene que ser Superior a Cero", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    Dim cant As Double

                    cant = txtcantidad.Value

                    If txtcantidad.Value > txtstock.Value Then
                        MessageBox.Show("La cantidad que Intenta Vender Supera Stock", "Error al vender el producto", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        txtcantidad.Value = txtstock.Value
                    Else
                        Dim dts As New vdetalle_venta
                        Dim func As New fdetalle_venta

                        dts.id_venta = lblId_venta.Text
                        dts.id_entrada = lbl_Id_Entrada.Text
                        dts.cantidad = txtcantidad.Text
                        dts.precio = txt_precio.Text

                        If func.insertar_detalle_venta(dts) Then
                            If func.disminuir_stock(dts) Then

                            End If
                            MessageBox.Show("La entrada fue añadido correctamente a la venta", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()

                        Else
                            MessageBox.Show("La entrada fue añadido correctamente a la venta intente de nuevo", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            mostrar()

                        End If
                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar algunos datos", "Guardando registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try

            If lblId_detalle_venta.Text = "" Then
                MessageBox.Show("Seleccione al detalle de Venta a eliminar")
            Else
                Dim result As DialogResult

                result = MessageBox.Show("Realmente desea quitar la Entrada de la venta?", "Eliminando Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

                If result = DialogResult.OK Then

                    Dim func As New fdetalle_venta
                    Dim dts As New vdetalle_venta

                    dts.id_detalle_venta = lblId_detalle_venta.Text
                    dts.id_entrada = lbl_Id_Entrada.Text
                    dts.id_venta = lblId_venta.Text
                    dts.cantidad = txtcantidad.Text

                    If func.eliminar_detalle_venta(dts) Then
                        If func.aumentar_stock(dts) Then
                            MessageBox.Show("La Entrada fue quitada de la venta", "Eliminando Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                        End If
                    Else
                        MessageBox.Show("La Entrada no fue quitado de la venta", "Eliminando Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mostrar()
        Try
            Dim func As New fdetalle_venta
            dt = func.mostrar_detalle_venta
            dt_detalle_venta.DataSource = dt
            ocultar_columnas()


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        mostrar_detalle_unico()
    End Sub
    Private Sub mostrar_detalle_unico()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))


            dv.RowFilter = "id_venta='" & lblId_venta.Text & "'"

            If dv.Count <> 0 Then

                dt_detalle_venta.DataSource = dv
                ocultar_columnas()

            Else

                dt_detalle_venta.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Private Sub ocultar_columnas()
        't_detalle_venta.Columns(0).Visible = False
        'dt_detalle_venta.Columns(1).Visible = False
        dt_detalle_venta.Columns(2).Visible = False
    End Sub

    Private Sub Detalle_de_Venta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_generar_comporbante.Enabled = False
       


        dt_detalle_venta.AllowUserToAddRows = False
        dt_detalle_venta.AllowUserToDeleteRows = False
        mostrar()
        activar_dtvent()
    End Sub
    Public Sub activar_dtvent()

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
        btn_generar_comporbante.Enabled = False

        For i = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i)("descripcion") = "Ventas" Then
                If tabla.Rows(i)("alta") = "True" Then btn_agregar.Enabled = True
                btn_generar_comporbante.Enabled = True

                If tabla.Rows(i)("baja") = "True" Then btn_eliminar.Enabled = True
                If tabla.Rows(i)("modifica") = "True" Then
                End If
            End If
        Next
    End Sub
    Private Sub dt_detalle_venta_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_detalle_venta.CellContentClick
        Dim dgv As DataGridViewRow = dt_detalle_venta.Rows(e.RowIndex)

        lblId_detalle_venta.Text = dgv.Cells(0).Value
        lblId_venta.Text = dgv.Cells(1).Value
        lbl_Id_Entrada.Text = dgv.Cells(2).Value
        lbl_nombreEntrada.Text = dgv.Cells(3).Value
        txtcantidad.Text = dgv.Cells(4).Value


    End Sub

    Private Sub btnCerrar_det_ven_Click(sender As Object, e As EventArgs) Handles btnCerrar_det_ven.Click
        Try

            Dim can_dv As DialogResult

            can_dv = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_dv = DialogResult.OK) Then

                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try

    End Sub

    'EVENTOS PARA ARRASTRAR EL FORM
    Private Sub Panel_det_ven_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_det_ven.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_det = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_det_ven_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_det_ven.MouseMove
        Try

            If mover_det Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_det_ven_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_det_ven.MouseUp
        Try
            mover_det = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Detalle_de_Venta_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_det = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Detalle_de_Venta_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_det Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Detalle_de_Venta_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_det = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_generar_comporbante_Click(sender As Object, e As EventArgs) Handles btn_generar_comporbante.Click
        Dim comp As New Reporte_de_Entrada
        comp.txt_cliente.Text = Me.txt_id_cliente.Text
        comp.ShowDialog()
    End Sub
End Class