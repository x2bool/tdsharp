using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class MessageContent : Structure
    {

        public partial class messagePaymentSuccessful : MessageContent
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "messagePaymentSuccessful";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("invoice_message_id")]
                public long? invoice_message_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("currency")]
                public string currency_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("total_amount")]
                public long? total_amount_;

        }

    }

}
