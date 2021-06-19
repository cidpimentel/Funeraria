<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListClientes
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.lblTotEntidades = New System.Windows.Forms.Label()
        Me.ListUsuarios = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ListUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(670, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(117, 26)
        Me.Button2.TabIndex = 290
        Me.Button2.Text = "&Buscar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(315, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 18)
        Me.Label8.TabIndex = 289
        Me.Label8.Text = "Nombre o clave"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txtBuscar.Location = New System.Drawing.Point(436, 15)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(228, 23)
        Me.txtBuscar.TabIndex = 288
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(518, 411)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 26)
        Me.Button1.TabIndex = 287
        Me.Button1.Text = "&Agregar"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.btnIngresar.Location = New System.Drawing.Point(656, 411)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(132, 26)
        Me.btnIngresar.TabIndex = 286
        Me.btnIngresar.Text = "&Ver detalle"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'lblTotEntidades
        '
        Me.lblTotEntidades.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotEntidades.AutoSize = True
        Me.lblTotEntidades.Font = New System.Drawing.Font("Franklin Gothic Medium", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTotEntidades.Location = New System.Drawing.Point(12, 415)
        Me.lblTotEntidades.Name = "lblTotEntidades"
        Me.lblTotEntidades.Size = New System.Drawing.Size(87, 18)
        Me.lblTotEntidades.TabIndex = 285
        Me.lblTotEntidades.Text = "LISTADOS 0"
        Me.lblTotEntidades.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.ListUsuarios.Location = New System.Drawing.Point(14, 49)
        Me.ListUsuarios.Name = "ListUsuarios"
        Me.ListUsuarios.ReadOnly = True
        Me.ListUsuarios.RowHeadersVisible = False
        Me.ListUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ListUsuarios.Size = New System.Drawing.Size(773, 351)
        Me.ListUsuarios.TabIndex = 284
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ListClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.lblTotEntidades)
        Me.Controls.Add(Me.ListUsuarios)
        Me.Name = "ListClientes"
        Me.Text = "ListarClientes"
        CType(Me.ListUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lblTotEntidades As Label
    Friend WithEvents ListUsuarios As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
End Class
