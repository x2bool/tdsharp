using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class getFavoriteStickers : Method<Stickers>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "getFavoriteStickers";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
