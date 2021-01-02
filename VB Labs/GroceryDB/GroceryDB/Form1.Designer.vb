<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim PricingLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim Product_NameLabel As System.Windows.Forms.Label
        Me.PricesDBDataSet = New GroceryDB.PricesDBDataSet()
        Me.PricesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PricesTableAdapter = New GroceryDB.PricesDBDataSetTableAdapters.PricesTableAdapter()
        Me.TableAdapterManager = New GroceryDB.PricesDBDataSetTableAdapters.TableAdapterManager()
        Me.PricesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PricesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PricingTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalText = New System.Windows.Forms.Label()
        Me.lblSubTotalText = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblTaxText = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.picBasket = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PricesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.lblSum = New System.Windows.Forms.Label()
        IDLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        PricingLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        CType(Me.PricesDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PricesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PricesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PricesBindingNavigator.SuspendLayout()
        CType(Me.picBasket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PricesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.Location = New System.Drawing.Point(93, 153)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(31, 22)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(33, 200)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(91, 22)
        DescriptionLabel.TabIndex = 5
        DescriptionLabel.Text = "Description:"
        '
        'PricingLabel
        '
        PricingLabel.AutoSize = True
        PricingLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PricingLabel.Location = New System.Drawing.Point(61, 247)
        PricingLabel.Name = "PricingLabel"
        PricingLabel.Size = New System.Drawing.Size(63, 22)
        PricingLabel.TabIndex = 7
        PricingLabel.Text = "Pricing:"
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PriceLabel.Location = New System.Drawing.Point(76, 294)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(48, 22)
        PriceLabel.TabIndex = 9
        PriceLabel.Text = "Price:"
        '
        'PricesDBDataSet
        '
        Me.PricesDBDataSet.DataSetName = "PricesDBDataSet"
        Me.PricesDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PricesBindingSource
        '
        Me.PricesBindingSource.DataMember = "Prices"
        Me.PricesBindingSource.DataSource = Me.PricesDBDataSet
        '
        'PricesTableAdapter
        '
        Me.PricesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PricesTableAdapter = Me.PricesTableAdapter
        Me.TableAdapterManager.UpdateOrder = GroceryDB.PricesDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PricesBindingNavigator
        '
        Me.PricesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PricesBindingNavigator.BindingSource = Me.PricesBindingSource
        Me.PricesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PricesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PricesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PricesBindingNavigatorSaveItem})
        Me.PricesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PricesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PricesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PricesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PricesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PricesBindingNavigator.Name = "PricesBindingNavigator"
        Me.PricesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PricesBindingNavigator.Size = New System.Drawing.Size(800, 25)
        Me.PricesBindingNavigator.TabIndex = 0
        Me.PricesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PricesBindingNavigatorSaveItem
        '
        Me.PricesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PricesBindingNavigatorSaveItem.Image = CType(resources.GetObject("PricesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PricesBindingNavigatorSaveItem.Name = "PricesBindingNavigatorSaveItem"
        Me.PricesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PricesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PricesBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(130, 150)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.IDTextBox.TabIndex = 2
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PricesBindingSource, "Description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(130, 197)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(100, 29)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'PricingTextBox
        '
        Me.PricingTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PricesBindingSource, "Pricing", True))
        Me.PricingTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PricingTextBox.Location = New System.Drawing.Point(130, 244)
        Me.PricingTextBox.Name = "PricingTextBox"
        Me.PricingTextBox.ReadOnly = True
        Me.PricingTextBox.Size = New System.Drawing.Size(100, 29)
        Me.PricingTextBox.TabIndex = 8
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PricesBindingSource, "Price", True))
        Me.PriceTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceTextBox.Location = New System.Drawing.Point(130, 291)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.ReadOnly = True
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 29)
        Me.PriceTextBox.TabIndex = 10
        '
        'lblMain
        '
        Me.lblMain.AutoSize = True
        Me.lblMain.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMain.Location = New System.Drawing.Point(12, 25)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(250, 44)
        Me.lblMain.TabIndex = 11
        Me.lblMain.Text = "Grocery Lookup"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(97, 346)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(84, 34)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add To Cart"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(614, 310)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 26)
        Me.lblTotal.TabIndex = 13
        '
        'lblTotalText
        '
        Me.lblTotalText.AutoSize = True
        Me.lblTotalText.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalText.Location = New System.Drawing.Point(548, 310)
        Me.lblTotalText.Name = "lblTotalText"
        Me.lblTotalText.Size = New System.Drawing.Size(60, 26)
        Me.lblTotalText.TabIndex = 14
        Me.lblTotalText.Text = "Total:"
        '
        'lblSubTotalText
        '
        Me.lblSubTotalText.AutoSize = True
        Me.lblSubTotalText.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotalText.Location = New System.Drawing.Point(516, 265)
        Me.lblSubTotalText.Name = "lblSubTotalText"
        Me.lblSubTotalText.Size = New System.Drawing.Size(92, 26)
        Me.lblSubTotalText.TabIndex = 15
        Me.lblSubTotalText.Text = "SubTotal:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(614, 265)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(0, 26)
        Me.lblSubTotal.TabIndex = 16
        '
        'lblTaxText
        '
        Me.lblTaxText.AutoSize = True
        Me.lblTaxText.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTaxText.Location = New System.Drawing.Point(561, 287)
        Me.lblTaxText.Name = "lblTaxText"
        Me.lblTaxText.Size = New System.Drawing.Size(47, 26)
        Me.lblTaxText.TabIndex = 17
        Me.lblTaxText.Text = "Tax:"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(614, 287)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(0, 26)
        Me.lblTax.TabIndex = 18
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(553, 350)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(96, 34)
        Me.btnClear.TabIndex = 19
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(504, 404)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(96, 34)
        Me.btnAbout.TabIndex = 21
        Me.btnAbout.Text = "About"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'picBasket
        '
        Me.picBasket.Image = Global.GroceryDB.My.Resources.Resources.grocerybasket
        Me.picBasket.Location = New System.Drawing.Point(462, 42)
        Me.picBasket.Name = "picBasket"
        Me.picBasket.Size = New System.Drawing.Size(266, 189)
        Me.picBasket.TabIndex = 20
        Me.picBasket.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(606, 404)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 34)
        Me.btnExit.TabIndex = 22
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'PricesBindingSource1
        '
        Me.PricesBindingSource1.DataMember = "Prices"
        Me.PricesBindingSource1.DataSource = Me.PricesDBDataSet
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_NameLabel.Location = New System.Drawing.Point(12, 106)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(114, 22)
        Product_NameLabel.TabIndex = 24
        Product_NameLabel.Text = "Product Name:"
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PricesBindingSource, "Product Name", True))
        Me.Product_NameTextBox.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(132, 103)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.ReadOnly = True
        Me.Product_NameTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Product_NameTextBox.TabIndex = 25
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(219, 405)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(132, 34)
        Me.btnLoad.TabIndex = 26
        Me.btnLoad.Text = "Load DB / Sum"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSum.Location = New System.Drawing.Point(357, 411)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(0, 22)
        Me.lblSum.TabIndex = 27
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.lblSum)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Product_NameTextBox)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.picBasket)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTaxText)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblSubTotalText)
        Me.Controls.Add(Me.lblTotalText)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblMain)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(PricingLabel)
        Me.Controls.Add(Me.PricingTextBox)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.PricesBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "GroceryDB"
        CType(Me.PricesDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PricesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PricesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PricesBindingNavigator.ResumeLayout(False)
        Me.PricesBindingNavigator.PerformLayout()
        CType(Me.picBasket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PricesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PricesDBDataSet As PricesDBDataSet
    Friend WithEvents PricesBindingSource As BindingSource
    Friend WithEvents PricesTableAdapter As PricesDBDataSetTableAdapters.PricesTableAdapter
    Friend WithEvents TableAdapterManager As PricesDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PricesBindingNavigator As BindingNavigator
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
    Friend WithEvents PricesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents DescriptionTextBox As TextBox
    Friend WithEvents PricingTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents lblMain As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTotalText As Label
    Friend WithEvents lblSubTotalText As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblTaxText As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents picBasket As PictureBox
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PricesBindingSource1 As BindingSource
    Friend WithEvents Product_NameTextBox As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents lblSum As Label
End Class
