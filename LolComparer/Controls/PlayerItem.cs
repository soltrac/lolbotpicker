using System;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LolComparer.Classes;
using RestSharp;

namespace LolComparer.Controls
{
    public partial class PlayerItem : UserControl
    {
        private const string Server = "euw";

        private string _summonerName;

        public PlayerItem()
        {
            InitializeComponent();
        }

        public void AnalyzeSummoner(string summoner)
        {
            labelLastResults.Visible = false;
            labelPlayerName.ForeColor = Color.Black;
            labelPlayerName.Text = @"Loading summoner data....";
            listBoxChampions.Items.Clear();
            listBoxLastGames.Items.Clear();

            _summonerName = summoner;

            var restFactory = new RestFactory($"https://{Server}.op.gg");
            var request = new RestRequest("summoner/", Method.GET);
            request.AddParameter("userName", summoner);
            restFactory.ExecuteAsync(request, LoadData);            
        }

        public void ChangeLabelText(Label control, string text)
        {
            control.Text = text;
        }

        public void LoadData(IRestResponse response)
        {
            if (response.StatusCode == HttpStatusCode.InternalServerError
                || response.StatusCode == HttpStatusCode.ServiceUnavailable
                || response.StatusCode == HttpStatusCode.BadRequest
                || response.StatusCode == HttpStatusCode.Unauthorized
                || response.StatusCode == HttpStatusCode.MethodNotAllowed
                || response.StatusCode == HttpStatusCode.Forbidden
                || response.StatusCode == HttpStatusCode.NotFound
                || response.StatusCode == 0)
            {
                var exception = new RestException(response.Content, response.ErrorMessage, response.StatusCode, response.ErrorException);
                throw exception;
            }

            var content = response.Content;

            // We look for the summonerId
            var pos = content.IndexOf("$.OP.GG.summoner.renewBtn.start(this, ", StringComparison.Ordinal);
            if (pos == -1)
            {
                labelPlayerName.Invoke(
                new Action(() =>
                {
                    labelPlayerName.Text = @"Unknown summoner " + _summonerName;
                }));
                
                return;
            }

            content = content.Substring(pos);
            pos = content.IndexOf("'", StringComparison.Ordinal);
            content = content.Substring(pos + 1);
            pos = content.IndexOf("'", StringComparison.Ordinal);
            var summonerId = content.Substring(0, pos);

            // Now we are going to update it:
            var restFactory = new RestFactory($"https://{Server}.op.gg");
            var request = new RestRequest("/summoner/ajax/renew.json/", Method.POST);
            request.AddParameter("summonerId", summonerId);
            var opGgAjax= restFactory.Execute<OPGGAjax>(request);
            if (opGgAjax != null)
            {
                var delay = opGgAjax.Delay;
                while (!opGgAjax.Finish)
                {
                    Thread.Sleep(delay);
                    request = new RestRequest("/summoner/ajax/renewStatus.json/", Method.POST);
                    request.AddParameter("summonerId", summonerId);
                    opGgAjax = restFactory.Execute<OPGGAjax>(request);
                }
            }

            request = new RestRequest("summoner/", Method.GET);
            request.AddParameter("userName", _summonerName);
            var res = restFactory.Execute(request);
            pos = res.IndexOf("name=\"description\"", StringComparison.Ordinal);
            res = res.Substring(pos);
            pos = res.IndexOf("content=\"", StringComparison.Ordinal);
            res = res.Substring(pos + 9);
            pos = res.IndexOf("\"", StringComparison.Ordinal);
            res = res.Substring(0, pos);

            var splitPlayer = res.Split('/');
            var find = res.Split();
            var intWinrate = 50;
            foreach (var str in find)
            {
                if (str.EndsWith("%"))
                {
                    intWinrate = Convert.ToInt32(str.Substring(0, str.Length - 1));
                    break;
                }
            }

            labelPlayerName.Invoke(
                new Action(() =>
                {
                    if (intWinrate > 55)
                        labelPlayerName.ForeColor = Color.Blue;
                    else if (intWinrate > 50)
                        labelPlayerName.ForeColor = Color.Green;
                    else if (intWinrate > 45)
                        labelPlayerName.ForeColor = Color.Black;
                    else
                        labelPlayerName.ForeColor = Color.Red;

                    labelPlayerName.Text = splitPlayer[0] + @" / " + splitPlayer[1] + @" / " + splitPlayer[2];
                }));
            
            // Now we need to check the champions most used
            request = new RestRequest("/summoner/champions/ajax/champions.most/", Method.GET);
            request.AddParameter("summonerId", summonerId);
            request.AddParameter("season", "7");
            res = restFactory.Execute(request);

            var splitMostChampion = res.Split(new [] { "<div class=\"ChampionBox Ranked\">" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var str in splitMostChampion)
            {
                pos = str.IndexOf("title=\"", StringComparison.Ordinal);
                if (pos != -1)
                {
                    res = str.Substring(pos + 7);
                    pos = res.IndexOf("\"", StringComparison.Ordinal);
                    var championName = res.Substring(0, pos);
                    pos = res.IndexOf("class=\"KDA\">", StringComparison.Ordinal);
                    res = res.Substring(pos + 12);
                    pos = res.IndexOf("<", StringComparison.Ordinal);
                    var kda = res.Substring(0, pos);
                    pos = res.IndexOf("<div class=\"WinRatio", StringComparison.Ordinal);
                    res = res.Substring(pos);
                    pos = res.IndexOf(">", StringComparison.Ordinal);
                    res = res.Substring(pos + 1);
                    pos = res.IndexOf("<", StringComparison.Ordinal);
                    var winrate = res.Substring(0, pos).Trim();
                    pos = res.IndexOf("<div class=\"Title", StringComparison.Ordinal);
                    res = res.Substring(pos);
                    pos = res.IndexOf(">", StringComparison.Ordinal);
                    res = res.Substring(pos + 1);
                    pos = res.IndexOf("<", StringComparison.Ordinal);
                    var played = res.Substring(0, pos).Trim();

                    var championUsed = new ChampionUsed(championName, kda, winrate, played);
                    listBoxChampions.Invoke(
                        new Action(() =>
                        {
                            listBoxChampions.Items.Add(championUsed);                            
                        }));
                }
            }

            request = new RestRequest("/summoner/matches/ajax/averageAndList/", Method.GET);
            request.AddParameter("startInfo", 0);
            request.AddParameter("summonerId", summonerId);
            request.AddParameter("type", "soloranked");
            res = restFactory.Execute(request);

            pos = res.IndexOf("data-interval='", StringComparison.Ordinal);
            var i = 0;
            var wins = 0;
            var loses = 0;
            while (pos != -1 && i < 10)
            {
                res = res.Substring(pos);
                pos = res.IndexOf(">", StringComparison.Ordinal);
                res = res.Substring(pos + 1);
                pos = res.IndexOf("<", StringComparison.Ordinal);
                var dateGame = res.Substring(0, pos);
                pos = res.IndexOf("GameResult", StringComparison.Ordinal);
                res = res.Substring(pos);
                pos = res.IndexOf(">", StringComparison.Ordinal);
                res = res.Substring(pos + 1);
                pos = res.IndexOf("<", StringComparison.Ordinal);
                var gameResult = res.Substring(0, pos).Replace("\\n", "");
                gameResult = gameResult.Replace("\\t", "");
                pos = res.IndexOf("ChampionName", StringComparison.Ordinal);
                res = res.Substring(pos);
                pos = res.IndexOf(">", StringComparison.Ordinal);
                res = res.Substring(pos + 1);
                pos = res.IndexOf("<a>", StringComparison.Ordinal);
                res = res.Substring(pos + 3);
                pos = res.IndexOf("<", StringComparison.Ordinal);
                var championName = res.Substring(0, pos).Trim();

                if (gameResult.Trim() == "Defeat" || gameResult.Trim() == "Victory")
                {
                    var game = new GameResult(dateGame, championName.Trim(), gameResult.Trim() != "Defeat");
                    if (game.Win)
                        wins++;
                    else
                        loses++;

                    listBoxLastGames.Invoke(
                        new Action(() =>
                        {
                            listBoxLastGames.Items.Add(game);
                        }));

                }

                pos = res.IndexOf("data-interval='", StringComparison.Ordinal);
                i++;
            }

            labelLastResults.Invoke(
                new Action(() =>
                {
                    labelLastResults.Visible = true;
                    if (wins > loses)
                        labelLastResults.ForeColor = Color.Green;
                    else if (wins == loses)
                        labelLastResults.ForeColor = Color.Black;
                    else
                        labelLastResults.ForeColor = Color.Red;

                    labelLastResults.Text = $"{wins}V / {loses}L";
                }));
        }

        private void listBoxChampions_DrawItem(object sender, DrawItemEventArgs e)
        {
            var championUsed = (ChampionUsed)((ListBox) sender).Items[e.Index];
            e.DrawBackground();

            var points = 0;
            Brush brush;
            if (championUsed.Kda >= 4)
            {
                brush = Brushes.Blue;
                points += 2;
            }
            else if (championUsed.Kda >= 3)
            {
                brush = Brushes.Green;
                points += 1;
            }
            else if (championUsed.Kda >= 1)
                brush = Brushes.Black;
            else
            {
                brush = Brushes.Red;                
                if (championUsed.Kda < 0.5)
                    points -= 2;
                else
                    points -= 1;
            }

            e.Graphics.DrawString(championUsed.Kda.ToString(), e.Font, brush, e.Bounds.Left + 70, e.Bounds.Top);

            if (championUsed.WinRate >= 60)
            {
                brush = Brushes.Blue;
                points += 2;
            }
            else if (championUsed.WinRate >= 55)
            {
                brush = Brushes.Green;
                points += 1;
            }
            else if (championUsed.WinRate >= 45)
                brush = Brushes.Black;
            else
            {
                brush = Brushes.Red;
                if (championUsed.WinRate > 40)
                    points -= 1;
                else
                    points -= 2;
            }

            e.Graphics.DrawString(championUsed.WinRate + "%", e.Font, brush, e.Bounds.Left + 100, e.Bounds.Top);

            if (championUsed.Played > 50)
            {
                points += 2;
                brush = Brushes.Blue;
            }
            else if (championUsed.Played > 20)
            {
                points += 1;
                brush = Brushes.Green;
            }
            else
                brush = Brushes.Black;

            e.Graphics.DrawString(championUsed.Played + " played", e.Font, brush, e.Bounds.Left + 130, e.Bounds.Top);


            if (points >= 4)
                brush = Brushes.Blue;
            else if (points >= 2)
                brush = Brushes.Green;
            else if (points >= 0)
                brush = Brushes.Black;
            else
                brush = Brushes.Red;

            e.Graphics.DrawString(championUsed.ChampionName, e.Font, brush, e.Bounds.Left, e.Bounds.Top);
        }

        private void listBoxLastGames_DrawItem(object sender, DrawItemEventArgs e)
        {
            var gameResult = (GameResult)((ListBox)sender).Items[e.Index];

            Brush brush;
            if (gameResult.Win)
                brush = Brushes.Green;
            else
                brush = Brushes.Red;

            e.Graphics.DrawString(gameResult.ChampionName, e.Font, brush, e.Bounds.Left, e.Bounds.Top);
            e.Graphics.DrawString(gameResult.DateGame, e.Font, brush, e.Bounds.Left + 70, e.Bounds.Top);
        }
    }
}
