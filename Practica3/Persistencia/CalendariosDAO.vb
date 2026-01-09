Public Class CalendariosDAO

    Public ReadOnly Property Calendarios As Collection

    Public Sub New()
        Me.Calendarios = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim calendario As Calendario

        Dim gp As GP
        gp = New GP()
        gp.LeerTodosGPs()

        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.calendario ORDER BY Temporada, Orden")
        For Each aux In col
            calendario = New Calendario(aux(1), gp.LeerIDPGP(aux(2)))
            calendario.Orden = aux(3)
            Me.Calendarios.Add(calendario)
        Next
    End Sub

    Public Sub Leer(ByRef calendario As Calendario)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM formulauno.calendario WHERE Temporada='" & calendario.Temporada & "' AND GP='" & calendario.GP.IdGP & "';")
        For Each aux In col
            calendario.Orden = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal calendario As Calendario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO formulauno.calendario(Temporada, GP, Orden) VALUES ('" & calendario.Temporada & "', '" & calendario.GP.IdGP & "' , '" & calendario.Orden & "');")
    End Function

    Public Function Borrar(ByVal calendario As Calendario) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.calendario WHERE Temporada='" & calendario.Temporada & "' AND GP='" & calendario.GP.IdGP & "';")
    End Function

    Public Sub BorrarTodas(ByVal temporada As Short)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.calendario ORDER BY Temporada, Orden")
        For Each aux In col

            AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.calendario WHERE Temporada='" & temporada & "';")

        Next
    End Sub

    Public Sub BorrarTablaCompleta()
        AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.calendario;")
    End Sub

End Class
