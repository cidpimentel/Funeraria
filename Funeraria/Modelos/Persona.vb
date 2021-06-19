Public Class Persona

    Protected _id, _tipo As Integer
    Protected _nombre, _paterno, _materno, _tel_fijo, _celular, _domicilio, _rfc, _email As String

    Public Sub New()
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Tipo As Integer
        Get
            Return _tipo
        End Get
        Set(value As Integer)
            _tipo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Paterno As String
        Get
            Return _paterno
        End Get
        Set(value As String)
            _paterno = value
        End Set
    End Property

    Public Property Materno As String
        Get
            Return _materno
        End Get
        Set(value As String)
            _materno = value
        End Set
    End Property

    Public Property Tel_fijo As String
        Get
            Return _tel_fijo
        End Get
        Set(value As String)
            _tel_fijo = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            _domicilio = value
        End Set
    End Property

    Public Property Rfc As String
        Get
            Return _rfc
        End Get
        Set(value As String)
            _rfc = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property
End Class
