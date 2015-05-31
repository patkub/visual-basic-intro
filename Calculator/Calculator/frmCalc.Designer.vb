<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalc
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
        Me.lblFirstNum = New System.Windows.Forms.Label()
        Me.lblSecondNum = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSub = New System.Windows.Forms.Button()
        Me.btnMulti = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.mtbFirstNum = New System.Windows.Forms.MaskedTextBox()
        Me.mtbSecondNum = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'lblFirstNum
        '
        Me.lblFirstNum.AutoSize = True
        Me.lblFirstNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstNum.Location = New System.Drawing.Point(12, 42)
        Me.lblFirstNum.Name = "lblFirstNum"
        Me.lblFirstNum.Size = New System.Drawing.Size(104, 20)
        Me.lblFirstNum.TabIndex = 0
        Me.lblFirstNum.Text = "First Number:"
        '
        'lblSecondNum
        '
        Me.lblSecondNum.AutoSize = True
        Me.lblSecondNum.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecondNum.Location = New System.Drawing.Point(395, 42)
        Me.lblSecondNum.Name = "lblSecondNum"
        Me.lblSecondNum.Size = New System.Drawing.Size(128, 20)
        Me.lblSecondNum.TabIndex = 2
        Me.lblSecondNum.Text = "Second Number:"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(255, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(50, 50)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSub
        '
        Me.btnSub.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSub.Location = New System.Drawing.Point(255, 68)
        Me.btnSub.Name = "btnSub"
        Me.btnSub.Size = New System.Drawing.Size(50, 50)
        Me.btnSub.TabIndex = 5
        Me.btnSub.Text = "-"
        Me.btnSub.UseVisualStyleBackColor = True
        '
        'btnMulti
        '
        Me.btnMulti.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMulti.Location = New System.Drawing.Point(255, 124)
        Me.btnMulti.Name = "btnMulti"
        Me.btnMulti.Size = New System.Drawing.Size(50, 50)
        Me.btnMulti.TabIndex = 6
        Me.btnMulti.Text = "*"
        Me.btnMulti.UseVisualStyleBackColor = True
        '
        'btnDiv
        '
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(255, 180)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(50, 50)
        Me.btnDiv.TabIndex = 7
        Me.btnDiv.Text = "÷"
        Me.btnDiv.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(12, 260)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(560, 20)
        Me.txtOutput.TabIndex = 8
        '
        'mtbFirstNum
        '
        Me.mtbFirstNum.Location = New System.Drawing.Point(16, 94)
        Me.mtbFirstNum.Mask = "0000000000000000000000000"
        Me.mtbFirstNum.Name = "mtbFirstNum"
        Me.mtbFirstNum.Size = New System.Drawing.Size(160, 20)
        Me.mtbFirstNum.TabIndex = 10
        '
        'mtbSecondNum
        '
        Me.mtbSecondNum.Location = New System.Drawing.Point(399, 94)
        Me.mtbSecondNum.Mask = "0000000000000000000000000"
        Me.mtbSecondNum.Name = "mtbSecondNum"
        Me.mtbSecondNum.Size = New System.Drawing.Size(160, 20)
        Me.mtbSecondNum.TabIndex = 11
        '
        'frmCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 312)
        Me.Controls.Add(Me.mtbSecondNum)
        Me.Controls.Add(Me.mtbFirstNum)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnMulti)
        Me.Controls.Add(Me.btnSub)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblSecondNum)
        Me.Controls.Add(Me.lblFirstNum)
        Me.Name = "frmCalc"
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstNum As System.Windows.Forms.Label
    Friend WithEvents lblSecondNum As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSub As System.Windows.Forms.Button
    Friend WithEvents btnMulti As System.Windows.Forms.Button
    Friend WithEvents btnDiv As System.Windows.Forms.Button
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents mtbFirstNum As System.Windows.Forms.MaskedTextBox
    Friend WithEvents mtbSecondNum As System.Windows.Forms.MaskedTextBox

End Class
