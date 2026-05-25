Imports System.Data
Imports System.Text.RegularExpressions

Public Class Form1
    Private pantallaTexto As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pantallauno.Items.Clear()
        pantallados.Items.Clear()
    End Sub

    '========================
    ' AGREGAR NÚMEROS
    '========================
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

    '========================
    ' PUNTO DECIMAL
    '========================
    Private Sub btn_decimal_Click(sender As Object, e As EventArgs) Handles btn_decimal.Click
        pantallaTexto &= "."
        ActualizarPantalla()
    End Sub

    '========================
    ' OPERACIONES
    '========================
    Private Sub AgregarOperacion(op As String)

        If pantallaTexto <> "" Then

            'Evita repetir operadores
            Dim ultimo As String = pantallaTexto.Substring(pantallaTexto.Length - 1)

            If "+-*/".Contains(ultimo) Then
                pantallaTexto = pantallaTexto.Substring(0, pantallaTexto.Length - 1)
            End If

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

    '========================
    ' PARÉNTESIS
    '========================
    Private Sub Btnparenteci1_Click(sender As Object, e As EventArgs) Handles Btnparenteci1.Click
        pantallaTexto &= "("
        ActualizarPantalla()
    End Sub

    Private Sub Btnparenteci2_Click(sender As Object, e As EventArgs) Handles Btnparenteci2.Click
        pantallaTexto &= ")"
        ActualizarPantalla()
    End Sub

    '========================
    ' PREPARAR EXPRESIÓN
    '========================
    Private Function PrepararExpresion(expresion As String) As String

        Dim nuevoTexto As String = expresion

        'Multiplicación implícita
        nuevoTexto = Regex.Replace(nuevoTexto, "\)\(", ")*(")
        nuevoTexto = Regex.Replace(nuevoTexto, "\)(\d)", ")*$1")
        nuevoTexto = Regex.Replace(nuevoTexto, "(\d)\(", "$1*(")

        Return nuevoTexto

    End Function

    '========================
    ' IGUAL
    '========================
    Private Sub igual_Click(sender As Object, e As EventArgs) Handles igual.Click

        Try

            If pantallaTexto.Trim = "" Then
                MessageBox.Show("Ingrese una expresión")
                Exit Sub
            End If

            Dim expresionPreparada As String = PrepararExpresion(pantallaTexto)

            'Validar división entre cero
            If expresionPreparada.Contains("/0") Then
                MessageBox.Show("No se puede dividir entre cero")
                Exit Sub
            End If

            Dim dt As New DataTable()

            Dim resultado = dt.Compute(expresionPreparada, "")

            pantallados.Items.Clear()

            pantallados.Items.Add(resultado.ToString())

        Catch ex As Exception

            MessageBox.Show("Expresión inválida")

        End Try

    End Sub

    '========================
    ' LIMPIAR
    '========================
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        pantallaTexto = ""

        pantallauno.Items.Clear()

        pantallados.Items.Clear()

    End Sub

    '========================
    ' BORRAR ÚLTIMO CARACTER
    '========================
    Private Sub Btn_elimina_caracter_Click(sender As Object, e As EventArgs) Handles Btn_elimina_caracter.Click

        If pantallaTexto.Length > 0 Then

            pantallaTexto = pantallaTexto.Substring(0, pantallaTexto.Length - 1)

            ActualizarPantalla()

        End If

    End Sub

    '========================
    ' ACTUALIZAR PANTALLA
    '========================
    Private Sub ActualizarPantalla()

        pantallauno.Items.Clear()

        pantallauno.Items.Add(pantallaTexto)

    End Sub

    '========================
    ' POTENCIA x²
    '========================
    Private Sub btn_potencia_Click(sender As Object, e As EventArgs) Handles btn_potencia.Click

        Try

            If pantallaTexto = "" Then
                MessageBox.Show("Ingrese un número")
                Exit Sub
            End If

            Dim numero As Decimal = Convert.ToDecimal(pantallaTexto)

            Dim resultado As Decimal = numero * numero

            pantallados.Items.Clear()
            pantallados.Items.Add(resultado.ToString())

        Catch ex As Exception

            MessageBox.Show("Número inválido")

        End Try

    End Sub

    '========================
    ' RAÍZ CUADRADA √
    '========================
    Private Sub btn_raiz_Click(sender As Object, e As EventArgs) Handles btn_raiz.Click

        Try

            If pantallaTexto = "" Then
                MessageBox.Show("Ingrese un número")
                Exit Sub
            End If

            Dim numero As Double = Convert.ToDouble(pantallaTexto)

            If numero < 0 Then
                MessageBox.Show("No existe raíz cuadrada de números negativos")
                Exit Sub
            End If

            Dim resultado As Double = Math.Sqrt(numero)

            pantallados.Items.Clear()
            pantallados.Items.Add(resultado.ToString())

        Catch ex As Exception

            MessageBox.Show("Número inválido")

        End Try

    End Sub

End Class