Public Class PaisesDAO
    Public ReadOnly Property Paises As Collection

    Public Sub New()
        Me.Paises = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim p As Pais
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.paises ORDER BY IdPais")
        For Each aux In col
            p = New Pais(aux(1).ToString)
            p.NombrePais = aux(2).ToString
            p.HabitantesPais = aux(3).ToString
            Me.Paises.Add(p)
        Next
    End Sub

    Public Sub Leer(ByRef p As Pais)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM formulauno.paises WHERE IdPais='" & p.IdPais & "';")
        For Each aux In col
            p.NombrePais = aux(2).ToString
            p.HabitantesPais = aux(3).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO formulauno.paises VALUES ('" & p.IdPais & "', '" & p.NombrePais & "', '" & p.HabitantesPais & "');")
    End Function

    Public Function Actualizar(ByVal p As Pais) As Integer
        AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.paises SET NombrePais='" & p.NombrePais & "' WHERE IdPais='" & p.IdPais & "';")
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE formulauno.paises SET HabitantesPais='" & p.HabitantesPais & "' WHERE IdPais='" & p.IdPais & "';")
    End Function

    Public Function Borrar(ByVal p As Pais) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.paises WHERE IdPais='" & p.IdPais & "';")
    End Function

    Public Function LeerID(ByVal id As String) As Pais

        For Each p As Pais In Paises
            If p.IdPais = id Then
                Return p
            End If
        Next

        Return Nothing

    End Function

End Class
