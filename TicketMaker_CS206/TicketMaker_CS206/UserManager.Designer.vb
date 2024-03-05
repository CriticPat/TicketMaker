<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManagement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserManagement))
        Dim User_FnameLabel As System.Windows.Forms.Label
        Dim User_PasswordLabel As System.Windows.Forms.Label
        Dim User_LevelLabel As System.Windows.Forms.Label
        Dim User_EmailLabel As System.Windows.Forms.Label
        Dim User_PhoneLabel As System.Windows.Forms.Label
        Dim User_FnameLabel1 As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToLoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutDeveloperToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.User_InfoDataSet = New TicketMaker_CS206.User_InfoDataSet()
        Me.UserTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UserTableTableAdapter = New TicketMaker_CS206.User_InfoDataSetTableAdapters.UserTableTableAdapter()
        Me.TableAdapterManager = New TicketMaker_CS206.User_InfoDataSetTableAdapters.TableAdapterManager()
        Me.UserTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.UserTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.UserTableDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.User_FnameTextBox = New System.Windows.Forms.TextBox()
        Me.User_PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.User_LevelTextBox = New System.Windows.Forms.TextBox()
        Me.User_EmailTextBox = New System.Windows.Forms.TextBox()
        Me.User_PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.User_FnameTextBox1 = New System.Windows.Forms.TextBox()
        User_FnameLabel = New System.Windows.Forms.Label()
        User_PasswordLabel = New System.Windows.Forms.Label()
        User_LevelLabel = New System.Windows.Forms.Label()
        User_EmailLabel = New System.Windows.Forms.Label()
        User_PhoneLabel = New System.Windows.Forms.Label()
        User_FnameLabel1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.User_InfoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UserTableBindingNavigator.SuspendLayout()
        CType(Me.UserTableDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(820, 30)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReturnToLoginToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ReturnToLoginToolStripMenuItem
        '
        Me.ReturnToLoginToolStripMenuItem.Name = "ReturnToLoginToolStripMenuItem"
        Me.ReturnToLoginToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ReturnToLoginToolStripMenuItem.Text = "Return to Login"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(194, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearFormToolStripMenuItem, Me.PrintToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ClearFormToolStripMenuItem
        '
        Me.ClearFormToolStripMenuItem.Name = "ClearFormToolStripMenuItem"
        Me.ClearFormToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.ClearFormToolStripMenuItem.Text = "Clear Form"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(164, 26)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AboutDeveloperToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(206, 26)
        Me.AboutToolStripMenuItem1.Text = "About  Program"
        '
        'AboutDeveloperToolStripMenuItem
        '
        Me.AboutDeveloperToolStripMenuItem.Name = "AboutDeveloperToolStripMenuItem"
        Me.AboutDeveloperToolStripMenuItem.Size = New System.Drawing.Size(206, 26)
        Me.AboutDeveloperToolStripMenuItem.Text = "About Developer"
        '
        'User_InfoDataSet
        '
        Me.User_InfoDataSet.DataSetName = "User_InfoDataSet"
        Me.User_InfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableBindingSource
        '
        Me.UserTableBindingSource.DataMember = "UserTable"
        Me.UserTableBindingSource.DataSource = Me.User_InfoDataSet
        '
        'UserTableTableAdapter
        '
        Me.UserTableTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = TicketMaker_CS206.User_InfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UserTableTableAdapter = Me.UserTableTableAdapter
        '
        'UserTableBindingNavigator
        '
        Me.UserTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.UserTableBindingNavigator.BindingSource = Me.UserTableBindingSource
        Me.UserTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.UserTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.UserTableBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.UserTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.UserTableBindingNavigatorSaveItem})
        Me.UserTableBindingNavigator.Location = New System.Drawing.Point(0, 30)
        Me.UserTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.UserTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.UserTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.UserTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.UserTableBindingNavigator.Name = "UserTableBindingNavigator"
        Me.UserTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.UserTableBindingNavigator.Size = New System.Drawing.Size(820, 31)
        Me.UserTableBindingNavigator.TabIndex = 1
        Me.UserTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 20)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'UserTableBindingNavigatorSaveItem
        '
        Me.UserTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UserTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("UserTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.UserTableBindingNavigatorSaveItem.Name = "UserTableBindingNavigatorSaveItem"
        Me.UserTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.UserTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'UserTableDataGridView
        '
        Me.UserTableDataGridView.AutoGenerateColumns = False
        Me.UserTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UserTableDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.UserTableDataGridView.DataSource = Me.UserTableBindingSource
        Me.UserTableDataGridView.Location = New System.Drawing.Point(0, 225)
        Me.UserTableDataGridView.Name = "UserTableDataGridView"
        Me.UserTableDataGridView.RowHeadersWidth = 51
        Me.UserTableDataGridView.RowTemplate.Height = 24
        Me.UserTableDataGridView.Size = New System.Drawing.Size(800, 225)
        Me.UserTableDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "User_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "User_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 125
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "User_Fname"
        Me.DataGridViewTextBoxColumn2.HeaderText = "User_Fname"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 125
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "User_Lname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "User_Lname"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 125
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "User_Password"
        Me.DataGridViewTextBoxColumn4.HeaderText = "User_Password"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 125
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "User_Level"
        Me.DataGridViewTextBoxColumn5.HeaderText = "User_Level"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 125
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "User_Email"
        Me.DataGridViewTextBoxColumn6.HeaderText = "User_Email"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 125
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "User_Phone"
        Me.DataGridViewTextBoxColumn7.HeaderText = "User_Phone"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 125
        '
        'User_FnameLabel
        '
        User_FnameLabel.AutoSize = True
        User_FnameLabel.Location = New System.Drawing.Point(12, 120)
        User_FnameLabel.Name = "User_FnameLabel"
        User_FnameLabel.Size = New System.Drawing.Size(89, 17)
        User_FnameLabel.TabIndex = 5
        User_FnameLabel.Text = "User Fname:"
        '
        'User_FnameTextBox
        '
        Me.User_FnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "User_Fname", True))
        Me.User_FnameTextBox.Location = New System.Drawing.Point(107, 117)
        Me.User_FnameTextBox.Name = "User_FnameTextBox"
        Me.User_FnameTextBox.Size = New System.Drawing.Size(100, 22)
        Me.User_FnameTextBox.TabIndex = 6
        '
        'User_PasswordLabel
        '
        User_PasswordLabel.AutoSize = True
        User_PasswordLabel.Location = New System.Drawing.Point(12, 76)
        User_PasswordLabel.Name = "User_PasswordLabel"
        User_PasswordLabel.Size = New System.Drawing.Size(107, 17)
        User_PasswordLabel.TabIndex = 7
        User_PasswordLabel.Text = "User Password:"
        '
        'User_PasswordTextBox
        '
        Me.User_PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "User_Password", True))
        Me.User_PasswordTextBox.Location = New System.Drawing.Point(116, 76)
        Me.User_PasswordTextBox.Name = "User_PasswordTextBox"
        Me.User_PasswordTextBox.Size = New System.Drawing.Size(100, 22)
        Me.User_PasswordTextBox.TabIndex = 8
        '
        'User_LevelLabel
        '
        User_LevelLabel.AutoSize = True
        User_LevelLabel.Location = New System.Drawing.Point(31, 161)
        User_LevelLabel.Name = "User_LevelLabel"
        User_LevelLabel.Size = New System.Drawing.Size(80, 17)
        User_LevelLabel.TabIndex = 8
        User_LevelLabel.Text = "User Level:"
        '
        'User_LevelTextBox
        '
        Me.User_LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "User_Level", True))
        Me.User_LevelTextBox.Location = New System.Drawing.Point(117, 158)
        Me.User_LevelTextBox.Name = "User_LevelTextBox"
        Me.User_LevelTextBox.Size = New System.Drawing.Size(100, 22)
        Me.User_LevelTextBox.TabIndex = 9
        '
        'User_EmailLabel
        '
        User_EmailLabel.AutoSize = True
        User_EmailLabel.Location = New System.Drawing.Point(294, 90)
        User_EmailLabel.Name = "User_EmailLabel"
        User_EmailLabel.Size = New System.Drawing.Size(80, 17)
        User_EmailLabel.TabIndex = 9
        User_EmailLabel.Text = "User Email:"
        '
        'User_EmailTextBox
        '
        Me.User_EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "User_Email", True))
        Me.User_EmailTextBox.Location = New System.Drawing.Point(380, 87)
        Me.User_EmailTextBox.Name = "User_EmailTextBox"
        Me.User_EmailTextBox.Size = New System.Drawing.Size(100, 22)
        Me.User_EmailTextBox.TabIndex = 10
        '
        'User_PhoneLabel
        '
        User_PhoneLabel.AutoSize = True
        User_PhoneLabel.Location = New System.Drawing.Point(302, 134)
        User_PhoneLabel.Name = "User_PhoneLabel"
        User_PhoneLabel.Size = New System.Drawing.Size(87, 17)
        User_PhoneLabel.TabIndex = 11
        User_PhoneLabel.Text = "User Phone:"
        '
        'User_PhoneTextBox
        '
        Me.User_PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "User_Phone", True))
        Me.User_PhoneTextBox.Location = New System.Drawing.Point(395, 131)
        Me.User_PhoneTextBox.Name = "User_PhoneTextBox"
        Me.User_PhoneTextBox.Size = New System.Drawing.Size(100, 22)
        Me.User_PhoneTextBox.TabIndex = 12
        '
        'User_FnameLabel1
        '
        User_FnameLabel1.AutoSize = True
        User_FnameLabel1.Location = New System.Drawing.Point(313, 163)
        User_FnameLabel1.Name = "User_FnameLabel1"
        User_FnameLabel1.Size = New System.Drawing.Size(89, 17)
        User_FnameLabel1.TabIndex = 13
        User_FnameLabel1.Text = "User Fname:"
        '
        'User_FnameTextBox1
        '
        Me.User_FnameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.UserTableBindingSource, "User_Fname", True))
        Me.User_FnameTextBox1.Location = New System.Drawing.Point(408, 160)
        Me.User_FnameTextBox1.Name = "User_FnameTextBox1"
        Me.User_FnameTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.User_FnameTextBox1.TabIndex = 14
        '
        'UserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(820, 470)
        Me.Controls.Add(User_FnameLabel1)
        Me.Controls.Add(Me.User_FnameTextBox1)
        Me.Controls.Add(User_PhoneLabel)
        Me.Controls.Add(Me.User_PhoneTextBox)
        Me.Controls.Add(User_EmailLabel)
        Me.Controls.Add(Me.User_EmailTextBox)
        Me.Controls.Add(User_LevelLabel)
        Me.Controls.Add(Me.User_LevelTextBox)
        Me.Controls.Add(User_PasswordLabel)
        Me.Controls.Add(Me.User_PasswordTextBox)
        Me.Controls.Add(User_FnameLabel)
        Me.Controls.Add(Me.User_FnameTextBox)
        Me.Controls.Add(Me.UserTableDataGridView)
        Me.Controls.Add(Me.UserTableBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UserManagement"
        Me.Text = "User Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.User_InfoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UserTableBindingNavigator.ResumeLayout(False)
        Me.UserTableBindingNavigator.PerformLayout()
        CType(Me.UserTableDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToLoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AboutDeveloperToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents User_InfoDataSet As User_InfoDataSet
    Friend WithEvents UserTableBindingSource As BindingSource
    Friend WithEvents UserTableTableAdapter As User_InfoDataSetTableAdapters.UserTableTableAdapter
    Friend WithEvents TableAdapterManager As User_InfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserTableBindingNavigator As BindingNavigator
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
    Friend WithEvents UserTableBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents UserTableDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents User_FnameTextBox As TextBox
    Friend WithEvents User_PasswordTextBox As TextBox
    Friend WithEvents User_LevelTextBox As TextBox
    Friend WithEvents User_EmailTextBox As TextBox
    Friend WithEvents User_PhoneTextBox As TextBox
    Friend WithEvents User_FnameTextBox1 As TextBox
End Class
