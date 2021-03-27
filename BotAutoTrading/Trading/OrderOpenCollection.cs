using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotAutoTrading.Trading
{
    public class OrderOpenCollection
    {

    }

    public class OrderOpen
    {
        public int OpenOrderId { get; set; }
        public string OpenSymbol { get; set; }
        public DateTime OpenOrderTime { get; set; }
        public decimal OpenOrderSize { get; set; }
        public decimal OpenOrderValues { get; set; }
        public decimal OpenOrderPrice { get; set; }
        public string OpenOrderAction { get; set; }
    }
}