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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnCrown = New System.Windows.Forms.Button()
        Me.btnEarbud = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picCrown = New System.Windows.Forms.PictureBox()
        Me.picEarbud = New System.Windows.Forms.PictureBox()
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEarbud, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.BackColor = System.Drawing.Color.White
        Me.lblMain.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.DarkGray
        Me.lblMain.Location = New System.Drawing.Point(298, 30)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(205, 39)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "VR Forward"
        '
        'btnCrown
        '
        Me.btnCrown.Location = New System.Drawing.Point(147, 311)
        Me.btnCrown.Name = "btnCrown"
        Me.btnCrown.Size = New System.Drawing.Size(75, 23)
        Me.btnCrown.TabIndex = 1
        Me.btnCrown.Text = "VR Crown"
        Me.btnCrown.UseVisualStyleBackColor = True
        '
        'btnEarbud
        '
        Me.btnEarbud.Location = New System.Drawing.Point(588, 311)
        Me.btnEarbud.Name = "btnEarbud"
        Me.btnEarbud.Size = New System.Drawing.Size(75, 23)
        Me.btnEarbud.TabIndex = 2
        Me.btnEarbud.Text = "VR Earbud"
        Me.btnEarbud.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(363, 385)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picCrown
        '
        Me.picCrown.Image = Global.LabWk2_1.My.Resources.Resources.crown
        Me.picCrown.Location = New System.Drawing.Point(49, 90)
        Me.picCrown.Name = "picCrown"
        Me.picCrown.Size = New System.Drawing.Size(270, 215)
        Me.picCrown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCrown.TabIndex = 5
        Me.picCrown.TabStop = False
        Me.picCrown.Visible = False
        '
        'picEarbud
        '
        Me.picEarbud.Image = Global.LabWk2_1.My.Resources.Resources.earbud
        Me.picEarbud.Location = New System.Drawing.Point(490, 90)
        Me.picEarbud.Name = "picEarbud"
        Me.picEarbud.Size = New System.Drawing.Size(270, 215)
        Me.picEarbud.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picEarbud.TabIndex = 4
        Me.picEarbud.TabStop = False
        Me.picEarbud.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picCrown)
        Me.Controls.Add(Me.picEarbud)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEarbud)
        Me.Controls.Add(Me.btnCrown)
        Me.Controls.Add(Me.lblMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Virtual Reality Headsets"
        CType(Me.picCrown, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEarbud, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents btnCrown As Button
    Friend WithEvents btnEarbud As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picEarbud As PictureBox
    Friend WithEvents picCrown As PictureBox
End Class
