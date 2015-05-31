<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaffeine
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
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblHalf = New System.Windows.Forms.Label()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblHourly24Hrs = New System.Windows.Forms.Label()
        Me.txtHalf = New System.Windows.Forms.TextBox()
        Me.txtDay = New System.Windows.Forms.TextBox()
        Me.txtHourly24Hrs = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(54, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(150, 35)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate Values"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblHalf
        '
        Me.lblHalf.AutoSize = True
        Me.lblHalf.Location = New System.Drawing.Point(12, 74)
        Me.lblHalf.Name = "lblHalf"
        Me.lblHalf.Size = New System.Drawing.Size(100, 26)
        Me.lblHalf.TabIndex = 1
        Me.lblHalf.Text = "One cup: When will" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "65 mg. remain?"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(12, 127)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(93, 26)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "One cup: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'lblHourly24Hrs
        '
        Me.lblHourly24Hrs.AutoSize = True
        Me.lblHourly24Hrs.Location = New System.Drawing.Point(12, 180)
        Me.lblHourly24Hrs.Name = "lblHourly24Hrs"
        Me.lblHourly24Hrs.Size = New System.Drawing.Size(108, 26)
        Me.lblHourly24Hrs.TabIndex = 3
        Me.lblHourly24Hrs.Text = "Hourly cups: Quantity" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "after 24 hours:"
        '
        'txtHalf
        '
        Me.txtHalf.Location = New System.Drawing.Point(141, 80)
        Me.txtHalf.Name = "txtHalf"
        Me.txtHalf.ReadOnly = True
        Me.txtHalf.Size = New System.Drawing.Size(100, 20)
        Me.txtHalf.TabIndex = 4
        '
        'txtDay
        '
        Me.txtDay.Location = New System.Drawing.Point(141, 133)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.ReadOnly = True
        Me.txtDay.Size = New System.Drawing.Size(100, 20)
        Me.txtDay.TabIndex = 5
        '
        'txtHourly24Hrs
        '
        Me.txtHourly24Hrs.Location = New System.Drawing.Point(141, 186)
        Me.txtHourly24Hrs.Name = "txtHourly24Hrs"
        Me.txtHourly24Hrs.ReadOnly = True
        Me.txtHourly24Hrs.Size = New System.Drawing.Size(100, 20)
        Me.txtHourly24Hrs.TabIndex = 6
        '
        'frmCaffeine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.txtHourly24Hrs)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtHalf)
        Me.Controls.Add(Me.lblHourly24Hrs)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.lblHalf)
        Me.Controls.Add(Me.btnCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCaffeine"
        Me.Text = "Caffeine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblHalf As System.Windows.Forms.Label
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblHourly24Hrs As System.Windows.Forms.Label
    Friend WithEvents txtHalf As System.Windows.Forms.TextBox
    Friend WithEvents txtDay As System.Windows.Forms.TextBox
    Friend WithEvents txtHourly24Hrs As System.Windows.Forms.TextBox

End Class
