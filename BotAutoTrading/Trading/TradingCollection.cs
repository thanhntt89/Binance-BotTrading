using System;
using System.Collections.Generic;
using System.Linq;

namespace BotAutoTrading.Trading
{
    public class TradingCollection
    {
        public List<TradeInfo> tradeInfos;
        public TradingCollection()
        {
            tradeInfos = new List<TradeInfo>();
        }

        public void AddTrade(string symbol, decimal priceChangePercent, decimal openedPrice, decimal deltal)
        {
            var exist = tradeInfos.Where(r => r.Symbol.Equals(symbol)).FirstOrDefault();
            if (exist != null || priceChangePercent <= deltal)
                return;
            tradeInfos.Add(new TradeInfo
            {
                Symbol = symbol,
                PriceChangePercentOpened = priceChangePercent,
                OpenedPrice = openedPrice,
                OpenedTime = DateTime.Now
            });
        }

        public void ClosedTrade(string symbol, decimal priceChangePercent, decimal closedPrice, decimal deltal)
        {
            var exist = tradeInfos.Where(r => r.Symbol.Equals(symbol)).FirstOrDefault();
            if (exist == null)
                return;
            exist.CurrentPriceChangePercentOpened = priceChangePercent;
            decimal closedPercent = priceChangePercent - exist.PriceChangePercentOpened;
            if (Math.Abs(closedPercent) >= deltal && exist.PriceChangePercentOpened != 0)
            {
                exist.PriceChangePercentColosed = priceChangePercent;
                exist.ClosedPrice = closedPrice;
                exist.ClosedTime = DateTime.Now;
            }
        }
    }

    public class TradeInfo
    {
        public string Symbol { get; set; }
        public decimal CurrentPriceChangePercentOpened { get; set; }
        public decimal PriceChangePercentOpened { get; set; }
        public DateTime OpenedTime { get; set; }
        public decimal OpenedPrice { get; set; }
        public decimal ClosedPrice { get; set; }
        public decimal PriceChangePercentColosed { get; set; }
        public DateTime ClosedTime { get; set; }
        public string ProfitPercent
        {
            get
            {
                PriceChangePercentColosed = CurrentPriceChangePercentOpened - PriceChangePercentOpened;
                if (PriceChangePercentColosed != 0 && PriceChangePercentOpened != 0)
                    return PriceChangePercentColosed.ToString();
                else
                    return string.Empty;
            }
        }

        public string Result
        {
            get
            {
                if (PriceChangePercentColosed != 0)
                    return PriceChangePercentColosed < 0 ? "LOSS" : "WIN";
                else
                    return string.Empty;
            }
        }
    }

}
