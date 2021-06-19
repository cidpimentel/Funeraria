Public Class ListadoPaquetes
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
            .ColumnCount = 4

            .Columns(0).HeaderText = "id"

            .Columns(1).HeaderText = "#"

            .Columns(2).HeaderText = "Paquete"
            .Columns(3).HeaderText = "Precio del paquete"


            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1


            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill


            .Columns(0).Visible = False
        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim paq As New DAOPaquete

        Dim resultado As List(Of Paquete) = paq.ListarPaquetes
        Dim i As Integer = 0
        Dim a As Integer = 1

        With ListProductos
            .Rows.Clear()
            For Each row As Paquete In resultado

                'MsgBox(row.Id & "-" & row.Paquete & "-" & row.Costo)

                .Rows.Add(1)

                .Item(0, i).Value = row.Id
                .Item(1, i).Value = a
                .Item(2, i).Value = row.Paquete
                .Item(3, i).Value = SoloNumeros.formatoMoneda(row.Costo)

                i += 1
                a += 1
            Next
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
        End With
    End Sub

    Private Sub ListadoPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim paq As New DAOPaquete
            paq.Id = 0
            editarPaquetes.paq = paq
            editarPaquetes.recibview = Me
            editarPaquetes.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim paq As New DAOPaquete
            With ListProductos
                paq.Id = .Item(0, .CurrentRow.Index).Value
            End With
            editarPaquetes.paq = paq
            editarPaquetes.recibview = Me
            editarPaquetes.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim mov As New DAOPaquete
        With ListProductos
            mov.Id = .Item(0, .CurrentRow.Index).Value
            mov.Eliminar()
            .Rows.Remove(.CurrentRow)
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            LlenarGrid()
        End With
    End Sub
End Class