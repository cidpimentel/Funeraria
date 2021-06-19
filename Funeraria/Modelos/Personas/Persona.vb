Public Class Persona
    Protected id As Integer
    Protected nombre, paterno, materno, tel_fijo, tel_cel, domicilio, rfc, email As String

    Public Sub New()
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Paterno1 As String
        Get
            Return paterno
        End Get
        Set(value As String)
            paterno = value
        End Set
    End Property

    Public Property Materno1 As String
        Get
            Return materno
        End Get
        Set(value As String)
            materno = value
        End Set
    End Property

    Public Property Tel_fijo1 As String
        Get
            Return tel_fijo
        End Get
        Set(value As String)
            tel_fijo = value
        End Set
    End Property

    Public Property Tel_cel1 As String
        Get
            Return tel_cel
        End Get
        Set(value As String)
            tel_cel = value
        End Set
    End Property

    Public Property Domicilio1 As String
        Get
            Return domicilio
        End Get
        Set(value As String)
            domicilio = value
        End Set
    End Property

    Public Property Rfc1 As String
        Get
            Return rfc
        End Get
        Set(value As String)
            rfc = value
        End Set
    End Property

    Public Property Email1 As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property
End Class
