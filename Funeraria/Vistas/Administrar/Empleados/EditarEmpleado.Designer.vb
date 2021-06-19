<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarEmpleado
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
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDomicilio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRFC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCelular = New System.Windows.Forms.TextBox()
        Me.txtFijo = New System.Windows.Forms.TextBox()
        Me.txtMaterno = New System.Windows.Forms.TextBox()
        Me.txtPaterno = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ListUsuarios = New System.Windows.Forms.DataGridView()
        Me.panelTitleBar.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.ListUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.panelTitleBar.Size = New System.Drawing.Size(1034, 57)
        Me.panelTitleBar.TabIndex = 2
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
        Me.btnExit.Location = New System.Drawing.Point(984, 11)
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
        Me.lblFormTitle.Size = New System.Drawing.Size(189, 26)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Editar Empleado"
        '
        'btnIngresar
        '
        Me.btnIngresar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIngresar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnIngresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnIngresar.FlatAppearance.BorderSize = 0
        Me.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnIngresar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnIngresar.Location = New System.Drawing.Point(812, 608)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(198, 40)
        Me.btnIngresar.TabIndex = 279
        Me.btnIngresar.Text = "&Guardar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Franklin Gothic Medium", 12.0!)
        Me.TabControl1.Location = New System.Drawing.Point(18, 66)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(998, 526)
        Me.TabControl1.TabIndex = 280
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.txtContraseña)
        Me.TabPage1.Controls.Add(Me.txtUsuario)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtDomicilio)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtEmail)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtRFC)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TxtCelular)
        Me.TabPage1.Controls.Add(Me.txtFijo)
        Me.TabPage1.Controls.Add(Me.txtMaterno)
        Me.TabPage1.Controls.Add(Me.txtPaterno)
        Me.TabPage1.Controls.Add(Me.txtNombre)
        Me.TabPage1.Location = New System.Drawing.Point(4, 39)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(990, 483)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Usuario"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(729, 194)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 37)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(476, 194)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 37)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "Usuario"
        '
        'txtContraseña
        '
        Me.txtContraseña.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtContraseña.Location = New System.Drawing.Point(729, 235)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(238, 37)
        Me.txtContraseña.TabIndex = 40
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsuario
        '
        Me.txtUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtUsuario.Location = New System.Drawing.Point(482, 235)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(238, 37)
        Me.txtUsuario.TabIndex = 39
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(10, 292)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 37)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Domicilio"
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDomicilio.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtDomicilio.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDomicilio.Location = New System.Drawing.Point(16, 334)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDomicilio.MaximumSize = New System.Drawing.Size(1500, 1538)
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(951, 123)
        Me.txtDomicilio.TabIndex = 37
        Me.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(10, 194)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 37)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtEmail.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtEmail.Location = New System.Drawing.Point(16, 235)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(456, 37)
        Me.txtEmail.TabIndex = 35
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(10, 103)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 37)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "RFC"
        '
        'txtRFC
        '
        Me.txtRFC.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRFC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRFC.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtRFC.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRFC.Location = New System.Drawing.Point(16, 145)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRFC.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(456, 37)
        Me.txtRFC.TabIndex = 33
        Me.txtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(729, 103)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 37)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(476, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 37)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Tel.Fijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(729, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 37)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(476, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 37)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 37)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nombre"
        '
        'TxtCelular
        '
        Me.TxtCelular.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtCelular.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtCelular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCelular.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.TxtCelular.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TxtCelular.Location = New System.Drawing.Point(729, 145)
        Me.TxtCelular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCelular.MaximumSize = New System.Drawing.Size(321, 26)
        Me.TxtCelular.MaxLength = 10
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(238, 37)
        Me.TxtCelular.TabIndex = 27
        Me.TxtCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFijo
        '
        Me.txtFijo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFijo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFijo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFijo.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtFijo.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtFijo.Location = New System.Drawing.Point(482, 145)
        Me.txtFijo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFijo.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtFijo.MaxLength = 10
        Me.txtFijo.Name = "txtFijo"
        Me.txtFijo.Size = New System.Drawing.Size(238, 37)
        Me.txtFijo.TabIndex = 26
        Me.txtFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMaterno
        '
        Me.txtMaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMaterno.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtMaterno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtMaterno.Location = New System.Drawing.Point(729, 54)
        Me.txtMaterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMaterno.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(238, 37)
        Me.txtMaterno.TabIndex = 25
        Me.txtMaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPaterno
        '
        Me.txtPaterno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaterno.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaterno.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtPaterno.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPaterno.Location = New System.Drawing.Point(482, 54)
        Me.txtPaterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPaterno.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(238, 37)
        Me.txtPaterno.TabIndex = 24
        Me.txtPaterno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtNombre.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNombre.Location = New System.Drawing.Point(14, 54)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(459, 37)
        Me.txtNombre.TabIndex = 23
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Controls.Add(Me.ListUsuarios)
        Me.TabPage2.Location = New System.Drawing.Point(4, 39)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(990, 483)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Permisos"
        '
        'ListUsuarios
        '
        Me.ListUsuarios.AllowUserToAddRows = False
        Me.ListUsuarios.AllowUserToDeleteRows = False
        Me.ListUsuarios.AllowUserToResizeRows = False
        Me.ListUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListUsuarios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.ListUsuarios.Location = New System.Drawing.Point(27, 51)
        Me.ListUsuarios.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListUsuarios.Name = "ListUsuarios"
        Me.ListUsuarios.RowHeadersVisible = False
        Me.ListUsuarios.RowHeadersWidth = 62
        Me.ListUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListUsuarios.Size = New System.Drawing.Size(921, 372)
        Me.ListUsuarios.TabIndex = 22
        '
        'EditarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1034, 669)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.panelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarEmpleado"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.ListUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnIngresar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDomicilio As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtCelular As TextBox
    Friend WithEvents txtFijo As TextBox
    Friend WithEvents txtMaterno As TextBox
    Friend WithEvents txtPaterno As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents ListUsuarios As DataGridView
End Class
