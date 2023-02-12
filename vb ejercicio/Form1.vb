Public Class Form1
    Sub cargarestado()
        With cbestado
            .Items.Add("Activo")
            .Items.Add("Inactivo")
        End With
    End Sub
    Sub limpiar()
        Textcodigo.Clear()
        Textproducto.Clear()
        Textprecio.Clear()
        Textcantidad.Clear()
    End Sub
    Function getcodigo()
        Return Textcodigo.Text
    End Function
    Function getproducto()
        Return Textproducto.Text
    End Function
    Function getprecio()
        Return Textprecio.Text
    End Function
    Function getcantidad()
        Return Textcantidad.Text
    End Function
    Function getestado()
        Return cbestado.SelectedItem
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarestado()
    End Sub

    Private Sub Btnguardar_Click(sender As Object, e As EventArgs) Handles Btnguardar.Click
        Dim oproducto As New CLProducto
        oproducto.codigo = getcodigo()
        oproducto.producto = getproducto()
        oproducto.cantidad = getcantidad()
        oproducto.precio = getprecio()
        oproducto.estado = getestado()
        oproducto.precio = calcularprecio(Textprecio.Text, Textcantidad.Text)
        ModVariables.producto.Add(oproducto)

        dgproducto.Rows.Add(getcodigo, getproducto, getcantidad, getprecio, getestado, calcularprecio(Textprecio.Text, Textcantidad.Text))
    End Sub

    Private Sub Btnnuevo_Click(sender As Object, e As EventArgs) Handles Btnnuevo.Click
        Call limpiar()
    End Sub

    Private Sub Btnbuscar_Click(sender As Object, e As EventArgs) Handles Btnbuscar.Click
        Dim oproducto As New CLProducto

        oproducto = buscarproducto(getcodigo)
        If oproducto.codigo = 0 Then
            MessageBox.Show("No existe")
            Exit Sub
        End If
        Textcodigo.Text = oproducto.codigo
        Textproducto.Text = oproducto.producto
        Textcantidad.Text = oproducto.cantidad
        Textprecio.Text = oproducto.precio
        cbestado.SelectedItem = oproducto.estado
    End Sub
End Class
