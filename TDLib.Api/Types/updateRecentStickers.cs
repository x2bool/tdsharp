using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateRecentStickers : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateRecentStickers";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_attached")]
                public bool? is_attached_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("sticker_ids")]
                public int[] sticker_ids_;

        }

    }

}
