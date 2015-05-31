Public Class frmCloud

    Private Sub btnDescribe_Click(sender As Object, e As EventArgs) Handles btnDescribe.Click
        Dim dblPCC As Double
        If IsNumeric(txtPCC.Text) Then
            dblPCC = CDbl(txtPCC.Text)

            Select Case dblPCC
                Case 0 To 30
                    txtResult.Text = "Clear"
                Case 31 To 70
                    txtResult.Text = "Partly Cloudy"
                Case 71 To 99
                    txtResult.Text = "Cloudy"
                Case 100
                    txtResult.Text = "Overcast"
                Case Else
                    txtResult.Text = "Invalid Percentage"
            End Select
        Else
            MessageBox.Show("Invalid Input", "ERROR")
        End If
    End Sub
End Class
