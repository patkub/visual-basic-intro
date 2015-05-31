<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemps
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
        Me.btnDCTDoWhile = New System.Windows.Forms.Button()
        Me.lstCTable = New System.Windows.Forms.ListBox()
        Me.btnDCTForNext = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDCTDoWhile
        '
        Me.btnDCTDoWhile.Location = New System.Drawing.Point(12, 12)
        Me.btnDCTDoWhile.Name = "btnDCTDoWhile"
        Me.btnDCTDoWhile.Size = New System.Drawing.Size(125, 40)
        Me.btnDCTDoWhile.TabIndex = 0
        Me.btnDCTDoWhile.Text = "Display Conversion Table (Do...While)"
        Me.btnDCTDoWhile.UseVisualStyleBackColor = True
        '
        'lstCTable
        '
        Me.lstCTable.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCTable.FormattingEnabled = True
        Me.lstCTable.ItemHeight = 14
        Me.lstCTable.Location = New System.Drawing.Point(12, 58)
        Me.lstCTable.Name = "lstCTable"
        Me.lstCTable.Size = New System.Drawing.Size(256, 130)
        Me.lstCTable.TabIndex = 1
        '
        'btnDCTForNext
        '
        Me.btnDCTForNext.Location = New System.Drawing.Point(143, 12)
        Me.btnDCTForNext.Name = "btnDCTForNext"
        Me.btnDCTForNext.Size = New System.Drawing.Size(125, 40)
        Me.btnDCTForNext.TabIndex = 2
        Me.btnDCTForNext.Text = "Display Conversion Table (For...Next)"
        Me.btnDCTForNext.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(193, 194)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmTemps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 232)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDCTForNext)
        Me.Controls.Add(Me.lstCTable)
        Me.Controls.Add(Me.btnDCTDoWhile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmTemps"
        Me.Text = "Temperatures"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDCTDoWhile As System.Windows.Forms.Button
    Friend WithEvents lstCTable As System.Windows.Forms.ListBox
    Friend WithEvents btnDCTForNext As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button

End Class
