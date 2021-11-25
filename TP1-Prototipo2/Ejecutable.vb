Module Ejecutable
    Public Sub Main()
        Dim iniciosesion As New inicioSesion
        iniciosesion.Crear()
        iniciosesion.ShowDialog()
    End Sub
End Module
