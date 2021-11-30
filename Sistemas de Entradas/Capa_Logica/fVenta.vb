Imports Capa_Datos
Imports System.Data.SqlClient
Public Class fVenta
    Inherits Conexion
    Dim cmd As New SqlCommand
    Public Function mostrar_venta() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_ventas")
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
            MsgBox("Error al mostrar las ventas")
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar_venta(ByVal dts As vventas) As Boolean
        ' Try
        conectado()
        cmd = New SqlCommand("insertar_venta")
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = cn

        cmd.Parameters.AddWithValue("@id_cliente", dts.id_cliente)
        cmd.Parameters.AddWithValue("@fecha", dts.fecha)
        cmd.Parameters.AddWithValue("@tipo_pago", dts.tipo_pago)



        If cmd.ExecuteNonQuery Then
            Return True
        Else
            Return False
        End If

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        '    Return False
        'End Try
    End Function


    Public Function editar_venta(ByVal dts As vventas) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("editar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@id_venta", dts.id_venta)
            cmd.Parameters.AddWithValue("@id_cliente", dts.id_cliente)
            cmd.Parameters.AddWithValue("@fecha", dts.fecha)
            cmd.Parameters.AddWithValue("@tipo_pago", dts.tipo_pago)
            cmd.Parameters.AddWithValue("@num_venta", dts.num_venta)


            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function eliminar_venta(ByVal dts As vventas) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@id_venta", SqlDbType.NVarChar, 50).Value = dts.id_venta

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function

End Class
