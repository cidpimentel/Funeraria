Public Class ListEmpleados
    Implements MetdosGrid

    Public Sub CrearGrid() Implements MetdosGrid.CrearGrid
        With ListUsuarios
            .Rows.Clear()
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowsDefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.SelectionBackColor = SetColors.RGBColors.dorado
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .AlternatingRowsDefaultCellStyle.BackColor = Color.DimGray
            .AlternatingRowsDefaultCellStyle.ForeColor = Color.White
            .ColumnCount = 6

            .Columns(0).HeaderText = "#"
            .Columns(1).HeaderText = "Empleado"
            .Columns(2).HeaderText = "Usuario"
            .Columns(3).HeaderText = "Tel.Fijo"
            .Columns(4).HeaderText = "Tel.Movil"
            .Columns(5).HeaderText = "Tel.Movil"

            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1
            .Columns(0).ContextMenuStrip = ContextMenuStrip1


            .Columns(0).Name = "Clave"

            .Columns(0).ReadOnly = True
            .Columns(5).Visible = False

        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim emp As New DAOUsuario
        emp.Tipo = 2
        Dim resultado As List(Of Usuario) = emp.Listar
        Dim i As Integer = 0


        With ListUsuarios
            .Rows.Clear()
            For Each row As Usuario In resultado



                .Rows.Add(1)
                .Item(0, i).Value = row.Id
                .Item(1, i).Value = row.Nombre
                .Item(2, i).Value = row.Usuario
                .Item(3, i).Value = row.Tel_fijo
                .Item(4, i).Value = row.Celular
                .Item(5, i).Value = row.IdUsuario

                i += 1
            Next
            lblTotEntidades.Text = "Listados " & ListUsuarios.RowCount
        End With
    End Sub
    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            Dim emp As New DAOUsuario
            With ListUsuarios
                emp.Id = .Item(0, .CurrentRow.Index).Value
                emp.IdUsuario = .Item(5, .CurrentRow.Index).Value
            End With
            EditarEmpleado.emp = emp
            EditarEmpleado.recibview = Me
            EditarEmpleado.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim emp As New DAOUsuario
            emp.Id = 0
            emp.IdUsuario = 0
            EditarEmpleado.emp = emp
            EditarEmpleado.recibview = Me
            EditarEmpleado.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim user As New DAOUsuario
        With ListUsuarios
            user.IdUsuario = .Item(5, .CurrentRow.Index).Value
            user.Eliminar()
            .Rows.Remove(.CurrentRow)
            lblTotEntidades.Text = "Listados " & ListUsuarios.RowCount
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
        End With
    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each row As DataGridViewRow In ListUsuarios.Rows
            'Si el contenido de la columna coinside con el valor del TextBox
            Dim cell As DataGridViewCell = row.Cells("Clave")

            If IsNumeric(txtBuscar.Text) Then
                If CStr(row.Cells(0).Value).ToLower = txtBuscar.Text.ToLower Then
                    'Selecciono fila y abandono bucle
                    row.Selected = True
                    ListUsuarios.FirstDisplayedCell = ListUsuarios.Item(1, row.Index)
                    ListUsuarios.CurrentCell = cell
                    Exit For

                Else
                    row.Selected = False
                End If
            Else
                Dim cadena As String = txtBuscar.Text.ToLower
                Dim i As Integer = InStr(CStr(row.Cells(1).Value).ToLower, cadena)

                If i > 0 Then
                    row.Selected = True
                    ListUsuarios.FirstDisplayedCell = ListUsuarios.Item(1, row.Index)
                    ListUsuarios.CurrentCell = cell
                    Exit For
                Else
                    row.Selected = False
                End If
            End If

        Next
    End Sub
End Class