Public Class Contratos

    Private _id, _cotizacion As Integer
    Private _nombreCliente, _nombre_finado, _domicilio_velacion, _tel_fijo, _celular, _destino, _fecha_hora_cotejo, _oficialia, _libro, _acta, _fecha_registro As String

    Public Sub New(id As Integer, cotizacion As Integer, cliente As String, finado As String, domicilioV As String, destino As String, celular As String, telfijo As String)
        Me.Id = id
        Me.Cotizacion = cotizacion
        Me.NombreCliente = cliente
        Me.Nombre_finado = finado
        Me.Domicilio_velacion = domicilioV
        Me.Destino = destino
        Me.Celular = celular
        Me.Tel_fijo = telfijo
    End Sub

    Public Sub New()
    End Sub

    Public Sub New(id As Integer, cotizacion As Integer, nombre_finado As String, domicilio_velacion As String, tel_fijo As String, celular As String, destino As String, fecha_hora_cotejo As String, oficialia As String, libro As String, acta As String, fecha_registro As String)
        Me.Id = id
        Me.Cotizacion = cotizacion
        Me.Nombre_finado = nombre_finado
        Me.Domicilio_velacion = domicilio_velacion
        Me.Tel_fijo = tel_fijo
        Me.Celular = celular
        Me.Destino = destino
        Me.Fecha_hora_cotejo = fecha_hora_cotejo
        Me.Oficialia = oficialia
        Me.Libro = libro
        Me.Acta = acta
        Me.Fecha_registro = fecha_registro
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Cotizacion As Integer
        Get
            Return _cotizacion
        End Get
        Set(value As Integer)
            _cotizacion = value
        End Set
    End Property

    Public Property Nombre_finado As String
        Get
            Return _nombre_finado
        End Get
        Set(value As String)
            _nombre_finado = value
        End Set
    End Property

    Public Property Domicilio_velacion As String
        Get
            Return _domicilio_velacion
        End Get
        Set(value As String)
            _domicilio_velacion = value
        End Set
    End Property

    Public Property Tel_fijo As String
        Get
            Return _tel_fijo
        End Get
        Set(value As String)
            _tel_fijo = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property

    Public Property Destino As String
        Get
            Return _destino
        End Get
        Set(value As String)
            _destino = value
        End Set
    End Property

    Public Property Fecha_hora_cotejo As String
        Get
            Return _fecha_hora_cotejo
        End Get
        Set(value As String)
            _fecha_hora_cotejo = value
        End Set
    End Property

    Public Property Oficialia As String
        Get
            Return _oficialia
        End Get
        Set(value As String)
            _oficialia = value
        End Set
    End Property

    Public Property Libro As String
        Get
            Return _libro
        End Get
        Set(value As String)
            _libro = value
        End Set
    End Property

    Public Property Acta As String
        Get
            Return _acta
        End Get
        Set(value As String)
            _acta = value
        End Set
    End Property

    Public Property Fecha_registro As String
        Get
            Return _fecha_registro
        End Get
        Set(value As String)
            _fecha_registro = value
        End Set
    End Property

    Public Property NombreCliente As String
        Get
            Return _nombreCliente
        End Get
        Set(value As String)
            _nombreCliente = value
        End Set
    End Property
End Class
