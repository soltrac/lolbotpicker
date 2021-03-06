﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using LolComparer.Properties;

namespace LolComparer
{
    public partial class Form1 : Form
    {
        private readonly List<Stats> _supports = new List<Stats>();
        private readonly List<Stats> _adcs = new List<Stats>();
        private readonly List<ChampionData> _adcData = new List<ChampionData>();
        private readonly List<ChampionData> _supData = new List<ChampionData>();
        private string _selectedTheirAdc, _selectedTheirSup, _selectedMyAdc, _selectedMySup;

        public Form1()
        {
            InitializeComponent();

#if DEBUG
            textBoxPaste.Text = @"astrojayce se ha unido a la sala.
Vraelyn se ha unido a la sala.
FalinInTheHole se ha unido a la sala.
3DMAN se ha unido a la sala.
Wuapeton se ha unido a la sala.
";
#endif

            textBoxSummoner.Text = (string)Settings.Default["SummonerName"];

            // Get supports and ADCs
            var webRequest =
                (HttpWebRequest)
                    WebRequest.Create("http://champion.gg/statistics");
            webRequest.ProtocolVersion = HttpVersion.Version10;
            webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6";
            webRequest.KeepAlive = true;
            webRequest.AllowAutoRedirect = true;
            try
            {
                using (var webResponse = (HttpWebResponse) webRequest.GetResponse())
                {
                    using (var stream = webResponse.GetResponseStream())
                    {
                        if (stream != null)
                        {
                            using (var streamReader = new StreamReader(stream))
                            {
                                var answer = streamReader.ReadToEnd();
                                answer = answer.Substring(answer.IndexOf("matchupData.stats", StringComparison.Ordinal));
                                answer = answer.Substring(answer.IndexOf("[", StringComparison.Ordinal));
                                answer = answer.Substring(0, answer.IndexOf(";", StringComparison.Ordinal));

                                var js = new JavaScriptSerializer();
                                var champions = js.Deserialize<Stats[]>(answer).ToList();

                                comboBoxMyADC.Items.Add("");
                                comboBoxTheirADC.Items.Add("");
                                comboBoxTheirSup.Items.Add("");
                                foreach (var champion in champions.FindAll(x => x.role == "ADC").OrderBy(x => x.title))
                                {
                                    comboBoxMyADC.Items.Add(champion.key);
                                    comboBoxTheirADC.Items.Add(champion.key);
                                    _adcs.Add(champion);
                                }

                                foreach (var champion in champions.FindAll(x => x.role == "Support").OrderBy(x => x.title))
                                {
                                    comboBoxTheirSup.Items.Add(champion.key);
                                    comboBoxMySup.Items.Add(champion.key);
                                    _supports.Add(champion);
                                }

                                CalculateBest();
                            }
                        }
                        else
                        {
                            MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                            Close();
                        }
                    }
                }
            }
            catch (WebException)
            {
                MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                Close();
            }
        }
        
        private void comboBoxMyADC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMyADC.SelectedItem != null && comboBoxMyADC.SelectedItem.ToString() != "" && comboBoxMyADC.Items.Contains(comboBoxMyADC.SelectedItem))
            {
                _selectedMyAdc = comboBoxMyADC.SelectedItem.ToString();
                if (_adcData.All(x => x.key != _selectedMyAdc))
                {
                    var webRequest =
                        (HttpWebRequest)
                            WebRequest.Create($"http://champion.gg/champion/{comboBoxMyADC.SelectedItem}/ADC");
                    webRequest.ProtocolVersion = HttpVersion.Version10;
                    webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6";
                    webRequest.KeepAlive = true;
                    webRequest.AllowAutoRedirect = true;
                    try
                    {
                        using (var webResponse = (HttpWebResponse) webRequest.GetResponse())
                        {
                            using (var stream = webResponse.GetResponseStream())
                            {
                                if (stream != null)
                                {
                                    using (var streamReader = new StreamReader(stream))
                                    {
                                        var answer = streamReader.ReadToEnd();
                                        answer = answer.Substring(answer.IndexOf("matchupData.championData", StringComparison.Ordinal));
                                        answer = answer.Substring(answer.IndexOf("{", StringComparison.Ordinal));
                                        answer = answer.Substring(0, answer.IndexOf(";", StringComparison.Ordinal));

                                        var js = new JavaScriptSerializer();
                                        var champion = js.Deserialize<ChampionData>(answer);
                                        _adcData.Add(champion);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                                }
                            }
                        }
                    }
                    catch (WebException)
                    {
                        MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                    }                    
                }
            }
            else
                _selectedMyAdc = null;

            CalculateBest();
        }

        private void comboBoxTheirADC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTheirADC.SelectedItem != null && comboBoxTheirADC.SelectedItem.ToString() != "" && comboBoxTheirADC.Items.Contains(comboBoxTheirADC.SelectedItem))
            {
                _selectedTheirAdc = comboBoxTheirADC.SelectedItem.ToString();
                if (_adcData.All(x => x.key != _selectedTheirAdc))
                {
                    var webRequest =
                        (HttpWebRequest)
                            WebRequest.Create($"http://champion.gg/champion/{comboBoxTheirADC.SelectedItem}/ADC");
                    webRequest.ProtocolVersion = HttpVersion.Version10;
                    webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6";
                    webRequest.KeepAlive = true;
                    webRequest.AllowAutoRedirect = true;
                    try
                    {
                        using (var webResponse = (HttpWebResponse)webRequest.GetResponse())
                        {
                            using (var stream = webResponse.GetResponseStream())
                            {
                                if (stream != null)
                                {
                                    using (var streamReader = new StreamReader(stream))
                                    {
                                        var answer = streamReader.ReadToEnd();
                                        answer = answer.Substring(answer.IndexOf("matchupData.championData", StringComparison.Ordinal));
                                        answer = answer.Substring(answer.IndexOf("{", StringComparison.Ordinal));
                                        answer = answer.Substring(0, answer.IndexOf(";", StringComparison.Ordinal));

                                        var js = new JavaScriptSerializer();
                                        var champion = js.Deserialize<ChampionData>(answer);
                                        _adcData.Add(champion);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                                }
                            }
                        }
                    }
                    catch (WebException)
                    {
                        MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                    }
                }
            }
            else
                _selectedTheirAdc = null;

            CalculateBest();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalculateBest();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                labelSup.Visible = false;
                comboBoxMySup.Visible = false;
                labelADC.Visible = true;
                comboBoxMyADC.Visible = true;
                comboBoxMySup.SelectedItem = "";
            }
            else
            {
                labelSup.Visible = true;
                comboBoxMySup.Visible = true;
                labelADC.Visible = false;
                comboBoxMyADC.Visible = false;
                comboBoxMyADC.SelectedItem = "";
            }

            CalculateBest();
        }

        private void radioButtonStatRating_CheckedChanged(object sender, EventArgs e)
        {
            CalculateBest();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default["SummonerName"] = textBoxSummoner.Text;
            Settings.Default.Save();
        }

        private void buttonAnalyzeSummoners_Click(object sender, EventArgs e)
        {
            var split = textBoxPaste.Text.Split('\n', '\r');

            var removeText = "";
            if (textBoxPaste.Text.Contains("joined the lobby"))
                removeText = "joined the lobby";
            else if (textBoxPaste.Text.Contains("se ha unido a la sala"))
                removeText = "se ha unido a la sala";

            playerItem1.Visible = false;
            playerItem2.Visible = false;
            playerItem3.Visible = false;
            playerItem4.Visible = false;


            var list = new List<string>();

            foreach (var splitStr in split)
            {
                if (splitStr.Trim() != string.Empty)
                {
                    var pos = splitStr.IndexOf(removeText, StringComparison.Ordinal);
                    string str;
                    if (pos != -1)
                        str = splitStr.Substring(0, pos).Trim();
                    else
                        str = splitStr;

                    if (str.ToLower().Trim() != textBoxSummoner.Text.ToLower().Trim())
                        list.Add(str.Trim());
                }
            }
            
            if (list.Count > 0)
            {
                playerItem1.Visible = true;
                playerItem1.AnalyzeSummoner(list[0]);
            }
            if (list.Count > 1)
            {
                playerItem2.Visible = true;
                playerItem2.AnalyzeSummoner(list[1]);
            }
            if (list.Count > 2)
            {
                playerItem3.Visible = true;
                playerItem3.AnalyzeSummoner(list[2]);
            }
            if (list.Count > 3)
            {
                playerItem4.Visible = true;
                playerItem4.AnalyzeSummoner(list[3]);
            }
        }

        private void comboBoxMySup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMySup.SelectedItem != null && comboBoxMySup.SelectedItem.ToString() != "" && comboBoxMySup.Items.Contains(comboBoxMySup.SelectedItem))
            {
                _selectedMySup = comboBoxMySup.SelectedItem.ToString();
                if (_supData.All(x => x.key != _selectedMySup))
                {
                    var webRequest =
                        (HttpWebRequest)
                            WebRequest.Create($"http://champion.gg/champion/{comboBoxMySup.SelectedItem}/Support");
                    webRequest.ProtocolVersion = HttpVersion.Version10;
                    webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6";
                    webRequest.KeepAlive = true;
                    webRequest.AllowAutoRedirect = true;
                    try
                    {
                        using (var webResponse = (HttpWebResponse)webRequest.GetResponse())
                        {
                            using (var stream = webResponse.GetResponseStream())
                            {
                                if (stream != null)
                                {
                                    using (var streamReader = new StreamReader(stream))
                                    {
                                        var answer = streamReader.ReadToEnd();
                                        answer = answer.Substring(answer.IndexOf("matchupData.championData", StringComparison.Ordinal));
                                        answer = answer.Substring(answer.IndexOf("{", StringComparison.Ordinal));
                                        answer = answer.Substring(0, answer.IndexOf(";", StringComparison.Ordinal));

                                        var js = new JavaScriptSerializer();
                                        var champion = js.Deserialize<ChampionData>(answer);
                                        _supData.Add(champion);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                                }
                            }
                        }
                    }
                    catch (WebException)
                    {
                        MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                    }
                }
            }
            else
                _selectedMySup = null;

            CalculateBest();
        }

        private void comboBoxTheirSup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTheirSup.SelectedItem != null && comboBoxTheirSup.SelectedItem.ToString() != "" && comboBoxTheirSup.Items.Contains(comboBoxTheirSup.SelectedItem))
            {
                _selectedTheirSup = comboBoxTheirSup.SelectedItem.ToString();
                if (_supData.All(x => x.key != _selectedTheirSup))
                {
                    var webRequest =
                        (HttpWebRequest)
                            WebRequest.Create($"http://champion.gg/champion/{comboBoxTheirSup.SelectedItem}/Support");
                    webRequest.ProtocolVersion = HttpVersion.Version10;
                    webRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; es-ES; rv:1.9.1.6) Gecko/20091201 Firefox/3.5.6";
                    webRequest.KeepAlive = true;
                    webRequest.AllowAutoRedirect = true;
                    try
                    {
                        using (var webResponse = (HttpWebResponse)webRequest.GetResponse())
                        {
                            using (var stream = webResponse.GetResponseStream())
                            {
                                if (stream != null)
                                {
                                    using (var streamReader = new StreamReader(stream))
                                    {
                                        var answer = streamReader.ReadToEnd();
                                        answer = answer.Substring(answer.IndexOf("matchupData.championData", StringComparison.Ordinal));
                                        answer = answer.Substring(answer.IndexOf("{", StringComparison.Ordinal));
                                        answer = answer.Substring(0, answer.IndexOf(";", StringComparison.Ordinal));

                                        var js = new JavaScriptSerializer();
                                        var champion = js.Deserialize<ChampionData>(answer);
                                        _supData.Add(champion);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                                }
                            }
                        }
                    }
                    catch (WebException)
                    {
                        MessageBox.Show(@"Could not load ADCs and support, maybe internet is down?");
                    }
                }
            }
            else
                _selectedTheirSup = null;

            CalculateBest();
        }

        private void CalculateBest()
        {
            listBox1.Items.Clear();
            if (_selectedMyAdc == null && _selectedTheirAdc == null && _selectedTheirSup == null && _selectedMySup == null)
            {
                var count = 0;
                if (radioButton1.Checked)
                {
                    foreach (var sup in _supports.OrderBy(x => x.general.overallPosition))
                    {
                        if (count > 10)
                            break;
                        listBox1.Items.Add(sup);
                        count++;
                    }
                }
                else if (radioButton2.Checked)
                {
                    foreach (var adc in _adcs.OrderBy(x => x.general.overallPosition))
                    {
                        if (count > 10)
                            break;
                        listBox1.Items.Add(adc);
                        count++;
                    }
                }
            }
            else
            {
                var pairs = new Dictionary<string, double>();
                if (_selectedMyAdc != null && radioButton1.Checked)
                {
                    var adc = _adcData.Find(x => x.key == _selectedMyAdc);
                    if (adc != null)
                    {
                        foreach (var sup in adc.synergy)
                        {
                            if (sup.games > numericUpDown1.Value)
                            {
                                if (pairs.ContainsKey(sup.key))
                                {
                                    if (radioButtonStatRating.Checked)
                                        pairs[sup.key] += sup.statScore;
                                    else
                                        pairs[sup.key] += sup.winRate;
                                }
                                else
                                {
                                    pairs.Add(sup.key, radioButtonStatRating.Checked ? sup.statScore : sup.winRate);
                                }
                            }
                        }
                    }
                }
                if (_selectedMySup != null && radioButton2.Checked)
                {
                    var support = _supData.Find(x => x.key == _selectedMySup);
                    if (support != null)
                    {
                        foreach (var sup in support.synergy)
                        {
                            if (sup.games > numericUpDown1.Value)
                            {
                                if (pairs.ContainsKey(sup.key))
                                {
                                    if (radioButtonStatRating.Checked)
                                        pairs[sup.key] += sup.statScore;
                                    else
                                        pairs[sup.key] += sup.winRate;
                                }
                                else
                                {
                                    pairs.Add(sup.key, radioButtonStatRating.Checked ? sup.statScore : sup.winRate);
                                }
                            }
                        }
                    }
                }
                if (_selectedTheirAdc != null)
                {
                    var adc = _adcData.Find(x => x.key == _selectedTheirAdc);
                    if (adc != null)
                    {
                        if (radioButton1.Checked)
                        {
                            foreach (var sup in adc.adcsupport)
                            {
                                if (sup.games > numericUpDown1.Value)
                                {
                                    if (pairs.ContainsKey(sup.key))
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs[sup.key] -= sup.statScore;
                                        else
                                            pairs[sup.key] -= sup.winRate;
                                    }
                                    else
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs.Add(sup.key, -sup.statScore);
                                        else
                                            pairs.Add(sup.key, -sup.winRate);
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (var sup in adc.matchups)
                            {
                                if (sup.games > numericUpDown1.Value)
                                {
                                    if (pairs.ContainsKey(sup.key))
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs[sup.key] -= sup.statScore;
                                        else
                                            pairs[sup.key] -= sup.winRate;
                                    }
                                    else
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs.Add(sup.key, -sup.statScore);
                                        else
                                            pairs.Add(sup.key, -sup.winRate);
                                    }
                                }
                            }
                        }
                    }
                }
                if (_selectedTheirSup != null)
                {
                    var support = _supData.Find(x => x.key == _selectedTheirSup);
                    if (support != null)
                    {
                        if (radioButton1.Checked)
                        {
                            foreach (var sup in support.matchups)
                            {
                                if (sup.games > numericUpDown1.Value)
                                {
                                    if (pairs.ContainsKey(sup.key))
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs[sup.key] -= sup.statScore;
                                        else
                                            pairs[sup.key] -= sup.winRate;
                                    }
                                    else
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs.Add(sup.key, -sup.statScore);
                                        else
                                            pairs.Add(sup.key, -sup.winRate);
                                    }
                                }
                            }
                        }
                        else
                        {
                            foreach (var sup in support.adcsupport)
                            {
                                if (sup.games > numericUpDown1.Value)
                                {
                                    if (pairs.ContainsKey(sup.key))
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs[sup.key] -= sup.statScore;
                                        else
                                            pairs[sup.key] -= sup.winRate;
                                    }
                                    else
                                    {
                                        if (radioButtonStatRating.Checked)
                                            pairs.Add(sup.key, -sup.statScore);
                                        else
                                            pairs.Add(sup.key, -sup.winRate);
                                    }
                                }
                            }
                        }
                    }
                }

                var count = 0;
                foreach (var pair in pairs.OrderByDescending(x => x.Value))
                {
                    if (count > 10)
                        break;

                    var champion = radioButton1.Checked ? _supports.Find(x => x.key == pair.Key) : _adcs.Find(x => x.key == pair.Key);
                    if (champion != null)
                    {
                        var championValue = new ChampionValue
                        {
                            Champion = champion,
                            Value = pair.Value
                        };
                        listBox1.Items.Add(championValue);
                        count++;
                    }
                }
            }
        }
    }
}
