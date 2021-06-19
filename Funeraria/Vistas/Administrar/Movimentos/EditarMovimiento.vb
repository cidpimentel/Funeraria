Imports System.Runtime.InteropServices

Public Class EditarMovimiento
    Implements MetdosGrid

    Friend Shared pro As DAOMovimientoAlmacen
    Friend Shared recibview As ListadoMovimientos

    Public Sub CrearGrid() Implements MetdosGrid.CrearGrid
        With ListProductos
            .Rows.Clear()
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = Color.Black
            .DefaultCellStyle.SelectionForeColor = Color.White
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            .ColumnCount = 10



            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Clave"
            .Columns(2).HeaderText = "Descripcion"
            .Columns(3).HeaderText = "idMarca"
            .Columns(4).HeaderText = "Marca"
            .Columns(5).HeaderText = "idUnidad"
            .Columns(6).HeaderText = "Unidad"
            .Columns(7).HeaderText = "Cantidad"
            .Columns(8).HeaderText = "Costo"
            .Columns(9).HeaderText = "id"

            .Columns(0).ContextMenuStrip = ContextMenuStrip1
            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1
            .Columns(6).ContextMenuStrip = ContextMenuStrip1
            .Columns(7).ContextMenuStrip = ContextMenuStrip1
            .Columns(8).ContextMenuStrip = ContextMenuStrip1


            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(3).Visible = False
            .Columns(5).Visible = False
            .Columns(9).Visible = False

            .Columns(0).ReadOnly = True
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
            .Columns(3).ReadOnly = True
            .Columns(4).ReadOnly = True
            .Columns(5).ReadOnly = True
            .Columns(6).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Throw New NotImplementedException()
    End Sub



    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Public Sub LlenarComboAlmacen()
        Dim alm As New DAOAlmacen
        Dim List As List(Of Almacen) = alm.ListarAlmacen

        With ComboAlmacen
            '.Items.Clear()
            .DataSource = List
            .DisplayMember = "Almacen"
            .ValueMember = "Id"
            ' .SelectedIndex = -1
        End With
    End Sub

    Private Sub EditarMovimiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboAlmacen()
        CrearGrid()
        If pro.Id <> 0 Then
            CargarInformacion()
        End If
    End Sub

    Private Sub btnAlmacen_Click(sender As Object, e As EventArgs) Handles btnAlmacen.Click
        Try
            AltaAlmacen.recibview = Me
            AltaAlmacen.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            ArticulosEntradaSalida.recibview = Me
            ArticulosEntradaSalida.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub ListNomEmpResDeduc_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles ListProductos.CellEndEdit
        Dim col As Integer = e.ColumnIndex
        If col = 7 Then
            If SoloNumeros.strNumeros(ListProductos.CurrentCell.Value.ToString) = False Then
                MsgBox("Ingrese un valor mayor a 0", vbCritical, "Error")
                ListProductos.CurrentCell.Value = 1

            End If
        End If
        If col = 8 Then
            If SoloNumeros.strNumeros(ListProductos.CurrentCell.Value.ToString) = False Then
                MsgBox("Ingrese un valor mayor a 0", vbCritical, "Error")
                ListProductos.CurrentCell.Value = 0
            Else
                ListProductos.CurrentCell.Value = SoloNumeros.formatoMoneda(ListProductos.CurrentCell.Value)
            End If
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        'Dim user As New DAOUsuario
        With ListProductos
            'user.IdUsuario = .Item(5, .CurrentRow.Index).Value
            'user.Eliminar()
            .Rows.Remove(.CurrentRow)
            'ListProductos.Text = "Listados " & ListProductos.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
        End With
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim mv As New DAOMovimientoAlmacen

        Try

            mv.Id = mv.getCount
            mv.Descripcion = txtDescripcion.Text
            mv.Movimiento = recibview.comboTipoMov.SelectedValue
            mv.Empleado = ActiveUser.idUser
            mv.Almacen = ComboAlmacen.SelectedValue
            mv.Fecha = ConversionHorasFecha.fechaDB(Today)
            mv.Guardar()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            For Each fila As DataGridViewRow In ListProductos.Rows
                Dim mvd As New DAOMvoAlmDet
                mvd.Movimiento = mv.Id
                mvd.Producto = fila.Cells(9).Value
                mvd.Cantidad = SoloNumeros.formatoNumero(fila.Cells(7).Value)
                mvd.Costo_uni = SoloNumeros.formatoNumero(fila.Cells(8).Value)
                mvd.Total = mvd.Cantidad * mvd.Costo_uni
                mvd.Guardar()
            Next

            MsgBox("Se ha completado la operacion", vbInformation, "Resultado")
            recibview.LlenarGrid()
            Me.Close()
            Me.Dispose()
        End Try
    End Sub

    Private Sub CargarInformacion()
        Dim lista As List(Of MovimientoAlmacen) = pro.consultar
        Dim mvd As New DAOMvoAlmDet
        mvd.Movimiento = pro.Id
        Dim detalle As List(Of MovAlmDet) = mvd.consultar
        For Each fila As MovimientoAlmacen In lista
            txtEmpleado.Text = fila.Nom_empleado
            ComboAlmacen.Text = fila.Nom_almacen
            txtDescripcion.Text = fila.Descripcion
        Next
        Dim i As Integer = 0
        Dim a As Integer = 1
        'MsgBox(detalle.Count)
        With ListProductos
            .Rows.Clear()
            For Each det As MovAlmDet In detalle
                .Rows.Add(1)

                '.Columns(0).HeaderText = "#"
                '.Columns(1).HeaderText = "Clave"
                '.Columns(2).HeaderText = "Descripcion"
                '.Columns(3).HeaderText = "idMarca"
                '.Columns(4).HeaderText = "Marca"
                '.Columns(5).HeaderText = "idUnidad"
                '.Columns(6).HeaderText = "Unidad"
                '.Columns(7).HeaderText = "Cantidad"
                '.Columns(8).HeaderText = "Costo"
                '.Columns(9).HeaderText = "id"

                .Item(0, i).Value = a
                .Item(1, i).Value = det.Parte
                .Item(2, i).Value = det.Descripcion
                .Item(3, i).Value = det.Marca
                .Item(4, i).Value = det.MarcaN
                .Item(5, i).Value = det.Unidad
                .Item(6, i).Value = det.UnidadN
                .Item(7, i).Value = det.Cantidad
                .Item(8, i).Value = det.Venta
                .Item(9, i).Value = det.Id

                .Columns(7).ReadOnly = True
                .Columns(8).ReadOnly = True

                i += 1
                a += 1
            Next
            btnAgregar.Enabled = False
            btnGuardar.Enabled = False
            txtDescripcion.ReadOnly = True
        End With


    End Sub

End Class