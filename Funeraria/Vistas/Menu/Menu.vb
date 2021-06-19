Imports System.Runtime.InteropServices
Imports FontAwesome.Sharp

Public Class Menu

    'Fields'
    Private currentBtn As IconButton
    Private leftBorderBtn As Panel
    Private currentChildForm As Form

    Public Structure RGBColors
        Public Shared dorado As Color = Color.FromArgb(252, 180, 62)
        Public Shared negro As Color = Color.FromArgb(34, 33, 32)
        Public Shared rojo As Color = Color.FromArgb(221, 19, 19)
        Public Shared color4 As Color = Color.FromArgb(95, 77, 221)
        Public Shared color5 As Color = Color.FromArgb(249, 88, 155)
        Public Shared color6 As Color = Color.FromArgb(24, 161, 251)
    End Structure

    'Constructor'
    Public Sub New()

        ' This call is required by the designer.'
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.'
        leftBorderBtn = New Panel()
        leftBorderBtn.Size = New Size(7, 60)
        panelMenu.Controls.Add(leftBorderBtn)
        'Form'
        Me.Text = String.Empty
        Me.ControlBox = False
        Me.DoubleBuffered = True
        Me.MaximizedBounds = Screen.PrimaryScreen.WorkingArea

    End Sub

    'Methods'
    Private Sub ActivateButton(senderBtn As Object, customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            'Button'
            currentBtn = CType(senderBtn, IconButton)
            currentBtn.BackColor = Color.FromArgb(133, 131, 130)
            currentBtn.ForeColor = customColor
            currentBtn.IconColor = customColor
            currentBtn.TextAlign = ContentAlignment.MiddleCenter
            currentBtn.ImageAlign = ContentAlignment.MiddleRight
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage
            'Left Border'
            leftBorderBtn.BackColor = customColor
            leftBorderBtn.Location = New Point(0, currentBtn.Location.Y)
            leftBorderBtn.Visible = True
            leftBorderBtn.BringToFront()
            'current Form icon'
            IconCurrentForm.IconChar = currentBtn.IconChar
            IconCurrentForm.IconColor = customColor
            lblFormTitle.Text = currentBtn.Text
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(34, 33, 32)
            currentBtn.ForeColor = Color.Gainsboro
            currentBtn.IconColor = Color.Gainsboro
            currentBtn.TextAlign = ContentAlignment.MiddleLeft
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText
        End If
    End Sub

    Private Sub Reset()
        DisableButton()
        leftBorderBtn.Visible = False
        IconCurrentForm.IconChar = IconChar.Home
        IconCurrentForm.IconColor = Color.Gainsboro
        lblFormTitle.Text = "Inicio"
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
    End Sub

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

    Private Sub OpenChildForm(childForm As Form)
        'Open only form'
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If
        currentChildForm = childForm
        'end'
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        PanelDesktop.Controls.Add(childForm)
        PanelDesktop.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        lblFormTitle.Text = childForm.Text
    End Sub

    'Close-Maximize-Minimize'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMaximize_Click_1(sender As Object, e As EventArgs) Handles btnMaximize.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
            btnMaximize.Visible = False
            btnRestore.Visible = True
        Else
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMaximize_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        If WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        Else
            btnMaximize.Visible = True
            btnRestore.Visible = False
            WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        WindowState = FormWindowState.Minimized
    End Sub

    'Remove transparent border in maximized state'
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
        Else
            FormBorderStyle = FormBorderStyle.Sizable
        End If
        If Me.Size.Height < 1000 And Me.Size.Height < 600 Then
            Me.Size = New Size(1000, 600)

        End If
    End Sub

    Public Sub tiempo()
        '1000 ms = 1 seg, 1 min = 60 seg.
        Timer1.Interval = 1000
        Timer1.Enabled = True
        Timer2.Interval = 60000
        Timer2.Enabled = True
    End Sub
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tiempo()
        HabilitarControles()
    End Sub


    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Reset()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHoraFecha.Text = Today & " " & TimeOfDay
    End Sub

    Private Sub btnExit_MouseHover(sender As Object, e As EventArgs) Handles btnExit.MouseHover
        btnExit.BackColor = RGBColors.rojo
    End Sub

    Private Sub btnExit_MouseLeave(sender As Object, e As EventArgs) Handles btnExit.MouseLeave
        btnExit.BackColor = RGBColors.negro
    End Sub

    Private Sub HabilitarControles()
        Dim usp As New DAOUsuariosPermisos
        usp.Usuario = ActiveUser.idUser

        IconButton1.Visible = usp.GetPermisOpc(IconButton1.Text)
        IconButton2.Visible = usp.GetPermisOpc(IconButton2.Text)
        IconButton3.Visible = usp.GetPermisOpc(IconButton3.Text)
        IconButton4.Visible = usp.GetPermisOpc(IconButton4.Text)
        IconButton5.Visible = usp.GetPermisOpc(IconButton5.Text)
        IconButton6.Visible = usp.GetPermisOpc(IconButton6.Text)
        IconButton7.Visible = usp.GetPermisOpc(IconButton7.Text)
        IconButton8.Visible = usp.GetPermisOpc(IconButton8.Text)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        ActivateButton(sender, RGBColors.dorado)
        OpenChildForm(New ListadoVentas)
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        ActivateButton(sender, RGBColors.dorado)
        OpenChildForm(New ListadoContratos)
    End Sub

    Private Sub IconButton7_Click(sender As Object, e As EventArgs) Handles IconButton7.Click
        ActivateButton(sender, RGBColors.dorado)
        OpenChildForm(New Productossssdd)
    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        ActivateButton(sender, RGBColors.dorado)
        OpenChildForm(New ListadoMovimientos)
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        ActivateButton(sender, RGBColors.dorado)
        OpenChildForm(New ListClientes)
    End Sub

    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        ActivateButton(sender, RGBColors.dorado)
        OpenChildForm(New ListEmpleados)
    End Sub

    Private Sub IconButton6_Click(sender As Object, e As EventArgs) Handles IconButton6.Click
        ActivateButton(sender, RGBColors.dorado)
        OpenChildForm(New ListadoPaquetes)
    End Sub
    Private Sub IconButton8_Click(sender As Object, e As EventArgs) Handles IconButton8.Click
        ActivateButton(sender, RGBColors.dorado)

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        HabilitarControles()
    End Sub
End Class