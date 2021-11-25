Public Class Color
    Private id As Integer
    Private nombre As String

    Public Sub New(id As Integer, nombre As String)
        Me.Id1 = id
        Me.Nombre1 = nombre
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
End Class
