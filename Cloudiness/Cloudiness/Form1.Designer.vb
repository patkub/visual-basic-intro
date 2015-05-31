<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCloud
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
        Me.lblPCC = New System.Windows.Forms.Label()
        Me.txtPCC = New System.Windows.Forms.TextBox()
        Me.btnDescribe = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPCC
        '
        Me.lblPCC.AutoSize = True
        Me.lblPCC.Location = New System.Drawing.Point(12, 9)
        Me.lblPCC.Name = "lblPCC"
        Me.lblPCC.Size = New System.Drawing.Size(136, 13)
        Me.lblPCC.TabIndex = 0
        Me.lblPCC.Text = "Percentage of cloud cover:"
        '
        'txtPCC
        '
        Me.txtPCC.Location = New System.Drawing.Point(154, 6)
        Me.txtPCC.Name = "txtPCC"
        Me.txtPCC.Size = New System.Drawing.Size(100, 20)
        Me.txtPCC.TabIndex = 1
        '
        'btnDescribe
        '
        Me.btnDescribe.Location = New System.Drawing.Point(15, 32)
        Me.btnDescribe.Name = "btnDescribe"
        Me.btnDescribe.Size = New System.Drawing.Size(239, 45)
        Me.btnDescribe.TabIndex = 2
        Me.btnDescribe.Text = "Describe Sky Conditions"
        Me.btnDescribe.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(15, 95)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(239, 20)
        Me.txtResult.TabIndex = 3
        '
        'frmCloud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 140)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnDescribe)
        Me.Controls.Add(Me.txtPCC)
        Me.Controls.Add(Me.lblPCC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmCloud"
        Me.Text = "Cloudiness"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPCC As System.Windows.Forms.Label
    Friend WithEvents txtPCC As System.Windows.Forms.TextBox
    Friend WithEvents btnDescribe As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
