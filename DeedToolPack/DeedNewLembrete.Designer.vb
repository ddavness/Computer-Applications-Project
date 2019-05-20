<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeedNewLembrete
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeedNewLembrete))
        Me.Exe = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataEvento = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Titulo = New System.Windows.Forms.TextBox()
        Me.Desc = New System.Windows.Forms.TextBox()
        Me.AtAviso = New System.Windows.Forms.ComboBox()
        Me.HoraEvento = New System.Windows.Forms.DateTimePicker()
        Me.DataAviso = New System.Windows.Forms.DateTimePicker()
        Me.HoraAviso = New System.Windows.Forms.DateTimePicker()
        Me.Av = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Exe
        '
        Me.Exe.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Exe.Location = New System.Drawing.Point(104, 229)
        Me.Exe.Name = "Exe"
        Me.Exe.Size = New System.Drawing.Size(327, 20)
        Me.Exe.TabIndex = 0
        Me.Exe.Text = "Concluir"
        Me.Exe.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Novo Lembrete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(121, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Título"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(94, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 19)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Descrição"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataEvento
        '
        Me.DataEvento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataEvento.Location = New System.Drawing.Point(173, 118)
        Me.DataEvento.Name = "DataEvento"
        Me.DataEvento.Size = New System.Drawing.Size(90, 20)
        Me.DataEvento.TabIndex = 3
        Me.DataEvento.Value = New Date(2018, 3, 10, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 19)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Data e Hora do Evento"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(11, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 19)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Antecedência de Aviso"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Titulo
        '
        Me.Titulo.Location = New System.Drawing.Point(173, 42)
        Me.Titulo.MaxLength = 32
        Me.Titulo.Name = "Titulo"
        Me.Titulo.Size = New System.Drawing.Size(350, 20)
        Me.Titulo.TabIndex = 4
        '
        'Desc
        '
        Me.Desc.Location = New System.Drawing.Point(173, 81)
        Me.Desc.MaxLength = 256
        Me.Desc.Name = "Desc"
        Me.Desc.Size = New System.Drawing.Size(350, 20)
        Me.Desc.TabIndex = 4
        '
        'AtAviso
        '
        Me.AtAviso.FormattingEnabled = True
        Me.AtAviso.Items.AddRange(New Object() {"Avisar na própria hora", "5 minutos", "15 minutos", "30 minutos", "1 hora", "2 horas", "3 horas", "Outro..."})
        Me.AtAviso.Location = New System.Drawing.Point(173, 153)
        Me.AtAviso.Name = "AtAviso"
        Me.AtAviso.Size = New System.Drawing.Size(187, 21)
        Me.AtAviso.TabIndex = 5
        Me.AtAviso.Text = "Avisar na própria hora"
        '
        'HoraEvento
        '
        Me.HoraEvento.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraEvento.Location = New System.Drawing.Point(270, 118)
        Me.HoraEvento.Name = "HoraEvento"
        Me.HoraEvento.ShowUpDown = True
        Me.HoraEvento.Size = New System.Drawing.Size(90, 20)
        Me.HoraEvento.TabIndex = 3
        Me.HoraEvento.Value = New Date(2018, 3, 10, 0, 0, 0, 0)
        '
        'DataAviso
        '
        Me.DataAviso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataAviso.Location = New System.Drawing.Point(173, 188)
        Me.DataAviso.Name = "DataAviso"
        Me.DataAviso.Size = New System.Drawing.Size(90, 20)
        Me.DataAviso.TabIndex = 3
        Me.DataAviso.Value = New Date(2018, 3, 10, 0, 0, 0, 0)
        Me.DataAviso.Visible = False
        '
        'HoraAviso
        '
        Me.HoraAviso.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraAviso.Location = New System.Drawing.Point(270, 188)
        Me.HoraAviso.Name = "HoraAviso"
        Me.HoraAviso.ShowUpDown = True
        Me.HoraAviso.Size = New System.Drawing.Size(90, 20)
        Me.HoraAviso.TabIndex = 3
        Me.HoraAviso.Value = New Date(2018, 3, 10, 0, 0, 0, 0)
        Me.HoraAviso.Visible = False
        '
        'Av
        '
        Me.Av.AutoSize = True
        Me.Av.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Av.ForeColor = System.Drawing.Color.White
        Me.Av.Location = New System.Drawing.Point(87, 188)
        Me.Av.Name = "Av"
        Me.Av.Size = New System.Drawing.Size(80, 19)
        Me.Av.TabIndex = 1
        Me.Av.Text = "Avisar às..."
        Me.Av.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Av.Visible = False
        '
        'DeedNewLembrete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(534, 262)
        Me.Controls.Add(Me.AtAviso)
        Me.Controls.Add(Me.Desc)
        Me.Controls.Add(Me.Titulo)
        Me.Controls.Add(Me.Av)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HoraAviso)
        Me.Controls.Add(Me.HoraEvento)
        Me.Controls.Add(Me.DataAviso)
        Me.Controls.Add(Me.DataEvento)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Exe)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 300)
        Me.MinimumSize = New System.Drawing.Size(550, 300)
        Me.Name = "DeedNewLembrete"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Novo Lembrete"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Exe As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataEvento As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Titulo As System.Windows.Forms.TextBox
    Friend WithEvents Desc As System.Windows.Forms.TextBox
    Friend WithEvents AtAviso As System.Windows.Forms.ComboBox
    Friend WithEvents HoraEvento As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataAviso As System.Windows.Forms.DateTimePicker
    Friend WithEvents HoraAviso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Av As System.Windows.Forms.Label
End Class
