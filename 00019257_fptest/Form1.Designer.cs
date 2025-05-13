namespace _00019257_fptest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lbl_name;
            System.Windows.Forms.Label lbl_sales;
            System.Windows.Forms.Label lbl_notes;
            System.Windows.Forms.Label lbl_type;
            System.Windows.Forms.Label lbl_name_add;
            System.Windows.Forms.Label lbl_sales_add;
            System.Windows.Forms.Label lbl_notes_add;
            System.Windows.Forms.Label lbl_type_add;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.main_connection = new System.Data.OleDb.OleDbConnection();
            this.tb_ClientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tb_ClientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsDataSet = new _00019257_fptest.ClientsDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tb_ClientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tb_ClientTableAdapter = new _00019257_fptest.ClientsDataSetTableAdapters.tb_ClientTableAdapter();
            this.tableAdapterManager = new _00019257_fptest.ClientsDataSetTableAdapters.TableAdapterManager();
            this.main_menu_lb = new System.Windows.Forms.ListBox();
            this.tbx_name = new System.Windows.Forms.TextBox();
            this.cbx_active = new System.Windows.Forms.CheckBox();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.tbClientTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_ClientTypeTableAdapter = new _00019257_fptest.ClientsDataSetTableAdapters.tb_ClientTypeTableAdapter();
            this.rtbx_notes = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.gb_add = new System.Windows.Forms.GroupBox();
            this.tbx_sales_add = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.rtbx_notes_add = new System.Windows.Forms.RichTextBox();
            this.tbx_name_add = new System.Windows.Forms.TextBox();
            this.cbx_type_add = new System.Windows.Forms.ComboBox();
            this.tbClientTypeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cbx_active_add = new System.Windows.Forms.CheckBox();
            this.tbx_sales = new System.Windows.Forms.TextBox();
            this.tbx_search = new System.Windows.Forms.TextBox();
            this.gb_save_del = new System.Windows.Forms.GroupBox();
            this.btn_first = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_last = new System.Windows.Forms.Button();
            lbl_name = new System.Windows.Forms.Label();
            lbl_sales = new System.Windows.Forms.Label();
            lbl_notes = new System.Windows.Forms.Label();
            lbl_type = new System.Windows.Forms.Label();
            lbl_name_add = new System.Windows.Forms.Label();
            lbl_sales_add = new System.Windows.Forms.Label();
            lbl_notes_add = new System.Windows.Forms.Label();
            lbl_type_add = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingNavigator)).BeginInit();
            this.tb_ClientBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientTypeBindingSource)).BeginInit();
            this.gb_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientTypeBindingSource1)).BeginInit();
            this.gb_save_del.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new System.Drawing.Point(24, 25);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(67, 13);
            lbl_name.TabIndex = 4;
            lbl_name.Text = "Client Name:";
            // 
            // lbl_sales
            // 
            lbl_sales.AutoSize = true;
            lbl_sales.Location = new System.Drawing.Point(24, 81);
            lbl_sales.Name = "lbl_sales";
            lbl_sales.Size = new System.Drawing.Size(63, 13);
            lbl_sales.TabIndex = 8;
            lbl_sales.Text = "Total Sales:";
            // 
            // lbl_notes
            // 
            lbl_notes.AutoSize = true;
            lbl_notes.Location = new System.Drawing.Point(24, 107);
            lbl_notes.Name = "lbl_notes";
            lbl_notes.Size = new System.Drawing.Size(38, 13);
            lbl_notes.TabIndex = 10;
            lbl_notes.Text = "Notes:";
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Location = new System.Drawing.Point(24, 188);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new System.Drawing.Size(63, 13);
            lbl_type.TabIndex = 12;
            lbl_type.Text = "Client Type:";
            // 
            // lbl_name_add
            // 
            lbl_name_add.AutoSize = true;
            lbl_name_add.Location = new System.Drawing.Point(34, 25);
            lbl_name_add.Name = "lbl_name_add";
            lbl_name_add.Size = new System.Drawing.Size(67, 13);
            lbl_name_add.TabIndex = 20;
            lbl_name_add.Text = "Client Name:";
            // 
            // lbl_sales_add
            // 
            lbl_sales_add.AutoSize = true;
            lbl_sales_add.Location = new System.Drawing.Point(34, 81);
            lbl_sales_add.Name = "lbl_sales_add";
            lbl_sales_add.Size = new System.Drawing.Size(63, 13);
            lbl_sales_add.TabIndex = 23;
            lbl_sales_add.Text = "Total Sales:";
            // 
            // lbl_notes_add
            // 
            lbl_notes_add.AutoSize = true;
            lbl_notes_add.Location = new System.Drawing.Point(34, 107);
            lbl_notes_add.Name = "lbl_notes_add";
            lbl_notes_add.Size = new System.Drawing.Size(38, 13);
            lbl_notes_add.TabIndex = 24;
            lbl_notes_add.Text = "Notes:";
            // 
            // lbl_type_add
            // 
            lbl_type_add.AutoSize = true;
            lbl_type_add.Location = new System.Drawing.Point(34, 188);
            lbl_type_add.Name = "lbl_type_add";
            lbl_type_add.Size = new System.Drawing.Size(63, 13);
            lbl_type_add.TabIndex = 25;
            lbl_type_add.Text = "Client Type:";
            // 
            // main_connection
            // 
            this.main_connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\\Users\\uservs2\\Desktop\\save_it_on" +
    "_the_desktop\\00019257_fptest\\00019257_fptest\\Clients.mdb";
            // 
            // tb_ClientBindingNavigator
            // 
            this.tb_ClientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tb_ClientBindingNavigator.BindingSource = this.tb_ClientBindingSource;
            this.tb_ClientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tb_ClientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tb_ClientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tb_ClientBindingNavigatorSaveItem});
            this.tb_ClientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tb_ClientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tb_ClientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tb_ClientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tb_ClientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tb_ClientBindingNavigator.Name = "tb_ClientBindingNavigator";
            this.tb_ClientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tb_ClientBindingNavigator.Size = new System.Drawing.Size(1115, 25);
            this.tb_ClientBindingNavigator.TabIndex = 0;
            this.tb_ClientBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tb_ClientBindingSource
            // 
            this.tb_ClientBindingSource.DataMember = "tb_Client";
            this.tb_ClientBindingSource.DataSource = this.clientsDataSet;
            // 
            // clientsDataSet
            // 
            this.clientsDataSet.DataSetName = "ClientsDataSet";
            this.clientsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tb_ClientBindingNavigatorSaveItem
            // 
            this.tb_ClientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tb_ClientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tb_ClientBindingNavigatorSaveItem.Image")));
            this.tb_ClientBindingNavigatorSaveItem.Name = "tb_ClientBindingNavigatorSaveItem";
            this.tb_ClientBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tb_ClientBindingNavigatorSaveItem.Text = "Save Data";
            this.tb_ClientBindingNavigatorSaveItem.Click += new System.EventHandler(this.tb_ClientBindingNavigatorSaveItem_Click);
            // 
            // tb_ClientTableAdapter
            // 
            this.tb_ClientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_ClientTableAdapter = this.tb_ClientTableAdapter;
            this.tableAdapterManager.tb_ClientTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _00019257_fptest.ClientsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // main_menu_lb
            // 
            this.main_menu_lb.BackColor = System.Drawing.SystemColors.WindowText;
            this.main_menu_lb.DataSource = this.tb_ClientBindingSource;
            this.main_menu_lb.DisplayMember = "ClientName";
            this.main_menu_lb.ForeColor = System.Drawing.SystemColors.Menu;
            this.main_menu_lb.FormattingEnabled = true;
            this.main_menu_lb.Location = new System.Drawing.Point(31, 118);
            this.main_menu_lb.Name = "main_menu_lb";
            this.main_menu_lb.Size = new System.Drawing.Size(140, 238);
            this.main_menu_lb.TabIndex = 1;
            // 
            // tbx_name
            // 
            this.tbx_name.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ClientBindingSource, "ClientName", true));
            this.tbx_name.Location = new System.Drawing.Point(97, 22);
            this.tbx_name.Name = "tbx_name";
            this.tbx_name.Size = new System.Drawing.Size(136, 20);
            this.tbx_name.TabIndex = 5;
            this.tbx_name.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_name_Validating);
            // 
            // cbx_active
            // 
            this.cbx_active.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_active.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tb_ClientBindingSource, "IsActive", true));
            this.cbx_active.Location = new System.Drawing.Point(27, 48);
            this.cbx_active.Name = "cbx_active";
            this.cbx_active.Size = new System.Drawing.Size(206, 24);
            this.cbx_active.TabIndex = 7;
            this.cbx_active.Text = "Active";
            this.cbx_active.UseVisualStyleBackColor = true;
            // 
            // cbx_type
            // 
            this.cbx_type.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_ClientBindingSource, "ClientType", true));
            this.cbx_type.DataSource = this.tbClientTypeBindingSource;
            this.cbx_type.DisplayMember = "ClientTypeName";
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Location = new System.Drawing.Point(96, 185);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(137, 21);
            this.cbx_type.TabIndex = 15;
            this.cbx_type.ValueMember = "Id";
            // 
            // tbClientTypeBindingSource
            // 
            this.tbClientTypeBindingSource.DataMember = "tb_ClientType";
            this.tbClientTypeBindingSource.DataSource = this.clientsDataSet;
            // 
            // tb_ClientTypeTableAdapter
            // 
            this.tb_ClientTypeTableAdapter.ClearBeforeFill = true;
            // 
            // rtbx_notes
            // 
            this.rtbx_notes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ClientBindingSource, "Notes", true));
            this.rtbx_notes.Location = new System.Drawing.Point(97, 107);
            this.rtbx_notes.Name = "rtbx_notes";
            this.rtbx_notes.Size = new System.Drawing.Size(136, 72);
            this.rtbx_notes.TabIndex = 16;
            this.rtbx_notes.Text = "";
            this.rtbx_notes.Validating += new System.ComponentModel.CancelEventHandler(this.rtbx_notes_Validating);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(97, 222);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(65, 23);
            this.btn_save.TabIndex = 17;
            this.btn_save.Text = "SAVE";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(168, 222);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(65, 23);
            this.btn_del.TabIndex = 18;
            this.btn_del.Text = "DELETE";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // gb_add
            // 
            this.gb_add.Controls.Add(this.tbx_sales_add);
            this.gb_add.Controls.Add(this.btn_add);
            this.gb_add.Controls.Add(this.rtbx_notes_add);
            this.gb_add.Controls.Add(this.tbx_name_add);
            this.gb_add.Controls.Add(this.cbx_type_add);
            this.gb_add.Controls.Add(lbl_type_add);
            this.gb_add.Controls.Add(lbl_notes_add);
            this.gb_add.Controls.Add(lbl_name_add);
            this.gb_add.Controls.Add(lbl_sales_add);
            this.gb_add.Controls.Add(this.cbx_active_add);
            this.gb_add.Location = new System.Drawing.Point(524, 118);
            this.gb_add.Name = "gb_add";
            this.gb_add.Size = new System.Drawing.Size(286, 246);
            this.gb_add.TabIndex = 19;
            this.gb_add.TabStop = false;
            this.gb_add.Text = "add";
            // 
            // tbx_sales_add
            // 
            this.tbx_sales_add.Location = new System.Drawing.Point(106, 79);
            this.tbx_sales_add.Name = "tbx_sales_add";
            this.tbx_sales_add.Size = new System.Drawing.Size(136, 20);
            this.tbx_sales_add.TabIndex = 30;
            this.tbx_sales_add.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_sales_add_Validating);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(197, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(45, 23);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // rtbx_notes_add
            // 
            this.rtbx_notes_add.Location = new System.Drawing.Point(107, 107);
            this.rtbx_notes_add.Name = "rtbx_notes_add";
            this.rtbx_notes_add.Size = new System.Drawing.Size(136, 72);
            this.rtbx_notes_add.TabIndex = 28;
            this.rtbx_notes_add.Text = "";
            this.rtbx_notes_add.Validating += new System.ComponentModel.CancelEventHandler(this.rtbx_notes_add_Validating);
            // 
            // tbx_name_add
            // 
            this.tbx_name_add.Location = new System.Drawing.Point(107, 22);
            this.tbx_name_add.Name = "tbx_name_add";
            this.tbx_name_add.Size = new System.Drawing.Size(136, 20);
            this.tbx_name_add.TabIndex = 21;
            this.tbx_name_add.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_name_add_Validating);
            // 
            // cbx_type_add
            // 
            this.cbx_type_add.DataSource = this.tbClientTypeBindingSource1;
            this.cbx_type_add.DisplayMember = "ClientTypeName";
            this.cbx_type_add.FormattingEnabled = true;
            this.cbx_type_add.Location = new System.Drawing.Point(106, 185);
            this.cbx_type_add.Name = "cbx_type_add";
            this.cbx_type_add.Size = new System.Drawing.Size(137, 21);
            this.cbx_type_add.TabIndex = 27;
            // 
            // tbClientTypeBindingSource1
            // 
            this.tbClientTypeBindingSource1.DataMember = "tb_ClientType";
            this.tbClientTypeBindingSource1.DataSource = this.clientsDataSet;
            // 
            // cbx_active_add
            // 
            this.cbx_active_add.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_active_add.Location = new System.Drawing.Point(37, 48);
            this.cbx_active_add.Name = "cbx_active_add";
            this.cbx_active_add.Size = new System.Drawing.Size(206, 24);
            this.cbx_active_add.TabIndex = 22;
            this.cbx_active_add.Text = "Active";
            this.cbx_active_add.UseVisualStyleBackColor = true;
            // 
            // tbx_sales
            // 
            this.tbx_sales.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_ClientBindingSource, "TotalSales", true));
            this.tbx_sales.Location = new System.Drawing.Point(97, 78);
            this.tbx_sales.Name = "tbx_sales";
            this.tbx_sales.Size = new System.Drawing.Size(136, 20);
            this.tbx_sales.TabIndex = 21;
            this.tbx_sales.Validating += new System.ComponentModel.CancelEventHandler(this.tbx_sales_Validating);
            // 
            // tbx_search
            // 
            this.tbx_search.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbx_search.ForeColor = System.Drawing.SystemColors.Window;
            this.tbx_search.Location = new System.Drawing.Point(31, 92);
            this.tbx_search.Name = "tbx_search";
            this.tbx_search.Size = new System.Drawing.Size(140, 20);
            this.tbx_search.TabIndex = 22;
            this.tbx_search.TextChanged += new System.EventHandler(this.tbx_search_TextChanged);
            // 
            // gb_save_del
            // 
            this.gb_save_del.Controls.Add(lbl_name);
            this.gb_save_del.Controls.Add(this.tbx_name);
            this.gb_save_del.Controls.Add(lbl_type);
            this.gb_save_del.Controls.Add(this.rtbx_notes);
            this.gb_save_del.Controls.Add(this.btn_save);
            this.gb_save_del.Controls.Add(this.tbx_sales);
            this.gb_save_del.Controls.Add(this.cbx_type);
            this.gb_save_del.Controls.Add(this.cbx_active);
            this.gb_save_del.Controls.Add(lbl_notes);
            this.gb_save_del.Controls.Add(this.btn_del);
            this.gb_save_del.Controls.Add(lbl_sales);
            this.gb_save_del.Location = new System.Drawing.Point(237, 110);
            this.gb_save_del.Name = "gb_save_del";
            this.gb_save_del.Size = new System.Drawing.Size(266, 258);
            this.gb_save_del.TabIndex = 23;
            this.gb_save_del.TabStop = false;
            this.gb_save_del.Text = "save n delete";
            // 
            // btn_first
            // 
            this.btn_first.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_first.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_first.Location = new System.Drawing.Point(31, 362);
            this.btn_first.Name = "btn_first";
            this.btn_first.Size = new System.Drawing.Size(31, 23);
            this.btn_first.TabIndex = 24;
            this.btn_first.Text = "<<";
            this.btn_first.UseVisualStyleBackColor = false;
            this.btn_first.Click += new System.EventHandler(this.btn_first_Click);
            // 
            // btn_prev
            // 
            this.btn_prev.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_prev.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_prev.Location = new System.Drawing.Point(66, 362);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(31, 23);
            this.btn_prev.TabIndex = 25;
            this.btn_prev.Text = "<";
            this.btn_prev.UseVisualStyleBackColor = false;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_next.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_next.Location = new System.Drawing.Point(103, 362);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(31, 23);
            this.btn_next.TabIndex = 26;
            this.btn_next.Text = ">";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_last
            // 
            this.btn_last.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_last.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_last.Location = new System.Drawing.Point(140, 362);
            this.btn_last.Name = "btn_last";
            this.btn_last.Size = new System.Drawing.Size(31, 23);
            this.btn_last.TabIndex = 27;
            this.btn_last.Text = ">>";
            this.btn_last.UseVisualStyleBackColor = false;
            this.btn_last.Click += new System.EventHandler(this.btn_last_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 538);
            this.Controls.Add(this.btn_last);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_first);
            this.Controls.Add(this.gb_save_del);
            this.Controls.Add(this.tbx_search);
            this.Controls.Add(this.gb_add);
            this.Controls.Add(this.main_menu_lb);
            this.Controls.Add(this.tb_ClientBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingNavigator)).EndInit();
            this.tb_ClientBindingNavigator.ResumeLayout(false);
            this.tb_ClientBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ClientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientTypeBindingSource)).EndInit();
            this.gb_add.ResumeLayout(false);
            this.gb_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbClientTypeBindingSource1)).EndInit();
            this.gb_save_del.ResumeLayout(false);
            this.gb_save_del.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection main_connection;
        private ClientsDataSet clientsDataSet;
        private System.Windows.Forms.BindingSource tb_ClientBindingSource;
        private ClientsDataSetTableAdapters.tb_ClientTableAdapter tb_ClientTableAdapter;
        private ClientsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tb_ClientBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tb_ClientBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox main_menu_lb;
        private System.Windows.Forms.TextBox tbx_name;
        private System.Windows.Forms.CheckBox cbx_active;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.BindingSource tbClientTypeBindingSource;
        private ClientsDataSetTableAdapters.tb_ClientTypeTableAdapter tb_ClientTypeTableAdapter;
        private System.Windows.Forms.RichTextBox rtbx_notes;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.GroupBox gb_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.RichTextBox rtbx_notes_add;
        private System.Windows.Forms.TextBox tbx_name_add;
        private System.Windows.Forms.ComboBox cbx_type_add;
        private System.Windows.Forms.CheckBox cbx_active_add;
        private System.Windows.Forms.BindingSource tbClientTypeBindingSource1;
        private System.Windows.Forms.TextBox tbx_sales;
        private System.Windows.Forms.TextBox tbx_sales_add;
        private System.Windows.Forms.TextBox tbx_search;
        private System.Windows.Forms.GroupBox gb_save_del;
        private System.Windows.Forms.Button btn_first;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_last;
    }
}

