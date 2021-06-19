Public Class Product


    Private _id, _categoria, _unidad, _marca, _mostrarP, _status, stock, almacen As Integer
    Private _venta, _compra As Double
    Private _descripcion, _parte, _categoriaN, _unidadN, _marcaN As String

    Public Sub New()
    End Sub


    Public Sub New(id As Integer, parte As String, descripcion As String, categoria As Integer, unidad As Integer, marca As Integer, compra As Double, venta As Double, mostrarP As Integer)
        Me.Id = id
        Me.Parte = parte
        Me.Categoria = categoria
        Me.Unidad = unidad
        Me.Marca = marca
        Me.Venta = venta
        Me.Compra = compra
        Me.Descripcion = descripcion
        Me.MostrarP = mostrarP
    End Sub

    Public Sub New(id As Integer, parte As String, descripcion As String, categoriaN As String, marcaN As String, unidadN As String, compra As Double, venta As Double, stock As Integer)
        Me.Id = id
        Me.Parte = parte
        Me.Descripcion = descripcion
        Me.CategoriaN = categoriaN
        Me.UnidadN = unidadN
        Me.MarcaN = marcaN
        Me.Venta = venta
        Me.Compra = compra
        Me.stock = stock
    End Sub

    Public Sub New(id As Integer, parte As String, descripcion As String, categoriaN As String, marcaN As String, unidadN As String, compra As Double, venta As Double, marca As Integer, uni As Integer, stock As Integer)
        Me.Id = id
        Me.Parte = parte
        Me.Descripcion = descripcion
        Me.CategoriaN = categoriaN
        Me.UnidadN = unidadN
        Me.MarcaN = marcaN
        Me.Venta = venta
        Me.Compra = compra
        Me.Marca = marca
        Me.Unidad = uni
        Me.stock = stock
    End Sub


    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Parte As String
        Get
            Return _parte
        End Get
        Set(value As String)
            _parte = value
        End Set
    End Property

    Public Property Categoria As Integer
        Get
            Return _categoria
        End Get
        Set(value As Integer)
            _categoria = value
        End Set
    End Property

    Public Property Unidad As Integer
        Get
            Return _unidad
        End Get
        Set(value As Integer)
            _unidad = value
        End Set
    End Property

    Public Property Marca As Integer
        Get
            Return _marca
        End Get
        Set(value As Integer)
            _marca = value
        End Set
    End Property

    Public Property Venta As Double
        Get
            Return _venta
        End Get
        Set(value As Double)
            _venta = value
        End Set
    End Property

    Public Property Compra As Double
        Get
            Return _compra
        End Get
        Set(value As Double)
            _compra = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property MostrarP As Integer
        Get
            Return _mostrarP
        End Get
        Set(value As Integer)
            _mostrarP = value
        End Set
    End Property

    Public Property Status As Integer
        Get
            Return _status
        End Get
        Set(value As Integer)
            _status = value
        End Set
    End Property

    Public Property CategoriaN As String
        Get
            Return _categoriaN
        End Get
        Set(value As String)
            _categoriaN = value
        End Set
    End Property

    Public Property UnidadN As String
        Get
            Return _unidadN
        End Get
        Set(value As String)
            _unidadN = value
        End Set
    End Property

    Public Property MarcaN As String
        Get
            Return _marcaN
        End Get
        Set(value As String)
            _marcaN = value
        End Set
    End Property

    Public Property Stock1 As Integer
        Get
            Return stock
        End Get
        Set(value As Integer)
            stock = value
        End Set
    End Property

    Public Property Almacen1 As Integer
        Get
            Return almacen
        End Get
        Set(value As Integer)
            almacen = value
        End Set
    End Property
End Class
