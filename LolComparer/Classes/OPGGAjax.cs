using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp.Deserializers;

namespace LolComparer.Classes
{
    class OPGGAjax
    {
        [DeserializeAs(Name = "finish")]
        public bool Finish { get; set; }

        [DeserializeAs(Name = "delay")]
        public int Delay { get; set; }
    }
}
