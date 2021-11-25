Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Windows.Forms

Public Class GestionDeProductos
    Implements IGestionProductos
    Dim controlador As ControladorGestionProductos

    Public Sub Crear()
        controlador = New ControladorGestionProductos(Me)

        'RUBRO
        Dim rubro As DataTable = generarDT()
        Dim listaRubro = Rubros()
        For Each r As Rubro In listaRubro
            rubro.Rows.Add(r.Nombre1, r.Id1)
        Next
        CBRubro.DisplayMember = "Text"
        CBRubro.ValueMember = "Value"
        CBRubro.DataSource = rubro

        'MARCA
        Dim marca As DataTable = generarDT()
        Dim listaMarca = Marcas()
        For Each m As Marca In listaMarca
            marca.Rows.Add(m.Nombre1, m.Id1)
        Next
        CBMarca.DisplayMember = "Text"
        CBMarca.ValueMember = "Value"
        CBMarca.DataSource = marca

        'COLOR
        Dim color As DataTable = generarDT()
        Dim listaColores = Colores()
        For Each col As Color In listaColores
            color.Rows.Add(col.Nombre1, col.Id1)
        Next
        CBColor.DisplayMember = "Text"
        CBColor.ValueMember = "Value"
        CBColor.DataSource = color

        'GANANCIA
        Dim ganancia As DataTable = generarDT()
        For i = 1 To 100
            ganancia.Rows.Add(i & "%", i)
        Next
        CBGanancia.DisplayMember = "Text"
        CBGanancia.ValueMember = "Value"
        CBGanancia.DataSource = ganancia

        'IVA
        Dim IVA As DataTable = generarDT()
        For i = 1 To 100
            IVA.Rows.Add(i & "%", i)
        Next
        CBIVA.DisplayMember = "Text"
        CBIVA.ValueMember = "Value"
        CBIVA.DataSource = IVA

        'LLENAR

        Me.txtNombre.Enabled = False
        Me.txtDescripcion.Enabled = False
        Me.CBMarca.Enabled = False
        Me.CBRubro.Enabled = False
        Me.txtCosto.Enabled = False
        Me.CBIVA.Enabled = False
        Me.CBGanancia.Enabled = False


    End Sub

    Public Function buscar(codigo As String) As String Implements IGestionProductos.buscar
        If codigo <> "" Then
            Dim producto As New Producto(codigo)
            Dim resultado As String = producto.Codigo_Existe(base.Productos)
            If resultado = True Then
                Me.txtNombre.Text = producto.Nombre1
                Me.txtDescripcion.Text = producto.Descripcion1
                Me.CBMarca.SelectedIndex = producto.MarcaId1
                Me.CBRubro.SelectedIndex = producto.RubroId1
                Me.txtCosto.Text = producto.Costo1
                Me.CBIVA.SelectedIndex = producto.IVA_PORCENTAJE1
                Me.CBGanancia.SelectedIndex = producto.Ganancia1
                Me.CBColor.Enabled = True
                llenarTalle(producto.RubroId1)

                Return "Este Codigo ya existe. Puedes añadir alguna especificacion"
            Else
                Me.txtNombre.Enabled = True
                Me.txtNombre.Text = ""
                Me.txtDescripcion.Enabled = True
                Me.txtDescripcion.Text = ""
                Me.CBMarca.Enabled = True
                Me.CBMarca.SelectedIndex = 0
                Me.CBRubro.Enabled = True
                Me.CBRubro.SelectedIndex = 0
                Me.txtCosto.Enabled = True
                Me.txtCosto.Text = ""
                Me.CBIVA.Enabled = True
                Me.CBIVA.SelectedIndex = 0
                Me.CBGanancia.Enabled = True
                Me.CBGanancia.SelectedIndex = 0

                Return ""
            End If
        Else
            Return "El campo esta vacio"
        End If
    End Function

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs)
        Dim codigo As String = txtCodigo.Text
        Dim respuesta As String = controlador.busqueda(codigo)
        If respuesta <> "" Then
            MsgBox(respuesta)
        End If
    End Sub

    Public Sub Cancelar() Implements IGestionProductos.Cancelar
        Me.Close()
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        controlador.Cerrar()
    End Sub

    Public Sub llenarTalle(rubroId As Integer)
        'TALLE
        Dim talle As DataTable = generarDT()
        Dim listaTalle = Talles()
        For Each tal As Talle In listaTalle
            If tal.RubroId1 = rubroId Then
                talle.Rows.Add(tal.Nombre1, tal.Id1)
            End If
        Next
        CBTalle.DisplayMember = "Text"
        CBTalle.ValueMember = "Value"
        CBTalle.DataSource = talle
    End Sub

    Public Function Aceptar(codigo As String, nombre As String, descripcion As String, costo As Double, iva As Integer, ganancia As Integer, rubro As Integer, marca As Integer, color As Integer, talle As Integer) As String Implements IGestionProductos.Aceptar

        If codigo <> "" And nombre <> "" And descripcion <> "" And costo > 0 And iva > 0 And ganancia > 0 And rubro > 0 And marca > 0 And talle > 0 And color > 0 Then
            Dim producto As New Producto(codigo, nombre, descripcion, costo, iva, ganancia, rubro, marca)
            Dim existe As Boolean = producto.Codigo_Existe(Productos)
            If existe = True Then
                Dim especificacion As New EspecificacionProducto(codigo, color, talle)
                existe = especificacion.Especificacion_Existe(base.EspecificacionesDeProductos)

                If existe = True Then
                    Return "El producto y especificacion Ingresados, ya existen"
                Else
                    Return "Se ha agregado una especificacion a " + producto.Codigo1
                End If
            Else
                Return "El producto se creo correctamente"
            End If
        Else
            Return "Complete los campos vacios"
        End If
    End Function

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim codigo As String = Me.txtCodigo.Text
        Dim nombre As String = Me.txtNombre.Text
        Dim descripcion As String = Me.txtDescripcion.Text
        Dim costo As Double = Me.txtCosto.Text
        Dim iva As Integer = Me.CBIVA.SelectedIndex
        Dim ganancia As Integer = Me.CBGanancia.SelectedIndex
        Dim rubro As Integer = Me.CBRubro.SelectedIndex
        Dim marca As Integer = Me.CBMarca.SelectedIndex
        Dim color As Integer = Me.CBColor.SelectedIndex
        Dim talle As Integer = Me.CBTalle.SelectedIndex

        Dim respuesta As String = controlador.Guardar(codigo, nombre, descripcion, costo, iva, ganancia, rubro, marca, color, talle)
        MsgBox(respuesta)
    End Sub
End Class