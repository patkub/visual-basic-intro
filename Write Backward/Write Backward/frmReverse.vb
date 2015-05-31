Public Class frmReverse

    Private Sub btnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        Dim strWord As String = txtWord.Text
        'Native function
        'txtBackward.Text = StrReverse(strWord)
        txtBackward.Text = ReverseString(strWord)
    End Sub

    Function ReverseString(strInfo As String) As String
        Dim strReverse As String = ""
        For i As Integer = strInfo.Length - 1 To 0 Step -1
            strReverse &= strInfo.Substring(i, 1)
        Next
        Return strReverse
    End Function
End Class
