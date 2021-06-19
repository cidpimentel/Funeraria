Public Class Paquete
    Private _id As Integer
    Private _paquete As String
    Private _costo As Double

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, paquete As String, costo As Double)
        Me.Id = id
        Me.Paquete = paquete
        Me.Costo = costo
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Paquete As String
        Get
            Return _paquete
        End Get
        Set(value As String)
            _paquete = value
        End Set
    End Property

    Public Property Costo As Double
        Get
            Return _costo
        End Get
        Set(value As Double)
            _costo = value
        End Set
    End Property
End Class
