Public Class Documento
    Protected Friend _id, _contrato, _documento As Integer
    Protected Friend _url_local, _nombre_documento As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombre_documento As String)
        Me.Id = id
        Me.Nombre_documento = nombre_documento
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Contrato As Integer
        Get
            Return _contrato
        End Get
        Set(value As Integer)
            _contrato = value
        End Set
    End Property

    Public Property Documento As Integer
        Get
            Return _documento
        End Get
        Set(value As Integer)
            _documento = value
        End Set
    End Property

    Public Property Url_local As String
        Get
            Return _url_local
        End Get
        Set(value As String)
            _url_local = value
        End Set
    End Property

    Public Property Nombre_documento As String
        Get
            Return _nombre_documento
        End Get
        Set(value As String)
            _nombre_documento = value
        End Set
    End Property
End Class
