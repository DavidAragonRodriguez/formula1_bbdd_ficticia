Public Class EscuderiasDAO

    Public ReadOnly Property Escuderias As Collection

    Public Sub New()
        Me.Escuderias = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim esc As Escuderia

        Dim p As Pais
        p = New Pais()
        p.LeerTodosPaises()

        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.escuderias ORDER BY IdEscuderia")
        For Each aux In col
            esc = New Escuderia(aux(1).ToString)
            esc.NombreEscuderia = aux(2).ToString
            esc.PaisEscuderia = p.LeerIDPais(aux(3).ToString)
            esc.FechaCreacionEscuderia = aux(4).ToString
            Me.Escuderias.Add(esc)
        Next
    End Sub

    Public Sub Leer(ByRef esc As Escuderia)

        Dim p As Pais
        p = New Pais()
        p.LeerTodosPaises()

        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM formulauno.escuderias WHERE IdEscuderia='" & esc.IdEscuderia & "';")
        For Each aux In col
            esc.NombreEscuderia = aux(2).ToString
            esc.PaisEscuderia = p.LeerIDPais(aux(3).ToString)
            esc.FechaCreacionEscuderia = aux(4).ToString
        Next
    End Sub

    Public Function LeerID(ByVal id As Integer) As Escuderia

        For Each esc As Escuderia In Escuderias
            If esc.IdEscuderia = id Then
                Return esc
            End If
        Next

        Return Nothing

    End Function

    Public Function Insertar(ByVal esc As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO formulauno.escuderias(NombreEscuderia, PaisEscuderia, FechaCreacion) VALUES ('" & esc.NombreEscuderia & "', '" & esc.PaisEscuderia.IdPais & "', '" & esc.FechaCreacionEscuderia.ToString("yyyy-MM-dd") & "');")
    End Function

    Public Function Actualizar(ByVal esc As Escuderia) As Integer
        AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.escuderias SET NombreEscuderia='" & esc.NombreEscuderia & "' WHERE IdEscuderia='" & esc.IdEscuderia & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.escuderias SET PaisEscuderia='" & esc.PaisEscuderia.IdPais & "' WHERE IdEscuderia='" & esc.IdEscuderia & "';")
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.escuderias SET FechaCreacion='" & esc.FechaCreacionEscuderia.ToString("yyyy-MM-dd") & "' WHERE IdEscuderia='" & esc.IdEscuderia & "';")
    End Function

    Public Function Borrar(ByVal esc As Escuderia) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.escuderias WHERE IdEscuderia='" & esc.IdEscuderia & "';")
    End Function

End Class
