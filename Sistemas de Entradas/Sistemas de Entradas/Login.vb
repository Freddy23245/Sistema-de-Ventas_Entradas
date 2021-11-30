Imports System.Security.Cryptography
Imports Capa_Logica

Public Class Login
    Dim fun As New vusuario

    Dim x, y As Integer
    Dim mover As Boolean
    Public Sub loguear()
        Dim x As New Seguridad

        Dim usu, contraseña, msj As String

        usu = txt_usuario.Text
        contraseña = (txt_contraseña.Text)
        Dim encript = x.encriptar(txt_contraseña.Text)
        msj = fun.ver_usuarios(usu, encript)
        MsgBox(msj)

        If (msj.Equals("Bienvenido")) Then
            Dim xmen As New Inicio(usu)
            xmen.Show()
            Hide()
        End If

    End Sub

    Private Sub btn_ingresar_Click_1(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If Me.ValidateChildren = True And txt_usuario.Text <> "" And txt_contraseña.Text <> "" Then
            loguear()
        Else
            MessageBox.Show("Falta ingresar Usuario/Contraseña")
        End If
    End Sub

    'Eventos para arrastrar la ventana Login
    Private Sub Login_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Login_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover Then
                'PointoScreen = Calcula la ubicación del punto especificado de cliente en coordenadas de pantalla, tanto x como y.
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Eventos para arrastrar el panel del login
    Private Sub panelLog_MouseDown(sender As Object, e As MouseEventArgs) Handles panelLog.MouseDown
        Try
            x = e.X

            y = e.Y

            mover = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub panelLog_MouseMove(sender As Object, e As MouseEventArgs) Handles panelLog.MouseMove
        Try

            If mover Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub panelLog_MouseUp(sender As Object, e As MouseEventArgs) Handles panelLog.MouseUp
        Try
            mover = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Login_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover = False

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '-------------------------------Validación de Campos del Formulario = Login-------------------------------------

    Private Sub txt_usuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_usuario.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorLogin.SetError(sender, "")
            Else
                Me.ErrorLogin.SetError(sender, "Es obligatorio que ingrese un Usuario")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_contraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_contraseña.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorLogin.SetError(sender, "")
            Else
                Me.ErrorLogin.SetError(sender, "Es obligatorio que ingrese una Contraseña")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Eventos y Validaciones de los campos Usuarios y Contraseña
    Private Sub txt_usuario_Enter(sender As Object, e As EventArgs) Handles txt_usuario.Enter
        Try
            If txt_usuario.Text = "USUARIO" Then
                txt_usuario.Text = ""
                txt_usuario.ForeColor = Color.LightGray
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_usuario_Leave(sender As Object, e As EventArgs) Handles txt_usuario.Leave
        Try
            If txt_usuario.Text = "" Then
                txt_usuario.Text = "USUARIO"
                txt_usuario.ForeColor = Color.DimGray
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_contraseña_Enter(sender As Object, e As EventArgs) Handles txt_contraseña.Enter
        Try
            If txt_contraseña.Text = "CONTRASEÑA" Then
                txt_contraseña.Text = ""
                txt_contraseña.ForeColor = Color.LightGray
                txt_contraseña.UseSystemPasswordChar = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_contraseña_Leave(sender As Object, e As EventArgs) Handles txt_contraseña.Leave
        Try
            If txt_contraseña.Text = "" Then
                txt_contraseña.Text = "CONTRASEÑA"
                txt_contraseña.ForeColor = Color.DimGray
                txt_contraseña.UseSystemPasswordChar = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Try
            Me.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Try

            Dim salir As DialogResult

            salir = MessageBox.Show("¿Seguro que desea cerrar el programa?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (salir = DialogResult.OK) Then
                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try
    End Sub


End Class
