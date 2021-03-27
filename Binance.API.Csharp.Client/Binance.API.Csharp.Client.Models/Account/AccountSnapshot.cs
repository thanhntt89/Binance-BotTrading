using Binance.API.Csharp.Client.Models.Market;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Binance.API.Csharp.Client.Models.Account
{
    public class AccountSnapshot
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("msg")]
        public string Msg { get; set; }
        [JsonProperty("snapshotVos")]
        public List<SnapshotVo> SnapshotVos { get; set; }
    }

    public class Data
    {
        [JsonProperty("totalAssetOfBtc")]
        public decimal TotalAssetOfBtc { get; set; }
        [JsonProperty("balances")]
        public IEnumerable<Balance> Balances { get; set; }
    }

    public class SnapshotVo
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("updateTime")]
        public object UpdateTime { get; set; }
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public class AccountSnapshotCollection
    {
        public List<SnapshotVo> SnapshotVos;
        public AccountSnapshotCollection()
        {
            SnapshotVos = new List<SnapshotVo>();
        }

        public string EstimateBTC()
        {
            decimal values = 0;

            foreach (var item in SnapshotVos)
            {
                values += item.Data.TotalAssetOfBtc;
            }

            return values.ToString();
        }
    }


}
