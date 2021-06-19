Imports System.Runtime.InteropServices

Public Class editarPaquetes
    Implements MetdosGrid

    Friend Shared recibview As ListadoPaquetes
    Friend Shared paq As DAOPaquete

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

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
            .Columns(8).ReadOnly = True

        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Throw New NotImplementedException()
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub editarPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        If paq.Id <> 0 Then
            CargarInformacion()
        End If
    End Sub

    Private Sub CargarInformacion()
        Dim lista As List(Of Paquete) = paq.consultar
        Dim pdet As New DAOPaqueteDetalle
        pdet.Id = paq.Id
        Dim detalle As List(Of PaqueteDetalle) = pdet.ListarPaqueteDetalle
        For Each fila As Paquete In lista
            txtPaquete.Text = fila.Paquete
            txtTotal.Text = SoloNumeros.formatoMoneda(fila.Costo)

        Next
        Dim i As Integer = 0
        Dim a As Integer = 1
        'MsgBox(detalle.Count)
        With ListProductos
            .Rows.Clear()
            For Each det As PaqueteDetalle In detalle
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
                .Item(3, i).Value = det.IdMarca
                .Item(4, i).Value = det.Marca
                .Item(5, i).Value = det.IdUni
                .Item(6, i).Value = det.Unidad
                .Item(7, i).Value = det.Cantidad
                .Item(8, i).Value = SoloNumeros.formatoMoneda(det.Precio_venta)
                .Item(9, i).Value = det.IdDetalle

                .Columns(7).ReadOnly = True
                .Columns(8).ReadOnly = True

                i += 1
                a += 1
            Next
            'btnAgregar.Enabled = False
            'btnGuardar.Enabled = False
            txtPaquete.ReadOnly = True
        End With


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarProductoPaquete.recibview = Me
        AgregarProductoPaquete.ShowDialog()
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

        sumarCantidades()
    End Sub

    Public Sub sumarCantidades()
        Dim total As Double
        For Each fila As DataGridViewRow In ListProductos.Rows

            total = total + (fila.Cells(7).Value * SoloNumeros.formatoNumero(fila.Cells(8).Value))
        Next
        txtTotal.Text = SoloNumeros.formatoMoneda(total)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Try
            If paq.Id = 0 Then
                paq.Id = paq.getCount
                paq.Paquete = txtPaquete.Text
                paq.Costo = SoloNumeros.formatoNumero(txtTotal.Text)
                paq.Guardar()
            Else
                paq.Paquete = txtPaquete.Text
                paq.Costo = SoloNumeros.formatoNumero(txtTotal.Text)
                paq.Actualizar()
                Dim pde As New DAOPaqueteDetalle
                pde.Id = paq.Id
                pde.EliminarTodos()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally

            For Each fila As DataGridViewRow In ListProductos.Rows
                Dim pdet As New DAOPaqueteDetalle
                pdet.IdDetalle = pdet.getCount
                pdet.Id = paq.Id
                pdet.Producto = fila.Cells(9).Value
                pdet.Cantidad = fila.Cells(7).Value
                pdet.Costo1 = SoloNumeros.formatoNumero(fila.Cells(8).Value)
                pdet.Guardar()
            Next
            MsgBox("Se ha completado la operacion", vbInformation, "Resultado")
            recibview.LlenarGrid()
            Me.Close()
            Me.Dispose()
        End Try
    End Sub

    Private Sub ListProductos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles ListProductos.RowsAdded
        lblTotEntidades.Text = "Productos y/o servicios " & ListProductos.RowCount
    End Sub

    Private Sub ListProductos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles ListProductos.RowsRemoved
        lblTotEntidades.Text = "Productos y/o servicios " & ListProductos.RowCount
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim mov As New DAOPaqueteDetalle
        With ListProductos
            mov.IdDetalle = .Item(3, .CurrentRow.Index).Value
            mov.Eliminar()
            .Rows.Remove(.CurrentRow)
            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            sumarCantidades()
        End With
    End Sub
End Class