Public Class MovAlmDet
    Inherits MovimientoAlmacen

    Protected Friend _producto, _cantidad As Integer
    Protected Friend _costo_uni, _total As Double

    Public Sub New(id As Integer, parte As String, descripcion As String, categoriaN As String, marcaN As String, unidadN As String, compra As Double, venta As Double, marca As Integer, uni As Integer, cantidad As Integer)
        MyBase.Id = id
        MyBase.Parte = parte
        MyBase.Descripcion = descripcion
        MyBase.CategoriaN = categoriaN
        MyBase.UnidadN = unidadN
        MyBase.MarcaN = marcaN
        MyBase.Venta = venta
        MyBase.Compra = compra
        MyBase.Marca = marca
        MyBase.Unidad = uni
        Me.Cantidad = cantidad
    End Sub


    Public Sub New()
    End Sub

    Public Sub New(producto As Integer, cantidad As Integer, costo_uni As Double, total As Double)

        Me.Producto = producto
        Me.Cantidad = cantidad
        Me.Costo_uni = costo_uni
        Me.Total = total
    End Sub



    Protected Friend Property Producto As Integer
        Get
            Return _producto
        End Get
        Set(value As Integer)
            _producto = value
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

    Protected Friend Property Costo_uni As Double
        Get
            Return _costo_uni
        End Get
        Set(value As Double)
            _costo_uni = value
        End Set
    End Property

    Protected Friend Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property
End Class
