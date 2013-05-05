using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftdCruncher.Templates
{
    public class CountryProfile
    {
        public string Name { get; set; }
        public long LatestYear { get; set; }
        public long Oil_Production { get; set; }
        public double Oil_Price { get; set; }
        public long  Gas_Production { get; set; }
        public double Gas_Price { get; set; }
    }
}
