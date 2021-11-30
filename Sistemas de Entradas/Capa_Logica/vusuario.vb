Public Class vusuario


    Public Property idUsuario As Integer
    Public Property nombre As String
    Public Property dni As Integer
    Public Property usuario As String
    Public Property contrasenia As String
    Public Property hab As Boolean 'Problemas en el parseo de String a byte en el boton editar

    Dim func As New fusuario
    Public Function ver_usuarios(ByVal usu As String, ByVal contraseña As String) As String
        Dim msj As String

        msj = func.validar_usuario(usu, contraseña)
        Return msj

    End Function

    Public Function npermisos(ByVal usu As String) As DataTable


        Return func.validar_permisos(usu)
    End Function
    Public Function nbotones(ByVal usu As String) As DataTable


        Return func.validar_botones(usu)
    End Function
End Class
