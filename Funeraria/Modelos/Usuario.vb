Public Class Usuario
    Inherits Persona
    Private _idUsuario As Integer
    Protected _usuario, _contraseña As String

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _usuario
        End Get
        Set(value As String)
            _usuario = value
        End Set
    End Property

    Public Property Contraseña As String
        Get
            Return _contraseña
        End Get
        Set(value As String)
            _contraseña = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(id As Integer, nombre As String, usuario As String, telF As String, telM As String, idUser As Integer)
        MyBase.Id = id
        MyBase.Nombre = nombre
        MyBase.Tel_fijo = telF
        MyBase.Celular = telM

        Me.Usuario = usuario
        Me.IdUsuario = idUser

    End Sub

    Public Sub New(nombre As String, paterno As String, materno As String, rfc As String, tel_fijo As String, celular As String, email As String, usuario As String, password As String, domicilio As String)
        MyBase.Nombre = nombre
        MyBase.Paterno = paterno
        MyBase.Materno = materno
        MyBase.Rfc = rfc
        MyBase.Tel_fijo = tel_fijo
        MyBase.Celular = celular
        MyBase.Email = email
        MyBase.Domicilio = domicilio
        Me.Usuario = usuario
        Me.Contraseña = password
    End Sub


End Class


