Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Windows.Forms
Public Class PantallaPrincipal
    Implements IPantallaPrincipal
    Dim controlador As controladorPantallaPrincipal

    Public Sub Crear()
        controlador = New controladorPantallaPrincipal(Me)
    End Sub

    Public Sub Salir() Implements IPantallaPrincipal.Salir
        Me.Close()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.controlador.cerrar()
    End Sub

    Public Sub Gestionar() Implements IPantallaPrincipal.Gestionar
        Dim gestionProductos As New GestionDeProductos
        gestionProductos.Crear()
        gestionProductos.ShowDialog()
    End Sub

    Private Sub BtnGestProd_Click(sender As Object, e As EventArgs) Handles BtnGestProd.Click
        controlador.NuevaPantalla()
    End Sub
End Class