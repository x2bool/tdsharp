using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageSendingState : Structure
    {

        public partial class messageSendingStatePending : MessageSendingState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "messageSendingStatePending";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
