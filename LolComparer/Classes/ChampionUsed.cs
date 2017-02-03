using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using RestSharp.Extensions.MonoHttp;

namespace LolComparer.Classes
{
    class ChampionUsed
    {
        public string ChampionName { get; private set; }
        public double Kda { get; private set; }
        public int WinRate { get; private set; }
        public int Played { get; private set; }

        public ChampionUsed(string championName, string kda, string winRate, string played)
        {
            ChampionName = HttpUtility.HtmlDecode(championName);
            Kda = Convert.ToDouble(kda.Split(':')[0].Replace(".", Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));
            WinRate = Convert.ToInt32(winRate.Substring(0, winRate.Length - 1));
            Played = Convert.ToInt32(played.Split()[0]);
        }
    }
}
