<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputer
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
        Me.grpModel = New System.Windows.Forms.GroupBox()
        Me.radDeluxe = New System.Windows.Forms.RadioButton()
        Me.radSuper = New System.Windows.Forms.RadioButton()
        Me.chkVideo = New System.Windows.Forms.CheckBox()
        Me.chkInternet = New System.Windows.Forms.CheckBox()
        Me.chkMemory = New System.Windows.Forms.CheckBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.grpModel.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpModel
        '
        Me.grpModel.Controls.Add(Me.radSuper)
        Me.grpModel.Controls.Add(Me.radDeluxe)
        Me.grpModel.Location = New System.Drawing.Point(41, 12)
        Me.grpModel.Name = "grpModel"
        Me.grpModel.Size = New System.Drawing.Size(200, 45)
        Me.grpModel.TabIndex = 0
        Me.grpModel.TabStop = False
        Me.grpModel.Text = "Model"
        '
        'radDeluxe
        '
        Me.radDeluxe.AutoSize = True
        Me.radDeluxe.Location = New System.Drawing.Point(30, 19)
        Me.radDeluxe.Name = "radDeluxe"
        Me.radDeluxe.Size = New System.Drawing.Size(58, 17)
        Me.radDeluxe.TabIndex = 0
        Me.radDeluxe.TabStop = True
        Me.radDeluxe.Text = "Deluxe"
        Me.radDeluxe.UseVisualStyleBackColor = True
        '
        'radSuper
        '
        Me.radSuper.AutoSize = True
        Me.radSuper.Location = New System.Drawing.Point(119, 19)
        Me.radSuper.Name = "radSuper"
        Me.radSuper.Size = New System.Drawing.Size(53, 17)
        Me.radSuper.TabIndex = 1
        Me.radSuper.TabStop = True
        Me.radSuper.Text = "Super"
        Me.radSuper.UseVisualStyleBackColor = True
        '
        'chkVideo
        '
        Me.chkVideo.AutoSize = True
        Me.chkVideo.Location = New System.Drawing.Point(48, 79)
        Me.chkVideo.Name = "chkVideo"
        Me.chkVideo.Size = New System.Drawing.Size(128, 17)
        Me.chkVideo.TabIndex = 1
        Me.chkVideo.Text = "Upgraded Video Card"
        Me.chkVideo.UseVisualStyleBackColor = True
        '
        'chkInternet
        '
        Me.chkInternet.AutoSize = True
        Me.chkInternet.Location = New System.Drawing.Point(48, 103)
        Me.chkInternet.Name = "chkInternet"
        Me.chkInternet.Size = New System.Drawing.Size(135, 17)
        Me.chkInternet.TabIndex = 2
        Me.chkInternet.Text = "Internal Modem + Wi-Fi"
        Me.chkInternet.UseVisualStyleBackColor = True
        '
        'chkMemory
        '
        Me.chkMemory.AutoSize = True
        Me.chkMemory.Location = New System.Drawing.Point(48, 127)
        Me.chkMemory.Name = "chkMemory"
        Me.chkMemory.Size = New System.Drawing.Size(139, 17)
        Me.chkMemory.TabIndex = 3
        Me.chkMemory.Text = "1 GB Additional Memory"
        Me.chkMemory.UseVisualStyleBackColor = True
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(68, 163)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(132, 160)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ReadOnly = True
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 5
        '
        'frmComputer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 212)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.chkMemory)
        Me.Controls.Add(Me.chkInternet)
        Me.Controls.Add(Me.chkVideo)
        Me.Controls.Add(Me.grpModel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmComputer"
        Me.Text = "Computer"
        Me.grpModel.ResumeLayout(False)
        Me.grpModel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpModel As System.Windows.Forms.GroupBox
    Friend WithEvents radSuper As System.Windows.Forms.RadioButton
    Friend WithEvents radDeluxe As System.Windows.Forms.RadioButton
    Friend WithEvents chkVideo As System.Windows.Forms.CheckBox
    Friend WithEvents chkInternet As System.Windows.Forms.CheckBox
    Friend WithEvents chkMemory As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalCost As System.Windows.Forms.Label
    Friend WithEvents txtResult As System.Windows.Forms.TextBox

End Class
