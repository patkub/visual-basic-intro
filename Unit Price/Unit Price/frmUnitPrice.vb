Public Class frmUnitPrice

    Dim dblPrice, dblPounds, dblOunces As Double

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtPrice.TextChanged
        txtResult.Clear()
        If IsNumeric(txtPrice.Text) Then
            dblPrice = CDbl(txtPrice.Text)
        Else
            dblPrice = 0
        End If
    End Sub

    Private Sub txtPounds_TextChanged(sender As Object, e As EventArgs) Handles txtPounds.TextChanged
        txtResult.Clear()
        If IsNumeric(txtPounds.Text) Then
            dblPounds = CDbl(txtPounds.Text)
        Else
            dblPounds = 0
        End If
    End Sub

    Private Sub txtOunces_TextChanged(sender As Object, e As EventArgs) Handles txtOunces.TextChanged
        txtResult.Clear()
        If IsNumeric(txtOunces.Text) Then
            dblOunces = CDbl(txtOunces.Text)
        Else
            dblOunces = 0
        End If
    End Sub

    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
        txtResult.Clear()
        Dim dblTotalOunces As Double = (dblPounds * 16) + dblOunces
        Dim dblUnitPrice As Double = dblPrice / dblTotalOunces
        txtResult.Text = dblUnitPrice.ToString("C")
    End Sub

End Class
