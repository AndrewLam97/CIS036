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
        Me.components = New System.ComponentModel.Container()
        Dim PriceLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim NameLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Me.Coffee_LabDataSet1 = New LAB_SQL.Coffee_LabDataSet()
        Me.Coffee_LabDataSet11 = New LAB_SQL.Coffee_LabDataSet1()
        Me.CoffeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoffeesTableAdapter = New LAB_SQL.Coffee_LabDataSet1TableAdapters.CoffeesTableAdapter()
        Me.TableAdapterManager = New LAB_SQL.Coffee_LabDataSet1TableAdapters.TableAdapterManager()
        Me.CoffeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CoffeesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceLabel1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.CoffeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NameLabel1 = New System.Windows.Forms.Label()
        Me.DescriptionLabel1 = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        CType(Me.Coffee_LabDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Coffee_LabDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoffeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoffeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CoffeesBindingNavigator.SuspendLayout()
        CType(Me.CoffeesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(90, 434)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(34, 13)
        PriceLabel.TabIndex = 7
        PriceLabel.Text = "Price:"
        '
        'Coffee_LabDataSet1
        '
        Me.Coffee_LabDataSet1.DataSetName = "Coffee_LabDataSet"
        Me.Coffee_LabDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Coffee_LabDataSet11
        '
        Me.Coffee_LabDataSet11.DataSetName = "Coffee_LabDataSet1"
        Me.Coffee_LabDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CoffeesBindingSource
        '
        Me.CoffeesBindingSource.DataMember = "Coffees"
        Me.CoffeesBindingSource.DataSource = Me.Coffee_LabDataSet11
        '
        'CoffeesTableAdapter
        '
        Me.CoffeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CoffeesTableAdapter = Me.CoffeesTableAdapter
        Me.TableAdapterManager.UpdateOrder = LAB_SQL.Coffee_LabDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CoffeesBindingNavigator
        '
        Me.CoffeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CoffeesBindingNavigator.BindingSource = Me.CoffeesBindingSource
        Me.CoffeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CoffeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CoffeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CoffeesBindingNavigatorSaveItem})
        Me.CoffeesBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.CoffeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CoffeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CoffeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CoffeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CoffeesBindingNavigator.Name = "CoffeesBindingNavigator"
        Me.CoffeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CoffeesBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.CoffeesBindingNavigator.TabIndex = 0
        Me.CoffeesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'CoffeesDataGridView
        '
        Me.CoffeesDataGridView.AutoGenerateColumns = False
        Me.CoffeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CoffeesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.CoffeesDataGridView.DataSource = Me.CoffeesBindingSource
        Me.CoffeesDataGridView.Location = New System.Drawing.Point(349, 257)
        Me.CoffeesDataGridView.Name = "CoffeesDataGridView"
        Me.CoffeesDataGridView.Size = New System.Drawing.Size(428, 209)
        Me.CoffeesDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Price"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'PriceLabel1
        '
        Me.PriceLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoffeesBindingSource, "Price", True))
        Me.PriceLabel1.Location = New System.Drawing.Point(130, 429)
        Me.PriceLabel1.Name = "PriceLabel1"
        Me.PriceLabel1.Size = New System.Drawing.Size(100, 23)
        Me.PriceLabel1.TabIndex = 8
        Me.PriceLabel1.Text = "Label1"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(702, 147)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'CoffeesBindingNavigatorSaveItem
        '
        Me.CoffeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CoffeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("CoffeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CoffeesBindingNavigatorSaveItem.Name = "CoffeesBindingNavigatorSaveItem"
        Me.CoffeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CoffeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(86, 360)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 10
        NameLabel.Text = "Name:"
        '
        'NameLabel1
        '
        Me.NameLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoffeesBindingSource, "Name", True))
        Me.NameLabel1.Location = New System.Drawing.Point(130, 355)
        Me.NameLabel1.Name = "NameLabel1"
        Me.NameLabel1.Size = New System.Drawing.Size(100, 23)
        Me.NameLabel1.TabIndex = 11
        Me.NameLabel1.Text = "Label1"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(61, 397)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 11
        DescriptionLabel.Text = "Description:"
        '
        'DescriptionLabel1
        '
        Me.DescriptionLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CoffeesBindingSource, "Description", True))
        Me.DescriptionLabel1.Location = New System.Drawing.Point(130, 392)
        Me.DescriptionLabel1.Name = "DescriptionLabel1"
        Me.DescriptionLabel1.Size = New System.Drawing.Size(100, 23)
        Me.DescriptionLabel1.TabIndex = 12
        Me.DescriptionLabel1.Text = "Label1"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LAB_SQL.My.Resources.Resources.coffee_1533253750x1z
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 478)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionLabel1)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameLabel1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceLabel1)
        Me.Controls.Add(Me.CoffeesDataGridView)
        Me.Controls.Add(Me.CoffeesBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Form1"
        CType(Me.Coffee_LabDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Coffee_LabDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoffeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoffeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CoffeesBindingNavigator.ResumeLayout(False)
        Me.CoffeesBindingNavigator.PerformLayout()
        CType(Me.CoffeesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Coffee_LabDataSet1 As Coffee_LabDataSet
    Friend WithEvents Coffee_LabDataSet11 As Coffee_LabDataSet1
    Friend WithEvents CoffeesBindingSource As BindingSource
    Friend WithEvents CoffeesTableAdapter As Coffee_LabDataSet1TableAdapters.CoffeesTableAdapter
    Friend WithEvents TableAdapterManager As Coffee_LabDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CoffeesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents CoffeesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CoffeesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents PriceLabel1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NameLabel1 As Label
    Friend WithEvents DescriptionLabel1 As Label
End Class
