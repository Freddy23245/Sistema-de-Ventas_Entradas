Imports Capa_Datos
Imports System.Data.SqlClient
Public Class fEquipos

    Inherits Conexion
    Dim cmd As New SqlCommand



    Public Function verEquipos() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_equipos")
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
            MsgBox("Error al mostrar los equipos")
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
    'Public Function ver_escudo() As DataTable
    '    Try
    '        Dim cod As Integer
    '        conectado()
    '        cmd = New SqlCommand("mostrar_escudo")
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Connection = cn
    '        cmd.Parameters.Add("@nom_equipo", SqlDbType.Int).Value = cod

    '        If cmd.ExecuteNonQuery Then
    '            Dim dt As New DataTable
    '            Dim da As New SqlDataAdapter(cmd)
    '            da.Fill(dt)
    '            Return dt
    '        Else
    '            Return Nothing
    '        End If

    '    Catch ex As Exception
    '        MsgBox("Error al mostrar los equipos")
    '        Return Nothing
    '    Finally
    '        desconectado()
    '    End Try
    'End Function

    Public Function insertar_equipos(ByVal dts As vEquipos) As Boolean
        Try
           
            conectado()
            cmd = New SqlCommand("insertarEquipos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@nombreEquipo", dts.nombEquipo)
            cmd.Parameters.AddWithValue("@img_equipo", dts.imagen)
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

    Public Function editar_equipos(ByVal dts As vEquipos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editarEquipos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idEquipo", dts.idEquipo)
            cmd.Parameters.AddWithValue("@nombreEquipo", dts.nombEquipo)
            cmd.Parameters.AddWithValue("@img_equipo", dts.imagen)
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

    Public Function eliminar_equipos(ByVal dts As vEquipos) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarEquipos")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.Add("@idEquipo", SqlDbType.NVarChar, 50).Value = dts.idEquipo
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
End Class
