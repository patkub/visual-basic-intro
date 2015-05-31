Public Class frmConversion

    Dim Miles, Yards, Feet, Inches As Double

    Private Sub txtMiles_TextChanged(sender As Object, e As EventArgs) Handles txtMiles.TextChanged
        lstResults.Items.Clear()
        If IsNumeric(txtMiles.Text) Then
            Miles = CDbl(txtMiles.Text)
        Else
            Miles = 0
        End If
    End Sub

    Private Sub txtYards_TextChanged(sender As Object, e As EventArgs) Handles txtYards.TextChanged
        lstResults.Items.Clear()
        If IsNumeric(txtYards.Text) Then
            Yards = CDbl(txtYards.Text)
        Else
            Yards = 0
        End If
    End Sub

    Private Sub txtFeet_TextChanged(sender As Object, e As EventArgs) Handles txtFeet.TextChanged
        lstResults.Items.Clear()
        If IsNumeric(txtFeet.Text) Then
            Feet = CDbl(txtFeet.Text)
        Else
            Feet = 0
        End If

    End Sub

    Private Sub txtInches_TextChanged(sender As Object, e As EventArgs) Handles txtInches.TextChanged
        lstResults.Items.Clear()
        If IsNumeric(txtInches.Text) Then
            Inches = CDbl(txtInches.Text)
        Else
            Inches = 0
        End If
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim Kilometers, Meters, Centimeters As Double
        Dim totalInches As Double = (63360 * Miles) + (36 * Yards) + (12 * Feet) + Inches
        Dim totalMeters As Double = totalInches / 39.37

        Kilometers = Int(totalMeters / 1000)
        totalMeters = totalMeters - (Kilometers * 1000)

        Meters = Int(totalMeters)
        totalMeters = totalMeters - Meters

        Centimeters = (totalMeters * 100).ToString("N1")

        lstResults.Items.Clear()
        lstResults.Items.Add("The metric length is")
        lstResults.Items.Add(Kilometers & " kilometers")
        lstResults.Items.Add(Meters & " meters")
        lstResults.Items.Add(Centimeters & " centimeters")
    End Sub
End Class
