<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DeedDef
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeedDef))
        Me.Definições = New System.Windows.Forms.TabControl()
        Me.CGeral = New System.Windows.Forms.TabPage()
        Me.User = New System.Windows.Forms.TextBox()
        Me.EnviarSegNotificacao = New System.Windows.Forms.CheckBox()
        Me.NU = New System.Windows.Forms.Label()
        Me.Info = New System.Windows.Forms.Label()
        Me.ResetAll = New System.Windows.Forms.Button()
        Me.DeedLogo = New System.Windows.Forms.PictureBox()
        Me.CDados = New System.Windows.Forms.TabPage()
        Me.AGDAClean = New System.Windows.Forms.Button()
        Me.AutoApagar = New System.Windows.Forms.CheckBox()
        Me.CDiscord = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.WBToken = New System.Windows.Forms.Label()
        Me.AccId = New System.Windows.Forms.Label()
        Me.WBNome = New System.Windows.Forms.Label()
        Me.WBChannel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.OpenConfig = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.DiscordLogo = New System.Windows.Forms.PictureBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Descartar = New System.Windows.Forms.Button()
        Me.Definições.SuspendLayout()
        Me.CGeral.SuspendLayout()
        CType(Me.DeedLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CDados.SuspendLayout()
        Me.CDiscord.SuspendLayout()
        CType(Me.DiscordLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Definições
        '
        Me.Definições.Controls.Add(Me.CGeral)
        Me.Definições.Controls.Add(Me.CDados)
        Me.Definições.Controls.Add(Me.CDiscord)
        Me.Definições.Location = New System.Drawing.Point(14, 15)
        Me.Definições.Name = "Definições"
        Me.Definições.SelectedIndex = 0
        Me.Definições.Size = New System.Drawing.Size(476, 150)
        Me.Definições.TabIndex = 0
        '
        'CGeral
        '
        Me.CGeral.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CGeral.Controls.Add(Me.User)
        Me.CGeral.Controls.Add(Me.EnviarSegNotificacao)
        Me.CGeral.Controls.Add(Me.NU)
        Me.CGeral.Controls.Add(Me.Info)
        Me.CGeral.Controls.Add(Me.ResetAll)
        Me.CGeral.Controls.Add(Me.DeedLogo)
        Me.CGeral.Location = New System.Drawing.Point(4, 24)
        Me.CGeral.Name = "CGeral"
        Me.CGeral.Padding = New System.Windows.Forms.Padding(3)
        Me.CGeral.Size = New System.Drawing.Size(468, 122)
        Me.CGeral.TabIndex = 0
        Me.CGeral.Text = "Geral"
        '
        'User
        '
        Me.User.Location = New System.Drawing.Point(121, 7)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(235, 23)
        Me.User.TabIndex = 6
        '
        'EnviarSegNotificacao
        '
        Me.EnviarSegNotificacao.AutoSize = True
        Me.EnviarSegNotificacao.Location = New System.Drawing.Point(10, 33)
        Me.EnviarSegNotificacao.Name = "EnviarSegNotificacao"
        Me.EnviarSegNotificacao.Size = New System.Drawing.Size(277, 19)
        Me.EnviarSegNotificacao.TabIndex = 5
        Me.EnviarSegNotificacao.Text = "Enviar uma segunda notificação na própria hora"
        Me.EnviarSegNotificacao.UseVisualStyleBackColor = True
        '
        'NU
        '
        Me.NU.AutoSize = True
        Me.NU.Location = New System.Drawing.Point(7, 11)
        Me.NU.Name = "NU"
        Me.NU.Size = New System.Drawing.Size(107, 15)
        Me.NU.TabIndex = 3
        Me.NU.Text = "Nome de Utilizador"
        '
        'Info
        '
        Me.Info.AutoSize = True
        Me.Info.ForeColor = System.Drawing.SystemColors.Control
        Me.Info.Location = New System.Drawing.Point(183, 100)
        Me.Info.Name = "Info"
        Me.Info.Size = New System.Drawing.Size(74, 15)
        Me.Info.TabIndex = 2
        Me.Info.Text = "Deed | 2018"
        '
        'ResetAll
        '
        Me.ResetAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ResetAll.Location = New System.Drawing.Point(10, 90)
        Me.ResetAll.Name = "ResetAll"
        Me.ResetAll.Size = New System.Drawing.Size(170, 25)
        Me.ResetAll.TabIndex = 1
        Me.ResetAll.Text = "Reinicializar Agenda"
        Me.ResetAll.UseVisualStyleBackColor = True
        '
        'DeedLogo
        '
        Me.DeedLogo.Image = Global.DeedToolPack.My.Resources.Resources.Logótipo_Deed
        Me.DeedLogo.Location = New System.Drawing.Point(362, 8)
        Me.DeedLogo.Name = "DeedLogo"
        Me.DeedLogo.Size = New System.Drawing.Size(100, 100)
        Me.DeedLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DeedLogo.TabIndex = 0
        Me.DeedLogo.TabStop = False
        '
        'CDados
        '
        Me.CDados.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CDados.Controls.Add(Me.AGDAClean)
        Me.CDados.Controls.Add(Me.AutoApagar)
        Me.CDados.Location = New System.Drawing.Point(4, 24)
        Me.CDados.Name = "CDados"
        Me.CDados.Padding = New System.Windows.Forms.Padding(3)
        Me.CDados.Size = New System.Drawing.Size(468, 122)
        Me.CDados.TabIndex = 1
        Me.CDados.Text = "Gestão de Dados"
        '
        'AGDAClean
        '
        Me.AGDAClean.ForeColor = System.Drawing.Color.Black
        Me.AGDAClean.Location = New System.Drawing.Point(10, 90)
        Me.AGDAClean.Name = "AGDAClean"
        Me.AGDAClean.Size = New System.Drawing.Size(204, 25)
        Me.AGDAClean.TabIndex = 1
        Me.AGDAClean.Text = "Apagar todos os lembretes antigos"
        Me.AGDAClean.UseVisualStyleBackColor = True
        '
        'AutoApagar
        '
        Me.AutoApagar.AutoSize = True
        Me.AutoApagar.Location = New System.Drawing.Point(10, 11)
        Me.AutoApagar.Name = "AutoApagar"
        Me.AutoApagar.Size = New System.Drawing.Size(252, 19)
        Me.AutoApagar.TabIndex = 0
        Me.AutoApagar.Text = "Apagar automaticamente lembretes antigos"
        Me.AutoApagar.UseVisualStyleBackColor = True
        '
        'CDiscord
        '
        Me.CDiscord.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.CDiscord.Controls.Add(Me.Label6)
        Me.CDiscord.Controls.Add(Me.WBToken)
        Me.CDiscord.Controls.Add(Me.AccId)
        Me.CDiscord.Controls.Add(Me.WBNome)
        Me.CDiscord.Controls.Add(Me.WBChannel)
        Me.CDiscord.Controls.Add(Me.Label5)
        Me.CDiscord.Controls.Add(Me.Label9)
        Me.CDiscord.Controls.Add(Me.Label4)
        Me.CDiscord.Controls.Add(Me.OpenConfig)
        Me.CDiscord.Controls.Add(Me.Delete)
        Me.CDiscord.Controls.Add(Me.Status)
        Me.CDiscord.Controls.Add(Me.DiscordLogo)
        Me.CDiscord.Location = New System.Drawing.Point(4, 24)
        Me.CDiscord.Name = "CDiscord"
        Me.CDiscord.Size = New System.Drawing.Size(468, 122)
        Me.CDiscord.TabIndex = 2
        Me.CDiscord.Text = "Discord"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Token:"
        '
        'WBToken
        '
        Me.WBToken.AutoSize = True
        Me.WBToken.Font = New System.Drawing.Font("Calibri Light", 9.75!)
        Me.WBToken.Location = New System.Drawing.Point(114, 34)
        Me.WBToken.Name = "WBToken"
        Me.WBToken.Size = New System.Drawing.Size(63, 15)
        Me.WBToken.TabIndex = 3
        Me.WBToken.Text = "<nenhum>"
        '
        'AccId
        '
        Me.AccId.AutoSize = True
        Me.AccId.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccId.Location = New System.Drawing.Point(73, 49)
        Me.AccId.Name = "AccId"
        Me.AccId.Size = New System.Drawing.Size(63, 15)
        Me.AccId.TabIndex = 3
        Me.AccId.Text = "<nenhum>"
        '
        'WBNome
        '
        Me.WBNome.AutoSize = True
        Me.WBNome.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WBNome.Location = New System.Drawing.Point(74, 4)
        Me.WBNome.Name = "WBNome"
        Me.WBNome.Size = New System.Drawing.Size(63, 15)
        Me.WBNome.TabIndex = 3
        Me.WBNome.Text = "<nenhum>"
        '
        'WBChannel
        '
        Me.WBChannel.AutoSize = True
        Me.WBChannel.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WBChannel.Location = New System.Drawing.Point(114, 19)
        Me.WBChannel.Name = "WBChannel"
        Me.WBChannel.Size = New System.Drawing.Size(63, 15)
        Me.WBChannel.TabIndex = 3
        Me.WBChannel.Text = "<nenhum>"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Servidor/Canal:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Utilizador:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Webhook:"
        '
        'OpenConfig
        '
        Me.OpenConfig.ForeColor = System.Drawing.Color.Black
        Me.OpenConfig.Location = New System.Drawing.Point(7, 94)
        Me.OpenConfig.Name = "OpenConfig"
        Me.OpenConfig.Size = New System.Drawing.Size(127, 23)
        Me.OpenConfig.TabIndex = 2
        Me.OpenConfig.Text = "Configurar"
        Me.OpenConfig.UseVisualStyleBackColor = True
        '
        'Delete
        '
        Me.Delete.ForeColor = System.Drawing.Color.Black
        Me.Delete.Location = New System.Drawing.Point(140, 94)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(127, 23)
        Me.Delete.TabIndex = 2
        Me.Delete.Text = "Desativar Ligação"
        Me.Delete.UseVisualStyleBackColor = True
        '
        'Status
        '
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(365, 106)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(100, 16)
        Me.Status.TabIndex = 1
        Me.Status.Text = "Desligado"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DiscordLogo
        '
        Me.DiscordLogo.Image = Global.DeedToolPack.My.Resources.Resources.Discord_Logo_White
        Me.DiscordLogo.Location = New System.Drawing.Point(365, 4)
        Me.DiscordLogo.Name = "DiscordLogo"
        Me.DiscordLogo.Size = New System.Drawing.Size(100, 100)
        Me.DiscordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DiscordLogo.TabIndex = 0
        Me.DiscordLogo.TabStop = False
        '
        'Guardar
        '
        Me.Guardar.ForeColor = System.Drawing.Color.Black
        Me.Guardar.Location = New System.Drawing.Point(18, 167)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(177, 23)
        Me.Guardar.TabIndex = 1
        Me.Guardar.Text = "Guardar Alterações e Sair"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Descartar
        '
        Me.Descartar.ForeColor = System.Drawing.Color.Black
        Me.Descartar.Location = New System.Drawing.Point(309, 167)
        Me.Descartar.Name = "Descartar"
        Me.Descartar.Size = New System.Drawing.Size(177, 23)
        Me.Descartar.TabIndex = 1
        Me.Descartar.Text = "Descartar e Sair"
        Me.Descartar.UseVisualStyleBackColor = True
        '
        'DeedDef
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(504, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.Descartar)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Definições)
        Me.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(520, 240)
        Me.MinimumSize = New System.Drawing.Size(520, 240)
        Me.Name = "DeedDef"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Definições da agenda"
        Me.Definições.ResumeLayout(False)
        Me.CGeral.ResumeLayout(False)
        Me.CGeral.PerformLayout()
        CType(Me.DeedLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CDados.ResumeLayout(False)
        Me.CDados.PerformLayout()
        Me.CDiscord.ResumeLayout(False)
        Me.CDiscord.PerformLayout()
        CType(Me.DiscordLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Definições As System.Windows.Forms.TabControl
    Friend WithEvents CGeral As System.Windows.Forms.TabPage
    Friend WithEvents CDados As System.Windows.Forms.TabPage
    Friend WithEvents CDiscord As System.Windows.Forms.TabPage
    Friend WithEvents Info As System.Windows.Forms.Label
    Friend WithEvents ResetAll As System.Windows.Forms.Button
    Friend WithEvents DeedLogo As System.Windows.Forms.PictureBox
    Friend WithEvents NU As System.Windows.Forms.Label
    Friend WithEvents AutoApagar As System.Windows.Forms.CheckBox
    Friend WithEvents EnviarSegNotificacao As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents WBToken As System.Windows.Forms.Label
    Friend WithEvents AccId As System.Windows.Forms.Label
    Friend WithEvents WBNome As System.Windows.Forms.Label
    Friend WithEvents WBChannel As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents OpenConfig As System.Windows.Forms.Button
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents DiscordLogo As System.Windows.Forms.PictureBox
    Friend WithEvents Guardar As System.Windows.Forms.Button
    Friend WithEvents Descartar As System.Windows.Forms.Button
    Friend WithEvents AGDAClean As System.Windows.Forms.Button
    Friend WithEvents User As System.Windows.Forms.TextBox
End Class
