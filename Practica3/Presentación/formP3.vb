Imports System
Imports System.Numerics
Imports Windows.Win32.System

Public Class formP3

    ' ---------- Conectar ---------- '

    Private Sub formP3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ConectarBD()

    End Sub

    Private Sub ConectarBD()

        LB_Pais.Items.Clear()
        LB_Piloto.Items.Clear()
        LB_GP.Items.Clear()
        LB_Escuderia.Items.Clear()

        LV_InfoContratos.Items.Clear()
        LB_InfoCalendario.Items.Clear()
        LV_InfoCarreras.Items.Clear()

        LV_Clasificacion.Items.Clear()

        CB_PaisPiloto.Items.Clear()
        CB_PaisGP.Items.Clear()
        CB_PaisEscuderia.Items.Clear()
        CB_PaisCampeones.Items.Clear()

        ConectarPais()
        ConectarPiloto()
        ConectarGP()
        ConectarEscuderia()

        ActualizarInformacionContratoTemporada()
        ActualizarInformacionCalendarioTemporada()

        If CHB_PilotosClasif.Checked = True Then

            CalcularClasifPilotos()

        Else

            CalcularClasifEscuderias()

        End If

        If CHB_HistPilotos.Checked = True Then

            ActualizarInformacionHistorialPilotos()

        Else

            ActualizarInformacionHistorialEscuderias()

        End If

        ActualizarResultados()

        ActualizarInformacionCampeones()

    End Sub

    ' ---------- TabPais ---------- '

    Private p As Pais

    Private Sub ConectarPais()

        Dim pAux As Pais
        p = New Pais

        Try
            p.LeerTodosPaises()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each pAux In p.PaisDAO.Paises

            LB_Pais.Items.Add(pAux.IdPais & " -> " & pAux.NombrePais)
            CB_PaisPiloto.Items.Add(pAux.IdPais)
            CB_PaisGP.Items.Add(pAux.IdPais)
            CB_PaisEscuderia.Items.Add(pAux.IdPais)
            CB_PaisCampeones.Items.Add(pAux.IdPais)

        Next

        BT_AnadirPais.Enabled = True

        TB_IDPais.Enabled = False

    End Sub

    Private Sub LB_Pais_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Pais.SelectedIndexChanged

        BT_ActualizarPais.Enabled = True
        BT_EliminarPais.Enabled = True

        If Not LB_Pais.SelectedItem Is Nothing Then

            p = New Pais(LB_Pais.SelectedItem.ToString.Split(" ")(0))

            Try
                p.LeerPais()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            TB_IDPais.Text = p.IdPais.ToString
            TB_NomPais.Text = p.NombrePais.ToString
            TB_HabPais.Text = p.HabitantesPais.ToString

        End If

    End Sub

    Private Sub BT_AnadirPais_Click(sender As Object, e As EventArgs) Handles BT_AnadirPais.Click

        If TB_NomPais.Text <> String.Empty And TB_HabPais.Text <> String.Empty Then

            Try
                If TB_HabPais.Text < 0 Then
                    MessageBox.Show("No se ha podido añadir el país porque el número de habitantes no puede ser negativo")
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show("Error al crear el país (el número de habitantes debe de ser un número)")
                Exit Sub
            End Try

            p = New Pais
            p.NombrePais = TB_NomPais.Text
            p.HabitantesPais = TB_HabPais.Text

            If TB_IDPais.Enabled = False Then
                If p.NombrePais.Length >= 3 Then
                    p.IdPais = p.NombrePais.Substring(0, 3).ToUpper
                Else
                    p.IdPais = TB_IDPais.Text.ToUpper
                End If

            Else

                If TB_IDPais.Text.Length = 3 Then
                    p.IdPais = TB_IDPais.Text.ToUpper
                Else
                    MessageBox.Show("Error al añadir el país (el ID tiene que tener 3 caracteres), vuelva a introducirlo")
                    TB_IDPais.Clear()
                    Exit Sub
                End If

            End If

            TB_IDPais.Text = p.IdPais

            Try
                If p.InsertarPais <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show("Error al añadir el país (ID ya existente), introduzca un ID manualmente")
                TB_IDPais.Clear()
                TB_IDPais.Enabled = True
                TB_NomPais.Enabled = False
                TB_HabPais.Enabled = False
                Exit Sub
            End Try

            ConectarBD()

            BT_LimpiarPais.PerformClick()

        Else

            MessageBox.Show("Faltan datos por introducir")

        End If

    End Sub

    Private Sub BT_ActualizarPais_Click(sender As Object, e As EventArgs) Handles BT_ActualizarPais.Click

        If Not p Is Nothing Then

            Try
                If TB_HabPais.Text < 0 Then
                    MessageBox.Show("No se ha podido añadir el país porque el número de habitantes no puede ser negativo")
                    TB_HabPais.Text = p.HabitantesPais
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show("Error al crear el país (el número de habitantes debe de ser un número)")
                TB_HabPais.Text = p.HabitantesPais
                Exit Sub
            End Try

            p.NombrePais = TB_NomPais.Text
            p.HabitantesPais = TB_HabPais.Text

            TB_IDPais.Text = p.IdPais

            Try
                If p.ActualizarPais() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            MessageBox.Show(p.NombrePais & " actualizando correctamente!")

            ConectarBD()
            BT_LimpiarPais.PerformClick()

        End If

    End Sub

    Private Sub BT_EliminarPais_Click(sender As Object, e As EventArgs) Handles BT_EliminarPais.Click

        If Not p Is Nothing Then

            If MessageBox.Show("¿Estás seguro de que quieres borrar " & p.NombrePais & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Try
                    If p.BorrarPais <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se ha podido eliminar el país debido a una restricción en la base de datos")
                    Exit Sub
                End Try

                ConectarBD()

                BT_LimpiarPais.PerformClick()

            End If



        End If

    End Sub

    Private Sub BT_LimpiarPais_Click(sender As Object, e As EventArgs) Handles BT_LimpiarPais.Click

        TB_IDPais.Text = String.Empty
        TB_NomPais.Text = String.Empty
        TB_HabPais.Text = String.Empty

        TB_IDPais.Enabled = False
        TB_NomPais.Enabled = True
        TB_HabPais.Enabled = True

        BT_ActualizarPais.Enabled = False
        BT_EliminarPais.Enabled = False

    End Sub

    ' ---------- TabPiloto ---------- '

    Private pil As Piloto

    Private Sub ConectarPiloto()

        Dim pilAux As Piloto
        pil = New Piloto

        Try
            pil.LeerTodosPilotos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each pilAux In pil.PilotoDAO.Pilotos
            LB_Piloto.Items.Add(pilAux.IdPiloto & " -> " & pilAux.NombrePiloto & " " & pilAux.ApellidoPiloto)
        Next

        BT_AnadirPiloto.Enabled = True

        TB_IDPiloto.Enabled = False

    End Sub

    Private Sub LB_Piloto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Piloto.SelectedIndexChanged

        BT_ActualizarPiloto.Enabled = True
        BT_EliminarPiloto.Enabled = True

        If Not LB_Piloto.SelectedItem Is Nothing Then

            pil = New Piloto(LB_Piloto.SelectedItem.ToString.Split(" "c)(0))

            Try
                pil.LeerPiloto()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            TB_IDPiloto.Text = pil.IdPiloto
            TB_NomPiloto.Text = pil.NombrePiloto.ToString
            TB_ApePiloto.Text = pil.ApellidoPiloto.ToString
            CB_PaisPiloto.Text = pil.PaisPiloto.IdPais.ToString

        End If

    End Sub

    Private Sub BT_AnadirPiloto_Click(sender As Object, e As EventArgs) Handles BT_AnadirPiloto.Click

        If TB_NomPiloto.Text <> String.Empty And TB_ApePiloto.Text <> String.Empty And CB_PaisPiloto.Text <> String.Empty Then

            Dim p As Pais
            p = New Pais()
            p.LeerTodosPaises()

            pil = New Piloto
            pil.NombrePiloto = TB_NomPiloto.Text
            pil.ApellidoPiloto = TB_ApePiloto.Text
            pil.PaisPiloto = p.LeerIDPais(CB_PaisPiloto.Text)

            Try
                If pil.InsertarPiloto <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            ConectarBD()

            BT_LimpiarPiloto.PerformClick()

        Else

            MessageBox.Show("Faltan datos por introducir")

        End If

    End Sub

    Private Sub BT_ActualizarPiloto_Click(sender As Object, e As EventArgs) Handles BT_ActualizarPiloto.Click

        If Not pil Is Nothing Then

            Dim p As Pais
            p = New Pais()
            p.LeerTodosPaises()

            pil.NombrePiloto = TB_NomPiloto.Text
            pil.ApellidoPiloto = TB_ApePiloto.Text
            pil.PaisPiloto = p.LeerIDPais(CB_PaisPiloto.Text)

            Try
                If pil.ActualizarPiloto <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            MessageBox.Show(pil.NombrePiloto & " " & pil.ApellidoPiloto & " actualizando correctamente!")

            ConectarBD()

            BT_LimpiarPiloto.PerformClick()

        End If

    End Sub

    Private Sub BT_EliminarPiloto_Click(sender As Object, e As EventArgs) Handles BT_EliminarPiloto.Click

        If Not pil Is Nothing Then

            If MessageBox.Show("¿Estás seguro de que quieres borrar " & pil.NombrePiloto & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Try
                    If pil.BorrarPiloto <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se ha podido eliminar el piloto debido a una restricción en la base de datos")
                    Exit Sub
                End Try

                ConectarBD()

                BT_LimpiarPiloto.PerformClick()

            End If


        End If

    End Sub

    Private Sub BT_LimpiarPiloto_Click(sender As Object, e As EventArgs) Handles BT_LimpiarPiloto.Click

        TB_IDPiloto.Text = String.Empty
        TB_NomPiloto.Text = String.Empty
        TB_ApePiloto.Text = String.Empty
        CB_PaisPiloto.Text = String.Empty
        BT_ActualizarPiloto.Enabled = False
        BT_EliminarPiloto.Enabled = False

    End Sub

    ' ---------- TabGP ---------- '

    Private gp As GP

    Private Sub ConectarGP()

        Dim gpAux As GP
        gp = New GP

        Try
            gp.LeerTodosGPs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each gpAux In gp.GPDAO.GPs
            LB_GP.Items.Add(gpAux.IdGP & " -> " & gpAux.DenominacionGP)
        Next

        BT_AnadirGP.Enabled = True

        TB_IDGP.Enabled = False

    End Sub

    Private Sub LB_GP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_GP.SelectedIndexChanged

        BT_ActualizarGP.Enabled = True
        BT_EliminarGP.Enabled = True

        If Not LB_GP.SelectedItem Is Nothing Then

            gp = New GP(LB_GP.SelectedItem.ToString.Split(" "c)(0))

            Try
                gp.LeerGP()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            TB_IDGP.Text = gp.IdGP
            TB_DenominacionGP.Text = gp.DenominacionGP.ToString
            CB_PaisGP.Text = gp.PaisGP.IdPais.ToString

        End If

    End Sub

    Private Sub BT_AnadirGP_Click(sender As Object, e As EventArgs) Handles BT_AnadirGP.Click

        If TB_DenominacionGP.Text <> String.Empty And CB_PaisGP.Text <> String.Empty Then

            Dim p As Pais
            p = New Pais()
            p.LeerTodosPaises()

            gp = New GP
            gp.DenominacionGP = TB_DenominacionGP.Text
            gp.PaisGP = p.LeerIDPais(CB_PaisGP.Text)

            Try
                If gp.InsertarGP <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            ConectarBD()

            BT_LimpiarGP.PerformClick()

        Else

            MessageBox.Show("Faltan datos por introducir")

        End If

    End Sub

    Private Sub BT_ActualizarGP_Click(sender As Object, e As EventArgs) Handles BT_ActualizarGP.Click

        If Not gp Is Nothing Then

            Dim p As Pais
            p = New Pais()
            p.LeerTodosPaises()

            gp.DenominacionGP = TB_DenominacionGP.Text
            gp.PaisGP = p.LeerIDPais(CB_PaisGP.Text)

            Try
                If gp.ActualizarGP() <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            MessageBox.Show(gp.DenominacionGP & " actualizando correctamente!")

            ConectarBD()

            BT_LimpiarGP.PerformClick()

        End If

    End Sub

    Private Sub BT_EliminarGP_Click(sender As Object, e As EventArgs) Handles BT_EliminarGP.Click

        If Not gp Is Nothing Then

            If MessageBox.Show("¿Estás seguro de que quieres borrar " & gp.DenominacionGP & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Try
                    If gp.BorrarGP <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se ha podido eliminar el GP debido a una restricción en la base de datos")
                    Exit Sub
                End Try

                ConectarBD()

                BT_LimpiarGP.PerformClick()

            End If

        End If

    End Sub

    Private Sub BT_LimpiarGP_Click(sender As Object, e As EventArgs) Handles BT_LimpiarGP.Click

        TB_IDGP.Text = String.Empty
        TB_DenominacionGP.Text = String.Empty
        CB_PaisGP.Text = String.Empty
        BT_ActualizarGP.Enabled = False
        BT_EliminarGP.Enabled = False

    End Sub

    ' ---------- TabEscuderia ---------- '

    Private esc As Escuderia

    Private Sub ConectarEscuderia()

        Dim escAux As Escuderia
        esc = New Escuderia

        Try
            esc.LeerTodasEscuderias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each escAux In esc.EscuderiaDAO.Escuderias
            LB_Escuderia.Items.Add(escAux.IdEscuderia & " -> " & escAux.NombreEscuderia)
        Next

        BT_AnadirEscuderia.Enabled = True

        TB_IDEscuderia.Enabled = False

    End Sub

    Private Sub LB_Escuderia_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Escuderia.SelectedIndexChanged

        BT_ActualizarEscuderia.Enabled = True
        BT_EliminarEscuderia.Enabled = True

        If Not LB_Escuderia.SelectedItem Is Nothing Then

            esc = New Escuderia(LB_Escuderia.SelectedItem.ToString.Split(" "c)(0))

            Try
                esc.LeerEscuderia()
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            TB_IDEscuderia.Text = esc.IdEscuderia
            TB_NomEscuderia.Text = esc.NombreEscuderia.ToString
            CB_PaisEscuderia.Text = esc.PaisEscuderia.IdPais.ToString
            DTP_FechaCreacionEscuderia.Value = esc.FechaCreacionEscuderia

        End If

    End Sub

    Private Sub BT_AnadirEscuderia_Click(sender As Object, e As EventArgs) Handles BT_AnadirEscuderia.Click

        If TB_NomEscuderia.Text <> String.Empty And CB_PaisEscuderia.Text <> String.Empty Then

            Dim p As Pais
            p = New Pais()
            p.LeerTodosPaises()

            esc = New Escuderia
            esc.NombreEscuderia = TB_NomEscuderia.Text
            esc.PaisEscuderia = p.LeerIDPais(CB_PaisEscuderia.Text)
            esc.FechaCreacionEscuderia = DTP_FechaCreacionEscuderia.Value.Date

            Try
                If esc.InsertarEscuderia <> 1 Then
                    MessageBox.Show("INSERT return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            ConectarBD()

            BT_LimpiarEscuderia.PerformClick()

        Else

            MessageBox.Show("Faltan datos por introducir")

        End If

    End Sub

    Private Sub BT_ActualizarEscuderia_Click(sender As Object, e As EventArgs) Handles BT_ActualizarEscuderia.Click

        If Not esc Is Nothing Then

            Dim p As Pais
            p = New Pais()
            p.LeerTodosPaises()

            esc.NombreEscuderia = TB_NomEscuderia.Text
            esc.PaisEscuderia = p.LeerIDPais(CB_PaisEscuderia.Text)
            esc.FechaCreacionEscuderia = DTP_FechaCreacionEscuderia.Value.Date

            Try
                If esc.ActualizarEscuderia <> 1 Then
                    MessageBox.Show("UPDATE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End Try

            MessageBox.Show(esc.NombreEscuderia & " actualizando correctamente!")

            ConectarBD()

            BT_LimpiarEscuderia.PerformClick()

        End If

    End Sub

    Private Sub BT_EliminarEscuderia_Click(sender As Object, e As EventArgs) Handles BT_EliminarEscuderia.Click

        If Not esc Is Nothing Then

            If MessageBox.Show("¿Estás seguro de que quieres borrar " & esc.NombreEscuderia & "?", "Por favor, confirma", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                Try
                    If esc.BorrarEscuderia <> 1 Then
                        MessageBox.Show("DELETE return <> 1", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Catch ex As Exception
                    MessageBox.Show("No se ha podido eliminar la escudería debido a una restricción en la base de datos")
                    Exit Sub
                End Try

                ConectarBD()

                BT_LimpiarEscuderia.PerformClick()

            End If


        End If

    End Sub

    Private Sub BT_LimpiarEscuderia_Click(sender As Object, e As EventArgs) Handles BT_LimpiarEscuderia.Click

        TB_IDEscuderia.Text = String.Empty
        TB_NomEscuderia.Text = String.Empty
        CB_PaisEscuderia.Text = String.Empty
        BT_ActualizarEscuderia.Enabled = False
        BT_EliminarEscuderia.Enabled = False

    End Sub

    ' ---------- TabTemporada ---------- '

    Private Sub Shuffle(Of T)(ByRef list As List(Of T))

        Dim rnd As New Random()
        Dim n As Integer = list.Count

        While n > 1

            n -= 1
            Dim k As Integer = rnd.Next(n + 1)
            Dim value As T = list(k)
            list(k) = list(n)
            list(n) = value

        End While

    End Sub

    Private Sub BorrarTemporada(ByVal temporada As Short)

        Dim car As Carrera
        car = New Carrera()
        car.BorrarTodasCarreras(temporada)

        Dim cal As Calendario
        cal = New Calendario()
        cal.BorrarTodosCalendarios(temporada)

        Dim con As Contrato
        con = New Contrato()
        con.BorrarTodosContratos(temporada)

        LV_InfoCarreras.Items.Clear()
        LB_InfoCalendario.Items.Clear()
        LV_InfoContratos.Items.Clear()

    End Sub

    Private Sub BT_GenerarTemporada_Click(sender As Object, e As EventArgs) Handles BT_GenerarTemporada.Click

        LV_InfoCarreras.Items.Clear()
        LB_InfoCalendario.Items.Clear()
        LV_InfoContratos.Items.Clear()

        BorrarTemporada(NU_Temporada.Value)
        GenerarContratos()
        GenerarCalendario()
        GenerarCarreras()

        If CHB_PilotosClasif.Checked = True Then

            CalcularClasifPilotos()

        Else

            CalcularClasifEscuderias()

        End If

        ActualizarResultados()

        ActualizarInformacionCampeones()

    End Sub

    Private Sub GenerarContratos()

        Dim nEscuderias As Integer
        Dim Temporada As Short

        nEscuderias = NU_Escuderia.Value
        Temporada = NU_Temporada.Value

        ' Creamos la lista de Pilotos usando el DAO y la desordenamos' 

        Dim ListaPilotos As New List(Of Piloto)

        Dim pilAux As Piloto
        Dim pil As Piloto
        pil = New Piloto()

        Try
            pil.LeerTodosPilotos()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each pilAux In pil.PilotoDAO.Pilotos
            ListaPilotos.Add(pilAux)
        Next

        Shuffle(ListaPilotos)

        'Creamos la lista de Escuderías usando el DAO y la desordenamos' 

        Dim ListaEscuderias As New List(Of Escuderia)

        Dim escAux As Escuderia
        Dim esc As Escuderia
        esc = New Escuderia

        Try
            esc.LeerTodasEscuderias()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each escAux In esc.EscuderiaDAO.Escuderias
            ListaEscuderias.Add(escAux)
        Next

        Shuffle(ListaEscuderias)

        'Teniendo ambas listas mezcladas, generaremos los contratos'

        Dim con As Contrato

        For i As Integer = 0 To nEscuderias - 1
            con = New Contrato(ListaEscuderias(i), Temporada)
            con.Piloto1 = ListaPilotos(i * 2)
            con.Piloto2 = ListaPilotos(i * 2 + 1)
            con.InsertarContrato()
        Next

        ActualizarInformacionContratoTemporada()

    End Sub

    Private Sub ActualizarInformacionContratoTemporada()

        LV_InfoContratos.Items.Clear()

        Dim Temporada As Short

        Temporada = NU_Temporada.Value

        Dim con As Contrato
        con = New Contrato()

        con.LeerTodosContratos()


        For Each item As Contrato In con.ContratoDAO.Contratos

            Dim NombreEscuderia As String

            NombreEscuderia = item.Escuderia.NombreEscuderia

            Dim Piloto1 As Piloto
            Dim Piloto2 As Piloto

            Piloto1 = item.Piloto1
            Piloto2 = item.Piloto2

            If item.Temporada = Temporada Then
                Dim newItem As New ListViewItem({NombreEscuderia, Piloto1.NombrePiloto & " " & Piloto1.ApellidoPiloto, Piloto2.NombrePiloto & " " & Piloto2.ApellidoPiloto})
                LV_InfoContratos.Items.Add(newItem)
            End If

        Next

    End Sub

    Private Sub NU_Temporada_ValueChanged(sender As Object, e As EventArgs) Handles NU_Temporada.ValueChanged

        NU_TempClasif.Value = NU_Temporada.Value

        ActualizarInformacionContratoTemporada()
        ActualizarInformacionCalendarioTemporada()
        LV_InfoCarreras.Items.Clear()

    End Sub

    Private Sub GenerarCalendario()

        Dim nGPs As Integer
        Dim Temporada As Short

        nGPs = NU_GP.Value
        Temporada = NU_Temporada.Value

        ' Creamos la lista de GPs usando el DAO y la desordenamos' 

        Dim ListaGPs As New List(Of GP)

        Dim gpAux As GP
        Dim gp As GP
        gp = New GP

        Try
            gp.LeerTodosGPs()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

        For Each gpAux In gp.GPDAO.GPs
            ListaGPs.Add(gpAux)
        Next

        Shuffle(ListaGPs)

        'Teniendo la lista de GPs desordenada, generaremos el calendario'

        Dim cal As Calendario

        Try

            For orden As Integer = 0 To nGPs - 1
                cal = New Calendario(Temporada, ListaGPs(orden))
                cal.Orden = orden
                cal.InsertarCalendario()
            Next

        Catch ex As Exception

            MessageBox.Show("No hay suficientes datos")
            BorrarTemporada(Temporada)

            Exit Sub

        End Try

        ActualizarInformacionCalendarioTemporada()

    End Sub

    Private Sub ActualizarInformacionCalendarioTemporada()

        LB_InfoCalendario.Items.Clear()

        Dim Temporada As Short

        Temporada = NU_Temporada.Value

        Dim cal As Calendario
        cal = New Calendario()

        cal.LeerTodosCalendarios()

        For Each item As Calendario In cal.CalendarioDAO.Calendarios

            Dim DenominacionGP As String

            DenominacionGP = item.GP.DenominacionGP

            Dim Orden As Byte

            Orden = item.Orden

            If item.Temporada = Temporada Then
                LB_InfoCalendario.Items.Add(Orden & " -> " & DenominacionGP)
            End If

        Next

    End Sub

    Private Sub GenerarCarreras()

        Dim Temporada As Short
        Temporada = NU_Temporada.Value

        Dim ListaPilotos As New List(Of Piloto)

        Dim cal As Calendario
        cal = New Calendario()
        cal.LeerTodosCalendarios()

        Dim con As Contrato
        con = New Contrato()
        con.LeerTodosContratos()

        Dim car As Carrera
        Dim posicion As Byte
        posicion = 1

        For Each itemCon As Contrato In con.ContratoDAO.Contratos

            If itemCon.Temporada = Temporada Then

                ListaPilotos.Add(itemCon.Piloto1)
                ListaPilotos.Add(itemCon.Piloto2)

            End If

        Next

        For Each itemCal As Calendario In cal.CalendarioDAO.Calendarios

            If itemCal.Temporada = Temporada Then

                Shuffle(ListaPilotos)
                posicion = 1

                For Each pil As Piloto In ListaPilotos

                    car = New Carrera(Temporada, itemCal.GP, pil)
                    car.Posicion = posicion

                    Select Case posicion

                        Case 1
                            car.Puntos = 10
                        Case 2
                            car.Puntos = 6
                        Case 3
                            car.Puntos = 4
                        Case 4
                            car.Puntos = 3
                        Case 5
                            car.Puntos = 2
                        Case 6
                            car.Puntos = 1
                        Case Else
                            car.Puntos = 0

                    End Select

                    car.InsertarCarrera()
                    posicion = posicion + 1

                Next

            End If

        Next

    End Sub

    Private Sub ActualizarInformacionCarrerasTemporada(idGP As Integer)

        LV_InfoCarreras.Items.Clear()

        Dim Temporada As Short
        Temporada = NU_Temporada.Value

        Dim car As Carrera
        car = New Carrera()
        car.LeerTodasCarreras()

        Dim pil As Piloto
        pil = New Piloto()
        pil.LeerTodosPilotos()

        Dim pilAux As Piloto

        For Each item As Carrera In car.CarreraDAO.Carreras

            If item.GP.IdGP = idGP And item.Temporada = Temporada Then

                pilAux = item.Piloto
                Dim newItem As New ListViewItem({item.Posicion & "º) ", pilAux.NombrePiloto.Substring(0, 1) & ". " & pilAux.ApellidoPiloto, item.Puntos})
                LV_InfoCarreras.Items.Add(newItem)

            End If

        Next

    End Sub

    Private Sub BT_EliminarTemporada_Click(sender As Object, e As EventArgs) Handles BT_EliminarTemporada.Click

        BorrarTemporada(NU_Temporada.Value)
        LV_Clasificacion.Items.Clear()

        ActualizarResultados()

        ActualizarInformacionCampeones()

    End Sub

    Private Sub BT_EliminarTemporadas_Click(sender As Object, e As EventArgs) Handles BT_EliminarTemporadas.Click

        Dim car As Carrera
        car = New Carrera()
        car.BorrarTablaCarreras()

        Dim cal As Calendario
        cal = New Calendario()
        cal.BorrarTablaCalendarios()

        Dim con As Contrato
        con = New Contrato()
        con.BorrarTablaContratos()

        LV_InfoCarreras.Items.Clear()
        LB_InfoCalendario.Items.Clear()
        LV_InfoContratos.Items.Clear()

        LV_Clasificacion.Items.Clear()

        ActualizarResultados()

        ActualizarInformacionCampeones()

    End Sub



    Private Sub CHB_MostrarContratos_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_MostrarContratos.CheckedChanged

        If CHB_MostrarContratos.Checked = True Then

            CHB_MostrarCalendarioYCarreras.Checked = False

            LV_InfoContratos.Visible = True
            LB_InfoCalendario.Visible = False
            LV_InfoCarreras.Visible = False
            LBL_Contratos.Visible = True
            LBL_Calendario.Visible = False
            LBL_Carreras.Visible = False

        Else

            CHB_MostrarCalendarioYCarreras.Checked = True

        End If

    End Sub

    Private Sub CHB_MostrarCalendarioYCarreras_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_MostrarCalendarioYCarreras.CheckedChanged

        If CHB_MostrarCalendarioYCarreras.Checked = True Then

            CHB_MostrarContratos.Checked = False

            LV_InfoContratos.Visible = False
            LB_InfoCalendario.Visible = True
            LV_InfoCarreras.Visible = True
            LBL_Contratos.Visible = False
            LBL_Calendario.Visible = True
            LBL_Carreras.Visible = True

        Else

            CHB_MostrarContratos.Checked = True

        End If

    End Sub

    Private Sub LB_InfoCalendario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_InfoCalendario.SelectedIndexChanged

        Dim Temporada As Short
        Temporada = NU_Temporada.Value

        Dim cal As Calendario
        cal = New Calendario()
        cal.LeerTodosCalendarios()

        Dim ordenGP As Byte
        ordenGP = Byte.Parse(LB_InfoCalendario.SelectedItem.Split(" ")(0))

        Dim idGP As Integer

        For Each itemCal As Calendario In cal.CalendarioDAO.Calendarios

            If itemCal.Orden = ordenGP And itemCal.Temporada = Temporada Then

                idGP = itemCal.GP.IdGP
                Exit For

            End If

        Next

        ActualizarInformacionCarrerasTemporada(idGP)


    End Sub

    Private Sub BT_Random_Click(sender As Object, e As EventArgs) Handles BT_Random.Click

        Randomize()

        NU_Escuderia.Value = GenerarEnteroAleatorio(5, 10)
        NU_GP.Value = GenerarEnteroAleatorio(10, 20)

    End Sub

    Function GenerarEnteroAleatorio(minimo As Integer, maximo As Integer) As Integer
        ' Genera un número aleatorio entre 0 y 1
        Dim numeroAleatorio As Double
        numeroAleatorio = Rnd()

        ' Escala el número aleatorio al rango deseado y lo redondea al entero más cercano
        GenerarEnteroAleatorio = Int((maximo - minimo + 1) * numeroAleatorio + minimo)
    End Function

    ' ---------- TabInformes ---------- '

    ' ---------- SubTabClasificación ---------- '

    Private Sub NU_TempClasif_ValueChanged(sender As Object, e As EventArgs) Handles NU_TempClasif.ValueChanged

        NU_Temporada.Value = NU_TempClasif.Value

        If CHB_PilotosClasif.Checked = True Then

            CalcularClasifPilotos()

        Else

            CalcularClasifEscuderias()

        End If

    End Sub

    Private Sub CHB_PilotosClasif_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_PilotosClasif.CheckedChanged

        If CHB_PilotosClasif.Checked = True Then

            CHB_EscClasif.Checked = False
            CalcularClasifPilotos()

        Else

            CHB_EscClasif.Checked = True

        End If

    End Sub

    Private Sub CHB_EscClasif_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_EscClasif.CheckedChanged

        If CHB_EscClasif.Checked = True Then

            CHB_PilotosClasif.Checked = False
            CalcularClasifEscuderias()

        Else

            CHB_PilotosClasif.Checked = True

        End If

    End Sub

    Private Sub CalcularClasifPilotos()

        LV_Clasificacion.Items.Clear()

        Dim Temporada As Short
        Temporada = NU_Temporada.Value

        Dim TotalPuntos As Byte

        Dim Puesto As Byte
        Puesto = 1

        Dim TablaClasifPiloto, aux As Collection

        Dim pilAux As Piloto
        pilAux = New Piloto()
        pilAux.LeerTodosPilotos()

        Dim pil As Piloto

        Dim car As Carrera
        car = New Carrera()
        TablaClasifPiloto = car.ObtenerClasificacionPilotos(Temporada)

        For Each aux In TablaClasifPiloto

            pil = pilAux.LeerIDPiloto(aux(1))
            TotalPuntos = aux(2)

            Dim newItem As New ListViewItem({Puesto.ToString & "º", pil.NombrePiloto & " " & pil.ApellidoPiloto, TotalPuntos})
            LV_Clasificacion.Items.Add(newItem)

            Select Case Puesto

                Case 1
                    LBL_PrimerPuesto.Text = pil.NombrePiloto.Substring(0, 1) & ". " & pil.ApellidoPiloto

                Case 2
                    LBL_SegundoPuesto.Text = pil.NombrePiloto.Substring(0, 1) & ". " & pil.ApellidoPiloto

                Case 3
                    LBL_TercerPuesto.Text = pil.NombrePiloto.Substring(0, 1) & ". " & pil.ApellidoPiloto


            End Select

            Puesto = Puesto + 1

        Next

    End Sub

    Private Sub CalcularClasifEscuderias()

        LV_Clasificacion.Items.Clear()

        Dim Temporada As Short
        Temporada = NU_Temporada.Value

        Dim TotalPuntos As Byte

        Dim Puesto As Byte
        Puesto = 1

        Dim TablaClasifEscuderia, aux As Collection

        Dim escAux As Escuderia
        escAux = New Escuderia()
        escAux.LeerTodasEscuderias()

        Dim esc As Escuderia

        Dim car As Carrera
        car = New Carrera()
        TablaClasifEscuderia = car.ObtenerClasificacionEscuderias(Temporada)

        For Each aux In TablaClasifEscuderia

            esc = escAux.LeerIDEscuderia(aux(1))
            TotalPuntos = aux(2)

            Dim newItem As New ListViewItem({Puesto.ToString & "º", esc.NombreEscuderia, TotalPuntos})
            LV_Clasificacion.Items.Add(newItem)

            Select Case Puesto

                Case 1
                    LBL_PrimerPuesto.Text = esc.NombreEscuderia

                Case 2
                    LBL_SegundoPuesto.Text = esc.NombreEscuderia

                Case 3
                    LBL_TercerPuesto.Text = esc.NombreEscuderia


            End Select

            Puesto = Puesto + 1

        Next

    End Sub

    ' ---------- SubTabHistorial ---------- '

    Private Sub CHB_Historico_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_Historico.CheckedChanged

        ActualizarResultados()

        If CHB_Historico.Checked = True Then

            NU_TempIni.Enabled = False
            NU_TempFin.Enabled = False

            CHB_Periodo.Checked = False

        Else

            CHB_Periodo.Checked = True

        End If

    End Sub

    Private Sub CHB_Periodo_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_Periodo.CheckedChanged

        If CHB_Periodo.Checked = True Then

            NU_TempIni.Enabled = True
            NU_TempFin.Enabled = True

            CHB_Historico.Checked = False

        Else

            CHB_Historico.Checked = True

        End If

    End Sub

    Private Sub CHB_HistPilotos_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_HistPilotos.CheckedChanged

        ActualizarResultados()

        If CHB_HistPilotos.Checked = True Then

            CHB_HistEscuderias.Checked = False
            ActualizarInformacionHistorialPilotos()

        Else

            CHB_HistEscuderias.Checked = True

        End If

    End Sub

    Private Sub CHB_HistEscuderias_CheckedChanged(sender As Object, e As EventArgs) Handles CHB_HistEscuderias.CheckedChanged

        If CHB_HistEscuderias.Checked = True Then

            CHB_HistPilotos.Checked = False
            ActualizarInformacionHistorialEscuderias()

        Else

            CHB_HistPilotos.Checked = True

        End If

    End Sub

    Private Sub NU_TempFin_ValueChanged(sender As Object, e As EventArgs) Handles NU_TempFin.ValueChanged

        ActualizarResultados()

        If NU_TempFin.Value < NU_TempIni.Value Then

            NU_TempIni.Value = NU_TempFin.Value

        End If

    End Sub

    Private Sub NU_TempIni_ValueChanged(sender As Object, e As EventArgs) Handles NU_TempIni.ValueChanged

        ActualizarResultados()

        If NU_TempIni.Value > NU_TempFin.Value Then

            NU_TempFin.Value = NU_TempIni.Value

        End If

    End Sub

    Private Sub ActualizarInformacionHistorialPilotos()

        LBL_HistSelectPilotos.Visible = True
        LBL_HistSelectEscuderia.Visible = False

        LV_HistSelect.Items.Clear()
        LV_ResultadosPil.Items.Clear()
        LV_ResultadosPil.Visible = True
        LV_ResultadosEsc.Visible = False

        Dim pil As Piloto
        pil = New Piloto()

        pil.LeerTodosPilotos()

        For Each item As Piloto In pil.PilotoDAO.Pilotos

            Dim newItem As New ListViewItem({item.IdPiloto, item.NombrePiloto & " " & item.ApellidoPiloto})
            LV_HistSelect.Items.Add(newItem)

        Next

    End Sub

    Private Sub ActualizarInformacionHistorialEscuderias()

        LBL_HistSelectPilotos.Visible = False
        LBL_HistSelectEscuderia.Visible = True

        LV_HistSelect.Items.Clear()
        LV_ResultadosEsc.Items.Clear()
        LV_ResultadosEsc.Visible = True
        LV_ResultadosPil.Visible = False

        Dim esc As Escuderia
        esc = New Escuderia()

        esc.LeerTodasEscuderias()

        For Each item As Escuderia In esc.EscuderiaDAO.Escuderias

            Dim newItem As New ListViewItem({item.IdEscuderia, item.NombreEscuderia})
            LV_HistSelect.Items.Add(newItem)

        Next

    End Sub

    Private Sub ActualizarInformacionResultadosPiloto()

        If LV_HistSelect.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        Dim pilID As Integer
        pilID = Integer.Parse(LV_HistSelect.SelectedItems(0).SubItems(0).Text)

        LV_ResultadosPil.Items.Clear()

        Dim TemporadaInicial As Short
        Dim TemporadaFinal As Short

        If CHB_Historico.Checked = True Then

            TemporadaInicial = NU_TempIni.Minimum
            TemporadaFinal = NU_TempFin.Maximum

        Else

            TemporadaInicial = NU_TempIni.Value
            TemporadaFinal = NU_TempFin.Value

        End If

        Dim car As Carrera
        car = New Carrera()

        car.LeerTodasCarreras()

        For Each item As Carrera In car.CarreraDAO.Carreras

            If item.Piloto.IdPiloto = pilID And item.Temporada >= TemporadaInicial And item.Temporada <= TemporadaFinal Then

                Dim newItem As New ListViewItem({item.Temporada, item.GP.DenominacionGP, item.Posicion, item.Puntos})
                LV_ResultadosPil.Items.Add(newItem)

            End If

        Next


    End Sub

    Private Sub ActualizarInformacionResultadosEscuderia()

        If LV_HistSelect.SelectedItems.Count = 0 Then
            Exit Sub
        End If

        Dim escID As Integer
        escID = Integer.Parse(LV_HistSelect.SelectedItems(0).SubItems(0).Text)

        LV_ResultadosEsc.Items.Clear()

        Dim TemporadaInicial As Short
        Dim TemporadaFinal As Short

        If CHB_Historico.Checked = True Then

            TemporadaInicial = NU_TempIni.Minimum
            TemporadaFinal = NU_TempFin.Maximum

        Else

            TemporadaInicial = NU_TempIni.Value
            TemporadaFinal = NU_TempFin.Value

        End If

        Dim car As Carrera
        car = New Carrera()

        car.LeerTodasCarreras()

        Dim con As Contrato
        con = New Contrato()

        con.LeerTodosContratos()

        For Each itemCon As Contrato In con.ContratoDAO.Contratos

            If itemCon.Temporada >= TemporadaInicial And itemCon.Temporada <= TemporadaFinal And itemCon.Escuderia.IdEscuderia = escID Then

                For Each itemCar As Carrera In car.CarreraDAO.Carreras

                    If (itemCon.Piloto1.IdPiloto = itemCar.Piloto.IdPiloto Or itemCon.Piloto2.IdPiloto = itemCar.Piloto.IdPiloto) And (itemCon.Temporada = itemCar.Temporada) Then

                        Dim newItem As New ListViewItem({itemCar.Temporada, itemCar.Piloto.NombrePiloto.Substring(0, 1) & ". " & itemCar.Piloto.ApellidoPiloto, itemCar.GP.DenominacionGP, itemCar.Posicion, itemCar.Puntos})
                        LV_ResultadosEsc.Items.Add(newItem)

                    End If

                Next

            End If

        Next

    End Sub

    Public Sub ActualizarResultados()

        If CHB_HistPilotos.Checked = True Then

            ActualizarInformacionResultadosPiloto()

        Else

            ActualizarInformacionResultadosEscuderia()

        End If

    End Sub

    Private Sub LV_HistSelect_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LV_HistSelect.SelectedIndexChanged

        ActualizarResultados()

    End Sub

    ' ---------- SubTabCampeones ---------- '

    Private Sub ActualizarInformacionCampeones()

        LV_Campeones.Items.Clear()

        Dim clasificacionTemporada, resultado, resultadoAux As Collection

        Dim car As Carrera
        car = New Carrera()

        car.LeerTodasCarreras()

        Dim pilAux As Piloto
        pilAux = New Piloto()

        pilAux.LeerTodosPilotos()

        Dim pil As Piloto

        Dim esc As Escuderia

        For temp As Short = 1970 To 2024

            clasificacionTemporada = car.ObtenerClasificacionPilotos(temp)

            If clasificacionTemporada.Count <> 0 Then

                resultadoAux = clasificacionTemporada(1)
                pil = pilAux.LeerIDPiloto(resultadoAux(1))

                If pil.PaisPiloto.IdPais = CB_PaisCampeones.Text Then

                    esc = ObtenerEscuderiaPiloto(temp, pil.IdPiloto)
                    resultado = CalcularPuntosVictoriasPiloto(temp, pil.IdPiloto)

                    Dim newItem As New ListViewItem({temp, pil.NombrePiloto & " " & pil.ApellidoPiloto, esc.NombreEscuderia, resultado(1).ToString, resultado(2).ToString})
                    LV_Campeones.Items.Add(newItem)

                End If

            End If

        Next

    End Sub

    Private Function ObtenerEscuderiaPiloto(ByVal temporada As Short, ByVal idPil As Integer) As Escuderia

        Dim con As Contrato
        con = New Contrato()

        con.LeerTodosContratos()

        For Each item As Contrato In con.ContratoDAO.Contratos

            If (item.Piloto1.IdPiloto = idPil Or item.Piloto2.IdPiloto = idPil) And (item.Temporada = temporada) Then

                Return item.Escuderia

            End If

        Next

        Return Nothing

    End Function

    Private Function CalcularPuntosVictoriasPiloto(ByVal temporada As Short, ByVal idPil As Integer) As Collection

        Dim car As Carrera
        car = New Carrera()

        car.LeerTodasCarreras()

        Dim puntosTotales As Byte
        puntosTotales = 0
        Dim victoriasTotales As Byte
        victoriasTotales = 0

        Dim Resultado As New Collection()

        For Each item As Carrera In car.CarreraDAO.Carreras

            If item.Temporada = temporada And item.Piloto.IdPiloto = idPil Then

                puntosTotales += item.Puntos

                If item.Posicion = 1 Then

                    victoriasTotales += 1

                End If

            End If

        Next

        Resultado.Add(victoriasTotales)
        Resultado.Add(puntosTotales)

        Return Resultado

    End Function

    Private Sub CB_PaisCampeones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_PaisCampeones.SelectedIndexChanged

        ActualizarInformacionCampeones()

    End Sub

End Class
