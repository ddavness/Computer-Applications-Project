<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlgoritmoResultados
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlgoritmoResultados))
        Me.ResultFechar = New System.Windows.Forms.Button()
        Me.Int3 = New System.Windows.Forms.Label()
        Me.Int1 = New System.Windows.Forms.Label()
        Me.Int4 = New System.Windows.Forms.Label()
        Me.Int2 = New System.Windows.Forms.Label()
        Me.Tarte = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.Tarte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResultFechar
        '
        Me.ResultFechar.Location = New System.Drawing.Point(12, 745)
        Me.ResultFechar.Name = "ResultFechar"
        Me.ResultFechar.Size = New System.Drawing.Size(75, 23)
        Me.ResultFechar.TabIndex = 6
        Me.ResultFechar.Text = "Fechar"
        Me.ResultFechar.UseVisualStyleBackColor = True
        '
        'Int3
        '
        Me.Int3.AutoSize = True
        Me.Int3.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Int3.ForeColor = System.Drawing.Color.White
        Me.Int3.Location = New System.Drawing.Point(29, 164)
        Me.Int3.Name = "Int3"
        Me.Int3.Size = New System.Drawing.Size(52, 19)
        Me.Int3.TabIndex = 5
        Me.Int3.Text = "Label1"
        '
        'Int1
        '
        Me.Int1.AutoSize = True
        Me.Int1.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Int1.ForeColor = System.Drawing.Color.White
        Me.Int1.Location = New System.Drawing.Point(29, 42)
        Me.Int1.Name = "Int1"
        Me.Int1.Size = New System.Drawing.Size(52, 19)
        Me.Int1.TabIndex = 4
        Me.Int1.Text = "Label1"
        '
        'Int4
        '
        Me.Int4.AutoSize = True
        Me.Int4.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Int4.ForeColor = System.Drawing.Color.White
        Me.Int4.Location = New System.Drawing.Point(29, 225)
        Me.Int4.Name = "Int4"
        Me.Int4.Size = New System.Drawing.Size(52, 19)
        Me.Int4.TabIndex = 3
        Me.Int4.Text = "Label1"
        '
        'Int2
        '
        Me.Int2.AutoSize = True
        Me.Int2.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Int2.ForeColor = System.Drawing.Color.White
        Me.Int2.Location = New System.Drawing.Point(29, 103)
        Me.Int2.Name = "Int2"
        Me.Int2.Size = New System.Drawing.Size(52, 19)
        Me.Int2.TabIndex = 2
        Me.Int2.Text = "Label1"
        '
        'Tarte
        '
        Me.Tarte.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        ChartArea1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        ChartArea1.Name = "ChartArea1"
        Me.Tarte.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Legend1.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.White
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Tarte.Legends.Add(Legend1)
        Me.Tarte.Location = New System.Drawing.Point(-2, 247)
        Me.Tarte.Name = "Tarte"
        Me.Tarte.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Me.Tarte.PaletteCustomColors = New System.Drawing.Color() {System.Drawing.Color.Teal, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer)), System.Drawing.Color.Cyan, System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))}
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Series1.CustomProperties = "CollectedColor=44\, 47\, 51"
        Series1.LabelBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Series1.Legend = "Legend1"
        Series1.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Series1.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Series1.MarkerImage = "44; 47; 51"
        Series1.MarkerImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series1.Name = "Series1"
        Series1.YValuesPerPoint = 4
        Me.Tarte.Series.Add(Series1)
        Me.Tarte.Size = New System.Drawing.Size(849, 534)
        Me.Tarte.TabIndex = 7
        Me.Tarte.Text = "Chart1"
        Title1.Font = New System.Drawing.Font("Calibri Light", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.White
        Title1.Name = "Title1"
        Title1.Text = "Distribuição dos valores"
        Me.Tarte.Titles.Add(Title1)
        '
        'AlgoritmoResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(844, 782)
        Me.Controls.Add(Me.ResultFechar)
        Me.Controls.Add(Me.Tarte)
        Me.Controls.Add(Me.Int3)
        Me.Controls.Add(Me.Int1)
        Me.Controls.Add(Me.Int4)
        Me.Controls.Add(Me.Int2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(860, 820)
        Me.MinimumSize = New System.Drawing.Size(860, 820)
        Me.Name = "AlgoritmoResultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Resultados"
        CType(Me.Tarte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ResultFechar As System.Windows.Forms.Button
    Friend WithEvents Int3 As System.Windows.Forms.Label
    Friend WithEvents Int1 As System.Windows.Forms.Label
    Friend WithEvents Int4 As System.Windows.Forms.Label
    Friend WithEvents Int2 As System.Windows.Forms.Label
    Friend WithEvents Tarte As System.Windows.Forms.DataVisualization.Charting.Chart
End Class
