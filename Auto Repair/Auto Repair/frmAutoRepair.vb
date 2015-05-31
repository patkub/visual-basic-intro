Public Class frmAuto

    'Declare global variables
    'strCustomer - Customer Name of type String
    'dblHours - Hours of labor of type Double
    'dblSuppliesCost - Cost of parts and supplies
    Dim strCustomer As String, dblHours, dblSuppliesCost As Double

    Private Sub txtCustomer_TextChanged(sender As Object, e As EventArgs) Handles txtCustomer.TextChanged
        'Text in TextBox for customer name (txtCustomer) changed
        lstResults.Items.Clear() 'Clear results list box
        strCustomer = txtCustomer.Text 'Store text from customer textbox (txtCustomer) in global variable strCustomer
    End Sub

    Private Sub txtHours_TextChanged(sender As Object, e As EventArgs) Handles txtHours.TextChanged
        'Text in textbox for hours (txtHours) changed
        lstResults.Items.Clear() 'Clear results list box

        If IsNumeric(txtHours.Text) Then 'Checks if txtHours.Text is a number
            dblHours = CDbl(txtHours.Text) 'Convert textbox with hours (txtHours) to double and store in global variable dblHours
        Else
            dblHours = 0 'If txtHours.Text was not a number, set the number of hours (dblHours) to 0
        End If
    End Sub

    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        'Text in textbox for cost (txtCost) changed
        lstResults.Items.Clear() 'Clear results list box

        If IsNumeric(txtCost.Text) Then 'Checks if txtCost.Text is a number
            dblSuppliesCost = CDbl(txtCost.Text) 'Convert textbox with supplies cost (txtCost) to double and store in global variable dblSuppliesCost
        Else
            dblSuppliesCost = 0 'If txtCost.Text was not a number, set the supplies cost (txtCost) to 0
        End If
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'Button Display Clicked

        'Declare local variables
        'dblLaborCost - Cost of labor of type Double
        'dblPartsCost - Cost of parts of type Double
        'dblTotalCost - Total cost of type Double
        Dim dblLaborCost, dblPartsCost, dblTotalCost As Double

        'Declare local constants
        'RATE_PER_HOUR - Cost of labor per hour of type Integer
        'SALES_TAX - Sales tax of parts
        Const RATE_PER_HOUR As Integer = 35, SALES_TAX As Double = 0.05

        dblLaborCost = RATE_PER_HOUR * dblHours 'Cost for labor
        dblPartsCost = dblSuppliesCost + (dblSuppliesCost * SALES_TAX) 'Cost for parts and supplies subject to a 5% sales tax
        dblTotalCost = dblLaborCost + dblPartsCost

        lstResults.Items.Clear() 'Clear results list box
        lstResults.Items.Add("Customer          " + strCustomer) 'Add customer name to results list box
        lstResults.Items.Add("Labor cost        " + dblLaborCost.ToString("C")) 'Add labor cost in format $XX,XXX.XX to results list box
        lstResults.Items.Add("Parts cost        " + dblPartsCost.ToString("C")) 'Add parts cost in format $XX,XXX.XX to results list box
        lstResults.Items.Add("Total cost        " + dblTotalCost.ToString("C")) 'Add total cost in format $XX,XXX.XX to results list box
    End Sub

End Class
