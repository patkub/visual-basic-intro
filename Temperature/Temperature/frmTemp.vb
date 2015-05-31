Public Class frmTemp

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim dblTempF, dblTempC As Double
        If IsNumeric(txtTempF.Text) Then
            dblTempF = CDbl(txtTempF.Text)
            dblTempC = Math.Round(FtoC(dblTempF), 2)
            txtTempC.Text = CStr(dblTempC) + " " + Chr(176) + "C"
        Else
            MessageBox.Show("Invalid Temperature", "ERROR")
        End If
    End Sub

    Function FtoC(temp As Double) As Double
        Return (5 / 9) * (temp - 32)
    End Function

End Class
