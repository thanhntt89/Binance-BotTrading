using Binance.API.Csharp.Client;
using Binance.API.Csharp.Client.Models.Account;
using Binance.API.Csharp.Client.Models.Enums;
using Binance.API.Csharp.Client.Models.Market;
using BotAutoTrading.Market;
using BotAutoTrading.Trading;
using BotAutoTrading.Utils;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace BotAutoTrading
{
    public partial class TradingBot : Form
    {
        private BalanceCollection balanceCollection = new BalanceCollection();
        private BalanceCollection balanceExist = new BalanceCollection();

        private BindingList<OrderBookOffer> Bids;
        private BindingList<OrderBookOffer> Asks;
        private OrderBook orderBook = null;
        private AssetBuyCollection assetBuy = new AssetBuyCollection();
        private AssetSellCollection assetSell = new AssetSellCollection();
        private DataUsers dataUsers = new DataUsers();

        private SymbolPriceCollection symbolPriceCollection = new SymbolPriceCollection();
        private OrdersCollection ordersCollection = new OrdersCollection();
        private OrderHistoryCollection orderHistoryCollection = new OrderHistoryCollection();

        private SymbolCollection symbolCollection = new SymbolCollection();

        public delegate void LoadOrderBookHandle(BindingList<OrderBookOffer> Bids, BindingList<OrderBookOffer> Asks);
        public LoadOrderBookHandle LoadOrderBookEvent;

        private Thread threadAccountInfo;
        private Thread threadTrading;
        private Thread threadLoadOrderBook;

        private string baseAsset = string.Empty;
        private string currentSymbol = string.Empty;

        private bool isLoadAccountInfo = false;
        private bool isStartTrading = false;
        private bool isPauseTrading = false;

        private bool isClosedAllTrade = false;

        private BinanceClient binanceClient;

        public TradingBot()
        {
            InitializeComponent();
        }


        private void TradingBot_Load(object sender, EventArgs e)
        {
            LogUtil.WriteLog(Constant.LogSystemPath, string.Format("Start log:"), true, true);
            LoadConfig();
            SetDataSource();
        }

        private void SetDataSource()
        {           
            LoadDataUser();
            dtgBuy.DataSource = assetBuy.assetInfos;
            dtgSell.DataSource = assetSell.assetInfos;
        }

        private void SaveDataUser()
        {
            try
            {
                dataUsers = new DataUsers();
                dataUsers.AssetBuy = assetBuy.assetInfos;
                dataUsers.AssetSell = assetSell.assetInfos;
                dataUsers.SymbolInfos = symbolCollection.GetSymbolInfos();
                Utilities.SerializeObject<DataUsers>(dataUsers, Constant.DataUserPath);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void LoadDataUser()
        {
            try
            {
                dataUsers = Utilities.DeSerializeObject<DataUsers>(Constant.DataUserPath);
                if (dataUsers == null) return;
                assetBuy.assetInfos = dataUsers.AssetBuy;
                assetSell.assetInfos = dataUsers.AssetSell;
                symbolCollection.symbolInfos = dataUsers.SymbolInfos;

                DisplayTotalAssetBase();
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void LoadConfig()
        {
            binanceClient = new BinanceClient(Constant.apiClient, false);
            btnStartTrading.Text = Constant.TRADING_START_TEXT;
            rdUsdt_CheckedChanged(null, null);
        }


        private void rdUsdt_CheckedChanged(object sender, EventArgs e)
        {
            baseAsset = rdUsdt.Text;
        }

        private void rdBtc_CheckedChanged(object sender, EventArgs e)
        {
            baseAsset = rdBtc.Text;
        }

        private void rdEth_CheckedChanged(object sender, EventArgs e)
        {
            baseAsset = rdEth.Text;
        }

        private void StartAction()
        {
            if (btnStartSystem.Text.Equals(Constant.START_TEXT))
            {
                grpBaseAsset.Enabled = false;
                btnStartSystem.Text = Constant.STOP_TEXT;
                btnStartSystem.ForeColor = Color.Red;
                btnStartTrading.Enabled = true;

                ThreadLoadAccountInfo();
            }
            else
            {
                btnStartTrading_Click(null, null);

                isLoadAccountInfo = false;
                isStartTrading = false;
                btnStartSystem.Text = Constant.START_TEXT;
                grpBaseAsset.Enabled = true;
                btnStartSystem.ForeColor = Color.Green;
                btnStartTrading.Enabled = false;
            }
        }

        private void btnStartSystem_Click(object sender, EventArgs e)
        {
            StartAction();
        }

        private void ThreadLoadAccountInfo()
        {
            if (threadAccountInfo == null)
                threadAccountInfo = new Thread(RunStartAccountInfo);
            if (!threadAccountInfo.IsAlive)
                threadAccountInfo.Start();
        }

        private void RunStartAccountInfo()
        {
            isLoadAccountInfo = true;
            while (isLoadAccountInfo)
            {
                GetAccountInfo();
                Thread.Sleep(3000);
            }

            threadAccountInfo.Interrupt();
            threadAccountInfo = null;
        }

        public void GetAccountInfo()
        {
            if (chkStopLoad.Checked) return;
            try
            {
                symbolPriceCollection.symbolPrices = binanceClient.GetAllPrices().Result;

                AccountInfo accountInfo = binanceClient.GetAccountInfo().Result;
                balanceCollection.Balances = accountInfo.Balances;
                balanceExist.Balances = balanceCollection.Balances;
                if (chkEmpty.Checked)
                    balanceExist.Balances = balanceCollection.GetBalanceExist();

                Invoke(new Action(() =>
                {
                    lblBaseAssetTotal.Text = baseAsset + " FREE";
                    lblBlanaceBaseAsset.Text = balanceExist.GetBalanceFreeByAsset(baseAsset);
                    lblEnquity.Text = string.Format("ENQUITY VALUE({0})", baseAsset);
                    lblAssetEstimate.Text = balanceExist.GetEstimate(baseAsset, symbolPriceCollection);
                    dtgBalance.DataSource = balanceExist.Balances;
                    dtgBalance.Refresh();
                }));

                LoadHistory(balanceExist);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void LoadHistory(BalanceCollection balanceExist)
        {
            string symbol = string.Empty;

            decimal qtyTotal = 0;

            foreach (var item in balanceExist.Balances)
            {
                if (!item.Asset.Equals(baseAsset))
                {
                    symbol = string.Format("{0}{1}", item.Asset, baseAsset);
                    var exist = symbolPriceCollection.symbolPrices.Where(r => r.Symbol.Equals(symbol)).FirstOrDefault();
                    if (exist == null)
                    {
                        continue;
                    }
                    try
                    {
                        ordersCollection.orders = new BindingList<Order>(binanceClient.GetAllOrders(symbol).Result.ToList());
                        qtyTotal = item.Free + item.Locked;
                        lock (orderHistoryCollection)
                            orderHistoryCollection.LoadOrderHistory(ordersCollection.GetOrderByStatus(Constant.ORDER_STATUS_FILLED), baseAsset, qtyTotal);

                        // Load new order 
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
                    }
                }
            }

            Invoke(new Action(() =>
            {
                dtgOrders.DataSource = orderHistoryCollection.orderHistories;
                dtgOrders.Refresh();
            }));
        }

        private void TradingBot_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExistThread();
        }

        private void ExistThread()
        {
            SaveDataUser();

            isLoadAccountInfo = false;
            isStartTrading = false;
        }

        private void btnStartTrading_Click(object sender, EventArgs e)
        {
            StartTrading();
        }

        private void StartTrading()
        {
            if (btnStartTrading.Text.Equals(Constant.TRADING_START_TEXT))
            {
                btnCloseAllTrade.Enabled = true;
                btnStartTrading.Text = Constant.TRADING_STOP_TEXT;
                btnStartTrading.ForeColor = Color.Red;
                btnStartTrading.Enabled = true;

                if (threadLoadOrderBook == null)
                    threadLoadOrderBook = new Thread(StartThreadLoadOrderBook);
                if (!threadLoadOrderBook.IsAlive)
                    threadLoadOrderBook.Start();

                if (threadTrading == null)
                    threadTrading = new Thread(StartThreadTrading);
                if (!threadTrading.IsAlive)
                    threadTrading.Start();
            }
            else
            {
                isStartTrading = false;
                btnStartTrading.Text = Constant.TRADING_START_TEXT;
                btnCloseAllTrade.Enabled = false;
                btnStartTrading.ForeColor = Color.Green;
            }
        }


        private void StartThreadTrading()
        {
            isStartTrading = true;

            while (isStartTrading)
            {
                TradingBuy();
                TradingSell();
                Thread.Sleep(1);
            }

            threadTrading.Interrupt();
            threadTrading = null;
        }

        private void StartThreadLoadOrderBook()
        {
            isStartTrading = true;

            while (isStartTrading)
            {
                LoadOrderBookBuySell();
                LoadOrderBookByCurrentSymbol();
                LoadHistories();
                Thread.Sleep(1);
            }

            threadLoadOrderBook.Interrupt();
            threadLoadOrderBook = null;
        }

        private void TradingSell()
        {
            try
            {
                if (!chkSell.Checked)
                {
                    return;
                }

                foreach (var asset in assetSell.assetInfos)
                {
                    if (asset.SellValues <= 0 || asset.SellFromPrice <= 0 && asset.SellToPrice <= 0) continue;

                    if (asset.SellMarketPrice >= asset.SellFromPrice && asset.SellMarketPrice <= asset.SellToPrice && !chkSellBuyMarket.Checked || chkSellBuyMarket.Checked)
                    {
                        asset.SellValues = asset.SellValues < asset.SellCurrentQty ? asset.SellValues : asset.SellCurrentQty;

                        NewOrder marketOrder = binanceClient.PostNewOrder(asset.SellSymbol
                           , asset.SellValues, asset.SellMarketPrice, OrderSide.SELL, OrderType.MARKET).Result;

                        Invoke(new Action(() =>
                        {
                            if (marketOrder.OrderId != 0)
                            {
                                assetSell.UpdateQty(asset.SellOrderId, asset.SellValues);
                            }
                        }));
                    }
                }

                Invoke(new Action(() =>
                {
                    dtgSell.Refresh();
                }));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void TradingBuy()
        {
            try
            {
                if (!chkBuy.Checked)
                {
                    return;
                }

                foreach (var asset in assetBuy.assetInfos)
                {
                    if (asset.BuyValues <= 0 || asset.BuyCurrentQty <= 0 || !chkBuyMarketPrice.Checked && asset.BuyFromPrice <= 0 && asset.BuyToPrice <= 0)
                        continue;

                    if (!chkBuyMarketPrice.Checked && asset.BuyMarketPrice >= asset.BuyFromPrice && asset.BuyMarketPrice <= asset.BuyToPrice || chkBuyMarketPrice.Checked)
                    {
                        decimal buyQty = asset.BuyCurrentQty;
                        decimal maxBuyQty = asset.BuyValues / asset.BuyMarketPrice;

                        buyQty = buyQty > maxBuyQty ? maxBuyQty : buyQty;

                        decimal buyValues = -buyQty * asset.BuyMarketPrice;                        
                        NewOrder marketOrder = binanceClient.PostNewOrder(asset.BuySymbol
                          , buyQty, asset.BuyMarketPrice, OrderSide.BUY, OrderType.MARKET).Result;

                        Invoke(new Action(() =>
                        {
                            if (marketOrder.OrderId != 0)
                            {
                                assetBuy.UpdateQty(asset.BuyOrderId, buyValues);
                            }
                        }));
                    }
                }

                Invoke(new Action(() =>
                {
                    dtgBuy.Refresh();
                }));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void LoadOrderBookBuySell()
        {
            if (!chkBuy.Checked && !chkSell.Checked || isPauseTrading) return;
            try
            {
                foreach (var symbol in symbolCollection.symbolInfos)
                {
                    var exist = symbolPriceCollection.symbolPrices.Where(r => r.Symbol.Equals(symbol.Symbol)).FirstOrDefault();
                    if (exist == null)
                    {
                        continue;
                    }

                    orderBook = binanceClient.GetOrderBook(symbol.Symbol, 5).Result;

                    if (chkBuy.Checked && orderBook.Asks.Count() > 0)
                        lock (assetBuy)
                        {
                            assetBuy.SetMarketPrice(symbol.Symbol, orderBook.Asks.FirstOrDefault().Price, orderBook.Asks.FirstOrDefault().Quantity);
                        }

                    if (chkSell.Checked && orderBook.Bids.Count() > 0)
                        lock (assetSell)
                        {
                            assetSell.SetMarketPrice(symbol.Symbol, orderBook.Bids.FirstOrDefault().Price, orderBook.Bids.FirstOrDefault().Quantity);
                        }
                }

                Invoke(new Action(() =>
                {
                    if (chkBuy.Checked)
                        dtgBuy.Refresh();
                    if (chkSell.Checked)
                        dtgSell.Refresh();
                }));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void LoadOrderBookByCurrentSymbol()
        {
            if (string.IsNullOrEmpty(currentSymbol))
                return;
            try
            {
                orderBook = binanceClient.GetOrderBook(currentSymbol, 100).Result;
                Bids = new BindingList<OrderBookOffer>(orderBook.Bids.ToList());
                Asks = new BindingList<OrderBookOffer>(orderBook.Asks.ToList());
                if (LoadOrderBookEvent != null)
                    LoadOrderBookEvent(Bids, Asks);
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void LoadHistories()
        {
            try
            {
                foreach (var item in balanceExist.Balances)
                {
                    string symbol = string.Format("{0}{1}", item.Asset, baseAsset);
                    try
                    {
                        lock (orderHistoryCollection)
                        {
                            orderHistoryCollection.UpdateSymbolPrice(symbol, symbolPriceCollection.SymbolPrice(symbol));
                            orderHistoryCollection.UpdateTargetPercent(numWinOrder.Value);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
                    }
                }
                Invoke(new Action(() =>
                {
                    dtgOrders.Refresh();
                }));
            }
            catch (Exception ex)
            {
                LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
            }
        }

        private void dtgOrders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Set the background to red for negative values in the Balance column.
            if (dtgOrders.Columns[e.ColumnIndex].DataPropertyName.Equals
                (colProfitPercent.DataPropertyName) || dtgOrders.Columns[e.ColumnIndex].DataPropertyName.Equals
                (colProfitValue.DataPropertyName))
            {
                decimal intValue;
                if (decimal.TryParse(e.Value.ToString(), out intValue) &&
                    (intValue < 0))
                {
                    e.CellStyle.BackColor = Color.DarkRed;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.SelectionBackColor = Color.DarkRed;
                }
                else
                {
                    e.CellStyle.ForeColor = Color.Yellow;
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }


        private void dtgBalance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colBuy.Index || e.ColumnIndex == colSell.Index)
                BalanceAction(e.ColumnIndex, e.RowIndex);
        }

        private void BalanceAction(int columnIndex, int rowIndex)
        {
            if (rowIndex == -1)
                return;
            Balance balance = (Balance)dtgBalance.CurrentRow.DataBoundItem;
            if (balance == null || balance.Asset.Equals(baseAsset))
                return;
            string symbol = string.Format("{0}{1}", balance.Asset, baseAsset);

            // Check exist symbol
            var exist = symbolPriceCollection.symbolPrices.Where(r => r.Symbol.Equals(symbol)).FirstOrDefault();
            if (exist == null)
            {
                MessageBox.Show(string.Format("Symbol {0} not exist!", symbol), "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add BUY
            if (columnIndex == colBuy.Index)
            {
                decimal basseAssetBalance = balanceCollection.GetBalanceFreeByAssetValue(baseAsset);

                if (basseAssetBalance <= 0)
                {
                    MessageBox.Show(string.Format("{0} balanace is not enough!", baseAsset), "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (assetBuy.CalculateAssetTotal(symbol) == basseAssetBalance)
                {
                    MessageBox.Show(string.Format("Total {0} is set order", symbol), "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chkBuy.Checked)
                {
                    MessageBox.Show("Uncheck BUY please!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                assetBuy.AddOrder(new AssetBuy
                {
                    BuySymbol = symbol,
                    BuyValues = numBudgetOrder.Value
                }, basseAssetBalance);

                symbolCollection.AddSymbol(symbol);
            }
            else if (columnIndex == colSell.Index)
            {
                if (balance.Free <= 0)
                {
                    MessageBox.Show(string.Format("Asset {0} balanace is not enough!", balance.Asset), "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (assetSell.CalculateAssetTotal(symbol) == balance.Free)
                {
                    MessageBox.Show(string.Format("Total asset {0} is set order", symbol), "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chkSell.Checked)
                {
                    MessageBox.Show("Uncheck SELL please!", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                assetSell.AddOrder(new AssetSell
                {
                    SellSymbol = symbol,
                    SellValues = balance.Free
                }, balance.Free);

                symbolCollection.AddSymbol(symbol);
            }
            DisplayTotalAssetBase();
        }

        private void DisplayTotalAssetBase()
        {
            lblTotalBaseAssetSell.Text = string.Format("{0}: {1}", baseAsset, string.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", assetSell.GetTotalBaseAsset()));
            lblTotalBaseAssetBuy.Text = string.Format("{0}: {1}", baseAsset, string.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", assetBuy.GetTotalBaseAsset()));
        }

        private void dtgSell_KeyDown(object sender, KeyEventArgs e)
        {
            if (chkSell.Checked)
            {
                MessageBox.Show(string.Format("Uncheck {0} to delete order", chkSell.Text), "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.KeyCode == Keys.Delete)
            {
                // delete the row from the corresponding database
                foreach (DataGridViewRow row in dtgSell.SelectedRows)
                {
                    string orderId = row.Cells[colSellOrderId.Index].Value == null ? string.Empty : row.Cells[colSellOrderId.Index].Value.ToString();
                    assetSell.RemovedOrder(orderId);
                }
                DisplayTotalAssetBase();
            }
        }

        private void dtgBuy_KeyDown(object sender, KeyEventArgs e)
        {
            if (chkBuy.Checked)
            {
                MessageBox.Show(string.Format("Uncheck {0} to delete order", chkBuy.Text), "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (e.KeyCode == Keys.Delete)
            {
                // delete the row from the corresponding database
                foreach (DataGridViewRow row in dtgBuy.SelectedRows)
                {
                    string orderId = row.Cells[colBuyOrderId.Index].Value == null ? string.Empty : row.Cells[colBuyOrderId.Index].Value.ToString();
                    assetBuy.RemovedOrder(orderId);
                }

                DisplayTotalAssetBase();
            }
        }

        private void dtgSell_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chkSell.Checked)
                return;
            string orderId = dtgSell.Rows[e.RowIndex].Cells[colSellOrderId.Index].Value == null ? string.Empty : dtgSell.Rows[e.RowIndex].Cells[colSellOrderId.Index].Value.ToString();
            currentSymbol = assetSell.GetAssetSell(orderId).SellSymbol;
            DisplayOrderBook(currentSymbol, Constant.ORDER_SELL);
        }

        private void DisplayOrderBook(string symbol, string orderType)
        {
            isPauseTrading = true;

            OrderBookDisplay orderBookDisplay = new OrderBookDisplay(symbol, orderType, baseAsset);
            LoadOrderBookEvent += orderBookDisplay.LoadOrderBook;
            orderBookDisplay.setSymbolPriceEvent += SetSymbolPrice;
            orderBookDisplay.ShowDialog();

            isPauseTrading = false;
            currentSymbol = string.Empty;
        }

        private void dtgBuy_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (chkBuy.Checked)
                return;
            string orderId = dtgBuy.Rows[e.RowIndex].Cells[colBuyOrderId.Index].Value == null ? string.Empty : dtgBuy.Rows[e.RowIndex].Cells[colBuyOrderId.Index].Value.ToString();
            currentSymbol = assetBuy.GetAssetBuy(orderId).BuySymbol;
            DisplayOrderBook(currentSymbol, Constant.ORDER_BUY);
        }

        public void SetSymbolPrice(string orderType, decimal fromPrice, decimal toPrice)
        {
            if (orderType.Contains(Constant.ORDER_BUY))
            {
                if (dtgBuy.Rows.Count == 0) return;
                dtgBuy.CurrentRow.Cells[colBuyFromPrice.Name].Value = fromPrice;
                dtgBuy.CurrentRow.Cells[colBuyToPrice.Name].Value = toPrice;
            }
            else if (orderType.Contains(Constant.ORDER_SELL))
            {
                if (dtgSell.Rows.Count == 0) return;
                dtgSell.CurrentRow.Cells[colSellFromPrice.Name].Value = fromPrice;
                dtgSell.CurrentRow.Cells[colSellToPrice.Name].Value = toPrice;
            }
        }

        private void chkSell_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgSell.Rows)
            {
                item.ReadOnly = chkSell.Checked;
            }
            chkSellBuyMarket.Enabled = !chkSell.Checked;
            dtgSell.AllowUserToDeleteRows = !chkSell.Checked;
        }

        private void chkBuy_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgBuy.Rows)
            {
                item.ReadOnly = chkBuy.Checked;
            }

            chkBuyMarketPrice.Enabled = !chkBuy.Checked;
            dtgBuy.AllowUserToDeleteRows = !chkBuy.Checked;
        }

        private void btnCloseAllTrade_Click(object sender, EventArgs e)
        {
            var rst = MessageBox.Show("Confirm closed all trade?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rst != DialogResult.Yes)
                isClosedAllTrade = false;
        }

        private void chkBuyMarketPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBuyMarketPrice.Checked)
            {
                var rst = MessageBox.Show("Confirm BUY marketprice?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rst != DialogResult.Yes)
                    chkBuyMarketPrice.Checked = false;
            }
        }

        private void chkSellBuyMarket_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSellBuyMarket.Checked)
            {
                var rst = MessageBox.Show("Confirm SELL marketprice?", "Warnning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rst != DialogResult.Yes)
                    chkSellBuyMarket.Checked = false;
            }
        }

        private void txtAssetSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    if (!string.IsNullOrWhiteSpace(txtAssetSearch.Text))
                    {
                        dtgBalance.DataSource = balanceCollection.SearchAsset(txtAssetSearch.Text);
                    }
                    else
                    {
                        dtgBalance.DataSource = balanceExist.Balances;
                    }
                }
                catch (Exception ex)
                {
                    LogUtil.WriteLog(Constant.LogSystemPath, string.Format("{0}: {1}", MethodBase.GetCurrentMethod().Name, ex.Message));
                }
            }
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.OpenFileByNotepad(Constant.LogSystemPath);
        }

        private void dtgBuy_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DisplayTotalAssetBase();
        }

        private void dtgSell_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DisplayTotalAssetBase();
        }
    }
}
