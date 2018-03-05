using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class StickerEmojis : Structure
    {

        public partial class stickerEmojis : StickerEmojis
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "stickerEmojis";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("emojis")]
                public string[] emojis_;

        }

    }

}
