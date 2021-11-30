Imports Capa_Datos
Imports System.Data.SqlClient


Public Class fSede

    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar_sede() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarSedes")
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

            MsgBox("Error al mostrar las sedes")
            Return Nothing
        Finally
            desconectado()
        End Try

    End Function

    Public Function insertar_sedes(ByVal dts As vSede) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertarSedes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@nombre_sede", dts.nombreSede)
            cmd.Parameters.AddWithValue("@dir_sede", dts.dirSede)

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

    Public Function editar_sedes(ByVal dts As vSede) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editarSedes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idSede", dts.idSede)
            cmd.Parameters.AddWithValue("@nombre_sede", dts.nombreSede)
            cmd.Parameters.AddWithValue("@dir_sede", dts.dirSede)

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

    Public Function eliminar_sedes(ByVal dts As vSede) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminarSedes")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.Add("@idSede", SqlDbType.NVarChar, 50).Value = dts.idSede
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
