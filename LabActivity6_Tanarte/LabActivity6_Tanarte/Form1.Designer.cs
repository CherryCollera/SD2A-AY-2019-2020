namespace LabActivity6_Tanarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.refreshToolStrip = new System.Windows.Forms.ToolStrip();
            this.refreshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.studIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblStudentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsDataSet = new LabActivity6_Tanarte.studentsDataSet();
            this.tblStudent_InfoTableAdapter = new LabActivity6_Tanarte.studentsDataSetTableAdapters.tblStudent_InfoTableAdapter();
            this.bSITToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSITToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bSCSToolStrip = new System.Windows.Forms.ToolStrip();
            this.bSCSToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this._2nd_YearToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._2nd_YearToolStrip = new System.Windows.Forms.ToolStrip();
            this.address_BalangaToolStrip = new System.Windows.Forms.ToolStrip();
            this.address_BalangaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.section_2BToolStrip = new System.Windows.Forms.ToolStrip();
            this.section_2BToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.firstnames_ConsonantToolStrip = new System.Windows.Forms.ToolStrip();
            this.firstnames_ConsonantToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lastname_Consonant_A_and_CToolStrip = new System.Windows.Forms.ToolStrip();
            this.lastname_Consonant_A_and_CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.refreshToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).BeginInit();
            this.bSITToolStrip.SuspendLayout();
            this.bSCSToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this._2nd_YearToolStrip.SuspendLayout();
            this.address_BalangaToolStrip.SuspendLayout();
            this.section_2BToolStrip.SuspendLayout();
            this.firstnames_ConsonantToolStrip.SuspendLayout();
            this.lastname_Consonant_A_and_CToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studIDDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.programDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.yearLevelDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(28, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(945, 201);
            this.dataGridView1.TabIndex = 0;
            // 
            // refreshToolStrip
            // 
            this.refreshToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.refreshToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripButton});
            this.refreshToolStrip.Location = new System.Drawing.Point(824, 293);
            this.refreshToolStrip.Name = "refreshToolStrip";
            this.refreshToolStrip.Size = new System.Drawing.Size(92, 63);
            this.refreshToolStrip.TabIndex = 1;
            this.refreshToolStrip.Text = "refreshToolStrip";
            this.refreshToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.refreshToolStrip_ItemClicked);
            // 
            // refreshToolStripButton
            // 
            this.refreshToolStripButton.AutoSize = false;
            this.refreshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshToolStripButton.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshToolStripButton.Name = "refreshToolStripButton";
            this.refreshToolStripButton.Size = new System.Drawing.Size(80, 60);
            this.refreshToolStripButton.Text = "Refresh";
            this.refreshToolStripButton.Click += new System.EventHandler(this.refreshToolStripButton_Click);
            // 
            // studIDDataGridViewTextBoxColumn
            // 
            this.studIDDataGridViewTextBoxColumn.DataPropertyName = "StudID";
            this.studIDDataGridViewTextBoxColumn.HeaderText = "StudID";
            this.studIDDataGridViewTextBoxColumn.Name = "studIDDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "Birthday";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            // 
            // programDataGridViewTextBoxColumn
            // 
            this.programDataGridViewTextBoxColumn.DataPropertyName = "Program";
            this.programDataGridViewTextBoxColumn.HeaderText = "Program";
            this.programDataGridViewTextBoxColumn.Name = "programDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // yearLevelDataGridViewTextBoxColumn
            // 
            this.yearLevelDataGridViewTextBoxColumn.DataPropertyName = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.HeaderText = "YearLevel";
            this.yearLevelDataGridViewTextBoxColumn.Name = "yearLevelDataGridViewTextBoxColumn";
            // 
            // tblStudentInfoBindingSource
            // 
            this.tblStudentInfoBindingSource.DataMember = "tblStudent_Info";
            this.tblStudentInfoBindingSource.DataSource = this.studentsDataSet;
            // 
            // studentsDataSet
            // 
            this.studentsDataSet.DataSetName = "studentsDataSet";
            this.studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStudent_InfoTableAdapter
            // 
            this.tblStudent_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // bSITToolStrip
            // 
            this.bSITToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSITToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSITToolStripButton});
            this.bSITToolStrip.Location = new System.Drawing.Point(85, 293);
            this.bSITToolStrip.Name = "bSITToolStrip";
            this.bSITToolStrip.Size = new System.Drawing.Size(57, 25);
            this.bSITToolStrip.TabIndex = 2;
            this.bSITToolStrip.Text = "bSITToolStrip";
            // 
            // bSITToolStripButton
            // 
            this.bSITToolStripButton.AutoSize = false;
            this.bSITToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSITToolStripButton.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSITToolStripButton.Name = "bSITToolStripButton";
            this.bSITToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.bSITToolStripButton.Text = "BSIT";
            this.bSITToolStripButton.Click += new System.EventHandler(this.bSITToolStripButton_Click);
            // 
            // bSCSToolStrip
            // 
            this.bSCSToolStrip.BackColor = System.Drawing.Color.White;
            this.bSCSToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.bSCSToolStrip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSCSToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bSCSToolStripButton});
            this.bSCSToolStrip.Location = new System.Drawing.Point(151, 333);
            this.bSCSToolStrip.Name = "bSCSToolStrip";
            this.bSCSToolStrip.Size = new System.Drawing.Size(59, 25);
            this.bSCSToolStrip.TabIndex = 3;
            this.bSCSToolStrip.Text = "bSCSToolStrip";
            // 
            // bSCSToolStripButton
            // 
            this.bSCSToolStripButton.BackColor = System.Drawing.Color.White;
            this.bSCSToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bSCSToolStripButton.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSCSToolStripButton.Name = "bSCSToolStripButton";
            this.bSCSToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.bSCSToolStripButton.Text = "BSCS";
            this.bSCSToolStripButton.Click += new System.EventHandler(this.bSCSToolStripButton_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.tblStudentInfoBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(361, 260);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 4;
            this.bindingNavigator1.Text = "0";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // _2nd_YearToolStripButton
            // 
            this._2nd_YearToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._2nd_YearToolStripButton.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2nd_YearToolStripButton.Name = "_2nd_YearToolStripButton";
            this._2nd_YearToolStripButton.Size = new System.Drawing.Size(92, 22);
            this._2nd_YearToolStripButton.Text = "_2nd_Year";
            this._2nd_YearToolStripButton.Click += new System.EventHandler(this._2nd_YearToolStripButton_Click);
            // 
            // _2nd_YearToolStrip
            // 
            this._2nd_YearToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this._2nd_YearToolStrip.Font = new System.Drawing.Font("Stencil", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._2nd_YearToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._2nd_YearToolStripButton});
            this._2nd_YearToolStrip.Location = new System.Drawing.Point(227, 293);
            this._2nd_YearToolStrip.Name = "_2nd_YearToolStrip";
            this._2nd_YearToolStrip.Size = new System.Drawing.Size(104, 25);
            this._2nd_YearToolStrip.TabIndex = 5;
            this._2nd_YearToolStrip.Text = "_2nd_YearToolStrip";
            // 
            // address_BalangaToolStrip
            // 
            this.address_BalangaToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.address_BalangaToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.address_BalangaToolStripButton});
            this.address_BalangaToolStrip.Location = new System.Drawing.Point(514, 333);
            this.address_BalangaToolStrip.Name = "address_BalangaToolStrip";
            this.address_BalangaToolStrip.Size = new System.Drawing.Size(159, 25);
            this.address_BalangaToolStrip.TabIndex = 6;
            this.address_BalangaToolStrip.Text = "address_BalangaToolStrip";
            // 
            // address_BalangaToolStripButton
            // 
            this.address_BalangaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.address_BalangaToolStripButton.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_BalangaToolStripButton.Name = "address_BalangaToolStripButton";
            this.address_BalangaToolStripButton.Size = new System.Drawing.Size(147, 22);
            this.address_BalangaToolStripButton.Text = "Address_Balanga";
            this.address_BalangaToolStripButton.Click += new System.EventHandler(this.address_BalangaToolStripButton_Click);
            // 
            // section_2BToolStrip
            // 
            this.section_2BToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.section_2BToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.section_2BToolStripButton});
            this.section_2BToolStrip.Location = new System.Drawing.Point(311, 333);
            this.section_2BToolStrip.Name = "section_2BToolStrip";
            this.section_2BToolStrip.Size = new System.Drawing.Size(111, 25);
            this.section_2BToolStrip.TabIndex = 7;
            this.section_2BToolStrip.Text = "section_2BToolStrip";
            // 
            // section_2BToolStripButton
            // 
            this.section_2BToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.section_2BToolStripButton.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.section_2BToolStripButton.Name = "section_2BToolStripButton";
            this.section_2BToolStripButton.Size = new System.Drawing.Size(99, 22);
            this.section_2BToolStripButton.Text = "Section_2B";
            this.section_2BToolStripButton.Click += new System.EventHandler(this.section_2BToolStripButton_Click);
            // 
            // firstnames_ConsonantToolStrip
            // 
            this.firstnames_ConsonantToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.firstnames_ConsonantToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstnames_ConsonantToolStripButton});
            this.firstnames_ConsonantToolStrip.Location = new System.Drawing.Point(376, 293);
            this.firstnames_ConsonantToolStrip.Name = "firstnames_ConsonantToolStrip";
            this.firstnames_ConsonantToolStrip.Size = new System.Drawing.Size(205, 25);
            this.firstnames_ConsonantToolStrip.TabIndex = 8;
            this.firstnames_ConsonantToolStrip.Text = "firstnames_ConsonantToolStrip";
            // 
            // firstnames_ConsonantToolStripButton
            // 
            this.firstnames_ConsonantToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.firstnames_ConsonantToolStripButton.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnames_ConsonantToolStripButton.Name = "firstnames_ConsonantToolStripButton";
            this.firstnames_ConsonantToolStripButton.Size = new System.Drawing.Size(193, 22);
            this.firstnames_ConsonantToolStripButton.Text = "Firstnames_Consonant";
            this.firstnames_ConsonantToolStripButton.Click += new System.EventHandler(this.firstnames_ConsonantToolStripButton_Click);
            // 
            // lastname_Consonant_A_and_CToolStrip
            // 
            this.lastname_Consonant_A_and_CToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lastname_Consonant_A_and_CToolStrip.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_Consonant_A_and_CToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lastname_Consonant_A_and_CToolStripButton});
            this.lastname_Consonant_A_and_CToolStrip.Location = new System.Drawing.Point(622, 293);
            this.lastname_Consonant_A_and_CToolStrip.Name = "lastname_Consonant_A_and_CToolStrip";
            this.lastname_Consonant_A_and_CToolStrip.Size = new System.Drawing.Size(166, 25);
            this.lastname_Consonant_A_and_CToolStrip.TabIndex = 9;
            this.lastname_Consonant_A_and_CToolStrip.Text = "lastname_Consonant_A_and_CToolStrip";
            // 
            // lastname_Consonant_A_and_CToolStripButton
            // 
            this.lastname_Consonant_A_and_CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lastname_Consonant_A_and_CToolStripButton.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname_Consonant_A_and_CToolStripButton.Name = "lastname_Consonant_A_and_CToolStripButton";
            this.lastname_Consonant_A_and_CToolStripButton.Size = new System.Drawing.Size(154, 22);
            this.lastname_Consonant_A_and_CToolStripButton.Text = "Lastname_A_and_C";
            this.lastname_Consonant_A_and_CToolStripButton.Click += new System.EventHandler(this.lastname_Consonant_A_and_CToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(600, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Student\'s Records Monitoring System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1003, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastname_Consonant_A_and_CToolStrip);
            this.Controls.Add(this.firstnames_ConsonantToolStrip);
            this.Controls.Add(this.section_2BToolStrip);
            this.Controls.Add(this.address_BalangaToolStrip);
            this.Controls.Add(this._2nd_YearToolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.bSCSToolStrip);
            this.Controls.Add(this.bSITToolStrip);
            this.Controls.Add(this.refreshToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.refreshToolStrip.ResumeLayout(false);
            this.refreshToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsDataSet)).EndInit();
            this.bSITToolStrip.ResumeLayout(false);
            this.bSITToolStrip.PerformLayout();
            this.bSCSToolStrip.ResumeLayout(false);
            this.bSCSToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this._2nd_YearToolStrip.ResumeLayout(false);
            this._2nd_YearToolStrip.PerformLayout();
            this.address_BalangaToolStrip.ResumeLayout(false);
            this.address_BalangaToolStrip.PerformLayout();
            this.section_2BToolStrip.ResumeLayout(false);
            this.section_2BToolStrip.PerformLayout();
            this.firstnames_ConsonantToolStrip.ResumeLayout(false);
            this.firstnames_ConsonantToolStrip.PerformLayout();
            this.lastname_Consonant_A_and_CToolStrip.ResumeLayout(false);
            this.lastname_Consonant_A_and_CToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private studentsDataSet studentsDataSet;
        private System.Windows.Forms.BindingSource tblStudentInfoBindingSource;
        private studentsDataSetTableAdapters.tblStudent_InfoTableAdapter tblStudent_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip refreshToolStrip;
        private System.Windows.Forms.ToolStripButton refreshToolStripButton;
        private System.Windows.Forms.ToolStrip bSITToolStrip;
        private System.Windows.Forms.ToolStripButton bSITToolStripButton;
        private System.Windows.Forms.ToolStrip bSCSToolStrip;
        private System.Windows.Forms.ToolStripButton bSCSToolStripButton;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
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
        private System.Windows.Forms.ToolStripButton _2nd_YearToolStripButton;
        private System.Windows.Forms.ToolStrip _2nd_YearToolStrip;
        private System.Windows.Forms.ToolStrip address_BalangaToolStrip;
        private System.Windows.Forms.ToolStripButton address_BalangaToolStripButton;
        private System.Windows.Forms.ToolStrip section_2BToolStrip;
        private System.Windows.Forms.ToolStripButton section_2BToolStripButton;
        private System.Windows.Forms.ToolStrip firstnames_ConsonantToolStrip;
        private System.Windows.Forms.ToolStripButton firstnames_ConsonantToolStripButton;
        private System.Windows.Forms.ToolStrip lastname_Consonant_A_and_CToolStrip;
        private System.Windows.Forms.ToolStripButton lastname_Consonant_A_and_CToolStripButton;
        private System.Windows.Forms.Label label1;
    }
}

