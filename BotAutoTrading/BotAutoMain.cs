using Binance.API.Csharp.Client;
using Binance.API.Csharp.Client.Models.Account;
using Binance.API.Csharp.Client.Models.Enums;
using Binance.API.Csharp.Client.Models.Market;
using BotAutoTrading.Trading;
using BotAutoTrading.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Balance = Binance.API.Csharp.Client.Models.Market.Balance;

namespace BotAutoTrading
{
    public partial class BotAutoMain : Form
    {
        private ApiClient apiClient = new ApiClient("G3DZ0x8akBBj2uRA5GyiwOPFt8vJAsHbildSISnriuzOi05dxr9w4pQVMnXFwWFl", "oHF4DInapL14axha86MYoBSAvkCwHZZF7fXdtxpfxGzwRGH6ptJvZqR0SSKUsYx2");
        private BinanceClient binanceClient;

        private bool isLoadAccountInfo = false;
        public bool isStartTrading = false;

        private int currentRowIndex = -1;
        private int currentColumnIndex = -1;
        private List<Balance> Balances;
        private List<OrderBookOffer> Bids;
        private List<OrderBookOffer> Asks;
        private string assetText = string.Empty;
        private string baseAssetText = string.Empty;
        private Thread threadTrading;
        private TradingCollection tradingCollection = new TradingCollection();
        private IEnumerable<PriceChangeInfo> allTickersInfo;

        private string currentDateTime = DateTime.Now.ToString("yyyyMMdd");

        public BotAutoMain()
        {
            InitializeComponent();
            binanceClient = new BinanceClient(apiClient, false);
        }

        private void StartThreadAccountInfo()
        {
            isLoadAccountInfo = true;
            while (isLoadAccountInfo)
            {
                GetAccountInfo();
                GetPriceChange24H();
                Thread.Sleep(5000);
            }
        }

        public void GetPriceChange24H()
        {
            try
            {
                allTickersInfo = binanceClient.GetPriceChange24H().Result;

                foreach (PriceChangeInfo item in allTickersInfo)
                {
                    if (!item.Symbol.Contains(baseAssetText) || string.IsNullOrEmpty(baseAssetText))
                        continue;
                    tradingCollection.AddTrade(item.Symbol, item.PriceChangePercent, item.AskPrice, 10);
                    tradingCollection.ClosedTrade(item.Symbol, item.PriceChangePercent, item.BidPrice, 3);
                }

                Invoke(new Action(() =>
                {
                    dtgTradingList.DataSource = tradingCollection.tradeInfos;
                    //ExportData();
                }));
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void ExportData()
        {
            if (!currentDateTime.Equals(DateTime.Now.ToString("yyyyMMdd")))
            {
                string filePath = string.Format("{0}\\{1}_{2}.xls", Application.StartupPath, "Result_trading", DateTime.Now.ToString("ddMMyyyy"));
                ExportToExcell.Export(dtgTradingList, filePath);
            }
        }

        public void GetAccountInfo()
        {
            AccountInfo accountInfo = binanceClient.GetAccountInfo().Result;
            Balances = accountInfo.Balances.ToList();
            if (chkEmpty.Checked)
                Balances = accountInfo.Balances.Where(b => b.Free != 0 || b.Locked != 0).ToList();
            Invoke(new Action(() =>
            {
                dtgAccountBalance.DataSource = Balances;
            }));
        }

        private void btnStarTrading_Click(object sender, EventArgs e)
        {
            if (threadTrading == null)
                threadTrading = new Thread(StartThreadTrading);

            if (isStartTrading)
            {
                btnStarTrading.Text = "Start trading";
                isStartTrading = false;
                grpBaseAsset.Enabled = true;
                dtgAccountBalance.Enabled = true;
            }
            else
            {
                btnStarTrading.Text = "Stop trading";
                grpBaseAsset.Enabled = false;
                dtgAccountBalance.Enabled = false;
                threadTrading.Start();
            }
        }

        private void StartThreadTrading()
        {
            isStartTrading = true;

            while (isStartTrading)
            {
                LoadOrderBook();
                TradingBuy();
                TradingSell();
                Thread.Sleep(5);
            }

            threadTrading.Interrupt();
            threadTrading = null;
        }

        private void TradingSell()
        {
            try
            {
                if (string.IsNullOrEmpty(txtSellPriceFrom.Text) && string.IsNullOrEmpty(txtSellPriceTo.Text) || string.IsNullOrEmpty(txtBudgetSell.Text) || !chkAutoSell.Checked)
                {
                    return;
                }

                decimal currentSellPrice = decimal.Parse(dgvBuyOrder.Rows[0].Cells[0].Value.ToString());
                decimal currentSellQuantity = decimal.Parse(dgvBuyOrder.Rows[0].Cells[1].Value.ToString());

                decimal sellQuantity = 0;
                decimal sellPriceFrom = 0;
                decimal sellPriceTo = 0;

                if (!string.IsNullOrEmpty(txtBudgetSell.Text))
                    sellQuantity = decimal.Parse(txtBudgetSell.Text);

                if (sellQuantity == 0) return;

                if (!string.IsNullOrEmpty(txtSellPriceFrom.Text))
                    sellPriceFrom = decimal.Parse(txtSellPriceFrom.Text);

                if (!string.IsNullOrEmpty(txtSellPriceTo.Text))
                    sellPriceTo = decimal.Parse(txtSellPriceTo.Text);

                if (currentSellPrice >= sellPriceFrom && currentSellPrice <= sellPriceTo)
                {
                    sellQuantity = sellQuantity < currentSellQuantity ? sellQuantity : currentSellQuantity;

                    NewOrder sellMarketOrder = binanceClient.PostNewOrder(lblBookSymbol.Text, sellQuantity, currentSellPrice, OrderSide.SELL, OrderType.MARKET).Result;
                    Invoke(new Action(() =>
                    {
                        if (sellMarketOrder.OrderId != 0)
                        {
                            txtLog.AppendText(string.Format("SELL {0} - Price: {1} - Quantity: {2} - Value: {3}\n", lblBookSymbol.Text, currentSellPrice, sellQuantity, currentSellPrice * sellQuantity));
                            txtBudgetSell.Text = (decimal.Parse(txtBudgetSell.Text) - sellQuantity).ToString();
                        }
                    }));

                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void TradingBuy()
        {
            try
            {
                if (string.IsNullOrEmpty(txtBuyPriceFrom.Text) && string.IsNullOrEmpty(txtBuyPriceTo.Text) || string.IsNullOrEmpty(txtBudgetBuy.Text) || !chkAutoBuy.Checked)
                {
                    return;
                }

                decimal currentBuyPrice = decimal.Parse(dgvSellOrder.Rows[0].Cells[0].Value.ToString());
                decimal currentBuyQuantity = decimal.Parse(dgvSellOrder.Rows[0].Cells[1].Value.ToString());

                decimal buyQuantity = 0;
                decimal buyPriceFrom = 0;
                decimal buyPriceTo = 0;

                if (!string.IsNullOrEmpty(txtBudgetBuy.Text))
                    buyQuantity = decimal.Parse(txtBudgetBuy.Text);

                if (buyQuantity == 0) return;

                if (!string.IsNullOrEmpty(txtBuyPriceFrom.Text))
                    buyPriceFrom = decimal.Parse(txtBuyPriceFrom.Text);

                if (!string.IsNullOrEmpty(txtBuyPriceTo.Text))
                    buyPriceTo = decimal.Parse(txtBuyPriceTo.Text);

                if (currentBuyPrice >= buyPriceFrom && currentBuyPrice <= buyPriceTo)
                {
                    buyQuantity = buyQuantity < currentBuyQuantity ? buyQuantity : currentBuyQuantity;

                    NewOrder buyMarketOrder = binanceClient.PostNewOrder(lblBookSymbol.Text, buyQuantity, currentBuyPrice, OrderSide.BUY, OrderType.MARKET).Result;

                    Invoke(new Action(() =>
                    {
                        if (buyMarketOrder.OrderId != 0)
                        {
                            txtLog.AppendText(string.Format("BUY {0} - Price: {1} - Quantity: {2} - Value: {3}\n", lblBookSymbol.Text, currentBuyPrice, buyQuantity, currentBuyPrice * buyQuantity));
                            txtBudgetBuy.Text = (decimal.Parse(txtBudgetBuy.Text) - buyQuantity).ToString();
                        }
                    }));
                }
            }
            catch (Exception ex)
            {
                LogException(ex);
            }
        }

        private void LoadOrderBook()
        {
            if (string.IsNullOrEmpty(lblBookSymbol.Text) || chkStopLoad.Checked)
                return;
            OrderBook orderBook = binanceClient.GetOrderBook(lblBookSymbol.Text, 50).Result;
            Bids = orderBook.Bids.ToList();
            Asks = orderBook.Asks.ToList();

            Invoke(new Action(() =>
            {
                dgvBuyOrder.DataSource = Bids;
                dgvSellOrder.DataSource = Asks;
            }));
        }

        private void BotAutoMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            isLoadAccountInfo = false;
            isStartTrading = false;
        }

        private void BotAutoMain_Load(object sender, EventArgs e)
        {
            LoadSymbolTrading();
            Thread threadTrading = new Thread(StartThreadAccountInfo);
            threadTrading.Start();
        }

        private void dtgAccountBalance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentColumnIndex = e.ColumnIndex;
            currentRowIndex = e.RowIndex;
            LoadSymbolTrading();
        }

        private void LoadSymbolTrading()
        {
            lblSymbol.Text = string.Empty;
            txtBudgetBuy.Text = string.Empty;
            txtBudgetSell.Text = string.Empty;
            lblBookSymbol.Text = string.Empty;

            lblTotalBuyAsset.Text = string.Empty;
            lblTotalBuyBaseAsset.Text = string.Empty;

            lblTotalSellAsset.Text = string.Empty;
            lblTotalSellBaseAsset.Text = string.Empty;

            baseAssetText = rdUsdt.Checked ? rdUsdt.Text : rdBtc.Checked ? rdBtc.Text : rdEth.Text;
            if (dtgAccountBalance.CurrentCell == null || currentRowIndex == -1) return;
            assetText = dtgAccountBalance.Rows[currentRowIndex].Cells[colSymbol.Index].Value.ToString();
            if (baseAssetText.Equals(assetText))
                return;

            lblSymbol.Text = string.Format("{0}/{1}", assetText, baseAssetText);
            lblBookSymbol.Text = string.Format("{0}{1}", assetText, baseAssetText);

            lblTotalBuyAsset.Text = assetText;
            lblTotalBuyBaseAsset.Text = baseAssetText;

            lblTotalSellAsset.Text = assetText;
            lblTotalSellBaseAsset.Text = baseAssetText;

            var existBaseAsset = Balances.Where(r => r.Asset.Equals(baseAssetText)).FirstOrDefault();
            if (existBaseAsset != null)
            {
                txtBudgetBuy.Text = existBaseAsset.Free.ToString();
            }

            var existasset = Balances.Where(r => r.Asset.Equals(assetText)).FirstOrDefault();
            if (existasset != null)
            {
                txtBudgetSell.Text = existasset.Free.ToString();
            }
        }

        private void dtgAccountBalance_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (currentColumnIndex != -1 && currentRowIndex != -1)
                dtgAccountBalance.CurrentCell = dtgAccountBalance.Rows[currentRowIndex].Cells[currentColumnIndex];
        }

        private void rdUsdt_CheckedChanged(object sender, EventArgs e)
        {
            LoadSymbolTrading();
        }

        private void rdBtc_CheckedChanged(object sender, EventArgs e)
        {
            LoadSymbolTrading();
        }

        private void rdEth_CheckedChanged(object sender, EventArgs e)
        {
            LoadSymbolTrading();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtLog.Clear();
        }

        private void dgvBuyOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvBuyOrder.CurrentCell.RowIndex;
            int lasIndex = dgvBuyOrder.Rows.Count - 1 > rowIndex + 1 ? rowIndex + 1 : dgvBuyOrder.Rows.Count - 1;
            if (!chkAutoBuy.Checked)
            {
                txtBuyPriceFrom.Text = dgvBuyOrder.Rows[lasIndex].Cells[0].Value.ToString();
                txtBuyPriceTo.Text = dgvBuyOrder.Rows[rowIndex].Cells[0].Value.ToString();
            }
            decimal totalAsset = 0;
            decimal totalBaseAsset = 0;
            decimal asset = 0;

            for (int index = 0; index < rowIndex; index++)
            {
                asset = decimal.Parse(dgvBuyOrder.Rows[index].Cells[1].Value.ToString());
                totalAsset += asset;

                totalBaseAsset += asset * decimal.Parse(dgvBuyOrder.Rows[index].Cells[0].Value.ToString());
            }

            lblTotalBuyAsset.Text = string.Format("{0}:{1}", assetText, totalAsset);
            lblTotalBuyBaseAsset.Text = string.Format("{0}:{1}", baseAssetText, totalBaseAsset);
        }

        private void dgvSellOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dgvSellOrder.CurrentCell.RowIndex;
            int lasIndex = dgvSellOrder.Rows.Count - 1 > rowIndex + 1 ? rowIndex + 1 : dgvSellOrder.Rows.Count - 1;

            if (!chkAutoSell.Checked)
            {
                txtSellPriceFrom.Text = dgvSellOrder.Rows[rowIndex].Cells[0].Value.ToString();
                txtSellPriceTo.Text = dgvSellOrder.Rows[lasIndex].Cells[0].Value.ToString();
            }
            decimal totalAsset = 0;
            decimal totalBaseAsset = 0;
            decimal asset = 0;

            for (int index = 0; index < rowIndex; index++)
            {
                asset = decimal.Parse(dgvSellOrder.Rows[index].Cells[1].Value.ToString());
                totalAsset += asset;

                totalBaseAsset += asset * decimal.Parse(dgvSellOrder.Rows[index].Cells[0].Value.ToString());
            }

            lblTotalSellAsset.Text = string.Format("{0}:{1}", assetText, totalAsset);
            lblTotalSellBaseAsset.Text = string.Format("{0}:{1}", baseAssetText, totalBaseAsset);
        }


        private void LogException(Exception ex)
        {
            Invoke(new Action(() =>
            {
                txtLog.AppendText(string.Format("Exception: {0}\n", ex.Message));
            }));
        }

        private void chkAutoBuy_CheckedChanged(object sender, EventArgs e)
        {
            grpBuySetting.Enabled = !chkAutoBuy.Checked;
        }

        private void chkAutoSell_CheckedChanged(object sender, EventArgs e)
        {
            grpSellSetting.Enabled = !chkAutoSell.Checked;
        }
    }
}
