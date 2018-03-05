using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateTrendingStickerSets : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateTrendingStickerSets";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_sets")]
                public StickerSets.stickerSets sticker_sets_;

        }

    }

}
