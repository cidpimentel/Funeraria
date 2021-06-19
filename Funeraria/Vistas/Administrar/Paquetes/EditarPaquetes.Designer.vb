<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editarPaquetes
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
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.ListProductos = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPaquete = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblTotEntidades = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.panelTitleBar.TabIndex = 65
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
        Me.lblFormTitle.Size = New System.Drawing.Size(170, 26)
        Me.lblFormTitle.TabIndex = 1
        Me.lblFormTitle.Text = "Editar Paquete"
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
        Me.btnAgregar.Location = New System.Drawing.Point(778, 811)
        Me.btnAgregar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(198, 40)
        Me.btnAgregar.TabIndex = 304
        Me.btnAgregar.Text = "&Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
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
        Me.ListProductos.Location = New System.Drawing.Point(32, 151)
        Me.ListProductos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ListProductos.Name = "ListProductos"
        Me.ListProductos.RowHeadersVisible = False
        Me.ListProductos.RowHeadersWidth = 62
        Me.ListProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListProductos.Size = New System.Drawing.Size(1152, 638)
        Me.ListProductos.TabIndex = 303
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
        Me.btnGuardar.Location = New System.Drawing.Point(986, 811)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(198, 40)
        Me.btnGuardar.TabIndex = 302
        Me.btnGuardar.Text = "&Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(32, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 37)
        Me.Label1.TabIndex = 307
        Me.Label1.Text = "Paquete"
        '
        'txtPaquete
        '
        Me.txtPaquete.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPaquete.BackColor = System.Drawing.SystemColors.Window
        Me.txtPaquete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPaquete.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPaquete.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtPaquete.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtPaquete.Location = New System.Drawing.Point(156, 88)
        Me.txtPaquete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPaquete.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtPaquete.Name = "txtPaquete"
        Me.txtPaquete.Size = New System.Drawing.Size(662, 37)
        Me.txtPaquete.TabIndex = 306
        Me.txtPaquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(826, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 37)
        Me.Label2.TabIndex = 309
        Me.Label2.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtTotal.Font = New System.Drawing.Font("Franklin Gothic Medium", 16.0!)
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtTotal.Location = New System.Drawing.Point(910, 88)
        Me.txtTotal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotal.MaximumSize = New System.Drawing.Size(1500, 1000)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(273, 37)
        Me.txtTotal.TabIndex = 308
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotEntidades
        '
        Me.lblTotEntidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotEntidades.AutoSize = True
        Me.lblTotEntidades.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotEntidades.Location = New System.Drawing.Point(33, 817)
        Me.lblTotEntidades.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotEntidades.Name = "lblTotEntidades"
        Me.lblTotEntidades.Size = New System.Drawing.Size(261, 25)
        Me.lblTotEntidades.TabIndex = 310
        Me.lblTotEntidades.Text = "Productos y/o servicios: 0"
        Me.lblTotEntidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'editarPaquetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1209, 869)
        Me.Controls.Add(Me.lblTotEntidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPaquete)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.ListProductos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.panelTitleBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "editarPaquetes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editarPaquetes"
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
    Friend WithEvents btnAgregar As Button
    Friend WithEvents ListProductos As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPaquete As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblTotEntidades As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
