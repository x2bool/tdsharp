using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatInviteLinkInfo : Structure
    {

        public partial class chatInviteLinkInfo : ChatInviteLinkInfo
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatInviteLinkInfo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long? chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("type")]
                public ChatType type_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo")]
                public ChatPhoto.chatPhoto photo_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_count")]
                public int? member_count_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_user_ids")]
                public int[] member_user_ids_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_public")]
                public bool? is_public_;

        }

    }

}
