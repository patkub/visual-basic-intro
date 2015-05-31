Public Class frmGrades

    Private Sub btnDSG_Click(sender As Object, e As EventArgs) Handles btnDSG.Click
        'Determine Semester Grade
        Dim strName As String = txtName.Text    'Get name from textbox
        Dim grade1, grade2, grade3 As Double    'Declare variables to hold grades

        If IsNumeric(txtGrade1.Text) And IsNumeric(txtGrade2.Text) And IsNumeric(txtGrade3.Text) Then  'Make sure input is valid
            grade1 = CDbl(txtGrade1.Text)       'Get grades from textboxes
            grade2 = CDbl(txtGrade2.Text)
            grade3 = CDbl(txtGrade3.Text)
            DisplayGrade(strName, grade1, grade2, grade3)   'Output name and grade
        Else
            MessageBox.Show("Invalid Grades", "ERROR")      'Invalid input. Entered grades are not numerics.
        End If
    End Sub

    Sub DisplayGrade(strName As String, grade1 As Double, grade2 As Double, grade3 As Double)
        'Display name and semester grade
        Dim strSemGrade As String = CalcSemGrade(grade1, grade2, grade3)    'Store letter grade for semester
        txtSemGrade.Text = strName & ": " & strSemGrade                     'Format output with name and grade
    End Sub

    Function CalcSemGrade(grade1 As Double, grade2 As Double, grade3 As Double) As String
        'Determine letter grade from average of 3 percentage grades
        Dim lowestGrade As Double = FindLowest(grade1, grade2, grade3)      'Determine lowest grade
        Dim totalGrade As Double = (grade1 + grade2 + grade3) - lowestGrade 'Sum of grades not including lowest
        Dim avgGrade As Integer = Int(totalGrade / 2)                       'Average of the two highest grades rounded to nearest whole number

        Select Case avgGrade    'Determine letter grade from average grade
            Case 90 To 100
                Return "A"
            Case 80 To 89
                Return "B"
            Case 70 To 79
                Return "C"
            Case 60 To 69
                Return "D"
            Case Else
                Return "F"
        End Select
    End Function

    Function FindLowest(num1 As Double, num2 As Double, num3 As Double) As Double
        'Find lowest of three numbers
        Dim lowest As Double = num1     'Lets say first number is lowest

        If (num2 < num1) Then           'Second number is lower than the first
            lowest = num2               'Lowest number is now the second number
        End If

        If (num3 < lowest) Then         'Third number is lower than the current lowest number
            lowest = num3               'Lowest number is now the third number
        End If

        Return lowest                   'Return the lowest number
    End Function

End Class
