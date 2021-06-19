Imports System.Runtime.InteropServices

Public Class EditarClientes
    Friend Shared recibview As ListClientes
    Friend Shared emp As DAOUsuario


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

    Private Sub EditarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        emp.Tipo = 1
    End Sub

End Class