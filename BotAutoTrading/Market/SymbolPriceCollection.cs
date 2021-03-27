using Binance.API.Csharp.Client.Models.Market;
using System.Collections.Generic;
using System.Linq;

namespace BotAutoTrading.Market
{
    public class SymbolPriceCollection
    {
        public IEnumerable<SymbolPrice> symbolPrices;

        public SymbolPriceCollection()
        {
            symbolPrices = new List<SymbolPrice>();
        }

        public decimal SymbolPrice(string symbol)
        {
            var exist = symbolPrices.Where(r => r.Symbol.Equals(symbol)).FirstOrDefault();
            if (exist != null)
                return exist.Price;
            return 0;
        }
    }
}
