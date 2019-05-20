<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlgoritmoNums
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AlgoritmoNums))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exe = New System.Windows.Forms.Button()
        Me.LabelInput = New System.Windows.Forms.Label()
        Me.Nnums = New System.Windows.Forms.NumericUpDown()
        Me.LabelNum = New System.Windows.Forms.Label()
        Me.Input = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Nnums, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjudaToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(384, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'Exe
        '
        Me.Exe.Location = New System.Drawing.Point(15, 90)
        Me.Exe.Name = "Exe"
        Me.Exe.Size = New System.Drawing.Size(100, 125)
        Me.Exe.TabIndex = 2
        Me.Exe.Text = "Confirmar"
        Me.Exe.UseVisualStyleBackColor = True
        '
        'LabelInput
        '
        Me.LabelInput.AutoSize = True
        Me.LabelInput.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelInput.ForeColor = System.Drawing.Color.White
        Me.LabelInput.Location = New System.Drawing.Point(12, 44)
        Me.LabelInput.Name = "LabelInput"
        Me.LabelInput.Size = New System.Drawing.Size(232, 18)
        Me.LabelInput.TabIndex = 3
        Me.LabelInput.Text = "Introduza a quantidade de números:"
        '
        'Nnums
        '
        Me.Nnums.Location = New System.Drawing.Point(260, 44)
        Me.Nnums.Maximum = New Decimal(New Integer() {72, 0, 0, 0})
        Me.Nnums.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Nnums.Name = "Nnums"
        Me.Nnums.Size = New System.Drawing.Size(100, 20)
        Me.Nnums.TabIndex = 4
        Me.Nnums.ThousandsSeparator = True
        Me.Nnums.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'LabelNum
        '
        Me.LabelNum.AutoSize = True
        Me.LabelNum.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNum.ForeColor = System.Drawing.Color.White
        Me.LabelNum.Location = New System.Drawing.Point(128, 90)
        Me.LabelNum.Name = "LabelNum"
        Me.LabelNum.Size = New System.Drawing.Size(150, 18)
        Me.LabelNum.TabIndex = 3
        Me.LabelNum.Text = "Números Introduzidos:"
        '
        'Input
        '
        Me.Input.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.ForeColor = System.Drawing.Color.White
        Me.Input.Location = New System.Drawing.Point(128, 108)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(232, 107)
        Me.Input.TabIndex = 3
        '
        'AlgoritmoNums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(384, 226)
        Me.Controls.Add(Me.Nnums)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.LabelNum)
        Me.Controls.Add(Me.LabelInput)
        Me.Controls.Add(Me.Exe)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 265)
        Me.MinimumSize = New System.Drawing.Size(400, 265)
        Me.Name = "AlgoritmoNums"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Intervalos de números"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Nnums, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AjudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exe As System.Windows.Forms.Button
    Friend WithEvents LabelInput As System.Windows.Forms.Label
    Friend WithEvents Nnums As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelNum As System.Windows.Forms.Label
    Friend WithEvents Input As System.Windows.Forms.Label

End Class
