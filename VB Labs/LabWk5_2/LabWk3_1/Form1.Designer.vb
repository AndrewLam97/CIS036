<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.picMango = New System.Windows.Forms.PictureBox()
        Me.picApple = New System.Windows.Forms.PictureBox()
        Me.lblPrompt = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblApple = New System.Windows.Forms.Label()
        Me.lblMango = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblQuantApple = New System.Windows.Forms.Label()
        Me.txtFruitQuant = New System.Windows.Forms.MaskedTextBox()
        Me.grpFruits = New System.Windows.Forms.GroupBox()
        Me.radMango = New System.Windows.Forms.RadioButton()
        Me.radApple = New System.Windows.Forms.RadioButton()
        CType(Me.picMango, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picApple, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFruits.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Enabled = False
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(602, 369)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 30)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(284, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(232, 42)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "Fruity Fruits"
        '
        'btnCalculate
        '
        Me.btnCalculate.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(344, 332)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(113, 29)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'picMango
        '
        Me.picMango.Image = Global.LabWk5_2.My.Resources.Resources.mango
        Me.picMango.Location = New System.Drawing.Point(487, 69)
        Me.picMango.Name = "picMango"
        Me.picMango.Size = New System.Drawing.Size(221, 205)
        Me.picMango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picMango.TabIndex = 5
        Me.picMango.TabStop = False
        '
        'picApple
        '
        Me.picApple.Image = Global.LabWk5_2.My.Resources.Resources.apple
        Me.picApple.Location = New System.Drawing.Point(86, 69)
        Me.picApple.Name = "picApple"
        Me.picApple.Size = New System.Drawing.Size(221, 205)
        Me.picApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picApple.TabIndex = 4
        Me.picApple.TabStop = False
        '
        'lblPrompt
        '
        Me.lblPrompt.AutoSize = True
        Me.lblPrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrompt.ForeColor = System.Drawing.Color.SeaGreen
        Me.lblPrompt.Location = New System.Drawing.Point(318, 53)
        Me.lblPrompt.Name = "lblPrompt"
        Me.lblPrompt.Size = New System.Drawing.Size(164, 20)
        Me.lblPrompt.TabIndex = 0
        Me.lblPrompt.Text = "Enter quantity desired"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(522, 332)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(48, 20)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.Color.Gold
        Me.txtTotal.Location = New System.Drawing.Point(567, 332)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 7
        '
        'lblApple
        '
        Me.lblApple.AutoSize = True
        Me.lblApple.Location = New System.Drawing.Point(187, 53)
        Me.lblApple.Name = "lblApple"
        Me.lblApple.Size = New System.Drawing.Size(19, 13)
        Me.lblApple.TabIndex = 8
        Me.lblApple.Text = "$1"
        '
        'lblMango
        '
        Me.lblMango.AutoSize = True
        Me.lblMango.Location = New System.Drawing.Point(588, 53)
        Me.lblMango.Name = "lblMango"
        Me.lblMango.Size = New System.Drawing.Size(19, 13)
        Me.lblMango.TabIndex = 9
        Me.lblMango.Text = "$2"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(521, 369)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 30)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "C&lear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblQuantApple
        '
        Me.lblQuantApple.AutoSize = True
        Me.lblQuantApple.Location = New System.Drawing.Point(149, 388)
        Me.lblQuantApple.Name = "lblQuantApple"
        Me.lblQuantApple.Size = New System.Drawing.Size(52, 13)
        Me.lblQuantApple.TabIndex = 0
        Me.lblQuantApple.Text = "Quantity: "
        '
        'txtFruitQuant
        '
        Me.txtFruitQuant.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite
        Me.txtFruitQuant.Location = New System.Drawing.Point(207, 385)
        Me.txtFruitQuant.Mask = "00000"
        Me.txtFruitQuant.Name = "txtFruitQuant"
        Me.txtFruitQuant.Size = New System.Drawing.Size(30, 20)
        Me.txtFruitQuant.TabIndex = 0
        Me.txtFruitQuant.ValidatingType = GetType(Integer)
        '
        'grpFruits
        '
        Me.grpFruits.Controls.Add(Me.radMango)
        Me.grpFruits.Controls.Add(Me.radApple)
        Me.grpFruits.Location = New System.Drawing.Point(138, 312)
        Me.grpFruits.Name = "grpFruits"
        Me.grpFruits.Size = New System.Drawing.Size(119, 67)
        Me.grpFruits.TabIndex = 0
        Me.grpFruits.TabStop = False
        Me.grpFruits.Text = "Fruits"
        '
        'radMango
        '
        Me.radMango.AutoSize = True
        Me.radMango.Location = New System.Drawing.Point(6, 43)
        Me.radMango.Name = "radMango"
        Me.radMango.Size = New System.Drawing.Size(58, 17)
        Me.radMango.TabIndex = 1
        Me.radMango.Text = "Mango"
        Me.radMango.UseVisualStyleBackColor = True
        '
        'radApple
        '
        Me.radApple.AutoSize = True
        Me.radApple.Checked = True
        Me.radApple.Location = New System.Drawing.Point(7, 20)
        Me.radApple.Name = "radApple"
        Me.radApple.Size = New System.Drawing.Size(52, 17)
        Me.radApple.TabIndex = 1
        Me.radApple.TabStop = True
        Me.radApple.Text = "Apple"
        Me.radApple.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightYellow
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpFruits)
        Me.Controls.Add(Me.txtFruitQuant)
        Me.Controls.Add(Me.lblQuantApple)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMango)
        Me.Controls.Add(Me.lblApple)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblPrompt)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.picMango)
        Me.Controls.Add(Me.picApple)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Fruity Fruits"
        CType(Me.picMango, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picApple, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFruits.ResumeLayout(False)
        Me.grpFruits.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMain As Label
    Friend WithEvents picApple As PictureBox
    Friend WithEvents picMango As PictureBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPrompt As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents lblApple As Label
    Friend WithEvents lblMango As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents lblQuantApple As Label
    Friend WithEvents txtFruitQuant As MaskedTextBox
    Friend WithEvents grpFruits As GroupBox
    Friend WithEvents radMango As RadioButton
    Friend WithEvents radApple As RadioButton
End Class
