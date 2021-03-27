using Binance.API.Csharp.Client;
using System.Windows.Forms;

namespace BotAutoTrading
{
    public class Constant
    {
        public static string DataUserPath = string.Format("{0}\\{1}", Application.StartupPath, "DataUser.jimmii88");
        public static string LogSystemPath = string.Format("{0}\\{1}", Application.StartupPath, "LogSystem.txt");
        public static string START_TEXT = "START";
        public static string STOP_TEXT = "STOP";
        public static string TRADING_START_TEXT = "TRADING START";
        public static string TRADING_STOP_TEXT = "TRADING STOP";
        public static string ORDER_BUY = "ORDER_BUY";
        public static string ORDER_SELL = "ORDER_SELL";
        public static string ORDER_STATUS_FILLED = "FILLED";
        public static string ORDER_STATUS_NEW = "NEW";
        public static ApiClient apiClient = new ApiClient("G3DZ0x8akBBj2uRA5GyiwOPFt8vJAsHbilHdSISnrMiuzOi05dxr9w4pQVMnXFwWFl", "oHF4DInapL14axha86MYo8BSAvkCwHZZF7fXdtxpfxGzTwRGH6ptJvZqR0SSKUsYx2");
    }
}
