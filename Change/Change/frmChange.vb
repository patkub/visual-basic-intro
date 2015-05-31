Public Class frmChange

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Dim Quarters, Dimes, Nickels, Cents As Double
        Dim Change As Integer

        If IsNumeric(txtAmount.Text) Then
            Change = CInt(txtAmount.Text)
        Else
            Change = 0
        End If

        Quarters = Int((Change / 25))
        Change = Change - (Quarters * 25)

        Dimes = Int(Change / 10)
        Change = Change - (Dimes * 10)

        Nickels = Int(Change / 5)
        Change = Change - (Nickels * 5)

        Cents = Change

        lstResults.Items.Clear()
        lstResults.Items.Add("Quarters: " & Quarters)
        lstResults.Items.Add("Dimes: " & Dimes)
        lstResults.Items.Add("Nickels: " & Nickels)
        lstResults.Items.Add("Cents: " & Cents)
    End Sub

    Private Sub txtAmount_TextChanged(sender As Object, e As EventArgs) Handles txtAmount.TextChanged
        lstResults.Items.Clear()
    End Sub

End Class
