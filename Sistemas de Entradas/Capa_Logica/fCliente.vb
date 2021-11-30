Imports Capa_Datos
Imports System.Data.SqlClient


Public Class fCliente

    Inherits Conexion
    Dim comando As New SqlCommand


    Public Function mostrarCli() As DataTable
        Try
            conectado()
            comando = New SqlCommand("mostrarClientes")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cn

            If comando.ExecuteNonQuery Then
                Dim dataTable As New DataTable
                Dim dataAdapter As New SqlDataAdapter(comando)
                dataAdapter.Fill(dataTable)
                Return dataTable
            Else
                Return Nothing
            End If
        Catch ex As Exception

            MsgBox("Error al mostrar los Clientes")
            Return Nothing
        Finally
            desconectado()
        End Try

    End Function

    Public Function agregarCli(ByVal dts As vCliente) As Boolean
        Try
            conectado()
            comando = New SqlCommand("agregarClientes")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cn

            comando.Parameters.AddWithValue("@nombre", dts.nombre)
            comando.Parameters.AddWithValue("@apellido", dts.Apellido)
            comando.Parameters.AddWithValue("@dni", dts.dni)
            comando.Parameters.AddWithValue("@tel", dts.tel)
            comando.Parameters.AddWithValue("@mail", dts.email)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("error encontrado en: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function actualizarCli(ByVal dts As vCliente) As Boolean
        Try
            conectado()
            comando = New SqlCommand("editarClientes")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cn

            comando.Parameters.AddWithValue("@idCliente", dts.idCliente)
            comando.Parameters.AddWithValue("@nombre", dts.Nombre)
            comando.Parameters.AddWithValue("@apellido", dts.Apellido)
            comando.Parameters.AddWithValue("@dni", dts.dni)
            comando.Parameters.AddWithValue("@tel", dts.tel)
            comando.Parameters.AddWithValue("@mail", dts.email)

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("error encontrado en: " & ex.Message)
            Return False
        End Try

    End Function

    Public Function eliminarCli(ByVal dts As vCliente) As Boolean
        Try
            conectado()
            comando = New SqlCommand("eliminarClientes")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cn
            comando.Parameters.Add("@idCliente", SqlDbType.NVarChar, 50).Value = dts.idCliente

            If comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox("Error encontrado en: " & ex.Message)
            Return False
        End Try
    End Function

    'Public Function busquedaCliente(ByVal dts As vCliente) As DataTable
    '    Try
    '        conectado()
    '        comando = New SqlCommand("buscarCliente")
    '        comando.CommandType = CommandType.StoredProcedure
    '        comando.Connection = cn

    '        comando.Parameters.AddWithValue("@nomCli", dts.Nombre)

    '        If comando.ExecuteNonQuery Then
    '            Dim dataTable As New DataTable
    '            Dim dataAdapter As New SqlDataAdapter(comando)
    '            dataAdapter.Fill(dataTable)
    '            Return dataTable
    '        Else
    '            Return Nothing
    '        End If

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return Nothing
    '    End Try
    'End Function

End Class
