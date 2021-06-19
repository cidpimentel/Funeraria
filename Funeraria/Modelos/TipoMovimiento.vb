Public Class TipoMovimiento

    Private _id As Integer
    Private _movimiento As String

    Public Sub New()
    End Sub

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Movimiento As String
        Get
            Return _movimiento
        End Get
        Set(value As String)
            _movimiento = value
        End Set
    End Property

    Public Sub New(id As Integer, movimiento As String)
        Me.id = id
        Me.movimiento = movimiento
    End Sub




End Class
