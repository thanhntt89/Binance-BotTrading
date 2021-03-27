using Binance.API.Csharp.Client.Models.Account;
using System.ComponentModel;
using System.Linq;

namespace BotAutoTrading.Trading
{
    public class OrdersCollection
    {
        public BindingList<Order> orders;
        public OrdersCollection()
        {
            orders = new BindingList<Order>();
        }

        public BindingList<Order> GetOrderByStatus(string orderStatus)
        {
            return new BindingList<Order>(orders.Where(r => r.Status.ToUpper().Equals(orderStatus) & r.Price != 0).OrderByDescending(r => r.Time).ToList());
        }
    }

}
