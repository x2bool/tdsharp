using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateFileGenerationStart : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateFileGenerationStart";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("generation_id")]
                public string generation_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("original_path")]
                public string original_path_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("destination_path")]
                public string destination_path_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("conversion")]
                public string conversion_;

        }

    }

}
