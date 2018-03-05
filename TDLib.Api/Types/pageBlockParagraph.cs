using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class PageBlock : Structure
    {

        public partial class pageBlockParagraph : PageBlock
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "pageBlockParagraph";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public RichText text_;

        }

    }

}
