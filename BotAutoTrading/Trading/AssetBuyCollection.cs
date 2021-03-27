using System;
using System.ComponentModel;
using System.Linq;

namespace BotAutoTrading.Trading
{
    public class AssetBuyCollection
    {
        public BindingList<AssetBuy> assetInfos;

        public AssetBuyCollection()
        {
            assetInfos = new BindingList<AssetBuy>();
        }

        public void AddOrder(AssetBuy assetBuy, decimal maxBaseAsset)
        {
            decimal maxValue = maxBaseAsset - CalculateAssetTotal(assetBuy.BuySymbol);
            assetBuy.BuyValues = assetBuy.BuyValues > maxValue ? maxValue : assetBuy.BuyValues;
            if (assetBuy.BuyValues > 0)
            {
                assetBuy.BuyOrderId = Guid.NewGuid().ToString();
                assetInfos.Add(assetBuy);
            }
        }

        public void RemovedOrder(string orderId)
        {
            var exist = GetAssetBuy(orderId);
            if (exist != null)
                assetInfos.Remove(exist);
        }

        public AssetBuy GetAssetBuy(string orderId)
        {
            var exist = assetInfos.Where(r => r.BuyOrderId.Equals(orderId)).FirstOrDefault();
            if (exist != null)
                return exist;
            return null;
        }

        public decimal CalculateAssetTotal(string symbol)
        {
            decimal total = 0;
            var exist = assetInfos.Where(r => r.BuySymbol.Equals(symbol)).ToList();
            foreach (var item in exist)
            {
                total += item.BuyValues;
            }
            return total;
        }

        public void SetMarketPrice(string symbol, decimal marketPrice, decimal qty)
        {
            assetInfos.Where(r => r.BuySymbol.Equals(symbol)).ToList().ForEach(r => { r.BuyMarketPrice = marketPrice; r.BuyCurrentQty = qty; });
        }

        public void UpdateQty(string orderId, decimal buyQty)
        {
            var exsit = GetAssetBuy(orderId);

            if (exsit != null)
            {
                if (exsit.BuyValues <= 0)
                {
                    exsit.BuyValues = 0;
                    return;
                }
                exsit.BuyValues += buyQty;
            }
        }

        public decimal GetTotalBaseAsset()
        {
            decimal totalBase = 0;
            foreach (var item in assetInfos)
            {
                totalBase += item.BuyValues;
            }

            return totalBase;
        }
    }

    [Serializable]
    public class AssetBuy
    {
        public string BuyOrderId { get; set; }
        public string BuySymbol { get; set; }
        public decimal BuyValues { get; set; }
        public decimal BuyFromPrice { get; set; }
        public decimal BuyToPrice { get; set; }
        public decimal BuyMarketPrice { get; set; }
        public decimal BuyCurrentQty { get; set; }
        public string BuyButtonAction { get; set; }
    }
}
