using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class sendChatSetTtlMessage : Method<Message>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "sendChatSetTtlMessage";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long? chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("ttl")]
                public int? ttl_;

        }

    }

}
