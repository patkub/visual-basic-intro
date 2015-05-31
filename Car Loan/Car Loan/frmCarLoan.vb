Public Class frmCarLoan

    Dim dblAmount, dblRate, dblYears As Double

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        txtMonthlyPayment.Clear()
        If IsNumeric(txtAmount.Text) Then
            dblAmount = CDbl(txtAmount.Text)
        Else
            dblAmount = 0
        End If
    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged
        txtMonthlyPayment.Clear()
        If IsNumeric(txtRate.Text) Then
            dblRate = CDbl(txtRate.Text)
        Else
            dblRate = 0
        End If
    End Sub

    Private Sub txtYears_TextChanged(sender As Object, e As EventArgs) Handles txtYears.TextChanged
        txtMonthlyPayment.Clear()
        If IsNumeric(txtYears.Text) Then
            dblYears = CDbl(txtYears.Text)
        Else
            dblYears = 0
        End If
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim dblInterest, dblMonthlyPayment As Double
        dblInterest = dblRate / 1200
        dblMonthlyPayment = (dblInterest / (1 - ((1 + dblInterest) ^ (-12 * dblYears)))) * dblAmount
        txtMonthlyPayment.Text = dblMonthlyPayment.ToString("C")
    End Sub

End Class
