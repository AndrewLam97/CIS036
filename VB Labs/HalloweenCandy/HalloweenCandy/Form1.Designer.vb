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
        Me.cboCandyOptions = New System.Windows.Forms.ComboBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.File = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.btnOpenBrowser = New System.Windows.Forms.Button()
        Me.lblOpenBrowser = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCandyOptions
        '
        Me.cboCandyOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCandyOptions.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCandyOptions.FormattingEnabled = True
        Me.cboCandyOptions.Items.AddRange(New Object() {"Reese's Peanut Butter Cups", "Snickers", "Twix", "Kit-Kat", "Butterfinger", "Candy Corn"})
        Me.cboCandyOptions.Location = New System.Drawing.Point(463, 259)
        Me.cboCandyOptions.Name = "cboCandyOptions"
        Me.cboCandyOptions.Size = New System.Drawing.Size(180, 32)
        Me.cboCandyOptions.TabIndex = 0
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Bradley Hand ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.ForeColor = System.Drawing.Color.Black
        Me.lblMain.Location = New System.Drawing.Point(297, 78)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(513, 60)
        Me.lblMain.TabIndex = 1
        Me.lblMain.Text = "HALLOWEEN CANDY"
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Bradley Hand ITC", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.ForeColor = System.Drawing.Color.Black
        Me.btnOrder.Location = New System.Drawing.Point(463, 557)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(180, 38)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Bradley Hand ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(543, 635)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(95, 30)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "$XX.XX"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.File, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(1107, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'File
        '
        Me.File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClear, Me.mnuExit})
        Me.File.Name = "File"
        Me.File.Size = New System.Drawing.Size(37, 22)
        Me.File.Text = "&File"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(101, 22)
        Me.mnuClear.Text = "&Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(101, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(44, 22)
        Me.ToolStripMenuItem1.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "&About"
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Bradley Hand ITC", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.ForeColor = System.Drawing.Color.Black
        Me.lblTotalLabel.Location = New System.Drawing.Point(469, 635)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(76, 30)
        Me.lblTotalLabel.TabIndex = 5
        Me.lblTotalLabel.Text = "Total: "
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Bradley Hand ITC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.ForeColor = System.Drawing.Color.Black
        Me.txtQuantity.Location = New System.Drawing.Point(559, 402)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 34)
        Me.txtQuantity.TabIndex = 6
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Font = New System.Drawing.Font("Bradley Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuantity.ForeColor = System.Drawing.Color.Black
        Me.lblQuantity.Location = New System.Drawing.Point(438, 405)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(115, 26)
        Me.lblQuantity.TabIndex = 7
        Me.lblQuantity.Text = "Quantity: "
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSelect.Location = New System.Drawing.Point(470, 232)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(157, 24)
        Me.lblSelect.TabIndex = 8
        Me.lblSelect.Text = "Select A Candy:"
        '
        'btnOpenBrowser
        '
        Me.btnOpenBrowser.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenBrowser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnOpenBrowser.Location = New System.Drawing.Point(823, 498)
        Me.btnOpenBrowser.Name = "btnOpenBrowser"
        Me.btnOpenBrowser.Size = New System.Drawing.Size(95, 27)
        Me.btnOpenBrowser.TabIndex = 9
        Me.btnOpenBrowser.Text = "Browse"
        Me.btnOpenBrowser.UseVisualStyleBackColor = True
        '
        'lblOpenBrowser
        '
        Me.lblOpenBrowser.AutoSize = True
        Me.lblOpenBrowser.Font = New System.Drawing.Font("Bradley Hand ITC", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpenBrowser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOpenBrowser.Location = New System.Drawing.Point(752, 471)
        Me.lblOpenBrowser.Name = "lblOpenBrowser"
        Me.lblOpenBrowser.Size = New System.Drawing.Size(234, 24)
        Me.lblOpenBrowser.TabIndex = 10
        Me.lblOpenBrowser.Text = "Try our Spooky Browser!"
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.HalloweenCandy.My.Resources.Resources.halloween_background_grunge_1536388349fpP
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1107, 690)
        Me.Controls.Add(Me.lblOpenBrowser)
        Me.Controls.Add(Me.btnOpenBrowser)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.cboCandyOptions)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Halloween Candy"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboCandyOptions As ComboBox
    Friend WithEvents lblMain As Label
    Friend WithEvents btnOrder As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents File As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblTotalLabel As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblSelect As Label
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents btnOpenBrowser As Button
    Friend WithEvents lblOpenBrowser As Label
End Class
