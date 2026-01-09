Public Class GPsDAO

    Public ReadOnly Property GPs As Collection

    Public Sub New()
        Me.GPs = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim gp As GP

        Dim p As Pais
        p = New Pais()
        p.LeerTodosPaises()

        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.gps ORDER BY IdGP")
        For Each aux In col
            gp = New GP(aux(1).ToString)
            gp.DenominacionGP = aux(2).ToString
            gp.PaisGP = p.LeerIDPais(aux(3).ToString)
            Me.GPs.Add(gp)
        Next
    End Sub

    Public Sub Leer(ByRef gp As GP)

        Dim p As Pais
        p = New Pais()
        p.LeerTodosPaises()

        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM formulauno.gps WHERE IdGP='" & gp.IdGP & "';")
        For Each aux In col
            gp.DenominacionGP = aux(2).ToString
            gp.PaisGP = p.LeerIDPais(aux(3).ToString)
        Next
    End Sub

    Public Function LeerID(ByVal id As Integer) As GP

        For Each gp As GP In GPs
            If gp.IdGP = id Then
                Return gp
            End If
        Next

        Return Nothing

    End Function

    Public Function Insertar(ByVal gp As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO formulauno.gps(DenominacionGP, PaisGP) VALUES ('" & gp.DenominacionGP & "', '" & gp.PaisGP.IdPais & "');")
    End Function

    Public Function Actualizar(ByVal gp As GP) As Integer
        AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.gps SET DenominacionGP='" & gp.DenominacionGP & "' WHERE IdGP='" & gp.IdGP & "';")
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.gps SET PaisGP='" & gp.PaisGP.IdPais & "' WHERE IdGP='" & gp.IdGP & "';")
    End Function

    Public Function Borrar(ByVal gp As GP) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.gps WHERE IdGP='" & gp.IdGP & "';")
    End Function

End Class
