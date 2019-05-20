<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscordConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiscordConfig))
        Me.PingUser = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Exe = New System.Windows.Forms.Button()
        Me.Help = New System.Windows.Forms.Button()
        Me.Status = New System.Windows.Forms.Label()
        Me.DSPic = New System.Windows.Forms.PictureBox()
        Me.AccID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ApiUrl = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DSPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PingUser
        '
        Me.PingUser.AutoSize = True
        Me.PingUser.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PingUser.ForeColor = System.Drawing.Color.White
        Me.PingUser.Location = New System.Drawing.Point(228, 97)
        Me.PingUser.Name = "PingUser"
        Me.PingUser.Size = New System.Drawing.Size(184, 19)
        Me.PingUser.TabIndex = 1
        Me.PingUser.Text = "Mencionar utilizador? ('ping')"
        Me.PingUser.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(767, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EX: 123456789123456789"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Exe
        '
        Me.Exe.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Exe.Enabled = False
        Me.Exe.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Exe.Location = New System.Drawing.Point(22, 128)
        Me.Exe.Name = "Exe"
        Me.Exe.Size = New System.Drawing.Size(69, 23)
        Me.Exe.TabIndex = 3
        Me.Exe.Text = "Concluir"
        Me.Exe.UseVisualStyleBackColor = False
        '
        'Help
        '
        Me.Help.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Help.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Help.Location = New System.Drawing.Point(97, 128)
        Me.Help.Name = "Help"
        Me.Help.Size = New System.Drawing.Size(69, 23)
        Me.Help.TabIndex = 3
        Me.Help.Text = "Ajuda"
        Me.Help.UseVisualStyleBackColor = False
        '
        'Status
        '
        Me.Status.ForeColor = System.Drawing.Color.Red
        Me.Status.Location = New System.Drawing.Point(16, 86)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(75, 15)
        Me.Status.TabIndex = 5
        Me.Status.Text = "Desligado"
        Me.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DSPic
        '
        Me.DSPic.Image = Global.DeedToolPack.My.Resources.Resources.Discord_Logo_White
        Me.DSPic.Location = New System.Drawing.Point(22, 23)
        Me.DSPic.Name = "DSPic"
        Me.DSPic.Size = New System.Drawing.Size(61, 60)
        Me.DSPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DSPic.TabIndex = 4
        Me.DSPic.TabStop = False
        '
        'AccID
        '
        Me.AccID.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.AccID.Enabled = False
        Me.AccID.ForeColor = System.Drawing.Color.White
        Me.AccID.Location = New System.Drawing.Point(706, 96)
        Me.AccID.MaxLength = 18
        Me.AccID.Name = "AccID"
        Me.AccID.Size = New System.Drawing.Size(239, 20)
        Me.AccID.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(93, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Link do Webhook"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ApiUrl
        '
        Me.ApiUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.ApiUrl.ForeColor = System.Drawing.Color.White
        Me.ApiUrl.Location = New System.Drawing.Point(228, 44)
        Me.ApiUrl.Name = "ApiUrl"
        Me.ApiUrl.Size = New System.Drawing.Size(716, 20)
        Me.ApiUrl.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(586, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "ID do Utilizador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(228, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(373, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "O link tem de começar com ""https://discordapp.com/api/webhooks/"""
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiscordConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(965, 168)
        Me.Controls.Add(Me.ApiUrl)
        Me.Controls.Add(Me.AccID)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.DSPic)
        Me.Controls.Add(Me.Help)
        Me.Controls.Add(Me.Exe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PingUser)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(975, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(975, 200)
        Me.Name = "DiscordConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configurar Ligação ao Discord"
        CType(Me.DSPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PingUser As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Exe As System.Windows.Forms.Button
    Friend WithEvents DSPic As System.Windows.Forms.PictureBox
    Friend WithEvents Help As System.Windows.Forms.Button
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents AccID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ApiUrl As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
