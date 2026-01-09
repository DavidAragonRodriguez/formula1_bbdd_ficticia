Public Class Escuderia

    Public Property IdEscuderia As Integer
    Public Property NombreEscuderia As String
    Public Property PaisEscuderia As Pais
    Public Property FechaCreacionEscuderia As Date
    Public ReadOnly Property EscuderiaDAO As EscuderiasDAO

    Public Sub New()
        Me.EscuderiaDAO = New EscuderiasDAO
    End Sub

    Public Sub New(id As String)
        Me.EscuderiaDAO = New EscuderiasDAO
        Me.IdEscuderia = id
    End Sub

    Public Sub LeerTodasEscuderias()
        Me.EscuderiaDAO.LeerTodas()
    End Sub

    Public Sub LeerEscuderia()
        Me.EscuderiaDAO.Leer(Me)
    End Sub

    Public Function InsertarEscuderia() As Integer
        Return Me.EscuderiaDAO.Insertar(Me)
    End Function

    Public Function ActualizarEscuderia() As Integer
        Return Me.EscuderiaDAO.Actualizar(Me)
    End Function

    Public Function BorrarEscuderia() As Integer
        Return Me.EscuderiaDAO.Borrar(Me)
    End Function

    Public Function LeerIDEscuderia(ByVal id As Integer) As Escuderia
        Return Me.EscuderiaDAO.LeerID(id)
    End Function

End Class
