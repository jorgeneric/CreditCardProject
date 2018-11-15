<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblHeadline = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCurrentBal = New System.Windows.Forms.TextBox()
        Me.txt90Days = New System.Windows.Forms.TextBox()
        Me.txt60Days = New System.Windows.Forms.TextBox()
        Me.txtPenalty = New System.Windows.Forms.TextBox()
        Me.txtInterest = New System.Windows.Forms.TextBox()
        Me.txtNewBal = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblDeadbeat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHeadline
        '
        Me.lblHeadline.AutoSize = True
        Me.lblHeadline.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeadline.Location = New System.Drawing.Point(225, 94)
        Me.lblHeadline.Name = "lblHeadline"
        Me.lblHeadline.Size = New System.Drawing.Size(304, 24)
        Me.lblHeadline.TabIndex = 0
        Me.lblHeadline.Text = "Credit Card Penalty and Interest"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Current Balance"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Past Due 90 Days"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(96, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Past Due 60 Days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(96, 346)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Penalty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(96, 392)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Interest"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(96, 438)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "New Balance Owed"
        '
        'txtCurrentBal
        '
        Me.txtCurrentBal.Location = New System.Drawing.Point(229, 165)
        Me.txtCurrentBal.Name = "txtCurrentBal"
        Me.txtCurrentBal.Size = New System.Drawing.Size(79, 20)
        Me.txtCurrentBal.TabIndex = 0
        '
        'txt90Days
        '
        Me.txt90Days.Location = New System.Drawing.Point(229, 213)
        Me.txt90Days.Name = "txt90Days"
        Me.txt90Days.Size = New System.Drawing.Size(79, 20)
        Me.txt90Days.TabIndex = 1
        '
        'txt60Days
        '
        Me.txt60Days.Location = New System.Drawing.Point(229, 260)
        Me.txt60Days.Name = "txt60Days"
        Me.txt60Days.Size = New System.Drawing.Size(79, 20)
        Me.txt60Days.TabIndex = 2
        '
        'txtPenalty
        '
        Me.txtPenalty.BackColor = System.Drawing.Color.SandyBrown
        Me.txtPenalty.Enabled = False
        Me.txtPenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenalty.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPenalty.Location = New System.Drawing.Point(229, 339)
        Me.txtPenalty.Name = "txtPenalty"
        Me.txtPenalty.Size = New System.Drawing.Size(79, 20)
        Me.txtPenalty.TabIndex = 10
        Me.txtPenalty.TabStop = False
        '
        'txtInterest
        '
        Me.txtInterest.BackColor = System.Drawing.Color.SandyBrown
        Me.txtInterest.Enabled = False
        Me.txtInterest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInterest.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInterest.Location = New System.Drawing.Point(229, 385)
        Me.txtInterest.Name = "txtInterest"
        Me.txtInterest.Size = New System.Drawing.Size(79, 20)
        Me.txtInterest.TabIndex = 11
        Me.txtInterest.TabStop = False
        '
        'txtNewBal
        '
        Me.txtNewBal.BackColor = System.Drawing.Color.SandyBrown
        Me.txtNewBal.Enabled = False
        Me.txtNewBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewBal.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNewBal.Location = New System.Drawing.Point(229, 431)
        Me.txtNewBal.Name = "txtNewBal"
        Me.txtNewBal.Size = New System.Drawing.Size(79, 20)
        Me.txtNewBal.TabIndex = 12
        Me.txtNewBal.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(468, 165)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(92, 40)
        Me.btnCalculate.TabIndex = 3
        Me.btnCalculate.Text = "Calculate New Balance"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(468, 236)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(92, 37)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(468, 307)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 37)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblDeadbeat
        '
        Me.lblDeadbeat.AutoSize = True
        Me.lblDeadbeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeadbeat.ForeColor = System.Drawing.Color.Red
        Me.lblDeadbeat.Location = New System.Drawing.Point(332, 218)
        Me.lblDeadbeat.Name = "lblDeadbeat"
        Me.lblDeadbeat.Size = New System.Drawing.Size(113, 13)
        Me.lblDeadbeat.TabIndex = 13
        Me.lblDeadbeat.Text = "Deadbeat Account"
        Me.lblDeadbeat.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 667)
        Me.Controls.Add(Me.lblDeadbeat)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtNewBal)
        Me.Controls.Add(Me.txtInterest)
        Me.Controls.Add(Me.txtPenalty)
        Me.Controls.Add(Me.txt60Days)
        Me.Controls.Add(Me.txt90Days)
        Me.Controls.Add(Me.txtCurrentBal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHeadline)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeadline As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtCurrentBal As TextBox
    Friend WithEvents txt90Days As TextBox
    Friend WithEvents txt60Days As TextBox
    Friend WithEvents txtPenalty As TextBox
    Friend WithEvents txtInterest As TextBox
    Friend WithEvents txtNewBal As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblDeadbeat As Label
End Class
