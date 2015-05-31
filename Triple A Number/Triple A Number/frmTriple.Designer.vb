<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTriple
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
        Me.lblNTT = New System.Windows.Forms.Label()
        Me.txtNTT = New System.Windows.Forms.TextBox()
        Me.lblT = New System.Windows.Forms.Label()
        Me.txtT = New System.Windows.Forms.TextBox()
        Me.btnT = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNTT
        '
        Me.lblNTT.AutoSize = True
        Me.lblNTT.Location = New System.Drawing.Point(13, 13)
        Me.lblNTT.Name = "lblNTT"
        Me.lblNTT.Size = New System.Drawing.Size(92, 13)
        Me.lblNTT.TabIndex = 0
        Me.lblNTT.Text = "Number To Triple:"
        '
        'txtNTT
        '
        Me.txtNTT.Location = New System.Drawing.Point(111, 10)
        Me.txtNTT.Name = "txtNTT"
        Me.txtNTT.Size = New System.Drawing.Size(100, 20)
        Me.txtNTT.TabIndex = 1
        '
        'lblT
        '
        Me.lblT.AutoSize = True
        Me.lblT.Location = New System.Drawing.Point(69, 39)
        Me.lblT.Name = "lblT"
        Me.lblT.Size = New System.Drawing.Size(36, 13)
        Me.lblT.TabIndex = 2
        Me.lblT.Text = "Triple:"
        '
        'txtT
        '
        Me.txtT.Location = New System.Drawing.Point(111, 36)
        Me.txtT.Name = "txtT"
        Me.txtT.ReadOnly = True
        Me.txtT.Size = New System.Drawing.Size(100, 20)
        Me.txtT.TabIndex = 3
        '
        'btnT
        '
        Me.btnT.Location = New System.Drawing.Point(111, 62)
        Me.btnT.Name = "btnT"
        Me.btnT.Size = New System.Drawing.Size(100, 25)
        Me.btnT.TabIndex = 4
        Me.btnT.Text = "Triple"
        Me.btnT.UseVisualStyleBackColor = True
        '
        'frmTriple
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 110)
        Me.Controls.Add(Me.btnT)
        Me.Controls.Add(Me.txtT)
        Me.Controls.Add(Me.lblT)
        Me.Controls.Add(Me.txtNTT)
        Me.Controls.Add(Me.lblNTT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmTriple"
        Me.Text = "Triple A Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNTT As System.Windows.Forms.Label
    Friend WithEvents txtNTT As System.Windows.Forms.TextBox
    Friend WithEvents lblT As System.Windows.Forms.Label
    Friend WithEvents txtT As System.Windows.Forms.TextBox
    Friend WithEvents btnT As System.Windows.Forms.Button

End Class
