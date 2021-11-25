Public Class Producto

    Private codigo As String
    Private nombre As String
    Private descripcion As String
    Private costo As Double
    Private IVA_PORCENTAJE As Integer
    Private ganancia As Integer
    Private rubroId As Integer
    Private marcaId As Integer

    Public Sub New(codigo As String)
        Me.codigo = codigo
    End Sub

    Public Sub New(codigo As String, nombre As String, descripcion As String, costo As Double, iVA_PORCENTAJE As Integer, ganancia As Integer, rubroId As Integer, marcaId As Integer)
        Me.codigo = codigo
        Me.nombre = nombre
        Me.descripcion = descripcion
        Me.costo = costo
        Me.IVA_PORCENTAJE = iVA_PORCENTAJE
        Me.ganancia = ganancia
        Me.rubroId = rubroId
        Me.marcaId = marcaId
    End Sub

    Public Property Codigo1 As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
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

    Public Property Costo1 As Double
        Get
            Return costo
        End Get
        Set(value As Double)
            costo = value
        End Set
    End Property

    Public Property IVA_PORCENTAJE1 As Integer
        Get
            Return IVA_PORCENTAJE
        End Get
        Set(value As Integer)
            IVA_PORCENTAJE = value
        End Set
    End Property

    Public Property Ganancia1 As Integer
        Get
            Return ganancia
        End Get
        Set(value As Integer)
            ganancia = value
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

    Public Property MarcaId1 As Integer
        Get
            Return marcaId
        End Get
        Set(value As Integer)
            marcaId = value
        End Set
    End Property

    Public Function Calcular_Precio_Venta() As Double
        Dim netoGravado, IVA, precioVenta As Double
        netoGravado = Me.costo + Me.costo * Me.ganancia / 100
        IVA = netoGravado + netoGravado * Me.IVA_PORCENTAJE / 100
        precioVenta = netoGravado + IVA
        Return precioVenta
    End Function

    Public Function Codigo_Existe(listaProductos As Object) As Boolean

        For Each producto As Producto In listaProductos
            If producto.Codigo1 = Me.Codigo1 Then
                Me.Nombre1 = producto.Nombre1
                Me.Descripcion1 = producto.Descripcion1
                Me.Costo1 = producto.Costo1
                Me.IVA_PORCENTAJE1 = producto.IVA_PORCENTAJE1
                Me.Ganancia1 = producto.Ganancia1
                Me.RubroId1 = producto.RubroId1
                Me.MarcaId1 = producto.MarcaId1
                Return True
            End If
        Next

        Return False

    End Function
End Class
