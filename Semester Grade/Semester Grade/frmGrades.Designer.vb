<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGrades
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblGrade1 = New System.Windows.Forms.Label()
        Me.lblGrade2 = New System.Windows.Forms.Label()
        Me.lblGrade3 = New System.Windows.Forms.Label()
        Me.txtGrade1 = New System.Windows.Forms.TextBox()
        Me.txtGrade2 = New System.Windows.Forms.TextBox()
        Me.txtGrade3 = New System.Windows.Forms.TextBox()
        Me.btnDSG = New System.Windows.Forms.Button()
        Me.txtSemGrade = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(39, 9)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(38, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(83, 6)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(150, 20)
        Me.txtName.TabIndex = 1
        '
        'lblGrade1
        '
        Me.lblGrade1.AutoSize = True
        Me.lblGrade1.Location = New System.Drawing.Point(80, 35)
        Me.lblGrade1.Name = "lblGrade1"
        Me.lblGrade1.Size = New System.Drawing.Size(61, 13)
        Me.lblGrade1.TabIndex = 2
        Me.lblGrade1.Text = "First Grade:"
        '
        'lblGrade2
        '
        Me.lblGrade2.AutoSize = True
        Me.lblGrade2.Location = New System.Drawing.Point(62, 64)
        Me.lblGrade2.Name = "lblGrade2"
        Me.lblGrade2.Size = New System.Drawing.Size(79, 13)
        Me.lblGrade2.TabIndex = 3
        Me.lblGrade2.Text = "Second Grade:"
        '
        'lblGrade3
        '
        Me.lblGrade3.AutoSize = True
        Me.lblGrade3.Location = New System.Drawing.Point(75, 90)
        Me.lblGrade3.Name = "lblGrade3"
        Me.lblGrade3.Size = New System.Drawing.Size(66, 13)
        Me.lblGrade3.TabIndex = 4
        Me.lblGrade3.Text = "Third Grade:"
        '
        'txtGrade1
        '
        Me.txtGrade1.Location = New System.Drawing.Point(147, 32)
        Me.txtGrade1.Name = "txtGrade1"
        Me.txtGrade1.Size = New System.Drawing.Size(30, 20)
        Me.txtGrade1.TabIndex = 5
        '
        'txtGrade2
        '
        Me.txtGrade2.Location = New System.Drawing.Point(147, 61)
        Me.txtGrade2.Name = "txtGrade2"
        Me.txtGrade2.Size = New System.Drawing.Size(30, 20)
        Me.txtGrade2.TabIndex = 6
        '
        'txtGrade3
        '
        Me.txtGrade3.Location = New System.Drawing.Point(147, 87)
        Me.txtGrade3.Name = "txtGrade3"
        Me.txtGrade3.Size = New System.Drawing.Size(30, 20)
        Me.txtGrade3.TabIndex = 7
        '
        'btnDSG
        '
        Me.btnDSG.Location = New System.Drawing.Point(42, 113)
        Me.btnDSG.Name = "btnDSG"
        Me.btnDSG.Size = New System.Drawing.Size(180, 30)
        Me.btnDSG.TabIndex = 8
        Me.btnDSG.Text = "Determine Semester Grade"
        Me.btnDSG.UseVisualStyleBackColor = True
        '
        'txtSemGrade
        '
        Me.txtSemGrade.Location = New System.Drawing.Point(83, 149)
        Me.txtSemGrade.Name = "txtSemGrade"
        Me.txtSemGrade.ReadOnly = True
        Me.txtSemGrade.Size = New System.Drawing.Size(100, 20)
        Me.txtSemGrade.TabIndex = 9
        '
        'frmGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 212)
        Me.Controls.Add(Me.txtSemGrade)
        Me.Controls.Add(Me.btnDSG)
        Me.Controls.Add(Me.txtGrade3)
        Me.Controls.Add(Me.txtGrade2)
        Me.Controls.Add(Me.txtGrade1)
        Me.Controls.Add(Me.lblGrade3)
        Me.Controls.Add(Me.lblGrade2)
        Me.Controls.Add(Me.lblGrade1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmGrades"
        Me.Text = "Grades"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblGrade1 As System.Windows.Forms.Label
    Friend WithEvents lblGrade2 As System.Windows.Forms.Label
    Friend WithEvents lblGrade3 As System.Windows.Forms.Label
    Friend WithEvents txtGrade1 As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade2 As System.Windows.Forms.TextBox
    Friend WithEvents txtGrade3 As System.Windows.Forms.TextBox
    Friend WithEvents btnDSG As System.Windows.Forms.Button
    Friend WithEvents txtSemGrade As System.Windows.Forms.TextBox

End Class
