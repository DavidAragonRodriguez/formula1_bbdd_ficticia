Public Class Calendario

    Public Property Temporada As Short
    Public Property GP As GP
    Public Property Orden As Byte
    Public ReadOnly Property CalendarioDAO As CalendariosDAO

    Public Sub New()
        Me.CalendarioDAO = New CalendariosDAO
    End Sub

    Public Sub New(temp As Short, gp As GP)
        Me.CalendarioDAO = New CalendariosDAO
        Me.Temporada = temp
        Me.GP = gp
    End Sub

    Public Sub LeerTodosCalendarios()
        Me.CalendarioDAO.LeerTodas()
    End Sub

    Public Sub LeerCalendario()
        Me.CalendarioDAO.Leer(Me)
    End Sub

    Public Function InsertarCalendario() As Integer
        Return Me.CalendarioDAO.Insertar(Me)
    End Function

    Public Function BorrarCalendario() As Integer
        Return Me.CalendarioDAO.Borrar(Me)
    End Function
    Public Sub BorrarTodosCalendarios(ByVal temporada As Short)
        Me.CalendarioDAO.BorrarTodas(temporada)
    End Sub

    Public Sub BorrarTablaCalendarios()
        Me.CalendarioDAO.BorrarTablaCompleta()
    End Sub

End Class
