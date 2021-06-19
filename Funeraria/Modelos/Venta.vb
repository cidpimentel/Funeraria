Public Class Venta

    Protected Friend _id, _cliente, _paquete As Integer
    Protected Friend _subtotal, _iva, _total, _descuento As Double
    Protected Friend _nom_cliente, _nom_paquete, _fecha As String

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, nombreCliente As String, nombrePaquete As String, subtotal As Double, iva As Double, total As Double, fecha As String, descuento As Double)
        Me.Id = id
        Me.Nom_cliente = nombreCliente
        Me.Nom_paquete = nombrePaquete
        Me.Subtotal = subtotal
        Me.Iva = iva
        Me.Total = total
        Me.Fecha = fecha
        Me.Descuento = descuento
    End Sub

    Public Sub New(id As Integer, cliente As Integer, paquete As Integer, subtotal As Double, iva As Double, total As Double)
        Me.Id = id
        Me.Cliente = cliente
        Me.Paquete = paquete
        Me.Subtotal = subtotal
        Me.Iva = iva
        Me.Total = total
    End Sub

    Protected Friend Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Protected Friend Property Cliente As Integer
        Get
            Return _cliente
        End Get
        Set(value As Integer)
            _cliente = value
        End Set
    End Property

    Protected Friend Property Paquete As Integer
        Get
            Return _paquete
        End Get
        Set(value As Integer)
            _paquete = value
        End Set
    End Property

    Protected Friend Property Subtotal As Double
        Get
            Return _subtotal
        End Get
        Set(value As Double)
            _subtotal = value
        End Set
    End Property

    Protected Friend Property Iva As Double
        Get
            Return _iva
        End Get
        Set(value As Double)
            _iva = value
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

    Protected Friend Property Nom_cliente As String
        Get
            Return _nom_cliente
        End Get
        Set(value As String)
            _nom_cliente = value
        End Set
    End Property

    Protected Friend Property Nom_paquete As String
        Get
            Return _nom_paquete
        End Get
        Set(value As String)
            _nom_paquete = value
        End Set
    End Property

    Protected Friend Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Protected Friend Property Descuento As Double
        Get
            Return _descuento
        End Get
        Set(value As Double)
            _descuento = value
        End Set
    End Property
End Class
