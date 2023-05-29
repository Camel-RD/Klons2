
namespace KlonsM.FormsM
{
    partial class FormM_DiscountList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormM_DiscountList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bsLists = new KlonsLIB.Data.MyBindingSource(this.components);
            this.bNav = new KlonsLIB.Components.MyBindingNavigator();
            this.bniNew = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bniDelete = new System.Windows.Forms.ToolStripButton();
            this.tslActiveTable = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bniSave = new System.Windows.Forms.ToolStripButton();
            this.tsbFindPrev = new System.Windows.Forms.ToolStripButton();
            this.tsbFind = new System.Windows.Forms.ToolStripTextBox();
            this.tsbFindNext = new System.Windows.Forms.ToolStripButton();
            this.bsRowsR = new KlonsLIB.Data.MyBindingSource2(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btTab2 = new KlonsLIB.Components.MyButton();
            this.btTab1 = new KlonsLIB.Components.MyButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLists = new KlonsLIB.Components.MyPickRowTextBox2();
            this.dgvRowsR = new KlonsLIB.Components.MyDataGridView();
            this.dgcRIdItemsCat = new KlonsLIB.Components.MyDgvTextboxColumn2();
            this.bsItemsCat = new KlonsLIB.Data.MyBindingSource(this.components);
            this.dgcRIdcItem = new KlonsLIB.Components.MyDgvTextboxColumn2();
            this.bsItems = new KlonsLIB.Data.MyBindingSource(this.components);
            this.dgcRItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgcRDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcTabs = new KlonsLIB.Components.TabControlWithoutHeader();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRowsP = new KlonsLIB.Components.MyDataGridView();
            this.dgcPIdStoresCat = new KlonsLIB.Components.MyDgvTextboxColumn2();
            this.bsStoresCat = new KlonsLIB.Data.MyBindingSource(this.components);
            this.dgcPIdStore = new KlonsLIB.Components.MyDgvTextboxColumn2();
            this.bsStores = new KlonsLIB.Data.MyBindingSource(this.components);
            this.bsRowsP = new KlonsLIB.Data.MyBindingSource2(this.components);
            this.myAdapterManager1 = new KlonsLIB.Data.MyAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bsLists)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNav)).BeginInit();
            this.bNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRowsR)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowsR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemsCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            this.tcTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStoresCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRowsP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAdapterManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // bsLists
            // 
            this.bsLists.DataMember = "M_DISC_LISTS";
            this.bsLists.MyDataSource = "KlonsMData";
            this.bsLists.CurrentChanged += new System.EventHandler(this.bsLists_CurrentChanged);
            this.bsLists.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsLists_ListChanged);
            // 
            // bNav
            // 
            this.bNav.AddNewItem = this.bniNew;
            this.bNav.CountItem = this.bindingNavigatorCountItem;
            this.bNav.CountItemFormat = " no {0}";
            this.bNav.DeleteItem = this.bniDelete;
            this.bNav.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bNav.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslActiveTable,
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bniNew,
            this.bniDelete,
            this.bniSave,
            this.tsbFindPrev,
            this.tsbFind,
            this.tsbFindNext});
            this.bNav.Location = new System.Drawing.Point(0, 504);
            this.bNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNav.Name = "bNav";
            this.bNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bNav.SaveItem = this.bniSave;
            this.bNav.Size = new System.Drawing.Size(903, 39);
            this.bNav.TabIndex = 3;
            this.bNav.Text = "myBindingNavigator1";
            this.bNav.ItemDeleting += new System.ComponentModel.CancelEventHandler(this.bNav_ItemDeleting);
            // 
            // bniNew
            // 
            this.bniNew.Image = ((System.Drawing.Image)(resources.GetObject("bniNew.Image")));
            this.bniNew.Name = "bniNew";
            this.bniNew.RightToLeftAutoMirrorImage = true;
            this.bniNew.Size = new System.Drawing.Size(93, 34);
            this.bniNew.Text = "Jauns";
            this.bniNew.Click += new System.EventHandler(this.bniNew_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(76, 34);
            this.bindingNavigatorCountItem.Text = " no {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Ierakstu skaits";
            // 
            // bniDelete
            // 
            this.bniDelete.Image = ((System.Drawing.Image)(resources.GetObject("bniDelete.Image")));
            this.bniDelete.Name = "bniDelete";
            this.bniDelete.RightToLeftAutoMirrorImage = true;
            this.bniDelete.Size = new System.Drawing.Size(94, 34);
            this.bniDelete.Text = "Dzēst";
            this.bniDelete.Click += new System.EventHandler(this.bniDelete_Click);
            // 
            // tslActiveTable
            // 
            this.tslActiveTable.Name = "tslActiveTable";
            this.tslActiveTable.Size = new System.Drawing.Size(28, 34);
            this.tslActiveTable.Text = "...";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveFirstItem.Text = "Iet uz pirmo";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMovePreviousItem.Text = "Iet uz iepriekšējo";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 37);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Pašreizējā pozīcija";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveNextItem.Text = "Iet uz nākošo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 34);
            this.bindingNavigatorMoveLastItem.Text = "Iet uz pēdējo";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // bniSave
            // 
            this.bniSave.Image = ((System.Drawing.Image)(resources.GetObject("bniSave.Image")));
            this.bniSave.Name = "bniSave";
            this.bniSave.Size = new System.Drawing.Size(124, 34);
            this.bniSave.Text = "Saglabāt";
            this.bniSave.Click += new System.EventHandler(this.bniSave_Click);
            // 
            // tsbFindPrev
            // 
            this.tsbFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindPrev.Image = ((System.Drawing.Image)(resources.GetObject("tsbFindPrev.Image")));
            this.tsbFindPrev.Name = "tsbFindPrev";
            this.tsbFindPrev.RightToLeftAutoMirrorImage = true;
            this.tsbFindPrev.Size = new System.Drawing.Size(34, 34);
            this.tsbFindPrev.Text = "Iet uz iepriekšējo";
            this.tsbFindPrev.Click += new System.EventHandler(this.tsbFindPrev_Click);
            // 
            // tsbFind
            // 
            this.tsbFind.Name = "tsbFind";
            this.tsbFind.Size = new System.Drawing.Size(100, 39);
            this.tsbFind.ToolTipText = "meklēt tekstu kolonnā";
            this.tsbFind.Enter += new System.EventHandler(this.tsbFind_Enter);
            this.tsbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tsbFind_KeyPress);
            // 
            // tsbFindNext
            // 
            this.tsbFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFindNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbFindNext.Image")));
            this.tsbFindNext.Name = "tsbFindNext";
            this.tsbFindNext.RightToLeftAutoMirrorImage = true;
            this.tsbFindNext.Size = new System.Drawing.Size(34, 34);
            this.tsbFindNext.Text = "Iet uz nākošo";
            this.tsbFindNext.Click += new System.EventHandler(this.tsbFindNext_Click);
            // 
            // bsRowsR
            // 
            this.bsRowsR.DataMember = "FK_M_DISC_LISTS_R_IDL";
            this.bsRowsR.DataSource = this.bsLists;
            this.bsRowsR.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsRowsR_ListChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btTab2);
            this.panel1.Controls.Add(this.btTab1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbLists);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 38);
            this.panel1.TabIndex = 4;
            // 
            // btTab2
            // 
            this.btTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTab2.Location = new System.Drawing.Point(499, 5);
            this.btTab2.Name = "btTab2";
            this.btTab2.Selectable = false;
            this.btTab2.Size = new System.Drawing.Size(79, 27);
            this.btTab2.TabIndex = 2;
            this.btTab2.Text = "Partneri";
            this.btTab2.UseVisualStyleBackColor = true;
            this.btTab2.Click += new System.EventHandler(this.btTab2_Click);
            // 
            // btTab1
            // 
            this.btTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTab1.Location = new System.Drawing.Point(416, 5);
            this.btTab1.Name = "btTab1";
            this.btTab1.Selectable = false;
            this.btTab1.Size = new System.Drawing.Size(79, 27);
            this.btTab1.TabIndex = 2;
            this.btTab1.Text = "Artikuli";
            this.btTab1.UseVisualStyleBackColor = true;
            this.btTab1.Click += new System.EventHandler(this.btTab1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atlaižu lapas:";
            // 
            // tbLists
            // 
            this.tbLists.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tbLists.DataMember = null;
            this.tbLists.DataSource = this.bsLists;
            this.tbLists.DisplayMember = "NAME";
            this.tbLists.Location = new System.Drawing.Point(119, 6);
            this.tbLists.Name = "tbLists";
            this.tbLists.SelectedIndex = -1;
            this.tbLists.ShowButton = true;
            this.tbLists.Size = new System.Drawing.Size(259, 26);
            this.tbLists.TabIndex = 0;
            this.tbLists.ValueMember = "ID";
            this.tbLists.ButtonClicked += new System.EventHandler(this.tbLists_ButtonClicked);
            // 
            // dgvRowsR
            // 
            this.dgvRowsR.AutoGenerateColumns = false;
            this.dgvRowsR.AutoSave = false;
            this.dgvRowsR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRowsR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRowsR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcRIdItemsCat,
            this.dgcRIdcItem,
            this.dgcRItemName,
            this.dgcRDiscount});
            this.dgvRowsR.DataSource = this.bsRowsR;
            this.dgvRowsR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRowsR.Location = new System.Drawing.Point(3, 3);
            this.dgvRowsR.Name = "dgvRowsR";
            this.dgvRowsR.RowHeadersWidth = 62;
            this.dgvRowsR.RowTemplate.Height = 28;
            this.dgvRowsR.ShowCellToolTips = false;
            this.dgvRowsR.Size = new System.Drawing.Size(889, 427);
            this.dgvRowsR.TabIndex = 5;
            this.dgvRowsR.MyKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRowsR_MyKeyDown);
            this.dgvRowsR.MyCheckForChanges += new System.EventHandler(this.dgvRowsR_MyCheckForChanges);
            this.dgvRowsR.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRowsR_CellDoubleClick);
            this.dgvRowsR.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRowsR_CellFormatting);
            this.dgvRowsR.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvRowsR_UserDeletingRow);
            this.dgvRowsR.Enter += new System.EventHandler(this.dgvRowsR_Enter);
            // 
            // dgcRIdItemsCat
            // 
            this.dgcRIdItemsCat.DataPropertyName = "IDITEMSCAT";
            this.dgcRIdItemsCat.DataSource = this.bsItemsCat;
            this.dgcRIdItemsCat.DisplayMember = "CODE";
            this.dgcRIdItemsCat.HeaderText = "artikulu kategorija";
            this.dgcRIdItemsCat.MinimumWidth = 8;
            this.dgcRIdItemsCat.Name = "dgcRIdItemsCat";
            this.dgcRIdItemsCat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcRIdItemsCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcRIdItemsCat.ValueMember = "ID";
            this.dgcRIdItemsCat.Width = 200;
            // 
            // bsItemsCat
            // 
            this.bsItemsCat.DataMember = "M_ITEMS_CAT";
            this.bsItemsCat.MyDataSource = "KlonsMData";
            this.bsItemsCat.Sort = "CODE";
            // 
            // dgcRIdcItem
            // 
            this.dgcRIdcItem.DataPropertyName = "IDITEM";
            this.dgcRIdcItem.DataSource = this.bsItems;
            this.dgcRIdcItem.DisplayMember = "BARCODE";
            this.dgcRIdcItem.HeaderText = "artikuls";
            this.dgcRIdcItem.MinimumWidth = 8;
            this.dgcRIdcItem.Name = "dgcRIdcItem";
            this.dgcRIdcItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcRIdcItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcRIdcItem.ValueMember = "ID";
            this.dgcRIdcItem.Width = 160;
            // 
            // bsItems
            // 
            this.bsItems.DataMember = "M_ITEMS";
            this.bsItems.MyDataSource = "KlonsMData";
            this.bsItems.Sort = "BARCODE";
            // 
            // dgcRItemName
            // 
            this.dgcRItemName.DataPropertyName = "IDITEM";
            this.dgcRItemName.HeaderText = "nosaukums";
            this.dgcRItemName.MinimumWidth = 8;
            this.dgcRItemName.Name = "dgcRItemName";
            this.dgcRItemName.ReadOnly = true;
            this.dgcRItemName.Width = 300;
            // 
            // dgcRDiscount
            // 
            this.dgcRDiscount.DataPropertyName = "DISCOUNT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgcRDiscount.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgcRDiscount.HeaderText = "atlaide";
            this.dgcRDiscount.MinimumWidth = 8;
            this.dgcRDiscount.Name = "dgcRDiscount";
            this.dgcRDiscount.Width = 95;
            // 
            // tcTabs
            // 
            this.tcTabs.Controls.Add(this.tabPage1);
            this.tcTabs.Controls.Add(this.tabPage2);
            this.tcTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcTabs.Location = new System.Drawing.Point(0, 38);
            this.tcTabs.Name = "tcTabs";
            this.tcTabs.SelectedIndex = 0;
            this.tcTabs.Size = new System.Drawing.Size(903, 466);
            this.tcTabs.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvRowsR);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Artikuli";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRowsP);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Partneri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRowsP
            // 
            this.dgvRowsP.AutoGenerateColumns = false;
            this.dgvRowsP.AutoSave = false;
            this.dgvRowsP.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRowsP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRowsP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgcPIdStoresCat,
            this.dgcPIdStore});
            this.dgvRowsP.DataSource = this.bsRowsP;
            this.dgvRowsP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRowsP.Location = new System.Drawing.Point(3, 3);
            this.dgvRowsP.Name = "dgvRowsP";
            this.dgvRowsP.RowHeadersWidth = 62;
            this.dgvRowsP.RowTemplate.Height = 28;
            this.dgvRowsP.ShowCellToolTips = false;
            this.dgvRowsP.Size = new System.Drawing.Size(889, 427);
            this.dgvRowsP.TabIndex = 0;
            this.dgvRowsP.MyKeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvRowsP_MyKeyDown);
            this.dgvRowsP.MyCheckForChanges += new System.EventHandler(this.dgvRowsP_MyCheckForChanges);
            this.dgvRowsP.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRowsP_CellDoubleClick);
            this.dgvRowsP.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvRowsP_UserDeletingRow);
            this.dgvRowsP.Enter += new System.EventHandler(this.dgvRowsP_Enter);
            // 
            // dgcPIdStoresCat
            // 
            this.dgcPIdStoresCat.DataPropertyName = "IDSTORESCAT";
            this.dgcPIdStoresCat.DataSource = this.bsStoresCat;
            this.dgcPIdStoresCat.DisplayMember = "CODE";
            this.dgcPIdStoresCat.HeaderText = "partneru kategorija";
            this.dgcPIdStoresCat.MinimumWidth = 8;
            this.dgcPIdStoresCat.Name = "dgcPIdStoresCat";
            this.dgcPIdStoresCat.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcPIdStoresCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcPIdStoresCat.ValueMember = "ID";
            this.dgcPIdStoresCat.Width = 200;
            // 
            // bsStoresCat
            // 
            this.bsStoresCat.DataMember = "M_STORES_CAT";
            this.bsStoresCat.MyDataSource = "KlonsMData";
            this.bsStoresCat.Sort = "CODE";
            // 
            // dgcPIdStore
            // 
            this.dgcPIdStore.DataPropertyName = "IDSTORE";
            this.dgcPIdStore.DataSource = this.bsStores;
            this.dgcPIdStore.DisplayMember = "CODE";
            this.dgcPIdStore.HeaderText = "partneris";
            this.dgcPIdStore.MinimumWidth = 8;
            this.dgcPIdStore.Name = "dgcPIdStore";
            this.dgcPIdStore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgcPIdStore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgcPIdStore.ValueMember = "ID";
            this.dgcPIdStore.Width = 200;
            // 
            // bsStores
            // 
            this.bsStores.DataMember = "M_STORES";
            this.bsStores.MyDataSource = "KlonsMData";
            this.bsStores.Sort = "CODE";
            // 
            // bsRowsP
            // 
            this.bsRowsP.DataMember = "FK_M_DISC_LISTS_P_IDL";
            this.bsRowsP.DataSource = this.bsLists;
            this.bsRowsP.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.bsRowsP_ListChanged);
            // 
            // myAdapterManager1
            // 
            this.myAdapterManager1.MyDataSource = "KlonsMData";
            this.myAdapterManager1.TableNames = new string[] {
        "M_DISC_LISTS",
        "M_DISC_LISTS_P",
        "M_DISC_LISTS_R",
        null};
            // 
            // FormM_DiscountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 543);
            this.Controls.Add(this.tcTabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bNav);
            this.Name = "FormM_DiscountList";
            this.Text = "Atlaižu lapa";
            this.Load += new System.EventHandler(this.FormM_DiscountList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsLists)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bNav)).EndInit();
            this.bNav.ResumeLayout(false);
            this.bNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRowsR)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowsR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItemsCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            this.tcTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRowsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStoresCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsStores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRowsP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myAdapterManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private KlonsLIB.Data.MyBindingSource bsLists;
        private KlonsLIB.Components.MyBindingNavigator bNav;
        private System.Windows.Forms.ToolStripButton bniNew;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bniDelete;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bniSave;
        private System.Windows.Forms.ToolStripButton tsbFindPrev;
        private System.Windows.Forms.ToolStripTextBox tsbFind;
        private System.Windows.Forms.ToolStripButton tsbFindNext;
        private KlonsLIB.Data.MyBindingSource2 bsRowsR;
        private System.Windows.Forms.Panel panel1;
        private KlonsLIB.Components.MyDataGridView dgvRowsR;
        private System.Windows.Forms.Label label1;
        private KlonsLIB.Components.MyPickRowTextBox2 tbLists;
        private KlonsLIB.Components.TabControlWithoutHeader tcTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private KlonsLIB.Data.MyBindingSource2 bsRowsP;
        private KlonsLIB.Components.MyDataGridView dgvRowsP;
        private KlonsLIB.Data.MyBindingSource bsItems;
        private KlonsLIB.Data.MyBindingSource bsItemsCat;
        private KlonsLIB.Data.MyBindingSource bsStores;
        private KlonsLIB.Data.MyBindingSource bsStoresCat;
        private KlonsLIB.Data.MyAdapterManager myAdapterManager1;
        private System.Windows.Forms.ToolStripLabel tslActiveTable;
        private KlonsLIB.Components.MyButton btTab2;
        private KlonsLIB.Components.MyButton btTab1;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcRIdItemsCat;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcRIdcItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgcRDiscount;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcPIdStoresCat;
        private KlonsLIB.Components.MyDgvTextboxColumn2 dgcPIdStore;
    }
}