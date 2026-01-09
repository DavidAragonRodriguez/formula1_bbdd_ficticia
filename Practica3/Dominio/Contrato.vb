Public Class Contrato

    Public Property Escuderia As Escuderia
    Public Property Temporada As Short
    Public Property Piloto1 As Piloto
    Public Property Piloto2 As Piloto
    Public ReadOnly Property ContratoDAO As ContratosDAO

    Public Sub New()
        Me.ContratoDAO = New ContratosDAO
    End Sub

    Public Sub New(escud As Escuderia, temp As Short)
        Me.ContratoDAO = New ContratosDAO
        Me.Escuderia = escud
        Me.Temporada = temp
    End Sub

    Public Sub LeerTodosContratos()
        Me.ContratoDAO.LeerTodas()
    End Sub

    Public Sub LeerContrato()
        Me.ContratoDAO.Leer(Me)
    End Sub

    Public Function InsertarContrato() As Integer
        Return Me.ContratoDAO.Insertar(Me)
    End Function

    Public Function BorrarContrato() As Integer
        Return Me.ContratoDAO.Borrar(Me)
    End Function
    Public Sub BorrarTodosContratos(ByVal temporada As Short)
        Me.ContratoDAO.BorrarTodas(temporada)
    End Sub

    Public Sub BorrarTablaContratos()
        Me.ContratoDAO.BorrarTablaCompleta()
    End Sub

End Class
