Public Class EspecificacionProducto

    Private id As Integer
    Private productoId As String
    Private colorId As Integer
    Private talleId As Integer

    Public Sub New(productoId As String, colorId As Integer, talleId As Integer)
        Me.productoId = productoId
        Me.colorId = colorId
        Me.talleId = talleId
    End Sub

    Public Sub New(id As Integer, productoId As String, colorId As Integer, talleId As Integer)
        Me.id = id
        Me.productoId = productoId
        Me.colorId = colorId
        Me.talleId = talleId
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property ProductoId1 As String
        Get
            Return productoId
        End Get
        Set(value As String)
            productoId = value
        End Set
    End Property

    Public Property ColorId1 As Integer
        Get
            Return colorId
        End Get
        Set(value As Integer)
            colorId = value
        End Set
    End Property

    Public Property TalleId1 As Integer
        Get
            Return talleId
        End Get
        Set(value As Integer)
            talleId = value
        End Set
    End Property

    Public Function Especificacion_Existe(listaEspecificaciones As Object) As Boolean

        For Each especificacion As EspecificacionProducto In listaEspecificaciones
            If especificacion.productoId = Me.productoId And especificacion.colorId = Me.colorId And especificacion.talleId = Me.talleId Then
                Return True
            End If
        Next
        Return False

    End Function

End Class
