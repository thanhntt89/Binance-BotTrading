using Binance.API.Csharp.Client.Models.Market;
using BotAutoTrading.Utils;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace BotAutoTrading
{
    public partial class OrderBookDisplay : Form
    {
        private string symbol = string.Empty;
        private string orderType = string.Empty;
        private string assetText = string.Empty;
        private string baseAssetText = string.Empty;
        BindingList<OrderBookOffer> Bids;
        BindingList<OrderBookOffer> Asks;

        public delegate void SetSymbolPriceHandle(string orderType, decimal fromPrice, decimal toPrice);
        public SetSymbolPriceHandle setSymbolPriceEvent;

        public OrderBookDisplay(string _symbol, string _orderType, string _baseAsset)
        {
            InitializeComponent();
            symbol = _symbol;
            orderType = _orderType;
            assetText = _symbol.Replace(_baseAsset, "");
            baseAssetText = _baseAsset;
            
        }

        private void OrderBookDisplay_Load(object sender, EventArgs e)
        {
            dtgAsks.DataSource = Asks;
            dtgBids.DataSource = Bids;
        }

        public void LoadOrderBook(BindingList<OrderBookOffer> Bids, BindingList<OrderBookOffer> Asks)
        {
            if (chkStopLoad.Checked)
                return;
            try
            {
                Invoke(new Action(() =>
                {
                    this.Text = string.Format("OrderBook Top({0})- {1}", Asks.Count, symbol);
                    dtgAsks.DataSource = Asks;
                    dtgBids.DataSource = Bids;
                }));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void OrderBookDisplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            chkStopLoad.Checked = true;
        }

        private void dtgAsks_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            SellClick();
        }

        private void SellClick()
        {
            int rowIndex = dtgAsks.CurrentCell.RowIndex;
            int lasIndex = dtgAsks.Rows.Count - 1 > rowIndex + 1 ? rowIndex + 1 : dtgAsks.Rows.Count - 1;

            decimal totalAsset = 0;
            decimal totalBaseAsset = 0;
            decimal asset = 0;

            decimal fromPrice = decimal.Parse(dtgAsks.Rows[rowIndex].Cells[0].Value.ToString());
            decimal toPrice = decimal.Parse(dtgAsks.Rows[lasIndex].Cells[0].Value.ToString());

            if (setSymbolPriceEvent != null)
            {
                setSymbolPriceEvent(Constant.ORDER_SELL, fromPrice, toPrice);
            }

            for (int index = 0; index < rowIndex; index++)
            {
                asset = decimal.Parse(dtgAsks.Rows[index].Cells[1].Value.ToString());
                totalAsset += asset;

                totalBaseAsset += asset * decimal.Parse(dtgAsks.Rows[index].Cells[0].Value.ToString());
            }

            lblTotalSellAsset.Text = string.Format("{0}:{1}", assetText, totalAsset);
            lblTotalSellBaseAsset.Text = string.Format("{0}:{1}", baseAssetText, totalBaseAsset);
        }

        private void dtgBids_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BuyClick();
        }

        private void BuyClick()
        {
            int rowIndex = dtgBids.CurrentCell.RowIndex;
            int lasIndex = dtgBids.Rows.Count - 1 > rowIndex + 1 ? rowIndex + 1 : dtgBids.Rows.Count - 1;
           
            decimal totalAsset = 0;
            decimal totalBaseAsset = 0;
            decimal asset = 0;
            decimal fromPrice = decimal.Parse(dtgBids.Rows[lasIndex].Cells[0].Value.ToString());
            decimal toPrice = decimal.Parse(dtgBids.Rows[rowIndex].Cells[0].Value.ToString());

            if (setSymbolPriceEvent != null)
            {
                setSymbolPriceEvent(Constant.ORDER_BUY, fromPrice, toPrice);
            }

            for (int index = 0; index < rowIndex; index++)
            {
                asset = decimal.Parse(dtgBids.Rows[index].Cells[1].Value.ToString());
                totalAsset += asset;

                totalBaseAsset += asset * decimal.Parse(dtgBids.Rows[index].Cells[0].Value.ToString());
            }

            lblTotalBuyAsset.Text = string.Format("{0}:{1}", assetText, totalAsset);
            lblTotalBuyBaseAsset.Text = string.Format("{0}:{1}", baseAssetText, totalBaseAsset);
        }
    }
}
