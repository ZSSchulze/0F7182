namespace _0F7182
{
    partial class mainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabConfiguration = new System.Windows.Forms.TabPage();
            this.buttonSaveConfigs = new System.Windows.Forms.Button();
            this.groupOutputSettings = new System.Windows.Forms.GroupBox();
            this.cbDisplayBad = new System.Windows.Forms.CheckBox();
            this.groupCustomItems = new System.Windows.Forms.GroupBox();
            this.buttonRemoveItem = new System.Windows.Forms.Button();
            this.buttonAddItem = new System.Windows.Forms.Button();
            this.tbItemID = new System.Windows.Forms.TextBox();
            this.listCustomItems = new System.Windows.Forms.ListBox();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.tabLogging = new System.Windows.Forms.TabPage();
            this.splitContainerLogging = new System.Windows.Forms.SplitContainer();
            this.rtbConsoleLog = new System.Windows.Forms.RichTextBox();
            this.rtbDebugLog = new System.Windows.Forms.RichTextBox();
            this.tabActions = new System.Windows.Forms.TabPage();
            this.dgvADetails = new System.Windows.Forms.DataGridView();
            this.cCustomItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCAccounts = new System.Windows.Forms.DataGridView();
            this.cUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupAccountDetails = new System.Windows.Forms.GroupBox();
            this.labelCI = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.labelCustomItems = new System.Windows.Forms.Label();
            this.labelBankItems = new System.Windows.Forms.Label();
            this.labelMoneyPouch = new System.Windows.Forms.Label();
            this.labelRuneScapeIGN = new System.Windows.Forms.Label();
            this.labelBI = new System.Windows.Forms.Label();
            this.labelMP = new System.Windows.Forms.Label();
            this.labelIGN = new System.Windows.Forms.Label();
            this.labelUN = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelTV = new System.Windows.Forms.Label();
            this.buttonGenOverview = new System.Windows.Forms.Button();
            this.buttonImportResults = new System.Windows.Forms.Button();
            this.buttonExportResults = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.tabQuickView = new System.Windows.Forms.TabPage();
            this.buttonClearOverview = new System.Windows.Forms.Button();
            this.buttonImportCSV = new System.Windows.Forms.Button();
            this.buttonExportOverview = new System.Windows.Forms.Button();
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.cUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cBI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPrefsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabConfiguration.SuspendLayout();
            this.groupOutputSettings.SuspendLayout();
            this.groupCustomItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.tabLogging.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogging)).BeginInit();
            this.splitContainerLogging.Panel1.SuspendLayout();
            this.splitContainerLogging.Panel2.SuspendLayout();
            this.splitContainerLogging.SuspendLayout();
            this.tabActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvADetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAccounts)).BeginInit();
            this.groupAccountDetails.SuspendLayout();
            this.tabQuickView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.menuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabConfiguration);
            this.tabControl1.Controls.Add(this.tabLogging);
            this.tabControl1.Controls.Add(this.tabActions);
            this.tabControl1.Controls.Add(this.tabQuickView);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 476);
            this.tabControl1.TabIndex = 0;
            // 
            // tabConfiguration
            // 
            this.tabConfiguration.Controls.Add(this.buttonSaveConfigs);
            this.tabConfiguration.Controls.Add(this.groupOutputSettings);
            this.tabConfiguration.Controls.Add(this.groupCustomItems);
            this.tabConfiguration.Controls.Add(this.dgvAccounts);
            this.tabConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabConfiguration.Name = "tabConfiguration";
            this.tabConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfiguration.Size = new System.Drawing.Size(839, 450);
            this.tabConfiguration.TabIndex = 0;
            this.tabConfiguration.Text = "Configuration";
            this.tabConfiguration.UseVisualStyleBackColor = true;
            // 
            // buttonSaveConfigs
            // 
            this.buttonSaveConfigs.Location = new System.Drawing.Point(752, 421);
            this.buttonSaveConfigs.Name = "buttonSaveConfigs";
            this.buttonSaveConfigs.Size = new System.Drawing.Size(81, 23);
            this.buttonSaveConfigs.TabIndex = 4;
            this.buttonSaveConfigs.Text = "Save Configurations";
            this.buttonSaveConfigs.UseVisualStyleBackColor = true;
            this.buttonSaveConfigs.Click += new System.EventHandler(this.buttonSaveConfigs_Click);
            // 
            // groupOutputSettings
            // 
            this.groupOutputSettings.Controls.Add(this.cbDisplayBad);
            this.groupOutputSettings.Location = new System.Drawing.Point(452, 7);
            this.groupOutputSettings.Name = "groupOutputSettings";
            this.groupOutputSettings.Size = new System.Drawing.Size(384, 100);
            this.groupOutputSettings.TabIndex = 2;
            this.groupOutputSettings.TabStop = false;
            this.groupOutputSettings.Text = "Output Settings";
            // 
            // cbDisplayBad
            // 
            this.cbDisplayBad.AutoSize = true;
            this.cbDisplayBad.Location = new System.Drawing.Point(7, 15);
            this.cbDisplayBad.Name = "cbDisplayBad";
            this.cbDisplayBad.Size = new System.Drawing.Size(130, 17);
            this.cbDisplayBad.TabIndex = 0;
            this.cbDisplayBad.Text = "Display Bad Accounts";
            this.cbDisplayBad.UseVisualStyleBackColor = true;
            // 
            // groupCustomItems
            // 
            this.groupCustomItems.Controls.Add(this.buttonRemoveItem);
            this.groupCustomItems.Controls.Add(this.buttonAddItem);
            this.groupCustomItems.Controls.Add(this.tbItemID);
            this.groupCustomItems.Controls.Add(this.listCustomItems);
            this.groupCustomItems.Location = new System.Drawing.Point(223, 6);
            this.groupCustomItems.Name = "groupCustomItems";
            this.groupCustomItems.Size = new System.Drawing.Size(222, 438);
            this.groupCustomItems.TabIndex = 1;
            this.groupCustomItems.TabStop = false;
            this.groupCustomItems.Text = "Custom Items";
            // 
            // buttonRemoveItem
            // 
            this.buttonRemoveItem.Location = new System.Drawing.Point(134, 70);
            this.buttonRemoveItem.Name = "buttonRemoveItem";
            this.buttonRemoveItem.Size = new System.Drawing.Size(81, 23);
            this.buttonRemoveItem.TabIndex = 3;
            this.buttonRemoveItem.Text = "Remove Item";
            this.buttonRemoveItem.UseVisualStyleBackColor = true;
            this.buttonRemoveItem.Click += new System.EventHandler(this.buttonRemoveItem_Click);
            // 
            // buttonAddItem
            // 
            this.buttonAddItem.Location = new System.Drawing.Point(135, 41);
            this.buttonAddItem.Name = "buttonAddItem";
            this.buttonAddItem.Size = new System.Drawing.Size(81, 23);
            this.buttonAddItem.TabIndex = 2;
            this.buttonAddItem.Text = "Add Item";
            this.buttonAddItem.UseVisualStyleBackColor = true;
            this.buttonAddItem.Click += new System.EventHandler(this.buttonAddItem_Click);
            // 
            // tbItemID
            // 
            this.tbItemID.Location = new System.Drawing.Point(135, 14);
            this.tbItemID.Name = "tbItemID";
            this.tbItemID.Size = new System.Drawing.Size(81, 20);
            this.tbItemID.TabIndex = 1;
            // 
            // listCustomItems
            // 
            this.listCustomItems.FormattingEnabled = true;
            this.listCustomItems.Location = new System.Drawing.Point(6, 12);
            this.listCustomItems.Name = "listCustomItems";
            this.listCustomItems.Size = new System.Drawing.Size(122, 420);
            this.listCustomItems.TabIndex = 0;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToResizeRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(6, 6);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersVisible = false;
            this.dgvAccounts.RowTemplate.Height = 18;
            this.dgvAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccounts.Size = new System.Drawing.Size(211, 438);
            this.dgvAccounts.TabIndex = 0;
            // 
            // tabLogging
            // 
            this.tabLogging.Controls.Add(this.splitContainerLogging);
            this.tabLogging.Location = new System.Drawing.Point(4, 22);
            this.tabLogging.Name = "tabLogging";
            this.tabLogging.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogging.Size = new System.Drawing.Size(839, 450);
            this.tabLogging.TabIndex = 1;
            this.tabLogging.Text = "Logging";
            this.tabLogging.UseVisualStyleBackColor = true;
            // 
            // splitContainerLogging
            // 
            this.splitContainerLogging.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLogging.Location = new System.Drawing.Point(3, 3);
            this.splitContainerLogging.Name = "splitContainerLogging";
            this.splitContainerLogging.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerLogging.Panel1
            // 
            this.splitContainerLogging.Panel1.Controls.Add(this.rtbConsoleLog);
            // 
            // splitContainerLogging.Panel2
            // 
            this.splitContainerLogging.Panel2.Controls.Add(this.rtbDebugLog);
            this.splitContainerLogging.Size = new System.Drawing.Size(833, 444);
            this.splitContainerLogging.SplitterDistance = 211;
            this.splitContainerLogging.TabIndex = 0;
            // 
            // rtbConsoleLog
            // 
            this.rtbConsoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbConsoleLog.Location = new System.Drawing.Point(0, 0);
            this.rtbConsoleLog.Name = "rtbConsoleLog";
            this.rtbConsoleLog.ReadOnly = true;
            this.rtbConsoleLog.Size = new System.Drawing.Size(833, 211);
            this.rtbConsoleLog.TabIndex = 0;
            this.rtbConsoleLog.Text = "";
            // 
            // rtbDebugLog
            // 
            this.rtbDebugLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDebugLog.Location = new System.Drawing.Point(0, 0);
            this.rtbDebugLog.Name = "rtbDebugLog";
            this.rtbDebugLog.ReadOnly = true;
            this.rtbDebugLog.Size = new System.Drawing.Size(833, 229);
            this.rtbDebugLog.TabIndex = 1;
            this.rtbDebugLog.Text = "";
            // 
            // tabActions
            // 
            this.tabActions.Controls.Add(this.dgvADetails);
            this.tabActions.Controls.Add(this.dgvCAccounts);
            this.tabActions.Controls.Add(this.groupAccountDetails);
            this.tabActions.Controls.Add(this.buttonGenOverview);
            this.tabActions.Controls.Add(this.buttonImportResults);
            this.tabActions.Controls.Add(this.buttonExportResults);
            this.tabActions.Controls.Add(this.buttonExecute);
            this.tabActions.Location = new System.Drawing.Point(4, 22);
            this.tabActions.Name = "tabActions";
            this.tabActions.Size = new System.Drawing.Size(839, 450);
            this.tabActions.TabIndex = 2;
            this.tabActions.Text = "Actions & Details";
            this.tabActions.UseVisualStyleBackColor = true;
            // 
            // dgvADetails
            // 
            this.dgvADetails.AllowUserToAddRows = false;
            this.dgvADetails.AllowUserToResizeRows = false;
            this.dgvADetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvADetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCustomItem,
            this.cItemID,
            this.cItemName,
            this.cItemPrice,
            this.cQuantity,
            this.cValue});
            this.dgvADetails.Location = new System.Drawing.Point(135, 120);
            this.dgvADetails.Name = "dgvADetails";
            this.dgvADetails.ReadOnly = true;
            this.dgvADetails.RowHeadersVisible = false;
            this.dgvADetails.RowTemplate.Height = 18;
            this.dgvADetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvADetails.Size = new System.Drawing.Size(701, 327);
            this.dgvADetails.TabIndex = 7;
            // 
            // cCustomItem
            // 
            this.cCustomItem.FillWeight = 41.4833F;
            this.cCustomItem.HeaderText = "Custom Item";
            this.cCustomItem.Name = "cCustomItem";
            this.cCustomItem.ReadOnly = true;
            this.cCustomItem.Width = 95;
            // 
            // cItemID
            // 
            this.cItemID.FillWeight = 57.08102F;
            this.cItemID.HeaderText = "Item ID";
            this.cItemID.Name = "cItemID";
            this.cItemID.ReadOnly = true;
            this.cItemID.Width = 121;
            // 
            // cItemName
            // 
            this.cItemName.FillWeight = 57.08102F;
            this.cItemName.HeaderText = "Item Name";
            this.cItemName.Name = "cItemName";
            this.cItemName.ReadOnly = true;
            this.cItemName.Width = 122;
            // 
            // cItemPrice
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            this.cItemPrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.cItemPrice.FillWeight = 57.08102F;
            this.cItemPrice.HeaderText = "Item Price";
            this.cItemPrice.Name = "cItemPrice";
            this.cItemPrice.ReadOnly = true;
            this.cItemPrice.Width = 122;
            // 
            // cQuantity
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.cQuantity.DefaultCellStyle = dataGridViewCellStyle2;
            this.cQuantity.FillWeight = 57.08102F;
            this.cQuantity.HeaderText = "Quantity";
            this.cQuantity.Name = "cQuantity";
            this.cQuantity.ReadOnly = true;
            this.cQuantity.Width = 122;
            // 
            // cValue
            // 
            this.cValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.cValue.DefaultCellStyle = dataGridViewCellStyle3;
            this.cValue.FillWeight = 57.08102F;
            this.cValue.HeaderText = "Value";
            this.cValue.Name = "cValue";
            this.cValue.ReadOnly = true;
            // 
            // dgvCAccounts
            // 
            this.dgvCAccounts.AllowUserToAddRows = false;
            this.dgvCAccounts.AllowUserToResizeRows = false;
            this.dgvCAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCAccounts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUsername});
            this.dgvCAccounts.Location = new System.Drawing.Point(4, 120);
            this.dgvCAccounts.Name = "dgvCAccounts";
            this.dgvCAccounts.ReadOnly = true;
            this.dgvCAccounts.RowHeadersVisible = false;
            this.dgvCAccounts.RowTemplate.Height = 18;
            this.dgvCAccounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCAccounts.Size = new System.Drawing.Size(125, 327);
            this.dgvCAccounts.TabIndex = 6;
            this.dgvCAccounts.SelectionChanged += new System.EventHandler(this.dgvCAccounts_SelectionChanged);
            // 
            // cUsername
            // 
            this.cUsername.HeaderText = "Username";
            this.cUsername.Name = "cUsername";
            this.cUsername.ReadOnly = true;
            // 
            // groupAccountDetails
            // 
            this.groupAccountDetails.Controls.Add(this.labelCI);
            this.groupAccountDetails.Controls.Add(this.labelTotalValue);
            this.groupAccountDetails.Controls.Add(this.labelCustomItems);
            this.groupAccountDetails.Controls.Add(this.labelBankItems);
            this.groupAccountDetails.Controls.Add(this.labelMoneyPouch);
            this.groupAccountDetails.Controls.Add(this.labelRuneScapeIGN);
            this.groupAccountDetails.Controls.Add(this.labelBI);
            this.groupAccountDetails.Controls.Add(this.labelMP);
            this.groupAccountDetails.Controls.Add(this.labelIGN);
            this.groupAccountDetails.Controls.Add(this.labelUN);
            this.groupAccountDetails.Controls.Add(this.labelUsername);
            this.groupAccountDetails.Controls.Add(this.labelTV);
            this.groupAccountDetails.Location = new System.Drawing.Point(135, 4);
            this.groupAccountDetails.Name = "groupAccountDetails";
            this.groupAccountDetails.Size = new System.Drawing.Size(701, 110);
            this.groupAccountDetails.TabIndex = 4;
            this.groupAccountDetails.TabStop = false;
            this.groupAccountDetails.Text = "Account Details";
            // 
            // labelCI
            // 
            this.labelCI.AutoSize = true;
            this.labelCI.Location = new System.Drawing.Point(100, 73);
            this.labelCI.Name = "labelCI";
            this.labelCI.Size = new System.Drawing.Size(0, 13);
            this.labelCI.TabIndex = 11;
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.AutoSize = true;
            this.labelTotalValue.Location = new System.Drawing.Point(335, 47);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(64, 13);
            this.labelTotalValue.TabIndex = 10;
            this.labelTotalValue.Text = "Total Value:";
            // 
            // labelCustomItems
            // 
            this.labelCustomItems.AutoSize = true;
            this.labelCustomItems.Location = new System.Drawing.Point(7, 73);
            this.labelCustomItems.Name = "labelCustomItems";
            this.labelCustomItems.Size = new System.Drawing.Size(73, 13);
            this.labelCustomItems.TabIndex = 9;
            this.labelCustomItems.Text = "Custom Items:";
            // 
            // labelBankItems
            // 
            this.labelBankItems.AutoSize = true;
            this.labelBankItems.Location = new System.Drawing.Point(7, 60);
            this.labelBankItems.Name = "labelBankItems";
            this.labelBankItems.Size = new System.Drawing.Size(73, 13);
            this.labelBankItems.TabIndex = 8;
            this.labelBankItems.Text = "Bank Items #:";
            // 
            // labelMoneyPouch
            // 
            this.labelMoneyPouch.AutoSize = true;
            this.labelMoneyPouch.Location = new System.Drawing.Point(7, 47);
            this.labelMoneyPouch.Name = "labelMoneyPouch";
            this.labelMoneyPouch.Size = new System.Drawing.Size(76, 13);
            this.labelMoneyPouch.TabIndex = 7;
            this.labelMoneyPouch.Text = "Money Pouch:";
            // 
            // labelRuneScapeIGN
            // 
            this.labelRuneScapeIGN.AutoSize = true;
            this.labelRuneScapeIGN.Location = new System.Drawing.Point(7, 34);
            this.labelRuneScapeIGN.Name = "labelRuneScapeIGN";
            this.labelRuneScapeIGN.Size = new System.Drawing.Size(89, 13);
            this.labelRuneScapeIGN.TabIndex = 6;
            this.labelRuneScapeIGN.Text = "RuneScape IGN:";
            // 
            // labelBI
            // 
            this.labelBI.AutoSize = true;
            this.labelBI.Location = new System.Drawing.Point(100, 60);
            this.labelBI.Name = "labelBI";
            this.labelBI.Size = new System.Drawing.Size(0, 13);
            this.labelBI.TabIndex = 5;
            // 
            // labelMP
            // 
            this.labelMP.AutoSize = true;
            this.labelMP.Location = new System.Drawing.Point(100, 47);
            this.labelMP.Name = "labelMP";
            this.labelMP.Size = new System.Drawing.Size(0, 13);
            this.labelMP.TabIndex = 4;
            // 
            // labelIGN
            // 
            this.labelIGN.AutoSize = true;
            this.labelIGN.Location = new System.Drawing.Point(100, 34);
            this.labelIGN.Name = "labelIGN";
            this.labelIGN.Size = new System.Drawing.Size(0, 13);
            this.labelIGN.TabIndex = 3;
            // 
            // labelUN
            // 
            this.labelUN.AutoSize = true;
            this.labelUN.Location = new System.Drawing.Point(100, 20);
            this.labelUN.Name = "labelUN";
            this.labelUN.Size = new System.Drawing.Size(0, 13);
            this.labelUN.TabIndex = 2;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(7, 20);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(58, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // labelTV
            // 
            this.labelTV.AutoSize = true;
            this.labelTV.Location = new System.Drawing.Point(405, 47);
            this.labelTV.Name = "labelTV";
            this.labelTV.Size = new System.Drawing.Size(0, 13);
            this.labelTV.TabIndex = 0;
            // 
            // buttonGenOverview
            // 
            this.buttonGenOverview.Location = new System.Drawing.Point(4, 91);
            this.buttonGenOverview.Name = "buttonGenOverview";
            this.buttonGenOverview.Size = new System.Drawing.Size(125, 23);
            this.buttonGenOverview.TabIndex = 3;
            this.buttonGenOverview.Text = "Gen. Overview";
            this.buttonGenOverview.UseVisualStyleBackColor = true;
            this.buttonGenOverview.Click += new System.EventHandler(this.buttonGenOverview_Click);
            // 
            // buttonImportResults
            // 
            this.buttonImportResults.Location = new System.Drawing.Point(4, 62);
            this.buttonImportResults.Name = "buttonImportResults";
            this.buttonImportResults.Size = new System.Drawing.Size(125, 23);
            this.buttonImportResults.TabIndex = 2;
            this.buttonImportResults.Text = "Import Results";
            this.buttonImportResults.UseVisualStyleBackColor = true;
            this.buttonImportResults.Click += new System.EventHandler(this.buttonImportResults_Click);
            // 
            // buttonExportResults
            // 
            this.buttonExportResults.Enabled = false;
            this.buttonExportResults.Location = new System.Drawing.Point(3, 33);
            this.buttonExportResults.Name = "buttonExportResults";
            this.buttonExportResults.Size = new System.Drawing.Size(126, 23);
            this.buttonExportResults.TabIndex = 1;
            this.buttonExportResults.Text = "Export Results";
            this.buttonExportResults.UseVisualStyleBackColor = true;
            this.buttonExportResults.Click += new System.EventHandler(this.buttonExportResults_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(4, 4);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(125, 23);
            this.buttonExecute.TabIndex = 0;
            this.buttonExecute.Text = "Execute Checks";
            this.buttonExecute.UseVisualStyleBackColor = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // tabQuickView
            // 
            this.tabQuickView.Controls.Add(this.buttonClearOverview);
            this.tabQuickView.Controls.Add(this.buttonImportCSV);
            this.tabQuickView.Controls.Add(this.buttonExportOverview);
            this.tabQuickView.Controls.Add(this.dgvOverview);
            this.tabQuickView.Location = new System.Drawing.Point(4, 22);
            this.tabQuickView.Name = "tabQuickView";
            this.tabQuickView.Size = new System.Drawing.Size(839, 450);
            this.tabQuickView.TabIndex = 3;
            this.tabQuickView.Text = "QuickView";
            this.tabQuickView.UseVisualStyleBackColor = true;
            // 
            // buttonClearOverview
            // 
            this.buttonClearOverview.Location = new System.Drawing.Point(711, 424);
            this.buttonClearOverview.Name = "buttonClearOverview";
            this.buttonClearOverview.Size = new System.Drawing.Size(125, 23);
            this.buttonClearOverview.TabIndex = 11;
            this.buttonClearOverview.Text = "Clear";
            this.buttonClearOverview.UseVisualStyleBackColor = true;
            this.buttonClearOverview.Click += new System.EventHandler(this.buttonClearOverview_Click);
            // 
            // buttonImportCSV
            // 
            this.buttonImportCSV.Location = new System.Drawing.Point(3, 424);
            this.buttonImportCSV.Name = "buttonImportCSV";
            this.buttonImportCSV.Size = new System.Drawing.Size(125, 23);
            this.buttonImportCSV.TabIndex = 10;
            this.buttonImportCSV.Text = "Import CSV";
            this.buttonImportCSV.UseVisualStyleBackColor = true;
            // 
            // buttonExportOverview
            // 
            this.buttonExportOverview.Location = new System.Drawing.Point(134, 424);
            this.buttonExportOverview.Name = "buttonExportOverview";
            this.buttonExportOverview.Size = new System.Drawing.Size(125, 23);
            this.buttonExportOverview.TabIndex = 9;
            this.buttonExportOverview.Text = "Export to CSV";
            this.buttonExportOverview.UseVisualStyleBackColor = true;
            this.buttonExportOverview.Click += new System.EventHandler(this.buttonExportOverview_Click);
            // 
            // dgvOverview
            // 
            this.dgvOverview.AllowUserToAddRows = false;
            this.dgvOverview.AllowUserToResizeRows = false;
            this.dgvOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cUN,
            this.cPS,
            this.cIGN,
            this.cMP,
            this.cBI,
            this.cTV});
            this.dgvOverview.Location = new System.Drawing.Point(3, 3);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.ReadOnly = true;
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.RowTemplate.Height = 18;
            this.dgvOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOverview.Size = new System.Drawing.Size(833, 417);
            this.dgvOverview.TabIndex = 8;
            // 
            // cUN
            // 
            this.cUN.HeaderText = "Username";
            this.cUN.Name = "cUN";
            this.cUN.ReadOnly = true;
            // 
            // cPS
            // 
            this.cPS.HeaderText = "Password";
            this.cPS.Name = "cPS";
            this.cPS.ReadOnly = true;
            // 
            // cIGN
            // 
            this.cIGN.HeaderText = "RuneScape IGN";
            this.cIGN.Name = "cIGN";
            this.cIGN.ReadOnly = true;
            // 
            // cMP
            // 
            dataGridViewCellStyle4.Format = "N0";
            this.cMP.DefaultCellStyle = dataGridViewCellStyle4;
            this.cMP.HeaderText = "Money Pouch";
            this.cMP.Name = "cMP";
            this.cMP.ReadOnly = true;
            // 
            // cBI
            // 
            dataGridViewCellStyle5.Format = "N0";
            this.cBI.DefaultCellStyle = dataGridViewCellStyle5;
            this.cBI.HeaderText = "Bank Items #";
            this.cBI.Name = "cBI";
            this.cBI.ReadOnly = true;
            // 
            // cTV
            // 
            dataGridViewCellStyle6.Format = "N0";
            this.cTV.DefaultCellStyle = dataGridViewCellStyle6;
            this.cTV.HeaderText = "Total Value";
            this.cTV.Name = "cTV";
            this.cTV.ReadOnly = true;
            // 
            // menuTop
            // 
            this.menuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuTop.Location = new System.Drawing.Point(0, 0);
            this.menuTop.Name = "menuTop";
            this.menuTop.Size = new System.Drawing.Size(871, 24);
            this.menuTop.TabIndex = 1;
            this.menuTop.Text = "menuTop";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importAccountsToolStripMenuItem,
            this.setPrefsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importAccountsToolStripMenuItem
            // 
            this.importAccountsToolStripMenuItem.Name = "importAccountsToolStripMenuItem";
            this.importAccountsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.importAccountsToolStripMenuItem.Text = "Import Accounts";
            this.importAccountsToolStripMenuItem.Click += new System.EventHandler(this.importAccountsToolStripMenuItem_Click);
            // 
            // setPrefsToolStripMenuItem
            // 
            this.setPrefsToolStripMenuItem.Name = "setPrefsToolStripMenuItem";
            this.setPrefsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.setPrefsToolStripMenuItem.Text = "Set Prefs";
            this.setPrefsToolStripMenuItem.Click += new System.EventHandler(this.setPrefsToolStripMenuItem_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 508);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(846, 5);
            this.progressBar.TabIndex = 2;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 519);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuTop;
            this.MaximumSize = new System.Drawing.Size(887, 558);
            this.Name = "mainForm";
            this.Text = "#0F7182";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabConfiguration.ResumeLayout(false);
            this.groupOutputSettings.ResumeLayout(false);
            this.groupOutputSettings.PerformLayout();
            this.groupCustomItems.ResumeLayout(false);
            this.groupCustomItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.tabLogging.ResumeLayout(false);
            this.splitContainerLogging.Panel1.ResumeLayout(false);
            this.splitContainerLogging.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLogging)).EndInit();
            this.splitContainerLogging.ResumeLayout(false);
            this.tabActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvADetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCAccounts)).EndInit();
            this.groupAccountDetails.ResumeLayout(false);
            this.groupAccountDetails.PerformLayout();
            this.tabQuickView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.menuTop.ResumeLayout(false);
            this.menuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabConfiguration;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.TabPage tabLogging;
        private System.Windows.Forms.TabPage tabActions;
        private System.Windows.Forms.TabPage tabQuickView;
        private System.Windows.Forms.MenuStrip menuTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAccountsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupCustomItems;
        private System.Windows.Forms.Button buttonRemoveItem;
        private System.Windows.Forms.Button buttonAddItem;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.ListBox listCustomItems;
        private System.Windows.Forms.Button buttonSaveConfigs;
        private System.Windows.Forms.GroupBox groupOutputSettings;
        private System.Windows.Forms.CheckBox cbDisplayBad;
        private System.Windows.Forms.SplitContainer splitContainerLogging;
        private System.Windows.Forms.RichTextBox rtbConsoleLog;
        private System.Windows.Forms.RichTextBox rtbDebugLog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.Button buttonGenOverview;
        private System.Windows.Forms.Button buttonImportResults;
        private System.Windows.Forms.Button buttonExportResults;
        private System.Windows.Forms.DataGridView dgvADetails;
        private System.Windows.Forms.DataGridView dgvCAccounts;
        private System.Windows.Forms.GroupBox groupAccountDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUsername;
        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.Button buttonExportOverview;
        private System.Windows.Forms.Label labelTV;
        private System.Windows.Forms.Label labelBI;
        private System.Windows.Forms.Label labelMP;
        private System.Windows.Forms.Label labelIGN;
        private System.Windows.Forms.Label labelUN;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelCI;
        private System.Windows.Forms.Label labelTotalValue;
        private System.Windows.Forms.Label labelCustomItems;
        private System.Windows.Forms.Label labelBankItems;
        private System.Windows.Forms.Label labelMoneyPouch;
        private System.Windows.Forms.Label labelRuneScapeIGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPS;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMP;
        private System.Windows.Forms.DataGridViewTextBoxColumn cBI;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCustomItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValue;
        private System.Windows.Forms.ToolStripMenuItem setPrefsToolStripMenuItem;
        private System.Windows.Forms.Button buttonImportCSV;
        private System.Windows.Forms.Button buttonClearOverview;
    }
}

