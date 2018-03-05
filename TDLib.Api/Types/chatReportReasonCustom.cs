using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatReportReason : Structure
    {

        public partial class chatReportReasonCustom : ChatReportReason
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatReportReasonCustom";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("text")]
                public string text_;

        }

    }

}
