Imports System.Data.SqlClient
Public Class Conexion
    Protected cn As New SqlConnection



    Protected Function conectado()
        Try
            cn = New SqlConnection("Data Source=BOCA_JUNIORS;Initial Catalog =Entradas;Integrated Security=True")
            cn.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

  



    Protected Function desconectado()
        Try
            If cn.State = ConnectionState.Open Then
                cn.Close()
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
