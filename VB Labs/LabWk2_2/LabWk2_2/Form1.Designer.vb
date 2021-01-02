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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picComputer = New System.Windows.Forms.PictureBox()
        Me.picVisualStudio = New System.Windows.Forms.PictureBox()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMain = New System.Windows.Forms.Label()
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisualStudio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(363, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picComputer
        '
        Me.picComputer.Image = Global.LabWk2_2.My.Resources.Resources._1024px_Gnome_computer
        Me.picComputer.Location = New System.Drawing.Point(71, 81)
        Me.picComputer.Name = "picComputer"
        Me.picComputer.Size = New System.Drawing.Size(247, 185)
        Me.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picComputer.TabIndex = 1
        Me.picComputer.TabStop = False
        '
        'picVisualStudio
        '
        Me.picVisualStudio.Image = Global.LabWk2_2.My.Resources.Resources._1024px_Visual_Studio_2017_Logo
        Me.picVisualStudio.Location = New System.Drawing.Point(498, 81)
        Me.picVisualStudio.Name = "picVisualStudio"
        Me.picVisualStudio.Size = New System.Drawing.Size(247, 185)
        Me.picVisualStudio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVisualStudio.TabIndex = 2
        Me.picVisualStudio.TabStop = False
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.Location = New System.Drawing.Point(168, 269)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(52, 13)
        Me.lblComputer.TabIndex = 3
        Me.lblComputer.Text = "Computer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 269)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Visual Studio"
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(308, 9)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(185, 55)
        Me.lblMain.TabIndex = 5
        Me.lblMain.Text = "2.2 Lab"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.picVisualStudio)
        Me.Controls.Add(Me.picComputer)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Week 2.2 Lab"
        CType(Me.picComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisualStudio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents picComputer As PictureBox
    Friend WithEvents picVisualStudio As PictureBox
    Friend WithEvents lblComputer As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMain As Label
End Class
