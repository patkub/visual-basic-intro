<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHurricane
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
        Me.lblSpeed = New System.Windows.Forms.Label()
        Me.txtSpeed = New System.Windows.Forms.TextBox()
        Me.btnDHR = New System.Windows.Forms.Button()
        Me.txtCategory = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblSpeed
        '
        Me.lblSpeed.AutoSize = True
        Me.lblSpeed.Location = New System.Drawing.Point(31, 13)
        Me.lblSpeed.Name = "lblSpeed"
        Me.lblSpeed.Size = New System.Drawing.Size(69, 13)
        Me.lblSpeed.TabIndex = 0
        Me.lblSpeed.Text = "Wind Speed:"
        '
        'txtSpeed
        '
        Me.txtSpeed.Location = New System.Drawing.Point(106, 10)
        Me.txtSpeed.Name = "txtSpeed"
        Me.txtSpeed.Size = New System.Drawing.Size(100, 20)
        Me.txtSpeed.TabIndex = 1
        '
        'btnDHR
        '
        Me.btnDHR.Location = New System.Drawing.Point(12, 38)
        Me.btnDHR.Name = "btnDHR"
        Me.btnDHR.Size = New System.Drawing.Size(230, 35)
        Me.btnDHR.TabIndex = 2
        Me.btnDHR.Text = "Determine Hurricane Rating"
        Me.btnDHR.UseVisualStyleBackColor = True
        '
        'txtCategory
        '
        Me.txtCategory.Location = New System.Drawing.Point(34, 79)
        Me.txtCategory.Name = "txtCategory"
        Me.txtCategory.ReadOnly = True
        Me.txtCategory.Size = New System.Drawing.Size(180, 20)
        Me.txtCategory.TabIndex = 3
        '
        'frmHurricane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 122)
        Me.Controls.Add(Me.txtCategory)
        Me.Controls.Add(Me.btnDHR)
        Me.Controls.Add(Me.txtSpeed)
        Me.Controls.Add(Me.lblSpeed)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmHurricane"
        Me.Text = "Hurricane"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSpeed As System.Windows.Forms.Label
    Friend WithEvents txtSpeed As System.Windows.Forms.TextBox
    Friend WithEvents btnDHR As System.Windows.Forms.Button
    Friend WithEvents txtCategory As System.Windows.Forms.TextBox

End Class
