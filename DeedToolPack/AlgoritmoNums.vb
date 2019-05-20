Public Class AlgoritmoNums
    Public Int0a25, Int25a50, Int50a75, Int75a100, Nvalores As Integer
    Dim Valor As String

    Private Sub Exe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Exe.Click
        If (IsNumeric(Nnums.Value) And Val(Nnums.Value) > 0) Then
            ' redefinir valores
            Exe.Enabled = False ' desativar botão
            Input.Text = ""
            Int0a25 = 0
            Int25a50 = 0
            Int50a75 = 0
            Int75a100 = 0
            Nvalores = Nnums.Value

            For i As Integer = 1 To Val(Nnums.Text)
                Do
                    Valor = InputBox("Introduza o " & i & "º número.", "Números")
                    If String.IsNullOrWhiteSpace(Valor) Then
                        If MsgBox("Dados em branco. Abortar contagem?", MsgBoxStyle.YesNo, "Contagem de Números") = MsgBoxResult.Yes Then
                            Exe.Enabled = True
                            Exit Sub
                        Else
                            Valor = -1
                        End If
                    ElseIf Not IsNumeric(Valor) Or Val(Valor) < 0 Or Val(Valor) > 100 Then
                        MsgBox("Valor inválido. Insira um valor entre 0 e 100, inclusive.", MsgBoxStyle.Exclamation, "Contagem de Números")
                        Valor = -1
                    ElseIf i = Val(Nnums.Text) Then
                        Input.Text = Input.Text & Val(Valor).ToString
                    Else
                        Input.Text = Input.Text & Val(Valor).ToString & " ; "
                    End If
                Loop Until (Valor >= 0 And Valor <= 100)
                If Val(Valor) > 75 Then
                    Int75a100 = Int75a100 + 1
                ElseIf Val(Valor) > 50 Then
                    Int50a75 = Int50a75 + 1
                ElseIf Val(Valor) > 25 Then
                    Int25a50 = Int25a50 + 1
                Else
                    Int0a25 = Int0a25 + 1
                End If
            Next
            AlgoritmoResultados.Close() ' atualiza os resultados caso a form já esteja aberta
            AlgoritmoResultados.Show(Me)
            Exe.Enabled = True ' reativar botão
        Else
            MsgBox("Não introduziu um valor válido.", MsgBoxStyle.Exclamation, "Contagem de Números")
            Nnums.Value = 1
        End If
    End Sub

    Private Sub Intervalos_nums_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Nnums.Maximum = 100
        Int0a25 = 0
        Int25a50 = 0
        Int50a75 = 0
        Int75a100 = 0
    End Sub

    Private Sub AjudaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjudaToolStripMenuItem.Click
        AlgoritmoAjuda.Show()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

End Class