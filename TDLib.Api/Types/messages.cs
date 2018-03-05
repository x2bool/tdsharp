using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Messages : Structure
    {

        public partial class messages : Messages
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "messages";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("total_count")]
                public int? total_count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("messages")]
                public Message.message[] messages_;

        }

    }

}
