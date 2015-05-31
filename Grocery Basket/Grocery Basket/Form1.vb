Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim begOfYearCost, endOfYearCost, percentIncrease As Double
        begOfYearCost = 200
        Dim strEndOfYearCost As String = InputBox("Enter the cost at the end of the year:", "End of Year Cost")

        If IsNumeric(strEndOfYearCost) Then
            endOfYearCost = CDbl(strEndOfYearCost)
            percentIncrease = (endOfYearCost - begOfYearCost) / begOfYearCost
            MessageBox.Show("The percent increase for the year is " & percentIncrease.ToString("P"), "Percent Increase")
            lstResults.Items.Add(percentIncrease.ToString("P"))
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstResults.Items.Clear()
    End Sub

End Class
