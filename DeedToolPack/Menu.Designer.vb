<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.Deed = New System.Windows.Forms.Button()
        Me.Fechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Tween = New System.Windows.Forms.Timer(Me.components)
        Me.Algoritmo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Deed
        '
        Me.Deed.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Deed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Deed.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Deed.Location = New System.Drawing.Point(58, 257)
        Me.Deed.Name = "Deed"
        Me.Deed.Size = New System.Drawing.Size(164, 40)
        Me.Deed.TabIndex = 0
        Me.Deed.Text = "E-Agenda By Deed"
        Me.Deed.UseVisualStyleBackColor = False
        '
        'Fechar
        '
        Me.Fechar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Fechar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Fechar.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fechar.Location = New System.Drawing.Point(85, 332)
        Me.Fechar.Name = "Fechar"
        Me.Fechar.Size = New System.Drawing.Size(110, 25)
        Me.Fechar.TabIndex = 0
        Me.Fechar.Text = "Fechar Tudo"
        Me.Fechar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Fechar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(91, 148)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Deed Toolpack"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.DeedToolPack.My.Resources.Resources.Logótipo_Deed
        Me.PictureBox1.Location = New System.Drawing.Point(76, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Tween
        '
        Me.Tween.Enabled = True
        Me.Tween.Interval = 15
        '
        'Algoritmo
        '
        Me.Algoritmo.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Algoritmo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Algoritmo.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Algoritmo.Location = New System.Drawing.Point(58, 183)
        Me.Algoritmo.Name = "Algoritmo"
        Me.Algoritmo.Size = New System.Drawing.Size(164, 40)
        Me.Algoritmo.TabIndex = 0
        Me.Algoritmo.Text = "Contagem de Números"
        Me.Algoritmo.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(280, 380)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Fechar)
        Me.Controls.Add(Me.Deed)
        Me.Controls.Add(Me.Algoritmo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Deed As System.Windows.Forms.Button
    Friend WithEvents Fechar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Tween As System.Windows.Forms.Timer
    Friend WithEvents Algoritmo As System.Windows.Forms.Button
End Class
