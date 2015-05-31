<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParentheses
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
        Me.lblSentence = New System.Windows.Forms.Label()
        Me.txtSentence = New System.Windows.Forms.TextBox()
        Me.btnRPFS = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSentence
        '
        Me.lblSentence.AutoSize = True
        Me.lblSentence.Location = New System.Drawing.Point(12, 9)
        Me.lblSentence.Name = "lblSentence"
        Me.lblSentence.Size = New System.Drawing.Size(56, 13)
        Me.lblSentence.TabIndex = 0
        Me.lblSentence.Text = "Sentence:"
        '
        'txtSentence
        '
        Me.txtSentence.Location = New System.Drawing.Point(15, 25)
        Me.txtSentence.Name = "txtSentence"
        Me.txtSentence.Size = New System.Drawing.Size(300, 20)
        Me.txtSentence.TabIndex = 1
        '
        'btnRPFS
        '
        Me.btnRPFS.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnRPFS.Location = New System.Drawing.Point(37, 51)
        Me.btnRPFS.Name = "btnRPFS"
        Me.btnRPFS.Size = New System.Drawing.Size(250, 35)
        Me.btnRPFS.TabIndex = 2
        Me.btnRPFS.Text = "Remove Parentheses from Sentence"
        Me.btnRPFS.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 92)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(300, 20)
        Me.txtOutput.TabIndex = 3
        '
        'frmParentheses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 142)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnRPFS)
        Me.Controls.Add(Me.txtSentence)
        Me.Controls.Add(Me.lblSentence)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmParentheses"
        Me.Text = "Remove Parentheses"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSentence As System.Windows.Forms.Label
    Friend WithEvents txtSentence As System.Windows.Forms.TextBox
    Friend WithEvents btnRPFS As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox

End Class
