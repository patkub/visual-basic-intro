Public Class frmHurricane

    Private Sub btnDHR_Click(sender As Object, e As EventArgs) Handles btnDHR.Click
        If IsNumeric(txtSpeed.Text) Then
            Dim windSpeed As Integer = CInt(txtSpeed.Text)
            txtCategory.Text = CategoryOfHurricane(windSpeed)
        Else
            MessageBox.Show("Invalid Speed", "ERROR")
        End If
    End Sub

    Function CategoryOfHurricane(speed As Integer) As String
        Select Case speed
            Case 0 To 73
                Return "Uncategorized hurricane."
            Case 74 To 95
                Return "Category One hurricane."
            Case 96 To 110
                Return "Category Two hurricane."
            Case 111 To 130
                Return "Category Three hurricane."
            Case 131 To 155
                Return "Category Four hurricane."
            Case Else
                Return "Category Five hurricane."
        End Select
    End Function

End Class
