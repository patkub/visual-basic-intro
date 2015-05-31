Public Class frmAverageGrade

    Dim Grades(0) As Double     'Store grades
    Dim pos As Integer          'Latest position in grades array

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        'Record Grade

        If IsNumeric(txtGrade.Text) Then
            Grades(pos) = txtGrade.Text
            pos += 1                        'Increment latest position in grades array
            ReDim Preserve Grades(pos)      'Expand grades array to accommodate next grade

            'Alert user the grade has been entered
            MessageBox.Show("Grade of " & Grades(pos - 1) & " Has Been Recorded")
        End If

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Display average grade and number of above average grades

        Dim dblAverageGrade As Double = CalcAverageOfArray(Grades, Grades.Length - 1)
        Dim AboveAverage As Integer = CalcNumOfAboveAverageInArray(Grades, dblAverageGrade)

        lstGradeData.Items.Clear()
        lstGradeData.Items.Add("The average grade is " & Math.Round(dblAverageGrade, 2) & ".")
        lstGradeData.Items.Add(AboveAverage & " students scored above the average.")
    End Sub

    Function CalcAverageOfArray(Array() As Double, NumOfFirstElements As Integer) As Double
        'Calculate average of first x elements in an array
        'NumOfFirstElements - first x elements in an array

        Dim Sum As Double   'Store sum of first x elements in an array

        For i As Integer = 0 To NumOfFirstElements     'Iterate through first x elements in an array
            Sum += Array(i)                 'Add current element to sum
        Next

        Return (Sum / NumOfFirstElements)   'Average of elements
    End Function

    Function CalcNumOfAboveAverageInArray(Array() As Double, dblAverage As Double)
        'Calculates number of above average elements in array

        Dim num As Integer      'Store number of above average elements
        Dim AboveAverageQuery = From element In Array
                                Where element > dblAverage
                                Select element

        'Loop through all selected elements
        For Each element As Double In AboveAverageQuery
            num += 1    'Count the elements
        Next

        Return num      'Number of above average elements
    End Function

End Class
