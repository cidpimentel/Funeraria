Public Class ListadoMovimientos
    Implements MetdosGrid

    Public Sub CrearGrid() Implements MetdosGrid.CrearGrid
        With ListMovimientos
            .Rows.Clear()
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = SetColors.RGBColors.dorado
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            .ColumnCount = 7

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Descripcion"
            .Columns(3).HeaderText = "Movimiento"
            .Columns(4).HeaderText = "Empleado"
            .Columns(5).HeaderText = "Almacen"
            .Columns(6).HeaderText = "Fecha"

            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1
            .Columns(6).ContextMenuStrip = ContextMenuStrip1

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(3).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns(5).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(0).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim emp As New DAOMovimientoAlmacen
        emp.Movimiento = comboTipoMov.SelectedValue
        Dim resultado As List(Of MovimientoAlmacen) = emp.ListarMovimientos
        Dim i As Integer = 0
        Dim a As Integer = 1

        With ListMovimientos
            .Rows.Clear()
            For Each row As MovimientoAlmacen In resultado



                .Rows.Add(1)


                .Item(0, i).Value = row.Id
                .Item(1, i).Value = a
                .Item(2, i).Value = row.Descripcion
                .Item(3, i).Value = row.Nom_movi
                .Item(4, i).Value = row.Nom_empleado
                .Item(5, i).Value = row._nom_almacen
                .Item(6, i).Value = ConversionHorasFecha.fechaDB(row.Fecha)

                i += 1
                a += 1
            Next
            lblTotEntidades.Text = "Listados " & ListMovimientos.RowCount
        End With
    End Sub

    Public Sub LlenarComboMovimiento()
        Dim cat As New DAOTipoMovimiento
        Dim List As List(Of TipoMovimiento) = cat.ListarTipoMovimiento

        With comboTipoMov
            '.Items.Clear()
            .DataSource = List
            .DisplayMember = "Movimiento"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ListadoMovimientos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboMovimiento()
        CrearGrid()

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If comboTipoMov.SelectedValue IsNot Nothing Then
                Dim pro As New DAOMovimientoAlmacen
                pro.Id = 0
                EditarMovimiento.pro = pro
                EditarMovimiento.recibview = Me
                EditarMovimiento.lblFormTitle.Text = comboTipoMov.Text
                EditarMovimiento.txtEmpleado.Text = ActiveUser.userName
                EditarMovimiento.ShowDialog()
            Else
                MsgBox("seleccione un tipo de movimiento", vbCritical, "Error")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If comboTipoMov.SelectedValue IsNot Nothing Then
                If ListMovimientos.RowCount > 0 Then
                    Dim pro As New DAOMovimientoAlmacen
                    With ListMovimientos
                        pro.Id = .Item(0, .CurrentRow.Index).Value
                    End With
                    EditarMovimiento.pro = pro
                    EditarMovimiento.recibview = Me
                    EditarMovimiento.lblFormTitle.Text = comboTipoMov.Text
                    EditarMovimiento.ShowDialog()

                End If

            Else
                MsgBox("seleccione un tipo de movimiento", vbCritical, "Error")
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub comboTipoMov_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboTipoMov.SelectedIndexChanged
        Try
            If comboTipoMov.SelectedValue IsNot Nothing Then
                LlenarGrid()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim mov As New DAOMovimientoAlmacen
        Dim mvd As New DAOMvoAlmDet
        With ListMovimientos
            mov.Id = .Item(0, .CurrentRow.Index).Value
            mvd.Movimiento = mov.Id
            mvd.Eliminar()
            mov.Eliminar()
            .Rows.Remove(.CurrentRow)
            lblTotEntidades.Text = "Listados " & ListMovimientos.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            LlenarGrid()
        End With
    End Sub
End Class