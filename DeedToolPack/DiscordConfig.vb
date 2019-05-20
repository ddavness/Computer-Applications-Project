Public Class DiscordConfig
    Private Sub Global_Load() Handles MyBase.Load

        ' trancar valores
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.MaximizeBox = False

    End Sub

    Private Sub PingUser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PingUser.CheckedChanged
        AccID.Enabled = PingUser.Checked
    End Sub

    Private Sub Help_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Help.Click
        DiscordHelp.Show()
    End Sub

    Private Sub Exe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exe.Click
        Status.ForeColor = Color.Yellow
        Status.Text = "A verificar..."

        Dim f As Dictionary(Of String, String) = Discord.ObterCredenciais(ApiUrl.Text) ' a função já contém as estruturas de validação necessárias

        If Not f.ContainsKey("Erro") Then ' foi devolvida uma tabela em JSON, o webhook existe;
            AppConfig.Definicao("DiscordWebhook") = ApiUrl.Text

            If PingUser.Checked Then
                AppConfig.Definicao("DiscordId") = ", <@" & AccID.Text & ">"
            ElseIf Not IsNothing(AppConfig.Definicao("DiscordId", Nothing)) Then
                AppConfig.Definicao("DiscordId") = ""
            End If

            Status.ForeColor = Color.Lime
            Status.Text = "Sucesso!"

            Dim a As String = Discord.EnviarMsg()
            If Not IsNothing(a) Then
                MsgBox(a)
            End If

            DeedMenu.AtualizarForm(True)

            MsgBox("Sucesso! Nome do Webhook: " & f.Item("Nome") & Chr(13) & "Foi enviada uma confirmação para si.", MsgBoxStyle.Information, "E-Agenda by Deed")

            DeedDef.Close()
            Me.Close()
        Else ' foi devolvido um erro
            Status.ForeColor = Color.Red
            Status.Text = "ERRO!"
            MsgBox("Comunicação falhada! Detalhes:" & Chr(13) & Chr(13) & f.Item("Erro") & Chr(13) & Chr(13) & "Por favor confirme se o link está correto.", MsgBoxStyle.Critical, "E-Agenda by Deed")
            Status.Text = "Desligado"
        End If
    End Sub

    Private Sub ApiUrl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ApiUrl.TextChanged
        Exe.Enabled = ApiUrl.Text.StartsWith("https://discordapp.com/api/webhooks/")
    End Sub

    Private Sub AccID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccID.TextChanged
        Dim charArray As Char() = AccID.Text.ToCharArray()
        Dim a As String = ""

        For Each c In charArray
            If IsNumeric(c) Then
                a = a & c
            End If
        Next

        AccID.Text = a
    End Sub

    Private Sub DiscordConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cred As Dictionary(Of String, String) = Discord.ObterCredenciais(AppConfig.Definicao("DiscordWebhook"))
        If cred.ContainsKey("Erro") Then ' o webhook não existe ou já é inválido!
            AppConfig.Definicao("DiscordWebhook") = ""
            Status.Text = "Desligado"
            Status.ForeColor = Color.Red
            ApiUrl.Text = ""
        Else
            Status.Text = "Ligado"
            Status.ForeColor = Color.Lime
            ApiUrl.Text = AppConfig.Definicao("DiscordWebhook")
        End If

        PingUser.Checked = AppConfig.Definicao("DiscordId") <> ""
        AccID.Text = AppConfig.Definicao("DiscordId")
    End Sub
End Class