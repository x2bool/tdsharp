using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class SearchMessagesFilter : Structure
    {

        public partial class searchMessagesFilterVideoNote : SearchMessagesFilter
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "searchMessagesFilterVideoNote";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
