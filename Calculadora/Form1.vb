Public Class Form1
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim valor1, valor2 As Integer

        valor1 = txtValor1.Text
        valor2 = txtValor2.Text

        If btnSuma.Checked = True Then
            txtResultado.Text = valor1 + valor2
        ElseIf btnResta.Checked = True Then
            txtResultado.Text = valor1 - valor2
        ElseIf btnMultiplicacion.Checked = True Then
            txtResultado.Text = valor1 * valor2
        ElseIf btnDivision.Checked = True Then
            txtResultado.Text = valor1 / valor2
        End If
    End Sub
End Class
