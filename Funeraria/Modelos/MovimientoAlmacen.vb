Public Class MovimientoAlmacen
    Inherits Product

    Protected Friend _id, _movimiento, _empleado, _almacen As Integer
    Protected Friend _nom_movi, _nom_empleado, _nom_almacen, _descripcion, _fecha As String



    Public Sub New()
    End Sub

    Public Sub New(id As Integer, descripcion As String, nom_movi As String, nom_empleado As String, nom_almacen As String, fecha As String)
        Me.Id = id
        Me.Nom_movi = nom_movi
        Me.Nom_empleado = nom_empleado
        Me.Nom_almacen = nom_almacen
        Me.Descripcion = descripcion
        Me.Fecha = fecha
    End Sub

    Protected Friend Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Protected Friend Property Movimiento As Integer
        Get
            Return _movimiento
        End Get
        Set(value As Integer)
            _movimiento = value
        End Set
    End Property

    Protected Friend Property Empleado As Integer
        Get
            Return _empleado
        End Get
        Set(value As Integer)
            _empleado = value
        End Set
    End Property

    Protected Friend Property Almacen As Integer
        Get
            Return _almacen
        End Get
        Set(value As Integer)
            _almacen = value
        End Set
    End Property

    Protected Friend Property Nom_movi As String
        Get
            Return _nom_movi
        End Get
        Set(value As String)
            _nom_movi = value
        End Set
    End Property

    Protected Friend Property Nom_empleado As String
        Get
            Return _nom_empleado
        End Get
        Set(value As String)
            _nom_empleado = value
        End Set
    End Property

    Protected Friend Property Nom_almacen As String
        Get
            Return _nom_almacen
        End Get
        Set(value As String)
            _nom_almacen = value
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

    Protected Friend Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property
End Class
