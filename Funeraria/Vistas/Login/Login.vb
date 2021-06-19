Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp


Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Drag Form'
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitleBar_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Application.Exit()
    End Sub

    Private Sub Logout(sender As Object, e As FormClosedEventArgs)
        txtUsuario.Clear()
        txtContraseña.Clear()
        Me.Show()
        txtUsuario.Focus()
    End Sub

    Private Sub Acceder()
        If txtUsuario.Text <> "" And txtContraseña.Text <> "" Then
            Dim user As New DAOUsuario With {
                .Usuario = txtUsuario.Text,
                .Contraseña = txtContraseña.Text
            }

            If user.ValidarUser(user.Usuario) = user.Contraseña Then
                Dim frm As New Menu()
                frm.tiempo()
                frm.Show()
                AddHandler frm.FormClosed, AddressOf Me.Logout
                Me.Hide()
            Else
                MsgBox("Error en las credenciales", vbCritical, "Error")
            End If
        Else
            MsgBox("Faltan campos por rellenar", vbExclamation, "Error")
        End If
    End Sub
    Private Sub txtContraseña_KeyDown(sender As Object, e As KeyEventArgs) Handles txtContraseña.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub txtUsuario_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Acceder()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class
