Public Class VentaDetalle
    Inherits Venta


    Protected Friend _idDetalle, _producto, _cantidad As Integer
    Private _costo As Double

    Public Sub New()
    End Sub

    Public Sub New(idDetalle As Integer, producto As Integer, costo As Double)
        _idDetalle = idDetalle
        _producto = producto
        _costo = costo
    End Sub

    Protected Friend Property IdDetalle As Integer
        Get
            Return _idDetalle
        End Get
        Set(value As Integer)
            _idDetalle = value
        End Set
    End Property

    Protected Friend Property Producto As Integer
        Get
            Return _producto
        End Get
        Set(value As Integer)
            _producto = value
        End Set
    End Property

    Protected Friend Property Costo As Double
        Get
            Return _costo
        End Get
        Set(value As Double)
            _costo = value
        End Set
    End Property

    Protected Friend Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property
End Class
