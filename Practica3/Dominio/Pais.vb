Public Class Pais

    Public Property IdPais As String
    Public Property NombrePais As String
    Public Property HabitantesPais As String
    Public ReadOnly Property PaisDAO As PaisesDAO

    Public Sub New()
        Me.PaisDAO = New PaisesDAO
    End Sub

    Public Sub New(id As String)
        Me.PaisDAO = New PaisesDAO
        Me.IdPais = id
    End Sub

    Public Sub LeerTodosPaises()
        Me.PaisDAO.LeerTodas()
    End Sub

    Public Sub LeerPais()
        Me.PaisDAO.Leer(Me)
    End Sub

    Public Function InsertarPais() As Integer
        Return Me.PaisDAO.Insertar(Me)
    End Function

    Public Function ActualizarPais() As Integer
        Return Me.PaisDAO.Actualizar(Me)
    End Function

    Public Function BorrarPais() As Integer
        Return Me.PaisDAO.Borrar(Me)
    End Function

    Public Function LeerIDPais(ByVal id As String) As Pais
        Return Me.PaisDAO.LeerID(id)
    End Function

End Class
