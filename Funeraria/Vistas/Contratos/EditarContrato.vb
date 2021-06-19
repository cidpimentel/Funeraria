Imports System.Runtime.InteropServices

Public Class EditarContrato
    Implements MetdosGrid


    Friend Shared recibview As ListadoContratos
    Friend Shared id_venta As Integer

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
            .ColumnCount = 6

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "contrato"
            .Columns(2).HeaderText = "#"
            .Columns(3).HeaderText = "id_documento"
            .Columns(4).HeaderText = "Documento"
            .Columns(5).HeaderText = "Url"


            .Columns(1).ContextMenuStrip = ContextMenuStrip1
            .Columns(2).ContextMenuStrip = ContextMenuStrip1
            .Columns(3).ContextMenuStrip = ContextMenuStrip1
            .Columns(4).ContextMenuStrip = ContextMenuStrip1
            .Columns(5).ContextMenuStrip = ContextMenuStrip1


            .Columns(4).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            .Columns(1).Name = "Clave"

            .Columns(0).Visible = False
            .Columns(1).Visible = False
            .Columns(3).Visible = False
            .Columns(5).Visible = False


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

    Private Sub txtFolioVenta_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFolioVenta.KeyDown
        If e.KeyCode = Keys.Enter Then
            'SendKeys.Send("{TAB}")
            cargarCliente()

        End If
    End Sub

    Private Sub cargarCliente()
        Dim per As New DAOUsuario

        Dim list As List(Of Usuario) = per.getVentaCliente(txtFolioVenta.Text)

        For Each user As Usuario In list
            txtCliente.Text = user.Nombre & " " & user.Paterno & " " & user.Materno
            txtEmail.Text = user.Email
            txtRFC.Text = user.Rfc
            txtFijo.Text = user.Tel_fijo
            txtmovil.Text = user.Celular
            txtDomicilio.Text = user.Domicilio
        Next
    End Sub

    Private Sub EditarContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        If id_venta <> 0 Then
            txtFolioVenta.Text = id_venta
            txtFolioVenta.ReadOnly = True
            Enter()
            cargarContrato()
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        DocumentoExporar.recibview = Me
        DocumentoExporar.ShowDialog()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cnt As New DAOContratos
        Try

            If txtFolioVenta.Text <> "" And txtFolioVenta.Text <> 0 Then

                cnt.Id = cnt.getCount()
                cnt.Cotizacion = txtFolioVenta.Text
                cnt.Nombre_finado = txtFinado.Text
                cnt.Domicilio_velacion = txtFinadoDomicilio.Text
                cnt.Tel_fijo = txtFijo.Text
                cnt.Celular = txtFinadoMovil.Text
                cnt.Destino = txtPanteonHorno.Text
                cnt.Fecha_hora_cotejo = dateCortejo.Text
                cnt.Oficialia = txtOficialia.Text
                cnt.Libro = txtLibro.Text
                cnt.Acta = txtActa.Text
                cnt.Fecha_registro = Today
                cnt.Guardar()

                For Each fila As DataGridViewRow In ListProductos.Rows
                    Dim doc As New DAOContDocs

                    doc.Id = doc.getCount
                    doc.Contrato = cnt.Id
                    doc.Documento = fila.Cells(3).Value
                    doc.Url = fila.Cells(5).Value
                    doc.Guardar()
                Next
                MsgBox("Se ha completado la operacion correctamente", vbInformation, "Resultado")
            Else
                MsgBox("Complete loscampos faltantes", vbCritical, "Error")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        With ListProductos
            Dim valor As String = .Item(5, .CurrentRow.Index).Value
            ServicioFTP.Download(valor)
        End With
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        With ListProductos
            Dim doc As New DAOContDocs
            Dim valor As String = .Item(5, .CurrentRow.Index).Value
            doc.Id = .Item(0, .CurrentRow.Index).Value
            .Rows.Remove(.CurrentRow)
            ServicioFTP.Eliminar(valor)
            doc.Eliminar()
            MsgBox("Se ha eliminado correctamente", vbInformation, "resultado")
        End With
    End Sub

    Public Sub Enter()
        SendKeys.Send("{ENTER}")
    End Sub

    Public Sub cargarContrato()
        Dim cont As New DAOContratos
        cont.Cotizacion = id_venta
        Dim con As List(Of Contratos) = cont.buscarContrato()

        For Each fila As Contratos In con
            txtFinado.Text = fila.Nombre_finado
            txtFinadoFijo.Text = fila.Tel_fijo
            txtFinadoMovil.Text = fila.Celular
            txtFinadoDomicilio.Text = fila.Domicilio_velacion
            txtPanteonHorno.Text = fila.Destino
            dateCortejo.Value = fila.Fecha_hora_cotejo
            txtOficialia.Text = fila.Oficialia
            txtLibro.Text = fila.Libro
            txtActa.Text = fila.Acta

            If ListProductos.RowCount = 0 Then
                Dim docs As New DAOContDocs
                docs.Contrato = fila.Id
                Dim lisdoc As List(Of ContratoDocs) = docs.buscarDocs()
                With ListProductos

                    Dim i As Integer = 0

                    For Each doc As ContratoDocs In lisdoc
                        .Rows.Add(1)

                        .Item(0, i).Value = doc.Id
                        .Item(1, i).Value = doc.Contrato
                        .Item(2, i).Value = .RowCount
                        .Item(3, i).Value = doc.Documento
                        .Item(4, i).Value = doc.Nom_documento
                        .Item(5, i).Value = doc.Url

                        i += 1
                    Next
                End With

            End If
        Next

    End Sub

End Class