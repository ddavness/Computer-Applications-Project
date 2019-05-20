Public Class AlgoritmoResultados
    Dim Int0a25, Int25a50, Int50a75, Int75a100, Nvalores As Single

    Private Sub Resultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' obter valores do outro formulário
        Nvalores = AlgoritmoNums.Nvalores
        Int0a25 = AlgoritmoNums.Int0a25 / Nvalores
        Int25a50 = AlgoritmoNums.Int25a50 / Nvalores
        Int50a75 = AlgoritmoNums.Int50a75 / Nvalores
        Int75a100 = AlgoritmoNums.Int75a100 / Nvalores
        ' escrever nas labels

        Int1.Text = "O número de valores inseridos na classe [0, 25] é de " & Int0a25 * Nvalores & " que corresponde a: " & Int0a25 * 100 & "% do total de números inseridos."
        Int2.Text = "O número de valores inseridos na classe ]25, 50] é " & Int25a50 * Nvalores & " que corresponde a: " & Int25a50 * 100 & "% do total de números inseridos."
        Int3.Text = "O número de valores inseridos na classe ]50, 75] é " & Int50a75 * Nvalores & " que corresponde a: " & Int50a75 * 100 & "% do total de números inseridos."
        Int4.Text = "O número de valores inseridos na classe ]75, 100] é " & Int75a100 * Nvalores & " que corresponde a: " & Int75a100 * 100 & "% do total de números inseridos."
        ' Criar um gráfico circular
        Tarte.Series.Clear() ' limpar tudo

        Dim intervalos As String() = {"[0, 25]", "]25, 50]", "]50, 75]", "]75, 100]"} ' valores
        Dim valores As Single() = {Int0a25, Int25a50, Int50a75, Int75a100} ' valores

        For i = 0 To 3 ' retirar campos vazios
            If valores(i) = 0 Then
                valores(i) = Nothing
                intervalos(i) = Nothing
            End If
        Next

        Tarte.Series.Add("DistVal")
        Tarte.Series("DistVal").ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
        Tarte.Series("DistVal").LabelForeColor = Color.Transparent
        Tarte.Series("DistVal").SetCustomProperty("PieDrawingStyle", "Concave")
        Tarte.Series("DistVal").SetCustomProperty("PieLabelStyle", "Disabled")
        Tarte.Series("DistVal").Points.DataBindXY(intervalos, valores)
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResultFechar.Click
        Me.Close()
    End Sub

    Private Sub Desligar(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        AlgoritmoNums.Input.Text = ""
    End Sub
End Class