namespace BotAutoTrading
{
    partial class BotAutoMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.grpSellSetting = new System.Windows.Forms.GroupBox();
            this.txtBudgetSell = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellPriceTo = new System.Windows.Forms.TextBox();
            this.txtSellPriceFrom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBuySetting = new System.Windows.Forms.GroupBox();
            this.txtBudgetBuy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuyPriceTo = new System.Windows.Forms.TextBox();
            this.txtBuyPriceFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAutoSell = new System.Windows.Forms.CheckBox();
            this.chkAutoBuy = new System.Windows.Forms.CheckBox();
            this.btnStarTrading = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalSellAsset = new System.Windows.Forms.Label();
            this.lblTotalSellBaseAsset = new System.Windows.Forms.Label();
            this.lblTotalBuyAsset = new System.Windows.Forms.Label();
            this.chkStopLoad = new System.Windows.Forms.CheckBox();
            this.lblTotalBuyBaseAsset = new System.Windows.Forms.Label();
            this.dgvSellOrder = new System.Windows.Forms.DataGridView();
            this.dgvBuyOrder = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblBookSymbol = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkEmpty = new System.Windows.Forms.CheckBox();
            this.dtgAccountBalance = new System.Windows.Forms.DataGridView();
            this.colSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grpBaseAsset = new System.Windows.Forms.GroupBox();
            this.rdBtc = new System.Windows.Forms.RadioButton();
            this.rdUsdt = new System.Windows.Forms.RadioButton();
            this.rdEth = new System.Windows.Forms.RadioButton();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.lblSymbolsss = new System.Windows.Forms.Label();
            this.dtgTradingList = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.grpSellSetting.SuspendLayout();
            this.grpBuySetting.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyOrder)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccountBalance)).BeginInit();
            this.panel3.SuspendLayout();
            this.grpBaseAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTradingList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClean);
            this.panel1.Controls.Add(this.txtLog);
            this.panel1.Controls.Add(this.grpSellSetting);
            this.panel1.Controls.Add(this.grpBuySetting);
            this.panel1.Controls.Add(this.chkAutoSell);
            this.panel1.Controls.Add(this.chkAutoBuy);
            this.panel1.Location = new System.Drawing.Point(12, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 301);
            this.panel1.TabIndex = 0;
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClean.Location = new System.Drawing.Point(10, 270);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(75, 23);
            this.btnClean.TabIndex = 7;
            this.btnClean.Text = "Clean";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLog.Location = new System.Drawing.Point(10, 123);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(490, 141);
            this.txtLog.TabIndex = 6;
            this.txtLog.Text = "";
            // 
            // grpSellSetting
            // 
            this.grpSellSetting.Controls.Add(this.txtBudgetSell);
            this.grpSellSetting.Controls.Add(this.label6);
            this.grpSellSetting.Controls.Add(this.txtSellPriceTo);
            this.grpSellSetting.Controls.Add(this.txtSellPriceFrom);
            this.grpSellSetting.Controls.Add(this.label3);
            this.grpSellSetting.Controls.Add(this.label4);
            this.grpSellSetting.Location = new System.Drawing.Point(258, 22);
            this.grpSellSetting.Name = "grpSellSetting";
            this.grpSellSetting.Size = new System.Drawing.Size(239, 95);
            this.grpSellSetting.TabIndex = 5;
            this.grpSellSetting.TabStop = false;
            this.grpSellSetting.Text = "Price config";
            // 
            // txtBudgetSell
            // 
            this.txtBudgetSell.Location = new System.Drawing.Point(110, 19);
            this.txtBudgetSell.Name = "txtBudgetSell";
            this.txtBudgetSell.Size = new System.Drawing.Size(113, 20);
            this.txtBudgetSell.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Budget";
            // 
            // txtSellPriceTo
            // 
            this.txtSellPriceTo.Location = new System.Drawing.Point(110, 70);
            this.txtSellPriceTo.Name = "txtSellPriceTo";
            this.txtSellPriceTo.Size = new System.Drawing.Size(113, 20);
            this.txtSellPriceTo.TabIndex = 3;
            // 
            // txtSellPriceFrom
            // 
            this.txtSellPriceFrom.Location = new System.Drawing.Point(110, 45);
            this.txtSellPriceFrom.Name = "txtSellPriceFrom";
            this.txtSellPriceFrom.Size = new System.Drawing.Size(113, 20);
            this.txtSellPriceFrom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price to";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Price from";
            // 
            // grpBuySetting
            // 
            this.grpBuySetting.Controls.Add(this.txtBudgetBuy);
            this.grpBuySetting.Controls.Add(this.label5);
            this.grpBuySetting.Controls.Add(this.txtBuyPriceTo);
            this.grpBuySetting.Controls.Add(this.txtBuyPriceFrom);
            this.grpBuySetting.Controls.Add(this.label2);
            this.grpBuySetting.Controls.Add(this.label1);
            this.grpBuySetting.Location = new System.Drawing.Point(8, 22);
            this.grpBuySetting.Name = "grpBuySetting";
            this.grpBuySetting.Size = new System.Drawing.Size(227, 95);
            this.grpBuySetting.TabIndex = 4;
            this.grpBuySetting.TabStop = false;
            this.grpBuySetting.Text = "Price config";
            // 
            // txtBudgetBuy
            // 
            this.txtBudgetBuy.Location = new System.Drawing.Point(91, 18);
            this.txtBudgetBuy.Name = "txtBudgetBuy";
            this.txtBudgetBuy.Size = new System.Drawing.Size(113, 20);
            this.txtBudgetBuy.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Budget";
            // 
            // txtBuyPriceTo
            // 
            this.txtBuyPriceTo.Location = new System.Drawing.Point(91, 70);
            this.txtBuyPriceTo.Name = "txtBuyPriceTo";
            this.txtBuyPriceTo.Size = new System.Drawing.Size(113, 20);
            this.txtBuyPriceTo.TabIndex = 3;
            // 
            // txtBuyPriceFrom
            // 
            this.txtBuyPriceFrom.Location = new System.Drawing.Point(91, 44);
            this.txtBuyPriceFrom.Name = "txtBuyPriceFrom";
            this.txtBuyPriceFrom.Size = new System.Drawing.Size(113, 20);
            this.txtBuyPriceFrom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price to";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price from";
            // 
            // chkAutoSell
            // 
            this.chkAutoSell.AutoSize = true;
            this.chkAutoSell.Location = new System.Drawing.Point(258, 3);
            this.chkAutoSell.Name = "chkAutoSell";
            this.chkAutoSell.Size = new System.Drawing.Size(77, 17);
            this.chkAutoSell.TabIndex = 3;
            this.chkAutoSell.Text = "Auto SELL";
            this.chkAutoSell.UseVisualStyleBackColor = true;
            this.chkAutoSell.CheckedChanged += new System.EventHandler(this.chkAutoSell_CheckedChanged);
            // 
            // chkAutoBuy
            // 
            this.chkAutoBuy.AutoSize = true;
            this.chkAutoBuy.Location = new System.Drawing.Point(10, 3);
            this.chkAutoBuy.Name = "chkAutoBuy";
            this.chkAutoBuy.Size = new System.Drawing.Size(73, 17);
            this.chkAutoBuy.TabIndex = 2;
            this.chkAutoBuy.Text = "Auto BUY";
            this.chkAutoBuy.UseVisualStyleBackColor = true;
            this.chkAutoBuy.CheckedChanged += new System.EventHandler(this.chkAutoBuy_CheckedChanged);
            // 
            // btnStarTrading
            // 
            this.btnStarTrading.Location = new System.Drawing.Point(10, 7);
            this.btnStarTrading.Name = "btnStarTrading";
            this.btnStarTrading.Size = new System.Drawing.Size(75, 23);
            this.btnStarTrading.TabIndex = 0;
            this.btnStarTrading.Text = "Start trading";
            this.btnStarTrading.UseVisualStyleBackColor = true;
            this.btnStarTrading.Click += new System.EventHandler(this.btnStarTrading_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotalSellAsset);
            this.panel2.Controls.Add(this.lblTotalSellBaseAsset);
            this.panel2.Controls.Add(this.lblTotalBuyAsset);
            this.panel2.Controls.Add(this.chkStopLoad);
            this.panel2.Controls.Add(this.lblTotalBuyBaseAsset);
            this.panel2.Controls.Add(this.dgvSellOrder);
            this.panel2.Controls.Add(this.dgvBuyOrder);
            this.panel2.Location = new System.Drawing.Point(525, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(559, 519);
            this.panel2.TabIndex = 2;
            // 
            // lblTotalSellAsset
            // 
            this.lblTotalSellAsset.AutoSize = true;
            this.lblTotalSellAsset.Location = new System.Drawing.Point(285, 493);
            this.lblTotalSellAsset.Name = "lblTotalSellAsset";
            this.lblTotalSellAsset.Size = new System.Drawing.Size(49, 13);
            this.lblTotalSellAsset.TabIndex = 13;
            this.lblTotalSellAsset.Text = "Quantity:";
            // 
            // lblTotalSellBaseAsset
            // 
            this.lblTotalSellBaseAsset.AutoSize = true;
            this.lblTotalSellBaseAsset.Location = new System.Drawing.Point(285, 469);
            this.lblTotalSellBaseAsset.Name = "lblTotalSellBaseAsset";
            this.lblTotalSellBaseAsset.Size = new System.Drawing.Size(46, 13);
            this.lblTotalSellBaseAsset.TabIndex = 12;
            this.lblTotalSellBaseAsset.Text = "Total(0):";
            // 
            // lblTotalBuyAsset
            // 
            this.lblTotalBuyAsset.AutoSize = true;
            this.lblTotalBuyAsset.Location = new System.Drawing.Point(3, 493);
            this.lblTotalBuyAsset.Name = "lblTotalBuyAsset";
            this.lblTotalBuyAsset.Size = new System.Drawing.Size(49, 13);
            this.lblTotalBuyAsset.TabIndex = 11;
            this.lblTotalBuyAsset.Text = "Quantity:";
            // 
            // chkStopLoad
            // 
            this.chkStopLoad.AutoSize = true;
            this.chkStopLoad.Location = new System.Drawing.Point(3, 444);
            this.chkStopLoad.Name = "chkStopLoad";
            this.chkStopLoad.Size = new System.Drawing.Size(95, 17);
            this.chkStopLoad.TabIndex = 10;
            this.chkStopLoad.Text = "Stop load data";
            this.chkStopLoad.UseVisualStyleBackColor = true;
            // 
            // lblTotalBuyBaseAsset
            // 
            this.lblTotalBuyBaseAsset.AutoSize = true;
            this.lblTotalBuyBaseAsset.Location = new System.Drawing.Point(3, 469);
            this.lblTotalBuyBaseAsset.Name = "lblTotalBuyBaseAsset";
            this.lblTotalBuyBaseAsset.Size = new System.Drawing.Size(46, 13);
            this.lblTotalBuyBaseAsset.TabIndex = 9;
            this.lblTotalBuyBaseAsset.Text = "Total(0):";
            // 
            // dgvSellOrder
            // 
            this.dgvSellOrder.AllowUserToAddRows = false;
            this.dgvSellOrder.AllowUserToDeleteRows = false;
            this.dgvSellOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSellOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSellOrder.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSellOrder.Location = new System.Drawing.Point(288, 3);
            this.dgvSellOrder.Name = "dgvSellOrder";
            this.dgvSellOrder.ReadOnly = true;
            this.dgvSellOrder.Size = new System.Drawing.Size(264, 435);
            this.dgvSellOrder.TabIndex = 1;
            this.dgvSellOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSellOrder_CellClick);
            // 
            // dgvBuyOrder
            // 
            this.dgvBuyOrder.AllowUserToAddRows = false;
            this.dgvBuyOrder.AllowUserToDeleteRows = false;
            this.dgvBuyOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvBuyOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBuyOrder.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBuyOrder.Location = new System.Drawing.Point(3, 3);
            this.dgvBuyOrder.Name = "dgvBuyOrder";
            this.dgvBuyOrder.ReadOnly = true;
            this.dgvBuyOrder.Size = new System.Drawing.Size(279, 435);
            this.dgvBuyOrder.TabIndex = 0;
            this.dgvBuyOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuyOrder_CellClick);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(522, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Symbol:";
            // 
            // lblBookSymbol
            // 
            this.lblBookSymbol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookSymbol.AutoSize = true;
            this.lblBookSymbol.Location = new System.Drawing.Point(572, 12);
            this.lblBookSymbol.Name = "lblBookSymbol";
            this.lblBookSymbol.Size = new System.Drawing.Size(0, 13);
            this.lblBookSymbol.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkEmpty);
            this.groupBox3.Controls.Add(this.dtgAccountBalance);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 181);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Accout info";
            // 
            // chkEmpty
            // 
            this.chkEmpty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEmpty.AutoSize = true;
            this.chkEmpty.Checked = true;
            this.chkEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmpty.Location = new System.Drawing.Point(11, 158);
            this.chkEmpty.Name = "chkEmpty";
            this.chkEmpty.Size = new System.Drawing.Size(114, 17);
            this.chkEmpty.TabIndex = 10;
            this.chkEmpty.Text = "Hide empty symbol";
            this.chkEmpty.UseVisualStyleBackColor = true;
            // 
            // dtgAccountBalance
            // 
            this.dtgAccountBalance.AllowUserToAddRows = false;
            this.dtgAccountBalance.AllowUserToDeleteRows = false;
            this.dtgAccountBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAccountBalance.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgAccountBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAccountBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSymbol,
            this.colfree,
            this.colLocked});
            this.dtgAccountBalance.Location = new System.Drawing.Point(6, 19);
            this.dtgAccountBalance.Name = "dtgAccountBalance";
            this.dtgAccountBalance.ReadOnly = true;
            this.dtgAccountBalance.Size = new System.Drawing.Size(495, 133);
            this.dtgAccountBalance.TabIndex = 7;
            this.dtgAccountBalance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAccountBalance_CellClick);
            this.dtgAccountBalance.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgAccountBalance_DataBindingComplete);
            // 
            // colSymbol
            // 
            this.colSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSymbol.DataPropertyName = "asset";
            this.colSymbol.HeaderText = "Symbol";
            this.colSymbol.Name = "colSymbol";
            this.colSymbol.ReadOnly = true;
            // 
            // colfree
            // 
            this.colfree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colfree.DataPropertyName = "free";
            this.colfree.HeaderText = "Free";
            this.colfree.Name = "colfree";
            this.colfree.ReadOnly = true;
            // 
            // colLocked
            // 
            this.colLocked.DataPropertyName = "locked";
            this.colLocked.HeaderText = "Locked";
            this.colLocked.Name = "colLocked";
            this.colLocked.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.grpBaseAsset);
            this.panel3.Controls.Add(this.lblSymbol);
            this.panel3.Controls.Add(this.lblSymbolsss);
            this.panel3.Controls.Add(this.btnStarTrading);
            this.panel3.Location = new System.Drawing.Point(12, 197);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(507, 46);
            this.panel3.TabIndex = 10;
            // 
            // grpBaseAsset
            // 
            this.grpBaseAsset.Controls.Add(this.rdBtc);
            this.grpBaseAsset.Controls.Add(this.rdUsdt);
            this.grpBaseAsset.Controls.Add(this.rdEth);
            this.grpBaseAsset.Location = new System.Drawing.Point(301, 1);
            this.grpBaseAsset.Name = "grpBaseAsset";
            this.grpBaseAsset.Size = new System.Drawing.Size(199, 39);
            this.grpBaseAsset.TabIndex = 12;
            this.grpBaseAsset.TabStop = false;
            // 
            // rdBtc
            // 
            this.rdBtc.AutoSize = true;
            this.rdBtc.Location = new System.Drawing.Point(80, 12);
            this.rdBtc.Name = "rdBtc";
            this.rdBtc.Size = new System.Drawing.Size(46, 17);
            this.rdBtc.TabIndex = 0;
            this.rdBtc.Text = "BTC";
            this.rdBtc.UseVisualStyleBackColor = true;
            this.rdBtc.CheckedChanged += new System.EventHandler(this.rdBtc_CheckedChanged);
            // 
            // rdUsdt
            // 
            this.rdUsdt.AutoSize = true;
            this.rdUsdt.Checked = true;
            this.rdUsdt.Location = new System.Drawing.Point(10, 12);
            this.rdUsdt.Name = "rdUsdt";
            this.rdUsdt.Size = new System.Drawing.Size(55, 17);
            this.rdUsdt.TabIndex = 0;
            this.rdUsdt.TabStop = true;
            this.rdUsdt.Text = "USDT";
            this.rdUsdt.UseVisualStyleBackColor = true;
            this.rdUsdt.CheckedChanged += new System.EventHandler(this.rdUsdt_CheckedChanged);
            // 
            // rdEth
            // 
            this.rdEth.AutoSize = true;
            this.rdEth.Location = new System.Drawing.Point(144, 11);
            this.rdEth.Name = "rdEth";
            this.rdEth.Size = new System.Drawing.Size(47, 17);
            this.rdEth.TabIndex = 0;
            this.rdEth.Text = "ETH";
            this.rdEth.UseVisualStyleBackColor = true;
            this.rdEth.CheckedChanged += new System.EventHandler(this.rdEth_CheckedChanged);
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(135, 12);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(40, 13);
            this.lblSymbol.TabIndex = 11;
            this.lblSymbol.Text = "{0}/{1}";
            // 
            // lblSymbolsss
            // 
            this.lblSymbolsss.AutoSize = true;
            this.lblSymbolsss.Location = new System.Drawing.Point(91, 12);
            this.lblSymbolsss.Name = "lblSymbolsss";
            this.lblSymbolsss.Size = new System.Drawing.Size(44, 13);
            this.lblSymbolsss.TabIndex = 10;
            this.lblSymbolsss.Text = "Symbol:";
            // 
            // dtgTradingList
            // 
            this.dtgTradingList.AllowUserToAddRows = false;
            this.dtgTradingList.AllowUserToDeleteRows = false;
            this.dtgTradingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgTradingList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgTradingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTradingList.Location = new System.Drawing.Point(12, 556);
            this.dtgTradingList.Name = "dtgTradingList";
            this.dtgTradingList.ReadOnly = true;
            this.dtgTradingList.Size = new System.Drawing.Size(1072, 193);
            this.dtgTradingList.TabIndex = 11;
            // 
            // BotAutoMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 761);
            this.Controls.Add(this.dtgTradingList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lblBookSymbol);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BotAutoMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bot Auto trading";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BotAutoMain_FormClosing);
            this.Load += new System.EventHandler(this.BotAutoMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpSellSetting.ResumeLayout(false);
            this.grpSellSetting.PerformLayout();
            this.grpBuySetting.ResumeLayout(false);
            this.grpBuySetting.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuyOrder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAccountBalance)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grpBaseAsset.ResumeLayout(false);
            this.grpBaseAsset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTradingList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpSellSetting;
        private System.Windows.Forms.TextBox txtSellPriceTo;
        private System.Windows.Forms.TextBox txtSellPriceFrom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpBuySetting;
        private System.Windows.Forms.TextBox txtBuyPriceTo;
        private System.Windows.Forms.TextBox txtBuyPriceFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAutoSell;
        private System.Windows.Forms.CheckBox chkAutoBuy;
        private System.Windows.Forms.Button btnStarTrading;
        private System.Windows.Forms.TextBox txtBudgetBuy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvSellOrder;
        private System.Windows.Forms.DataGridView dgvBuyOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblBookSymbol;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgAccountBalance;
        private System.Windows.Forms.TextBox txtBudgetSell;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocked;
        private System.Windows.Forms.CheckBox chkEmpty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.Label lblSymbolsss;
        private System.Windows.Forms.RadioButton rdEth;
        private System.Windows.Forms.RadioButton rdBtc;
        private System.Windows.Forms.RadioButton rdUsdt;
        private System.Windows.Forms.GroupBox grpBaseAsset;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.CheckBox chkStopLoad;
        private System.Windows.Forms.Label lblTotalBuyBaseAsset;
        private System.Windows.Forms.Label lblTotalBuyAsset;
        private System.Windows.Forms.Label lblTotalSellAsset;
        private System.Windows.Forms.Label lblTotalSellBaseAsset;
        private System.Windows.Forms.DataGridView dtgTradingList;
    }
}

