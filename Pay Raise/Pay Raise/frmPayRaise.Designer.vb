<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayRaise
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
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblCSalary = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtCSalary = New System.Windows.Forms.TextBox()
        Me.btnDNS = New System.Windows.Forms.Button()
        Me.txtNSalary = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(59, 15)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(60, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(58, 41)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(61, 13)
        Me.lblLastName.TabIndex = 1
        Me.lblLastName.Text = "Last Name:"
        '
        'lblCSalary
        '
        Me.lblCSalary.AutoSize = True
        Me.lblCSalary.Location = New System.Drawing.Point(43, 67)
        Me.lblCSalary.Name = "lblCSalary"
        Me.lblCSalary.Size = New System.Drawing.Size(76, 13)
        Me.lblCSalary.TabIndex = 2
        Me.lblCSalary.Text = "Current Salary:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(125, 12)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 3
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(125, 38)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 4
        '
        'txtCSalary
        '
        Me.txtCSalary.Location = New System.Drawing.Point(125, 64)
        Me.txtCSalary.Name = "txtCSalary"
        Me.txtCSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtCSalary.TabIndex = 5
        '
        'btnDNS
        '
        Me.btnDNS.Location = New System.Drawing.Point(46, 90)
        Me.btnDNS.Name = "btnDNS"
        Me.btnDNS.Size = New System.Drawing.Size(179, 50)
        Me.btnDNS.TabIndex = 6
        Me.btnDNS.Text = "Display New Salary"
        Me.btnDNS.UseVisualStyleBackColor = True
        '
        'txtNSalary
        '
        Me.txtNSalary.Location = New System.Drawing.Point(12, 146)
        Me.txtNSalary.Name = "txtNSalary"
        Me.txtNSalary.ReadOnly = True
        Me.txtNSalary.Size = New System.Drawing.Size(250, 20)
        Me.txtNSalary.TabIndex = 7
        '
        'frmPayRaise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 212)
        Me.Controls.Add(Me.txtNSalary)
        Me.Controls.Add(Me.btnDNS)
        Me.Controls.Add(Me.txtCSalary)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblCSalary)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "frmPayRaise"
        Me.Text = "Pay Raise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents lblCSalary As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtCSalary As System.Windows.Forms.TextBox
    Friend WithEvents btnDNS As System.Windows.Forms.Button
    Friend WithEvents txtNSalary As System.Windows.Forms.TextBox

End Class
