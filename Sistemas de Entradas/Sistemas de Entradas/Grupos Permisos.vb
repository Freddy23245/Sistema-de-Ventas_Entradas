Imports Capa_Logica

Public Class Grupos_Permisos

    Dim x, y As Integer
    Dim mover_per As Boolean
    Dim dt As New DataTable

    Private Sub Grupos_Permisos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        Dim cargaGrupos As New fgrupo_permiso
        Dim cargaPermisos As New fgrupo_permiso
        mostrarGP()
        cbx_grupos.DataSource = cargaGrupos.mostrar_grupos
        cbx_grupos.DisplayMember = "nom_grupo"
        cbx_grupos.ValueMember = "id_grupo"

        cbx_permisos.DataSource = cargaPermisos.mostrar_permisos
        cbx_permisos.DisplayMember = "descripcion"
        cbx_permisos.ValueMember = "id_permiso"

        


        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Public Sub mostrarGP()
        Dim funpro As New fgrupo_permiso

        dt = funpro.mostrar_GP 'muestro la tabla mediante el dataTable
        dt_permisos.DataSource = dt 'declaro para que se muestren los campos en el dataGried
    End Sub

    Private Sub btnCerrar_permiso_Click(sender As Object, e As EventArgs) Handles btnCerrar_permiso.Click
        Try

            Dim can_pr As DialogResult

            can_pr = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_pr = DialogResult.OK) Then

                Close()
            End If

        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try




    End Sub

    Private Sub Grupo_Permisos_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_per Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grupo_Permisos_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_per = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grupo_Permisos_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_per = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_aplicar_Click(sender As Object, e As EventArgs) Handles btn_aplicar.Click
        Try
            'If Me.chk_alta.Checked = False And Me.chk_baja.Checked = False And Me.chk_modificacion.Checked = False Then
            '    Throw New Exception("No ha marcado ningún permiso")
            'End If
          

            Dim func As New fgrupo_permiso
            Dim dts As New vgrupo_permiso

            dts.id_grupo = cbx_grupos.SelectedValue
            dts.id_permiso = cbx_permisos.SelectedValue
            dts.alta = chk_alta.Checked
            dts.baja = chk_baja.Checked
            dts.modificacion = chk_modificacion.Checked


            If func.insertar_permisos(dts) Then

                MessageBox.Show("El Permiso Fue Asignado Correctamente", "Asignacion de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                mostrarGP()
            Else
                MessageBox.Show("El Permiso no Fue Asignado Correctamente", "Asignacion de Permisos", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

        Catch ex As Exception
            MsgBox("Error al asignar")
        End Try
    End Sub

    'Private Sub btn_quitar_permisos_Click(sender As Object, e As EventArgs)

    '    Dim dts As New vgrupo_permiso
    '    Dim fun_usu As New fgrupo_permiso

    '    dts.id_grupo = cbx_grupos.SelectedValue
    '    dts.id_permiso = cbx_permisos.SelectedValue
    '    'dts.alta = chk_alta.Checked
    '    'dts.baja = chk_baja.Checked
    '    'dts.modificacion = chk_modificacion.Checked


    '    If fun_usu.eliminar_permisos(dts) Then
    '        MessageBox.Show("Se ha eliminado correctamente")
    '        mostrarGP()
    '    Else
    '        MessageBox.Show("No se ha podido eliminar")
    '    End If





    'End Sub

    Private Sub dt_permisos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_permisos.CellContentClick
        Try
            Dim dgv As DataGridViewRow = dt_permisos.Rows(e.RowIndex)
            lbl_usuario.Text = dgv.Cells(0).Value
            cbx_grupos.Text = dgv.Cells(1).Value
            cbx_permisos.Text = dgv.Cells(2).Value
            chk_alta.Checked = dgv.Cells(3).Value
            chk_baja.Checked = dgv.Cells(4).Value
            chk_modificacion.Checked = dgv.Cells(5).Value
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btn_eliminar_permisos_Click(sender As Object, e As EventArgs) Handles btn_eliminar_permisos.Click
        Dim dts As New vgrupo_permiso
        Dim fun_usu As New fgrupo_permiso

        dts.id_grupo = cbx_grupos.SelectedValue
        dts.id_permiso = cbx_permisos.SelectedValue
        'dts.alta = chk_alta.Checked
        'dts.baja = chk_baja.Checked
        'dts.modificacion = chk_modificacion.Checked


        If fun_usu.eliminar_permisos(dts) Then
            MessageBox.Show("Se ha eliminado correctamente")
            mostrarGP()
        Else
            MessageBox.Show("No se ha podido eliminar")
        End If
    End Sub

    Private Sub cbx_permisos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbx_permisos.SelectedIndexChanged
        If cbx_permisos.Text = "Correo" Then
            chk_alta.Enabled = False
            chk_baja.Enabled = False
            chk_modificacion.Enabled = False
        ElseIf cbx_permisos.Text = "Grupos_usuarios" Then
            chk_alta.Enabled = False
            chk_baja.Enabled = False
            chk_modificacion.Enabled = False
        ElseIf cbx_permisos.Text = "Grupos_permisos" Then
            chk_alta.Enabled = False
            chk_baja.Enabled = False
            chk_modificacion.Enabled = False
        ElseIf cbx_permisos.Text = "Grupos" Then
            chk_alta.Enabled = False
            chk_baja.Enabled = False
            chk_modificacion.Enabled = False
        Else
            chk_alta.Enabled = True
            chk_baja.Enabled = True
            chk_modificacion.Enabled = True
        End If
       
    End Sub

End Class