Imports Capa_Datos
Imports System.Data.SqlClient
Public Class fusuario

    Inherits Conexion
    Dim cmd As New SqlCommand


    Public Function validar_usuario(ByVal usu As String, ByVal contraseña As String) As String

        Try
            Dim msj As String
            conectado()
            cmd = New SqlCommand("verificar_usuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu
            cmd.Parameters.Add("@contraseña", SqlDbType.VarChar).Value = contraseña
            cmd.Parameters.Add("@msje", SqlDbType.VarChar, 60).Direction = 2

            cmd.ExecuteNonQuery()
            msj = cmd.Parameters("@msje").Value.ToString


            Return msj

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try


    End Function


    Public Function validar_permisos(ByVal usu As String) As DataTable
        'Try
        conectado()
        cmd = New SqlCommand("validar_permisos")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn

        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu
        Dim dr As SqlDataReader

        dr = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        Return dt
        'Catch ex As Exception
        '    MsgBox("Error al validar permisos")
        '    Return Nothing
        'Finally
        '    desconectado()
        'End Try
    End Function

    Public Function mostrarUsuario() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarUsuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            If cmd.ExecuteNonQuery Then
                Dim dataTable As New DataTable
                Dim dataAdapter As New SqlDataAdapter(cmd)
                dataAdapter.Fill(dataTable)
                Return dataTable
            Else
                Return Nothing
            End If
        Catch ex As Exception

            MsgBox("Error al mostrar los usuarios")
            Return Nothing
        Finally
            desconectado()
        End Try

    End Function

    Public Function agregar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("agregarUsuarios")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@dni", dts.dni)
            cmd.Parameters.AddWithValue("@usuario", dts.usuario)
            cmd.Parameters.AddWithValue("@contraseña", dts.contrasenia)
            cmd.Parameters.AddWithValue("@habilitado", dts.hab)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("error encontrado en: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function editar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idUsuario", dts.idUsuario)
            cmd.Parameters.AddWithValue("@nombre", dts.nombre)
            cmd.Parameters.AddWithValue("@dni", dts.dni)
            cmd.Parameters.AddWithValue("@usuario", dts.usuario)
            cmd.Parameters.AddWithValue("@contraseña", dts.contrasenia)
            cmd.Parameters.AddWithValue("@habilitado", dts.hab)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("error encontrado en: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function eliminar(ByVal dts As vusuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarUsuario")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.Add("@idUsuario", SqlDbType.NVarChar, 50).Value = dts.idUsuario
            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
            Return False
        End Try
    End Function
    Public Function validar_botones(ByVal usu As String) As DataTable
        'Try
        conectado()
        cmd = New SqlCommand("validar_botones")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn

        cmd.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usu
        Dim dr As SqlDataReader

        dr = cmd.ExecuteReader()
        Dim dt As New DataTable
        dt.Load(dr)
        Return dt
        'Catch ex As Exception
        '    MsgBox("Error al validar permisos")
        '    Return Nothing
        'Finally
        '    desconectado()
        'End Try
    End Function

End Class
