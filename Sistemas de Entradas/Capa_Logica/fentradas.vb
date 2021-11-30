Imports Capa_Datos
Imports System.Data.SqlClient
Public Class fentradas
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar_equipos() As DataTable
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
    Public Function mostrar_entradas() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_entradas")
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

    Public Function agregarEnt(ByVal dts As ventradas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_entradas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@local", dts.local)
            cmd.Parameters.AddWithValue("@visitante", dts.visitante)
            cmd.Parameters.AddWithValue("@hora", dts.hora)
            cmd.Parameters.AddWithValue("@fecha", dts.fecha)
            cmd.Parameters.AddWithValue("@precio", dts.precio)
            cmd.Parameters.AddWithValue("@stock", dts.stock)
            cmd.Parameters.AddWithValue("@id_sede", dts.id_sede)

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

    Public Function editarEntrada(ByVal dts As ventradas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editarEntradas")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idEntrada", dts.id_entradas)
            cmd.Parameters.AddWithValue("@hora", dts.hora)
            cmd.Parameters.AddWithValue("@fecha", dts.fecha)
            cmd.Parameters.AddWithValue("@precio", dts.precio)
            cmd.Parameters.AddWithValue("@stock", dts.stock)
            cmd.Parameters.AddWithValue("@id_sede", dts.id_sede)

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

    Public Function eliminarEntradas(ByVal dts As ventradas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_entrada")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.Add("@id_entrada", SqlDbType.NVarChar, 50).Value = dts.id_entradas
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
