Public Class Talle

    Private id As Integer
    Private nombre As String
    Private descripcion As String
    Private rubroId As Integer

    Public Sub New(id As Integer, nombre As String, descripcion As String, rubroId As Integer)
        Me.Id1 = id
        Me.Nombre1 = nombre
        Me.Descripcion1 = descripcion
        Me.rubroId = rubroId
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

    Public Property RubroId1 As Integer
        Get
            Return rubroId
        End Get
        Set(value As Integer)
            rubroId = value
        End Set
    End Property
End Class
