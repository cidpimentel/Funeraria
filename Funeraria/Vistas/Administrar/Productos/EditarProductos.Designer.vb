<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarProductos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtParte = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVenta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCompra = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboUnidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboMarca = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboCategoria = New System.Windows.Forms.ComboBox()
        Me.btnUnidades = New System.Windows.Forms.Button()
        Me.btnMarca = New System.Windows.Forms.Button()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.checkOnine = New System.Windows.Forms.CheckBox()
        Me.panelTitleBar.SuspendLayout()
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
        Me.panelTitleBar.Size = New System.Drawing.Size(1222, 57)
        Me.panelTitleBar.TabIndex = 64
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
        Me.btnExit.Location = New System.Drawing.Point(1173, 11)
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
        Me.lblFormTitle.Size = New System.Drawing.Size(177, 26)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Editar Producto"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(33, 98)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 37)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "NO.PARTE"
        '
        'txtParte
        '
        Me.txtParte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtParte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtParte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtParte.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtParte.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtParte.Location = New System.Drawing.Point(184, 98)
        Me.txtParte.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtParte.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtParte.Name = "txtParte"
        Me.txtParte.Size = New System.Drawing.Size(219, 37)
        Me.txtParte.TabIndex = 0
        Me.txtParte.Text = """01FGD"""
        Me.txtParte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDescripcion.Location = New System.Drawing.Point(33, 220)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcion.MaximumSize = New System.Drawing.Size(1500, 1538)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(642, 243)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnGuardar.Location = New System.Drawing.Point(994, 505)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(198, 40)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(464, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 37)
        Me.Label2.TabIndex = 283
        Me.Label2.Text = "P.VENTA"
        '
        'txtVenta
        '
        Me.txtVenta.AccessibleDescription = ""
        Me.txtVenta.AccessibleName = ""
        Me.txtVenta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtVenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtVenta.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtVenta.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtVenta.Location = New System.Drawing.Point(590, 98)
        Me.txtVenta.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtVenta.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtVenta.Name = "txtVenta"
        Me.txtVenta.Size = New System.Drawing.Size(219, 37)
        Me.txtVenta.TabIndex = 1
        Me.txtVenta.Tag = ""
        Me.txtVenta.Text = "0"
        Me.txtVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(818, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 37)
        Me.Label3.TabIndex = 285
        Me.Label3.Text = "P.COMPRA"
        '
        'txtCompra
        '
        Me.txtCompra.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCompra.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtCompra.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtCompra.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtCompra.Location = New System.Drawing.Point(974, 98)
        Me.txtCompra.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtCompra.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtCompra.Name = "txtCompra"
        Me.txtCompra.Size = New System.Drawing.Size(219, 37)
        Me.txtCompra.TabIndex = 2
        Me.txtCompra.Tag = ""
        Me.txtCompra.Text = "0"
        Me.txtCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(30, 178)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 37)
        Me.Label4.TabIndex = 286
        Me.Label4.Text = "DESCRIPCION"
        '
        'comboUnidad
        '
        Me.comboUnidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.comboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboUnidad.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.comboUnidad.FormattingEnabled = True
        Me.comboUnidad.Location = New System.Drawing.Point(848, 228)
        Me.comboUnidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboUnidad.Name = "comboUnidad"
        Me.comboUnidad.Size = New System.Drawing.Size(290, 41)
        Me.comboUnidad.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(684, 226)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 37)
        Me.Label5.TabIndex = 288
        Me.Label5.Text = "UNIDAD"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(684, 320)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 37)
        Me.Label6.TabIndex = 290
        Me.Label6.Text = "MARCA"
        '
        'comboMarca
        '
        Me.comboMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.comboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMarca.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.comboMarca.FormattingEnabled = True
        Me.comboMarca.Location = New System.Drawing.Point(848, 320)
        Me.comboMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboMarca.Name = "comboMarca"
        Me.comboMarca.Size = New System.Drawing.Size(290, 41)
        Me.comboMarca.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(684, 412)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(163, 37)
        Me.Label7.TabIndex = 292
        Me.Label7.Text = "CATEGORÍA"
        '
        'comboCategoria
        '
        Me.comboCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboCategoria.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.comboCategoria.FormattingEnabled = True
        Me.comboCategoria.Location = New System.Drawing.Point(848, 411)
        Me.comboCategoria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.comboCategoria.Name = "comboCategoria"
        Me.comboCategoria.Size = New System.Drawing.Size(290, 41)
        Me.comboCategoria.TabIndex = 6
        '
        'btnUnidades
        '
        Me.btnUnidades.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUnidades.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUnidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUnidades.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnUnidades.FlatAppearance.BorderSize = 0
        Me.btnUnidades.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUnidades.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnUnidades.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUnidades.Location = New System.Drawing.Point(1149, 226)
        Me.btnUnidades.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnUnidades.Name = "btnUnidades"
        Me.btnUnidades.Size = New System.Drawing.Size(44, 45)
        Me.btnUnidades.TabIndex = 8
        Me.btnUnidades.Text = "..."
        Me.btnUnidades.UseVisualStyleBackColor = False
        '
        'btnMarca
        '
        Me.btnMarca.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMarca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMarca.FlatAppearance.BorderSize = 0
        Me.btnMarca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarca.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnMarca.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnMarca.Location = New System.Drawing.Point(1149, 320)
        Me.btnMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnMarca.Name = "btnMarca"
        Me.btnMarca.Size = New System.Drawing.Size(44, 45)
        Me.btnMarca.TabIndex = 9
        Me.btnMarca.Text = "..."
        Me.btnMarca.UseVisualStyleBackColor = False
        '
        'btnCategoria
        '
        Me.btnCategoria.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCategoria.FlatAppearance.BorderSize = 0
        Me.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCategoria.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCategoria.Location = New System.Drawing.Point(1149, 411)
        Me.btnCategoria.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(44, 45)
        Me.btnCategoria.TabIndex = 10
        Me.btnCategoria.Text = "..."
        Me.btnCategoria.UseVisualStyleBackColor = False
        '
        'checkOnine
        '
        Me.checkOnine.AutoSize = True
        Me.checkOnine.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.checkOnine.Location = New System.Drawing.Point(33, 505)
        Me.checkOnine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.checkOnine.Name = "checkOnine"
        Me.checkOnine.Size = New System.Drawing.Size(376, 41)
        Me.checkOnine.TabIndex = 11
        Me.checkOnine.Text = "MOSTRAR PRECIO ONLINE"
        Me.checkOnine.UseVisualStyleBackColor = True
        '
        'EditarProductos
        '
        Me.AccessibleDescription = "0"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1222, 563)
        Me.Controls.Add(Me.checkOnine)
        Me.Controls.Add(Me.btnCategoria)
        Me.Controls.Add(Me.btnMarca)
        Me.Controls.Add(Me.btnUnidades)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.comboCategoria)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.comboMarca)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.comboUnidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCompra)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtVenta)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtParte)
        Me.Controls.Add(Me.panelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "EditProductos"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtParte As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVenta As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCompra As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents comboUnidad As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents comboMarca As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents comboCategoria As ComboBox
    Friend WithEvents btnUnidades As Button
    Friend WithEvents btnMarca As Button
    Friend WithEvents btnCategoria As Button
    Friend WithEvents checkOnine As CheckBox
End Class
