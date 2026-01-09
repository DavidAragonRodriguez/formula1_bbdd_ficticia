Public Class PilotosDAO

    Public ReadOnly Property Pilotos As Collection

    Public Sub New()
        Me.Pilotos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim pil As Piloto
        Dim col, aux As Collection

        Dim p As Pais
        p = New Pais()
        p.LeerTodosPaises()

        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.pilotos ORDER BY IdPiloto")
        For Each aux In col
            pil = New Piloto(aux(1).ToString)
            pil.NombrePiloto = aux(2).ToString
            pil.ApellidoPiloto = aux(3).ToString
            pil.PaisPiloto = p.LeerIDPais(aux(4).ToString)
            Me.Pilotos.Add(pil)
        Next
    End Sub

    Public Sub Leer(ByRef pil As Piloto)
        Dim col As Collection : Dim aux As Collection

        Dim p As Pais
        p = New Pais()
        p.LeerTodosPaises()

        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM formulauno.pilotos WHERE IdPiloto='" & pil.IdPiloto & "';")
        For Each aux In col
            pil.NombrePiloto = aux(2).ToString
            pil.ApellidoPiloto = aux(3).ToString
            pil.PaisPiloto = p.LeerIDPais(aux(4).ToString)
        Next
    End Sub

    Public Function LeerID(ByVal id As Integer) As Piloto

        For Each pil As Piloto In Pilotos
            If pil.IdPiloto = id Then
                Return pil
            End If
        Next

        Return Nothing

    End Function

    Public Function Insertar(ByVal pil As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO formulauno.pilotos(NombrePiloto, ApellidoPiloto, PaisPiloto) VALUES ('" & pil.NombrePiloto & "', '" & pil.ApellidoPiloto & "', '" & pil.PaisPiloto.IdPais & "');")
    End Function

    Public Function Actualizar(ByVal pil As Piloto) As Integer
        AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.pilotos SET NombrePiloto='" & pil.NombrePiloto & "' WHERE IdPiloto='" & pil.IdPiloto & "';")
        AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.pilotos SET ApellidoPiloto='" & pil.ApellidoPiloto & "' WHERE IdPiloto='" & pil.IdPiloto & "';")
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.pilotos SET PaisPiloto='" & pil.PaisPiloto.IdPais & "' WHERE IdPiloto='" & pil.IdPiloto & "';")
    End Function

    Public Function Borrar(ByVal pil As Piloto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.pilotos WHERE IdPiloto='" & pil.IdPiloto & "';")
    End Function

End Class
