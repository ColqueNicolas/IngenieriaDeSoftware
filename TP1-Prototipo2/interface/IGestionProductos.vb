Public Interface IGestionProductos
    Function buscar(codigo As String) As String

    Sub Cancelar()

    Function Aceptar(codigo As String, nombre As String, descripcion As String, costo As Double, iva As Integer, ganancia As Integer, rubro As Integer, marca As Integer, color As Integer, talle As Integer) As String


End Interface
