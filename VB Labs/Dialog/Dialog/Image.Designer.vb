<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Image
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Image))
        Me.btnImage = New System.Windows.Forms.Button()
        Me.picBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(575, 211)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(75, 23)
        Me.btnImage.TabIndex = 0
        Me.btnImage.Text = "Open Image"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'picBox1
        '
        Me.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picBox1.Location = New System.Drawing.Point(12, 12)
        Me.picBox1.Name = "picBox1"
        Me.picBox1.Size = New System.Drawing.Size(430, 426)
        Me.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBox1.TabIndex = 1
        Me.picBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Image
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picBox1)
        Me.Controls.Add(Me.btnImage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Image"
        Me.Text = "Image"
        CType(Me.picBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnImage As Button
    Friend WithEvents picBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
