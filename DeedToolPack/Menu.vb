Public Class Menu
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Algoritmo.Click
        AlgoritmoNums.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Deed.Click
        ' preparar o form principal para ser mostrado.

        AppConfig.LerTudo() ' ler todas as configuracoes
        LembreteManagement.LerTudo() ' ler todos os lembretes

        Dim pNome, apel As String
        pNome = AppConfig.Definicao("UserPrimNome")
        apel = AppConfig.Definicao("UserApel")

        If String.IsNullOrWhiteSpace(pNome) And String.IsNullOrWhiteSpace(apel) Then
            Dim nome As String = InputBox("Introduza o seu nome completo.", "E-Agenda by DeeD")

            While String.IsNullOrWhiteSpace(nome)
                If MsgBox("Nome inválido (em branco)! Pretende abortar?", MsgBoxStyle.YesNo, "E-Agenda by Deed") = MsgBoxResult.No Then
                    nome = InputBox("Introduza o seu nome completo.", "E-Agenda by DeeD")
                Else
                    Exit Sub
                End If
            End While
            Dim n As Boolean = False

            ' estruturas de validação e correção dos dados
            For Each i In nome.Split({Chr(32)})
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
        End If

        AppConfig.GuardarTudo()
        DeedMenu.Show()
    End Sub

    Private Sub Fechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fechar.Click
        LembreteManagement.GuardarTudo()
        AppConfig.GuardarTudo()

        End
    End Sub

    Dim tweenCompleto As Boolean = False
    Dim t As Integer = 0
    Dim h As Integer = 0
    Dim r, g, b As Integer
    Dim c, c1 As Color

    Private Sub TweenServ() Handles Tween.Tick ' controlos de fade in & fade out
        If Not tweenCompleto Then
            t = t + 15
            Me.Opacity = 0.85 * (t / 250) ^ (1 / 3)
            If Me.Opacity >= 0.85 Then
                Me.Opacity = 0.85
                tweenCompleto = True
            End If
        End If

        h = (h + 1) Mod 360

        Select Case h
            Case 0 To 60
                r = 255
                g = (1 - Math.Abs(((h / 60) Mod 2) - 1)) * 255
                b = 0
            Case 60 To 120
                r = (1 - Math.Abs(((h / 60) Mod 2) - 1)) * 255
                g = 255
                b = 0
            Case 120 To 180
                r = 0
                g = 255
                b = (1 - Math.Abs(((h / 60) Mod 2) - 1)) * 255
            Case 180 To 240
                r = 0
                g = (1 - Math.Abs(((h / 60) Mod 2) - 1)) * 255
                b = 255
            Case 240 To 300
                r = (1 - Math.Abs(((h / 60) Mod 2) - 1)) * 255
                g = 0
                b = 255
            Case 300 To 360
                r = 255
                g = 0
                b = (1 - Math.Abs(((h / 60) Mod 2) - 1)) * 255
        End Select

        c = Color.FromArgb(r, g, b)
        c1 = Color.FromArgb(r * (70 / 255), g * (70 / 255), b * (70 / 255))

        Algoritmo.BackColor = c

        Deed.BackColor = c
        Me.BackColor = c1
    End Sub
End Class