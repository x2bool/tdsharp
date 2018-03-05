using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageContent : Structure
    {

        public partial class messageChatUpgradeTo : MessageContent
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "messageChatUpgradeTo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("supergroup_id")]
                public int? supergroup_id_;

        }

    }

}
