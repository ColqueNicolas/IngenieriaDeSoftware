Imports System.Windows.Forms

Public Class ControladorGestionProductos
    Dim IGestionProductos As IGestionProductos

    Public Sub New(IGestionProductos As IGestionProductos)
        Me.IGestionProductos = IGestionProductos
    End Sub

    Public Function busqueda(codigo As String) As String
        Dim respuesta As String = IGestionProductos.buscar(codigo)
        Return respuesta
    End Function

    Public Sub Cerrar()
        Me.IGestionProductos.Cancelar()
    End Sub

    Public Function Guardar(codigo As String, nombre As String, descripcion As String, costo As Double, iva As Integer, ganancia As Integer, rubro As Integer, marca As Integer, color As Integer, talle As Integer) As String
        Dim respuesta As String = Me.IGestionProductos.Aceptar(codigo, nombre, descripcion, costo, iva, ganancia, rubro, marca, color, talle)
        Return respuesta
    End Function

End Class
