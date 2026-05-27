Public Class Form1

    ' BOTÓN CLASIFICAR
    Private Sub btnClasificar_Click(sender As Object, e As EventArgs) Handles btnClasificar.Click

        Dim nombre As String = txtNombre.Text.Trim()
        Dim precio As Decimal
        Dim categoria As String
        Dim iva As Decimal
        Dim precioFinal As Decimal

        ' Validar precio
        If Not Decimal.TryParse(txtPrecio.Text, precio) OrElse precio <= 0 Then
            MessageBox.Show("Ingrese un precio válido y positivo.")

            txtPrecio.Focus()
            txtPrecio.SelectAll()

            Exit Sub
        End If

        ' Clasificar producto
        If precio < 500D Then
            categoria = "Económico"

        ElseIf precio >= 500D AndAlso precio <= 2000D Then
            categoria = "Estándar"

        Else
            categoria = "Premium"
        End If

        ' Calcular IVA y precio final
        iva = precio * 0.16D
        precioFinal = precio + iva

        ' Mostrar resultados
        lblCategoria.Text = categoria
        lblIva.Text = iva.ToString("C")
        lblPrecioFinal.Text = precioFinal.ToString("C")

    End Sub

    ' BOTÓN LIMPIAR
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click

        txtNombre.Clear()
        txtPrecio.Clear()

        lblCategoria.Text = ""
        lblIva.Text = ""
        lblPrecioFinal.Text = ""

        txtNombre.Focus()

    End Sub

End Class