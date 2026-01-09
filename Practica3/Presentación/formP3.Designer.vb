<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class formP3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formP3))
        TabP3 = New TabControl()
        TabPaises = New TabPage()
        LB_Pais = New ListBox()
        BT_LimpiarPais = New Button()
        BT_EliminarPais = New Button()
        BT_ActualizarPais = New Button()
        BT_AnadirPais = New Button()
        TB_HabPais = New TextBox()
        TB_NomPais = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TB_IDPais = New TextBox()
        TabPilotos = New TabPage()
        CB_PaisPiloto = New ComboBox()
        Label7 = New Label()
        LB_Piloto = New ListBox()
        BT_LimpiarPiloto = New Button()
        BT_EliminarPiloto = New Button()
        BT_ActualizarPiloto = New Button()
        BT_AnadirPiloto = New Button()
        TB_ApePiloto = New TextBox()
        TB_NomPiloto = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TB_IDPiloto = New TextBox()
        TabEscuderias = New TabPage()
        DTP_FechaCreacionEscuderia = New DateTimePicker()
        CB_PaisEscuderia = New ComboBox()
        Label11 = New Label()
        LB_Escuderia = New ListBox()
        BT_LimpiarEscuderia = New Button()
        BT_EliminarEscuderia = New Button()
        BT_ActualizarEscuderia = New Button()
        BT_AnadirEscuderia = New Button()
        TB_NomEscuderia = New TextBox()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        TB_IDEscuderia = New TextBox()
        TabGPs = New TabPage()
        CB_PaisGP = New ComboBox()
        LB_GP = New ListBox()
        BT_LimpiarGP = New Button()
        BT_EliminarGP = New Button()
        BT_ActualizarGP = New Button()
        BT_AnadirGP = New Button()
        TB_DenominacionGP = New TextBox()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        TB_IDGP = New TextBox()
        TabTemporada = New TabPage()
        BT_Random = New Button()
        LV_InfoContratos = New ListView()
        Escuderia = New ColumnHeader()
        Piloto_1 = New ColumnHeader()
        Piloto_2 = New ColumnHeader()
        LV_InfoCarreras = New ListView()
        POS = New ColumnHeader()
        PILOTO = New ColumnHeader()
        PTS = New ColumnHeader()
        LBL_Calendario = New Label()
        LBL_Carreras = New Label()
        LBL_Contratos = New Label()
        LB_InfoCalendario = New ListBox()
        CHB_MostrarCalendarioYCarreras = New CheckBox()
        CHB_MostrarContratos = New CheckBox()
        BT_EliminarTemporadas = New Button()
        BT_EliminarTemporada = New Button()
        BT_GenerarTemporada = New Button()
        NU_GP = New NumericUpDown()
        NU_Escuderia = New NumericUpDown()
        Label17 = New Label()
        Label16 = New Label()
        Label15 = New Label()
        NU_Temporada = New NumericUpDown()
        TabInformes = New TabPage()
        TabControl1 = New TabControl()
        TabClasificacion = New TabPage()
        CHB_EscClasif = New CheckBox()
        CHB_PilotosClasif = New CheckBox()
        Label18 = New Label()
        NU_TempClasif = New NumericUpDown()
        LBL_SegundoPuesto = New Label()
        LBL_TercerPuesto = New Label()
        LBL_PrimerPuesto = New Label()
        PictureBox1 = New PictureBox()
        LV_Clasificacion = New ListView()
        PosicionClasif = New ColumnHeader()
        NombreClasif = New ColumnHeader()
        PtsClasif = New ColumnHeader()
        TabHistorial = New TabPage()
        LV_ResultadosEsc = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColPiloto = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        ColumnHeader4 = New ColumnHeader()
        LBL_HistSelectEscuderia = New Label()
        LV_HistSelect = New ListView()
        ColId = New ColumnHeader()
        ColNombre = New ColumnHeader()
        Label22 = New Label()
        NU_TempFin = New NumericUpDown()
        Label21 = New Label()
        NU_TempIni = New NumericUpDown()
        CHB_Periodo = New CheckBox()
        CHB_Historico = New CheckBox()
        CHB_HistPilotos = New CheckBox()
        CHB_HistEscuderias = New CheckBox()
        LV_ResultadosPil = New ListView()
        ColTemporada = New ColumnHeader()
        ColGP = New ColumnHeader()
        ColPos = New ColumnHeader()
        ColPts = New ColumnHeader()
        LBL_HistSelectPilotos = New Label()
        Label20 = New Label()
        TabCampeones = New TabPage()
        LV_Campeones = New ListView()
        ColumnHeader5 = New ColumnHeader()
        ColumnHeader6 = New ColumnHeader()
        ColumnHeader7 = New ColumnHeader()
        ColumnHeader8 = New ColumnHeader()
        ColumnHeader9 = New ColumnHeader()
        CB_PaisCampeones = New ComboBox()
        Label19 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        TabP3.SuspendLayout()
        TabPaises.SuspendLayout()
        TabPilotos.SuspendLayout()
        TabEscuderias.SuspendLayout()
        TabGPs.SuspendLayout()
        TabTemporada.SuspendLayout()
        CType(NU_GP, ComponentModel.ISupportInitialize).BeginInit()
        CType(NU_Escuderia, ComponentModel.ISupportInitialize).BeginInit()
        CType(NU_Temporada, ComponentModel.ISupportInitialize).BeginInit()
        TabInformes.SuspendLayout()
        TabControl1.SuspendLayout()
        TabClasificacion.SuspendLayout()
        CType(NU_TempClasif, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabHistorial.SuspendLayout()
        CType(NU_TempFin, ComponentModel.ISupportInitialize).BeginInit()
        CType(NU_TempIni, ComponentModel.ISupportInitialize).BeginInit()
        TabCampeones.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabP3
        ' 
        TabP3.Controls.Add(TabPaises)
        TabP3.Controls.Add(TabPilotos)
        TabP3.Controls.Add(TabEscuderias)
        TabP3.Controls.Add(TabGPs)
        TabP3.Controls.Add(TabTemporada)
        TabP3.Controls.Add(TabInformes)
        TabP3.Location = New Point(1, 0)
        TabP3.Name = "TabP3"
        TabP3.SelectedIndex = 0
        TabP3.Size = New Size(801, 453)
        TabP3.TabIndex = 0
        ' 
        ' TabPaises
        ' 
        TabPaises.Controls.Add(LB_Pais)
        TabPaises.Controls.Add(BT_LimpiarPais)
        TabPaises.Controls.Add(BT_EliminarPais)
        TabPaises.Controls.Add(BT_ActualizarPais)
        TabPaises.Controls.Add(BT_AnadirPais)
        TabPaises.Controls.Add(TB_HabPais)
        TabPaises.Controls.Add(TB_NomPais)
        TabPaises.Controls.Add(Label3)
        TabPaises.Controls.Add(Label2)
        TabPaises.Controls.Add(Label1)
        TabPaises.Controls.Add(TB_IDPais)
        TabPaises.Location = New Point(4, 29)
        TabPaises.Name = "TabPaises"
        TabPaises.Padding = New Padding(3)
        TabPaises.Size = New Size(793, 420)
        TabPaises.TabIndex = 0
        TabPaises.Text = "Países"
        TabPaises.UseVisualStyleBackColor = True
        ' 
        ' LB_Pais
        ' 
        LB_Pais.FormattingEnabled = True
        LB_Pais.Location = New Point(99, 37)
        LB_Pais.Name = "LB_Pais"
        LB_Pais.Size = New Size(235, 284)
        LB_Pais.TabIndex = 13
        ' 
        ' BT_LimpiarPais
        ' 
        BT_LimpiarPais.Location = New Point(571, 309)
        BT_LimpiarPais.Name = "BT_LimpiarPais"
        BT_LimpiarPais.Size = New Size(117, 68)
        BT_LimpiarPais.TabIndex = 11
        BT_LimpiarPais.Text = "Limpiar"
        BT_LimpiarPais.UseVisualStyleBackColor = True
        ' 
        ' BT_EliminarPais
        ' 
        BT_EliminarPais.Location = New Point(414, 309)
        BT_EliminarPais.Name = "BT_EliminarPais"
        BT_EliminarPais.Size = New Size(117, 68)
        BT_EliminarPais.TabIndex = 10
        BT_EliminarPais.Text = "Eliminar"
        BT_EliminarPais.UseVisualStyleBackColor = True
        ' 
        ' BT_ActualizarPais
        ' 
        BT_ActualizarPais.Location = New Point(571, 219)
        BT_ActualizarPais.Name = "BT_ActualizarPais"
        BT_ActualizarPais.Size = New Size(117, 68)
        BT_ActualizarPais.TabIndex = 9
        BT_ActualizarPais.Text = "Actualizar"
        BT_ActualizarPais.UseVisualStyleBackColor = True
        ' 
        ' BT_AnadirPais
        ' 
        BT_AnadirPais.Location = New Point(414, 219)
        BT_AnadirPais.Name = "BT_AnadirPais"
        BT_AnadirPais.Size = New Size(117, 68)
        BT_AnadirPais.TabIndex = 8
        BT_AnadirPais.Text = "Añadir"
        BT_AnadirPais.UseVisualStyleBackColor = True
        ' 
        ' TB_HabPais
        ' 
        TB_HabPais.Location = New Point(504, 143)
        TB_HabPais.Name = "TB_HabPais"
        TB_HabPais.Size = New Size(125, 27)
        TB_HabPais.TabIndex = 7
        ' 
        ' TB_NomPais
        ' 
        TB_NomPais.Location = New Point(504, 91)
        TB_NomPais.Name = "TB_NomPais"
        TB_NomPais.Size = New Size(125, 27)
        TB_NomPais.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(397, 143)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 5
        Label3.Text = "Habitantes"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(414, 91)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 4
        Label2.Text = "Nombre"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(454, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(24, 20)
        Label1.TabIndex = 3
        Label1.Text = "ID"
        ' 
        ' TB_IDPais
        ' 
        TB_IDPais.Enabled = False
        TB_IDPais.Location = New Point(506, 37)
        TB_IDPais.Name = "TB_IDPais"
        TB_IDPais.Size = New Size(123, 27)
        TB_IDPais.TabIndex = 2
        ' 
        ' TabPilotos
        ' 
        TabPilotos.Controls.Add(CB_PaisPiloto)
        TabPilotos.Controls.Add(Label7)
        TabPilotos.Controls.Add(LB_Piloto)
        TabPilotos.Controls.Add(BT_LimpiarPiloto)
        TabPilotos.Controls.Add(BT_EliminarPiloto)
        TabPilotos.Controls.Add(BT_ActualizarPiloto)
        TabPilotos.Controls.Add(BT_AnadirPiloto)
        TabPilotos.Controls.Add(TB_ApePiloto)
        TabPilotos.Controls.Add(TB_NomPiloto)
        TabPilotos.Controls.Add(Label4)
        TabPilotos.Controls.Add(Label5)
        TabPilotos.Controls.Add(Label6)
        TabPilotos.Controls.Add(TB_IDPiloto)
        TabPilotos.Location = New Point(4, 29)
        TabPilotos.Name = "TabPilotos"
        TabPilotos.Padding = New Padding(3)
        TabPilotos.Size = New Size(793, 420)
        TabPilotos.TabIndex = 1
        TabPilotos.Text = "Pilotos"
        TabPilotos.UseVisualStyleBackColor = True
        ' 
        ' CB_PaisPiloto
        ' 
        CB_PaisPiloto.FormattingEnabled = True
        CB_PaisPiloto.Location = New Point(410, 84)
        CB_PaisPiloto.Name = "CB_PaisPiloto"
        CB_PaisPiloto.Size = New Size(123, 28)
        CB_PaisPiloto.TabIndex = 27
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(359, 87)
        Label7.Name = "Label7"
        Label7.Size = New Size(34, 20)
        Label7.TabIndex = 26
        Label7.Text = "País"
        ' 
        ' LB_Piloto
        ' 
        LB_Piloto.FormattingEnabled = True
        LB_Piloto.Location = New Point(102, 40)
        LB_Piloto.Name = "LB_Piloto"
        LB_Piloto.Size = New Size(235, 284)
        LB_Piloto.TabIndex = 25
        ' 
        ' BT_LimpiarPiloto
        ' 
        BT_LimpiarPiloto.Location = New Point(575, 312)
        BT_LimpiarPiloto.Name = "BT_LimpiarPiloto"
        BT_LimpiarPiloto.Size = New Size(117, 68)
        BT_LimpiarPiloto.TabIndex = 23
        BT_LimpiarPiloto.Text = "Limpiar"
        BT_LimpiarPiloto.UseVisualStyleBackColor = True
        ' 
        ' BT_EliminarPiloto
        ' 
        BT_EliminarPiloto.Location = New Point(417, 312)
        BT_EliminarPiloto.Name = "BT_EliminarPiloto"
        BT_EliminarPiloto.Size = New Size(117, 68)
        BT_EliminarPiloto.TabIndex = 22
        BT_EliminarPiloto.Text = "Eliminar"
        BT_EliminarPiloto.UseVisualStyleBackColor = True
        ' 
        ' BT_ActualizarPiloto
        ' 
        BT_ActualizarPiloto.Location = New Point(575, 220)
        BT_ActualizarPiloto.Name = "BT_ActualizarPiloto"
        BT_ActualizarPiloto.Size = New Size(117, 68)
        BT_ActualizarPiloto.TabIndex = 21
        BT_ActualizarPiloto.Text = "Actualizar"
        BT_ActualizarPiloto.UseVisualStyleBackColor = True
        ' 
        ' BT_AnadirPiloto
        ' 
        BT_AnadirPiloto.Location = New Point(417, 220)
        BT_AnadirPiloto.Name = "BT_AnadirPiloto"
        BT_AnadirPiloto.Size = New Size(117, 68)
        BT_AnadirPiloto.TabIndex = 20
        BT_AnadirPiloto.Text = "Añadir"
        BT_AnadirPiloto.UseVisualStyleBackColor = True
        ' 
        ' TB_ApePiloto
        ' 
        TB_ApePiloto.Location = New Point(635, 85)
        TB_ApePiloto.Name = "TB_ApePiloto"
        TB_ApePiloto.Size = New Size(125, 27)
        TB_ApePiloto.TabIndex = 19
        ' 
        ' TB_NomPiloto
        ' 
        TB_NomPiloto.Location = New Point(635, 44)
        TB_NomPiloto.Name = "TB_NomPiloto"
        TB_NomPiloto.Size = New Size(125, 27)
        TB_NomPiloto.TabIndex = 18
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(550, 92)
        Label4.Name = "Label4"
        Label4.Size = New Size(66, 20)
        Label4.TabIndex = 17
        Label4.Text = "Apellido"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(550, 47)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 16
        Label5.Text = "Nombre"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(359, 47)
        Label6.Name = "Label6"
        Label6.Size = New Size(24, 20)
        Label6.TabIndex = 15
        Label6.Text = "ID"
        ' 
        ' TB_IDPiloto
        ' 
        TB_IDPiloto.Enabled = False
        TB_IDPiloto.Location = New Point(410, 44)
        TB_IDPiloto.Name = "TB_IDPiloto"
        TB_IDPiloto.Size = New Size(123, 27)
        TB_IDPiloto.TabIndex = 14
        ' 
        ' TabEscuderias
        ' 
        TabEscuderias.Controls.Add(DTP_FechaCreacionEscuderia)
        TabEscuderias.Controls.Add(CB_PaisEscuderia)
        TabEscuderias.Controls.Add(Label11)
        TabEscuderias.Controls.Add(LB_Escuderia)
        TabEscuderias.Controls.Add(BT_LimpiarEscuderia)
        TabEscuderias.Controls.Add(BT_EliminarEscuderia)
        TabEscuderias.Controls.Add(BT_ActualizarEscuderia)
        TabEscuderias.Controls.Add(BT_AnadirEscuderia)
        TabEscuderias.Controls.Add(TB_NomEscuderia)
        TabEscuderias.Controls.Add(Label12)
        TabEscuderias.Controls.Add(Label13)
        TabEscuderias.Controls.Add(Label14)
        TabEscuderias.Controls.Add(TB_IDEscuderia)
        TabEscuderias.Location = New Point(4, 29)
        TabEscuderias.Name = "TabEscuderias"
        TabEscuderias.Padding = New Padding(3)
        TabEscuderias.Size = New Size(793, 420)
        TabEscuderias.TabIndex = 2
        TabEscuderias.Text = "Escuderías"
        TabEscuderias.UseVisualStyleBackColor = True
        ' 
        ' DTP_FechaCreacionEscuderia
        ' 
        DTP_FechaCreacionEscuderia.Format = DateTimePickerFormat.Short
        DTP_FechaCreacionEscuderia.Location = New Point(515, 141)
        DTP_FechaCreacionEscuderia.Name = "DTP_FechaCreacionEscuderia"
        DTP_FechaCreacionEscuderia.Size = New Size(250, 27)
        DTP_FechaCreacionEscuderia.TabIndex = 41
        ' 
        ' CB_PaisEscuderia
        ' 
        CB_PaisEscuderia.FormattingEnabled = True
        CB_PaisEscuderia.Location = New Point(342, 141)
        CB_PaisEscuderia.Name = "CB_PaisEscuderia"
        CB_PaisEscuderia.Size = New Size(123, 28)
        CB_PaisEscuderia.TabIndex = 40
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(342, 115)
        Label11.Name = "Label11"
        Label11.Size = New Size(34, 20)
        Label11.TabIndex = 39
        Label11.Text = "País"
        ' 
        ' LB_Escuderia
        ' 
        LB_Escuderia.FormattingEnabled = True
        LB_Escuderia.Location = New Point(67, 40)
        LB_Escuderia.Name = "LB_Escuderia"
        LB_Escuderia.Size = New Size(235, 284)
        LB_Escuderia.TabIndex = 38
        ' 
        ' BT_LimpiarEscuderia
        ' 
        BT_LimpiarEscuderia.Location = New Point(539, 312)
        BT_LimpiarEscuderia.Name = "BT_LimpiarEscuderia"
        BT_LimpiarEscuderia.Size = New Size(117, 68)
        BT_LimpiarEscuderia.TabIndex = 37
        BT_LimpiarEscuderia.Text = "Limpiar"
        BT_LimpiarEscuderia.UseVisualStyleBackColor = True
        ' 
        ' BT_EliminarEscuderia
        ' 
        BT_EliminarEscuderia.Location = New Point(382, 312)
        BT_EliminarEscuderia.Name = "BT_EliminarEscuderia"
        BT_EliminarEscuderia.Size = New Size(117, 68)
        BT_EliminarEscuderia.TabIndex = 36
        BT_EliminarEscuderia.Text = "Eliminar"
        BT_EliminarEscuderia.UseVisualStyleBackColor = True
        ' 
        ' BT_ActualizarEscuderia
        ' 
        BT_ActualizarEscuderia.Location = New Point(539, 220)
        BT_ActualizarEscuderia.Name = "BT_ActualizarEscuderia"
        BT_ActualizarEscuderia.Size = New Size(117, 68)
        BT_ActualizarEscuderia.TabIndex = 35
        BT_ActualizarEscuderia.Text = "Actualizar"
        BT_ActualizarEscuderia.UseVisualStyleBackColor = True
        ' 
        ' BT_AnadirEscuderia
        ' 
        BT_AnadirEscuderia.Location = New Point(382, 220)
        BT_AnadirEscuderia.Name = "BT_AnadirEscuderia"
        BT_AnadirEscuderia.Size = New Size(117, 68)
        BT_AnadirEscuderia.TabIndex = 34
        BT_AnadirEscuderia.Text = "Añadir"
        BT_AnadirEscuderia.UseVisualStyleBackColor = True
        ' 
        ' TB_NomEscuderia
        ' 
        TB_NomEscuderia.Location = New Point(515, 69)
        TB_NomEscuderia.Name = "TB_NomEscuderia"
        TB_NomEscuderia.Size = New Size(125, 27)
        TB_NomEscuderia.TabIndex = 32
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(515, 115)
        Label12.Name = "Label12"
        Label12.Size = New Size(128, 20)
        Label12.TabIndex = 31
        Label12.Text = "Fecha de creación"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(515, 47)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 20)
        Label13.TabIndex = 30
        Label13.Text = "Nombre"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(342, 47)
        Label14.Name = "Label14"
        Label14.Size = New Size(24, 20)
        Label14.TabIndex = 29
        Label14.Text = "ID"
        ' 
        ' TB_IDEscuderia
        ' 
        TB_IDEscuderia.Enabled = False
        TB_IDEscuderia.Location = New Point(342, 69)
        TB_IDEscuderia.Name = "TB_IDEscuderia"
        TB_IDEscuderia.Size = New Size(123, 27)
        TB_IDEscuderia.TabIndex = 28
        ' 
        ' TabGPs
        ' 
        TabGPs.Controls.Add(CB_PaisGP)
        TabGPs.Controls.Add(LB_GP)
        TabGPs.Controls.Add(BT_LimpiarGP)
        TabGPs.Controls.Add(BT_EliminarGP)
        TabGPs.Controls.Add(BT_ActualizarGP)
        TabGPs.Controls.Add(BT_AnadirGP)
        TabGPs.Controls.Add(TB_DenominacionGP)
        TabGPs.Controls.Add(Label8)
        TabGPs.Controls.Add(Label9)
        TabGPs.Controls.Add(Label10)
        TabGPs.Controls.Add(TB_IDGP)
        TabGPs.Location = New Point(4, 29)
        TabGPs.Name = "TabGPs"
        TabGPs.Padding = New Padding(3)
        TabGPs.Size = New Size(793, 420)
        TabGPs.TabIndex = 3
        TabGPs.Text = "GPs"
        TabGPs.UseVisualStyleBackColor = True
        ' 
        ' CB_PaisGP
        ' 
        CB_PaisGP.FormattingEnabled = True
        CB_PaisGP.Location = New Point(507, 141)
        CB_PaisGP.Name = "CB_PaisGP"
        CB_PaisGP.Size = New Size(123, 28)
        CB_PaisGP.TabIndex = 28
        ' 
        ' LB_GP
        ' 
        LB_GP.FormattingEnabled = True
        LB_GP.Location = New Point(102, 40)
        LB_GP.Name = "LB_GP"
        LB_GP.Size = New Size(235, 284)
        LB_GP.TabIndex = 24
        ' 
        ' BT_LimpiarGP
        ' 
        BT_LimpiarGP.Location = New Point(575, 312)
        BT_LimpiarGP.Name = "BT_LimpiarGP"
        BT_LimpiarGP.Size = New Size(117, 68)
        BT_LimpiarGP.TabIndex = 23
        BT_LimpiarGP.Text = "Limpiar"
        BT_LimpiarGP.UseVisualStyleBackColor = True
        ' 
        ' BT_EliminarGP
        ' 
        BT_EliminarGP.Location = New Point(417, 312)
        BT_EliminarGP.Name = "BT_EliminarGP"
        BT_EliminarGP.Size = New Size(117, 68)
        BT_EliminarGP.TabIndex = 22
        BT_EliminarGP.Text = "Eliminar"
        BT_EliminarGP.UseVisualStyleBackColor = True
        ' 
        ' BT_ActualizarGP
        ' 
        BT_ActualizarGP.Location = New Point(575, 220)
        BT_ActualizarGP.Name = "BT_ActualizarGP"
        BT_ActualizarGP.Size = New Size(117, 68)
        BT_ActualizarGP.TabIndex = 21
        BT_ActualizarGP.Text = "Actualizar"
        BT_ActualizarGP.UseVisualStyleBackColor = True
        ' 
        ' BT_AnadirGP
        ' 
        BT_AnadirGP.Location = New Point(417, 220)
        BT_AnadirGP.Name = "BT_AnadirGP"
        BT_AnadirGP.Size = New Size(117, 68)
        BT_AnadirGP.TabIndex = 20
        BT_AnadirGP.Text = "Añadir"
        BT_AnadirGP.UseVisualStyleBackColor = True
        ' 
        ' TB_DenominacionGP
        ' 
        TB_DenominacionGP.Location = New Point(507, 92)
        TB_DenominacionGP.Name = "TB_DenominacionGP"
        TB_DenominacionGP.Size = New Size(125, 27)
        TB_DenominacionGP.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(447, 145)
        Label8.Name = "Label8"
        Label8.Size = New Size(34, 20)
        Label8.TabIndex = 17
        Label8.Text = "País"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(375, 92)
        Label9.Name = "Label9"
        Label9.Size = New Size(106, 20)
        Label9.TabIndex = 16
        Label9.Text = "Denominación"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(457, 43)
        Label10.Name = "Label10"
        Label10.Size = New Size(24, 20)
        Label10.TabIndex = 15
        Label10.Text = "ID"
        ' 
        ' TB_IDGP
        ' 
        TB_IDGP.Enabled = False
        TB_IDGP.Location = New Point(509, 40)
        TB_IDGP.Name = "TB_IDGP"
        TB_IDGP.Size = New Size(123, 27)
        TB_IDGP.TabIndex = 14
        ' 
        ' TabTemporada
        ' 
        TabTemporada.Controls.Add(BT_Random)
        TabTemporada.Controls.Add(LV_InfoContratos)
        TabTemporada.Controls.Add(LV_InfoCarreras)
        TabTemporada.Controls.Add(LBL_Calendario)
        TabTemporada.Controls.Add(LBL_Carreras)
        TabTemporada.Controls.Add(LBL_Contratos)
        TabTemporada.Controls.Add(LB_InfoCalendario)
        TabTemporada.Controls.Add(CHB_MostrarCalendarioYCarreras)
        TabTemporada.Controls.Add(CHB_MostrarContratos)
        TabTemporada.Controls.Add(BT_EliminarTemporadas)
        TabTemporada.Controls.Add(BT_EliminarTemporada)
        TabTemporada.Controls.Add(BT_GenerarTemporada)
        TabTemporada.Controls.Add(NU_GP)
        TabTemporada.Controls.Add(NU_Escuderia)
        TabTemporada.Controls.Add(Label17)
        TabTemporada.Controls.Add(Label16)
        TabTemporada.Controls.Add(Label15)
        TabTemporada.Controls.Add(NU_Temporada)
        TabTemporada.Location = New Point(4, 29)
        TabTemporada.Name = "TabTemporada"
        TabTemporada.Padding = New Padding(3)
        TabTemporada.Size = New Size(793, 420)
        TabTemporada.TabIndex = 4
        TabTemporada.Text = "Temporada"
        TabTemporada.UseVisualStyleBackColor = True
        ' 
        ' BT_Random
        ' 
        BT_Random.Location = New Point(174, 72)
        BT_Random.Margin = New Padding(3, 4, 3, 4)
        BT_Random.Name = "BT_Random"
        BT_Random.Size = New Size(86, 75)
        BT_Random.TabIndex = 21
        BT_Random.Text = "Aleatorio"
        BT_Random.UseVisualStyleBackColor = True
        ' 
        ' LV_InfoContratos
        ' 
        LV_InfoContratos.Columns.AddRange(New ColumnHeader() {Escuderia, Piloto_1, Piloto_2})
        LV_InfoContratos.FullRowSelect = True
        LV_InfoContratos.GridLines = True
        LV_InfoContratos.Location = New Point(323, 55)
        LV_InfoContratos.Margin = New Padding(3, 4, 3, 4)
        LV_InfoContratos.Name = "LV_InfoContratos"
        LV_InfoContratos.ShowGroups = False
        LV_InfoContratos.Size = New Size(398, 344)
        LV_InfoContratos.TabIndex = 20
        LV_InfoContratos.UseCompatibleStateImageBehavior = False
        LV_InfoContratos.View = View.Details
        ' 
        ' Escuderia
        ' 
        Escuderia.Text = "ESCUDERÍA"
        Escuderia.Width = 90
        ' 
        ' Piloto_1
        ' 
        Piloto_1.Text = "PILOTO 1"
        Piloto_1.Width = 125
        ' 
        ' Piloto_2
        ' 
        Piloto_2.Text = "PILOTO2"
        Piloto_2.Width = 125
        ' 
        ' LV_InfoCarreras
        ' 
        LV_InfoCarreras.Columns.AddRange(New ColumnHeader() {POS, PILOTO, PTS})
        LV_InfoCarreras.FullRowSelect = True
        LV_InfoCarreras.GridLines = True
        LV_InfoCarreras.Location = New Point(525, 55)
        LV_InfoCarreras.Margin = New Padding(3, 4, 3, 4)
        LV_InfoCarreras.Name = "LV_InfoCarreras"
        LV_InfoCarreras.ShowGroups = False
        LV_InfoCarreras.Size = New Size(255, 344)
        LV_InfoCarreras.TabIndex = 19
        LV_InfoCarreras.UseCompatibleStateImageBehavior = False
        LV_InfoCarreras.View = View.Details
        ' 
        ' POS
        ' 
        POS.Text = "POS"
        POS.Width = 40
        ' 
        ' PILOTO
        ' 
        PILOTO.Text = "PILOTO"
        PILOTO.Width = 140
        ' 
        ' PTS
        ' 
        PTS.Text = "PTS"
        PTS.Width = 40
        ' 
        ' LBL_Calendario
        ' 
        LBL_Calendario.AutoSize = True
        LBL_Calendario.Location = New Point(347, 21)
        LBL_Calendario.Name = "LBL_Calendario"
        LBL_Calendario.Size = New Size(99, 20)
        LBL_Calendario.TabIndex = 18
        LBL_Calendario.Text = "CALENDARIO"
        LBL_Calendario.Visible = False
        ' 
        ' LBL_Carreras
        ' 
        LBL_Carreras.AutoSize = True
        LBL_Carreras.Location = New Point(613, 21)
        LBL_Carreras.Name = "LBL_Carreras"
        LBL_Carreras.Size = New Size(81, 20)
        LBL_Carreras.TabIndex = 17
        LBL_Carreras.Text = "CARRERAS"
        LBL_Carreras.Visible = False
        ' 
        ' LBL_Contratos
        ' 
        LBL_Contratos.AutoSize = True
        LBL_Contratos.Location = New Point(474, 21)
        LBL_Contratos.Name = "LBL_Contratos"
        LBL_Contratos.Size = New Size(92, 20)
        LBL_Contratos.TabIndex = 16
        LBL_Contratos.Text = "CONTRATOS"
        ' 
        ' LB_InfoCalendario
        ' 
        LB_InfoCalendario.FormattingEnabled = True
        LB_InfoCalendario.Location = New Point(281, 55)
        LB_InfoCalendario.Name = "LB_InfoCalendario"
        LB_InfoCalendario.Size = New Size(214, 344)
        LB_InfoCalendario.TabIndex = 14
        LB_InfoCalendario.Visible = False
        ' 
        ' CHB_MostrarCalendarioYCarreras
        ' 
        CHB_MostrarCalendarioYCarreras.AutoSize = True
        CHB_MostrarCalendarioYCarreras.Location = New Point(25, 363)
        CHB_MostrarCalendarioYCarreras.Name = "CHB_MostrarCalendarioYCarreras"
        CHB_MostrarCalendarioYCarreras.Size = New Size(223, 24)
        CHB_MostrarCalendarioYCarreras.TabIndex = 13
        CHB_MostrarCalendarioYCarreras.Text = "Mostrar calendario y carreras"
        CHB_MostrarCalendarioYCarreras.UseVisualStyleBackColor = True
        ' 
        ' CHB_MostrarContratos
        ' 
        CHB_MostrarContratos.AutoSize = True
        CHB_MostrarContratos.Checked = True
        CHB_MostrarContratos.CheckState = CheckState.Checked
        CHB_MostrarContratos.Location = New Point(25, 324)
        CHB_MostrarContratos.Name = "CHB_MostrarContratos"
        CHB_MostrarContratos.Size = New Size(148, 24)
        CHB_MostrarContratos.TabIndex = 12
        CHB_MostrarContratos.Text = "Mostrar contratos"
        CHB_MostrarContratos.UseVisualStyleBackColor = True
        ' 
        ' BT_EliminarTemporadas
        ' 
        BT_EliminarTemporadas.BackColor = Color.Red
        BT_EliminarTemporadas.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BT_EliminarTemporadas.ForeColor = SystemColors.ButtonHighlight
        BT_EliminarTemporadas.Location = New Point(16, 240)
        BT_EliminarTemporadas.Name = "BT_EliminarTemporadas"
        BT_EliminarTemporadas.Size = New Size(243, 48)
        BT_EliminarTemporadas.TabIndex = 9
        BT_EliminarTemporadas.Text = "Eliminar todas las temporadas"
        BT_EliminarTemporadas.UseVisualStyleBackColor = False
        ' 
        ' BT_EliminarTemporada
        ' 
        BT_EliminarTemporada.Location = New Point(151, 185)
        BT_EliminarTemporada.Name = "BT_EliminarTemporada"
        BT_EliminarTemporada.Size = New Size(109, 41)
        BT_EliminarTemporada.TabIndex = 8
        BT_EliminarTemporada.Text = "Eliminar"
        BT_EliminarTemporada.UseVisualStyleBackColor = True
        ' 
        ' BT_GenerarTemporada
        ' 
        BT_GenerarTemporada.Location = New Point(16, 185)
        BT_GenerarTemporada.Name = "BT_GenerarTemporada"
        BT_GenerarTemporada.Size = New Size(115, 41)
        BT_GenerarTemporada.TabIndex = 6
        BT_GenerarTemporada.Text = "Generar"
        BT_GenerarTemporada.UseVisualStyleBackColor = True
        ' 
        ' NU_GP
        ' 
        NU_GP.Location = New Point(102, 116)
        NU_GP.Maximum = New Decimal(New Integer() {20, 0, 0, 0})
        NU_GP.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        NU_GP.Name = "NU_GP"
        NU_GP.Size = New Size(58, 27)
        NU_GP.TabIndex = 5
        NU_GP.Value = New Decimal(New Integer() {10, 0, 0, 0})
        ' 
        ' NU_Escuderia
        ' 
        NU_Escuderia.Location = New Point(102, 72)
        NU_Escuderia.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        NU_Escuderia.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        NU_Escuderia.Name = "NU_Escuderia"
        NU_Escuderia.Size = New Size(58, 27)
        NU_Escuderia.TabIndex = 4
        NU_Escuderia.Value = New Decimal(New Integer() {5, 0, 0, 0})
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(16, 117)
        Label17.Name = "Label17"
        Label17.Size = New Size(33, 20)
        Label17.TabIndex = 3
        Label17.Text = "GPs"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(16, 75)
        Label16.Name = "Label16"
        Label16.Size = New Size(78, 20)
        Label16.TabIndex = 2
        Label16.Text = "Escuderías"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(16, 29)
        Label15.Name = "Label15"
        Label15.Size = New Size(85, 20)
        Label15.TabIndex = 1
        Label15.Text = "Temporada"
        ' 
        ' NU_Temporada
        ' 
        NU_Temporada.Location = New Point(102, 28)
        NU_Temporada.Maximum = New Decimal(New Integer() {2024, 0, 0, 0})
        NU_Temporada.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        NU_Temporada.Name = "NU_Temporada"
        NU_Temporada.Size = New Size(58, 27)
        NU_Temporada.TabIndex = 0
        NU_Temporada.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        ' 
        ' TabInformes
        ' 
        TabInformes.Controls.Add(TabControl1)
        TabInformes.Location = New Point(4, 29)
        TabInformes.Name = "TabInformes"
        TabInformes.Padding = New Padding(3)
        TabInformes.Size = New Size(793, 420)
        TabInformes.TabIndex = 5
        TabInformes.Text = "Informes"
        TabInformes.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabClasificacion)
        TabControl1.Controls.Add(TabHistorial)
        TabControl1.Controls.Add(TabCampeones)
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(793, 419)
        TabControl1.TabIndex = 0
        ' 
        ' TabClasificacion
        ' 
        TabClasificacion.Controls.Add(CHB_EscClasif)
        TabClasificacion.Controls.Add(CHB_PilotosClasif)
        TabClasificacion.Controls.Add(Label18)
        TabClasificacion.Controls.Add(NU_TempClasif)
        TabClasificacion.Controls.Add(LBL_SegundoPuesto)
        TabClasificacion.Controls.Add(LBL_TercerPuesto)
        TabClasificacion.Controls.Add(LBL_PrimerPuesto)
        TabClasificacion.Controls.Add(PictureBox1)
        TabClasificacion.Controls.Add(LV_Clasificacion)
        TabClasificacion.Location = New Point(4, 29)
        TabClasificacion.Name = "TabClasificacion"
        TabClasificacion.Padding = New Padding(3)
        TabClasificacion.Size = New Size(785, 386)
        TabClasificacion.TabIndex = 0
        TabClasificacion.Text = "Clasificación"
        TabClasificacion.UseVisualStyleBackColor = True
        ' 
        ' CHB_EscClasif
        ' 
        CHB_EscClasif.AutoSize = True
        CHB_EscClasif.Location = New Point(13, 105)
        CHB_EscClasif.Name = "CHB_EscClasif"
        CHB_EscClasif.Size = New Size(187, 24)
        CHB_EscClasif.TabIndex = 15
        CHB_EscClasif.Text = "Clasificación Escuderías"
        CHB_EscClasif.UseVisualStyleBackColor = True
        ' 
        ' CHB_PilotosClasif
        ' 
        CHB_PilotosClasif.AutoSize = True
        CHB_PilotosClasif.Checked = True
        CHB_PilotosClasif.CheckState = CheckState.Checked
        CHB_PilotosClasif.Location = New Point(13, 67)
        CHB_PilotosClasif.Name = "CHB_PilotosClasif"
        CHB_PilotosClasif.Size = New Size(163, 24)
        CHB_PilotosClasif.TabIndex = 14
        CHB_PilotosClasif.Text = "Clasificación Pilotos"
        CHB_PilotosClasif.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(13, 17)
        Label18.Name = "Label18"
        Label18.Size = New Size(85, 20)
        Label18.TabIndex = 6
        Label18.Text = "Temporada"
        ' 
        ' NU_TempClasif
        ' 
        NU_TempClasif.Location = New Point(98, 16)
        NU_TempClasif.Maximum = New Decimal(New Integer() {2024, 0, 0, 0})
        NU_TempClasif.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        NU_TempClasif.Name = "NU_TempClasif"
        NU_TempClasif.Size = New Size(58, 27)
        NU_TempClasif.TabIndex = 5
        NU_TempClasif.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        ' 
        ' LBL_SegundoPuesto
        ' 
        LBL_SegundoPuesto.AutoSize = True
        LBL_SegundoPuesto.Location = New Point(73, 236)
        LBL_SegundoPuesto.Name = "LBL_SegundoPuesto"
        LBL_SegundoPuesto.Size = New Size(15, 20)
        LBL_SegundoPuesto.TabIndex = 4
        LBL_SegundoPuesto.Text = "-"
        LBL_SegundoPuesto.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LBL_TercerPuesto
        ' 
        LBL_TercerPuesto.AutoSize = True
        LBL_TercerPuesto.Location = New Point(73, 312)
        LBL_TercerPuesto.Name = "LBL_TercerPuesto"
        LBL_TercerPuesto.Size = New Size(15, 20)
        LBL_TercerPuesto.TabIndex = 3
        LBL_TercerPuesto.Text = "-"
        LBL_TercerPuesto.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' LBL_PrimerPuesto
        ' 
        LBL_PrimerPuesto.AutoSize = True
        LBL_PrimerPuesto.Location = New Point(73, 161)
        LBL_PrimerPuesto.Name = "LBL_PrimerPuesto"
        LBL_PrimerPuesto.Size = New Size(15, 20)
        LBL_PrimerPuesto.TabIndex = 2
        LBL_PrimerPuesto.Text = "-"
        LBL_PrimerPuesto.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(13, 144)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(86, 228)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' LV_Clasificacion
        ' 
        LV_Clasificacion.Columns.AddRange(New ColumnHeader() {PosicionClasif, NombreClasif, PtsClasif})
        LV_Clasificacion.FullRowSelect = True
        LV_Clasificacion.GridLines = True
        LV_Clasificacion.Location = New Point(305, 17)
        LV_Clasificacion.Name = "LV_Clasificacion"
        LV_Clasificacion.Size = New Size(463, 352)
        LV_Clasificacion.TabIndex = 0
        LV_Clasificacion.UseCompatibleStateImageBehavior = False
        LV_Clasificacion.View = View.Details
        ' 
        ' PosicionClasif
        ' 
        PosicionClasif.Text = "POS"
        PosicionClasif.Width = 40
        ' 
        ' NombreClasif
        ' 
        NombreClasif.Text = "NOMBRE"
        NombreClasif.Width = 270
        ' 
        ' PtsClasif
        ' 
        PtsClasif.Text = "PTS TOTALES"
        PtsClasif.Width = 90
        ' 
        ' TabHistorial
        ' 
        TabHistorial.Controls.Add(LV_ResultadosEsc)
        TabHistorial.Controls.Add(LBL_HistSelectEscuderia)
        TabHistorial.Controls.Add(LV_HistSelect)
        TabHistorial.Controls.Add(Label22)
        TabHistorial.Controls.Add(NU_TempFin)
        TabHistorial.Controls.Add(Label21)
        TabHistorial.Controls.Add(NU_TempIni)
        TabHistorial.Controls.Add(CHB_Periodo)
        TabHistorial.Controls.Add(CHB_Historico)
        TabHistorial.Controls.Add(CHB_HistPilotos)
        TabHistorial.Controls.Add(CHB_HistEscuderias)
        TabHistorial.Controls.Add(LV_ResultadosPil)
        TabHistorial.Controls.Add(LBL_HistSelectPilotos)
        TabHistorial.Controls.Add(Label20)
        TabHistorial.Location = New Point(4, 29)
        TabHistorial.Name = "TabHistorial"
        TabHistorial.Padding = New Padding(3)
        TabHistorial.Size = New Size(785, 386)
        TabHistorial.TabIndex = 1
        TabHistorial.Text = "Historial"
        TabHistorial.UseVisualStyleBackColor = True
        ' 
        ' LV_ResultadosEsc
        ' 
        LV_ResultadosEsc.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColPiloto, ColumnHeader2, ColumnHeader3, ColumnHeader4})
        LV_ResultadosEsc.FullRowSelect = True
        LV_ResultadosEsc.GridLines = True
        LV_ResultadosEsc.Location = New Point(418, 35)
        LV_ResultadosEsc.Margin = New Padding(3, 4, 3, 4)
        LV_ResultadosEsc.Name = "LV_ResultadosEsc"
        LV_ResultadosEsc.ShowGroups = False
        LV_ResultadosEsc.Size = New Size(348, 323)
        LV_ResultadosEsc.TabIndex = 34
        LV_ResultadosEsc.UseCompatibleStateImageBehavior = False
        LV_ResultadosEsc.View = View.Details
        LV_ResultadosEsc.Visible = False
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "TEMP"
        ColumnHeader1.Width = 50
        ' 
        ' ColPiloto
        ' 
        ColPiloto.Text = "PILOTO"
        ColPiloto.Width = 85
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "GP"
        ColumnHeader2.Width = 85
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "POS"
        ColumnHeader3.Width = 40
        ' 
        ' ColumnHeader4
        ' 
        ColumnHeader4.Text = "PTS"
        ColumnHeader4.Width = 40
        ' 
        ' LBL_HistSelectEscuderia
        ' 
        LBL_HistSelectEscuderia.AutoSize = True
        LBL_HistSelectEscuderia.Location = New Point(257, 11)
        LBL_HistSelectEscuderia.Name = "LBL_HistSelectEscuderia"
        LBL_HistSelectEscuderia.Size = New Size(94, 20)
        LBL_HistSelectEscuderia.TabIndex = 33
        LBL_HistSelectEscuderia.Text = "ESCUDERIAS"
        LBL_HistSelectEscuderia.Visible = False
        ' 
        ' LV_HistSelect
        ' 
        LV_HistSelect.Columns.AddRange(New ColumnHeader() {ColId, ColNombre})
        LV_HistSelect.FullRowSelect = True
        LV_HistSelect.GridLines = True
        LV_HistSelect.ImeMode = ImeMode.NoControl
        LV_HistSelect.Location = New Point(197, 35)
        LV_HistSelect.Margin = New Padding(3, 4, 3, 4)
        LV_HistSelect.MultiSelect = False
        LV_HistSelect.Name = "LV_HistSelect"
        LV_HistSelect.Size = New Size(198, 323)
        LV_HistSelect.TabIndex = 32
        LV_HistSelect.UseCompatibleStateImageBehavior = False
        LV_HistSelect.View = View.Details
        ' 
        ' ColId
        ' 
        ColId.Text = "ID"
        ColId.Width = 30
        ' 
        ' ColNombre
        ' 
        ColNombre.Text = "Nombre"
        ColNombre.Width = 123
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Location = New Point(3, 176)
        Label22.Name = "Label22"
        Label22.Size = New Size(120, 20)
        Label22.TabIndex = 31
        Label22.Text = "Temporada Final"
        ' 
        ' NU_TempFin
        ' 
        NU_TempFin.Enabled = False
        NU_TempFin.Location = New Point(126, 174)
        NU_TempFin.Maximum = New Decimal(New Integer() {2024, 0, 0, 0})
        NU_TempFin.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        NU_TempFin.Name = "NU_TempFin"
        NU_TempFin.Size = New Size(58, 27)
        NU_TempFin.TabIndex = 30
        NU_TempFin.Value = New Decimal(New Integer() {2024, 0, 0, 0})
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(6, 130)
        Label21.Name = "Label21"
        Label21.Size = New Size(111, 20)
        Label21.TabIndex = 29
        Label21.Text = "Tempora Inicial"
        ' 
        ' NU_TempIni
        ' 
        NU_TempIni.Enabled = False
        NU_TempIni.Location = New Point(126, 128)
        NU_TempIni.Maximum = New Decimal(New Integer() {2024, 0, 0, 0})
        NU_TempIni.Minimum = New Decimal(New Integer() {1970, 0, 0, 0})
        NU_TempIni.Name = "NU_TempIni"
        NU_TempIni.Size = New Size(58, 27)
        NU_TempIni.TabIndex = 28
        NU_TempIni.Value = New Decimal(New Integer() {1970, 0, 0, 0})
        ' 
        ' CHB_Periodo
        ' 
        CHB_Periodo.AutoSize = True
        CHB_Periodo.Location = New Point(24, 73)
        CHB_Periodo.Name = "CHB_Periodo"
        CHB_Periodo.Size = New Size(132, 24)
        CHB_Periodo.TabIndex = 27
        CHB_Periodo.Text = "Limitar Periodo"
        CHB_Periodo.UseVisualStyleBackColor = True
        ' 
        ' CHB_Historico
        ' 
        CHB_Historico.AutoSize = True
        CHB_Historico.Checked = True
        CHB_Historico.CheckState = CheckState.Checked
        CHB_Historico.Location = New Point(24, 35)
        CHB_Historico.Name = "CHB_Historico"
        CHB_Historico.Size = New Size(91, 24)
        CHB_Historico.TabIndex = 26
        CHB_Historico.Text = "Histórico"
        CHB_Historico.UseVisualStyleBackColor = True
        ' 
        ' CHB_HistPilotos
        ' 
        CHB_HistPilotos.AutoSize = True
        CHB_HistPilotos.Checked = True
        CHB_HistPilotos.CheckState = CheckState.Checked
        CHB_HistPilotos.Location = New Point(24, 291)
        CHB_HistPilotos.Name = "CHB_HistPilotos"
        CHB_HistPilotos.Size = New Size(136, 24)
        CHB_HistPilotos.TabIndex = 25
        CHB_HistPilotos.Text = "Historial Pilotos"
        CHB_HistPilotos.UseVisualStyleBackColor = True
        ' 
        ' CHB_HistEscuderias
        ' 
        CHB_HistEscuderias.AutoSize = True
        CHB_HistEscuderias.Location = New Point(24, 333)
        CHB_HistEscuderias.Name = "CHB_HistEscuderias"
        CHB_HistEscuderias.Size = New Size(160, 24)
        CHB_HistEscuderias.TabIndex = 24
        CHB_HistEscuderias.Text = "Historial Escuderías"
        CHB_HistEscuderias.UseVisualStyleBackColor = True
        ' 
        ' LV_ResultadosPil
        ' 
        LV_ResultadosPil.Columns.AddRange(New ColumnHeader() {ColTemporada, ColGP, ColPos, ColPts})
        LV_ResultadosPil.FullRowSelect = True
        LV_ResultadosPil.GridLines = True
        LV_ResultadosPil.Location = New Point(418, 35)
        LV_ResultadosPil.Margin = New Padding(3, 4, 3, 4)
        LV_ResultadosPil.Name = "LV_ResultadosPil"
        LV_ResultadosPil.ShowGroups = False
        LV_ResultadosPil.Size = New Size(348, 323)
        LV_ResultadosPil.TabIndex = 23
        LV_ResultadosPil.UseCompatibleStateImageBehavior = False
        LV_ResultadosPil.View = View.Details
        ' 
        ' ColTemporada
        ' 
        ColTemporada.Text = "TEMP"
        ColTemporada.Width = 50
        ' 
        ' ColGP
        ' 
        ColGP.Text = "GP"
        ColGP.Width = 152
        ' 
        ' ColPos
        ' 
        ColPos.Text = "POS"
        ColPos.Width = 40
        ' 
        ' ColPts
        ' 
        ColPts.Text = "PTS"
        ColPts.Width = 40
        ' 
        ' LBL_HistSelectPilotos
        ' 
        LBL_HistSelectPilotos.AutoSize = True
        LBL_HistSelectPilotos.Location = New Point(272, 11)
        LBL_HistSelectPilotos.Name = "LBL_HistSelectPilotos"
        LBL_HistSelectPilotos.Size = New Size(63, 20)
        LBL_HistSelectPilotos.TabIndex = 22
        LBL_HistSelectPilotos.Text = "PILOTOS"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(550, 11)
        Label20.Name = "Label20"
        Label20.Size = New Size(97, 20)
        Label20.TabIndex = 21
        Label20.Text = "RESULTADOS"
        ' 
        ' TabCampeones
        ' 
        TabCampeones.Controls.Add(LV_Campeones)
        TabCampeones.Controls.Add(CB_PaisCampeones)
        TabCampeones.Controls.Add(Label19)
        TabCampeones.Location = New Point(4, 29)
        TabCampeones.Name = "TabCampeones"
        TabCampeones.Padding = New Padding(3)
        TabCampeones.Size = New Size(785, 386)
        TabCampeones.TabIndex = 2
        TabCampeones.Text = "Campeones"
        TabCampeones.UseVisualStyleBackColor = True
        ' 
        ' LV_Campeones
        ' 
        LV_Campeones.Columns.AddRange(New ColumnHeader() {ColumnHeader5, ColumnHeader6, ColumnHeader7, ColumnHeader8, ColumnHeader9})
        LV_Campeones.FullRowSelect = True
        LV_Campeones.GridLines = True
        LV_Campeones.Location = New Point(275, 20)
        LV_Campeones.Margin = New Padding(3, 4, 3, 4)
        LV_Campeones.Name = "LV_Campeones"
        LV_Campeones.ShowGroups = False
        LV_Campeones.Size = New Size(453, 333)
        LV_Campeones.TabIndex = 35
        LV_Campeones.UseCompatibleStateImageBehavior = False
        LV_Campeones.View = View.Details
        ' 
        ' ColumnHeader5
        ' 
        ColumnHeader5.Text = "TEMP"
        ColumnHeader5.Width = 50
        ' 
        ' ColumnHeader6
        ' 
        ColumnHeader6.Text = "PILOTO"
        ColumnHeader6.Width = 120
        ' 
        ' ColumnHeader7
        ' 
        ColumnHeader7.Text = "ESCUDERÍA"
        ColumnHeader7.Width = 120
        ' 
        ' ColumnHeader8
        ' 
        ColumnHeader8.DisplayIndex = 4
        ColumnHeader8.Text = "VICS"
        ColumnHeader8.Width = 40
        ' 
        ' ColumnHeader9
        ' 
        ColumnHeader9.DisplayIndex = 3
        ColumnHeader9.Text = "PTS"
        ColumnHeader9.Width = 40
        ' 
        ' CB_PaisCampeones
        ' 
        CB_PaisCampeones.FormattingEnabled = True
        CB_PaisCampeones.Location = New Point(74, 17)
        CB_PaisCampeones.Name = "CB_PaisCampeones"
        CB_PaisCampeones.Size = New Size(123, 28)
        CB_PaisCampeones.TabIndex = 29
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(23, 20)
        Label19.Name = "Label19"
        Label19.Size = New Size(34, 20)
        Label19.TabIndex = 28
        Label19.Text = "País"
        ' 
        ' formP3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(TabP3)
        Name = "formP3"
        Text = "Práctica3"
        TabP3.ResumeLayout(False)
        TabPaises.ResumeLayout(False)
        TabPaises.PerformLayout()
        TabPilotos.ResumeLayout(False)
        TabPilotos.PerformLayout()
        TabEscuderias.ResumeLayout(False)
        TabEscuderias.PerformLayout()
        TabGPs.ResumeLayout(False)
        TabGPs.PerformLayout()
        TabTemporada.ResumeLayout(False)
        TabTemporada.PerformLayout()
        CType(NU_GP, ComponentModel.ISupportInitialize).EndInit()
        CType(NU_Escuderia, ComponentModel.ISupportInitialize).EndInit()
        CType(NU_Temporada, ComponentModel.ISupportInitialize).EndInit()
        TabInformes.ResumeLayout(False)
        TabControl1.ResumeLayout(False)
        TabClasificacion.ResumeLayout(False)
        TabClasificacion.PerformLayout()
        CType(NU_TempClasif, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabHistorial.ResumeLayout(False)
        TabHistorial.PerformLayout()
        CType(NU_TempFin, ComponentModel.ISupportInitialize).EndInit()
        CType(NU_TempIni, ComponentModel.ISupportInitialize).EndInit()
        TabCampeones.ResumeLayout(False)
        TabCampeones.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabP3 As TabControl
    Friend WithEvents TabPaises As TabPage
    Friend WithEvents TabPilotos As TabPage
    Friend WithEvents TabEscuderias As TabPage
    Friend WithEvents TabGPs As TabPage
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_IDPais As TextBox
    Friend WithEvents TB_HabPais As TextBox
    Friend WithEvents TB_NomPais As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BT_LimpiarPais As Button
    Friend WithEvents BT_EliminarPais As Button
    Friend WithEvents BT_ActualizarPais As Button
    Friend WithEvents BT_AnadirPais As Button
    Friend WithEvents LB_Pais As ListBox
    Friend WithEvents LB_Piloto As ListBox
    Friend WithEvents BT_LimpiarPiloto As Button
    Friend WithEvents BT_EliminarPiloto As Button
    Friend WithEvents BT_ActualizarPiloto As Button
    Friend WithEvents BT_AnadirPiloto As Button
    Friend WithEvents TB_ApePiloto As TextBox
    Friend WithEvents TB_NomPiloto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_IDPiloto As TextBox
    Friend WithEvents CB_PaisPiloto As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LB_GP As ListBox
    Friend WithEvents BT_LimpiarGP As Button
    Friend WithEvents BT_EliminarGP As Button
    Friend WithEvents BT_ActualizarGP As Button
    Friend WithEvents BT_AnadirGP As Button
    Friend WithEvents TB_DenominacionGP As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TB_IDGP As TextBox
    Friend WithEvents CB_PaisGP As ComboBox
    Friend WithEvents CB_PaisEscuderia As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LB_Escuderia As ListBox
    Friend WithEvents BT_LimpiarEscuderia As Button
    Friend WithEvents BT_EliminarEscuderia As Button
    Friend WithEvents BT_ActualizarEscuderia As Button
    Friend WithEvents BT_AnadirEscuderia As Button
    Friend WithEvents TB_NomEscuderia As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TB_IDEscuderia As TextBox
    Friend WithEvents DTP_FechaCreacionEscuderia As DateTimePicker
    Friend WithEvents TabTemporada As TabPage
    Friend WithEvents NU_Temporada As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents NU_GP As NumericUpDown
    Friend WithEvents NU_Escuderia As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents BT_GenerarTemporada As Button
    Friend WithEvents BT_EliminarTemporada As Button
    Friend WithEvents BT_EliminarTemporadas As Button
    Friend WithEvents CHB_MostrarCalendarioYCarreras As CheckBox
    Friend WithEvents CHB_MostrarContratos As CheckBox
    Friend WithEvents LBL_Calendario As Label
    Friend WithEvents LBL_Carreras As Label
    Friend WithEvents LBL_Contratos As Label
    Friend WithEvents LB_InfoCalendario As ListBox
    Friend WithEvents TabInformes As TabPage
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabClasificacion As TabPage
    Friend WithEvents TabHistorial As TabPage
    Friend WithEvents TabCampeones As TabPage
    Friend WithEvents LV_Clasificacion As ListView
    Friend WithEvents LV_InfoCarreras As ListView
    Friend WithEvents POS As ColumnHeader
    Friend WithEvents PILOTO As ColumnHeader
    Friend WithEvents PTS As ColumnHeader
    Friend WithEvents LV_InfoContratos As ListView
    Friend WithEvents Escuderia As ColumnHeader
    Friend WithEvents Piloto_1 As ColumnHeader
    Friend WithEvents Piloto_2 As ColumnHeader
    Friend WithEvents BT_Random As Button
    Friend WithEvents LBL_PrimerPuesto As Label
    Friend WithEvents LBL_TercerPuesto As Label
    Friend WithEvents LBL_SegundoPuesto As Label
    Friend WithEvents PosicionClasif As ColumnHeader
    Friend WithEvents CHB_EscClasif As CheckBox
    Friend WithEvents CHB_PilotosClasif As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents NU_TempClasif As NumericUpDown
    Friend WithEvents NombreClasif As ColumnHeader
    Friend WithEvents PtsClasif As ColumnHeader
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LV_ResultadosPil As ListView
    Friend WithEvents LBL_HistSelectPilotos As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents NU_TempFin As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents NU_TempIni As NumericUpDown
    Friend WithEvents CHB_Periodo As CheckBox
    Friend WithEvents CHB_Historico As CheckBox
    Friend WithEvents CHB_HistPilotos As CheckBox
    Friend WithEvents CHB_HistEscuderias As CheckBox
    Friend WithEvents ColTemporada As ColumnHeader
    Friend WithEvents ColGP As ColumnHeader
    Friend WithEvents ColPos As ColumnHeader
    Friend WithEvents ColPts As ColumnHeader
    Friend WithEvents LV_HistSelect As ListView
    Friend WithEvents ColId As ColumnHeader
    Friend WithEvents ColNombre As ColumnHeader
    Friend WithEvents LBL_HistSelectEscuderia As Label
    Friend WithEvents LV_ResultadosEsc As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColPiloto As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents LV_Campeones As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents CB_PaisCampeones As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
