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
        Me.picMain = New System.Windows.Forms.PictureBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNights = New System.Windows.Forms.Label()
        Me.lblCostOfStay = New System.Windows.Forms.Label()
        Me.txtNumNights = New System.Windows.Forms.TextBox()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpMain = New System.Windows.Forms.GroupBox()
        Me.radDeluxe = New System.Windows.Forms.RadioButton()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'picMain
        '
        Me.picMain.Image = Global.Chapter4_Assignment1.My.Resources.Resources.airbnb
        Me.picMain.Location = New System.Drawing.Point(0, 0)
        Me.picMain.Margin = New System.Windows.Forms.Padding(4)
        Me.picMain.Name = "picMain"
        Me.picMain.Size = New System.Drawing.Size(551, 627)
        Me.picMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMain.TabIndex = 0
        Me.picMain.TabStop = False
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Palatino Linotype", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(655, 21)
        Me.lblMain.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(299, 50)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "Orlando AirBnB"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(705, 91)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(218, 28)
        Me.lblPrice.TabIndex = 2
        Me.lblPrice.Text = "only $79.00 per night"
        Me.lblPrice.Visible = False
        '
        'lblNights
        '
        Me.lblNights.AutoSize = True
        Me.lblNights.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNights.Location = New System.Drawing.Point(665, 349)
        Me.lblNights.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNights.Name = "lblNights"
        Me.lblNights.Size = New System.Drawing.Size(150, 22)
        Me.lblNights.TabIndex = 3
        Me.lblNights.Text = "Number of Nights:"
        '
        'lblCostOfStay
        '
        Me.lblCostOfStay.AutoSize = True
        Me.lblCostOfStay.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostOfStay.Location = New System.Drawing.Point(665, 430)
        Me.lblCostOfStay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCostOfStay.Name = "lblCostOfStay"
        Me.lblCostOfStay.Size = New System.Drawing.Size(104, 22)
        Me.lblCostOfStay.TabIndex = 4
        Me.lblCostOfStay.Text = "Cost of Stay:"
        '
        'txtNumNights
        '
        Me.txtNumNights.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.txtNumNights.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumNights.Location = New System.Drawing.Point(893, 346)
        Me.txtNumNights.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumNights.Name = "txtNumNights"
        Me.txtNumNights.Size = New System.Drawing.Size(48, 29)
        Me.txtNumNights.TabIndex = 5
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(889, 430)
        Me.lblCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(0, 22)
        Me.lblCost.TabIndex = 6
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.Location = New System.Drawing.Point(629, 493)
        Me.btnDisplayCost.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(100, 32)
        Me.btnDisplayCost.TabIndex = 7
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(761, 493)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 32)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(893, 493)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 32)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'grpMain
        '
        Me.grpMain.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.grpMain.Controls.Add(Me.radDeluxe)
        Me.grpMain.Controls.Add(Me.radStandard)
        Me.grpMain.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpMain.Location = New System.Drawing.Point(703, 153)
        Me.grpMain.Name = "grpMain"
        Me.grpMain.Size = New System.Drawing.Size(220, 122)
        Me.grpMain.TabIndex = 10
        Me.grpMain.TabStop = False
        Me.grpMain.Text = "Room Type"
        '
        'radDeluxe
        '
        Me.radDeluxe.AutoSize = True
        Me.radDeluxe.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radDeluxe.Location = New System.Drawing.Point(20, 73)
        Me.radDeluxe.Name = "radDeluxe"
        Me.radDeluxe.Size = New System.Drawing.Size(80, 26)
        Me.radDeluxe.TabIndex = 1
        Me.radDeluxe.Text = "Deluxe"
        Me.radDeluxe.UseVisualStyleBackColor = True
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Checked = True
        Me.radStandard.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radStandard.Location = New System.Drawing.Point(20, 34)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(97, 26)
        Me.radStandard.TabIndex = 0
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnDisplayCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(1067, 623)
        Me.Controls.Add(Me.grpMain)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.txtNumNights)
        Me.Controls.Add(Me.lblCostOfStay)
        Me.Controls.Add(Me.lblNights)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.picMain)
        Me.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMain"
        Me.Text = "AirBnB Reservations"
        CType(Me.picMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMain.ResumeLayout(False)
        Me.grpMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picMain As PictureBox
    Friend WithEvents lblMain As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNights As Label
    Friend WithEvents lblCostOfStay As Label
    Friend WithEvents txtNumNights As TextBox
    Friend WithEvents lblCost As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents grpMain As GroupBox
    Friend WithEvents radDeluxe As RadioButton
    Friend WithEvents radStandard As RadioButton
End Class
