Module ModVariables
    Public producto As New List(Of CLProducto)
    Public Function buscarproducto(ByVal codigo As Integer) As CLProducto
        Dim miproducto As New CLProducto

        For Each miproducto In ModVariables.producto
            If miproducto.codigo = codigo Then
                Exit For
            End If
        Next
        Return miproducto
    End Function

    Public Function calcularprecio(ByVal precio As Double, cantidad As Integer) As Double
        Return precio * cantidad
    End Function
End Module
