using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolComparer
{
    public class ChampionData
    {
        public string _id { get; set; }
        public string key { get; set; }
        public List<AdcSupport> synergy { get; set; }
        public List<AdcSupport> adcsupport { get; set; }
        public List<AdcSupport> matchups { get; set; }
    }
}
