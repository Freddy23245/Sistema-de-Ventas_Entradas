Imports Capa_Logica
Public Class Grupos_Usuarios

    Dim fun As New fgrupo_usuario
    Dim mover_gu As Boolean = False
    Dim x, y As Integer


    Private Sub Grupos_Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim cargaGrupos As New fgrupo_usuario
            Dim cargaPermisos As New fgrupo_usuario

            cbx_grupos.DataSource = cargaGrupos.mostrar_grupos()
            cbx_grupos.DisplayMember = "nom_grupo"
            cbx_grupos.ValueMember = "id_grupo"

            cbx_usuarios.DataSource = cargaPermisos.mostrar_usuarios()
            cbx_usuarios.DisplayMember = "usuario"
            cbx_usuarios.ValueMember = "id_usuario"
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.StackTrace)
        End Try
    End Sub

    Private Sub btn_aplicar_Click(sender As Object, e As EventArgs) Handles btn_aplicar.Click
        Try
            Dim func As New fgrupo_usuario
            Dim dts As New vgrupo_usuario

            dts.id_grupo = cbx_grupos.SelectedValue
            dts.id_usuario = cbx_usuarios.SelectedValue

            If func.insertar(dts) Then
                MessageBox.Show("El usuario fue asigando correctamente", "Asignar Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'MessageBox.Show("Error al insertar ", "Asignar Grupos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("El usuario ya se encuentra en el grupo", "Asignar Grupos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al insertar Usuarios y Grupos")
        End Try
    End Sub



    Private Sub btnCerrar_grup_usu_Click(sender As Object, e As EventArgs) Handles btnCerrar_grup_usu.Click
        Try

            Dim can_gu As DialogResult

            can_gu = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_gu = DialogResult.OK) Then

                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try

    End Sub

    Private Sub Grupos_Usuarios_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_gu Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grupos_Usuarios_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_gu = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Grupos_Usuarios_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_gu = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

  
    Private Sub btn_elinar_del_grupo_Click(sender As Object, e As EventArgs) Handles btn_elinar_del_grupo.Click
        Try
            Dim func As New fgrupo_usuario
            Dim dts As New vgrupo_usuario

            dts.id_grupo = cbx_grupos.SelectedValue
            dts.id_usuario = cbx_usuarios.SelectedValue

            If func.eliminar_grup(dts) Then
                MessageBox.Show("El usuario fue eliminado del grupo correctamente", "Quitar del Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'MessageBox.Show("Error al insertar ", "Asignar Grupos", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MessageBox.Show("El usuario ya se elimino del grupo", "Quitar Grupo", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Error al eliminar Usuarios del Grupos")
        End Try
    End Sub
End Class