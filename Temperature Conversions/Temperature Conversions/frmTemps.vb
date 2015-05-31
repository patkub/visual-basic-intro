Public Class frmTemps

    Private Sub btnDCTDoWhile_Click(sender As Object, e As EventArgs) Handles btnDCTDoWhile.Click
        'Display Conversion Table
        'Method: Do...While Loop
        lstCTable.Items.Clear()
        lstCTable.Items.Add("Celsius" & "   " & "Fahrenheit")

        'Do...While Loop Method
        Dim CTemp As Double = 10
        Do While CTemp <= 40
            lstCTable.Items.Add("   " & CTemp & "       " & CtoF(CTemp))
            CTemp += 5
        Loop

    End Sub

    Private Sub btnDCTForNext_Click(sender As Object, e As EventArgs) Handles btnDCTForNext.Click
        'Display Conversion Table
        'Method: For...Next Loop
        lstCTable.Items.Clear()
        lstCTable.Items.Add("Celsius" & "   " & "Fahrenheit")

        'For...Next Loop Method
        For i As Integer = 10 To 40 Step 5
            Dim CTemp As Double = Int(CtoF(i))
            lstCTable.Items.Add("   " & i & "       " & CStr(CTemp))
        Next
    End Sub

    Function CtoF(temp As Double) As Double
        'Convert Celcius to Fahrenheit
        Return ((9 / 5) * temp) + 32
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstCTable.Items.Clear()
    End Sub
End Class
