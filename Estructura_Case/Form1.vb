'Problema: Ingresar un número por teclado y determinar su representación en un día
'de la semana.
'Ej: Si se ingresa 3 debera mostrar miércoles, si ingresa 7 mostrará domingo; pero si no 
'ingresa un número fuera del rango entre 1 y 7 mostrar el mensaje"Error Intente con un nuevo
''nuevo numero"
Public Class Form1
    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        'Declaración de variables
        Dim num As Integer
        Dim dia As String
        'Entrada de datos
        num = Val(Textnumero.Text)
        'Proceso
        Select Case (num)
            Case 1
                dia = "Lunes"
            Case 2
                dia = "Martes"
            Case 3
                dia = "Miercoles"
            Case 4
                dia = "Jueves"
            Case 5
                dia = "Viernes"
            Case 6
                dia = "Sábado"
            Case 7
                dia = "Domingo"
            Case Else
                dia = "Error intente con un nuevo número"
        End Select
        'Salida de información
        Textdia.Text = dia
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Textdia.Clear()
        Textnumero.Clear()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class
