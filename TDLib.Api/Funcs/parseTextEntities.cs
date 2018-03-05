using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class parseTextEntities : Method<FormattedText>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "parseTextEntities";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public string text_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("parse_mode")]
                public TextParseMode parse_mode_;

        }

    }

}
