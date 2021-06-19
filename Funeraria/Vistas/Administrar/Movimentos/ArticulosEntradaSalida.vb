Imports System.Runtime.InteropServices

Public Class ArticulosEntradaSalida
    Implements MetdosGrid

    Friend Shared recibview As EditarMovimiento


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

    Public Sub CrearGrid() Implements MetdosGrid.CrearGrid
        With ListAdicionales
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
            .Columns(3).HeaderText = "idMarca"
            .Columns(4).HeaderText = "Marca"
            .Columns(5).HeaderText = "idUnidad"
            .Columns(6).HeaderText = "Unidad"
            .Columns(7).HeaderText = "venta"
            .Columns(8).HeaderText = "Stock"



            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(0).Visible = False
            .Columns(3).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim cat As New DAOProducto
        cat.Parte = txtValor.Text
        Dim pro As List(Of Product) = cat.BuscarProductoClave
        If pro.Count = 0 Then
            cat.Descripcion = txtValor.Text
            pro = cat.BuscarProductoDescripcion
        End If

        If pro.Count = 0 Then
            MsgBox("No hay resultados para esta busqueda", vbExclamation, "Error")
        End If

        Dim a As Integer = 1
        Dim i As Integer = 0

        With ListAdicionales
            .Rows.Clear()

            '  MsgBox(categorias.Count)
            For Each row As Product In pro

                .Rows.Add(1)


                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Parte
                .Item(2, i).Value = row.Descripcion
                .Item(3, i).Value = row.Marca
                .Item(4, i).Value = row.MarcaN
                .Item(5, i).Value = row.Unidad
                .Item(6, i).Value = row.UnidadN
                .Item(7, i).Value = row.Venta
                .Item(8, i).Value = row.Stock1

                i += 1
                a += 1
            Next

        End With
    End Sub

    Private Sub ArticulosEntradaSalida_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CrearGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            LlenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            With recibview.ListProductos

                Dim exite As Boolean = False
                Dim indRecib As Integer
                For Each fila As DataGridViewRow In recibview.ListProductos.Rows
                    If fila.Cells(1).Value = ListAdicionales.Item(1, ListAdicionales.CurrentRow.Index).Value Then
                        exite = True
                        indRecib = fila.Index
                        Exit For
                    End If
                Next

                If exite = False Then
                    .Rows.Add(1)
                    Dim index As Integer = recibview.ListProductos.RowCount - 1
                    If index < 0 Then
                        index = 0
                    End If
                    .Item(0, index).Value = recibview.ListProductos.RowCount
                    .Item(1, index).Value = ListAdicionales.Item(1, ListAdicionales.CurrentRow.Index).Value
                    .Item(2, index).Value = ListAdicionales.Item(2, ListAdicionales.CurrentRow.Index).Value
                    .Item(3, index).Value = ListAdicionales.Item(3, ListAdicionales.CurrentRow.Index).Value
                    .Item(4, index).Value = ListAdicionales.Item(4, ListAdicionales.CurrentRow.Index).Value
                    .Item(5, index).Value = ListAdicionales.Item(5, ListAdicionales.CurrentRow.Index).Value
                    .Item(6, index).Value = ListAdicionales.Item(6, ListAdicionales.CurrentRow.Index).Value
                    .Item(7, index).Value = 1
                    .Item(8, index).Value = SoloNumeros.formatoMoneda(ListAdicionales.Item(7, ListAdicionales.CurrentRow.Index).Value)
                    .Item(9, index).Value = ListAdicionales.Item(0, ListAdicionales.CurrentRow.Index).Value
                Else
                    .Item(7, indRecib).Value = .Item(7, indRecib).Value + 1
                End If



            End With
        Catch ex As Exception

        End Try
    End Sub
End Class