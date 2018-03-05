using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class searchPublicChats : Method<Chats>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "searchPublicChats";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("query")]
                public string query_;

        }

    }

}
