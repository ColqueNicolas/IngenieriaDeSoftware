Imports System.Windows.Forms

Public Class controladorPantallaPrincipal
    Dim IPantallaPrincipal As IPantallaPrincipal

    Public Sub New(IPantallaPrincipal As IPantallaPrincipal)
        Me.IPantallaPrincipal = IPantallaPrincipal
    End Sub

    Public Sub cerrar()
        Me.IPantallaPrincipal.Salir()
    End Sub

    Public Sub NuevaPantalla()
        Me.IPantallaPrincipal.Gestionar()
    End Sub

End Class