<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarContrato
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolioVenta = New System.Windows.Forms.TextBox()
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFinado = New System.Windows.Forms.TextBox()
        Me.txtFinadoDomicilio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFinadoFijo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFinadoMovil = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOficialia = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtLibro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtActa = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtmovil = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtFijo = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dateCortejo = New System.Windows.Forms.DateTimePicker()
        Me.txtPanteonHorno = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ListProductos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DescargarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.panelTitleBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        CType(Me.ListProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 37)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "NO.VENTA"
        '
        'txtFolioVenta
        '
        Me.txtFolioVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFolioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFolioVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFolioVenta.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtFolioVenta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFolioVenta.Location = New System.Drawing.Point(177, 83)
        Me.txtFolioVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFolioVenta.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtFolioVenta.Name = "txtFolioVenta"
        Me.txtFolioVenta.Size = New System.Drawing.Size(153, 37)
        Me.txtFolioVenta.TabIndex = 67
        Me.txtFolioVenta.Text = "0"
        Me.txtFolioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panelTitleBar
        '
        Me.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.panelTitleBar.Controls.Add(Me.btnExit)
        Me.panelTitleBar.Controls.Add(Me.lblFormTitle)
        Me.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelTitleBar.Location = New System.Drawing.Point(0, 0)
        Me.panelTitleBar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.panelTitleBar.Name = "panelTitleBar"
        Me.panelTitleBar.Size = New System.Drawing.Size(1200, 57)
        Me.panelTitleBar.TabIndex = 69
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
        Me.btnExit.Location = New System.Drawing.Point(1150, 11)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(40, 35)
        Me.btnExit.TabIndex = 9
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFormTitle
        '
        Me.lblFormTitle.AutoSize = True
        Me.lblFormTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitle.ForeColor = System.Drawing.SystemColors.Control
        Me.lblFormTitle.Location = New System.Drawing.Point(18, 14)
        Me.lblFormTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormTitle.Name = "lblFormTitle"
        Me.lblFormTitle.Size = New System.Drawing.Size(219, 26)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Detalle del contrato"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(33, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 37)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Nombre del finado"
        '
        'txtFinado
        '
        Me.txtFinado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFinado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFinado.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFinado.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtFinado.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFinado.Location = New System.Drawing.Point(39, 66)
        Me.txtFinado.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFinado.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtFinado.Name = "txtFinado"
        Me.txtFinado.Size = New System.Drawing.Size(1062, 37)
        Me.txtFinado.TabIndex = 71
        Me.txtFinado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFinadoDomicilio
        '
        Me.txtFinadoDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFinadoDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFinadoDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFinadoDomicilio.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtFinadoDomicilio.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFinadoDomicilio.Location = New System.Drawing.Point(39, 262)
        Me.txtFinadoDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFinadoDomicilio.MaximumSize = New System.Drawing.Size(1500, 1538)
        Me.txtFinadoDomicilio.Multiline = True
        Me.txtFinadoDomicilio.Name = "txtFinadoDomicilio"
        Me.txtFinadoDomicilio.Size = New System.Drawing.Size(1062, 125)
        Me.txtFinadoDomicilio.TabIndex = 73
        Me.txtFinadoDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(33, 211)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(281, 37)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Domicilio de velación"
        '
        'txtFinadoFijo
        '
        Me.txtFinadoFijo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFinadoFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFinadoFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFinadoFijo.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtFinadoFijo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFinadoFijo.Location = New System.Drawing.Point(154, 137)
        Me.txtFinadoFijo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFinadoFijo.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtFinadoFijo.Name = "txtFinadoFijo"
        Me.txtFinadoFijo.Size = New System.Drawing.Size(394, 37)
        Me.txtFinadoFijo.TabIndex = 75
        Me.txtFinadoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(33, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 37)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Tel.Fijo"
        '
        'txtFinadoMovil
        '
        Me.txtFinadoMovil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFinadoMovil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFinadoMovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFinadoMovil.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtFinadoMovil.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFinadoMovil.Location = New System.Drawing.Point(706, 137)
        Me.txtFinadoMovil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFinadoMovil.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtFinadoMovil.Name = "txtFinadoMovil"
        Me.txtFinadoMovil.Size = New System.Drawing.Size(394, 37)
        Me.txtFinadoMovil.TabIndex = 77
        Me.txtFinadoMovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(572, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 37)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "Tel.movil"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(36, 62)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(321, 37)
        Me.Label6.TabIndex = 78
        Me.Label6.Text = "Fecha y hora del  cortejo"
        '
        'txtOficialia
        '
        Me.txtOficialia.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtOficialia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtOficialia.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtOficialia.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtOficialia.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtOficialia.Location = New System.Drawing.Point(168, 49)
        Me.txtOficialia.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtOficialia.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtOficialia.Name = "txtOficialia"
        Me.txtOficialia.Size = New System.Drawing.Size(213, 37)
        Me.txtOficialia.TabIndex = 81
        Me.txtOficialia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(44, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 37)
        Me.Label7.TabIndex = 80
        Me.Label7.Text = "Oficialia"
        '
        'txtLibro
        '
        Me.txtLibro.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLibro.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLibro.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtLibro.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtLibro.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtLibro.Location = New System.Drawing.Point(520, 48)
        Me.txtLibro.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtLibro.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.Size = New System.Drawing.Size(213, 37)
        Me.txtLibro.TabIndex = 83
        Me.txtLibro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(436, 51)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 37)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Libro"
        '
        'txtActa
        '
        Me.txtActa.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtActa.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActa.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtActa.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtActa.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtActa.Location = New System.Drawing.Point(867, 48)
        Me.txtActa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtActa.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtActa.Name = "txtActa"
        Me.txtActa.Size = New System.Drawing.Size(213, 37)
        Me.txtActa.TabIndex = 85
        Me.txtActa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(789, 51)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 37)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "Acta"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.TabControl1.Location = New System.Drawing.Point(38, 148)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1144, 497)
        Me.TabControl1.TabIndex = 86
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtmovil)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtFijo)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtRFC)
        Me.TabPage1.Controls.Add(Me.txtDomicilio)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtCliente)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Location = New System.Drawing.Point(4, 46)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1136, 447)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cliente"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label17.Location = New System.Drawing.Point(483, 182)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 37)
        Me.Label17.TabIndex = 83
        Me.Label17.Text = "Tel.Móvil"
        '
        'txtmovil
        '
        Me.txtmovil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtmovil.BackColor = System.Drawing.Color.White
        Me.txtmovil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmovil.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtmovil.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtmovil.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtmovil.Location = New System.Drawing.Point(615, 180)
        Me.txtmovil.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtmovil.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtmovil.Name = "txtmovil"
        Me.txtmovil.ReadOnly = True
        Me.txtmovil.Size = New System.Drawing.Size(302, 37)
        Me.txtmovil.TabIndex = 82
        Me.txtmovil.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label16.Location = New System.Drawing.Point(39, 183)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 37)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Tel.Fijo"
        '
        'txtFijo
        '
        Me.txtFijo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFijo.BackColor = System.Drawing.Color.White
        Me.txtFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtFijo.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtFijo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFijo.Location = New System.Drawing.Point(160, 180)
        Me.txtFijo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFijo.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtFijo.Name = "txtFijo"
        Me.txtFijo.ReadOnly = True
        Me.txtFijo.Size = New System.Drawing.Size(302, 37)
        Me.txtFijo.TabIndex = 80
        Me.txtFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtEmail.Location = New System.Drawing.Point(160, 114)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(552, 37)
        Me.txtEmail.TabIndex = 79
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label15.Location = New System.Drawing.Point(39, 117)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 37)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Email"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label14.Location = New System.Drawing.Point(724, 117)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(68, 37)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "RFC"
        '
        'txtRFC
        '
        Me.txtRFC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRFC.BackColor = System.Drawing.Color.White
        Me.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtRFC.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtRFC.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRFC.Location = New System.Drawing.Point(806, 114)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRFC.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.ReadOnly = True
        Me.txtRFC.Size = New System.Drawing.Size(302, 37)
        Me.txtRFC.TabIndex = 76
        Me.txtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDomicilio.BackColor = System.Drawing.Color.White
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtDomicilio.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDomicilio.Location = New System.Drawing.Point(45, 278)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDomicilio.MaximumSize = New System.Drawing.Size(1500, 1538)
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(1062, 125)
        Me.txtDomicilio.TabIndex = 75
        Me.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label13.Location = New System.Drawing.Point(39, 237)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(133, 37)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "Domicilio"
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCliente.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCliente.Location = New System.Drawing.Point(160, 42)
        Me.txtCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCliente.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.ReadOnly = True
        Me.txtCliente.Size = New System.Drawing.Size(946, 37)
        Me.txtCliente.TabIndex = 73
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label12.Location = New System.Drawing.Point(39, 42)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(117, 37)
        Me.Label12.TabIndex = 72
        Me.Label12.Text = "Nombre"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.txtFinado)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.txtFinadoDomicilio)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtFinadoMovil)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.txtFinadoFijo)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Location = New System.Drawing.Point(4, 46)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(1136, 447)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Finado(a)"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.dateCortejo)
        Me.TabPage3.Controls.Add(Me.txtPanteonHorno)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Location = New System.Drawing.Point(4, 46)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage3.Size = New System.Drawing.Size(1136, 447)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Destinno"
        '
        'dateCortejo
        '
        Me.dateCortejo.CustomFormat = "dd/MM/yyyy HH:mm:ss"
        Me.dateCortejo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateCortejo.Location = New System.Drawing.Point(358, 55)
        Me.dateCortejo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dateCortejo.Name = "dateCortejo"
        Me.dateCortejo.Size = New System.Drawing.Size(397, 40)
        Me.dateCortejo.TabIndex = 80
        '
        'txtPanteonHorno
        '
        Me.txtPanteonHorno.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPanteonHorno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPanteonHorno.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtPanteonHorno.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtPanteonHorno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPanteonHorno.Location = New System.Drawing.Point(38, 183)
        Me.txtPanteonHorno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPanteonHorno.MaximumSize = New System.Drawing.Size(1500, 1538)
        Me.txtPanteonHorno.Multiline = True
        Me.txtPanteonHorno.Name = "txtPanteonHorno"
        Me.txtPanteonHorno.Size = New System.Drawing.Size(1062, 185)
        Me.txtPanteonHorno.TabIndex = 75
        Me.txtPanteonHorno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(36, 142)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(376, 37)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Panteon u Horno crematorio "
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.btnGuardar)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.ListProductos)
        Me.TabPage4.Controls.Add(Me.txtActa)
        Me.TabPage4.Controls.Add(Me.Label7)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.txtOficialia)
        Me.TabPage4.Controls.Add(Me.txtLibro)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Location = New System.Drawing.Point(4, 46)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Size = New System.Drawing.Size(1136, 447)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Oficialia"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Location = New System.Drawing.Point(882, 374)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(198, 40)
        Me.btnGuardar.TabIndex = 287
        Me.btnGuardar.Text = "&Agregar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label11.Location = New System.Drawing.Point(44, 120)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(321, 37)
        Me.Label11.TabIndex = 286
        Me.Label11.Text = "Documentos entregados"
        '
        'ListProductos
        '
        Me.ListProductos.AllowUserToAddRows = False
        Me.ListProductos.AllowUserToDeleteRows = False
        Me.ListProductos.AllowUserToResizeRows = False
        Me.ListProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ListProductos.Location = New System.Drawing.Point(50, 162)
        Me.ListProductos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListProductos.Name = "ListProductos"
        Me.ListProductos.ReadOnly = True
        Me.ListProductos.RowHeadersVisible = False
        Me.ListProductos.RowHeadersWidth = 62
        Me.ListProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListProductos.Size = New System.Drawing.Size(1030, 203)
        Me.ListProductos.TabIndex = 285
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(753, 654)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 40)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "&Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(969, 654)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 40)
        Me.Button2.TabIndex = 88
        Me.Button2.Text = "&Carta poder"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DescargarToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(164, 68)
        '
        'DescargarToolStripMenuItem
        '
        Me.DescargarToolStripMenuItem.Name = "DescargarToolStripMenuItem"
        Me.DescargarToolStripMenuItem.Size = New System.Drawing.Size(163, 32)
        Me.DescargarToolStripMenuItem.Text = "Descargar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(163, 32)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'EditarContrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1200, 718)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFolioVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarContrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarContrato"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.ListProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFolioVenta As TextBox
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFinado As TextBox
    Friend WithEvents txtFinadoDomicilio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtFinadoFijo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFinadoMovil As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtOficialia As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtLibro As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtActa As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dateCortejo As DateTimePicker
    Friend WithEvents txtPanteonHorno As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents Label11 As Label
    Friend WithEvents ListProductos As DataGridView
    Friend WithEvents Label17 As Label
    Friend WithEvents txtmovil As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtFijo As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DescargarToolStripMenuItem As ToolStripMenuItem
End Class
