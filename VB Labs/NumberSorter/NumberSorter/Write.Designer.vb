<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Write
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Write))
        Me.btnWrite = New System.Windows.Forms.Button()
        Me.lblWrite = New System.Windows.Forms.Label()
        Me.lbl5D = New System.Windows.Forms.Label()
        Me.btnAddMask = New System.Windows.Forms.Button()
        Me.txt5digit = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'btnWrite
        '
        Me.btnWrite.Font = New System.Drawing.Font("Papyrus", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWrite.Location = New System.Drawing.Point(337, 172)
        Me.btnWrite.Name = "btnWrite"
        Me.btnWrite.Size = New System.Drawing.Size(119, 45)
        Me.btnWrite.TabIndex = 0
        Me.btnWrite.Text = "Write To File"
        Me.btnWrite.UseVisualStyleBackColor = True
        '
        'lblWrite
        '
        Me.lblWrite.AutoSize = True
        Me.lblWrite.BackColor = System.Drawing.Color.Transparent
        Me.lblWrite.Font = New System.Drawing.Font("Papyrus", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWrite.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblWrite.Location = New System.Drawing.Point(271, 127)
        Me.lblWrite.Name = "lblWrite"
        Me.lblWrite.Size = New System.Drawing.Size(258, 42)
        Me.lblWrite.TabIndex = 1
        Me.lblWrite.Text = "Write to numbers.txt"
        '
        'lbl5D
        '
        Me.lbl5D.AutoSize = True
        Me.lbl5D.BackColor = System.Drawing.Color.Transparent
        Me.lbl5D.Font = New System.Drawing.Font("Papyrus", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5D.ForeColor = System.Drawing.Color.White
        Me.lbl5D.Location = New System.Drawing.Point(322, 275)
        Me.lbl5D.Name = "lbl5D"
        Me.lbl5D.Size = New System.Drawing.Size(100, 25)
        Me.lbl5D.TabIndex = 13
        Me.lbl5D.Text = "5 Digit Num:"
        '
        'btnAddMask
        '
        Me.btnAddMask.Font = New System.Drawing.Font("Papyrus", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMask.Location = New System.Drawing.Point(337, 306)
        Me.btnAddMask.Name = "btnAddMask"
        Me.btnAddMask.Size = New System.Drawing.Size(133, 31)
        Me.btnAddMask.TabIndex = 12
        Me.btnAddMask.Text = "Add 5 Digit"
        Me.btnAddMask.UseVisualStyleBackColor = True
        '
        'txt5digit
        '
        Me.txt5digit.Font = New System.Drawing.Font("Papyrus", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt5digit.Location = New System.Drawing.Point(428, 272)
        Me.txt5digit.Mask = "00000"
        Me.txt5digit.Name = "txt5digit"
        Me.txt5digit.Size = New System.Drawing.Size(42, 28)
        Me.txt5digit.TabIndex = 11
        Me.txt5digit.ValidatingType = GetType(Integer)
        '
        'Write
        '
        Me.AcceptButton = Me.btnWrite
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NumberSorter.My.Resources.Resources.chalkboard_517818_1280
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl5D)
        Me.Controls.Add(Me.btnAddMask)
        Me.Controls.Add(Me.txt5digit)
        Me.Controls.Add(Me.lblWrite)
        Me.Controls.Add(Me.btnWrite)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Write"
        Me.Text = "Write"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWrite As Button
    Friend WithEvents lblWrite As Label
    Friend WithEvents lbl5D As Label
    Friend WithEvents btnAddMask As Button
    Friend WithEvents txt5digit As MaskedTextBox
End Class
