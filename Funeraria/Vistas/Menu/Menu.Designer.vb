<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.IconButton8 = New FontAwesome.Sharp.IconButton()
        Me.IconButton5 = New FontAwesome.Sharp.IconButton()
        Me.IconButton4 = New FontAwesome.Sharp.IconButton()
        Me.IconButton7 = New FontAwesome.Sharp.IconButton()
        Me.IconButton6 = New FontAwesome.Sharp.IconButton()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.IconButton1 = New FontAwesome.Sharp.IconButton()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.btnHome = New System.Windows.Forms.PictureBox()
        Me.lblHoraFecha = New System.Windows.Forms.Label()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.btnMaximize = New FontAwesome.Sharp.IconButton()
        Me.btnRestore = New FontAwesome.Sharp.IconButton()
        Me.btnMinimize = New FontAwesome.Sharp.IconButton()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.IconCurrentForm = New FontAwesome.Sharp.IconPictureBox()
        Me.PanelDesktop = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu.SuspendLayout()
        Me.panelLogo.SuspendLayout()
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDesktop.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.panelMenu.Controls.Add(Me.IconButton8)
        Me.panelMenu.Controls.Add(Me.IconButton5)
        Me.panelMenu.Controls.Add(Me.IconButton4)
        Me.panelMenu.Controls.Add(Me.IconButton7)
        Me.panelMenu.Controls.Add(Me.IconButton6)
        Me.panelMenu.Controls.Add(Me.IconButton3)
        Me.panelMenu.Controls.Add(Me.IconButton2)
        Me.panelMenu.Controls.Add(Me.IconButton1)
        Me.panelMenu.Controls.Add(Me.panelLogo)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(272, 1037)
        Me.panelMenu.TabIndex = 0
        '
        'IconButton8
        '
        Me.IconButton8.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton8.FlatAppearance.BorderSize = 0
        Me.IconButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton8.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton8.IconChar = FontAwesome.Sharp.IconChar.ChartBar
        Me.IconButton8.IconColor = System.Drawing.Color.White
        Me.IconButton8.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.Location = New System.Drawing.Point(0, 930)
        Me.IconButton8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton8.Name = "IconButton8"
        Me.IconButton8.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton8.Size = New System.Drawing.Size(272, 92)
        Me.IconButton8.TabIndex = 32
        Me.IconButton8.Text = "Reportes"
        Me.IconButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton8.UseVisualStyleBackColor = True
        '
        'IconButton5
        '
        Me.IconButton5.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton5.FlatAppearance.BorderSize = 0
        Me.IconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton5.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton5.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconButton5.IconColor = System.Drawing.Color.White
        Me.IconButton5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.Location = New System.Drawing.Point(0, 838)
        Me.IconButton5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton5.Name = "IconButton5"
        Me.IconButton5.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton5.Size = New System.Drawing.Size(272, 92)
        Me.IconButton5.TabIndex = 31
        Me.IconButton5.Text = "Empleados"
        Me.IconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton5.UseVisualStyleBackColor = True
        '
        'IconButton4
        '
        Me.IconButton4.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton4.FlatAppearance.BorderSize = 0
        Me.IconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton4.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton4.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.IconButton4.IconColor = System.Drawing.Color.White
        Me.IconButton4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.Location = New System.Drawing.Point(0, 746)
        Me.IconButton4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton4.Name = "IconButton4"
        Me.IconButton4.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton4.Size = New System.Drawing.Size(272, 92)
        Me.IconButton4.TabIndex = 30
        Me.IconButton4.Text = "Clientes"
        Me.IconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton4.UseVisualStyleBackColor = True
        '
        'IconButton7
        '
        Me.IconButton7.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton7.FlatAppearance.BorderSize = 0
        Me.IconButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton7.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton7.IconChar = FontAwesome.Sharp.IconChar.BoxOpen
        Me.IconButton7.IconColor = System.Drawing.Color.White
        Me.IconButton7.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.Location = New System.Drawing.Point(0, 654)
        Me.IconButton7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton7.Name = "IconButton7"
        Me.IconButton7.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton7.Size = New System.Drawing.Size(272, 92)
        Me.IconButton7.TabIndex = 29
        Me.IconButton7.Text = "Productos"
        Me.IconButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton7.UseVisualStyleBackColor = True
        '
        'IconButton6
        '
        Me.IconButton6.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton6.FlatAppearance.BorderSize = 0
        Me.IconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton6.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton6.IconChar = FontAwesome.Sharp.IconChar.Cubes
        Me.IconButton6.IconColor = System.Drawing.Color.White
        Me.IconButton6.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.Location = New System.Drawing.Point(0, 562)
        Me.IconButton6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton6.Name = "IconButton6"
        Me.IconButton6.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton6.Size = New System.Drawing.Size(272, 92)
        Me.IconButton6.TabIndex = 28
        Me.IconButton6.Text = "Paquetes"
        Me.IconButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton6.UseVisualStyleBackColor = True
        '
        'IconButton3
        '
        Me.IconButton3.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.PeopleCarry
        Me.IconButton3.IconColor = System.Drawing.Color.White
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.Location = New System.Drawing.Point(0, 470)
        Me.IconButton3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton3.Size = New System.Drawing.Size(272, 92)
        Me.IconButton3.TabIndex = 24
        Me.IconButton3.Text = "Movimientos"
        Me.IconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton3.UseVisualStyleBackColor = True
        '
        'IconButton2
        '
        Me.IconButton2.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.FileSignature
        Me.IconButton2.IconColor = System.Drawing.Color.White
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.Location = New System.Drawing.Point(0, 378)
        Me.IconButton2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton2.Size = New System.Drawing.Size(272, 92)
        Me.IconButton2.TabIndex = 23
        Me.IconButton2.Text = "Contratos"
        Me.IconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton2.UseVisualStyleBackColor = True
        '
        'IconButton1
        '
        Me.IconButton1.Dock = System.Windows.Forms.DockStyle.Top
        Me.IconButton1.FlatAppearance.BorderSize = 0
        Me.IconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton1.ForeColor = System.Drawing.SystemColors.Control
        Me.IconButton1.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar
        Me.IconButton1.IconColor = System.Drawing.Color.White
        Me.IconButton1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.Location = New System.Drawing.Point(0, 286)
        Me.IconButton1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconButton1.Name = "IconButton1"
        Me.IconButton1.Padding = New System.Windows.Forms.Padding(15, 0, 30, 0)
        Me.IconButton1.Size = New System.Drawing.Size(272, 92)
        Me.IconButton1.TabIndex = 21
        Me.IconButton1.Text = "Ventas"
        Me.IconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.IconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.IconButton1.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.Controls.Add(Me.btnHome)
        Me.panelLogo.Controls.Add(Me.lblHoraFecha)
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(272, 286)
        Me.panelLogo.TabIndex = 0
        '
        'btnHome
        '
        Me.btnHome.Image = CType(resources.GetObject("btnHome.Image"), System.Drawing.Image)
        Me.btnHome.Location = New System.Drawing.Point(18, 14)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(236, 175)
        Me.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHome.TabIndex = 0
        Me.btnHome.TabStop = False
        '
        'lblHoraFecha
        '
        Me.lblHoraFecha.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblHoraFecha.ForeColor = System.Drawing.SystemColors.Window
        Me.lblHoraFecha.Location = New System.Drawing.Point(18, 197)
        Me.lblHoraFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraFecha.Name = "lblHoraFecha"
        Me.lblHoraFecha.Size = New System.Drawing.Size(236, 85)
        Me.lblHoraFecha.TabIndex = 8
        Me.lblHoraFecha.Text = "00:00:00"
        Me.lblHoraFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.btnMaximize)
        Me.panelTitleBar.Controls.Add(Me.btnRestore)
        Me.panelTitleBar.Controls.Add(Me.btnMinimize)
        Me.panelTitleBar.Controls.Add(Me.btnExit)
        Me.panelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.panelTitleBar.Controls.Add(Me.IconCurrentForm)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(272, 0)
        Me.panelTitleBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(1074, 63)
        Me.panelTitleBar.TabIndex = 1
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.FlatAppearance.BorderSize = 0
        Me.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize
        Me.btnMaximize.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMaximize.IconSize = 20
        Me.btnMaximize.Location = New System.Drawing.Point(966, 14)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(40, 35)
        Me.btnMaximize.TabIndex = 11
        Me.btnMaximize.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestore.FlatAppearance.BorderSize = 0
        Me.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore
        Me.btnRestore.IconColor = System.Drawing.Color.Gainsboro
        Me.btnRestore.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnRestore.IconSize = 20
        Me.btnRestore.Location = New System.Drawing.Point(966, 14)
        Me.btnRestore.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(40, 35)
        Me.btnRestore.TabIndex = 10
        Me.btnRestore.UseVisualStyleBackColor = True
        Me.btnRestore.Visible = False
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.FlatAppearance.BorderSize = 0
        Me.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize
        Me.btnMinimize.IconColor = System.Drawing.Color.Gainsboro
        Me.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnMinimize.IconSize = 20
        Me.btnMinimize.Location = New System.Drawing.Point(916, 14)
        Me.btnMinimize.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(40, 35)
        Me.btnMinimize.TabIndex = 9
        Me.btnMinimize.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times
        Me.btnExit.IconColor = System.Drawing.Color.Gainsboro
        Me.btnExit.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnExit.IconSize = 20
        Me.btnExit.Location = New System.Drawing.Point(1016, 14)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 35)
        Me.btnExit.TabIndex = 8
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFormTitle.Location = New System.Drawing.Point(96, 20)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(69, 26)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Inicio"
        '
        'IconCurrentForm
        '
        Me.IconCurrentForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.IconCurrentForm.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.IconCurrentForm.IconChar = FontAwesome.Sharp.IconChar.Home
        Me.IconCurrentForm.IconColor = System.Drawing.SystemColors.ControlLight
        Me.IconCurrentForm.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCurrentForm.IconSize = 52
        Me.IconCurrentForm.Location = New System.Drawing.Point(33, 8)
        Me.IconCurrentForm.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IconCurrentForm.Name = "IconCurrentForm"
        Me.IconCurrentForm.Size = New System.Drawing.Size(60, 52)
        Me.IconCurrentForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconCurrentForm.TabIndex = 0
        Me.IconCurrentForm.TabStop = False
        '
        'PanelDesktop
        '
        Me.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.PanelDesktop.Controls.Add(Me.PictureBox1)
        Me.PanelDesktop.Controls.Add(Me.Label4)
        Me.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDesktop.Location = New System.Drawing.Point(272, 63)
        Me.PanelDesktop.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PanelDesktop.Name = "PanelDesktop"
        Me.PanelDesktop.Size = New System.Drawing.Size(1074, 974)
        Me.PanelDesktop.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(354, 234)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(417, 278)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(306, 528)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(502, 42)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "AGENCIA FUNERARIA GARCÍA"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(272, 63)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 974)
        Me.Panel1.TabIndex = 3
        '
        'Timer1
        '
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(278, 63)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1068, 7)
        Me.Panel2.TabIndex = 5
        '
        'Timer2
        '
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 1037)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelDesktop)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.panelMenu)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panelMenu.ResumeLayout(False)
        Me.panelLogo.ResumeLayout(False)
        CType(Me.btnHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.IconCurrentForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDesktop.ResumeLayout(False)
        Me.PanelDesktop.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelMenu As Panel
    Friend WithEvents panelLogo As Panel
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents IconCurrentForm As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents PanelDesktop As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnRestore As FontAwesome.Sharp.IconButton
    Friend WithEvents btnMinimize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblHoraFecha As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnMaximize As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHome As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconButton8 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton5 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton4 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton7 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton6 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton1 As FontAwesome.Sharp.IconButton
    Friend WithEvents Timer2 As Timer
End Class
