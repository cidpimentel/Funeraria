Public Class Almacen

    Private _id As Integer
    Private _almacen As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, almacen As String)
        Me.Id = id
        Me.Almacen = almacen
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Almacen As String
        Get
            Return _almacen
        End Get
        Set(value As String)
            _almacen = value
        End Set
    End Property
End Class
