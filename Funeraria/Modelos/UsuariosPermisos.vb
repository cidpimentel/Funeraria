Public Class UsuariosPermisos

    Protected _id, _usuario, _menu, _valor As Integer

    Protected _menu_nombre As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, menu_nombre As String, valor As Integer)
        Me.Id = id
        Me.Valor = valor
        Me.Menu_nombre = menu_nombre
    End Sub

    Public Sub New(id As Integer, usuario As Integer, menu As Integer, valor As Integer, menu_nombre As String)
        Me.Id = id
        Me.Usuario = usuario
        Me.Menu = menu
        Me.Valor = valor
        Me.Menu_nombre = menu_nombre
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Usuario As Integer
        Get
            Return _usuario
        End Get
        Set(value As Integer)
            _usuario = value
        End Set
    End Property

    Public Property Menu As Integer
        Get
            Return _menu
        End Get
        Set(value As Integer)
            _menu = value
        End Set
    End Property

    Public Property Valor As Integer
        Get
            Return _valor
        End Get
        Set(value As Integer)
            _valor = value
        End Set
    End Property

    Public Property Menu_nombre As String
        Get
            Return _menu_nombre
        End Get
        Set(value As String)
            _menu_nombre = value
        End Set
    End Property
End Class
