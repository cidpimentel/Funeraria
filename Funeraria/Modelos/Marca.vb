﻿Public Class Marca

    Private _id As Integer
    Private _descripcion As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
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

    Public Sub New(id As Integer, descripcion As String)
        Me.id = id
        Me.descripcion = descripcion
    End Sub

    Public Sub New()
    End Sub


End Class
