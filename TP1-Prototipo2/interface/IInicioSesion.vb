Public Interface IInicioSesion
    Sub Check()

    Function Aceptar(legajo As String, contraseña As String) As String

    Sub Cerrar()

End Interface
