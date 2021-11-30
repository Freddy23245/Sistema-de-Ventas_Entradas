Imports Capa_Logica

Public Class Crear_Grupos

    Dim x, y As Integer
    Dim mover_grupo As Boolean

    Private Sub btn_crear_Click(sender As Object, e As EventArgs) Handles btn_crear.Click
        If Me.ValidateChildren = True And txt_grupo.Text <> "" Then
            Try
                Dim funCGrup As New fGrupos
                Dim dts As New vGrupos

                dts.nombreGrupo = txt_grupo.Text

                If funCGrup.insertarGrupo(dts) Then
                    MessageBox.Show("Nuevo grupo " + dts.nombreGrupo + " agregado correctamente", "Nuevo Registro", MessageBoxButtons.OK, MessageBoxIcon.Question)
                    limpiar()
                Else
                    MessageBox.Show("No se ha podido agregar", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox("Error en: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Falta ingresar datos para la creaciòn de un nuevo grupo")
        End If
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        Try

            Dim vol As DialogResult

            vol = MessageBox.Show("¿Seguro que desea salir de la planilla de Grupos?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (vol = DialogResult.OK) Then

                Me.Close()
                Me.Hide()
            End If

        Catch ex As Exception

            MsgBox(ex.StackTrace)

        End Try
    End Sub


    Private Sub txt_grupo_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_grupo.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorGrupo.SetError(sender, "")
            Else
                Me.ErrorGrupo.SetError(sender, "Es obligatorio que ingrese un Nombre de Grupo")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txt_grupo.Clear()
    End Sub

    Private Sub Crear_Grupos_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_grupo = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Crear_Grupos_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_grupo Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Crear_Grupos_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_grupo = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnCerrar_grupo_Click(sender As Object, e As EventArgs) Handles btnCerrar_grupo.Click
        Try

            Dim cerrar_grupo As DialogResult

            cerrar_grupo = MessageBox.Show("¿Seguro que desea cerrar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (cerrar_grupo = DialogResult.OK) Then
                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try
    End Sub

 

End Class