using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputInlineQueryResult : Structure
    {

        public partial class inputInlineQueryResultGame : InputInlineQueryResult
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inputInlineQueryResultGame";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("game_short_name")]
                public string game_short_name_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup reply_markup_;

        }

    }

}
