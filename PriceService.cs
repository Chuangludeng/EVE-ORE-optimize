using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EVE_OREoptimize.PriceStructure
{
    public class All
    {
        public int max { get; set; }
        public double min { get; set; }
        public long volume { get; set; }
    }

    public class Buy
    {
        public double max { get; set; }
        public double min { get; set; }
        public long volume { get; set; }
    }

    public class Sell
    {
        public int max { get; set; }
        public int min { get; set; }
        public long volume { get; set; }
    }

    public class Root
    {
        public All all { get; set; }
        public Buy buy { get; set; }
        public Sell sell { get; set; }
    }
}

namespace EVE_OREoptimize
{
    public class PriceService
    {
        public PriceService()
        {

        }

        public static PriceStructure.Root GetPrice(int type_id)
        {
             return GetCallAPI("https://www.ceve-market.org/api/market/region/10000002/type/" + type_id.ToString() + ".json");
        }

        public static PriceStructure.Root GetCallAPI(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return JsonConvert.DeserializeObject<PriceStructure.Root>(retString);
        }
    }
}
