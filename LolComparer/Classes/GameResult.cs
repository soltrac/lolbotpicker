using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Extensions.MonoHttp;

namespace LolComparer.Classes
{
    class GameResult
    {
        public string DateGame { get; private set; }
        public string ChampionName { get; private set; }
        public bool Win { get; private set; }

        public GameResult(string dateGame, string championName, bool win)
        {
            DateGame = dateGame;
            ChampionName = HttpUtility.HtmlDecode(championName); ;
            Win = win;
        }
    }
}
