Public Class Piloto

    Public Property IdPiloto As Integer
    Public Property NombrePiloto As String
    Public Property ApellidoPiloto As String
    Public Property PaisPiloto As Pais
    Public ReadOnly Property PilotoDAO As PilotosDAO

    Public Sub New()
        Me.PilotoDAO = New PilotosDAO
    End Sub

    Public Sub New(id As String)
        Me.PilotoDAO = New PilotosDAO
        Me.IdPiloto = id
    End Sub

    Public Sub LeerTodosPilotos()
        Me.PilotoDAO.LeerTodas()
    End Sub

    Public Sub LeerPiloto()
        Me.PilotoDAO.Leer(Me)
    End Sub

    Public Function InsertarPiloto() As Integer
        Return Me.PilotoDAO.Insertar(Me)
    End Function

    Public Function ActualizarPiloto() As Integer
        Return Me.PilotoDAO.Actualizar(Me)
    End Function

    Public Function BorrarPiloto() As Integer
        Return Me.PilotoDAO.Borrar(Me)
    End Function

    Public Function LeerIDPiloto(ByVal id As Integer) As Piloto
        Return Me.PilotoDAO.LeerID(id)
    End Function

End Class
