using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public partial class pageBlockPhoto : PageBlock
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "pageBlockPhoto";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public Photo.photo photo_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("caption")]
                public RichText caption_;

        }

    }

}
