using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatReportReason : Structure
    {

        public partial class chatReportReasonSpam : ChatReportReason
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatReportReasonSpam";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
