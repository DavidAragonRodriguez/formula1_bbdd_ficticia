Public Class GP

    Public Property IdGP As Integer
    Public Property DenominacionGP As String
    Public Property PaisGP As Pais
    Public ReadOnly Property GPDAO As GPsDAO

    Public Sub New()
        Me.GPDAO = New GPsDAO
    End Sub

    Public Sub New(id As String)
        Me.GPDAO = New GPsDAO
        Me.IdGP = id
    End Sub

    Public Sub LeerTodosGPs()
        Me.GPDAO.LeerTodas()
    End Sub

    Public Sub LeerGP()
        Me.GPDAO.Leer(Me)
    End Sub

    Public Function InsertarGP() As Integer
        Return Me.GPDAO.Insertar(Me)
    End Function

    Public Function ActualizarGP() As Integer
        Return Me.GPDAO.Actualizar(Me)
    End Function

    Public Function BorrarGP() As Integer
        Return Me.GPDAO.Borrar(Me)
    End Function

    Public Function LeerIDPGP(ByVal id As Integer) As GP
        Return Me.GPDAO.LeerID(id)
    End Function

End Class
