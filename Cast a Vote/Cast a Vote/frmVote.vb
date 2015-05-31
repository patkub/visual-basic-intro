Public Class frmVote

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear selections
        radKennedy.Checked = False
        radNixon.Checked = False
    End Sub

    Private Sub btnVote_Click(sender As Object, e As EventArgs) Handles btnVote.Click
        If radKennedy.Checked Then
            txtResult.Text = "You voted for Kennedy."
        ElseIf radNixon.Checked Then
            txtResult.Text = "You voted for Nixon."
        Else
            txtResult.Text = "You voted for neither."
        End If
    End Sub

End Class
