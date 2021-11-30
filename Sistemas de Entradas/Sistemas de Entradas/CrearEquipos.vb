Imports Capa_Logica
Imports System.Data.SqlClient

Public Class CrearEquipos

    Dim fun As New fEquipos
    Dim dt As New DataTable
    Dim x, y As Integer
    Dim mover_equipo As Boolean
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

    Private Sub CrearEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EntradasDataSet.Equipos' Puede moverla o quitarla según sea necesario.
        'Me.EquiposTableAdapter.Fill(Me.EntradasDataSet.Equipos)

        dgv_equipos.AllowUserToAddRows = False
        dgv_equipos.AllowUserToDeleteRows = False

        dgv_equipos.Columns.Item("Eliminar").Visible = False
        activar_team()
        Try

            Dim cargarEquipos As New fEquipos

            cmbEquipos.DataSource = cargarEquipos.verEquipos()
            cmbEquipos.DisplayMember = "nombre_equipo"
            cmbEquipos.ValueMember = "id_equipo"

            mostrarEquipos()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub activar_team()

        Dim fun As New fusuario
        Dim dts As New vusuario
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim tabla As DataTable


        tabla = dts.nbotones(_usu)
        j = tabla.Rows.Count

        btnReg_equipo.Enabled = False
        btnEliminar.Enabled = False
        btnModificar.Enabled = False
        For i = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i)("descripcion") = "Equipos" Then

                If tabla.Rows(i)("alta") = "True" Then btnReg_equipo.Enabled = True
                If tabla.Rows(i)("baja") = "True" Then btnEliminar.Enabled = True
                If tabla.Rows(i)("modifica") = "True" Then btnModificar.Enabled = True
            End If


        Next

    End Sub
    'EVENTOS PARA ARRASTRAR EL FORM
    Private Sub CrearEquipos_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_equipo = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CrearEquipos_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_equipo Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CrearEquipos_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_equipo = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_equipos_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_equipos.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_equipo = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_equipos_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_equipos.MouseMove
        Try

            If mover_equipo Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_equipos_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_equipos.MouseUp
        Try
            mover_equipo = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '------------------------------------------------------------------------------------------------

    Private Sub mostrarEquipos()
        Try
            Dim funE As New fEquipos
            dt = funE.verEquipos()

            dgv_equipos.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub cmbEquipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEquipos.SelectedIndexChanged

        cmbEquipos.Text = "Seleccione un equipo"

        Try
            If cmbEquipos.DisplayMember <> "" And cmbEquipos.ValueMember <> "" Then
                lblId_equipo.Text = cmbEquipos.SelectedValue
                txtEquip_sel.Text = cmbEquipos.SelectedItem(cmbEquipos.DisplayMember)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            If lblId_equipo.Text = "" Then
                MessageBox.Show("Seleccione al Equipo quiera Editar", "Crear Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim fun_Eq As New fEquipos
                Dim dts As New vEquipos

                dts.idEquipo = lblId_equipo.Text
                dts.nombEquipo = txtEquip_sel.Text
                Dim ms As New IO.MemoryStream()
                If Not PbEscudo.Image Is Nothing Then
                    PbEscudo.Image.Save(MS, PbEscudo.Image.RawFormat)
                Else
                    PbEscudo.Image = My.Resources.file
                    PbEscudo.Image.Save(MS, PbEscudo.Image.RawFormat)
                End If
                dts.imagen = MS.GetBuffer


                If fun_Eq.editar_equipos(dts) Then
                    MessageBox.Show("Se ha modificado correctamente")
                    limpiar_equipo()
                    mostrarEquipos()
                Else
                    MessageBox.Show("No se ha podido modificar")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If lblId_equipo.Text = "" Then
                MessageBox.Show("Seleccione el Equipo que quiere eliminar", "Creando Equipos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim resultado As DialogResult

                resultado = MessageBox.Show("¿Realmente desea eliminar los equipos de la base?", "Consulta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then


                    For Each row As DataGridViewRow In dgv_equipos.Rows
                        Dim marcador As Boolean = Convert.ToBoolean(row.Cells("Eliminar").Value)

                        If marcador Then
                            Dim unClick As Integer = Convert.ToInt32(row.Cells("id_equipo").Value)
                            Dim dts As New vEquipos
                            Dim fun_equipo As New fEquipos

                            dts.idEquipo = unClick

                            If fun_equipo.eliminar_equipos(dts) Then

                            Else
                                MessageBox.Show("No se ha podido eliminar")
                            End If
                        End If
                    Next

                    MessageBox.Show("Se ha eliminado correctamente")

                    mostrarEquipos()
                    limpiar_equipo()

                End If
            End If
        Catch ex As Exception
            MsgBox("Error en: " & ex.Message)
        End Try
        'Try
    End Sub

    Public Sub limpiar_equipo()
        Try
            lblId_equipo.Text = ""
            cmbEquipos.SelectedIndex = 0
            txtEquip_sel.Clear()
            txtNuevo_equipo.Clear()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            cmbEquipos.Text = "Seleccione un Equipo"
            txtEquip_sel.Clear()
            txtNuevo_equipo.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnReg_equipo_Click(sender As Object, e As EventArgs) Handles btnReg_equipo.Click

        If Me.ValidateChildren = True And txtNuevo_equipo.Text <> "" Then
            Try
                Dim fun_ne As New fEquipos
                Dim dts As New vEquipos

                dts.nombEquipo = txtNuevo_equipo.Text

                Dim ms As New IO.MemoryStream()

                If Not PbEscudo.Image Is Nothing Then
                    PbEscudo.Image.Save(ms, PbEscudo.Image.RawFormat)
                Else
                    PbEscudo.Image = My.Resources.file
                    PbEscudo.Image.Save(ms, PbEscudo.Image.RawFormat)
                End If
                dts.imagen = ms.GetBuffer

                If fun_ne.insertar_equipos(dts) Then
                    MessageBox.Show("Se ha agregado correctamente")
                    limpiar_equipo()
                    mostrarEquipos()
                Else
                    MessageBox.Show("No se ha podido agregado")
                End If

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe ingresar un nombre del equipo", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub dgv_equipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_equipos.CellClick
        Try
            lblId_equipo.Text = dgv_equipos.SelectedCells.Item(1).Value.ToString
            txtEquip_sel.Text = dgv_equipos.SelectedCells.Item(2).Value.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgv_equipos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_equipos.CellContentClick
        Try
            Dim dgv As DataGridViewRow = dgv_equipos.Rows(e.RowIndex)
            Dim contador As Integer

            If e.ColumnIndex = dgv_equipos.Columns.Item("Eliminar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = dgv_equipos.Rows(e.RowIndex).Cells("Eliminar")
                chkcell.Value = Not chkcell.Value
            End If

            lblId_equipo.Text = dgv.Cells(1).Value
            cmbEquipos.Text = dgv.Cells(2).Value

            PbEscudo.BackgroundImage = Nothing
            Dim i() As Byte = dgv_equipos.SelectedCells.Item(3).Value
            Dim ms As New IO.MemoryStream(i)
            PbEscudo.Image = Image.FromStream(ms)
            PbEscudo.SizeMode = PictureBoxSizeMode.StretchImage

            For Each row As DataGridViewRow In dgv_equipos.Rows
                If row.Cells("Eliminar").Value = True Then
                    contador = contador + 1
                End If
            Next
            LblSeleccionar_equipos.Text = contador

        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub buscar_equipo()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre_equipo like'" & txtEquip_sel.Text & "%'"

            If dv.Count <> 0 Then
                dgv_equipos.DataSource = dv
            Else
                dgv_equipos.DataSource = Nothing
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnMostrar_equipos_Click(sender As Object, e As EventArgs) Handles btnMostrar_equipos.Click
        Try
            mostrarEquipos()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExplorar_Click(sender As Object, e As EventArgs) Handles btnExplorar.Click
        Try
            Dim file As New OpenFileDialog

            file.Filter = "Imagenes JPG|* .jpg|Imagenes PNG|* .png"

            If file.ShowDialog = Windows.Forms.DialogResult.OK Then
                PbEscudo.Image = Image.FromFile(file.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub txtNuevo_equipo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtNuevo_equipo.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorEquipo.SetError(sender, "")
            Else
                ErrorEquipo.SetError(sender, "Es obligatorio que ingrese el nombre del equipo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_equip_Click(sender As Object, e As EventArgs) Handles btnCerrar_equip.Click
        Try

            Dim can_eq As DialogResult

            can_eq = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_eq = DialogResult.OK) Then

                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try
    End Sub

    Private Sub chkbSel_equip_CheckedChanged(sender As Object, e As EventArgs) Handles chkbSel_equip.CheckedChanged
        Try
            If chkbSel_equip.CheckState = CheckState.Checked Then
                dgv_equipos.Columns.Item("Eliminar").Visible = True
                LblSeleccionar_equipos.Visible = True
            Else
                dgv_equipos.Columns.Item("Eliminar").Visible = False
                LblSeleccionar_equipos.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtEquip_sel_TextChanged(sender As Object, e As EventArgs) Handles txtEquip_sel.TextChanged
        Try
            buscar_equipo()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class