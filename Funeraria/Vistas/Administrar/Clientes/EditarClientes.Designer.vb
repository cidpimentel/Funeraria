<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarClientes
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
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.panelTitleBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label9.Location = New System.Drawing.Point(746, 265)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 37)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Contraseña"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label10.Location = New System.Drawing.Point(492, 265)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 37)
        Me.Label10.TabIndex = 61
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
        Me.txtContraseña.Location = New System.Drawing.Point(746, 306)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtContraseña.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(238, 37)
        Me.txtContraseña.TabIndex = 60
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
        Me.txtUsuario.Location = New System.Drawing.Point(498, 306)
        Me.txtUsuario.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUsuario.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(238, 37)
        Me.txtUsuario.TabIndex = 59
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label8.Location = New System.Drawing.Point(27, 363)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 37)
        Me.Label8.TabIndex = 58
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
        Me.txtDomicilio.Location = New System.Drawing.Point(33, 405)
        Me.txtDomicilio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDomicilio.MaximumSize = New System.Drawing.Size(1500, 1538)
        Me.txtDomicilio.Multiline = True
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(951, 123)
        Me.txtDomicilio.TabIndex = 57
        Me.txtDomicilio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(27, 265)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 37)
        Me.Label7.TabIndex = 56
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
        Me.txtEmail.Location = New System.Drawing.Point(33, 306)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(456, 37)
        Me.txtEmail.TabIndex = 55
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(27, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 37)
        Me.Label6.TabIndex = 54
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
        Me.txtRFC.Location = New System.Drawing.Point(33, 215)
        Me.txtRFC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtRFC.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtRFC.Name = "txtRFC"
        Me.txtRFC.Size = New System.Drawing.Size(456, 37)
        Me.txtRFC.TabIndex = 53
        Me.txtRFC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(746, 174)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 37)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Celular"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(492, 174)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 37)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Tel.Fijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(746, 83)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 37)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(492, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 37)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(24, 83)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 37)
        Me.Label1.TabIndex = 48
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
        Me.TxtCelular.Location = New System.Drawing.Point(746, 215)
        Me.TxtCelular.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtCelular.MaximumSize = New System.Drawing.Size(321, 26)
        Me.TxtCelular.MaxLength = 10
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(238, 37)
        Me.TxtCelular.TabIndex = 47
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
        Me.txtFijo.Location = New System.Drawing.Point(498, 215)
        Me.txtFijo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFijo.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtFijo.MaxLength = 10
        Me.txtFijo.Name = "txtFijo"
        Me.txtFijo.Size = New System.Drawing.Size(238, 37)
        Me.txtFijo.TabIndex = 46
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
        Me.txtMaterno.Location = New System.Drawing.Point(746, 125)
        Me.txtMaterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtMaterno.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtMaterno.Name = "txtMaterno"
        Me.txtMaterno.Size = New System.Drawing.Size(238, 37)
        Me.txtMaterno.TabIndex = 45
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
        Me.txtPaterno.Location = New System.Drawing.Point(498, 125)
        Me.txtPaterno.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPaterno.MaximumSize = New System.Drawing.Size(321, 26)
        Me.txtPaterno.Name = "txtPaterno"
        Me.txtPaterno.Size = New System.Drawing.Size(238, 37)
        Me.txtPaterno.TabIndex = 44
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
        Me.txtNombre.Location = New System.Drawing.Point(30, 125)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNombre.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(459, 37)
        Me.txtNombre.TabIndex = 43
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.panelTitleBar.Size = New System.Drawing.Size(1010, 57)
        Me.panelTitleBar.TabIndex = 63
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
        Me.btnExit.Location = New System.Drawing.Point(960, 11)
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
        Me.lblFormTitle.Size = New System.Drawing.Size(157, 26)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Editar Cliente"
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
        Me.btnIngresar.Location = New System.Drawing.Point(786, 551)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(198, 40)
        Me.btnIngresar.TabIndex = 280
        Me.btnIngresar.Text = "&Guardar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'EditarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 609)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.panelTitleBar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDomicilio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtRFC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCelular)
        Me.Controls.Add(Me.txtFijo)
        Me.Controls.Add(Me.txtMaterno)
        Me.Controls.Add(Me.txtPaterno)
        Me.Controls.Add(Me.txtNombre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarClientes"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents btnIngresar As Button
End Class
