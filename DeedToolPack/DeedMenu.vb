Public Class DeedMenu
    ' DADOS
    Dim CurrentLembretes(3) As Integer
    Dim NextLembretes(3) As Integer

    Dim CurrentUI(3, 3) As Object
    Dim NextUI(3, 3) As Object

    Dim lembreteAExecutar As Lembrete
    Dim lowestTicks As Long
    Dim aviso As Boolean

    ' SUBROTINAS DE MÚLTIPLO USO
    Public Sub AtualizarForm(Optional valAlterados As Boolean = False) ' atualiza o form sempre que necessario. pode ser usado por outras classes se tal se revelar necessário.
        'valAlterados vai forçar o sistema a guardar tudo
        If valAlterados Then
            AppConfig.GuardarTudo()
            LembreteManagement.GuardarTudo()
        End If

        ' ===================== MISCELLANEOUS STUFF ==================== '
        ' ============================================================== '
        ' ============================================================== '

        Header.Text = "Olá, " & AppConfig.Definicao("UserPrimNome") & "! :)"

        ' =================== DISCORD WEBHOOK UPDATE =================== '
        ' ============================================================== '
        ' ============================================================== '

        _DiscordPopupConfig.Visible = (AppConfig.Definicao("DiscordWebhook") = "")
        If AppConfig.Definicao("DiscordWebhook") <> "" Then
            DiscordStatus.Text = "Ligado"
            DiscordStatus.ForeColor = Color.LimeGreen
        Else
            DiscordStatus.Text = "Desligado"
            DiscordStatus.ForeColor = Color.Red
        End If

        ' =================== CALENDARIO E LEMBRETES =================== '
        ' ============================================================== '
        ' ============================================================== '

        ' apagar listas

        If AppConfig.Definicao("AutoApagar") = "True" Then
            ' tirar lembretes antigos daqui
            For i = 0 To LembreteManagement.ListaLembretes.Length - 1
                If LembreteManagement.ListaLembretes(i).NotifTick(True) < 0 Then
                    LembreteManagement.ListaLembretes(i) = Nothing
                End If
            Next

            LembreteManagement.GuardarTudo()
            LembreteManagement.LerTudo()
        End If

        CurrentLembretes = {}
        NextLembretes = {}

        Dim data As Date = Calendario.SelectionRange.Start
        Dim cc, nn As Byte
        cc = 0
        nn = 0

        Dim index As Integer = 0

        For Each l In LembreteManagement.ListaLembretes
            If l.Data.Date = data And cc < 4 Then
                ReDim Preserve CurrentLembretes(cc)
                CurrentLembretes(cc) = index
                cc = cc + 1
            ElseIf l.Data.Date = data.AddDays(1) And nn < 4 Then
                ReDim Preserve NextLembretes(nn)
                NextLembretes(nn) = index
                nn = nn + 1
            End If
            index = index + 1
        Next

        NoEventsCurrent.Visible = Not cc > 0
        NoEventsNext.Visible = Not nn > 0

        Select Case data
            Case Date.Today
                LCurrent.Text = "Hoje"
                LNext.Text = "Amanhã"
            Case Date.Today.AddDays(-1)
                LCurrent.Text = "Ontem"
                LNext.Text = "Hoje"
            Case Date.Today.AddDays(-2)
                LCurrent.Text = data.ToLongDateString()
                LNext.Text = "Ontem"
            Case Date.Today.AddDays(1)
                LCurrent.Text = "Amanhã"
                LNext.Text = data.AddDays(1).ToLongDateString()
            Case Else
                LCurrent.Text = data.ToLongDateString()
                LNext.Text = data.AddDays(1).ToLongDateString()
        End Select

        For j = 0 To CurrentLembretes.Length - 1
            CurrentUI(j, 0).Text = LembreteManagement.ListaLembretes(CurrentLembretes(j)).Titulo
            CurrentUI(j, 1).Text = LembreteManagement.ListaLembretes(CurrentLembretes(j)).Data.TimeOfDay.ToString()
            For i = 0 To 3
                CurrentUI(j, i).Visible = True
            Next
        Next

        For j = CurrentLembretes.Length To 3
            For i = 0 To 3
                CurrentUI(j, i).Visible = False
            Next
        Next

        For j = 0 To NextLembretes.Length - 1
            NextUI(j, 0).Text = LembreteManagement.ListaLembretes(NextLembretes(j)).Titulo
            NextUI(j, 1).Text = LembreteManagement.ListaLembretes(NextLembretes(j)).Data.TimeOfDay.ToString()
            For i = 0 To 3
                NextUI(j, i).Visible = True
            Next
        Next

        For j = NextLembretes.Length To 3
            For i = 0 To 3
                NextUI(j, i).Visible = False
            Next
        Next

        ' =================== NOTIFICAÇÕES E DISCORD =================== '
        ' ============================================================== '
        ' ============================================================== '

        lembreteAExecutar = Nothing
        lowestTicks = 2 ^ 62

        For i = 0 To LembreteManagement.ListaLembretes.Length - 1
            Dim l As Lembrete = LembreteManagement.ListaLembretes(i)
            Dim a, b As Long
            a = l.NotifTick(True)
            b = l.NotifTick(False)

            If a > 0 Then
                If b < lowestTicks And b > 0 Then
                    lembreteAExecutar = l
                    lowestTicks = b
                    aviso = True
                ElseIf a < lowestTicks And a > 0 Then
                    aviso = False
                    lembreteAExecutar = l
                    lowestTicks = a
                End If
            End If
        Next

        Contador.Enabled = Not IsNothing(lembreteAExecutar)
        If Contador.Enabled Then
            If lowestTicks < Int32.MaxValue Then
                Contador.Interval = lowestTicks
                'MsgBox(lowestTicks)
                If Not aviso Or lembreteAExecutar.DataNotificacao = lembreteAExecutar.Data Then
                    Taskbar.BalloonTipTitle = "Tem um evento pendente! Agora!"
                    Taskbar.BalloonTipIcon = ToolTipIcon.Warning
                Else
                    Taskbar.BalloonTipTitle = "Tem um aviso pendente!"
                    Taskbar.BalloonTipIcon = ToolTipIcon.Info
                End If
                Taskbar.BalloonTipText = "Evento: " & lembreteAExecutar.Titulo & ";" & Chr(13)

                If Not String.IsNullOrWhiteSpace(lembreteAExecutar.Descricao) Then
                    Taskbar.BalloonTipText = Taskbar.BalloonTipText & "Descrição: " & lembreteAExecutar.Descricao & ";" & Chr(13) & Chr(13)
                Else
                    Taskbar.BalloonTipText = Taskbar.BalloonTipText & Chr(13)
                End If

                If aviso And lembreteAExecutar.DataNotificacao <> lembreteAExecutar.Data Then
                    If lembreteAExecutar.Data.ToShortDateString = lembreteAExecutar.DataNotificacao.ToShortDateString Then
                        Taskbar.BalloonTipText = Taskbar.BalloonTipText & "O evento ocorrerá às " & lembreteAExecutar.Data.TimeOfDay.ToString & " do mesmo dia."
                    Else
                        Taskbar.BalloonTipText = Taskbar.BalloonTipText & "O evento ocorrerá às " & lembreteAExecutar.Data.TimeOfDay.ToString & " do dia " & lembreteAExecutar.Data.ToLongDateString
                    End If
                End If
            Else
                Contador.Interval = Int32.MaxValue
                lembreteAExecutar = Nothing
            End If
        End If
    End Sub


    ''-----------------------------------------------------------------------------------------
    Private Sub Background()
        If Not AppConfig.Definicao("UserSabeBackgroundStatus") = "True" Then
            MsgBox("O programa vai continuar a correr em segundo plano, de modo a que possa continuar a receber as suas notificações.", MsgBoxStyle.Information, "E-Agenda by Deed")
            AppConfig.Definicao("UserSabeBackgroundStatus") = "True"
        End If
        Me.Hide() ' esconde o formulário sem desligar o programa
        DiscordConfig.Close()
        DiscordHelp.Close()

        AppConfig.GuardarTudo() ' por segurança, guardar
        LembreteManagement.GuardarTudo() ' por segurança, guardar
    End Sub

    ' SUBROTINAS DE EVENTOS
    ' =====================

    Private Sub _Load(sender As System.Object, e As System.EventArgs) Handles Me.Load
        'MsgBox(Application.LocalUserAppDataPath) 'debug purposes

        Data_Hora_0.Interval = (Int(Date.Now.Ticks / 10000000) * 10000000 + 10000000 - Date.Now.Ticks) / 10000
        Data_Hora_0.Enabled = True

        ' inicialização de dados
        CurrentUI = {{LC1, HC1, EC1, DC1}, {LC2, HC2, EC2, DC2}, {LC3, HC3, EC3, DC3}, {LC4, HC4, EC4, DC4}}
        NextUI = {{LN1, HN1, EN1, DN1}, {LN2, HN2, EN2, DN2}, {LN3, HN3, EN3, DN3}, {LN4, HN4, EN4, DN4}}

        Calendario.SelectionRange.Start = Date.Today
        Calendario.SelectionRange.End = Date.Today
        Calendario.TodayDate = Date.Today
        Header.Text = "Olá, " & AppConfig.Definicao("UserPrimNome") & "! :)"
        AtualizarForm()
    End Sub

    Private Sub AtivarLembrete(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Contador.Tick
        If IsNothing(lembreteAExecutar) Then
            AtualizarForm() ' a proteção anti overflow está ativada, apenas atualizar
            Exit Sub
        End If

        If Not (Not aviso And AppConfig.Definicao("EnviarSegNotificação", "False") <> "True") Then
            Taskbar.ShowBalloonTip(5000)
            Discord.EnviarMsg(New DiscordEventEmbed(lembreteAExecutar, Not aviso))
            AtualizarForm()
        End If

    End Sub

    Private Sub EditClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EC1.Click, EC2.Click, EC3.Click, EC4.Click, EN1.Click, EN2.Click, EN3.Click, EN4.Click
        If sender.Name.StartsWith("EC") Then
            DeedEditarLembrete.Mostrar(CurrentLembretes(Val(sender.Name.Substring(2)) - 1))
        Else
            DeedEditarLembrete.Mostrar(NextLembretes(Val(sender.Name.Substring(2)) - 1))
        End If
    End Sub

    Private Sub DeleteClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DN4.Click, DN3.Click, DN2.Click, DN1.Click, DC4.Click, DC3.Click, DC2.Click, DC1.Click
        Dim Lid, id As Byte
        id = Val(sender.Name.Substring(2)) - 1

        If sender.Name.StartsWith("DC") Then
            Lid = CurrentLembretes(id)
            CurrentUI(id, 0).ForeColor = Color.Yellow
            CurrentUI(id, 1).ForeColor = Color.Yellow

            If MsgBox("Tem a certeza que pretende apagar este lembrete? Esta ação não pode ser anulada.", MsgBoxStyle.YesNo, "E-Agenda by Deed") = MsgBoxResult.Yes Then
                LembreteManagement.ListaLembretes(Lid) = Nothing
                LembreteManagement.GuardarTudo()
                LembreteManagement.LerTudo()
                AtualizarForm()
            End If

            CurrentUI(id, 0).ForeColor = Color.White
            CurrentUI(id, 1).ForeColor = Color.White
        Else
            Lid = NextLembretes(id)
            NextUI(id, 0).ForeColor = Color.Yellow
            NextUI(id, 1).ForeColor = Color.Yellow

            If MsgBox("Tem a certeza que pretende apagar este lembrete? Esta ação não pode ser anulada.", MsgBoxStyle.YesNo, "E-Agenda by Deed") = MsgBoxResult.Yes Then
                LembreteManagement.ListaLembretes(Lid) = Nothing
                LembreteManagement.GuardarTudo()
                LembreteManagement.LerTudo()
                AtualizarForm()
            End If

            NextUI(id, 0).ForeColor = Color.White
            NextUI(id, 1).ForeColor = Color.White
        End If
    End Sub

    Private Sub _Background_Click(sender As System.Object, e As System.EventArgs) Handles _Background.Click
        Background()
    End Sub

    Private Sub _Quit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _Quit.Click
        If MsgBox("Tem a certeza que pretende terminar a execução do programa? Não vai receber notificações se o programa não estiver a correr de todo!", MsgBoxStyle.OkCancel, "E-Agenda by Deed") = MsgBoxResult.Ok Then
            AppConfig.GuardarTudo() ' guardar antes de fechar!
            LembreteManagement.GuardarTudo() ' guardar antes de fechar!

            End
        End If
    End Sub

    Private Sub _DiscordPopupConfig_Click(sender As System.Object, e As System.EventArgs) Handles _DiscordPopupConfig.Click
        DiscordConfig.Show(Me)
    End Sub

    Private Sub _DiscordConfig_Click(sender As System.Object, e As System.EventArgs)
        DiscordConfig.Show(Me)
    End Sub

    Private Sub Menu_Load(sender As System.Object, e As FormClosingEventArgs) Handles Me.FormClosing ' a agenda passa a operar em segundo plano
        If e.CloseReason = CloseReason.UserClosing Then
            e.Cancel = True ' para o evento e evita que a aplicação feche
            Background()
        End If
    End Sub

    Private Sub Taskbar_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Taskbar.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub _NLembrete_Click() Handles _NLembrete.Click
        DeedNewLembrete.Show(Me)
    End Sub

    Private Sub Calendario_DateChanged() Handles Calendario.DateChanged
        AtualizarForm()
    End Sub

    Private Sub _Def_Click(sender As System.Object, e As System.EventArgs) Handles _Def.Click
        DeedDef.Show(Me)
    End Sub

    Private Sub Data_Hora_Tick(sender As System.Object, e As System.EventArgs) Handles Data_Hora.Tick
        Data_Hora_Label.Text = Date.Now.ToLongDateString() & ", " & Date.Now.AddMilliseconds(100).ToString("HH:mm:ss")
    End Sub

    Private Sub Data_Hora_Tick_0(sender As System.Object, e As System.EventArgs) Handles Data_Hora_0.Tick
        Data_Hora.Enabled = True
        Data_Hora_0.Enabled = False
    End Sub
End Class