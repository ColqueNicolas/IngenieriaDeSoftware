Imports System.Collections.Generic
Imports System.Data

Module base
    Public Function Empleados()
        Dim listaEmpleados As New List(Of Empleado)
        listaEmpleados.Add(New Empleado(1, "Nicolas Colque", 46346, "12913231806"))
        listaEmpleados.Add(New Empleado(2, "Johnny Bravo", 46271, "Oh,NENA!"))
        listaEmpleados.Add(New Empleado(3, "Kyle Strada", 45551, "kamenRIDER555"))
        Return listaEmpleados
    End Function

    Public Function Colores()
        Dim listaColores As New List(Of Color)
        listaColores.Add(New Color(1, "Blanco"))
        listaColores.Add(New Color(2, "Negro"))
        listaColores.Add(New Color(3, "Azul"))
        listaColores.Add(New Color(4, "Rojo"))
        Return listaColores
    End Function

    Public Function Marcas()
        Dim listaMarcas As New List(Of Marca)
        listaMarcas.Add(New Marca(1, "Nike", "Empresa multinacional estadounidense dedicada al diseño, desarrollo, fabricación y comercialización de equipamiento deportivo"))
        listaMarcas.Add(New Marca(2, "Adidas", "Compañía multinacional alemana fundada en 1949 dedicada a la fabricación de equipamiento deportivo y productos de moda. "))
        listaMarcas.Add(New Marca(3, "Under Armour", "Empresa estadounidense de ropa y accesorios deportivos. La compañía vende ropa deportiva y de vestimenta informal.​"))
        listaMarcas.Add(New Marca(4, "Gucci", "Gucci es una firma italiana de productos de lujo con sede en Florencia, Italia"))
        listaMarcas.Add(New Marca(5, "Cartier", "Fábrica francesa de relojes y joyas, fundada en 1847 por Louis-François Cartier, perteneciente al grupo suizo de bienes de lujo Richemont."))
        Return listaMarcas
    End Function

    Public Function Rubros()
        Dim listaRubros As New List(Of Rubro)
        listaRubros.Add(New Rubro(1, "Calzado", "Todo tipo de calzados para los pies"))
        listaRubros.Add(New Rubro(2, "Ropa", "Ropa SOLO para Hombre y Mujer"))
        Return listaRubros
    End Function

    Public Function Talles()
        Dim listaTalles As New List(Of Talle)
        listaTalles.Add(New Talle(1, "A", "Ancho de Pie: Angosto", 1))
        listaTalles.Add(New Talle(2, "B", "Ancho de Pie: Medio / Normal", 1))
        listaTalles.Add(New Talle(3, "E", "Ancho de Pie: Ancho", 1))
        listaTalles.Add(New Talle(4, "XS", "Cuello (cm): 33 - 34" + Chr(13) + Chr(10) + "Pecho (cm): 84 - 86" + Chr(13) + Chr(10) + "Manga (cm): 80 - 81" + Chr(13) + Chr(10) + "Cintura (cm): 68 - 71", 2))
        listaTalles.Add(New Talle(5, "S", "Cuello (cm):  36 - 37" + Chr(13) + Chr(10) + "Pecho (cm): 89 - 94" + Chr(13) + Chr(10) + "Manga (cm): 82 - 94" + Chr(13) + Chr(10) + "Cintura (cm): 73 - 79", 2))
        listaTalles.Add(New Talle(6, "M", "Cuello (cm): 38 - 39" + Chr(13) + Chr(10) + "Pecho (cm): 96 - 102" + Chr(13) + Chr(10) + "Manga (cm): 85 - 86" + Chr(13) + Chr(10) + "Cintura (cm): 81 - 86", 2))
        listaTalles.Add(New Talle(7, "L", "Cuello (cm): 40 - 42" + Chr(13) + Chr(10) + "Pecho (cm): 107 - 112" + Chr(13) + Chr(10) + "Manga (cm): 87 - 89" + Chr(13) + Chr(10) + "Cintura (cm): 91 - 97", 2))
        listaTalles.Add(New Talle(8, "XL", "Cuello (cm):  43 - 45" + Chr(13) + Chr(10) + "Pecho (cm): 116 - 122" + Chr(13) + Chr(10) + "Manga (cm): 90 - 91" + Chr(13) + Chr(10) + "Cintura (cm): 101 - 107", 2))
        listaTalles.Add(New Talle(9, "X", "Ancho de Pie: Adicional", 1))
        Return listaTalles
    End Function

    Public Function Productos()
        Dim listaProductos As New List(Of Producto)
        listaProductos.Add(New Producto("Zap33", "Zapatillas Deportivas", "Zapatillas Deportivas para hombres rudos", 3400.5, 21, 30, 1, 4))
        listaProductos.Add(New Producto("Vest44", "Vestido", "Vestidos de Tela Suave", 12800.5, 21, 50, 2, 2))
        listaProductos.Add(New Producto("Traj88", "Traje", "Traje de Oficina", 12800.5, 21, 45, 2, 3))
        Return listaProductos
    End Function

    Public Function EspecificacionesDeProductos()
        Dim listaEspecificaciones As New List(Of EspecificacionProducto)
        listaEspecificaciones.Add(New EspecificacionProducto(1, "Zap33", 4, 9))
        listaEspecificaciones.Add(New EspecificacionProducto(2, "Zap33", 1, 2))
        listaEspecificaciones.Add(New EspecificacionProducto(3, "Vest44", 3, 3))
        listaEspecificaciones.Add(New EspecificacionProducto(4, "Vest44", 1, 5))
        listaEspecificaciones.Add(New EspecificacionProducto(5, "Vest44", 3, 8))
        listaEspecificaciones.Add(New EspecificacionProducto(6, "Traj88", 1, 4))
        listaEspecificaciones.Add(New EspecificacionProducto(7, "Traj88", 2, 6))
        Return listaEspecificaciones
    End Function

    '*******************
    Public Function generarDT() As DataTable
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))
        tb.Rows.Add("", 0)
        generarDT = tb
        Return generarDT
    End Function

End Module
