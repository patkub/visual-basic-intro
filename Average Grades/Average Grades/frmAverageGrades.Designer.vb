<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageGrades
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
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.grpGrades = New System.Windows.Forms.GroupBox()
        Me.txtMaxGrade2 = New System.Windows.Forms.TextBox()
        Me.txtMaxGrade = New System.Windows.Forms.TextBox()
        Me.lblMaxGrade = New System.Windows.Forms.Label()
        Me.lstGrades = New System.Windows.Forms.ListBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnCGrades = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lstOrderedGrades = New System.Windows.Forms.ListBox()
        Me.grpGrades.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCalc.Location = New System.Drawing.Point(12, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(75, 23)
        Me.btnCalc.TabIndex = 0
        Me.btnCalc.Text = "Calculate"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'txtAverage
        '
        Me.txtAverage.Location = New System.Drawing.Point(74, 39)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(102, 20)
        Me.txtAverage.TabIndex = 1
        '
        'grpGrades
        '
        Me.grpGrades.Controls.Add(Me.txtMaxGrade2)
        Me.grpGrades.Controls.Add(Me.txtMaxGrade)
        Me.grpGrades.Controls.Add(Me.lblMaxGrade)
        Me.grpGrades.Controls.Add(Me.lstGrades)
        Me.grpGrades.Location = New System.Drawing.Point(12, 66)
        Me.grpGrades.Name = "grpGrades"
        Me.grpGrades.Size = New System.Drawing.Size(181, 160)
        Me.grpGrades.TabIndex = 2
        Me.grpGrades.TabStop = False
        Me.grpGrades.Text = "Grades"
        '
        'txtMaxGrade2
        '
        Me.txtMaxGrade2.Location = New System.Drawing.Point(74, 120)
        Me.txtMaxGrade2.Name = "txtMaxGrade2"
        Me.txtMaxGrade2.Size = New System.Drawing.Size(90, 20)
        Me.txtMaxGrade2.TabIndex = 5
        '
        'txtMaxGrade
        '
        Me.txtMaxGrade.Location = New System.Drawing.Point(74, 94)
        Me.txtMaxGrade.Name = "txtMaxGrade"
        Me.txtMaxGrade.Size = New System.Drawing.Size(90, 20)
        Me.txtMaxGrade.TabIndex = 4
        '
        'lblMaxGrade
        '
        Me.lblMaxGrade.AutoSize = True
        Me.lblMaxGrade.Location = New System.Drawing.Point(6, 98)
        Me.lblMaxGrade.Name = "lblMaxGrade"
        Me.lblMaxGrade.Size = New System.Drawing.Size(62, 13)
        Me.lblMaxGrade.TabIndex = 3
        Me.lblMaxGrade.Text = "Max Grade:"
        '
        'lstGrades
        '
        Me.lstGrades.FormattingEnabled = True
        Me.lstGrades.Location = New System.Drawing.Point(6, 19)
        Me.lstGrades.Name = "lstGrades"
        Me.lstGrades.Size = New System.Drawing.Size(158, 69)
        Me.lstGrades.TabIndex = 0
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(12, 232)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblAverage
        '
        Me.lblAverage.AutoSize = True
        Me.lblAverage.Location = New System.Drawing.Point(18, 42)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(50, 13)
        Me.lblAverage.TabIndex = 4
        Me.lblAverage.Text = "Average:"
        '
        'btnCGrades
        '
        Me.btnCGrades.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCGrades.Location = New System.Drawing.Point(209, 12)
        Me.btnCGrades.Name = "btnCGrades"
        Me.btnCGrades.Size = New System.Drawing.Size(100, 23)
        Me.btnCGrades.TabIndex = 5
        Me.btnCGrades.Text = "Custom Grades"
        Me.btnCGrades.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstOrderedGrades)
        Me.GroupBox1.Location = New System.Drawing.Point(209, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 164)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Grades in Order"
        '
        'lstOrderedGrades
        '
        Me.lstOrderedGrades.FormattingEnabled = True
        Me.lstOrderedGrades.Location = New System.Drawing.Point(7, 19)
        Me.lstOrderedGrades.Name = "lstOrderedGrades"
        Me.lstOrderedGrades.Size = New System.Drawing.Size(187, 134)
        Me.lstOrderedGrades.TabIndex = 0
        '
        'frmAverageGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 262)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCGrades)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpGrades)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.btnCalc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmAverageGrades"
        Me.Text = "Average Of Grades"
        Me.grpGrades.ResumeLayout(False)
        Me.grpGrades.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents grpGrades As System.Windows.Forms.GroupBox
    Friend WithEvents lstGrades As System.Windows.Forms.ListBox
    Friend WithEvents lblMaxGrade As System.Windows.Forms.Label
    Friend WithEvents txtMaxGrade As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents txtMaxGrade2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCGrades As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstOrderedGrades As System.Windows.Forms.ListBox

End Class
