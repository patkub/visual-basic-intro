<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReverse
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnReverse = New System.Windows.Forms.Button()
        Me.txtBackward = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(12, 9)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(64, 13)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "Enter Word:"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(82, 6)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(100, 20)
        Me.txtWord.TabIndex = 1
        '
        'btnReverse
        '
        Me.btnReverse.Location = New System.Drawing.Point(12, 32)
        Me.btnReverse.Name = "btnReverse"
        Me.btnReverse.Size = New System.Drawing.Size(170, 30)
        Me.btnReverse.TabIndex = 2
        Me.btnReverse.Text = "Write Backward"
        Me.btnReverse.UseVisualStyleBackColor = True
        '
        'txtBackward
        '
        Me.txtBackward.Location = New System.Drawing.Point(45, 68)
        Me.txtBackward.Name = "txtBackward"
        Me.txtBackward.ReadOnly = True
        Me.txtBackward.Size = New System.Drawing.Size(100, 20)
        Me.txtBackward.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 112)
        Me.Controls.Add(Me.txtBackward)
        Me.Controls.Add(Me.btnReverse)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Write Backward"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents btnReverse As System.Windows.Forms.Button
    Friend WithEvents txtBackward As System.Windows.Forms.TextBox

End Class
