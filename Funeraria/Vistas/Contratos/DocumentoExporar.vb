Imports System.Runtime.InteropServices

Public Class DocumentoExporar
    Friend Shared recibview As EditarContrato

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            OpenFileDialog1.DefaultExt = "*.*"

            OpenFileDialog1.Filter = "Pdf | *.pdf| Imagen | *.jpg"

            If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then

                Exit Sub

            Else

                txtRuta.Text = OpenFileDialog1.FileName

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            If comboDocumento.SelectedValue IsNot Nothing And txtRuta.Text <> "" Then
                With recibview.ListProductos
                    .Rows.Add(1)
                    Dim index As Integer = recibview.ListProductos.RowCount - 1
                    If index < 0 Then
                        index = 0
                    End If

                    .Item(0, index).Value = 0
                    .Item(1, index).Value = recibview.txtFolioVenta.Text
                    .Item(2, index).Value = recibview.ListProductos.RowCount
                    .Item(3, index).Value = comboDocumento.SelectedValue
                    .Item(4, index).Value = comboDocumento.Text
                    .Item(5, index).Value = ServicioFTP.upload(recibview.txtFolioVenta.Text & "-" & comboDocumento.Text, txtRuta.Text)

                End With

                Me.Close()
                Me.Dispose()
            End If

        Catch ex As Exception
        MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub LlenarComboDocs()
        Dim cat As New DAODocumento
        Dim ListCat As List(Of Documento) = cat.ListarDocumentos

        With comboDocumento
            '.Items.Clear()
            .DataSource = ListCat
            .DisplayMember = "Nombre_documento"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub
    Private Sub DocumentoExporar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboDocs()
    End Sub
End Class