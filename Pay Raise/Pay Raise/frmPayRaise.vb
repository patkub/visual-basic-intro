Public Class frmPayRaise

    Private Sub btnDNS_Click(sender As Object, e As EventArgs) Handles btnDNS.Click
        'Determine New Salary
        Dim strFirstName As String = "", strLastName As String = "" 'Store first and last name
        Dim dblCurSal, dblNewSal As Double                          'Store current and new salaries

        If (IsNumeric(txtCSalary.Text)) Then                        'Make sure current salary is a number
            GetInput(strFirstName, strLastName, dblCurSal)          'Get name and current salary
            dblNewSal = CalcNewSalary(dblCurSal)                    'Calculate new salary
            SetOutput(strFirstName, strLastName, dblNewSal)         'Display new salary
        Else
            MessageBox.Show("Invalid Salary", "ERROR")
        End If
    End Sub

    Sub GetInput(ByRef strFirstName As String, ByRef strLastName As String, ByRef dblCurrentSalary As Double)
        'Get first name, last name, and current salary from input textboxes
        strFirstName = txtFirstName.Text
        strLastName = txtLastName.Text
        dblCurrentSalary = CDbl(txtCSalary.Text)
    End Sub

    Sub SetOutput(strFirstName As String, strLastName As String, dblNewSalary As Double)
        'Display new salary with first and last name
        txtNSalary.Text = "New salary for " + strFirstName + " " + strLastName + ": " + (dblNewSalary).ToString("C")
    End Sub

    Function CalcNewSalary(dblCurrentSalary As Double) As Double
        'Calculate new salary based on current salary

        'Define constants
        'LOW_INCOME             -   Earning low income
        'LOW_INCOME_PERCENT     -   Percent raise for low income
        'HIGH_INCOME_PERCENT    -   Percent raise for amount over low income
        'HIGH_INCOME_RAISE      -   Raise for earning high income
        Const LOW_INCOME As Double = 40000,
            LOW_INCOME_PERCENT As Double = 0.05,
            HIGH_INCOME_PERCENT As Double = 0.02,
            HIGH_INCOME_RAISE As Double = 2000

        Dim dblNewSalary As Double = dblCurrentSalary   'Set new salary to old salary

        If (dblCurrentSalary < LOW_INCOME) Then         'Earning less than low income
            '+5% Raise to current salary
            dblNewSalary += (dblCurrentSalary * LOW_INCOME_PERCENT)
        Else                                            'Earning greater than or equal to low income
            '+$2,000 + (2% of amount left over) to current salary
            Dim dblLeftOver As Double
            dblNewSalary += HIGH_INCOME_RAISE
            dblLeftOver = dblCurrentSalary - LOW_INCOME
            dblNewSalary += dblLeftOver * HIGH_INCOME_PERCENT
        End If

        'Resulting new salary
        Return dblNewSalary
    End Function

End Class
