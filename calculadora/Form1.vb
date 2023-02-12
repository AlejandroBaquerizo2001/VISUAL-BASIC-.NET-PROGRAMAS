Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    'Definimos nuestras variables para nuestras operaciones
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    'Definimos cada funcion que hara nuestros botones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "0"
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        EvaluarRestriccionesParaConcatenar()
        If InStr(TextBox1.Text, ".", CompareMethod.Text) = 0 Then
            TextBox1.Text &= "."
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "1"
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "2"
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "3"
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "4"
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "5"
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "6"
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "7"
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "8"
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        EvaluarRestriccionesParaConcatenar()
        TextBox1.Text &= "9"
    End Sub

    'Limpiamos the caja de texto
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub
    'Definimos nuestros botones de operaciones +, -, *, /.
    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonResta_Click(sender As Object, e As EventArgs) Handles ButtonResta.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonMultiplicar_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicar.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonResultado_Click(sender As Object, e As EventArgs) Handles ButtonResultado.Click
        EvaluayHazOperacion()
        Operacion = " "
    End Sub
    'Declaramos una sentencia que evalue y realice la operacion cual sea elegida
    Public Sub EvaluayHazOperacion()
        SePresionaOperador = True
        Valor2 = Val(TextBox1.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            TextBox1.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub
    'Declararemos otra sentencia para evaluar las restricciones al momento de realizar cada operacion
    Public Sub EvaluarRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TextBox1.Text = ""
            SePresionaOperador = False
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
