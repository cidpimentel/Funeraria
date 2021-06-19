Imports System.Runtime.InteropServices

Public Class EditarVenta
    Implements MetdosGrid

    Friend Shared recibview As ListadoVentas



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

    Private Sub EditarVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboCliente()
        LlenarComboPaquete()
        CrearGrid()
        checkIva.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        BuscarCliente.recibview = Me
        BuscarCliente.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPaquete.Click
        BuscarPaquete.recibview = Me
        BuscarPaquete.ShowDialog()
    End Sub

    Public Sub LlenarComboCliente()
        Dim cat As New DAOUsuario
        cat.Tipo = 1
        Dim ListCat As List(Of Usuario) = cat.Listar

        With ComboCliente
            '.Items.Clear()
            .DataSource = ListCat
            .DisplayMember = "Nombre"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub LlenarComboPaquete()
        Dim cat As New DAOPaquete
        Dim ListCat As List(Of Paquete) = cat.ListarPaquetes

        With ComboPaquete
            '.Items.Clear()
            .DataSource = ListCat
            .DisplayMember = "Paquete"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarProductoPaquete.recibview2 = Me
        AgregarProductoPaquete.ShowDialog()
    End Sub

    Private Sub ComboPaquete_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboPaquete.SelectedIndexChanged
        Try
            If ComboPaquete.SelectedValue IsNot Nothing Then
                LlenarGrid()
            End If
        Catch ex As Exception

        End Try
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
            .ColumnCount = 12



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
            .Columns(10).HeaderText = "eliminar"
            .Columns(11).HeaderText = "categoria"

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
            .Columns(10).Visible = False
            .Columns(11).Visible = False

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

        Dim pdet As New DAOPaqueteDetalle
        pdet.Id = ComboPaquete.SelectedValue
        Dim detalle As List(Of PaqueteDetalle) = pdet.ListarPaqueteDetalle

        Dim total As Double

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
                .Item(10, i).Value = 1
                .Item(11, i).Value = det.Catgeoria

                .Columns(7).ReadOnly = True
                .Columns(8).ReadOnly = True

                i += 1
                a += 1

                total = total + SoloNumeros.formatoNumero(det.Precio_venta)
            Next
            txtSubtotal.Text = SoloNumeros.formatoMoneda(total)
            calculoImporte()
            'btnAgregar.Enabled = False
            'btnGuardar.Enabled = False

        End With


    End Sub

    Public Sub calculoImporte()
        Dim subtotal As Double = 0

        For Each fila As DataGridViewRow In ListProductos.Rows
            subtotal = subtotal + SoloNumeros.formatoNumero(fila.Cells(8).Value)
        Next

        txtSubtotal.Text = SoloNumeros.formatoMoneda(subtotal)

        Dim descuento As Double = SoloNumeros.formatoNumero(txtDesc.Text)
        Dim total_desc As Double = SoloNumeros.formatoNumero(txtTotDesc.Text)
        Dim iva As Double = SoloNumeros.formatoNumero(txtIva.Text)
        Dim total As Double = SoloNumeros.formatoNumero(txtSubtotal.Text)

        total_desc = subtotal - descuento

        txtTotDesc.Text = SoloNumeros.formatoMoneda(total_desc)

        If checkIva.Checked = True Then
            iva = (total_desc * 0.16)
            total = total_desc + iva
            txtIva.Text = SoloNumeros.formatoMoneda(iva)
        Else
            txtIva.Text = 0
        End If




        txtTotal.Text = SoloNumeros.formatoMoneda(total)

        lblTotEntidades.Text = "Productos y/o servicios: " & ListProductos.RowCount
    End Sub

    Private Sub checkIva_CheckedChanged(sender As Object, e As EventArgs) Handles checkIva.CheckedChanged
        calculoImporte()
    End Sub



    Private Sub txtDesc_LostFocus(sender As Object, e As EventArgs) Handles txtDesc.LostFocus
        calculoImporte()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

        With ListProductos
            If ListProductos.Item(10, ListProductos.CurrentRow.Index).Value = 1 And ListProductos.Item(11, ListProductos.CurrentRow.Index).Value <> "ATAUD" And ListProductos.Item(11, ListProductos.CurrentRow.Index).Value <> "URNA" Then
                MsgBox("Este producto es parte del paquete, no esposible quitar", vbCritical, "Error")
            Else
                .Rows.Remove(.CurrentRow)
                MsgBox("Se ha eliminado correctamente", vbInformation, "Resultado")
            End If

            lblTotEntidades.Text = "Listados " & ListProductos.RowCount
            calculoImporte()
        End With
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim ven As New DAOVenta
        Dim Msg, Style, Title, Response, MyString
        Try

            Msg = "¿Desea cerrar la compra?"    ' Define message.
            Style = vbYesNo + vbCritical + vbDefaultButton2    ' Define buttons.
            Title = "Confirmar operacion"    ' Define title.

            ' Display message.
            Response = MsgBox(Msg, Style, Title)
            If Response = vbYes Then
                MyString = "Yes"

                If ComboPaquete.SelectedValue IsNot Nothing And ComboCliente.SelectedValue IsNot Nothing And ListProductos.RowCount > 0 Then
                    ven.Id = ven.getCountVentas()
                    ven.Iva = SoloNumeros.formatoNumero(txtIva.Text)
                    ven.Paquete = ComboPaquete.SelectedValue
                    ven.Cliente = ComboCliente.SelectedValue
                    ven.Subtotal = SoloNumeros.formatoNumero(txtSubtotal.Text)
                    ven.Total = SoloNumeros.formatoNumero(txtTotal.Text)
                    ven.Guardar()
                    For Each fila As DataGridViewRow In ListProductos.Rows
                        Dim vend As New DAOVentaDetalle
                        vend.IdDetalle = vend.getCountDet()
                        vend.Id = ven.Id
                        vend.Paquete = ven.Paquete
                        vend.Producto = fila.Cells(9).Value
                        vend.Cantidad = fila.Cells(7).Value
                        vend.Costo = fila.Cells(8).Value
                        vend.Guardar()
                    Next
                    recibview.LlenarGrid()
                    Me.Close()
                    Me.Dispose()
                    MsgBox("Se completo la operacion con exito", vbInformation, "Resultado")
                Else
                    MsgBox("Complete los campos faltantes", vbCritical, "Error")
                End If

            Else
                MyString = "No"

                MsgBox("Se ha cancelado la operacion", vbInformation, "Error")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")

        End Try
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub
End Class