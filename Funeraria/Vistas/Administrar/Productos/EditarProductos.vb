Imports System.Runtime.InteropServices

Public Class EditarProductos
    Friend Shared pro As DAOProducto
    Friend Shared recibview As Productossssdd


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


    Private Sub EditProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarComboCat()
        LlenarComboUni()
        LlenarComboMar()

        Dim lista As List(Of Product) = pro.Consultar
        For Each objet As Product In lista

            txtParte.Text = objet.Parte
            txtCompra.Text = SoloNumeros.formatoMoneda(objet.Compra)
            txtVenta.Text = SoloNumeros.formatoMoneda(objet.Venta)
            txtDescripcion.Text = objet.Descripcion

            comboCategoria.SelectedValue = objet.Categoria

            comboMarca.SelectedValue = objet.Marca
            comboUnidad.SelectedValue = objet.Unidad
            If objet.MostrarP = 1 Then
                checkOnine.Checked = True
            Else
                checkOnine.Checked = False
            End If
        Next
    End Sub

    Public Sub LlenarComboCat()
        Dim cat As New DAOCategoria
        Dim ListCat As List(Of Categoria) = cat.ListarCategorias

        With comboCategoria
            '.Items.Clear()
            .DataSource = ListCat
            .DisplayMember = "Descripcion"
            .ValueMember = "Id"
            .SelectedIndex = -1
        End With
    End Sub

    Public Sub LlenarComboUni()
        Dim cat As New DAOUnidad
        Dim ListCat As List(Of Unidad) = cat.ListarUnidades
        With comboUnidad
            '.Items.Clear()
            .DataSource = ListCat
            .DisplayMember = "Descripcion"
            .ValueMember = "Id"
            .SelectedIndex = 0
        End With
    End Sub

    Public Sub LlenarComboMar()
        Dim cat As New DAOMarca
        Dim ListCat As List(Of Marca) = cat.ListarMarcas
        With comboMarca
            '.Items.Clear()
            .DataSource = ListCat
            .DisplayMember = "Descripcion"
            .ValueMember = "Id"
            .SelectedIndex = 3
        End With
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            AsignarValores()

            If pro.Id <> 0 Then
                pro.Actualizar()
            Else
                pro.Id = pro.getCountProducto
                pro.Guardar()
            End If
            recibview.LlenarGrid()

            MsgBox("Se ha almacenado con exito", vbInformation, "Resultado")
            Me.Close()
            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub AsignarValores()

        pro.Parte = txtParte.Text
        pro.Descripcion = txtDescripcion.Text
        pro.Categoria = comboCategoria.SelectedValue()
        pro.Unidad = comboUnidad.SelectedValue()
        pro.Marca = comboMarca.SelectedValue()
        pro.Compra = txtCompra.Text
        pro.Venta = txtVenta.Text
        If checkOnine.Checked = True Then
            pro.MostrarP = 1
        Else
            pro.MostrarP = 0
        End If

    End Sub

    Private Sub btnUnidades_Click(sender As Object, e As EventArgs) Handles btnUnidades.Click
        Try
            AdicionalesProductos.lblFormTitle.Text = "Unidades"
            AdicionalesProductos.recibView = Me
            AdicionalesProductos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMarca_Click(sender As Object, e As EventArgs) Handles btnMarca.Click
        Try
            AdicionalesProductos.lblFormTitle.Text = "Marcas"
            AdicionalesProductos.recibView = Me
            AdicionalesProductos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        Try
            AdicionalesProductos.lblFormTitle.Text = "Categorias"
            AdicionalesProductos.recibView = Me
            AdicionalesProductos.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub


    Private Sub txtVenta_LostFocus(sender As Object, e As EventArgs) Handles txtVenta.LostFocus
        Dim cantidad As Double = txtVenta.Text = "."
        txtVenta.Text = SoloNumeros.formatoMoneda(cantidad)
    End Sub

    Private Sub txtCompra_TextChanged(sender As Object, e As EventArgs) Handles txtCompra.LostFocus
        Dim cantidad As Double = txtCompra.Text = "."
        txtCompra.Text = SoloNumeros.formatoMoneda(cantidad)
    End Sub

    Private Sub txtVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCompra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCompra.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtVenta_Enter(sender As Object, e As EventArgs) Handles txtVenta.Enter
        txtVenta.Tag = txtVenta.Text
        txtVenta.Clear()
    End Sub

    Private Sub txtCompra_Enter(sender As Object, e As EventArgs) Handles txtCompra.Enter
        txtCompra.Tag = txtCompra.Text
        txtCompra.Clear()
    End Sub

    Private Sub txtParte_Enter(sender As Object, e As EventArgs) Handles txtParte.Enter
        txtParte.Tag = txtParte.Text
        txtParte.Clear()
    End Sub
End Class