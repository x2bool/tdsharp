using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Venue : Structure
    {

        public partial class venue : Venue
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "venue";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("location")]
                public Location.location location_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("address")]
                public string address_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("provider")]
                public string provider_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

        }

    }

}
