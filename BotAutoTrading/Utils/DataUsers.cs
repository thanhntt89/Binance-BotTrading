using BotAutoTrading.Trading;
using System;
using System.ComponentModel;

namespace BotAutoTrading.Utils
{
    [Serializable]
    public class DataUsers
    {
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public BindingList<AssetSell> AssetSell { get; set; }
        public BindingList<AssetBuy> AssetBuy { get; set; }
        public BindingList<SymbolInfo> SymbolInfos { get; set; }
    }
}
