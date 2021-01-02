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
        Me.txtGroupSize = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtPrices = New System.Windows.Forms.ListBox()
        Me.lblPricesLabel = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtGroupSize
        '
        Me.txtGroupSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGroupSize.Location = New System.Drawing.Point(503, 206)
        Me.txtGroupSize.Name = "txtGroupSize"
        Me.txtGroupSize.Size = New System.Drawing.Size(115, 26)
        Me.txtGroupSize.TabIndex = 0
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(517, 238)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 27)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtPrices
        '
        Me.txtPrices.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrices.FormattingEnabled = True
        Me.txtPrices.ItemHeight = 25
        Me.txtPrices.Items.AddRange(New Object() {"1-8        $249", "9-12      $219", "13-24    $199", "25-99    $169"})
        Me.txtPrices.Location = New System.Drawing.Point(120, 174)
        Me.txtPrices.Name = "txtPrices"
        Me.txtPrices.Size = New System.Drawing.Size(147, 104)
        Me.txtPrices.TabIndex = 3
        '
        'lblPricesLabel
        '
        Me.lblPricesLabel.AutoSize = True
        Me.lblPricesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPricesLabel.Location = New System.Drawing.Point(90, 146)
        Me.lblPricesLabel.Name = "lblPricesLabel"
        Me.lblPricesLabel.Size = New System.Drawing.Size(209, 25)
        Me.lblPricesLabel.TabIndex = 4
        Me.lblPricesLabel.Text = "Group Size $/person"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(190, 24)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(403, 55)
        Me.lblMain.TabIndex = 5
        Me.lblMain.Text = "Broadway Tickets"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(593, 310)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 24)
        Me.lblTotal.TabIndex = 6
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(524, 310)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(63, 24)
        Me.lblPrice.TabIndex = 7
        Me.lblPrice.Text = "Price: "
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.lblPricesLabel)
        Me.Controls.Add(Me.txtPrices)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtGroupSize)
        Me.Name = "frmMain"
        Me.Text = "Broadway Tickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtGroupSize As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtPrices As ListBox
    Friend WithEvents lblPricesLabel As Label
    Friend WithEvents lblMain As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblPrice As Label
End Class
