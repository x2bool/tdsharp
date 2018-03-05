using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class CallState : Structure
    {

        public partial class callStatePending : CallState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "callStatePending";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_created")]
                public bool? is_created_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_received")]
                public bool? is_received_;

        }

    }

}
