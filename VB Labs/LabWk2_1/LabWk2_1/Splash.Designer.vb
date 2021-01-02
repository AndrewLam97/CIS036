<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Me.picSplash = New System.Windows.Forms.PictureBox()
        Me.lblSplash = New System.Windows.Forms.Label()
        CType(Me.picSplash, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picSplash
        '
        Me.picSplash.Image = Global.LabWk2_1.My.Resources.Resources.VRHeadset
        Me.picSplash.Location = New System.Drawing.Point(169, 83)
        Me.picSplash.Name = "picSplash"
        Me.picSplash.Size = New System.Drawing.Size(462, 284)
        Me.picSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picSplash.TabIndex = 0
        Me.picSplash.TabStop = False
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.Font = New System.Drawing.Font("Tahoma", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplash.Location = New System.Drawing.Point(297, 29)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(205, 39)
        Me.lblSplash.TabIndex = 1
        Me.lblSplash.Text = "VR Forward"
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSplash)
        Me.Controls.Add(Me.picSplash)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.Text = "Splash"
        CType(Me.picSplash, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSplash As PictureBox
    Friend WithEvents lblSplash As Label
End Class
