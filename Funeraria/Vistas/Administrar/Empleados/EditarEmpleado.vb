Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp
Public Class EditarEmpleado
    Implements MetdosGrid




    Friend Shared emp As DAOUsuario
    Friend Shared recibview As ListEmpleados

    Dim AddColumn As New DataGridViewCheckBoxColumn

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

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
            .ColumnCount = 3

            .Columns(0).HeaderText = "id"
            .Columns(1).HeaderText = "#"
            .Columns(2).HeaderText = "Opcion Menu"
            .Columns.Insert(3, AddColumn)

            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            With AddColumn
                .HeaderText = "Habilitar"
                .Name = "check"
                .Width = 80
            End With
            .Columns(0).Visible = False
            .Columns(1).ReadOnly = True
            .Columns(2).ReadOnly = True
        End With
    End Sub

    Public Sub LlenarGrid() Implements MetdosGrid.LlenarGrid
        Dim em As New DAOUsuariosPermisos
        em.Usuario = emp.IdUsuario
        Dim resultado As List(Of UsuariosPermisos) = em.Listar
        Dim i As Integer = 0
        Dim a As Integer = 1

        With ListUsuarios
            .Rows.Clear()
            For Each row As UsuariosPermisos In resultado



                .Rows.Add(1)
                .Item(0, i).Value = row.Id
                .Item(1, i).Value = a
                .Item(2, i).Value = row.Menu_nombre
                If row.Valor = 1 Then
                    .Item(3, i).Value = True
                Else
                    .Item(3, i).Value = False
                End If



                i += 1
                a += 1
            Next
            'lblTotEntidades.Text = "Listados " & ListUsuarios.RowCount
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
    Private Sub EditarEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearGrid()
        LlenarGrid()
        Dim lista As List(Of Usuario) = emp.Consultar
        For Each objet As Usuario In lista
            txtNombre.Text = objet.Nombre
            txtPaterno.Text = objet.Paterno
            txtMaterno.Text = objet.Materno
            txtRFC.Text = objet.Rfc
            txtFijo.Text = objet.Tel_fijo
            TxtCelular.Text = objet.Celular
            txtEmail.Text = objet.Email
            txtDomicilio.Text = objet.Domicilio
            txtUsuario.Text = objet.Usuario
            txtContraseña.Text = objet.Contraseña

        Next

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            AsignarValores()

            If emp.Id <> 0 Then
                emp.Actualizar()
            Else
                emp.Id = emp.getCountPersona
                emp.IdUsuario = emp.getCountUser
                emp.Guardar()
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
        emp.Nombre = txtNombre.Text
        emp.Paterno = txtPaterno.Text
        emp.Materno = txtMaterno.Text
        emp.Rfc = txtRFC.Text
        emp.Tel_fijo = txtFijo.Text
        emp.Celular = TxtCelular.Text
        emp.Email = txtEmail.Text
        emp.Domicilio = txtDomicilio.Text
        emp.Usuario = txtUsuario.Text
        emp.Contraseña = txtContraseña.Text
        emp.Tipo = 2
    End Sub

    Private Sub ListUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ListUsuarios.CellContentClick
        ListUsuarios.CommitEdit(DataGridViewDataErrorContexts.Commit)
        Dim usp As New DAOUsuariosPermisos
        If e.ColumnIndex = 3 Then
            Dim value As Boolean = CType(Me.ListUsuarios.CurrentCell.EditedFormattedValue, Boolean)
            usp.Id = ListUsuarios.Item(0, ListUsuarios.CurrentRow.Index).Value
            If value = True Then
                usp.Valor = 1
            Else
                usp.Valor = 2
            End If
            usp.Actualizar()
        End If
    End Sub


    Private Sub txtFijo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFijo.KeyPress
        SoloNumeros.soloNumeros(sender, e)
    End Sub

    Private Sub TxtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCelular.KeyPress
        SoloNumeros.soloNumeros(sender, e)
    End Sub
End Class