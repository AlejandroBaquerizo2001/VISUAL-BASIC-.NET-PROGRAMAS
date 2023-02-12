'Problemática:
'Crear un programa que permita ingresar el nombre de un usuario en un Inputbox y después 
'mostrar el saludo respectivo en un MessageBox.
'Además mostrar un botón de salir que pregunte y seleccione la opción de salir antes 
'de cerrar la aplicación
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btningresar_Click(sender As Object, e As EventArgs) Handles Btningresar.Click
        'Declaracion de variables
        Dim nombre As String
        'Entrada de datos
        nombre = InputBox("Ingrese Nombre", "Registro de Datos", "Nombre", 100, 0)
        MessageBox.Show("Bienvenido Usuario: " & nombre, "Registro de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("Realmente desea salir de la APP?", "Salir de la App", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If (opcion = DialogResult.Yes) Then
            Me.Close()

        End If
    End Sub
End Class
