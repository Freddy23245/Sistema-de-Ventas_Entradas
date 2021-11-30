Imports Capa_Datos
Imports System.Data.SqlClient
Public Class fdetalle_venta
    Inherits Conexion
    Dim cmd As New SqlCommand

    Public Function mostrar_detalle_venta() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle")
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
            MsgBox("Error al mostrar el detalle de venta")
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar_detalle_venta(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_detalleventa")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@id_venta", dts.id_venta)
            cmd.Parameters.AddWithValue("@id_entrada", dts.id_entrada)
            cmd.Parameters.AddWithValue("@cantidad", dts.cantidad)
            cmd.Parameters.AddWithValue("@precio", dts.precio)


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


    Public Function editar_detalle_venta(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("editar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@id_detalle_venta", dts.id_detalle_venta)
            cmd.Parameters.AddWithValue("@id_venta", dts.id_venta)
            cmd.Parameters.AddWithValue("@id_entrada", dts.id_entrada)
            cmd.Parameters.AddWithValue("@cantidad", dts.cantidad)
            cmd.Parameters.AddWithValue("@precio", dts.precio)

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

    Public Function eliminar_detalle_venta(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_detalle_venta")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn

            cmd.Parameters.Add("@id_detalle_venta", SqlDbType.NVarChar, 50).Value = dts.id_detalle_venta

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

    Public Function aumentar_stock(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("aumentar_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.AddWithValue("@id_entrada", dts.id_entrada)
            cmd.Parameters.AddWithValue("@cantidad", dts.cantidad)


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

    Public Function disminuir_stock(ByVal dts As vdetalle_venta) As Boolean
        Try
            conectado()

            cmd = New SqlCommand("disminuir_stock")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.AddWithValue("@id_entrada", dts.id_entrada)
            cmd.Parameters.AddWithValue("@cantidad", dts.cantidad)


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
