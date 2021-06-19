Imports System.Runtime.InteropServices

Public Class BuscarCliente
    Implements MetdosGrid

    Friend Shared recibview As EditarVenta


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

            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Cliente"


            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).Name = "Clave"

            .Columns(0).Visible = False


        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim emp As New DAOUsuario

        Dim resultado As List(Of Usuario) = emp.ListarTodo
        Dim i As Integer = 0
        Dim a As Integer = 1

        With ListAdicionales
            .Rows.Clear()
            For Each row As Usuario In resultado

                .Rows.Add(1)
                .Item(0, i).Value = row.Id
                .Item(1, i).Value = a
                .Item(2, i).Value = row.Nombre

                i += 1
                a += 1
            Next
            'lblTotEntidades.Text = "Listados " & ListProductos.RowCount
        End With
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles panelTitleBar.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BuscarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In ListAdicionales.Rows
            'Si el contenido de la columna coinside con el valor del TextBox
            Dim cell As DataGridViewCell = row.Cells("Clave")

            If IsNumeric(txtValor.Text) Then
                If CStr(row.Cells(0).Value).ToLower = txtValor.Text.ToLower Then
                    'Selecciono fila y abandono bucle
                    row.Selected = True
                    ListAdicionales.FirstDisplayedCell = ListAdicionales.Item(1, row.Index)
                    ListAdicionales.CurrentCell = cell
                    Exit For

                Else
                    row.Selected = False
                End If
            Else
                Dim cadena As String = txtValor.Text.ToLower
                Dim i As Integer = InStr(CStr(row.Cells(2).Value).ToLower, cadena)

                If i > 0 Then
                    row.Selected = True
                    ListAdicionales.FirstDisplayedCell = ListAdicionales.Item(1, row.Index)
                    ListAdicionales.CurrentCell = cell
                    Exit For
                Else
                    row.Selected = False
                End If
            End If

        Next
    End Sub
End Class