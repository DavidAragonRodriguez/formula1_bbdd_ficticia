Public Class ContratosDAO

    Public ReadOnly Property Contratos As Collection

    Public Sub New()
        Me.Contratos = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim con As Contrato

        Dim esc As Escuderia
        esc = New Escuderia()
        esc.LeerTodasEscuderias()

        Dim pil As Piloto
        pil = New Piloto()
        pil.LeerTodosPilotos()

        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.contratos ORDER BY Escuderia, Temporada")
        For Each aux In col
            con = New Contrato(esc.LeerIDEscuderia(aux(1)), aux(2))
            con.Piloto1 = pil.LeerIDPiloto(aux(3))
            con.Piloto2 = pil.LeerIDPiloto(aux(4))
            Me.Contratos.Add(con)
        Next
    End Sub

    Public Sub Leer(ByRef con As Contrato)

        Dim pil As Piloto
        pil = New Piloto()
        pil.LeerTodosPilotos()

        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM formulauno.contratos WHERE Escuderia='" & con.Escuderia.IdEscuderia & "' AND Temporada='" & con.Temporada & "';")
        For Each aux In col
            con.Piloto1 = pil.LeerIDPiloto(aux(3))
            con.Piloto2 = pil.LeerIDPiloto(aux(4))
        Next
    End Sub

    Public Function Insertar(ByVal con As Contrato) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO formulauno.contratos(Escuderia, Temporada, Piloto1, Piloto2) VALUES ('" & con.Escuderia.IdEscuderia & "', '" & con.Temporada & "', '" & con.Piloto1.IdPiloto & "', '" & con.Piloto2.IdPiloto & "');")
    End Function

    Public Function Borrar(ByVal con As Contrato) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.contratos WHERE Escuderia='" & con.Escuderia.IdEscuderia & "' AND Temporada='" & con.Temporada & "';")
    End Function

    Public Sub BorrarTodas(ByVal temporada As Short)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.contratos ORDER BY Escuderia, Temporada")
        For Each aux In col

            AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.contratos WHERE Temporada='" & temporada & "';")

        Next
    End Sub

    Public Sub BorrarTablaCompleta()
        AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.contratos;")
    End Sub

End Class
