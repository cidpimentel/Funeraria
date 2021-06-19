Public Class Productossssdd
    Implements MetdosGrid

    Public Sub CrearGrid() Implements MetdosGrid.CrearGrid
        With ListProductos
            .Rows.Clear()
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = SetColors.RGBColors.dorado
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            .ColumnCount = 9

            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Clave"
            .Columns(2).HeaderText = "Descripcion"
            .Columns(3).HeaderText = "Categoria"
            .Columns(4).HeaderText = "Marca"
            .Columns(5).HeaderText = "Unidad"
            .Columns(6).HeaderText = "Stock"
            .Columns(7).HeaderText = "Precio.Compra"
            .Columns(8).HeaderText = "Precio.Venta"

            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1
            .Columns(6).ContextMenuStrip = ContextMenuStrip1
            .Columns(7).ContextMenuStrip = ContextMenuStrip1
            .Columns(8).ContextMenuStrip = ContextMenuStrip1

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).Name = "Clave"

            .Columns(0).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim emp As New DAOProducto
        emp.Status = 1
        Dim resultado As List(Of Product) = emp.Listar
        Dim i As Integer = 0


        With ListProductos
            .Rows.Clear()
            For Each row As Product In resultado



                .Rows.Add(1)


                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Parte
                .Item(2, i).Value = row.Descripcion
                .Item(3, i).Value = row.CategoriaN
                .Item(4, i).Value = row.MarcaN
                .Item(5, i).Value = row.UnidadN
                .Item(6, i).Value = row.Stock1
                .Item(7, i).Value = SoloNumeros.formatoMoneda(row.Compra)
                .Item(8, i).Value = SoloNumeros.formatoMoneda(row.Venta)

                i += 1
            Next
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
        End With
    End Sub

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim pro As New DAOProducto
            With ListProductos
                pro.Id = .Item(0, .CurrentRow.Index).Value
            End With
            EditarProductos.pro = pro
            EditarProductos.recibview = Me
            EditarProductos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In ListProductos.Rows
            'Si el contenido de la columna coinside con el valor del TextBox
            Dim cell As DataGridViewCell = row.Cells("Clave")

            If IsNumeric(txtBuscar.Text) Then
                If CStr(row.Cells(1).Value).ToLower = txtBuscar.Text.ToLower Then
                    'Selecciono fila y abandono bucle
                    row.Selected = True
                    ListProductos.FirstDisplayedCell = ListProductos.Item(1, row.Index)
                    ListProductos.CurrentCell = cell
                    Exit For

                Else
                    row.Selected = False
                End If
            Else
                Dim cadena As String = txtBuscar.Text.ToLower
                Dim i As Integer = InStr(CStr(row.Cells(2).Value).ToLower, cadena)

                If i > 0 Then
                    row.Selected = True
                    ListProductos.FirstDisplayedCell = ListProductos.Item(1, row.Index)
                    ListProductos.CurrentCell = cell
                    Exit For
                Else
                    row.Selected = False
                End If
            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim pro As New DAOProducto
            pro.Id = 0
            EditarProductos.pro = pro
            EditarProductos.recibview = Me
            EditarProductos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim mov As New DAOProducto
        With ListProductos
            mov.Id = .Item(0, .CurrentRow.Index).Value
            mov.Status = 0
            mov.Eliminar()
            .Rows.Remove(.CurrentRow)
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            LlenarGrid()
        End With
    End Sub
End Class