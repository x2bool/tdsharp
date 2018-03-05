using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Update : Structure
    {

        public partial class updateChatDraftMessage : Update
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "updateChatDraftMessage";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long? chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("draft_message")]
                public DraftMessage.draftMessage draft_message_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("order")]
                public string order_;

        }

    }

}
