using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace BotAutoTrading.Trading
{
    public class AssetSellCollection
    {
        public BindingList<AssetSell> assetInfos;

        public AssetSellCollection()
        {
            assetInfos = new BindingList<AssetSell>();
        }

        public void AddOrder(AssetSell assetSell, decimal maxAsset)
        {
            assetSell.SellValues = maxAsset - CalculateAssetTotal(assetSell.SellSymbol);
            if (assetSell.SellValues > 0)
            {
                assetSell.SellOrderId = Guid.NewGuid().ToString();
                assetInfos.Add(assetSell);
            }
        }

        public void RemovedOrder(string orderId)
        {
            var exist = GetAssetSell(orderId);
            if (exist != null)
                assetInfos.Remove(exist);
        }

        public AssetSell GetAssetSell(string orderId)
        {
            var exist = assetInfos.Where(r => r.SellOrderId.Equals(orderId)).FirstOrDefault();
            if (exist != null)
                return exist;
            return null;
        }

        public decimal CalculateAssetTotal(string symbol)
        {
            decimal total = 0;
            var exist = assetInfos.Where(r => r.SellSymbol.Equals(symbol)).ToList();
            foreach (var item in exist)
            {
                total += item.SellValues;
            }
            return total;
        }

        public void SetMarketPrice(string symbol, decimal marketPrice, decimal qty)
        {
            assetInfos.Where(r => r.SellSymbol.Equals(symbol)).ToList().ForEach(r => { r.SellMarketPrice = marketPrice; r.SellCurrentQty = qty; });
        }

        public void UpdateQty(string orderId, decimal buyQty)
        {
            var exsit = GetAssetSell(orderId);
            if (exsit != null)
                exsit.SellValues -= buyQty;
        }

        public decimal GetTotalBaseAsset()
        {
            decimal totalBase = 0;
            foreach (var item in assetInfos)
            {
                totalBase += item.SellValues * item.SellFromPrice;
            }

            return totalBase;
        }
    }

    [Serializable]
    public class AssetSell
    {
        public string SellOrderId { get; set; }
        public string SellSymbol { get; set; }
        public decimal SellValues { get; set; }
        public decimal SellFromPrice { get; set; }
        public decimal SellToPrice { get; set; }
        public decimal SellMarketPrice { get; set; }
        public decimal SellCurrentQty { get; set; }
        public string SellButtonAction { get; set; }
    }
}
