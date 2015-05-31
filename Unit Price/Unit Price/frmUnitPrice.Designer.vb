<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUnitPrice
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
        Me.lblPriceOfItem = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblPounds = New System.Windows.Forms.Label()
        Me.txtPounds = New System.Windows.Forms.TextBox()
        Me.lblOunces = New System.Windows.Forms.Label()
        Me.txtOunces = New System.Windows.Forms.TextBox()
        Me.btnPrice = New System.Windows.Forms.Button()
        Me.lblPricePerOunce = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblPriceOfItem
        '
        Me.lblPriceOfItem.AutoSize = True
        Me.lblPriceOfItem.Location = New System.Drawing.Point(60, 15)
        Me.lblPriceOfItem.Name = "lblPriceOfItem"
        Me.lblPriceOfItem.Size = New System.Drawing.Size(68, 13)
        Me.lblPriceOfItem.TabIndex = 0
        Me.lblPriceOfItem.Text = "Price of item:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(134, 12)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 1
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(106, 47)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(65, 20)
        Me.lblWeight.TabIndex = 2
        Me.lblWeight.Text = "Weight"
        '
        'lblPounds
        '
        Me.lblPounds.AutoSize = True
        Me.lblPounds.Location = New System.Drawing.Point(19, 84)
        Me.lblPounds.Name = "lblPounds"
        Me.lblPounds.Size = New System.Drawing.Size(46, 13)
        Me.lblPounds.TabIndex = 3
        Me.lblPounds.Text = "Pounds:"
        '
        'txtPounds
        '
        Me.txtPounds.Location = New System.Drawing.Point(71, 81)
        Me.txtPounds.Name = "txtPounds"
        Me.txtPounds.Size = New System.Drawing.Size(50, 20)
        Me.txtPounds.TabIndex = 4
        '
        'lblOunces
        '
        Me.lblOunces.AutoSize = True
        Me.lblOunces.Location = New System.Drawing.Point(144, 84)
        Me.lblOunces.Name = "lblOunces"
        Me.lblOunces.Size = New System.Drawing.Size(47, 13)
        Me.lblOunces.TabIndex = 5
        Me.lblOunces.Text = "Ounces:"
        '
        'txtOunces
        '
        Me.txtOunces.Location = New System.Drawing.Point(197, 81)
        Me.txtOunces.Name = "txtOunces"
        Me.txtOunces.Size = New System.Drawing.Size(50, 20)
        Me.txtOunces.TabIndex = 6
        '
        'btnPrice
        '
        Me.btnPrice.Location = New System.Drawing.Point(43, 117)
        Me.btnPrice.Name = "btnPrice"
        Me.btnPrice.Size = New System.Drawing.Size(190, 40)
        Me.btnPrice.TabIndex = 7
        Me.btnPrice.Text = "Determine Unit Price"
        Me.btnPrice.UseVisualStyleBackColor = True
        '
        'lblPricePerOunce
        '
        Me.lblPricePerOunce.AutoSize = True
        Me.lblPricePerOunce.Location = New System.Drawing.Point(40, 174)
        Me.lblPricePerOunce.Name = "lblPricePerOunce"
        Me.lblPricePerOunce.Size = New System.Drawing.Size(85, 13)
        Me.lblPricePerOunce.TabIndex = 8
        Me.lblPricePerOunce.Text = "Price per ounce:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(131, 174)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 9
        '
        'frmUnitPrice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 224)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblPricePerOunce)
        Me.Controls.Add(Me.btnPrice)
        Me.Controls.Add(Me.txtOunces)
        Me.Controls.Add(Me.lblOunces)
        Me.Controls.Add(Me.txtPounds)
        Me.Controls.Add(Me.lblPounds)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblPriceOfItem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmUnitPrice"
        Me.Text = "Unit Price"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPriceOfItem As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents lblPounds As System.Windows.Forms.Label
    Friend WithEvents txtPounds As System.Windows.Forms.TextBox
    Friend WithEvents lblOunces As System.Windows.Forms.Label
    Friend WithEvents txtOunces As System.Windows.Forms.TextBox
    Friend WithEvents btnPrice As System.Windows.Forms.Button
    Friend WithEvents lblPricePerOunce As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
