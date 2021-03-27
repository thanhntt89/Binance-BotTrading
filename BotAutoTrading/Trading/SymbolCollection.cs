using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotAutoTrading.Trading
{
    public class SymbolCollection
    {
        public BindingList<SymbolInfo> symbolInfos;
        public SymbolCollection()
        {
            symbolInfos = new BindingList<SymbolInfo>();
        }

        public void AddSymbol(string symbol)
        {
            var exist = GetSymbol(symbol);
            if (exist != null) return;
            symbolInfos.Add(new SymbolInfo
            {
                Symbol = symbol
            });
        }

        public SymbolInfo GetSymbol(string symbol)
        {
            var exist = symbolInfos.Where(r => r.Symbol.Equals(symbol)).FirstOrDefault();
            if (exist != null)
                return exist;
            return null;
        }

        public BindingList<SymbolInfo> GetSymbolInfos()
        {
            return new BindingList<SymbolInfo>(symbolInfos.Distinct().ToList());           
        }
    }
    [Serializable]
    public class SymbolInfo
    {
        public string Symbol { get; set; }
    }
}
