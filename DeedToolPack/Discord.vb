Imports System
Imports System.Net
Imports System.Text
Imports System.IO

Public Class DiscordEventEmbed
    Dim l As Lembrete
    Dim propriaHora As Boolean
    Dim b As String = "{"

    Public Sub New(lembrete, notAviso)
        l = lembrete
        propriaHora = notAviso
    End Sub

    Public Function Serializar()
        If Not String.IsNullOrWhiteSpace(AppConfig.Definicao("DiscordId").Replace(", ", "")) Then
            b = b & """content"":" & Aspas(AppConfig.Definicao("DiscordId").Replace(", ", "")) & ","
        End If

        If propriaHora Or l.DataNotificacao = l.Data Then
            b = b & """embeds"":[{""title"":""" & AppConfig.Definicao("UserPrimNome") & ", tem um evento! AGORA!"",""description"":""Este evento ocorreu às " & l.Data.TimeOfDay.ToString & " de " & l.Data.ToLongDateString & ".""," & """color"":16711680,"
        Else
            b = b & """embeds"":[{""title"":""" & AppConfig.Definicao("UserPrimNome") & ", tem um aviso pendente!"",""description"":""Este aviso foi entregue às " & l.DataNotificacao.TimeOfDay.ToString & " de " & l.DataNotificacao.ToLongDateString & ".\n\n"
            If l.Data.ToShortDateString = l.DataNotificacao.ToShortDateString Then
                b = b & "O evento ocorrerá às " & l.Data.TimeOfDay.ToString & " do mesmo dia."",""color"":16776960,"
            Else
                b = b & "O evento ocorrerá às " & l.Data.TimeOfDay.ToString & " do dia " & l.Data.ToLongDateString & ",""color"":16776960,"
            End If
        End If

        b = b & """footer"":{""text"":""Esta mensagem foi gerada automaticamente | DeedToolPack""},""thumbnail"":{""url"":""https://pasteboard.co/images/HcNWqGS.png/load""},""author"":{""name"":""E-Agenda by Deed"",""icon_url"":""https://pasteboard.co/images/HcCzA83.png/load""},""fields"":[{""name"":""===============Evento==============="",""value"":" & Aspas(l.Titulo) & "},{""name"":""Informação Adicional"",""value"":"

        If String.IsNullOrWhiteSpace(l.Descricao) Then
            b = b & """<Nada foi adicionado>""}]}]}"
        Else
            b = b & Aspas(l.Descricao) & "}]}]}"
        End If

        'Clipboard.SetText(b)

        Return Encoding.UTF8.GetBytes(b)
    End Function
End Class

Module Discord
    Public Function Aspas(a)
        Return """" & a & """"
    End Function

    Public Function ObterCredenciais(url) As Dictionary(Of String, String) ' verifica se o webhook existe. Em caso de sucesso, devolve um header de sucesso ("json_") e o nome do webhook. De outra forma devolve a mensagem de erro sem o header.
        Dim credenciais As New Dictionary(Of String, String)

        If Not url.StartsWith("https://discordapp.com/api/webhooks/") Then
            credenciais.Add("Erro", "")
            Return credenciais
        End If

        Try ' vai tentar executar o bloco abaixo e manter controlados os erros de runtime que possam aparecer
            Dim webhook As WebRequest = WebRequest.Create(url)
            webhook.Method = "GET"

            Dim dados As New StreamReader(webhook.GetResponse.GetResponseStream())

            Dim json As String = dados.ReadToEnd()
            dados.Close() ' fecha o leitor de dados para libertar recursos computacionais
            Dim nome As String = ""

            Dim campos() As String = json.Split(", ")
            credenciais.Add("Nome", campos(0).Split(": ")(1).Replace("""", ""))
            credenciais.Add("CanalId", campos(1).Split(": ")(1).Replace("""", ""))
            credenciais.Add("Token", campos(2).Split(": ")(1).Replace("""", ""))

            For i = 2 To json.Length
                If json.Chars(i - 1).ToString = Chr(34) And nome = "" Then
                    nome = json.Substring(0, i - 1)
                    Exit For
                End If
            Next

            Return credenciais
        Catch erro As Exception ' vai conduzir o erro para uma MsgBox, em vez de crashar o programa
            credenciais.Add("Erro", erro.Message)
            Return credenciais
        End Try
    End Function

    Public Function EnviarMsg(Optional embed As DiscordEventEmbed = Nothing)
        Dim webhookURL As String = AppConfig.Definicao("DiscordWebhook")

        If webhookURL = "" Then
            Return Nothing
        End If

        Try ' vai tentar executar o bloco abaixo
            Dim content As Byte()

            If IsNothing(embed) Then
                ' conteúdo de configuração feita com sucesso
                content = Encoding.UTF8.GetBytes("{""content"": ""Olá" & AppConfig.Definicao("DiscordId", " **" & AppConfig.Definicao("UserPrimNome") & "**") & " :)"",""embeds"": [{""title"": ""O webhook foi configurado com sucesso!"",""description"": ""Configurado para '" & AppConfig.Definicao("UserPrimNome") & AppConfig.Definicao("UserApel") & "'."",""color"": 38655,""footer"": {""text"": ""Esta mensagem foi gerada automaticamente | DeedToolPack""},""thumbnail"": {""url"": ""https://pasteboard.co/images/HcNWqGS.png/load""},""author"": {""name"": ""e-Agenda by DeeD"",""icon_url"": ""https://pasteboard.co/images/HcCzA83.png/load""},""fields"": [{""name"": ""E agora?"",""value"": ""Está pronto! Não precisa de fazer mais nada. Assim que for necessário enviar-lhe-ei as notificações por aqui. Não se preocupe: não deixará de as receber no PC.""},{""name"": ""Não quer receber mais notificações?"",""value"": ""No menu principal, vá a 'Definições' (canto superior esquerdo), clique em 'Discord', e finalmente, 'Desativar Ligação'. Em alternativa, pode apagar o webhook diretamente no Discord.""}]}]}") ' cria a mensagem em formato JSON
            Else
                ' transformar conteúdo do lembrete em JSON
                content = embed.Serializar()
            End If

            Dim webhook As WebRequest = WebRequest.Create(webhookURL)
            webhook.Method = "POST"
            webhook.ContentLength = content.Length
            webhook.ContentType = "application/json" ' vai dizer ao servidor que estamos a fazer upload de conteudo em JSON

            Dim dataStream As Stream = webhook.GetRequestStream()
            dataStream.Write(content, 0, content.Length)
            dataStream.Close()

            Dim objReader2 As WebResponse = (webhook.GetResponse()) 'vai enviar o pedido ao servidor
            objReader2.Close()

            Return Nothing
        Catch erro As Exception ' vai conduzir o erro para uma MsgBox, em vez de crashar o programa
            If ObterCredenciais(webhookURL).ContainsKey("Erro") Then
                AppConfig.Definicao("DiscordWebhook") = "" ' apagar o webhook por já não existir.
                AppConfig.Definicao("DiscordId") = ""
                DeedMenu.AtualizarForm(True)
            End If
            Return erro.Message
        End Try
    End Function
End Module
