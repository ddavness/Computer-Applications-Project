<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DeedMenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DeedMenu))
        Me.Calendario = New System.Windows.Forms.MonthCalendar()
        Me.Header = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Strip = New System.Windows.Forms.MenuStrip()
        Me._Def = New System.Windows.Forms.ToolStripMenuItem()
        Me._Sair = New System.Windows.Forms.ToolStripMenuItem()
        Me._Background = New System.Windows.Forms.ToolStripMenuItem()
        Me._Quit = New System.Windows.Forms.ToolStripMenuItem()
        Me._DiscordPopupConfig = New System.Windows.Forms.Button()
        Me.DiscordDescription = New System.Windows.Forms.Label()
        Me.DiscordStatus = New System.Windows.Forms.Label()
        Me.DiscordLogo = New System.Windows.Forms.PictureBox()
        Me.Contador = New System.Windows.Forms.Timer(Me.components)
        Me.Taskbar = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LCurrent = New System.Windows.Forms.GroupBox()
        Me.EC4 = New System.Windows.Forms.Button()
        Me.EC3 = New System.Windows.Forms.Button()
        Me.EC2 = New System.Windows.Forms.Button()
        Me.DC4 = New System.Windows.Forms.Button()
        Me.DC3 = New System.Windows.Forms.Button()
        Me.DC2 = New System.Windows.Forms.Button()
        Me.DC1 = New System.Windows.Forms.Button()
        Me.EC1 = New System.Windows.Forms.Button()
        Me.LC4 = New System.Windows.Forms.Label()
        Me.LC3 = New System.Windows.Forms.Label()
        Me.LC2 = New System.Windows.Forms.Label()
        Me.LC1 = New System.Windows.Forms.Label()
        Me.HC1 = New System.Windows.Forms.Label()
        Me.HC4 = New System.Windows.Forms.Label()
        Me.HC2 = New System.Windows.Forms.Label()
        Me.HC3 = New System.Windows.Forms.Label()
        Me.NoEventsCurrent = New System.Windows.Forms.Label()
        Me.LNext = New System.Windows.Forms.GroupBox()
        Me.EN4 = New System.Windows.Forms.Button()
        Me.EN3 = New System.Windows.Forms.Button()
        Me.EN2 = New System.Windows.Forms.Button()
        Me.DN4 = New System.Windows.Forms.Button()
        Me.DN3 = New System.Windows.Forms.Button()
        Me.DN2 = New System.Windows.Forms.Button()
        Me.DN1 = New System.Windows.Forms.Button()
        Me.EN1 = New System.Windows.Forms.Button()
        Me.LN4 = New System.Windows.Forms.Label()
        Me.LN3 = New System.Windows.Forms.Label()
        Me.HN4 = New System.Windows.Forms.Label()
        Me.HN2 = New System.Windows.Forms.Label()
        Me.HN3 = New System.Windows.Forms.Label()
        Me.HN1 = New System.Windows.Forms.Label()
        Me.LN1 = New System.Windows.Forms.Label()
        Me.LN2 = New System.Windows.Forms.Label()
        Me.NoEventsNext = New System.Windows.Forms.Label()
        Me._NLembrete = New System.Windows.Forms.Button()
        Me.Data_Hora_Label = New System.Windows.Forms.Label()
        Me.Data_Hora = New System.Windows.Forms.Timer(Me.components)
        Me.Data_Hora_0 = New System.Windows.Forms.Timer(Me.components)
        Me.Strip.SuspendLayout()
        CType(Me.DiscordLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LCurrent.SuspendLayout()
        Me.LNext.SuspendLayout()
        Me.SuspendLayout()
        '
        'Calendario
        '
        Me.Calendario.BackColor = System.Drawing.SystemColors.ControlText
        Me.Calendario.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.Calendario.Location = New System.Drawing.Point(501, 102)
        Me.Calendario.MaxSelectionCount = 1
        Me.Calendario.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.Calendario.Name = "Calendario"
        Me.Calendario.TabIndex = 0
        Me.Calendario.TodayDate = New Date(2018, 3, 16, 0, 0, 0, 0)
        '
        'Header
        '
        Me.Header.Font = New System.Drawing.Font("Calibri", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Header.ForeColor = System.Drawing.Color.White
        Me.Header.Location = New System.Drawing.Point(19, 41)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(427, 52)
        Me.Header.TabIndex = 1
        Me.Header.Text = "Olá, pessoa!"
        Me.Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.Transparent
        Me.Label.Font = New System.Drawing.Font("Calibri Light", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.White
        Me.Label.Location = New System.Drawing.Point(14, 93)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(432, 26)
        Me.Label.TabIndex = 1
        Me.Label.Text = "Aqui estão os seus compromissos:"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Strip
        '
        Me.Strip.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Def, Me._Sair})
        Me.Strip.Location = New System.Drawing.Point(0, 0)
        Me.Strip.Name = "Strip"
        Me.Strip.Size = New System.Drawing.Size(749, 24)
        Me.Strip.TabIndex = 2
        Me.Strip.Text = "MenuStrip1"
        '
        '_Def
        '
        Me._Def.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me._Def.Name = "_Def"
        Me._Def.Size = New System.Drawing.Size(74, 20)
        Me._Def.Text = "Definições"
        '
        '_Sair
        '
        Me._Sair.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me._Background, Me._Quit})
        Me._Sair.ForeColor = System.Drawing.SystemColors.ControlLight
        Me._Sair.Name = "_Sair"
        Me._Sair.Size = New System.Drawing.Size(38, 20)
        Me._Sair.Text = "Sair"
        '
        '_Background
        '
        Me._Background.Name = "_Background"
        Me._Background.Size = New System.Drawing.Size(214, 22)
        Me._Background.Text = "Manter em segundo plano"
        '
        '_Quit
        '
        Me._Quit.Name = "_Quit"
        Me._Quit.Size = New System.Drawing.Size(214, 22)
        Me._Quit.Text = "Fechar todos os processos"
        '
        '_DiscordPopupConfig
        '
        Me._DiscordPopupConfig.BackColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(181, Byte), Integer))
        Me._DiscordPopupConfig.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me._DiscordPopupConfig.Location = New System.Drawing.Point(224, 487)
        Me._DiscordPopupConfig.Name = "_DiscordPopupConfig"
        Me._DiscordPopupConfig.Size = New System.Drawing.Size(75, 23)
        Me._DiscordPopupConfig.TabIndex = 4
        Me._DiscordPopupConfig.Text = "Configurar"
        Me._DiscordPopupConfig.UseVisualStyleBackColor = False
        '
        'DiscordDescription
        '
        Me.DiscordDescription.AutoSize = True
        Me.DiscordDescription.BackColor = System.Drawing.Color.Transparent
        Me.DiscordDescription.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscordDescription.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.DiscordDescription.Location = New System.Drawing.Point(224, 463)
        Me.DiscordDescription.Name = "DiscordDescription"
        Me.DiscordDescription.Size = New System.Drawing.Size(239, 18)
        Me.DiscordDescription.TabIndex = 1
        Me.DiscordDescription.Text = "Receba as suas notificações no Discord"
        '
        'DiscordStatus
        '
        Me.DiscordStatus.BackColor = System.Drawing.Color.Transparent
        Me.DiscordStatus.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiscordStatus.ForeColor = System.Drawing.Color.Red
        Me.DiscordStatus.Location = New System.Drawing.Point(86, 492)
        Me.DiscordStatus.Name = "DiscordStatus"
        Me.DiscordStatus.Size = New System.Drawing.Size(50, 15)
        Me.DiscordStatus.TabIndex = 1
        Me.DiscordStatus.Text = "Desligado"
        Me.DiscordStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DiscordLogo
        '
        Me.DiscordLogo.Image = Global.DeedToolPack.My.Resources.Resources.Discord_Logo_Wordmark_White
        Me.DiscordLogo.Location = New System.Drawing.Point(19, 450)
        Me.DiscordLogo.Name = "DiscordLogo"
        Me.DiscordLogo.Size = New System.Drawing.Size(199, 60)
        Me.DiscordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.DiscordLogo.TabIndex = 3
        Me.DiscordLogo.TabStop = False
        '
        'Contador
        '
        Me.Contador.Enabled = True
        Me.Contador.Interval = 6000
        '
        'Taskbar
        '
        Me.Taskbar.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.Taskbar.BalloonTipText = "Ir às compras"
        Me.Taskbar.BalloonTipTitle = "LEMBRETE (69 Minutos):"
        Me.Taskbar.Icon = CType(resources.GetObject("Taskbar.Icon"), System.Drawing.Icon)
        Me.Taskbar.Text = "E-Agenda by Deed"
        Me.Taskbar.Visible = True
        '
        'LCurrent
        '
        Me.LCurrent.Controls.Add(Me.EC4)
        Me.LCurrent.Controls.Add(Me.EC3)
        Me.LCurrent.Controls.Add(Me.EC2)
        Me.LCurrent.Controls.Add(Me.DC4)
        Me.LCurrent.Controls.Add(Me.DC3)
        Me.LCurrent.Controls.Add(Me.DC2)
        Me.LCurrent.Controls.Add(Me.DC1)
        Me.LCurrent.Controls.Add(Me.EC1)
        Me.LCurrent.Controls.Add(Me.LC4)
        Me.LCurrent.Controls.Add(Me.LC3)
        Me.LCurrent.Controls.Add(Me.LC2)
        Me.LCurrent.Controls.Add(Me.LC1)
        Me.LCurrent.Controls.Add(Me.HC1)
        Me.LCurrent.Controls.Add(Me.HC4)
        Me.LCurrent.Controls.Add(Me.HC2)
        Me.LCurrent.Controls.Add(Me.HC3)
        Me.LCurrent.Controls.Add(Me.NoEventsCurrent)
        Me.LCurrent.ForeColor = System.Drawing.Color.White
        Me.LCurrent.Location = New System.Drawing.Point(19, 123)
        Me.LCurrent.Name = "LCurrent"
        Me.LCurrent.Size = New System.Drawing.Size(427, 161)
        Me.LCurrent.TabIndex = 6
        Me.LCurrent.TabStop = False
        Me.LCurrent.Text = "Hoje"
        '
        'EC4
        '
        Me.EC4.Image = CType(resources.GetObject("EC4.Image"), System.Drawing.Image)
        Me.EC4.Location = New System.Drawing.Point(346, 113)
        Me.EC4.Name = "EC4"
        Me.EC4.Size = New System.Drawing.Size(25, 25)
        Me.EC4.TabIndex = 3
        Me.EC4.UseVisualStyleBackColor = True
        Me.EC4.Visible = False
        '
        'EC3
        '
        Me.EC3.Image = CType(resources.GetObject("EC3.Image"), System.Drawing.Image)
        Me.EC3.Location = New System.Drawing.Point(346, 83)
        Me.EC3.Name = "EC3"
        Me.EC3.Size = New System.Drawing.Size(25, 25)
        Me.EC3.TabIndex = 3
        Me.EC3.UseVisualStyleBackColor = True
        Me.EC3.Visible = False
        '
        'EC2
        '
        Me.EC2.Image = CType(resources.GetObject("EC2.Image"), System.Drawing.Image)
        Me.EC2.Location = New System.Drawing.Point(346, 53)
        Me.EC2.Name = "EC2"
        Me.EC2.Size = New System.Drawing.Size(25, 25)
        Me.EC2.TabIndex = 3
        Me.EC2.UseVisualStyleBackColor = True
        Me.EC2.Visible = False
        '
        'DC4
        '
        Me.DC4.Image = CType(resources.GetObject("DC4.Image"), System.Drawing.Image)
        Me.DC4.Location = New System.Drawing.Point(377, 113)
        Me.DC4.Name = "DC4"
        Me.DC4.Size = New System.Drawing.Size(25, 25)
        Me.DC4.TabIndex = 3
        Me.DC4.UseVisualStyleBackColor = True
        Me.DC4.Visible = False
        '
        'DC3
        '
        Me.DC3.Image = CType(resources.GetObject("DC3.Image"), System.Drawing.Image)
        Me.DC3.Location = New System.Drawing.Point(377, 83)
        Me.DC3.Name = "DC3"
        Me.DC3.Size = New System.Drawing.Size(25, 25)
        Me.DC3.TabIndex = 3
        Me.DC3.UseVisualStyleBackColor = True
        Me.DC3.Visible = False
        '
        'DC2
        '
        Me.DC2.Image = Global.DeedToolPack.My.Resources.Resources.delete_icon
        Me.DC2.Location = New System.Drawing.Point(377, 53)
        Me.DC2.Name = "DC2"
        Me.DC2.Size = New System.Drawing.Size(25, 25)
        Me.DC2.TabIndex = 3
        Me.DC2.UseVisualStyleBackColor = True
        Me.DC2.Visible = False
        '
        'DC1
        '
        Me.DC1.Image = Global.DeedToolPack.My.Resources.Resources.delete_icon
        Me.DC1.Location = New System.Drawing.Point(377, 23)
        Me.DC1.Name = "DC1"
        Me.DC1.Size = New System.Drawing.Size(25, 25)
        Me.DC1.TabIndex = 3
        Me.DC1.UseVisualStyleBackColor = True
        Me.DC1.Visible = False
        '
        'EC1
        '
        Me.EC1.Image = CType(resources.GetObject("EC1.Image"), System.Drawing.Image)
        Me.EC1.Location = New System.Drawing.Point(346, 23)
        Me.EC1.Name = "EC1"
        Me.EC1.Size = New System.Drawing.Size(25, 25)
        Me.EC1.TabIndex = 3
        Me.EC1.UseVisualStyleBackColor = True
        Me.EC1.Visible = False
        '
        'LC4
        '
        Me.LC4.AutoSize = True
        Me.LC4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LC4.Location = New System.Drawing.Point(25, 115)
        Me.LC4.Name = "LC4"
        Me.LC4.Size = New System.Drawing.Size(239, 18)
        Me.LC4.TabIndex = 1
        Me.LC4.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LC4.Visible = False
        '
        'LC3
        '
        Me.LC3.AutoSize = True
        Me.LC3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LC3.Location = New System.Drawing.Point(25, 85)
        Me.LC3.Name = "LC3"
        Me.LC3.Size = New System.Drawing.Size(239, 18)
        Me.LC3.TabIndex = 1
        Me.LC3.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LC3.Visible = False
        '
        'LC2
        '
        Me.LC2.AutoSize = True
        Me.LC2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LC2.Location = New System.Drawing.Point(25, 55)
        Me.LC2.Name = "LC2"
        Me.LC2.Size = New System.Drawing.Size(239, 18)
        Me.LC2.TabIndex = 1
        Me.LC2.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LC2.Visible = False
        '
        'LC1
        '
        Me.LC1.AutoSize = True
        Me.LC1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LC1.Location = New System.Drawing.Point(25, 25)
        Me.LC1.Name = "LC1"
        Me.LC1.Size = New System.Drawing.Size(239, 18)
        Me.LC1.TabIndex = 1
        Me.LC1.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LC1.Visible = False
        '
        'HC1
        '
        Me.HC1.AutoSize = True
        Me.HC1.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HC1.Location = New System.Drawing.Point(268, 25)
        Me.HC1.Name = "HC1"
        Me.HC1.Size = New System.Drawing.Size(64, 18)
        Me.HC1.TabIndex = 1
        Me.HC1.Text = "23:00:00"
        Me.HC1.Visible = False
        '
        'HC4
        '
        Me.HC4.AutoSize = True
        Me.HC4.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HC4.Location = New System.Drawing.Point(268, 115)
        Me.HC4.Name = "HC4"
        Me.HC4.Size = New System.Drawing.Size(64, 18)
        Me.HC4.TabIndex = 1
        Me.HC4.Text = "23:00:00"
        Me.HC4.Visible = False
        '
        'HC2
        '
        Me.HC2.AutoSize = True
        Me.HC2.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HC2.Location = New System.Drawing.Point(268, 55)
        Me.HC2.Name = "HC2"
        Me.HC2.Size = New System.Drawing.Size(64, 18)
        Me.HC2.TabIndex = 1
        Me.HC2.Text = "23:00:00"
        Me.HC2.Visible = False
        '
        'HC3
        '
        Me.HC3.AutoSize = True
        Me.HC3.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HC3.Location = New System.Drawing.Point(268, 85)
        Me.HC3.Name = "HC3"
        Me.HC3.Size = New System.Drawing.Size(64, 18)
        Me.HC3.TabIndex = 1
        Me.HC3.Text = "23:00:00"
        Me.HC3.Visible = False
        '
        'NoEventsCurrent
        '
        Me.NoEventsCurrent.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoEventsCurrent.ForeColor = System.Drawing.Color.Gray
        Me.NoEventsCurrent.Location = New System.Drawing.Point(63, 30)
        Me.NoEventsCurrent.Name = "NoEventsCurrent"
        Me.NoEventsCurrent.Size = New System.Drawing.Size(300, 100)
        Me.NoEventsCurrent.TabIndex = 0
        Me.NoEventsCurrent.Text = "Não há nada :("
        Me.NoEventsCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NoEventsCurrent.Visible = False
        '
        'LNext
        '
        Me.LNext.Controls.Add(Me.EN4)
        Me.LNext.Controls.Add(Me.EN3)
        Me.LNext.Controls.Add(Me.EN2)
        Me.LNext.Controls.Add(Me.DN4)
        Me.LNext.Controls.Add(Me.DN3)
        Me.LNext.Controls.Add(Me.DN2)
        Me.LNext.Controls.Add(Me.DN1)
        Me.LNext.Controls.Add(Me.EN1)
        Me.LNext.Controls.Add(Me.LN4)
        Me.LNext.Controls.Add(Me.LN3)
        Me.LNext.Controls.Add(Me.HN4)
        Me.LNext.Controls.Add(Me.HN2)
        Me.LNext.Controls.Add(Me.HN3)
        Me.LNext.Controls.Add(Me.HN1)
        Me.LNext.Controls.Add(Me.LN1)
        Me.LNext.Controls.Add(Me.LN2)
        Me.LNext.Controls.Add(Me.NoEventsNext)
        Me.LNext.ForeColor = System.Drawing.Color.White
        Me.LNext.Location = New System.Drawing.Point(19, 283)
        Me.LNext.Name = "LNext"
        Me.LNext.Size = New System.Drawing.Size(427, 161)
        Me.LNext.TabIndex = 6
        Me.LNext.TabStop = False
        Me.LNext.Text = "Amanhã"
        '
        'EN4
        '
        Me.EN4.Image = CType(resources.GetObject("EN4.Image"), System.Drawing.Image)
        Me.EN4.Location = New System.Drawing.Point(346, 113)
        Me.EN4.Name = "EN4"
        Me.EN4.Size = New System.Drawing.Size(25, 25)
        Me.EN4.TabIndex = 3
        Me.EN4.UseVisualStyleBackColor = True
        Me.EN4.Visible = False
        '
        'EN3
        '
        Me.EN3.Image = CType(resources.GetObject("EN3.Image"), System.Drawing.Image)
        Me.EN3.Location = New System.Drawing.Point(346, 83)
        Me.EN3.Name = "EN3"
        Me.EN3.Size = New System.Drawing.Size(25, 25)
        Me.EN3.TabIndex = 3
        Me.EN3.UseVisualStyleBackColor = True
        Me.EN3.Visible = False
        '
        'EN2
        '
        Me.EN2.Image = CType(resources.GetObject("EN2.Image"), System.Drawing.Image)
        Me.EN2.Location = New System.Drawing.Point(346, 53)
        Me.EN2.Name = "EN2"
        Me.EN2.Size = New System.Drawing.Size(25, 25)
        Me.EN2.TabIndex = 3
        Me.EN2.UseVisualStyleBackColor = True
        Me.EN2.Visible = False
        '
        'DN4
        '
        Me.DN4.Image = CType(resources.GetObject("DN4.Image"), System.Drawing.Image)
        Me.DN4.Location = New System.Drawing.Point(377, 113)
        Me.DN4.Name = "DN4"
        Me.DN4.Size = New System.Drawing.Size(25, 25)
        Me.DN4.TabIndex = 3
        Me.DN4.UseVisualStyleBackColor = True
        Me.DN4.Visible = False
        '
        'DN3
        '
        Me.DN3.Image = CType(resources.GetObject("DN3.Image"), System.Drawing.Image)
        Me.DN3.Location = New System.Drawing.Point(377, 83)
        Me.DN3.Name = "DN3"
        Me.DN3.Size = New System.Drawing.Size(25, 25)
        Me.DN3.TabIndex = 3
        Me.DN3.UseVisualStyleBackColor = True
        Me.DN3.Visible = False
        '
        'DN2
        '
        Me.DN2.Image = CType(resources.GetObject("DN2.Image"), System.Drawing.Image)
        Me.DN2.Location = New System.Drawing.Point(377, 53)
        Me.DN2.Name = "DN2"
        Me.DN2.Size = New System.Drawing.Size(25, 25)
        Me.DN2.TabIndex = 3
        Me.DN2.UseVisualStyleBackColor = True
        Me.DN2.Visible = False
        '
        'DN1
        '
        Me.DN1.Image = CType(resources.GetObject("DN1.Image"), System.Drawing.Image)
        Me.DN1.Location = New System.Drawing.Point(377, 23)
        Me.DN1.Name = "DN1"
        Me.DN1.Size = New System.Drawing.Size(25, 25)
        Me.DN1.TabIndex = 3
        Me.DN1.UseVisualStyleBackColor = True
        Me.DN1.Visible = False
        '
        'EN1
        '
        Me.EN1.Image = CType(resources.GetObject("EN1.Image"), System.Drawing.Image)
        Me.EN1.Location = New System.Drawing.Point(346, 23)
        Me.EN1.Name = "EN1"
        Me.EN1.Size = New System.Drawing.Size(25, 25)
        Me.EN1.TabIndex = 3
        Me.EN1.UseVisualStyleBackColor = True
        Me.EN1.Visible = False
        '
        'LN4
        '
        Me.LN4.AutoSize = True
        Me.LN4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN4.Location = New System.Drawing.Point(25, 115)
        Me.LN4.Name = "LN4"
        Me.LN4.Size = New System.Drawing.Size(239, 18)
        Me.LN4.TabIndex = 1
        Me.LN4.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LN4.Visible = False
        '
        'LN3
        '
        Me.LN3.AutoSize = True
        Me.LN3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN3.Location = New System.Drawing.Point(25, 85)
        Me.LN3.Name = "LN3"
        Me.LN3.Size = New System.Drawing.Size(239, 18)
        Me.LN3.TabIndex = 1
        Me.LN3.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LN3.Visible = False
        '
        'HN4
        '
        Me.HN4.AutoSize = True
        Me.HN4.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HN4.Location = New System.Drawing.Point(268, 115)
        Me.HN4.Name = "HN4"
        Me.HN4.Size = New System.Drawing.Size(64, 18)
        Me.HN4.TabIndex = 1
        Me.HN4.Text = "23:00:00"
        Me.HN4.Visible = False
        '
        'HN2
        '
        Me.HN2.AutoSize = True
        Me.HN2.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HN2.Location = New System.Drawing.Point(268, 55)
        Me.HN2.Name = "HN2"
        Me.HN2.Size = New System.Drawing.Size(64, 18)
        Me.HN2.TabIndex = 1
        Me.HN2.Text = "23:00:00"
        Me.HN2.Visible = False
        '
        'HN3
        '
        Me.HN3.AutoSize = True
        Me.HN3.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HN3.Location = New System.Drawing.Point(268, 85)
        Me.HN3.Name = "HN3"
        Me.HN3.Size = New System.Drawing.Size(64, 18)
        Me.HN3.TabIndex = 1
        Me.HN3.Text = "23:00:00"
        Me.HN3.Visible = False
        '
        'HN1
        '
        Me.HN1.AutoSize = True
        Me.HN1.Font = New System.Drawing.Font("Calibri Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HN1.Location = New System.Drawing.Point(268, 25)
        Me.HN1.Name = "HN1"
        Me.HN1.Size = New System.Drawing.Size(64, 18)
        Me.HN1.TabIndex = 1
        Me.HN1.Text = "23:00:00"
        Me.HN1.Visible = False
        '
        'LN1
        '
        Me.LN1.AutoSize = True
        Me.LN1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN1.Location = New System.Drawing.Point(25, 25)
        Me.LN1.Name = "LN1"
        Me.LN1.Size = New System.Drawing.Size(239, 18)
        Me.LN1.TabIndex = 1
        Me.LN1.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LN1.Visible = False
        '
        'LN2
        '
        Me.LN2.AutoSize = True
        Me.LN2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LN2.Location = New System.Drawing.Point(25, 55)
        Me.LN2.Name = "LN2"
        Me.LN2.Size = New System.Drawing.Size(239, 18)
        Me.LN2.TabIndex = 1
        Me.LN2.Text = "k8TqaQGRP3wtI2SGXfjDvopEtpjPafQk"
        Me.LN2.Visible = False
        '
        'NoEventsNext
        '
        Me.NoEventsNext.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoEventsNext.ForeColor = System.Drawing.Color.Gray
        Me.NoEventsNext.Location = New System.Drawing.Point(63, 30)
        Me.NoEventsNext.Name = "NoEventsNext"
        Me.NoEventsNext.Size = New System.Drawing.Size(300, 100)
        Me.NoEventsNext.TabIndex = 0
        Me.NoEventsNext.Text = "Não há nada :("
        Me.NoEventsNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NoEventsNext.Visible = False
        '
        '_NLembrete
        '
        Me._NLembrete.Location = New System.Drawing.Point(501, 425)
        Me._NLembrete.Name = "_NLembrete"
        Me._NLembrete.Size = New System.Drawing.Size(227, 23)
        Me._NLembrete.TabIndex = 0
        Me._NLembrete.Text = "Novo Evento"
        Me._NLembrete.UseVisualStyleBackColor = True
        '
        'Data_Hora_Label
        '
        Me.Data_Hora_Label.Font = New System.Drawing.Font("Calibri Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data_Hora_Label.ForeColor = System.Drawing.Color.White
        Me.Data_Hora_Label.Location = New System.Drawing.Point(365, 492)
        Me.Data_Hora_Label.Name = "Data_Hora_Label"
        Me.Data_Hora_Label.Size = New System.Drawing.Size(363, 24)
        Me.Data_Hora_Label.TabIndex = 7
        Me.Data_Hora_Label.Text = "A inicializar..."
        Me.Data_Hora_Label.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Data_Hora
        '
        Me.Data_Hora.Interval = 1000
        '
        'Data_Hora_0
        '
        '
        'DeedMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(749, 531)
        Me.Controls.Add(Me.Data_Hora_Label)
        Me.Controls.Add(Me.DiscordStatus)
        Me.Controls.Add(Me._NLembrete)
        Me.Controls.Add(Me.LNext)
        Me.Controls.Add(Me.LCurrent)
        Me.Controls.Add(Me._DiscordPopupConfig)
        Me.Controls.Add(Me.DiscordLogo)
        Me.Controls.Add(Me.DiscordDescription)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.Calendario)
        Me.Controls.Add(Me.Strip)
        Me.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.Strip
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(765, 570)
        Me.MinimumSize = New System.Drawing.Size(765, 570)
        Me.Name = "DeedMenu"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.Strip.ResumeLayout(False)
        Me.Strip.PerformLayout()
        CType(Me.DiscordLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LCurrent.ResumeLayout(False)
        Me.LCurrent.PerformLayout()
        Me.LNext.ResumeLayout(False)
        Me.LNext.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Calendario As System.Windows.Forms.MonthCalendar
    Friend WithEvents Header As System.Windows.Forms.Label
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents Strip As System.Windows.Forms.MenuStrip
    Friend WithEvents _Sair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiscordLogo As System.Windows.Forms.PictureBox
    Friend WithEvents _DiscordPopupConfig As System.Windows.Forms.Button
    Friend WithEvents DiscordDescription As System.Windows.Forms.Label
    Friend WithEvents DiscordStatus As System.Windows.Forms.Label
    Friend WithEvents _Def As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _Background As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents _Quit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Contador As System.Windows.Forms.Timer
    Friend WithEvents Taskbar As System.Windows.Forms.NotifyIcon
    Friend WithEvents LCurrent As System.Windows.Forms.GroupBox
    Friend WithEvents LNext As System.Windows.Forms.GroupBox
    Friend WithEvents _NLembrete As System.Windows.Forms.Button
    Friend WithEvents NoEventsCurrent As System.Windows.Forms.Label
    Friend WithEvents NoEventsNext As System.Windows.Forms.Label
    Friend WithEvents LC1 As System.Windows.Forms.Label
    Friend WithEvents LC3 As System.Windows.Forms.Label
    Friend WithEvents LC2 As System.Windows.Forms.Label
    Friend WithEvents LN3 As System.Windows.Forms.Label
    Friend WithEvents HN1 As System.Windows.Forms.Label
    Friend WithEvents LN1 As System.Windows.Forms.Label
    Friend WithEvents LN2 As System.Windows.Forms.Label
    Friend WithEvents HN2 As System.Windows.Forms.Label
    Friend WithEvents HN3 As System.Windows.Forms.Label
    Friend WithEvents EC1 As System.Windows.Forms.Button
    Friend WithEvents HC1 As System.Windows.Forms.Label
    Friend WithEvents HC2 As System.Windows.Forms.Label
    Friend WithEvents HC3 As System.Windows.Forms.Label
    Friend WithEvents EC3 As System.Windows.Forms.Button
    Friend WithEvents EC2 As System.Windows.Forms.Button
    Friend WithEvents EN3 As System.Windows.Forms.Button
    Friend WithEvents EN2 As System.Windows.Forms.Button
    Friend WithEvents EN1 As System.Windows.Forms.Button
    Friend WithEvents EC4 As System.Windows.Forms.Button
    Friend WithEvents LC4 As System.Windows.Forms.Label
    Friend WithEvents HC4 As System.Windows.Forms.Label
    Friend WithEvents EN4 As System.Windows.Forms.Button
    Friend WithEvents LN4 As System.Windows.Forms.Label
    Friend WithEvents HN4 As System.Windows.Forms.Label
    Friend WithEvents DC4 As System.Windows.Forms.Button
    Friend WithEvents DC3 As System.Windows.Forms.Button
    Friend WithEvents DC2 As System.Windows.Forms.Button
    Friend WithEvents DC1 As System.Windows.Forms.Button
    Friend WithEvents DN4 As System.Windows.Forms.Button
    Friend WithEvents DN3 As System.Windows.Forms.Button
    Friend WithEvents DN2 As System.Windows.Forms.Button
    Friend WithEvents DN1 As System.Windows.Forms.Button
    Friend WithEvents Data_Hora_Label As System.Windows.Forms.Label
    Friend WithEvents Data_Hora As System.Windows.Forms.Timer
    Friend WithEvents Data_Hora_0 As System.Windows.Forms.Timer
End Class
