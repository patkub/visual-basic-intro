Public Class frmCalc

    'Declare global variables
    'dblFirstNum - First number to preform operation with of type Double
    'dblSecondNum - Second number to preform operation with of type Double
    Dim dblFirstNum, dblSecondNum As Double

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Button Add Clicked
        'Set output textbox (txtOutput) to "dblFirstNum + dblSecondNum = sum"
        txtOutput.Text = CStr(dblFirstNum) + " + " + CStr(dblSecondNum) + " = " + CStr(dblFirstNum + dblSecondNum)
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        'Button Subtract Clicked
        'Set output textbox (txtOutput) to "dblFirstNum - dblSecondNum = difference"
        txtOutput.Text = CStr(dblFirstNum) + " - " + CStr(dblSecondNum) + " = " + CStr(dblFirstNum - dblSecondNum)
    End Sub

    Private Sub btnMulti_Click(sender As Object, e As EventArgs) Handles btnMulti.Click
        'Button Multiply Clicked
        'Set output textbox (txtOutput) to "dblFirstNum * dblSecondNum = product"
        txtOutput.Text = CStr(dblFirstNum) + " * " + CStr(dblSecondNum) + " = " + CStr(dblFirstNum * dblSecondNum)
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        'Button Divide Clicked
        'Set output textbox (txtOutput) to "dblFirstNum / dblSecondNum = quotient"
        txtOutput.Text = CStr(dblFirstNum) + " / " + CStr(dblSecondNum) + " = " + CStr(dblFirstNum / dblSecondNum)
    End Sub

    Private Sub mtbFirstNum_TextChanged(sender As Object, e As EventArgs) Handles mtbFirstNum.TextChanged
        'Text in Masked TextBox for first number (mtbFirstNum) changed
        txtOutput.Clear() 'Clear read-only output textbox (txtOutput)

        If IsNumeric(mtbFirstNum.Text) Then 'Checks if mtbFirstNum.Text is a number
            dblFirstNum = CDbl(mtbFirstNum.Text) 'Convert textbox with first number (mtbFirstNum) to double and store in global variable dblFirstNum
        Else
            dblFirstNum = 0 'If mtbFirstNum.Text was not a number, set the first number (dblFirstNum) to 0
        End If
    End Sub

    Private Sub mtbSecondNum_TextChanged(sender As Object, e As EventArgs) Handles mtbSecondNum.TextChanged
        'Text in Masked TextBox for second number (mtbSecondNum) changed
        txtOutput.Clear() 'Clear read-only output textbox (txtOutput)

        If IsNumeric(mtbSecondNum.Text) Then 'Checks if mtbSecondNum.Text is a number
            dblSecondNum = CDbl(mtbSecondNum.Text) 'Convert textbox with second number (mtbSecondNum) to double and store in global variable dblSecondNum
        Else
            dblSecondNum = 0 'If mtbSecondNum.Text was not a number, set the second number (dblSecondNum) to 0
        End If
    End Sub

End Class