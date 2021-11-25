Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TP1_Prototipo2

<TestClass()> Public Class InicioSesionTest

    'ESTA PRUEBA DEMUESTRA EL CORRECTO INICIO DE SESION
    <TestMethod()> Public Sub Inicio_De_Sesion_Normal()
        Dim iniciosesion As New inicioSesion
        iniciosesion.Crear()

        Dim legajo As String = "46346"
        Dim contraseña As String = "12913231806"
        Dim respuesta As String = iniciosesion.Aceptar(legajo, contraseña)

        Assert.AreEqual("Bienvenido: Nicolas Colque", respuesta)
    End Sub

    'ESTA PRUEBA ES PARA VER QUE PASA SI INGRESO UN LEGAJO O CONTRASEÑA INVALIDOS
    <TestMethod()> Public Sub Ingreso_De_Usuario_Inexistente()
        Dim iniciosesion As New inicioSesion
        iniciosesion.Crear()

        Dim legajo As String = "47444"
        Dim contraseña As String = "contraseñaFALSA"
        Dim respuesta As String = iniciosesion.Aceptar(legajo, contraseña)

        Assert.AreEqual("Usuario No Encontrado", respuesta)

    End Sub

    'ESTA PRUEBA ES PARA VER QUE PASA SI DEJO EL CAMPO DE LA CONTRASEÑA VACIO
    <TestMethod()> Public Sub Ingreso_De_Campo_Vacio()
        Dim iniciosesion As New inicioSesion
        iniciosesion.Crear()
        Dim respuesta As String
        respuesta = iniciosesion.Aceptar("47444", "")
        Assert.AreEqual("Al menos 1 de los campos está vacios", respuesta)

        respuesta = iniciosesion.Aceptar("", "contraseñaFALSA")
        Assert.AreEqual("Al menos 1 de los campos está vacios", respuesta)
    End Sub

End Class