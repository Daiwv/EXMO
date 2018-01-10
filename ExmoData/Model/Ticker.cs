// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using ExmoData.Model;
//
//    var data = Ticker.FromJson(jsonString);

namespace ExmoData.Model
{
    using System;
    using System.Net;
    using System.Collections.Generic;

    using Newtonsoft.Json;

    public class Ticker
    {
        public string PairName { get; set; }

        [JsonProperty("buy_price")]
        public string BuyPrice { get; set; }

        [JsonProperty("sell_price")]
        public string SellPrice { get; set; }

        [JsonProperty("last_trade")]
        public string LastTrade { get; set; }

        [JsonProperty("high")]
        public string High { get; set; }

        [JsonProperty("low")]
        public string Low { get; set; }

        [JsonProperty("avg")]
        public string Avg { get; set; }

        [JsonProperty("vol")]
        public string Vol { get; set; }

        [JsonProperty("vol_curr")]
        public string VolCurr { get; set; }

        [JsonProperty("updated")]
        public long Updated { get; set; }


        public static Dictionary<string, Ticker> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, Ticker>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Dictionary<string, Ticker> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
