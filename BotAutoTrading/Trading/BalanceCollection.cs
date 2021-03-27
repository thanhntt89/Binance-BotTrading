using Binance.API.Csharp.Client.Models.Market;
using BotAutoTrading.Market;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BotAutoTrading.Trading
{
    public class BalanceCollection
    {
        public BindingList<Balance> Balances;

        public BalanceCollection()
        {
            Balances = new BindingList<Balance>();
        }

        public string GetBalanceFreeByAsset(string asset)
        {
            return GetBalanceFreeByAssetValue(asset).ToString();
        }

        public decimal GetBalanceFreeByAssetValue(string asset)
        {
            var exist = Balances.Where(r => r.Asset.Equals(asset) & r.Free != 0).FirstOrDefault();
            if (exist != null)
                return exist.Free;
            return 0;
        }

        public string GetEstimate(string asset, SymbolPriceCollection symbolPriceCollection)
        {
            decimal estimate = 0;
            string symbol = string.Empty;
            var coins = Balances.Where(r => r.Free != 0 || r.Locked != 0);

            foreach (var item in coins)
            {
                if (!asset.Equals(item.Asset))
                {
                    symbol = string.Format("{0}{1}", item.Asset, asset);
                    estimate += (item.Free + item.Locked) * symbolPriceCollection.SymbolPrice(symbol);
                }
            }

            return Math.Round(estimate, 4).ToString();
        }

        public BindingList<Balance> GetBalanceExist()
        {
            return new BindingList<Balance>(Balances.Where(r => r.Free != 0 || r.Locked != 0).ToList());
        }
              

        public BindingList<Balance> SearchAsset(string asset)
        {
            return new BindingList<Balance>(Balances.Where(r => r.Asset.Equals(asset.ToUpper())).ToList());
        }
    }

}
