namespace BotAutoTrading
{
    partial class TradingBot
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TradingBot));
            this.dtgOrders = new System.Windows.Forms.DataGridView();
            this.colOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpenedTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfitValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpenedPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCurrentPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProfitPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTargetPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grpTradingConfig = new System.Windows.Forms.GroupBox();
            this.numRiskOrder = new System.Windows.Forms.NumericUpDown();
            this.numWinOrder = new System.Windows.Forms.NumericUpDown();
            this.numBudgetOrder = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblAssetEstimate = new System.Windows.Forms.Label();
            this.lblEnquity = new System.Windows.Forms.Label();
            this.lblBlanaceBaseAsset = new System.Windows.Forms.Label();
            this.lblBaseAssetTotal = new System.Windows.Forms.Label();
            this.grpBaseAsset = new System.Windows.Forms.GroupBox();
            this.rdBtc = new System.Windows.Forms.RadioButton();
            this.rdUsdt = new System.Windows.Forms.RadioButton();
            this.rdEth = new System.Windows.Forms.RadioButton();
            this.btnStartSystem = new System.Windows.Forms.Button();
            this.btnCloseAllTrade = new System.Windows.Forms.Button();
            this.btnStartTrading = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgSell = new System.Windows.Forms.DataGridView();
            this.colSellOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellFromPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellToPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellMarketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellCurrentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellButtonAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.txtAssetSearch = new System.Windows.Forms.TextBox();
            this.chkStopLoad = new System.Windows.Forms.CheckBox();
            this.chkEmpty = new System.Windows.Forms.CheckBox();
            this.dtgBalance = new System.Windows.Forms.DataGridView();
            this.colAsset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuy = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colSell = new System.Windows.Forms.DataGridViewButtonColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lblTotalBaseAssetBuy = new System.Windows.Forms.Label();
            this.chkBuyMarketPrice = new System.Windows.Forms.CheckBox();
            this.chkBuy = new System.Windows.Forms.CheckBox();
            this.dtgBuy = new System.Windows.Forms.DataGridView();
            this.colBuyOrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuySymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyFromPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyToPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyMarketPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyCurrentQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyButtonAction = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblTotalBaseAssetSell = new System.Windows.Forms.Label();
            this.chkSellBuyMarket = new System.Windows.Forms.CheckBox();
            this.chkSell = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).BeginInit();
            this.grpTradingConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRiskOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBudgetOrder)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.grpBaseAsset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSell)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuy)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOrders
            // 
            this.dtgOrders.AllowUserToAddRows = false;
            this.dtgOrders.AllowUserToDeleteRows = false;
            this.dtgOrders.AllowUserToResizeRows = false;
            this.dtgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgOrders.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOrderId,
            this.colSymbol,
            this.colOpenedTime,
            this.colQty,
            this.colValue,
            this.colProfitValue,
            this.colOpenedPrice,
            this.colCurrentPrice,
            this.colProfitPercent,
            this.colTargetPercent,
            this.colAction});
            this.dtgOrders.Location = new System.Drawing.Point(4, 23);
            this.dtgOrders.Name = "dtgOrders";
            this.dtgOrders.ReadOnly = true;
            this.dtgOrders.RowHeadersVisible = false;
            this.dtgOrders.Size = new System.Drawing.Size(477, 170);
            this.dtgOrders.TabIndex = 0;
            this.dtgOrders.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgOrders_CellFormatting);
            // 
            // colOrderId
            // 
            this.colOrderId.DataPropertyName = "OrderId";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOrderId.DefaultCellStyle = dataGridViewCellStyle1;
            this.colOrderId.HeaderText = "OrderId";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.ReadOnly = true;
            // 
            // colSymbol
            // 
            this.colSymbol.DataPropertyName = "Symbol";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSymbol.DefaultCellStyle = dataGridViewCellStyle2;
            this.colSymbol.HeaderText = "Symbol";
            this.colSymbol.Name = "colSymbol";
            this.colSymbol.ReadOnly = true;
            // 
            // colOpenedTime
            // 
            this.colOpenedTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOpenedTime.DataPropertyName = "OpenedTime";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colOpenedTime.DefaultCellStyle = dataGridViewCellStyle3;
            this.colOpenedTime.HeaderText = "Opened time";
            this.colOpenedTime.Name = "colOpenedTime";
            this.colOpenedTime.ReadOnly = true;
            // 
            // colQty
            // 
            this.colQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colQty.DataPropertyName = "Qty";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.colQty.HeaderText = "Size";
            this.colQty.Name = "colQty";
            this.colQty.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colValue.DataPropertyName = "Value";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colValue.DefaultCellStyle = dataGridViewCellStyle5;
            this.colValue.HeaderText = "Value";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // colProfitValue
            // 
            this.colProfitValue.DataPropertyName = "ProfitValue";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colProfitValue.DefaultCellStyle = dataGridViewCellStyle6;
            this.colProfitValue.HeaderText = "ProfitValue";
            this.colProfitValue.Name = "colProfitValue";
            this.colProfitValue.ReadOnly = true;
            // 
            // colOpenedPrice
            // 
            this.colOpenedPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colOpenedPrice.DataPropertyName = "OpenedPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colOpenedPrice.DefaultCellStyle = dataGridViewCellStyle7;
            this.colOpenedPrice.HeaderText = "OpenedPrice";
            this.colOpenedPrice.Name = "colOpenedPrice";
            this.colOpenedPrice.ReadOnly = true;
            // 
            // colCurrentPrice
            // 
            this.colCurrentPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCurrentPrice.DataPropertyName = "CurrentPrice";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colCurrentPrice.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCurrentPrice.HeaderText = "CurrentPrice";
            this.colCurrentPrice.Name = "colCurrentPrice";
            this.colCurrentPrice.ReadOnly = true;
            // 
            // colProfitPercent
            // 
            this.colProfitPercent.DataPropertyName = "ProfitPercent";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colProfitPercent.DefaultCellStyle = dataGridViewCellStyle9;
            this.colProfitPercent.HeaderText = "ProfitPercent";
            this.colProfitPercent.Name = "colProfitPercent";
            this.colProfitPercent.ReadOnly = true;
            // 
            // colTargetPercent
            // 
            this.colTargetPercent.DataPropertyName = "TargetPercent";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colTargetPercent.DefaultCellStyle = dataGridViewCellStyle10;
            this.colTargetPercent.HeaderText = "Target Percent";
            this.colTargetPercent.Name = "colTargetPercent";
            this.colTargetPercent.ReadOnly = true;
            this.colTargetPercent.Width = 120;
            // 
            // colAction
            // 
            this.colAction.DataPropertyName = "Action";
            this.colAction.HeaderText = "Action";
            this.colAction.Name = "colAction";
            this.colAction.ReadOnly = true;
            this.colAction.Visible = false;
            this.colAction.Width = 75;
            // 
            // grpTradingConfig
            // 
            this.grpTradingConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpTradingConfig.Controls.Add(this.numRiskOrder);
            this.grpTradingConfig.Controls.Add(this.numWinOrder);
            this.grpTradingConfig.Controls.Add(this.numBudgetOrder);
            this.grpTradingConfig.Controls.Add(this.label3);
            this.grpTradingConfig.Controls.Add(this.label2);
            this.grpTradingConfig.Controls.Add(this.label1);
            this.grpTradingConfig.Location = new System.Drawing.Point(598, 12);
            this.grpTradingConfig.Name = "grpTradingConfig";
            this.grpTradingConfig.Size = new System.Drawing.Size(385, 116);
            this.grpTradingConfig.TabIndex = 1;
            this.grpTradingConfig.TabStop = false;
            this.grpTradingConfig.Text = "Setting Risk and Reward";
            // 
            // numRiskOrder
            // 
            this.numRiskOrder.Location = new System.Drawing.Point(272, 58);
            this.numRiskOrder.Name = "numRiskOrder";
            this.numRiskOrder.Size = new System.Drawing.Size(102, 20);
            this.numRiskOrder.TabIndex = 5;
            this.numRiskOrder.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numWinOrder
            // 
            this.numWinOrder.Location = new System.Drawing.Point(140, 58);
            this.numWinOrder.Name = "numWinOrder";
            this.numWinOrder.Size = new System.Drawing.Size(102, 20);
            this.numWinOrder.TabIndex = 4;
            this.numWinOrder.ThousandsSeparator = true;
            this.numWinOrder.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numBudgetOrder
            // 
            this.numBudgetOrder.Location = new System.Drawing.Point(9, 58);
            this.numBudgetOrder.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numBudgetOrder.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBudgetOrder.Name = "numBudgetOrder";
            this.numBudgetOrder.Size = new System.Drawing.Size(102, 20);
            this.numBudgetOrder.TabIndex = 3;
            this.numBudgetOrder.ThousandsSeparator = true;
            this.numBudgetOrder.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Risk %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Win %";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size per trade(USDT)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblAssetEstimate);
            this.groupBox2.Controls.Add(this.lblEnquity);
            this.groupBox2.Controls.Add(this.lblBlanaceBaseAsset);
            this.groupBox2.Controls.Add(this.lblBaseAssetTotal);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 113);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Balance info";
            // 
            // lblAssetEstimate
            // 
            this.lblAssetEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAssetEstimate.AutoSize = true;
            this.lblAssetEstimate.Location = new System.Drawing.Point(205, 54);
            this.lblAssetEstimate.Name = "lblAssetEstimate";
            this.lblAssetEstimate.Size = new System.Drawing.Size(16, 13);
            this.lblAssetEstimate.TabIndex = 3;
            this.lblAssetEstimate.Text = "...";
            // 
            // lblEnquity
            // 
            this.lblEnquity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEnquity.AutoSize = true;
            this.lblEnquity.Location = new System.Drawing.Point(205, 31);
            this.lblEnquity.Name = "lblEnquity";
            this.lblEnquity.Size = new System.Drawing.Size(132, 13);
            this.lblEnquity.TabIndex = 2;
            this.lblEnquity.Text = "ENQUITY VALUE (USDT)";
            // 
            // lblBlanaceBaseAsset
            // 
            this.lblBlanaceBaseAsset.AutoSize = true;
            this.lblBlanaceBaseAsset.Location = new System.Drawing.Point(18, 54);
            this.lblBlanaceBaseAsset.Name = "lblBlanaceBaseAsset";
            this.lblBlanaceBaseAsset.Size = new System.Drawing.Size(16, 13);
            this.lblBlanaceBaseAsset.TabIndex = 1;
            this.lblBlanaceBaseAsset.Text = "...";
            // 
            // lblBaseAssetTotal
            // 
            this.lblBaseAssetTotal.AutoSize = true;
            this.lblBaseAssetTotal.Location = new System.Drawing.Point(8, 31);
            this.lblBaseAssetTotal.Name = "lblBaseAssetTotal";
            this.lblBaseAssetTotal.Size = new System.Drawing.Size(37, 13);
            this.lblBaseAssetTotal.TabIndex = 0;
            this.lblBaseAssetTotal.Text = "USDT";
            // 
            // grpBaseAsset
            // 
            this.grpBaseAsset.Controls.Add(this.rdBtc);
            this.grpBaseAsset.Controls.Add(this.rdUsdt);
            this.grpBaseAsset.Controls.Add(this.rdEth);
            this.grpBaseAsset.Location = new System.Drawing.Point(8, 78);
            this.grpBaseAsset.Name = "grpBaseAsset";
            this.grpBaseAsset.Size = new System.Drawing.Size(215, 36);
            this.grpBaseAsset.TabIndex = 14;
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
            // btnStartSystem
            // 
            this.btnStartSystem.ForeColor = System.Drawing.Color.Green;
            this.btnStartSystem.Location = new System.Drawing.Point(8, 4);
            this.btnStartSystem.Name = "btnStartSystem";
            this.btnStartSystem.Size = new System.Drawing.Size(110, 34);
            this.btnStartSystem.TabIndex = 3;
            this.btnStartSystem.Text = "START";
            this.btnStartSystem.UseVisualStyleBackColor = true;
            this.btnStartSystem.Click += new System.EventHandler(this.btnStartSystem_Click);
            // 
            // btnCloseAllTrade
            // 
            this.btnCloseAllTrade.Enabled = false;
            this.btnCloseAllTrade.Location = new System.Drawing.Point(124, 5);
            this.btnCloseAllTrade.Name = "btnCloseAllTrade";
            this.btnCloseAllTrade.Size = new System.Drawing.Size(99, 33);
            this.btnCloseAllTrade.TabIndex = 4;
            this.btnCloseAllTrade.Text = "CLOSED ALL";
            this.btnCloseAllTrade.UseVisualStyleBackColor = true;
            this.btnCloseAllTrade.Click += new System.EventHandler(this.btnCloseAllTrade_Click);
            // 
            // btnStartTrading
            // 
            this.btnStartTrading.Enabled = false;
            this.btnStartTrading.ForeColor = System.Drawing.Color.Green;
            this.btnStartTrading.Location = new System.Drawing.Point(8, 44);
            this.btnStartTrading.Name = "btnStartTrading";
            this.btnStartTrading.Size = new System.Drawing.Size(215, 34);
            this.btnStartTrading.TabIndex = 5;
            this.btnStartTrading.Text = "TRADING";
            this.btnStartTrading.UseVisualStyleBackColor = true;
            this.btnStartTrading.Click += new System.EventHandler(this.btnStartTrading_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "BLANCE";
            // 
            // dtgSell
            // 
            this.dtgSell.AllowUserToAddRows = false;
            this.dtgSell.AllowUserToResizeRows = false;
            this.dtgSell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgSell.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSell.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSellOrderId,
            this.colSellSymbol,
            this.colSellValues,
            this.colSellFromPrice,
            this.colSellToPrice,
            this.colSellMarketPrice,
            this.colSellCurrentQty,
            this.colSellButtonAction});
            this.dtgSell.Location = new System.Drawing.Point(3, 24);
            this.dtgSell.Name = "dtgSell";
            this.dtgSell.Size = new System.Drawing.Size(354, 161);
            this.dtgSell.TabIndex = 12;
            this.dtgSell.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSell_CellDoubleClick);
            this.dtgSell.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgSell_CellEndEdit);
            this.dtgSell.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgSell_KeyDown);
            // 
            // colSellOrderId
            // 
            this.colSellOrderId.DataPropertyName = "SellOrderId";
            this.colSellOrderId.HeaderText = "colSellOrderId";
            this.colSellOrderId.Name = "colSellOrderId";
            this.colSellOrderId.ReadOnly = true;
            this.colSellOrderId.Visible = false;
            // 
            // colSellSymbol
            // 
            this.colSellSymbol.DataPropertyName = "SellSymbol";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colSellSymbol.DefaultCellStyle = dataGridViewCellStyle11;
            this.colSellSymbol.HeaderText = "Symbol";
            this.colSellSymbol.Name = "colSellSymbol";
            this.colSellSymbol.ReadOnly = true;
            this.colSellSymbol.Width = 75;
            // 
            // colSellValues
            // 
            this.colSellValues.DataPropertyName = "SellValues";
            this.colSellValues.HeaderText = "Size";
            this.colSellValues.Name = "colSellValues";
            // 
            // colSellFromPrice
            // 
            this.colSellFromPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSellFromPrice.DataPropertyName = "SellFromPrice";
            this.colSellFromPrice.HeaderText = "FromPrice";
            this.colSellFromPrice.Name = "colSellFromPrice";
            // 
            // colSellToPrice
            // 
            this.colSellToPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSellToPrice.DataPropertyName = "SellToPrice";
            this.colSellToPrice.HeaderText = "SellToPrice";
            this.colSellToPrice.Name = "colSellToPrice";
            // 
            // colSellMarketPrice
            // 
            this.colSellMarketPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colSellMarketPrice.DataPropertyName = "SellMarketPrice";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colSellMarketPrice.DefaultCellStyle = dataGridViewCellStyle12;
            this.colSellMarketPrice.HeaderText = "MarketPrice";
            this.colSellMarketPrice.Name = "colSellMarketPrice";
            this.colSellMarketPrice.ReadOnly = true;
            // 
            // colSellCurrentQty
            // 
            this.colSellCurrentQty.DataPropertyName = "SellCurrentQty";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSellCurrentQty.DefaultCellStyle = dataGridViewCellStyle13;
            this.colSellCurrentQty.HeaderText = "Quantity";
            this.colSellCurrentQty.Name = "colSellCurrentQty";
            this.colSellCurrentQty.ReadOnly = true;
            this.colSellCurrentQty.Width = 75;
            // 
            // colSellButtonAction
            // 
            this.colSellButtonAction.DataPropertyName = "SellButtonAction";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.NullValue = "SELL MARKET";
            this.colSellButtonAction.DefaultCellStyle = dataGridViewCellStyle14;
            this.colSellButtonAction.HeaderText = "Action";
            this.colSellButtonAction.Name = "colSellButtonAction";
            this.colSellButtonAction.ReadOnly = true;
            this.colSellButtonAction.Visible = false;
            this.colSellButtonAction.Width = 85;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCloseAllTrade);
            this.panel1.Controls.Add(this.btnStartTrading);
            this.panel1.Controls.Add(this.btnStartSystem);
            this.panel1.Controls.Add(this.grpBaseAsset);
            this.panel1.Location = new System.Drawing.Point(361, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 117);
            this.panel1.TabIndex = 15;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 131);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(971, 418);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 16;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.txtAssetSearch);
            this.splitContainer3.Panel1.Controls.Add(this.chkStopLoad);
            this.splitContainer3.Panel1.Controls.Add(this.chkEmpty);
            this.splitContainer3.Panel1.Controls.Add(this.dtgBalance);
            this.splitContainer3.Panel1.Controls.Add(this.label7);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer3.Size = new System.Drawing.Size(971, 218);
            this.splitContainer3.SplitterDistance = 241;
            this.splitContainer3.TabIndex = 7;
            // 
            // txtAssetSearch
            // 
            this.txtAssetSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAssetSearch.Location = new System.Drawing.Point(3, 191);
            this.txtAssetSearch.Name = "txtAssetSearch";
            this.txtAssetSearch.Size = new System.Drawing.Size(233, 20);
            this.txtAssetSearch.TabIndex = 17;
            this.txtAssetSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAssetSearch_KeyDown);
            // 
            // chkStopLoad
            // 
            this.chkStopLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStopLoad.AutoSize = true;
            this.chkStopLoad.Location = new System.Drawing.Point(141, 3);
            this.chkStopLoad.Name = "chkStopLoad";
            this.chkStopLoad.Size = new System.Drawing.Size(95, 17);
            this.chkStopLoad.TabIndex = 16;
            this.chkStopLoad.Text = "Stop load data";
            this.chkStopLoad.UseVisualStyleBackColor = true;
            // 
            // chkEmpty
            // 
            this.chkEmpty.AutoSize = true;
            this.chkEmpty.Checked = true;
            this.chkEmpty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmpty.Location = new System.Drawing.Point(54, 6);
            this.chkEmpty.Name = "chkEmpty";
            this.chkEmpty.Size = new System.Drawing.Size(114, 17);
            this.chkEmpty.TabIndex = 15;
            this.chkEmpty.Text = "Hide empty symbol";
            this.chkEmpty.UseVisualStyleBackColor = true;
            // 
            // dtgBalance
            // 
            this.dtgBalance.AllowUserToAddRows = false;
            this.dtgBalance.AllowUserToDeleteRows = false;
            this.dtgBalance.AllowUserToResizeRows = false;
            this.dtgBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBalance.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colAsset,
            this.colFree,
            this.colLocked,
            this.colBuy,
            this.colSell});
            this.dtgBalance.Location = new System.Drawing.Point(2, 24);
            this.dtgBalance.Name = "dtgBalance";
            this.dtgBalance.ReadOnly = true;
            this.dtgBalance.RowHeadersVisible = false;
            this.dtgBalance.Size = new System.Drawing.Size(234, 161);
            this.dtgBalance.TabIndex = 14;
            this.dtgBalance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBalance_CellClick);
            // 
            // colAsset
            // 
            this.colAsset.DataPropertyName = "Asset";
            this.colAsset.HeaderText = "Asset";
            this.colAsset.Name = "colAsset";
            this.colAsset.ReadOnly = true;
            this.colAsset.Width = 75;
            // 
            // colFree
            // 
            this.colFree.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFree.DataPropertyName = "Free";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colFree.DefaultCellStyle = dataGridViewCellStyle15;
            this.colFree.HeaderText = "Free";
            this.colFree.Name = "colFree";
            this.colFree.ReadOnly = true;
            // 
            // colLocked
            // 
            this.colLocked.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colLocked.DataPropertyName = "Locked";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colLocked.DefaultCellStyle = dataGridViewCellStyle16;
            this.colLocked.HeaderText = "Locked";
            this.colLocked.Name = "colLocked";
            this.colLocked.ReadOnly = true;
            // 
            // colBuy
            // 
            this.colBuy.DataPropertyName = "Buy";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle17.NullValue = "BUY";
            this.colBuy.DefaultCellStyle = dataGridViewCellStyle17;
            this.colBuy.HeaderText = "";
            this.colBuy.Name = "colBuy";
            this.colBuy.ReadOnly = true;
            this.colBuy.Width = 75;
            // 
            // colSell
            // 
            this.colSell.DataPropertyName = "Sell";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle18.NullValue = "SELL";
            this.colSell.DefaultCellStyle = dataGridViewCellStyle18;
            this.colSell.HeaderText = "";
            this.colSell.Name = "colSell";
            this.colSell.ReadOnly = true;
            this.colSell.Width = 75;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lblTotalBaseAssetBuy);
            this.splitContainer2.Panel1.Controls.Add(this.chkBuyMarketPrice);
            this.splitContainer2.Panel1.Controls.Add(this.chkBuy);
            this.splitContainer2.Panel1.Controls.Add(this.dtgBuy);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.lblTotalBaseAssetSell);
            this.splitContainer2.Panel2.Controls.Add(this.chkSellBuyMarket);
            this.splitContainer2.Panel2.Controls.Add(this.chkSell);
            this.splitContainer2.Panel2.Controls.Add(this.dtgSell);
            this.splitContainer2.Size = new System.Drawing.Size(726, 218);
            this.splitContainer2.SplitterDistance = 360;
            this.splitContainer2.TabIndex = 14;
            // 
            // lblTotalBaseAssetBuy
            // 
            this.lblTotalBaseAssetBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalBaseAssetBuy.AutoSize = true;
            this.lblTotalBaseAssetBuy.Location = new System.Drawing.Point(3, 196);
            this.lblTotalBaseAssetBuy.Name = "lblTotalBaseAssetBuy";
            this.lblTotalBaseAssetBuy.Size = new System.Drawing.Size(34, 13);
            this.lblTotalBaseAssetBuy.TabIndex = 17;
            this.lblTotalBaseAssetBuy.Text = "Total:";
            // 
            // chkBuyMarketPrice
            // 
            this.chkBuyMarketPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkBuyMarketPrice.AutoSize = true;
            this.chkBuyMarketPrice.Location = new System.Drawing.Point(242, 3);
            this.chkBuyMarketPrice.Name = "chkBuyMarketPrice";
            this.chkBuyMarketPrice.Size = new System.Drawing.Size(113, 17);
            this.chkBuyMarketPrice.TabIndex = 16;
            this.chkBuyMarketPrice.Text = "BUY BY MARKET";
            this.chkBuyMarketPrice.UseVisualStyleBackColor = true;
            this.chkBuyMarketPrice.CheckedChanged += new System.EventHandler(this.chkBuyMarketPrice_CheckedChanged);
            // 
            // chkBuy
            // 
            this.chkBuy.AutoSize = true;
            this.chkBuy.Location = new System.Drawing.Point(3, 3);
            this.chkBuy.Name = "chkBuy";
            this.chkBuy.Size = new System.Drawing.Size(48, 17);
            this.chkBuy.TabIndex = 14;
            this.chkBuy.Text = "BUY";
            this.chkBuy.UseVisualStyleBackColor = true;
            this.chkBuy.CheckedChanged += new System.EventHandler(this.chkBuy_CheckedChanged);
            // 
            // dtgBuy
            // 
            this.dtgBuy.AllowUserToAddRows = false;
            this.dtgBuy.AllowUserToResizeRows = false;
            this.dtgBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBuy.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgBuy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBuy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBuyOrderId,
            this.colBuySymbol,
            this.colBuyValues,
            this.colBuyFromPrice,
            this.colBuyToPrice,
            this.colBuyMarketPrice,
            this.colBuyCurrentQty,
            this.colBuyButtonAction});
            this.dtgBuy.Location = new System.Drawing.Point(3, 24);
            this.dtgBuy.Name = "dtgBuy";
            this.dtgBuy.Size = new System.Drawing.Size(352, 161);
            this.dtgBuy.TabIndex = 13;
            this.dtgBuy.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBuy_CellDoubleClick);
            this.dtgBuy.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBuy_CellEndEdit);
            this.dtgBuy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtgBuy_KeyDown);
            // 
            // colBuyOrderId
            // 
            this.colBuyOrderId.DataPropertyName = "BuyOrderId";
            this.colBuyOrderId.HeaderText = "colBuyOrderId";
            this.colBuyOrderId.Name = "colBuyOrderId";
            this.colBuyOrderId.Visible = false;
            // 
            // colBuySymbol
            // 
            this.colBuySymbol.DataPropertyName = "BuySymbol";
            this.colBuySymbol.HeaderText = "Symbol";
            this.colBuySymbol.Name = "colBuySymbol";
            this.colBuySymbol.ReadOnly = true;
            this.colBuySymbol.Width = 75;
            // 
            // colBuyValues
            // 
            this.colBuyValues.DataPropertyName = "BuyValues";
            this.colBuyValues.HeaderText = "Size";
            this.colBuyValues.Name = "colBuyValues";
            // 
            // colBuyFromPrice
            // 
            this.colBuyFromPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBuyFromPrice.DataPropertyName = "BuyFromPrice";
            this.colBuyFromPrice.HeaderText = "FromPrice";
            this.colBuyFromPrice.Name = "colBuyFromPrice";
            // 
            // colBuyToPrice
            // 
            this.colBuyToPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBuyToPrice.DataPropertyName = "BuyToPrice";
            this.colBuyToPrice.HeaderText = "ToPrice";
            this.colBuyToPrice.Name = "colBuyToPrice";
            // 
            // colBuyMarketPrice
            // 
            this.colBuyMarketPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colBuyMarketPrice.DataPropertyName = "BuyMarketPrice";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colBuyMarketPrice.DefaultCellStyle = dataGridViewCellStyle19;
            this.colBuyMarketPrice.HeaderText = "MarketPrice";
            this.colBuyMarketPrice.Name = "colBuyMarketPrice";
            this.colBuyMarketPrice.ReadOnly = true;
            // 
            // colBuyCurrentQty
            // 
            this.colBuyCurrentQty.DataPropertyName = "BuyCurrentQty";
            this.colBuyCurrentQty.HeaderText = "Quantity";
            this.colBuyCurrentQty.Name = "colBuyCurrentQty";
            this.colBuyCurrentQty.ReadOnly = true;
            this.colBuyCurrentQty.Width = 75;
            // 
            // colBuyButtonAction
            // 
            this.colBuyButtonAction.DataPropertyName = "BuyButtonAction";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle20.NullValue = "BUY MARKET";
            this.colBuyButtonAction.DefaultCellStyle = dataGridViewCellStyle20;
            this.colBuyButtonAction.HeaderText = "Action";
            this.colBuyButtonAction.Name = "colBuyButtonAction";
            this.colBuyButtonAction.Visible = false;
            this.colBuyButtonAction.Width = 80;
            // 
            // lblTotalBaseAssetSell
            // 
            this.lblTotalBaseAssetSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalBaseAssetSell.AutoSize = true;
            this.lblTotalBaseAssetSell.Location = new System.Drawing.Point(3, 194);
            this.lblTotalBaseAssetSell.Name = "lblTotalBaseAssetSell";
            this.lblTotalBaseAssetSell.Size = new System.Drawing.Size(34, 13);
            this.lblTotalBaseAssetSell.TabIndex = 17;
            this.lblTotalBaseAssetSell.Text = "Total:";
            // 
            // chkSellBuyMarket
            // 
            this.chkSellBuyMarket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkSellBuyMarket.AutoSize = true;
            this.chkSellBuyMarket.Location = new System.Drawing.Point(240, 3);
            this.chkSellBuyMarket.Name = "chkSellBuyMarket";
            this.chkSellBuyMarket.Size = new System.Drawing.Size(117, 17);
            this.chkSellBuyMarket.TabIndex = 15;
            this.chkSellBuyMarket.Text = "SELL BY MARKET";
            this.chkSellBuyMarket.UseVisualStyleBackColor = true;
            this.chkSellBuyMarket.CheckedChanged += new System.EventHandler(this.chkSellBuyMarket_CheckedChanged);
            // 
            // chkSell
            // 
            this.chkSell.AutoSize = true;
            this.chkSell.Location = new System.Drawing.Point(3, 3);
            this.chkSell.Name = "chkSell";
            this.chkSell.Size = new System.Drawing.Size(52, 17);
            this.chkSell.TabIndex = 14;
            this.chkSell.Text = "SELL";
            this.chkSell.UseVisualStyleBackColor = true;
            this.chkSell.CheckedChanged += new System.EventHandler(this.chkSell_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Order histories";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(95, 26);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.dtgOrders);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.label5);
            this.splitContainer4.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer4.Size = new System.Drawing.Size(971, 196);
            this.splitContainer4.SplitterDistance = 484;
            this.splitContainer4.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewButtonColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(3, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(477, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Open orders";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Symbol";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridViewTextBoxColumn2.HeaderText = "Symbol";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "OpenedTime";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewTextBoxColumn3.HeaderText = "Opened time";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Qty";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Value";
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridViewTextBoxColumn5.HeaderText = "Value";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OpenedPrice";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewTextBoxColumn7.HeaderText = "OpenedPrice";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Action";
            this.dataGridViewButtonColumn1.HeaderText = "Action";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.ReadOnly = true;
            this.dataGridViewButtonColumn1.Width = 75;
            // 
            // TradingBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 561);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpTradingConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TradingBot";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TradingBot";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TradingBot_FormClosing);
            this.Load += new System.EventHandler(this.TradingBot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrders)).EndInit();
            this.grpTradingConfig.ResumeLayout(false);
            this.grpTradingConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRiskOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWinOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBudgetOrder)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpBaseAsset.ResumeLayout(false);
            this.grpBaseAsset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSell)).EndInit();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBalance)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBuy)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            this.splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrders;
        private System.Windows.Forms.GroupBox grpTradingConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnStartSystem;
        private System.Windows.Forms.Button btnCloseAllTrade;
        private System.Windows.Forms.Label lblBaseAssetTotal;
        private System.Windows.Forms.NumericUpDown numRiskOrder;
        private System.Windows.Forms.NumericUpDown numWinOrder;
        private System.Windows.Forms.NumericUpDown numBudgetOrder;
        private System.Windows.Forms.Button btnStartTrading;
        private System.Windows.Forms.Label lblEnquity;
        private System.Windows.Forms.Label lblBlanaceBaseAsset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dtgSell;
        private System.Windows.Forms.GroupBox grpBaseAsset;
        private System.Windows.Forms.RadioButton rdBtc;
        private System.Windows.Forms.RadioButton rdUsdt;
        private System.Windows.Forms.RadioButton rdEth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAssetEstimate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgBuy;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dtgBalance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpenedTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfitValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOpenedPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCurrentPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProfitPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTargetPercent;
        private System.Windows.Forms.DataGridViewButtonColumn colAction;
        private System.Windows.Forms.CheckBox chkBuy;
        private System.Windows.Forms.CheckBox chkSell;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.CheckBox chkEmpty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAsset;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocked;
        private System.Windows.Forms.DataGridViewButtonColumn colBuy;
        private System.Windows.Forms.DataGridViewButtonColumn colSell;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuySymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyFromPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyToPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyMarketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyCurrentQty;
        private System.Windows.Forms.DataGridViewButtonColumn colBuyButtonAction;
        private System.Windows.Forms.CheckBox chkSellBuyMarket;
        private System.Windows.Forms.CheckBox chkBuyMarketPrice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkStopLoad;
        private System.Windows.Forms.TextBox txtAssetSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellOrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellFromPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellToPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellMarketPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellCurrentQty;
        private System.Windows.Forms.DataGridViewButtonColumn colSellButtonAction;
        private System.Windows.Forms.Label lblTotalBaseAssetBuy;
        private System.Windows.Forms.Label lblTotalBaseAssetSell;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
    }
}