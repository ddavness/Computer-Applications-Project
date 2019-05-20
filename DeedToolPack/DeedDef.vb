Public Class DeedDef
    Private Sub DeedDef_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        User.Text = AppConfig.Definicao("UserPrimNome") & AppConfig.Definicao("UserApel")
        EnviarSegNotificacao.Checked = AppConfig.Definicao("EnviarSegNotificação", "False") = "True"
        AutoApagar.Checked = AppConfig.Definicao("AutoApagar", "False") = "True"

        Dim wb As Dictionary(Of String, String) = Discord.ObterCredenciais(AppConfig.Definicao("DiscordWebhook"))

        If wb.ContainsKey("Erro") Then ' o webhook já não existe.
            AppConfig.Definicao("DiscordWebhook") = ""
            WBNome.Text = "<Nenhum>"
            WBChannel.Text = "<Nenhum>"
            WBToken.Text = "<Nenhum>"
            DeedMenu.AtualizarForm()
        Else
            WBNome.Text = wb.Item("Nome")
            WBChannel.Text = wb.Item("CanalId")
            WBToken.Text = wb.Item("Token").Substring(0, 20) & "(...)"
            Status.Text = "Ligado"
            Status.ForeColor = Color.Lime
        End If

        AccId.Text = AppConfig.Definicao("DiscordId").Replace("<", "").Replace(">", "").Replace("@", "").Replace(",", "")
        If AccId.Text = "" Then
            AccId.Text = "<Nenhum>"
        End If
    End Sub

    Private Sub Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guardar.Click
        AppConfig.Definicao("EnviarSegNotificação") = EnviarSegNotificacao.Checked.ToString
        AppConfig.Definicao("AutoApagar") = AutoApagar.Checked.ToString

        If String.IsNullOrWhiteSpace(User.Text) Then
            MsgBox("O nome de utilizador não foi guardado/alterado por estar vazio.", MsgBoxStyle.Exclamation, "E-Agenda by Deed")
            MsgBox("Guardado!", MsgBoxStyle.Information, "E-Agenda by Deed")
            DeedMenu.AtualizarForm(True)
            Me.Close()
            Exit Sub
        End If

        ' estruturas de validação e correção dos dados
        Dim apel, pNome As String
        apel = ""
        pNome = ""

        Dim n As Boolean
        For Each i In User.Text.Split({Chr(32)})
            If Not String.IsNullOrWhiteSpace(i) Then
                If n Then
                    apel = apel & " " & i
                Else
                    pNome = i
                    n = True
                End If
            End If
        Next

        AppConfig.Definicao("UserApel") = apel
        AppConfig.Definicao("UserPrimNome") = pNome

        MsgBox("Guardado!", MsgBoxStyle.Information, "E-Agenda by Deed")
        DeedMenu.AtualizarForm(True)
        Me.Close()
    End Sub

    Private Sub ResetAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetAll.Click
        ' apagar tudo!
        If MsgBox("Tem a certeza de que pretende reinicializar a agenda?" & Chr(13) & " - TODOS OS SEUS DADOS SERÃO APAGADOS;" & Chr(13) & " - Esta ação NÃO PODE ser anulada." & Chr(13) & Chr(13) & "A aplicação vai ser reiniciada.", MsgBoxStyle.YesNo, "E-Agenda by Deed") = MsgBoxResult.Yes Then
            My.Computer.FileSystem.DeleteDirectory(Application.LocalUserAppDataPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
            MsgBox("Ficheiros apagados com sucesso!", MsgBoxStyle.Information, "E-Agenda by Deed")
            Application.Restart()
        End If
    End Sub

    Private Sub Descartar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Descartar.Click
        If MsgBox("Tem a certeza de que pretende descartar as alterações?", MsgBoxStyle.YesNo, "E-Agenda by Deed") = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub AGDAClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGDAClean.Click
        If MsgBox("Tem a certeza de que pretende descartar todos os lembretes antigos?" & Chr(13) & "Esta ação não pode ser anulada.", MsgBoxStyle.YesNo, "E-Agenda by Deed") = MsgBoxResult.Yes Then
            ' tirar lembretes antigos daqui
            For i = 0 To LembreteManagement.ListaLembretes.Length - 1
                If LembreteManagement.ListaLembretes(i).NotifTick(True) < 0 Then
                    LembreteManagement.ListaLembretes(i) = Nothing
                End If
            Next

            LembreteManagement.GuardarTudo()
            LembreteManagement.LerTudo()

            MsgBox("Lembretes antigos apagados!", MsgBoxStyle.Information, "E-Agenda by Deed")
            DeedMenu.AtualizarForm()
            Me.Close()
        End If
    End Sub

    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        If MsgBox("Tem a certeza de que pretende desativar a ligação ao Discord?" & Chr(13) & "Pode voltar a ativar esta funcionalidade, se assim o entender.", MsgBoxStyle.YesNo, "E-Agenda by Deed") = MsgBoxResult.Yes Then
            AppConfig.Definicao("DiscordWebhook") = ""
            AppConfig.Definicao("DiscordId") = ""
            MsgBox("Feito! Não irá voltar a receber mais notificações.", MsgBoxStyle.Information, "E-Agenda by Deed")
            DeedMenu.AtualizarForm(True)
            Me.Close()
        End If
    End Sub

    Private Sub OpenConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenConfig.Click
        DiscordConfig.Show(Me)
    End Sub

    Private Sub Info_Click(sender As Object, e As EventArgs) Handles Info.Click

    End Sub
End Class