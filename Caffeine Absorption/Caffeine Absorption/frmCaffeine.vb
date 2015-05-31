Public Class frmCaffeine

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculate values

        'ELIMINATED_PER_HOUR    -   Percent eliminated per hour of type double
        'AMOUNT_OF_CAFFEINE     -   mg of caffeine per cup of type double
        Const ELIMINATED_PER_HOUR As Double = 0.13,
            AMOUNT_OF_CAFFEINE As Double = 130

        'dblHoursTillHalf   -   Hours it takes for half the caffeine to remain of type double
        'dblAmountAfterDay  -   Amount of caffeine left after a day (24 hours)
        'dblHourlyCupForDay -   Amount of caffeine in body after 1 cup of coffee every hour for 24 hours
        Dim dblHoursTillHalf, dblAmountAfterDay, dblHourlyCupForDay As Double

        'Calculate values
        dblHoursTillHalf = CalcHoursTillHalfRemains(AMOUNT_OF_CAFFEINE, ELIMINATED_PER_HOUR)
        dblAmountAfterDay = CalcAmountAfterDay(AMOUNT_OF_CAFFEINE, ELIMINATED_PER_HOUR)
        dblHourlyCupForDay = CalcAmountAfterHourlyCupForDay(AMOUNT_OF_CAFFEINE, ELIMINATED_PER_HOUR)

        'Output calculated values
        DisplayResults(dblHoursTillHalf, dblAmountAfterDay, dblHourlyCupForDay)
    End Sub

    Sub DisplayResults(dblHoursTillHalf As Double, dblAmountAfterDay As Double, dblHourlyCupForDay As Double)
        'Output values

        txtHalf.Text = CStr(dblHoursTillHalf) & " hours"                'Hours it takes for half the caffeine to remain
        txtDay.Text = dblAmountAfterDay.ToString("N") & " mg"           'Amount of caffeine left after a day (24 hours)
        txtHourly24Hrs.Text = dblHourlyCupForDay.ToString("N") & " mg"  'Amount of caffeine in body after 1 cup of coffee every hour for 24 hours
    End Sub

    Function CalcHoursTillHalfRemains(dblAmount As Double, dblRemovedPerHour As Double) As Double
        'Calculates amount of hours it takes for half the caffeine to remain

        Dim dblHours As Double                              'Store count of number of hours
        Dim dblHalf As Double = (dblAmount / 2)             'Half the amount

        Do
            dblAmount -= (dblAmount * dblRemovedPerHour)    'Subtract amount removed per hour
            dblHours += 1                                   'Add 1 hour to count
        Loop Until (dblAmount <= dblHalf)       'End loop once half or less is left

        Return dblHours                         'Return number of hours of type double
    End Function

    Function CalcAmountAfterDay(dblAmount As Double, dblRemovedPerHour As Double) As Double
        'Calculates amount of caffeine left after 24 hours

        For i As Integer = 1 To 24
            dblAmount -= (dblAmount * dblRemovedPerHour)    'Subtract amount removed each hour for 24 hours
        Next

        Return dblAmount            'Return amount left over of type double
    End Function

    Function CalcAmountAfterHourlyCupForDay(dblAmount As Double, dblPercentRemovedPerHour As Double) As Double
        'Calculates amount of caffeine in body after 1 cup of coffee every hour for 24 hours

        Dim dblAmountAfterDay As Double = dblAmount
        For i As Integer = 1 To 24                                                  'Each hour for 24 hours
            dblAmountAfterDay -= (dblAmountAfterDay * dblPercentRemovedPerHour)     'Subtract percent of caffeine removed
            dblAmountAfterDay += dblAmount                                          'Add caffeine for 1 cup
        Next

        Return dblAmountAfterDay        'Return amount in body of type double
    End Function

End Class
