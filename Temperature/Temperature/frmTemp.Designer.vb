<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTemp
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
        Me.lblTempF = New System.Windows.Forms.Label()
        Me.txtTempF = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblTempC = New System.Windows.Forms.Label()
        Me.txtTempC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTempF
        '
        Me.lblTempF.AutoSize = True
        Me.lblTempF.Location = New System.Drawing.Point(12, 9)
        Me.lblTempF.Name = "lblTempF"
        Me.lblTempF.Size = New System.Drawing.Size(129, 13)
        Me.lblTempF.TabIndex = 0
        Me.lblTempF.Text = "Temperature (Fahrenheit):"
        '
        'txtTempF
        '
        Me.txtTempF.Location = New System.Drawing.Point(147, 6)
        Me.txtTempF.Name = "txtTempF"
        Me.txtTempF.Size = New System.Drawing.Size(100, 20)
        Me.txtTempF.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(15, 41)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(232, 35)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert to Celsius"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblTempC
        '
        Me.lblTempC.AutoSize = True
        Me.lblTempC.Location = New System.Drawing.Point(29, 91)
        Me.lblTempC.Name = "lblTempC"
        Me.lblTempC.Size = New System.Drawing.Size(112, 13)
        Me.lblTempC.TabIndex = 3
        Me.lblTempC.Text = "Temperature (Celsius):"
        '
        'txtTempC
        '
        Me.txtTempC.Location = New System.Drawing.Point(147, 88)
        Me.txtTempC.Name = "txtTempC"
        Me.txtTempC.ReadOnly = True
        Me.txtTempC.Size = New System.Drawing.Size(100, 20)
        Me.txtTempC.TabIndex = 4
        '
        'frmTemp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(264, 122)
        Me.Controls.Add(Me.txtTempC)
        Me.Controls.Add(Me.lblTempC)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtTempF)
        Me.Controls.Add(Me.lblTempF)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmTemp"
        Me.Text = "Temperature"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTempF As System.Windows.Forms.Label
    Friend WithEvents txtTempF As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents lblTempC As System.Windows.Forms.Label
    Friend WithEvents txtTempC As System.Windows.Forms.TextBox

End Class
