Imports System.Data
Imports System.Text.RegularExpressions

Public Class Form1
    Private pantallaTexto As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pantallauno.Items.Clear()
        pantallados.Items.Clear()
    End Sub

    Private Sub AgregarNumero(valor As String)
        pantallaTexto &= valor
        ActualizarPantalla()
    End Sub

    Private Sub Bnt_num0_Click(sender As Object, e As EventArgs) Handles Bnt_num0.Click
        AgregarNumero("0")
    End Sub
    Private Sub Bnt_num1_Click(sender As Object, e As EventArgs) Handles Bnt_num1.Click
        AgregarNumero("1")
    End Sub
    Private Sub Bnt_num2_Click(sender As Object, e As EventArgs) Handles Bnt_num2.Click
        AgregarNumero("2")
    End Sub
    Private Sub Bnt_num3_Click(sender As Object, e As EventArgs) Handles Bnt_num3.Click
        AgregarNumero("3")
    End Sub
    Private Sub Bnt_num4_Click(sender As Object, e As EventArgs) Handles Bnt_num4.Click
        AgregarNumero("4")
    End Sub
    Private Sub Bnt_num5_Click(sender As Object, e As EventArgs) Handles Bnt_num5.Click
        AgregarNumero("5")
    End Sub
    Private Sub Bnt_num6_Click(sender As Object, e As EventArgs) Handles Bnt_num6.Click
        AgregarNumero("6")
    End Sub
    Private Sub Bnt_num7_Click(sender As Object, e As EventArgs) Handles Bnt_num7.Click
        AgregarNumero("7")
    End Sub
    Private Sub Bnt_num8_Click(sender As Object, e As EventArgs) Handles Bnt_num8.Click
        AgregarNumero("8")
    End Sub
    Private Sub Bnt_num9_Click(sender As Object, e As EventArgs) Handles Bnt_num9.Click
        AgregarNumero("9")
    End Sub

    Private Sub AgregarOperacion(op As String)
        If pantallaTexto <> "" Then
            pantallaTexto &= op
            ActualizarPantalla()
        End If
    End Sub

    Private Sub suma_Click(sender As Object, e As EventArgs) Handles suma.Click
        AgregarOperacion("+")
    End Sub
    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        AgregarOperacion("-")
    End Sub
    Private Sub multiplica_Click(sender As Object, e As EventArgs) Handles multiplica.Click
        AgregarOperacion("*")
    End Sub
    Private Sub divide_Click(sender As Object, e As EventArgs) Handles divide.Click
        AgregarOperacion("/")
    End Sub

    Private Sub Btnparenteci1_Click(sender As Object, e As EventArgs) Handles Btnparenteci1.Click
        pantallaTexto &= "("
        ActualizarPantalla()
    End Sub
    Private Sub Btnparenteci2_Click(sender As Object, e As EventArgs) Handles Btnparenteci2.Click
        pantallaTexto &= ")"
        ActualizarPantalla()
    End Sub

    Private Function PrepararExpresion(expresion As String) As String
        Dim nuevoTexto As String = Regex.Replace(expresion, "\)\(", ")*(")
        nuevoTexto = Regex.Replace(nuevoTexto, "\)(\d)", ")*$1")
        nuevoTexto = Regex.Replace(nuevoTexto, "(\d)\(", "$1*(")
        Return nuevoTexto
    End Function

    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click
        Try
            Dim dt As New DataTable()
            Dim expresionPreparada = PrepararExpresion(pantallaTexto)
            Dim resultado = dt.Compute(expresionPreparada, "")
            pantallados.Items.Clear()
            pantallados.Items.Add(resultado.ToString())
        Catch ex As Exception
            MessageBox.Show("Expresión inválida")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pantallaTexto = ""
        pantallauno.Items.Clear()
        pantallados.Items.Clear()
    End Sub

    Private Sub Btn_elimina_caracter_Click(sender As Object, e As EventArgs) Handles Btn_elimina_caracter.Click
        If pantallaTexto.Length > 0 Then
            pantallaTexto = pantallaTexto.Substring(0, pantallaTexto.Length - 1)
            ActualizarPantalla()
        End If
    End Sub

    Private Sub ActualizarPantalla()
        pantallauno.Items.Clear()
        pantallauno.Items.Add(pantallaTexto)
    End Sub
End Class