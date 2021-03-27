namespace BotAutoTrading
{
    partial class OrderBookDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderBookDisplay));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblTotalBuyAsset = new System.Windows.Forms.Label();
            this.chkStopLoad = new System.Windows.Forms.CheckBox();
            this.lblTotalBuyBaseAsset = new System.Windows.Forms.Label();
            this.dtgBids = new System.Windows.Forms.DataGridView();
            this.lblTotalSellAsset = new System.Windows.Forms.Label();
            this.lblTotalSellBaseAsset = new System.Windows.Forms.Label();
            this.dtgAsks = new System.Windows.Forms.DataGridView();
            this.cboTopOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsks)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalBuyAsset);
            this.splitContainer1.Panel1.Controls.Add(this.chkStopLoad);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalBuyBaseAsset);
            this.splitContainer1.Panel1.Controls.Add(this.dtgBids);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cboTopOrder);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalSellAsset);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.lblTotalSellBaseAsset);
            this.splitContainer1.Panel2.Controls.Add(this.dtgAsks);
            this.splitContainer1.Size = new System.Drawing.Size(607, 553);
            this.splitContainer1.SplitterDistance = 300;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblTotalBuyAsset
            // 
            this.lblTotalBuyAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalBuyAsset.AutoSize = true;
            this.lblTotalBuyAsset.Location = new System.Drawing.Point(3, 526);
            this.lblTotalBuyAsset.Name = "lblTotalBuyAsset";
            this.lblTotalBuyAsset.Size = new System.Drawing.Size(49, 13);
            this.lblTotalBuyAsset.TabIndex = 14;
            this.lblTotalBuyAsset.Text = "Quantity:";
            // 
            // chkStopLoad
            // 
            this.chkStopLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkStopLoad.AutoSize = true;
            this.chkStopLoad.Location = new System.Drawing.Point(3, 477);
            this.chkStopLoad.Name = "chkStopLoad";
            this.chkStopLoad.Size = new System.Drawing.Size(95, 17);
            this.chkStopLoad.TabIndex = 13;
            this.chkStopLoad.Text = "Stop load data";
            this.chkStopLoad.UseVisualStyleBackColor = true;
            // 
            // lblTotalBuyBaseAsset
            // 
            this.lblTotalBuyBaseAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalBuyBaseAsset.AutoSize = true;
            this.lblTotalBuyBaseAsset.Location = new System.Drawing.Point(3, 502);
            this.lblTotalBuyBaseAsset.Name = "lblTotalBuyBaseAsset";
            this.lblTotalBuyBaseAsset.Size = new System.Drawing.Size(46, 13);
            this.lblTotalBuyBaseAsset.TabIndex = 12;
            this.lblTotalBuyBaseAsset.Text = "Total(0):";
            // 
            // dtgBids
            // 
            this.dtgBids.AllowUserToAddRows = false;
            this.dtgBids.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            this.dtgBids.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgBids.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgBids.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBids.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgBids.Location = new System.Drawing.Point(3, 3);
            this.dtgBids.Name = "dtgBids";
            this.dtgBids.ReadOnly = true;
            this.dtgBids.Size = new System.Drawing.Size(294, 468);
            this.dtgBids.TabIndex = 0;
            this.dtgBids.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgBids_CellClick);
            // 
            // lblTotalSellAsset
            // 
            this.lblTotalSellAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalSellAsset.AutoSize = true;
            this.lblTotalSellAsset.Location = new System.Drawing.Point(3, 526);
            this.lblTotalSellAsset.Name = "lblTotalSellAsset";
            this.lblTotalSellAsset.Size = new System.Drawing.Size(49, 13);
            this.lblTotalSellAsset.TabIndex = 15;
            this.lblTotalSellAsset.Text = "Quantity:";
            // 
            // lblTotalSellBaseAsset
            // 
            this.lblTotalSellBaseAsset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotalSellBaseAsset.AutoSize = true;
            this.lblTotalSellBaseAsset.Location = new System.Drawing.Point(3, 502);
            this.lblTotalSellBaseAsset.Name = "lblTotalSellBaseAsset";
            this.lblTotalSellBaseAsset.Size = new System.Drawing.Size(46, 13);
            this.lblTotalSellBaseAsset.TabIndex = 14;
            this.lblTotalSellBaseAsset.Text = "Total(0):";
            // 
            // dtgAsks
            // 
            this.dtgAsks.AllowUserToAddRows = false;
            this.dtgAsks.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dtgAsks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgAsks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgAsks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgAsks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgAsks.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgAsks.Location = new System.Drawing.Point(3, 3);
            this.dtgAsks.Name = "dtgAsks";
            this.dtgAsks.ReadOnly = true;
            this.dtgAsks.Size = new System.Drawing.Size(297, 468);
            this.dtgAsks.TabIndex = 1;
            this.dtgAsks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAsks_CellClick);
            // 
            // cboTopOrder
            // 
            this.cboTopOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboTopOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTopOrder.FormattingEnabled = true;
            this.cboTopOrder.Items.AddRange(new object[] {
            "5",
            "100",
            "500",
            "1000"});
            this.cboTopOrder.Location = new System.Drawing.Point(58, 473);
            this.cboTopOrder.Name = "cboTopOrder";
            this.cboTopOrder.Size = new System.Drawing.Size(96, 21);
            this.cboTopOrder.TabIndex = 15;
            this.cboTopOrder.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Top order";
            this.label1.Visible = false;
            // 
            // OrderBookDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(607, 553);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderBookDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderBookDisplay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderBookDisplay_FormClosing);
            this.Load += new System.EventHandler(this.OrderBookDisplay_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAsks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dtgBids;
        private System.Windows.Forms.DataGridView dtgAsks;
        private System.Windows.Forms.Label lblTotalBuyAsset;
        private System.Windows.Forms.CheckBox chkStopLoad;
        private System.Windows.Forms.Label lblTotalBuyBaseAsset;
        private System.Windows.Forms.Label lblTotalSellAsset;
        private System.Windows.Forms.Label lblTotalSellBaseAsset;
        private System.Windows.Forms.ComboBox cboTopOrder;
        private System.Windows.Forms.Label label1;
    }
}