Public Class DeedEditarLembrete
    Private Sub AtAviso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AtAviso.SelectedIndexChanged
        Av.Visible = AtAviso.SelectedItem = "Outro..."
        DataAviso.Visible = AtAviso.SelectedItem = "Outro..."
        HoraAviso.Visible = AtAviso.SelectedItem = "Outro..."
    End Sub

    Dim int As Integer
    Dim l As Lembrete

    Public Sub Mostrar(ByVal id)
        l = LembreteManagement.ListaLembretes(id)
        int = id

        Titulo.Text = l.Titulo
        Desc.Text = l.Descricao
        DataEvento.Value = l.Data
        HoraEvento.Value = l.Data
        DataAviso.Value = l.DataNotificacao
        HoraAviso.Value = l.DataNotificacao

        Select Case (l.Data.Ticks - l.DataNotificacao.Ticks)
            Case 0
                AtAviso.Text = "Avisar na própria hora"
            Case 3000000000 ' existem 10 milhões de ticks num segundo (1 tick = 100 nanosegundos), e 300 segundos em 5 minutos
                AtAviso.Text = "5 minutos"
            Case 9000000000 ' 15 minutos
                AtAviso.Text = "15 minutos"
            Case 18000000000 ' 30 mins
                AtAviso.Text = "30 minutos"
            Case 36000000000 ' 1h
                AtAviso.Text = "1 hora"
            Case 72000000000 ' 2h
                AtAviso.Text = "2 horas"
            Case 108000000000 '3h
                AtAviso.Text = "3 horas"
            Case Else
                AtAviso.Text = "Outro..."
        End Select

        Me.Show(DeedMenu)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exe.Click
        If Not IsNothing(int) Then ' está a ser editado; proceder.
            If String.IsNullOrWhiteSpace(Titulo.Text) Then
                MsgBox("Por favor dê um título ao lembrete.", MsgBoxStyle.Exclamation, "E-Agenda by Deed")
                Exit Sub
            End If

            Dim data, aviso As Date

            If Not Date.TryParse(DataEvento.Value.ToShortDateString & " " & HoraEvento.Value.TimeOfDay.ToString, data) Then ' vai tentar converter os dois blocos para uma variável do tipo "Date" unificada
                MsgBox("Erro ao tentar converter string para data!" & Chr(13) & "Por favor confirme se todas as informações se encontram corretas" & Chr(13) & Chr(13) & "DEV_CODE: PARSE Data FAILED", MsgBoxStyle.Critical, "Erro: DateParse")
                Exit Sub
            Else
                If Date.Compare(data, Date.Now) <= 0 Then ' sair se a data já tiver caducado
                    MsgBox("A data/hora introduzida (" & data.ToShortDateString & " às " & data.TimeOfDay.ToString & ") é anterior à atual! (" & Date.Now.ToShortDateString & " às " & Date.Now.ToString("HH:mm:ss") & ")", MsgBoxStyle.Exclamation, "E-Agenda by Deed")
                    Exit Sub
                End If

                Select Case AtAviso.Text
                    Case "Avisar na própria hora"
                        aviso = data
                    Case "5 minutos"
                        aviso = data.AddMinutes(-5)
                    Case "15 minutos"
                        aviso = data.AddMinutes(-15)
                    Case "30 minutos"
                        aviso = data.AddMinutes(-30)
                    Case "1 hora"
                        aviso = data.AddHours(-1)
                    Case "2 horas"
                        aviso = data.AddHours(-2)
                    Case "3 horas"
                        aviso = data.AddHours(-3)
                    Case "Outro..."
                        If Not Date.TryParse(DataAviso.Value.ToShortDateString & " " & HoraAviso.Value.TimeOfDay.ToString, aviso) Then
                            MsgBox("Erro ao tentar converter string para data!" & Chr(13) & "Por favor confirme se todas as informações se encontram corretas" & Chr(13) & "DEV_CODE: PARSE DataAviso FAILED")
                            Exit Sub
                        End If
                    Case Else
                        MsgBox("Por favor selecione uma opção de antecedência de aviso.", MsgBoxStyle.Exclamation, "E-Agenda by Deed")
                        Exit Sub ' cancela a criação do lembrete
                End Select

                If Date.Compare(aviso, Date.Now) <= 0 Then ' sair se a data de aviso for anterior à atual
                    MsgBox("A data/hora de aviso introduzida (" & aviso.ToShortDateString & " às " & aviso.TimeOfDay.ToString & ") é anterior à atual! (" & Date.Now.ToShortDateString & " às " & Date.Now.ToString("HH:mm:ss") & ")", MsgBoxStyle.Exclamation, "E-Agenda by Deed")
                    Exit Sub
                ElseIf Date.Compare(aviso, data) = 1 Then ' sair se a data de aviso for posterior à do evento
                    MsgBox("A data/hora introduzida (" & aviso.ToShortDateString & " às " & aviso.TimeOfDay.ToString & ") é posterior à do evento! (" & data.ToShortDateString & " às " & data.TimeOfDay.ToString & ")", MsgBoxStyle.Exclamation, "E-Agenda by Deed")
                    Exit Sub
                End If
            End If

            ' caso tenha passado todas as estruturas de validação, editar o lembrete!

            LembreteManagement.ListaLembretes(int) = New Lembrete(Titulo.Text, Desc.Text, data, aviso)
            int = Nothing
            l = Nothing
            DeedMenu.AtualizarForm(True)
            MsgBox("Alterações Guardadas!", MsgBoxStyle.Information, "E-Agenda by Deed")
            Me.Close()
        End If
    End Sub
End Class