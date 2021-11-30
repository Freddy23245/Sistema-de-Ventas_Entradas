Imports Capa_Logica
Imports System.Data.SqlClient
Public Class Clientes

    Dim dt As New DataTable

    Dim x, y As Integer
    Dim mover_cli As Boolean

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


    Public Property idCli As Integer
    Public Property nomCli As String
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        activar_cli()
        dt_clientes.AllowUserToAddRows = False
        dt_clientes.AllowUserToDeleteRows = False

        cmbBuscar.Text = ("Seleccione una columna")

        LblContador_Clientes.Visible = False
        LblReg_cli.Visible = False


        mostrarclientes()

    End Sub
    Public Sub activar_cli()

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
            If tabla.Rows(i)("descripcion") = "Clientes" Then

                If tabla.Rows(i)("alta") = "True" Then btn_agregar.Enabled = True
                If tabla.Rows(i)("baja") = "True" Then btn_eliminar.Enabled = True
                If tabla.Rows(i)("modifica") = "True" Then btn_editar.Enabled = True
            End If


        Next

    End Sub

    'EVENTOS PARA ARRASTRAR EL FORM
    Private Sub Panel_cli_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel_cli.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_cli = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_cli_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel_cli.MouseMove
        Try

            If mover_cli Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Panel_cli_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel_cli.MouseUp
        Try
            mover_cli = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clientes_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        Try
            x = e.X

            y = e.Y

            mover_cli = True

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clientes_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Try

            If mover_cli Then
                Location = PointToScreen(New Point(MousePosition.X - Location.X - x, MousePosition.Y - Location.Y - y))
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Clientes_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        Try
            mover_cli = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '------------------------------------------------------------------------------------------------
    Public Sub mostrarclientes()
        Dim funCli As New fCliente

        dt = funCli.mostrarCli 'muestro la tabla mediante el dataTable
        dt_clientes.DataSource = dt 'declaro para que se muestren los campos en el dataGried
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        If Me.ValidateChildren = True And txt_nombre.Text <> "" And txt_apellido.Text <> "" And txt_dni.Text <> "" And
            txt_telefono.Text <> "" Then

            Try

                Dim fCli As New fCliente
                Dim dts As New vCliente

                dts.Nombre = txt_nombre.Text
                dts.Apellido = txt_apellido.Text
                dts.dni = txt_dni.Text
                dts.tel = txt_telefono.Text
                dts.email = txt_mail.Text

                If fCli.agregarCli(dts) Then
                    MessageBox.Show("Se ha agregado correctamente")
                    limpiarClientes()
                    mostrarclientes()
                Else
                    MessageBox.Show("No se ha podido agregar")
                End If
            Catch ex As Exception
                MsgBox("Error en: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Faltan ingresar datos del Cliente", "Atención!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        If lblCodCli.Text = "" Then
            MessageBox.Show("Por Favor Seleccione al cliente que quiere Editar ", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim faCli As New fCliente
                Dim dts As New vCliente

                dts.idCliente = lblCodCli.Text
                dts.Nombre = txt_nombre.Text
                dts.Apellido = txt_apellido.Text
                dts.dni = txt_dni.Text
                dts.tel = txt_telefono.Text
                dts.email = txt_mail.Text

                If faCli.actualizarCli(dts) Then
                    MessageBox.Show("Se ha editado correctamente")
                    mostrarclientes()
                Else
                    MessageBox.Show("No se ha podido editar")
                End If

            Catch ex As Exception
                MsgBox("Error en: " & ex.Message)
            End Try
        End If
    End Sub

  

    Private Sub dt_clientes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_clientes.CellContentClick
        Dim dgv As DataGridViewRow = dt_clientes.Rows(e.RowIndex)

        lblCodCli.Text = dgv.Cells(0).Value
        txt_nombre.Text = dgv.Cells(1).Value
        txt_apellido.Text = dgv.Cells(2).Value
        txt_dni.Text = dgv.Cells(3).Value
        txt_telefono.Text = dgv.Cells(4).Value
        txt_mail.Text = dgv.Cells(5).Value

    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

        If lblCodCli.Text = "" Then
            MessageBox.Show("Por Favor Seleccione al cliente que quiere Eliminar ", "Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            Try

                Dim resultado As DialogResult

                resultado = MessageBox.Show("¿Realmente desea eliminar los clientes de la base?", "Consulta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If resultado = DialogResult.Yes Then



                    Dim dts As New vCliente
                    Dim feCli As New fCliente

                    dts.idCliente = lblCodCli.Text


                    'dts.idCliente = lblCodCli.Text

                    If feCli.eliminarCli(dts) Then
                        MessageBox.Show("Se ha eliminado correctamente")

                    Else
                        MessageBox.Show("No se ha podido eliminar")
                    End If
                End If

                mostrarclientes()
                limpiarClientes()

            Catch ex As InvalidConstraintException
                MsgBox("Error en: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dt_clientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_clientes.CellDoubleClick
        Dim dgv As DataGridViewRow = dt_clientes.Rows(e.RowIndex)

        If txt_flag.Text = "1" Then
            idCli = dgv.Cells(0).Value
            nomCli = dgv.Cells(1).Value
            Hide()
        End If
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            If txtBuscar_cli.Text = "" Then
                mostrarclientes()
            Else
             
                dv.RowFilter = cmbBuscar.Text & " like'" & txtBuscar_cli.Text & "%'"

                If dv.Count <> 0 Then
                    dt_clientes.DataSource = dv
                Else
                    dt_clientes.DataSource = Nothing
                End If
            End If
         

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


    Private Sub txtBuscar_cli_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar_cli.TextChanged
        buscar()
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

 

    '-------------------------------Validación de Campos de la Clase Clientes-------------------------------------

    Private Sub txt_nombre_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_nombre.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorClientes.SetError(sender, "")
            Else
                ErrorClientes.SetError(sender, "Es obligatorio que ingrese el Nombre del Cliente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido.KeyPress
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

  

    Private Sub txt_apellido_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_apellido.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorClientes.SetError(sender, "")
            Else
                ErrorClientes.SetError(sender, "Es obligatorio que ingrese el Apellido del Cliente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_dni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_dni.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            Me.ErrorClientes.SetError(sender, "solo acepta numero")
        End If
    End Sub

    Private Sub txt_dni_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_dni.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorClientes.SetError(sender, "")
            Else
                ErrorClientes.SetError(sender, "Es obligatorio que ingrese el Dni del Cliente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)
        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            Me.ErrorClientes.SetError(sender, "solo acepta numero")
        End If
    End Sub


    Private Sub txt_telefono_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txt_telefono.Validating
        Try
            If DirectCast(sender, TextBox).Text.Length > 0 Then
                ErrorClientes.SetError(sender, "")
            Else
                ErrorClientes.SetError(sender, "Es obligatorio que ingrese el Teléfono del Cliente. En caso de no contar con un número, por favor informese con el Administrador de la Empresa.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiarClientes()
        Try
            lblCodCli.Text = ""
            txt_nombre.Clear()
            txt_apellido.Clear()
            txt_dni.Clear()
            txt_telefono.Clear()
            txt_mail.Clear()
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Try
            lblCodCli.Text = ""
            txt_nombre.Clear()
            txt_apellido.Clear()
            txt_dni.Clear()
            txt_telefono.Clear()
            txt_mail.Clear()
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
        End Try
    End Sub

    Private Sub btnCerrar_cli_Click(sender As Object, e As EventArgs) Handles btnCerrar_cli.Click
        Try

            Dim can_cli As DialogResult

            can_cli = MessageBox.Show("¿Seguro que desea cancelar?", "Consulta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If (can_cli = DialogResult.OK) Then

                Close()
            End If

        Catch ex As Exception

            MsgBox("Error encontrado en: " & ex.Message)

        End Try
    End Sub

    'Private Sub chkEliminar_CheckedChanged(sender As Object, e As EventArgs)
    '    Try
    '        If chkEliminar.CheckState = CheckState.Checked Then
    '            dt_clientes.Columns.Item("Eliminar").Visible = True
    '            LblFila_eliminar.Visible = True
    '        Else
    '            dt_clientes.Columns.Item("Eliminar").Visible = False
    '            LblFila_eliminar.Visible = False
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    Public Sub CantFilas_cli()
        Dim contador As Integer = 0

        For Each fila As DataGridViewRow In dt_clientes.Rows
            contador = contador + 1
        Next
        LblContador_Clientes.Text = contador
    End Sub

    Private Sub txt_apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged

    End Sub
End Class