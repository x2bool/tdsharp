using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class CallDiscardReason : Structure
    {

        public partial class callDiscardReasonMissed : CallDiscardReason
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "callDiscardReasonMissed";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
