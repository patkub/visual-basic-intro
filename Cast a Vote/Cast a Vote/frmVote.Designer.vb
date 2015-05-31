<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVote
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
        Me.grpPresident = New System.Windows.Forms.GroupBox()
        Me.radNixon = New System.Windows.Forms.RadioButton()
        Me.radKennedy = New System.Windows.Forms.RadioButton()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnVote = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.grpPresident.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpPresident
        '
        Me.grpPresident.Controls.Add(Me.radNixon)
        Me.grpPresident.Controls.Add(Me.radKennedy)
        Me.grpPresident.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPresident.Location = New System.Drawing.Point(34, 12)
        Me.grpPresident.Name = "grpPresident"
        Me.grpPresident.Size = New System.Drawing.Size(203, 86)
        Me.grpPresident.TabIndex = 0
        Me.grpPresident.TabStop = False
        Me.grpPresident.Text = "President"
        '
        'radNixon
        '
        Me.radNixon.AutoSize = True
        Me.radNixon.Location = New System.Drawing.Point(31, 53)
        Me.radNixon.Name = "radNixon"
        Me.radNixon.Size = New System.Drawing.Size(60, 20)
        Me.radNixon.TabIndex = 1
        Me.radNixon.Text = "Nixon"
        Me.radNixon.UseVisualStyleBackColor = True
        '
        'radKennedy
        '
        Me.radKennedy.AutoSize = True
        Me.radKennedy.Location = New System.Drawing.Point(31, 20)
        Me.radKennedy.Name = "radKennedy"
        Me.radKennedy.Size = New System.Drawing.Size(79, 20)
        Me.radKennedy.TabIndex = 0
        Me.radKennedy.Text = "Kennedy"
        Me.radKennedy.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(34, 122)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(203, 35)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Selected Candidate"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnVote
        '
        Me.btnVote.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnVote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVote.Location = New System.Drawing.Point(65, 178)
        Me.btnVote.Name = "btnVote"
        Me.btnVote.Size = New System.Drawing.Size(146, 43)
        Me.btnVote.TabIndex = 2
        Me.btnVote.Text = "Cast Vote"
        Me.btnVote.UseVisualStyleBackColor = False
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(34, 245)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(203, 20)
        Me.txtResult.TabIndex = 3
        '
        'frmVote
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 287)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnVote)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.grpPresident)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmVote"
        Me.Text = "Vote for One"
        Me.grpPresident.ResumeLayout(False)
        Me.grpPresident.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpPresident As System.Windows.Forms.GroupBox
    Friend WithEvents radNixon As System.Windows.Forms.RadioButton
    Friend WithEvents radKennedy As System.Windows.Forms.RadioButton
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnVote As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
