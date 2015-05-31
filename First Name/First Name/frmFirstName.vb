Public Class frmFirstName

    Private Sub btnDFN_Click(sender As Object, e As EventArgs) Handles btnDFN.Click
        Dim fullName As String
        fullName = txtFullName.Text
        txtFirstName.Text = FirstName(fullName)
    End Sub

    Function FirstName(strFullName As String) As String
        'Extract the first name from a full name
        Dim firstSpace As Integer
        firstSpace = strFullName.IndexOf(" ")
        If firstSpace <> -1 Then
            Return strFullName.Substring(0, firstSpace)
        Else
            Return strFullName
        End If
    End Function

End Class
