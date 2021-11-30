Imports Capa_Logica

Public Class CorreoElectronico

    Private Sub btnenviar_Click(sender As Object, e As EventArgs) Handles btnenviar.Click
        If Me.ValidateChildren = True And txtDe.Text <> "" And txtPara.Text <> "" And txtAsunto.Text <> "" And txtContraseña.Text <> "" Then

            Try
                enviarCorreo(txtDe.Text, txtContraseña.Text, rtxtTexto.Text, txtAsunto.Text, txtPara.Text)
                txtDe.Clear()
                txtPara.Clear()
                txtAsunto.Clear()
                rtxtTexto.Clear()
                txtContraseña.Clear()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar datos.", "Campos Incompletos!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub rtxtTexto_Enter(sender As Object, e As EventArgs) Handles rtxtTexto.Enter
        Try
            If rtxtTexto.Text = "Escriba acá" Then
                rtxtTexto.Text = ""
                rtxtTexto.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub rtxtTexto_Leave(sender As Object, e As EventArgs) Handles rtxtTexto.Leave
        Try
            If rtxtTexto.Text = "" Then
                rtxtTexto.Text = "Escriba acá"
                rtxtTexto.ForeColor = Color.Black
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub CorreoElectronico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim cargar_funMail As New fCliente

            cmbUsu_correo.DataSource = cargar_funMail.mostrarCli
            cmbUsu_correo.DisplayMember = "mail"
            cmbUsu_correo.ValueMember = "id_cliente"

            rtxtTexto.Text = "Escriba acá"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
      
    End Sub

    Private Sub cmbUsu_correo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsu_correo.SelectedIndexChanged
        cmbUsu_correo.Text = "Elija un Cliente"
        Try
            If cmbUsu_correo.DisplayMember <> "" And cmbUsu_correo.ValueMember <> "" Then
                txtPara.Text = cmbUsu_correo.SelectedItem(cmbUsu_correo.DisplayMember)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtDe_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtDe.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorCorreo.SetError(sender, "")
            Else
                ErrorCorreo.SetError(sender, "Es obligatorio que ingrese el correo del emisor")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtPara_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtPara.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorCorreo.SetError(sender, "")
            Else
                ErrorCorreo.SetError(sender, "Es obligatorio que ingrese el correo del receptor. Por favor, seleccione el cliente que desée enviar por medio de nuestra lista de despliegue")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

 
    Private Sub txtAsunto_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtAsunto.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorCorreo.SetError(sender, "")
            Else
                ErrorCorreo.SetError(sender, "Es obligatorio que ingrese un asunto")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtContraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtContraseña.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorCorreo.SetError(sender, "")
            Else
                ErrorCorreo.SetError(sender, "Es obligatorio que ingrese su contraseña.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_mail_Click(sender As Object, e As EventArgs) Handles btnCerrar_mail.Click
        Try

            Dim can_correo As DialogResult

            can_correo = MessageBox.Show("¿Seguro que desea cerrar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_correo = DialogResult.OK) Then
                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try
    End Sub
    Private Sub txtContraseña_Enter(sender As Object, e As EventArgs) Handles txtContraseña.Enter
        Try
            txtContraseña.UseSystemPasswordChar = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtContraseña_Leave(sender As Object, e As EventArgs) Handles txtContraseña.Leave
        Try
            txtContraseña.UseSystemPasswordChar = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class