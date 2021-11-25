Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP1_Prototipo2

<TestClass()> Public Class GestionDeProductosTest

    'ESTA PRUEBA MUESTRA QUE PASA SI SE INTENTA REGISTRAR UN PRODUCTO Y
    'ESPECIFICACION EXISTENTE
    <TestMethod()> Public Sub Especificacion_Y_Producto_Existentes()
        Dim gestionProductos As New GestionDeProductos
        gestionProductos.Crear()

        Dim codigo As String = "Vest44"
        Dim nombre As String = "Vestido"
        Dim descripcion As String = "Vestidos de Tela Suave"
        Dim costo As Double = 12800.5
        Dim iva As Integer = 21
        Dim ganancia As Integer = 50
        Dim rubro As Integer = 2
        Dim marca As Integer = 2
        Dim color As Integer = 1
        Dim talle As Integer = 5

        Dim respuesta = gestionProductos.Aceptar(codigo, nombre, descripcion, costo, iva, ganancia, rubro, marca, color, talle)
        Assert.AreEqual("El producto y especificacion Ingresados, ya existen", respuesta)
    End Sub


    'ESTA PRUEBA MUESTRA QUE PASA SI SE QUIERE REGISTRAR UNA ESPECIFICACION
    'DE UN PRODUCTO EXISTENTE
    <TestMethod()> Public Sub Especificacion_De_Producto_Existente()
        Dim gestionProductos As New GestionDeProductos
        gestionProductos.Crear()

        Dim codigo As String = "Vest44"
        Dim nombre As String = "Vestido"
        Dim descripcion As String = "Vestidos de Tela Suave"
        Dim costo As Double = 12800.5
        Dim iva As Integer = 21
        Dim ganancia As Integer = 50
        Dim rubro As Integer = 2
        Dim marca As Integer = 2
        Dim color As Integer = 2
        Dim talle As Integer = 6

        Dim respuesta = gestionProductos.Aceptar(codigo, nombre, descripcion, costo, iva, ganancia, rubro, marca, color, talle)
        Assert.AreEqual("Se ha agregado una especificacion a Vest44", respuesta)
    End Sub

    'ESTA PRUEBA MUESTRA QUE PASA SI OLVIDO EL INGRESO DE ALGUN DATO
    'EN ESTE CASO OMITI EL CODIGO, NOMBRE DESCRIPCION Y GANANCIA
    <TestMethod()> Public Sub TestMethod1()
        Dim gestionProductos As New GestionDeProductos
        gestionProductos.Crear()

        Dim codigo As String = ""
        Dim nombre As String = ""
        Dim descripcion As String = ""
        Dim costo As Double = 13000.55
        Dim iva As Integer = 20
        Dim ganancia As Integer = -4
        Dim rubro As Integer = 1
        Dim marca As Integer = 3
        Dim color As Integer = 1
        Dim talle As Integer = 2

        Dim respuesta = gestionProductos.Aceptar(codigo, nombre, descripcion, costo, iva, ganancia, rubro, marca, color, talle)
        Assert.AreEqual("Complete los campos vacios", respuesta)

    End Sub

End Class