Public Class frmRewards

    Private Sub txtRecovered_TextChanged(sender As Object, e As EventArgs) Handles txtRecovered.TextChanged
        mtbReward.Clear()   'Clear rewards textbox when input changes
    End Sub

    Private Sub btnCalcReward_Click(sender As Object, e As EventArgs) Handles btnCalcReward.Click
        'Define local constants used for calculations

        'FIRST_AMOUNT - first pay group of type double
        'SECOND_AMOUNT - second pay group of type double
        'MAX_AMOUNT - maximum award payout of type double

        Const FIRST_AMOUNT As Double = 75000,
            SECOND_AMOUNT As Double = 25000,
            MAX_AMOUNT As Double = 50000

        'FIRST_PERCENT - percent of first pay group of type double
        'SECOND_PERCENT - percent of second pay group of type double
        'REMAINING_PERCENT - percent of remaining reward of type double

        Const FIRST_PERCENT As Double = 0.1,
            SECOND_PERCENT As Double = 0.05,
            REMAINING_PERCENT As Double = 0.01

        'dblRecovered - used to store amount recovered of type double
        'dblReward - used to store total reward of type double
        'dblRecoveryRemaining - amount recovered not yet processed, used for calculations

        Dim dblRecovered, dblReward, dblRecoveryRemaining As Double


        If IsNumeric(txtRecovered.Text) Then            'Test to make sure input is valid
            dblRecovered = CDbl(txtRecovered.Text)      'Store input from textbox with amount recovered to dblRecovered

            If (dblRecovered <= FIRST_AMOUNT) Then          'Recovered an amount in the first pay group
                dblReward = (dblRecovered * FIRST_PERCENT)  'Reward is set to the percent of the first pay group

            Else                                            'Recovered an amount higher than the first pay group
                dblReward = (FIRST_AMOUNT * FIRST_PERCENT)  'Reward is set to the first payout
                dblRecoveryRemaining = dblRecovered - FIRST_AMOUNT  'Determine left over recovery after first pay group is accounted for

                If (dblRecoveryRemaining >= SECOND_AMOUNT) Then     'If remaining recovered amount is in the second pay group
                    dblReward += (SECOND_AMOUNT * SECOND_PERCENT)   'The second payout is added to the reward
                    dblRecoveryRemaining -= SECOND_AMOUNT           'Determine left over recovery after both pay groups are accounted for
                End If

                dblReward += (dblRecoveryRemaining * REMAINING_PERCENT)     'Percentage of remaining pay is added to the reward
            End If

            If (dblReward > MAX_AMOUNT) Then                'Check if reward exceeds maximum payout
                mtbReward.Text = (MAX_AMOUNT).ToString("C") 'Set reward to the maximum payout
            Else
                mtbReward.Text = (dblReward).ToString("C")  'Reward is under the maximum payout
            End If
        Else
            MessageBox.Show("Invalid Amount", "ERROR")  'Alert user the input is invalid
        End If

    End Sub

End Class
