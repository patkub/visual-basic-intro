Public Class frmPostage

    Private Sub btnCAC_Click(sender As Object, e As EventArgs) Handles btnCAC.Click
        If IsNumeric(txtWeight.Text) Then
            Dim weight As Double = CDbl(txtWeight.Text)
            Dim cost As Double = CostOfLetter(weight)
            txtCost.Text = (cost).ToString("C")
        Else
            MessageBox.Show("Invalid Amount", "ERROR")
        End If
    End Sub

    Function CostOfLetter(weight As Double) As Double
        Const FIRST_OUNCE As Double = 0.05, ADDITIONAL_OUNCE As Double = 0.1
        Return FIRST_OUNCE + (Ceil(weight) - 1) * ADDITIONAL_OUNCE
    End Function

    Function Ceil(X As Integer) As Integer
        Return -Int(-X)
    End Function

End Class
