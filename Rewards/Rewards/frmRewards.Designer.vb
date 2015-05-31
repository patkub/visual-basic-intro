<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRewards
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
        Me.lblRecovered = New System.Windows.Forms.Label()
        Me.txtRecovered = New System.Windows.Forms.TextBox()
        Me.btnCalcReward = New System.Windows.Forms.Button()
        Me.lblReward = New System.Windows.Forms.Label()
        Me.mtbReward = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblRecovered
        '
        Me.lblRecovered.AutoSize = True
        Me.lblRecovered.Location = New System.Drawing.Point(49, 9)
        Me.lblRecovered.Name = "lblRecovered"
        Me.lblRecovered.Size = New System.Drawing.Size(97, 13)
        Me.lblRecovered.TabIndex = 0
        Me.lblRecovered.Text = "Amount recovered:"
        '
        'txtRecovered
        '
        Me.txtRecovered.Location = New System.Drawing.Point(152, 6)
        Me.txtRecovered.Name = "txtRecovered"
        Me.txtRecovered.Size = New System.Drawing.Size(100, 20)
        Me.txtRecovered.TabIndex = 1
        '
        'btnCalcReward
        '
        Me.btnCalcReward.Location = New System.Drawing.Point(52, 44)
        Me.btnCalcReward.Name = "btnCalcReward"
        Me.btnCalcReward.Size = New System.Drawing.Size(200, 35)
        Me.btnCalcReward.TabIndex = 2
        Me.btnCalcReward.Text = "Determine Reward"
        Me.btnCalcReward.UseVisualStyleBackColor = True
        '
        'lblReward
        '
        Me.lblReward.AutoSize = True
        Me.lblReward.Location = New System.Drawing.Point(49, 99)
        Me.lblReward.Name = "lblReward"
        Me.lblReward.Size = New System.Drawing.Size(93, 13)
        Me.lblReward.TabIndex = 3
        Me.lblReward.Text = "Amount of reward:"
        '
        'mtbReward
        '
        Me.mtbReward.Location = New System.Drawing.Point(148, 96)
        Me.mtbReward.Name = "mtbReward"
        Me.mtbReward.ReadOnly = True
        Me.mtbReward.Size = New System.Drawing.Size(100, 20)
        Me.mtbReward.TabIndex = 4
        '
        'frmRewards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 142)
        Me.Controls.Add(Me.mtbReward)
        Me.Controls.Add(Me.lblReward)
        Me.Controls.Add(Me.btnCalcReward)
        Me.Controls.Add(Me.txtRecovered)
        Me.Controls.Add(Me.lblRecovered)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmRewards"
        Me.Text = "Rewards"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRecovered As System.Windows.Forms.Label
    Friend WithEvents txtRecovered As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcReward As System.Windows.Forms.Button
    Friend WithEvents lblReward As System.Windows.Forms.Label
    Friend WithEvents mtbReward As System.Windows.Forms.TextBox

End Class
