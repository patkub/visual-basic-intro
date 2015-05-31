Public Class frmTriple

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        Dim NTT As Double = txtNTT.Text
        Triple(NTT)
        txtT.Text = CStr(NTT)
    End Sub

    Sub Triple(ByRef NTT As Double)
        NTT = NTT * 3
    End Sub

End Class
