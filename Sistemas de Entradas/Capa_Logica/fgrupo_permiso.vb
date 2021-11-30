Imports Capa_Datos
Imports System.Data.SqlClient
Public Class fgrupo_permiso
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar_grupos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarGrupos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Error al mostrar los grupos")
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function mostrar_permisos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_permisos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing

            End If
        Catch ex As Exception
            MsgBox("Error al mostrar Permisos")
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar_permisos(ByVal dts As vgrupo_permiso) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_permisos_grup")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@id_grupo", dts.id_grupo)
            cmd.Parameters.AddWithValue("@id_permiso", dts.id_permiso)
            cmd.Parameters.AddWithValue("@alta", dts.alta)
            cmd.Parameters.AddWithValue("@baja", dts.baja)
            cmd.Parameters.AddWithValue("@modifica", dts.modificacion)


            If cmd.ExecuteNonQuery Then

                Return True
            Else
                Return False

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try




    End Function

    Public Function eliminar_permisos(ByVal dts As vgrupo_permiso) As Boolean
        'Try
        conectado()
        cmd = New SqlCommand("SP_Quitar_PErmisos")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn

        cmd.Parameters.AddWithValue("@id_grupo", dts.id_grupo)
        cmd.Parameters.AddWithValue("@id_permiso", dts.id_permiso)
        'cmd.Parameters.AddWithValue("@alta", dts.alta)
        'cmd.Parameters.AddWithValue("@baja", dts.baja)
        'cmd.Parameters.AddWithValue("@modifica", dts.modificacion)


        If cmd.ExecuteNonQuery Then

            Return True
        Else
            Return False

        End If
        'Catch ex As Exception
        '    MsgBox("Error Al ingresar Permisos")
        '    Return False
        'Finally
        '    desconectado()
        'End Try




    End Function
    Public Function mostrar_GP() As DataTable
        'Try
        conectado()
        cmd = New SqlCommand("mostrar_grupos_permisos")
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
        'Catch ex As Exception

        '    MsgBox("Error al mostrar los Clientes")
        '    Return Nothing
        'Finally
        '    desconectado()
        'End Try

    End Function

End Class
