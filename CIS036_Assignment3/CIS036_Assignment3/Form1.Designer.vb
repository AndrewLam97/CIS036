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
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.btnParkImage = New System.Windows.Forms.Button()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picOne
        '
        Me.picOne.Image = Global.CIS036_Assignment3.My.Resources.Resources.xB8B_toxUQCJHgBdioyLCMUJ0Zuv_3osLg8x6c1kx8c
        Me.picOne.Location = New System.Drawing.Point(104, 65)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(100, 50)
        Me.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picOne.TabIndex = 0
        Me.picOne.TabStop = False
        '
        'btnParkImage
        '
        Me.btnParkImage.Location = New System.Drawing.Point(120, 174)
        Me.btnParkImage.Name = "btnParkImage"
        Me.btnParkImage.Size = New System.Drawing.Size(75, 23)
        Me.btnParkImage.TabIndex = 1
        Me.btnParkImage.Text = "Button1"
        Me.btnParkImage.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnParkImage)
        Me.Controls.Add(Me.picOne)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picOne As PictureBox
    Friend WithEvents btnParkImage As Button
End Class
