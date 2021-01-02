<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WebBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WebBrowser))
        Me.webBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.lblBrowser = New System.Windows.Forms.Label()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'webBrowser1
        '
        Me.webBrowser1.Location = New System.Drawing.Point(12, 25)
        Me.webBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.webBrowser1.Name = "webBrowser1"
        Me.webBrowser1.Size = New System.Drawing.Size(776, 396)
        Me.webBrowser1.TabIndex = 0
        '
        'lblBrowser
        '
        Me.lblBrowser.AutoSize = True
        Me.lblBrowser.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrowser.Location = New System.Drawing.Point(273, -2)
        Me.lblBrowser.Name = "lblBrowser"
        Me.lblBrowser.Size = New System.Drawing.Size(254, 24)
        Me.lblBrowser.TabIndex = 1
        Me.lblBrowser.Text = "SPOOKY WEB BROWSER"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(713, 425)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(75, 23)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "GO"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtURL
        '
        Me.txtURL.Location = New System.Drawing.Point(12, 427)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(695, 20)
        Me.txtURL.TabIndex = 3
        '
        'WebBrowser
        '
        Me.AcceptButton = Me.btnGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtURL)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lblBrowser)
        Me.Controls.Add(Me.webBrowser1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WebBrowser"
        Me.Text = "Spooky Browser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents webBrowser1 As Windows.Forms.WebBrowser
    Friend WithEvents lblBrowser As Label
    Friend WithEvents btnGo As Button
    Friend WithEvents txtURL As TextBox
End Class
