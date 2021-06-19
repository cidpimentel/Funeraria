Public Class ListadoContratos
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
            .Columns(1).HeaderText = "Folio Venta"
            .Columns(2).HeaderText = "Cliente"
            .Columns(3).HeaderText = "Finado"
            .Columns(4).HeaderText = "Lugar velacion"
            .Columns(5).HeaderText = "Destino"
            .Columns(6).HeaderText = "Tel.Celular"
            .Columns(7).HeaderText = "Tel.Fijo"


            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1
            .Columns(6).ContextMenuStrip = ContextMenuStrip1
            .Columns(7).ContextMenuStrip = ContextMenuStrip1
            '.Columns(8).ContextMenuStrip = ContextMenuStrip1


            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).Name = "Clave"

            '.Columns(0).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim emp As New DAOContratos
        Dim resultado As List(Of Contratos) = emp.ListarContratos
        Dim i As Integer = 0


        With ListProductos
            .Rows.Clear()
            For Each row As Contratos In resultado


                .Rows.Add(1)


                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Cotizacion
                .Item(2, i).Value = row.NombreCliente
                .Item(3, i).Value = row.Nombre_finado
                .Item(4, i).Value = row.Domicilio_velacion
                .Item(5, i).Value = row.Destino
                .Item(6, i).Value = row.Celular
                .Item(7, i).Value = row.Tel_fijo


                i += 1
            Next
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            EditarContrato.recibview = Me
            EditarContrato.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListadoContratos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub
    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnVer.Click
        Try
            Dim id As Integer
            With ListProductos
                id = .Item(0, .CurrentRow.Index).Value
            End With
            EditarContrato.id_venta = id

            EditarContrato.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim mov As New DAOContratos
        Dim docs As New DAOContDocs
        With ListProductos
            mov.Id = .Item(0, .CurrentRow.Index).Value

            docs.Id = mov.Id

            docs.Contrato = mov.Id
            Dim lisdoc As List(Of ContratoDocs) = docs.buscarDocs()


            For Each doc As ContratoDocs In lisdoc
                docs.Id = doc.Id
                ServicioFTP.Eliminar(doc.Url)
                docs.Eliminar()
            Next

            mov.Eliminar()
            .Rows.Remove(.CurrentRow)

            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            LlenarGrid()
        End With
    End Sub
End Class