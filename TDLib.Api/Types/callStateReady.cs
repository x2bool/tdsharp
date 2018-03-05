using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class CallState : Structure
    {

        public partial class callStateReady : CallState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "callStateReady";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("protocol")]
                public CallProtocol.callProtocol protocol_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("connections")]
                public CallConnection.callConnection[] connections_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("config")]
                public string config_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("encryption_key")]
                public byte[] encryption_key_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("emojis")]
                public string[] emojis_;

        }

    }

}
