Imports Capa_Datos
Imports System.Data.SqlClient

Public Class fGrupos

    Inherits Conexion
    Dim comando As New SqlCommand

    Public Function insertarGrupo(ByVal dts As vGrupos) As Boolean
        Try
            conectado()
            comando = New SqlCommand("agregarGrupos")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = cn

            comando.Parameters.AddWithValue("@nombre_grupo", dts.nombreGrupo)

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
End Class
