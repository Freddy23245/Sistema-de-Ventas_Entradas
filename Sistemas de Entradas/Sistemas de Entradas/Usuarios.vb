Imports Capa_Logica

Public Class Usuarios

    Dim dt As New DataTable

    Dim x, y As Integer
    Dim mover_usu As Boolean

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

    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbUsuario.Text = ("Seleccione una columna")
        activar_usu()
        dt_usuarios.AllowUserToAddRows = False
        dt_usuarios.AllowUserToDeleteRows = False

        dt_usuarios.Columns.Item("Eliminar").Visible = False
        mostrarUsu()
    End Sub

    'EVENTOS PARA ARRASTRAR EL FORM
    Private Sub Panel_usu_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_usu.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_usu = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_usu_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_usu.MouseMove
        Try

            If mover_usu Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_usu_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_usu.MouseUp
        Try
            mover_usu = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Usuarios_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_usu = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Usuarios_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_usu Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Usuarios_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_usu = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '----------------------------------------------------------------------------------------------
    Public Sub activar_usu()

        Dim fun As New fusuario
        Dim dts As New vusuario
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim tabla As DataTable


        tabla = dts.nbotones(_usu)
        j = tabla.Rows.Count

        btn_agregar.Enabled = False
        btn_eliminar.Enabled = False
        btn_editar.Enabled = False
        For i = 0 To tabla.Rows.Count - 1
            If tabla.Rows(i)("descripcion") = "Usuarios" Then

                If tabla.Rows(i)("alta") = "True" Then btn_agregar.Enabled = True
                If tabla.Rows(i)("baja") = "True" Then btn_eliminar.Enabled = True
                If tabla.Rows(i)("modifica") = "True" Then btn_editar.Enabled = True
            End If


        Next
    End Sub

    Public Sub mostrarUsu()
        Dim funpro As New fusuario

        dt = funpro.mostrarUsuario 'muestro la tabla mediante el dataTable
        dt_usuarios.DataSource = dt 'declaro para que se muestren los campos en el dataGried
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If txt_nombre.Text = String.Empty And txt_dni.Text = String.Empty And txt_usuario.Text = String.Empty And txt_contraseña.Text = String.Empty Then
            MessageBox.Show("Por Favor Ingrese datos", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txt_nombre.Text = String.Empty Or txt_dni.Text = String.Empty Or txt_usuario.Text = String.Empty Or txt_contraseña.Text = String.Empty Then
            MessageBox.Show("Falta Ingresar Datos", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else


            Try
                Dim funPro As New fusuario
                Dim dts As New vusuario
                Dim x As New Seguridad
                dts.nombre = txt_nombre.Text
                dts.dni = txt_dni.Text
                dts.usuario = txt_usuario.Text
                dts.contrasenia = x.encriptar(txt_contraseña.Text)
                dts.hab = chk_habilitado.Checked

                If funPro.agregar(dts) Then
                    MessageBox.Show("Se ha agregado correctamente")
                    mostrarUsu()
                Else
                    MessageBox.Show("No se ha podido agregar")
                End If
                mostrarUsu()
                limpiarUsuarios()
            Catch ex As Exception
                MsgBox("Error en: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If lblId_usuario.Text = "" Then
            MessageBox.Show("Por favor seleccione al Usuario que quiere Editar ", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim funPro As New fusuario
                Dim dts As New vusuario
                Dim x As New Seguridad
                dts.idUsuario = lblId_usuario.Text
                dts.nombre = txt_nombre.Text
                dts.dni = txt_dni.Text
                dts.usuario = txt_usuario.Text
                dts.contrasenia = x.encriptar(txt_contraseña.Text)
                dts.hab = chk_habilitado.Checked

                If funPro.editar(dts) Then
                    MessageBox.Show("Se ha editado correctamente")
                    mostrarUsu()
                Else
                    MessageBox.Show("No se ha podido editar")
                End If

            Catch ex As Exception
                MsgBox("Error en: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dt_usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_usuarios.CellClick
        Try

            lblId_usuario.Text = dt_usuarios.SelectedCells.Item(1).Value.ToString
            txt_nombre.Text = dt_usuarios.SelectedCells.Item(2).Value.ToString
            txt_dni.Text = dt_usuarios.SelectedCells.Item(3).Value.ToString
            txt_usuario.Text = dt_usuarios.SelectedCells.Item(4).Value.ToString
            txt_contraseña.Text = dt_usuarios.SelectedCells.Item(5).Value.ToString
            chk_habilitado.Checked = dt_usuarios.SelectedCells.Item(6).Value.ToString


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dt_usuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_usuarios.CellContentClick
        Try
            Dim contador As Integer

            If e.ColumnIndex = dt_usuarios.Columns.Item("Eliminar").Index Then
                Dim chkcell As DataGridViewCheckBoxCell = dt_usuarios.Rows(e.RowIndex).Cells("Eliminar")
                chkcell.Value = Not chkcell.Value
            End If

            For Each row As DataGridViewRow In dt_usuarios.Rows
                If row.Cells("Eliminar").Value = True Then
                    contador = contador + 1
                End If
            Next
            LblSeleccion_usu.Text = contador
            'Dim dgv As DataGridViewRow = dt_usuarios.Rows(e.RowIndex)

            'lblId_usuario.Text = dgv.Cells(0).Value
            'txt_nombre.Text = dgv.Cells(1).Value
            'txt_dni.Text = dgv.Cells(2).Value
            'txt_usuario.Text = dgv.Cells(3).Value
            'txt_contraseña.Text = dgv.Cells(4).Value
            'chk_habilitado.Checked = dgv.Cells(5).Value

        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If lblId_usuario.Text = "" Then
            MessageBox.Show("Por favor seleccione al Usuario que quiere Eliminar ", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try

                Dim resultado As DialogResult

                resultado = MessageBox.Show("¿Realmente desea eliminar los usuarios seleccionados de la base?", "Consulta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then



                    Dim dts As New vusuario
                    Dim fun_usu As New fusuario

                    dts.idUsuario = lblId_usuario.Text

                    If fun_usu.eliminar(dts) Then
                        MessageBox.Show("Se ha eliminado correctamente")

                    Else
                        MessageBox.Show("No se ha podido eliminar")
                    End If
                End If

                mostrarUsu()

            Catch ex As Exception
                MsgBox("Error en: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            lblId_usuario.Text = ""
            txt_nombre.Clear()
            txt_dni.Clear()
            txt_usuario.Clear()
            txt_contraseña.Clear()

        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub buscar_usuarios()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))
            If txtBuscar_usu.Text = "" Then
                mostrarUsu()
            Else
                'If cmbUsuario.SelectedItem = "dni" Then
                '    dt_usuarios.CurrentRow.Selected = False
                '    For Each dr As DataGridViewRow In Me.dt_usuarios.Rows
                '        If dr.Cells("dni").Value = txtBuscar_usu.Text Then
                '            dr.Selected = txtBuscar_usu.Text
                '        End If

                '    Next
                'Else
                dv.RowFilter = cmbUsuario.Text & " like'" & Convert.ToString(txtBuscar_usu.Text) & "%'"

                If dv.Count <> 0 Then
                    dt_usuarios.DataSource = dv
                    'ocultar_columnas()
                Else
                    dt_usuarios.DataSource = Nothing
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    'Private Sub ocultar_columnas()
    '    dt_usuarios.Columns(0).Visible = False
    'End Sub

    Private Sub txtBuscar_usu_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_usu.TextChanged
        Try
            buscar_usuarios()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    '-------------------------------Validación de Campos de la Clase Usuarios-------------------------------------
    Private Sub txt_nombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nombre.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorUsuarios.SetError(sender, "")
            Else
                Me.ErrorUsuarios.SetError(sender, "Es obligatorio que ingrese el Nombre de Usuario")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dni.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            Me.ErrorUsuarios.SetError(sender, "solo acepta numero")
        End If
    End Sub


    Private Sub txt_dni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_dni.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorUsuarios.SetError(sender, "")
            Else
                Me.ErrorUsuarios.SetError(sender, "Es obligatorio que ingrese el Dni de Usuario")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_usuario_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_usuario.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorUsuarios.SetError(sender, "")
            Else
                Me.ErrorUsuarios.SetError(sender, "Es obligatorio que ingrese un Usuario de identificación")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_contraseña_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_contraseña.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                Me.ErrorUsuarios.SetError(sender, "")
            Else
                Me.ErrorUsuarios.SetError(sender, "Es obligatorio que ingrese una Contraseña")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_usuario_Click(sender As Object, e As EventArgs) Handles btnCerrar_usuario.Click
        Try

            Dim can_usu As DialogResult

            can_usu = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_usu = DialogResult.OK) Then

                Close()

            End If

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub chkbUsu_CheckedChanged(sender As Object, e As EventArgs) Handles chkbUsu.CheckedChanged
        Try
            If chkbUsu.CheckState = CheckState.Checked Then
                dt_usuarios.Columns.Item("Eliminar").Visible = True
                LblSeleccion_usu.Visible = True
            Else
                dt_usuarios.Columns.Item("Eliminar").Visible = False
                LblSeleccion_usu.Visible = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiarUsuarios()
        Try
            lblId_usuario.Text = ""
            txt_nombre.Clear()
            txt_dni.Clear()
            txt_usuario.Clear()
            txt_contraseña.Clear()
            chk_habilitado.Checked = False
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub PbEditar_usu_Click(sender As Object, e As EventArgs) Handles PbEditar_usu.Click

    End Sub
End Class