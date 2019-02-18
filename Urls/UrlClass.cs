using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Urls
{
    public static class UrlClass
    {
        public static string GetValue()
        {
            string url = "https://cdn.prodworksngwapi.de/ihdcc-services/content/vw-de/brand/de/config.json";
            WebClient webClient = new WebClient();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            string data = webClient.DownloadString(url);
            dynamic sessionObj = JObject.Parse(data);
            var sessionUrl = sessionObj["body"]["currentdataversion"].ToString();
            return sessionUrl;
        }
    }
}
