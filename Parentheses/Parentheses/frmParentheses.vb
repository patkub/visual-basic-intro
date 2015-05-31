Public Class frmParentheses

    Private Sub btnRPFS_Click(sender As Object, e As EventArgs) Handles btnRPFS.Click
        'Removes parentheses and content from sentence

        Dim strSentence As String = txtSentence.Text
        RemoveParSet(strSentence)
        txtOutput.Text = strSentence
    End Sub

    Sub RemoveParSet(ByRef strPhrase As String)
        'Remove parentheses and their content
        'strPhrase - string to search in and remove parentheses set

        Dim FirstOpenPar, LastClosePar, FirstParOffset, LastParOffset As Integer
        FirstOpenPar = FindFirstIndexOfString(strPhrase, "(")   'Index of first (
        LastClosePar = FindLastIndexOfString(strPhrase, ")")    'Index of last )
        FirstParOffset = FirstOpenPar - 1                       'Index to end before first (
        LastParOffset = LastClosePar + 1                        'Index to start after last )


        Dim strNewPhrase As String = ""                         'Store new phrase
        If (FirstOpenPar <> -1 And LastClosePar <> -1) Then     'If opening and closing parentheses exist
            'Set phrase to new phrase without parentheses

            If (FirstOpenPar > 0) Then                                  'If there is a string before first (
                strNewPhrase = strPhrase.Substring(0, FirstParOffset)   'Add string before first ( to new phrase
            End If

            'Add string after last ) to new phrase
            strNewPhrase &= strPhrase.Substring(LastParOffset, strPhrase.Length - LastParOffset)
        End If

        strPhrase = strNewPhrase
    End Sub

    Function FindFirstIndexOfString(strPhrase As String, strChar As String) As Integer
        'Finds first index of strChar in strPhrase
        'Returns index or -1 if not found

        Dim i As Integer = 0
        Do While (i < strPhrase.Length)  'Increment through all characters of phrase
            If strPhrase.Substring(i, 1) = strChar Then
                Return i
            End If
            i += 1
        Loop

        Return -1
    End Function

    Function FindLastIndexOfString(strPhrase As String, strChar As String) As Integer
        'Finds last index of strChar in strPhrase
        'Returns index or -1 if not found

        Dim LastIndex As Integer = -1
        Dim i As Integer = 0
        Do While (i < strPhrase.Length)  'Increment through all characters of phrase
            If strPhrase.Substring(i, 1) = strChar Then
                LastIndex = i
            End If
            i += 1
        Loop

        Return LastIndex
    End Function

End Class
