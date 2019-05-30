using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExamWPF_EarthQuakeApi.Models
{
    public class GeoInformationJSON
    {
        public class Metadata
        {

            [JsonProperty("generated")]
            public long generated { get; set; }

            [JsonProperty("url")]
            public string url { get; set; }

            [JsonProperty("title")]
            public string title { get; set; }

            [JsonProperty("status")]
            public int status { get; set; }

            [JsonProperty("api")]
            public string api { get; set; }

            [JsonProperty("limit")]
            public int limit { get; set; }

            [JsonProperty("offset")]
            public int offset { get; set; }

            [JsonProperty("count")]
            public int count { get; set; }
        }

        public class Properties
        {

            [JsonProperty("mag")]
            public double? mag { get; set; }

            [JsonProperty("place")]
            public string place { get; set; }

            [JsonProperty("time")]
            [JsonConverter(typeof(UtilityDateTime))]
            public DateTime time { get; set; }

            [JsonProperty("updated")]
            public object updated { get; set; }

            [JsonProperty("tz")]
            public int tz { get; set; }

            [JsonProperty("url")]
            public string url { get; set; }

            [JsonProperty("detail")]
            public string detail { get; set; }

            [JsonProperty("felt")]
            public object felt { get; set; }

            [JsonProperty("cdi")]
            public object cdi { get; set; }

            [JsonProperty("mmi")]
            public object mmi { get; set; }

            [JsonProperty("alert")]
            public object alert { get; set; }

            [JsonProperty("status")]
            public string status { get; set; }

            [JsonProperty("tsunami")]
            public int tsunami { get; set; }

            [JsonProperty("sig")]
            public int sig { get; set; }

            [JsonProperty("net")]
            public string net { get; set; }

            [JsonProperty("code")]
            public string code { get; set; }

            [JsonProperty("ids")]
            public string ids { get; set; }

            [JsonProperty("sources")]
            public string sources { get; set; }

            [JsonProperty("types")]
            public string types { get; set; }

            [JsonProperty("nst")]
            public int? nst { get; set; }

            [JsonProperty("dmin")]
            public double? dmin { get; set; }

            [JsonProperty("rms")]
            public double? rms { get; set; }

            [JsonProperty("gap")]
            public double? gap { get; set; }

            [JsonProperty("magType")]
            public string magType { get; set; }

            [JsonProperty("type")]
            public string type { get; set; }

            [JsonProperty("title")]
            public string title { get; set; }
        }

        public class Geometry
        {

            [JsonProperty("type")]
            public string type { get; set; }

            [JsonProperty("coordinates")]
            public IList<double> coordinates { get; set; }
        }

        public class Feature
        {

            [JsonProperty("type")]
            public string type { get; set; }

            [JsonProperty("properties")]
            public Properties properties { get; set; }

            [JsonProperty("geometry")]
            public Geometry geometry { get; set; }

            [JsonProperty("id")]
            public string id { get; set; }
        }

        public class GeoData
        {

            [JsonProperty("type")]
            public string type { get; set; }

            [JsonProperty("metadata")]
            public Metadata metadata { get; set; }

            [JsonProperty("features")]
            public IList<Feature> features { get; set; }

            [JsonProperty("bbox")]
            public IList<double> bbox { get; set; }
        }
    }
}
