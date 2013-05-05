using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using ftdCruncher.Templates.ApiResponses;
using System.Net;
using Newtonsoft.Json;

namespace ftdCruncher.Services
{
    public class FApi
    {

        public async Task<List<CountryResponseRootObject>> GetCountries()
        {
            
            //time wasting
            var y = await Gapi("http://liverugbydata.com/followthedata/api/country");
            await Task.Delay(3000);
            //var x = JsonConvert.DeserializeObject<CountryResponseRootObject>(y).countries;
            
            return new List<CountryResponseRootObject>();

        }
        private async static Task<string> Gapi(string url)
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
