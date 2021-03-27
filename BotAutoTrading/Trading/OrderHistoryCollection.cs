using Binance.API.Csharp.Client.Models.Account;
using BotAutoTrading.Utils;
using System;
using System.ComponentModel;
using System.Linq;
namespace BotAutoTrading.Trading
{
    public class OrderHistoryCollection
    {
        public BindingList<OrderHistories> orderHistories;
        public OrderHistoryCollection()
        {
            orderHistories = new BindingList<OrderHistories>();
        }

        public void LoadOrderHistory(BindingList<Order> orders, string baseAsset, decimal qtyTotal)
        {
            decimal total = 0;
            foreach (var order in orders)
            {
                // Qty buy > current total break
                if (order.ExecutedQty <= qtyTotal)
                {
                    total += order.ExecutedQty;
                    AddOrder(order);
                }

                if (total >= qtyTotal || order.ExecutedQty > qtyTotal)
                    break;
            }
        }

        public void AddOrder(Order order)
        {
            if (!OrderExist(order.OrderId))
            {
                orderHistories.Add(new OrderHistories
                {
                    OrderId = order.OrderId,
                    Symbol = order.Symbol,
                    OpenedPrice = order.Price,
                    OpenedTime = Utilities.TimeSpanToDate(order.Time).ToString("dd/MM/yyyy HH:mm:ss"),
                    Qty = order.ExecutedQty
                });
            }
        }

        public void UpdateSymbolPrice(string symbol, decimal currentPrice)
        {
            var exist = GetOrderHistoriesBySymbol(symbol);
            if (exist != null)
                exist.Select(r => r.CurrentPrice = currentPrice).ToList();
        }

        public void UpdateTargetPercent(decimal targetPercent)
        {
            orderHistories.Select(r => r.TargetPercent = targetPercent).ToList();
        }

        public BindingList<OrderHistories> GetOrderHistoriesBySymbol(string symbol)
        {
            return new BindingList<OrderHistories>(orderHistories.Where(r => r.Symbol.Equals(symbol)).ToList());
        }

        public OrderHistories GetOrderByOrderId(int orderId)
        {
            var exist = orderHistories.Where(r => r.OrderId == orderId).FirstOrDefault();
            if (exist != null)
                return exist;
            return null;
        }

        private bool OrderExist(int orderId)
        {
            var exist = orderHistories.Where(r => r.OrderId == orderId).FirstOrDefault();
            if (exist != null)
                return true;
            return false;
        }
    }

    public class OrderHistories
    {
        public int OrderId { get; set; }
        public string Symbol { get; set; }
        public string OpenedTime { get; set; }
        public decimal Qty { get; set; }
        public decimal OpenedPrice { get; set; }
        public decimal Value { get { return Math.Round(Qty * OpenedPrice, 4); } }
        public decimal ProfitValue { get { return Math.Round(Value * ProfitPercent / 100, 2); } }
        public decimal CurrentPrice { get; set; }
        public decimal ProfitPercent { get { return CurrentPrice == 0 ? 0 : Math.Round((CurrentPrice - OpenedPrice) / OpenedPrice, 2) * 100; } }
        public decimal TargetPercent { get; set; }

        public string Action { get { return "SELL"; } }
    }

}
