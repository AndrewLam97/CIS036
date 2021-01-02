<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.cboMonths = New System.Windows.Forms.ComboBox()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblAvg = New System.Windows.Forms.Label()
        Me.lblMost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStatistics
        '
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.Location = New System.Drawing.Point(55, 224)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(178, 31)
        Me.btnStatistics.TabIndex = 0
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        Me.btnStatistics.Visible = False
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(12, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(366, 31)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "Smart Home Electric Savings"
        '
        'cboMonths
        '
        Me.cboMonths.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonths.FormattingEnabled = True
        Me.cboMonths.Items.AddRange(New Object() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cboMonths.Location = New System.Drawing.Point(45, 103)
        Me.cboMonths.Name = "cboMonths"
        Me.cboMonths.Size = New System.Drawing.Size(121, 28)
        Me.cboMonths.TabIndex = 2
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(41, 177)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(248, 20)
        Me.lblMonth.TabIndex = 3
        Me.lblMonth.Text = "The electric savings for -----: $xx.xx"
        '
        'lblAvg
        '
        Me.lblAvg.AutoSize = True
        Me.lblAvg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvg.Location = New System.Drawing.Point(51, 279)
        Me.lblAvg.Name = "lblAvg"
        Me.lblAvg.Size = New System.Drawing.Size(262, 20)
        Me.lblAvg.TabIndex = 4
        Me.lblAvg.Text = "The average monthly savings: $xx.xx"
        Me.lblAvg.Visible = False
        '
        'lblMost
        '
        Me.lblMost.AutoSize = True
        Me.lblMost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMost.Location = New System.Drawing.Point(51, 320)
        Me.lblMost.Name = "lblMost"
        Me.lblMost.Size = New System.Drawing.Size(322, 20)
        Me.lblMost.TabIndex = 5
        Me.lblMost.Text = "----- had the most significant monthly savings"
        Me.lblMost.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Ch8_1.My.Resources.Resources.smarthome
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMost)
        Me.Controls.Add(Me.lblAvg)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.cboMonths)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnStatistics)
        Me.Name = "frmMain"
        Me.Text = "Smart Home Monthly Electric Savings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblMain As Label
    Friend WithEvents cboMonths As ComboBox
    Friend WithEvents lblMonth As Label
    Friend WithEvents lblAvg As Label
    Friend WithEvents lblMost As Label
End Class
