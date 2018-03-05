using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventLogFilters : Structure
    {

        public partial class chatEventLogFilters : ChatEventLogFilters
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatEventLogFilters";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_edits")]
                public bool? message_edits_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_deletions")]
                public bool? message_deletions_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("message_pins")]
                public bool? message_pins_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_joins")]
                public bool? member_joins_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_leaves")]
                public bool? member_leaves_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_invites")]
                public bool? member_invites_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_promotions")]
                public bool? member_promotions_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("member_restrictions")]
                public bool? member_restrictions_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("info_changes")]
                public bool? info_changes_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("setting_changes")]
                public bool? setting_changes_;

        }

    }

}
