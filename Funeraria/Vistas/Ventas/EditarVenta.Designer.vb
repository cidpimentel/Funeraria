<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditarVenta
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
        Me.panelTitleBar = New System.Windows.Forms.Panel()
        Me.btnExit = New FontAwesome.Sharp.IconButton()
        Me.lblFormTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboPaquete = New System.Windows.Forms.ComboBox()
        Me.ComboCliente = New System.Windows.Forms.ComboBox()
        Me.ListProductos = New System.Windows.Forms.DataGridView()
        Me.checkIva = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubtotal = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIva = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTotDesc = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotEntidades = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnPaquete = New System.Windows.Forms.Button()
        Me.panelTitleBar.SuspendLayout()
        CType(Me.ListProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.panelTitleBar.Size = New System.Drawing.Size(1209, 57)
        Me.panelTitleBar.TabIndex = 66
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
        Me.btnExit.Location = New System.Drawing.Point(1160, 11)
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
        Me.lblFormTitle.Size = New System.Drawing.Size(74, 26)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Venta"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(39, 146)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 37)
        Me.Label1.TabIndex = 308
        Me.Label1.Text = "Paquete"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(39, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 37)
        Me.Label2.TabIndex = 310
        Me.Label2.Text = "Cliente"
        '
        'ComboPaquete
        '
        Me.ComboPaquete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboPaquete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboPaquete.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.ComboPaquete.FormattingEnabled = True
        Me.ComboPaquete.Location = New System.Drawing.Point(164, 145)
        Me.ComboPaquete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboPaquete.Name = "ComboPaquete"
        Me.ComboPaquete.Size = New System.Drawing.Size(942, 41)
        Me.ComboPaquete.TabIndex = 311
        '
        'ComboCliente
        '
        Me.ComboCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ComboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboCliente.Font = New System.Drawing.Font("Franklin Gothic Medium", 13.0!)
        Me.ComboCliente.FormattingEnabled = True
        Me.ComboCliente.Location = New System.Drawing.Point(164, 85)
        Me.ComboCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboCliente.Name = "ComboCliente"
        Me.ComboCliente.Size = New System.Drawing.Size(942, 41)
        Me.ComboCliente.TabIndex = 312
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
        Me.ListProductos.Location = New System.Drawing.Point(42, 222)
        Me.ListProductos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListProductos.Name = "ListProductos"
        Me.ListProductos.ReadOnly = True
        Me.ListProductos.RowHeadersVisible = False
        Me.ListProductos.RowHeadersWidth = 62
        Me.ListProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListProductos.Size = New System.Drawing.Size(1116, 483)
        Me.ListProductos.TabIndex = 313
        '
        'checkIva
        '
        Me.checkIva.AutoSize = True
        Me.checkIva.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.checkIva.Location = New System.Drawing.Point(472, 915)
        Me.checkIva.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.checkIva.Name = "checkIva"
        Me.checkIva.Size = New System.Drawing.Size(259, 41)
        Me.checkIva.TabIndex = 314
        Me.checkIva.Text = "Requiere Factura"
        Me.checkIva.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(738, 729)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 37)
        Me.Label3.TabIndex = 316
        Me.Label3.Text = "SUB.TOTAL"
        '
        'txtSubtotal
        '
        Me.txtSubtotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSubtotal.BackColor = System.Drawing.Color.White
        Me.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSubtotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtSubtotal.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtSubtotal.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtSubtotal.Location = New System.Drawing.Point(904, 728)
        Me.txtSubtotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubtotal.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtSubtotal.Name = "txtSubtotal"
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Size = New System.Drawing.Size(254, 37)
        Me.txtSubtotal.TabIndex = 315
        Me.txtSubtotal.Text = "0"
        Me.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(738, 874)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 37)
        Me.Label4.TabIndex = 318
        Me.Label4.Text = "IVA"
        '
        'txtIva
        '
        Me.txtIva.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtIva.BackColor = System.Drawing.Color.White
        Me.txtIva.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtIva.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtIva.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtIva.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtIva.Location = New System.Drawing.Point(904, 871)
        Me.txtIva.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtIva.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.ReadOnly = True
        Me.txtIva.Size = New System.Drawing.Size(254, 37)
        Me.txtIva.TabIndex = 317
        Me.txtIva.Text = "0"
        Me.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(738, 922)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 37)
        Me.Label5.TabIndex = 320
        Me.Label5.Text = "TOTAL"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotal.BackColor = System.Drawing.Color.White
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtTotal.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTotal.Location = New System.Drawing.Point(904, 918)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(254, 37)
        Me.txtTotal.TabIndex = 319
        Me.txtTotal.Text = "0"
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(738, 777)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 37)
        Me.Label6.TabIndex = 322
        Me.Label6.Text = "DESC"
        '
        'txtDesc
        '
        Me.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDesc.BackColor = System.Drawing.Color.White
        Me.txtDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtDesc.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtDesc.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtDesc.Location = New System.Drawing.Point(904, 775)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDesc.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(254, 37)
        Me.txtDesc.TabIndex = 321
        Me.txtDesc.Text = "0"
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label7.Location = New System.Drawing.Point(738, 825)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 37)
        Me.Label7.TabIndex = 324
        Me.Label7.Text = "TOT.DESC"
        '
        'txtTotDesc
        '
        Me.txtTotDesc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotDesc.BackColor = System.Drawing.Color.White
        Me.txtTotDesc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotDesc.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtTotDesc.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtTotDesc.ForeColor = System.Drawing.SystemColors.InfoText
        Me.txtTotDesc.Location = New System.Drawing.Point(904, 823)
        Me.txtTotDesc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotDesc.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtTotDesc.Name = "txtTotDesc"
        Me.txtTotDesc.ReadOnly = True
        Me.txtTotDesc.Size = New System.Drawing.Size(254, 37)
        Me.txtTotDesc.TabIndex = 323
        Me.txtTotDesc.Text = "0"
        Me.txtTotDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(147, 36)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(146, 32)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'lblTotEntidades
        '
        Me.lblTotEntidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotEntidades.AutoSize = True
        Me.lblTotEntidades.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.lblTotEntidades.Location = New System.Drawing.Point(40, 717)
        Me.lblTotEntidades.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotEntidades.Name = "lblTotEntidades"
        Me.lblTotEntidades.Size = New System.Drawing.Size(336, 37)
        Me.lblTotEntidades.TabIndex = 326
        Me.lblTotEntidades.Text = "Productos y/o servicios: 0"
        Me.lblTotEntidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAgregar.Location = New System.Drawing.Point(44, 915)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(198, 40)
        Me.btnAgregar.TabIndex = 328
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
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
        Me.btnGuardar.Location = New System.Drawing.Point(250, 917)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(198, 40)
        Me.btnGuardar.TabIndex = 327
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnCliente
        '
        Me.btnCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnCliente.FlatAppearance.BorderSize = 0
        Me.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCliente.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCliente.Location = New System.Drawing.Point(1116, 85)
        Me.btnCliente.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(45, 40)
        Me.btnCliente.TabIndex = 329
        Me.btnCliente.Text = "..."
        Me.btnCliente.UseVisualStyleBackColor = False
        '
        'btnPaquete
        '
        Me.btnPaquete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnPaquete.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPaquete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPaquete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnPaquete.FlatAppearance.BorderSize = 0
        Me.btnPaquete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnPaquete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPaquete.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPaquete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnPaquete.Location = New System.Drawing.Point(1116, 148)
        Me.btnPaquete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPaquete.Name = "btnPaquete"
        Me.btnPaquete.Size = New System.Drawing.Size(45, 40)
        Me.btnPaquete.TabIndex = 330
        Me.btnPaquete.Text = "..."
        Me.btnPaquete.UseVisualStyleBackColor = False
        '
        'EditarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1209, 977)
        Me.Controls.Add(Me.btnPaquete)
        Me.Controls.Add(Me.btnCliente)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblTotEntidades)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTotDesc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIva)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSubtotal)
        Me.Controls.Add(Me.checkIva)
        Me.Controls.Add(Me.ListProductos)
        Me.Controls.Add(Me.ComboCliente)
        Me.Controls.Add(Me.ComboPaquete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.panelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "EditarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditarVenta"
        Me.panelTitleBar.ResumeLayout(False)
        Me.panelTitleBar.PerformLayout()
        CType(Me.ListProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents panelTitleBar As Panel
    Friend WithEvents btnExit As FontAwesome.Sharp.IconButton
    Friend WithEvents lblFormTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboPaquete As ComboBox
    Friend WithEvents ComboCliente As ComboBox
    Friend WithEvents ListProductos As DataGridView
    Friend WithEvents checkIva As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtIva As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTotDesc As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTotEntidades As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCliente As Button
    Friend WithEvents btnPaquete As Button
End Class
