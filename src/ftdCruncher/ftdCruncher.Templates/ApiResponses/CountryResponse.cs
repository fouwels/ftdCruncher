using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ftdCruncher.Templates.ApiResponses
{       // ReSharper disable InconsistentNaming
        public class Id
        {
            public string oid { get; set; }
        }

        public class CountryResponseRootObject
        {
            public Id _id { get; set; }
            public string name { get; set; }
        }
        // ReSharper restore InconsistentNaming
    
}
