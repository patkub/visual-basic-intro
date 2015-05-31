<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarLoan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(22, 20)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(81, 13)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Amount of loan:"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(20, 46)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(83, 13)
        Me.lblRate.TabIndex = 1
        Me.lblRate.Text = "Interest rate (%):"
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Location = New System.Drawing.Point(17, 73)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(87, 13)
        Me.lblYears.TabIndex = 2
        Me.lblYears.Text = "Number of years:"
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(12, 140)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(91, 13)
        Me.lblMonthlyPayment.TabIndex = 3
        Me.lblMonthlyPayment.Text = "Monthly Payment:"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(109, 17)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 4
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(109, 43)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 5
        '
        'txtYears
        '
        Me.txtYears.Location = New System.Drawing.Point(110, 70)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 20)
        Me.txtYears.TabIndex = 6
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(110, 137)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.ReadOnly = True
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(100, 20)
        Me.txtMonthlyPayment.TabIndex = 8
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(15, 96)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(200, 35)
        Me.btnCalc.TabIndex = 7
        Me.btnCalc.Text = "Calculate Monthly Payment"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'frmCarLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 187)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblAmount)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCarLoan"
        Me.Text = "Car Loan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents lblYears As System.Windows.Forms.Label
    Friend WithEvents lblMonthlyPayment As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents txtYears As System.Windows.Forms.TextBox
    Friend WithEvents txtMonthlyPayment As System.Windows.Forms.TextBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button

End Class
