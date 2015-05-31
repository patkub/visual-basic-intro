Public Class frmAverageGrades

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculates grade data using pre-defined list
        Dim Grades() As Double = {75, 80, 60, 95, 82}
        Dim i As Integer
        Dim Max, Average As Double

        Average = CalcAverageOfArray(Grades)  'Calc average of grades
        txtAverage.Text = CStr(Average)

        lstGrades.Items.Clear()
        For i = 0 To Grades.Count - 1   'Iterate all grades
            lstGrades.Items.Add(Grades(i))
        Next

        Max = CalcMaxOfArray(Grades)

        txtMaxGrade.Text = Max          'Maximum grade
        txtMaxGrade2.Text = Grades.Max  'Maximun element of array
    End Sub


    Private Sub btnCGrades_Click(sender As Object, e As EventArgs) Handles btnCGrades.Click
        'Order custom grades list
        Dim Grades(0), dblCGrade As Double
        Dim i As Integer
        Dim strInput As String
        strInput = InputBox("Enter grade or -1 to stop entering grades:", "Order of Grades")

        If IsNumeric(strInput) Then
            dblCGrade = CDbl(strInput)
        End If

        Do While dblCGrade <> -1
            Grades(i) = dblCGrade
            ReDim Preserve Grades(i + 1)

            strInput = InputBox("Enter grade or -1 to stop entering grades:", "Order of Grades")
            If IsNumeric(strInput) Then
                dblCGrade = CDbl(strInput)
            End If
            i += 1
        Loop

        If i > 0 Then
            Dim GradesQuery = From Grade In Grades
                              Order By Grade Ascending
                              Where Grade > 0
                              Select Grade

            For Each Grade As Integer In GradesQuery
                lstOrderedGrades.Items.Add(Grade)
            Next
        End If

    End Sub

    Function CalcAverageOfArray(Array() As Double) As Double
        'Calculate average of numbers in array
        Dim i As Integer
        Dim Sum As Double

        For i = 0 To Array.Count - 1   'Iterate all grades
            Sum += Array(i)            'Add current grade to sum
        Next

        Return (Sum / Array.Count)     'Average of grades
    End Function

    Function CalcMaxOfArray(Array() As Double) As Double
        'Get max element of array using a for loop
        Dim Max As Double

        For i = 0 To Array.Count - 1   'Iterate all grades
            If Array(i) > Max Then
                Max = Array(i)
            End If
        Next

        Return Max      'Max element
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears outputs
        txtAverage.Clear()
        lstGrades.Items.Clear()
        txtMaxGrade.Clear()
        txtMaxGrade2.Clear()
        lstOrderedGrades.Items.Clear()
    End Sub

End Class
