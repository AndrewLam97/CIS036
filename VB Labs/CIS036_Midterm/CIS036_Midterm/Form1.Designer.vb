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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.lstCart = New System.Windows.Forms.ListBox()
        Me.btnUndo = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblFlavor = New System.Windows.Forms.Label()
        Me.lblHoursTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSandwichOptions = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCart = New System.Windows.Forms.Label()
        Me.picCheese = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.picHamburger = New System.Windows.Forms.PictureBox()
        Me.picPbj = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.picCheese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHamburger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPbj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Palatino Linotype", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(432, 29)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(401, 65)
        Me.lblMain.TabIndex = 0
        Me.lblMain.Text = "PCC Sandwiches"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.toolStripSeparator2, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem1.Text = "&Clear"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        '
        'btnOrder
        '
        Me.btnOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnOrder.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(560, 495)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(144, 42)
        Me.btnOrder.TabIndex = 2
        Me.btnOrder.Text = "&Order"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'lstCart
        '
        Me.lstCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lstCart.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCart.FormattingEnabled = True
        Me.lstCart.ItemHeight = 28
        Me.lstCart.Location = New System.Drawing.Point(538, 206)
        Me.lstCart.Name = "lstCart"
        Me.lstCart.Size = New System.Drawing.Size(187, 172)
        Me.lstCart.TabIndex = 3
        '
        'btnUndo
        '
        Me.btnUndo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnUndo.Enabled = False
        Me.btnUndo.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUndo.Location = New System.Drawing.Point(560, 543)
        Me.btnUndo.Name = "btnUndo"
        Me.btnUndo.Size = New System.Drawing.Size(144, 42)
        Me.btnUndo.TabIndex = 4
        Me.btnUndo.Text = "&Undo Prev"
        Me.btnUndo.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(560, 591)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(144, 42)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(515, 401)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(104, 44)
        Me.lblTotalPrice.TabIndex = 6
        Me.lblTotalPrice.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(621, 401)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(128, 44)
        Me.lblTotal.TabIndex = 7
        Me.lblTotal.Text = "$XX.XX"
        '
        'lblFlavor
        '
        Me.lblFlavor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblFlavor.AutoSize = True
        Me.lblFlavor.Font = New System.Drawing.Font("Segoe Script", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlavor.Location = New System.Drawing.Point(347, 99)
        Me.lblFlavor.Name = "lblFlavor"
        Me.lblFlavor.Size = New System.Drawing.Size(571, 51)
        Me.lblFlavor.TabIndex = 8
        Me.lblFlavor.Text = "No fuss or frill. Just great taste!"
        '
        'lblHoursTitle
        '
        Me.lblHoursTitle.AutoSize = True
        Me.lblHoursTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHoursTitle.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoursTitle.Location = New System.Drawing.Point(0, 24)
        Me.lblHoursTitle.Name = "lblHoursTitle"
        Me.lblHoursTitle.Size = New System.Drawing.Size(77, 30)
        Me.lblHoursTitle.TabIndex = 9
        Me.lblHoursTitle.Text = "Hours:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(261, 30)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "7am to 3pm, Mon to Fri"
        '
        'lblSandwichOptions
        '
        Me.lblSandwichOptions.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSandwichOptions.AutoSize = True
        Me.lblSandwichOptions.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSandwichOptions.Location = New System.Drawing.Point(97, 239)
        Me.lblSandwichOptions.Name = "lblSandwichOptions"
        Me.lblSandwichOptions.Size = New System.Drawing.Size(279, 44)
        Me.lblSandwichOptions.TabIndex = 11
        Me.lblSandwichOptions.Text = "Sandwich Options"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TextBox1.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(90, 301)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(286, 184)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "pbj - $1.50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "hamburger - $4.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "veggie - $3.50" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "cheese - $2.00"
        '
        'lblCart
        '
        Me.lblCart.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCart.AutoSize = True
        Me.lblCart.Font = New System.Drawing.Font("Perpetua Titling MT", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCart.Location = New System.Drawing.Point(585, 171)
        Me.lblCart.Name = "lblCart"
        Me.lblCart.Size = New System.Drawing.Size(95, 32)
        Me.lblCart.TabIndex = 13
        Me.lblCart.Text = "Cart"
        '
        'picCheese
        '
        Me.picCheese.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picCheese.Image = Global.CIS036_Midterm.My.Resources.Resources.Grilled_Cheese_with_hoisin
        Me.picCheese.Location = New System.Drawing.Point(1036, 401)
        Me.picCheese.Name = "picCheese"
        Me.picCheese.Size = New System.Drawing.Size(216, 184)
        Me.picCheese.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picCheese.TabIndex = 17
        Me.picCheese.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picVeggie.Image = Global.CIS036_Midterm.My.Resources.Resources.cheese_salad_sandwich
        Me.picVeggie.Location = New System.Drawing.Point(780, 401)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(216, 184)
        Me.picVeggie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picVeggie.TabIndex = 16
        Me.picVeggie.TabStop = False
        '
        'picHamburger
        '
        Me.picHamburger.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picHamburger.Image = Global.CIS036_Midterm.My.Resources.Resources.hearty_cheeseburger
        Me.picHamburger.Location = New System.Drawing.Point(1036, 206)
        Me.picHamburger.Name = "picHamburger"
        Me.picHamburger.Size = New System.Drawing.Size(216, 184)
        Me.picHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picHamburger.TabIndex = 15
        Me.picHamburger.TabStop = False
        '
        'picPbj
        '
        Me.picPbj.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.picPbj.Image = Global.CIS036_Midterm.My.Resources.Resources.sandwich
        Me.picPbj.Location = New System.Drawing.Point(780, 205)
        Me.picPbj.Name = "picPbj"
        Me.picPbj.Size = New System.Drawing.Size(216, 184)
        Me.picPbj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picPbj.TabIndex = 14
        Me.picPbj.TabStop = False
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnOrder
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.picCheese)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picHamburger)
        Me.Controls.Add(Me.picPbj)
        Me.Controls.Add(Me.lblCart)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSandwichOptions)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHoursTitle)
        Me.Controls.Add(Me.lblFlavor)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUndo)
        Me.Controls.Add(Me.lstCart)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "PCC Sandwiches"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.picCheese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHamburger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPbj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMain As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnOrder As Button
    Friend WithEvents lstCart As ListBox
    Friend WithEvents btnUndo As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblFlavor As Label
    Friend WithEvents lblHoursTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSandwichOptions As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblCart As Label
    Friend WithEvents picPbj As PictureBox
    Friend WithEvents picHamburger As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents picCheese As PictureBox
End Class
