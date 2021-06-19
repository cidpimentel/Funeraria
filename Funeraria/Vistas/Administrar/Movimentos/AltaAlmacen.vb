Imports System.Runtime.InteropServices

Public Class AltaAlmacen
    Implements MetdosGrid

    Friend Shared recibview As EditarMovimiento



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
            .DefaultCellStyle.SelectionBackColor = Color.Black
            .DefaultCellStyle.SelectionForeColor = Color.White
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            .ColumnCount = 3

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Almacen"

            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill



            .Columns(0).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim cat As New DAOAlmacen
        Dim almacenes As List(Of Almacen) = cat.ListarAlmacen
        Dim a As Integer = 1
        Dim i As Integer = 0

        With ListAdicionales
            .Rows.Clear()

            '  MsgBox(categorias.Count)
            For Each row As Almacen In almacenes

                .Rows.Add(1)
                .Item(0, i).Value = row.Id
                .Item(1, i).Value = a
                .Item(2, i).Value = row.Almacen

                i += 1
                a += 1
            Next

        End With
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub AltaAlmacen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim alm As New DAOAlmacen
        alm.Id = alm.getCount
        alm.Almacen = txtValor.Text
        alm.Guardar()
        recibview.LlenarComboAlmacen()
        LlenarGrid()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With ListAdicionales
            Dim id As Integer = .Item(0, .CurrentRow.Index).Value

            recibview.ComboAlmacen.SelectedValue = id


            Me.Close()
            Me.Dispose()
        End With
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Try

            Dim alm As New DAOAlmacen

            With ListAdicionales
                Dim id As Integer = .Item(0, .CurrentRow.Index).Value
                .Rows.Remove(.CurrentRow)
                alm.Id = id
                alm.Eliminar()
                recibview.LlenarComboAlmacen()
                MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class