using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolComparer
{
    public class ChampionValue
    {
        public Stats Champion { get; set; }       
        public double Value { get; set; }

        public override string ToString()
        {
            return Champion.title + "\t" + Value + "\t(" + Champion.general.overallPosition + " - " + Champion.general.winPercent + ")";
        }
    }
}
