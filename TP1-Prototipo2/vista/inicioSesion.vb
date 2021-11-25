Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms

Public Class inicioSesion
    Implements IInicioSesion
    Dim controlador As ControladorInicioSesion

    Public Sub Crear()
        controlador = New ControladorInicioSesion(Me)
    End Sub

    Public Sub Check() Implements IInicioSesion.Check
        Dim usoActual As Boolean = CBOcultar.Checked
        If usoActual = True Then
            txtContraseña.UseSystemPasswordChar = False
            txtContraseña.PasswordChar = ""
        Else
            txtContraseña.UseSystemPasswordChar = True
            txtContraseña.PasswordChar = "*"
        End If
    End Sub

    Public Function Aceptar(legajo As String, contraseña As String) As String Implements IInicioSesion.Aceptar
        Dim respuesta As String

        If contraseña <> "" And legajo <> "" Then
            Dim usuario As New Empleado(legajo, contraseña)
            Dim resultado = usuario.Registrado(base.Empleados)

            If resultado = True Then
                respuesta = "Bienvenido: " + usuario.Nombre1
            Else
                respuesta = "Usuario No Encontrado"
            End If

        Else
            respuesta = "Al menos 1 de los campos está vacios"
        End If

        Return respuesta
    End Function

    Public Sub Cerrar() Implements IInicioSesion.Cerrar
        Me.Close()
    End Sub

    Private Sub CBOcultar_CheckedChanged(sender As Object, e As EventArgs) Handles CBOcultar.CheckedChanged
        controlador.CBOcultar()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim legajo As String = txtLegajo.Text
        Dim contraseña As String = txtContraseña.Text
        Dim respuesta = controlador.Aceptar(legajo, contraseña)
        Me.Dispose()
        MsgBox(respuesta)
        Dim pantallaPrincipal As New PantallaPrincipal
        pantallaPrincipal.Crear()
        pantallaPrincipal.ShowDialog()

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        controlador.Salir()
    End Sub

End Class