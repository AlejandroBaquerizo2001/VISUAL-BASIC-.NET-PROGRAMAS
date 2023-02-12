'Problematica de ERROR PROVIDER Y VALIDACIONES
'Crear un programa que permita ingresar de manera obligatoria los nombres, la edad y el salario de una persona;
'además todos los campos de texto deben de tener un mensaje emergente que ayude al usuario final con el contenido
'que debe ingresar.
Imports System.ComponentModel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Try
            If Me.ValidateChildren And TextNombre.Text <> String.Empty And Val(TextEdad.Text) - Int(Val(TextEdad.Text)) = 0 And TextSalario.Text <> String.Empty Then
                MessageBox.Show("Datos registrados correctamente", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Ingrese correctamente algunos datos remarcados", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TextNombre_TextChanged(sender As Object, e As EventArgs) Handles TextNombre.TextChanged

    End Sub

    Private Sub TextNombre_Validating(sender As Object, e As CancelEventArgs) Handles TextNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese el salario este dato es obligatorio")
        End If
    End Sub

    Private Sub TextEdad_TextChanged(sender As Object, e As EventArgs) Handles TextEdad.TextChanged

    End Sub

    Private Sub TextEdad_Validating(sender As Object, e As CancelEventArgs) Handles TextEdad.Validating
        If (Val(TextEdad.Text) - Int(Val(TextEdad.Text)) = 0) Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Ingrese una edad valida, este dato es obligatorio")
        End If
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        TextEdad.Clear()
        TextSalario.Clear()
        TextNombre.Clear()
        TextDescripcion.Clear()
    End Sub

    Private Sub lblSalir_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblSalir.LinkClicked
        Me.Close()
    End Sub
End Class
