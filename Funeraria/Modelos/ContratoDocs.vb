Public Class ContratoDocs

    Private _id, _contrato, _documento As Integer
    Private _url, _nom_documento As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, contrato As Integer, documento As Integer, url As String, nom_documento As String)
        Me.Id = id
        Me.Contrato = contrato
        Me.Documento = documento
        Me.Url = url
        Me.Nom_documento = nom_documento
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

    Public Property Url As String
        Get
            Return _url
        End Get
        Set(value As String)
            _url = value
        End Set
    End Property

    Public Property Nom_documento As String
        Get
            Return _nom_documento
        End Get
        Set(value As String)
            _nom_documento = value
        End Set
    End Property
End Class
