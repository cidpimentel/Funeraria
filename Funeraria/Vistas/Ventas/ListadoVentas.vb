Public Class ListadoVentas
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
            .ColumnCount = 8

            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Cliente"
            .Columns(2).HeaderText = "Paquete"
            .Columns(3).HeaderText = "Subtotal"
            .Columns(4).HeaderText = "descuento"
            .Columns(5).HeaderText = "Iva"
            .Columns(6).HeaderText = "Total"
            .Columns(7).HeaderText = "Fecha"


            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1
            .Columns(6).ContextMenuStrip = ContextMenuStrip1
            .Columns(7).ContextMenuStrip = ContextMenuStrip1
            '.Columns(8).ContextMenuStrip = ContextMenuStrip1


            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).Name = "Clave"

            '.Columns(0).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim emp As New DAOVenta
        Dim resultado As List(Of Venta) = emp.Listar
        Dim i As Integer = 0


        With ListProductos
            .Rows.Clear()
            For Each row As Venta In resultado


                .Rows.Add(1)


                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Nom_cliente
                .Item(2, i).Value = row.Nom_paquete
                .Item(3, i).Value = SoloNumeros.formatoMoneda(row.Subtotal)
                .Item(4, i).Value = SoloNumeros.formatoMoneda(row.Descuento)
                .Item(5, i).Value = SoloNumeros.formatoMoneda(row.Iva)
                .Item(6, i).Value = SoloNumeros.formatoMoneda(row.Total)
                .Item(7, i).Value = ConversionHorasFecha.fechaDB(row.Fecha)


                i += 1
            Next
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditarVenta.recibview = Me
        EditarVenta.ShowDialog()
    End Sub

    Private Sub ListadoVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim id As Integer
            With ListProductos
                id = .Item(0, .CurrentRow.Index).Value
            End With
            PreviewVenta.id_venta = id
            PreviewVenta.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim mov As New DAOVenta
        Dim vnd As New DAOVentaDetalle
        With ListProductos
            mov.Id = .Item(0, .CurrentRow.Index).Value
            vnd.Id = mov.Id
            vnd.Eliminar()
            mov.Eliminar()
            .Rows.Remove(.CurrentRow)
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            LlenarGrid()
        End With
    End Sub
End Class