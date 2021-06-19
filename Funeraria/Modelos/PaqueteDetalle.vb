Public Class PaqueteDetalle
    Inherits Paquete

    Protected Friend _idDetalle, _producto, _cantidad As Integer
    Private _costo1 As Double

    Public Sub New()
    End Sub

    Public Sub New(v1 As Object, parte As String, descripcion As String, catgeoria As String, marca As String, unidad As String, precio_compra As Object, precio_venta As Object, idMarca As Object, idUni As Object, cantidad As Object)
        Me.IdDetalle = v1
        Me.parte = parte
        Me.descripcion = descripcion
        Me.catgeoria = catgeoria
        Me.marca = marca
        Me.unidad = unidad
        Me.precio_compra = precio_compra
        Me.precio_venta = precio_venta
        Me.idMarca = idMarca
        Me.idUni = idUni
        Me.Cantidad = cantidad
    End Sub


    Private _parte As String
    Private _descripcion As String
    Private _catgeoria As String
    Private _marca As String
    Private _unidad As String
    Private _precio_compra As Object
    Private _precio_venta As Object
    Private _idMarca As Object
    Private _idUni As Object


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

    Protected Friend Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Protected Friend Property Costo1 As Double
        Get
            Return _costo1
        End Get
        Set(value As Double)
            _costo1 = value
        End Set
    End Property

    Protected Friend Property Parte As String
        Get
            Return _parte
        End Get
        Set(value As String)
            _parte = value
        End Set
    End Property

    Protected Friend Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Protected Friend Property Catgeoria As String
        Get
            Return _catgeoria
        End Get
        Set(value As String)
            _catgeoria = value
        End Set
    End Property

    Protected Friend Property Marca As String
        Get
            Return _marca
        End Get
        Set(value As String)
            _marca = value
        End Set
    End Property

    Protected Friend Property Unidad As String
        Get
            Return _unidad
        End Get
        Set(value As String)
            _unidad = value
        End Set
    End Property

    Protected Friend Property Precio_compra As Object
        Get
            Return _precio_compra
        End Get
        Set(value As Object)
            _precio_compra = value
        End Set
    End Property

    Protected Friend Property Precio_venta As Object
        Get
            Return _precio_venta
        End Get
        Set(value As Object)
            _precio_venta = value
        End Set
    End Property

    Protected Friend Property IdMarca As Object
        Get
            Return _idMarca
        End Get
        Set(value As Object)
            _idMarca = value
        End Set
    End Property

    Protected Friend Property IdUni As Object
        Get
            Return _idUni
        End Get
        Set(value As Object)
            _idUni = value
        End Set
    End Property
End Class
