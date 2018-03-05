using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputMessageContent : Structure
    {

        public partial class inputMessagePhoto : InputMessageContent
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inputMessagePhoto";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public InputFile photo_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail")]
                public InputThumbnail.inputThumbnail thumbnail_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("added_sticker_file_ids")]
                public int[] added_sticker_file_ids_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("width")]
                public int? width_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("height")]
                public int? height_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public FormattedText.formattedText caption_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("ttl")]
                public int? ttl_;

        }

    }

}
