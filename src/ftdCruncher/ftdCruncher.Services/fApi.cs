using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ftdCruncher.Templates.ApiResponses;
using System.Net;
using Newtonsoft.Json;

namespace ftdCruncher.Services
{
    public class FApi
    {

        public async Task<CountryResponseRootObject> GetCountries()
        {
            var x = JsonConvert.DeserializeObject<CountryResponseRootObject>(await Gapi("http://liverugbydata.com/followthedata/api/country"));
            return x;

        }
        private async Task<string> Gapi(string url)
        {
            var req = (HttpWebRequest) HttpWebRequest.Create(url);
            req.ContentType = "application/json";
            req.Method = "GET";
            var resp = await req.GetResponseAsync();
            var respStream = resp.GetResponseStream();

            using (var sr = new StreamReader(respStream))
            {
                return sr.ReadToEnd();
            }

        }
    }
}
