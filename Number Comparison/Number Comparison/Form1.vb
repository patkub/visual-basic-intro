Public Class frmNumCompare

    Dim dblNum1, dblNum2 As Double

    Private Sub txtNum1_TextChanged(sender As Object, e As EventArgs) Handles txtNum1.TextChanged
        If IsNumeric(txtNum1.Text) Then
            dblNum1 = CDbl(txtNum1.Text)
        Else
            dblNum1 = 0
        End If
    End Sub

    Private Sub txtNum2_TextChanged(sender As Object, e As EventArgs) Handles txtNum2.TextChanged
        If IsNumeric(txtNum2.Text) Then
            dblNum2 = CDbl(txtNum2.Text)
        Else
            dblNum2 = 0
        End If
    End Sub

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        If (dblNum1 = dblNum2) Then
            txtResult.Text = "The two numbers are equal."
        ElseIf (dblNum1 > dblNum2) Then
            txtResult.Text = "The first number is greater."
        Else
            txtResult.Text = "The second number is greater."
        End If
    End Sub
End Class
