using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatType : Structure
    {

        public partial class chatTypePrivate : ChatType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatTypePrivate";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int? user_id_;

        }

    }

}
