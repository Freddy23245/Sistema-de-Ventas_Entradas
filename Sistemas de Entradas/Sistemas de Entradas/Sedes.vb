Imports Capa_Logica
Imports System.Data.SqlClient

Public Class Sedes

    Dim dt As New DataTable
    Dim x, y As Integer
    Dim mover_Sede As Boolean
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


    Public Property id_sede As Integer
    Public Property nom_sede As String

    Private Sub Sedes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbSede.Text = "Seleccione una columna"
        activar_Sede()
        dt_sede.AllowUserToAddRows = False
        dt_sede.AllowUserToDeleteRows = False

        dt_sede.Columns.Item("Eliminar").Visible = False
        verSedes()
    End Sub

    Public Sub activar_Sede()

        Dim fun As New fusuario
        Dim dts As New vusuario
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim tabla As DataTable


        tabla = dts.nbotones(_usu)
        j = tabla.Rows.Count

        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_modificar.Enabled = False
        For i = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i)("descripcion") = "Sedes" Then

                If tabla.Rows(i)("alta") = "True" Then btn_agregar.Enabled = True
                If tabla.Rows(i)("baja") = "True" Then btn_eliminar.Enabled = True
                If tabla.Rows(i)("modifica") = "True" Then btn_modificar.Enabled = True
            End If


        Next

    End Sub

    Public Sub verSedes()
        Dim funSe As New fSede

        dt = funSe.mostrar_sede 'muestro la tabla mediante el dataTable
        dt_sede.DataSource = dt 'declaro para que se muestren los campos en el dataGried
    End Sub

    Private Sub dt_sede_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_sede.CellClick
        Try
            LblId_sede.Text = dt_sede.SelectedCells.Item(1).Value.ToString
            txt_nom_sede.Text = dt_sede.SelectedCells.Item(2).Value.ToString
            txt_dir_sede.Text = dt_sede.SelectedCells.Item(3).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dt_sede_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_sede.CellContentClick
        Try
            Dim contar_Sede As Integer

            If e.ColumnIndex = dt_sede.Columns.Item("Eliminar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = dt_sede.Rows(e.RowIndex).Cells("Eliminar")
                chkcell.Value = Not chkcell.Value
            End If

            For Each row As DataGridViewRow In dt_sede.Rows
                If row.Cells("Eliminar").Value = True Then
                    contar_Sede = contar_Sede + 1
                End If
            Next

            LblSeleccion_sede.Text = contar_Sede

        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If Me.ValidateChildren = True And txt_nom_sede.Text <> "" And txt_dir_sede.Text <> "" Then
            Try
                Dim fsede As New fSede
                Dim dts As New vSede

                dts.nombreSede = txt_nom_sede.Text
                dts.dirSede = txt_dir_sede.Text

                If fsede.insertar_sedes(dts) Then
                    MessageBox.Show("Se ha agregado correctamente")
                    verSedes()
                ElseIf fsede.insertar_sedes(dts) Then
                    MessageBox.Show("No se ha podido agregar")
                End If
            Catch ex As Exception
                MsgBox("Error en: " & ex.Message)
            End Try

        Else
            MessageBox.Show("Faltan ingresar datos de la Sede", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        Try
            If LblId_sede.Text = "" Then
                MessageBox.Show("No se ha seleccionado ninguna sede para modificar", "Sedes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim funSede As New fSede
                Dim dts As New vSede

                dts.idSede = LblId_sede.Text
                dts.nombreSede = txt_nom_sede.Text
                dts.dirSede = txt_dir_sede.Text

                If funSede.editar_sedes(dts) Then
                    MessageBox.Show("Se ha editado correctamente")
                    verSedes()
                Else
                    MessageBox.Show("No se ha podido editar")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Try
            If LblId_sede.Text = "" Then
                MessageBox.Show("No se ha seleccionado ninguna sede para Eliminar", "Sedes", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim resultado As DialogResult

                resultado = MessageBox.Show("¿Realmente desea eliminar los clientes de la base?", "Consulta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then



                    Dim dts As New vSede
                    Dim fun_sede As New fSede

                    dts.idSede = LblId_sede.Text

                    If fun_sede.eliminar_sedes(dts) Then

                    Else
                        MessageBox.Show("No se ha podido eliminar")
                    End If
                End If

                MessageBox.Show("Se ha eliminado correctamente")

                verSedes()
                limpiarSede()
            End If
        Catch ex As Exception
            MsgBox("Error en: " & ex.Message)
        End Try
    End Sub


    Private Sub btn_nueva_sede_Click(sender As Object, e As EventArgs) Handles btn_nueva_sede.Click
        Try
            LblId_sede.Text = ""
            txt_nom_sede.Clear()
            txt_dir_sede.Clear()
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub


    Private Sub dt_sede_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_sede.CellDoubleClick
        Dim dgv As DataGridViewRow = dt_sede.Rows(e.RowIndex)

        If txtflag.Text = "1" Then
            LblId_sede.Text = dgv.Cells(1).Value.ToString
            nom_sede = dgv.Cells(2).Value.ToString
            Hide()
        End If
    End Sub

    Private Sub busqueda_sedes()
        Try
            Dim ds As New DataSet

            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cmbSede.Text & " like'" & txtBuscar_Sede.Text & "%'"

            If dv.Count <> 0 Then
                dt_sede.DataSource = dv
            Else
                dt_sede.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtBuscar_Sede_Enter(sender As Object, e As EventArgs) Handles txtBuscar_Sede.Enter
        Try
            If cmbSede.SelectedIndex = -1 Then
                MessageBox.Show("Debe elegir un ítem de la lista", "Campo Vacío!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBuscar_Sede_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_Sede.TextChanged
        busqueda_sedes()
    End Sub

    '-------------------------------Validación de Campos de la Clase Usuarios-------------------------------------

    Private Sub txt_nom_sede_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nom_sede.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorSede.SetError(sender, "")
            Else
                ErrorSede.SetError(sender, "Es obligatorio que ingrese el Nombre de la Sede")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dir_sede_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_dir_sede.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorSede.SetError(sender, "")
            Else
                ErrorSede.SetError(sender, "Es obligatorio que ingrese la Dirección de la Sede")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_sede_Click(sender As Object, e As EventArgs) Handles btnCerrar_sede.Click
        Try

            Dim can_sed As DialogResult

            can_sed = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_sed = DialogResult.OK) Then

                Close()
            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub

    'EVENTOS PARA ARRASTRAR EL FORM
    Private Sub Panel_Sede_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_Sede.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_Sede = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_Sede_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_Sede.MouseMove
        Try

            If mover_Sede Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_Sede_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_Sede.MouseUp
        Try
            mover_Sede = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '----------------------------------------------------------------------------------------------------
    Private Sub Sedes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_Sede = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sedes_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_Sede Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Sedes_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_Sede = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chkbSede_CheckedChanged(sender As Object, e As EventArgs) Handles chkbSede.CheckedChanged
        Try
            If chkbSede.CheckState = CheckState.Checked Then
                dt_sede.Columns.Item("Eliminar").Visible = True
                LblSeleccion_sede.Visible = True
            Else
                dt_sede.Columns.Item("Eliminar").Visible = False
                LblSeleccion_sede.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiarSede()
        Try
            LblId_sede.Text = ""
            txt_nom_sede.Clear()
            txt_dir_sede.Clear()
            LblSeleccion_sede.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class