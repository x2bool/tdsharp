using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatMember : Structure
    {

        public partial class chatMember : ChatMember
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatMember";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("user_id")]
                public int? user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("inviter_user_id")]
                public int? inviter_user_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("joined_chat_date")]
                public int? joined_chat_date_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("status")]
                public ChatMemberStatus status_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("bot_info")]
                public BotInfo.botInfo bot_info_;

        }

    }

}
