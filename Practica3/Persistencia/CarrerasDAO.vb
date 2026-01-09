Public Class CarrerasDAO
    Public ReadOnly Property Carreras As Collection

    Public Sub New()
        Me.Carreras = New Collection
    End Sub

    Public Sub LeerTodas()
        Dim car As Carrera

        Dim gp As GP
        gp = New GP()
        gp.LeerTodosGPs()

        Dim pil As Piloto
        pil = New Piloto()
        pil.LeerTodosPilotos()

        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.carreras ORDER BY Temporada, GP, Posicion")
        For Each aux In col
            car = New Carrera(aux(1), gp.LeerIDPGP(aux(2)), pil.LeerIDPiloto(aux(3)))
            car.Posicion = aux(4)
            car.Puntos = aux(5)
            Me.Carreras.Add(car)
        Next
    End Sub

    Public Sub Leer(ByRef car As Carrera)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM formulauno.carreras WHERE Temporada='" & car.Temporada & "' AND GP='" & car.GP.IdGP & "' AND Piloto='" & car.Piloto.IdPiloto & "';")
        For Each aux In col
            car.Posicion = aux(4)
            car.Puntos = aux(5)
        Next
    End Sub

    Public Function Insertar(ByVal car As Carrera) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO formulauno.carreras(Temporada, GP, Piloto, Posicion, Puntos) VALUES ('" & car.Temporada & "', '" & car.GP.IdGP & "' , '" & car.Piloto.IdPiloto & "' ,'" & car.Posicion & "' ,'" & car.Puntos & "');")
    End Function

    Public Function Borrar(ByVal car As Carrera) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.carreras WHERE Temporada='" & car.Temporada & "' AND GP='" & car.GP.IdGP & "' AND Piloto='" & car.Piloto.IdPiloto & "';")
    End Function

    Public Sub BorrarTodas(ByVal temporada As Short)
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM formulauno.carreras ORDER BY Temporada, GP, Posicion")
        For Each aux In col

            AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.carreras WHERE Temporada='" & temporada & "';")

        Next
    End Sub

    Public Sub BorrarTablaCompleta()
        AgenteBD.ObtenerAgente.Modificar("DELETE FROM formulauno.carreras;")
    End Sub

    Public Function ObtenerClasificacionPilotosDAO(ByVal Temporada As Short) As Collection
        Return AgenteBD.ObtenerAgente.Leer("SELECT Piloto, SUM(Puntos) AS TotalPuntos
        FROM formulauno.carreras
        WHERE Temporada = '" & Temporada & "'
        GROUP BY Piloto
        ORDER BY TotalPuntos DESC;")
    End Function

    Public Function ObtenerClasificacionEscuderiasDAO(ByVal Temporada As Short) As Collection
        Return AgenteBD.ObtenerAgente.Leer("SELECT e.IdEscuderia, SUM(ca.Puntos) AS PuntosTotales
        FROM formulauno.escuderias e
        JOIN formulauno.contratos co ON e.IdEscuderia = co.Escuderia AND co.Temporada = " & Temporada & "
        JOIN formulauno.carreras ca ON co.Temporada = ca.Temporada AND (co.Piloto1 = ca.Piloto OR co.Piloto2 = ca.Piloto)
        WHERE ca.Temporada = " & Temporada & "
        GROUP BY e.IdEscuderia
        ORDER BY PuntosTotales DESC;")
    End Function

End Class
