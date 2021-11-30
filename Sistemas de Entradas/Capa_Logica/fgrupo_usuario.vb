Imports Capa_Datos
Imports System.Data.SqlClient
Public Class fgrupo_usuario

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
            MsgBox("Error al mostrar Grupos")
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function


    Public Function mostrar_usuarios() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrarUsuarios")
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
            MsgBox("Error al mostrar usuarios")
            Return Nothing
        End Try
    End Function


    Public Function insertar(ByVal dts As vgrupo_usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("insertar_grup_usu")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.AddWithValue("@id_grupo", dts.id_grupo)
            cmd.Parameters.AddWithValue("@id_usuario", dts.id_usuario)


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
    Public Function eliminar_grup(ByVal dts As vgrupo_usuario) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_grup")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn


            cmd.Parameters.Add("@id_grupo", SqlDbType.NVarChar, 50).Value = dts.id_grupo
            cmd.Parameters.Add("@id_usuario", SqlDbType.NVarChar, 50).Value = dts.id_usuario


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
End Class
