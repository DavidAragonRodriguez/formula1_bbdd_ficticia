Public Class Carrera
    Public Property Temporada As Short
    Public Property GP As GP
    Public Property Piloto As Piloto
    Public Property Posicion As Byte
    Public Property Puntos As Byte
    Public ReadOnly Property CarreraDAO As CarrerasDAO

    Public Sub New()
        Me.CarreraDAO = New CarrerasDAO
    End Sub
    Public Sub New(temp As Short, gp As GP, pil As Piloto)
        Me.CarreraDAO = New CarrerasDAO
        Me.Temporada = temp
        Me.GP = gp
        Me.Piloto = pil
    End Sub

    Public Sub LeerTodasCarreras()
        Me.CarreraDAO.LeerTodas()
    End Sub

    Public Sub LeerCarrera()
        Me.CarreraDAO.Leer(Me)
    End Sub

    Public Function InsertarCarrera() As Integer
        Return Me.CarreraDAO.Insertar(Me)
    End Function

    Public Function BorrarCarrera() As Integer
        Return Me.CarreraDAO.Borrar(Me)
    End Function
    Public Sub BorrarTodasCarreras(ByVal temporada As Short)
        Me.CarreraDAO.BorrarTodas(temporada)
    End Sub

    Public Sub BorrarTablaCarreras()
        Me.CarreraDAO.BorrarTablaCompleta()
    End Sub

    Public Function ObtenerClasificacionPilotos(ByVal Temporada As Short) As Collection
        Return Me.CarreraDAO.ObtenerClasificacionPilotosDAO(Temporada)
    End Function

    Public Function ObtenerClasificacionEscuderias(ByVal Temporada As Short) As Collection
        Return Me.CarreraDAO.ObtenerClasificacionEscuderiasDAO(Temporada)
    End Function

End Class
