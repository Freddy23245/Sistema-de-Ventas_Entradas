Public Class vEquipos

    Public Property idEquipo As Integer
    Public Property nombEquipo As String
    Private img_equipo() As Byte

    Public Property imagen
        Get
            Return img_equipo
        End Get
        Set(ByVal value)
            img_equipo = value

        End Set
    End Property




End Class
