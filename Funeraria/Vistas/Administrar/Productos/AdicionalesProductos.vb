Imports System.Runtime.InteropServices

Public Class AdicionalesProductos
    Implements MetdosGrid

    Friend Shared recibView As EditarProductos

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
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
            .ColumnCount = 3

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Unidad"

            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



            .Columns(0).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim cat As New DAOCategoria
        Dim uni As New DAOUnidad
        Dim mar As New DAOMarca
        Dim unidades As List(Of Unidad)
        Dim categorias As List(Of Categoria)
        Dim marcas As List(Of Marca)
        Dim a As Integer = 1
        Dim i As Integer = 0

        With ListAdicionales
            .Rows.Clear()
            Select Case lblFormTitle.Text
                Case "Unidades"
                    unidades = uni.ListarUnidades
                    '   MsgBox(unidades.Count)
                    For Each row As Unidad In unidades

                        .Rows.Add(1)
                        .Item(0, i).Value = row.Id
                        .Item(1, i).Value = a
                        .Item(2, i).Value = row.Descripcion

                        i += 1
                        a += 1
                    Next
                Case "Marcas"
                    marcas = mar.ListarMarcas
                    '  MsgBox(marcas.Count)
                    For Each row As Marca In marcas

                        .Rows.Add(1)
                        .Item(0, i).Value = row.Id
                        .Item(1, i).Value = a
                        .Item(2, i).Value = row.Descripcion

                        i += 1
                        a += 1
                    Next
                Case "Categorias"
                    categorias = cat.ListarCategorias
                    '  MsgBox(categorias.Count)
                    For Each row As Categoria In categorias

                        .Rows.Add(1)
                        .Item(0, i).Value = row.Id
                        .Item(1, i).Value = a
                        .Item(2, i).Value = row.Descripcion

                        i += 1
                        a += 1
                    Next
            End Select



        End With
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub AdicionalesProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            Dim cat As New DAOCategoria
            Dim uni As New DAOUnidad
            Dim mar As New DAOMarca

            Select Case lblFormTitle.Text
                Case "Unidades"
                    uni.Id = uni.getCount
                    uni.Descripcion = txtValor.Text
                    uni.Guardar()
                    recibView.LlenarComboUni()
                Case "Marcas"
                    mar.Id = mar.getCount
                    mar.Descripcion = txtValor.Text
                    mar.Guardar()
                    recibView.LlenarComboMar()
                Case "Categorias"
                    cat.Id = cat.getCount
                    cat.Descripcion = txtValor.Text
                    cat.Guardar()
                    recibView.LlenarComboCat()
            End Select
            LlenarGrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try


            Dim cat As New DAOCategoria
            Dim uni As New DAOUnidad
            Dim mar As New DAOMarca

            With ListAdicionales
                Dim id As Integer = .Item(0, .CurrentRow.Index).Value

                .Rows.Remove(.CurrentRow)

                Select Case lblFormTitle.Text
                    Case "Unidades"
                        uni.Id = id
                        uni.Eliminar()
                        recibView.LlenarComboUni()
                    Case "Marcas"
                        mar.Id = id
                        mar.Eliminar()
                        recibView.LlenarComboMar()
                    Case "Categorias"
                        cat.Id = id
                        cat.Eliminar()
                        recibView.LlenarComboCat()
                End Select

                MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With ListAdicionales
            Dim id As Integer = .Item(0, .CurrentRow.Index).Value


            Select Case lblFormTitle.Text
                Case "Unidades"

                    recibView.comboUnidad.SelectedValue = id
                Case "Marcas"

                    recibView.comboMarca.SelectedValue = id
                Case "Categorias"

                    recibView.comboCategoria.SelectedValue = id
            End Select

            Me.Close()
            Me.Dispose()
        End With
    End Sub


End Class