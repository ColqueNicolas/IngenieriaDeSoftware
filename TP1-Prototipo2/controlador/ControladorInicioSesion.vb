Imports System.Windows.Forms

Public Class ControladorInicioSesion
    Dim IInicioSesion As IInicioSesion

    Public Sub New(inicioSesion As IInicioSesion)
        Me.IInicioSesion = inicioSesion
    End Sub

    Public Sub CBOcultar()
        Me.IInicioSesion.Check()
    End Sub

    Public Function Aceptar(legajo As Integer, contraseña As String) As String
        Dim respuesta = Me.IInicioSesion.Aceptar(legajo, contraseña)
        Return respuesta
    End Function

    Public Sub Salir()
        Me.IInicioSesion.Cerrar()
    End Sub
End Class
