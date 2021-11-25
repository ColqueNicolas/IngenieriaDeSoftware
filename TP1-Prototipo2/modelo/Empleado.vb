Imports System.Collections.Generic
Public Class Empleado
    Private id As Integer
    Private nombre As String
    Private legajo As String
    Private contraseña As String

    Public Sub New(id As Integer, nombre As String, legajo As String, contraseña As String)
        Me.id = id
        Me.nombre = nombre
        Me.legajo = legajo
        Me.contraseña = contraseña
    End Sub

    Public Sub New(legajo As Integer, contraseña As String)
        Me.legajo = legajo
        Me.contraseña = contraseña
    End Sub

    Public Property Id1 As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
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

    Public Property Legajo1 As String
        Get
            Return legajo
        End Get
        Set(value As String)
            legajo = value
        End Set
    End Property

    Public Property Contraseña1 As String
        Get
            Return contraseña
        End Get
        Set(value As String)
            contraseña = value
        End Set
    End Property

    Public Function Registrado(listaEmpleados As Object) As Boolean

        For Each empleado As Empleado In listaEmpleados
            If empleado.Legajo1 = Legajo1 And empleado.Contraseña1 = Contraseña1 Then
                Me.Id1 = empleado.Id1
                Me.Nombre1 = empleado.Nombre1
                Return True
            End If
        Next

        Return False
    End Function

End Class
