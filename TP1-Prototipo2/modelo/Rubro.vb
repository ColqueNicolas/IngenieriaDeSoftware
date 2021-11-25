Public Class Rubro

    Private id As Integer
    Private nombre As String
    Private descripcion As String

    Public Sub New(id As Integer, nombre As String, descripcion As String)
        Me.Id1 = id
        Me.Nombre1 = nombre
        Me.Descripcion1 = descripcion
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Descripcion1 As String
        Get
            Return descripcion
        End Get
        Set(value As String)
            descripcion = value
        End Set
    End Property

End Class
